# Rizia/Turn 5/SnO_TitusLucitaBriefing

- **ID konwersacji:** `328`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Rizia/Turn_05/328_SnO_TitusLucitaBriefing.md`
- **Liczba węzłów dialogowych:** 920
- **Liczba wyborów gracza:** 162

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.InvestigatePoisoning_NoPabel`
- `RiziaDLC.PoisonInvestigator_Lucita`
- `RiziaDLC.PoisonInvestigator_Titus`
- `RiziaDLC.Policy_Law_StateReligion_Wruhecism`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Relations_Lucita_PromisedDate`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Pabel_OutedToPlayer`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Relations_Titus`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn05_MurderInvest_InvestigateHugo`
- `RiziaDLC.Turn05_MurderInvest_InvestigateLucita`
- `RiziaDLC.Turn05_MurderInvest_InvestigateSal`
- `RiziaDLC.Turn05_MurderInvest_InvestigateTitus`
- `RiziaDLC.Turn05_MurderInvest_SuspectEstela`
- `RiziaDLC.Turn05_MurderInvest_SuspectHugo`
- `RiziaDLC.Turn05_MurderInvest_SuspectLucita`
- `RiziaDLC.Turn05_MurderInvest_SuspectPabel`
- `RiziaDLC.Turn05_MurderInvest_SuspectSal`
- `RiziaDLC.Turn05_MurderInvest_SuspectTitus`
- `RiziaDLCIsolated.Investigation_SuspectHugo_Argument`
- `RiziaDLCIsolated.Investigation_SuspectHugo_Lying`
- `RiziaDLCIsolated.Investigation_SuspectHugo_Timing`
- `RiziaDLCIsolated.Turn04_Winery_DrinkingGamePabel`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.PoisonInvestigation_Continues`
- `RiziaDLC.PoisonInvestigator_Lucita`
- `RiziaDLC.PoisonInvestigator_Titus`
- `RiziaDLC.Relations_Pabel_OutedToPlayer`
- `RiziaDLC.Turn05_MurderInvest_InvestigateHugo`
- `RiziaDLC.Turn05_MurderInvest_InvestigateLucita`
- `RiziaDLC.Turn05_MurderInvest_InvestigateNoone`
- `RiziaDLC.Turn05_MurderInvest_InvestigateSal`
- `RiziaDLC.Turn05_MurderInvest_InvestigateTitus`
- `RiziaDLC.Turn05_MurderInvest_SuspectEstela`
- `RiziaDLC.Turn05_MurderInvest_SuspectHugo`
- `RiziaDLC.Turn05_MurderInvest_SuspectLucita`
- `RiziaDLC.Turn05_MurderInvest_SuspectPabel`
- `RiziaDLC.Turn05_MurderInvest_SuspectSal`
- `RiziaDLC.Turn05_MurderInvest_SuspectTitus`
- `RiziaDLCIsolated.Investigation_SuspectHugo_Argument`
- `RiziaDLCIsolated.Investigation_SuspectHugo_Lying`
- `RiziaDLCIsolated.Investigation_SuspectHugo_Timing`
- `RiziaDLCSupport.Journal_Turn05_Security_InvestigateHugo`
- `RiziaDLCSupport.Journal_Turn05_Security_InvestigateLucita`
- `RiziaDLCSupport.Journal_Turn05_Security_InvestigateNoone`
- `RiziaDLCSupport.Journal_Turn05_Security_InvestigateSal`
- `RiziaDLCSupport.Journal_Turn05_Security_InvestigateTitus`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 16
- **Węzły modyfikujące stan gry:** 27

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Pabel_OutedToPlayer`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[130]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] = true;`
- Węzeł `[131]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] = true;`
- Węzeł `[135]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn05_MurderInvest_SuspectTitus"] = true;`
- Węzeł `[147]` (Paskal Beniwoll): `RemoveConversant("Lucita Azaro");`
- Węzeł `[148]` (Paskal Beniwoll): `RemoveConversant("Lucita Azaro");`
- Węzeł `[149]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateNoone"] = true; Variable["RiziaDLCSupport.Journ...`
- Węzeł `[150]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] = true; Variable["RiziaDLCSupport.Journal...`
- Węzeł `[151]` (Paskal Beniwoll): `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] = true; Variable["RiziaDLCSupport.Journal...`
- *...oraz 19 innych węzłów ze skryptami.*

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
  - -> `[919]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Lucita Azaro**
> ""Let me start by saying that I've made significant progress into who may be responsible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[86]`
  - -> `[4]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you *do* suspect foul play.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[5]`
Mówca: **Lucita Azaro**
> ""Unfortunately, yes. There are several individuals I find highly suspicious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[6]`
Mówca: **Lucita Azaro**
> ""My initial list comprised five individuals: Captain Gordion, Grand Wiseman Ignacius, your butler, your uncle, and your mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[9]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Narrator**
> "Lucita discreetly glanced around as if making sure there was no one else with us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're conveniently forgetting yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you've narrowed it down from there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My mother? How dare you insinuate such an awful thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[11]`
Mówca: **Lucita Azaro**
> ""You wouldn't have asked me to investigate if you thought I was guilty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[13]`
  - -> `[12]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me what you’ve learned -- no matter how hard it is to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright, let's go down the list.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you're armed with substantial evidence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[15]`
Mówca: **Lucita Azaro**
> ""As a matter of fact, I have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[13]`
  - -> `[12]`

### Węzeł `[16]`
Mówca: **Lucita Azaro**
> ""I meant no offense. You instructed me to investigate everyone present at the palace during that time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[13]`
  - -> `[12]`

### Węzeł `[17]`
Mówca: **Lucita Azaro**
> ""With whom should I begin?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Suspects Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[44]`
  - -> `[47]`
  - -> `[366]`
  - -> `[92]`
  - -> `[688]`
  - -> `[113]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectHugo == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectHugo == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_SuspectHugo == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me about my uncle. Why him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is all too vague. I want cold, hard facts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I seriously find it hard to believe that my uncle would murder his brother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If your account is accurate, we need to find out more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm glad you did. If what you're saying is true, we must handle this delicately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Suspects Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, but what you're implying sounds too far-fetched.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me all the details about my mother's whereabouts on the night my father passed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's hear why you suspect Titus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[31]`
Mówca: **Lucita Azaro**
> ""Your Majesty, our investigative efforts have unveiled a rather unexpected revelation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Lucita Azaro**
> ""The Queen Mother was at dinner that night. Later, as verified by Titus Gordion, she opened the door to your father's chambers and immediately alerted the Golden Guard that he was unconscious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[915]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's good right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Dastnurist? Are you sure?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If this is your idea of a joke, I'm not laughing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, they must have been mistaken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Suspects Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[38]`
Mówca: **Lucita Azaro**
> ""Your guardsman's behavior was suspicious, to say the least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I find this accusation hard to believe. Titus has been nothing but loyal from day one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[40]`
Mówca: **Lucita Azaro**
> ""On the night of King Valero's death, Captain Gordion was charged with guarding his chambers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[52]`
  - -> `[53]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He probably just went to the toilet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He wasn't at his post? That's not like Titus at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did he or anyone else enter my father's room during that time?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectEstela == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectEstela == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_SuspectEstela == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectTitus == false && RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectTitus == false && RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectTitus"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_SuspectTitus == false && RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectTitus"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not in the palace? Then where the hell was she?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So my mother has her own share of secrets... guess that makes her human after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's often taken it upon himself to personally oversee the king's security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay, I'm listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. And?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This only confirms my suspicions that he can't be trusted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is troubling news indeed. I've always taken Titus to be a loyal protector.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There must be some mistake. As far as I'm concerned he is the epitome of honor and loyalty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus >= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus >= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Titus"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[56]`
  - -> `[39]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Titus >= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Titus"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[133]`
  - -> `[134]`

