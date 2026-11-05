# Sordland/Turn07/SecurityDecisions

- **ID konwersacji:** `124`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/124_SecurityDecisions.md`
- **Liczba węzłów dialogowych:** 289
- **Liczba wyborów gracza:** 51

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[56]** Karl Greiser

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Policy_Order_SecretStatePolice`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Law_Judges_Impeachment_Default`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Turn07_Emergency_Detained_Frens`
- `BaseGame.Stopped_Investigations_NFP`
- `BaseGame.Turn05_SnO_Investigate_OldGuard`
- `BaseGame.Turn05_SnO_Investigate_Oligarchs`
- `BaseGame.Turn07_Detained_MarcelKoronti`
- `BaseGame.Turn07_Detained_WalterTusk`
- `BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker`
- `BaseGame.YoungSords_Kill_OrsoHawker`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Turn07_Investigate_Dropped`
- `BaseGame.Turn07_Investigate_OldGuard`
- `BaseGame.Turn07_Investigate_Oligarchs`
- `BaseGame.Turn07_Investigate_Opposition`
- `BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker`
- `BaseGame.Turn07_SecretState_Detained_FrensRicter`
- `BaseGame.Turn07_SecretState_Detained_KesaroKibener`
- `BaseGame.Turn07_SecretState_Kill_FrensRicter`
- `BaseGame.Turn07_SecretState_Kill_KesaroKibener`
- `BaseGame.Turn07_SecretState_Kill_OrsoHawker`
- `BaseGameSupport.Journal_Turn07_Results_DetainFrens`
- `BaseGameSupport.Journal_Turn07_Results_DetainFrens_ACP`
- `BaseGameSupport.Journal_Turn07_Results_DetainKesaro`
- `BaseGameSupport.Journal_Turn07_Results_DetainKesaro_ACP`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuardDropped`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuardDropped_ACP`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard_ACP`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchsDropped`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchsDropped_ACP`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs_ACP`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOppositionDropped`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOppositionDropped_ACP`
- `BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition_ACP`
- `BaseGameSupport.Journal_Turn07_Results_KillFrens`
- `BaseGameSupport.Journal_Turn07_Results_KillKesaro`
- `BaseGameSupport.Journal_Turn07_Results_KillOrsoAndInvestigateOldGuard`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[115] Sordland/Turn07/A_ResultsMeeting** (../Turn_07/115_A_ResultsMeeting.md), Węzeł `[9]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **""Of course. Let's go inside the office.""** | `[5]` **Karl Greiser**: ""Can I have a moment of your tim..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Narrator**: "We entered my office. I sat behi..." |
| `[7]` | **""What is this about?""** | `[5]` **Karl Greiser**: ""Can I have a moment of your tim..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Karl Greiser**: ""It is classified information re..." |
| `[10]` | **""Okay. Let's go inside the office.""** | `[9]` **Karl Greiser**: ""It would be better if we talk i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Narrator**: "We entered my office. I sat behi..." |
| `[11]` | **""Fine. But I don't have too much time to spare.""** | `[9]` **Karl Greiser**: ""It would be better if we talk i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Karl Greiser**: ""It will only take a moment, sir."" |
| `[14]` | **""So... What is this about?""** | `[13]` **Narrator**: "We entered my office. I sat behi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Karl Greiser**: ""The Secret State Police has com..."<br>`[22]` **Karl Greiser**: ""The Anti-Corruption Police has ..." |
| `[15]` | **""I'm listening.""** | `[13]` **Narrator**: "We entered my office. I sat behi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Karl Greiser**: ""The Secret State Police has com..."<br>`[22]` **Karl Greiser**: ""The Anti-Corruption Police has ..." |
| `[16]` | **""Please have a seat, Karl.""** | `[13]` **Narrator**: "We entered my office. I sat behi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Karl Greiser**: ""Thank you sir. But I'm fine. I ..." |
| `[84]` | **""If the laws are not on our side, we'll find *another* way. That's why I have you.""** | `[44]` **Karl Greiser**: ""If we decide to make a case, we..." | `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  and  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false` | *Brak zmian stanu* | `[98]` **Karl Greiser**: ""Of course, sir."" |
| `[85]` | **""Proceed with the case. As long as we hurt them, the Court doesn't matter.""** | `[44]` **Karl Greiser**: ""If we decide to make a case, we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Karl Greiser**: ""Yes, sir."" |
| `[86]` | **""Let's drop the investigations for now. We don't need it anymore.""** | `[44]` **Karl Greiser**: ""If we decide to make a case, we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Karl Greiser**: ""As you wish, sir."" |
| `[87]` | **""We don't need the *legal* way. I need Orso gone.""** | `[46]` **Karl Greiser**: ""If we decide to proceed, we can..." | `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  and  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false` | *Brak zmian stanu* | `[100]` **Karl Greiser**: ""I see."" |
| `[88]` | **""Proceed with a legal case. We can finally get them.""** | `[46]` **Karl Greiser**: ""If we decide to proceed, we can..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Karl Greiser**: ""Yes, sir."" |
| `[89]` | **""Let's drop the investigations for now. We don't need it anymore.""** | `[46]` **Karl Greiser**: ""If we decide to proceed, we can..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Karl Greiser**: ""As you wish, sir."" |
| `[90]` | **""Continue your efforts and keep looking.""** | `[74]` **Karl Greiser**: ""If we decide to proceed with ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Karl Greiser**: ""Yes, sir."" |
| `[91]` | **""Let's drop the investigation for now. We don't need it anymore.""** | `[74]` **Karl Greiser**: ""If we decide to proceed with ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Karl Greiser**: ""As you wish, sir."" |
| `[92]` | **""Let's drop the investigation for now. We don't need it anymore.""** | `[80]` **Karl Greiser**: ""However, it is very difficult t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Karl Greiser**: ""As you wish, sir."" |
| `[93]` | **""Continue your efforts and keep looking." [Investigate Opposition]"** | `[78]` **Karl Greiser**: ""However, it is very difficult t..."<br>`[80]` **Karl Greiser**: ""However, it is very difficult t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Karl Greiser**: ""As you wish, sir."" |
| `[94]` | **""We don't need a *legal* case to end them, Karl. That's why I have you.""** | `[78]` **Karl Greiser**: ""However, it is very difficult t..."<br>`[80]` **Karl Greiser**: ""However, it is very difficult t..." | `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true` | *Brak zmian stanu* | `[144]` **Karl Greiser**: ""Of course, sir."" |
| `[95]` | **""Let's drop the investigation for now. We don't need it anymore.""** | `[78]` **Karl Greiser**: ""However, it is very difficult t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Karl Greiser**: ""As you wish, sir."" |
| `[103]` | **""Keep your eyes open. I don't want your focus to be centered at one target.""** | `[96]` **Karl Greiser**: ""As you wish, sir."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_Investigate_Dropped"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn07_Results_Investig...`<br>*(+2 skryptów)* | `[171]` **Karl Greiser**: ""Yes, sir."" |
| `[104]` | **""It's time we shift our focus on another faction.""** | `[96]` **Karl Greiser**: ""As you wish, sir."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Player**: ""Start investigating the Oligarc..."<br>`[137]` **Player**: ""Start investigating the opposit..." |
| `[105]` | **""Keep a low profile. We can't afford to risk unwanted attention with these investi..."** | `[96]` **Karl Greiser**: ""As you wish, sir."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_Investigate_Dropped"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn07_Results_Investig...`<br>*(+2 skryptów)* | `[171]` **Karl Greiser**: ""Yes, sir."" |
| `[106]` | **""But for now, just proceed with the case, Karl. We don't want unnecessary attention.""** | `[98]` **Karl Greiser**: ""Of course, sir."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_Investigate_OldGuard"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn07_Results_Investig...` | `[172]` **Karl Greiser**: ""As you wish, sir."" |
| `[107]` | **""I want Orso gone. For good.""** | `[98]` **Karl Greiser**: ""Of course, sir.""<br>`[100]` **Karl Greiser**: ""I see."" | `(Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] == true) == false` | *Brak zmian stanu* | `[113]` **Karl Greiser**: ""I understand. I'll see to it, s..." |
| `[111]` | **""I thought I was clear before. Why isn't Orso *gone*?""** | `[98]` **Karl Greiser**: ""Of course, sir.""<br>`[100]` **Karl Greiser**: ""I see."" | `Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] == true` | *Brak zmian stanu* | `[112]` **Karl Greiser**: ""It will happen soon, sir. It wa..." |
| `[119]` | **""Keep a low profile. We can't afford to risk unwanted attention with these investi..."** | `[121]` **Karl Greiser**: ""As you wish, sir."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_Investigate_Dropped"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn07_Results_Investig...`<br>*(+1 skryptów)* | `[169]` **Karl Greiser**: ""I'll give you an update soon."" |
| `[122]` | **""Keep your eyes open. I don't want your focus to be centered at one target.""** | `[121]` **Karl Greiser**: ""As you wish, sir."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_Investigate_Dropped"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn07_Results_Investig...`<br>*(+1 skryptów)* | `[169]` **Karl Greiser**: ""I'll give you an update soon."" |
| `[123]` | **""It's time we shift our focus to another faction.""** | `[121]` **Karl Greiser**: ""As you wish, sir."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Player**: ""Start investigating the Old Gua..."<br>`[140]` **Player**: ""Start investigating the opposit..." |
| `[125]` | **""It's time we shift our focus on another faction.""** | `[127]` **Karl Greiser**: ""As you wish, sir."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Player**: ""Start investigating the Old Gua..."<br>`[162]` **Player**: ""Start investigating the Oligarc..." |
| `[126]` | **""Keep a low profile. We can't afford to risk unwanted attention with these investi..."** | `[127]` **Karl Greiser**: ""As you wish, sir."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_Investigate_Dropped"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn07_Results_Investig...`<br>*(+1 skryptów)* | `[166]` **Karl Greiser**: ""Yes sir."" |
| `[129]` | **""Keep your eyes open. I don't want your focus to be centered at one target.""** | `[127]` **Karl Greiser**: ""As you wish, sir."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_Investigate_Dropped"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn07_Results_Investig...`<br>*(+1 skryptów)* | `[166]` **Karl Greiser**: ""Yes sir."" |
| `[134]` | **""I hope there is an update about Orso, Karl.""** | `[13]` **Narrator**: "We entered my office. I sat behi..." | `Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] == true` | *Brak zmian stanu* | `[133]` **Karl Greiser**: ""Not yet sir, but soon. He will ..." |
| `[136]` | **""Start investigating the Oligarchs.""** | `[104]` **Player**: ""It's time we shift our focus el..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_Investigate_Oligarchs"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn07_Results_Investig...`<br>*(+2 skryptów)* | `[171]` **Karl Greiser**: ""Yes, sir."" |
| `[137]` | **""Start investigating the opposition.""** | `[104]` **Player**: ""It's time we shift our focus el..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_Investigate_Opposition"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn07_Results_Investig...`<br>*(+2 skryptów)* | `[171]` **Karl Greiser**: ""Yes, sir."" |
| `[140]` | **""Start investigating the opposition.""** | `[123]` **Player**: ""It's time we shift our focus el..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_Investigate_Opposition"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn07_Results_Investig...`<br>*(+1 skryptów)* | `[170]` **Karl Greiser**: ""Yes, sir."" |
| `[143]` | **""Start investigating the Old Guard.""** | `[123]` **Player**: ""It's time we shift our focus el..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_Investigate_OldGuard"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn07_Results_Investig...`<br>*(+1 skryptów)* | `[170]` **Karl Greiser**: ""Yes, sir."" |
| `[145]` | **""But for now, just continue your investigations, Karl. We don't want unnecessary a..."** | `[144]` **Karl Greiser**: ""Of course, sir."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Karl Greiser**: ""As you wish, sir."" |
| `[146]` | **""I want Ricter gone. For good.""** | `[144]` **Karl Greiser**: ""Of course, sir."" | `(Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true) == false` | *Brak zmian stanu* | `[147]` **Karl Greiser**: ""For good?"" |
| `[148]` | **""Yes.""** | `[147]` **Karl Greiser**: ""For good?"" | `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true` | `Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] ...`<br>`Variable["BaseGameSupport.Journal_Turn07_Results_KillFren...`<br>*(+1 skryptów)* | `[168]` **Karl Greiser**: ""I understand. I'll see to it, s..." |
| `[149]` | **""I just want him detained and sent to Antel Rock.""** | `[147]` **Karl Greiser**: ""For good?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_SecretState_Detained_FrensRicte...`<br>`Variable["BaseGameSupport.Journal_Turn07_Results_DetainFr...`<br>*(+2 skryptów)* | `[168]` **Karl Greiser**: ""I understand. I'll see to it, s..." |
| `[154]` | **""We have already arrested Mr. Ricter. This should send a message to the others.""** | `[144]` **Karl Greiser**: ""Of course, sir."" | `Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true` | *Brak zmian stanu* | `[155]` **Karl Greiser**: ""It already did, sir. But the op..." |
| `[156]` | **""Keep watching them. Make sure nobody does something stupid.""** | `[155]` **Karl Greiser**: ""It already did, sir. But the op..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Karl Greiser**: ""We'll do our best, sir."" |
| `[157]` | **""Arrest them if they create problems.""** | `[155]` **Karl Greiser**: ""It already did, sir. But the op..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Karl Greiser**: ""We'll do our best, sir."" |
| `[162]` | **""Start investigating the Oligarchs.""** | `[125]` **Player**: ""It's time we shift our focus el..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_Investigate_Oligarchs"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn07_Results_Investig...`<br>*(+1 skryptów)* | `[150]` **Karl Greiser**: ""Yes sir."" |
| `[164]` | **""Start investigating the Old Guard.""** | `[125]` **Player**: ""It's time we shift our focus el..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_Investigate_OldGuard"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn07_Results_Investig...`<br>*(+1 skryptów)* | `[150]` **Karl Greiser**: ""Yes sir."" |
| `[175]` | **""I'll be waiting.""** | `[174]` **Karl Greiser**: ""Thank you for your time."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Narrator**: "He bowed his head and left the o..." |
| `[176]` | **""Thank you Karl.""** | `[174]` **Karl Greiser**: ""Thank you for your time."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Narrator**: "He bowed his head and left the o..." |
| `[178]` | **""I want Kibener gone. For good.""** | `[144]` **Karl Greiser**: ""Of course, sir."" | `Variable["BaseGame.Stopped_Investigations_NFP"] == false` | *Brak zmian stanu* | `[179]` **Karl Greiser**: ""For good?"" |
| `[180]` | **""I just want him detained and sent to Antel Rock.""** | `[179]` **Karl Greiser**: ""For good?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibe...`<br>`Variable["BaseGameSupport.Journal_Turn07_Results_DetainKe...`<br>*(+2 skryptów)* | `[168]` **Karl Greiser**: ""I understand. I'll see to it, s..." |
| `[181]` | **""Yes.""** | `[179]` **Karl Greiser**: ""For good?"" | `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true` | `Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"...`<br>`Variable["BaseGameSupport.Journal_Turn07_Results_KillKesa...`<br>*(+1 skryptów)* | `[168]` **Karl Greiser**: ""I understand. I'll see to it, s..." |
| `[288]` | **""The oligarch connection sounds promising. Keep chasing that lead." [Investigate O..."** | `[78]` **Karl Greiser**: ""However, it is very difficult t..."<br>`[80]` **Karl Greiser**: ""However, it is very difficult t..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_Investigate_Oligarchs"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn07_Results_Investig...`<br>*(+1 skryptów)* | `[124]` **Karl Greiser**: ""Yes, sir."" |

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
  - -> `[3]` (*Narrator: "Karl Greiser was waiting for me by the door."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Karl Greiser: ""It would be better if we talk inside.""*)

### Węzeł `[3]`
Mówca: **Narrator**
> "Karl Greiser was waiting for me by the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Karl Greiser: ""Mr. President.""*)

### Węzeł `[4]`
Mówca: **Karl Greiser**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Karl Greiser: ""Can I have a moment of your time? I have something to di..."*)

### Węzeł `[5]`
Mówca: **Karl Greiser**
> ""Can I have a moment of your time? I have something to discuss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: ""Of course. Let's go inside the office.""*)
  - -> `[7]` (*Player: ""What is this about?""*)

### Węzeł `[6]`
**[WYBÓR GRACZA: ""Of course. Let's go inside the office.""]** — Mówca: **Player**
> ""Of course. Let's go inside the office.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "We entered my office. I sat behind my desk."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: ""What is this about?""]** — Mówca: **Player**
> ""What is this about?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Karl Greiser: ""It is classified information regarding our investigation..."*)

### Węzeł `[8]`
Mówca: **Karl Greiser**
> ""It is classified information regarding our investigations, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Karl Greiser: ""It would be better if we talk inside.""*)

### Węzeł `[9]`
Mówca: **Karl Greiser**
> ""It would be better if we talk inside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: ""Okay. Let's go inside the office.""*)
  - -> `[11]` (*Player: ""Fine. But I don't have too much time to spare.""*)

### Węzeł `[10]`
**[WYBÓR GRACZA: ""Okay. Let's go inside the office.""]** — Mówca: **Player**
> ""Okay. Let's go inside the office.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "We entered my office. I sat behind my desk."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: ""Fine. But I don't have too much time to spare.""]** — Mówca: **Player**
> ""Fine. But I don't have too much time to spare.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Karl Greiser: ""It will only take a moment, sir.""*)

### Węzeł `[12]`
Mówca: **Karl Greiser**
> ""It will only take a moment, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "We entered my office. I sat behind my desk."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "We entered my office. I sat behind my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player: ""Please have a seat, Karl.""*)
  - -> `[14]` (*Player: ""So... What is this about?""*)
  - -> `[15]` (*Player: ""I'm listening.""*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true"*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""So... What is this about?""]** — Mówca: **Player**
> ""So... What is this about?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""I'm listening.""]** — Mówca: **Player**
> ""I'm listening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""Please have a seat, Karl.""]** — Mówca: **Player**
> ""Please have a seat, Karl.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Karl Greiser: ""Thank you sir. But I'm fine. I will not take long.""*)

### Węzeł `[17]`
Mówca: **Karl Greiser**
> ""Thank you sir. But I'm fine. I will not take long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[18]`
Mówca: **Karl Greiser**
> ""The Secret State Police has compiled a report regarding the active investigations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_OldGuard == true"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Karl Greiser: ""The Secret State Police has compiled a report regarding ..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Karl Greiser: ""The Anti-Corruption Police has compiled a report regardi..."*)

### Węzeł `[22]`
Mówca: **Karl Greiser**
> ""The Anti-Corruption Police has compiled a report regarding the active investigations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_OldGuard == true"*)

### Węzeł `[23]`
Mówca: **Karl Greiser**
> ""We have been watching the Oligarchs closely just as you asked, and found a very complex web of connections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Karl Greiser: ""There are missing links in our investigations but the Ol..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_OldGuard == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_OldGuard == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_Investigate_OldGuard == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_OldGuard == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_OldGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Karl Greiser: ""We have been watching the Old Guard closely just as you ..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_Investigate_OldGuard == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_OldGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs == true"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Oligarchs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_Investigate_Oligarchs == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Oligarchs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == true && BaseGame.T..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_Investigate_Oligarchs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Karl Greiser: ""We have been watching the opposition closely just as you..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Oligarchs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_Investigate_Oligarchs == true)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Oligarchs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == true && BaseGame.T..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_Investigate_Oligarchs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Oligarchs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Karl Greiser: ""We have been watching the opposition closely just as you..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_OldGuard == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_OldGuard == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_Investigate_OldGuard == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_OldGuard == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_OldGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Karl Greiser: ""We have been watching the Old Guard closely just as you ..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_Investigate_OldGuard == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_OldGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Oligarchs == true"*)

