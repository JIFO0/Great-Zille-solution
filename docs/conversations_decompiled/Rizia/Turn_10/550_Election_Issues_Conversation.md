# Rizia/Turn 10/Election_Issues/Election_Issues Conversation

- **ID konwersacji:** `550`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/550_Election_Issues_Conversation.md`
- **Liczba węzłów dialogowych:** 287
- **Liczba wyborów gracza:** 21

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[95]** Player_Romus *(Gracz)*
- **[102]** Adarfo Sotelato

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.Pales_DidntRatifyTreaty`
- `RiziaDLC.Pales_War`
- `RiziaDLC.RRG_NationalizedUnderAdarfo`
- `RiziaDLC.Reform_Monarch_Veto`
- `RiziaDLC.Reform_PrimeMinister_Adarfo`
- `RiziaDLC.Reform_PrimeMinister_Daria`
- `RiziaDLC.Reform_PrimeMinister_Manus`
- `RiziaDLC.Rusty_Executed`
- `RiziaDLC.Rusty_Pardoned`
- `RiziaDLC.Situation_Welfare_LivingStandards_Bad`
- `RiziaDLC.Situation_Welfare_LivingStandards_Good`
- `RiziaDLC.Situation_Welfare_LivingStandards_Great`
- `RiziaDLC.Situation_Welfare_LivingStandards_Horrible`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.War_Happened`
- `RiziaDLC.War_Pales_Won`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLCIsolated.TalkWithPM_PalesUpdate`
- `RiziaDLCIsolated.TalkWithPM_RRG_StateOwns100`
- `RiziaDLCIsolated.TalkWithPM_ZilleUpdate`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCIsolated.TalkWithPM_PalesUpdate`
- `RiziaDLCIsolated.TalkWithPM_RNC_Favorability`
- `RiziaDLCIsolated.TalkWithPM_RPP_Favorability`
- `RiziaDLCIsolated.TalkWithPM_ZilleUpdate`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[348] Rizia/Turn 10/TalkWithPrimeMinister** (../Turn_10/348_TalkWithPrimeMinister.md), Węzeł `[679]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[185]` | **""Let’s hope it doesn’t end up costing us more than it’s worth.""** | `[184]` **Manus Sazon**: ""I know what Rusty's pardon and ..."<br>`[196]` **Manus Sazon**: ""Thanks to the efforts of Treasu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Manus Sazon**: ""Sometimes the cost of doing not..." |
| `[186]` | **""Rusty Montoro... a man of the people, now? How charming.""** | `[184]` **Manus Sazon**: ""I know what Rusty's pardon and ..."<br>`[196]` **Manus Sazon**: ""Thanks to the efforts of Treasu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Manus Sazon**: ""I don't know if 'charming' is t..." |
| `[187]` | **""Public support is fleeting. You shouldn't base policy on every passing whim.""** | `[184]` **Manus Sazon**: ""I know what Rusty's pardon and ..."<br>`[196]` **Manus Sazon**: ""Thanks to the efforts of Treasu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Manus Sazon**: ""It's the price of a free society."" |
| `[188]` | **""If it serves the people, then perhaps it’s a step in the right direction.""** | `[184]` **Manus Sazon**: ""I know what Rusty's pardon and ..."<br>`[196]` **Manus Sazon**: ""Thanks to the efforts of Treasu..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Manus Sazon**: ""I'm glad you agree.""<br>`[202]` **Adarfo Sotelato**: ""Yes, it is."" |
| `[204]` | **""Let’s hope this wealth doesn’t end up locked away in another set of hands.""** | `[198]` **Adarfo Sotelato**: ""As a result of my party's actio..."<br>`[283]` **Adarfo Sotelato**: ""Your actions went a long way to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Adarfo Sotelato**: ""Believe me, this wealth will re..." |
| `[206]` | **""Wonderful! I assume every Rizian will get a gold bar delivered to their door?""** | `[198]` **Adarfo Sotelato**: ""As a result of my party's actio..."<br>`[283]` **Adarfo Sotelato**: ""Your actions went a long way to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[207]` **Adarfo Sotelato**: ""If only it were that simple. Wh..." |
| `[228]` | **""We’ll see how long their concerns last after the ballots are tallied.""** | `[219]` **Manus Sazon**: ""As you can see, the issues faci..."<br>`[226]` **Daria de Rava**: ""Clearly, the concerns driving v..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[230]` | **""Perhaps. But such unpredictability can also breed opportunity. Opportunity for th..."** | `[219]` **Manus Sazon**: ""As you can see, the issues faci..."<br>`[226]` **Daria de Rava**: ""Clearly, the concerns driving v..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[231]` | **""Public opinion is volatile, but leadership requires steady hands.""** | `[219]` **Manus Sazon**: ""As you can see, the issues faci..."<br>`[226]` **Daria de Rava**: ""Clearly, the concerns driving v..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[232]` | **""Despite the challenges, this election will serve as a reminder of the power of th..."** | `[219]` **Manus Sazon**: ""As you can see, the issues faci..."<br>`[226]` **Daria de Rava**: ""Clearly, the concerns driving v..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[238]` | **""We'll bring her home on our terms. Not the Duke's.""** | `[237]` **Manus Sazon**: ""I still don't understand, Your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Manus Sazon**: ""I suppose you're right.."" |
| `[239]` | **""If you think the Palesians would have kept those promises, you're even more gulli..."** | `[237]` **Manus Sazon**: ""I still don't understand, Your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Manus Sazon**: ""I suppose you're right.."" |
| `[240]` | **""The life of a princess is no more valuable than the lives that will be lost if we..."** | `[237]` **Manus Sazon**: ""I still don't understand, Your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Manus Sazon**: ""I suppose you're right.."" |
| `[241]` | **""I can't second-guess every decision I make. If I did, I wouldn't be King.""** | `[237]` **Manus Sazon**: ""I still don't understand, Your ..." | `(Variable["RiziaDLC.Reform_Monarch_Veto"] == false) == false` | *Brak zmian stanu* | `[242]` **Manus Sazon**: ""I suppose you're right.."" |
| `[245]` | **""You were making a mistake. The Duke would never have kept his promises.""** | `[244]` **Daria de Rava**: ""And to be frank, the fact that ..."<br>`[90]` **Manus Sazon**: ""And to be honest, Your Majesty,..." | `(Variable["RiziaDLC.Vina_Hostage"] == true) == false` | *Brak zmian stanu* | `[265]` **Manus Sazon**: ""Yes, maybe you're right...""<br>`[266]` **Daria de Rava**: ""Perhaps you're right."" |
| `[247]` | **""Why didn't you override me if you thought I was making the wrong call? You had th..."** | `[244]` **Daria de Rava**: ""And to be frank, the fact that ..."<br>`[90]` **Manus Sazon**: ""And to be honest, Your Majesty,..." | `Variable["RiziaDLC.Reform_Monarch_Veto"] == false`<br>`(Variable["RiziaDLC.Vina_Hostage"] == true) == false` | *Brak zmian stanu* | `[257]` **Manus Sazon**: ""A major disagreement between th..."<br>`[261]` **Daria de Rava**: ""You are still head of state, Yo..." |
| `[251]` | **""This is exactly why I gave myself veto power. I'll take the fall for the continua..."** | `[244]` **Daria de Rava**: ""And to be frank, the fact that ..."<br>`[90]` **Manus Sazon**: ""And to be honest, Your Majesty,..." | `(Variable["RiziaDLC.Reform_Monarch_Veto"] == false) == false`<br>`(Variable["RiziaDLC.Vina_Hostage"] == true) == false` | *Brak zmian stanu* | `[265]` **Manus Sazon**: ""Yes, maybe you're right...""<br>`[266]` **Daria de Rava**: ""Perhaps you're right."" |
| `[252]` | **""They'll come around once we achieve our victory.""** | `[244]` **Daria de Rava**: ""And to be frank, the fact that ..."<br>`[90]` **Manus Sazon**: ""And to be honest, Your Majesty,..." | `(Variable["RiziaDLC.Vina_Hostage"] == true) == false` | *Brak zmian stanu* | `[265]` **Manus Sazon**: ""Yes, maybe you're right...""<br>`[266]` **Daria de Rava**: ""Perhaps you're right."" |
| `[256]` | **""You had the power to override me. Why didn't you?""** | `[237]` **Manus Sazon**: ""I still don't understand, Your ..." | `Variable["RiziaDLC.Reform_Monarch_Veto"] == false` | *Brak zmian stanu* | `[257]` **Manus Sazon**: ""A major disagreement between th..." |
| `[284]` | **""You're welcome. Should you be elected, I expect the redistribution of Rizia's wea..."** | `[283]` **Adarfo Sotelato**: ""Your actions went a long way to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Adarfo Sotelato**: ""Oh, it will."" |
| `[286]` | **""That was a terrible idea. Rusty knew how to make the most of Rizia's resources.""** | `[198]` **Adarfo Sotelato**: ""As a result of my party's actio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Adarfo Sotelato**: ""The most for himself, you mean...." |

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
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true )"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_PalesUpdate = true;"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Happened == true"*)