### Węzeł `[61]`
Mówca: **Lucita Azaro**
> ""Yes, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want to know why you suspect Pabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[63]`
Mówca: **Narrator**
> "She took a quick look around before proceeding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[64]`
Mówca: **Lucita Azaro**
> ""I'm merely presenting the facts, Your Majesty. It's unusual for someone in Pabel's position to be absent for such a long period.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[65]`
Mówca: **Lucita Azaro**
> ""As you know, it is my duty to explore every possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just because he was unaccounted for doesn't mean he had anything to do with my father's death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unaccounted for? Please explain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[68]`
Mówca: **Lucita Azaro**
> ""During the time leading up to Valero's death, there was a significant period when he couldn't be accounted for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[66]`
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure there's a reasonable explanation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds very un-Pabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[71]`
Mówca: **Lucita Azaro**
> ""He has access to the inner workings of the palace, which made him a person of interest -- a detail that couldn't be overlooked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[72]`
Mówca: **Narrator**
> "She paused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[73]`
Mówca: **Narrator**
> "He paused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[77]`
Mówca: **Lucita Azaro**
> ""Further investigation, however, revealed that Pabel had a solid alibi. His whereabouts during that time can be completely accounted for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[872]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What aren't you telling me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[79]`
Mówca: **Narrator**
> "Lucita gave a slight bow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[80]`
Mówca: **Narrator**
> "Lucita bowed and bid me good day before she turned and left my side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_PromisedDate == true && RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_PromisedDate == true && RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_PromisedDate"] == true  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_PromisedDate == true && RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_PromisedDate"] == true  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that all? That doesn't prove he had a hand in anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were right to come to me, however, we need something more concrete before jumping to conclusions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I was correct in believing my father's untimely end was no accident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That quickly? Tell me more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An eyewitness? What led you to find that out?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If this information is inaccurate in any way, there will  be hell to pay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is a lot to process. I'm having a hard time believing any of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My God... A Dastnurist service? How can this be?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectSal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectSal == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectSal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_SuspectSal == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectSal"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want to hear about what you found on the Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[96]`
Mówca: **Lucita Azaro**
> ""Your Majesty, multiple sources have confirmed to me that the Grand Wiseman visited the king's chambers the night of his death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Lucita Azaro**
> ""In fact, at that time he was consulting privately with the King on a near-nightly basis.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Makes sense. He had plenty to atone for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[99]`
Mówca: **Lucita Azaro**
> ""What's interesting is that aside from those meetings, witnesses describe your father's behavior as no more religious than usual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Lucita Azaro**
> ""He was even skipping services some weeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]`
  - -> `[827]`
  - -> `[828]`
  - -> `[833]`

### Węzeł `[101]`
Mówca: **Lucita Azaro**
> ""Yes, however, it's unusual for someone in Pabel's position to remain absent for an extended duration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[102]`
Mówca: **Lucita Azaro**
> ""I'm sure. But for an individual in Pabel's position to be away for such a prolonged period raised questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[103]`
Mówca: **Lucita Azaro**
> ""As you know, to have someone of his status go missing for such an extended duration would raise suspicions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Lucita Azaro**
> ""Especially with Pabel's knowledge of the inner workings of the palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Lucita Azaro**
> ""Could his absence be a coincidence? Sure. But it was something I couldn't overlook.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[106]`
Mówca: **Lucita Azaro**
> ""He has access to the palace's internal operations, which made him a noteworthy figure in my inquiry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Lucita Azaro**
> ""While it might be coincidental, it was a detail we couldn't ignore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[108]`
Mówca: **Lucita Azaro**
> ""He possesses knowledge of the palace's internal workings, which rendered him a significant figure in my investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How wise of my father. I hope he found the serenity he was seeking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father turned towards God... and away from everyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[111]`
Mówca: **Lucita Azaro**
> ""It's not surprising. God forgives where humans don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Suspects Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectHugo == true || RiziaDLC.Turn05_MurderInvest_SuspectSal == true || 
RiziaDLC.Turn05_MurderInvest_SuspectTitus == true || RiziaDLC.Turn05_MurderInvest_SuspectLucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectHugo == true || RiziaDLC.Turn05_MurderInvest_SuspectSal == true || 
RiziaDLC.Turn05_MurderInvest_SuspectTitus == true || RiziaDLC.Turn05_MurderInvest_SuspectLucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true  or  Variable["RiziaDLC.Turn05_MurderInvest_SuspectSal"] == true  or  
Variable["RiziaDLC.Turn05_MurderInvest_SuspectTitus"] == true  or  Variable["RiziaDLC.Turn05_MurderInvest_SuspectLucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_SuspectHugo == true || RiziaDLC.Turn05_MurderInvest_SuspectSal == true || 
RiziaDLC.Turn05_MurderInvest_SuspectTitus == true || RiziaDLC.Turn05_MurderInvest_SuspectLucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true  or  Variable["RiziaDLC.Turn05_MurderInvest_SuspectSal"] == true  or  
Variable["RiziaDLC.Turn05_MurderInvest_SuspectTitus"] == true  or  Variable["RiziaDLC.Turn05_MurderInvest_SuspectLucita"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Here are the next steps for your investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[863]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo is obviously our primary suspect, so focus your investigation on him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Discreetly continue your investigation into Titus. He has eyes and ears everywhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This investigation has gone as far as it can go. Cease all further efforts, effective immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hate to say it, but keep looking into Sal. There's more to the Grand Wiseman than he's letting on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep digging into Sal. There's more to the Wiseman than he's letting on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[125]`
Mówca: **Lucita Azaro**
> ""Yes, Your Majesty. I'll get my stealthiest agents on the case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[126]`
Mówca: **Lucita Azaro**
> ""Very good, Your Majesty. Rest assured, I will get to the bottom of this as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[127]`
Mówca: **Lucita Azaro**
> ""Very well. But for the record, I still believe the actions of our suspects warrant further scrutiny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`
  - -> `[156]`

### Węzeł `[128]`
Mówca: **Lucita Azaro**
> ""Consider it already done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Suspects Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectEstela = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectHugo = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Suspect Sal Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had a funny feeling about that Golden Guardsman. There was something about him that never sat right with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If what you're saying is true, this angers me to no end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectTitus = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectTitus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[136]`
Mówca: **Narrator**
> "I didn't want to think about what would happen if Titus' suspicions were proven right."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[137]`
Mówca: **Lucita Azaro**
> ""Investigation aside... I would humbly remind you of that date you owe me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[138]`
  - -> `[140]`
  - -> `[868]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still haven't found a setting befitting the beauty and majesty of the Duchess of House Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The King of Rizia has no time for such frivolities. And neither do you, Duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I haven't forgotten. But we've both been busy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[141]`
Mówca: **Lucita Azaro**
> ""Yes... of course. I'll look for something that fits into both of our schedules.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Narrator**
> "She flashed a suggestive smile as she left the chambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[143]`
Mówca: **Lucita Azaro**
> ""Leave that to me, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[144]`
Mówca: **Lucita Azaro**
> ""I'm still looking forward to the day when we're not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[145]`
Mówca: **Narrator**
> "Now alone, my thoughts, once again, returned to the investigation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[146]`
Mówca: **Narrator**
> "I assured myself that investigating Lucita was the right course of action."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateNoone = true; RiziaDLCSupport.Journal_Turn05_Security_InvestigateNoone = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateNoone"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Security_InvestigateNoone"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateSal = true; RiziaDLCSupport.Journal_Turn05_Security_InvestigateSal = true;
RiziaDLC.PoisonInvestigation_Continues = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Security_InvestigateSal"] = true;
Variable["RiziaDLC.PoisonInvestigation_Continues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateSal = true; RiziaDLCSupport.Journal_Turn05_Security_InvestigateSal = true;
RiziaDLC.PoisonInvestigation_Continues = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Security_InvestigateSal"] = true;
Variable["RiziaDLC.PoisonInvestigation_Continues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateTitus = true; RiziaDLCSupport.Journal_Turn05_Security_InvestigateTitus = true;
RiziaDLC.PoisonInvestigation_Continues = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateTitus"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Security_InvestigateTitus"] = true;
Variable["RiziaDLC.PoisonInvestigation_Continues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateHugo = true; RiziaDLCSupport.Journal_Turn05_Security_InvestigateHugo = true;
RiziaDLC.PoisonInvestigation_Continues = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Security_InvestigateHugo"] = true;
Variable["RiziaDLC.PoisonInvestigation_Continues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've already uncovered enough unpleasant secrets about the people around me. I'd rather not learn more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll keep all of what you said in mind. But I don't see grounds for a full-blown investigation into any of these suspects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For the record, I don't. My father was an old, sick man. That's all there is to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Investigate Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateTitus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateTitus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateTitus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_InvestigateTitus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateTitus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[164]`
Mówca: **Narrator**
> "If he was to remain my bodyguard, I wanted to make sure he had no skeletons in his closet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Narrator**
> "I assured myself that investigating Titus was the right course of action."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[166]`
Mówca: **Narrator**
> "I didn't want to think about what would happen if Lucita's suspicions were proven right?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateSal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateSal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_InvestigateSal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Narrator**
> "I took no pleasure in it, but I was duty-bound to dispense God's justice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[174]`
Mówca: **Narrator**
> "But it had to be done."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Narrator**
> "I assured myself that investigating Sal was the right course of action."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[176]`
Mówca: **Narrator**
> "And if my suspicions turned out to be true, especially regarding a man of faith, it begged the question... who could I trust?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[177]`
Mówca: **Narrator**
> "I assured myself that halting the investigation was the right thing to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Narrator**
> "I was becoming as paranoid as my father. For the sake of my own well-being, it had to stop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[917]`

### Węzeł `[179]`
Mówca: **Titus Gordion**
> ""Very good, Your Majesty. I'll work diligently to uncover the truth as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[180]`
Mówca: **Titus Gordion**
> ""Very well. For the record, I still believe the actions of our suspects warrant further scrutiny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`
  - -> `[156]`

### Węzeł `[181]`
Mówca: **Titus Gordion**
> ""Consider it handled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Titus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Titus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Titus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Titus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[194]`
Mówca: **Narrator**
> "Titus bowed and bid me good day before he turned and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[196]`
Mówca: **Titus Gordion**
> ""Allow me to begin by stating that I've made significant headway in identifying potential culprits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[86]`
  - -> `[4]`

### Węzeł `[197]`
Mówca: **Titus Gordion**
> ""Regrettably, yes. Multiple individuals raised strong suspicions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[198]`
Mówca: **Titus Gordion**
> ""My initial list of suspects comprised five individuals. Lucita Azaro, Grand Wiseman Ignacius, your butler, your uncle, and your mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[9]`
  - -> `[8]`

### Węzeł `[199]`
Mówca: **Narrator**
> "Titus discreetly looked around as if making sure there was no one else with us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[200]`
Mówca: **Titus Gordion**
> ""Starting with whom?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[213]`
Mówca: **Lucita Azaro**
> ""Yes, it seems you were right after all. And I believe I've narrowed it down to a handful of possible suspects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[214]`
Mówca: **Titus Gordion**
> ""That appears to be the case. I've narrowed it down to a handful of possible suspects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[215]`
Mówca: **Lucita Azaro**
> ""I've identified several individuals who initially raised significant suspicions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Titus Gordion**
> ""I've pinpointed several individuals who initially aroused considerable suspicion and warranted closer examination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[746]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Titus Gordion**
> ""Presumably, you tasked me with the investigation because I'm not under suspicion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[13]`
  - -> `[12]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Titus Gordion**
> ""Sir, our investigation has uncovered some intriguing findings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Titus Gordion**
> ""The Queen Mother was at dinner that night. Later, as I personally witnessed, she opened the door to your father's chambers and immediately alerted the Golden Guard that he was unconscious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[916]`

### Węzeł `[232]`
Mówca: **Lucita Azaro**
> ""It certainly does. That said, you might be shocked to learn the nature of her secret outing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Titus Gordion**
> ""It certainly does. As for the nature of her whereabouts, you might be surprised to learn that she was attending a religious service just outside the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[237]`
Mówca: **Lucita Azaro**
> ""Not so fast, Your Majesty. This may come as a shock, but as it happens, she was attending a religious service just outside the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Titus Gordion**
> ""That depends on how you look at it. This may come as a surprise, but as it happens, she was attending a religious service just outside the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[242]`
Mówca: **Lucita Azaro**
> ""This may come as a shock, but it turns out, she was attending a clandestine religious service just outside the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[246]`
Mówca: **Titus Gordion**
> ""This may come as a surprise, but it turns out, she was attending a religious service just outside the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[247]`
Mówca: **Lucita Azaro**
> ""We managed to find credible eyewitnesses at the Dastnurist archsanctuary that night who can verify it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[36]`
  - -> `[480]`
  - -> `[486]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[251]`
Mówca: **Titus Gordion**
> ""One of my Golden Guards, who was assigned to protect her, confirmed it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`
  - -> `[36]`
  - -> `[480]`
  - -> `[486]`

### Węzeł `[252]`
Mówca: **Lucita Azaro**
> ""It's no joke. Credible eyewitnesses were present at the archsanctuary that night who can verify it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[36]`
  - -> `[480]`
  - -> `[486]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Titus Gordion**
> ""It's no joke, sir. One of my Golden Guards, who was assigned to protect her, confirmed it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`
  - -> `[36]`
  - -> `[480]`
  - -> `[486]`

### Węzeł `[257]`
Mówca: **Lucita Azaro**
> ""All I know is that multiple eyewitnesses at the Dastnurist archsanctuary that night can verify it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[36]`
  - -> `[480]`
  - -> `[486]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Titus Gordion**
> ""All I know is that one of my Golden Guards, who was assigned to protect her, confirmed it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`
  - -> `[36]`
  - -> `[480]`
  - -> `[486]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Dastnurity aside, it's a relief to hear she's no longer a suspect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sure, but it still doesn't excuse her attendance at a Dastnurist gathering. It's an affront to our faith!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your slow approach to sharing crucial information is frustrating. Get to the point faster next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I suppose I'll have to find another suspect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[275]`
Mówca: **Lucita Azaro**
> ""Needless to say, this proves your mother had an alibi, and had nothing to do with your father's death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`
  - -> `[271]`
  - -> `[499]`
  - -> `[496]`

### Węzeł `[276]`
Mówca: **Titus Gordion**
> ""Needless to say, this establishes an alibi for your mother -- that she had no involvement in your father's death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`
  - -> `[271]`
  - -> `[499]`
  - -> `[496]`

### Węzeł `[277]`
Mówca: **Lucita Azaro**
> ""Of all the individuals I've been looking into, your Uncle Hugo stands out the most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]`

### Węzeł `[281]`
Mówca: **Titus Gordion**
> ""After supper on the night Valero died, His Grace accompanied the King to his chambers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]`

### Węzeł `[282]`
Mówca: **Lucita Azaro**
> ""After supper on the night Valero died, His Grace accompanied the King to his chambers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]`

### Węzeł `[283]`
Mówca: **Lucita Azaro**
> ""I agree completely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[287]`
Mówca: **Titus Gordion**
> ""I share your sentiment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[288]`
Mówca: **Lucita Azaro**
> ""Believe it or not, but facts are facts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[292]`
Mówca: **Titus Gordion**
> ""I only present the facts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[293]`
Mówca: **Lucita Azaro**
> ""Forgive my bluntness, but what more do you need? We must get to the bottom of what happened between the two of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Titus Gordion**
> ""I believe that such behavior is enough to warrant further scrutiny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[298]`
Mówca: **Lucita Azaro**
> ""If we keep pursuing this lead, we will get them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[302]`
Mówca: **Titus Gordion**
> ""If we continue our investigation, we will deliver them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Lucita Azaro**
> ""Given the severity of accusing the Grand Vizier of murder, I wanted to inform you first before proceeding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[28]`
  - -> `[85]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Titus Gordion**
> ""Given the potential uproar from accusing the Grand Vizier of murder, I wanted to inform you before proceeding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[28]`
  - -> `[85]`

### Węzeł `[308]`
Mówca: **Lucita Azaro**
> ""There's nothing unusual about that fact.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[913]`

### Węzeł `[309]`
Mówca: **Lucita Azaro**
> ""Yes. He stuck to His Majesty like glue, much as he currently sticks to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[913]`

### Węzeł `[310]`
Mówca: **Lucita Azaro**
> ""Titus guarded your father's quarters almost every night. Without fail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[913]`

### Węzeł `[311]`
Mówca: **Lucita Azaro**
> ""It is, which raises questions about his loyalty and the circumstances surrounding the king's demise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[312]`
Mówca: **Lucita Azaro**
> ""For half an hour?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[313]`
Mówca: **Lucita Azaro**
> ""The other guardsman claims nothing happened. But he could have been covering for his colleague...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[314]`
Mówca: **Lucita Azaro**
> ""Your admiration of Captain Gordion is notable, but our duty sometimes requires us to question even the most loyal among us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[315]`
Mówca: **Lucita Azaro**
> ""I understand your reservations, but my duty is to uncover the truth, no matter how uncomfortable it may be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[316]`
Mówca: **Lucita Azaro**
> ""I understand. But my responsibility is to unveil the truth, no matter how unsettling it might be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[317]`
Mówca: **Lucita Azaro**
> ""Yes. We proceed with caution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[318]`
Mówca: **Lucita Azaro**
> ""I've had my reservations about him as well. It's always best to trust your instincts in such matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[319]`
Mówca: **Lucita Azaro**
> ""I share your frustration. If these allegations hold up, it's a betrayal that none of us could have foreseen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Titus Gordion**
> ""Your Majesty, I myself admitted the Grand Wiseman into the king's chambers the night of his death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[324]`
Mówca: **Titus Gordion**
> ""I thought nothing of it at the time. The two of them had been consulting privately on a near-nightly basis.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[825]`

### Węzeł `[325]`
Mówca: **Titus Gordion**
> ""Religion is often a source of comfort to those who feel abandoned by everything and everyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`
  - -> `[328]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Titus Gordion**
> ""What's interesting is that aside from those meetings, witnesses describe your father's behavior as no more religious than usual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[336]`
Mówca: **Titus Gordion**
> ""He was even skipping services some weeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]`
  - -> `[827]`
  - -> `[828]`
  - -> `[833]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[340]`
Mówca: **Titus Gordion**
> ""As you know, I've been tasked with exploring every possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[341]`
Mówca: **Titus Gordion**
> ""Prior to Valero's passing, there was an extended period during which his movements couldn't be traced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[66]`
  - -> `[69]`
  - -> `[70]`

### Węzeł `[342]`
Mówca: **Titus Gordion**
> ""Having someone of his status go missing for such an extended duration indeed raises suspicions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[343]`
Mówca: **Titus Gordion**
> ""I'm merely presenting the facts, sir. It's unusual for someone in Pabel's position to be absent for such a long time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[347]`
Mówca: **Titus Gordion**
> ""Yes, although it's uncommon for someone in Pabel's position to be absent for an extended period...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`
  - -> `[350]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`
  - -> `[353]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[357]`
Mówca: **Titus Gordion**
> ""I'm sure, but it's unusual for someone in Pabel's position to be absent for such an extended period. It raised concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[358]`
Mówca: **Titus Gordion**
> ""Having access to the inner workings of the palace elevated his importance in my investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[359]`
Mówca: **Titus Gordion**
> ""Because of this, it was a detail that couldn't be ignored.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[360]`
Mówca: **Titus Gordion**
> ""He possesses knowledge of the palace's internal workings, which makes him a significant figure in my investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[361]`
Mówca: **Titus Gordion**
> ""His access to the inner workings of the palace made him a person of interest. It was a detail that couldn't be overlooked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[362]`
Mówca: **Titus Gordion**
> ""And with Pabel's grasp of the palace's internal workings, this took on added significance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[363]`
Mówca: **Titus Gordion**
> ""It's possible that his absence during that time was a mere coincidence. However, it's something that couldn't be overlooked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[364]`
Mówca: **Titus Gordion**
> ""Further investigation, however, revealed that your butler had a solid alibi. His whereabouts during that time can be completely accounted for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[873]`

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's hear why you suspect Lucita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectLucita == false && RiziaDLC.PoisonInvestigator_Titus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectLucita == false && RiziaDLC.PoisonInvestigator_Titus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectLucita"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_SuspectLucita == false && RiziaDLC.PoisonInvestigator_Titus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectLucita"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[369]`
Mówca: **Titus Gordion**
> ""My suspicions stem from Lucita allegedly visiting King Valero's chambers on the night of his passing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`
  - -> `[370]`
  - -> `[374]`

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see... Go on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[371]`
Mówca: **Titus Gordion**
> ""When I returned, he informed me nothing out of the ordinary had occurred. But pressed for details during this investigation, he admitted he had allowed Duchess Azaro access to the room for a brief period.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[648]`
  - -> `[757]`
  - -> `[651]`

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're implying they were secret lovers or something?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[373]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Allegedly? You were guarding my father's chambers. Wouldn't you know if she visited?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[374]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, what of it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What was she doing in there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[376]`
Mówca: **Titus Gordion**
> ""I would never suggest such a thing. However...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[377]`
Mówca: **Titus Gordion**
> ""When I questioned the guardsman, he claimed Lucita had provided him with an order signed by your father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[378]`
  - -> `[380]`

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An order? What for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you believed him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If true, we need to verify its authenticity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[381]`
Mówca: **Titus Gordion**
> ""I suspect she may have been carrying a correspondence letter, but I cannot confirm it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Titus Gordion**
> ""I have no reason not to. Being a Golden Guardsman means maintaining the highest level of integrity and loyalty. But as I was saying...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`

### Węzeł `[383]`
Mówca: **Titus Gordion**
> ""When we searched your father's chambers later, we found no evidence of a summons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`
  - -> `[384]`
  - -> `[386]`
  - -> `[659]`

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is deeply troubling. What could Lucita be hiding?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have a hard time wrapping my head around Lucita doing something so drastic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I always suspected that, when it came to the throne, House Azaro was out for blood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`

### Węzeł `[387]`
Mówca: **Titus Gordion**
> ""My thoughts exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[388]`
Mówca: **Titus Gordion**
> ""That's what concerned me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Suspects Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[390]`
Mówca: **Titus Gordion**
> ""People can surprise us, for better or for worse. In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`

### Węzeł `[391]`
Mówca: **Titus Gordion**
> ""That's a question I hope to find out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`

### Węzeł `[392]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep looking into Lucita's motivation. You might be onto something there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateLucita = true; RiziaDLCSupport.Journal_Turn05_Security_InvestigateLucita = true;
RiziaDLC.PoisonInvestigation_Continues = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Security_InvestigateLucita"] = true;
Variable["RiziaDLC.PoisonInvestigation_Continues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[394]`
Mówca: **Titus Gordion**
> ""Considered it already handled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectSal = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectSal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[396]`
Mówca: **Narrator**
> "Alone once again, my thoughts returned to the investigation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`
  - -> `[399]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[399]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[400]`
Mówca: **Titus Gordion**
> ""I meant no offense, sir. You told me to investigate everyone present at the palace during that time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[13]`
  - -> `[12]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`
  - -> `[403]`

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[403]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[404]`
Mówca: **Titus Gordion**
> ""Yes, that's what I'm here to talk about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[13]`
  - -> `[12]`

### Węzeł `[405]`
Mówca: **Lucita Azaro**
> ""Trust can be a double-edged sword, and it's disheartening when broken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[406]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I said nothing, silently waiting for them to continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[407]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita. To what do I owe this pleasure?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[408]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes? Something on your mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[409]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please tell me you're here because you have information on my father's passing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[410]`
Mówca: **Lucita Azaro**
> ""Yes, I have, in fact, made significant progress on the investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, do tell! I'm eager to know what you've uncovered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[412]`
Mówca: **Lucita Azaro**
> ""Only that I may have some information regarding your father's demise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Really? In that case, let's hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[414]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, what are you waiting for? Spit it out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[415]`
Mówca: **Lucita Azaro**
> ""'This pleasure' happens to be the information you requested about your father's death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`

### Węzeł `[416]`
Mówca: **Narrator**
> "And the city's distant lights shimmered, a testament to life continuing beyond the palace walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`

### Węzeł `[417]`
Mówca: **Narrator**
> "His presence on the balcony hinted at an urgent matter, a reminder that, as a monarch, even moments of solitude could be fleeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[418]`
Mówca: **Titus Gordion**
> ""Good evening, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`
  - -> `[419]`
  - -> `[421]`
  - -> `[422]`

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you doing lurking in the dark?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To what do I owe the pleasure, Captain?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[421]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, it's you. Is everything all right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[422]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you have something to report, make it quick.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]`

### Węzeł `[423]`
Mówca: **Titus Gordion**
> ""The one concerning His Majesty, King Valero.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`
  - -> `[413]`
  - -> `[411]`
  - -> `[406]`

### Węzeł `[424]`
Mówca: **Titus Gordion**
> ""I'm here to discuss that *personal matter* you asked me to look into.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[425]`
Mówca: **Lucita Azaro**
> ""A Dastnurist service.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[452]`
  - -> `[455]`

### Węzeł `[426]`
Mówca: **Lucita Azaro**
> ""I didn't think much of it until I stumbled across the name and address of a Dastnurist sanctuary handwritten on the inside cover of one such book.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[427]`
Mówca: **Lucita Azaro**
> ""The investigation into her whereabouts began when Dastnurist literature was found hidden in her bedchamber during a secret search.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[428]`
Mówca: **Lucita Azaro**
> ""My curiosity piqued, I thoroughly investigated the events of that night by gathering records, logs, cross-referencing attendance lists, and witness accounts to solve the puzzle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[429]`
Mówca: **Titus Gordion**
> ""But it wasn't a Wruhecist service. It was a Dastnurist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[452]`
  - -> `[455]`

### Węzeł `[430]`
Mówca: **Titus Gordion**
> ""My guardsmen don't make mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]`

### Węzeł `[431]`
Mówca: **Titus Gordion**
> ""Given that Wruhecism is not only a faith but a state institution, I understand the gravity of this contradiction. However...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`
  - -> `[434]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]`

### Węzeł `[435]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Looks like our next family chat is about to get interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[436]`
Mówca: **Lucita Azaro**
> ""It could lead to an even more interesting discussion, when I tell you where she really was...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`
  - -> `[439]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[439]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[440]`
Mówca: **Titus Gordion**
> ""It could lead to an even more interesting discussion, when I disclose her actual whereabouts...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[441]`
Mówca: **Lucita Azaro**
> ""...attending a clandestine Dastnurist religious service just outside the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[452]`
  - -> `[458]`
  - -> `[469]`

### Węzeł `[442]`
Mówca: **Titus Gordion**
> ""...attending a Dastnurist religious service just outside the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[452]`
  - -> `[458]`
  - -> `[469]`

### Węzeł `[443]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay, I'm listening...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`
  - -> `[446]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[446]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]`

### Węzeł `[447]`
Mówca: **Lucita Azaro**
> ""Brace yourself, but it turns out, she was attending a secret religious service just outside the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`
  - -> `[450]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[451]`
Mówca: **Titus Gordion**
> ""As it happens, she was participating in a covert religious gathering just outside the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[452]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`
  - -> `[454]`

### Węzeł `[453]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[454]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]`

### Węzeł `[455]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`
  - -> `[457]`

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, that's certainly not what I expected to hear. You can verify the accuracy of this information?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[459]`
Mówca: **Lucita Azaro**
> ""Without question. Multiple eyewitnesses at the Dastnurist archsanctuary that night can verify it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[36]`
  - -> `[480]`
  - -> `[486]`

### Węzeł `[460]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`
  - -> `[462]`

### Węzeł `[461]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[462]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[463]`
Mówca: **Titus Gordion**
> ""Absolutely. One of my Golden Guards, who was assigned to protect her, can confirm it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`
  - -> `[36]`
  - -> `[480]`
  - -> `[486]`

### Węzeł `[464]`
Mówca: **Lucita Azaro**
> ""Which is why I came to you as soon as I could.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[465]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`
  - -> `[467]`

### Węzeł `[466]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[467]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[468]`
Mówca: **Titus Gordion**
> ""All the more reason I thought it necessary to brief you as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must admit I'm quite surprised by this revelation. It could spark quite a scandal if it became public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[470]`
Mówca: **Lucita Azaro**
> ""She was attending Dastnurist religious service just outside the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[452]`
  - -> `[455]`
  - -> `[458]`
  - -> `[469]`

### Węzeł `[471]`
Mówca: **Titus Gordion**
> ""Specifically, a Dastnurist religious service.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[452]`
  - -> `[455]`
  - -> `[458]`
  - -> `[469]`

### Węzeł `[472]`
Mówca: **Lucita Azaro**
> ""Credible eyewitnesses were present at the archsanctuary that night who can verify her attendance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[480]`
  - -> `[486]`

### Węzeł `[473]`
Mówca: **Titus Gordion**
> ""One of my Golden Guards, who was assigned to protect her, confirmed it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`
  - -> `[36]`
  - -> `[480]`
  - -> `[486]`

### Węzeł `[474]`
Mówca: **Titus Gordion**
> ""The information is indeed accurate. The guardsman who accompanied her is among my most trustworthy subordinates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]`

### Węzeł `[475]`
Mówca: **Titus Gordion**
> ""I know how disconcerting this news might be, especially considering it goes against the official state religion of Wruhecism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[476]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And how reliable is this Golden Guardsman of yours?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[477]`
Mówca: **Lucita Azaro**
> ""No mistake. The information is solid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[478]`
Mówca: **Lucita Azaro**
> ""I was first made aware of her beliefs when we conducted a search of her bedchamber, where hidden Dastnurist literature was found.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[479]`
Mówca: **Titus Gordion**
> ""The individual of which I speak is very reliable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]`

### Węzeł `[480]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`
  - -> `[482]`

### Węzeł `[481]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[482]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]`

### Węzeł `[483]`
Mówca: **Lucita Azaro**
> ""The gathered information has undergone rigorous scrutiny. I wouldn't approach you with anything less.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[484]`
Mówca: **Lucita Azaro**
> ""I understand how disconcerting this news might be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[485]`
Mówca: **Titus Gordion**
> ""However, the information is reliable. The guardsman who was with her is one of my most dependable subordinates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[486]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`
  - -> `[488]`

