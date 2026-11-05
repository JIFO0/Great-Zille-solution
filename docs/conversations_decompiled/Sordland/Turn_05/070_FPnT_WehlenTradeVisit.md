# Sordland/Turn05/FPnT_WehlenTradeVisit

- **ID konwersacji:** `70`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/070_FPnT_WehlenTradeVisit.md`
- **Liczba węzłów dialogowych:** 335
- **Liczba wyborów gracza:** 56

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[17]** Wiktor Smolak

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Country_Unrest`
- `BaseGame.Policy_Diplomacy_Agnolia_Trade`
- `BaseGame.Policy_Diplomacy_Wehlen_Trade`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg`
- `BaseGame.Reform_EmergencyDecree_PoliceAuthority`
- `BaseGame.Situation_Diplomacy_Energy_PriceSurge`
- `BaseGame.Turn05_FPnT_Immigration_Tight`
- `BaseGame.Wehlen_DefendBorder`
- `BaseGame.Wehlen_JointOperation`
- `BaseGame.Wehlen_TradeDeal`
- `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Capitalist`
- `BaseGame.Democratic`
- `BaseGame.Economy_Bergia`
- `BaseGame.GovernmentBudget`
- `BaseGame.Policy_Diplomacy_CoalitionIntervention`
- `BaseGame.Policy_Diplomacy_Neutrality`
- `BaseGame.Policy_Diplomacy_Wehlen_DefendBorder`
- `BaseGame.Policy_Diplomacy_Wehlen_JointOperation`
- `BaseGame.Policy_Diplomacy_Wehlen_Trade`
- `BaseGame.Policy_Military_JointMilitaryExercises`
- `BaseGame.Public_Opinion`
- `BaseGame.Situation_Diplomacy_FailedTradeNegotiation`
- `BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil`
- `BaseGame.Situation_Economy_DecreasedTrade`
- `BaseGame.Situation_Economy_IncreasedTrade`
- `BaseGame.Situation_Economy_RecoveredTrade`
- `BaseGame.Situation_Military_MilitaryInterventionWehlen`
- `BaseGame.Situation_Military_Wehlen_BorderDefence`
- `BaseGame.Sollist`
- `BaseGame.Wehlen_DefendBorder`
- `BaseGame.Wehlen_JointOperation`
- `BaseGame.Wehlen_TradeDeal`
- `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton`
- `BaseGameSupport.CountryReport_Turn05_Lespia_CondemnsWehlenDeal`
- `BaseGameSupport.FactionReport_Turn05_ATO_WarnsRiziaKingdom`
- `BaseGameSupport.FactionReport_Turn05_CSP_BansPMCs`
- `BaseGameSupport.Journal_Turn05_Trade_WehlenFailed`
- `BaseGameSupport.Journal_Turn05_Trade_WehlenMilitaryOpSigned`
- `BaseGameSupport.Journal_Turn05_Trade_WehlenSigned`
- `BaseGameSupport.News_Turn05_HP_WehlenDeal`
- `BaseGameSupport.News_Turn05_R_WehlenCoop`
- `BaseGameSupport.Report_Turn05_Narbel_DetainReport`
- `BaseGameSupport.Report_Turn05_Valgen_SurveillanceReport`
- `GameCondition.Turn05_FPnT_WehlenTradeVisit`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **"“Nice to see you, Mr. President.”"** | `[13]` **Narrator**: "He immediately motioned for an e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Wiktor Smolak**: "“Now that the pleasantries are d..." |
| `[8]` | **"Salute the soldiers."** | `[6]` **Narrator**: "I saw the soldiers lined up on e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Narrator**: "At the bottom of the stairs, Wik..." |
| `[9]` | **"Proceed to the red carpet without any gestures."** | `[6]` **Narrator**: "I saw the soldiers lined up on e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Narrator**: "At the bottom of the stairs, Wik..." |
| `[14]` | **"“Thank you for inviting us.”"** | `[13]` **Narrator**: "He immediately motioned for an e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Wiktor Smolak**: "“Now that the pleasantries are d..." |
| `[15]` | **"Pull him aside for a couple of more poses yourself."** | `[13]` **Narrator**: "He immediately motioned for an e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Wiktor Smolak**: "“Now that the pleasantries are d..." |
| `[19]` | **"Salute the soldiers."** | `[18]` **Narrator**: "As we started speeding up, the s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Narrator**: "Both of our security details sta..." |
| `[20]` | **"Do nothing."** | `[18]` **Narrator**: "As we started speeding up, the s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Narrator**: "Both of our security details sta..." |
| `[23]` | **"“Whose statue?”"** | `[21]` **Wiktor Smolak**: "“We will first go to the city ce..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Wiktor Smolak**: "“Mine, of course.”" |
| `[24]` | **"“Sounds ...exciting.”"** | `[21]` **Wiktor Smolak**: "“We will first go to the city ce..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Wiktor Smolak**: "“This is an important occasion f..." |
| `[25]` | **"“I'd rather not waste time. Let's get straight to business.”"** | `[21]` **Wiktor Smolak**: "“We will first go to the city ce..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Wiktor Smolak**: "“Ah, Mr. President. I must insis..." |
| `[31]` | **"“Is Wraclawitz always this empty?”"** | `[30]` **Narrator**: "On almost every corner, there we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Wiktor Smolak**: "“I had this part of the city clo..." |
| `[32]` | **"“Is this all a big photo op for you?”"** | `[30]` **Narrator**: "On almost every corner, there we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Wiktor Smolak**: "“It is a good opportunity to sho..." |
| `[35]` | **"“How long is this going to take?”"** | `[30]` **Narrator**: "On almost every corner, there we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Wiktor Smolak**: "“Patience is a virtue. We will b..." |
| `[43]` | **"“I see that you know how to handle dissidents. Very good.”"** | `[42]` **Wiktor Smolak**: "“Thankfully the sun is out. Toda..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Wiktor Smolak**: "“I am glad you approve. We are o..." |
| `[44]` | **"“What will happen to the man who was protesting you?”"** | `[42]` **Wiktor Smolak**: "“Thankfully the sun is out. Toda..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Wiktor Smolak**: "“Oh, which man? That one in the ..." |
| `[45]` | **"“Very good.”"** | `[42]` **Wiktor Smolak**: "“Thankfully the sun is out. Toda..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Wiktor Smolak**: "“Let's take our places.”" |
| `[54]` | **"“Our artists can do better in Sordland.”"** | `[53]` **Wiktor Smolak**: "“Excellent statue. Very lifelike..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Narrator**: "His face soured." |
| `[55]` | **"“Yes, it's very good. Very lifelike.”"** | `[53]` **Wiktor Smolak**: "“Excellent statue. Very lifelike..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Wiktor Smolak**: "“Glad you appreciate the art beh..." |
| `[56]` | **"“Mr. Smolak, I don't have time for these games. Let's get straight to the business.”"** | `[53]` **Wiktor Smolak**: "“Excellent statue. Very lifelike..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Wiktor Smolak**: "“Don't worry. We will.”" |
| `[67]` | **"Pay the street vendor."** | `[66]` **Narrator**: "The man behind the stand smiled ..."<br>`[69]` **Player_Italic**: "I waited for him to pay the stre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Wiktor Smolak**: "“Hold up. Your money doesn't cou..." |
| `[68]` | **"“Are you going to pay for it?”"** | `[66]` **Narrator**: "The man behind the stand smiled ..."<br>`[69]` **Player_Italic**: "I waited for him to pay the stre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Wiktor Smolak**: "“Of course, Mr. Rayne! Smolak's ..." |
| `[69]` | **"Wait for him to pay the street vendor."** | `[66]` **Narrator**: "The man behind the stand smiled ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Player**: "“Are you going to pay for it?”"<br>`[67]` **Player_Italic**: "I put my hand on my wallet and b..."<br>*(oraz 1 innych odgałęzień)* |
| `[73]` | **"Keep walking."** | `[69]` **Player_Italic**: "I waited for him to pay the stre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Narrator**: "Afterwards, we walked a short di..." |
| `[80]` | **"“Finally.”"** | `[79]` **Wiktor Smolak**: "“Now we can talk about our trade..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Wiktor Smolak**: "“But before that.”" |
| `[81]` | **"Nod."** | `[79]` **Wiktor Smolak**: "“Now we can talk about our trade..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Wiktor Smolak**: "“But before that.”" |
| `[87]` | **"Partake."** | `[86]` **Narrator**: "Wiktor inhaled the smoke and han..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("Shisha");` | `[298]` **Narrator**: "It was probably the highest-qual..." |
| `[88]` | **"“I don't smoke.”"** | `[86]` **Narrator**: "Wiktor inhaled the smoke and han..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Wiktor Smolak**: "“Your loss. It's the finest toba..." |
| `[92]` | **"“I prefer my official title.”"** | `[90]` **Wiktor Smolak**: "“So... Mr. President. Bah, that'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Wiktor Smolak**: "“Very well, Mr. President.”" |
| `[93]` | **"“Sure.”"** | `[90]` **Wiktor Smolak**: "“So... Mr. President. Bah, that'..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"...` | `[96]` **Wiktor Smolak**: "“Anton.”" |
| `[102]` | **"“They are a threat to the region.”"** | `[97]` **Wiktor Smolak**: "“Tell me. What do you really thi..."<br>`[101]` **Wiktor Smolak**: "“I know you have put an embargo ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Wiktor Smolak**: "“I agree with your sentiments, A..."<br>`[133]` **Wiktor Smolak**: "“I agree with your sentiments, M..." |
| `[103]` | **"“A barking dog doesn't bite.”"** | `[97]` **Wiktor Smolak**: "“Tell me. What do you really thi..."<br>`[101]` **Wiktor Smolak**: "“I know you have put an embargo ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Wiktor Smolak**: "“I wouldn't be so sure, Anton.”"<br>`[111]` **Wiktor Smolak**: "“I wouldn't be so sure, Mr. Pres..." |
| `[104]` | **"“They can go to hell!”"** | `[97]` **Wiktor Smolak**: "“Tell me. What do you really thi..."<br>`[101]` **Wiktor Smolak**: "“I know you have put an embargo ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Wiktor Smolak**: "“Exactly! To hell with Rumburg! ..."<br>`[129]` **Wiktor Smolak**: "“Exactly! To hell with Rumburg! ..." |
| `[113]` | **"“Are you planning something?”"** | `[112]` **Wiktor Smolak**: "“I assure you their time will co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Wiktor Smolak**: "“Well...”" |
| `[114]` | **"“In due time, yes.”"** | `[112]` **Wiktor Smolak**: "“I assure you their time will co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Wiktor Smolak**: ""Exactly."" |
| `[115]` | **"“Regardless, I would rather prevent further conflict in the region.”"** | `[112]` **Wiktor Smolak**: "“I assure you their time will co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Wiktor Smolak**: "“You know as well as I do, Anton..."<br>`[123]` **Wiktor Smolak**: "“You know as well as I do, Mr. P..." |
| `[124]` | **"“Not much in particular. Like any other country, they have their needs and their o..."** | `[97]` **Wiktor Smolak**: "“Tell me. What do you really thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Wiktor Smolak**: "“Yes, they do. But their ambitio..." |
| `[139]` | **"“What is it?”"** | `[118]` **Wiktor Smolak**: "“First, I need to solve some pro..."<br>`[304]` **Wiktor Smolak**: "“And now, I need to solve some p..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Narrator**: "He clapped his hands again. Two ..." |
| `[140]` | **"“I'm listening.”"** | `[118]` **Wiktor Smolak**: "“First, I need to solve some pro..."<br>`[304]` **Wiktor Smolak**: "“And now, I need to solve some p..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Narrator**: "He clapped his hands again. Two ..." |
| `[146]` | **"“I don't support any military action this close to our borders.”"** | `[145]` **Wiktor Smolak**: "“I call it Operation Bear Trap.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Narrator**: "He lay back on the large pillow ..." |
| `[147]` | **"“What do you want from me?”"** | `[145]` **Wiktor Smolak**: "“I call it Operation Bear Trap.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Narrator**: "He grinned and lay back on the l..." |
| `[148]` | **"“I like the sound of it.”"** | `[145]` **Wiktor Smolak**: "“I call it Operation Bear Trap.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Narrator**: "He grinned and lay back on the l..." |
| `[153]` | **"“I need specifics.”"** | `[151]` **Wiktor Smolak**: "“You will give me your assistanc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Wiktor Smolak**: "“Sure.”" |
| `[154]` | **"“Absolutely not. I won't meddle in Wehlen's military interventions.”"** | `[151]` **Wiktor Smolak**: "“You will give me your assistanc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Wiktor Smolak**: "“This is not just Wehlen's probl..." |
| `[155]` | **"“Two birds, one stone.”"** | `[151]` **Wiktor Smolak**: "“You will give me your assistanc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Wiktor Smolak**: "“You read my mind.”" |
| `[169]` | **"“What kind of support do you need from me? Can't Wehlen handle it by itself?”"** | `[168]` **Wiktor Smolak**: "“You know that as long as they u..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Wiktor Smolak**: "“We can, but these vermin are go..." |
| `[171]` | **"“There might be international ramifications.”"** | `[168]` **Wiktor Smolak**: "“You know that as long as they u..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Wiktor Smolak**: "“To hell with international rami..." |
| `[174]` | **"“Deal.” [-1 Government Budget]"** | `[175]` **Narrator**: "I took a moment to think about it." | `Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true` | `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGam...`<br>`Variable["BaseGameSupport.Journal_Turn05_Trade_WehlenSign...`<br>*(+5 skryptów)* | *Koniec sceny / Terminal* |
| `[176]` | **"“No deal. It's too risky. I'm afraid I can't accept.”"** | `[175]` **Narrator**: "I took a moment to think about it." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Wiktor Smolak**: "“Wait, Anton. Wait.”"<br>`[183]` **Wiktor Smolak**: "“Wait, Mr. President. Wait.”" |
| `[177]` | **"“Let's negotiate Sordland's contribution in this operation.”"** | `[175]` **Narrator**: "I took a moment to think about it." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Wiktor Smolak**: "“You are a tough one, Anton.”"<br>`[182]` **Wiktor Smolak**: "“You are a tough one, Mr. Presid..." |
| `[198]` | **"“No deal. I'm afraid I can't accept.”"** | `[197]` **Wiktor Smolak**: "“So what do you think?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn05_Trade_WehlenFail...`<br>`Variable["BaseGame.Wehlen_TradeDeal"] = false; ;`<br>*(+1 skryptów)* | `[199]` **Wiktor Smolak**: "“That's unfortunate. I thought w..." |
| `[210]` | **"“Take care of yourself, Wiktor.”"** | `[209]` **Wiktor Smolak**: "“Goodbye, Mr. Rayne.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Narrator**: "I returned to Sordland immediately." |
| `[211]` | **"Nod and leave."** | `[209]` **Wiktor Smolak**: "“Goodbye, Mr. Rayne.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Narrator**: "I returned to Sordland immediately." |
| `[219]` | **"“Deal.”"** | `[197]` **Wiktor Smolak**: "“So what do you think?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn05_Trade_WehlenSign...`<br>`Variable["BaseGame.Wehlen_DefendBorder"] = true; Variable...`<br>*(+3 skryptów)* | *Koniec sceny / Terminal* |
| `[282]` | **""Why would you offer me so much?""** | `[168]` **Wiktor Smolak**: "“You know that as long as they u..." | `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true) == false` | *Brak zmian stanu* | `[283]` **Wiktor Smolak**: "“Why wouldn't I? I want Sordland..." |
| `[320]` | **"“Deal.”"** | `[175]` **Narrator**: "I took a moment to think about it." | `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true) == false` | `Variable["BaseGameSupport.Journal_Turn05_Trade_WehlenSign...`<br>`Variable["BaseGame.Wehlen_TradeDeal"] = true; Variable["B...`<br>*(+4 skryptów)* | *Koniec sceny / Terminal* |
| `[329]` | **""Are you suggesting we pay a higher rate than usual?""** | `[168]` **Wiktor Smolak**: "“You know that as long as they u..." | `Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true` | *Brak zmian stanu* | `[330]` **Wiktor Smolak**: ""Indeed, there are additional ex..." |

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
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_Country_Wehlen", "Progress_Di..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Sordland One's flight from Holsord to Wraclawitz took approximately five hours. Despite heavy turbulence, I managed to sleep a little."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Symon, Deivid and I landed at the international airport o..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Symon, Deivid and I landed at the international airport of the capital city of Wehlen. Our aim here was to finalise the trade deal drafted between Sordland and Wehlen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("PlaneLandingRoughly");"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Our plane landed, and the door opened. The sun blinded me for a moment. I stepped outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "I saw the soldiers lined up on either side of a red carpe..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "I saw the soldiers lined up on either side of a red carpet. There must've been at least a hundred of them. A marching band started playing and the soldiers immediately saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player_Italic: "Salute the soldiers."*)
  - -> `[9]` (*Player_Italic: "Proceed to the red carpet without any gestures."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "“Nice to see you, Mr. President.”"]** — Mówca: **Player**
