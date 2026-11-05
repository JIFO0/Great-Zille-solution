# Sordland/Turn09/MansounDemands

- **ID konwersacji:** `198`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/198_MansounDemands.md`
- **Liczba węzłów dialogowych:** 267
- **Liczba wyborów gracza:** 35

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[15]** Mansoun Leke

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Arrest_FetihEjall`
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Bergia_Governor_Krull`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Bill_Turn07_LanguageBill_Signed`
- `BaseGame.Decision_Turn07_BludishRightsMeeting_Accept`
- `BaseGame.Decision_Turn07_BludishRightsMeeting_Reject`
- `BaseGame.Decision_Turn08_VPSelection_Gloria`
- `BaseGame.ErsenCase_Statement_ProSollist`
- `BaseGame.Media_Censored`
- `BaseGame.Policy_Law_AutonomousZoneOfBergia`
- `BaseGame.Policy_Law_Ban_BFP`
- `BaseGame.Policy_Law_Ban_WPB`
- `BaseGame.Policy_Law_Decree_Removed`
- `BaseGame.Policy_Law_Decree_Weaker`
- `BaseGame.Policy_Law_SpecialZoneOfBergia`
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_Law_Veto_Removed`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Turn07_Results_Decision_TrySoll`
- `BaseGame.Turn08_Action_Court_GloriaJustice`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Bill_Turn07_LanguageBill_Signed`
- `BaseGame.Bill_Turn09_BludishCommission_Signed`
- `BaseGame.Bludish_Opinion`
- `BaseGame.Democratic`
- `BaseGame.Malenyevist`
- `BaseGame.NoUnrest_Mansoun_Deal_Failed`
- `BaseGame.NoUnrest_Mansoun_Deal_Promised`
- `BaseGame.Policy_Law_Ban_BFP`
- `BaseGame.Policy_Law_Ban_WPB`
- `BaseGame.Policy_Law_EducationUnification`
- `BaseGame.Policy_Law_MinorityRights`
- `BaseGame.Policy_Law_ReligiousHarmony`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Situation_Law_BludishOppression`
- `BaseGame.Situation_Law_BludishProblem`
- `BaseGame.Situation_Law_BludishReconciliation`
- `BaseGame.Situation_Law_RestrictiononReligious`
- `BaseGame.Sollist`
- `BaseGameSupport.Journal_Turn09_NoUnrest_Decree`
- `BaseGameSupport.Journal_Turn09_NoUnrest_Promise`
- `BaseGameSupport.Journal_Turn09_NoUnrest_Refuse`
- `BaseGameSupport.News_Turn09_HP_BludishRights_Decree`
- `BaseGameSupport.News_Turn09_R_BludishRights_Decree`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[197] Sordland/Turn09/A_Talks** (../Turn_09/197_A_Talks.md), Węzeł `[47]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **""How can I help you, Mr. Leke?""** | `[14]` **Mansoun Leke**: ""We need your help."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Narrator**: "He gestured at the papers that I..." |
| `[15]` | **""I understand you, Mr. Leke. This discrimination against you is unacceptable.""** | `[14]` **Mansoun Leke**: ""We need your help."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Mansoun Leke**: ""That's where your help would be..." |
| `[16]` | **""I don't see what I can do. This is the cold truth of Sordish politics.""** | `[14]` **Mansoun Leke**: ""We need your help."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Mansoun Leke**: ""I don't think you are taking th..." |
| `[30]` | **""What makes you think that I only had political reasons?""** | `[29]` **Mansoun Leke**: ""I am here to ask you to reconsi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Narrator**: "He eyed me closely for a few sec..." |
| `[31]` | **""I don't believe I've done anything against the Bludish people.""** | `[29]` **Mansoun Leke**: ""I am here to ask you to reconsi..."<br>`[55]` **Mansoun Leke**: ""Then please tell me, Mr. Presid..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Mansoun Leke**: ""You banned the only pro-Bludish..."<br>`[56]` **Mansoun Leke**: ""You did not protect Ishval Erse..."<br>*(oraz 1 innych odgałęzień)* |
| `[32]` | **""It's true that I have some regrets over my actions. But how can I help you?""** | `[29]` **Mansoun Leke**: ""I am here to ask you to reconsi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Mansoun Leke**: ""We should start by undoing your..." |
| `[66]` | **""The dangerous separatist sentiment in Bergia needed to be curbed.""** | `[55]` **Mansoun Leke**: ""Then please tell me, Mr. Presid..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Mansoun Leke**: ""Dangerous separatist sentiment?"" |
| `[67]` | **""True, it was political. I couldn't reject such popular requests from the national..."** | `[55]` **Mansoun Leke**: ""Then please tell me, Mr. Presid..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Mansoun Leke**: ""Sometimes it's easier to ignore..." |
| `[72]` | **""What are you asking me to do?""** | `[62]` **Mansoun Leke**: ""It is time to undo these mistak..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Mansoun Leke**: ""Talk to your fellow USP members..."<br>`[89]` **Mansoun Leke**: ""We have a proposal to give amne..." |
| `[73]` | **""You are right, Mr. Leke. I'm not proud of my decisions.""** | `[62]` **Mansoun Leke**: ""It is time to undo these mistak..." | `(Variable["BaseGame.Reform_Law_Veto_Removed"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false` | *Brak zmian stanu* | `[83]` **Mansoun Leke**: ""Then please help us, Mr. Presid..." |
| `[74]` | **""Why should I undo what I did?""** | `[62]` **Mansoun Leke**: ""It is time to undo these mistak..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "Mansoun's eyes hardened." |
| `[76]` | **""Know your place, Mr. Leke.""** | `[62]` **Mansoun Leke**: ""It is time to undo these mistak..."<br>`[82]` **Mansoun Leke**: ""Maybe I was wrong."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "He looked at me with a stolid ex..." |
| `[91]` | **""Yes, you were. And I think our meeting is now over.""** | `[82]` **Mansoun Leke**: ""Maybe I was wrong."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Mansoun Leke**: ""I never thought you were an eth..." |
| `[92]` | **""What do you want me to do?""** | `[82]` **Mansoun Leke**: ""Maybe I was wrong."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Mansoun Leke**: ""Talk to your fellow USP members..."<br>`[89]` **Mansoun Leke**: ""We have a proposal to give amne..." |
| `[94]` | **""Okay, I'll do it.""** | `[90]` **Mansoun Leke**: ""And let us independents form a ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"]...`<br>`Variable["BaseGameSupport.Journal_Turn09_NoUnrest_Decree"...` | `[153]` **Mansoun Leke**: ""Thank you, Mr. President."" |
| `[96]` | **""I don't think I can support this proposal, Mr. Leke.""** | `[99]` **Mansoun Leke**: ""It's not Tarquin Soll's era any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Mansoun Leke**: ""Really?""<br>`[105]` **Narrator**: "Mansoun's eyes hardened." |
| `[97]` | **""I agree with you completely, Mr. Leke. Thank you for representing this noble cause.""** | `[99]` **Mansoun Leke**: ""It's not Tarquin Soll's era any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Mansoun Leke**: ""Glad to hear it, Mr. President."" |
| `[100]` | **""Exactly. By the way, his trial is next month. You can attend it if you want to.""** | `[99]` **Mansoun Leke**: ""It's not Tarquin Soll's era any..." | `Variable["BaseGame.Turn07_Results_Decision_TrySoll"] == true` | *Brak zmian stanu* | `[106]` **Mansoun Leke**: ""Oh, thank you. I will *definite..." |
| `[104]` | **""I entirely disagree.""** | `[99]` **Mansoun Leke**: ""It's not Tarquin Soll's era any..." | `(Variable["BaseGame.Turn07_Results_Decision_TrySoll"] == true) == false` | *Brak zmian stanu* | `[237]` **Mansoun Leke**: ""Really?""<br>`[105]` **Narrator**: "Mansoun's eyes hardened." |
| `[110]` | **""It's a no, Mr. Leke. I cannot help you.""** | `[109]` **Mansoun Leke**: ""What is that supposed to mean?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Mansoun Leke**: ""You're that scared of losing yo..." |
| `[111]` | **""It means stop hurling accusations at me and just tell me what you want.""** | `[109]` **Mansoun Leke**: ""What is that supposed to mean?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Mansoun Leke**: ""Talk to your fellow USP members..."<br>`[89]` **Mansoun Leke**: ""We have a proposal to give amne..." |
| `[117]` | **""Yes. I'll form the commission and support your bill in the Assembly.""** | `[113]` **Mansoun Leke**: ""So we have your support?"" | `(Variable["BaseGame.Policy_Law_Decree_Weaker"] == true  or  Variable["BaseGame.Policy_Law_Decree_Removed"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true` | `Variable["BaseGame.NoUnrest_Mansoun_Deal_Promised"] = tru...`<br>`Variable["BaseGameSupport.Journal_Turn09_NoUnrest_Promise...` | `[135]` **Mansoun Leke**: ""Thank you, Mr. President."" |
| `[118]` | **""Yes. I'll form the commission and sign your proposal as a decree.""** | `[113]` **Mansoun Leke**: ""So we have your support?"" | `((Variable["BaseGame.Policy_Law_Decree_Weaker"] == true  or  Variable["BaseGame.Policy_Law_Decree_Removed"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false` | `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"]...`<br>`Variable["BaseGameSupport.Journal_Turn09_NoUnrest_Decree"...`<br>*(+1 skryptów)* | `[135]` **Mansoun Leke**: ""Thank you, Mr. President."" |
| `[119]` | **""As much as I want to, I don't think this is the right time. The nationalists woul..."** | `[113]` **Mansoun Leke**: ""So we have your support?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Mansoun Leke**: ""Really?""<br>`[120]` **Mansoun Leke**: ""What?"" |
| `[122]` | **""It's a no, Mr. Leke. I cannot help you.""** | `[121]` **Mansoun Leke**: ""It's a no, then?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Mansoun Leke**: ""You're that scared of losing yo..." |
| `[123]` | **""This isn't the right time. The nationalists would have my head for this.""** | `[121]` **Mansoun Leke**: ""It's a no, then?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Mansoun Leke**: ""What?"" |
| `[125]` | **""I can't help the Bluds while my own people suffer.""** | `[121]` **Mansoun Leke**: ""It's a no, then?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Mansoun Leke**: ""I never thought you were an eth..." |
| `[126]` | **""I can't help the Bluds while my own people suffer.""** | `[109]` **Mansoun Leke**: ""What is that supposed to mean?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Mansoun Leke**: ""I never thought you were an eth..." |
| `[130]` | **""I don't think I can help you, Mr. Leke.""** | `[88]` **Mansoun Leke**: ""And it will form a Commission f..."<br>`[90]` **Mansoun Leke**: ""And let us independents form a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Mansoun Leke**: ""What?"" |
| `[132]` | **""Okay, I'll do it.""** | `[88]` **Mansoun Leke**: ""And it will form a Commission f..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.NoUnrest_Mansoun_Deal_Promised"] = tru...`<br>`Variable["BaseGameSupport.Journal_Turn09_NoUnrest_Promise...` | `[141]` **Mansoun Leke**: ""Thank you, Mr. President."" |
| `[154]` | **""I don't know what you're talking about, Mr. Leke. I had no power over these matte..."** | `[62]` **Mansoun Leke**: ""It is time to undo these mistak..." | `Variable["BaseGame.Reform_Law_Veto_Removed"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true` | *Brak zmian stanu* | `[158]` **Mansoun Leke**: ""Mr. President, with all due res..." |
| `[225]` | **""How can I help you, Mr. Leke?""** | `[224]` **Mansoun Leke**: ""According to the movement, ther..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[230]` **Mansoun Leke**: ""We just want you to undo the mi..." |
| `[226]` | **""Of course. Just tell me what you need.""** | `[224]` **Mansoun Leke**: ""According to the movement, ther..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[230]` **Mansoun Leke**: ""We just want you to undo the mi..." |
| `[227]` | **""I'm not sure if I can do more after all I've done for your people.""** | `[224]` **Mansoun Leke**: ""According to the movement, ther..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Mansoun Leke**: ""I understand where you're comin..." |
| `[228]` | **""Do you still have demands? Really?""** | `[224]` **Mansoun Leke**: ""According to the movement, ther..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Mansoun Leke**: ""I understand where you're comin..." |

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
  - -> `[3]` (*Mansoun Leke: ""As I said earlier, we've been working on this bill for a..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && B..."*)

### Węzeł `[3]`
Mówca: **Mansoun Leke**
> ""As I said earlier, we've been working on this bill for a long time, Mr. President. I've always done my best to represent my people... only to keep getting blocked in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Mansoun Leke: ""We can't have the same happen again.""*)

### Węzeł `[4]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Mansoun Leke: ""And something must be done about this.""*)

### Węzeł `[5]`
**[WYBÓR GRACZA: ""How can I help you, Mr. Leke?""]** — Mówca: **Player**
> ""How can I help you, Mr. Leke?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "He gestured at the papers that I had received from him ea..."*)

### Węzeł `[6]`
Mówca: **Mansoun Leke**
> ""But all that we get is disrespect. MPs shouting racial slurs at us, not allowing us to speak. And it's not only the National Front...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Narrator: "He stopped for a moment and repositioned himself on his s..."*)

### Węzeł `[7]`
Mówca: **Mansoun Leke**
> ""Now I can speak freely without Mrs. Tory leading the floor, but the outcome is no different.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Arrest_FetihEjall == true"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_GloriaJustice == true || BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true || Bas..."*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_GloriaJustice == true || B..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_GloriaJustice == true || BaseGame.Decision_Turn08_VPSelection_Gloria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true  or  Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Mansoun Leke: ""Now I can speak freely without Mrs. Tory leading the flo..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_GloriaJustice == true || BaseGame.Decision_Turn08_VPSelection_Gloria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true  or  Variable["BaseGame.Decision_Turn08_VPSelection_Gloria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Mansoun Leke: ""I don't even remember a time when Mrs. Tory allowed me t..."*)

### Węzeł `[11]`
Mówca: **Mansoun Leke**
> ""I've always brought my people's concerns to the Assembly and raised my voice whenever our rights were in question. All we ask is that the Assembly at least have a proper discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Mansoun Leke: ""But all that we get is disrespect. MPs shouting racial s..."*)

### Węzeł `[12]`
Mówca: **Mansoun Leke**
> ""The Assembly does not take us independents seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true || B..."*)

### Węzeł `[13]`
Mówca: **Mansoun Leke**
> ""I don't even remember a time when Mrs. Tory allowed me to finish a speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Arrest_FetihEjall == true"*)

### Węzeł `[14]`
Mówca: **Mansoun Leke**
> ""We need your help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player: ""How can I help you, Mr. Leke?""*)
  - -> `[15]` (*Player: ""I understand you, Mr. Leke. This discrimination against ..."*)
  - -> `[16]` (*Player: ""I don't see what I can do. This is the cold truth of Sor..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""I understand you, Mr. Leke. This discrimination against you is unacceptable.""]** — Mówca: **Player**
> ""I understand you, Mr. Leke. This discrimination against you is unacceptable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Mansoun Leke: ""That's where your help would be very valuable.""*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""I don't see what I can do. This is the cold truth of Sordish politics.""]** — Mówca: **Player**
> ""I don't see what I can do. This is the cold truth of Sordish politics.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Mansoun Leke: ""I don't think you are taking this issue seriously, Mr. P..."*)

### Węzeł `[17]`
Mówca: **Mansoun Leke**
> ""We can't have the same happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Mansoun Leke: ""I've always brought my people's concerns to the Assembly..."*)

### Węzeł `[18]`
Mówca: **Mansoun Leke**
> ""That's where your help would be very valuable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "He gestured at the papers that I had received from him ea..."*)

### Węzeł `[19]`
Mówca: **Mansoun Leke**
> ""I don't think you are taking this issue seriously, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Mansoun Leke: ""If you wanted to help, you could do that very easily. Yo..."*)

### Węzeł `[20]`
Mówca: **Mansoun Leke**
> ""If you wanted to help, you could do that very easily. You cannot let this vicious cycle run its course. The USP's Bludish voters have high expectations of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "He gestured at the papers that I had received from him ea..."*)

### Węzeł `[21]`
Mówca: **Mansoun Leke**
> ""All we need is your support for our bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Mansoun Leke: ""It's time to undo the mistakes of the Sordish state agai..."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "He gestured at the papers that I had received from him earlier."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Mansoun Leke: ""All we need is your support for our bill.""*)

### Węzeł `[23]`
Mówca: **Mansoun Leke**
> ""It's time to undo the mistakes of the Sordish state against its citizens. I only ask you to help us make this single step for good instead of staying idle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Mansoun Leke: ""Our proposal aims to form a Committee for Minority Rights.""*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true || BaseGame.Bill_Turn07_LanguageBill_Signed == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true || B..."*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true ||..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true || BaseGame.Bill_Turn07_LanguageBill_Signed == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  or  Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Mansoun Leke: ""And you, Mr. President, have approved anti-Bludish polic..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true || BaseGame.Bill_Turn07_LanguageBill_Signed == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  or  Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Mansoun Leke: ""We need your help.""*)

### Węzeł `[27]`
Mówca: **Mansoun Leke**
> ""And you, Mr. President, have approved anti-Bludish policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Mansoun Leke: ""I know, or want to believe, that you only did this to ap..."*)

### Węzeł `[28]`
Mówca: **Mansoun Leke**
> ""I know, or want to believe, that you only did this to appease your base.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Mansoun Leke: ""I am here to ask you to reconsider your stance. We can m..."*)

### Węzeł `[29]`
Mówca: **Mansoun Leke**
> ""I am here to ask you to reconsider your stance. We can make a difference in Sordland. Together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player: ""What makes you think that I only had political reasons?""*)
  - -> `[31]` (*Player: ""I don't believe I've done anything against the Bludish p..."*)
  - -> `[32]` (*Player: ""It's true that I have some regrets over my actions. But ..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: ""What makes you think that I only had political reasons?""]** — Mówca: **Player**
> ""What makes you think that I only had political reasons?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "He eyed me closely for a few seconds."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: ""I don't believe I've done anything against the Bludish people.""]** — Mówca: **Player**
> ""I don't believe I've done anything against the Bludish people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Mansoun Leke), `[55]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[32]`
**[WYBÓR GRACZA: ""It's true that I have some regrets over my actions. But how can I help you?""]** — Mówca: **Player**
> ""It's true that I have some regrets over my actions. But how can I help you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Mansoun Leke: ""We should start by undoing your regrets, Mr. President.""*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProSollist == true && BaseGame.Policy_Law_AutonomousZoneOfBergia == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProSollist == true && BaseGa..."*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ErsenCase_Statement_ProSollist == true && Base..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProSollist == true && BaseGame.Policy_Law_AutonomousZoneOfBergia == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true  and  Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Mansoun Leke: ""You did not protect Ishval Ersen and allowed the Court t..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ErsenCase_Statement_ProSollist == true && BaseGame.Policy_Law_AutonomousZoneOfBergia == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true  and  Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Mansoun Leke: ""Really?""*)

### Węzeł `[36]`
Mówca: **Mansoun Leke**
> ""You banned the only pro-Bludish democratic party in Sordland. For alleged links to the BFF...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Mansoun Leke: ""Are you aware of the numbers of Bludish people who were ..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Mansoun Leke: ""You banned the only pro-Bludish democratic party in Sord..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProSollist == true && BaseGa..."*)

### Węzeł `[40]`
Mówca: **Mansoun Leke**
> ""Are you aware of the numbers of Bludish people who were arrested because of that decision? Do you know how your police acted against us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && B..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn07_LanguageBill_Signed == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Mansoun Leke: ""You targeted our language and banned it in schools.""*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn07_LanguageBill_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Mansoun Leke: ""What are these policies if not an attempt to oppress Blu..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Mansoun Leke: ""You targeted our faith and banned our language and our p..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && B..."*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true &&..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  and  Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Mansoun Leke: ""And you effectively removed our language in Sordland. Fi..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Bill_Turn07_LanguageBill_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  and  Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)

### Węzeł `[50]`
Mówca: **Mansoun Leke**
> ""And you effectively removed our language in Sordland. First from religion, and then from schools.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Mansoun Leke: ""What are these laws if not an attempt at cultural genoci..."*)

### Węzeł `[51]`
Mówca: **Mansoun Leke**
> ""You targeted our faith and banned our language and our priests from the sanctuaries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Mansoun Leke: ""What are these laws if not an attempt at cultural genoci..."*)

### Węzeł `[52]`
Mówca: **Mansoun Leke**
> ""You targeted our language and banned it in schools.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Mansoun Leke: ""What are these laws if not an attempt at cultural genoci..."*)

### Węzeł `[53]`
Mówca: **Mansoun Leke**
> ""What are these laws if not an attempt at cultural genocide?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Mansoun Leke: ""It is time to undo these mistakes, Mr. President.""*)

### Węzeł `[54]`
Mówca: **Narrator**
> "He eyed me closely for a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Mansoun Leke: ""Then please tell me, Mr. President. What was your motiva..."*)

