# Sordland/Turn08/A_InvestigationResults

- **ID konwersacji:** `178`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/178_A_InvestigationResults.md`
- **Liczba węzłów dialogowych:** 477
- **Liczba wyborów gracza:** 135

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[41]** Livia Suno
- **[56]** Karl Greiser

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Accepted_MediaDeal`
- `BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum`
- `BaseGame.Policy_Order_SecretStatePolice`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Relations_Marcel_Enemy`
- `BaseGame.Relations_Walter_Promise_BailBusiness`
- `BaseGame.Relations_Walter_Promise_Company`
- `BaseGame.SecretState_LucianKnowsSSPKills`
- `BaseGame.Turn07_A_Marcel_Threatened`
- `BaseGame.Turn07_Detained_MarcelKoronti`
- `BaseGame.Turn07_SecretState_Kill_FrensRicter`
- `BaseGame.Turn07_SecretState_Kill_KesaroKibener`
- `BaseGame.Turn07_SecretState_Kill_OrsoHawker`
- `BaseGame.Turn08_SecondScandal_BlamePetrForLeak`
- `BaseGame.Turn08_SecondScandal_Detained_Livia`
- `BaseGame.Turn08_SecondScandal_Detained_Petr`
- `BaseGame.Turn08_SecondScandal_LiviaFired`
- `BaseGame.Turn08_SecondScandal_LiviaInvestigated`
- `BaseGame.Turn08_SecondScandal_LiviaStays`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr`
- `BaseGame.Turn08_SecondScandal_ShareBlame`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Enable_LiviaPetrGone`
- `BaseGame.Enable_PressRelease`
- `BaseGame.Enable_VPSelection`
- `BaseGame.Petr_Dead`
- `BaseGame.Petr_isVP`
- `BaseGame.Relations_Lucian_Opinion`
- `BaseGame.Situation_Order_InfiltratedIntelligence`
- `BaseGame.Turn08_PressConference_PetrKnowsResigning`
- `BaseGame.Turn08_SecondScandal_BlamePetrForLeak`
- `BaseGame.Turn08_SecondScandal_DenyEverything`
- `BaseGame.Turn08_SecondScandal_Detained_Livia`
- `BaseGame.Turn08_SecondScandal_Detained_Petr`
- `BaseGame.Turn08_SecondScandal_LiviaFired`
- `BaseGame.Turn08_SecondScandal_LiviaStays`
- `BaseGame.Turn08_SecondScandal_LiviaTrialled`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr`
- `BaseGame.Turn08_SecondScandal_ShareBlame`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing`
- `BaseGameSupport.Journal_Turn08_SecondScandal_BlamePetrForLeak`
- `BaseGameSupport.Journal_Turn08_SecondScandal_DenyEverything`
- `BaseGameSupport.Journal_Turn08_SecondScandal_LiviaAndPetrDetained`
- `BaseGameSupport.Journal_Turn08_SecondScandal_LiviaDetained`
- `BaseGameSupport.Journal_Turn08_SecondScandal_LiviaFired`
- `BaseGameSupport.Journal_Turn08_SecondScandal_LiviaSpy`
- `BaseGameSupport.Journal_Turn08_SecondScandal_LiviaStays`
- `BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_ArrestLivia`
- `BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_ArrestLiviaAndPetr`
- `BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_KillLivia`
- `BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_KillLiviaAndPetr`
- `BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_LiviaTrialled`
- `BaseGameSupport.Journal_Turn08_SecondScandal_ShareBlame`
- `BaseGameSupport.News_Turn08_HP_LiviaSpyReveal`
- `BaseGameSupport.News_Turn08_R_LiviaSpyReveal`
- `BaseGameSupport.News_Turn08_ST_LiviaSpyReveal`
- `GameCondition.Turn08_A_InvestigationResults`
- `GameCondition.Turn08_A_PressReleases`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 49

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Lucian_Opinion`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[42]` (Lucian Galade): `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 2;`
- Węzeł `[55]` (Lucian Galade): `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 2;`
- Węzeł `[67]` (Lucian Galade): `Variable["BaseGame.Turn08_SecondScandal_LiviaFired"] = true;`
- Węzeł `[97]` (Lucian Galade): `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] + 1;`
- Węzeł `[120]` (Lucian Galade): `Variable["GameCondition.Turn08_A_InvestigationResults"] = true;`
- Węzeł `[191]` (Lucian Galade): `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- Węzeł `[221]` (Lucian Galade): `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] = true;`
- Węzeł `[222]` (Lucian Galade): `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] = true;`
- *...oraz 41 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaInvestigated == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaInvestigated == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_LiviaInvestigated == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Several days had passed since I ordered the investigation into my secretary, Livia Suno."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[7]`
Mówca: **Narrator**
> "Several days had passed since the confrontation with Petr, Livia and Lucian in my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Lucian was still acting frosty towards me for rejecting his advice. On the other hand, both Petr and Livia were unnaturally nice to me, though they avoided speaking to each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Both Petr and Livia had been acting unnaturally nice to me, believing I'd let them off the hook for their affair. They seemed to be avoiding each other in the hallways, though."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Narrator**
> "I was just settling in behind my desk when Lucian knocked on my door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""Sir, a moment of your time?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`
  - -> `[14]`

