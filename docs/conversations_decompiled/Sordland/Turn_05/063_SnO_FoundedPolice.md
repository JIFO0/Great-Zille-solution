# Sordland/Turn05/SnO_FoundedPolice

- **ID konwersacji:** `63`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/063_SnO_FoundedPolice.md`
- **Liczba węzłów dialogowych:** 398
- **Liczba wyborów gracza:** 90

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[56]** Karl Greiser

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_Default`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Relations_Nia_Opposition`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`
- `BaseGame.Relations_Walter_Promise_TaxFulfilled`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn04_SnO_LE_Interior_Increased`
- `BaseGame.Turn04_SnO_LE_Justice_Increased`
- `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice`
- `BaseGame.Turn05_SnO_LE_Policy_CommunityPolice`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.Turn05_SnO_Investigate_OldGuard`
- `BaseGame.Turn05_SnO_Investigate_Oligarchs`
- `BaseGame.Turn05_SnO_Investigate_Opposition`
- `BaseGameSupport.Journal_Turn05_Investigations_OldGuard`
- `BaseGameSupport.Journal_Turn05_Investigations_Oligarchs`
- `BaseGameSupport.Journal_Turn05_Investigations_Reformists`
- `BaseGameSupport.News_Turn05_HP_ACPFormed`
- `BaseGameSupport.News_Turn05_HP_CPFormed`
- `GameCondition.Turn05_SnO_FoundedPolice`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 10
- **Węzły modyfikujące stan gry:** 13

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[5]` (Nia Morgna): `Variable["GameCondition.Turn05_SnO_FoundedPolice"] = true;`
- Węzeł `[220]` (Nia Morgna): `Variable["BaseGame.Turn05_SnO_Investigate_OldGuard"] = true; Variable["BaseGameSupport.Journal_Tu...`
- Węzeł `[221]` (Nia Morgna): `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] = true; Variable["BaseGameSupport.Journal_T...`
- Węzeł `[222]` (Nia Morgna): `Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] = true; Variable["BaseGameSupport.Journal_...`
- Węzeł `[389]` (Nia Morgna): `Variable["BaseGameSupport.News_Turn05_HP_ACPFormed"] = true;`
- Węzeł `[390]` (Nia Morgna): `Variable["BaseGameSupport.News_Turn05_HP_CPFormed"] = true;`
- Węzeł `[391]` (Nia Morgna): `Variable["BaseGame.Turn05_SnO_Investigate_OldGuard"] = true; Variable["BaseGameSupport.Journal_Tu...`
- Węzeł `[392]` (Nia Morgna): `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] = true; Variable["BaseGameSupport.Journal_T...`
- *...oraz 5 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Nia Morgna)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: "“We need to find out who has ulterior motives and root them out of the administration.”"]** — Mówca: **Player**
> "“We need to find out who has ulterior motives and root them out of the administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Karl Greiser arrived for a meeting to discuss the new police force. After Livia informed us of his arrival, Lucian opened the door and let him in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[5]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: GameCondition.Turn05_SnO_FoundedPolice = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn05_SnO_FoundedPolice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Karl and Lucian left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "“I guess Minister Morgna is on our side on this. She really wants to tackle corruption inside.”"]** — Mówca: **Player**
> "“I guess Minister Morgna is on our side on this. She really wants to tackle corruption inside.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Keep pursuing this Karl. If you encounter any obstacles, my full authority will protect you.”"]** — Mówca: **Player**
> "“Keep pursuing this Karl. If you encounter any obstacles, my full authority will protect you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[9]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[11]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[14]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[15]`
Mówca: **Karl Greiser**
> "“I want to make it absolutely clear. My belief in you as a leader is unquestionable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[16]`
Mówca: **Narrator**
> "Karl sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[17]`
Mówca: **Lucian Galade**
> "“We have been informed of the establishment of the Anti-Corruption Police under the Ministry of Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Focus Anti-Corruption investigations on Hawker and the Old Guard.”"]** — Mówca: **Player**
> "“Focus Anti-Corruption investigations on Hawker and the Old Guard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[19]`
Mówca: **Lucian Galade**
> "“We have been informed of the establishment of the Community Police under the Ministry of Interior.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[20]`
Mówca: **Lucian Galade**
> "“We have been informed of the establishment of the Secret State Police under the Ministry of Interior.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[21]`
Mówca: **Karl Greiser**
> "“Our current efforts have been successful at containing these gangs. This force will ensure the reduction of crime in neighbourhoods.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[22]`
Mówca: **Karl Greiser**
> "“I want to make it absolutely clear. My belief in you as a leader is unquestionable. Consider me as your inside man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[23]`
Mówca: **Karl Greiser**
> "“I have been used to being uncomfortable my whole life. I too came from a poor family, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`
  - -> `[47]`

### Węzeł `[24]`
Mówca: **Narrator**
> "He took a seat and corrected his posture."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "“The economy must be controlled by the state. Lotherberg has too much influence.”"]** — Mówca: **Player**
> "“The economy must be controlled by the state. Lotherberg has too much influence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[26]`
Mówca: **Karl Greiser**
> "“Hello, Mr. President. Mr. Galade. What a sunny day, isn't it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Narrator**
> "The weather outside was beautiful indeed. Clear sky and sunshine made the scenery look lively. I could even hear the sounds of birds chirping from the palace garden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[30]`
  - -> `[29]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "“You are right, I need to go out more often nowadays.”"]** — Mówca: **Player**
> "“You are right, I need to go out more often nowadays.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "“The weather isn't of much concern right now.”"]** — Mówca: **Player**
> "“The weather isn't of much concern right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Good to see you, Karl. How have you been?”"]** — Mówca: **Player**
> "“Good to see you, Karl. How have you been?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[31]`
Mówca: **Karl Greiser**
> "“Good idea. And when you do, the Presidential Guard will be there to protect you, as always.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[32]`
Mówca: **Karl Greiser**
> "“Very good. Thanks to the increased budget at the Interior, we have been combatting a lot of the issues that plagued us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[33]`
Mówca: **Karl Greiser**
> "“Of course, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Lucian Galade**
> "“Please have a seat. We don't want you to feel uncomfortable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[35]`
Mówca: **Karl Greiser**
> "“It's been going okay. We have tackled many security issues but there are still some to go through.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[36]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[38]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Interior_Increased == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[39]`
Mówca: **Karl Greiser**
> "“My position bears more responsibility now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Karl Greiser**
> "“But more importantly, the security situation in the country is much more stable, allowing people to return to a normal life.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[41]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[43]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Deyr_Poor == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Karl Greiser**
> "“I am used to being uncomfortable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“People like us know the additional steps that need to be climbed to get anywhere in life.”"]** — Mówca: **Player**
> "“People like us know the additional steps that need to be climbed to get anywhere in life.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "“We both did well for ourselves, Karl.”"]** — Mówca: **Player**
> "“We both did well for ourselves, Karl.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Italic**
> "I didn't comment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[48]`
Mówca: **Karl Greiser**
> "“I used to work 15 hours a day to bring food back to my sisters. My entire life was been a struggle until I signed up to be a volunteer in the Arvory police force.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Karl Greiser**
> "“Indeed, sir. One way or another we took what we deserved, and life has rewarded us for it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[52]`
  - -> `[58]`

