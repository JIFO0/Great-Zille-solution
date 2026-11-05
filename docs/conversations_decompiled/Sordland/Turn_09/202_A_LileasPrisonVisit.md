# Sordland/Turn09/A_LileasPrisonVisit

- **ID konwersacji:** `202`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/202_A_LileasPrisonVisit.md`
- **Liczba węzłów dialogowych:** 179
- **Liczba wyborów gracza:** 25

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[44]** Lileas Graf

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Democratic`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Joined_ATO`
- `BaseGame.Joined_CSP`
- `BaseGame.LeakedScandals_Severity`
- `BaseGame.Malenyevist`
- `BaseGame.Policy_Diplomacy_ATO`
- `BaseGame.Policy_Diplomacy_CSP`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_Law_Threshold_15`
- `BaseGame.Reform_Law_Threshold_Default`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Turn07_Detained_MarcelKoronti`
- `BaseGame.Turn07_Detained_WalterTusk`
- `BaseGame.Turn07_SecretState_Detained_FrensRicter`
- `BaseGame.Turn07_SecretState_Detained_KesaroKibener`
- `BaseGame.Turn08_SecondScandal_Detained_Livia`
- `BaseGame.Turn08_SecondScandal_Detained_Petr`
- `BaseGame.Turn08_SecondScandal_LiviaTrialled`
- `BaseGame.Turn08_SecondScandal_PetrTrialled`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr`
- `BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro`
- `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso`
- `BaseGame.Turn09_A_Investigation_Oligarchs_MarcelTrialled`
- `BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk`
- `BaseGame.Turn09_A_Investigation_PFJP_RicterFramed`
- `BaseGame.Turn09_A_MarcelArrested`
- `BaseGame.Turn09_Military_WeakAgainstRumburg`
- `BaseGame.YoungSords_Kill_OrsoHawker`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Death`
- `BaseGameSupport.Journal_Turn09_LileasDiscussion_Trial`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameSupport.News_Turn09_HP_Lileas_Jailed`
- `BaseGameSupport.News_Turn09_ST_Lileas_Jailed`
- `BaseGameSupport.Report_Turn09_Conriat_CSPShips`
- `BaseGameSupport.Report_Turn09_Erlory_ATOPlanes`
- `BaseGameSupport.Report_Turn09_Holsord_WPB_CPS_InTalks`
- `GameCondition.Turn09_A_LileasDiscussion`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[65]` | **""Hello, Lileas.""** | `[64]` **Narrator**: "She appeared to be busy writing ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Lileas Graf**: ""Mr. President. What brings you ..." |
| `[66]` | **""Who are you writing to?""** | `[64]` **Narrator**: "She appeared to be busy writing ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Lileas Graf**: ""Just catching up with a few old..." |
| `[67]` | **""Stop writing at once and speak to me.""** | `[64]` **Narrator**: "She appeared to be busy writing ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Lileas Graf**: ""No need for the imperatives. Yo..." |
| `[72]` | **""Why did you kill Bernard Circas?""** | `[68]` **Lileas Graf**: ""Mr. President. What brings you ..."<br>`[70]` **Lileas Graf**: ""What brings you all this way, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Lileas Graf**: ""I thought you already knew the ..." |
| `[73]` | **""You spent my entire term trying to undermine me. Why?""** | `[68]` **Lileas Graf**: ""Mr. President. What brings you ..."<br>`[70]` **Lileas Graf**: ""What brings you all this way, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Lileas Graf**: ""I thought you already knew the ..." |
| `[74]` | **""Who was really behind the Circas assassination?""** | `[68]` **Lileas Graf**: ""Mr. President. What brings you ..."<br>`[70]` **Lileas Graf**: ""What brings you all this way, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "Lileas blinked and smiled benignly." |
| `[79]` | **""But whose idea was it, really?""** | `[78]` **Lileas Graf**: ""I thought the court already est..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Lileas Graf**: ""I know what you're implying."" |
| `[80]` | **""Come off it, Lileas. How long have you been Soll's puppet?""** | `[78]` **Lileas Graf**: ""I thought the court already est..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Narrator**: "Lileas drew herself up, her back..." |
| `[94]` | **""The Sordish people wanted change. You can't just disregard their will.""** | `[93]` **Lileas Graf**: ""Without our interference, who k..."<br>`[118]` **Lileas Graf**: ""As I tried to tell you many tim..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Lileas Graf**: ""The people don't always know be..." |
| `[95]` | **""I'm the President, and I wanted change. You can't just disregard my will.""** | `[93]` **Lileas Graf**: ""Without our interference, who k..."<br>`[118]` **Lileas Graf**: ""As I tried to tell you many tim..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Lileas Graf**: ""The President doesn't always kn..." |
| `[106]` | **""I'm going to crush Rumburg. Just like I crushed you and the rest of the Old Guard.""** | `[104]` **Lileas Graf**: ""As shown by their willingness t..."<br>`[105]` **Lileas Graf**: ""As shown by your leading the co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Lileas Graf**: ""You're going to regret that. So..." |
| `[107]` | **""They knew enough to vote me in. And I knew enough to force you out.""** | `[100]` **Lileas Graf**: ""The people don't always know be..." | `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_CSP"] == false) == false` | *Brak zmian stanu* | `[109]` **Lileas Graf**: ""You're going to regret that. So..." |
| `[108]` | **""I knew enough to get rid of you and the rest of your Old Guard chums.""** | `[99]` **Lileas Graf**: ""The President doesn't always kn..." | `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_CSP"] == false) == false` | *Brak zmian stanu* | `[109]` **Lileas Graf**: ""You're going to regret that. So..." |
| `[110]` | **""And you think you would have done a better job?""** | `[104]` **Lileas Graf**: ""As shown by their willingness t..."<br>`[105]` **Lileas Graf**: ""As shown by your leading the co..."<br>*(oraz 2 innych węzłów)* | `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_CSP"] == false) == false` | *Brak zmian stanu* | `[111]` **Lileas Graf**: ""I would not have let our proud ..." |
| `[112]` | **""Have you always been Soll's puppet? Or just since you entered my cabinet?""** | `[109]` **Lileas Graf**: ""You're going to regret that. So..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Narrator**: "Lileas drew herself up, her back..." |
| `[113]` | **""To hell with Soll, and to hell with you.""** | `[109]` **Lileas Graf**: ""You're going to regret that. So..."<br>`[111]` **Lileas Graf**: ""I would not have let our proud ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Narrator**: "Lileas drew herself up, her back..." |
| `[125]` | **""Is that what you're writing? An obituary for your beloved Tarquin Soll?""** | `[109]` **Lileas Graf**: ""You're going to regret that. So..."<br>`[111]` **Lileas Graf**: ""I would not have let our proud ..." | `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true` | *Brak zmian stanu* | `[81]` **Lileas Graf**: ""I know what you're implying."" |
| `[127]` | **""That decision wasn't yours to make.""** | `[126]` **Lileas Graf**: ""Including the decision to sacri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Lileas Graf**: ""History will redeem me. Even if..." |
| `[128]` | **""Save them from what, Lileas?""** | `[126]` **Lileas Graf**: ""Including the decision to sacri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Narrator**: "Lileas' face darkened." |
| `[129]` | **""I thought you religious freaks were against playing God.""** | `[126]` **Lileas Graf**: ""Including the decision to sacri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Lileas Graf**: ""Mr. Rayne. Did you really take ..." |
| `[132]` | **""I-- I suppose I did.""** | `[114]` **Lileas Graf**: ""Mr. Rayne. Did you really take ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Lileas Graf**: ""Then allow me to return the fav..." |
| `[133]` | **""Of course not. I just wanted to understand your motivations.""** | `[114]` **Lileas Graf**: ""Mr. Rayne. Did you really take ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Lileas Graf**: ""My motivations are and have alw..." |
| `[137]` | **""Is that who those letters are for? Your beloved Tarquin Soll?""** | `[109]` **Lileas Graf**: ""You're going to regret that. So..."<br>`[111]` **Lileas Graf**: ""I would not have let our proud ..." | `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false` | *Brak zmian stanu* | `[81]` **Lileas Graf**: ""I know what you're implying."" |
| `[148]` | **""Guards! Take this woman's pens and paper away. They're too dangerous to have lyin..."** | `[145]` **Lileas Graf**: ""You're hanging on by a thread, ..."<br>`[147]` **Lileas Graf**: ""Sooner or later, the people wil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Narrator**: "The guards moved in and roughly ..." |
| `[149]` | **""I've had enough of this. I'm leaving.""** | `[145]` **Lileas Graf**: ""You're hanging on by a thread, ..."<br>`[147]` **Lileas Graf**: ""Sooner or later, the people wil..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Narrator**: "Lileas nodded and turned back to..." |

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
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_LileasDiscussion_Trial == ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn09_A_LileasDiscussion = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn09_A_LileasDiscussion"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && ..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The thrum of the helicopter engine, the first of its kind in Sordland, was deafening as we touched down on the landing pad of Antel Rock Prison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "I stepped out, bracing myself against the salty winds. Th..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "I stepped out, bracing myself against the salty winds. The noise of the helicopter was replaced by that of squawking seabirds and waves furiously crashing on the jagged rocks below."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Flanked by my guards, I walked into Antel Rock Prison."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Flanked by my guards, I walked into Antel Rock Prison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "A team of security personnel led me through the winding c..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "A team of security personnel led me through the winding corridors on the ground floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrTrialled == true || Bas..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrTrialled == true || BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrTrialled == true || Bas..."*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_PetrTrialled == true || B..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrTrialled == true || BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Passing by the rows of cells, I wondered how Petr was doing."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_PetrTrialled == true || BaseGame.Turn08_SecondScandal_Detained_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_Detained_Petr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Livia == true || B..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "Passing by the rows of cells, I wondered how Petr was doing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Livia == true || B..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "And Orso Hawker..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "At the back of the building, we came to an elevator. The guards punched in a code, and we rode all the way to the top floor of the prison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "Lileas had a corner cell, with large windows overlooking ..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Livia == true || B..."*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_Detained_Livia == true ||..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Passing by the rows of cells, I wondered how Livia was do..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MarcelKoronti == true || BaseGam..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Livia == true || B..."*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_Detained_Livia == true ||..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "And Livia..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MarcelKoronti == true || BaseGam..."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "And Livia..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MarcelKoronti == true || BaseGam..."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "Passing by the rows of cells, I wondered how Livia was doing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MarcelKoronti == true || BaseGam..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_MarcelKoronti == true || BaseGame.Turn09_A_MarcelArrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MarcelKoronti == true || BaseGam..."*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Detained_MarcelKoronti == true || BaseG..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_MarcelKoronti == true || BaseGame.Turn09_A_MarcelArrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true  or  Variable["BaseGame.Turn09_A_MarcelArrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "And Marcel..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Detained_MarcelKoronti == true || BaseGame.Turn09_A_MarcelArrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true  or  Variable["BaseGame.Turn09_A_MarcelArrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.T..."*)

