# Sordland/Turn03/Autocrat Post Discussion

- **ID konwersacji:** `34`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/034_Autocrat_Post_Discussion.md`
- **Liczba węzłów dialogowych:** 115
- **Liczba wyborów gracza:** 12

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[8]** Orso Hawker
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia`
- `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg`
- `BaseGame.Reform_EmergencyDecree_Embargo_UC`
- `BaseGame.Reform_EmergencyDecree_PoliceAuthority`
- `BaseGame.Reform_EmergencyDecree_SuspendedProtests`
- `BaseGame.Turn01_EnT_Economy_Market`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Democratic`
- `BaseGame.Economy`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Malenyevist`
- `BaseGame.Policy_Law_Ban_RedYouth`
- `BaseGame.Policy_Law_Ban_WPB`
- `BaseGame.Policy_Law_Ban_YoungSords`
- `BaseGame.Policy_Law_EmergencyDecree`
- `BaseGame.Reform_EmergencyDecree_Embargo_None`
- `BaseGame.Relations_Nia_Opposition`
- `BaseGame.Sollist`
- `BaseGameSupport.Journal_Turn03_EmergencyDecree_Autocrat`
- `BaseGameSupport.News_Turn03_ST_InternalPeace_Deal_A`
- `BaseGameSupport.News_Turn03_ST_RayneIgnores_NoDeal_A`
- `GameCondition.Turn03_A_Constitution`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[33] Sordland/Turn03/A_AutocratDecree** (../Turn_03/033_A_AutocratDecree.md), Węzeł `[42]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 13

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy`
- `BaseGame.Policy_Law_EmergencyDecree`
- `BaseGame.Reform_EmergencyDecree_Embargo_None`
- `BaseGame.Relations_Nia_Opposition`
- `BaseGame.Sollist`
- `BaseGameSupport.Journal_Turn03_EmergencyDecree_Autocrat`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[81]` (Paskal Beniwoll): `Variable["GameCondition.Turn03_A_Constitution"] = true;`
- Węzeł `[82]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn03_EmergencyDecree_Autocrat"] = true;`
- Węzeł `[86]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn03_ST_InternalPeace_Deal_A"] = true;`
- Węzeł `[87]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn03_ST_RayneIgnores_NoDeal_A"] = true;`
- Węzeł `[88]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Nia_Opposition"] = true;`
- Węzeł `[89]` (Paskal Beniwoll): `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- Węzeł `[90]` (Paskal Beniwoll): `-- Start;`
- Węzeł `[100]` (Paskal Beniwoll): `Variable["BaseGame.Policy_Law_Ban_WPB"] = true; Variable["BaseGame.Sollist"] = Variable["BaseGame...`
- *...oraz 5 innych węzłów ze skryptami.*

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
  - -> `[90]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `33` (*Sordland/Turn03/A_AutocratDecree*), Węzeł `[42]`

### Węzeł `[3]`
Mówca: **Narrator**
> "They read the decree and discussed it amongst themselves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[4]`
Mówca: **Narrator**
> "After I made the final changes to the decree, I showed it to them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[5]`
Mówca: **Lucian Galade**
> ""Looks like the only thing left is to sign and declare the order, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Lucian spoke afterwards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[10]`
Mówca: **Lucian Galade**
> ""But I am afraid that this will create further problems for our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""Especially by declaring the Bludish separatists a threat, we should expect more violence against Bludish citizens in general.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Orso Hawker**
> ""What are you worried about? They are a national security threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Orso Hawker**
> ""We can't allow Bludish people to support terrorist organizations. They should have known better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[17]`
Mówca: **Lucian Galade**
> ""I agree with declaring the Young Sords as a threat, especially after the shooting. However, I think we might bring the nationalists wrath upon ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Orso Hawker**
> ""I believe Mr. Kibener may have connections to that organization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Orso Hawker**
> ""Although I have no problems with him, this should prompt a proper investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[20]`
Mówca: **Narrator**
> "Lucian looked at the decree again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""I agree. Anyone who have any connections to them should be investigated.""]** — Mówca: **Player**
> ""I agree. Anyone who have any connections to them should be investigated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
**[WYBÓR GRACZA: ""Maybe we can leave Mr. Kibener alone for now and keep it on the organization level.""]** — Mówca: **Player**
> ""Maybe we can leave Mr. Kibener alone for now and keep it on the organization level.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Narrator**
> "Lucian looked at the decree again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[27]`
Mówca: **Lucian Galade**
> ""Mr. President. We have to be careful with the situation we're creating here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Lucian Galade**
> ""Our actions against Arcasia will not be received lightly. Angering a superpower will be tough on our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[29]`
  - -> `[31]`

### Węzeł `[29]`
**[WYBÓR GRACZA: ""We'll no longer bow to them.""]** — Mówca: **Player**
> ""We'll no longer bow to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[30]`
**[WYBÓR GRACZA: ""We will take the proper precautions.""]** — Mówca: **Player**
> ""We will take the proper precautions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
**[WYBÓR GRACZA: ""I am aware, Lucian.""]** — Mówca: **Player**
> ""I am aware, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_UC == true && BaseGame.Reform_EmergencyDecree_Banned_RY)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_UC == true && BaseGame.Reform_EmergencyDecree_Banned_RY)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_UC == true && BaseGame.Reform_EmergencyDecree_Banned_RY))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[35]`
Mówca: **Lucian Galade**
> ""Going against United Contana and banning the Red Youth will definitely make us an enemy of the Contanan Security Pact.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Orso Hawker**
> ""What's important here is that we're taking the steps to fight against the communists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[37]`
Mówca: **Lucian Galade**
> ""We can't take this lightly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[41]`
Mówca: **Lucian Galade**
> ""But we're also acting against Arcasia, Mr. President. We'll need them against the Eastern powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Orso Hawker**
> ""I believe that was a difficult decision to make but Sordland stands alone, Mr. Galade, you know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[43]`
Mówca: **Orso Hawker**
> ""As much as I despise Arcasia and have a reason to believe that they're behind all this mess...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Orso Hawker**
> ""Mr. President decided not to act against them. If things comes to the worst, we'll have their protection, Mr. Galade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Orso Hawker**
> ""There's no reason to be afraid of those communists...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[49]`
Mówca: **Orso Hawker**
> ""With the order of this decree, we would be able to detain anybody who is suspected for a crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Orso Hawker**
> ""I will personally lead an investigation against Mr. Ricter. As soon as any other leads come up...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Orso Hawker**
> ""...We'll be able to get rid of him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[54]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Orso Hawker**
> ""Let's instead focus on what we will be doing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[53]`
**[WYBÓR GRACZA: ""Don't get carried away, he's not our main target.""]** — Mówca: **Player**
> ""Don't get carried away, he's not our main target.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[54]`
**[WYBÓR GRACZA: ""Yes, we must focus on the opposition.""]** — Mówca: **Player**
> ""Yes, we must focus on the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
**[WYBÓR GRACZA: ""I'm looking forward to that.""]** — Mówca: **Player**
> ""I'm looking forward to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[59]`
Mówca: **Orso Hawker**
> ""Whatever you say, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[60]`
Mówca: **Orso Hawker**
> ""Luckily, the police will have the authority to deal with the threats now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Orso Hawker**
> ""But I still do not think that the police has the necessary powers to eliminate the threats effectively.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[65]`
Mówca: **Lucian Galade**
> ""Well, I think suspension of protests and gathering of crowds will be very tough on the budget of the police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Lucian Galade**
> ""And the people will not like this. Especially the reformists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Orso Hawker**
> ""I hope the precautions will prove to be enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[68]`
Mówca: **Orso Hawker**
> ""That's precisely who we are against, Mr. Galade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Lucian Galade**
> ""In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Lucian Galade**
> ""What's left to do is to declare the emergency and get it accepted in the Supreme Court, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Lucian Galade**
> ""We should plan your speech for the declaration. This will be a big moment for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Narrator**
> "We all shook hands and they left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[73]`
Mówca: **Orso Hawker**
> ""I'll be in touch, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Orso Hawker**
> ""The Supreme Court will be waiting for the declaration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`
  - -> `[77]`
  - -> `[78]`

### Węzeł `[75]`
**[WYBÓR GRACZA: ""I expect the Court to fulfil their promise.""]** — Mówca: **Player**
> ""I expect the Court to fulfil their promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[76]`
**[WYBÓR GRACZA: ""Let's get to work gentlemen.""]** — Mówca: **Player**
> ""Let's get to work gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[77]`
**[WYBÓR GRACZA: ""Thank you for all the hard work.""]** — Mówca: **Player**
> ""Thank you for all the hard work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[78]`
**[WYBÓR GRACZA: ""A new era begins.""]** — Mówca: **Player**
> ""A new era begins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Lucian Galade**
> ""It seems so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[80]`
Mówca: **Orso Hawker**
> ""Of course, Mr. President. We are working together in this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_A_Constitution = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_A_Constitution"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn03_EmergencyDecree_Autocrat = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn03_EmergencyDecree_Autocrat"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_InternalPeace_Deal_A = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_InternalPeace_Deal_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_RayneIgnores_NoDeal_A = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_RayneIgnores_NoDeal_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Nia_Opposition = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Nia_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Economy -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // Start)*
- **Efekt (`userScript`):** `-- Start;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_WPB = true;
BaseGame.Sollist += 2;
BaseGame.Democratic -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Law_Ban_WPB"] = true;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_RedYouth = true;
BaseGame.Malenyevist -= 2;
BaseGame.Sollist += 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Law_Ban_RedYouth"] = true;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_YoungSords = true;
BaseGame.Malenyevist += 2;
BaseGame.Sollist -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Law_Ban_YoungSords"] = true;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_EmergencyDecree = true; BaseGame.Faction_OldGuard_Content = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Law_EmergencyDecree"] = true;
Variable["BaseGame.Faction_OldGuard_Content"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Ban_RedYouth = true;
BaseGame.Policy_Law_Ban_YoungSords = true;
BaseGame.Malenyevist -= 2;
BaseGame.Democratic -= 2;
BaseGame.Sollist -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Law_Ban_RedYouth"] = true;
Variable["BaseGame.Policy_Law_Ban_YoungSords"] = true;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 2;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Market == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Market == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true || BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true || 
BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true || BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true || 
BaseGame.Reform_EmergencyDecree_Embargo_UC == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  or  
Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true || BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true || 
BaseGame.Reform_EmergencyDecree_Embargo_UC == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  or  
Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_None = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_None"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