### Węzeł `[487]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[488]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[489]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a man of faith, forgive me when I say, I have a hard time relying solely on that... faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[490]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`
  - -> `[492]`

### Węzeł `[491]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[492]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[493]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sure, but it still doesn't excuse her attendance at a Dastnurist gathering!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[494]`
Mówca: **Titus Gordion**
> ""Considering her upbringing in Zille, where Dastnurity is the prevailing religion, this revelation is quite understandable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[495]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well then, I guess there's no need to place Mother in the royal dungeon. I suppose I'll have to find another suspect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`
  - -> `[498]`

### Węzeł `[497]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[498]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[499]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`
  - -> `[501]`

### Węzeł `[500]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[502]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your meticulous approach to sharing important information is valued, but please aim for more concise summaries in future discussions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[503]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The plot thickens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[504]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hmm, so he won't be the star of our treasonous play after all. The plot thickens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[505]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why didn't you say so in the first place?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[506]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, that is good news. You can lead with that next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[507]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`
  - -> `[509]`

### Węzeł `[508]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_FunnyKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[509]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_FunnyKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[510]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`
  - -> `[512]`

### Węzeł `[511]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[512]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[513]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The truth always prevails, as our faith teaches us. Pabel's innocence is a testament to this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[514]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The truth always prevails. Pabel's innocence is a testament to this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[515]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`
  - -> `[517]`

### Węzeł `[516]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[517]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[518]`
Mówca: **Lucita Azaro**
> ""Indeed, it's heartening to see the truth come to light. Pabel can finally put this behind him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[519]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`
  - -> `[521]`

