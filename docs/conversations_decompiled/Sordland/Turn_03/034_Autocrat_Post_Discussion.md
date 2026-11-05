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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[21]` | **""I agree. Anyone who have any connections to them should be investigated.""** | `[19]` **Orso Hawker**: ""Although I have no problems wit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Lucian Galade**: ""Mr. President. We have to be ca..."<br>`[36]` **Orso Hawker**: ""What's important here is that w..."<br>*(oraz 1 innych odgałęzień)* |
| `[22]` | **""Maybe we can leave Mr. Kibener alone for now and keep it on the organization level.""** | `[19]` **Orso Hawker**: ""Although I have no problems wit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Lucian Galade**: ""Mr. President. We have to be ca..."<br>`[36]` **Orso Hawker**: ""What's important here is that w..."<br>*(oraz 1 innych odgałęzień)* |
| `[29]` | **""We'll no longer bow to them.""** | `[28]` **Lucian Galade**: ""Our actions against Arcasia wil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Orso Hawker**: ""What's important here is that w..."<br>`[49]` **Orso Hawker**: ""With the order of this decree, ..."<br>*(oraz 2 innych odgałęzień)* |
| `[30]` | **""We will take the proper precautions.""** | `[28]` **Lucian Galade**: ""Our actions against Arcasia wil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Orso Hawker**: ""What's important here is that w..."<br>`[49]` **Orso Hawker**: ""With the order of this decree, ..."<br>*(oraz 2 innych odgałęzień)* |
| `[31]` | **""I am aware, Lucian.""** | `[28]` **Lucian Galade**: ""Our actions against Arcasia wil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Orso Hawker**: ""What's important here is that w..."<br>`[49]` **Orso Hawker**: ""With the order of this decree, ..."<br>*(oraz 2 innych odgałęzień)* |
| `[53]` | **""Don't get carried away, he's not our main target.""** | `[51]` **Orso Hawker**: ""...We'll be able to get rid of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Orso Hawker**: ""Whatever you say, Mr. President."" |
| `[54]` | **""Yes, we must focus on the opposition.""** | `[51]` **Orso Hawker**: ""...We'll be able to get rid of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Orso Hawker**: ""Luckily, the police will have t..."<br>`[61]` **Orso Hawker**: ""But I still do not think that t..." |
| `[55]` | **""I'm looking forward to that.""** | `[51]` **Orso Hawker**: ""...We'll be able to get rid of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Orso Hawker**: ""Luckily, the police will have t..."<br>`[61]` **Orso Hawker**: ""But I still do not think that t..." |
| `[75]` | **""I expect the Court to fulfil their promise.""** | `[74]` **Orso Hawker**: ""The Supreme Court will be waiti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Orso Hawker**: ""Of course, Mr. President. We ar..." |
| `[76]` | **""Let's get to work gentlemen.""** | `[74]` **Orso Hawker**: ""The Supreme Court will be waiti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "We all shook hands and they left..." |
| `[77]` | **""Thank you for all the hard work.""** | `[74]` **Orso Hawker**: ""The Supreme Court will be waiti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "We all shook hands and they left..." |
| `[78]` | **""A new era begins.""** | `[74]` **Orso Hawker**: ""The Supreme Court will be waiti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Lucian Galade**: ""It seems so."" |

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
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "// Start"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Orso Hawker: ""I believe that was a difficult decision to make but Sord..."*)

### Węzeł `[3]`
Mówca: **Narrator**
> "They read the decree and discussed it amongst themselves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Lucian spoke afterwards."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "After I made the final changes to the decree, I showed it to them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "They read the decree and discussed it amongst themselves."*)

### Węzeł `[5]`
Mówca: **Lucian Galade**
> ""Looks like the only thing left is to sign and declare the order, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Lucian spoke afterwards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Lucian Galade: ""Looks like the only thing left is to sign and declare th..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucian Galade: ""But I am afraid that this will create further problems f..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[10]`
Mówca: **Lucian Galade**
> ""But I am afraid that this will create further problems for our administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Lucian Galade: ""Especially by declaring the Bludish separatists a threat..."*)

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""Especially by declaring the Bludish separatists a threat, we should expect more violence against Bludish citizens in general.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Orso Hawker: ""What are you worried about? They are a national security..."*)