### Węzeł `[6]`
Mówca: **Manus Sazon**
> ""The ongoing war with Pales remains a top concern on voters' minds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Horrible == tr..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Manus Sazon: ""The ongoing war with Pales remains a top concern on vote..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Daria de Rava: ""The ongoing war with Pales remains a top concern for vot..."*)

### Węzeł `[10]`
Mówca: **Daria de Rava**
> ""The ongoing war with Pales remains a top concern for voters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Horrible == tr..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Horrible == tr..."*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Horrible == ..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Manus Sazon: ""With the hardships many are facing at home, they just wa..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Manus Sazon: ""Though they support our troops, they are eager for the f..."*)

### Węzeł `[14]`
Mówca: **Manus Sazon**
> ""Though they support our troops, they are eager for the fighting to be over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Manus Sazon: ""And to be honest, Your Majesty, the fact that you reject..."*)

### Węzeł `[15]`
Mówca: **Manus Sazon**
> ""With the hardships many are facing at home, they just want the fighting to be over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Manus Sazon: ""And to be honest, Your Majesty, the fact that you reject..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Horrible == tr..."*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Horrible == ..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Daria de Rava: ""With the hardships many are facing at home, they simply ..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true || RiziaDLC.Situation_Welfare_LivingStandards_Bad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Daria de Rava: ""Though they support our troops, they are eager for the f..."*)