### Węzeł `[55]`
Mówca: **Mansoun Leke**
> ""Then please tell me, Mr. President. What was your motivation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: ""The dangerous separatist sentiment in Bergia needed to b..."*)
  - -> `[67]` (*Player: ""True, it was political. I couldn't reject such popular r..."*)
  - -> `[31]` (*Player: ""I don't believe I've done anything against the Bludish p..."*)

### Węzeł `[56]`
Mówca: **Mansoun Leke**
> ""You did not protect Ishval Ersen and allowed the Court to appoint a ultranationalist as the governor of Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_SpecialZoneOfBergia == false && BaseG..."*)

### Węzeł `[57]`
Mówca: **Mansoun Leke**
> ""Are you aware of the actions of the governor? How he's oppressing our people? What he's doing in our villages?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && B..."*)

### Węzeł `[58]`
Mówca: **Mansoun Leke**
> ""Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Mansoun Leke: ""You were not only silent about the racism in this countr..."*)

### Węzeł `[59]`
Mówca: **Mansoun Leke**
> ""You were not only silent about the racism in this country, you enabled it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && B..."*)

### Węzeł `[60]`
Mówca: **Mansoun Leke**
> ""We should start by undoing your regrets, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[61]`
Mówca: **Mansoun Leke**
> ""What are these policies if not an attempt to oppress Bludish people?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Mansoun Leke: ""It is time to undo these mistakes, Mr. President.""*)

### Węzeł `[62]`
Mówca: **Mansoun Leke**
> ""It is time to undo these mistakes, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Veto_Removed == true && BaseGame.Refo..."*)
  - -> `[72]` (*Player: ""What are you asking me to do?""*)
  - -> `[74]` (*Player: ""Why should I undo what I did?""*)
  - -> `[76]` (*Player: ""Know your place, Mr. Leke.""*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Mansoun Leke: ""You banned the only pro-Bludish democratic party in Sord..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProSollist == true && BaseGa..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: ""The dangerous separatist sentiment in Bergia needed to be curbed.""]** — Mówca: **Player**
> ""The dangerous separatist sentiment in Bergia needed to be curbed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Mansoun Leke: ""Dangerous separatist sentiment?""*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""True, it was political. I couldn't reject such popular requests from the nationalists.""]** — Mówca: **Player**
> ""True, it was political. I couldn't reject such popular requests from the nationalists.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Mansoun Leke: ""Sometimes it's easier to ignore issues that do not direc..."*)

### Węzeł `[68]`
Mówca: **Mansoun Leke**
> ""Dangerous separatist sentiment?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Mansoun Leke: ""We only want our rights as proper citizens of this count..."*)

### Węzeł `[69]`
Mówca: **Mansoun Leke**
> ""We only want our rights as proper citizens of this country. But since the founding of this republic, we have only been further disenfranchised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[70]`
Mówca: **Mansoun Leke**
> ""Sometimes it's easier to ignore issues that do not directly affect you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Mansoun Leke: ""But this system of Sordland that feeds on the Bludish pe..."*)

### Węzeł `[71]`
Mówca: **Mansoun Leke**
> ""But this system of Sordland that feeds on the Bludish people's suffering will one day explode.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[72]`
**[WYBÓR GRACZA: ""What are you asking me to do?""]** — Mówca: **Player**
> ""What are you asking me to do?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Po..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: ""You are right, Mr. Leke. I'm not proud of my decisions.""]** — Mówca: **Player**
> ""You are right, Mr. Leke. I'm not proud of my decisions.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Veto_Removed"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[62]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Mansoun Leke: ""Then please help us, Mr. President.""*)

### Węzeł `[74]`
**[WYBÓR GRACZA: ""Why should I undo what I did?""]** — Mówca: **Player**
> ""Why should I undo what I did?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "Mansoun's eyes hardened."*)

### Węzeł `[75]`
Mówca: **Mansoun Leke**
> ""I thought you would understand. As someone who made it to this position from the farmlands of outer Deyr...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Mansoun Leke: ""Maybe I was wrong.""*)

