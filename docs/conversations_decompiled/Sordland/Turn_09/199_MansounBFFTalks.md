# Sordland/Turn09/MansounBFFTalks

- **ID konwersacji:** `199`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/199_MansounBFFTalks.md`
- **Liczba węzłów dialogowych:** 219
- **Liczba wyborów gracza:** 37

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[15]** Mansoun Leke

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Bergia_Governor_Krull`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Bill_Turn07_LanguageBill_Signed`
- `BaseGame.Decision_Turn08_AschrafSupport_Go`
- `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity`
- `BaseGame.Media_Censored`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Decrees_Weaker`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization`
- `BaseGame.Reform_Reform_Court_Success`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Bergia_Governor_Ersen`
- `BaseGame.Bergia_Governor_Krull`
- `BaseGame.Bludish_Opinion`
- `BaseGame.Economy`
- `BaseGame.Policy_Law_Ban_BFP`
- `BaseGame.Policy_Law_Ban_WPB`
- `BaseGame.Policy_Law_EducationUnification`
- `BaseGame.Policy_Law_ReligiousHarmony`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization`
- `BaseGame.Situation_Law_BludishOppression`
- `BaseGame.Situation_Law_BludishProblem`
- `BaseGame.Situation_Law_BludishReconciliation`
- `BaseGame.Situation_Law_RestrictiononReligious`
- `BaseGame.Situation_Law_RestrictionsOnMinorityLanguage`
- `BaseGame.Situation_Order_BFF_ThreatAlarming`
- `BaseGame.Situation_Order_BFF_ThreatContinues`
- `BaseGame.Situation_Order_BFF_ThreatEliminated`
- `BaseGame.Situation_Order_BludishProtests`
- `BaseGame.Situation_Order_BludishQuelled`
- `BaseGame.Situation_Order_BludishUprising`
- `BaseGame.Turn09_UnrestStopped`
- `BaseGame.Unrest_BFF_Deal_Failed`
- `BaseGame.Unrest_BFF_Deal_Promised`
- `BaseGame.Unrest_BFF_Deal_Signed`
- `BaseGameSupport.Codex_Characters_Others_DewlenArge`
- `BaseGameSupport.Codex_Characters_Others_DewlenArge_Freed`
- `BaseGameSupport.Codex_Characters_Others_IshvalErsen`
- `BaseGameSupport.Codex_Characters_StateFigures_HerbertKrull`
- `BaseGameSupport.Codex_Characters_StateFigures_HerbertKrull_Dismissed`
- `BaseGameSupport.Codex_Characters_StateFigures_HerbertKrull_DismissedAfterZoneChange`
- `BaseGameSupport.Codex_Characters_StateFigures_IshvalErsen_Governor`
- `BaseGameSupport.Codex_Characters_StateFigures_PhelixBron`
- `BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_Dismissed`
- `BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_DismissedAfterZoneChange`
- `BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_Exploded`
- `BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_Killed`
- `BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_Saved`
- `BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Autonomy`
- `BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Bron`
- `BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Krull`
- `BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplomatic_Counteroffer`
- `BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplomatic_Decree`
- `BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplomatic_Promise`
- `BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplomatic_Refuse`
- `BaseGameSupport.News_Turn09_HP_BFF_BillPromised`
- `BaseGameSupport.News_Turn09_HP_BFF_DecreeSigned`
- `BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_BronAccept`
- `BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_BronCounter`
- `BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_BronRefuse`
- `BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_KrullAccept`
- `BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_KrullCounter`
- `BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_KrullRefuse`
- `BaseGameSupport.News_Turn09_R_BFF_BillPromised`
- `BaseGameSupport.News_Turn09_R_BFF_DecreeSigned`
- `BaseGameSupport.Report_Turn09_Erzaren_BFF_Diplomatic_PromiseFailed`
- `BaseGameSupport.Report_Turn09_Erzaren_Unrest_BFF_Diplomatic`
- `BaseGameSupport.Report_Turn09_Holsord_Unrest_BFF_Diplomatic_Promise`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[197] Sordland/Turn09/A_Talks** (../Turn_09/197_A_Talks.md), Węzeł `[37]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **""Why exactly did they release him?""** | `[4]` **Mansoun Leke**: ""And they did not harm anyone. E..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Mansoun Leke**: ""They said they wanted to return..." |
| `[6]` | **""You are saying that but your eyes speak differently.""** | `[4]` **Mansoun Leke**: ""And they did not harm anyone. E..."<br>`[154]` **Mansoun Leke**: ""I'm glad they didn't harm anyon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Mansoun Leke**: ""I haven't slept in days, Mr. Pr..." |
| `[7]` | **""Thank you for your service, Mr. Leke.""** | `[4]` **Mansoun Leke**: ""And they did not harm anyone. E..."<br>`[154]` **Mansoun Leke**: ""I'm glad they didn't harm anyon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Mansoun Leke**: ""Don't mention it. I did this fo..." |
| `[15]` | **""So they gave away their bargaining chip just like that?""** | `[11]` **Mansoun Leke**: ""Apparently, nobody expected you..." | `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true` | *Brak zmian stanu* | `[20]` **Mansoun Leke**: ""Yes. They don't want violence. ..." |
| `[16]` | **""And how about you?""** | `[11]` **Mansoun Leke**: ""Apparently, nobody expected you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Mansoun Leke**: ""To be completely honest, me nei..." |
| `[17]` | **""What did you tell them to make this happen?""** | `[11]` **Mansoun Leke**: ""Apparently, nobody expected you..." | `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true` | *Brak zmian stanu* | `[21]` **Mansoun Leke**: ""Nothing."" |
| `[24]` | **""What? Are you defending them now?""** | `[19]` **Mansoun Leke**: ""Judging by your previous action..."<br>`[20]` **Mansoun Leke**: ""Yes. They don't want violence. ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Mansoun Leke**: ""What? No."" |
| `[25]` | **""And what were their demands?""** | `[19]` **Mansoun Leke**: ""Judging by your previous action..."<br>`[20]` **Mansoun Leke**: ""Yes. They don't want violence. ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "He took a deep breath." |
| `[26]` | **""Oh, now they are *against violence*?""** | `[20]` **Mansoun Leke**: ""Yes. They don't want violence. ..."<br>`[23]` **Mansoun Leke**: ""As I said, they took that as a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Mansoun Leke**: ""While I do not support any of t..." |
| `[27]` | **""It's *us* now?""** | `[19]` **Mansoun Leke**: ""Judging by your previous action..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Mansoun Leke**: ""Of course I do not support the ..." |
| `[35]` | **""Good. Tell me about the meeting.""** | `[19]` **Mansoun Leke**: ""Judging by your previous action..."<br>`[20]` **Mansoun Leke**: ""Yes. They don't want violence. ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "He took a deep breath." |
| `[38]` | **""I should have known sending a Blud was a mistake.""** | `[30]` **Mansoun Leke**: ""Because you have left them no c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Mansoun Leke**: ""And I should have known that yo..."<br>`[54]` **Mansoun Leke**: ""I'm just another *Blud* for you..." |
| `[39]` | **""Everything I've done was out of necessity.""** | `[30]` **Mansoun Leke**: ""Because you have left them no c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Mansoun Leke**: ""There is no excuse for oppressi..." |
| `[40]` | **""So, I'm to blame for this attack?""** | `[30]` **Mansoun Leke**: ""Because you have left them no c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Mansoun Leke**: ""Our people have suffered a lot ..." |
| `[41]` | **""Just tell me about their demands.""** | `[30]` **Mansoun Leke**: ""Because you have left them no c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "He took a deep breath." |
| `[56]` | **""Who's reinforcing this cycle? Me or the armed separatists who attacked our nation..."** | `[55]` **Mansoun Leke**: ""You have only fed the stigma an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Mansoun Leke**: ""I don't want to be disrespectfu..." |
| `[57]` | **""I advise you to watch your words, Mr. Leke.""** | `[55]` **Mansoun Leke**: ""You have only fed the stigma an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Mansoun Leke**: ""I don't want to be disrespectfu..." |
| `[58]` | **""Look. I'm doing my best to support the Bludish people.""** | `[55]` **Mansoun Leke**: ""You have only fed the stigma an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Mansoun Leke**: ""Let's try to achieve something ..." |
| `[87]` | **""And here I thought we could have a diplomatic solution...""** | `[89]` **Narrator**: "Nobody had really spoken of him ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Narrator**: "Mansoun looked at me as if he wa..." |
| `[90]` | **""I'll do it. For the sake of peace.""** | `[89]` **Narrator**: "Nobody had really spoken of him ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Narrator**: "Mansoun looked at me with surprise." |
| `[91]` | **""There is no way I can accept such demands.""** | `[89]` **Narrator**: "Nobody had really spoken of him ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Narrator**: "Mansoun looked at me as if he wa..." |
| `[92]` | **""These points seem fair to me.""** | `[89]` **Narrator**: "Nobody had really spoken of him ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Narrator**: "Mansoun looked at me with surprise." |
| `[97]` | **""Yes. I'll write a decree and sign it immediately.""** | `[96]` **Mansoun Leke**: ""So, you'll comply with their de..." | `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  (Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false` | `Variable["BaseGame.Unrest_BFF_Deal_Signed"] = true; Varia...`<br>`Variable["BaseGameSupport.Codex_Characters_StateFigures_P...`<br>*(+4 skryptów)* | *Koniec sceny / Terminal* |
| `[101]` | **""Yes, but I'll need the Assembly. I don't have the authority to sign such decrees ..."** | `[96]` **Mansoun Leke**: ""So, you'll comply with their de..." | `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  (Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true` | `Variable["BaseGame.Unrest_BFF_Deal_Promised"] = true; Var...`<br>`Variable["BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplo...`<br>*(+2 skryptów)* | `[113]` **Mansoun Leke**: ""I hope they listen to you. The ..." |
| `[102]` | **""You heard me. I'll give them what they want.""** | `[96]` **Mansoun Leke**: ""So, you'll comply with their de..." | `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  (Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false` | `Variable["BaseGame.Unrest_BFF_Deal_Signed"] = true; Varia...`<br>`Variable["BaseGameSupport.Codex_Characters_StateFigures_P...`<br>*(+4 skryptów)* | *Koniec sceny / Terminal* |
| `[103]` | **""We'll put them in a bill and propose it to the Assembly immediately.""** | `[96]` **Mansoun Leke**: ""So, you'll comply with their de..." | `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  (Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true` | `Variable["BaseGame.Unrest_BFF_Deal_Promised"] = true; Var...`<br>`Variable["BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplo...`<br>*(+2 skryptów)* | `[113]` **Mansoun Leke**: ""I hope they listen to you. The ..." |
| `[104]` | **""Yes. I cannot accept these demands. And we cannot let them destroy the Soll Dam.""** | `[93]` **Mansoun Leke**: ""So, you'll initiate the attack ..."<br>`[209]` **Mansoun Leke**: ""So, you'll initiate the attack ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Report_Turn09_Erzaren_BFF_Diplo...`<br>`Variable["BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplo...`<br>*(+3 skryptów)* | `[123]` **Mansoun Leke**: ""This will only result in more d..." |
| `[105]` | **""No. We'll make a counter offer.""** | `[93]` **Mansoun Leke**: ""So, you'll initiate the attack ..."<br>`[209]` **Mansoun Leke**: ""So, you'll initiate the attack ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Report_Turn09_Erzaren_BFF_Diplo...`<br>`Variable["BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplo...`<br>*(+2 skryptów)* | `[116]` **Player**: ""I will only accept the amnesty.""<br>`[117]` **Player**: ""I can do it except the autonomy.""<br>*(oraz 1 innych odgałęzień)* |
| `[111]` | **""Go ahead and gather the team. I'm counting on you.""** | `[110]` **Mansoun Leke**: ""Should I relay the message?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Policy_Law_Ban_WPB"] = false; Variable...`<br>`Variable["BaseGameSupport.Codex_Characters_StateFigures_P...`<br>*(+4 skryptów)* | *Koniec sceny / Terminal* |
| `[112]` | **""No. You've done enough. I'll have someone else do it.""** | `[110]` **Mansoun Leke**: ""Should I relay the message?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Policy_Law_Ban_WPB"] = false; Variable...`<br>`Variable["BaseGameSupport.Codex_Characters_StateFigures_P...`<br>*(+4 skryptów)* | *Koniec sceny / Terminal* |
| `[116]` | **""I will only accept the amnesty.""** | `[105]` **Player**: ""No. We'll make a counter offer."" | `(Variable["BaseGame.Media_Censored"] == false) == false` | *Brak zmian stanu* | `[119]` **Mansoun Leke**: ""You think they'll accept that?"" |
| `[117]` | **""I can do it except the autonomy.""** | `[105]` **Player**: ""No. We'll make a counter offer."" | `(Variable["BaseGame.Media_Censored"] == false) == false` | *Brak zmian stanu* | `[119]` **Mansoun Leke**: ""You think they'll accept that?"" |
| `[118]` | **""First, they will have to put down their weapons and surrender.""** | `[105]` **Player**: ""No. We'll make a counter offer."" | `(Variable["BaseGame.Media_Censored"] == false) == false` | *Brak zmian stanu* | `[119]` **Mansoun Leke**: ""You think they'll accept that?"" |
| `[120]` | **""They will if they truly desire a diplomatic solution.""** | `[119]` **Mansoun Leke**: ""You think they'll accept that?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[121]` | **""We have to try.""** | `[119]` **Mansoun Leke**: ""You think they'll accept that?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[122]` | **""If they don't, I will have no other choice but to destroy them.""** | `[119]` **Mansoun Leke**: ""You think they'll accept that?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[175]` | **""Well.. Me neither.""** | `[11]` **Mansoun Leke**: ""Apparently, nobody expected you..." | `(Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false` | *Brak zmian stanu* | `[22]` **Mansoun Leke**: ""I, and the whole delegation onl..." |

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
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BFFDemands"*)

### Węzeł `[3]`
Mówca: **Mansoun Leke**
> ""I'm glad they released the governor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Mansoun Leke: ""And they did not harm anyone. Everything has gone incred..."*)

### Węzeł `[4]`
Mówca: **Mansoun Leke**
> ""And they did not harm anyone. Everything has gone incredibly well so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player: ""Why exactly did they release him?""*)
  - -> `[6]` (*Player: ""You are saying that but your eyes speak differently.""*)
  - -> `[7]` (*Player: ""Thank you for your service, Mr. Leke.""*)

### Węzeł `[5]`
**[WYBÓR GRACZA: ""Why exactly did they release him?""]** — Mówca: **Player**
> ""Why exactly did they release him?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Mansoun Leke: ""They said they wanted to return the gesture of goodwill.""*)

### Węzeł `[6]`
**[WYBÓR GRACZA: ""You are saying that but your eyes speak differently.""]** — Mówca: **Player**
> ""You are saying that but your eyes speak differently.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Mansoun Leke), `[154]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Mansoun Leke: ""I haven't slept in days, Mr. President. And of course, i..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: ""Thank you for your service, Mr. Leke.""]** — Mówca: **Player**
> ""Thank you for your service, Mr. Leke.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Mansoun Leke), `[154]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Mansoun Leke: ""Don't mention it. I did this for my people, and for Sord..."*)

### Węzeł `[8]`
Mówca: **Mansoun Leke**
> ""Don't mention it. I did this for my people, and for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Mansoun Leke: ""If my service helps with the unity of our people, I woul..."*)

### Węzeł `[9]`
Mówca: **Mansoun Leke**
> ""I haven't slept in days, Mr. President. And of course, it was tough being around heavily armed men, if that's what you're trying to get at...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[10]`
Mówca: **Mansoun Leke**
> ""They said they wanted to return the gesture of goodwill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Mansoun Leke: ""Apparently, nobody expected you to hold talks with them.""*)

### Węzeł `[11]`
Mówca: **Mansoun Leke**
> ""Apparently, nobody expected you to hold talks with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_..."*)
  - -> `[16]` (*Player: ""And how about you?""*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_..."*)

### Węzeł `[12]`
Mówca: **Mansoun Leke**
> ""But they did release Mr. Bron, didn't they? They said they wanted to return the gesture of goodwill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Mansoun Leke: ""Apparently, nobody expected you to hold talks with them.""*)

### Węzeł `[13]`
Mówca: **Mansoun Leke**
> ""If my service helps with the unity of our people, I would never hesitate to do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[14]`
Mówca: **Mansoun Leke**
> ""And luckily, the meeting went well. They even released Mr. Bron, saying they wanted to return the gesture of goodwill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Mansoun Leke: ""Apparently, nobody expected you to hold talks with them.""*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""So they gave away their bargaining chip just like that?""]** — Mówca: **Player**
> ""So they gave away their bargaining chip just like that?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Kontekst wejściowy (poprzednik):** `[11]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Mansoun Leke: ""Yes. They don't want violence. They only want their voic..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""And how about you?""]** — Mówca: **Player**
> ""And how about you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Mansoun Leke: ""To be completely honest, me neither.""*)

### Węzeł `[17]`
**[WYBÓR GRACZA: ""What did you tell them to make this happen?""]** — Mówca: **Player**
> ""What did you tell them to make this happen?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Kontekst wejściowy (poprzednik):** `[11]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Mansoun Leke: ""Nothing.""*)

### Węzeł `[18]`
Mówca: **Mansoun Leke**
> ""To be completely honest, me neither.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Mansoun Leke: ""Judging by your previous actions against... us.""*)

### Węzeł `[19]`
Mówca: **Mansoun Leke**
> ""Judging by your previous actions against... us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""And what were their demands?""*)
  - -> `[35]` (*Player: ""Good. Tell me about the meeting.""*)
  - -> `[24]` (*Player: ""What? Are you defending them now?""*)
  - -> `[27]` (*Player: ""It's *us* now?""*)

### Węzeł `[20]`
Mówca: **Mansoun Leke**
> ""Yes. They don't want violence. They only want their voices to be heard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""And what were their demands?""*)
  - -> `[35]` (*Player: ""Good. Tell me about the meeting.""*)
  - -> `[24]` (*Player: ""What? Are you defending them now?""*)
  - -> `[26]` (*Player: ""Oh, now they are *against violence*?""*)

### Węzeł `[21]`
Mówca: **Mansoun Leke**
> ""Nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Mansoun Leke: ""I, and the whole delegation only relayed your intentions..."*)

### Węzeł `[22]`
Mówca: **Mansoun Leke**
> ""I, and the whole delegation only relayed your intentions to find a diplomatic solution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Mansoun Leke: ""As I said, they took that as a gesture of goodwill.""*)

### Węzeł `[23]`
Mówca: **Mansoun Leke**
> ""As I said, they took that as a gesture of goodwill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""And what were their demands?""*)
  - -> `[35]` (*Player: ""Good. Tell me about the meeting.""*)
  - -> `[24]` (*Player: ""What? Are you defending them now?""*)
  - -> `[26]` (*Player: ""Oh, now they are *against violence*?""*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""What? Are you defending them now?""]** — Mówca: **Player**
> ""What? Are you defending them now?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Mansoun Leke), `[20]` (Mansoun Leke), `[23]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Mansoun Leke: ""What? No.""*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""And what were their demands?""]** — Mówca: **Player**
> ""And what were their demands?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Mansoun Leke), `[20]` (Mansoun Leke), `[23]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "Jump to: [BFFDemands]"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""Oh, now they are *against violence*?""]** — Mówca: **Player**
> ""Oh, now they are *against violence*?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Mansoun Leke), `[23]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Mansoun Leke: ""While I do not support any of their actions, you must un..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""It's *us* now?""]** — Mówca: **Player**
> ""It's *us* now?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Mansoun Leke: ""Of course I do not support the actions of the BFF, let a..."*)