### Węzeł `[19]`
Mówca: **Daria de Rava**
> ""With the hardships many are facing at home, they simply want the war to end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Daria de Rava: ""And to be frank, the fact that you rejected our proposed..."*)

### Węzeł `[20]`
Mówca: **Daria de Rava**
> ""Though they support our troops, they are eager for the fighting to be over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Daria de Rava: ""And to be frank, the fact that you rejected our proposed..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Happened == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Happened == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_PalesUpdate = true;"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)

### Węzeł `[24]`
Mówca: **Manus Sazon**
> ""The fallout of the war with Pales is one of the top issues on voters' minds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Won == true"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Manus Sazon: ""The fallout of the war with Pales is one of the top issu..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Daria de Rava: ""The fallout of the war with Pales remains a top issue fo..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Adarfo Sotelato: ""The fallout of the war with Pales is one of the most pre..."*)

### Węzeł `[31]`
Mówca: **Daria de Rava**
> ""The fallout of the war with Pales remains a top issue for voters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Won == true"*)

### Węzeł `[32]`
Mówca: **Adarfo Sotelato**
> ""The fallout of the war with Pales is one of the most pressing issues for voters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Won == true"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Won == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Won == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[36]`
Mówca: **Manus Sazon**
> ""Our military's accomplishments have reinforced the RPP's leadership and positioned us well for the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RPP_Favorability += 1;"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Manus Sazon: ""Our military's accomplishments have reinforced the RPP's..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Manus Sazon: ""Our military's accomplishments have reinforced the RNC's..."*)

### Węzeł `[46]`
Mówca: **Manus Sazon**
> ""Our military's accomplishments have reinforced the RNC's leadership and, unfortunately, strengthened their position in the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RNC_Favorability += 1;"*)

### Węzeł `[47]`
Mówca: **Daria de Rava**
> ""Our military's accomplishments have reinforced the RNC's leadership and positioned us well for the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RNC_Favorability += 1;"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Daria de Rava: ""Our military's accomplishments have reinforced the RNC's..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Daria de Rava: ""Our military's accomplishments have reinforced the RPP's..."*)

### Węzeł `[51]`
Mówca: **Daria de Rava**
> ""Our military's accomplishments have reinforced the RPP's leadership and, unfortunately, bolstered their position in the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RPP_Favorability += 1;"*)

### Węzeł `[52]`
Mówca: **Adarfo Sotelato**
> ""The military's accomplishments have reinforced the RPP's leadership and positioned us well for the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RPP_Favorability += 1;"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Adarfo Sotelato: ""The military's accomplishments have reinforced the RPP's..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Adarfo Sotelato: ""Our military successes have only reinforced the RNC's ho..."*)

### Węzeł `[56]`
Mówca: **Adarfo Sotelato**
> ""Our military successes have only reinforced the RNC's hold on power, and, regrettably, have solidified their standing in this election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RNC_Favorability += 1;"*)

### Węzeł `[57]`
Mówca: **Manus Sazon**
> ""I and the RPP never fully supported the war, but the fact that it happened with us holding a majority is undermining our position in the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RNC_Favorability += 1;"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[64]`
Mówca: **Adarfo Sotelato**
> ""I and the RPP never supported the war. So your military's failure to secure a victory has solidified our standing in this election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_DidntRatifyTreaty == true"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Manus Sazon: ""I and the RPP never fully supported the war, but the fac..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Manus Sazon: ""I do regret our failure to win, but it has weakened publ..."*)

### Węzeł `[68]`
Mówca: **Daria de Rava**
> ""The fact that our military failures happened with the RPP in power has strengthened our position in the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RPP_Favorability += 1;"*)

### Węzeł `[69]`
Mówca: **Adarfo Sotelato**
> ""I and the RPP never supported the war. But the fact that your military's failures happened with my party in power has undermined our position in the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RNC_Favorability += 1;"*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_DidntRatifyTreaty == true"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Adarfo Sotelato: ""I and the RPP never supported the war. But the fact that..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Adarfo Sotelato: ""I and the RPP never supported the war. So your military'..."*)

### Węzeł `[73]`
Mówca: **Manus Sazon**
> ""I do regret our failure to win, but it has weakened public perception of the RNC and strengthened my party's position in the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RPP_Favorability += 1;"*)

### Węzeł `[74]`
Mówca: **Daria de Rava**
> ""Our military's failures have weakened the RNC's hold on power and, unfortunately, undermined our position in the election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RNC_Favorability += 1;"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Daria de Rava: ""The fact that our military failures happened with the RP..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Daria de Rava: ""Our military's failures have weakened the RNC's hold on ..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReturn_Success == true)"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_ZilleUpdate = true;"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReturn_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[81]`
Mówca: **Manus Sazon**
> ""Zille's return has been a rallying point for voters, reaffirming confidence and support in the current leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.R..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_PalesUpdate == true"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_PalesUpdate == true"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_PalesUpdate == true"*)

### Węzeł `[88]`
Mówca: **Daria de Rava**
> ""Zille’s return has become a key rallying point for voters, restoring confidence and support in the current leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.R..."*)