> "“Nice to see you, Mr. President.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Wiktor Smolak: "“Now that the pleasantries are done, let's go! We will ta..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "Salute the soldiers."]** — Mówca: **Player_Italic**
> "I saluted the soldiers."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "At the bottom of the stairs, Wiktor Smolak was waiting fo..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "Proceed to the red carpet without any gestures."]** — Mówca: **Player_Italic**
> "I walked downstairs and proceeded without any gestures."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "At the bottom of the stairs, Wiktor Smolak was waiting fo..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "At the bottom of the stairs, Wiktor Smolak was waiting for me next to a military jeep with a few soldiers by his side. There were a few reporters at the edge of the crowd, waiting with their cameras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "He was a tall man, almost as tall as me. He was wearing l..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "He was a tall man, almost as tall as me. He was wearing large sunglasses and a regular suit, contrasting with the military attire of everyone else in the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Wiktor Smolak: "“Mr. President. Welcome to Wraclawitz.”"*)

### Węzeł `[12]`
Mówca: **Wiktor Smolak**
> "“Mr. President. Welcome to Wraclawitz.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "He immediately motioned for an embrace. We hugged and man..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "He immediately motioned for an embrace. We hugged and many cameras went off at the same time. He turned around for a couple of additional poses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: "“Nice to see you, Mr. President.”"*)
  - -> `[15]` (*Player_Italic: "Pull him aside for a couple of more poses yourself."*)
  - -> `[14]` (*Player: "“Thank you for inviting us.”"*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "“Thank you for inviting us.”"]** — Mówca: **Player**