### Węzeł `[36]`
Mówca: **Karl Greiser**
> ""We have been watching the Old Guard closely just as you asked, and found a very complex web of connections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Karl Greiser: ""There are missing links in our investigations but the Ol..."*)

### Węzeł `[37]`
Mówca: **Karl Greiser**
> ""There are missing links in our investigations but the Old Guard seems to be involved in huge cases of corruption and lobbying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Karl Greiser: ""Most of the connections link to Chief Justice Hawker. De..."*)

### Węzeł `[38]`
Mówca: **Karl Greiser**
> ""Most of the connections link to Chief Justice Hawker. Despite none of the members of assembly having direct ties with him, there seems to be a complex web of connections that is proving very difficult to track.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Karl Greiser: ""We also have another suspicion. Our findings led us to b..."*)

### Węzeł `[39]`
Mówca: **Karl Greiser**
> ""We also have another suspicion. Our findings led us to believe there is an ongoing cooperation between the Young Sords organization and the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Default == false &..."*)

### Węzeł `[40]`
Mówca: **Karl Greiser**
> ""While this is huge, it is very difficult to create a solid case at the moment. And the Justices of the Court have immunity before the law. I don't see how we can take them down legally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Karl Greiser: ""If we decide to make a case, we can arrest most of their..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Default == false && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Default == false &..."*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Default == false..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Default == false && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Karl Greiser: ""While this is huge, it is very difficult to create a str..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Default == false && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Karl Greiser: ""While this is huge, it is very difficult to create a sol..."*)