### Węzeł `[28]`
Mówca: **Mansoun Leke**
> ""Of course I do not support the actions of the BFF, let alone stand with them. I only support the Bludish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Mansoun Leke: ""But you must understand they have a lot of Bludish peopl..."*)

### Węzeł `[29]`
Mówca: **Mansoun Leke**
> ""But you must understand they have a lot of Bludish people supporting them today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Mansoun Leke: ""Because you have left them no choice.""*)

### Węzeł `[30]`
Mówca: **Mansoun Leke**
> ""Because you have left them no choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: ""I should have known sending a Blud was a mistake.""*)
  - -> `[39]` (*Player: ""Everything I've done was out of necessity.""*)
  - -> `[40]` (*Player: ""So, I'm to blame for this attack?""*)
  - -> `[41]` (*Player: ""Just tell me about their demands.""*)

### Węzeł `[31]`
Mówca: **Mansoun Leke**
> ""What? No.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Mansoun Leke: ""Of course I do not support the actions of the BFF, nor t..."*)

### Węzeł `[32]`
Mówca: **Mansoun Leke**
> ""Of course I do not support the actions of the BFF, nor try to defend them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Mansoun Leke: ""But you must understand they have a lot of Bludish peopl..."*)

### Węzeł `[33]`
Mówca: **Mansoun Leke**
> ""While I do not support any of their actions, you must understand they have a lot of Bludish people supporting them today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Mansoun Leke: ""Many in their ranks were young men, probably recruited f..."*)

### Węzeł `[34]`
Mówca: **Mansoun Leke**
> ""Many in their ranks were young men, probably recruited from the villages in Bergia. They are led to believe the BFF is the only way to make their voices heard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Mansoun Leke: ""Because you have left them no choice.""*)

### Węzeł `[35]`
**[WYBÓR GRACZA: ""Good. Tell me about the meeting.""]** — Mówca: **Player**
> ""Good. Tell me about the meeting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Mansoun Leke), `[20]` (Mansoun Leke), `[23]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "Jump to: [BFFDemands]"*)

### Węzeł `[36]`
Mówca: **Mansoun Leke**
> ""First of all, they want the region of Bergia to be made autonomous. They want the local populace to be able to govern themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "He took out a piece of paper and stood up."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BFFDemands`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "He took a deep breath."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""I should have known sending a Blud was a mistake.""]** — Mówca: **Player**
> ""I should have known sending a Blud was a mistake.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_Go == true || Bas..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""Everything I've done was out of necessity.""]** — Mówca: **Player**
> ""Everything I've done was out of necessity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Mansoun Leke: ""There is no excuse for oppressing a group of people, Mr...."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""So, I'm to blame for this attack?""]** — Mówca: **Player**
> ""So, I'm to blame for this attack?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Mansoun Leke: ""Our people have suffered a lot through the short history..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""Just tell me about their demands.""]** — Mówca: **Player**
> ""Just tell me about their demands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "Jump to: [BFFDemands]"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [BFFDemands]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BFFDemands"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [BFFDemands]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BFFDemands"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Mansoun Leke: ""They also want the revocation of the ban on the Workers ..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Mansoun Leke: ""They also want the revocation of the ban on the Bludish ..."*)