> "“Thank you for inviting us.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Wiktor Smolak: "“Now that the pleasantries are done, let's go! We will ta..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "Pull him aside for a couple of more poses yourself."]** — Mówca: **Player_Italic**
> "I pulled him aside for a couple of more poses."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Wiktor Smolak: "“Now that the pleasantries are done, let's go! We will ta..."*)

### Węzeł `[16]`
Mówca: **Wiktor Smolak**
> "“Now that the pleasantries are done, let's go! We will take the jeep for a tour.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "With another tune from the marching band, we boarded the ..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "With another tune from the marching band, we boarded the military jeep. He sat in the driver's seat and I sat next to him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "As we started speeding up, the soldiers saluted again. Wi..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "As we started speeding up, the soldiers saluted again. Wiktor saluted back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Italic: "Salute the soldiers."*)
  - -> `[20]` (*Player_Italic: "Do nothing."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "Salute the soldiers."]** — Mówca: **Player_Italic**
> "I saluted the soldiers."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Both of our security details started following us immedia..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "Do nothing."]** — Mówca: **Player_Italic**
> "I did nothing."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Both of our security details started following us immedia..."*)

### Węzeł `[21]`
Mówca: **Wiktor Smolak**
> "“We will first go to the city center to see the unveiling of a statue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "“Whose statue?”"*)
  - -> `[24]` (*Player: "“Sounds ...exciting.”"*)
  - -> `[25]` (*Player: "“I'd rather not waste time. Let's get straight to business.”"*)

### Węzeł `[22]`
Mówca: **Narrator**
> "Both of our security details started following us immediately, along with a team of reporters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Wiktor Smolak: "“We will first go to the city center to see the unveiling..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "“Whose statue?”"]** — Mówca: **Player**
> "“Whose statue?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Wiktor Smolak: "“Mine, of course.”"*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Sounds ...exciting.”"]** — Mówca: **Player**
> "“Sounds ...exciting.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Wiktor Smolak: "“This is an important occasion for Wehlen. I am sure you ..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "“I'd rather not waste time. Let's get straight to business.”"]** — Mówca: **Player**
> "“I'd rather not waste time. Let's get straight to business.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Wiktor Smolak: "“Ah, Mr. President. I must insist. Also, I am in the driv..."*)

### Węzeł `[26]`
Mówca: **Wiktor Smolak**
> "“Ah, Mr. President. I must insist. Also, I am in the driver's seat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "We kept making small talk about the flight and the weathe..."*)

### Węzeł `[27]`
Mówca: **Wiktor Smolak**
> "“This is an important occasion for Wehlen. I am sure you will like it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "We kept making small talk about the flight and the weathe..."*)

### Węzeł `[28]`
Mówca: **Wiktor Smolak**
> "“Mine, of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "We kept making small talk about the flight and the weathe..."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "We kept making small talk about the flight and the weather as we made our way towards the city center."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "On almost every corner, there were reporters taking photo..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "On almost every corner, there were reporters taking photos of us. Aside from them, though, the streets seemed completely empty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: "“Is Wraclawitz always this empty?”"*)
  - -> `[32]` (*Player: "“Is this all a big photo op for you?”"*)
  - -> `[35]` (*Player: "“How long is this going to take?”"*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Is Wraclawitz always this empty?”"]** — Mówca: **Player**
> "“Is Wraclawitz always this empty?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Wiktor Smolak: "“I had this part of the city close down because of your v..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "“Is this all a big photo op for you?”"]** — Mówca: **Player**
> "“Is this all a big photo op for you?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Wiktor Smolak: "“It is a good opportunity to show the world our unity in ..."*)

### Węzeł `[33]`
Mówca: **Wiktor Smolak**
> "“I had this part of the city close down because of your visit so that you could enjoy the city in peace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Wiktor Smolak: "“There we are.”"*)

### Węzeł `[34]`
Mówca: **Wiktor Smolak**
> "“It is a good opportunity to show the world our unity in Eastern Merkopa. We must display our unified strength to Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Wiktor Smolak: "“There we are.”"*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“How long is this going to take?”"]** — Mówca: **Player**
> "“How long is this going to take?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Wiktor Smolak: "“Patience is a virtue. We will be done soon, and then we ..."*)

### Węzeł `[36]`
Mówca: **Wiktor Smolak**
> "“Patience is a virtue. We will be done soon, and then we can discuss our trade deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Wiktor Smolak: "“There we are.”"*)

### Węzeł `[37]`
Mówca: **Wiktor Smolak**
> "“There we are.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "We arrived at the center. In the middle of a large plaza,..."*)

### Węzeł `[38]`
Mówca: **Narrator**
> "We arrived at the center. In the middle of a large plaza, there was a covered statue. Large crowds of people were gathered behind fences. waving both Sordland and Wehlen flags. Wiktor waved back at them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Wiktor Smolak: "“My people have been very supportive of this visit, Mr. P..."*)

### Węzeł `[39]`
Mówca: **Wiktor Smolak**
> "“My people have been very supportive of this visit, Mr. President. I am sure you are delighted to see them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "A man came closer to the fences and started yelling at Wi..."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "A man came closer to the fences and started yelling at Wiktor. With my limited knowledge of the Wehzek language, I understood the words 'Wiktor' and 'murderer'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Almost instantaneously, two soldiers came up from behind ..."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "Almost instantaneously, two soldiers came up from behind the man and he was taken away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Wiktor Smolak: "“Thankfully the sun is out. Today will be a good day for ..."*)

### Węzeł `[42]`
Mówca: **Wiktor Smolak**
> "“Thankfully the sun is out. Today will be a good day for the reveal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "“I see that you know how to handle dissidents. Very good.”"*)
  - -> `[44]` (*Player: "“What will happen to the man who was protesting you?”"*)
  - -> `[45]` (*Player: "“Very good.”"*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“I see that you know how to handle dissidents. Very good.”"]** — Mówca: **Player**
> "“I see that you know how to handle dissidents. Very good.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Wiktor Smolak: "“I am glad you approve. We are of the same mind.”"*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“What will happen to the man who was protesting you?”"]** — Mówca: **Player**
> "“What will happen to the man who was protesting you?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Wiktor Smolak: "“Oh, which man? That one in the crowd?”"*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“Very good.”"]** — Mówca: **Player**
> "“Very good.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Wiktor Smolak: "“Let's take our places.”"*)

### Węzeł `[46]`
Mówca: **Wiktor Smolak**
> "“Oh, which man? That one in the crowd?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Wiktor Smolak: "“Don't worry about the details. He must've been a trouble..."*)

### Węzeł `[47]`
Mówca: **Wiktor Smolak**
> "“Don't worry about the details. He must've been a troubled fellow. Let's focus on the event.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "We took our places in front of the statue. With a drumrol..."*)

### Węzeł `[48]`
Mówca: **Wiktor Smolak**
> "“I am glad you approve. We are of the same mind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Wiktor Smolak: "“See, I knew we would get along fine.”"*)

### Węzeł `[49]`
Mówca: **Wiktor Smolak**
> "“See, I knew we would get along fine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "We took our places in front of the statue. With a drumrol..."*)

### Węzeł `[50]`
Mówca: **Wiktor Smolak**
> "“Let's take our places.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "We took our places in front of the statue. With a drumrol..."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "We took our places in front of the statue. With a drumroll, the statue of Wiktor Smolak was uncovered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "It was a fairly good likeness, albeit more muscular than ..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "It was a fairly good likeness, albeit more muscular than the real Wiktor. He was wearing a cloak and holding a sword in his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Wiktor Smolak: "“Excellent statue. Very lifelike. What do you think?”"*)

### Węzeł `[53]`
Mówca: **Wiktor Smolak**
> "“Excellent statue. Very lifelike. What do you think?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: "“Mr. Smolak, I don't have time for these games. Let's get..."*)
  - -> `[55]` (*Player: "“Yes, it's very good. Very lifelike.”"*)
  - -> `[54]` (*Player: "“Our artists can do better in Sordland.”"*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "“Our artists can do better in Sordland.”"]** — Mówca: **Player**