### Węzeł `[50]`
Mówca: **Karl Greiser**
> "“They gave me a scholarship to attend the police academy. An opportunity I wouldn't have been able to have, if I didn't work diligently.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Karl Greiser**
> "“That allowed me to enter the Arvory Police Force as a patrolman and to meet Ms. Graf, who opened several doors that led me to better places.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`
  - -> `[60]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "“You're a good man, Karl. I still owe you for protecting me and my family.”"]** — Mówca: **Player**
> "“You're a good man, Karl. I still owe you for protecting me and my family.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "“Nothing comes free and easy, that's for sure.”"]** — Mówca: **Player**
> "“Nothing comes free and easy, that's for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "“So, are you very close with Mrs. Graf?”"]** — Mówca: **Player**
> "“So, are you very close with Mrs. Graf?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[55]`
**[WYBÓR GRACZA: "“So, she's the one who got you this far, eh?”"]** — Mówca: **Player**
> "“So, she's the one who got you this far, eh?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[56]`
Mówca: **Karl Greiser**
> "“I did my job. But beyond that I would easily risk my life to save the President of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[57]`
Mówca: **Karl Greiser**
> "“We see eye to eye.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "“We can rise even higher if we dare to dream.”"]** — Mówca: **Player**
> "“We can rise even higher if we dare to dream big.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Karl Greiser**
> "“Then we will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Hard-working and loyal people are hard to come by. I need people like you.”"]** — Mówca: **Player**
> "“Hard-working and loyal people are hard to come by. I need people like you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[61]`
Mówca: **Karl Greiser**
> "“She played a major role in my life and she still is my superior. But to be honest, my motivations lie with serving the country. And right now that means serving you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[62]`
Mówca: **Karl Greiser**
> "“I'd like to think that it was my own skills and experience, sir. But of course, I cannot deny that she had a huge impact on my career.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[63]`
Mówca: **Karl Greiser**
> "“My loyalties lie with you, Mr. President. No one else.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[64]`
Mówca: **Narrator**
> "He didn't sit down and walked a few steps towards the wall where President Alphonso's portrait was hanging."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[65]`
Mówca: **Karl Greiser**
> "“Minister Morgna —though not as inspiring as you are— has also shown great capability. The more I work with her, the more I am convinced that she is a very motivated and efficient administrator.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[67]`
  - -> `[68]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“She takes her work personally. Her motivations to fight corruption are real.”"]** — Mówca: **Player**
> "“She takes her work personally. Her motivations to fight corruption are real.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "“So the Anti-Corruption Police is separated from the Interior?”"]** — Mówca: **Player**
> "“So the Anti-Corruption Police is separated from the Interior?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "“You are our best man for the job and I am sure you will excel at it.”"]** — Mówca: **Player**
> "“You are our best man for the job and I am sure you will excel at it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[69]`
Mówca: **Karl Greiser**
> "“Minister Graf —though not as inspiring as you are— has also shown great capability. But the more I work with her, the more I am convinced that she herself might pose a threat to you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[71]`
  - -> `[72]`
  - -> `[199]`

### Węzeł `[70]`
Mówca: **Karl Greiser**
> "“The Nargis, Agnland and Bergia regions are suffering from most of the crime issues. Out of all Estord seems to be the hot spot.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`
  - -> `[76]`
  - -> `[268]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "“Why would she?”"]** — Mówca: **Player**
> "“Why would she?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "“The only thing that matters is that you only take orders from me, and not anyone else.”"]** — Mówca: **Player**
> "“The only thing that matters is that you only take orders from me, and not anyone else.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "“Minister Graf is our close ally in the cabinet. I don't want similar words uttered again.”"]** — Mówca: **Player**
> "“Minister Graf is our close ally in the cabinet. I don't want similar words uttered again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "“The gangs are concentrated in that city aren't they?”"]** — Mówca: **Player**
> "“The gangs are concentrated in that city aren't they?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Lileas Graf has a good security history. You will handle them with her.”"]** — Mówca: **Player**
> "“Lileas Graf has a good security history. You will handle them with her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "“If you are successful, a better future awaits you in the administration.”"]** — Mówca: **Player**
> "“If you are successful, a better future awaits you in the administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[77]`
Mówca: **Karl Greiser**
> "“Her drive certainly is, but there are real obstacles nonetheless. This new force can help in removing those.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[78]`
Mówca: **Karl Greiser**
> "“Therefore, having the new police force separated from the Interior helps its independence and objectivity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[79]`
Mówca: **Karl Greiser**
> "“Yes. It is for a good reason. We have found some irregularities in our police forces. Some of our top officers are involved with corruption.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[80]`
Mówca: **Karl Greiser**
> "“Thanks for the good words. You honor me, but our job is not yet done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[81]`
Mówca: **Lucian Galade**
> "“The Old Guard must have pushed this forward. We shouldn't even consider moving on the reformist leader in our position.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[242]`
  - -> `[243]`
  - -> `[247]`