### Węzeł `[12]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "Motion for him to come in."]** — Mówca: **Player_Italic**
> "I motioned for him to come in. He sat and closed the door behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Not now.""]** — Mówca: **Player**
> ""Not now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Lucian Galade**
> ""I'm afraid it's urgent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Narrator**
> "He entered my office and closed the door behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Narrator**
> "Lucian entered my office and closed the door behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaInvestigated == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaInvestigated == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[20]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_LiviaInvestigated == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[21]`
Mówca: **Lucian Galade**
> ""I still believe you were wrong not to pursue an investigation into Miss Suno. However, I acknowledge my lack of concrete evidence and unorthodox information gathering method may have given you pause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[23]`
  - -> `[22]`

### Węzeł `[22]`
**[WYBÓR GRACZA: ""Unorthodox? You surveilled Petr behind my back!""]** — Mówca: **Player**
> ""Unorthodox? You surveilled Petr behind my back!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[23]`
**[WYBÓR GRACZA: ""You're not going to change my mind about this.""]** — Mówca: **Player**
> ""You're not going to change my mind about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""I could have been less rude to you about it, though.""]** — Mówca: **Player**
> ""I could have been less rude to you about it, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Lucian Galade**
> ""Perhaps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[26]`
Mówca: **Lucian Galade**
> ""I feel I would be failing in my duties as a chief strategist not to give you one last piece of advice on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[27]`
Mówca: **Lucian Galade**
> ""That isn't my goal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Lucian Galade**
> ""I have already apologized to Mr. Vectern for the intrusion. It won't happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Narrator**
> "Lucian looked me in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[30]`
Mówca: **Lucian Galade**
> ""Please, consider dismissing Miss Suno from her position at the palace. Just in case I am right after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[32]`
  - -> `[31]`

### Węzeł `[31]`
**[WYBÓR GRACZA: ""Are you crazy? She'll go public about the affair.""]** — Mówca: **Player**
> ""Are you crazy? She'll go public about the affair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[32]`
**[WYBÓR GRACZA: ""I can't. She's so good at her job!""]** — Mówca: **Player**
> ""I can't. She's so good at her job!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[33]`
**[WYBÓR GRACZA: ""Well, she has been a distraction to Petr...""]** — Mówca: **Player**
> ""Well, she has been a distraction to Petr...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[34]`
**[WYBÓR GRACZA: ""How do I justify that to her?""]** — Mówca: **Player**
> ""How do I justify that to her?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Lucian Galade**
> ""She slept with the vice president. Extremely unprofessional behavior.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[36]`
Mówca: **Lucian Galade**
> ""Her looks may be unmatched, but her skills most certainly are not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[37]`
Mówca: **Lucian Galade**
> ""That might make a headline or two, but it won't sink your administration. Unlike a potential uncontrolled intelligence leak to Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""All right. If it'll get you off my case, I'll fire her.""]** — Mówca: **Player**
> ""All right. If it'll get you off my case, I'll fire her right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""No. I won't continue to indulge your paranoid fantasies. Livia stays.""]** — Mówca: **Player**
> ""No. I won't continue to indulge your paranoid fantasies. Livia stays.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[40]`
Mówca: **Lucian Galade**
> ""Keeping Mr. Vectern around may be another mistake. But that's a conversation for another time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[41]`
Mówca: **Lucian Galade**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[42]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Narrator**
> "Lucian looked as if he was about to object one last time, but then smiled thinly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Lucian Galade**
> ""As you wish. I won't bring this up any further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Narrator**
> "He walked out and closed the door behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[46]`
Mówca: **Narrator**
> "I called Livia into my office. She tentatively stepped in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Livia Suno**
> ""What is it, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[48]`
Mówca: **Narrator**
> "I thought about how useful she'd been to me as a secretary -- and how much she knew about what I'd done."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[49]`

### Węzeł `[49]`
**[WYBÓR GRACZA: ""Nothing. Go back to work.""]** — Mówca: **Player**
> ""Nothing. Go back to work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[50]`
**[WYBÓR GRACZA: ""You're fired, Livia.""]** — Mówca: **Player**
> ""You're fired, Livia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Livia Suno**
> ""W-what? I thought we'd been over all this...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[59]`
  - -> `[58]`
  - -> `[57]`

### Węzeł `[52]`
Mówca: **Livia Suno**
> ""Um... okay. Just let me know if you need anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
**[WYBÓR GRACZA: ""You're making Petr too distracted to work.""]** — Mówca: **Player**
> ""You're making Petr too distracted to work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[54]`
Mówca: **Narrator**
> "Livia walked back out. Lucian looked at me in disbelief for a moment, then smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Lucian Galade**
> ""You've made your point, Mr. President. I won't trouble you with this any further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[57]`
**[WYBÓR GRACZA: ""You're too ambitious for this job. Go get a proper university education.""]** — Mówca: **Player**
> ""You're too ambitious for this job. Go get a proper university education.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[58]`
**[WYBÓR GRACZA: ""I don't share Lucian's suspicions that you're a spy, but I can't take the risk that he's right.""]** — Mówca: **Player**
> ""I don't share Lucian's suspicions that you're a spy, but I can't take the risk that he's right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[59]`
**[WYBÓR GRACZA: ""Your performance has been abysmal lately.""]** — Mówca: **Player**
> ""Your performance has been abysmal lately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Livia Suno**
> ""I know that's not true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Narrator**
> "She glared at Lucian, then at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[62]`
Mówca: **Livia Suno**
> ""Then perhaps you should fire him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[63]`
Mówca: **Livia Suno**
> ""How prudent of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[64]`
Mówca: **Livia Suno**
> ""That's the best you could come up with?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[65]`
Mówca: **Livia Suno**
> ""I hope you're both happy. You've ruined a woman's career simply because she acted too much like a man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Narrator**
> "She stormed out, slamming the door behind her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaFired = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaFired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[68]`
Mówca: **Lucian Galade**
> ""Trust me, Mr. President, your decision was the correct one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[70]`
  - -> `[69]`

### Węzeł `[69]`
**[WYBÓR GRACZA: ""I hope so.""]** — Mówca: **Player**
> ""I hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[70]`
**[WYBÓR GRACZA: ""Stop talking. Don't make this worse than it is.""]** — Mówca: **Player**
> ""Stop talking. Don't make this worse than it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
**[WYBÓR GRACZA: ""Yes, I know.""]** — Mówca: **Player**
> ""Yes, I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Narrator**
> "I showed him out and went to brew myself a pot of coffee."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[73]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Livia Firing Decision)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[74]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Livia Firing Decision])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[75]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Investigation Results Discussion)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[76]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Investigation Results Discussion])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[77]`
Mówca: **Lucian Galade**
> ""Our security team travelled to Lachaven to speak to the owners of the pub Miss Suno named. They confirmed that one Livia Suno had worked there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Lucian Galade**
> ""Their description of her did not match that of your secretary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Lucian Galade**
> ""However, it did match that of an unidentified corpse that washed up in Lenkurg Bay two months before your inauguration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[81]`
  - -> `[80]`
  - -> `[377]`

### Węzeł `[80]`
**[WYBÓR GRACZA: ""Oh, shit.""]** — Mówca: **Player**
> ""Oh, shit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""If that was Livia Suno... who's the woman working for me?""]** — Mówca: **Player**
> ""If that was Livia Suno... who's the woman working for me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
**[WYBÓR GRACZA: ""You mean...""]** — Mówca: **Player**
> ""You mean...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Lucian Galade**
> ""Further investigation by our operatives in Rumburg matched Miss Suno's description to a woman named Ilana Vance, last seen graduating from Crimsrad Political Sciences Institute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Lucian Galade**
> ""Our whistleblower from Rumburg recognized the name Vance as belonging to a deeply embedded covert agent, although he had previously assumed it was a man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[91]`
  - -> `[96]`
  - -> `[90]`

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""Recent coded transmissions from Rumburg have mentioned a deeply embedded covert agent named Vance, but our intelligence always assumed it was a man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[91]`
  - -> `[96]`
  - -> `[90]`

### Węzeł `[89]`
**[WYBÓR GRACZA: ""How could we have missed all this?""]** — Mówca: **Player**
> ""How could we have missed all this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[90]`
**[WYBÓR GRACZA: ""My God. You were right. I should never have doubted you.""]** — Mówca: **Player**
> ""My God. You were right. I should never have doubted you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[91]`
**[WYBÓR GRACZA: ""That lying, two-faced succubus!""]** — Mówca: **Player**
> ""That lying, two-faced succubus!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Lucian Galade**
> ""As mentioned, Miss Suno was hired without a background check. It's possible this all could have been avoided, had any of Mr. Vectern's blood flow been directed to his brain when he selected her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[93]`
Mówca: **Lucian Galade**
> ""To be fair, Miss Suno was just doing her job. Your vice president, on the other hand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[94]`
Mówca: **Lucian Galade**
> ""The standard procedure would be to try Miss Suno for espionage. If we do so, it's only a matter of time before the media pieces together what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[113]`
  - -> `[114]`
  - -> `[118]`