### Węzeł `[47]`
Mówca: **Mansoun Leke**
> ""Our people have suffered a lot through the short history of this republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Mansoun Leke: ""Even though this state keeps denying it, all of us know ..."*)

### Węzeł `[48]`
Mówca: **Mansoun Leke**
> ""Even though this state keeps denying it, all of us know this to be true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Mansoun Leke: ""You have only fed the stigma and discrimination, reinfor..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_Go == true || BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_Go == true || Bas..."*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_AschrafSupport_Go == true || B..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_Go == true || BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_Go"] == true  or  Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Mansoun Leke: ""And I should have known that you meant none of it. At yo..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_AschrafSupport_Go == true || BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_Go"] == true  or  Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Mansoun Leke: ""I'm just another *Blud* for you, am I not, Mr. President?""*)

### Węzeł `[52]`
Mówca: **Mansoun Leke**
> ""And I should have known that you meant none of it. At your speech during the Izzam Anniversary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Mansoun Leke: ""You have only fed the stigma and discrimination, reinfor..."*)

### Węzeł `[53]`
Mówca: **Mansoun Leke**
> ""There is no excuse for oppressing a group of people, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Mansoun Leke: ""Our people have suffered a lot through the short history..."*)

### Węzeł `[54]`
Mówca: **Mansoun Leke**
> ""I'm just another *Blud* for you, am I not, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Mansoun Leke: ""You have only fed the stigma and discrimination, reinfor..."*)