### Węzeł `[76]`
**[WYBÓR GRACZA: ""Know your place, Mr. Leke.""]** — Mówca: **Player**
> ""Know your place, Mr. Leke.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Mansoun Leke), `[82]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "He looked at me with a stolid expression."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "Mansoun's eyes hardened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Mansoun Leke: ""I thought you would understand. As someone who made it t..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Mansoun Leke: ""I thought you were different.""*)

### Węzeł `[81]`
Mówca: **Mansoun Leke**
> ""I thought you were different.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Mansoun Leke: ""Maybe I was wrong.""*)

### Węzeł `[82]`
Mówca: **Mansoun Leke**
> ""Maybe I was wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: ""What do you want me to do?""*)
  - -> `[91]` (*Player: ""Yes, you were. And I think our meeting is now over.""*)
  - -> `[76]` (*Player: ""Know your place, Mr. Leke.""*)

### Węzeł `[83]`
Mówca: **Mansoun Leke**
> ""Then please help us, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Po..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Policy_Law_Decree_Removed == true) && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Po..."*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Policy_Law_Decree_Weaker == true || BaseGame...."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Policy_Law_Decree_Removed == true) && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Weaker"] == true  or  Variable["BaseGame.Policy_Law_Decree_Removed"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Mansoun Leke: ""Talk to your fellow USP members and put your support beh..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Policy_Law_Decree_Removed == true) && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Decree_Weaker"] == true  or  Variable["BaseGame.Policy_Law_Decree_Removed"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Mansoun Leke: ""We have a proposal to give amnesty to those who were fal..."*)

### Węzeł `[87]`
Mówca: **Mansoun Leke**
> ""Talk to your fellow USP members and put your support behind our bill. Our proposal will give amnesty to those who were falsely arrested for having ties to the democratic Bludish Freedom Party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_La..."*)

### Węzeł `[88]`
Mówca: **Mansoun Leke**
> ""And it will form a Commission for Minority Rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player: ""Okay, I'll do it.""*)
  - -> `[130]` (*Player: ""I don't think I can help you, Mr. Leke.""*)

### Węzeł `[89]`
Mówca: **Mansoun Leke**
> ""We have a proposal to give amnesty to those who were falsely arrested for having ties to the democratic Bludish Freedom Party. Pass it as a decree. You don't need the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_La..."*)

### Węzeł `[90]`
Mówca: **Mansoun Leke**
> ""And let us independents form a Commission for Minority Rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player: ""Okay, I'll do it.""*)
  - -> `[130]` (*Player: ""I don't think I can help you, Mr. Leke.""*)

### Węzeł `[91]`
**[WYBÓR GRACZA: ""Yes, you were. And I think our meeting is now over.""]** — Mówca: **Player**
> ""Yes, you were. And I think our meeting is now over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Mansoun Leke: ""I never thought you were an ethnonationalist.""*)

### Węzeł `[92]`
**[WYBÓR GRACZA: ""What do you want me to do?""]** — Mówca: **Player**
> ""What do you want me to do?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Po..."*)

### Węzeł `[93]`
Mówca: **Mansoun Leke**
> ""And it will lift the ban on the Bludish Freedom Party. As well as giving amnesty to all who were arrested for having ties to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Mansoun Leke: ""Their families are still waiting for them in Bergia..."'"*)

### Węzeł `[94]`
**[WYBÓR GRACZA: ""Okay, I'll do it.""]** — Mówca: **Player**
> ""Okay, I'll do it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed = true; Bas..."*)

### Węzeł `[95]`
Mówca: **Mansoun Leke**
> ""Their families are still waiting for them in Bergia..."'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Mansoun Leke: ""It's not Tarquin Soll's era anymore. It's time we try to..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA: ""I don't think I can support this proposal, Mr. Leke.""]** — Mówca: **Player**
> ""I don't think I can support this proposal, Mr. Leke.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA: ""I agree with you completely, Mr. Leke. Thank you for representing this noble cause.""]** — Mówca: **Player**
> ""I agree with you completely, Mr. Leke. Thank you for representing this noble cause.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Mansoun Leke: ""Glad to hear it, Mr. President.""*)

### Węzeł `[98]`
Mówca: **Mansoun Leke**
> ""Our proposal aims to form a Committee for Minority Rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Mansoun Leke: ""And it will lift the ban on the Bludish Freedom Party. A..."*)

### Węzeł `[99]`
Mówca: **Mansoun Leke**
> ""It's not Tarquin Soll's era anymore. It's time we try to clean up the taint he left on our history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player: ""I agree with you completely, Mr. Leke. Thank you for rep..."*)
  - -> `[96]` (*Player: ""I don't think I can support this proposal, Mr. Leke.""*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Decision_TrySoll == true"*)

### Węzeł `[100]`
**[WYBÓR GRACZA: ""Exactly. By the way, his trial is next month. You can attend it if you want to.""]** — Mówca: **Player**
> ""Exactly. By the way, his trial is next month. You can attend it if you want to.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Results_Decision_TrySoll"] == true`
- **Kontekst wejściowy (poprzednik):** `[99]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Mansoun Leke: ""Oh, thank you. I will *definitely* be there.""*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Results_Decision_TrySoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Decision_TrySoll == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Results_Decision_TrySoll == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Results_Decision_TrySoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Results_Decision_TrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player: ""Exactly. By the way, his trial is next month. You can at..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Results_Decision_TrySoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Results_Decision_TrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player: ""I entirely disagree.""*)

### Węzeł `[104]`
**[WYBÓR GRACZA: ""I entirely disagree.""]** — Mówca: **Player**
> ""I entirely disagree.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_Results_Decision_TrySoll"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[99]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[105]`
Mówca: **Narrator**
> "Mansoun's eyes hardened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Mansoun Leke: ""It's a no, then?""*)