> "“Our artists can do better in Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "His face soured."*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "“Yes, it's very good. Very lifelike.”"]** — Mówca: **Player**
> "“Yes, it's very good. Very lifelike.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Wiktor Smolak: "“Glad you appreciate the art behind it.”"*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "“Mr. Smolak, I don't have time for these games. Let's get straight to the business.”"]** — Mówca: **Player**
> "“Mr. Smolak, I don't have time for these games. Let's get straight to the business.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Wiktor Smolak: "“Don't worry. We will.”"*)

### Węzeł `[57]`
Mówca: **Wiktor Smolak**
> "“Don't worry. We will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Wiktor Smolak: "“Join me for a walk.”"*)

### Węzeł `[58]`
Mówca: **Wiktor Smolak**
> "“Glad you appreciate the art behind it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Wiktor Smolak: "“Join me for a walk.”"*)

### Węzeł `[59]`
Mówca: **Narrator**
> "His face soured."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Wiktor Smolak: "“Well...then I'd like to contact one.”"*)

### Węzeł `[60]`
Mówca: **Wiktor Smolak**
> "“Well...then I'd like to contact one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "He turned to the soldiers and started yelling at them in ..."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "He turned to the soldiers and started yelling at them in Wehzek. The soldiers covered the statue again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Wiktor Smolak: "“Join me for a walk.”"*)

### Węzeł `[62]`
Mówca: **Wiktor Smolak**
> "“Join me for a walk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "I followed him through the streets. At every corner, more..."*)

### Węzeł `[63]`
Mówca: **Narrator**
> "I followed him through the streets. At every corner, more and more photos were taken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "We stopped in front of a pastry vendor on the street."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "We stopped in front of a pastry vendor on the street."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Wiktor Smolak: "“Give me two strudels.”"*)

### Węzeł `[65]`
Mówca: **Wiktor Smolak**
> "“Give me two strudels.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The man behind the stand smiled and gave us two strudels."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "The man behind the stand smiled and gave us two strudels."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: "“Are you going to pay for it?”"*)
  - -> `[67]` (*Player_Italic: "Pay the street vendor."*)
  - -> `[69]` (*Player_Italic: "Wait for him to pay the street vendor."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "Pay the street vendor."]** — Mówca: **Player_Italic**
> "I put my hand on my wallet and brought up some money to give the vendor."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator), `[69]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Wiktor Smolak: "“Hold up. Your money doesn't count here. I got this.”"*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "“Are you going to pay for it?”"]** — Mówca: **Player**
> "“Are you going to pay for it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator), `[69]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Wiktor Smolak: "“Of course, Mr. Rayne! Smolak's got your back!""*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "Wait for him to pay the street vendor."]** — Mówca: **Player_Italic**
> "I waited for him to pay the street vendor. He simply took the two strudels and didn't pay anything."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: "“Are you going to pay for it?”"*)
  - -> `[67]` (*Player_Italic: "Pay the street vendor."*)
  - -> `[73]` (*Player_Italic: "Keep walking."*)

### Węzeł `[70]`
Mówca: **Wiktor Smolak**
> "“Of course, Mr. Rayne! Smolak's got your back!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "He handed the money to the street vendor with a huge smil..."*)

### Węzeł `[71]`
Mówca: **Wiktor Smolak**
> "“Hold up. Your money doesn't count here. I got this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "He handed the money to the street vendor with a huge smil..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "He handed the money to the street vendor with a huge smile on his face. The cameras flashed again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "Afterwards, we walked a short distance to the palace."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "Keep walking."]** — Mówca: **Player_Italic**
> "I kept walking alongside Wiktor."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "Afterwards, we walked a short distance to the palace."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "Afterwards, we walked a short distance to the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "Passing the gates, we made our way into the main building..."*)

### Węzeł `[75]`
Mówca: **Narrator**
> "Passing the gates, we made our way into the main building made from ivory-colored stones. The old guard towers flanked the magnificent structure from both sides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "The inside of the palace was very spacious, with a very l..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "The inside of the palace was very spacious, with a very large chandelier hanging from the ceiling. Grand staircases made from the same ivory stone had red carpets on them. On the upper levels, guards stood wearing the traditional outfits of the old Wehzek kingdom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "We finally reached the office of the President of Wehlen...."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "We finally reached the office of the President of Wehlen. The door closed behind us. I looked around at the golden ornaments on the walls and the various jewel-encrusted artifacts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "As it was customary in Wehlen, we sat down on the carpet."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "As it was customary in Wehlen, we sat down on the carpet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Wiktor Smolak: "“Now we can talk about our trade deal.”"*)

### Węzeł `[79]`
Mówca: **Wiktor Smolak**
> "“Now we can talk about our trade deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: "“Finally.”"*)
  - -> `[81]` (*Player_Italic: "Nod."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "“Finally.”"]** — Mówca: **Player**
> "“Finally.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Wiktor Smolak: "“But before that.”"*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Wiktor Smolak: "“But before that.”"*)

### Węzeł `[82]`
Mówca: **Wiktor Smolak**
> "“But before that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "He clapped his hands twice."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "He clapped his hands twice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Wiktor Smolak: "“Bring the Khisha.”"*)

### Węzeł `[84]`
Mówca: **Wiktor Smolak**
> "“Bring the Khisha.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "A few assistants immediately entered the room, carrying a..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "A few assistants immediately entered the room, carrying a large ornamented Khisha, the well-known smoking instrument originating from Wehlen. They immediately lit it up and the room was filled with the smell of tobacco."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "Wiktor inhaled the smoke and handed me the Khisha."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "Wiktor inhaled the smoke and handed me the Khisha."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player: "“I don't smoke.”"*)
  - -> `[87]` (*Player_Italic: "Partake."*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "Partake."]** — Mówca: **Player_Italic**
> "I inhaled the smoke."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Shisha");"*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "“I don't smoke.”"]** — Mówca: **Player**
> "“I don't smoke.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Wiktor Smolak: "“Your loss. It's the finest tobacco in the land.”"*)

### Węzeł `[89]`
Mówca: **Wiktor Smolak**
> "“Your loss. It's the finest tobacco in the land.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "He took another puff, filling the room with more smoke."*)

### Węzeł `[90]`
Mówca: **Wiktor Smolak**
> "“So... Mr. President. Bah, that's too long. Can I call you Anton?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: "“I prefer my official title.”"*)
  - -> `[93]` (*Player: "“Sure.”"*)

### Węzeł `[91]`
Mówca: **Narrator**
> "He took another puff, filling the room with more smoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Wiktor Smolak: "“So... Mr. President. Bah, that's too long. Can I call yo..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "“I prefer my official title.”"]** — Mówca: **Player**
> "“I prefer my official title.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Wiktor Smolak: "“Very well, Mr. President.”"*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "“Sure.”"]** — Mówca: **Player**
> "“Sure.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton = true"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Wiktor Smolak: "“Anton.”"*)

### Węzeł `[95]`
Mówca: **Wiktor Smolak**
> "“Very well, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)

### Węzeł `[96]`
Mówca: **Wiktor Smolak**
> "“Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)

### Węzeł `[97]`
Mówca: **Wiktor Smolak**
> "“Tell me. What do you really think about Rumburg?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player: "“A barking dog doesn't bite.”"*)
  - -> `[102]` (*Player: "“They are a threat to the region.”"*)
  - -> `[104]` (*Player: "“They can go to hell!”"*)
  - -> `[124]` (*Player: "“Not much in particular. Like any other country, they hav..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Wiktor Smolak: "“I know you have put an embargo on Rumburg, and I congrat..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Wiktor Smolak: "“Tell me. What do you really think about Rumburg?”"*)

### Węzeł `[101]`
Mówca: **Wiktor Smolak**
> "“I know you have put an embargo on Rumburg, and I congratulate you for standing up to them. But let me ask you a question. What do you really think about Rumburg?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player: "“A barking dog doesn't bite.”"*)
  - -> `[102]` (*Player: "“They are a threat to the region.”"*)
  - -> `[104]` (*Player: "“They can go to hell!”"*)

### Węzeł `[102]`
**[WYBÓR GRACZA: "“They are a threat to the region.”"]** — Mówca: **Player**
> "“They are a threat to the region.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Wiktor Smolak), `[101]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)

### Węzeł `[103]`
**[WYBÓR GRACZA: "“A barking dog doesn't bite.”"]** — Mówca: **Player**
> "“A barking dog doesn't bite.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Wiktor Smolak), `[101]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "“They can go to hell!”"]** — Mówca: **Player**
> "“They can go to hell!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Wiktor Smolak), `[101]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)

### Węzeł `[105]`
Mówca: **Wiktor Smolak**
> "“Exactly! To hell with Rumburg! I like you already, Anton!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Wiktor Smolak: "“I assure you their time will come.”"*)

### Węzeł `[106]`
Mówca: **Wiktor Smolak**
> "“I agree with your sentiments, Anton. They are a threat to everyone in the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Wiktor Smolak: "“I assure you their time will come.”"*)