### Węzeł `[25]`
Mówca: **Narrator**
> "And Marcel..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.T..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_MarcelKoronti == true || BaseGame.Turn09_A_MarcelArrested == true || BaseGame.Turn09_A_Investigation_Oligarchs_MarcelTrialled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MarcelKoronti == true || BaseGam..."*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Detained_MarcelKoronti == true || BaseG..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_MarcelKoronti == true || BaseGame.Turn09_A_MarcelArrested == true || BaseGame.Turn09_A_Investigation_Oligarchs_MarcelTrialled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true  or  Variable["BaseGame.Turn09_A_MarcelArrested"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_MarcelTrialled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "Passing by the rows of cells, I wondered how Marcel was d..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Detained_MarcelKoronti == true || BaseGame.Turn09_A_MarcelArrested == true || BaseGame.Turn09_A_Investigation_Oligarchs_MarcelTrialled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true  or  Variable["BaseGame.Turn09_A_MarcelArrested"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_MarcelTrialled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.T..."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "Passing by the rows of cells, I wondered how Marcel was doing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.T..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.T..."*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Detained_WalterTusk == true || BaseGame..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Passing by the rows of cells, I wondered how Walter Tusk ..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso == tr..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "Passing by the rows of cells, I wondered how Walter Tusk was doing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso == tr..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "And Walter..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso == tr..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.T..."*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Detained_WalterTusk == true || BaseGame..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "And Walter..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Detained_WalterTusk == true || BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Trial_Tusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso == tr..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso == true && BaseGame.YoungSords_Kill_OrsoHawker == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso == tr..."*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso == ..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso == true && BaseGame.YoungSords_Kill_OrsoHawker == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso"] == true  and  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "And Orso Hawker..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso == true && BaseGame.YoungSords_Kill_OrsoHawker == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso"] == true  and  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "Passing by the rows of cells, I wondered how Orso Hawker was doing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso == true && BaseGame.YoungSords_Kill_OrsoHawker == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso == tr..."*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso == ..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso == true && BaseGame.YoungSords_Kill_OrsoHawker == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso"] == true  and  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Passing by the rows of cells, I wondered how Orso Hawker ..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso == true && BaseGame.YoungSords_Kill_OrsoHawker == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Orso"] == true  and  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Detained_FrensRicter == tru..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn09_A_Investigation_PFJP_RicterFramed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "And Frens Ricter..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn09_A_Investigation_PFJP_RicterFramed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "And Frens Ricter..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Detained_FrensRicter == tru..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn09_A_Investigation_PFJP_RicterFramed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "Passing by the rows of cells, I wondered how Frens Ricter..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn09_A_Investigation_PFJP_RicterFramed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn09_A_Investigation_PFJP_RicterFramed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Detained_KesaroKibener == t..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "And Kesaro Kibener..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "But that wasn't who I was here to see."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "And Kesaro Kibener..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "But that wasn't who I was here to see."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "Passing by the rows of cells, I wondered how Frens Ricter was doing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Detained_KesaroKibener == t..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "Passing by the rows of cells, I wondered how Kesaro Kiben..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn09_A_Investigation_NFP_Trialled_RemusAndKesaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "Passing by the rows of cells, I heard prisoners pounding ..."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "Passing by the rows of cells, I wondered how Kesaro Kibener was doing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "But that wasn't who I was here to see."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "But that wasn't who I was here to see."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "At the back of the building, we came to an elevator. The ..."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "Passing by the rows of cells, I heard prisoners pounding on their doors and pleading me for a pardon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "At the back of the building, we came to an elevator. The ..."*)