### Węzeł `[106]`
Mówca: **Mansoun Leke**
> ""Oh, thank you. I will *definitely* be there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "He rubbed his chin."*)

### Węzeł `[107]`
Mówca: **Mansoun Leke**
> ""Glad to hear it, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "He rubbed his chin."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "He looked at me with a stolid expression."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Mansoun Leke: ""What is that supposed to mean?""*)

### Węzeł `[109]`
Mówca: **Mansoun Leke**
> ""What is that supposed to mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: ""It's a no, Mr. Leke. I cannot help you.""*)
  - -> `[111]` (*Player: ""It means stop hurling accusations at me and just tell me..."*)
  - -> `[126]` (*Player: ""I can't help the Bluds while my own people suffer.""*)

### Węzeł `[110]`
**[WYBÓR GRACZA: ""It's a no, Mr. Leke. I cannot help you.""]** — Mówca: **Player**
> ""It's a no, Mr. Leke. I cannot help you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Mansoun Leke: ""You're that scared of losing your *racist* voters ahead ..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA: ""It means stop hurling accusations at me and just tell me what you want.""]** — Mówca: **Player**
> ""It means stop hurling accusations at me and just tell me what you want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Po..."*)

### Węzeł `[112]`
Mówca: **Narrator**
> "He rubbed his chin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Mansoun Leke: ""So we have your support?""*)

### Węzeł `[113]`
Mówca: **Mansoun Leke**
> ""So we have your support?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Po..."*)
  - -> `[119]` (*Player: ""As much as I want to, I don't think this is the right ti..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Policy_Law_Decree_Removed == true) && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Po..."*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Policy_Law_Decree_Weaker == true || BaseGame...."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Policy_Law_Decree_Removed == true) && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Weaker"] == true  or  Variable["BaseGame.Policy_Law_Decree_Removed"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: ""Yes. I'll form the commission and support your bill in t..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Policy_Law_Decree_Removed == true) && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Policy_Law_Decree_Weaker"] == true  or  Variable["BaseGame.Policy_Law_Decree_Removed"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: ""Yes. I'll form the commission and sign your proposal as ..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA: ""Yes. I'll form the commission and support your bill in the Assembly.""]** — Mówca: **Player**
> ""Yes. I'll form the commission and support your bill in the Assembly.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Policy_Law_Decree_Weaker"] == true  or  Variable["BaseGame.Policy_Law_Decree_Removed"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[113]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.NoUnrest_Mansoun_Deal_Promised = true; BaseGame...."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: ""Yes. I'll form the commission and sign your proposal as a decree.""]** — Mówca: **Player**
> ""Yes. I'll form the commission and sign your proposal as a decree.""
- **Wymagania odblokowania (kod gry):** `((Variable["BaseGame.Policy_Law_Decree_Weaker"] == true  or  Variable["BaseGame.Policy_Law_Decree_Removed"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[113]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed = true; Bas..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA: ""As much as I want to, I don't think this is the right time. The nationalists would be furious.""]** — Mówca: **Player**
> ""As much as I want to, I don't think this is the right time. The nationalists would be furious.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[120]`
Mówca: **Mansoun Leke**
> ""What?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Mansoun Leke: ""You're that scared of losing your *racist* voters ahead ..."*)

### Węzeł `[121]`
Mówca: **Mansoun Leke**
> ""It's a no, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: ""It's a no, Mr. Leke. I cannot help you.""*)
  - -> `[123]` (*Player: ""This isn't the right time. The nationalists would have m..."*)
  - -> `[125]` (*Player: ""I can't help the Bluds while my own people suffer.""*)

### Węzeł `[122]`
**[WYBÓR GRACZA: ""It's a no, Mr. Leke. I cannot help you.""]** — Mówca: **Player**
> ""It's a no, Mr. Leke. I cannot help you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Mansoun Leke: ""You're that scared of losing your *racist* voters ahead ..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: ""This isn't the right time. The nationalists would have my head for this.""]** — Mówca: **Player**
> ""This isn't the right time. The nationalists would have my head for this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Mansoun Leke: ""What?""*)

### Węzeł `[124]`
Mówca: **Mansoun Leke**
> ""You're that scared of losing your *racist* voters ahead of the elections?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.NoUnrest_Mansoun_Deal_Failed = true; BaseGame.Bl..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA: ""I can't help the Bluds while my own people suffer.""]** — Mówca: **Player**
> ""I can't help the Bluds while my own people suffer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Mansoun Leke: ""I never thought you were an ethnonationalist.""*)

### Węzeł `[126]`
**[WYBÓR GRACZA: ""I can't help the Bluds while my own people suffer.""]** — Mówca: **Player**
> ""I can't help the Bluds while my own people suffer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Mansoun Leke: ""I never thought you were an ethnonationalist.""*)

### Węzeł `[127]`
Mówca: **Mansoun Leke**
> ""I never thought you were an ethnonationalist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.NoUnrest_Mansoun_Deal_Failed = true; BaseGame.Bl..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NoUnrest_Mansoun_Deal_Promised = true;
BaseGame.Bludish_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.NoUnrest_Mansoun_Deal_Promised"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_NoUnrest_Promise = true"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed = true;
BaseGame.Policy_Law_MinorityRights = true;
BaseGame.Policy_Law_Ban_BFP = false;
BaseGame.Situation_Law_BludishProblem = false;
BaseGame.Bludish_Opinion += 4; BaseGame.Democratic += 2; BaseGame.Malenyevist += 1; BaseGame.Sollist -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] = true;
Variable["BaseGame.Policy_Law_MinorityRights"] = true;
Variable["BaseGame.Policy_Law_Ban_BFP"] = false;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 4;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 2;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_NoUnrest_Decree = true"*)

### Węzeł `[130]`
**[WYBÓR GRACZA: ""I don't think I can help you, Mr. Leke.""]** — Mówca: **Player**
> ""I don't think I can help you, Mr. Leke.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Mansoun Leke), `[90]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Mansoun Leke: ""What?""*)

### Węzeł `[131]`
Mówca: **Mansoun Leke**
> ""What?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Mansoun Leke: ""You're that scared of losing your *racist* voters ahead ..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: ""Okay, I'll do it.""]** — Mówca: **Player**
> ""Okay, I'll do it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.NoUnrest_Mansoun_Deal_Promised = true; BaseGame...."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed = true;
BaseGame.Policy_Law_MinorityRights = true;
BaseGame.Policy_Law_Ban_BFP = false;
BaseGame.Situation_Law_BludishProblem = false;
BaseGame.Situation_Law_BludishOppression = false;
BaseGame.Situation_Law_RestrictiononReligious = false;
BaseGame.Bill_Turn05_ReligiousHarmony_Signed = false;
BaseGame.Bill_Turn07_LanguageBill_Signed = false; BaseGame.Reform_EmergencyDecree_Banned_Bluds = false;
BaseGame.Policy_Law_ReligiousHarmony = false;
BaseGame.Policy_Law_EducationUnification
= false;
BaseGame.Situation_Law_BludishReconciliation = true;
BaseGame.Policy_Law_Ban_WPB = false;
BaseGame.Bludish_Opinion += 4; BaseGame.Democratic += 3; BaseGame.Malenyevist += 1; BaseGame.Sollist -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] = true;
Variable["BaseGame.Policy_Law_MinorityRights"] = true;
Variable["BaseGame.Policy_Law_Ban_BFP"] = false;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;
Variable["BaseGame.Situation_Law_BludishOppression"] = false;
Variable["BaseGame.Situation_Law_RestrictiononReligious"] = false;
Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] = false;
Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] = false;
Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] = false;
Variable["BaseGame.Policy_Law_ReligiousHarmony"] = false;
Variable["BaseGame.Policy_Law_EducationUnification"]
= false;
Variable["BaseGame.Situation_Law_BludishReconciliation"] = true;
Variable["BaseGame.Policy_Law_Ban_WPB"] = false;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 4;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 3;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_NoUnrest_Decree = true"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NoUnrest_Mansoun_Deal_Promised = true;
BaseGame.Bludish_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.NoUnrest_Mansoun_Deal_Promised"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_NoUnrest_Promise = true"*)