### Węzeł `[44]`
Mówca: **Karl Greiser**
> ""If we decide to make a case, we can arrest most of their connections in the Assembly. However, there is probably more to this than we had imagined.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true && BaseGa..."*)
  - -> `[85]` (*Player: ""Proceed with the case. As long as we hurt them, the Cour..."*)
  - -> `[86]` (*Player: ""Let's drop the investigations for now. We don't need it ..."*)

### Węzeł `[45]`
Mówca: **Karl Greiser**
> ""While this is huge, it is very difficult to create a strong case at the moment. But the Justices of the Court no longer enjoys absolute immunity before the law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Karl Greiser: ""If we decide to proceed, we can possibly take the Old Gu..."*)

### Węzeł `[46]`
Mówca: **Karl Greiser**
> ""If we decide to proceed, we can possibly take the Old Guard down in a legal way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true && BaseGa..."*)
  - -> `[88]` (*Player: ""Proceed with a legal case. We can finally get them.""*)
  - -> `[89]` (*Player: ""Let's drop the investigations for now. We don't need it ..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true && BaseGame.YoungSords_Kill_OrsoHawker == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true && BaseGa..."*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true && Base..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true && BaseGame.YoungSords_Kill_OrsoHawker == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  and  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: ""We don't need the *legal* way. I need Orso gone.""*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true && BaseGame.YoungSords_Kill_OrsoHawker == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  and  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[50]`
Mówca: **Karl Greiser**
> ""There are missing links in our investigations but the Oligarchs seem to be involved in huge cases of corruption and lobbying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Karl Greiser: ""Even though so many links lead to Walter Tusk, we couldn..."*)

### Węzeł `[51]`
Mówca: **Karl Greiser**
> ""Even though so many links lead to Walter Tusk, we couldn't find a direct incriminating evidence yet. Currently, we're following a trail that leads to Estord, which will hopefully and finally get us Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Karl Greiser: ""We also have another suspicion. Our findings led us to b..."*)

### Węzeł `[52]`
Mówca: **Karl Greiser**
> ""We also have another suspicion. Our findings led us to believe there might be some connection between the increasing illegal arms trafficking in East Merkopa and the Oligarchs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Karl Greiser: ""If we decide to proceed with our investigations, we can ..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_MarcelKoronti == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MarcelKoronti == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Detained_MarcelKoronti == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_MarcelKoronti == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Karl Greiser: ""We have been watching the Oligarchs closely just as you ..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Detained_MarcelKoronti == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == true"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_WalterTusk == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Detained_WalterTusk == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_WalterTusk == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Karl Greiser: ""We have been watching the Oligarchs closely just as you ..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Detained_WalterTusk == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Karl Greiser: ""We have been watching the Oligarchs closely just as you ..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_WalterTusk == true && BaseGame.Turn07_Detained_MarcelKoronti == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_WalterTusk == true && BaseGame.T..."*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Detained_WalterTusk == true && BaseGame..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_WalterTusk == true && BaseGame.Turn07_Detained_MarcelKoronti == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Karl Greiser: ""We have been watching the Oligarchs closely just as you ..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Detained_WalterTusk == true && BaseGame.Turn07_Detained_MarcelKoronti == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_WalterTusk"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MarcelKoronti == true"*)

### Węzeł `[62]`
Mówca: **Karl Greiser**
> ""We have been watching the Oligarchs closely just as you asked, and found a very complex web of connections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Karl Greiser: ""There are missing links in our investigations but Marcel..."*)

### Węzeł `[63]`
Mówca: **Karl Greiser**
> ""There are missing links in our investigations but Marcel Koronti and Walter Tusk seems to have been involved in huge cases of corruption and lobbying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Karl Greiser: ""Currently, we're following a trail that leads to Estord,..."*)

### Węzeł `[64]`
Mówca: **Karl Greiser**
> ""Currently, we're following a trail that leads to Estord, which might reveal some of their secrets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Karl Greiser: ""We also have another suspicion. Our findings led us to b..."*)

### Węzeł `[65]`
Mówca: **Karl Greiser**
> ""We have been watching the Oligarchs closely just as you asked, and found a very complex web of connections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Karl Greiser: ""There are missing links in our investigations but the Ol..."*)

### Węzeł `[66]`
Mówca: **Karl Greiser**
> ""There are missing links in our investigations but the Oligarchs seem to be involved in huge cases of corruption and lobbying. And recently there was a major power shift to Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Karl Greiser: ""Even though so many links lead to Koronti, we couldn't f..."*)

### Węzeł `[67]`
Mówca: **Karl Greiser**
> ""We also have another suspicion. Our findings led us to believe there might be some connection between the increasing illegal arms trafficking in East Merkopa and the Oligarchs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Karl Greiser: ""If we decide to proceed with our investigations, we can ..."*)

### Węzeł `[68]`
Mówca: **Karl Greiser**
> ""Even though so many links lead to Koronti, we couldn't find a direct incriminating evidence yet. Currently, we're following a trail that leads to Estord, which will hopefully and finally get us Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Karl Greiser: ""We also have another suspicion. Our findings led us to b..."*)

### Węzeł `[69]`
Mówca: **Karl Greiser**
> ""We have been watching the Oligarchs closely just as you asked, and found a very complex web of connections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Karl Greiser: ""There are missing links in our investigations but the Ol..."*)

### Węzeł `[70]`
Mówca: **Karl Greiser**
> ""There are missing links in our investigations but the Oligarchs seem to be involved in huge cases of corruption and lobbying. And recently Tusk has increased his operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Karl Greiser: ""Even though so many links lead to Walter Tusk, we couldn..."*)

### Węzeł `[71]`
Mówca: **Karl Greiser**
> ""Even though so many links lead to Walter Tusk, we couldn't find a direct incriminating evidence yet. Currently, we're following a trail that leads to Estord, which will hopefully and finally get us Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Karl Greiser: ""We also have another suspicion. Our findings led us to b..."*)

### Węzeł `[72]`
Mówca: **Karl Greiser**
> ""We also have another suspicion. Our findings led us to believe there might be some connection between the increasing illegal arms trafficking in East Merkopa and the Oligarchs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Karl Greiser: ""If we decide to proceed with our investigations, we can ..."*)

### Węzeł `[73]`
Mówca: **Karl Greiser**
> ""We also have another suspicion. Our findings led us to believe there might be some connections between the illegal arms trafficking in East Merkopa and the Oligarchs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Karl Greiser: ""If we decide to proceed with our investigations, we can ..."*)

### Węzeł `[74]`
Mówca: **Karl Greiser**
> ""If we decide to proceed with our investigations, we can potentially undercover a lot more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: ""Continue your efforts and keep looking.""*)
  - -> `[91]` (*Player: ""Let's drop the investigation for now. We don't need it a..."*)

### Węzeł `[75]`
Mówca: **Karl Greiser**
> ""We have been watching the opposition closely just as you asked, and found a very complex web of connections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Karl Greiser: ""We have found suspicious irregularities and indirect con..."*)

### Węzeł `[76]`
Mówca: **Karl Greiser**
> ""We have been watching the opposition closely just as you asked, and found a very complex web of connections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Karl Greiser: ""We have found suspicious irregularities and indirect con..."*)

### Węzeł `[77]`
Mówca: **Karl Greiser**
> ""We have found suspicious irregularities and indirect connections to the Oligarchs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Karl Greiser: ""However, it is very difficult to make a legal argument a..."*)

### Węzeł `[78]`
Mówca: **Karl Greiser**
> ""However, it is very difficult to make a legal argument against anything at this moment. Our investigation is still ongoing but the process is proving to very slow. Their tracks are very well covered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[93]` (*Player: ""Continue your efforts and keep looking." [Investigate Op..."*)
  - -> `[288]` (*Player: ""The oligarch connection sounds promising. Keep chasing t..."*)
  - -> `[95]` (*Player: ""Let's drop the investigation for now. We don't need it a..."*)

### Węzeł `[79]`
Mówca: **Karl Greiser**
> ""We have found suspicious irregularities and indirect connections to the Oligarchs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Karl Greiser: ""However, it is very difficult to make a legal argument a..."*)

### Węzeł `[80]`
Mówca: **Karl Greiser**
> ""However, it is very difficult to make a legal argument against anything at this moment. Our investigation is still ongoing but the process is proving to very slow. Their tracks are very well covered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[93]` (*Player: ""Continue your efforts and keep looking." [Investigate Op..."*)
  - -> `[288]` (*Player: ""The oligarch connection sounds promising. Keep chasing t..."*)
  - -> `[92]` (*Player: ""Let's drop the investigation for now. We don't need it a..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true && BaseGame.YoungSords_Kill_OrsoHawker == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true && BaseGa..."*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true && Base..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true && BaseGame.YoungSords_Kill_OrsoHawker == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  and  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: ""If the laws are not on our side, we'll find *another* wa..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true && BaseGame.YoungSords_Kill_OrsoHawker == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  and  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[84]`
**[WYBÓR GRACZA: ""If the laws are not on our side, we'll find *another* way. That's why I have you.""]** — Mówca: **Player**
> ""If the laws are not on our side, we'll find *another* way. That's why I have you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  and  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false`
- **Kontekst wejściowy (poprzednik):** `[44]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Karl Greiser: ""Of course, sir.""*)

### Węzeł `[85]`
**[WYBÓR GRACZA: ""Proceed with the case. As long as we hurt them, the Court doesn't matter.""]** — Mówca: **Player**
> ""Proceed with the case. As long as we hurt them, the Court doesn't matter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Karl Greiser: ""Yes, sir.""*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Let's drop the investigations for now. We don't need it anymore.""]** — Mówca: **Player**
> ""Let's drop the investigations for now. We don't need it anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Karl Greiser: ""As you wish, sir.""*)

### Węzeł `[87]`
**[WYBÓR GRACZA: ""We don't need the *legal* way. I need Orso gone.""]** — Mówca: **Player**
> ""We don't need the *legal* way. I need Orso gone.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true  and  Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false`
- **Kontekst wejściowy (poprzednik):** `[46]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Karl Greiser: ""I see.""*)

### Węzeł `[88]`
**[WYBÓR GRACZA: ""Proceed with a legal case. We can finally get them.""]** — Mówca: **Player**
> ""Proceed with a legal case. We can finally get them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Karl Greiser: ""Yes, sir.""*)

### Węzeł `[89]`
**[WYBÓR GRACZA: ""Let's drop the investigations for now. We don't need it anymore.""]** — Mówca: **Player**
> ""Let's drop the investigations for now. We don't need it anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Karl Greiser: ""As you wish, sir.""*)

### Węzeł `[90]`
**[WYBÓR GRACZA: ""Continue your efforts and keep looking.""]** — Mówca: **Player**
> ""Continue your efforts and keep looking.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Karl Greiser: ""Yes, sir.""*)

### Węzeł `[91]`
**[WYBÓR GRACZA: ""Let's drop the investigation for now. We don't need it anymore.""]** — Mówca: **Player**
> ""Let's drop the investigation for now. We don't need it anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Karl Greiser: ""As you wish, sir.""*)

### Węzeł `[92]`
**[WYBÓR GRACZA: ""Let's drop the investigation for now. We don't need it anymore.""]** — Mówca: **Player**
> ""Let's drop the investigation for now. We don't need it anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Karl Greiser: ""As you wish, sir.""*)

### Węzeł `[93]`
**[WYBÓR GRACZA: ""Continue your efforts and keep looking." [Investigate Opposition]"]** — Mówca: **Player**
> ""Continue your efforts and keep looking.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Karl Greiser), `[80]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Karl Greiser: ""As you wish, sir.""*)

### Węzeł `[94]`
**[WYBÓR GRACZA: ""We don't need a *legal* case to end them, Karl. That's why I have you.""]** — Mówca: **Player**
> ""We don't need a *legal* case to end them, Karl. That's why I have you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Kontekst wejściowy (poprzednik):** `[78]` (Karl Greiser), `[80]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Karl Greiser: ""Of course, sir.""*)

### Węzeł `[95]`
**[WYBÓR GRACZA: ""Let's drop the investigation for now. We don't need it anymore.""]** — Mówca: **Player**
> ""Let's drop the investigation for now. We don't need it anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Karl Greiser: ""As you wish, sir.""*)

### Węzeł `[96]`
Mówca: **Karl Greiser**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player: ""Keep your eyes open. I don't want your focus to be cente..."*)
  - -> `[105]` (*Player: ""Keep a low profile. We can't afford to risk unwanted att..."*)
  - -> `[104]` (*Player: ""It's time we shift our focus on another faction.""*)

### Węzeł `[97]`
Mówca: **Karl Greiser**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_OldGuard = true"*)

### Węzeł `[98]`
Mówca: **Karl Greiser**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player: ""But for now, just proceed with the case, Karl. We don't ..."*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true"*)

### Węzeł `[99]`
Mówca: **Karl Greiser**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_OldGuard = true"*)

### Węzeł `[100]`
Mówca: **Karl Greiser**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Oligarchs = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Investigate_Oligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[102]`
Mówca: **Karl Greiser**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Oligarchs = true"*)

### Węzeł `[103]`
**[WYBÓR GRACZA: ""Keep your eyes open. I don't want your focus to be centered at one target.""]** — Mówca: **Player**
> ""Keep your eyes open. I don't want your focus to be centered at one target.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Dropped = true"*)

### Węzeł `[104]`
**[WYBÓR GRACZA: ""It's time we shift our focus on another faction.""]** — Mówca: **Player**
> ""It's time we shift our focus elsewhere.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player: ""Start investigating the Oligarchs.""*)
  - -> `[137]` (*Player: ""Start investigating the opposition.""*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""Keep a low profile. We can't afford to risk unwanted attention with these investigations.""]** — Mówca: **Player**
> ""Keep a low profile. We can't afford to risk unwanted attention with these investigations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Dropped = true"*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""But for now, just proceed with the case, Karl. We don't want unnecessary attention.""]** — Mówca: **Player**
> ""But for now, just proceed with the case, Karl. We don't want unnecessary attention.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_OldGuard = true"*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""I want Orso gone. For good.""]** — Mówca: **Player**
> ""I want Orso gone. For good.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[98]` (Karl Greiser), `[100]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Karl Greiser: ""I understand. I'll see to it, sir.""*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == ..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player: ""I thought I was clear before. Why isn't Orso *gone*?""*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player: ""I want Orso gone. For good.""*)

### Węzeł `[111]`
**[WYBÓR GRACZA: ""I thought I was clear before. Why isn't Orso *gone*?""]** — Mówca: **Player**
> ""I thought I was clear before. Why isn't Orso *gone*?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] == true`
- **Kontekst wejściowy (poprzednik):** `[98]` (Karl Greiser), `[100]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Karl Greiser: ""It will happen soon, sir. It was difficult to organize t..."*)

### Węzeł `[112]`
Mówca: **Karl Greiser**
> ""It will happen soon, sir. It was difficult to organize the force with the Old Guard having ears everywhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_OldGuard = true"*)

### Węzeł `[113]`
Mówca: **Karl Greiser**
> ""I understand. I'll see to it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_OldGuard = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Investigate_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_OldGuard = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Investigate_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuar..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_OrsoHawker = true;
BaseGame.Turn07_Investigate_OldGuard = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] = true;
Variable["BaseGame.Turn07_Investigate_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_KillOrsoAndInvesti..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Dropped = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Investigate_Dropped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Oligarchs = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Investigate_Oligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[119]`
**[WYBÓR GRACZA: ""Keep a low profile. We can't afford to risk unwanted attention with these investigations.""]** — Mówca: **Player**
> ""Keep a low profile. We can't afford to risk unwanted attention with these investigations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Dropped = true"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Dropped = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Investigate_Dropped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[121]`
Mówca: **Karl Greiser**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: ""Keep your eyes open. I don't want your focus to be cente..."*)
  - -> `[119]` (*Player: ""Keep a low profile. We can't afford to risk unwanted att..."*)
  - -> `[123]` (*Player: ""It's time we shift our focus to another faction.""*)

### Węzeł `[122]`
**[WYBÓR GRACZA: ""Keep your eyes open. I don't want your focus to be centered at one target.""]** — Mówca: **Player**
> ""Keep your eyes open. I don't want your focus to be centered at one target.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Dropped = true"*)

### Węzeł `[123]`
**[WYBÓR GRACZA: ""It's time we shift our focus to another faction.""]** — Mówca: **Player**
> ""It's time we shift our focus elsewhere.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player: ""Start investigating the Old Guard.""*)
  - -> `[140]` (*Player: ""Start investigating the opposition.""*)

### Węzeł `[124]`
Mówca: **Karl Greiser**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Karl Greiser: ""I'll give you an update soon.""*)

### Węzeł `[125]`
**[WYBÓR GRACZA: ""It's time we shift our focus on another faction.""]** — Mówca: **Player**
> ""It's time we shift our focus elsewhere.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player: ""Start investigating the Old Guard.""*)
  - -> `[162]` (*Player: ""Start investigating the Oligarchs.""*)

### Węzeł `[126]`
**[WYBÓR GRACZA: ""Keep a low profile. We can't afford to risk unwanted attention with these investigations.""]** — Mówca: **Player**
> ""Keep a low profile. We can't afford to risk unwanted attention with these investigations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Dropped = true"*)

### Węzeł `[127]`
Mówca: **Karl Greiser**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: ""Keep your eyes open. I don't want your focus to be cente..."*)
  - -> `[126]` (*Player: ""Keep a low profile. We can't afford to risk unwanted att..."*)
  - -> `[125]` (*Player: ""It's time we shift our focus on another faction.""*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Dropped = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Investigate_Dropped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[129]`
**[WYBÓR GRACZA: ""Keep your eyes open. I don't want your focus to be centered at one target.""]** — Mówca: **Player**
> ""Keep your eyes open. I don't want your focus to be centered at one target.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Dropped = true"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == ..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player: ""I hope there is an update about Orso, Karl.""*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[133]`
Mówca: **Karl Greiser**
> ""Not yet sir, but soon. He will be gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Karl Greiser: ""I wanted to tell you about something else.""*)

### Węzeł `[134]`
**[WYBÓR GRACZA: ""I hope there is an update about Orso, Karl.""]** — Mówca: **Player**
> ""I hope there is an update about Orso, Karl.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] == true`
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Karl Greiser: ""Not yet sir, but soon. He will be gone.""*)

### Węzeł `[135]`
Mówca: **Karl Greiser**
> ""I wanted to tell you about something else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[136]`
**[WYBÓR GRACZA: ""Start investigating the Oligarchs.""]** — Mówca: **Player**
> ""Start investigating the Oligarchs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Oligarchs = true"*)

### Węzeł `[137]`
**[WYBÓR GRACZA: ""Start investigating the opposition.""]** — Mówca: **Player**
> ""Start investigating the opposition.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Opposition = true"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Oligarchs = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Investigate_Oligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Opposition = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Investigate_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[140]`
**[WYBÓR GRACZA: ""Start investigating the opposition.""]** — Mówca: **Player**
> ""Start investigating the opposition.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Opposition = true"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Opposition = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Investigate_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_OldGuard = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Investigate_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[143]`
**[WYBÓR GRACZA: ""Start investigating the Old Guard.""]** — Mówca: **Player**
> ""Start investigating the Old Guard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_OldGuard = true"*)

### Węzeł `[144]`
Mówca: **Karl Greiser**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Turn07_Emergency_Detained_Frens == true"*)
  - -> `[145]` (*Player: ""But for now, just continue your investigations, Karl. We..."*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.Stopped_Investigations_NFP == false"*)

### Węzeł `[145]`
**[WYBÓR GRACZA: ""But for now, just continue your investigations, Karl. We don't want unnecessary attention.""]** — Mówca: **Player**
> ""But for now, just continue your investigations, Karl. We don't want unnecessary attention.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Karl Greiser: ""As you wish, sir.""*)

### Węzeł `[146]`
**[WYBÓR GRACZA: ""I want Ricter gone. For good.""]** — Mówca: **Player**
> ""I want Ricter gone. For good.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[144]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Karl Greiser: ""For good?""*)

### Węzeł `[147]`
Mówca: **Karl Greiser**
> ""For good?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[149]` (*Player: ""I just want him detained and sent to Antel Rock.""*)

### Węzeł `[148]`
**[WYBÓR GRACZA: ""Yes.""]** — Mówca: **Player**
> ""Yes.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Kontekst wejściowy (poprzednik):** `[147]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_FrensRicter = true; Base..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA: ""I just want him detained and sent to Antel Rock.""]** — Mówca: **Player**
> ""I just want him detained and sent to Antel Rock.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter = true; ..."*)

### Węzeł `[150]`
Mówca: **Karl Greiser**
> ""Yes sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Karl Greiser: ""I'll give you an update soon.""*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Turn07_Emergency_Detained_Frens == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Turn07_Emergency_Detained_Frens == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Turn07_Emergency_Detained_Frens == true)"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Turn07_Emergency_Detained_Frens == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Player: ""We have already arrested Mr. Ricter. This should send a ..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Turn07_Emergency_Detained_Frens == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player: ""I want Ricter gone. For good.""*)

### Węzeł `[154]`
**[WYBÓR GRACZA: ""We have already arrested Mr. Ricter. This should send a message to the others.""]** — Mówca: **Player**
> ""We have already arrested Mr. Ricter. This should send a message to the others.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Turn07_Emergency_Detained_Frens"] == true`
- **Kontekst wejściowy (poprzednik):** `[144]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Karl Greiser: ""It already did, sir. But the opposition is furious about..."*)

### Węzeł `[155]`
Mówca: **Karl Greiser**
> ""It already did, sir. But the opposition is furious about the decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Player: ""Keep watching them. Make sure nobody does something stup..."*)
  - -> `[157]` (*Player: ""Arrest them if they create problems.""*)

### Węzeł `[156]`
**[WYBÓR GRACZA: ""Keep watching them. Make sure nobody does something stupid.""]** — Mówca: **Player**
> ""Keep watching them. Make sure nobody does something stupid.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Karl Greiser: ""We'll do our best, sir.""*)

### Węzeł `[157]`
**[WYBÓR GRACZA: ""Arrest them if they create problems.""]** — Mówca: **Player**
> ""Arrest them if they create problems.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Karl Greiser: ""We'll do our best, sir.""*)

### Węzeł `[158]`
Mówca: **Karl Greiser**
> ""We'll do our best, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Opposition = true"*)

### Węzeł `[159]`
Mówca: **Karl Greiser**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Opposition = true"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Opposition = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Investigate_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_FrensRicter = true;
BaseGame.Turn07_Investigate_Opposition = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] = true;
Variable["BaseGame.Turn07_Investigate_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[162]`
**[WYBÓR GRACZA: ""Start investigating the Oligarchs.""]** — Mówca: **Player**
> ""Start investigating the Oligarchs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Oligarchs = true"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Oligarchs = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Investigate_Oligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[164]`
**[WYBÓR GRACZA: ""Start investigating the Old Guard.""]** — Mówca: **Player**
> ""Start investigating the Old Guard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_OldGuard = true"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_OldGuard = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Investigate_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[166]`
Mówca: **Karl Greiser**
> ""Yes sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Karl Greiser: ""I'll give you an update soon.""*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_FrensRicter = true;
BaseGame.Turn07_Investigate_Opposition = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] = true;
Variable["BaseGame.Turn07_Investigate_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_KillFrens = true"*)

### Węzeł `[168]`
Mówca: **Karl Greiser**
> ""I understand. I'll see to it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Karl Greiser: ""I'll give you an update soon.""*)

### Węzeł `[169]`
Mówca: **Karl Greiser**
> ""I'll give you an update soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Karl Greiser: ""I will also send you the detailed report of our previous..."*)

### Węzeł `[170]`
Mówca: **Karl Greiser**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Karl Greiser: ""I'll give you an update soon.""*)

### Węzeł `[171]`
Mówca: **Karl Greiser**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Karl Greiser: ""I'll give you an update soon.""*)

### Węzeł `[172]`
Mówca: **Karl Greiser**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Karl Greiser: ""I'll give you an update soon.""*)

### Węzeł `[173]`
Mówca: **Karl Greiser**
> ""I will also send you the detailed report of our previous findings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Karl Greiser: ""Thank you for your time.""*)

### Węzeł `[174]`
Mówca: **Karl Greiser**
> ""Thank you for your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player: ""Thank you Karl.""*)
  - -> `[175]` (*Player: ""I'll be waiting.""*)

### Węzeł `[175]`
**[WYBÓR GRACZA: ""I'll be waiting.""]** — Mówca: **Player**
> ""I'll be waiting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "He bowed his head and left the office."*)

### Węzeł `[176]`
**[WYBÓR GRACZA: ""Thank you Karl.""]** — Mówca: **Player**
> ""Thank you Karl.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "He bowed his head and left the office."*)

### Węzeł `[177]`
Mówca: **Narrator**
> "He bowed his head and left the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[178]`
**[WYBÓR GRACZA: ""I want Kibener gone. For good.""]** — Mówca: **Player**
> ""I want Kibener gone. For good.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Stopped_Investigations_NFP"] == false`
- **Kontekst wejściowy (poprzednik):** `[144]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Karl Greiser: ""For good?""*)

### Węzeł `[179]`
Mówca: **Karl Greiser**
> ""For good?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[180]` (*Player: ""I just want him detained and sent to Antel Rock.""*)

### Węzeł `[180]`
**[WYBÓR GRACZA: ""I just want him detained and sent to Antel Rock.""]** — Mówca: **Player**
> ""I just want him detained and sent to Antel Rock.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener = true..."*)

### Węzeł `[181]`
**[WYBÓR GRACZA: ""Yes.""]** — Mówca: **Player**
> ""Yes.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Kontekst wejściowy (poprzednik):** `[179]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_KesaroKibener = true; Ba..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_KesaroKibener = true;
BaseGame.Turn07_Investigate_Opposition = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] = true;
Variable["BaseGame.Turn07_Investigate_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_KillKesaro = true"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_KesaroKibener = true;
BaseGame.Turn07_Investigate_Opposition = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] = true;
Variable["BaseGame.Turn07_Investigate_Opposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Karl Greiser: ""Yes, sir.""*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOppositionDropped = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOppositionDropped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Karl Greiser: ""Yes sir.""*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Karl Greiser: ""Yes sir.""*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Karl Greiser: ""Yes sir.""*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_DetainKesaro = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_DetainKesaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_KillKesaro = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_KillKesaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_KillFrens = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_KillFrens"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_DetainFrens = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_DetainFrens"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Karl Greiser: ""As you wish, sir.""*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchsDropped = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchsDropped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Karl Greiser: ""I'll give you an update soon.""*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuardDropped = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuardDropped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Karl Greiser: ""Yes, sir.""*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Karl Greiser: ""Yes, sir.""*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Karl Greiser: ""I'll give you an update soon.""*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_KillOrsoAndInvestigateOldGuard = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_KillOrsoAndInvestigateOldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Karl Greiser: ""I'll give you an update soon.""*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_OldGuard = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_Investigate_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuar..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Karl Greiser: ""I'll give you an update soon.""*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker = tru..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_OrsoHawker = true; BaseG..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker = true;
BaseGame.Turn07_Investigate_OldGuard = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] = true;
Variable["BaseGame.Turn07_Investigate_OldGuard"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_KillOrsoAndInvesti..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOligarc..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOligarc..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs_ACP  = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs_ACP"]  = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Karl Greiser: ""Yes, sir.""*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOpposit..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOpposit..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOppositionDropped_ACP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOppositionDropped_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Karl Greiser: ""Yes sir.""*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuar..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuar..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard_ACP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Karl Greiser: ""Yes sir.""*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOligarc..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOligarc..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs_ACP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Karl Greiser: ""Yes sir.""*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player: ""Yes.""*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_DetainKesaro = true"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_DetainKesaro_ACP =..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_DetainKesaro_ACP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_DetainKesaro_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player: ""Yes.""*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_DetainFrens = true"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_DetainFrens_ACP = ..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_DetainFrens_ACP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_DetainFrens_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Karl Greiser: ""I understand. I'll see to it, sir.""*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Karl Greiser: ""I understand. I'll see to it, sir.""*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOpposit..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOpposit..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition_ACP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Karl Greiser: ""I'll give you an update soon.""*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuar..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuar..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard_ACP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Karl Greiser: ""Yes, sir.""*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOpposit..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOpposit..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition_ACP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Karl Greiser: ""Yes, sir.""*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOligarc..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOligarc..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchsDropped_ACP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchsDropped_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Karl Greiser: ""I'll give you an update soon.""*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOligarc..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOligarc..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs_ACP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Karl Greiser: ""I'll give you an update soon.""*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOpposit..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOpposit..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition_ACP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOpposition_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOligarc..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOligarc..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs_ACP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOligarchs_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuar..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuar..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuardDropped_ACP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuardDropped_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Karl Greiser: ""Yes, sir.""*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Karl Greiser: ""Yes, sir.""*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Karl Greiser: ""Yes, sir.""*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuar..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuar..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard_ACP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn07_Results_InvestigateOldGuard_ACP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Karl Greiser: ""I'll give you an update soon.""*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player: ""We don't need a *legal* case to end them, Karl. That's w..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Stopped_Investigations_NFP == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGame.Stopped_Investigations_NFP == false"*)
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Stopped_Investigations_NFP == false)"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Stopped_Investigations_NFP == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Stopped_Investigations_NFP"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Player: ""I want Kibener gone. For good.""*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Stopped_Investigations_NFP == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Stopped_Investigations_NFP"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[288]`
**[WYBÓR GRACZA: ""The oligarch connection sounds promising. Keep chasing that lead." [Investigate Oligarchs]"]** — Mówca: **Player**
> ""The oligarch connection sounds promising. Keep chasing that lead.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Karl Greiser), `[80]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Oligarchs = true"*)