### Węzeł `[12]`
Mówca: **Orso Hawker**
> ""What are you worried about? They are a national security threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Orso Hawker: ""We can't allow Bludish people to support terrorist organ..."*)

### Węzeł `[13]`
Mówca: **Orso Hawker**
> ""We can't allow Bludish people to support terrorist organizations. They should have known better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "Lucian looked at the decree again."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Lucian looked at the decree again."*)

### Węzeł `[17]`
Mówca: **Lucian Galade**
> ""I agree with declaring the Young Sords as a threat, especially after the shooting. However, I think we might bring the nationalists wrath upon ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Orso Hawker: ""I believe Mr. Kibener may have connections to that organ..."*)

### Węzeł `[18]`
Mówca: **Orso Hawker**
> ""I believe Mr. Kibener may have connections to that organization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Orso Hawker: ""Although I have no problems with him, this should prompt..."*)

### Węzeł `[19]`
Mówca: **Orso Hawker**
> ""Although I have no problems with him, this should prompt a proper investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""I agree. Anyone who have any connections to them should ..."*)
  - -> `[22]` (*Player: ""Maybe we can leave Mr. Kibener alone for now and keep it..."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "Lucian looked at the decree again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucian Galade: ""I agree with declaring the Young Sords as a threat, espe..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""I agree. Anyone who have any connections to them should be investigated.""]** — Mówca: **Player**
> ""I agree. Anyone who have any connections to them should be investigated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)

### Węzeł `[22]`
**[WYBÓR GRACZA: ""Maybe we can leave Mr. Kibener alone for now and keep it on the organization level.""]** — Mówca: **Player**
> ""Maybe we can leave Mr. Kibener alone for now and keep it on the organization level.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)

### Węzeł `[23]`
Mówca: **Narrator**
> "Lucian looked at the decree again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Lucian Galade: ""Mr. President. We have to be careful with the situation ..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true && Bas..."*)

### Węzeł `[27]`
Mówca: **Lucian Galade**
> ""Mr. President. We have to be careful with the situation we're creating here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucian Galade: ""Our actions against Arcasia will not be received lightly..."*)