### Węzeł `[135]`
Mówca: **Mansoun Leke**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "He rose up and walked up to me. He extended a hand."*)

### Węzeł `[136]`
Mówca: **Narrator**
> "He rose up and walked up to me. He extended a hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Mansoun Leke: ""It means a lot. Thank you.""*)

### Węzeł `[137]`
Mówca: **Mansoun Leke**
> ""It means a lot. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "We shook hands."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[139]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[140]`
Mówca: **Narrator**
> "He rose and walked up to me. He extended a hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Mansoun Leke: ""This means a lot. Thank you.""*)

### Węzeł `[141]`
Mówca: **Mansoun Leke**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "He rose and walked up to me. He extended a hand."*)

### Węzeł `[142]`
Mówca: **Mansoun Leke**
> ""This means a lot. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "We shook hands."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NoUnrest_Mansoun_Deal_Failed = true;
BaseGame.Bludish_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.NoUnrest_Mansoun_Deal_Failed"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_NoUnrest_Refuse = true"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_NoUnrest_Promise = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_NoUnrest_Promise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Mansoun Leke: ""Thank you, Mr. President.""*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_NoUnrest_Decree = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_NoUnrest_Decree"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Mansoun Leke: ""Thank you, Mr. President.""*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_NoUnrest_Promise = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_NoUnrest_Promise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Mansoun Leke: ""Thank you, Mr. President.""*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_NoUnrest_Decree = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_NoUnrest_Decree"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_NoUnrest_Refuse = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_NoUnrest_Refuse"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_BludishRights_Decree = true; BaseGameSupport.News_Turn09_R_BludishRights_Decree = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_BludishRights_Decree"] = true;
Variable["BaseGameSupport.News_Turn09_R_BludishRights_Decree"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Mansoun Leke: ""Thank you, Mr. President.""*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_BludishRights_Decree = tru..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Mansoun Leke: ""Thank you, Mr. President.""*)

### Węzeł `[153]`
Mówca: **Mansoun Leke**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "He rose and walked up to me. He extended a hand."*)

### Węzeł `[154]`
**[WYBÓR GRACZA: ""I don't know what you're talking about, Mr. Leke. I had no power over these matters.""]** — Mówca: **Player**
> ""I don't know what you're talking about, Mr. Leke. I had no power over these matters.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Law_Veto_Removed"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[62]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Mansoun Leke: ""Mr. President, with all due respect, you should have rea..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Veto_Removed == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Veto_Removed == true && BaseGame.Refo..."*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Veto_Removed == true && BaseGame.Re..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Veto_Removed == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Veto_Removed"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Player: ""I don't know what you're talking about, Mr. Leke. I had ..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Veto_Removed == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Veto_Removed"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: ""You are right, Mr. Leke. I'm not proud of my decisions.""*)

### Węzeł `[158]`
Mówca: **Mansoun Leke**
> ""Mr. President, with all due respect, you should have realized removing your veto powers would lead to this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Mansoun Leke: ""You knew full well the state of the assembly and the dir..."*)

### Węzeł `[159]`
Mówca: **Mansoun Leke**
> ""You knew full well the state of the assembly and the direction it would take on its own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "As he talked, he tightened his clenched fist."*)

### Węzeł `[160]`
Mówca: **Mansoun Leke**
> ""By doing nothing, you are enabling the Assembly's bigotry, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Mansoun Leke: ""Whether it is intentional or not.""*)

### Węzeł `[161]`
Mówca: **Mansoun Leke**
> ""Whether it is intentional or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "Mansoun took a deep breath, calming himself."*)

### Węzeł `[162]`
Mówca: **Mansoun Leke**
> ""However, today, I am giving you a chance to take long-overdue action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Policy_Law_Decree_Weaker == true || BaseGame.Po..."*)

### Węzeł `[163]`
Mówca: **Narrator**
> "Mansoun took a deep breath, calming himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Mansoun Leke: ""However, today, I am giving you a chance to take long-ov..."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "As he talked, he tightened his clenched fist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Mansoun Leke: ""By doing nothing, you are enabling the Assembly's bigotr..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_BludishRightsMeeting_Accept == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_BludishRightsMeeting_Accept == true"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn07_BludishRightsMeeting_Accept ==..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_BludishRightsMeeting_Accept == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_BludishRightsMeeting_Accept"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Mansoun Leke: ""Having said that, there has been a lot of new developmen..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn07_BludishRightsMeeting_Accept == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_BludishRightsMeeting_Accept"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_BludishRightsMeeting_Reject == true"*)

### Węzeł `[168]`
Mówca: **Mansoun Leke**
> ""Having said that, there has been a lot of new developments since we last spoke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_BludishRightsMeeting_Reject == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_BludishRightsMeeting_Reject == true"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn07_BludishRightsMeeting_Reject ==..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_BludishRightsMeeting_Reject == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_BludishRightsMeeting_Reject"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Mansoun Leke: ""Having said that, there has been a lot of new developmen..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn07_BludishRightsMeeting_Reject == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_BludishRightsMeeting_Reject"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true || Bas..."*)

### Węzeł `[172]`
Mówca: **Mansoun Leke**
> ""Having said that, there has been a lot of new developments since you rejected our offer to meet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Mansoun Leke: ""Unfortunately, the lack of cooperation from your side ha..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Mansoun Leke: ""Unfortunately, the lack of cooperation from your side ha..."*)

### Węzeł `[176]`
Mówca: **Mansoun Leke**
> ""And the Bludish rights movement is extremely happy with the new changes to the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true)"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Mansoun Leke: ""And the Bludish rights movement is extremely happy with ..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Mansoun Leke: ""Despite failing to change the constitution, I should say..."*)

### Węzeł `[180]`
Mówca: **Mansoun Leke**
> ""Despite failing to change the constitution, I should say that you earned the respect of the Bludish rights movement. I must thank you again for fighting with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[181]`
Mówca: **Mansoun Leke**
> ""Unfortunately, the lack of cooperation from your side has been enabling the hardline nationalists to get bolder about their racist tirades.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Au..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Mansoun Leke: ""Luckily, you approved the new Autonomous Zone of Bergia...."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)