### Węzeł `[520]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[521]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[522]`
Mówca: **Titus Gordion**
> ""Indeed. The truth always prevails.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[523]`
Mówca: **Lucita Azaro**
> ""My apologies for the delay, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[524]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`
  - -> `[526]`

### Węzeł `[525]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[526]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[527]`
Mówca: **Titus Gordion**
> ""My apologies for the delay, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[528]`
Mówca: **Lucita Azaro**
> ""Of course, Your Majesty. We're keeping our eyes on the unfolding drama.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[529]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`
  - -> `[531]`

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[532]`
Mówca: **Titus Gordion**
> ""I'm pleased to have put your suspicion of Pabel to rest, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[533]`
Mówca: **Lucita Azaro**
> ""Well, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[874]`

### Węzeł `[534]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`
  - -> `[536]`

### Węzeł `[535]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[536]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[537]`
Mówca: **Titus Gordion**
> ""Well, sir, in the course of charting out Mr. Adria's exact activities on that night, my team made a rather... interesting discovery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[895]`
  - -> `[892]`
  - -> `[540]`

### Węzeł `[538]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's ridiculous. You will tell me at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[882]`

### Węzeł `[539]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why not? Was he involved in illegal activity?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[876]`

### Węzeł `[540]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right, let's hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[893]`