### Węzeł `[28]`
Mówca: **Lucian Galade**
> ""Our actions against Arcasia will not be received lightly. Angering a superpower will be tough on our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""We will take the proper precautions.""*)
  - -> `[29]` (*Player: ""We'll no longer bow to them.""*)
  - -> `[31]` (*Player: ""I am aware, Lucian.""*)

### Węzeł `[29]`
**[WYBÓR GRACZA: ""We'll no longer bow to them.""]** — Mówca: **Player**
> ""We'll no longer bow to them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true && Bas..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: ""We will take the proper precautions.""]** — Mówca: **Player**
> ""We will take the proper precautions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true && Bas..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: ""I am aware, Lucian.""]** — Mówca: **Player**
> ""I am aware, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true && Bas..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true && BaseGame.Reform_EmergencyDecree_Banned_RY`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_UC == true && Bas..."*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true && B..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_UC == true && BaseGame.Reform_EmergencyDecree_Banned_RY`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Orso Hawker: ""What's important here is that we're taking the steps to ..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_UC == true && BaseGame.Reform_EmergencyDecree_Banned_RY)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[35]`
Mówca: **Lucian Galade**
> ""Going against United Contana and banning the Red Youth will definitely make us an enemy of the Contanan Security Pact.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucian Galade: ""We can't take this lightly.""*)

### Węzeł `[36]`
Mówca: **Orso Hawker**
> ""What's important here is that we're taking the steps to fight against the communists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Lucian Galade: ""Going against United Contana and banning the Red Youth w..."*)

### Węzeł `[37]`
Mówca: **Lucian Galade**
> ""We can't take this lightly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: ""But we're also acting against Arcasia, Mr. President. We..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Orso Hawker: ""As much as I despise Arcasia and have a reason to believ..."*)

### Węzeł `[41]`
Mówca: **Lucian Galade**
> ""But we're also acting against Arcasia, Mr. President. We'll need them against the Eastern powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Orso Hawker: ""I believe that was a difficult decision to make but Sord..."*)

### Węzeł `[42]`
Mówca: **Orso Hawker**
> ""I believe that was a difficult decision to make but Sordland stands alone, Mr. Galade, you know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Orso Hawker: ""Let's instead focus on what we will be doing.""*)

### Węzeł `[43]`
Mówca: **Orso Hawker**
> ""As much as I despise Arcasia and have a reason to believe that they're behind all this mess...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Orso Hawker: ""Mr. President decided not to act against them. If things..."*)

### Węzeł `[44]`
Mówca: **Orso Hawker**
> ""Mr. President decided not to act against them. If things comes to the worst, we'll have their protection, Mr. Galade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Orso Hawker: ""There's no reason to be afraid of those communists...""*)

### Węzeł `[45]`
Mówca: **Orso Hawker**
> ""There's no reason to be afraid of those communists...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Orso Hawker: ""Let's instead focus on what we will be doing.""*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial =..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Orso Hawker: ""With the order of this decree, we would be able to detai..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true"*)

### Węzeł `[49]`
Mówca: **Orso Hawker**
> ""With the order of this decree, we would be able to detain anybody who is suspected for a crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Orso Hawker: ""I will personally lead an investigation against Mr. Rict..."*)

### Węzeł `[50]`
Mówca: **Orso Hawker**
> ""I will personally lead an investigation against Mr. Ricter. As soon as any other leads come up...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Orso Hawker: ""...We'll be able to get rid of him.""*)

### Węzeł `[51]`
Mówca: **Orso Hawker**
> ""...We'll be able to get rid of him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: ""I'm looking forward to that.""*)
  - -> `[54]` (*Player: ""Yes, we must focus on the opposition.""*)
  - -> `[53]` (*Player: ""Don't get carried away, he's not our main target.""*)

### Węzeł `[52]`
Mówca: **Orso Hawker**
> ""Let's instead focus on what we will be doing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: ""Don't get carried away, he's not our main target.""]** — Mówca: **Player**
> ""Don't get carried away, he's not our main target.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Orso Hawker: ""Whatever you say, Mr. President.""*)

### Węzeł `[54]`
**[WYBÓR GRACZA: ""Yes, we must focus on the opposition.""]** — Mówca: **Player**
> ""Yes, we must focus on the opposition.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true"*)

### Węzeł `[55]`
**[WYBÓR GRACZA: ""I'm looking forward to that.""]** — Mówca: **Player**
> ""I'm looking forward to that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_PoliceAuthority == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_PoliceAuthority == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Orso Hawker: ""Luckily, the police will have the authority to deal with..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Orso Hawker: ""But I still do not think that the police has the necessa..."*)

### Węzeł `[59]`
Mówca: **Orso Hawker**
> ""Whatever you say, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true"*)

### Węzeł `[60]`
Mówca: **Orso Hawker**
> ""Luckily, the police will have the authority to deal with the threats now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)

### Węzeł `[61]`
Mówca: **Orso Hawker**
> ""But I still do not think that the police has the necessary powers to eliminate the threats effectively.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Orso Hawker: ""I hope the precautions will prove to be enough.""*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Lucian Galade: ""Well, I think suspension of protests and gathering of cr..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lucian Galade: ""In any case...""*)

### Węzeł `[65]`
Mówca: **Lucian Galade**
> ""Well, I think suspension of protests and gathering of crowds will be very tough on the budget of the police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucian Galade: ""And the people will not like this. Especially the reform..."*)

### Węzeł `[66]`
Mówca: **Lucian Galade**
> ""And the people will not like this. Especially the reformists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Orso Hawker: ""That's precisely who we are against, Mr. Galade.""*)

### Węzeł `[67]`
Mówca: **Orso Hawker**
> ""I hope the precautions will prove to be enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)

### Węzeł `[68]`
Mówca: **Orso Hawker**
> ""That's precisely who we are against, Mr. Galade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lucian Galade: ""In any case...""*)

### Węzeł `[69]`
Mówca: **Lucian Galade**
> ""In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: ""What's left to do is to declare the emergency and get it..."*)

### Węzeł `[70]`
Mówca: **Lucian Galade**
> ""What's left to do is to declare the emergency and get it accepted in the Supreme Court, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lucian Galade: ""We should plan your speech for the declaration. This wil..."*)

### Węzeł `[71]`
Mówca: **Lucian Galade**
> ""We should plan your speech for the declaration. This will be a big moment for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Orso Hawker: ""I'll be in touch, Mr. President.""*)

### Węzeł `[72]`
Mówca: **Narrator**
> "We all shook hands and they left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Nia_Opposition = true"*)

### Węzeł `[73]`
Mówca: **Orso Hawker**
> ""I'll be in touch, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Orso Hawker: ""The Supreme Court will be waiting for the declaration.""*)

### Węzeł `[74]`
Mówca: **Orso Hawker**
> ""The Supreme Court will be waiting for the declaration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player: ""I expect the Court to fulfil their promise.""*)
  - -> `[76]` (*Player: ""Let's get to work gentlemen.""*)
  - -> `[77]` (*Player: ""Thank you for all the hard work.""*)
  - -> `[78]` (*Player: ""A new era begins.""*)

### Węzeł `[75]`
**[WYBÓR GRACZA: ""I expect the Court to fulfil their promise.""]** — Mówca: **Player**
> ""I expect the Court to fulfil their promise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Orso Hawker: ""Of course, Mr. President. We are working together in this.""*)

### Węzeł `[76]`
**[WYBÓR GRACZA: ""Let's get to work gentlemen.""]** — Mówca: **Player**
> ""Let's get to work gentlemen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "We all shook hands and they left the room."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: ""Thank you for all the hard work.""]** — Mówca: **Player**
> ""Thank you for all the hard work.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "We all shook hands and they left the room."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: ""A new era begins.""]** — Mówca: **Player**
> ""A new era begins.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucian Galade: ""It seems so.""*)

### Węzeł `[79]`
Mówca: **Lucian Galade**
> ""It seems so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "We all shook hands and they left the room."*)

### Węzeł `[80]`
Mówca: **Orso Hawker**
> ""Of course, Mr. President. We are working together in this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "We all shook hands and they left the room."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_A_Constitution = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_A_Constitution"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn03_EmergencyDecree_Autocrat = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn03_EmergencyDecree_Autocrat"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "After I made the final changes to the decree, I showed it..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_InternalPeace_Deal_A = true"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_RayneIgnores_NoDeal_A = true"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_InternalPeace_Deal_A = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_InternalPeace_Deal_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_Constitution = true"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_RayneIgnores_NoDeal_A = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_RayneIgnores_NoDeal_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_Constitution = true"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Nia_Opposition = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Nia_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Start`
- **Efekt skryptowy (`userScript`):** `-- Start;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_WPB = true; BaseGame.Sollist += 2..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_RedYouth = true; BaseGame.Malenye..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_YoungSords = true; BaseGame.Malen..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_EmergencyDecree = true; BaseGame.Fact..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_WPB = true;
BaseGame.Sollist += 2;
BaseGame.Democratic -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Law_Ban_WPB"] = true;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_RedYouth = true;
BaseGame.Malenyevist -= 2;
BaseGame.Sollist += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Law_Ban_RedYouth"] = true;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_EmergencyDecree = true; BaseGame.Fact..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_YoungSords = true;
BaseGame.Malenyevist += 2;
BaseGame.Sollist -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Law_Ban_YoungSords"] = true;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_EmergencyDecree = true; BaseGame.Fact..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_EmergencyDecree = true; BaseGame.Faction_OldGuard_Content = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Law_EmergencyDecree"] = true;
Variable["BaseGame.Faction_OldGuard_Content"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true |..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true && Ba..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_RedYouth = true; BaseGame.Policy_..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_RedYouth = true;
BaseGame.Policy_Law_Ban_YoungSords = true;
BaseGame.Malenyevist -= 2;
BaseGame.Democratic -= 2;
BaseGame.Sollist -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Law_Ban_RedYouth"] = true;
Variable["BaseGame.Policy_Law_Ban_YoungSords"] = true;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 2;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_EmergencyDecree = true; BaseGame.Fact..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy -= 1"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true || BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true || 
BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true |..."*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true || BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true || 
BaseGame.Reform_EmergencyDecree_Embargo_UC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  or  
Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn03_EmergencyDecree_Autocrat =..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == true || BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true || 
BaseGame.Reform_EmergencyDecree_Embargo_UC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true  or  
Variable["BaseGame.Reform_EmergencyDecree_Embargo_UC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_None = true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_None = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_None"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn03_EmergencyDecree_Autocrat =..."*)