### Węzeł `[55]`
Mówca: **Mansoun Leke**
> ""You have only fed the stigma and discrimination, reinforcing this vicious cycle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: ""Who's reinforcing this cycle? Me or the armed separatist..."*)
  - -> `[57]` (*Player: ""I advise you to watch your words, Mr. Leke.""*)
  - -> `[58]` (*Player: ""Look. I'm doing my best to support the Bludish people.""*)

### Węzeł `[56]`
**[WYBÓR GRACZA: ""Who's reinforcing this cycle? Me or the armed separatists who attacked our nation's energy source?""]** — Mówca: **Player**
> ""Who's reinforcing this cycle? Me or the armed separatists who attacked our nation's energy source?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Mansoun Leke: ""I don't want to be disrespectful, Mr. President. We have..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: ""I advise you to watch your words, Mr. Leke.""]** — Mówca: **Player**
> ""I advise you to watch your words, Mr. Leke.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Mansoun Leke: ""I don't want to be disrespectful, Mr. President. We have..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""Look. I'm doing my best to support the Bludish people.""]** — Mówca: **Player**
> ""Look. I'm doing my best to support the Bludish people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Mansoun Leke: ""Let's try to achieve something for them with this meetin..."*)

### Węzeł `[59]`
Mówca: **Mansoun Leke**
> ""I don't want to be disrespectful, Mr. President. We have an important matter to discuss here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Mansoun Leke: ""I don't want these meetings to fall flat. Especially not..."*)