### Węzeł `[541]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectPabel = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[542]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Suspects Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[543]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`
  - -> `[545]`

### Węzeł `[544]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[899]`

### Węzeł `[545]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[898]`

### Węzeł `[546]`
Mówca: **Lucita Azaro**
> "“After extensive interviews with palace staff, it was determined that Pabel was in the wine cellar the entire time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]`

### Węzeł `[547]`
Mówca: **Titus Gordion**
> "“After extensive interviews with palace staff, it was determined that Pabel spent an inordinate amount of time in the wine cellar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]`

### Węzeł `[548]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That old dog… Good for him! Who was the lucky lady?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[549]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If my butler had a secret lover, I would know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`

### Węzeł `[550]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How very unprofessional -- not to mention, inappropriate. With whom was he engaged in this… 'rendezvous?'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`

### Węzeł `[551]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`
  - -> `[553]`

### Węzeł `[552]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[553]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[554]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`
  - -> `[556]`

### Węzeł `[555]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[556]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[557]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In the wine cellar? With whom was he engaged in this… 'rendezvous?'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`

### Węzeł `[558]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My faith guides me to condemn such actions. I'm highly disappointed in Pabel's behavior.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[559]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm highly disappointed in Pabel's behavior.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[560]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel and I are old friends, so I'll bring this up with him myself. No need to drag the law into it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[561]`
Mówca: **Lucita Azaro**
> ""More like lucky gentleman, if you catch my meaning...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`

### Węzeł `[562]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`
  - -> `[564]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[565]`
Mówca: **Titus Gordion**
> ""Actually, sir, he wasn't with a woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`

### Węzeł `[566]`
Mówca: **Lucita Azaro**
> ""I have to confess, I had a feeling about Pabel since our trip to Qalus. I'm not surprised at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`

### Węzeł `[567]`
Mówca: **Titus Gordion**
> ""We didn't turn up any conclusive evidence of what your butler and the courier were doing together. So this is all pure speculation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]`

### Węzeł `[568]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's keep this between us to avoid it from becoming public and causing a scandal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`

### Węzeł `[569]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A pervert residing in front of my very nose. Keep an eye on him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[570]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep an eye on him. The last thing I need is my butler flaunting his criminal lifestyle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[571]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`
  - -> `[573]`

### Węzeł `[572]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[573]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[574]`
Mówca: **Lucita Azaro**
> ""I won’t tell anyone. You have my word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[575]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`
  - -> `[577]`

### Węzeł `[576]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[577]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[578]`
Mówca: **Titus Gordion**
> ""I won't disclose this to anyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[579]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`
  - -> `[581]`

### Węzeł `[580]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[581]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[582]`
Mówca: **Lucita Azaro**
> ""That's your prerogative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[583]`
Mówca: **Titus Gordion**
> ""Certainly, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[584]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`
  - -> `[586]`

### Węzeł `[585]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[586]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[587]`
Mówca: **Lucita Azaro**
> ""Very well, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[588]`
Mówca: **Titus Gordion**
> ""Very well, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[589]`
Mówca: **Lucita Azaro**
> ""In any case, Pabel is innocent -- of murdering His Majesty King Valero, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`

### Węzeł `[590]`
Mówca: **Titus Gordion**
> ""In any case, what we discovered about Pabel absolves him of any culpability in King Valero's death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`

### Węzeł `[591]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`
  - -> `[593]`

### Węzeł `[592]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`

### Węzeł `[593]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]`

### Węzeł `[594]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Suspects Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[595]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as it doesn't interfere with his duties, I don’t see an issue. Let's stay focused on the task at hand, please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[596]`
Mówca: **Lucita Azaro**
> ""You're right. Pabel's love life or lack thereof is not relevant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[597]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`
  - -> `[599]`

### Węzeł `[598]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[599]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`

### Węzeł `[600]`
Mówca: **Titus Gordion**
> ""Of course. We shouldn't lose sight of our main objective.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[601]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectPabel = true; RiziaDLC.Relations_Pabel_OutedToPlayer = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] = true;
Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[602]`
Mówca: **Lucita Azaro**
> ""A delivery person from Cantuavo vineyards who was dropping off casks of wine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`
  - -> `[614]`
  - -> `[613]`
  - -> `[918]`

### Węzeł `[603]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]`
  - -> `[605]`

### Węzeł `[604]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`

### Węzeł `[605]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[606]`
Mówca: **Titus Gordion**
> ""As it happens, it was a delivery person from Cantuavo vineyards who was dropping off casks of wine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`
  - -> `[614]`
  - -> `[613]`
  - -> `[918]`

### Węzeł `[607]`
Mówca: **Lucita Azaro**
> ""The other individual was supposedly a Cantuavo vineyards' delivery person dropping off wine casks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`
  - -> `[614]`
  - -> `[613]`
  - -> `[918]`

### Węzeł `[608]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`
  - -> `[610]`

### Węzeł `[609]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[610]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]`

### Węzeł `[611]`
Mówca: **Titus Gordion**
> ""The other person was supposedly a Cantuavo vineyards' delivery person dropping off wine casks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`
  - -> `[614]`
  - -> `[613]`
  - -> `[918]`

### Węzeł `[612]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’ll see to it that she’s reported to the Cantuavos for her indiscretion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[613]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Her heedless and disrespectful actions should be conveyed to the Cantuavos.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`

### Węzeł `[614]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She should be fired, immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[615]`
Mówca: **Lucita Azaro**
> ""Not 'her.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`

### Węzeł `[616]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`
  - -> `[618]`

### Węzeł `[617]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[618]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`

### Węzeł `[619]`
Mówca: **Titus Gordion**
> ""Actually, sir, the 'her' is a *he*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[902]`

### Węzeł `[620]`
Mówca: **Lucita Azaro**
> ""Not 'she.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`

### Węzeł `[621]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`
  - -> `[623]`

### Węzeł `[622]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`

### Węzeł `[623]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[624]`
Mówca: **Titus Gordion**
> ""Actually, sir, the 'she' is a *he*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[902]`

### Węzeł `[625]`
Mówca: **Lucita Azaro**
> ""He.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[901]`