### Węzeł `[107]`
Mówca: **Wiktor Smolak**
> "“I wouldn't be so sure, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Wiktor Smolak: "“I assure you their time will come.”"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Wiktor Smolak: "“I wouldn't be so sure, Anton.”"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Wiktor Smolak: "“I wouldn't be so sure, Mr. President.”"*)

### Węzeł `[111]`
Mówca: **Wiktor Smolak**
> "“I wouldn't be so sure, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Wiktor Smolak: "“I assure you their time will come.”"*)

### Węzeł `[112]`
Mówca: **Wiktor Smolak**
> "“I assure you their time will come.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player: "“In due time, yes.”"*)
  - -> `[113]` (*Player: "“Are you planning something?”"*)
  - -> `[115]` (*Player: "“Regardless, I would rather prevent further conflict in t..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "“Are you planning something?”"]** — Mówca: **Player**
> "“Are you planning something?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Wiktor Smolak: "“Well...”"*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "“In due time, yes.”"]** — Mówca: **Player**
> "“In due time, yes.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Wiktor Smolak: ""Exactly.""*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Regardless, I would rather prevent further conflict in the region.”"]** — Mówca: **Player**
> "“Regardless, I would rather prevent further conflict in the region.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)

### Węzeł `[116]`
Mówca: **Wiktor Smolak**
> "“Well...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Wiktor Smolak: "“Not yet.”"*)

### Węzeł `[117]`
Mówca: **Wiktor Smolak**
> "“Not yet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Wiktor Smolak: "“First, I need to solve some problems they are creating f..."*)

### Węzeł `[118]`
Mówca: **Wiktor Smolak**
> "“First, I need to solve some problems they are creating for me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player: "“What is it?”"*)
  - -> `[140]` (*Player: "“I'm listening.”"*)

### Węzeł `[119]`
Mówca: **Wiktor Smolak**
> "“You know as well as I do, Anton. They are coming whether we like it or not. They are the aggressor, not us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Wiktor Smolak: "“And now, I need to solve some problems they are creating..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Wiktor Smolak: "“You know as well as I do, Anton. They are coming whether..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Wiktor Smolak: "“You know as well as I do, Mr. President. They are coming..."*)

### Węzeł `[123]`
Mówca: **Wiktor Smolak**
> "“You know as well as I do, Mr. President. They are coming whether we like it or not. They are the aggressor, not us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Wiktor Smolak: "“And now, I need to solve some problems they are creating..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA: "“Not much in particular. Like any other country, they have their needs and their own agenda.”"]** — Mówca: **Player**
> "“Not much in particular. Like any other country, they have their needs and their own agenda.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Wiktor Smolak: "“Yes, they do. But their ambitions are over Wehlen and So..."*)

### Węzeł `[125]`
Mówca: **Wiktor Smolak**
> "“Yes, they do. But their ambitions are over Wehlen and Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Wiktor Smolak: "“Exactly! To hell with Rumburg! I like you already, Anton!”"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Wiktor Smolak: "“Exactly! To hell with Rumburg! I like you already, Mr. P..."*)

### Węzeł `[129]`
Mówca: **Wiktor Smolak**
> "“Exactly! To hell with Rumburg! I like you already, Mr. President!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Wiktor Smolak: "“I assure you their time will come.”"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Wiktor Smolak: "“I agree with your sentiments, Anton. They are a threat t..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Wiktor Smolak: "“I agree with your sentiments, Mr. President. They are a ..."*)

### Węzeł `[133]`
Mówca: **Wiktor Smolak**
> "“I agree with your sentiments, Mr. President. They are a threat to everyone in the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Wiktor Smolak: "“I assure you their time will come.”"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Wiktor Smolak: "“We must be careful, Anton.”"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Wiktor Smolak: "“We must be careful, Mr. President.”"*)

### Węzeł `[137]`
Mówca: **Wiktor Smolak**
> "“We must be careful, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Wiktor Smolak: "“I assure you their time will come.”"*)

### Węzeł `[138]`
Mówca: **Wiktor Smolak**
> "“We must be careful, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Wiktor Smolak: "“I assure you their time will come.”"*)

### Węzeł `[139]`
**[WYBÓR GRACZA: "“What is it?”"]** — Mówca: **Player**
> "“What is it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Wiktor Smolak), `[304]` (Wiktor Smolak), `[305]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "He clapped his hands again. Two assistants came into the ..."*)

### Węzeł `[140]`
**[WYBÓR GRACZA: "“I'm listening.”"]** — Mówca: **Player**
> "“I'm listening.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Wiktor Smolak), `[304]` (Wiktor Smolak), `[305]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "He clapped his hands again. Two assistants came into the ..."*)

### Węzeł `[141]`
Mówca: **Narrator**
> "He clapped his hands again. Two assistants came into the room with a map of the border regions between Wehlen and Sordland. He pointed at the border."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Wiktor Smolak: "“Look.”"*)

### Węzeł `[142]`
Mówca: **Wiktor Smolak**
> "“Look.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Wiktor Smolak: "“Bluds and their so called *BFF* are causing problems for..."*)

### Węzeł `[143]`
Mówca: **Wiktor Smolak**
> "“Bluds and their so called *BFF* are causing problems for me in this region. They are getting increasingly dangerous with Rumburg's active support. I know that they are a problem for you as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Wiktor Smolak: "“I will not allow these traitors to exist within my borde..."*)

### Węzeł `[144]`
Mówca: **Wiktor Smolak**
> "“I will not allow these traitors to exist within my borders. So I will hit them with all the might of Wehlen. These terrorists need to be destroyed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Wiktor Smolak: "“I will cut all their supplies from Rumburg and trap them..."*)

### Węzeł `[145]`
Mówca: **Wiktor Smolak**
> "“I call it Operation Bear Trap.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player: "“I don't support any military action this close to our bo..."*)
  - -> `[147]` (*Player: "“What do you want from me?”"*)
  - -> `[148]` (*Player: "“I like the sound of it.”"*)

### Węzeł `[146]`
**[WYBÓR GRACZA: "“I don't support any military action this close to our borders.”"]** — Mówca: **Player**
> "“I don't support any military action this close to our borders.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "He lay back on the large pillow behind him."*)

### Węzeł `[147]`
**[WYBÓR GRACZA: "“What do you want from me?”"]** — Mówca: **Player**
> "“What do you want from me?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "He grinned and lay back on the large pillow behind him."*)

### Węzeł `[148]`
**[WYBÓR GRACZA: "“I like the sound of it.”"]** — Mówca: **Player**
> "“I like the sound of it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "He grinned and lay back on the large pillow behind him."*)

### Węzeł `[149]`
Mówca: **Wiktor Smolak**
> "“Here is the deal. I will give you objectively the *best* trade deal in the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Wiktor Smolak: "“You will give me your assistance crushing the terrorists..."*)

### Węzeł `[150]`
Mówca: **Narrator**
> "He grinned and lay back on the large pillow behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Wiktor Smolak: "“Here is the deal. I will give you objectively the *best*..."*)

### Węzeł `[151]`
Mówca: **Wiktor Smolak**
> "“You will give me your assistance crushing the terrorists on both of our borders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player: "“I need specifics.”"*)
  - -> `[154]` (*Player: "“Absolutely not. I won't meddle in Wehlen's military inte..."*)
  - -> `[155]` (*Player: "“Two birds, one stone.”"*)

### Węzeł `[152]`
Mówca: **Narrator**
> "He lay back on the large pillow behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Wiktor Smolak: "“Here is the deal. I will give you objectively the *best*..."*)

### Węzeł `[153]`
**[WYBÓR GRACZA: "“I need specifics.”"]** — Mówca: **Player**
> "“I need specifics.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[151]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Wiktor Smolak: "“Sure.”"*)

### Węzeł `[154]`
**[WYBÓR GRACZA: "“Absolutely not. I won't meddle in Wehlen's military interventions.”"]** — Mówca: **Player**
> "“Absolutely not. I won't meddle in Wehlen's military interventions.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[151]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Wiktor Smolak: "“This is not just Wehlen's problem. This is also Sordland..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA: "“Two birds, one stone.”"]** — Mówca: **Player**
> "“Two birds, one stone.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[151]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Wiktor Smolak: "“You read my mind.”"*)

### Węzeł `[156]`
Mówca: **Wiktor Smolak**
> "“You read my mind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Wiktor Smolak: "“My spies have infiltrated BFF cells and they found cache..."*)

### Węzeł `[157]`
Mówca: **Wiktor Smolak**
> "“This is not just Wehlen's problem. This is also Sordland's problem. These terrorists are doing anything they can to destabilize the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Wiktor Smolak: "“My spies have infiltrated BFF cells and they found cache..."*)

### Węzeł `[158]`
Mówca: **Wiktor Smolak**
> "“Sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Wiktor Smolak: "“My spies have infiltrated BFF cells and they found cache..."*)

### Węzeł `[159]`
Mówca: **Wiktor Smolak**
> "“My spies have infiltrated BFF cells and they found caches of KA-74s. We traced them back to Rumburg. This alone justifies my retaliation to protect my country!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Wiktor Smolak: "“Worst of all, we also found that similar shipments are g..."*)