### Węzeł `[60]`
Mówca: **Mansoun Leke**
> ""I don't want these meetings to fall flat. Especially not because of me. Please excuse me for my language.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Mansoun Leke: ""Let's move on to what the BFF demanded.""*)

### Węzeł `[61]`
Mówca: **Mansoun Leke**
> ""Let's try to achieve something for them with this meeting then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Mansoun Leke: ""I will tell you what the BFF told me.""*)

### Węzeł `[62]`
Mówca: **Mansoun Leke**
> ""I will tell you what the BFF told me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "Jump to: [BFFDemands]"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [BFFDemands]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BFFDemands"*)

### Węzeł `[64]`
Mówca: **Mansoun Leke**
> ""Let's move on to what the BFF demanded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "Jump to: [BFFDemands]"*)

### Węzeł `[65]`
Mówca: **Narrator**
> "He took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Mansoun Leke: ""First of all, they want the region of Bergia to be made ..."*)

### Węzeł `[66]`
Mówca: **Mansoun Leke**
> ""These are their demands. They want the governor dismissed and the Special Zone's current structure to be abolished.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "He walked up to me and placed the paper in my hands."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "He took out a piece of paper and stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "He walked up to me and placed the paper in my hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Mansoun Leke: ""They want a local assembly to be formed responsible for ..."*)

### Węzeł `[69]`
Mówca: **Mansoun Leke**
> ""They want a local assembly to be formed responsible for all regional affairs of Bergia...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "He returned back to the couch and sat down."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "He returned back to the couch and sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Mansoun Leke: ""...which is elected by the residents of the region.""*)