### Węzeł `[626]`
Mówca: **Lucita Azaro**
> ""'He.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[901]`

### Węzeł `[627]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_OutedToPlayer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`
  - -> `[629]`

### Węzeł `[628]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_OutedToPlayer == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`

### Węzeł `[629]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_OutedToPlayer == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`
  - -> `[904]`

### Węzeł `[630]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What?! I had no idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`

### Węzeł `[631]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as Pabel didn't kill my father, I don't care what he was doing that night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`

### Węzeł `[632]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`

### Węzeł `[633]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, this just keeps getting better and better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`

### Węzeł `[634]`
Mówca: **Lucita Azaro**
> ""If this assignation occurred, it was with a courier from the Cantuavo vineyards. A man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[901]`

### Węzeł `[635]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`
  - -> `[637]`

### Węzeł `[636]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[637]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`

### Węzeł `[638]`
Mówca: **Titus Gordion**
> ""If this assignation occurred, it was with a courier from the Cantuavo vineyards. A male one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[902]`

### Węzeł `[639]`
Mówca: **Lucita Azaro**
> ""It was supposedly a man, by the way. A courier from the Cantuavo vineyards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[901]`

### Węzeł `[640]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`
  - -> `[642]`

### Węzeł `[641]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]`

### Węzeł `[642]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`

### Węzeł `[643]`
Mówca: **Titus Gordion**
> ""You might be surprised to know that it was a man. A courier from the Cantuavo vineyards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[902]`

### Węzeł `[644]`
Mówca: **Titus Gordion**
> ""As is my duty, I was standing guard outside your father's room that night, but departed for half an hour to attend a personal matter, leaving one of my guardsmen in charge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[645]`
Mówca: **Titus Gordion**
> ""Given her high rank in your cabinet and access to sensitive government information, her exact activities on that night should be ascertained as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]`

### Węzeł `[646]`
Mówca: **Titus Gordion**
> ""I can't attest to that. I'm only presenting what I've been able to gather.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]`

### Węzeł `[647]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do hope you're not suggesting they were doing something... impure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[648]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`
  - -> `[650]`

### Węzeł `[649]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]`

### Węzeł `[650]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[651]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you left your post while on duty? Not the best way to start your case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[652]`
Mówca: **Titus Gordion**
> ""And I take full responsibility for it. I can assure you that it was an exceptional circumstance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]`

### Węzeł `[653]`
Mówca: **Titus Gordion**
> ""But as I was saying...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[654]`
Mówca: **Titus Gordion**
> ""I suspect she may have been carrying a letter, but I cannot confirm its contents, recipient, or sender.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[655]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like a lot of speculation and no sustenance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[656]`
Mówca: **Titus Gordion**
> ""I'm only presenting what I've been able to gather.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]`

### Węzeł `[657]`
Mówca: **Titus Gordion**
> ""I had my suspicions that she might have been carrying letters, but I couldn't ascertain the sender, the recipients, or the contents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[658]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like a lot of speculation and no sustenance. I was expecting more from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[659]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`
  - -> `[661]`

### Węzeł `[660]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`

### Węzeł `[661]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`

### Węzeł `[662]`
Mówca: **Narrator**
> "On the palace balcony, I sought refuge from the relentless affairs of the state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]`

### Węzeł `[663]`
Mówca: **Narrator**
> "The grandeur of the night sky spread before me, stars punctuating the obsidian expanse like celestial jewels."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[664]`
Mówca: **Narrator**
> "Amid this tranquil backdrop, I found a brief respite from the responsibilities that weighed on my shoulders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`

### Węzeł `[665]`
Mówca: **Narrator**
> "It was during this peaceful interlude that Captain Gordion approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[666]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]`
  - -> `[668]`

### Węzeł `[667]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[668]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[669]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]`

### Węzeł `[670]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[671]`
Mówca: **Narrator**
> "It was during this peaceful interlude that Lucita approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]`

### Węzeł `[672]`
Mówca: **Narrator**
> "Her presence on the balcony was a reminder that, as a monarch, even moments of solitude could be fleeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[673]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]`

### Węzeł `[674]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Lucita Azaro");)*
- **Efekt (`userScript`):** `AddConversant("Lucita Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[675]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Relations_Lucita_PromisedDate)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`
  - -> `[677]`

### Węzeł `[676]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Relations_Lucita_PromisedDate)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true  or  Variable["RiziaDLC.Relations_Lucita_PromisedDate"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]`

### Węzeł `[677]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Relations_Lucita_PromisedDate))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true  or  Variable["RiziaDLC.Relations_Lucita_PromisedDate"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[678]`
Mówca: **Narrator**
> "The only question was whether she was here for an urgent matter or..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[679]`
Mówca: **Narrator**
> "...something else."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[680]`
Mówca: **Lucita Azaro**
> ""Good evening, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`
  - -> `[408]`
  - -> `[409]`

### Węzeł `[681]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Relations_Lucita_PromisedDate)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]`
  - -> `[683]`

### Węzeł `[682]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Relations_Lucita_PromisedDate)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true  or  Variable["RiziaDLC.Relations_Lucita_PromisedDate"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`

### Węzeł `[683]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Relations_Lucita_PromisedDate))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true  or  Variable["RiziaDLC.Relations_Lucita_PromisedDate"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`
  - -> `[413]`
  - -> `[411]`
  - -> `[406]`

### Węzeł `[684]`
Mówca: **Narrator**
> "Business only, it seemed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`
  - -> `[413]`
  - -> `[411]`
  - -> `[406]`

### Węzeł `[685]`
Mówca: **Titus Gordion**
> ""Everything's fine. No need to worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[686]`
Mówca: **Titus Gordion**
> ""Gladly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[687]`
Mówca: **Titus Gordion**
> ""I apologize if I startled you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[688]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.InvestigatePoisoning_NoPabel == false &&
RiziaDLC.Turn05_MurderInvest_SuspectPabel == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]`
  - -> `[690]`

### Węzeł `[689]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.InvestigatePoisoning_NoPabel == false &&
RiziaDLC.Turn05_MurderInvest_SuspectPabel == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false  and 
Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[690]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.InvestigatePoisoning_NoPabel == false &&
RiziaDLC.Turn05_MurderInvest_SuspectPabel == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false  and 
Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[691]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`
  - -> `[693]`

### Węzeł `[692]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Lucita_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[870]`

### Węzeł `[693]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Lucita_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[871]`

### Węzeł `[694]`
Mówca: **Narrator**
> "But if Titus' suspicions were true, it raised a significant question... whom in my inner circle could I trust?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[695]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]`
  - -> `[697]`

### Węzeł `[696]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]`

### Węzeł `[697]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[698]`
Mówca: **Narrator**
> "I took no pleasure in suspecting a member of my own family, but the evidence had been laid out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`

### Węzeł `[699]`
Mówca: **Narrator**
> "I assured myself that investigating Hugo was the right course of action."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]`

### Węzeł `[700]`
Mówca: **Narrator**
> "And if my suspicions turned out to be true, it begged the question... whom in my inner circle could I trust?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[701]`
Mówca: **Lucita Azaro**
> ""The scuttlebutt has it that he was having a secret rendezvous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`
  - -> `[551]`
  - -> `[554]`

### Węzeł `[702]`
Mówca: **Titus Gordion**
> "“Some suspect him of having a secret rendezvous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`
  - -> `[551]`
  - -> `[554]`

### Węzeł `[703]`
Mówca: **Lucita Azaro**
> ""This was months before your coronation. And the individual in question hasn't returned to the palace since.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]`

### Węzeł `[704]`
Mówca: **Titus Gordion**
> ""This occurred months before your coronation, and the individual in question hasn't returned to the palace since then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[705]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`
  - -> `[707]`

### Węzeł `[706]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]`

### Węzeł `[707]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`

### Węzeł `[708]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_Winery_DrinkingGamePabel)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]`
  - -> `[710]`

### Węzeł `[709]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_Winery_DrinkingGamePabel)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_Winery_DrinkingGamePabel"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[710]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn04_Winery_DrinkingGamePabel))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_Winery_DrinkingGamePabel"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]`

### Węzeł `[711]`
Mówca: **Lucita Azaro**
> ""I have to confess, I'm not surprised. Your butler is too dapper for his own good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`

### Węzeł `[712]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]`
  - -> `[714]`

### Węzeł `[713]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`

### Węzeł `[714]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]`

### Węzeł `[715]`
Mówca: **Narrator**
> "He looked me straight in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]`

### Węzeł `[716]`
Mówca: **Titus Gordion**
> ""But if we catch him in a similar act again, we'll ensure he is adequately punished for his crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`
  - -> `[723]`
  - -> `[571]`
  - -> `[595]`

### Węzeł `[717]`
Mówca: **Lucita Azaro**
> ""That said... we were unable to turn up any conclusive evidence of what he and the courier were doing in the cellar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[912]`

### Węzeł `[718]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]`
  - -> `[720]`

### Węzeł `[719]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]`

### Węzeł `[720]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]`

### Węzeł `[721]`
Mówca: **Narrator**
> "She looked me straight in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]`

### Węzeł `[722]`
Mówca: **Lucita Azaro**
> ""But if we catch him in a similar act again, you'll be notified right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`
  - -> `[723]`
  - -> `[571]`
  - -> `[595]`

### Węzeł `[723]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`
  - -> `[725]`

### Węzeł `[724]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[725]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]`