### Węzeł `[63]`
Mówca: **Narrator**
> "Lileas had a corner cell, with large windows overlooking the seaside. It was equipped with a comfortable-looking bed and a modest writing desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Lileas Graf", "Inmate 64498");"*)

### Węzeł `[64]`
Mówca: **Narrator**
> "She appeared to be busy writing letters as the guards opened the door to the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: ""Hello, Lileas.""*)
  - -> `[66]` (*Player: ""Who are you writing to?""*)
  - -> `[67]` (*Player: ""Stop writing at once and speak to me.""*)

### Węzeł `[65]`
**[WYBÓR GRACZA: ""Hello, Lileas.""]** — Mówca: **Player**
> ""Hello, Lileas.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lileas Graf: ""Mr. President. What brings you all this way?""*)

### Węzeł `[66]`
**[WYBÓR GRACZA: ""Who are you writing to?""]** — Mówca: **Player**
> ""Who are you writing to?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lileas Graf: ""Just catching up with a few old friends.""*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""Stop writing at once and speak to me.""]** — Mówca: **Player**
> ""Stop writing at once and speak to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lileas Graf: ""No need for the imperatives. You already have me in a pr..."*)

### Węzeł `[68]`
Mówca: **Lileas Graf**
> ""Mr. President. What brings you all this way?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player: ""Why did you kill Bernard Circas?""*)
  - -> `[73]` (*Player: ""You spent my entire term trying to undermine me. Why?""*)
  - -> `[74]` (*Player: ""Who was really behind the Circas assassination?""*)