### Węzeł `[89]`
Mówca: **Adarfo Sotelato**
> ""Zille’s return to Rizia has served as a powerful rallying point for voters, strengthening confidence and backing for the current leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.R..."*)

### Węzeł `[90]`
Mówca: **Manus Sazon**
> ""And to be honest, Your Majesty, the fact that you rejected our proposed ceasefire treaty has called my leadership abilities into question among some.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RNC_Favorability += 1;"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_RPP_Favorability += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] = Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_RNC_Favorability += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.TalkWithPM_RNC_Favorability"] = Variable["RiziaDLCIsolated.TalkWithPM_RNC_Favorability"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_RPP_Favorability += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] = Variable["RiziaDLCIsolated.TalkWithPM_RPP_Favorability"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Manus Sazon: ""At its core, the election is shaped by household realiti..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Daria de Rava: ""At its core, the election is influenced by the realities..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaD..."*)

### Węzeł `[100]`
Mówca: **Adarfo Sotelato**
> ""But the heart of the election beats in tune with the daily lives and hardships of the working masses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)

### Węzeł `[101]`
Mówca: **Manus Sazon**
> ""High living standards, such as access to quality healthcare and stable employment, have reinforced confidence in the current leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Manus Sazon: ""In addition, modern conveniences -- such as widespread a..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Great == tru..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Manus Sazon: ""High living standards, such as access to quality healthc..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)

### Węzeł `[105]`
Mówca: **Manus Sazon**
> ""In addition, modern conveniences -- such as widespread air conditioning, personal vehicles, and increasing homeownership -- have further bolstered public support as they head to the polls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[106]`
Mówca: **Manus Sazon**
> ""Living standards remain stable, with consistent access to healthcare and steady employment providing a sense of security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Manus Sazon: ""At the same time, reliable transportation and stable hou..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Great == tru..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Manus Sazon: ""Living standards remain stable, with consistent access t..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Manus Sazon: ""Living standards have significantly declined, with risin..."*)

### Węzeł `[110]`
Mówca: **Manus Sazon**
> ""At the same time, reliable transportation and stable housing have continued to support public confidence in the leadership as voters head to the polls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[111]`
Mówca: **Manus Sazon**
> ""Living standards have significantly declined, with rising unemployment and limited access to healthcare leaving many feeling uncertain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Manus Sazon: ""Basic needs are becoming harder to meet, and issues like..."*)

### Węzeł `[112]`
Mówca: **Manus Sazon**
> ""Basic needs are becoming harder to meet, and issues like unreliable transportation and inadequate housing continue to undermine public confidence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Manus Sazon: ""As a result, the current leadership faces growing dissat..."*)

### Węzeł `[113]`
Mówca: **Manus Sazon**
> ""As a result, the current leadership faces growing dissatisfaction, which is expected to influence voter turnout against them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[114]`
Mówca: **Daria de Rava**
> ""Living standards remain steady, with consistent access to healthcare and reliable employment offering security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Daria de Rava: ""Furthermore, dependable transportation and stable housin..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Great == tru..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Daria de Rava: ""High living standards, including access to quality healt..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Great == tru..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Daria de Rava: ""Living standards remain steady, with consistent access t..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Daria de Rava: ""Living standards have sharply declined, with rising unem..."*)

### Węzeł `[121]`
Mówca: **Daria de Rava**
> ""Furthermore, modern conveniences like widespread air conditioning, personal vehicles, and rising homeownership have increased public support as voters go to the polls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[122]`
Mówca: **Daria de Rava**
> ""Living standards have sharply declined, with rising unemployment and limited healthcare access making many feel uneasy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Daria de Rava: ""Basic needs are harder to fulfill, and issues like unrel..."*)

### Węzeł `[123]`
Mówca: **Daria de Rava**
> ""Basic needs are harder to fulfill, and issues like unreliable transportation and poor housing continue to erode public trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Daria de Rava: ""As a result, dissatisfaction with the current leadership..."*)

### Węzeł `[124]`
Mówca: **Daria de Rava**
> ""As a result, dissatisfaction with the current leadership is growing, which will likely influence voter turnout against them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[125]`
Mówca: **Daria de Rava**
> ""Furthermore, dependable transportation and stable housing continue to reinforce public confidence in the leadership as voters cast their ballots.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[126]`
Mówca: **Daria de Rava**
> ""High living standards, including access to quality healthcare and stable employment, have strengthened confidence in the current leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Daria de Rava: ""Furthermore, modern conveniences like widespread air con..."*)

### Węzeł `[127]`
Mówca: **Adarfo Sotelato**
> ""While the standard of living has improved for many, the working class continues to benefit most from access to essentials like healthcare, stable employment, and reliable public services.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Adarfo Sotelato: ""As a result, this has fostered confidence in our ability..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Great == tru..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Adarfo Sotelato: ""While the standard of living has improved for many, the ..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Great == tru..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Adarfo Sotelato: ""Living standards have stabilized for most, thanks to acc..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Great == true || RiziaDLC.Situation_Welfare_LivingStandards_Good == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Great"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Good"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Adarfo Sotelato: ""Living standards have significantly declined, with risin..."*)