### Węzeł `[82]`
Mówca: **Lucian Galade**
> "“Hawker, Heron and their cronies in the Supreme Court won't be able to be prosecuted unless the Assembly agrees to in our new constitution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[83]`
Mówca: **Lucian Galade**
> "“The Community Police is driven by local enforcement and will aid us in our internal security efforts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[84]`
Mówca: **Karl Greiser**
> "“There are elements within our state that have ulterior motives.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[85]`
Mówca: **Karl Greiser**
> "“Why would anyone pose a threat? Because of the power they hold, of course. I can easily tell you that she pulls many strings. Ambition is a dangerous thing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[86]`
**[WYBÓR GRACZA: "“What do you mean?”"]** — Mówca: **Player**
> "“What do you mean?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "“Elaborate, please.”"]** — Mówca: **Player**
> "“Elaborate, please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[88]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Justice_Increased == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Justice_Increased == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Justice_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Justice_Increased == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Justice_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[91]`
Mówca: **Karl Greiser**
> "“Thanks to the resource diversion to her ministry, those objectives can now be met. Justice will indeed be served.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[92]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[94]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[95]`
Mówca: **Karl Greiser**
> "“May I speak frankly, sir?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
**[WYBÓR GRACZA: "“Sure. You are among friends.”"]** — Mówca: **Player**
> "“Sure. You are among friends.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[97]`
**[WYBÓR GRACZA: "“Of course.”"]** — Mówca: **Player**
> "“Of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[98]`
Mówca: **Karl Greiser**
> "“There are some very powerful deep state forces inside the administration. Our investigations have just begun, but certain links we have discovered are troubling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[99]`
Mówca: **Karl Greiser**
> "“I am a supporter of the Emergency Act and the expanded powers given to our police to stabilise the country. We have achieved our goals.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[100]`
Mówca: **Lucian Galade**
> "“We always suspected the existence of such a deep state. The real question here is, who in the government and cabinet is on Mr. Hawker's side?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[130]`
  - -> `[3]`
  - -> `[8]`

### Węzeł `[101]`
Mówca: **Karl Greiser**
> "“Mr. Hawker has financial and other ties to certain figures. He is a dangerous man. Currently, we are collecting evidence to find out exactly what his network comprises.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[102]`
Mówca: **Karl Greiser**
> "“Very well, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[103]`
Mówca: **Karl Greiser**
> "“I couldn't agree more. Anyone who corrupts our system and creates a parallel organization is a threat to Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[104]`
Mówca: **Karl Greiser**
> "“Thank you, sir. I will be relentless. The adversaries of this country will be found.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[105]`
Mówca: **Karl Greiser**
> "“Yes, she does, despite constantly encountering resistance in the Ministry and other institutions. Morgna is poking around where she isn't wanted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[106]`
Mówca: **Lucian Galade**
> "“Once enough evidence is gathered, we should be able to begin the corruption trials if we want to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[114]`

### Węzeł `[107]`
Mówca: **Karl Greiser**
> "“Besides them, there are other elements we are aware of. The Oligarchs seem to have some people in the inside as well. We have received some unconfirmed reports about Mr. Tusk having bought people in the administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[108]`
**[WYBÓR GRACZA: "“Bribery should be eradicated from the system.”"]** — Mówca: **Player**
> "“Bribery should be eradicated from the system.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[109]`
**[WYBÓR GRACZA: "“We could look further into Tusk and the Lotherberg group.”"]** — Mówca: **Player**
> "“We could look further into Tusk and the Lotherberg group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[110]`
Mówca: **Karl Greiser**
> "“And they seem to be evading taxes through bribery and exploiting the grey areas in our laws. Our investigators in Estord and Narbel have also found some suspicious financial activity from some of their corporations. If their tax returns were to be made public, it would help us track irregularities in the filings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[109]`
  - -> `[108]`
  - -> `[224]`