### Węzeł `[69]`
Mówca: **Lileas Graf**
> ""Just catching up with a few old friends.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lileas Graf: ""What brings you all this way, Mr. President?""*)

### Węzeł `[70]`
Mówca: **Lileas Graf**
> ""What brings you all this way, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player: ""Why did you kill Bernard Circas?""*)
  - -> `[73]` (*Player: ""You spent my entire term trying to undermine me. Why?""*)
  - -> `[74]` (*Player: ""Who was really behind the Circas assassination?""*)

### Węzeł `[71]`
Mówca: **Lileas Graf**
> ""No need for the imperatives. You already have me in a prison cell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lileas Graf: ""What brings you all this way, Mr. President?""*)

### Węzeł `[72]`
**[WYBÓR GRACZA: ""Why did you kill Bernard Circas?""]** — Mówca: **Player**
> ""Why did you kill Bernard Circas?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Lileas Graf), `[70]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lileas Graf: ""I thought you already knew the answer to that.""*)

### Węzeł `[73]`
**[WYBÓR GRACZA: ""You spent my entire term trying to undermine me. Why?""]** — Mówca: **Player**
> ""You spent my entire term trying to undermine me. Why?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Lileas Graf), `[70]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lileas Graf: ""I thought you already knew the answer to that.""*)