### Węzeł `[160]`
Mówca: **Wiktor Smolak**
> "“Worst of all, we also found that similar shipments are going to Sordland. Rumburg is trying to unite the BFF forces in both of our countries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Wiktor Smolak: ""However, the main problem is the border security between..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Wiktor Smolak: "“Yes, Anton. You see. This is not just Wehlen's problem.”"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Wiktor Smolak: "“Yes, Mr. President. You see. This is not just Wehlen's p..."*)

### Węzeł `[164]`
Mówca: **Wiktor Smolak**
> "“Yes, Anton. You see. This is not just Wehlen's problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Wiktor Smolak: "“Let's take a step back and talk about what you will get ..."*)

### Węzeł `[165]`
Mówca: **Wiktor Smolak**
> "“Yes, Mr. President. You see. This is not just Wehlen's problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Wiktor Smolak: "“Let's take a step back and talk about what you will get ..."*)

### Węzeł `[166]`
Mówca: **Wiktor Smolak**
> "“Let's take a step back and talk about what you will get in return.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Wiktor Smolak: "“I propose you a no-tariff agreement, co-investment proje..."*)

### Węzeł `[167]`
Mówca: **Wiktor Smolak**
> "“I propose you a no-tariff agreement, co-investment projects and oil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceSurge == true"*)

### Węzeł `[168]`
Mówca: **Wiktor Smolak**
> "“You know that as long as they use the mountains in Wehlen as a base, Sordland and Lespia will equally suffer. This is in the interest of the whole region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceSurge == true"*)
  - -> `[169]` (*Player: "“What kind of support do you need from me? Can't Wehlen h..."*)
  - -> `[171]` (*Player: "“There might be international ramifications.”"*)

### Węzeł `[169]`
**[WYBÓR GRACZA: "“What kind of support do you need from me? Can't Wehlen handle it by itself?”"]** — Mówca: **Player**
> "“What kind of support do you need from me? Can't Wehlen handle it by itself?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Wiktor Smolak: "“We can, but these vermin are good at hiding. As I told y..."*)

### Węzeł `[170]`
Mówca: **Wiktor Smolak**
> "“We can, but these vermin are good at hiding. As I told you, they operate and keep reorganizing inside both of our countries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceSurge == true"*)

### Węzeł `[171]`
**[WYBÓR GRACZA: "“There might be international ramifications.”"]** — Mówca: **Player**
> "“There might be international ramifications.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Wiktor Smolak: "“To hell with international ramifications! I will protect..."*)

### Węzeł `[172]`
Mówca: **Wiktor Smolak**
> "“To hell with international ramifications! I will protect my country! I don't care what they say!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceSurge == true"*)

### Węzeł `[173]`
Mówca: **Wiktor Smolak**
> "“What I want from you in return for all the money and the resources, is only a joint operation between our armies against the BFF.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "I took a moment to think about it."*)

