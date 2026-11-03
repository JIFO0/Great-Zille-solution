# Sordland/Turn06/A_AutocratDemands

- **ID konwersacji:** `83`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Sordland/Turn_06/083_A_AutocratDemands.md`
- **Liczba węzłów dialogowych:** 372
- **Liczba wyborów gracza:** 78

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[36]** Heron Garaci
- **[41]** Livia Suno

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.Policy_Diplomacy_RelaxedImmigration`
- `BaseGame.Policy_Military_CompulsoryMilitaryService`
- `BaseGame.Policy_Military_IncreasedFunding`
- `BaseGame.Policy_Order_IncreasedInteriorFunding`
- `BaseGame.Promise_Diplomacy_East`
- `BaseGame.Promise_Immigration_Relaxed`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain`
- `BaseGame.Turn03_EnT_Military_Budget_Decrease`
- `BaseGame.Turn03_EnT_Military_Budget_Increase`
- `BaseGame.Turn03_EnT_Military_Budget_Maintain`
- `BaseGame.Turn06_SnO_Conscription_Removed`
- `BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligarchs`
- `BaseGameIsolated.turn06_AutocratDemands_Conscription`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Policy_Diplomacy_RelaxedImmigration`
- `BaseGame.Policy_Diplomacy_TightenedImmigration`
- `BaseGame.Policy_Military_CompulsoryMilitaryService`
- `BaseGame.Reform_Autocrat_Demanded_FullNationalization`
- `BaseGame.Reform_Autocrat_Demanded_TightenedImmigration`
- `BaseGame.Situation_Military_LackOfReservists`
- `BaseGame.Situation_Military_LargeReservistPool`
- `BaseGame.Situation_Order_IllegalImmigration`
- `BaseGame.Situation_Order_StreamlinedImmigration`
- `BaseGame.Turn05_FPnT_Immigration_Tight`
- `BaseGame.Turn06_SnO_Conscription_Removed`
- `BaseGameIsolated.Turn06_AutocratDemands_Immigration`
- `BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligarchs`
- `BaseGameIsolated.turn06_AutocratDemands_Conscription`
- `BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces`
- `BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_IosefLeads`
- `BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_NoConscription`
- `BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_NoConscriptionIosefLeads`
- `BaseGameSupport.Journal_Turn06_AutocratDemand_FullNationalise`
- `BaseGameSupport.Journal_Turn06_Conscription_Mandatory`
- `BaseGameSupport.Journal_Turn06_Conscription_Removed`
- `BaseGameSupport.Journal_Turn06_ImmigrationDemand_Ignore`
- `BaseGameSupport.Journal_Turn06_ImmigrationDemand_Tighten`
- `BaseGameSupport.News_Turn06_ST_VictoryDay`
- `BaseGameSupport.News_Turn06_ST_VictoryDay_Emergency`
- `GameCondition.Turn06_A_AutocratDemands`
- `GameCondition.Turn06_A_Reform`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 33

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[208]` (Heron Garaci): `Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] = true; Variable["BaseGame.Policy_Dipl...`
- Węzeł `[215]` (Heron Garaci): `Variable["GameCondition.Turn06_A_AutocratDemands"] = true;`
- Węzeł `[288]` (Heron Garaci): `Variable["BaseGame.Situation_Order_StreamlinedImmigration"] = true;`
- Węzeł `[289]` (Heron Garaci): `Variable["BaseGame.Situation_Order_IllegalImmigration"] = false;`
- Węzeł `[290]` (Heron Garaci): `Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] = true;`
- Węzeł `[296]` (Heron Garaci): `Variable["BaseGame.Reform_Autocrat_Demanded_FullNationalization"] = true;`
- Węzeł `[297]` (Heron Garaci): `Variable["BaseGame.Reform_Autocrat_Demanded_FullNationalization"] = true;`
- Węzeł `[298]` (Heron Garaci): `Variable["BaseGameSupport.Journal_Turn06_AutocratDemand_FullNationalise"] = true;`
- *...oraz 25 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Heron Garaci)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Earlier in the day, I learned that Frens Ricter's complaint had been accepted by the Supreme Court for review."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[4]`
**[WYBÓR GRACZA: ""Send him in.""]** — Mówca: **Player**
> ""Send him in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[5]`
Mówca: **Heron Garaci**
> ""I heard that, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[6]`
Mówca: **Livia Suno**
> ""Sorry to interrupt, Mr. President, but Justice Garaci is here to see you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[11]`
  - -> `[12]`

### Węzeł `[7]`
Mówca: **Narrator**
> "I called Chief Justice Hawker's office to demand an explanation, but he wasn't in. I sat by the phone, waiting for him to call back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Narrator**
> "I had also been hearing countless reports about our police forces becoming reluctant to enforce the rules of the emergency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[9]`
Mówca: **Narrator**
> "I waited and waited."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Narrator**
> "Suddenly, I heard a knock on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[11]`
**[WYBÓR GRACZA: ""I told you that I'm expecting an important call. No visitors.""]** — Mówca: **Player**
> ""I told you that I'm expecting an important call. No visitors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
**[WYBÓR GRACZA: ""I'm waiting for Orso Hawker, not Heron.""]** — Mówca: **Player**
> ""I'm waiting for Orso Hawker, not Heron.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Livia Suno**
> ""He told me that he's here to talk to you about the Emergency Act. He said he couldn't speak on the phone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[14]`
Mówca: **Livia Suno**
> ""Right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[15]`
**[WYBÓR GRACZA: ""Send him in.""]** — Mówca: **Player**
> ""Send him in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[16]`
**[WYBÓR GRACZA: ""So Orso has sent his pawn.""]** — Mówca: **Player**
> ""So Orso has sent his pawn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Livia Suno**
> ""Um...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[18]`
Mówca: **Narrator**
> "She opened the door for Heron Garaci and closed the door behind her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Heron Garaci**
> ""Hello, Mr. President. Sorry to have come unannounced, but I'm sure you expected us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[20]`
Mówca: **Narrator**
> "Heron brushed past Livia and strode into the office. Livia gave me an apologetic half-smile, turned and closed the door behind her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Heron Garaci**
> ""It would be wise of you not to be so rude to your partners in the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Heron Garaci**
> ""I'm sorry if I disappointed you, but the Chief Justice is very busy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`
  - -> `[25]`
  - -> `[26]`

### Węzeł `[23]`
**[WYBÓR GRACZA: ""Busy? I'm a busy man too, Mr. Garaci.""]** — Mówca: **Player**
> ""Busy? I'm a busy man too, Mr. Garaci.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""You're right. I am disappointed.""]** — Mówca: **Player**
> ""You're right. I am disappointed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Let's get to the point.""]** — Mówca: **Player**
> ""Let's get to the point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""What is the Court plotting, Mr. Garaci?""]** — Mówca: **Player**
> ""What is the Court plotting, Mr. Garaci?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[27]`
Mówca: **Heron Garaci**
> ""Of course you are, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[28]`
Mówca: **Heron Garaci**
> ""Life is full of disappointments, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
Mówca: **Heron Garaci**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Heron Garaci**
> ""We are not plotting anything, Mr. President. Please calm down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Heron Garaci**
> ""You already know that Frens Ricter has filed a complaint about your Emergency Act being unconstitutional. The judges couldn't ignore his arguments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[32]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: (BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true) && (BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Turn03_EnT_Military_Budget_Maintain == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: (BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true) && (BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Turn03_EnT_Military_Budget_Maintain == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain"] == true)  and  (Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !((BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true) && (BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Turn03_EnT_Military_Budget_Maintain == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain"] == true)  and  (Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[35]`
Mówca: **Heron Garaci**
> ""Mr. Ricter has made a very compelling case against the Emergency Act. It's going to be very hard for us to refute it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[36]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true && BaseGame.Turn03_EnT_Military_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true && BaseGame.Turn03_EnT_Military_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true  and  Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true && BaseGame.Turn03_EnT_Military_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true  and  Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Heron Garaci**
> ""But as we have promised, the Court is doing its best to help you out...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Heron Garaci**
> ""To be honest, Mr. Ricter has made a very compelling case against the Emergency Act. It's going to be very hard for us to refute it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[41]`
Mówca: **Heron Garaci**
> ""...Even though the arguments filed by Ricter are noteworthy and do give us the right to deem your actions as unconstitutional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[42]`
Mówca: **Heron Garaci**
> ""Although, of course, none of us want the act revoked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`
  - -> `[45]`

### Węzeł `[43]`
**[WYBÓR GRACZA: ""Then why did you accept the case?""]** — Mówca: **Player**
> ""Then why did you accept the case?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[44]`
**[WYBÓR GRACZA: ""What is the meaning of this?""]** — Mówca: **Player**
> ""What is the meaning of this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
**[WYBÓR GRACZA: ""We don't want that indeed...""]** — Mówca: **Player**
> ""We don't want that indeed...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[46]`
Mówca: **Heron Garaci**
> ""It is the responsibility of the Supreme Court, Mr. President. We can't simply ignore matters of the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[47]`
Mówca: **Heron Garaci**
> ""There's nothing out of the ordinary, Mr. President. I'm here to ask for your help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Heron Garaci**
> ""Yes. That's why we need to talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Heron Garaci**
> ""Our hands are tied. The decrees you've signed are seen as abuse of power... Although of course, that isn't how Chief Justice Hawker and myself see it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Heron Garaci**
> ""But as you know, The Constitution states, 'No State shall modify or suspend the rights of freedom defined in Article 100 of the Constitution, unless actually invaded, or in such imminent danger as will not allow for delay.' And this does not seem to be the case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`
  - -> `[54]`
  - -> `[55]`

### Węzeł `[51]`
Mówca: **Heron Garaci**
> ""But as you know... the Constitution states, 'No State shall modify or suspend the rights of freedom defined in Article 100 of the Constitution, unless actually invaded, or in such imminent danger as will not allow for delay.' This is fairly clear...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[65]`
  - -> `[66]`

### Węzeł `[52]`
**[WYBÓR GRACZA: ""The Court has promised not to act about this clause.""]** — Mówca: **Player**
> ""The Court has promised not to act about this clause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[53]`
**[WYBÓR GRACZA: ""Don't you dare stab me in the back.""]** — Mówca: **Player**
> ""Don't you dare stab me in the back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[54]`
**[WYBÓR GRACZA: ""You and Orso are also implicated in this. Don't forget that.""]** — Mówca: **Player**
> ""You and Orso are also implicated in this. Don't forget that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[55]`
**[WYBÓR GRACZA: ""Okay, I get it. You have demands.""]** — Mówca: **Player**
> ""Okay, I get it. You have demands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Heron Garaci**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[57]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`
  - -> `[60]`

### Węzeł `[58]`
**[WYBÓR GRACZA: ""If you promised to help me, why did you accept the case?""]** — Mówca: **Player**
> ""If you promised to help me, why did you accept the case?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[59]`
**[WYBÓR GRACZA: ""I hope you are really doing your best, Mr. Garaci.""]** — Mówca: **Player**
> ""I hope you are really doing your best, Mr. Garaci.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
**[WYBÓR GRACZA: ""Is that a threat?""]** — Mówca: **Player**
> ""Is that a threat?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Heron Garaci**
> ""No. No. You are getting this all wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[62]`
Mówca: **Heron Garaci**
> ""Of course we are, Mr. President. Rest assured, everything's going to work out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Heron Garaci**
> ""It is the responsibility of the Supreme Court, Mr. President. We couldn't simply ignore matters of the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Heron Garaci**
> ""The Old Guard are happy with the Emergency Act. And Mr. Hawker is currently working on a legal argument against Mr. Ricter's case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[65]`
**[WYBÓR GRACZA: ""The Court promised not to act on this clause.""]** — Mówca: **Player**
> ""The Court promised not to act on this clause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[66]`
**[WYBÓR GRACZA: ""Don't you dare stab me in the back.""]** — Mówca: **Player**
> ""Don't you dare stab me in the back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""And?""]** — Mówca: **Player**
> ""And?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[68]`
Mówca: **Heron Garaci**
> ""Yes, we did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[69]`
Mówca: **Heron Garaci**
> ""Of course not... As long as you keep your promises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Heron Garaci**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Heron Garaci**
> ""Personally, I believe Sordland is in more than enough imminent danger to justify the emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Heron Garaci**
> ""But we must work within the boundaries defined by our Constitution. I'm sure you understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Heron Garaci**
> ""I'll be honest with you. There are a few justices who are taking Mr. Ricter's side on this. They do believe you are acting unconstitutionally and must be held accountable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[74]`
Mówca: **Heron Garaci**
> ""Of course not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[75]`
Mówca: **Heron Garaci**
> ""We won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Heron Garaci**
> ""That's true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[78]`
Mówca: **Heron Garaci**
> ""We are simply a little disappointed about the lack of proper budget for our police and military forces. This Emergency Act has taken a heavy toll on them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Heron Garaci**
> ""And we have a few other suggestions that may help you manage this difficult period in the best way possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Heron Garaci**
> ""We wish to see you address these concerns before the judicial review is concluded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`
  - -> `[83]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""Tell me about them.""]** — Mówca: **Player**
> ""Tell me about them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[82]`
**[WYBÓR GRACZA: ""And what if I don't?""]** — Mówca: **Player**
> ""And what if I don't?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[83]`
**[WYBÓR GRACZA: ""This is treachery!""]** — Mówca: **Player**
> ""This is treachery!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Heron Garaci**
> ""It is not. It would only be treacherous if we overlook problems that may end up damaging Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[85]`
Mówca: **Heron Garaci**
> ""Then I cannot promise the Court will find your actions constitutionally justified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Heron Garaci**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Heron Garaci**
> ""Mr. Hawker and I only want to make sure that you are on our side, Mr. President. Addressing these concerns of ours would be a great place to start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[88]`
Mówca: **Heron Garaci**
> ""There have been countless cases of foreigners joining the fight against our state. We require better border security and a tighter immigration policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[91]`
  - -> `[90]`

### Węzeł `[89]`
**[WYBÓR GRACZA: ""You're right. We'll definitely tighten immigration.""]** — Mówca: **Player**
> ""You're right. We'll definitely tighten immigration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[90]`
**[WYBÓR GRACZA: ""I can't do that.""]** — Mówca: **Player**
> ""I can't do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[92]`
Mówca: **Heron Garaci**
> ""That's precisely why we are concerned about your management of this sensitive period. Keeping the current policy would be a grave mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Heron Garaci**
> ""That's good to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Heron Garaci**
> ""We hope to see you revert your earlier decision to relax immigration laws with a decree as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[95]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true ||BaseGame.Turn03_EnT_Military_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true ||BaseGame.Turn03_EnT_Military_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[97]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true ||BaseGame.Turn03_EnT_Military_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[98]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_RelaxedImmigration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_RelaxedImmigration == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[100]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_RelaxedImmigration == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[101]`
Mówca: **Heron Garaci**
> ""Our biggest concern, however, regards the Oligarchs. Walter Tusk and Marcel Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Heron Garaci**
> ""They are in close cooperation with Arcasia and have ties to almost every other country on this continent. And as we all know, they only care about money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Heron Garaci**
> ""It is clear that they're trying to profit from the violence in Sordland and abroad. We have reason to believe they are supporting the militant organizations we are fighting against.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`
  - -> `[106]`

### Węzeł `[104]`
**[WYBÓR GRACZA: ""What are you suggesting here?""]** — Mówca: **Player**
> ""What are you suggesting here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[105]`
**[WYBÓR GRACZA: ""There is no evidence of this.""]** — Mówca: **Player**
> ""There is no evidence of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""I share the same concerns.""]** — Mówca: **Player**
> ""I share the same concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Heron Garaci**
> ""What evidence do you need when they are the only people who are not affected by these crises? They influence politics in Sordland for their own gains as well as those of foreign interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[108]`
Mówca: **Heron Garaci**
> ""Then we are on the same page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[109]`
Mówca: **Heron Garaci**
> ""We are already in an emergency, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[110]`
**[WYBÓR GRACZA: ""I can't disagree with that.""]** — Mówca: **Player**
> ""I can't disagree with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[111]`
**[WYBÓR GRACZA: ""That is too extreme, Mr. Garaci.""]** — Mówca: **Player**
> ""That is too extreme, Mr. Garaci.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[112]`
**[WYBÓR GRACZA: ""We are already working on market economy reforms. Your little proposal doesn't align with my plans.""]** — Mówca: **Player**
> ""We are already working on market economy reforms. Your little proposal doesn't align with my plans.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[113]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[115]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[116]`
Mówca: **Heron Garaci**
> ""Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[117]`
Mówca: **Heron Garaci**
> ""We hope you follow through with this plan at the next economy meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[118]`
Mówca: **Heron Garaci**
> ""And your Emergency Act was not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Heron Garaci**
> ""Mr. President... You don't seem to understand the whole picture here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Heron Garaci**
> ""This is not only a matter of revoking the validity of your decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Heron Garaci**
> ""As much as we're doing our best to help you out, the Court could still decide to try you for deliberately going against the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[122]`
Mówca: **Heron Garaci**
> ""In the meantime, the Court will be doing its best. As long as you listen to our concerns, Chief Justice Hawker will be motivated to help you further...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Heron Garaci**
> ""I hope you understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[124]`
Mówca: **Heron Garaci**
> ""With that said, they might be persuaded to rule in your favor if certain other judicial concerns were addressed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`
  - -> `[127]`

### Węzeł `[125]`
**[WYBÓR GRACZA: ""What concerns?""]** — Mówca: **Player**
> ""What concerns?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[126]`
**[WYBÓR GRACZA: ""I'm on to your shenanigans, Mr. Garaci.""]** — Mówca: **Player**
> ""I'm on to your shenanigans, Mr. Garaci.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[127]`
**[WYBÓR GRACZA: ""I thought the Old Guard controlled the Court.""]** — Mówca: **Player**
> ""I thought the Old Guard controlled the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Heron Garaci**
> ""We do. And there are no problems from our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Heron Garaci**
> ""There are no shenanigans, Mr. President. Relax a little. I'm here to help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Heron Garaci**
> ""We are personally happy with the work you've been doing to keep Sordland safe. Especially your generous support of the police and military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Heron Garaci**
> ""But of course, some of us are harder to please than others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
**[WYBÓR GRACZA: ""Okay, I get it. What do you want?""]** — Mówca: **Player**
> ""Okay, I get it. What do you want?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[133]`
**[WYBÓR GRACZA: ""No. As we already agreed, you will fix this as soon as possible. I won't cave to your demands.""]** — Mówca: **Player**
> ""No. As we already agreed, you will fix this as soon as possible. I won't cave to your demands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Heron Garaci**
> ""Whatever you say, Mr. President. But I can't promise I'll be able to convince those finicky holdouts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[135]`
Mówca: **Heron Garaci**
> ""There have been countless cases of foreigners joining the fight against our state. We require better border security and a tighter immigration policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[139]`
  - -> `[145]`

### Węzeł `[136]`
**[WYBÓR GRACZA: ""You're right. We'll definitely tighten immigration.""]** — Mówca: **Player**
> ""You're right. We'll definitely tighten immigration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[137]`
Mówca: **Heron Garaci**
> ""We are already in an emergency, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[138]`
Mówca: **Heron Garaci**
> ""Our biggest concern, however, regards the Oligarchs. Marcel Koronti and Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[139]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[140]`
Mówca: **Heron Garaci**
> ""It is clear that they're trying to profit from the violence in Sordland and abroad. We have reason to believe they are supporting the militant organizations we are fighting against.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[149]`
  - -> `[150]`

### Węzeł `[141]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_RelaxedImmigration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_RelaxedImmigration == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[143]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_RelaxedImmigration == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[144]`
Mówca: **Heron Garaci**
> ""Then we are on the same page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[145]`
**[WYBÓR GRACZA: ""I can't do that.""]** — Mówca: **Player**
> ""I can't do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Heron Garaci**
> ""That's precisely why we are concerned about your management of this sensitive period. Keeping the current policy would be a grave mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[147]`
Mówca: **Heron Garaci**
> ""What evidence do you need when they are the only people who are not affected by these crises? They influence politics in Sordland for their own gains as well as those of foreign interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[148]`
Mówca: **Heron Garaci**
> ""That's relieving.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[149]`
**[WYBÓR GRACZA: ""There is no evidence of this.""]** — Mówca: **Player**
> ""There is no evidence of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[150]`
**[WYBÓR GRACZA: ""I share the same concerns.""]** — Mówca: **Player**
> ""I share the same concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[151]`
Mówca: **Heron Garaci**
> ""We hope to see you revert your earlier decision to relax immigration laws with a decree as soon as possible. We are in an emergency, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[152]`
**[WYBÓR GRACZA: ""What are you suggesting here?""]** — Mówca: **Player**
> ""What are you suggesting here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[153]`
Mówca: **Heron Garaci**
> ""They are in close cooperation with Arcasia and have ties to almost every other country on this continent. And as we all know, they only care about money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[154]`
Mówca: **Heron Garaci**
> ""For example, something has to be done about the Oligarchs. Walter Tusk and Marcel Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[155]`
Mówca: **Heron Garaci**
> ""Mr. President, we are worried about the Oligarchs. Marcel Koronti and Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[156]`
Mówca: **Heron Garaci**
> ""In these difficult times when unity is so sorely needed, they pose a great threat to all of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[157]`
Mówca: **Heron Garaci**
> ""Anyway, I am not here to argue with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Heron Garaci**
> ""I hope our alliance stands strong. As I said earlier, there is nothing to worry about. The Court will reject Mr. Ricter's case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Heron Garaci**
> ""Barring any... extraordinary circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[160]`
Mówca: **Heron Garaci**
> ""Of course, there are some justices who believe you are to blame. Going against the Constitution is a serious offense, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[162]`
  - -> `[161]`

### Węzeł `[161]`
**[WYBÓR GRACZA: ""Is that a threat?""]** — Mówca: **Player**
> ""Is that a threat?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[162]`
**[WYBÓR GRACZA: ""You promised the Court would side with me.""]** — Mówca: **Player**
> ""You promised the Court would side with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[163]`
**[WYBÓR GRACZA: ""What is the meaning of this!?""]** — Mówca: **Player**
> ""What is the meaning of this!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[164]`
Mówca: **Heron Garaci**
> ""You promised to manage this emergency period as best as you can. Yet our police and military forces took a heavy toll with their lack of proper budget.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Heron Garaci**
> ""This is having very negative effects on Sordland, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Heron Garaci**
> ""We are doing our best to keep the Court in check, but it seems your decree has made you quite unpopular.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Heron Garaci**
> ""Of course, nobody would go as far as to impeach you for crimes against the Constitution. Yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`
  - -> `[170]`

### Węzeł `[168]`
**[WYBÓR GRACZA: ""Impeach me?""]** — Mówca: **Player**
> ""Impeach me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[169]`
**[WYBÓR GRACZA: ""What are you suggesting?""]** — Mówca: **Player**
> ""What are you suggesting?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
**[WYBÓR GRACZA: ""Don't you dare stab me in the back.""]** — Mówca: **Player**
> ""Don't you dare stab me in the back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Heron Garaci**
> ""As you know, the Constitution states, 'No State shall modify or suspend the rights of freedom defined in Article 100 of the Constitution, unless actually invaded, or in such imminent danger as will not allow for delay.' That does not seem to apply to our current situation...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Heron Garaci**
> ""I don't know what to say. After all, it is up to the majority in the Court if they decide to take action against your decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[173]`
  - -> `[174]`
  - -> `[175]`

### Węzeł `[173]`
**[WYBÓR GRACZA: ""Screw you, Mr. Garaci.""]** — Mówca: **Player**
> ""Screw you, Mr. Garaci.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[174]`
**[WYBÓR GRACZA: ""You have balls coming to me like that.""]** — Mówca: **Player**
> ""You have balls coming to me like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[175]`
**[WYBÓR GRACZA: ""Listen to me. The Court will reject Ricter's case and I will forget about this conversation. Okay?""]** — Mówca: **Player**
> ""Listen to me. The Court will reject Ricter's case and I will forget about this conversation. Okay?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[177]`
Mówca: **Heron Garaci**
> ""That depends, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[178]`
Mówca: **Heron Garaci**
> ""Where are your manners, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Heron Garaci**
> ""Listen...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[180]`
Mówca: **Heron Garaci**
> ""You will implement a nationalization plan and seize the assets of the Oligarchs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Heron Garaci**
> ""Then we will see what happens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`
  - -> `[184]`
  - -> `[209]`

### Węzeł `[182]`
**[WYBÓR GRACZA: ""You will regret this. Get out of my sight!""]** — Mówca: **Player**
> ""You will regret this. Get out of my sight!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[183]`
**[WYBÓR GRACZA: ""What if I don't?""]** — Mówca: **Player**
> ""What if I don't?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[184]`
**[WYBÓR GRACZA: ""Don't worry. We are on the same side. I will do as you say.""]** — Mówca: **Player**
> ""Don't worry. We are on the same side. I will do as you say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[185]`
**[WYBÓR GRACZA: ""We are already working on market economy reforms. What you're saying doesn't align with my plans.""]** — Mówca: **Player**
> ""We are already working on market economy reforms. What you're saying doesn't align with my plans.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Heron Garaci**
> ""Does being impeached align with your plans? Does spending the rest of your term in prison?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[187]`
Mówca: **Heron Garaci**
> ""Then it might just be too hard for us to ignore your crimes against the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[188]`
Mówca: **Heron Garaci**
> ""Whatever you say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Heron Garaci**
> ""Good. The Old Guard will be waiting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[190]`
Mówca: **Heron Garaci**
> ""I have to say... You are not so different from President Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Narrator**
> "He stood up and went to the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Heron Garaci**
> ""Goodbye and good luck, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[193]`
Mówca: **Heron Garaci**
> ""Well... For now, I must leave. I hope you'll think long and hard about what we just talked about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[194]`
**[WYBÓR GRACZA: "Don't shake his hand."]** — Mówca: **Player_Italic**
> "I did not shake his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[195]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Italic**
> "I shook his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Narrator**
> "He raised an eyebrow and then smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Heron Garaci**
> ""Goodbye, Mr. President. Thank you for your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[198]`
Mówca: **Narrator**
> "He extended his hand towards mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[194]`

### Węzeł `[199]`
Mówca: **Narrator**
> "He went out and closed the door behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[200]`
Mówca: **Narrator**
> "He went out and closed the door behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[201]`
Mówca: **Narrator**
> "I reflected on our conversation for a moment. Would it be worth re-tightening the laws on immigration to keep the Old Guard happy?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[202]`
**[WYBÓR GRACZA: "Start working on a decree to tighten immigration."]** — Mówca: **Player_Italic**
> "I decided to comply with Heron's suggestion and started to work on a decree to implement tighter immigration laws."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[203]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_RelaxedImmigration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_RelaxedImmigration == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[205]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_RelaxedImmigration == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[206]`
**[WYBÓR GRACZA: "Ignore their demand."]** — Mówca: **Player_Italic**
> "I decided to ignore their demands on immigration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[207]`
Mówca: **Narrator**
> "I leaned back in my chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[208]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_TightenedImmigration = true;
BaseGame.Policy_Diplomacy_RelaxedImmigration = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] = true;
Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[209]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[211]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[212]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[214]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[215]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: GameCondition.Turn06_A_AutocratDemands = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn06_A_AutocratDemands"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[216]`
Mówca: **Heron Garaci**
> ""We are concerned about Walter Tusk and Marcel Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Heron Garaci**
> ""The Oligarchs are in close cooperation with Arcasia and have ties to almost every other country on the continent. And as we all know, they only care about money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Heron Garaci**
> ""It is clear that they're trying to profit from the violence in Sordland and abroad. We have reasons to believe they are supporting the militant organizations inside our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[221]`
  - -> `[222]`

### Węzeł `[219]`
**[WYBÓR GRACZA: ""What are you suggesting here?""]** — Mówca: **Player**
> ""What are you suggesting here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[220]`
Mówca: **Heron Garaci**
> ""What evidence do you need when they are the only people who are not affected by these crises? They influence politics in Sordland for their own gains as well as those of foreign interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[221]`
**[WYBÓR GRACZA: ""There is no evidence of this.""]** — Mówca: **Player**
> ""There is no evidence of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[222]`
**[WYBÓR GRACZA: ""I share the same concerns.""]** — Mówca: **Player**
> ""I share the same concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[223]`
Mówca: **Heron Garaci**
> ""They pose a great threat to all of Sordland. The State must seize both of their corporations and bring an end to their supremacy very soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[224]`
Mówca: **Heron Garaci**
> ""We are already in an emergency, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[225]`
Mówca: **Heron Garaci**
> ""Then we are on the same page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[226]`
Mówca: **Heron Garaci**
> ""So here is the deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[227]`
Mówca: **Heron Garaci**
> ""Now you listen to me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[228]`
Mówca: **Heron Garaci**
> ""We hope you follow through on this in the next economy meeting. For your own good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[229]`
Mówca: **Heron Garaci**
> ""I have one final request.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[230]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_RelaxedImmigration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_RelaxedImmigration == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[232]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_RelaxedImmigration == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[233]`
Mówca: **Heron Garaci**
> ""We are concerned about Sordland's current immigration laws. We fear too many troublemakers are crossing the border to lend support to militant organizations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[234]`
**[WYBÓR GRACZA: ""You're right. We'll definitely tighten immigration.""]** — Mówca: **Player**
> ""You're right. We'll definitely tighten immigration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[235]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[236]`
**[WYBÓR GRACZA: ""I can't do that.""]** — Mówca: **Player**
> ""I can't do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Heron Garaci**
> ""I will not repeat myself. I think you get the point. We will not let Sordland deteriorate under bad leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[238]`
Mówca: **Heron Garaci**
> ""That's a relief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[239]`
Mówca: **Heron Garaci**
> ""There have been countless cases of foreigners joining the fight against our state. We require better border security and a tighter immigration policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[240]`
Mówca: **Heron Garaci**
> ""We are in an emergency, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Heron Garaci**
> ""So. In addition to what I said before, you will make a decree reverting your earlier decision to relax immigration laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`
  - -> `[236]`

### Węzeł `[242]`
Mówca: **Narrator**
> "Even if I was wrong, would I be able to get out of this if I wanted?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[243]`
Mówca: **Narrator**
> "Was my decision to work with the Old Guard right?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[244]`
Mówca: **Heron Garaci**
> ""We also know that you've been *working* with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Heron Garaci**
> ""Remember, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[246]`
Mówca: **Heron Garaci**
> ""Those who sleep with dogs will rise with fleas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[247]`
Mówca: **Heron Garaci**
> ""We also know that you've been *working* with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[248]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[250]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[251]`
Mówca: **Heron Garaci**
> ""Remember, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[252]`
Mówca: **Heron Garaci**
> ""Those who sleep with dogs will rise with fleas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[253]`
Mówca: **Heron Garaci**
> ""We also know that you've been *working* with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[254]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[256]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[257]`
Mówca: **Heron Garaci**
> ""Remember, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
Mówca: **Heron Garaci**
> ""Those who sleep with dogs will rise with fleas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[259]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Immigration_Relaxed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Immigration_Relaxed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Immigration_Relaxed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Immigration_Relaxed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Immigration_Relaxed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[206]`

### Węzeł `[262]`
Mówca: **Narrator**
> "I had promised the people of Sordland that I would open our borders, and I had followed through. Turning back now would mean betraying all that work. On the other hand, so would losing the court case."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[206]`

### Węzeł `[263]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[265]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[266]`
Mówca: **Narrator**
> "Earlier in the day, I learned that Frens Ricter's complaint had been accepted by the Supreme Court for review."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Narrator**
> "I had stopped the state of emergency, but the reformists and the Old Guard were still coming after me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
Mówca: **Narrator**
> "I called Chief Justice Hawker's office to demand an explanation, but he wasn't in. I sat by the phone, waiting for him to call back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[269]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[271]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Heron Garaci**
> ""To be honest, Mr. Ricter has made a very compelling case against the Emergency Act. It's going to be very hard for us to refute it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[273]`
Mówca: **Heron Garaci**
> ""Of course, there are some Justices who believe you were to blame from the beginning. Going against the Constitution was an impeachable offence, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[276]`
  - -> `[279]`
  - -> `[274]`

### Węzeł `[274]`
**[WYBÓR GRACZA: ""Is that a threat?""]** — Mówca: **Player**
> ""Is that a threat?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[275]`
Mówca: **Heron Garaci**
> ""This is having very negative effects on Sordland, Mr. President. You were supposed to use the state of emergency to its full advantage, not trigger more dissent by attacking militants and retreating before defeating them...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[276]`
**[WYBÓR GRACZA: ""You promised the Court would side with me.""]** — Mówca: **Player**
> ""You promised the Court would side with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[277]`
**[WYBÓR GRACZA: ""What is the meaning of this!?""]** — Mówca: **Player**
> ""What is the meaning of this!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Heron Garaci**
> ""You promised to eliminate the national security threats. Yet you stopped the emergency before our security forces could successfully do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[279]`
**[WYBÓR GRACZA: ""Orso gave me the green light. It was your plan.""]** — Mówca: **Player**
> ""Orso gave me the green light. It was your plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[280]`
Mówca: **Heron Garaci**
> ""As you know... The Constitution states, 'No State shall modify or suspend the rights of freedom defined in Article 100 of the Constitution, unless actually invaded, or in such imminent danger as will not allow for delay'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[281]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`

### Węzeł `[282]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[283]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[284]`
Mówca: **Heron Garaci**
> ""You must deal with them...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[285]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[287]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[288]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_StreamlinedImmigration = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Order_StreamlinedImmigration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[289]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Order_IllegalImmigration = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Order_IllegalImmigration"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[290]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_FPnT_Immigration_Tight = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[291]`
Mówca: **Heron Garaci**
> ""But it isn't up to me. Unless... a majority of the court could somehow be convinced to take your side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`
  - -> `[54]`
  - -> `[55]`

### Węzeł `[292]`
Mówca: **Heron Garaci**
> ""In these difficult times when unity is so sorely needed, they pose a great threat to all of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[293]`
Mówca: **Heron Garaci**
> ""We propose a nationalization plan to eliminate the power of the Oligarchs. The State must have control over their assets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Heron Garaci**
> ""We can't let a handful of people control the treasury, can we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`
  - -> `[113]`

### Węzeł `[295]`
Mówca: **Heron Garaci**
> ""Namely Walter Tusk's Bergia Steel and Marcel Koronti's Heart of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[296]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Demanded_FullNationalization = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Autocrat_Demanded_FullNationalization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Demanded_FullNationalization = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Autocrat_Demanded_FullNationalization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_AutocratDemand_FullNationalise = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_AutocratDemand_FullNationalise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[299]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_AutocratDemand_FullNationalise = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_AutocratDemand_FullNationalise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[300]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_ImmigrationDemand_Tighten = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_ImmigrationDemand_Tighten"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[301]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_ImmigrationDemand_Ignore = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_ImmigrationDemand_Ignore"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[302]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true && BaseGame.Promise_Diplomacy_East == true && BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true && BaseGame.Promise_Diplomacy_East == true && BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true  and  Variable["BaseGame.Promise_Diplomacy_East"] == true  and  Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true && BaseGame.Promise_Diplomacy_East == true && BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true  and  Variable["BaseGame.Promise_Diplomacy_East"] == true  and  Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[305]`
Mówca: **Heron Garaci**
> ""You played your cards wrong, Mr. President. Look at you. You have done virtually *everything* that is possible to oppose us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Heron Garaci**
> ""First you ban the Young Sords, then you make a deal with the communists!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Heron Garaci**
> ""We knew you were leaning eastwards, but accepting financial aid from our enemies? Preposterous!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[308]`
Mówca: **Heron Garaci**
> ""Let me just say this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[309]`
Mówca: **Heron Garaci**
> ""They already control much of our economy. They can't be allowed to have that much power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[310]`
Mówca: **Heron Garaci**
> ""Something must be done. Nationalizing their assets, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`
  - -> `[314]`

### Węzeł `[311]`
**[WYBÓR GRACZA: ""That would be too extreme, Mr. Garaci.""]** — Mówca: **Player**
> ""That would be too extreme, Mr. Garaci.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[312]`
**[WYBÓR GRACZA: ""I will think about it.""]** — Mówca: **Player**
> ""I will think about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[313]`
Mówca: **Heron Garaci**
> ""Look. I'm not asking you to do anything. It's just a friendly suggestion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[314]`
**[WYBÓR GRACZA: ""That was my plan anyway.""]** — Mówca: **Player**
> ""That was my plan anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[315]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Demanded_TightenedImmigration = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Autocrat_Demanded_TightenedImmigration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[316]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Demanded_TightenedImmigration = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Autocrat_Demanded_TightenedImmigration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[317]`
Mówca: **Heron Garaci**
> ""We are concerned about Sordland's current immigration laws. We fear too many troublemakers are crossing the border to lend support to militant organizations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[318]`
Mówca: **Heron Garaci**
> ""Firstly, we are concerned about Sordland's current immigration laws. We fear too many troublemakers are crossing the border to lend support to militant organizations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[319]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_SnO_Conscription_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_SnO_Conscription_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[321]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_SnO_Conscription_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[322]`
Mówca: **Heron Garaci**
> ""You must reverse your ridiculous decision to end mandatory conscription. A large, strong military is the only way to ensure stability in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[323]`
Mówca: **Heron Garaci**
> ""But that's not all we want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[324]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligarchs = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[325]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGameIsolated.turn06_AutocratDemands_Conscription = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.turn06_AutocratDemands_Conscription"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[326]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_AutocratDemands_Immigration = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn06_AutocratDemands_Immigration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[327]`
Mówca: **Heron Garaci**
> ""Personally, I of course believe the emergency was fully justified. It would be a shame if the rest of the Court failed to agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[328]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Demanded_FullNationalization = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Autocrat_Demanded_FullNationalization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_AutocratDemand_FullNationalise = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_AutocratDemand_FullNationalise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[330]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_SnO_Conscription_Removed = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_SnO_Conscription_Removed"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_CompulsoryMilitaryService = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[332]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Military_LargeReservistPool = true;
BaseGame.Situation_Military_LackOfReservists = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Military_LargeReservistPool"] = true;
Variable["BaseGame.Situation_Military_LackOfReservists"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[333]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Conscription_Removed = false; BaseGameSupport.Journal_Turn06_Conscription_Mandatory = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Conscription_Removed"] = false;
Variable["BaseGameSupport.Journal_Turn06_Conscription_Mandatory"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[334]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGameIsolated.turn06_AutocratDemands_Conscription == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGameIsolated.turn06_AutocratDemands_Conscription == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.turn06_AutocratDemands_Conscription"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[336]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.turn06_AutocratDemands_Conscription == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.turn06_AutocratDemands_Conscription"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[337]`
Mówca: **Narrator**
> "And then there was the conscription issue..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[338]`
Mówca: **Narrator**
> "If I reversed my policy, boys like my own son would be forced to join the army. Would I be able to live with that?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`
  - -> `[340]`

### Węzeł `[339]`
**[WYBÓR GRACZA: "Start working on a decree to reinstate conscription."]** — Mówca: **Player_Italic**
> "I decided to comply with Heron's suggestion and bring conscription back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[340]`
**[WYBÓR GRACZA: "Leave the law as it is."]** — Mówca: **Player_Italic**
> "I decided to ignore Heron's demands on conscription."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Narrator**
> "I didn't even want to think about Heron's demands for the Oligarchs. Nationalizing Sordland's two largest private corporations would have huge repercussions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[342]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_SnO_Conscription_Removed = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_SnO_Conscription_Removed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[343]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_CompulsoryMilitaryService = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Military_LackOfReservists = true; BaseGame.Situation_Military_LargeReservistPool = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Military_LackOfReservists"] = true;
Variable["BaseGame.Situation_Military_LargeReservistPool"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[345]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Conscription_Removed = true; BaseGameSupport.Journal_Turn06_Conscription_Mandatory = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Conscription_Removed"] = true;
Variable["BaseGameSupport.Journal_Turn06_Conscription_Mandatory"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[346]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: GameCondition.Turn06_A_Reform = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn06_A_Reform"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[347]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligarchs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[349]`

### Węzeł `[348]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligarchs == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[349]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligarchs == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligarchs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[350]`
Mówca: **Heron Garaci**
> ""There is more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[351]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_SnO_Conscription_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`
  - -> `[353]`

### Węzeł `[352]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_SnO_Conscription_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[353]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_SnO_Conscription_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[354]`
Mówca: **Heron Garaci**
> ""You must reverse your ridiculous decision to end mandatory conscription. A large, strong military is the only way to ensure stability in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGameIsolated.turn06_AutocratDemands_Conscription = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.turn06_AutocratDemands_Conscription"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[356]`
Mówca: **Heron Garaci**
> ""Do that and we will see about the rest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[357]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_NoConscription = true;
BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_IosefLeads = false;
BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_NoConscriptionIosefLeads = false; BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_NoConscription"] = true;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_IosefLeads"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_NoConscriptionIosefLeads"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[358]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces = true;
BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_NoConscription = false;
BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_IosefLeads = false;
BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_NoConscriptionIosefLeads = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces"] = true;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_NoConscription"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_IosefLeads"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_NoConscriptionIosefLeads"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[359]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_IncreasedFunding == false && BaseGame.Policy_Order_IncreasedInteriorFunding == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`
  - -> `[361]`

### Węzeł `[360]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_IncreasedFunding == false && BaseGame.Policy_Order_IncreasedInteriorFunding == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Military_IncreasedFunding"] == false  and  Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[361]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Military_IncreasedFunding == false && BaseGame.Policy_Order_IncreasedInteriorFunding == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Military_IncreasedFunding"] == false  and  Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Heron Garaci**
> ""We have a few other suggestions that may help you manage this difficult period in the best way possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[363]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_ST_VictoryDay_Emergency = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_ST_VictoryDay_Emergency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[364]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_ST_VictoryDay = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_ST_VictoryDay"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[365]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[366]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: (BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true) && (BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Turn03_EnT_Military_Budget_Maintain == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`
  - -> `[368]`

### Węzeł `[367]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: (BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true) && (BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Turn03_EnT_Military_Budget_Maintain == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain"] == true)  and  (Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[368]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !((BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true) && (BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Turn03_EnT_Military_Budget_Maintain == true)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain"] == true)  and  (Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[369]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_CompulsoryMilitaryService == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`
  - -> `[371]`

### Węzeł `[370]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_CompulsoryMilitaryService == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[371]`
Mówca: **Heron Garaci**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Military_CompulsoryMilitaryService == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