### Węzeł `[74]`
**[WYBÓR GRACZA: ""Who was really behind the Circas assassination?""]** — Mówca: **Player**
> ""Who was really behind the Circas assassination?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Lileas Graf), `[70]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "Lileas blinked and smiled benignly."*)

### Węzeł `[75]`
Mówca: **Lileas Graf**
> ""I thought you already knew the answer to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lileas Graf: ""I and my colleagues judged you to be a threat to Sordlan..."*)

### Węzeł `[76]`
Mówca: **Lileas Graf**
> ""I and my colleagues judged you to be a threat to Sordland. From the start of your term, we felt you were putting the country at risk of succumbing to outside influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist > 5 || BaseGame.Democratic > 5 || (B..."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "Lileas blinked and smiled benignly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lileas Graf: ""I thought the court already established that during my t..."*)

### Węzeł `[78]`
Mówca: **Lileas Graf**
> ""I thought the court already established that during my trial. I drafted the order to the Young Sords, Hawker signed off on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: ""But whose idea was it, really?""*)
  - -> `[80]` (*Player: ""Come off it, Lileas. How long have you been Soll's puppet?""*)

### Węzeł `[79]`
**[WYBÓR GRACZA: ""But whose idea was it, really?""]** — Mówca: **Player**
> ""But whose idea was it, really?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lileas Graf: ""I know what you're implying.""*)

### Węzeł `[80]`
**[WYBÓR GRACZA: ""Come off it, Lileas. How long have you been Soll's puppet?""]** — Mówca: **Player**
> ""Come off it, Lileas. How long have you been Soll's puppet?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Lileas drew herself up, her back straight as a rod."*)

### Węzeł `[81]`
Mówca: **Lileas Graf**
> ""I know what you're implying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Lileas drew herself up, her back straight as a rod."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "Lileas drew herself up, her back straight as a rod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death"*)

### Węzeł `[83]`
Mówca: **Lileas Graf**
> ""Tarquin Soll was a great man with whom I shared many ideals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lileas Graf: ""But my decisions have always been my own.""*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death)"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lileas Graf: ""Tarquin Soll was a great man with whom I shared many ide..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lileas Graf: ""Tarquin Soll was -- is -- a great man, with whom I share..."*)

### Węzeł `[87]`
Mówca: **Lileas Graf**
> ""Tarquin Soll was -- is -- a great man, with whom I share many ideals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lileas Graf: ""But my decisions have always been my own.""*)

### Węzeł `[88]`
Mówca: **Lileas Graf**
> ""But my decisions have always been my own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Lileas Graf: ""Including the decision to sacrifice one man's life to sa..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist > 5 || BaseGame.Democratic > 5 || (BaseGame.Reform_Reform_Court_Success == true && BaseGame.Faction_OldGuard_Content == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist > 5 || BaseGame.Democratic > 5 || (B..."*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Malenyevist > 5 || BaseGame.Democratic > 5 || ..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist > 5 || BaseGame.Democratic > 5 || (BaseGame.Reform_Reform_Court_Success == true && BaseGame.Faction_OldGuard_Content == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Malenyevist"] > 5  or  Variable["BaseGame.Democratic"] > 5  or  (Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lileas Graf: ""Obviously, we were right.""*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Malenyevist > 5 || BaseGame.Democratic > 5 || (BaseGame.Reform_Reform_Court_Success == true && BaseGame.Faction_OldGuard_Content == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] > 5  or  Variable["BaseGame.Democratic"] > 5  or  (Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Faction_OldGuard_Content"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Lileas Graf: ""Without our interference, who knows what kind of radical..."*)

### Węzeł `[92]`
Mówca: **Lileas Graf**
> ""Obviously, we were right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist > 15"*)

### Węzeł `[93]`
Mówca: **Lileas Graf**
> ""Without our interference, who knows what kind of radical change you would have brought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player: ""The Sordish people wanted change. You can't just disrega..."*)
  - -> `[95]` (*Player: ""I'm the President, and I wanted change. You can't just d..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA: ""The Sordish people wanted change. You can't just disregard their will.""]** — Mówca: **Player**
> ""The Sordish people wanted change. You can't just disregard their will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Lileas Graf), `[118]` (Lileas Graf), `[122]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lileas Graf: ""The people don't always know best.""*)

### Węzeł `[95]`
**[WYBÓR GRACZA: ""I'm the President, and I wanted change. You can't just disregard my will.""]** — Mówca: **Player**
> ""I'm the President, and I wanted change. You can't just disregard my will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Lileas Graf), `[118]` (Lileas Graf), `[122]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lileas Graf: ""The President doesn't always know best.""*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_CSP == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true && Ba..."*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true && ..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_CSP == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_CSP"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lileas Graf: ""As shown by their willingness to follow you into a fooli..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_CSP == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_CSP"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: ""And you think you would have done a better job?""*)
  - -> `[107]` (*Player: ""They knew enough to vote me in. And I knew enough to for..."*)

### Węzeł `[99]`
Mówca: **Lileas Graf**
> ""The President doesn't always know best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true && Ba..."*)

### Węzeł `[100]`
Mówca: **Lileas Graf**
> ""The people don't always know best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true && Ba..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_CSP == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true && Ba..."*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true && ..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_CSP == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_CSP"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lileas Graf: ""As shown by your leading the country into a foolish war ..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true && BaseGame.Policy_Diplomacy_ATO == false && BaseGame.Policy_Diplomacy_CSP == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_CSP"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: ""And you think you would have done a better job?""*)
  - -> `[108]` (*Player: ""I knew enough to get rid of you and the rest of your Old..."*)

### Węzeł `[104]`
Mówca: **Lileas Graf**
> ""As shown by their willingness to follow you into a foolish war that Sordland is ill-prepared to win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: ""And you think you would have done a better job?""*)
  - -> `[106]` (*Player: ""I'm going to crush Rumburg. Just like I crushed you and ..."*)

### Węzeł `[105]`
Mówca: **Lileas Graf**
> ""As shown by your leading the country into a foolish war that it is ill-prepared to win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: ""And you think you would have done a better job?""*)
  - -> `[106]` (*Player: ""I'm going to crush Rumburg. Just like I crushed you and ..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""I'm going to crush Rumburg. Just like I crushed you and the rest of the Old Guard.""]** — Mówca: **Player**
> ""I'm going to crush Rumburg. Just like I crushed you and the rest of the Old Guard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Lileas Graf), `[105]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lileas Graf: ""You're going to regret that. Sordland without Sollism is..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""They knew enough to vote me in. And I knew enough to force you out.""]** — Mówca: **Player**
> ""They knew enough to vote me in. And I knew enough to force you out.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_CSP"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[100]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lileas Graf: ""You're going to regret that. Sordland without Sollism is..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: ""I knew enough to get rid of you and the rest of your Old Guard chums.""]** — Mówca: **Player**
> ""I knew enough to get rid of you and the rest of your Old Guard chums.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_CSP"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[99]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lileas Graf: ""You're going to regret that. Sordland without Sollism is..."*)