### Węzeł `[185]`
Mówca: **Mansoun Leke**
> ""Luckily, you approved the new Autonomous Zone of Bergia. This was an historic accomplishment. And I must applaud you for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Mansoun Leke: ""However, there is still a lot to do.""*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Au..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Mansoun Leke: ""On top of all that, you approved the new Autonomous Zone..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)

### Węzeł `[189]`
Mówca: **Mansoun Leke**
> ""On top of all that, you approved the new Autonomous Zone of Bergia. This was an historic accomplishment. And I must applaud you for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Mansoun Leke: ""The Bludish community it extremely happy about these dev..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Ce..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Mansoun Leke: ""On top of all that, you managed to revoke the Special Zo..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[193]`
Mówca: **Mansoun Leke**
> ""On top of all that, you managed to revoke the Special Zone. This was an historic accomplishment. And I must applaud you for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Mansoun Leke: ""However, there is still a lot to do.""*)

### Węzeł `[194]`
Mówca: **Mansoun Leke**
> ""On top of all that, you managed to revoke the Special Zone. Although this was an historic accomplishment, I'm not sure if anything really changed that drastically.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "He sighed."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Ce..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Mansoun Leke: ""On top of all that, you managed to revoke the Special Zo..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true)"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Mansoun Leke: ""And Governor Bron is still in charge of the Special Zone..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)

### Węzeł `[201]`
Mówca: **Mansoun Leke**
> ""And Governor Bron is still in charge of the Special Zone... Free to continue his oppressive policies against the Bludish community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "He sighed."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Krull == true)"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Mansoun Leke: ""And an ultranationalist is now governing the Special Zon..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "He sighed."*)

### Węzeł `[205]`
Mówca: **Mansoun Leke**
> ""And an ultranationalist is now governing the Special Zone... Continuing his oppressive policies against the Bludish community behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "He sighed."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true)"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Mansoun Leke: ""But Governor Bron is still in charge of the Special Zone..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)

### Węzeł `[209]`
Mówca: **Mansoun Leke**
> ""But Governor Bron is still in charge of the Special Zone... Free to continue his oppressive policies against the Bludish community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "He sighed."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Krull == true)"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Mansoun Leke: ""But an ultranationalist is now governing the Special Zon..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Mansoun Leke: ""Luckily, we got rid of the governor. This has already he..."*)

### Węzeł `[213]`
Mówca: **Mansoun Leke**
> ""But an ultranationalist is now governing the Special Zone... Continuing his oppressive policies against the Bludish community behind the scenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "He sighed."*)

### Węzeł `[214]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Mansoun Leke: ""And something must be done about this.""*)