### Węzeł `[726]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to raise an alarm because of some palace scuttlebutt. I'll ask Pabel about this myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[727]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not in the palace? Well, if she wasn't here, then where was she?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[728]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Really? Wouldn't have guessed that Mother was still full of surprises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]`

### Węzeł `[729]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]`
  - -> `[731]`

### Węzeł `[730]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]`

### Węzeł `[731]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]`

### Węzeł `[732]`
Mówca: **Lucita Azaro**
> ""Speaking of surprises, you'll be interested in hearing where she really was...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[733]`
Mówca: **Titus Gordion**
> ""Speaking of surprises, you'll want to hear where she really was...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[734]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're kidding, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[735]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A Dastnurist service? How can this be?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[736]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A part of me hopes this information is inaccurate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[737]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_StateReligion_Wruhecism == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`
  - -> `[739]`

### Węzeł `[738]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_StateReligion_Wruhecism == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[739]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Law_StateReligion_Wruhecism == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]`

### Węzeł `[740]`
Mówca: **Titus Gordion**
> ""I understand how unsettling this might be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[741]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_StateReligion_Wruhecism == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]`
  - -> `[743]`

### Węzeł `[742]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Law_StateReligion_Wruhecism == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[743]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Law_StateReligion_Wruhecism == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]`

### Węzeł `[744]`
Mówca: **Titus Gordion**
> ""I understand how disconcerting this news might be. But...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[745]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectLucita = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectLucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[746]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.InvestigatePoisoning_NoPabel == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]`
  - -> `[748]`

### Węzeł `[747]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.InvestigatePoisoning_NoPabel == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[748]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.InvestigatePoisoning_NoPabel == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]`

### Węzeł `[749]`
Mówca: **Narrator**
> "Titus looked around discreetly as if making sure there was no one else with us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`

### Węzeł `[750]`
Mówca: **Titus Gordion**
> ""My initial list of suspects comprised four individuals. Lucita Azaro, Grand Wiseman Ignacius, your uncle, and your mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[9]`
  - -> `[8]`

### Węzeł `[751]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.InvestigatePoisoning_NoPabel == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]`
  - -> `[753]`

### Węzeł `[752]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.InvestigatePoisoning_NoPabel == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[753]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.InvestigatePoisoning_NoPabel == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`

### Węzeł `[754]`
Mówca: **Lucita Azaro**
> ""My initial list comprised four individuals: Captain Gordion, Grand Wiseman Ignacius, your uncle, and your mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[9]`

### Węzeł `[755]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? Please tell me you fired him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]`

### Węzeł `[756]`
Mówca: **Titus Gordion**
> ""Of course I did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]`

### Węzeł `[757]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]`
  - -> `[759]`

### Węzeł `[758]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_TyrantKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]`

### Węzeł `[759]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_TyrantKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]`

### Węzeł `[760]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""His head will roll for that blunder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]`

### Węzeł `[761]`
Mówca: **Titus Gordion**
> ""He has been dishonorably discharged from his duties, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]`

### Węzeł `[762]`
Mówca: **Titus Gordion**
> ""In his defense, he claimed that Lucita had shown him an official order signed by your father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[378]`
  - -> `[380]`

### Węzeł `[763]`
Mówca: **Titus Gordion**
> ""I don't truly believe your esteemed uncle would commit fratricide, but no stone must be left unturned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[764]`
Mówca: **Titus Gordion**
> ""I did not listen in to their conversation. But a maid who was on duty at the time claims she overheard snippets of an argument.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]`

### Węzeł `[765]`
Mówca: **Lucita Azaro**
> ""Your Golden Guardsman claims not to remember what they were talking about. But the maid who was on duty at the time says she overheard snippets of an argument.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]`

### Węzeł `[766]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An argument? About what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]`

### Węzeł `[767]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Dinner was hours before the time of death. How could Hugo have killed him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]`

### Węzeł `[768]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you saying Titus was lying?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]`

### Węzeł `[769]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Could this maid have been lying?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]`

### Węzeł `[770]`
Mówca: **Lucita Azaro**
> ""He could have slipped him a slow-acting poison. Either on the stairs or while escorting the King into his chambers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]`

### Węzeł `[771]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[772]`
  - -> `[773]`

### Węzeł `[772]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]`

### Węzeł `[773]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[775]`

### Węzeł `[774]`
Mówca: **Lucita Azaro**
> ""Hard to say. He may have thought it inappropriate to listen in on the Royal Family's conversations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]`

### Węzeł `[775]`
Mówca: **Titus Gordion**
> ""He could have slipped him a slow-acting poison. Either on the stairs or while escorting the King into his chambers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]`

### Węzeł `[776]`
Mówca: **Lucita Azaro**
> ""Apparently, the King shouted, 'He is not yet ready!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[781]`

### Węzeł `[777]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]`
  - -> `[779]`

### Węzeł `[778]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]`

### Węzeł `[779]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]`

### Węzeł `[780]`
Mówca: **Titus Gordion**
> ""Apparently, the King shouted out, 'He is not yet ready!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]`

### Węzeł `[781]`
Mówca: **Narrator**
> "She shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[782]`

### Węzeł `[782]`
Mówca: **Lucita Azaro**
> ""Which doesn't clear anything up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]`

### Węzeł `[783]`
Mówca: **Titus Gordion**
> ""I don't see why she would have been. Unless...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]`

### Węzeł `[784]`
Mówca: **Titus Gordion**
> ""Those are the only words she remembered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]`

### Węzeł `[785]`
Mówca: **Lucita Azaro**
> ""Captain Gordion claims to have witnessed no such thing. But a lot gets by him, it seems...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`

### Węzeł `[786]`
Mówca: **Titus Gordion**
> ""I personally witnessed no such thing. But there's a slim possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`

### Węzeł `[787]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Investigation_SuspectHugo_Lying == false && RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]`
  - -> `[789]`

### Węzeł `[788]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Investigation_SuspectHugo_Lying == false && RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Lying"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]`

### Węzeł `[789]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Investigation_SuspectHugo_Lying == false && RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Lying"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[790]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Investigation_SuspectHugo_Lying = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Lying"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]`

### Węzeł `[791]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Investigation_SuspectHugo_Argument == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]`
  - -> `[793]`

### Węzeł `[792]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Investigation_SuspectHugo_Argument == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Argument"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]`

### Węzeł `[793]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Investigation_SuspectHugo_Argument == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Argument"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[794]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Investigation_SuspectHugo_Argument = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Argument"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]`

### Węzeł `[795]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Investigation_SuspectHugo_Timing == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]`
  - -> `[797]`

### Węzeł `[796]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Investigation_SuspectHugo_Timing == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Timing"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]`

### Węzeł `[797]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Investigation_SuspectHugo_Timing == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Timing"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[798]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Suspect Hugo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[787]`
  - -> `[791]`
  - -> `[795]`
  - -> `[800]`
  - -> `[806]`

### Węzeł `[799]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Investigation_SuspectHugo_Timing = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Timing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]`

### Węzeł `[800]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Investigation_SuspectHugo_Lying == false && RiziaDLC.PoisonInvestigator_Titus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]`
  - -> `[802]`

### Węzeł `[801]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Investigation_SuspectHugo_Lying == false && RiziaDLC.PoisonInvestigator_Titus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Lying"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]`

### Węzeł `[802]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Investigation_SuspectHugo_Lying == false && RiziaDLC.PoisonInvestigator_Titus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Lying"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[803]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Investigation_SuspectHugo_Lying = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Lying"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]`

### Węzeł `[804]`
Mówca: **Lucita Azaro**
> ""Or there's something about the content of this argument that he wants to hide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]`

### Węzeł `[805]`
Mówca: **Titus Gordion**
> ""Someone might have convinced her to give this statement. Someone who wanted to cast aspersions on Hugo to throw us off her -- their -- trail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]`

### Węzeł `[806]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough about the maid. Is there any other reason to suspect Hugo?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]`

### Węzeł `[807]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Suspect Hugo])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]`

### Węzeł `[808]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[809]`
  - -> `[810]`

### Węzeł `[809]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[811]`

### Węzeł `[810]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[813]`

### Węzeł `[811]`
Mówca: **Lucita Azaro**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]`

### Węzeł `[812]`
Mówca: **Lucita Azaro**
> ""The councilors and aides I questioned admitted to sensing mistrust between the two brothers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]`

### Węzeł `[813]`
Mówca: **Titus Gordion**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]`

### Węzeł `[814]`
Mówca: **Titus Gordion**
> ""The councilors and aides I questioned admitted to sensing mistrust between the two brothers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[816]`

### Węzeł `[815]`
Mówca: **Lucita Azaro**
> ""But as you well know, there was almost nobody King Valero trusted by then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[24]`
  - -> `[84]`
  - -> `[23]`

### Węzeł `[816]`
Mówca: **Titus Gordion**
> ""But King Valero's paranoia at that stage of his life is well documented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[24]`
  - -> `[84]`
  - -> `[23]`

### Węzeł `[817]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not sure I believe that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[821]`

### Węzeł `[818]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]`
  - -> `[820]`

### Węzeł `[819]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[820]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[821]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]`
  - -> `[823]`

### Węzeł `[822]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[823]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[824]`
Mówca: **Lucita Azaro**
> ""According to the Grand Wiseman himself, Valero turned towards God when he sensed that the end of his life was coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[98]`
  - -> `[817]`
  - -> `[818]`

### Węzeł `[825]`
Mówca: **Titus Gordion**
> ""According to the Grand Wiseman himself, Valero turned toward God when he sensed that the end of his life was coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[98]`
  - -> `[817]`
  - -> `[818]`