### Węzeł `[134]`
Mówca: **Adarfo Sotelato**
> ""Nevertheless, reliable transportation and stable housing have continued to support public confidence in us as voters head to the polls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[135]`
Mówca: **Adarfo Sotelato**
> ""Living standards have significantly declined, with rising unemployment and limited access to healthcare leaving many feeling uncertain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Adarfo Sotelato: ""Most of this is fallout from your governance, King Romus..."*)

### Węzeł `[136]`
Mówca: **Adarfo Sotelato**
> ""Most of this is fallout from your governance, King Romus. Our voters are counting on us to turn this around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[137]`
Mówca: **Adarfo Sotelato**
> ""Furthermore, modern conveniences such as widespread air conditioning, personal vehicles, and increasing homeownership have helped bolster public support as voters head to the polls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[138]`
Mówca: **Adarfo Sotelato**
> ""Living standards have stabilized for most, thanks to access to essentials like healthcare and secure jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Adarfo Sotelato: ""Though disparities do remain.""*)

### Węzeł `[139]`
Mówca: **Adarfo Sotelato**
> ""As a result, this has fostered confidence in our ability to maintain order and stability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Adarfo Sotelato: ""Furthermore, modern conveniences such as widespread air ..."*)

### Węzeł `[140]`
Mówca: **Adarfo Sotelato**
> ""Though disparities do remain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Adarfo Sotelato: ""Nevertheless, reliable transportation and stable housing..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_PalesUpdate = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_ZilleUpdate = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.TalkWithPM_ZilleUpdate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_PalesUpdate = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_PalesUpdate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_PalesUpdate == true"*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_PalesUpdate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Manus Sazon: ""Zille's return has also been a rallying point for voters..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Manus Sazon: ""Zille's return has been a rallying point for voters, rea..."*)

### Węzeł `[147]`
Mówca: **Manus Sazon**
> ""Zille's return has also been a rallying point for voters, reaffirming confidence and support in the current leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.R..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_PalesUpdate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_PalesUpdate == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_PalesUpdate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Daria de Rava: ""Zille’s return has also become a key rallying point for ..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Daria de Rava: ""Zille’s return has become a key rallying point for voter..."*)

### Węzeł `[151]`
Mówca: **Daria de Rava**
> ""Zille’s return has also become a key rallying point for voters, restoring confidence and support in the current leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.R..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_PalesUpdate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_PalesUpdate == true"*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_PalesUpdate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Adarfo Sotelato: ""Zille’s return to Rizia has also served as a powerful ra..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Adarfo Sotelato: ""Zille’s return to Rizia has served as a powerful rallyin..."*)

### Węzeł `[155]`
Mówca: **Adarfo Sotelato**
> ""Zille’s return to Rizia has also served as a powerful rallying point for voters, strengthening confidence and backing for the current leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.R..."*)

### Węzeł `[156]`
Mówca: **Manus Sazon**
> ""Losing Zille has become a rallying point for voters, whose anger and deepening frustrations with the current leadership fuel their desire for change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.R..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_PalesUpdate == true"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_PalesUpdate == true"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_PalesUpdate == true"*)

### Węzeł `[163]`
Mówca: **Daria de Rava**
> ""The loss of Zille has become a rallying point for voters, whose anger and deepening frustrations with the current leadership fuel their desire for change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.R..."*)

### Węzeł `[164]`
Mówca: **Adarfo Sotelato**
> ""Losing Zille has become a rallying point for voters, whose growing anger and frustrations with the current leadership drive their desire for change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.R..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_PalesUpdate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_PalesUpdate == true"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_PalesUpdate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Adarfo Sotelato: ""Losing Zille has also become a rallying point for voters..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Adarfo Sotelato: ""Losing Zille has become a rallying point for voters, who..."*)

### Węzeł `[168]`
Mówca: **Adarfo Sotelato**
> ""Losing Zille has also become a rallying point for voters, whose growing anger and frustrations with the current leadership drive their desire for change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.R..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_PalesUpdate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_PalesUpdate == true"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_PalesUpdate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Manus Sazon: ""Losing Zille has also become a rallying point for voters..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Manus Sazon: ""Losing Zille has become a rallying point for voters, who..."*)

### Węzeł `[172]`
Mówca: **Manus Sazon**
> ""Losing Zille has also become a rallying point for voters, whose anger and deepening frustrations with the current leadership fuel their desire for change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.R..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_PalesUpdate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_PalesUpdate == true"*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_PalesUpdate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Daria de Rava: ""The loss of Zille has also become a rallying point for v..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Daria de Rava: ""The loss of Zille has become a rallying point for voters..."*)

### Węzeł `[176]`
Mówca: **Daria de Rava**
> ""The loss of Zille has also become a rallying point for voters, whose anger and deepening frustrations with the current leadership fuel their desire for change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.R..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.Rusty_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.R..."*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.Rusty_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true  and  Variable["RiziaDLC.Rusty_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaD..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true && RiziaDLC.Rusty_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true  and  Variable["RiziaDLC.Rusty_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Adarfo == true"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaDLCIsolated.TalkWithPM_PalesUpdate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaD..."*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || Rizi..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaDLCIsolated.TalkWithPM_PalesUpdate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_ZilleUpdate"] == true  or  Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Manus Sazon: ""In addition, there has been significant public support f..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_ZilleUpdate"] == true  or  Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Manus Sazon: ""There has been significant public support for our econom..."*)

### Węzeł `[183]`
Mówca: **Manus Sazon**
> ""In addition, there has been significant public support for our economic direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Pardoned == true"*)

### Węzeł `[184]`
Mówca: **Manus Sazon**
> ""I know what Rusty's pardon and the reversal of RRG's nationalization looked like on paper. But his efforts will result in a flood of new jobs for our industries, not to mention profits that will be redirected to the Rizian people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player_Romus: ""If it serves the people, then perhaps it’s a step in the..."*)
  - -> `[186]` (*Player_Romus: ""Rusty Montoro... a man of the people, now? How charming.""*)
  - -> `[185]` (*Player_Romus: ""Let’s hope it doesn’t end up costing us more than it’s w..."*)
  - -> `[187]` (*Player_Romus: ""Public support is fleeting. You shouldn't base policy on..."*)

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let’s hope it doesn’t end up costing us more than it’s worth.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Manus Sazon), `[196]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Manus Sazon: ""Sometimes the cost of doing nothing is far greater.""*)

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rusty Montoro... a man of the people, now? How charming.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Manus Sazon), `[196]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Manus Sazon: ""I don't know if 'charming' is the word I'd use... but he..."*)

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Public support is fleeting. You shouldn't base policy on every passing whim.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Manus Sazon), `[196]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Manus Sazon: ""It's the price of a free society.""*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If it serves the people, then perhaps it’s a step in the right direction.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Manus Sazon), `[196]` (Manus Sazon), `[198]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[189]`
Mówca: **Manus Sazon**
> ""It's the price of a free society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[190]`
Mówca: **Manus Sazon**
> ""Sometimes the cost of doing nothing is far greater.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[191]`
Mówca: **Manus Sazon**
> ""I don't know if 'charming' is the word I'd use... but he's what we need right now. We can’t ignore the fact that his actions have resonated with the public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[192]`
Mówca: **Manus Sazon**
> ""I'm glad you agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Pardoned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Pardoned == true"*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_Pardoned == true)"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_Pardoned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_Pardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Manus Sazon: ""I know what Rusty's pardon and the reversal of RRG's nat..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_Pardoned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_Pardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Manus Sazon: ""Thanks to the efforts of Treasury Secretary Rusty Montor..."*)