### Węzeł `[174]`
**[WYBÓR GRACZA: "“Deal.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Deal.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true`
- **Kontekst wejściowy (poprzednik):** `[175]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 1;"*)

### Węzeł `[175]`
Mówca: **Narrator**
> "I took a moment to think about it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceSurge == true"*)
  - -> `[176]` (*Player: "“No deal. It's too risky. I'm afraid I can't accept.”"*)
  - -> `[177]` (*Player: "“Let's negotiate Sordland's contribution in this operation.”"*)

### Węzeł `[176]`
**[WYBÓR GRACZA: "“No deal. It's too risky. I'm afraid I can't accept.”"]** — Mówca: **Player**
> "“No deal. It's too risky. I'm afraid I can't accept.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)

### Węzeł `[177]`
**[WYBÓR GRACZA: "“Let's negotiate Sordland's contribution in this operation.”"]** — Mówca: **Player**
> "“Let's negotiate Sordland's contribution in this operation.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Wiktor Smolak: "“You are a tough one, Anton.”"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Wiktor Smolak: "“You are a tough one, Mr. President.”"*)

### Węzeł `[181]`
Mówca: **Wiktor Smolak**
> "“You are a tough one, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Wiktor Smolak: "“Normally, I wouldn't offer anything else but, I like you.”"*)

### Węzeł `[182]`
Mówca: **Wiktor Smolak**
> "“You are a tough one, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Wiktor Smolak: "“Normally, I wouldn't offer anything else but, I like you.”"*)

### Węzeł `[183]`
Mówca: **Wiktor Smolak**
> "“Wait, Mr. President. Wait.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Wiktor Smolak: "“Normally, I wouldn't offer anything else but, I like you.”"*)

### Węzeł `[184]`
Mówca: **Wiktor Smolak**
> "“Wait, Anton. Wait.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Wiktor Smolak: "“Normally, I wouldn't offer anything else but, I like you.”"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Wiktor Smolak: "“Wait, Anton. Wait.”"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Wiktor Smolak: "“Wait, Mr. President. Wait.”"*)

### Węzeł `[188]`
Mówca: **Wiktor Smolak**
> "“I knew I could trust you, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Wiktor Smolak: "“Tonight we will drink!”"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Wiktor Smolak: "“I knew I could trust you, Anton.”"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Wiktor Smolak: "“I knew I could trust you, Mr. President.”"*)

### Węzeł `[192]`
Mówca: **Wiktor Smolak**
> "“I knew I could trust you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Wiktor Smolak: "“Tonight we will drink!”"*)

### Węzeł `[193]`
Mówca: **Wiktor Smolak**
> "“Normally, I wouldn't offer anything else but, I like you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Wiktor Smolak: "“Here is my final offer.”"*)

### Węzeł `[194]`
Mówca: **Wiktor Smolak**
> "“Here is my final offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Wiktor Smolak: "“When the operation starts, with you or without you, ther..."*)

### Węzeł `[195]`
Mówca: **Wiktor Smolak**
> "“When the operation starts, with you or without you, there will be stragglers trying to cross into Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Wiktor Smolak: "“We just want you to support the operation even if you do..."*)

### Węzeł `[196]`
Mówca: **Wiktor Smolak**
> "“We just want you to support the operation even if you do not join. Stop the terrorists from fleeing into your country and you will have your deal. Simple, isn't it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Wiktor Smolak: "“So what do you think?”"*)

### Węzeł `[197]`
Mówca: **Wiktor Smolak**
> "“So what do you think?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Player: "“Deal.”"*)
  - -> `[198]` (*Player: "“No deal. I'm afraid I can't accept.”"*)

### Węzeł `[198]`
**[WYBÓR GRACZA: "“No deal. I'm afraid I can't accept.”"]** — Mówca: **Player**
> "“No deal. I'm afraid I can't accept.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[197]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn05_Trade_WehlenFailed = true"*)

### Węzeł `[199]`
Mówca: **Wiktor Smolak**
> "“That's unfortunate. I thought we could be friends.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Wiktor Smolak: "“But you decided to leave Wehlen to fend for itself.”"*)

### Węzeł `[200]`
Mówca: **Wiktor Smolak**
> "“But you decided to leave Wehlen to fend for itself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Wiktor Smolak: "“Such a shame. I am sure a powerful leader like Soll woul..."*)

### Węzeł `[201]`
Mówca: **Wiktor Smolak**
> "“Such a shame. I am sure a powerful leader like Soll would've accepted this great offer without a doubt.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Wiktor Smolak: "“My assistants will show you the way.”"*)

### Węzeł `[202]`
Mówca: **Wiktor Smolak**
> "“Tonight we will drink!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "He clapped his hands again."*)

### Węzeł `[203]`
Mówca: **Narrator**
> "He clapped his hands again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Wiktor Smolak: "“Drinks! Dancers! Music!”"*)

### Węzeł `[204]`
Mówca: **Wiktor Smolak**
> "“Drinks! Dancers! Music!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "Instead of the two assistants this time, a group of dance..."*)

### Węzeł `[205]`
Mówca: **Narrator**
> "Instead of the two assistants this time, a group of dancers and performers entered. Smoke filled  the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "As they performed their songs, we clinked our glasses to ..."*)

### Węzeł `[206]`
Mówca: **Narrator**
> "As they performed their songs, we clinked our glasses to our new partnership while sipping the sweet Wehzek liquor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Wehlen", "Fri..."*)

### Węzeł `[207]`
Mówca: **Narrator**
> "The next day, I returned to Sordland with a hangover."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_FPnT_WehlenTradeVisit = true"*)

### Węzeł `[208]`
Mówca: **Wiktor Smolak**
> "“My assistants will show you the way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Wiktor Smolak: "“Goodbye, Mr. Rayne.”"*)

### Węzeł `[209]`
Mówca: **Wiktor Smolak**
> "“Goodbye, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Player: "“Take care of yourself, Wiktor.”"*)
  - -> `[211]` (*Player_Italic: "Nod and leave."*)

### Węzeł `[210]`
**[WYBÓR GRACZA: "“Take care of yourself, Wiktor.”"]** — Mówca: **Player**
> "“Take care of yourself, Wiktor.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[209]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "I returned to Sordland immediately."*)

### Węzeł `[211]`
**[WYBÓR GRACZA: "Nod and leave."]** — Mówca: **Player_Italic**
> "I nodded and left."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[209]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "I returned to Sordland immediately."*)

### Węzeł `[212]`
Mówca: **Narrator**
> "I returned to Sordland immediately."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "I felt relieved to be back in Holsord."*)

### Węzeł `[213]`
Mówca: **Narrator**
> "I felt relieved to be back in Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_FPnT_WehlenTradeVisit = true"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn05_FPnT_WehlenTradeVisit = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn05_FPnT_WehlenTradeVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn05_Trade_WehlenSigned = true; BaseGameSupport.Journal_Turn05_Trade_WehlenMilitaryOpSigned = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn05_Trade_WehlenSigned"] = true;
Variable["BaseGameSupport.Journal_Turn05_Trade_WehlenMilitaryOpSigned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal = true; BaseGame.Wehlen_JointOp..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal = true;
BaseGame.Wehlen_JointOperation = true;
BaseGame.Public_Opinion -= 1;
BaseGame.Bludish_Opinion -= 5;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Wehlen_TradeDeal"] = true;
Variable["BaseGame.Wehlen_JointOperation"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation = true; B..."*)

### Węzeł `[217]`
Mówca: **Wiktor Smolak**
> "“I knew I could trust you, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Wiktor Smolak: "“Tonight we will drink!”"*)

### Węzeł `[218]`
Mówca: **Narrator**
> "The next day, I returned to Sordland with a hangover."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_FPnT_WehlenTradeVisit = true"*)

### Węzeł `[219]`
**[WYBÓR GRACZA: "“Deal.”"]** — Mówca: **Player**
> "“Deal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[197]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn05_Trade_WehlenSigned = true"*)

### Węzeł `[220]`
Mówca: **Wiktor Smolak**
> "“Tonight we will drink!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Narrator: "He clapped his hands again."*)

### Węzeł `[221]`
Mówca: **Narrator**
> "A group of dancers and performers entered and smoke filled the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "As they performed their songs, we clinked our glasses to ..."*)

### Węzeł `[222]`
Mówca: **Narrator**
> "He clapped his hands again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Wiktor Smolak: "“Drinks! Dancers! Music!”"*)

### Węzeł `[223]`
Mówca: **Wiktor Smolak**
> "“Drinks! Dancers! Music!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Narrator: "A group of dancers and performers entered and smoke fille..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Wiktor Smolak: "“I knew I could trust you, Anton.”"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Wiktor Smolak: "“I knew I could trust you, Mr. President.”"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn05_Trade_WehlenSigned = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn05_Trade_WehlenSigned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder = true; BaseGame.Wehlen_Trad..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder = true;
BaseGame.Wehlen_TradeDeal = true; 

BaseGame.Public_Opinion += 1;
BaseGame.Bludish_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Wehlen_DefendBorder"] = true;
Variable["BaseGame.Wehlen_TradeDeal"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil = tru..."*)

### Węzeł `[229]`
Mówca: **Narrator**
> "As they performed their songs, we clinked our glasses to our new partnership while sipping the sweet Wehzek liquor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "The next day, I returned to Sordland with a hangover."*)

### Węzeł `[230]`
Mówca: **Wiktor Smolak**
> "“I knew I could trust you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Wiktor Smolak: "“Tonight we will drink!”"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation = true;
BaseGame.Policy_Diplomacy_Wehlen_Trade = true;
BaseGame.Policy_Diplomacy_CoalitionIntervention = true;
BaseGame.Policy_Diplomacy_Neutrality = false;
BaseGame.Policy_Military_JointMilitaryExercises = true;
BaseGame.Situation_Military_MilitaryInterventionWehlen = true;
BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] = true;
Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] = true;
Variable["BaseGame.Policy_Diplomacy_CoalitionIntervention"] = true;
Variable["BaseGame.Policy_Diplomacy_Neutrality"] = false;
Variable["BaseGame.Policy_Military_JointMilitaryExercises"] = true;
Variable["BaseGame.Situation_Military_MilitaryInterventionWehlen"] = true;
Variable["BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_Country_Wehlen", "Country_Wehlen..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil = true;
BaseGame.Situation_Military_Wehlen_BorderDefence = true;
BaseGame.Policy_Diplomacy_Wehlen_DefendBorder = true;
BaseGame.Policy_Diplomacy_Wehlen_Trade = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil"] = true;
Variable["BaseGame.Situation_Military_Wehlen_BorderDefence"] = true;
Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] = true;
Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_Country_Wehlen", "Country_Wehlen..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn05_Trade_WehlenFailed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn05_Trade_WehlenFailed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal = false;"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_JointOperation == true)"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.CountryReport_Turn05_Lespia_CondemnsWehle..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.CountryReport_Turn05_Lespia_CondemnsWehlenDeal = true;
BaseGameSupport.News_Turn05_R_WehlenCoop = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn05_Lespia_CondemnsWehlenDeal"] = true;
Variable["BaseGameSupport.News_Turn05_R_WehlenCoop"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Valgen_SurveillanceReport = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Valgen_SurveillanceReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_PoliceAuthority == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_PoliceAuthority == true"*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_PoliceAuthority == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Valgen_SurveillanceReport =..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial =..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Narbel", "City_Widesprea..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest < 0"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Narbel_DetainReport = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Narbel_DetainReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest < 0"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_TradeDeal == true)"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_HP_WehlenDeal = true"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_HP_WehlenDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_WehlenDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_TradeDeal == true)"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic += 1; BaseGame.Capitalist -= 1;"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic += 1;
BaseGame.Capitalist -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;
Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "// Filler Node for organization"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic -= 1;
BaseGame.Sollist += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "// Filler Node for organization"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_JointOperation == true)"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic -= 1; BaseGame.Sollist += 2;"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "// Filler Node for organization"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true"*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_DefendBorder == true)"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist += 1;"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_DefendBorder == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "// Filler Node for organization"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Filler Node for organization`
- **Efekt skryptowy (`userScript`):** `-- Filler Node for organization;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_Trade == true || BaseGam..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Wehlen_TradeDeal"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil = fal..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil = false;
BaseGame.Situation_Military_MilitaryInterventionWehlen = false;
BaseGame.Situation_Military_Wehlen_BorderDefence = false;
BaseGame.Policy_Diplomacy_Wehlen_DefendBorder = false;
BaseGame.Policy_Diplomacy_Wehlen_JointOperation = false;
BaseGame.Policy_Diplomacy_Wehlen_Trade = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Wehlen_FreeTariffs_Oil"] = false;
Variable["BaseGame.Situation_Military_MilitaryInterventionWehlen"] = false;
Variable["BaseGame.Situation_Military_Wehlen_BorderDefence"] = false;
Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] = false;
Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] = false;
Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Wiktor Smolak: "“That's unfortunate. I thought we could be friends.”"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_Trade == true || BaseGame.Policy_Diplomacy_Agnolia_Trade == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_Trade == true || BaseGam..."*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Wehlen_Trade == true || BaseG..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_Trade == true || BaseGame.Policy_Diplomacy_Agnolia_Trade == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] == true  or  Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_Trade == true && BaseGam..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Wehlen_Trade == true || BaseGame.Policy_Diplomacy_Agnolia_Trade == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] == true  or  Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_RecoveredTrade = false; BaseGa..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_IncreasedTrade = true;
BaseGame.Situation_Economy_RecoveredTrade = false;
BaseGame.Situation_Economy_DecreasedTrade = false;
BaseGame.Situation_Diplomacy_FailedTradeNegotiation = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_IncreasedTrade"] = true;
Variable["BaseGame.Situation_Economy_RecoveredTrade"] = false;
Variable["BaseGame.Situation_Economy_DecreasedTrade"] = false;
Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_RecoveredTrade = false;
BaseGame.Situation_Economy_IncreasedTrade = false;
BaseGame.Situation_Economy_DecreasedTrade = true;
BaseGame.Situation_Diplomacy_FailedTradeNegotiation = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_RecoveredTrade"] = false;
Variable["BaseGame.Situation_Economy_IncreasedTrade"] = false;
Variable["BaseGame.Situation_Economy_DecreasedTrade"] = true;
Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_Trade == true && BaseGame.Policy_Diplomacy_Agnolia_Trade == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_Trade == true && BaseGam..."*)
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Wehlen_Trade == true && BaseG..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_Trade == true && BaseGame.Policy_Diplomacy_Agnolia_Trade == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] == true  and  Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_IncreasedTrade = true; BaseGam..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Wehlen_Trade == true && BaseGame.Policy_Diplomacy_Agnolia_Trade == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_Trade"] == true  and  Variable["BaseGame.Policy_Diplomacy_Agnolia_Trade"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Economy_IncreasedTrade = false; BaseGa..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Economy_IncreasedTrade = false;
BaseGame.Situation_Economy_RecoveredTrade = true;
BaseGame.Situation_Economy_DecreasedTrade = false;
BaseGame.Situation_Diplomacy_FailedTradeNegotiation = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Economy_IncreasedTrade"] = false;
Variable["BaseGame.Situation_Economy_RecoveredTrade"] = true;
Variable["BaseGame.Situation_Economy_DecreasedTrade"] = false;
Variable["BaseGame.Situation_Diplomacy_FailedTradeNegotiation"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_FPnT_Immigration_Tight == true && BaseGam..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_FPnT_Immigration_Tight == true && BaseGame.Wehlen_DefendBorder == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_FPnT_Immigration_Tight == true && BaseGam..."*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_FPnT_Immigration_Tight == true && BaseG..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_FPnT_Immigration_Tight == true && BaseGame.Wehlen_DefendBorder == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == true  and  Variable["BaseGame.Wehlen_DefendBorder"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy_Bergia += 1;"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_FPnT_Immigration_Tight == true && BaseGame.Wehlen_DefendBorder == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] == true  and  Variable["BaseGame.Wehlen_DefendBorder"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.FactionReport_Turn05_CSP_BansPMCs = true;..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy_Bergia += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy_Bergia"] = Variable["BaseGame.Economy_Bergia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.FactionReport_Turn05_CSP_BansPMCs = true;..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.FactionReport_Turn05_CSP_BansPMCs = true; BaseGameSupport.FactionReport_Turn05_ATO_WarnsRiziaKingdom = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.FactionReport_Turn05_CSP_BansPMCs"] = true;
Variable["BaseGameSupport.FactionReport_Turn05_ATO_WarnsRiziaKingdom"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true || (BaseGame.Wehle..."*)

### Węzeł `[280]`
Mówca: **Wiktor Smolak**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Wiktor Smolak: "“But now, I need to solve some problems they are creating..."*)

### Węzeł `[281]`
Mówca: **Wiktor Smolak**
> "“I will cut all their supplies from Rumburg and trap them on the mountains.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Wiktor Smolak: "“I call it Operation Bear Trap.”"*)

### Węzeł `[282]`
**[WYBÓR GRACZA: ""Why would you offer me so much?""]** — Mówca: **Player**
> ""Why would you offer me so much?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[168]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Wiktor Smolak: "“Why wouldn't I? I want Sordland to be Wehlen's friend.”"*)

### Węzeł `[283]`
Mówca: **Wiktor Smolak**
> "“Why wouldn't I? I want Sordland to be Wehlen's friend.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Wiktor Smolak: ""The question is, do you also want Wehlen as your friend?""*)

### Węzeł `[284]`
Mówca: **Wiktor Smolak**
> ""The question is, do you also want Wehlen as your friend?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceSurge == true"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Narbel", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Narbel","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Narbel_DetainReport = true"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Country_Unrest < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest < 0"*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Country_Unrest < 0)"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Country_Unrest < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Country_Unrest"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Narbel", "City_Widesprea..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Country_Unrest < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Country_Unrest"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Narbel", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Narbel","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Anrica", "City_Widesprea..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Anrica", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Anrica","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Arvory", "City_Widesprea..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Arvory", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Arvory","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Morna", "City_Widespread..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Morna", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Morna","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Erzaren", "City_Widespre..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Erzaren", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Erzaren","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Vesord", "City_Widesprea..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Vesord", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Vesord","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Estord", "City_Widesprea..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Estord", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Estord","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("PlaneLandingRoughly");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("PlaneLandingRoughly");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Our plane landed, and the door opened. The sun blinded me..."*)

### Węzeł `[298]`
Mówca: **Narrator**
> "It was probably the highest-quality tobacco I had ever smoked. I handed it back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "He took another puff, filling the room with more smoke."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Shisha");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Shisha");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Narrator: "It was probably the highest-quality tobacco I had ever sm..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Wehlen", "Friendly");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Wehlen","Friendly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "The next day, I returned to Sordland with a hangover."*)

### Węzeł `[301]`
Mówca: **Wiktor Smolak**
> ""However, the main problem is the border security between our nations. BFF militants have been using the mountains between Sordland and Wehlen to escape justice in both of our countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Wiktor Smolak: ""If we don't act and trap them in those mountains, they w..."*)

### Węzeł `[302]`
Mówca: **Wiktor Smolak**
> ""If we don't act and trap them in those mountains, they will keep replenishing their forces in both of our countries and keep waging war against our citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)

### Węzeł `[303]`
Mówca: **Wiktor Smolak**
> "“In return, you will assist me in destroying the armed militants in my country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Wiktor Smolak: "“You know that as long as they use the mountains in Wehle..."*)

### Węzeł `[304]`
Mówca: **Wiktor Smolak**
> "“And now, I need to solve some problems they are creating for me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player: "“What is it?”"*)
  - -> `[140]` (*Player: "“I'm listening.”"*)

### Węzeł `[305]`
Mówca: **Wiktor Smolak**
> "“But now, I need to solve some problems they are creating for me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player: "“What is it?”"*)
  - -> `[140]` (*Player: "“I'm listening.”"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_Country_Wehlen", "Country_Wehlen_Trade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_Country_Wehlen","Country_Wehlen_Trade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_Country_Wehlen", "Country_Wehlen..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_Country_Wehlen", "Country_Wehlen_Cooperation");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_Country_Wehlen","Country_Wehlen_Cooperation");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_Country_Wehlen", "Country_Wehlen..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_Country_Wehlen", "Country_Wehlen_Trade");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_Country_Wehlen","Country_Wehlen_Trade");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_Country_Wehlen", "Country_Wehlen..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_Country_Wehlen", "Country_Wehlen_Trade_Oil");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_Country_Wehlen","Country_Wehlen_Trade_Oil");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_Country_Wehlen", "Country_Wehlen_Trade_Oil");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_Country_Wehlen","Country_Wehlen_Trade_Oil");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true || (BaseGame.Wehlen_DefendBorder == true && BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true || (BaseGame.Wehle..."*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_JointOperation == true || (BaseGame.Weh..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true || (BaseGame.Wehlen_DefendBorder == true && BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true  or  (Variable["BaseGame.Wehlen_DefendBorder"] == true  and  Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Derdia", "Unf..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_JointOperation == true || (BaseGame.Wehlen_DefendBorder == true && BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true  or  (Variable["BaseGame.Wehlen_DefendBorder"] == true  and  Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Derdia", "Unfriendly");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Derdia","Unfriendly");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_Country_Wehlen", "Progress_DiplomaticMission_Wehlen");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_Country_Wehlen","Progress_DiplomaticMission_Wehlen");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Sordland One's flight from Holsord to Wraclawitz took app..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceSurge == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceSurge == true"*)
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceSurge == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player: "“Deal.” [-1 Government Budget]"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Player: "“Deal.”"*)

### Węzeł `[320]`
**[WYBÓR GRACZA: "“Deal.”"]** — Mówca: **Player**
> "“Deal.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[175]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn05_Trade_WehlenSigned = true;..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn05_Trade_WehlenSigned = true;..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceSurge == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceSurge == true"*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceSurge == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Wiktor Smolak: ""What I seek from you, in reciprocation for this advantag..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Wiktor Smolak: "“What I want from you in return for all the money and the..."*)

### Węzeł `[325]`
Mówca: **Wiktor Smolak**
> ""What I seek from you, in reciprocation for this advantageous collaboration, is merely a cooperative military endeavor involving our forces against the BFF.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "I took a moment to think about it."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceSurge == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceSurge == true"*)
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceSurge == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Player: ""Are you suggesting we pay a higher rate than usual?""*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Player: ""Why would you offer me so much?""*)

### Węzeł `[329]`
**[WYBÓR GRACZA: ""Are you suggesting we pay a higher rate than usual?""]** — Mówca: **Player**
> ""Are you suggesting we pay a higher rate than usual?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true`
- **Kontekst wejściowy (poprzednik):** `[168]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Wiktor Smolak: ""Indeed, there are additional expenses emerging within ou..."*)

### Węzeł `[330]`
Mówca: **Wiktor Smolak**
> ""Indeed, there are additional expenses emerging within our oil sector. Consider it a modest surcharge, a token of our potential friendship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Wiktor Smolak: ""The question is, do you also want Wehlen as your friend?""*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceSurge == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceSurge == true"*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceSurge == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Wiktor Smolak: "“In exchange, we will offer you a competitive new oil pri..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Wiktor Smolak: "“In return, you will assist me in destroying the armed mi..."*)

### Węzeł `[334]`
Mówca: **Wiktor Smolak**
> "“In exchange, we will offer you a competitive new oil price, aligned with the latest market dynamics, and in turn, you'll aid me in dismantling the armed militants in my country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Wiktor Smolak: "“You know that as long as they use the mountains in Wehle..."*)