### Węzeł `[109]`
Mówca: **Lileas Graf**
> ""You're going to regret that. Sordland without Sollism is a ship without a rudder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: ""Have you always been Soll's puppet? Or just since you en..."*)
  - -> `[113]` (*Player: ""To hell with Soll, and to hell with you.""*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)

### Węzeł `[110]`
**[WYBÓR GRACZA: ""And you think you would have done a better job?""]** — Mówca: **Player**
> ""And you think you would have done a better job?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true  and  Variable["BaseGame.Policy_Diplomacy_ATO"] == false  and  Variable["BaseGame.Policy_Diplomacy_CSP"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[104]` (Lileas Graf), `[105]` (Lileas Graf), `[100]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Lileas Graf: ""I would not have let our proud republic stray so far fro..."*)

### Węzeł `[111]`
Mówca: **Lileas Graf**
> ""I would not have let our proud republic stray so far from its Sollist roots.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player: ""To hell with Soll, and to hell with you.""*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)

### Węzeł `[112]`
**[WYBÓR GRACZA: ""Have you always been Soll's puppet? Or just since you entered my cabinet?""]** — Mówca: **Player**
> ""Have you always been Soll's puppet? Or just since you entered my cabinet?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Lileas drew herself up, her back straight as a rod."*)

### Węzeł `[113]`
**[WYBÓR GRACZA: ""To hell with Soll, and to hell with you.""]** — Mówca: **Player**
> ""To hell with Soll, and to hell with you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Lileas Graf), `[111]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "Lileas drew herself up, her back straight as a rod."*)

### Węzeł `[114]`
Mówca: **Lileas Graf**
> ""Mr. Rayne. Did you really take a helicopter to Antel Rock just to provoke me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player: ""Of course not. I just wanted to understand your motivati..."*)
  - -> `[132]` (*Player: ""I-- I suppose I did.""*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist > 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist > 15"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Malenyevist > 15)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist > 15`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Malenyevist"] > 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lileas Graf: ""As I tried to tell you many times when we were working t..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Malenyevist > 15)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] > 15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic > 20"*)

### Węzeł `[118]`
Mówca: **Lileas Graf**
> ""As I tried to tell you many times when we were working together, Sordland is not United Contana. Your heedless shift towards Malenyevism will bring only chaos.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player: ""The Sordish people wanted change. You can't just disrega..."*)
  - -> `[95]` (*Player: ""I'm the President, and I wanted change. You can't just d..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic > 20`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic > 20"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Democratic > 20)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic > 20`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Democratic"] > 20`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Lileas Graf: ""As I tried to tell you many times when we were working t..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Democratic > 20)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Democratic"] > 20) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lileas Graf: ""Your hapless attempts to reform the Constitution have go..."*)