### Węzeł `[111]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[113]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[114]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Lucian Galade**
> "“Hawker, Heron and the rest of the Guard in the Supreme Court will be able to be prosecuted with our new constitution. The President will have full authority to do so.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[118]`
Mówca: **Lucian Galade**
> "“Hawker, Heron and the rest of the Guard in the Supreme Court won't be able to be prosecuted at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[119]`
**[WYBÓR GRACZA: "“Don't poke the bear when we are not ready to fight it. Maintain low-key operations.”"]** — Mówca: **Player**
> "“Don't poke the bear when we are not ready to fight it. Maintain low-key operations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Karl Greiser**
> "“Our police is made up of only the most loyal officers, sir. Hundreds of people, hand-picked by Minister Morgna. They have no history with the establishment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Karl Greiser**
> "“Our operations are very hidden at the moment. We are picking off the weaker cogs in the machine that will eventually lead us to the top.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[122]`
Mówca: **Lucian Galade**
> "“It won't be possible to get them if we fail to pass the reforms or we have low political support in the Assembly. But it is too early to tell.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[123]`
Mówca: **Lucian Galade**
> "“This means we can't cut the head off the snake, but we will be able to strangle everyone around them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[124]`
Mówca: **Lucian Galade**
> "“However, it won't be possible to get them if we fail to pass the reforms. It all depends on whether we can gather support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[125]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[128]`
**[WYBÓR GRACZA: "“I don't always see eye to eye with her, but we might be allies on this topic.”"]** — Mówca: **Player**
> "“I don't always see eye to eye with her, but we might be allies on this topic.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Karl Greiser**
> "“I think our enemies are common so why not be friends. The bigger picture is about our country after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[130]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[133]`
**[WYBÓR GRACZA: "“I'm not sure if Morgna can be fully trusted. What if she turns this force against us?”"]** — Mówca: **Player**
> "“I'm not sure if Morgna can be fully trusted. What if she turns this force against us?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Karl Greiser**
> "“That would be unlikely, wouldn't it? You are the person that gave her the cabinet position, allowing her to have the authority to fight the real enemies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Justice_Increased == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Justice_Increased == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Justice_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Justice_Increased == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Justice_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Karl Greiser**
> "“Not only that, you diverted funding to her ministry. You are the only President to have done so in the history of the Republic.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Karl Greiser**
> "“Mr. President, you founded this force to fight corruption. We will only take down those who are truly deserving of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Narrator**
> "Lucian coughed. I saw Karl gaze at him for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[141]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Media_SordlandToday_Bias == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Media_SordlandToday_Bias == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true  or  Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[143]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Media_SordlandToday_Bias == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true  or  Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Narrator**
> "Lucian wrote a couple of notes down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Lucian Galade**
> "“The most important subject here is the Old Guard establishment. They pose a direct threat to us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[146]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[148]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[149]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[152]`
**[WYBÓR GRACZA: "“Tusk is an issue but he shouldn't be our primary target. There are bigger fish to fry.”"]** — Mówca: **Player**
> "“Tusk is an issue but he shouldn't be our primary target. There are bigger fish to fry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[153]`
Mówca: **Karl Greiser**
> "“If that is your desire, we can certainly inquire further about their operations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[154]`
Mówca: **Karl Greiser**
> "“We will do our best, sir. It plagues us from all ends but the Oligarchs seem to have immense influence and money. They keep utilizing it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Karl Greiser**
> "“You are correct, President Rayne. They need to be looked at.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Karl Greiser**
> "“Marcel Koronti and HOS also have a strong presence in the media and many other industries. There are some patterns we observed that are unusual.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[157]`
**[WYBÓR GRACZA: ""Who cares about him, anyway...""]** — Mówca: **Player**
> ""Who cares about him anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[158]`
**[WYBÓR GRACZA: "“Mr. Koronti has been very supportive of my administration. He is a close friend.”"]** — Mówca: **Player**
> "“Mr. Koronti has been very supportive of my administration. He is a close friend.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[159]`
**[WYBÓR GRACZA: "“Marcel offered me a deal before, and needs to be investigated.”"]** — Mówca: **Player**
> "“Marcel offered me a deal before, and needs to be investigated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[160]`
**[WYBÓR GRACZA: "“Focus Anti-Corruption investigations on Tusk and the Oligarchs.”"]** — Mówca: **Player**
> "“Focus Anti-Corruption investigations on Tusk and the Oligarchs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[161]`
Mówca: **Karl Greiser**
> "“Yes. Minister Graf has given me full authority to lead the new force in order to combat organised crime, drug trade and trafficking in our poorer cities and their neighbourhoods. Their role is of a supportive nature.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[162]`
**[WYBÓR GRACZA: "“We need to protect and keep our communities safe. This is another step towards that.”"]** — Mówca: **Player**
> "“We need to protect and keep our communities safe. This is another step towards that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[163]`
**[WYBÓR GRACZA: "“If communities, especially of ethnic descent, gain more responsibility in their own security, it could backfire.”"]** — Mówca: **Player**
> "“If communities, especially of ethnic descent, gain more responsibility in their own security, it could backfire.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[164]`
**[WYBÓR GRACZA: "“How did we ever come to this low point?”"]** — Mówca: **Player**
> "“How did we ever come to this low point?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[165]`
Mówca: **Karl Greiser**
> "“Correct. Minister Graf has given me full authority to lead the new force in order to combat subversives and other threats to the state from the inside. The agents we have recruited are the most loyal and experienced.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`
  - -> `[172]`

### Węzeł `[166]`
Mówca: **Karl Greiser**
> "“Indeed so. Minister Morgna has given me full authority to lead the new force in order to fight corruption from within.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`
  - -> `[169]`

### Węzeł `[167]`
**[WYBÓR GRACZA: "“It's a very powerful force. One that didn't exist in Sordland before.”"]** — Mówca: **Player**
> "“It's a very powerful force. One that didn't exist in Sordland before.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[168]`
**[WYBÓR GRACZA: "“The important question for us is where your loyalties lie.”"]** — Mówca: **Player**
> "“The important question for us is where your loyalties lie.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[169]`
**[WYBÓR GRACZA: "“Congratulations. I hope we'll be close partners in the fight against corruption.”"]** — Mówca: **Player**
> "“Congratulations. I hope we'll be close partners in the fight against corruption.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[170]`
**[WYBÓR GRACZA: "“There are too many enemies inside Sordland. They need to be found and imprisoned.”"]** — Mówca: **Player**
> "“There are too many enemies inside Sordland. They need to be found and imprisoned.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[171]`
**[WYBÓR GRACZA: "“The important question for us is where your loyalties lie.”"]** — Mówca: **Player**
> "“The important question for us is where your loyalties lie.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[172]`
**[WYBÓR GRACZA: "“It's a very powerful force. One that didn't exist in Sordland before.”"]** — Mówca: **Player**
> "“It's a very powerful force. One that didn't exist in Sordland before.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[173]`
Mówca: **Karl Greiser**
> "“Our established forces has begun gathering intelligence on the suspected enemies of the state.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[174]`
Mówca: **Karl Greiser**
> "“I serve my country and its leader President Anton Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[175]`
Mówca: **Karl Greiser**
> "“Yes. We have great powers regarding our operations, thanks to the Security Package and your authority.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[176]`
Mówca: **Karl Greiser**
> "“The enhanced local security and cooperation these new local forces provide will help us improve the dangerous situation in these neighbourhoods.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[177]`
Mówca: **Karl Greiser**
> "“Harsher police action does not necessarily helps us win the battle against organised crime. We need to work with the locals.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[178]`
Mówca: **Karl Greiser**
> "“The recession has allowed these criminal gangs to take control in poverty-stricken areas. Desperate people will do a lot for money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[179]`
Mówca: **Karl Greiser**
> "“The structure being separated from the Interior helps maintain perspective and independence from previous hierarchies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[180]`
Mówca: **Karl Greiser**
> "“I serve my country and its leader President Anton Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[181]`
Mówca: **Karl Greiser**
> "“Sir, we have a tough and long fight ahead of us. It will take years, but we will win. You can believe that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[182]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[185]`
Mówca: **Karl Greiser**
> "“It's fine, sir. The Emergency Act gave us wide-ranging powers and allowed us to crush any illegal activity in the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[186]`
Mówca: **Karl Greiser**
> "“However, I couldn't help but notice that certain high-ranking officers in the Sordish Police Force have been acting autonomously. This is a grave concern for us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Lucian Galade**
> "“The chain of command is jeopardised?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[188]`
**[WYBÓR GRACZA: "“We need to find out about their weaknesses, just in case.”"]** — Mówca: **Player**
> "“We need to find out about their weaknesses, just in case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[189]`
**[WYBÓR GRACZA: "“Don't worry about Hawker. He is aiding our administration.”"]** — Mówca: **Player**
> "“Don't worry about Hawker. He is aiding our administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[190]`
Mówca: **Karl Greiser**
> "“Mr. Hawker has financial and other ties to certain figures in the police and the government. He is a dangerous man. Currently, we are collecting evidence of his middlemen to discover a real link that would lead to further suspects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[191]`
Mówca: **Karl Greiser**
> "“After further research, we found that there are some very powerful deep state forces inside the administration influencing our security. Our investigations have just begun, but certain links we have discovered are troubling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[192]`
Mówca: **Karl Greiser**
> "“Good day, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[193]`
**[WYBÓR GRACZA: "“Good day and good luck, Mr. Greiser.”"]** — Mówca: **Player**
> "“Good day and good luck, Mr. Greiser.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[194]`
**[WYBÓR GRACZA: "“Thank you for your time Karl.”"]** — Mówca: **Player**
> "“Thank you for your time, Karl.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Karl Greiser**
> "“It is a privilege to work with you, President Rayne. Good day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[196]`
Mówca: **Narrator**
> "Lucian glanced at me with his eyebrow raised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[197]`
Mówca: **Karl Greiser**
> "“Very well, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[198]`
Mówca: **Karl Greiser**
> "“In that case, the department will keep an eye on any leads.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[199]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[201]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Interior_Increased == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[202]`
**[WYBÓR GRACZA: "“Me and Lileas see eye to eye on many issues. I wouldn't worry about her.”"]** — Mówca: **Player**
> "“Me and Lileas see eye to eye on many issues. I wouldn't worry about her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[203]`
Mówca: **Karl Greiser**
> "“That won't change sir. I was just trying to give you some inside information from the Interior.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[204]`
Mówca: **Karl Greiser**
> "“Affirmative. Won't happen again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[205]`
Mówca: **Karl Greiser**
> "“She holds immense power in the Interior security apparatus. She also seems to have a powerful base in the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Narrator**
> "Karl leaned closer and lowered his voice ever so slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[207]`
Mówca: **Narrator**
> "Karl leaned closer and lowered his voice ever so slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[208]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[210]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[211]`
Mówca: **Karl Greiser**
> "“There are elements within our state that have ulterior motives.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[215]`