### Węzeł `[95]`
**[WYBÓR GRACZA: ""Easy. I'll get Marcel on it.""]** — Mówca: **Player**
> ""Easy. I'll get Marcel on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[96]`
**[WYBÓR GRACZA: ""You should have figured this out ages ago.""]** — Mówca: **Player**
> ""You should have figured this out ages ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[97]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Lucian Galade**
> ""I'm happy to hear that. Now, what are you going to do, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[100]`
  - -> `[101]`
  - -> `[103]`

### Węzeł `[99]`
Mówca: **Lucian Galade**
> ""But none of that can be helped now. The question is, what are you going to do, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[100]`
  - -> `[101]`
  - -> `[103]`

### Węzeł `[100]`
**[WYBÓR GRACZA: ""What do you think I should do?""]** — Mówca: **Player**
> ""What do you think I should do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[101]`
**[WYBÓR GRACZA: ""What do you mean? I'm going to murder them both.""]** — Mówca: **Player**
> ""What do you mean? I'm going to murder them both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[102]`
**[WYBÓR GRACZA: ""Arrest her for espionage, of course.""]** — Mówca: **Player**
> ""Arrest her for espionage, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[103]`
**[WYBÓR GRACZA: ""I'm going to have Petr castrated.""]** — Mówca: **Player**
> ""I'm going to have Petr castrated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[104]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.SecretState_LucianKnowsSSPKills == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.SecretState_LucianKnowsSSPKills == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SecretState_LucianKnowsSSPKills"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[106]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.SecretState_LucianKnowsSSPKills == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SecretState_LucianKnowsSSPKills"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[107]`
Mówca: **Lucian Galade**
> ""Perhaps as a last resort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[108]`
Mówca: **Narrator**
> "Lucian lowered his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[109]`
Mówca: **Narrator**
> "Lucian stroked his beard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Lucian Galade**
> ""I'm going to assume you're joking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[111]`
Mówca: **Lucian Galade**
> ""That would be standard procedure. However, if we do so it's only a matter of time before the media pieces together what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[113]`
  - -> `[114]`
  - -> `[118]`

### Węzeł `[112]`
Mówca: **Lucian Galade**
> ""I wouldn't be opposed to that idea. But I meant with regards to our spy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[113]`
**[WYBÓR GRACZA: ""I'll look like a fool for having her under my nose this entire time.""]** — Mówca: **Player**
> ""I'll look like a fool for having her under my nose this entire time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[114]`
**[WYBÓR GRACZA: ""Outwitted by a woman. It won't look good.""]** — Mówca: **Player**
> ""Outwitted by a woman. It won't look good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[115]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true && BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true && BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[117]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true && BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[118]`
**[WYBÓR GRACZA: ""What if there were no trial?""]** — Mówca: **Player**
> ""What if there were no trial?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[119]`
Mówca: **Lucian Galade**
> ""Asking Mr. Koronti for help would be advisable, but you'll still have to do a fair amount of crisis management yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[120]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn08_A_InvestigationResults = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn08_A_InvestigationResults"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[121]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[123]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[124]`
Mówca: **Lucian Galade**
> ""With the powers granted by your emergency decree, you could certainly detain her without a trial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[125]`
Mówca: **Lucian Galade**
> ""With the powers granted by your emergency decree, you could certainly detain her without a trial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`
  - -> `[130]`

### Węzeł `[126]`
Mówca: **Lucian Galade**
> ""Mr. Greiser and his men could certainly take care of this in secret.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[127]`
Mówca: **Lucian Galade**
> ""Alternately, you could mobilize Mr. Greiser and his men to take care of the situation in secret.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`
  - -> `[136]`

### Węzeł `[128]`
**[WYBÓR GRACZA: ""You are right. Let's detain her immediately.""]** — Mówca: **Player**
> ""You are right. Let's detain her immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[129]`
**[WYBÓR GRACZA: ""Good. Let's detain her. And Petr, too -- this was all his fault.""]** — Mówca: **Player**
> ""Good. Let's detain her. And Petr, too -- this was all his fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[130]`
**[WYBÓR GRACZA: ""No, no. I'd rather do it all above board.""]** — Mówca: **Player**
> ""No, no. I'd rather do it all above board.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[131]`
**[WYBÓR GRACZA: ""Yes, brilliant. Let's do that.""]** — Mówca: **Player**
> ""Yes, brilliant. Let's do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[132]`
**[WYBÓR GRACZA: ""No, no. I'd rather do it all above board.""]** — Mówca: **Player**
> ""No, no. I'd rather do it all above board.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[133]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Hide The Truth)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[134]`
**[WYBÓR GRACZA: ""Detention without trial sounds like the easiest thing to do.""]** — Mówca: **Player**
> ""Detention without trial sounds like the easiest thing to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[135]`
**[WYBÓR GRACZA: ""Let's use Karl. The fewer loose ends, the better.""]** — Mówca: **Player**
> ""Let's use Karl. The fewer loose ends, the better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[136]`
**[WYBÓR GRACZA: ""No, no. I'd rather do it all above board.""]** — Mówca: **Player**
> ""No, no. I'd rather do it all above board.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[137]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Public Trial - Blame Petr Or Not)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`
  - -> `[160]`
  - -> `[163]`

### Węzeł `[138]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Public Trial - Blame Petr Or Not])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[139]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Hide The Truth])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[140]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[142]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true || BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true  or  Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Lucian Galade**
> ""Then you'd -- what, exactly? Knowingly let her return to Rumburg? That would damage us even further if the truth got out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[144]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true || BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true || BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true || BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[147]`
Mówca: **Lucian Galade**
> ""There are other options.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Hide The Truth])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[149]`
Mówca: **Lucian Galade**
> ""Asking Mr. Koronti for help would be advisable, but you'll still have to do a fair amount of crisis management yourself. Unless you opt to handle this another way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[150]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true || BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true || BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[152]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true || BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[153]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Hide The Truth])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[154]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Public Trial - Blame Petr Or Not])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[155]`
Mówca: **Lucian Galade**
> ""That's why you must let Mr. Vectern take the fall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[156]`
Mówca: **Lucian Galade**
> ""You must remain in control of the narrative, Mr. President. Starting by letting Petr Vectern take the fall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[157]`
Mówca: **Lucian Galade**
> ""Starting by letting Petr Vectern take the fall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[158]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Public Trial - Blame Petr Or Not])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[159]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Public Trial - Blame Petr Or Not])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[160]`
**[WYBÓR GRACZA: ""No. No, I told you, Petr did nothing wrong!""]** — Mówca: **Player**
> ""No. No, I told you, Petr did nothing wrong!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[161]`
**[WYBÓR GRACZA: ""I know his actions were problematic...""]** — Mówca: **Player**
> ""I know his actions were problematic...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[162]`
**[WYBÓR GRACZA: ""This is my fault as much as his. I should have suspected something.""]** — Mówca: **Player**
> ""This is my fault as much as his. I should have suspected something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[163]`
**[WYBÓR GRACZA: ""I know you think you'd be a better vice president. But enough is enough.""]** — Mówca: **Player**
> ""I know you think you'd be a better vice president. But enough is enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[164]`
**[WYBÓR GRACZA: ""You can share the blame, but you have to prepare for your public opinion to nosedive.""]** — Mówca: **Lucian Galade**
> ""You can share the blame, but you have to prepare for your public opinion to nosedive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Lucian Galade**
> ""Thankfully, Mr. Koronti can soften that blow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[166]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Turn07_A_Marcel_Threatened == false && BaseGame.Relations_Marcel_Enemy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Turn07_A_Marcel_Threatened == false && BaseGame.Relations_Marcel_Enemy == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Turn07_A_Marcel_Threatened"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[168]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Turn07_A_Marcel_Threatened == false && BaseGame.Relations_Marcel_Enemy == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Turn07_A_Marcel_Threatened"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[169]`
Mówca: **Lucian Galade**
> ""Mr. Vectern put you in danger by failing to order a background check on your closest personal staff. He betrayed your confidence to a woman with whom he was committing adultery. Anton, would you do the same to your so-called best friend?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[174]`
  - -> `[175]`

### Węzeł `[170]`
Mówca: **Lucian Galade**
> ""Problematic is an understatement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[171]`
**[WYBÓR GRACZA: ""I-- no. I wouldn't.""]** — Mówca: **Player**
> ""I-- no. I wouldn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[172]`
Mówca: **Lucian Galade**
> ""Mr. President, rest assured this is not about me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[173]`
Mówca: **Lucian Galade**
> ""But please, take a moment to think about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[174]`
**[WYBÓR GRACZA: ""For a woman I loved? Maybe I would!""]** — Mówca: **Player**
> ""For a woman I loved? Maybe I would!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[175]`
**[WYBÓR GRACZA: ""I don't know. I can't put myself in his shoes.""]** — Mówca: **Player**
> ""I don't know. I can't put myself in his shoes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[176]`
Mówca: **Narrator**
> "I thought about how useful she'd been to me as a secretary."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[49]`

### Węzeł `[177]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusiness == true || BaseGame.Relations_Walter_Promise_Company == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Walter_Promise_BailBusiness == true || BaseGame.Relations_Walter_Promise_Company == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  or  Variable["BaseGame.Relations_Walter_Promise_Company"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[179]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Walter_Promise_BailBusiness == true || BaseGame.Relations_Walter_Promise_Company == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  or  Variable["BaseGame.Relations_Walter_Promise_Company"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[180]`
Mówca: **Lucian Galade**
> ""Try guzzling half a bottle of whiskey. That might help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Narrator**
> "Lucian sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[182]`
Mówca: **Lucian Galade**
> ""If you say so, sir. Are you ready to let Mr. Vectern take the fall?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[183]`
Mówca: **Lucian Galade**
> ""If you say so, sir. Are you ready to let Mr. Vectern take the fall?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Public Trial - Blame Petr Or Not])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[185]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Public Trial - Blame Petr Or Not])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[186]`
Mówca: **Lucian Galade**
> ""If you say so, sir. Are you ready to let Mr. Vectern take the fall?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[187]`
Mówca: **Lucian Galade**
> ""I am your chief strategist. I have advised you on what I believe is the best strategy. But of course, the ultimate decision is yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[188]`
  - -> `[190]`

### Węzeł `[188]`
**[WYBÓR GRACZA: ""I will shoulder the blame along with him.""]** — Mówca: **Player**
> ""I will shoulder the blame along with him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[189]`
**[WYBÓR GRACZA: ""All right. Petr will be our scapegoat.""]** — Mówca: **Player**
> ""All right. Petr will be our scapegoat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[190]`
**[WYBÓR GRACZA: ""I will blame Livia -- I mean, Ilana -- and nobody else.""]** — Mówca: **Player**
> ""I will blame Livia -- I mean, Ilana -- and nobody else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[192]`
Mówca: **Narrator**
> "Lucian looked as if he was about to object one last time, but instead smiled thinly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Lucian Galade**
> ""Very well. I shall consult with our friend Mr. Koronti and write a statement for you to read at the press conference. I'll leave you to handle Miss Vance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`

### Węzeł `[194]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Relations_Marcel_Enemy == false && BaseGame.Turn07_Detained_MarcelKoronti == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Relations_Marcel_Enemy == false && BaseGame.Turn07_Detained_MarcelKoronti == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[196]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true && BaseGame.Relations_Marcel_Enemy == false && BaseGame.Turn07_Detained_MarcelKoronti == false ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Lucian Galade**
> ""Very well. I shall write a statement for you to read at the press conference. I'll leave you to handle Miss Vance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`

### Węzeł `[198]`
**[WYBÓR GRACZA: ""With pleasure.""]** — Mówca: **Player**
> ""With pleasure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[199]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[200]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`

### Węzeł `[201]`
**[WYBÓR GRACZA: ""Great. Let's detain her immediately.""]** — Mówca: **Player**
> ""Great. Let's detain her immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[202]`
**[WYBÓR GRACZA: ""Great. Let's detain both her and Petr. He got us into this mess, after all.""]** — Mówca: **Player**
> ""Great. Let's detain both her and Petr. He got us into this mess, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[203]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[204]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Secret Police Talk)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[205]`
Mówca: **Lucian Galade**
> ""A wise choice, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Secret Police Talk])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[207]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: Jump to: [Secret Police Talk])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[208]`
**[WYBÓR GRACZA: ""By 'take care of', you mean secretly arrest, right?""]** — Mówca: **Player**
> ""By 'take care of', you mean secretly arrest, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[209]`
**[WYBÓR GRACZA: ""By 'take care of', you mean 'take care of for good', right?""]** — Mówca: **Player**
> ""By 'take care of', you mean 'take care of for good', right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[210]`
Mówca: **Lucian Galade**
> ""I think you know precisely what I mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[211]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.SecretState_LucianKnowsSSPKills == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.SecretState_LucianKnowsSSPKills == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SecretState_LucianKnowsSSPKills"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[213]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.SecretState_LucianKnowsSSPKills == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SecretState_LucianKnowsSSPKills"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Lucian Galade**
> ""What else could I have meant?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[223]`

### Węzeł `[215]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.SecretState_LucianKnowsSSPKills == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.SecretState_LucianKnowsSSPKills == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SecretState_LucianKnowsSSPKills"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.SecretState_LucianKnowsSSPKills == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SecretState_LucianKnowsSSPKills"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Lucian Galade**
> ""I think you know precisely what I mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[219]`
Mówca: **Lucian Galade**
> ""It means whatever you want it to mean, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[220]`
Mówca: **Narrator**
> "Lucian nodded and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[221]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_BlamePetrForLeak = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[222]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_DenyEverything = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[223]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_Kill_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[228]`

### Węzeł `[225]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_Kill_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[231]`

### Węzeł `[226]`
**[WYBÓR GRACZA: ""Uh, nothing.""]** — Mówca: **Player**
> ""Uh, nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[227]`
**[WYBÓR GRACZA: ""Nothing...""]** — Mówca: **Player**
> ""Nothing...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[228]`
**[WYBÓR GRACZA: ""Kill, perhaps? It's been done before.""]** — Mówca: **Player**
> ""Kill, perhaps? It's been done before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Lucian Galade**
> ""I see. Curious that I wasn't informed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[230]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[231]`
**[WYBÓR GRACZA: ""Kill, maybe?""]** — Mówca: **Player**
> ""Kill, maybe?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[232]`
Mówca: **Lucian Galade**
> ""If made to look like an accident, another covert assassination could solve our problem before it even starts. But I understand if you still harbor fond feelings for Miss Vance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`
  - -> `[236]`
  - -> `[237]`

### Węzeł `[233]`
Mówca: **Narrator**
> "I could almost see the gears in Lucian's head turning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[234]`
**[WYBÓR GRACZA: ""Let's just have her arrested, okay?""]** — Mówca: **Player**
> ""Let's just have her arrested, okay?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[235]`
**[WYBÓR GRACZA: ""Let's just have her arrested -- and Petr, too, while we're at it. He's done enough harm to this administration.""]** — Mówca: **Player**
> ""Let's just have her arrested -- and Petr, too, while we're at it. He's done enough harm to this administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[236]`
**[WYBÓR GRACZA: ""Screw Liv--Ilana. Let's have her killed.""]** — Mówca: **Player**
> ""Screw Liv--Ilana. Let's have her killed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[237]`
**[WYBÓR GRACZA: ""Screw Miss Vance. And Petr too! Let's have them both killed.""]** — Mówca: **Player**
> ""Screw Miss Vance. And Petr too! Let's have them both killed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[240]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[241]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[243]`
Mówca: **Lucian Galade**
> ""As you wish. I'll call Mr. Greiser right away. It ought to be done by the end of today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[309]`

### Węzeł `[244]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[245]`
Mówca: **Lucian Galade**
> ""As you wish. I'll call Mr. Greiser right away. It ought to be done by the end of today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[307]`

### Węzeł `[246]`
Mówca: **Narrator**
> "Lucian was trying very hard not to appear pleased."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Narrator**
> "Lucian was trying very hard not to appear pleased."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Lucian Galade**
> ""As you wish. I'll call Mr. Greiser right away. It ought to be done by the end of today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[332]`

### Węzeł `[249]`
Mówca: **Lucian Galade**
> ""As you wish. I'll call Mr. Greiser right away. It ought to be done by the end of today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[322]`

### Węzeł `[250]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Livia = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[251]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Livia = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[252]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Petr = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[253]`
Mówca: **Narrator**
> "Lucian was trying very hard not to appear pleased."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Lucian Galade**
> ""As you wish. I'll call Mr. Greiser right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[325]`

### Węzeł `[255]`
Mówca: **Lucian Galade**
> ""As you wish. I'll call Mr. Greiser right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`
  - -> `[294]`

### Węzeł `[256]`
Mówca: **Narrator**
> "I called Karl Greiser from my desk and explained the situation. After a few minutes, I rang for Livia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Livia Suno**
> ""Is there something you need, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`
  - -> `[261]`
  - -> `[262]`

### Węzeł `[258]`
Mówca: **Narrator**
> "She entered my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[259]`
**[WYBÓR GRACZA: ""You tell me... Ilana.""]** — Mówca: **Player**
> ""You tell me... Ilana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[260]`
**[WYBÓR GRACZA: ""It's been a pleasure working with you, Livia.""]** — Mówca: **Player**
> ""It's been a pleasure working with you, Livia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[261]`
**[WYBÓR GRACZA: ""Yes. I need you to stop pretending.""]** — Mówca: **Player**
> ""Yes. I need you to stop pretending.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[262]`
**[WYBÓR GRACZA: ""Please, sit down.""]** — Mówca: **Player**
> ""Please, sit down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[263]`
Mówca: **Narrator**
> "A barely perceptible flash of fear crossed her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Livia Suno**
> ""Livia, sir. My name is Livia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[265]`
Mówca: **Narrator**
> "A barely perceptible flash of fear crossed her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
Mówca: **Livia Suno**
> ""Wh-what do you mean, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[267]`
Mówca: **Narrator**
> "A barely perceptible flash of fear crossed her face. She sat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
Mówca: **Livia Suno**
> ""Why did you call me in here, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Narrator**
> "I nodded toward my office doorway. Karl Greiser was standing there along with two of his guards, blocking the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[270]`
Mówca: **Karl Greiser**
> ""Ilana Vance, you are under arrest on suspicion of espionage. Please come with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[271]`
Mówca: **Narrator**
> "Her eyes darted around the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Livia Suno**
> ""What the hell is going on? Mr. President, have you let Lucian get to your head? I thought you were smarter than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[274]`
  - -> `[275]`
  - -> `[276]`

### Węzeł `[273]`
**[WYBÓR GRACZA: ""You're going to pay for your lies, Ilana.""]** — Mówca: **Player**
> ""You're going to pay for your lies, Ilana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[274]`
**[WYBÓR GRACZA: ""You're going to pay for the way you used Petr.""]** — Mówca: **Player**
> ""You're going to pay for the way you used Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[275]`
**[WYBÓR GRACZA: ""I'm sorry it had to come to this.""]** — Mówca: **Player**
> ""I'm sorry it had to come to this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[276]`
**[WYBÓR GRACZA: ""If you thought I wouldn't trust my closest advisor, you're the stupid one.""]** — Mówca: **Player**
> ""If you thought I wouldn't trust my closest advisor, you're the stupid one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
Mówca: **Narrator**
> "Karl's men grabbed her arms and began dragging her out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Livia Suno**
> ""No. No! You can't do this to me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Petr Vectern**
> ""Liv? What in the hell!? Anton, what's going on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[282]`
  - -> `[283]`
  - -> `[284]`

### Węzeł `[280]`
Mówca: **Narrator**
> "Petr, hearing her cries, rushed out of his office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[281]`
**[WYBÓR GRACZA: ""Her name's Ilana. Lucian was right about her. She's a spy.""]** — Mówca: **Player**
> ""Her name's Ilana. Lucian was right about her. She's a spy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[282]`
**[WYBÓR GRACZA: ""She was using you all along, Petr.""]** — Mówca: **Player**
> ""She was using you all along, Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[283]`
**[WYBÓR GRACZA: ""Livia, tell Petr who you really are.""]** — Mówca: **Player**
> ""Livia, tell Petr who you really are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[284]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I said nothing. Petr ran up to my now ex-secretary."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[285]`
Mówca: **Livia Suno**
> ""I won't say another word without a lawyer present.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[286]`
Mówca: **Narrator**
> "She looked Petr square in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[287]`
Mówca: **Livia Suno**
> ""Except this. You're a sad old drunk and a lousy lay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[288]`
Mówca: **Petr Vectern**
> ""No. That can't be true. Can it? Liv?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[289]`
Mówca: **Petr Vectern**
> ""Liv! Come on, tell them this was all a misunderstanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[290]`
Mówca: **Livia Suno**
> ""Honestly, if I *were* a Rumburg spy, I'd barely have to do a thing. You two have Sordland ripe for the taking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[291]`
Mówca: **Narrator**
> "She straightened up, ran a hand through her curls and allowed Karl to lead her away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[292]`
Mówca: **Narrator**
> "Petr sank to the floor in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[293]`
**[WYBÓR GRACZA: ""Thank you, Lucian.""]** — Mówca: **Player**
> ""Thank you, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[294]`
**[WYBÓR GRACZA: ""No, I'll do it myself.""]** — Mówca: **Player**
> ""No, I'll do it myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[295]`
Mówca: **Narrator**
> "Lucian nodded and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Narrator**
> "I waited a few minutes, then rang for Livia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[297]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Livia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Livia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_Detained_Livia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[300]`
Mówca: **Karl Greiser**
> ""No lawyers, ma'am. You're going away for a very long time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[301]`
Mówca: **Livia Suno**
> ""Fine. Then I will say this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[302]`
Mówca: **Narrator**
> "She looked Petr square in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
Mówca: **Livia Suno**
> ""You're a sad old drunk and a lousy lay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Livia Suno**
> ""Honestly, if I *were* a Rumburg spy, I'd barely have to do a thing. You two have Sordland ripe for the taking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[305]`
Mówca: **Narrator**
> "Lucian nodded and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[306]`
**[WYBÓR GRACZA: ""Tell him to make her suffer.""]** — Mówca: **Player**
> ""Tell him to make her suffer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[307]`
**[WYBÓR GRACZA: ""Tell him to make it painless.""]** — Mówca: **Player**
> ""Tell him to make it painless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[308]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[309]`
**[WYBÓR GRACZA: ""Keep me informed.""]** — Mówca: **Player**
> ""Keep me informed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[310]`
Mówca: **Narrator**
> "I took a minute to gather my thoughts, then headed out the office. My secretary was outside, typing up some correspondence at her desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`
  - -> `[313]`
  - -> `[314]`

### Węzeł `[311]`
**[WYBÓR GRACZA: ""Stepping out for lunch. Hold my calls.""]** — Mówca: **Player**
> ""Stepping out for lunch. Hold my calls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[312]`
**[WYBÓR GRACZA: ""I'm so sorry for the misunderstanding with Lucian. You've got a brilliant career ahead of you.""]** — Mówca: **Player**
> ""I'm sorry again for the misunderstanding with Lucian. You've got a brilliant career ahead of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[313]`
**[WYBÓR GRACZA: ""Thank you for your hard work, Miss Suno.""]** — Mówca: **Player**
> ""Thank you for your hard work, Miss Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[314]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I said nothing as I walked past her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[315]`
Mówca: **Narrator**
> "She looked at me a bit strangely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[316]`
Mówca: **Livia Suno**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[317]`
Mówca: **Livia Suno**
> ""Very well, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[318]`
Mówca: **Narrator**
> "She looked at me a bit strangely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[319]`
Mówca: **Livia Suno**
> ""No trouble at all, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Narrator**
> "I took one long, last look at her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[321]`
**[WYBÓR GRACZA: ""Tell him to make them suffer.""]** — Mówca: **Player**
> ""Tell him to make them suffer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[322]`
**[WYBÓR GRACZA: ""Tell him to make it painless.""]** — Mówca: **Player**
> ""Tell him to make it painless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Narrator**
> "Lucian nodded and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[324]`
**[WYBÓR GRACZA: ""Thank you, Lucian.""]** — Mówca: **Player**
> ""Thank you, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[325]`
**[WYBÓR GRACZA: ""No, I'll do it myself.""]** — Mówca: **Player**
> ""No, I'll do it myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[326]`
Mówca: **Petr Vectern**
> ""Anton... what the hell just happened?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`
  - -> `[404]`

### Węzeł `[327]`
Mówca: **Narrator**
> "How could I tell him that the worst was still yet to come?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[328]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Petr == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_Detained_Petr == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[330]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_Detained_Petr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[331]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[332]`
**[WYBÓR GRACZA: ""Keep me informed.""]** — Mówca: **Player**
> ""Keep me informed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[333]`
Mówca: **Narrator**
> "I took a minute to gather my thoughts, then left the room, taking my bottle of Erlory Maroon whiskey with me. My secretary was outside, typing up some correspondence at her desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`
  - -> `[313]`
  - -> `[314]`

### Węzeł `[334]`
Mówca: **Narrator**
> "Petr was about to receive some very unpleasant news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[335]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[385]`

### Węzeł `[337]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[338]`
Mówca: **Narrator**
> "I knocked on the door, and Petr answered. He looked at the bottle of whiskey, then at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[339]`
Mówca: **Petr Vectern**
> ""Hello there, you two. What's the occasion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`
  - -> `[341]`
  - -> `[342]`
  - -> `[343]`

### Węzeł `[340]`
**[WYBÓR GRACZA: ""Life, my friend. Life.""]** — Mówca: **Player**
> ""Life, my friend. Life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[341]`
**[WYBÓR GRACZA: ""Surviving your affair without a scandal, of course.""]** — Mówca: **Player**
> ""Surviving your affair without a scandal, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[342]`
**[WYBÓR GRACZA: ""Do I need an occasion to have a drink with my friend?""]** — Mówca: **Player**
> ""Do I need an occasion to have a drink with my friend?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[343]`
**[WYBÓR GRACZA: ""I just found this. Forgot I still had it left over from my first day in office.""]** — Mówca: **Player**
> ""I just found this. Forgot I still had it left over from my first day in office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Petr Vectern**
> ""Anton, it's 11:30 in the morning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[345]`
Mówca: **Narrator**
> "He cracked a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[346]`
Mówca: **Petr Vectern**
> ""What are we waiting for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[347]`
Mówca: **Narrator**
> "He brought out two glasses, and I filled them up. We drank in silence for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[348]`
Mówca: **Petr Vectern**
> ""Lucian was right. I've been a miserable excuse for a vice president. But I'm ready to start over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[349]`
Mówca: **Petr Vectern**
> ""No more affairs. No more being late. No more -- well, less drinking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[350]`
Mówca: **Petr Vectern**
> ""I just want to do right by you, Anton. As a colleague and as a friend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`
  - -> `[352]`
  - -> `[353]`
  - -> `[354]`

### Węzeł `[351]`
**[WYBÓR GRACZA: ""I'm sorry. It's too late.""]** — Mówca: **Player**
> ""I'm sorry. It's too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[352]`
**[WYBÓR GRACZA: ""Thank you. I'm sure you will.""]** — Mówca: **Player**
> ""Thank you. I'm sure you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[353]`
**[WYBÓR GRACZA: ""You don't need to make it up to me. Our friendship goes too deep for that:""]** — Mówca: **Player**
> ""You don't need to make it up to me. Our friendship goes too deep for that:""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[354]`
**[WYBÓR GRACZA: ""We'll see.""]** — Mówca: **Player**
> ""We'll see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Petr Vectern**
> ""But--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`
  - -> `[358]`
  - -> `[383]`

### Węzeł `[356]`
Mówca: **Narrator**
> "Petr's eyes had that old sparkle in them again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`
  - -> `[358]`
  - -> `[383]`

### Węzeł `[357]`
**[WYBÓR GRACZA: ""I'm going back to work now.""]** — Mówca: **Player**
> ""I'm going back to work now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[358]`
**[WYBÓR GRACZA: ""Goodbye, Petr.""]** — Mówca: **Player**
> ""Goodbye, Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[359]`
Mówca: **Narrator**
> "I walked out, leaving the bottle on his desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[360]`
Mówca: **Narrator**
> "I returned home that evening and headed straight to my study, waiting for Karl to call."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[361]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_ShareBlame = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[362]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaStays = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaStays"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[363]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_HP_LiviaSpyReveal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_LiviaSpyReveal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[364]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_ST_LiviaSpyReveal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_LiviaSpyReveal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[365]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_R_LiviaSpyReveal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_LiviaSpyReveal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[366]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: (BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true) || (BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true && BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true) || (BaseGame.Turn08_SecondScandal_Detained_Livia == true && BaseGame.Turn08_SecondScandal_Detained_Petr == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: (BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true) || (BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true && BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true) || (BaseGame.Turn08_SecondScandal_Detained_Livia == true && BaseGame.Turn08_SecondScandal_Detained_Petr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true)  or  (Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true)  or  (Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[368]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !((BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true) || (BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true && BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true) || (BaseGame.Turn08_SecondScandal_Detained_Livia == true && BaseGame.Turn08_SecondScandal_Detained_Petr == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true)  or  (Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true)  or  (Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[369]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Enable_PressRelease = true;
BaseGame.Situation_Order_InfiltratedIntelligence = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_PressRelease"] = true;
Variable["BaseGame.Situation_Order_InfiltratedIntelligence"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[370]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Enable_LiviaPetrGone = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_LiviaPetrGone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[371]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true ||
BaseGame.Turn08_SecondScandal_ShareBlame == true ||
BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true ||
BaseGame.Turn08_SecondScandal_ShareBlame == true ||
BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true  or 
Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true  or 
Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true ||
BaseGame.Turn08_SecondScandal_ShareBlame == true ||
BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true  or 
Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true  or 
Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[374]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Enable_VPSelection = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_VPSelection"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[375]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn08_A_PressReleases = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn08_A_PressReleases"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[376]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaTrialled = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[377]`
**[WYBÓR GRACZA: ""Are you sure about this?""]** — Mówca: **Player**
> ""Are you sure about this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[378]`
Mówca: **Lucian Galade**
> ""Here. It's all in the report from our intelligence officers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[379]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[381]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[382]`
**[WYBÓR GRACZA: ""It's okay, Lucian. I know exactly what you mean.""]** — Mówca: **Player**
> ""It's okay, Lucian. I know exactly what you mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[383]`
**[WYBÓR GRACZA: ""Have a nice one, old friend.""]** — Mówca: **Player**
> ""Have a nice one, old friend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[384]`
**[WYBÓR GRACZA: "Head to Petr's office."]** — Mówca: **Player_Italic**
> "I headed down the hall to Petr's office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[385]`
**[WYBÓR GRACZA: "Head out."]** — Mówca: **Player_Italic**
> "I headed outside with the bottle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[386]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaFired == true || BaseGame.Turn08_SecondScandal_LiviaStays == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaFired == true || BaseGame.Turn08_SecondScandal_LiviaStays == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaFired"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaStays"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[388]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_LiviaFired == true || BaseGame.Turn08_SecondScandal_LiviaStays == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaFired"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaStays"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[389]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_SecondScandal_LiviaFired = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_LiviaFired"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[390]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_SecondScandal_LiviaStays = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_LiviaStays"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[391]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_SecondScandal_LiviaDetained = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_LiviaDetained"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[392]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_SecondScandal_LiviaAndPetrDetained = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_LiviaAndPetrDetained"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[393]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_SecondScandal_BlamePetrForLeak = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_BlamePetrForLeak"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[394]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_SecondScandal_ShareBlame = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_ShareBlame"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[395]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_SecondScandal_DenyEverything = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_DenyEverything"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[396]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_ArrestLivia = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_ArrestLivia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[397]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_KillLivia = true;
BaseGameSupport.Codex_Characters_Others_LiviaSuno = false;
BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_KillLivia"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[398]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_ArrestLiviaAndPetr = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_ArrestLiviaAndPetr"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[399]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_KillLiviaAndPetr = true; BaseGame.Petr_Dead = true; BaseGame.Petr_isVP = false;
BaseGameSupport.Codex_Characters_Others_LiviaSuno = false;
BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_KillLiviaAndPetr"] = true;
Variable["BaseGame.Petr_Dead"] = true;
Variable["BaseGame.Petr_isVP"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[400]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_LiviaTrialled = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_SecretState_LiviaTrialled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[401]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_SecondScandal_LiviaSpy = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_LiviaSpy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[402]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Others_LiviaSuno = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed = true; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[403]`
**[WYBÓR GRACZA: ""Come to my office. You're making a scene out here.""]** — Mówca: **Player**
> ""Come to my office. You're making a scene out here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[404]`
**[WYBÓR GRACZA: ""I'll tell you in my office. Feel free to take a moment first.""]** — Mówca: **Player**
> ""I'll tell you in my office. Feel free to take a moment first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[405]`
Mówca: **Narrator**
> "Once Petr was in my office, I shut the door and explained everything Lucian had told me about Livia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[406]`
Mówca: **Petr Vectern**
> ""And you believed him? Well, better safe than sorry, especially after what she called me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[407]`
Mówca: **Petr Vectern**
> ""At least we finally have this ordeal behind us. Let's get on with running the country, shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`
  - -> `[408]`
  - -> `[409]`

### Węzeł `[408]`
**[WYBÓR GRACZA: ""Yes, let's.""]** — Mówca: **Player**
> ""Yes, let's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[409]`
**[WYBÓR GRACZA: ""Yes, let's. But first, a drink.""]** — Mówca: **Player**
> ""Yes, let's. But first, a drink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[410]`
**[WYBÓR GRACZA: ""Actually, I have to tell you something...""]** — Mówca: **Player**
> ""Actually, I have to tell you something...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[411]`
Mówca: **Petr Vectern**
> ""Yeah? What is it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`
  - -> `[412]`
  - -> `[416]`

### Węzeł `[412]`
**[WYBÓR GRACZA: ""Lucian wants you to resign.""]** — Mówca: **Player**
> ""Lucian wants you to resign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[413]`
**[WYBÓR GRACZA: ""I want you to resign.""]** — Mówca: **Player**
> ""I want you to resign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[414]`
**[WYBÓR GRACZA: ""Lucian wanted you to resign, but I told him it's not happening.""]** — Mówca: **Player**
> ""Lucian wanted you to resign, but I told him it's not happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[415]`
Mówca: **Narrator**
> "Petr looked up at me. His expression was numb."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[416]`
**[WYBÓR GRACZA: ""You look like shit. Why don't you take the rest of the day off?""]** — Mówca: **Player**
> ""You look like shit. Why don't you take the rest of the day off?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[417]`
Mówca: **Narrator**
> "Petr looked at me gratefully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[418]`
Mówca: **Petr Vectern**
> ""Thanks, Anton. I do need a little time. But I promise it's going to be a whole new me from now on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[419]`
Mówca: **Narrator**
> "I watched him leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[420]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`
  - -> `[422]`

### Węzeł `[421]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[422]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[423]`
Mówca: **Narrator**
> "A whole new vice president... I didn't have the heart to tell Petr how right he was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[424]`
Mówca: **Narrator**
> "A whole new Petr... I hoped he was right about that."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[425]`
Mówca: **Petr Vectern**
> ""I... I guess I deserve this, don't I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`
  - -> `[427]`

### Węzeł `[426]`
**[WYBÓR GRACZA: ""Yes. Your philandering put all of us in danger.""]** — Mówca: **Player**
> ""Yes. Your philandering put all of us in danger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[427]`
**[WYBÓR GRACZA: ""No. But we need someone to take the fall for this scandal, or the administration suffers.""]** — Mówca: **Player**
> ""No. But we need someone to take the fall for this scandal, or the administration suffers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[428]`
Mówca: **Narrator**
> "He exhaled slowly. I could see tears in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[429]`
Mówca: **Petr Vectern**
> ""I'm so sorry, Anton. I was never cut out for this job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`
  - -> `[431]`
  - -> `[453]`

### Węzeł `[430]`
**[WYBÓR GRACZA: ""It was fun while it lasted.""]** — Mówca: **Player**
> ""It was fun while it lasted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[431]`
**[WYBÓR GRACZA: ""You really weren't. But at least you got a nice house out of the deal.""]** — Mówca: **Player**
> ""You really weren't. But at least you got a nice house out of the deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[432]`
Mówca: **Narrator**
> "Petr looked up at me with an indignant expression."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[433]`
Mówca: **Petr Vectern**
> ""Of course he does, that fink. Did you tell him off?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`
  - -> `[435]`
  - -> `[436]`

### Węzeł `[434]`
**[WYBÓR GRACZA: ""Actually, I agree with him. I'm announcing your resignation, Petr.""]** — Mówca: **Player**
> ""Actually, I agree with him. I'm announcing your resignation, Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[435]`
**[WYBÓR GRACZA: ""I did. We're laying this all at Rumburg's feet.""]** — Mówca: **Player**
> ""I did. We're laying this all at Rumburg's feet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[436]`
**[WYBÓR GRACZA: ""I did. This is as much my fault as it is yours. The administration will take the hit.""]** — Mówca: **Player**
> ""I did. This is as much my fault as it is yours. The administration will take the hit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[437]`
Mówca: **Narrator**
> "Petr looked up at me in surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[438]`
Mówca: **Petr Vectern**
> ""Really, Anton? That means a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`
  - -> `[441]`

### Węzeł `[439]`
Mówca: **Narrator**
> "Petr's face fell. He seemed to sink into the couch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[440]`
**[WYBÓR GRACZA: ""We're laying this all at Rumburg's feet.""]** — Mówca: **Player**
> ""We're laying this all at Rumburg's feet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[441]`
**[WYBÓR GRACZA: ""This is as much my fault as it is yours. The administration will take the hit.""]** — Mówca: **Player**
> ""This is as much my fault as it is yours. The administration will take the hit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[442]`
Mówca: **Narrator**
> "Petr eagerly nodded, then thought better of it and shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[443]`
Mówca: **Petr Vectern**
> ""No. My drunken idiocy got us into this mess in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[444]`
Mówca: **Petr Vectern**
> ""It's going to be a whole new me from now on, Anton. I promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[445]`
Mówca: **Petr Vectern**
> ""I can't believe I was so careless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[446]`
Mówca: **Petr Vectern**
> ""That's... wow. I can't believe you'd do that for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`
  - -> `[456]`

### Węzeł `[447]`
Mówca: **Petr Vectern**
> ""Oof. I hope they don't take it as a sign to escalate. But, wow, thanks for protecting me from Guillotine Galade over there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`
  - -> `[456]`

### Węzeł `[448]`
Mówca: **Petr Vectern**
> ""Unless Evelyn takes it in the divorce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`
  - -> `[451]`

### Węzeł `[449]`
Mówca: **Petr Vectern**
> ""Sure was, old buddy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`
  - -> `[451]`

### Węzeł `[450]`
**[WYBÓR GRACZA: ""You'll have some time before the news goes public. I suggest you get your affairs in order.""]** — Mówca: **Player**
> ""You'll have some time before the news goes public. I suggest you get your affairs in order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[451]`
**[WYBÓR GRACZA: ""Stay for a drink.""]** — Mówca: **Player**
> ""Stay for a drink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[452]`
Mówca: **Petr Vectern**
> ""All right, I get the message. But first...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[453]`
**[WYBÓR GRACZA: ""You did great. Sordland's just not ready for a vice president like you yet.""]** — Mówca: **Player**
> ""You did great. Sordland's just not ready for a vice president like you yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[454]`
Mówca: **Petr Vectern**
> ""Don't patronize me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`
  - -> `[451]`

### Węzeł `[455]`
**[WYBÓR GRACZA: ""We'll have some time before the news goes public. We should get our stories straight.""]** — Mówca: **Player**
> ""We'll have some time before the news goes public. We should get our stories straight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[456]`
**[WYBÓR GRACZA: ""Stay for a drink.""]** — Mówca: **Player**
> ""Stay for a drink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[457]`
Mówca: **Narrator**
> "Without waiting for him to answer, I poured some whiskey into a glass. Petr grabbed the bottle instead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[458]`
Mówca: **Petr Vectern**
> ""To new beginnings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[459]`
Mówca: **Narrator**
> "He drained a third of the bottle in one long swig, then got to his feet and unsteadily made his way to the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[460]`
Mówca: **Narrator**
> "He grabbed the bottle of Erlory Maroon 30-Year-Old from the shelf behind my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[461]`
Mówca: **Narrator**
> "I knew this was for the best. But I hoped my friend would be all right."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[462]`
Mówca: **Petr Vectern**
> ""Sure, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[463]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`
  - -> `[465]`

### Węzeł `[464]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[465]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[466]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_BlamePetrForLeak = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[467]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_DenyEverything = true; BaseGame.Turn08_SecondScandal_ShareBlame = false; BaseGame.Turn08_SecondScandal_BlamePetrForLeak = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] = true;
Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] = false;
Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[468]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_DenyEverything = false; BaseGame.Turn08_SecondScandal_ShareBlame = true; BaseGame.Turn08_SecondScandal_BlamePetrForLeak = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] = false;
Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] = true;
Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[469]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_DenyEverything = true; BaseGame.Turn08_SecondScandal_ShareBlame = false; BaseGame.Turn08_SecondScandal_BlamePetrForLeak = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] = true;
Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] = false;
Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[470]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_DenyEverything = false; BaseGame.Turn08_SecondScandal_ShareBlame = true; BaseGame.Turn08_SecondScandal_BlamePetrForLeak = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] = false;
Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] = true;
Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[471]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_PressConference_PetrKnowsResigning = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_PressConference_PetrKnowsResigning"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[472]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[473]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.SecretState_LucianKnowsSSPKills == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`
  - -> `[475]`

### Węzeł `[474]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.SecretState_LucianKnowsSSPKills == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.SecretState_LucianKnowsSSPKills"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[475]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.SecretState_LucianKnowsSSPKills == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.SecretState_LucianKnowsSSPKills"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[476]`
Mówca: **Lucian Galade**
> ""If made to look like an accident, a covert assassination by your Secret State Police could solve our problem before it even starts. But I understand if you still harbor fond feelings for Miss Vance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`
  - -> `[236]`
  - -> `[237]`