### Węzeł `[122]`
Mówca: **Lileas Graf**
> ""As I tried to tell you many times when we were working together, Sordland is not Arcasia. Your heedless shift towards liberalism will bring only chaos.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player: ""The Sordish people wanted change. You can't just disrega..."*)
  - -> `[95]` (*Player: ""I'm the President, and I wanted change. You can't just d..."*)

### Węzeł `[123]`
Mówca: **Lileas Graf**
> ""Your hapless attempts to reform the Constitution have gone against everything this country stands for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player: ""The Sordish people wanted change. You can't just disrega..."*)
  - -> `[95]` (*Player: ""I'm the President, and I wanted change. You can't just d..."*)

### Węzeł `[124]`
Mówca: **Narrator**
> "Lileas drew herself up, her back straight as a rod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lileas Graf: ""Mr. Rayne. Did you really take a helicopter to Antel Roc..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA: ""Is that what you're writing? An obituary for your beloved Tarquin Soll?""]** — Mówca: **Player**
> ""Is that what you're writing? An obituary for your beloved Tarquin Soll?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Kontekst wejściowy (poprzednik):** `[109]` (Lileas Graf), `[111]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lileas Graf: ""I know what you're implying.""*)

### Węzeł `[126]`
Mówca: **Lileas Graf**
> ""Including the decision to sacrifice one man's life to save millions of Sordish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: ""I thought you religious freaks were against playing God.""*)
  - -> `[127]` (*Player: ""That decision wasn't yours to make.""*)
  - -> `[128]` (*Player: ""Save them from what, Lileas?""*)

### Węzeł `[127]`
**[WYBÓR GRACZA: ""That decision wasn't yours to make.""]** — Mówca: **Player**
> ""That decision wasn't yours to make.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Lileas Graf: ""History will redeem me. Even if you won't.""*)

### Węzeł `[128]`
**[WYBÓR GRACZA: ""Save them from what, Lileas?""]** — Mówca: **Player**
> ""Save them from what, Lileas?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "Lileas' face darkened."*)

### Węzeł `[129]`
**[WYBÓR GRACZA: ""I thought you religious freaks were against playing God.""]** — Mówca: **Player**
> ""I thought you religious freaks were against playing God.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lileas Graf: ""Mr. Rayne. Did you really take a helicopter to Antel Roc..."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "Lileas' face darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Lileas Graf: ""Oh, you'll see.""*)

### Węzeł `[131]`
Mówca: **Lileas Graf**
> ""Oh, you'll see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lileas Graf: ""Sooner or later, the people will realize that Soll was t..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: ""I-- I suppose I did.""]** — Mówca: **Player**
> ""I-- I suppose I did.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Lileas Graf: ""Then allow me to return the favor.""*)

### Węzeł `[133]`
**[WYBÓR GRACZA: ""Of course not. I just wanted to understand your motivations.""]** — Mówca: **Player**
> ""Of course not. I just wanted to understand your motivations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Lileas Graf: ""My motivations are and have always been crystal clear. I..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: ""Is that what you're writing? An obituary for your belove..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: ""Is that who those letters are for? Your beloved Tarquin ..."*)

### Węzeł `[137]`
**[WYBÓR GRACZA: ""Is that who those letters are for? Your beloved Tarquin Soll?""]** — Mówca: **Player**
> ""Is that who those letters are for? Your beloved Tarquin Soll?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[109]` (Lileas Graf), `[111]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lileas Graf: ""I know what you're implying.""*)

### Węzeł `[138]`
Mówca: **Lileas Graf**
> ""History will redeem me. Even if you won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Lileas Graf: ""But as for you...""*)

### Węzeł `[139]`
Mówca: **Lileas Graf**
> ""My motivations are and have always been crystal clear. It's yours I would worry about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Lileas Graf: ""All this change you've attempted to bring to Sordland......"*)

### Węzeł `[140]`
Mówca: **Lileas Graf**
> ""Then allow me to return the favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Lileas Graf: ""All this change you've attempted to bring to Sordland......"*)

### Węzeł `[141]`
Mówca: **Lileas Graf**
> ""All this change you've attempted to bring to Sordland... is it truly for the betterment of the country, or to cement a place for Anton Rayne in the history books?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < 1 || BaseGame.LeakedScandals_Se..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < 1 || BaseGame.LeakedScandals_Severity > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < 1 || BaseGame.LeakedScandals_Se..."*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion < 1 || BaseGame.LeakedScandals_..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < 1 || BaseGame.LeakedScandals_Severity > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < 1  or  Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Lileas Graf: ""You're hanging on by a thread, dear. Time is running out..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion < 1 || BaseGame.LeakedScandals_Severity > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < 1  or  Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lileas Graf: ""Sooner or later, the people will realize that Soll was t..."*)

### Węzeł `[145]`
Mówca: **Lileas Graf**
> ""You're hanging on by a thread, dear. Time is running out to choose how you want to be remembered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player: ""Guards! Take this woman's pens and paper away. They're t..."*)
  - -> `[149]` (*Player: ""I've had enough of this. I'm leaving.""*)

### Węzeł `[146]`
Mówca: **Lileas Graf**
> ""But as for you...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Lileas Graf: ""All this change you've attempted to bring to Sordland......"*)

### Węzeł `[147]`
Mówca: **Lileas Graf**
> ""Sooner or later, the people will realize that Soll was the best leader they'll ever have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player: ""Guards! Take this woman's pens and paper away. They're t..."*)
  - -> `[149]` (*Player: ""I've had enough of this. I'm leaving.""*)