### Węzeł `[212]`
**[WYBÓR GRACZA: "“Yes. You are among confidants.”"]** — Mówca: **Player**
> "“Yes. You are among confidants.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[213]`
Mówca: **Karl Greiser**
> "“May I speak frankly, sir?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[214]`
  - -> `[379]`

### Węzeł `[214]`
**[WYBÓR GRACZA: "“Of course.”"]** — Mówca: **Player**
> "“Of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[215]`
**[WYBÓR GRACZA: "“Elaborate please.”"]** — Mówca: **Player**
> "“Elaborate please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[216]`
**[WYBÓR GRACZA: "“What do you mean?”"]** — Mówca: **Player**
> "“What do you mean?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[217]`
Mówca: **Karl Greiser**
> "“The initial analysis by our agents has uncovered some troubling facts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[218]`
Mówca: **Lucian Galade**
> "“Let's discuss this further later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[219]`
Mówca: **Lucian Galade**
> "“We surely can to be on the safe side, even though we are working with them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[220]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_OldGuard = true; BaseGameSupport.Journal_Turn05_Investigations_OldGuard = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn05_SnO_Investigate_OldGuard"] = true;
Variable["BaseGameSupport.Journal_Turn05_Investigations_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[221]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Oligarchs = true; BaseGameSupport.Journal_Turn05_Investigations_Oligarchs = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] = true;
Variable["BaseGameSupport.Journal_Turn05_Investigations_Oligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[222]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Opposition = true; BaseGameSupport.Journal_Turn05_Investigations_Reformists = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] = true;
Variable["BaseGameSupport.Journal_Turn05_Investigations_Reformists"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[223]`
Mówca: **Karl Greiser**
> "“Minister Morgna is very concerned about the Supreme Court and Old Guards. She sees them as the primary threat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[188]`

### Węzeł `[224]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[226]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[227]`
Mówca: **Karl Greiser**
> "“I've had many of my trusted officers scout hundreds of loyal community volunteers and train them in the police academies around the country. The Koranelli and Skinner gangs have a presence in many of their districts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`
  - -> `[229]`
  - -> `[164]`

### Węzeł `[228]`
Mówca: **Karl Greiser**
> "“We are fighting them already, and the community police force will cut their connections further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[229]`
**[WYBÓR GRACZA: "“The crime families need to be taken down. We can't let them do what they want with impunity.”"]** — Mówca: **Player**
> "“The crime families need to be taken down. We can't let them do what they want with impunity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[230]`
Mówca: **Karl Greiser**
> "“Of course, sir. We are working in close collaboration with Mrs. Graf. Things are much better already.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[231]`
Mówca: **Karl Greiser**
> "“Yes, they have a lot of presence there. Our efforts are increasingly pushing them to act in the shadows.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[232]`
Mówca: **Karl Greiser**
> "“I won't disappoint you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[233]`
Mówca: **Karl Greiser**
> "“He might not be innocent, but if you think he isn't an issue then we can move on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[234]`
Mówca: **Karl Greiser**
> "“They do have reach, but the President has much more influence and authority.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[235]`
Mówca: **Karl Greiser**
> "“We certainly can. I wish we had proof of the incident. It would help in a case against him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[236]`
Mówca: **Karl Greiser**
> "“Last but not least is the opposition leader Frens Ricter. We have received intelligence that he has connections to Arcasia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[237]`
**[WYBÓR GRACZA: "“Focus Anti-Corruption investigations on the opposition.""]** — Mówca: **Player**
> "“Focus Anti-Corruption investigations on the opposition parties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[238]`
Mówca: **Karl Greiser**
> "“It really seems like they have a powerful influence in the majority of the so-called independent news organisations. They might not be so independent after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[157]`
  - -> `[159]`

### Węzeł `[239]`
Mówca: **Lucian Galade**
> "“It's not good to underestimate such critical public opinion tools.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[240]`
Mówca: **Karl Greiser**
> "“Upon further inquiries, we can't see anything illegal here besides a mismatch of information.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[241]`
**[WYBÓR GRACZA: "“Frens Ricter is our ally and we shouldn't move against him.”"]** — Mówca: **Player**
> "“Frens Ricter is our ally and we shouldn't move against him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[242]`
**[WYBÓR GRACZA: "“There is nothing illegal, so why even talk about this?”"]** — Mówca: **Player**
> "“There is nothing illegal, so why even talk about this?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[243]`
**[WYBÓR GRACZA: "“Ricter is a loyal servant of Sordland. The Old Guard is trying to pressure him.”"]** — Mówca: **Player**
> "“Ricter is a loyal servant of Sordland. The Old Guard is trying to pressure him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[244]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[246]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[247]`
**[WYBÓR GRACZA: "“He must have some dirt on him. We should look deeper.”"]** — Mówca: **Player**
> "“He must have some dirt on him. We should look deeper.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[248]`
Mówca: **Karl Greiser**
> "“Very well, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[249]`
Mówca: **Karl Greiser**
> "“The way we received this intelligence was unusual, to say the least. It totally came through the back channels.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[250]`
Mówca: **Karl Greiser**
> "“I wanted to disclose all of the information that the ACP has.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[251]`
Mówca: **Karl Greiser**
> "“Everyone has something, usually. The PFJP and the other opposition members can't be fully clean.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Karl Greiser**
> "“Therefore, we need to pick a faction to focus on. We can't investigate everyone within the remainder of this term and come up with a thorough and compelling case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
  - -> `[261]`

### Węzeł `[253]`
Mówca: **Lucian Galade**
> "“There are so many potential corruption cases here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[254]`
Mówca: **Karl Greiser**
> "“Where should we concentrate our anti-corruption efforts?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[160]`
  - -> `[237]`

### Węzeł `[255]`
Mówca: **Karl Greiser**
> "“Yes, sir. We will focus our research and investigation on the Old Guard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[256]`
Mówca: **Karl Greiser**
> "“Yes, sir. We will focus our research and investigation on the Oligarchs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[257]`
Mówca: **Karl Greiser**
> "“Yes, sir. We will focus our research and investigation on the PFJP as well as the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[258]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[260]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Path == true || BaseGame.Reform_Dictator_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true  or  Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[261]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[263]`

### Węzeł `[262]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true && BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[264]`
Mówca: **Lucian Galade**
> "“The Old Guard has us exactly where they want us. If we unleash the ACP on them, we might have a backup in case things don't go well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[265]`
Mówca: **Lucian Galade**
> "“The most logical step would be to use the ACP to pressure either the Oligarchs or the Old Guard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[266]`
Mówca: **Lucian Galade**
> "“Well, it has been decided. That should conclude the meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[193]`

### Węzeł `[267]`
Mówca: **Karl Greiser**
> "“I am very glad you have taken such a step, Mr. President. Well... I will continue my work if there is nothing else.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[193]`

### Węzeł `[268]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Interior_Increased == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[271]`
**[WYBÓR GRACZA: "“The increased Interior budget should allow us to diminish them.”"]** — Mówca: **Player**
> "“The increased Interior budget should allow us to diminish them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Karl Greiser**
> "“It already has. We are receiving reports of several early successes. Once the Community Police operations kick in with full force, we will end those gangs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[273]`
Mówca: **Karl Greiser**
> "“You should receive further reports on our progress and actions in the upcoming months, President Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[274]`
**[WYBÓR GRACZA: "“Make sure the force represents the diverse makeup of the neighborhoods in which it is active.”"]** — Mówca: **Player**
> "“Make sure the force represents the diverse makeup of the neighborhoods in which it is active.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[275]`
**[WYBÓR GRACZA: "“Make sure to pick the right people for the job and have solid background checks.”"]** — Mówca: **Player**
> "“Make sure to pick the right people for the job and have solid background checks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[276]`
**[WYBÓR GRACZA: "“Don't arm the Community Police. We shouldn't trust them yet.”"]** — Mówca: **Player**
> "“Don't arm the Community Police. We shouldn't trust them yet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[277]`
Mówca: **Karl Greiser**
> "“I also wanted to point out that hundreds of Agno-Sordish, Bludish and Sordish volunteers are now entering training. Soon they will assist our forces.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Karl Greiser**
> "“Very well, sir. We will ensure diversity in the new force.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[279]`
Mówca: **Karl Greiser**
> "“We are ensuring that people take charge of their own districts. By giving them responsibility and oversight, we will have them as our allies on the ground.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`
  - -> `[276]`

### Węzeł `[280]`
Mówca: **Karl Greiser**
> "“I have personally picked the initial recruits. My officers are evaluating all of them with thorough checks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[281]`
Mówca: **Karl Greiser**
> "“I understand your perspective. I will remove the right to carry a weapon for the CP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[282]`
Mówca: **Karl Greiser**
> "“Yes sir. If you think he is an enemy, we will look deeper.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[283]`
**[WYBÓR GRACZA: "“He must have some dirt on him. We might need to look deeper.”"]** — Mówca: **Player**
> "“He must have some dirt on him. We might need to look deeper.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[284]`
Mówca: **Lucian Galade**
> "“The Old Guard must have pushed this forward. We should consider investigating Mr. Ricter further. The PFJP poses a threat for the next election. It's better to know more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`
  - -> `[289]`
  - -> `[283]`

### Węzeł `[285]`
Mówca: **Karl Greiser**
> "“Upon further inquiries, we see a mismatch of information between the border guard and the intelligence units.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[286]`
Mówca: **Karl Greiser**
> "“The way we received this intelligence was unusual to say the least. It totally went through the back-channels.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[287]`
**[WYBÓR GRACZA: "“Frens Ricter should be investigated in full.”"]** — Mówca: **Player**
> "“Frens Ricter should be investigated in full.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[288]`
**[WYBÓR GRACZA: "“There is nothing illegal, so why even talk about this?”"]** — Mówca: **Player**
> "“There is nothing illegal, so why even talk about this?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[289]`
**[WYBÓR GRACZA: "“Ricter is a loyal servant of Sordland. Old Guards are trying to pressure him.”"]** — Mówca: **Player**
> "“Ricter is a loyal servant of Sordland. Old Guards are trying to pressure him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[290]`
Mówca: **Karl Greiser**
> "“Let's start with the primary person, the opposition leader Frens Ricter. We have received credible intelligence that he has connections to Arcasia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[291]`
Mówca: **Karl Greiser**
> "“Everyone has something, usually. The PFJP and the other opposition members can't be fully clean.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[292]`
Mówca: **Lucian Galade**
> "“There are so many potential corruption cases here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[293]`
Mówca: **Karl Greiser**
> "“I wanted to fully disclose all information available to the SSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[294]`
Mówca: **Narrator**
> "Lucian looked deep in thoughts. He sighed before he continued. I saw Karl gaze at him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[295]`
Mówca: **Karl Greiser**
> "“Not only that you also diverted the funding to her ministry. You are the only President to have done so in the history of the Republic.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Karl Greiser**
> "“Mr. President you founded this force to fight corruption and it won't be able take those down who are clear of evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[297]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Nia_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[299]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Nia_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Nia_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[300]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Media_SordlandToday_Bias == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Media_SordlandToday_Bias == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true  or  Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[302]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Media_SordlandToday_Bias == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true  or  Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Karl Greiser**
> "“Mr. Hawker has financial and other ties to certain figures. He is a dangerous man. Currently we are collecting evidence of his middlemen to discover a real link that would lead to further suspects.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[304]`
Mówca: **Narrator**
> "Lucian wrote a couple of notes down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[305]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[307]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Interior_Increased == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[308]`
Mówca: **Lucian Galade**
> "“Hawker, Heron and the rest of the Guard in the Supreme Court will be able to be prosecuted with our new constitution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[309]`
Mówca: **Lucian Galade**
> "“We always suspected that they were dangerously close but the real question here is who in the government and cabinet is on their side?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[312]`
  - -> `[320]`
  - -> `[321]`

### Węzeł `[310]`
**[WYBÓR GRACZA: "“I guess Minister Morgna is on our side on this. She really wants to tackle corruption inside.”"]** — Mówca: **Player**
> "“I guess Minister Morgna is on our side on this. She really wants to tackle corruption inside.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Karl Greiser**
> "“Yes. And she is constantly encountering resistance in the Ministry and other institutions. Mrs. Morgna is poking into places they don't want her to.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[312]`
**[WYBÓR GRACZA: "“Don't poke the bear when we are not ready to fight it. Maintain low-key operations.”"]** — Mówca: **Player**
> "“Don't poke the bear when we are not ready to fight it. Maintain low-key operations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[313]`
Mówca: **Karl Greiser**
> "“Our agency is made up of the most loyal, sir. Hundreds of people were hand-picked by Minister Graf, personally. They have no history with the establishment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[314]`
Mówca: **Karl Greiser**
> "“Our operations are very hidden at the moment. We are picking off the weaker cogs in the machine that will eventually lead us to the top."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[315]`
**[WYBÓR GRACZA: "“Not sure if Graf can be fully trusted. What if she turns this force against us?”"]** — Mówca: **Player**
> "“Not sure if Graf can be fully trusted. What if she turns this force against us?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Karl Greiser**
> "“That would be unlikely wouldn't it, sir? You are the person that gave her the cabinet position; allowing her to have the authority to fight the real enemies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[317]`
Mówca: **Karl Greiser**
> "“There are some very powerful deep state forces inside the administration. Our investigations have just begun but certain links we have discovered are troubling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[318]`
Mówca: **Karl Greiser**
> "“Thank you sir, I will be relentless; the adversaries of this country will be found.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[319]`
Mówca: **Karl Greiser**
> "“I couldn't agree more. Anyone who attacks the state and creates a parallel organisation is a threat to Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[320]`
**[WYBÓR GRACZA: "“We need to find out who has ulterior motives and root them out of the administration.”"]** — Mówca: **Player**
> "“We need to find out who has ulterior motives and root them out of the administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[321]`
**[WYBÓR GRACZA: "“Keep pursuing this Karl. If you encounter any obstacles, my full authority will protect you.”"]** — Mówca: **Player**
> "“Keep pursuing this Karl. If you encounter any obstacles, my full authority will protect you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[322]`
Mówca: **Lucian Galade**
> "“The most important subject here is the Old Guard establishment. They pose a direct threat to us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Lucian Galade**
> "“Once enough intelligence is gathered, we may be able to arrest them extrajudicially.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[324]`
**[WYBÓR GRACZA: "“Focus Secret State Police investigations on Hawker and the Old Guard.”"]** — Mówca: **Player**
> "“Focus Secret State Police investigations on Hawker and the Old Guard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[325]`
**[WYBÓR GRACZA: "“Focus Secret State Police investigations on Tusk and the Oligarchs.”"]** — Mówca: **Player**
> "“Focus Secret State Police investigations on Tusk and the Oligarchs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[326]`
**[WYBÓR GRACZA: "“Focus Secret State Police investigations on the opposition parties.”"]** — Mówca: **Player**
> "“Focus Secret State Police investigations on the opposition parties.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[327]`
Mówca: **Karl Greiser**
> "“Yes, sir. We will focus our research and investigation on the Oligarchs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[328]`
Mówca: **Karl Greiser**
> "“Yes, sir. We will focus our research and investigation on the PFJP and the NFP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[329]`
Mówca: **Karl Greiser**
> "“Yes, sir. We will focus our research and investigation on the Old Guard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[330]`
Mówca: **Karl Greiser**
> "“He might not be innocent, sir. But if you think he isn't an issue, then we can move on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[331]`
Mówca: **Karl Greiser**
> "“Very well, sir. If he isn't a big concern for you, we can talk about other figures.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[332]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`
  - -> `[334]`

### Węzeł `[333]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[334]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[335]`
Mówca: **Karl Greiser**
> "“If that is your desire, we can certainly inquire further about their operations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Karl Greiser**
> "“We will do our best, sir. It plagues us from all ends, but the Oligarchs seem to have immense influence and money. They keep utilizing it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Karl Greiser**
> "“Marcel Koronti and HOS also have a strong presence in the media and many other industries. There are some patterns we observed that are unusual.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[338]`
Mówca: **Karl Greiser**
> "“We certainly can do so. I wish we had proof of the incident... It would help in a case against him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[339]`
Mówca: **Karl Greiser**
> "“And it is suspected that they are evading taxes through bribery and exploiting grey areas in our laws. Our investigators in Estord and Narbel have also found some suspicious financial activity from some of their corporations. If tax returns were to be made public, it would help us track irregularities in the filings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`
  - -> `[351]`
  - -> `[353]`
  - -> `[340]`

### Węzeł `[340]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[342]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[343]`
Mówca: **Karl Greiser**
> "“Besides them, there are other elements we are aware of. The Oligarchs seem to have some people in the inside as well. We have received some unconfirmed reports about Mr. Tusk having made deals with the enemies of the state.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[344]`
**[WYBÓR GRACZA: "“Who cares about him, anyway...”"]** — Mówca: **Player**
> "“Who cares about him, anyway...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[345]`
**[WYBÓR GRACZA: "“Mr. Koronti has been very supportive of my administration. He is a close friend.”"]** — Mówca: **Player**
> "“Mr. Koronti has been very supportive of my administration. He is a close friend.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[346]`
**[WYBÓR GRACZA: "“Marcel offered me a deal before. He needs to be investigated in full.”"]** — Mówca: **Player**
> "“Marcel offered me a deal before. He needs to be investigated in full.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[347]`
Mówca: **Karl Greiser**
> "“You are correct, President Rayne. They need to be looked at.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[348]`
Mówca: **Karl Greiser**
> "“They do have reach, but the President has much more influence and authority.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[349]`
**[WYBÓR GRACZA: "“Tusk is an issue, but he shouldn't be our primary target. There are bigger fish to fry.”"]** — Mówca: **Player**
> "“Tusk is an issue, but he shouldn't be our primary target. There are bigger fish to fry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[350]`
Mówca: **Karl Greiser**
> "“It really seems like they have a powerful influence in the majority of the so-called independent news organisations. They might not be so independent after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[344]`
  - -> `[346]`

### Węzeł `[351]`
**[WYBÓR GRACZA: "“The Oligarchs pose a larger threat to our administration. We need to curb them immediately.”"]** — Mówca: **Player**
> "“The Oligarchs pose a larger threat to our administration. We need to curb them immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[352]`
**[WYBÓR GRACZA: "“The economy must be controlled by the state. Lotherberg has too much influence.”"]** — Mówca: **Player**
> "“The economy must be controlled by the state. Lotherberg has too much influence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[353]`
**[WYBÓR GRACZA: "“Bribery should be eradicated from the system.”"]** — Mówca: **Player**
> "“Bribery should be eradicated from the system.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[354]`
Mówca: **Lucian Galade**
> "“It's not good to underestimate such critical public opinion tools.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[355]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[357]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[358]`
Mówca: **Lucian Galade**
> "“Let's discuss this further later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[359]`
**[WYBÓR GRACZA: "“We need to find out about their weaknesses, just in case.”"]** — Mówca: **Player**
> "“We need to find out about their weaknesses, just in case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[360]`
**[WYBÓR GRACZA: "“Don't worry about Hawker. He is aiding our administration.”"]** — Mówca: **Player**
> "“Don't worry about Hawker. He is aiding our administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[361]`
Mówca: **Karl Greiser**
> "“Very well, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[362]`
Mówca: **Karl Greiser**
> "“In that case, the department will keep an eye on any leads.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Karl Greiser**
> "“Mr. Hawker has financial and other ties to certain figures in the police and the government. He is a dangerous man. Currently, we are collecting evidence in order to discover exactly what his network comprises.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[364]`
Mówca: **Lucian Galade**
> "“We surely can do that to be on the safe side, even though we are working with them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[365]`
Mówca: **Karl Greiser**
> "“Minister Morgna is very concerned about the Supreme Court and Old Guard. She sees them as the primary threat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`
  - -> `[359]`

### Węzeł `[366]`
Mówca: **Narrator**
> "Lucian glanced at me with his eyebrow raised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[367]`
Mówca: **Karl Greiser**
> "“I am a supporter of the Emergency Act and the expanded powers given to our police to stabilise the country. We have achieved our goals.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[368]`
Mówca: **Karl Greiser**
> "“After further research, we found that there are some very powerful deep state forces inside the administration influencing our security. Our investigations have just begun, but certain links we have discovered are troubling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[369]`
Mówca: **Lucian Galade**
> "“The chain of command is jeopardized?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[370]`
Mówca: **Karl Greiser**
> "“However, I couldn't help but notice that certain high-ranking officers in the Sordish Police Force have been acting autonomously. This is a grave concern for us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[371]`
Mówca: **Karl Greiser**
> "“Therefore we need to pick a faction to focus on. We can't investigate everyone within the remainder of the term and come up with a thorough and compelling case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Karl Greiser**
> "“Where should we concentrate our efforts?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[325]`
  - -> `[326]`

### Węzeł `[373]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true && BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true && BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[376]`
Mówca: **Lucian Galade**
> "“The Old Guard have us exactly where they want us. If we unleash the SSP on them we might have something as a backup, in case things don't go well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[377]`
Mówca: **Lucian Galade**
> "“The most logical step would be to use the SSP to pressure either the Oligarchs or the Old Guard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[378]`
Mówca: **Karl Greiser**
> "“The Reformists are a threat to the next election, sir. The people could rally behind them and endanger your administration. With the SSP, we can resort to harsh but necessary actions to remove these threats.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[379]`
**[WYBÓR GRACZA: "“That's exactly what I want you to do.”"]** — Mówca: **Player**
> "“That's exactly what I want you to do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[380]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[382]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[383]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[385]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[386]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_CommunityPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[388]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_CommunityPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[389]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_HP_ACPFormed = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_ACPFormed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[390]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_HP_CPFormed = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_CPFormed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[391]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_OldGuard = true; BaseGameSupport.Journal_Turn05_Investigations_OldGuard = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn05_SnO_Investigate_OldGuard"] = true;
Variable["BaseGameSupport.Journal_Turn05_Investigations_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[392]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Oligarchs = true; BaseGameSupport.Journal_Turn05_Investigations_Oligarchs = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] = true;
Variable["BaseGameSupport.Journal_Turn05_Investigations_Oligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[393]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Opposition = true; BaseGameSupport.Journal_Turn05_Investigations_Reformists = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] = true;
Variable["BaseGameSupport.Journal_Turn05_Investigations_Reformists"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[394]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Faction_OldGuard_Content"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[395]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Faction_Oligarchs_Content"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[396]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: BaseGame.Faction_OldGuard_Content = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Faction_OldGuard_Content"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[397]`
Mówca: **Nia Morgna**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