### Węzeł `[71]`
Mówca: **Mansoun Leke**
> ""...which is elected by the residents of the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[72]`
Mówca: **Mansoun Leke**
> ""They also want the revocation of the ban on the Workers Party of Bludia and the Bludish Freedom Party...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true && BaseG..."*)

### Węzeł `[73]`
Mówca: **Mansoun Leke**
> ""They also want the revocation of the ban on the Bludish Freedom Party...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true && BaseG..."*)

### Węzeł `[74]`
Mówca: **Mansoun Leke**
> ""...And the revocation of both the Unified Education Language Act and the Religious Harmony Act...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Mansoun Leke: ""...as well as amnesty for every Bludish prisoner who was..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true && BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true && BaseG..."*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn07_LanguageBill_Signed == true && Bas..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true && BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  and  Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Mansoun Leke: ""...And the revocation of both the Unified Education Lang..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn07_LanguageBill_Signed == true && BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  and  Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn07_LanguageBill_Signed == true)"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Mansoun Leke: ""And the revocation of the Unified Education Language Act..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn07_LanguageBill_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Mansoun Leke: ""And the revocation of the Religious Harmony Act...""*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Mansoun Leke: ""...as well as amnesty for every Bludish prisoner who was..."*)

### Węzeł `[84]`
Mówca: **Mansoun Leke**
> ""And the revocation of the Unified Education Language Act...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Mansoun Leke: ""...as well as amnesty for every Bludish prisoner who was..."*)

### Węzeł `[85]`
Mówca: **Mansoun Leke**
> ""And the revocation of the Religious Harmony Act...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Mansoun Leke: ""...as well as amnesty for every Bludish prisoner who was..."*)

### Węzeł `[86]`
Mówca: **Mansoun Leke**
> ""...as well as amnesty for every Bludish prisoner who was arrested for alleged separatist actions. Including Dewlen Arge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "It had been a very long time since I heard that name. He ..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA: ""And here I thought we could have a diplomatic solution...""]** — Mówca: **Player**
> ""And here I thought we could have a diplomatic solution...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Mansoun looked at me as if he was trying to figure out if..."*)

### Węzeł `[88]`
Mówca: **Narrator**
> "It had been a very long time since I heard that name. He was dubbed "The Bludish Terror" by Tarquin Soll when he led the BFF against the state in 1935."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "Nobody had really spoken of him since his arrest more tha..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "Nobody had really spoken of him since his arrest more than 10 years ago."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: ""And here I thought we could have a diplomatic solution...""*)
  - -> `[90]` (*Player: ""I'll do it. For the sake of peace.""*)
  - -> `[91]` (*Player: ""There is no way I can accept such demands.""*)
  - -> `[92]` (*Player: ""These points seem fair to me.""*)

### Węzeł `[90]`
**[WYBÓR GRACZA: ""I'll do it. For the sake of peace.""]** — Mówca: **Player**
> ""I'll do it. For the sake of peace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Mansoun looked at me with surprise."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: ""There is no way I can accept such demands.""]** — Mówca: **Player**
> ""There is no way I can accept such demands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Mansoun looked at me as if he was trying to figure out if..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA: ""These points seem fair to me.""]** — Mówca: **Player**
> ""These points seem fair to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Mansoun looked at me with surprise."*)

### Węzeł `[93]`
Mówca: **Mansoun Leke**
> ""So, you'll initiate the attack then? After they released the governor?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player: ""Yes. I cannot accept these demands. And we cannot let th..."*)
  - -> `[105]` (*Player: ""No. We'll make a counter offer.""*)

### Węzeł `[94]`
Mówca: **Narrator**
> "Mansoun looked at me as if he was trying to figure out if he understood me correctly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true || BaseGame.Bergia..."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "Mansoun looked at me with surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Mansoun Leke: ""So, you'll comply with their demands then?""*)

### Węzeł `[96]`
Mówca: **Mansoun Leke**
> ""So, you'll comply with their demands then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && (BaseGame.Refor..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA: ""Yes. I'll write a decree and sign it immediately.""]** — Mówca: **Player**
> ""Yes. I'll write a decree and sign it immediately.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  (Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[96]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Deal_Signed = true; BaseGame.Bludish_..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && (BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && (BaseGame.Refor..."*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == false && (BaseGame.Ref..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && (BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  (Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: ""Yes, but I'll need the Assembly. I don't have the author..."*)
  - -> `[103]` (*Player: ""We'll put them in a bill and propose it to the Assembly ..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == false && (BaseGame.Reform_Law_Decrees_Removed == true || BaseGame.Reform_Law_Decrees_Weaker == true) && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  (Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player: ""Yes. I'll write a decree and sign it immediately.""*)
  - -> `[102]` (*Player: ""You heard me. I'll give them what they want.""*)

### Węzeł `[101]`
**[WYBÓR GRACZA: ""Yes, but I'll need the Assembly. I don't have the authority to sign such decrees anymore.""]** — Mówca: **Player**
> ""Yes, but I'll need the Assembly. I don't have the authority to sign such decrees anymore.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  (Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[96]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Deal_Promised = true; BaseGame.Bludis..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA: ""You heard me. I'll give them what they want.""]** — Mówca: **Player**
> ""You heard me. I'll give them what they want.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  (Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[96]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Deal_Signed = true; BaseGame.Bludish_..."*)

### Węzeł `[103]`
**[WYBÓR GRACZA: ""We'll put them in a bill and propose it to the Assembly immediately.""]** — Mówca: **Player**
> ""We'll put them in a bill and propose it to the Assembly immediately.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  (Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  or  Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[96]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Deal_Promised = true; BaseGame.Bludis..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA: ""Yes. I cannot accept these demands. And we cannot let them destroy the Soll Dam.""]** — Mówca: **Player**
> ""Yes. I cannot accept these demands. And we cannot let them destroy the Soll Dam.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Mansoun Leke), `[209]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn09_Erzaren_BFF_Diplomatic_Prom..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""No. We'll make a counter offer.""]** — Mówca: **Player**
> ""No. We'll make a counter offer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Mansoun Leke), `[209]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn09_Erzaren_BFF_Diplomatic_Prom..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Deal_Failed = true;
BaseGame.Bludish_Opinion -= 2;
BaseGame.Economy -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_BFF_Deal_Failed"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 2;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Deal_Failed = true;
BaseGame.Bludish_Opinion -= 2;
BaseGame.Economy -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_BFF_Deal_Failed"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 2;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player: ""I will only accept the amnesty.""*)
  - -> `[117]` (*Player: ""I can do it except the autonomy.""*)
  - -> `[118]` (*Player: ""First, they will have to put down their weapons and surr..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Deal_Promised = true;
BaseGame.Bludish_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_BFF_Deal_Promised"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplomatic_Prom..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Deal_Signed = true;
BaseGame.Bludish_Opinion += 4;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_BFF_Deal_Signed"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[110]`
Mówca: **Mansoun Leke**
> ""Should I relay the message?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player: ""Go ahead and gather the team. I'm counting on you.""*)
  - -> `[112]` (*Player: ""No. You've done enough. I'll have someone else do it.""*)

### Węzeł `[111]`
**[WYBÓR GRACZA: ""Go ahead and gather the team. I'm counting on you.""]** — Mówca: **Player**
> ""Go ahead and gather the team. I'm counting on you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_WPB = false; BaseGame.Policy_Law_..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA: ""No. You've done enough. I'll have someone else do it.""]** — Mówca: **Player**
> ""No. You've done enough. I'll have someone else do it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_WPB = false; BaseGame.Policy_Law_..."*)

### Węzeł `[113]`
Mówca: **Mansoun Leke**
> ""I hope they listen to you. The Assembly is full of anti-Bludish sentiment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Mansoun Leke: ""I wouldn't think I'd regret supporting limiting presiden..."*)

### Węzeł `[114]`
Mówca: **Mansoun Leke**
> ""I wouldn't think I'd regret supporting limiting presidential decrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "He sighed."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Erzaren", "City_WidespreadP..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: ""I will only accept the amnesty.""]** — Mówca: **Player**
> ""I will only accept the amnesty.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[105]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Mansoun Leke: ""You think they'll accept that?""*)

### Węzeł `[117]`
**[WYBÓR GRACZA: ""I can do it except the autonomy.""]** — Mówca: **Player**
> ""I can do it except the autonomy.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[105]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Mansoun Leke: ""You think they'll accept that?""*)

### Węzeł `[118]`
**[WYBÓR GRACZA: ""First, they will have to put down their weapons and surrender.""]** — Mówca: **Player**
> ""First, they will have to put down their weapons and surrender.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[105]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Mansoun Leke: ""You think they'll accept that?""*)

### Węzeł `[119]`
Mówca: **Mansoun Leke**
> ""You think they'll accept that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: ""They will if they truly desire a diplomatic solution.""*)
  - -> `[121]` (*Player: ""We have to try.""*)
  - -> `[122]` (*Player: ""If they don't, I will have no other choice but to destro..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA: ""They will if they truly desire a diplomatic solution.""]** — Mówca: **Player**
> ""They will if they truly desire a diplomatic solution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""We have to try.""]** — Mówca: **Player**
> ""We have to try.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[122]`
**[WYBÓR GRACZA: ""If they don't, I will have no other choice but to destroy them.""]** — Mówca: **Player**
> ""If they don't, I will have no other choice but to destroy them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[123]`
Mówca: **Mansoun Leke**
> ""This will only result in more death and destruction in Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_UnrestStopped = true; BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplomatic_Decree = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_UnrestStopped"] = true;
Variable["BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplomatic_Decree"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn09_Erzaren_Unrest_BFF_Diplomat..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplomatic_Promise = true;
BaseGame.Situation_Order_BludishUprising = false;
BaseGame.Situation_Order_BludishQuelled = false;
BaseGame.Situation_Order_BludishProtests = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplomatic_Promise"] = true;
Variable["BaseGame.Situation_Order_BludishUprising"] = false;
Variable["BaseGame.Situation_Order_BludishQuelled"] = false;
Variable["BaseGame.Situation_Order_BludishProtests"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplomatic_Counteroffer = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplomatic_Counteroffer"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Deal_Failed = true; BaseGame.Bludish_..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplomatic_Refuse = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplomatic_Refuse"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Deal_Failed = true; BaseGame.Bludish_..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_BronAccept = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_BronAccept"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn09_Erzaren_BFF_Diplomatic_Prom..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_BronCounter = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_BronCounter"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplomatic_Coun..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_BronRefuse = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_BronRefuse"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Mansoun Leke: ""This will only result in more death and destruction in B..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn09_Erzaren_BFF_Diplomatic_Prom..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplomatic_Coun..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn09_Erzaren_BFF_Diplomatic_PromiseFailed = true;
BaseGameSupport.Report_Turn09_Holsord_Unrest_BFF_Diplomatic_Promise = true;
BaseGameSupport.News_Turn09_HP_BFF_BillPromised = true;
BaseGameSupport.News_Turn09_R_BFF_BillPromised = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn09_Erzaren_BFF_Diplomatic_PromiseFailed"] = true;
Variable["BaseGameSupport.Report_Turn09_Holsord_Unrest_BFF_Diplomatic_Promise"] = true;
Variable["BaseGameSupport.News_Turn09_HP_BFF_BillPromised"] = true;
Variable["BaseGameSupport.News_Turn09_R_BFF_BillPromised"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Mansoun Leke: ""I hope they listen to you. The Assembly is full of anti-..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn09_Erzaren_Unrest_BFF_Diplomatic = true;
BaseGameSupport.News_Turn09_HP_BFF_DecreeSigned = true;
BaseGameSupport.News_Turn09_R_BFF_DecreeSigned = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn09_Erzaren_Unrest_BFF_Diplomatic"] = true;
Variable["BaseGameSupport.News_Turn09_HP_BFF_DecreeSigned"] = true;
Variable["BaseGameSupport.News_Turn09_R_BFF_DecreeSigned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Mansoun Leke: ""Should I relay the message?""*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn09_Erzaren_BFF_Diplomatic_PromiseFailed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn09_Erzaren_BFF_Diplomatic_PromiseFailed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn09_Erzaren_BFF_Diplomatic_PromiseFailed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn09_Erzaren_BFF_Diplomatic_PromiseFailed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplomatic_Refu..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_WPB = false;
BaseGame.Policy_Law_Ban_BFP = false;
BaseGame.Policy_Law_EducationUnification = false;
BaseGame.Policy_Law_ReligiousHarmony = false;


BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone = true;
BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization = false;


BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Bron = false;
BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Krull = false;
BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Autonomy = true;

BaseGameSupport.Codex_Characters_Others_IshvalErsen = false;
BaseGameSupport.Codex_Characters_StateFigures_IshvalErsen_Governor = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Law_Ban_WPB"] = false;
Variable["BaseGame.Policy_Law_Ban_BFP"] = false;
Variable["BaseGame.Policy_Law_EducationUnification"] = false;
Variable["BaseGame.Policy_Law_ReligiousHarmony"] = false;
Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] = true;
Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Bron"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Krull"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Autonomy"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_IshvalErsen"] = false;
Variable["BaseGameSupport.Codex_Characters_StateFigures_IshvalErsen_Governor"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_RestrictiononReligious = false;
BaseGame.Situation_Law_RestrictionsOnMinorityLanguage = false;

BaseGame.Situation_Law_BludishOppression = false;
BaseGame.Situation_Law_BludishProblem = false;
BaseGame.Situation_Law_BludishReconciliation = true;

BaseGame.Situation_Order_BludishUprising = false;
BaseGame.Situation_Order_BludishQuelled = true;
BaseGame.Situation_Order_BludishProtests = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_RestrictiononReligious"] = false;
Variable["BaseGame.Situation_Law_RestrictionsOnMinorityLanguage"] = false;
Variable["BaseGame.Situation_Law_BludishOppression"] = false;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;
Variable["BaseGame.Situation_Law_BludishReconciliation"] = true;
Variable["BaseGame.Situation_Order_BludishUprising"] = false;
Variable["BaseGame.Situation_Order_BludishQuelled"] = true;
Variable["BaseGame.Situation_Order_BludishProtests"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// end`
- **Efekt skryptowy (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Erzaren", "City_ArmedUnr..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_StateFigures_PhelixBron = false; BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_Dismissed = true; BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_Exploded = false; BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_Killed = false; BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_Saved = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_StateFigures_PhelixBron"] = false;
Variable["BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_Dismissed"] = true;
Variable["BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_Exploded"] = false;
Variable["BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_Killed"] = false;
Variable["BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_Saved"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Others_DewlenArge = fals..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Others_DewlenArge = false; BaseGameSupport.Codex_Characters_Others_DewlenArge_Freed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_DewlenArge"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_DewlenArge_Freed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_UnrestStopped = true; BaseGameSupport.Jou..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Erzaren", "City_ArmedUnrest");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Erzaren","City_ArmedUnrest");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Uziren", "City_ArmedUnre..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Uziren", "City_ArmedUnrest");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Uziren","City_ArmedUnrest");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Ribel", "City_ArmedUnres..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Ribel", "City_ArmedUnrest");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Ribel","City_ArmedUnrest");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Sarna", "City_ArmedUnres..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Sarna", "City_ArmedUnrest");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Sarna","City_ArmedUnrest");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Erzaren", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Erzaren","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_..."*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergi..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Mansoun Leke: ""I'm glad they released the governor.""*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Mansoun Leke: ""I'm glad they didn't harm anyone. Everything has gone in..."*)

### Węzeł `[154]`
Mówca: **Mansoun Leke**
> ""I'm glad they didn't harm anyone. Everything has gone incredibly well so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: ""You are saying that but your eyes speak differently.""*)
  - -> `[7]` (*Player: ""Thank you for your service, Mr. Leke.""*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true)"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Mansoun Leke: ""But they did release Mr. Bron, didn't they? They said th..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Krull == true)"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Mansoun Leke: ""But they did release Mr. Krull, didn't they? They said t..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Mansoun Leke: ""Apparently, nobody expected you to hold talks with them.""*)

### Węzeł `[161]`
Mówca: **Mansoun Leke**
> ""But they did release Mr. Krull, didn't they? They said they wanted to return the gesture of goodwill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Mansoun Leke: ""Apparently, nobody expected you to hold talks with them.""*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true)"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Mansoun Leke: ""And luckily, the meeting went well. They even released M..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Krull == true)"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Mansoun Leke: ""And luckily, the meeting went well. They even released M..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Mansoun Leke: ""Apparently, nobody expected you to hold talks with them.""*)

### Węzeł `[168]`
Mówca: **Mansoun Leke**
> ""And luckily, the meeting went well. They even released Mr. Krull, saying they wanted to return the gesture of goodwill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Mansoun Leke: ""Apparently, nobody expected you to hold talks with them.""*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_..."*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergi..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: ""So they gave away their bargaining chip just like that?""*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_..."*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergi..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: ""What did you tell them to make this happen?""*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Player: ""Well.. Me neither.""*)

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well.. Me neither.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[11]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Mansoun Leke: ""I, and the whole delegation only relayed your intentions..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Ce..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Mansoun Leke: ""These are their demands. They want the centralization of..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Mansoun Leke: ""These are their demands. They want the governor dismisse..."*)