### Węzeł `[148]`
**[WYBÓR GRACZA: ""Guards! Take this woman's pens and paper away. They're too dangerous to have lying around.""]** — Mówca: **Player**
> ""Guards! Take this woman's pens and paper away. They're too dangerous to have lying around.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Lileas Graf), `[147]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "The guards moved in and roughly grabbed Lileas' writing m..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA: ""I've had enough of this. I'm leaving.""]** — Mówca: **Player**
> ""I've had enough of this. I'm leaving.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Lileas Graf), `[147]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "Lileas nodded and turned back to her correspondence."*)

### Węzeł `[150]`
Mówca: **Narrator**
> "The guards moved in and roughly grabbed Lileas' writing materials off her desk. She looked unfazed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Lileas Graf: ""Thanks for the visit, Mr. President. I'm sure this isn't..."*)

### Węzeł `[151]`
Mówca: **Lileas Graf**
> ""Thanks for the visit, Mr. President. I'm sure this isn't the last we'll see of each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "The guards re-locked her cell door and escorted me away."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "Lileas nodded and turned back to her correspondence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Lileas Graf: ""Thanks for the visit, Mr. President. I'm sure this isn't..."*)

### Węzeł `[153]`
Mówca: **Narrator**
> "The guards re-locked her cell door and escorted me away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "On the way back to Holsord, I couldn't help thinking abou..."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "On the way back to Holsord, I couldn't help thinking about what she said."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < 1 || BaseGame.LeakedScandals_Se..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < 1 || BaseGame.LeakedScandals_Severity > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion < 1 || BaseGame.LeakedScandals_Se..."*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion < 1 || BaseGame.LeakedScandals_..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion < 1 || BaseGame.LeakedScandals_Severity > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] < 1  or  Variable["BaseGame.LeakedScandals_Severity"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "How would I be remembered?"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion < 1 || BaseGame.LeakedScandals_Severity > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] < 1  or  Variable["BaseGame.LeakedScandals_Severity"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "Would I ever be able to escape Soll's shadow?"*)

### Węzeł `[158]`
Mówca: **Narrator**
> "How would I be remembered?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_A_LileasDiscussion = true"*)

### Węzeł `[159]`
Mówca: **Narrator**
> "Would I ever be able to escape Soll's shadow?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_A_LileasDiscussion = true"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_Lileas_Jailed = true; BaseGameSupport.News_Turn09_ST_Lileas_Jailed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Lileas_Jailed"] = true;
Variable["BaseGameSupport.News_Turn09_ST_Lileas_Jailed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Helicopter");"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn09_Holsord_WPB_CPS_InTalks = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn09_Holsord_WPB_CPS_InTalks"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && BaseGame.Reform_EmergencyDecree_Banned_RY == false && (BaseGame.Reform_Law_Threshold_15 == true || BaseGame.Reform_Law_Threshold_Default == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && ..."*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == false &..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && BaseGame.Reform_EmergencyDecree_Banned_RY == false && (BaseGame.Reform_Law_Threshold_15 == true || BaseGame.Reform_Law_Threshold_Default == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == false  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false  and  (Variable["BaseGame.Reform_Law_Threshold_15"] == true  or  Variable["BaseGame.Reform_Law_Threshold_Default"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn09_Holsord_WPB_CPS_InTalks = true"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && BaseGame.Reform_EmergencyDecree_Banned_RY == false && (BaseGame.Reform_Law_Threshold_15 == true || BaseGame.Reform_Law_Threshold_Default == true && BaseGame.Reform_Reform_Court_Success == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == false  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false  and  (Variable["BaseGame.Reform_Law_Threshold_15"] == true  or  Variable["BaseGame.Reform_Law_Threshold_Default"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_LileasDiscussion_Trial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_LileasDiscussion_Trial == ..."*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(BaseGameSupport.Journal_Turn09_LileasDiscussion_Trial =..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_LileasDiscussion_Trial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameSupport.Journal_Turn09_LileasDiscussion_Trial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Lileas_Jailed = true; Base..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameSupport.Journal_Turn09_LileasDiscussion_Trial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameSupport.Journal_Turn09_LileasDiscussion_Trial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_CSP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP == true"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_CSP == true)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_CSP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn09_Conriat_CSPShips = true"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_CSP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Lileas_Jailed = true; Base..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn09_Erlory_ATOPlanes = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn09_Erlory_ATOPlanes"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Lileas_Jailed = true; Base..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_ATO == true)"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn09_Erlory_ATOPlanes = true"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_ATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP == true"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn09_Conriat_CSPShips = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn09_Conriat_CSPShips"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Lileas_Jailed = true; Base..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Lileas Graf", "Inmate 64498");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Lileas Graf","Inmate 64498");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "She appeared to be busy writing letters as the guards ope..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Helicopter");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Helicopter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The thrum of the helicopter engine, the first of its kind..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