### Węzeł `[196]`
Mówca: **Manus Sazon**
> ""Thanks to the efforts of Treasury Secretary Rusty Montoro, the industry now benefits the everyday Rizian, not just the privileged few.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player_Romus: ""If it serves the people, then perhaps it’s a step in the..."*)
  - -> `[186]` (*Player_Romus: ""Rusty Montoro... a man of the people, now? How charming.""*)
  - -> `[185]` (*Player_Romus: ""Let’s hope it doesn’t end up costing us more than it’s w..."*)
  - -> `[187]` (*Player_Romus: ""Public support is fleeting. You shouldn't base policy on..."*)

### Węzeł `[197]`
Mówca: **Adarfo Sotelato**
> ""In addition, there has been significant public support for the decision to nationalize the Rizian Royal Gold corporation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.RRG_NationalizedUnderAdarfo == true"*)

### Węzeł `[198]`
Mówca: **Adarfo Sotelato**
> ""As a result of my party's actions, the industry now works for the prosperity of the nation, ensuring its wealth benefits not just the privileged few, but the everyday Rizian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player_Romus: ""If it serves the people, then perhaps it’s a step in the..."*)
  - -> `[204]` (*Player_Romus: ""Let’s hope this wealth doesn’t end up locked away in ano..."*)
  - -> `[286]` (*Player_Romus: ""That was a terrible idea. Rusty knew how to make the mos..."*)
  - -> `[206]` (*Player_Romus: ""Wonderful! I assume every Rizian will get a gold bar del..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Manus Sazon: ""I'm glad you agree.""*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Adarfo Sotelato: ""Yes, it is.""*)

### Węzeł `[202]`
Mówca: **Adarfo Sotelato**
> ""Yes, it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[203]`
Mówca: **Adarfo Sotelato**
> ""The most for himself, you mean. RRG's profits might shrink in the short term, but we'll reap the long-term rewards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let’s hope this wealth doesn’t end up locked away in another set of hands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Adarfo Sotelato), `[283]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Adarfo Sotelato: ""Believe me, this wealth will reach the hands that truly ..."*)

### Węzeł `[205]`
Mówca: **Adarfo Sotelato**
> ""Believe me, this wealth will reach the hands that truly need it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wonderful! I assume every Rizian will get a gold bar delivered to their door?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Adarfo Sotelato), `[283]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Adarfo Sotelato: ""If only it were that simple. What we’re doing is ensurin..."*)

### Węzeł `[207]`
Mówca: **Adarfo Sotelato**
> ""If only it were that simple. What we’re doing is ensuring a fairer distribution of resources, not childish fantasies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[208]`
Mówca: **Manus Sazon**
> ""There has been significant public support for our economic direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_Pardoned == true"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaDLCIsolated.TalkWithPM_PalesUpdate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaD..."*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || Rizi..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaDLCIsolated.TalkWithPM_PalesUpdate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_ZilleUpdate"] == true  or  Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Adarfo Sotelato: ""In addition, there has been significant public support f..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaDLCIsolated.TalkWithPM_PalesUpdate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_ZilleUpdate"] == true  or  Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Adarfo Sotelato: ""There has been significant public support for the decisi..."*)

### Węzeł `[212]`
Mówca: **Adarfo Sotelato**
> ""There has been significant public support for the decision to nationalize the Rizian Royal Gold corporation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.RRG_NationalizedUnderAdarfo == true"*)

### Węzeł `[213]`
Mówca: **Manus Sazon**
> ""At its core, the election is shaped by household realities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)

### Węzeł `[214]`
Mówca: **Daria de Rava**
> ""At its core, the election is influenced by the realities of daily life within households.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaDLCIsolated.TalkWithPM_PalesUpdate == true || RiziaDLCIsolated.TalkWithPM_RRG_StateOwns100 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaD..."*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || Rizi..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaDLCIsolated.TalkWithPM_PalesUpdate == true || RiziaDLCIsolated.TalkWithPM_RRG_StateOwns100 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.TalkWithPM_ZilleUpdate"] == true  or  Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true  or  Variable["RiziaDLCIsolated.TalkWithPM_RRG_StateOwns100"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Adarfo Sotelato: ""But the heart of the election beats in tune with the dai..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaDLCIsolated.TalkWithPM_PalesUpdate == true || RiziaDLCIsolated.TalkWithPM_RRG_StateOwns100 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.TalkWithPM_ZilleUpdate"] == true  or  Variable["RiziaDLCIsolated.TalkWithPM_PalesUpdate"] == true  or  Variable["RiziaDLCIsolated.TalkWithPM_RRG_StateOwns100"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Adarfo Sotelato: ""The heart of the election beats in tune with the daily l..."*)

### Węzeł `[218]`
Mówca: **Adarfo Sotelato**
> ""The heart of the election beats in tune with the daily lives and hardships of the working masses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Great == true ..."*)

### Węzeł `[219]`
Mówca: **Manus Sazon**
> ""As you can see, the issues facing us are as diverse and unpredictable as Rizia itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Manus Sazon: ""As you can see, the issues facing us are as diverse and ..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria == true"*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Daria == true)"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Daria de Rava: ""Clearly, the concerns driving voters are as varied and c..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Daria == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Daria"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Adarfo Sotelato: ""As you can see, the issues influencing the election are ..."*)