### Węzeł `[215]`
Mówca: **Mansoun Leke**
> ""However, there is still a lot to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true || Bas..."*)

### Węzeł `[216]`
Mówca: **Mansoun Leke**
> ""And something must be done about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true || Bas..."*)

### Węzeł `[217]`
Mówca: **Mansoun Leke**
> ""Luckily, we got rid of the governor. This has already helped with decreasing the tensions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Mansoun Leke: ""However, there is still a lot to do.""*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProSollist == true && BaseGame.Policy_Law_AutonomousZoneOfBergia == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.ErsenCase_Statement_ProSollist == true && BaseGa..."*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ErsenCase_Statement_ProSollist == true && Base..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ErsenCase_Statement_ProSollist == true && BaseGame.Policy_Law_AutonomousZoneOfBergia == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true  and  Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Mansoun Leke: ""You did not protect Ishval Ersen and allowed the Court t..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ErsenCase_Statement_ProSollist == true && BaseGame.Policy_Law_AutonomousZoneOfBergia == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ErsenCase_Statement_ProSollist"] == true  and  Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Mansoun Leke: ""You were not only silent about the racism in this countr..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Mansoun Leke: ""Our proposal aims to form a Commit..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Mansoun Leke: ""Our proposal aims to form a Committee for Minority Rights.""*)