### Węzeł `[826]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He wanted his enlightenment straight from the tap. I don't blame him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]`

### Węzeł `[827]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you implying that the two of them were planning something?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[841]`

### Węzeł `[828]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[829]`
  - -> `[830]`

### Węzeł `[829]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]`

### Węzeł `[830]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]`

### Węzeł `[831]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Blasphemy! I myself have attended every single service since my coronation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[848]`

### Węzeł `[832]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That proves nothing. I myself skip services all the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[853]`

### Węzeł `[833]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Grand Wiseman is one of the most respected figures in our kingdom. We should think twice before pointing the finger at him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]`

### Węzeł `[834]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[835]`
  - -> `[836]`

### Węzeł `[835]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]`

### Węzeł `[836]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[839]`

### Węzeł `[837]`
Mówca: **Lucita Azaro**
> ""Maybe... but I believe this inconsistency is worth looking into.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[838]`

### Węzeł `[838]`
Mówca: **Lucita Azaro**
> ""Especially since Grand Wiseman Ignacius was one of the last people to see your father alive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[839]`
Mówca: **Titus Gordion**
> ""I nonetheless believe this inconsistency is worth looking into.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]`

### Węzeł `[840]`
Mówca: **Titus Gordion**
> ""Especially since Grand Wiseman Ignacius was one of the last people to see your father alive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[841]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]`
  - -> `[843]`

### Węzeł `[842]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[844]`

### Węzeł `[843]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[846]`

### Węzeł `[844]`
Mówca: **Lucita Azaro**
> ""I don't know. But the inconsistency sticks out to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[845]`

### Węzeł `[845]`
Mówca: **Lucita Azaro**
> ""I haven't been able to establish a motive for the Grand Wiseman. But the means were there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[846]`
Mówca: **Titus Gordion**
> ""It strikes me as unlikely. But the inconsistency sticks out to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[847]`

### Węzeł `[847]`
Mówca: **Titus Gordion**
> ""I haven't been able to establish a motive for the Grand Wiseman. But the means were there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[848]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[849]`
  - -> `[850]`

### Węzeł `[849]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[852]`

### Węzeł `[850]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[851]`

### Węzeł `[851]`
Mówca: **Titus Gordion**
> ""Yes, your commitment to spirituality is a shining example for the rest of the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[859]`

### Węzeł `[852]`
Mówca: **Lucita Azaro**
> ""I'm impressed. I could never sit through them myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[858]`

### Węzeł `[853]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[854]`
  - -> `[855]`

### Węzeł `[854]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[856]`

### Węzeł `[855]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[857]`

### Węzeł `[856]`
Mówca: **Lucita Azaro**
> ""Same here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[858]`

### Węzeł `[857]`
Mówca: **Titus Gordion**
> ""The Lord will forgive you. You're a busy man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[859]`

### Węzeł `[858]`
Mówca: **Lucita Azaro**
> ""I am hesitant to cast blame on the Sanctuary. But I'd like to find out more about the nature of these meetings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[859]`
Mówca: **Titus Gordion**
> ""I do not want to soil the Grand Wiseman's good name. But I'm willing to dig further to find out the exact nature of these meetings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[860]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]`
  - -> `[862]`

### Węzeł `[861]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[858]`

### Węzeł `[862]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[859]`

### Węzeł `[863]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[864]`
  - -> `[865]`

### Węzeł `[864]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[866]`

### Węzeł `[865]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PoisonInvestigator_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[867]`

### Węzeł `[866]`
Mówca: **Narrator**
> "Lucita leaned forward, listening eagerly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[118]`
  - -> `[121]`
  - -> `[119]`

### Węzeł `[867]`
Mówca: **Narrator**
> "Titus stood at full attention, awaiting my next words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[121]`
  - -> `[119]`
  - -> `[392]`

### Węzeł `[868]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Right. Dinner and a movie, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[869]`

### Węzeł `[869]`
Mówca: **Lucita Azaro**
> ""I can do better than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[870]`
Mówca: **Narrator**
> "If our relationship was to continue, I wanted to make sure she didn't have any skeletons in her closet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[871]`
Mówca: **Narrator**
> "I took no pleasure in suspecting my own councilor, but it had to be done."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]`

### Węzeł `[872]`
Mówca: **Narrator**
> "There was a note of uncertainty in her voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[507]`
  - -> `[510]`
  - -> `[515]`

### Węzeł `[873]`
Mówca: **Narrator**
> "There was a strangely somber tone to his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[510]`
  - -> `[515]`

### Węzeł `[874]`
Mówca: **Lucita Azaro**
> ""Perhaps you're better off not knowing where your butler was that night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[875]`
  - -> `[539]`
  - -> `[538]`
  - -> `[883]`

### Węzeł `[875]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you think I shouldn't know, I trust you. Spare me the details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[881]`

### Węzeł `[876]`
Mówca: **Lucita Azaro**
> ""In a manner of speaking...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[877]`
  - -> `[885]`
  - -> `[886]`

### Węzeł `[877]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, forget it. I don't want to know. Case closed on Pabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[878]`

### Węzeł `[878]`
Mówca: **Narrator**
> "She nodded forcefully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[879]`

### Węzeł `[879]`
Mówca: **Lucita Azaro**
> ""Case closed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[880]`
Mówca: **Lucita Azaro**
> ""Yes, let's move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[881]`
Mówca: **Narrator**
> "She nodded forcefully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[880]`

### Węzeł `[882]`
Mówca: **Lucita Azaro**
> ""Very well. Though this has absolutely no bearing on the murder case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[883]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Saying that has only made me more curious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[884]`

### Węzeł `[884]`
Mówca: **Narrator**
> "She shook her head ruefully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[882]`

### Węzeł `[885]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right, now you definitely have to tell me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[884]`

### Węzeł `[886]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_OutedToPlayer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[887]`
  - -> `[888]`

### Węzeł `[887]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_OutedToPlayer == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[889]`

### Węzeł `[888]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_OutedToPlayer == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[889]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think I know what you're getting at. I've already given him a talking-to about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[890]`

### Węzeł `[890]`
Mówca: **Narrator**
> "She nodded forcefully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[891]`

### Węzeł `[891]`
Mówca: **Lucita Azaro**
> ""If something similar happens again, I don't need or want to know about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[892]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good interesting, or bad interesting?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[894]`

### Węzeł `[893]`
Mówca: **Narrator**
> "He drew in a breath through clenched teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[894]`
Mówca: **Titus Gordion**
> ""I'll let you be the judge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[893]`

### Węzeł `[895]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If it's not germane to the case, I don't want to hear about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[896]`

### Węzeł `[896]`
Mówca: **Titus Gordion**
> ""Really, Your Majesty? This concerns your personal attendant...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[897]`

### Węzeł `[897]`
Mówca: **Titus Gordion**
> ""But as you wish. Let's move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[898]`
Mówca: **Titus Gordion**
> ""I am, however, obliged to tell you that in the course of charting out Mr. Adria's exact activities on that night, my team made a rather... interesting discovery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[899]`
Mówca: **Lucita Azaro**
> ""Let's move on, shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[900]`

### Węzeł `[900]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, gladly. I knew Pabel was innocent all along.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[890]`

### Węzeł `[901]`
Mówca: **Narrator**
> "She peered at me closely, trying to gauge my reaction to the news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[903]`

### Węzeł `[902]`
Mówca: **Narrator**
> "He peered at me closely, trying to gauge my reaction to the news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[903]`

### Węzeł `[903]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`
  - -> `[631]`
  - -> `[633]`
  - -> `[908]`

### Węzeł `[904]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]`
  - -> `[906]`

### Węzeł `[905]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[907]`

### Węzeł `[906]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[907]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My butler lies with men? He must repent his sodomous ways before it's too late!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`

### Węzeł `[908]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[909]`
  - -> `[910]`

### Węzeł `[909]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel <= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[911]`

### Węzeł `[910]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel <= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel"] <= 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[911]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But that's disgusting. I let him dress me and everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`

### Węzeł `[912]`
Mówca: **Lucita Azaro**
> ""It could be there's a perfectly innocuous reason they were down there, and the staff we talked to were spreading rumors out of boredom or spite.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]`

### Węzeł `[913]`
Mówca: **Lucita Azaro**
> ""But when I questioned the other Golden Guardsmen, one of them admitted that Captain Gordion left his post that night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[914]`

### Węzeł `[914]`
Mówca: **Lucita Azaro**
> ""The guardsman assumed Titus' duties for a half hour. The Captain could have gone anywhere during that time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[41]`
  - -> `[43]`

### Węzeł `[915]`
Mówca: **Lucita Azaro**
> ""In between, however, Madam Estela was not in the Palace at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[33]`
  - -> `[443]`
  - -> `[51]`
  - -> `[432]`

### Węzeł `[916]`
Mówca: **Titus Gordion**
> ""In between, however, Madam Estela was not in the Palace at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[33]`
  - -> `[443]`
  - -> `[51]`
  - -> `[432]`

### Węzeł `[917]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PoisonInvestigator_Lucita = false;
RiziaDLC.PoisonInvestigator_Titus = false)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] = false;
Variable["RiziaDLC.PoisonInvestigator_Titus"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[918]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Meh. Her behavior isn’t worth bringing to the Cantuavos’ attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`

### Węzeł `[919]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Investigating the former king’s suspicious death", "Palace Balcony", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Investigating the former king’s suspicious death","Palace Balcony","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]`