### Węzeł `[226]`
Mówca: **Daria de Rava**
> ""Clearly, the concerns driving voters are as varied and complex as the regions they come from.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[227]`
Mówca: **Adarfo Sotelato**
> ""As you can see, the issues influencing the election are as dynamic and diverse as Rizia's people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We’ll see how long their concerns last after the ballots are tallied.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Manus Sazon), `[226]` (Daria de Rava), `[227]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Player_Romus: ""Despite the challenges, this election will serve as a re..."*)
  - -> `[230]` (*Player_Romus: ""Perhaps. But such unpredictability can also breed opport..."*)
  - -> `[228]` (*Player_Romus: ""We’ll see how long their concerns last after the ballots..."*)
  - -> `[231]` (*Player_Romus: ""Public opinion is volatile, but leadership requires stea..."*)

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps. But such unpredictability can also breed opportunity. Opportunity for those willing to seize it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Manus Sazon), `[226]` (Daria de Rava), `[227]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Public opinion is volatile, but leadership requires steady hands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Manus Sazon), `[226]` (Daria de Rava), `[227]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite the challenges, this election will serve as a reminder of the power of the people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Manus Sazon), `[226]` (Daria de Rava), `[227]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "He paused with a look of consternation on his face."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[236]`
Mówca: **Narrator**
> "He paused with a look of consternation on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Manus Sazon: ""I still don't understand, Your Majesty. We had a chance ..."*)

### Węzeł `[237]`
Mówca: **Manus Sazon**
> ""I still don't understand, Your Majesty. We had a chance to stop the casualties and bring Vina home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Player_Romus: ""We'll bring her home on our terms. Not the Duke's.""*)
  - -> `[239]` (*Player_Romus: ""If you think the Palesians would have kept those promise..."*)
  - -> `[240]` (*Player_Romus: ""The life of a princess is no more valuable than the live..."*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Monarch_Veto == false"*)

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll bring her home on our terms. Not the Duke's.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Manus Sazon: ""I suppose you're right..""*)

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you think the Palesians would have kept those promises, you're even more gullible than I thought.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Manus Sazon: ""I suppose you're right..""*)

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The life of a princess is no more valuable than the lives that will be lost if we let Pales continue their campaign of aggression against us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Manus Sazon: ""I suppose you're right..""*)

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't second-guess every decision I make. If I did, I wouldn't be King.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Monarch_Veto"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[237]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Manus Sazon: ""I suppose you're right..""*)