### Węzeł `[222]`
Mówca: **Mansoun Leke**
> ""The Bludish community it extremely happy about these developments. You've definitely earned their support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Mansoun Leke: ""I came here today to show you our gratitude and thank yo..."*)

### Węzeł `[223]`
Mówca: **Mansoun Leke**
> ""I came here today to show you our gratitude and thank you again personally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Mansoun Leke: ""According to the movement, there is still one more thing..."*)

### Węzeł `[224]`
Mówca: **Mansoun Leke**
> ""According to the movement, there is still one more thing to do. We'd appreciate your help on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Player: ""How can I help you, Mr. Leke?""*)
  - -> `[226]` (*Player: ""Of course. Just tell me what you need.""*)
  - -> `[227]` (*Player: ""I'm not sure if I can do more after all I've done for yo..."*)
  - -> `[228]` (*Player: ""Do you still have demands? Really?""*)

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""How can I help you, Mr. Leke?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Mansoun Leke: ""We just want you to undo the mistakes of the Sordish sta..."*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Of course. Just tell me what you need.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Mansoun Leke: ""We just want you to undo the mistakes of the Sordish sta..."*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not sure if I can do more after all I've done for your people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Mansoun Leke: ""I understand where you're coming from, Mr. President, bu..."*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you still have demands? Really?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Mansoun Leke)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Mansoun Leke: ""I understand where you're coming from, Mr. President, bu..."*)

### Węzeł `[229]`
Mówca: **Mansoun Leke**
> ""I understand where you're coming from, Mr. President, but please hear us out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Mansoun Leke: ""We just want you to undo the mistakes of the Sordish sta..."*)

### Węzeł `[230]`
Mówca: **Mansoun Leke**
> ""We just want you to undo the mistakes of the Sordish state against Bludish political movements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "Jump to: [Mansoun Leke: ""Our proposal aims to form a Com..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Au..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Mansoun Leke: ""Really?""*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "Mansoun's eyes hardened."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Au..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Mansoun Leke: ""Really?""*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Mansoun Leke: ""What?""*)

### Węzeł `[237]`
Mówca: **Mansoun Leke**
> ""Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Mansoun Leke: ""After all you've done, is this really such a major thing..."*)

### Węzeł `[238]`
Mówca: **Mansoun Leke**
> ""After all you've done, is this really such a major thing for you or the nationalists?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "He sighed."*)

### Węzeł `[239]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Mansoun Leke: ""This is very disappointing. But I understand.""*)

### Węzeł `[240]`
Mówca: **Mansoun Leke**
> ""This is very disappointing. But I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Arrest_FetihEjall == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Arrest_FetihEjall == true"*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Arrest_FetihEjall == true)"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Arrest_FetihEjall == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Arrest_FetihEjall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Mansoun Leke: ""And considering now that I'm representing the Workers Pa..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Arrest_FetihEjall == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Arrest_FetihEjall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_BludishRightsMeeting_Accept == true"*)

### Węzeł `[244]`
Mówca: **Narrator**
> "He stopped for a moment and repositioned himself on his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Arrest_FetihEjall == true"*)

### Węzeł `[245]`
Mówca: **Mansoun Leke**
> ""And considering now that I'm representing the Workers Party in the Assembly as its new leader...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Mansoun Leke: ""...I have a lot more responsibility against my people.""*)

### Węzeł `[246]`
Mówca: **Mansoun Leke**
> ""...I have a lot more responsibility against my people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_BludishRightsMeeting_Accept == true"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Arrest_FetihEjall == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Arrest_FetihEjall == true"*)
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Arrest_FetihEjall == true)"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Arrest_FetihEjall == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Arrest_FetihEjall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Mansoun Leke: ""The Assembly does not take the Workers Party seriously.""*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Arrest_FetihEjall == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Arrest_FetihEjall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Mansoun Leke: ""The Assembly does not take us independents seriously.""*)

### Węzeł `[250]`
Mówca: **Mansoun Leke**
> ""The Assembly does not take the Workers Party seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true || B..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_SpecialZoneOfBergia == false && BaseGame.Policy_Law_AutonomousZoneOfBergia == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_SpecialZoneOfBergia == false && BaseG..."*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_SpecialZoneOfBergia == false && Bas..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_SpecialZoneOfBergia == false && BaseGame.Policy_Law_AutonomousZoneOfBergia == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false  and  Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Mansoun Leke: ""Are you aware of the actions of the Minister of Interior..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_SpecialZoneOfBergia == false && BaseGame.Policy_Law_AutonomousZoneOfBergia == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false  and  Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_AutonomousZoneOfBergia == true"*)

### Węzeł `[254]`
Mówca: **Mansoun Leke**
> ""Are you aware of the actions of the Minister of Interior? How she's making life difficult for some locals? What her police is doing to our community leaders?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && B..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_AutonomousZoneOfBergia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_AutonomousZoneOfBergia == true"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_AutonomousZoneOfBergia == true)"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_AutonomousZoneOfBergia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Mansoun Leke: ""The situation might be better now with the autonomous zo..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_AutonomousZoneOfBergia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Mansoun Leke: ""Are you aware of the actions of the governor? How he's o..."*)

### Węzeł `[258]`
Mówca: **Mansoun Leke**
> ""The situation might be better now with the autonomous zone but the history of our people and their memories will remain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && B..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_BFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_La..."*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_BFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_BFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Mansoun Leke: ""It will revoke the current ban and allow both the Worker..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_BFP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_BFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Mansoun Leke: ""And it will form a Commission for Minority Rights.""*)

### Węzeł `[262]`
Mówca: **Mansoun Leke**
> ""It will revoke the current ban and allow both the Worker's Party of Bludia and the Bludish Freedom Party into politics once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Mansoun Leke: ""And it will form a Commission for Minority Rights.""*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_BFP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_La..."*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_BFP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_BFP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Mansoun Leke: ""Needless to say, your decree must also revoke the curren..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_BFP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_BFP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Mansoun Leke: ""And let us independents form a Commission for Minority R..."*)

### Węzeł `[266]`
Mówca: **Mansoun Leke**
> ""Needless to say, your decree must also revoke the current ban and allow both the Worker's Party of Bludia and the Bludish Freedom Party into politics once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Mansoun Leke: ""And let us independents form a Commission for Minority R..."*)