### Węzeł `[179]`
Mówca: **Mansoun Leke**
> ""These are their demands. They want the centralization of Bergia to be cancelled and the Interior's control over the region to be taken away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "He walked up to me and placed the paper in my hands."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true)"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_StateFigures_PhelixBron ..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Krull == true)"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_StateFigures_HerbertKrul..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Others_DewlenArge = fals..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_StateFigures_HerbertKrull = false; BaseGameSupport.Codex_Characters_StateFigures_HerbertKrull_Dismissed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_StateFigures_HerbertKrull"] = false;
Variable["BaseGameSupport.Codex_Characters_StateFigures_HerbertKrull_Dismissed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Others_DewlenArge = fals..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true)"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_StateFigures_PhelixBron ..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_StateFigures_PhelixBron = false;
BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_DismissedAfterZoneChange = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_StateFigures_PhelixBron"] = false;
Variable["BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_DismissedAfterZoneChange"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron = false; BaseGame.Bergia_Go..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_StateFigures_HerbertKrull = false;
BaseGameSupport.Codex_Characters_StateFigures_HerbertKrull_DismissedAfterZoneChange = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_StateFigures_HerbertKrull"] = false;
Variable["BaseGameSupport.Codex_Characters_StateFigures_HerbertKrull_DismissedAfterZoneChange"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron = false; BaseGame.Bergia_Go..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron = false;
BaseGame.Bergia_Governor_Krull = false;
BaseGame.Bergia_Governor_Ersen = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Bergia_Governor_Bron"] = false;
Variable["BaseGame.Bergia_Governor_Krull"] = false;
Variable["BaseGame.Bergia_Governor_Ersen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatEliminated = true; Bas..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_BFF_ThreatEliminated = true;
BaseGame.Situation_Order_BFF_ThreatContinues = false;
BaseGame.Situation_Order_BFF_ThreatAlarming = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatContinues"] = false;
Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_RestrictiononReligious = false; Ba..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_KrullAccept = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_KrullAccept"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn09_Erzaren_BFF_Diplomatic_Prom..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Krull == true)"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_Krul..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_KrullCounter = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_KrullCounter"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplomatic_Coun..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Krull == true)"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_Krul..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_KrullRefuse = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_KrullRefuse"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Mansoun Leke: ""This will only result in more death and destruction in B..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Krull == true)"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_Krul..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_Bron..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true || BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true || BaseGame.Bergia..."*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Krull == true || BaseGame.Berg..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true || BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true  or  Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Mansoun Leke: ""So, you'll initiate the attack then? After they released..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Krull == true || BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true  or  Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Mansoun Leke: ""So, you'll initiate the attack then?""*)

### Węzeł `[209]`
Mówca: **Mansoun Leke**
> ""So, you'll initiate the attack then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player: ""Yes. I cannot accept these demands. And we cannot let th..."*)
  - -> `[105]` (*Player: ""No. We'll make a counter offer.""*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true)"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_Bron..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Unrest_BFF_Diplomatic_Coun..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true)"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_Unrest_BFF_Diplomatic_Bron..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn09_Erzaren_BFF_Diplomatic_Prom..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Krull == true)"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_StateFigures_HerbertKrul..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron = false; BaseGame.Bergia_Go..."*)