### Węzeł `[242]`
Mówca: **Manus Sazon**
> ""I suppose you're right..""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_RNC_Favorability += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.TalkWithPM_RNC_Favorability"] = Variable["RiziaDLCIsolated.TalkWithPM_RNC_Favorability"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[244]`
Mówca: **Daria de Rava**
> ""And to be frank, the fact that you rejected our proposed ceasefire treaty brought my leadership abilities into question among our voter base.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RPP_Favorability += 1;"*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were making a mistake. The Duke would never have kept his promises.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[244]` (Daria de Rava), `[90]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player_Romus: ""You were making a mistake. The Duke would never have kep..."*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Monarch_Veto == false"*)
  - -> `[252]` (*Player_Romus: ""They'll come around once we achieve our victory.""*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why didn't you override me if you thought I was making the wrong call? You had the power to do so.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Monarch_Veto"] == false` AND `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[244]` (Daria de Rava), `[90]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Monarch_Veto == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Monarch_Veto == false"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Monarch_Veto == false)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Monarch_Veto == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Monarch_Veto"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player_Romus: ""Why didn't you override me if you thought I was making t..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Monarch_Veto == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Monarch_Veto"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Player_Romus: ""This is exactly why I gave myself veto power. I'll take ..."*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is exactly why I gave myself veto power. I'll take the fall for the continuation of the war, not you.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Monarch_Veto"] == false) == false` AND `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[244]` (Daria de Rava), `[90]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They'll come around once we achieve our victory.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[244]` (Daria de Rava), `[90]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Monarch_Veto == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Monarch_Veto == false"*)
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Monarch_Veto == false)"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Monarch_Veto == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Monarch_Veto"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Player_Romus: ""You had the power to override me. Why didn't you?""*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Monarch_Veto == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Monarch_Veto"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Player_Romus: ""I can't second-guess every decision I make. If I did, I ..."*)

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You had the power to override me. Why didn't you?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Monarch_Veto"] == false`
- **Kontekst wejściowy (poprzednik):** `[237]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Manus Sazon: ""A major disagreement between the monarch and the Prime M..."*)

### Węzeł `[257]`
Mówca: **Manus Sazon**
> ""A major disagreement between the monarch and the Prime Minister so soon after our reforms? It would have been an even bigger mess than the war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Manus Sazon: ""A major disagreement between the monarch and the Prime M..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Daria de Rava: ""You are still head of state, Your Majesty. I would never..."*)

### Węzeł `[261]`
Mówca: **Daria de Rava**
> ""You are still head of state, Your Majesty. I would never let the treaty go ahead without your approval.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Manus == true)"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Manus Sazon: ""Yes, maybe you're right...""*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Daria de Rava: ""Perhaps you're right.""*)

### Węzeł `[265]`
Mówca: **Manus Sazon**
> ""Yes, maybe you're right...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[266]`
Mówca: **Daria de Rava**
> ""Perhaps you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_DidntRatifyTreaty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_DidntRatifyTreaty == true"*)
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_DidntRatifyTreaty == true)"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_DidntRatifyTreaty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_DidntRatifyTreaty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Adarfo Sotelato: ""As has the fact that we had to sign the peace treaty wit..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_DidntRatifyTreaty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_DidntRatifyTreaty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RNC_Favorability += 1;"*)

### Węzeł `[270]`
Mówca: **Adarfo Sotelato**
> ""As has the fact that we had to sign the peace treaty without the King's blessing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RNC_Favorability = 2;"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_DidntRatifyTreaty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_DidntRatifyTreaty == true"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_DidntRatifyTreaty == true)"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_DidntRatifyTreaty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_DidntRatifyTreaty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Adarfo Sotelato: ""But the fact that we went ahead with the peace treaty wi..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_DidntRatifyTreaty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_DidntRatifyTreaty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_RPP_Favorability += 1;"*)

### Węzeł `[274]`
Mówca: **Adarfo Sotelato**
> ""But the fact that we went ahead with the peace treaty without your approval did rankle traditionalists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.TalkWithPM_RNC_Favorability = 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.TalkWithPM_RNC_Favorability"] = 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Adarfo == true"*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_PrimeMinister_Adarfo == true)"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.TalkWithPM_ZilleUpdate == true || RiziaD..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_PrimeMinister_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.RRG_NationalizedUnderAdarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.RRG_NationalizedUnderAdarfo == true"*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.RRG_NationalizedUnderAdarfo == true)"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.RRG_NationalizedUnderAdarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.RRG_NationalizedUnderAdarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Adarfo Sotelato: ""As a result of my party's actions, the industry now work..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.RRG_NationalizedUnderAdarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.RRG_NationalizedUnderAdarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Adarfo Sotelato: ""Your actions went a long way towards ensuring the indust..."*)

### Węzeł `[283]`
Mówca: **Adarfo Sotelato**
> ""Your actions went a long way towards ensuring the industry's wealth benefits not just the privileged few, but the everyday Rizian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Player_Romus: ""Let’s hope this wealth doesn’t end up locked away in ano..."*)
  - -> `[284]` (*Player_Romus: ""You're welcome. Should you be elected, I expect the redi..."*)
  - -> `[206]` (*Player_Romus: ""Wonderful! I assume every Rizian will get a gold bar del..."*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're welcome. Should you be elected, I expect the redistribution of Rizia's wealth to continue.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[283]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Adarfo Sotelato: ""Oh, it will.""*)

### Węzeł `[285]`
Mówca: **Adarfo Sotelato**
> ""Oh, it will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus == true"*)

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That was a terrible idea. Rusty knew how to make the most of Rizia's resources.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Adarfo Sotelato: ""The most for himself, you mean. RRG's profits might shri..."*)
