# Sordland/Turn02/A_ContractBribe

- **ID konwersacji:** `20`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Sordland/Turn_02/020_A_ContractBribe.md`
- **Liczba węzłów dialogowych:** 269
- **Liczba wyborów gracza:** 65

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[19]** Walter Tusk
- **[41]** Livia Suno

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn01_InfrastructureProject_Invest`
- `BaseGame.Decision_Turn01_PersonalInvestment_DontSpend`
- `BaseGame.Relations_Walter_Promise_BailBusiness`
- `BaseGame.Relations_Walter_Promise_Company`
- `BaseGame.Turn01_Admin_Meeting`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn02_FPnT_Consulate_Condemn`
- `BaseGameIsolated.Turn01_A_ContractBribe_Smoked`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.PersonalWealth`
- `BaseGame.Relations_Walter_Promise_BailBusiness`
- `BaseGame.Relations_Walter_Promise_Company`
- `BaseGameIsolated.Turn01_A_ContractBribe_Smoked`
- `BaseGameSupport.CountryReport_Turn02_Pales_RaisesRiziaCaution`
- `BaseGameSupport.Journal_Turn02_AcceptedTuskBailBribe`
- `BaseGameSupport.Journal_Turn02_AcceptedTuskCompanyBribe`
- `BaseGameSupport.Journal_Turn02_RejectedTuskBailBribe`
- `BaseGameSupport.Journal_Turn02_RejectedTuskCompanyBribe`
- `BaseGameSupport.News_Turn02_HP_GasomEngineerSalaries`
- `BaseGameSupport.News_Turn02_HP_KibenerSuggestsPower`
- `BaseGameSupport.News_Turn02_LT_LUSNarbelStatement`
- `BaseGameSupport.News_Turn02_LT_ReformDemands`
- `BaseGameSupport.News_Turn02_R_BludishLynched`
- `BaseGameSupport.News_Turn02_R_WorkersPartyMarch`
- `BaseGameSupport.Report_Turn02_Anrica_LocalPoliceReport`
- `BaseGameSupport.Report_Turn02_Narbel_SituationReport`
- `BaseGameSupport.Report_Turn02_Narbel_TenseSituationReport`
- `GameCondition.Turn02_A_ContractBribe`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[19]` | **"“Our goal is to unite every stakeholder to improve the economy.”"** | `[79]` **Walter Tusk**: "“This deal also aligns with the ..."<br>`[80]` **Walter Tusk**: "“This deal will also show to the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Walter Tusk**: "“Exactly, business owners need t..." |
| `[23]` | **""We need more government control to fix the economy.""** | `[8]` **Walter Tusk**: ""For us it is worrying to see th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Walter Tusk**: ""Do you really though?"" |
| `[24]` | **""The ability of the free-market to evolve is hard to dispute.""** | `[7]` **Walter Tusk**: ""I'm glad that you have decided ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Walter Tusk**: ""I couldn't have it said it bett..." |
| `[25]` | **""Indeed, Mr. Tusk. I am looking forward to our future transactions. [Take Bribe]""** | `[233]` **Walter Tusk**: ""Remind me to visit your office ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame....`<br>`Variable["BaseGameSupport.Journal_Turn02_AcceptedTuskBail...`<br>*(+3 skryptów)* | `[154]` **Walter Tusk**: "“You don't have to wait long, Mr..." |
| `[26]` | **"“No. I will make my own decision.”"** | `[233]` **Walter Tusk**: ""Remind me to visit your office ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Narrator**: "Walter sighed and pulled the che..." |
| `[31]` | **""Please.""** | `[50]` **Walter Tusk**: ""May I continue?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Walter Tusk**: ""I'd like to build a profitable ..." |
| `[32]` | **""I'm listening.""** | `[30]` **Walter Tusk**: ""...which I would like to take t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Walter Tusk**: ""The ruined state of the economy..." |
| `[33]` | **""What are these concerns?""** | `[30]` **Walter Tusk**: ""...which I would like to take t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Walter Tusk**: ""The ruined state of the economy..." |
| `[34]` | **""The people you represent?""** | `[30]` **Walter Tusk**: ""...which I would like to take t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Walter Tusk**: ""You know that I represent the L..." |
| `[36]` | **""Don't worry about it.""** | `[78]` **Livia Suno**: ""You had a meeting with the Loth..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Livia Suno**: ""Thank you for your understanding."" |
| `[44]` | **"Prepare to go home."** | `[41]` **Narrator**: "It had been an exhausting day, j..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Narrator**: "I quickly glanced out the window..." |
| `[45]` | **"Nod."** | `[50]` **Walter Tusk**: ""May I continue?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Walter Tusk**: ""I'd like to build a profitable ..." |
| `[46]` | **"Lean back and relax."** | `[41]` **Narrator**: "It had been an exhausting day, j..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Narrator**: "Holsord's skyline was daunting b..." |
| `[48]` | **"Pour some whiskey."** | `[41]` **Narrator**: "It had been an exhausting day, j..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Narrator**: "It felt like the best salve afte..." |
| `[51]` | **""Forgive me, I didn't want to be rude. Long day.""** | `[57]` **Walter Tusk**: ""I merely congratulated you. I s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Walter Tusk**: ""No need to ask for forgiveness."" |
| `[52]` | **""I don't believe I'm being rude. Time is money after all. Isn't that right?""** | `[57]` **Walter Tusk**: ""I merely congratulated you. I s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Narrator**: "Walter took a conspicuous look a..." |
| `[58]` | **"“Do your job properly next time. Do you expect me to keep track of everything myse..."** | `[78]` **Livia Suno**: ""You had a meeting with the Loth..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Livia Suno**: ""You're right, Mr. President. I ..." |
| `[60]` | **""Likewise.""** | `[72]` **Walter Tusk**: ""But we are very much looking fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Walter Tusk**: ""I'd like to build a profitable ..." |
| `[61]` | **""Thank you.""** | `[72]` **Walter Tusk**: ""But we are very much looking fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Walter Tusk**: ""I'd like to build a profitable ..." |
| `[63]` | **""Why is it that you're really here, Mr. Tusk?""** | `[72]` **Walter Tusk**: ""But we are very much looking fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Walter Tusk**: ""I see that you're not very welc..." |
| `[68]` | **""Thank you, Mr. Tusk.""** | `[64]` **Walter Tusk**: ""My business partners and I wish..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Walter Tusk**: ""I had no chance to say this at ..." |
| `[69]` | **""Get to the point, Mr. Tusk. Why are you really here?""** | `[64]` **Walter Tusk**: ""My business partners and I wish..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Walter Tusk**: ""I see that you're not very welc..." |
| `[70]` | **"Nod."** | `[64]` **Walter Tusk**: ""My business partners and I wish..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Walter Tusk**: ""I had no chance to say this at ..." |
| `[75]` | **""I was just about to leave. Maybe we can postpone the meeting?""** | `[78]` **Livia Suno**: ""You had a meeting with the Loth..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Livia Suno**: ""But he's already here, Mr. Pres..." |
| `[84]` | **""The recession was triggered by the market reforms of Alphonso.""** | `[8]` **Walter Tusk**: ""For us it is worrying to see th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Walter Tusk**: ""Which he couldn't finish due to..." |
| `[85]` | **""It is good that we think alike on the matter.""** | `[7]` **Walter Tusk**: ""I'm glad that you have decided ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Walter Tusk**: ""To a closer relationship then!"" |
| `[93]` | **""I took my economic team's advice.""** | `[7]` **Walter Tusk**: ""I'm glad that you have decided ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Walter Tusk**: ""You have talented economists li..." |
| `[95]` | **""I don't mind that we disagree on the economy.""** | `[8]` **Walter Tusk**: ""For us it is worrying to see th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Walter Tusk**: ""Neither do I. But you know how ..." |
| `[100]` | **"Smoke a cigar."** | `[101]` **Walter Tusk**: ""I had these brought from Lespia..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Walter Tusk**: ""Now we are talking. A man who k..." |
| `[103]` | **""You go ahead, I don't want to smoke.""** | `[101]` **Walter Tusk**: ""I had these brought from Lespia..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Narrator**: "Walter grabbed himself a cigar a..." |
| `[105]` | **""I'd rather not have you smoke here.""** | `[101]` **Walter Tusk**: ""I had these brought from Lespia..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Narrator**: "Walter took a suspicious sniff a..."<br>`[102]` **Walter Tusk**: ""Sure. No problem."" |
| `[118]` | **""Our goal was to focus on the needs of the businesses.""** | `[97]` **Walter Tusk**: ""The high-speed rail investment ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Walter Tusk**: ""Glad to hear that because the u..." |
| `[119]` | **""The intention of the administration is to boost the economy.""** | `[15]` **Walter Tusk**: ""The highway investment was a go..."<br>`[97]` **Walter Tusk**: ""The high-speed rail investment ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Walter Tusk**: ""The right intention for sure."" |
| `[120]` | **""The Agnland region was in dire need of investments.""** | `[15]` **Walter Tusk**: ""The highway investment was a go..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Walter Tusk**: ""The most important goal is to d..." |
| `[121]` | **""Our goal was to focus on the needs of the people not businesses.""** | `[15]` **Walter Tusk**: ""The highway investment was a go..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Walter Tusk**: ""I do understand where you are c..." |
| `[126]` | **""The Greater Holsord and Gelsord regions needed better links.""** | `[97]` **Walter Tusk**: ""The high-speed rail investment ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Walter Tusk**: ""Connecting our largest two econ..." |
| `[131]` | **"“If this is what you came here for then we are done here.”"** | `[13]` **Narrator**: "Walter sighed and pulled the che..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Walter Tusk**: "“My goal was to begin a mutually..." |
| `[132]` | **"“Did you think that I was just another corrupt politician?”"** | `[13]` **Narrator**: "Walter sighed and pulled the che..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Walter Tusk**: "“Administrations are built on mu..." |
| `[136]` | **"“Thank you for the visit nonetheless.”"** | `[13]` **Narrator**: "Walter sighed and pulled the che..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Walter Tusk**: "“It was good to share opinions. ..." |
| `[140]` | **"“The administration will maintain a good relationship with the Group.”"** | `[79]` **Walter Tusk**: "“This deal also aligns with the ..."<br>`[80]` **Walter Tusk**: "“This deal will also show to the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Walter Tusk**: "“Great to hear, President."" |
| `[141]` | **"“I am very happy we came to an agreement today, Mr. Tusk.”"** | `[79]` **Walter Tusk**: "“This deal also aligns with the ..."<br>`[80]` **Walter Tusk**: "“This deal will also show to the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Walter Tusk**: "“Likewise, President Rayne. It w..." |
| `[147]` | **"Light a cigarette."** | `[41]` **Narrator**: "It had been an exhausting day, j..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Narrator**: "It helped take my mind off my wo..." |
| `[150]` | **"“Not yet. We both know you can do better than that amount.""** | `[233]` **Walter Tusk**: ""Remind me to visit your office ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Walter Tusk**: "“You are right about that. I'll ..." |
| `[153]` | **"“I accept the offer.” [Take Bribe]"** | `[152]` **Narrator**: "He pulled out another check with..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame....`<br>`Variable["BaseGameSupport.Journal_Turn02_AcceptedTuskBail...`<br>*(+3 skryptów)* | `[155]` **Narrator**: "He grinned and let out a laugh. ..." |
| `[156]` | **"“Did you just try to bribe the President of Sordland? I refuse!”"** | `[233]` **Walter Tusk**: ""Remind me to visit your office ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Narrator**: "Walter sighed and pulled the che..." |
| `[157]` | **"“Be careful, Tusk, or you will have to make your deals in a prison cell.”"** | `[13]` **Narrator**: "Walter sighed and pulled the che..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Walter Tusk**: "“I think we started off on the w..." |
| `[161]` | **"“Until you come back with a better offer, the answer is no.”"** | `[152]` **Narrator**: "He pulled out another check with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Walter Tusk**: "“Very well, then. We will be in ..." |
| `[164]` | **"“Here is my final offer. Do not try to bribe me again or you will have to make you..."** | `[152]` **Narrator**: "He pulled out another check with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Narrator**: "Walter sighed and pulled the che..." |
| `[170]` | **""We had nothing but troubles so far and economy is not the only concern.""** | `[7]` **Walter Tusk**: ""I'm glad that you have decided ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Walter Tusk**: ""Economy is always the biggest c..." |
| `[185]` | **""The intention of the administration is to boost the economy overall.""** | `[201]` **Walter Tusk**: ""What are your overall intention..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Walter Tusk**: ""The most important goal is to d..." |
| `[186]` | **""Our goal is to focus on the needs of the people, not businesses.""** | `[201]` **Walter Tusk**: ""What are your overall intention..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Walter Tusk**: ""I do understand where you are c..." |
| `[187]` | **""Our goal is to focus on the needs of the businesses.""** | `[201]` **Walter Tusk**: ""What are your overall intention..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Walter Tusk**: ""Glad to hear that because the u..." |
| `[206]` | **""I don't want to disclose our intentions to an outsider.""** | `[201]` **Walter Tusk**: ""What are your overall intention..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[207]` **Walter Tusk**: ""That is a fair point but why di..." |
| `[209]` | **""I don't want to disclose our intentions to an outsider.""** | `[15]` **Walter Tusk**: ""The highway investment was a go..."<br>`[97]` **Walter Tusk**: ""The high-speed rail investment ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Walter Tusk**: ""That is a fair point but why di..." |
| `[221]` | **""Spend money to make money they say. Let's see if it holds true.""** | `[220]` **Walter Tusk**: ""I heard that you purchased stoc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Walter Tusk**: ""You will be surprised at what o..." |
| `[222]` | **""With risk comes reward. I expect a very good return on investment.""** | `[220]` **Walter Tusk**: ""I heard that you purchased stoc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[223]` **Walter Tusk**: ""You have a keen eye for business."" |
| `[227]` | **""I figured why not take the chance?""** | `[220]` **Walter Tusk**: ""I heard that you purchased stoc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[228]` **Walter Tusk**: ""It's much worse to live with re..." |
| `[240]` | **""As a matter of fact, I did. What of it?""** | `[235]` **Livia Suno**: ""If I may be so bold, Mr. Presid..." | `Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  or Variable["BaseGame.Relations_Walter_Promise_Company"] == true == true` | *Brak zmian stanu* | `[244]` **Livia Suno**: ""Are you sure it was a good idea..." |
| `[241]` | **""That is absolutely none of your business.""** | `[235]` **Livia Suno**: ""If I may be so bold, Mr. Presid..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Livia Suno**: ""Of course. Sorry to intrude."" |
| `[242]` | **""Of course I didn't. How could you even ask me that?""** | `[235]` **Livia Suno**: ""If I may be so bold, Mr. Presid..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[236]` **Livia Suno**: ""The other girls have told me ab..." |
| `[245]` | **""Don't worry your pretty head about it.""** | `[236]` **Livia Suno**: ""The other girls have told me ab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Narrator**: "She and I took a moment to look ..." |
| `[246]` | **""I most certainly am not.""** | `[236]` **Livia Suno**: ""The other girls have told me ab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Narrator**: "She and I took a moment to look ..." |
| `[247]` | **""A valid concern. But I've made my decision.""** | `[244]` **Livia Suno**: ""Are you sure it was a good idea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Narrator**: "She and I took a moment to look ..." |
| `[248]` | **""Don't worry your pretty head about it.""** | `[244]` **Livia Suno**: ""Are you sure it was a good idea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Narrator**: "She and I took a moment to look ..." |
| `[258]` | **""Do not ever speak about it again. You didn't see anything.""** | `[235]` **Livia Suno**: ""If I may be so bold, Mr. Presid..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Livia Suno**: ""Of course. Sorry to intrude."" |

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
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_Consulate_Condemn == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn02_A_ContractBribe = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn02_A_ContractBribe"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[4]`
Mówca: **Walter Tusk**
> ""We can be close allies. The Group can help you get Sordland out of the recession. Which will be the key problem to solve in your term and could even determine your re-election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Walter Tusk: ""Let's start with a gesture of goodwill. Soon the investm..."*)

### Węzeł `[5]`
Mówca: **Walter Tusk**
> ""If the contract were somehow awarded to Underhall Construction, they would not only work hard and deliver, but also do it on time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Walter Tusk: ""What do you think, Mr. Rayne, wouldn't that be good?""*)

### Węzeł `[6]`
Mówca: **Walter Tusk**
> ""What do you think, Mr. Rayne, wouldn't that be good?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "He put his index finger on the check."*)

### Węzeł `[7]`
Mówca: **Walter Tusk**
> ""I'm glad that you have decided to promote the free market, which is the only thing that can get us out of this mess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player: ""We had nothing but troubles so far and economy is not th..."*)
  - -> `[24]` (*Player: ""The ability of the free-market to evolve is hard to disp..."*)
  - -> `[85]` (*Player: ""It is good that we think alike on the matter.""*)
  - -> `[93]` (*Player: ""I took my economic team's advice.""*)

### Węzeł `[8]`
Mówca: **Walter Tusk**
> ""For us it is worrying to see that you have decided to promote a planned economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: ""The recession was triggered by the market reforms of Alp..."*)
  - -> `[23]` (*Player: ""We need more government control to fix the economy.""*)
  - -> `[95]` (*Player: ""I don't mind that we disagree on the economy.""*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Walter Tusk: ""You are having a good start to the term for sure. Beside..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Walter Tusk: ""The assassination and the troubles between the left and ..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "He closed the door behind him. I gathered my things and prepared to finally head home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Narrator: "As I walked out I noticed Livia still there, covering up ..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "Walter sighed and pulled the check away, putting it in his pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player: "“Did you think that I was just another corrupt politician?”"*)
  - -> `[131]` (*Player: "“If this is what you came here for then we are done here.”"*)
  - -> `[136]` (*Player: "“Thank you for the visit nonetheless.”"*)
  - -> `[157]` (*Player: "“Be careful, Tusk, or you will have to make your deals in..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)

### Węzeł `[15]`
Mówca: **Walter Tusk**
> ""The highway investment was a good call. But high-speed rail would've been better, especially for business logistics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: ""The Agnland region was in dire need of investments.""*)
  - -> `[121]` (*Player: ""Our goal was to focus on the needs of the people not bus..."*)
  - -> `[119]` (*Player: ""The intention of the administration is to boost the econ..."*)
  - -> `[209]` (*Player: ""I don't want to disclose our intentions to an outsider.""*)

### Węzeł `[16]`
Mówca: **Walter Tusk**
> ""Glad to hear that because the unemployment rate won't decrease otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Walter Tusk: ""We can be close allies. The Group can help you get Sordl..."*)

### Węzeł `[17]`
Mówca: **Walter Tusk**
> ""Do you really though?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Walter Tusk: ""Our government is already overburdened with managing sev..."*)

### Węzeł `[18]`
Mówca: **Walter Tusk**
> ""Which he couldn't finish due to being heavily obstructed by the establishment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Walter Tusk: "“Economics needs long-term strategy and mid-term adjustme..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "“Our goal is to unite every stakeholder to improve the economy.”"]** — Mówca: **Player**
> "“Our goal is to unite every stakeholder to improve the economy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Walter Tusk), `[80]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Walter Tusk: "“Exactly, business owners need to unite and support growt..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_Admin_Meeting == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_Admin_Meeting == true"*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_Admin_Meeting == true)"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_Admin_Meeting == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_Admin_Meeting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Walter Tusk: "“Oh I almost forgot. Please say hello to Mr. Koronti for ..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_Admin_Meeting == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_Admin_Meeting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Walter Tusk: "“Have a good evening, President.”"*)

### Węzeł `[23]`
**[WYBÓR GRACZA: ""We need more government control to fix the economy.""]** — Mówca: **Player**
> ""We need more government control to fix the economy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Walter Tusk: ""Do you really though?""*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""The ability of the free-market to evolve is hard to dispute.""]** — Mówca: **Player**
> ""The ability of the free-market to evolve is hard to dispute.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Walter Tusk: ""I couldn't have it said it better. Or could I?""*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Indeed, Mr. Tusk. I am looking forward to our future transactions. [Take Bribe]""]** — Mówca: **Player**
> ""Indeed, Mr. Tusk. I am looking forward to our future transactions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 1"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "“No. I will make my own decision.”"]** — Mówca: **Player**
> "“No. I will make my own decision.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "Walter sighed and pulled the check away, putting it in hi..."*)

### Węzeł `[27]`
Mówca: **Walter Tusk**
> ""The ruined state of the economy in Sordland has influenced everyone. The recession hit all of us hard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "Walter pulled out a box of cigars from his jacket."*)

### Węzeł `[28]`
Mówca: **Walter Tusk**
> ""I'd like to build a profitable relationship between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Walter Tusk: ""That being said, there are some concerns of mine and the..."*)

### Węzeł `[29]`
Mówca: **Walter Tusk**
> ""That being said, there are some concerns of mine and the people I represent...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Walter Tusk: ""...which I would like to take this opportunity to clear ..."*)

### Węzeł `[30]`
Mówca: **Walter Tusk**
> ""...which I would like to take this opportunity to clear up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: ""I'm listening.""*)
  - -> `[33]` (*Player: ""What are these concerns?""*)
  - -> `[34]` (*Player: ""The people you represent?""*)

### Węzeł `[31]`
**[WYBÓR GRACZA: ""Please.""]** — Mówca: **Player**
> ""Please.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Walter Tusk: ""I'd like to build a profitable relationship between us.""*)

### Węzeł `[32]`
**[WYBÓR GRACZA: ""I'm listening.""]** — Mówca: **Player**
> ""I'm listening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Walter Tusk: ""The ruined state of the economy in Sordland has influenc..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: ""What are these concerns?""]** — Mówca: **Player**
> ""What are these concerns?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Walter Tusk: ""The ruined state of the economy in Sordland has influenc..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: ""The people you represent?""]** — Mówca: **Player**
> ""The people you represent?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Walter Tusk: ""You know that I represent the Lotherberg Group, Mr. Pres..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "It was late in the evening."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "The Maroon Palace was finally getting somewhat quiet when..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: ""Don't worry about it.""]** — Mówca: **Player**
> ""Don't worry about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Livia Suno: ""Thank you for your understanding.""*)

### Węzeł `[37]`
Mówca: **Narrator**
> "I eagerly approached my chair and sprawled out on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "It had been an exhausting day, just like every day since ..."*)

### Węzeł `[38]`
Mówca: **Narrator**
> "The Maroon Palace was finally getting somewhat quiet when I returned to my office at the top."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "I eagerly approached my chair and sprawled out on it."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "After a moment, Mr. Tusk swaggered into the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Narrator: "I'd met Sordland's most prominent businessman once or twi..."*)

### Węzeł `[40]`
Mówca: **Walter Tusk**
> ""You know that I represent the Lotherberg Group, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Walter Tusk: ""But of course, these concerns are not limited to them.""*)

### Węzeł `[41]`
Mówca: **Narrator**
> "It had been an exhausting day, just like every day since I took office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player_Italic: "Light a cigarette."*)
  - -> `[48]` (*Player_Italic: "Pour some whiskey."*)
  - -> `[46]` (*Player_Italic: "Lean back and relax."*)
  - -> `[44]` (*Player_Italic: "Prepare to go home."*)

### Węzeł `[42]`
Mówca: **Walter Tusk**
> ""But of course, these concerns are not limited to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Walter Tusk: ""The ruined state of the economy in Sordland has influenc..."*)

### Węzeł `[43]`
Mówca: **Walter Tusk**
> ""Good evening, Mr. President. I am here to congratulate you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "We both sat down."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "Prepare to go home."]** — Mówca: **Player_Italic**
> "I forced myself out of the chair to gather my jacket and briefcase. I really needed to make some time for my family."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "I quickly glanced out the window before leaving."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Walter Tusk: ""I'd like to build a profitable relationship between us.""*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "Lean back and relax."]** — Mówca: **Player_Italic**
> "I stretched out my arms, leaned back in my chair and took a deep breath."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "Holsord's skyline was daunting but beautiful."*)

### Węzeł `[47]`
Mówca: **Walter Tusk**
> ""Cognac. Preferably from before you were born, sweetheart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Livia Suno: ""I-- I'll check the supply room.""*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "Pour some whiskey."]** — Mówca: **Player_Italic**
> "I poured a little whiskey for myself and had a sip."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "It felt like the best salve after a long day of work."*)

### Węzeł `[49]`
Mówca: **Walter Tusk**
> ""I had no chance to say this at the ball with all the panic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Walter Tusk: ""But we are very much looking forward to working with you.""*)

### Węzeł `[50]`
Mówca: **Walter Tusk**
> ""May I continue?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: ""Please.""*)
  - -> `[45]` (*Player_Italic: "Nod."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: ""Forgive me, I didn't want to be rude. Long day.""]** — Mówca: **Player**
> ""Forgive me, I didn't want to be rude. Long day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Walter Tusk: ""No need to ask for forgiveness.""*)

### Węzeł `[52]`
**[WYBÓR GRACZA: ""I don't believe I'm being rude. Time is money after all. Isn't that right?""]** — Mówca: **Player**
> ""I don't believe I'm being rude. Time is money after all. Isn't that right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Walter took a conspicuous look at the diamond-encrusted w..."*)

### Węzeł `[53]`
Mówca: **Walter Tusk**
> ""Yes, that's true. But at the same time, patience and humility are important virtues for a man in your position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Walter Tusk: ""You are the President after all.""*)

### Węzeł `[54]`
Mówca: **Walter Tusk**
> ""No need to ask for forgiveness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Walter Tusk: ""You are the President after all.""*)

### Węzeł `[55]`
Mówca: **Walter Tusk**
> ""You are the President after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Walter Tusk: ""May I continue?""*)

### Węzeł `[56]`
Mówca: **Narrator**
> "I quickly glanced out the window before leaving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "Serge and the guards were outside by the main gate as usual."*)

### Węzeł `[57]`
Mówca: **Walter Tusk**
> ""I merely congratulated you. I see no reason to necessitate rudeness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: ""Forgive me, I didn't want to be rude. Long day.""*)
  - -> `[52]` (*Player: ""I don't believe I'm being rude. Time is money after all...."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "“Do your job properly next time. Do you expect me to keep track of everything myself?""]** — Mówca: **Player**
> ""Do your job properly next time. Do you expect me to keep track of everything myself?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Livia Suno: ""You're right, Mr. President. I probably made a mistake w..."*)

### Węzeł `[59]`
Mówca: **Narrator**
> "Holsord's skyline was daunting but beautiful."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "I glanced downwards out the window and saw Serge and the ..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: ""Likewise.""]** — Mówca: **Player**
> ""Likewise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Walter Tusk: ""I'd like to build a profitable relationship between us.""*)

### Węzeł `[61]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Walter Tusk: ""I'd like to build a profitable relationship between us.""*)

### Węzeł `[62]`
Mówca: **Narrator**
> "It felt like the best salve after a long day of work."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "I glanced downwards out the window and saw Serge and the ..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""Why is it that you're really here, Mr. Tusk?""]** — Mówca: **Player**
> ""Why is it that you're really here, Mr. Tusk?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Walter Tusk: ""I see that you're not very welcoming, President.""*)

### Węzeł `[64]`
Mówca: **Walter Tusk**
> ""My business partners and I wish you a successful term as the leader of our nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: ""Thank you, Mr. Tusk.""*)
  - -> `[70]` (*Player_Italic: "Nod."*)
  - -> `[69]` (*Player: ""Get to the point, Mr. Tusk. Why are you really here?""*)

### Węzeł `[65]`
Mówca: **Narrator**
> "Serge and the guards were outside by the main gate as usual."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "I heard a couple of knocks on the door. My secretary, Liv..."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "I glanced downwards out the window and saw Serge and the guards waiting for me by the main gate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "I heard a couple of knocks on the door. My secretary, Liv..."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "I heard a couple of knocks on the door. My secretary, Livia Suno, entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Livia Suno: ""Mr. President, Mr. Tusk is here to see you.""*)

### Węzeł `[68]`
**[WYBÓR GRACZA: ""Thank you, Mr. Tusk.""]** — Mówca: **Player**
> ""Thank you, Mr. Tusk.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Walter Tusk: ""I had no chance to say this at the ball with all the pan..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: ""Get to the point, Mr. Tusk. Why are you really here?""]** — Mówca: **Player**
> ""Get to the point, Mr. Tusk. Why are you really here?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Walter Tusk: ""I see that you're not very welcoming, President.""*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Walter Tusk: ""I had no chance to say this at the ball with all the pan..."*)

### Węzeł `[71]`
Mówca: **Walter Tusk**
> ""I see that you're not very welcoming, President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Walter Tusk: ""I merely congratulated you. I see no reason to necessita..."*)

### Węzeł `[72]`
Mówca: **Walter Tusk**
> ""But we are very much looking forward to working with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: ""Likewise.""*)
  - -> `[61]` (*Player: ""Thank you.""*)
  - -> `[63]` (*Player: ""Why is it that you're really here, Mr. Tusk?""*)

### Węzeł `[73]`
Mówca: **Livia Suno**
> ""But he's already here, Mr. President. What do you want me to tell him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "After a moment, Mr. Tusk swaggered into the room."*)

### Węzeł `[74]`
Mówca: **Livia Suno**
> ""Mr. President, Mr. Tusk is here to see you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Livia Suno: ""You had a meeting with the Lotherberg spokesman. I'm so ..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA: ""I was just about to leave. Maybe we can postpone the meeting?""]** — Mówca: **Player**
> ""I was just about to leave. Maybe we can postpone the meeting?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Livia Suno: ""But he's already here, Mr. President. What do you want m..."*)

### Węzeł `[76]`
Mówca: **Livia Suno**
> ""Thank you for your understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "After a moment, Mr. Tusk swaggered into the room."*)

### Węzeł `[77]`
Mówca: **Livia Suno**
> ""You're right, Mr. President. I probably made a mistake with my notes. It'll never happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Livia Suno: ""But he's already here, Mr. President. What do you want m..."*)

### Węzeł `[78]`
Mówca: **Livia Suno**
> ""You had a meeting with the Lotherberg spokesman. I'm so sorry for not giving you proper notice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: ""Don't worry about it.""*)
  - -> `[58]` (*Player: "“Do your job properly next time. Do you expect me to keep..."*)
  - -> `[75]` (*Player: ""I was just about to leave. Maybe we can postpone the mee..."*)

### Węzeł `[79]`
Mówca: **Walter Tusk**
> "“This deal also aligns with the free-market strategy your government has adopted besides boosting further investment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: "“Our goal is to unite every stakeholder to improve the ec..."*)
  - -> `[140]` (*Player: "“The administration will maintain a good relationship wit..."*)
  - -> `[141]` (*Player: "“I am very happy we came to an agreement today, Mr. Tusk.”"*)

### Węzeł `[80]`
Mówca: **Walter Tusk**
> "“This deal will also show to the Group that the administration hasn't left the private sector behind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: "“Our goal is to unite every stakeholder to improve the ec..."*)
  - -> `[140]` (*Player: "“The administration will maintain a good relationship wit..."*)
  - -> `[141]` (*Player: "“I am very happy we came to an agreement today, Mr. Tusk.”"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "He pulled his hands back and I took the check."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "He pulled his hands back and I took the check."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: ""The recession was triggered by the market reforms of Alphonso.""]** — Mówca: **Player**
> ""The recession was triggered by the market reforms of Alphonso.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Walter Tusk: ""Which he couldn't finish due to being heavily obstructed..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA: ""It is good that we think alike on the matter.""]** — Mówca: **Player**
> ""It is good that we think alike on the matter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Walter Tusk: ""To a closer relationship then!""*)

### Węzeł `[86]`
Mówca: **Walter Tusk**
> ""I couldn't have it said it better. Or could I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Walter Tusk: ""We really think that there are many elements where our c..."*)

### Węzeł `[87]`
Mówca: **Walter Tusk**
> ""To a closer relationship then!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Walter Tusk: ""One that will bring Sordland out of crippling recession!""*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Highway == true)"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Walter Tusk: ""The highway investment was a good call. But high-speed r..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Highway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Walter Tusk: ""The high-speed rail investment was a great decision, the..."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "He pulled his hands back and I took the check."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Walter Tusk: "“This deal also aligns with the free-market strategy your..."*)

### Węzeł `[92]`
Mówca: **Walter Tusk**
> ""You have talented economists like Mr. Holl in the cabinet, so you made the right choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Walter Tusk: ""There are many other avenues where we could work together.""*)

### Węzeł `[93]`
**[WYBÓR GRACZA: ""I took my economic team's advice.""]** — Mówca: **Player**
> ""I took my economic team's advice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Walter Tusk: ""You have talented economists like Mr. Holl in the cabine..."*)

### Węzeł `[94]`
Mówca: **Walter Tusk**
> ""Neither do I. But you know how much capital Lotherberg represents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Walter Tusk: ""Even though you're pursuing this path, you're going to n..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA: ""I don't mind that we disagree on the economy.""]** — Mówca: **Player**
> ""I don't mind that we disagree on the economy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Walter Tusk: ""Neither do I. But you know how much capital Lotherberg r..."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "He pulled his hands back and I took the check."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Walter Tusk: "“This deal will also show to the Group that the administr..."*)

### Węzeł `[97]`
Mówca: **Walter Tusk**
> ""The high-speed rail investment was a great decision, the business logistics will improve and boost the economy once finished.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: ""The intention of the administration is to boost the econ..."*)
  - -> `[118]` (*Player: ""Our goal was to focus on the needs of the businesses.""*)
  - -> `[126]` (*Player: ""The Greater Holsord and Gelsord regions needed better li..."*)
  - -> `[209]` (*Player: ""I don't want to disclose our intentions to an outsider.""*)

### Węzeł `[98]`
Mówca: **Narrator**
> "We both sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Walter Tusk: ""My business partners and I wish you a successful term as..."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "Walter pulled out a box of cigars from his jacket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Walter Tusk: ""I had these brought from Lespia. The best cigars in the ..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA: "Smoke a cigar."]** — Mówca: **Player_Italic**
> "I grabbed one out of the pack, Walter lit it up with his large engraved lighter."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Walter Tusk: ""Now we are talking. A man who knows pleasure and business.""*)

### Węzeł `[101]`
Mówca: **Walter Tusk**
> ""I had these brought from Lespia. The best cigars in the whole continent. Would you like to try one?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player_Italic: "Smoke a cigar."*)
  - -> `[103]` (*Player: ""You go ahead, I don't want to smoke.""*)
  - -> `[105]` (*Player: ""I'd rather not have you smoke here.""*)

### Węzeł `[102]`
Mówca: **Walter Tusk**
> ""Sure. No problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == ..."*)

### Węzeł `[103]`
**[WYBÓR GRACZA: ""You go ahead, I don't want to smoke.""]** — Mówca: **Player**
> ""You go ahead. I don't want to smoke right now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "Walter grabbed himself a cigar and lit it. He looked out ..."*)

### Węzeł `[104]`
Mówca: **Narrator**
> "Walter grabbed himself a cigar and lit it. He looked out towards the city scenery as he puffed away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == ..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""I'd rather not have you smoke here.""]** — Mówca: **Player**
> ""I'd rather not have you smoke here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_A_ContractBribe_Smoked == true"*)

### Węzeł `[106]`
Mówca: **Walter Tusk**
> ""Now we are talking. A man who knows pleasure and business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Walter grabbed himself a cigar and lit it up as well. We ..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "Walter grabbed himself a cigar and lit it up as well. We looked out at the city scenery as we both puffed away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == ..."*)

### Węzeł `[108]`
Mówca: **Walter Tusk**
> ""You are having a good start to the term for sure. Besides the recent troubles, I mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Walter Tusk: ""I'm glad that you have decided to promote the free marke..."*)

### Węzeł `[109]`
Mówca: **Walter Tusk**
> ""The assassination and the troubles between the left and right are worrying. But the recession is the root cause of these issues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Walter Tusk: ""For us it is worrying to see that you have decided to pr..."*)

### Węzeł `[110]`
Mówca: **Walter Tusk**
> "“Economics needs long-term strategy and mid-term adjustments to provide growth and stability.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Walter Tusk: ""My father once said, you have to finish what you started..."*)

### Węzeł `[111]`
Mówca: **Walter Tusk**
> ""Our government is already overburdened with managing several key industries, with the loss of efficiency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "He leaned forward in the chair."*)

### Węzeł `[112]`
Mówca: **Narrator**
> "He leaned forward in the chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)

### Węzeł `[113]`
Mówca: **Walter Tusk**
> ""Even though you're pursuing this path, you're going to need further market investments to boost the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "He leaned forward in the chair."*)

### Węzeł `[114]`
Mówca: **Walter Tusk**
> ""We really think that there are many elements where our capital could be of help to the government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "He grinned."*)

### Węzeł `[115]`
Mówca: **Walter Tusk**
> ""One that will bring Sordland out of crippling recession!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "He grinned."*)

### Węzeł `[116]`
Mówca: **Walter Tusk**
> ""There are many other avenues where we could work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "He grinned."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "He grinned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: ""Our goal was to focus on the needs of the businesses.""]** — Mówca: **Player**
> ""Our goal was to focus on the needs of the businesses.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Walter Tusk: ""Glad to hear that because the unemployment rate won't de..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA: ""The intention of the administration is to boost the economy.""]** — Mówca: **Player**
> ""The intention of the administration is to boost the economy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Walter Tusk), `[97]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Walter Tusk: ""The right intention for sure.""*)

### Węzeł `[120]`
**[WYBÓR GRACZA: ""The Agnland region was in dire need of investments.""]** — Mówca: **Player**
> ""The Agnland region was in dire need of investments.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Walter Tusk: ""The most important goal is to divert investments where m..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""Our goal was to focus on the needs of the people not businesses.""]** — Mówca: **Player**
> ""Our goal was to focus on the needs of the people, not businesses.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Walter Tusk: ""I do understand where you are coming from but the busine..."*)

### Węzeł `[122]`
Mówca: **Walter Tusk**
> ""The right intention for sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Walter Tusk: ""We can be close allies. The Group can help you get Sordl..."*)

### Węzeł `[123]`
Mówca: **Walter Tusk**
> ""The most important goal is to divert investments where most profits can be made for the treasury.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Walter Tusk: ""We can be close allies. The Group can help you get Sordl..."*)

### Węzeł `[124]`
Mówca: **Walter Tusk**
> ""I do understand where you are coming from but the businesses will help these people get employed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Walter Tusk: ""We can be close allies. The Group can help you get Sordl..."*)

### Węzeł `[125]`
Mówca: **Walter Tusk**
> ""Connecting our largest two economic powerhouses was the right call to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Walter Tusk: ""We can be close allies. The Group can help you get Sordl..."*)

### Węzeł `[126]`
**[WYBÓR GRACZA: ""The Greater Holsord and Gelsord regions needed better links.""]** — Mówca: **Player**
> ""The Greater Holsord and Gelsord regions needed better links.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Walter Tusk: ""Connecting our largest two economic powerhouses was the ..."*)

### Węzeł `[127]`
Mówca: **Narrator**
> "He pulled a check out of his pocket and slid it towards me on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "My personal bank details were listed on it, showing a dep..."*)

### Węzeł `[128]`
Mówca: **Narrator**
> "My personal bank details were listed on it, showing a deposit of 500,000 Sordish Ren ready to be transferred. This amount was equivalent to six months of the presidential budget."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Walter Tusk: ""If the contract were somehow awarded to Underhall Constr..."*)

### Węzeł `[129]`
Mówca: **Walter Tusk**
> "“Oh I almost forgot. Please say hello to Mr. Koronti for me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "He smiled."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "He put his index finger on the check."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "There was a noise by the door. Livia Suno was standing th..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "“If this is what you came here for then we are done here.”"]** — Mówca: **Player**
> "“If this is what you came here for, then we are done here, Mr. Tusk.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Walter Tusk: "“My goal was to begin a mutually beneficial partnership, ..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "“Did you think that I was just another corrupt politician?”"]** — Mówca: **Player**
> "“Did you think that I was just another corrupt politician?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Walter Tusk: "“Administrations are built on mutually beneficial partner..."*)

### Węzeł `[133]`
Mówca: **Walter Tusk**
> "“My goal was to begin a mutually beneficial partnership, but besides that it was good to spend time together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)

### Węzeł `[134]`
Mówca: **Walter Tusk**
> "“Administrations are built on mutually beneficial partnerships. But I do understand where you stand now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)

### Węzeł `[135]`
Mówca: **Walter Tusk**
> "“Have a good evening, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "Walter stood up, grabbed his jacket and made his way towa..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA: "“Thank you for the visit nonetheless.”"]** — Mówca: **Player**
> "“Thank you for the visit nonetheless.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Walter Tusk: "“It was good to share opinions. We will meet again in the..."*)

### Węzeł `[137]`
Mówca: **Walter Tusk**
> "“It was good to share opinions. We will meet again in the future for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "Walter stood up, grabbed his jacket and made his way towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "He closed the door behind him. I gathered my things and p..."*)

### Węzeł `[139]`
Mówca: **Narrator**
> "Walter stood up, grabbed his jacket and shook my hand before making his way towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "He smiled before closing the door and leaving. I gathered..."*)

### Węzeł `[140]`
**[WYBÓR GRACZA: "“The administration will maintain a good relationship with the Group.”"]** — Mówca: **Player**
> "“The administration will maintain a good relationship with the Group.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Walter Tusk), `[80]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Walter Tusk: "“Great to hear, President.""*)

### Węzeł `[141]`
**[WYBÓR GRACZA: "“I am very happy we came to an agreement today, Mr. Tusk.”"]** — Mówca: **Player**
> "“I am very happy we came to an agreement today, Mr. Tusk.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Walter Tusk), `[80]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Walter Tusk: "“Likewise, President Rayne. It was a pleasure doing busin..."*)

### Węzeł `[142]`
Mówca: **Walter Tusk**
> "“Great to hear, President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Walter Tusk: ""Oh, and before I forget, a final token of my gratitude.""*)

### Węzeł `[143]`
Mówca: **Walter Tusk**
> "“Exactly, business owners need to unite and support growth. Thanks to your efforts, we'll see it happen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Walter Tusk: ""Oh, and before I forget, a final token of my gratitude.""*)

### Węzeł `[144]`
Mówca: **Walter Tusk**
> "“Likewise, President Rayne. It was a pleasure doing business with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Walter Tusk: ""Oh, and before I forget, a final token of my gratitude.""*)

### Węzeł `[145]`
Mówca: **Narrator**
> "He smiled before closing the door and leaving. I gathered my things and prepared to finally head home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Narrator: "As I walked out I noticed Livia still there, covering up ..."*)

### Węzeł `[146]`
Mówca: **Walter Tusk**
> "“We will be in touch.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "Walter stood up, grabbed his jacket and shook my hand bef..."*)

### Węzeł `[147]`
**[WYBÓR GRACZA: "Light a cigarette."]** — Mówca: **Player_Italic**
> "I lit a cigarette and smoked it for a while."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "It helped take my mind off my work stress for a minute. T..."*)

### Węzeł `[148]`
Mówca: **Narrator**
> "It helped take my mind off my work stress for a minute. The smoke slowly rose towards the tall ceiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_A_ContractBribe_Smoked = true"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Company = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_Company"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Walter Tusk: "“You don't have to wait long, Mr. Rayne. As a gesture of ..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA: "“Not yet. We both know you can do better than that amount.""]** — Mówca: **Player**
> "“Not yet. We both know you can do better than that amount.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Walter Tusk: "“You are right about that. I'll make this my final offer.”"*)

### Węzeł `[151]`
Mówca: **Walter Tusk**
> "“You are right about that. I'll make this my final offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "He pulled out another check with a smile. This time, 1,00..."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "He pulled out another check with a smile. This time, 1,000,000 Sordish Ren was listed on the piece of paper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player: "“I accept the offer.” [Take Bribe]"*)
  - -> `[161]` (*Player: "“Until you come back with a better offer, the answer is no.”"*)
  - -> `[164]` (*Player: "“Here is my final offer. Do not try to bribe me again or ..."*)

### Węzeł `[153]`
**[WYBÓR GRACZA: "“I accept the offer.” [Take Bribe]"]** — Mówca: **Player**
> "“I accept the offer.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 2"*)

### Węzeł `[154]`
Mówca: **Walter Tusk**
> "“You don't have to wait long, Mr. Rayne. As a gesture of faith in our newfound partnership, I will invite you to a special meeting in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "He grinned and let out a laugh. The check was right betwe..."*)

### Węzeł `[155]`
Mówca: **Narrator**
> "He grinned and let out a laugh. The check was right between his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[156]`
**[WYBÓR GRACZA: "“Did you just try to bribe the President of Sordland? I refuse!”"]** — Mówca: **Player**
> "“Did you just try to bribe the President of Sordland? I refuse!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "Walter sighed and pulled the check away, putting it in hi..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA: "“Be careful, Tusk, or you will have to make your deals in a prison cell.”"]** — Mówca: **Player**
> "“Be careful, Tusk, or you will have to make your deals in a prison cell.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Walter Tusk: "“I think we started off on the wrong foot here.”"*)

### Węzeł `[158]`
Mówca: **Walter Tusk**
> "“My goal was to begin a mutually beneficial partnership. Nothing more, I assure you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Walter Tusk: "“Well, I will excuse myself then. Thank you for your time.”"*)

### Węzeł `[159]`
Mówca: **Walter Tusk**
> "“I think we started off on the wrong foot here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Walter Tusk: "“My goal was to begin a mutually beneficial partnership. ..."*)

### Węzeł `[160]`
Mówca: **Walter Tusk**
> "“Well, I will excuse myself then. Thank you for your time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)

### Węzeł `[161]`
**[WYBÓR GRACZA: "“Until you come back with a better offer, the answer is no.”"]** — Mówca: **Player**
> "“Until you come back with a better offer, the answer is no.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Walter Tusk: "“Very well, then. We will be in touch. I still think this..."*)

### Węzeł `[162]`
Mówca: **Walter Tusk**
> "“Very well, then. We will be in touch. I still think this was a good start for a beneficial partnership in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "Walter sighed and pulled the check away, putting it in hi..."*)

### Węzeł `[163]`
Mówca: **Narrator**
> "Walter sighed and pulled the check away, putting it in his pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)

### Węzeł `[164]`
**[WYBÓR GRACZA: "“Here is my final offer. Do not try to bribe me again or you will have to make your deals in a prison cell.”"]** — Mówca: **Player**
> "“Here is my final offer. Do not try to bribe me again or you will have to make your deals in a prison cell.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "Walter sighed and pulled the check away, putting it in hi..."*)

### Węzeł `[165]`
Mówca: **Narrator**
> "Walter sighed and pulled the check away, putting it in his pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Walter Tusk: "“I think we started off on the wrong foot here.”"*)

### Węzeł `[166]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Walter Tusk: "“Have a good evening, President.”"*)

### Węzeł `[167]`
Mówca: **Narrator**
> "She and I took a moment to look out over the lights of the city before heading to the elevators."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_R_WorkersPartyMarch = true; B..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_Company = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_Company"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "He grinned and let out a laugh. The check was right betwe..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA: ""We had nothing but troubles so far and economy is not the only concern.""]** — Mówca: **Player**
> ""We had nothing but troubles so far and economy is not the only concern.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Walter Tusk: ""Economy is always the biggest concern, President.""*)

### Węzeł `[171]`
Mówca: **Walter Tusk**
> ""Economy is always the biggest concern, President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Walter Tusk: ""Whether we like it or not.""*)

### Węzeł `[172]`
Mówca: **Walter Tusk**
> ""Whether we like it or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "He grinned."*)

### Węzeł `[173]`
Mówca: **Walter Tusk**
> ""Let's start with a gesture of goodwill. Soon the investment project contract will be awarded to one of the three main contenders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "He pulled a check out of his pocket and slid it towards m..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusiness = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Walter Tusk: "“You don't have to wait long, Mr. Rayne. As a gesture of ..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn02_Narbel_SituationReport = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Narbel_SituationReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_R_BludishLynched = true"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_R_WorkersPartyMarch = true;
BaseGameSupport.News_Turn02_LT_ReformDemands = true;
BaseGameSupport.News_Turn02_HP_KibenerSuggestsPower = true;
BaseGameSupport.Report_Turn02_Anrica_LocalPoliceReport = true;
BaseGameSupport.CountryReport_Turn02_Pales_RaisesRiziaCaution = true;
BaseGameSupport.News_Turn02_HP_GasomEngineerSalaries = true;
BaseGameSupport.News_Turn02_LT_LUSNarbelStatement = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_R_WorkersPartyMarch"] = true;
Variable["BaseGameSupport.News_Turn02_LT_ReformDemands"] = true;
Variable["BaseGameSupport.News_Turn02_HP_KibenerSuggestsPower"] = true;
Variable["BaseGameSupport.Report_Turn02_Anrica_LocalPoliceReport"] = true;
Variable["BaseGameSupport.CountryReport_Turn02_Pales_RaisesRiziaCaution"] = true;
Variable["BaseGameSupport.News_Turn02_HP_GasomEngineerSalaries"] = true;
Variable["BaseGameSupport.News_Turn02_LT_LUSNarbelStatement"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_A_ContractBribe = true"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_R_BludishLynched = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_R_BludishLynched"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "It was late in the evening."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_AcceptedTuskCompanyBribe = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_AcceptedTuskCompanyBribe"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Company = true"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_AcceptedTuskCompanyBribe = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_AcceptedTuskCompanyBribe"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_Company = true"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_RejectedTuskCompanyBribe = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_RejectedTuskCompanyBribe"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_Admin_Meeting == true"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_InfrastructureProject_Invest =..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Walter Tusk: ""In my opinion, not investing in our infrastructure was a..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_InfrastructureProject_Invest == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)

### Węzeł `[184]`
Mówca: **Walter Tusk**
> ""In my opinion, not investing in our infrastructure was a missed opportunity. But the government could still work on an economic relief package.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Walter Tusk: ""What are your overall intentions with the economy?""*)

### Węzeł `[185]`
**[WYBÓR GRACZA: ""The intention of the administration is to boost the economy overall.""]** — Mówca: **Player**
> ""The intention of the administration is to boost the economy overall.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Walter Tusk: ""The most important goal is to divert investments where m..."*)

### Węzeł `[186]`
**[WYBÓR GRACZA: ""Our goal is to focus on the needs of the people, not businesses.""]** — Mówca: **Player**
> ""Our goal is to focus on the needs of the people, not businesses.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Walter Tusk: ""I do understand where you are coming from but the busine..."*)

### Węzeł `[187]`
**[WYBÓR GRACZA: ""Our goal is to focus on the needs of the businesses.""]** — Mówca: **Player**
> ""Our goal is to focus on the needs of the businesses.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Walter Tusk: ""Glad to hear that because the unemployment rate won't de..."*)

### Węzeł `[188]`
Mówca: **Walter Tusk**
> ""The most important goal is to divert investments where most profits can be made for the treasury. These are businesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Walter Tusk: ""We can be close allies. The Group can help you get Sordl..."*)

### Węzeł `[189]`
Mówca: **Walter Tusk**
> ""I do understand where you are coming from but the businesses will help these people get employed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Walter Tusk: ""We can be close allies. The Group can help you get Sordl..."*)

### Węzeł `[190]`
Mówca: **Walter Tusk**
> ""Glad to hear that because the unemployment rate won't decrease otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Walter Tusk: ""We can be close allies. The Group can help you get Sordl..."*)

### Węzeł `[191]`
Mówca: **Walter Tusk**
> ""If the package ends up bailing out the businesses that have suffered under this recession, they could provide employment and help the economy recover.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Walter Tusk: ""What do you think, Mr. Rayne, wouldn't that be good?""*)

### Węzeł `[192]`
Mówca: **Walter Tusk**
> ""What do you think, Mr. Rayne, wouldn't that be good?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "He put his index finger on the check."*)

### Węzeł `[193]`
Mówca: **Narrator**
> "He pulled a check out of his pocket and slid it towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "My personal bank details were listed on it, showing a dep..."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "My personal bank details were listed on it, showing a deposit of 500,000 Sordish Ren ready to be transferred. This amount was equivalent to six months of the presidential budget."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Walter Tusk: ""If the package ends up bailing out the businesses that h..."*)

### Węzeł `[195]`
Mówca: **Walter Tusk**
> ""Let's start with a gesture of goodwill. Soon the economic relief package will be presented and it will either bail out businesses or provide checks for people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "He pulled a check out of his pocket and slid it towards me."*)

### Węzeł `[196]`
Mówca: **Walter Tusk**
> ""We can be close allies. The Group can help you get Sordland out of the recession. Which will be the key problem to solve in your term and could even determine to your re-election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Walter Tusk: ""Let's start with a gesture of goodwill. Soon the economi..."*)

### Węzeł `[197]`
Mówca: **Narrator**
> "He put his index finger on the check."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "There was a noise by the door. Livia Suno was standing th..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_InfrastructureProject_Invest =..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_AcceptedTuskBailBribe = true"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_InfrastructureProject_Invest == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_AcceptedTuskCompanyBribe =..."*)

### Węzeł `[201]`
Mówca: **Walter Tusk**
> ""What are your overall intentions with the economy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player: ""The intention of the administration is to boost the econ..."*)
  - -> `[186]` (*Player: ""Our goal is to focus on the needs of the people, not bus..."*)
  - -> `[187]` (*Player: ""Our goal is to focus on the needs of the businesses.""*)
  - -> `[206]` (*Player: ""I don't want to disclose our intentions to an outsider.""*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusiness = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "He grinned and let out a laugh. The check was right betwe..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_InfrastructureProject_Invest =..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_AcceptedTuskBailBribe = true"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_InfrastructureProject_Invest == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_AcceptedTuskCompanyBribe =..."*)

### Węzeł `[206]`
**[WYBÓR GRACZA: ""I don't want to disclose our intentions to an outsider.""]** — Mówca: **Player**
> ""I don't want to disclose our intentions to an outsider.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Walter Tusk: ""That is a fair point but why distance yourself from pote..."*)

### Węzeł `[207]`
Mówca: **Walter Tusk**
> ""That is a fair point but why distance yourself from potential friends here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Walter Tusk: ""We can be close allies. The Group can help you get Sordl..."*)

### Węzeł `[208]`
Mówca: **Walter Tusk**
> ""That is a fair point but why distance yourself from potential friends here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Walter Tusk: ""We can be close allies. The Group can help you get Sordl..."*)

### Węzeł `[209]`
**[WYBÓR GRACZA: ""I don't want to disclose our intentions to an outsider.""]** — Mówca: **Player**
> ""I don't want to disclose our intentions to an outsider.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Walter Tusk), `[97]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Walter Tusk: ""That is a fair point but why distance yourself from pote..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_AcceptedTuskBailBribe = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_AcceptedTuskBailBribe"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusiness = true"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_AcceptedTuskBailBribe = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_AcceptedTuskBailBribe"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusiness = true"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_InfrastructureProject_Invest =..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_RejectedTuskBailBribe = true"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_InfrastructureProject_Invest == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_RejectedTuskCompanyBribe =..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_RejectedTuskBailBribe = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_RejectedTuskBailBribe"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_Admin_Meeting == true"*)

### Węzeł `[216]`
Mówca: **Walter Tusk**
> ""My father once said, you have to finish what you started. He is right. The system collapsed because Alphonso didn't finish the reforms he started. And look at what happened to him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "He leaned forward in the chair."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == ..."*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_PersonalInvestment_DontSpend =..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Walter Tusk: ""I heard that you purchased stock from Armadine Industrie..."*)

### Węzeł `[220]`
Mówca: **Walter Tusk**
> ""I heard that you purchased stock from Armadine Industries in Arcasia. Smart buy. They are developing new gadgets that are going to be profitable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Player: ""With risk comes reward. I expect a very good return on i..."*)
  - -> `[221]` (*Player: ""Spend money to make money they say. Let's see if it hold..."*)
  - -> `[227]` (*Player: ""I figured why not take the chance?""*)

### Węzeł `[221]`
**[WYBÓR GRACZA: ""Spend money to make money they say. Let's see if it holds true.""]** — Mówca: **Player**
> ""Spend money to make money they say. Let's see if it holds true.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Walter Tusk: ""You will be surprised at what one can achieve given the ..."*)

### Węzeł `[222]`
**[WYBÓR GRACZA: ""With risk comes reward. I expect a very good return on investment.""]** — Mówca: **Player**
> ""With risk comes reward. I expect a very good return on investment.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Walter Tusk: ""You have a keen eye for business.""*)

### Węzeł `[223]`
Mówca: **Walter Tusk**
> ""You have a keen eye for business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Walter Tusk: ""I will buy a couple of thousand of shares too to expand ..."*)

### Węzeł `[224]`
Mówca: **Walter Tusk**
> ""You will be surprised at what one can achieve given the resources in capitalism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Walter Tusk: ""I will buy a couple of thousand of shares too to expand ..."*)

### Węzeł `[225]`
Mówca: **Walter Tusk**
> ""I will buy a couple of thousand of shares too to expand my portfolio. Hope the investments pay off for both of us, President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "His eyes wandered away for a moment."*)

### Węzeł `[226]`
Mówca: **Narrator**
> "His eyes wandered away for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[227]`
**[WYBÓR GRACZA: ""I figured why not take the chance?""]** — Mówca: **Player**
> ""I figured why not take the chance?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Walter Tusk: ""It's much worse to live with regret and what ifs.""*)

### Węzeł `[228]`
Mówca: **Walter Tusk**
> ""It's much worse to live with regret and what ifs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Walter Tusk: ""I will buy a couple of thousand of shares too to expand ..."*)

### Węzeł `[229]`
Mówca: **Livia Suno**
> ""Anything to drink, Mr. Tusk? Water, whiskey?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Walter Tusk: ""Cognac. Preferably from before you were born, sweetheart.""*)

### Węzeł `[230]`
Mówca: **Narrator**
> "There was a noise by the door. Livia Suno was standing there, holding a tray with a bottle and two glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Livia Suno: ""I'm so sorry, Mr. Tusk, but all I could find was a 1942 ..."*)

### Węzeł `[231]`
Mówca: **Livia Suno**
> ""I'm so sorry, Mr. Tusk, but all I could find was a 1942 Sevigny. I hope that's acceptable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "She quickly put the tray on my desk and walked out. Tusk ..."*)

### Węzeł `[232]`
Mówca: **Narrator**
> "She quickly put the tray on my desk and walked out. Tusk eyed her as she left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Walter Tusk: ""Remind me to visit your office more often. Now, where we..."*)

### Węzeł `[233]`
Mówca: **Walter Tusk**
> ""Remind me to visit your office more often. Now, where were we? Do we have a deal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: ""Indeed, Mr. Tusk. I am looking forward to our future tra..."*)
  - -> `[150]` (*Player: "“Not yet. We both know you can do better than that amount.""*)
  - -> `[26]` (*Player: "“No. I will make my own decision.”"*)
  - -> `[156]` (*Player: "“Did you just try to bribe the President of Sordland? I r..."*)

### Węzeł `[234]`
Mówca: **Narrator**
> "As I walked out I noticed Livia still there, covering up her typewriter for the evening."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Livia Suno: ""If I may be so bold, Mr. President... did you accept his..."*)

### Węzeł `[235]`
Mówca: **Livia Suno**
> ""If I may be so bold, Mr. President... did you accept his offer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusiness == true ||..."*)
  - -> `[241]` (*Player: ""That is absolutely none of your business.""*)
  - -> `[242]` (*Player: ""Of course I didn't. How could you even ask me that?""*)
  - -> `[258]` (*Player: ""Do not ever speak about it again. You didn't see anything.""*)

### Węzeł `[236]`
Mówca: **Livia Suno**
> ""The other girls have told me about all kinds of dealings that went on during the Alphonso administration. I wasn't sure if you were that kind of president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player: ""I most certainly am not.""*)
  - -> `[245]` (*Player: ""Don't worry your pretty head about it.""*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusiness == true ||BaseGame.Relations_Walter_Promise_Company == true == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusiness == true ||..."*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_BailBusiness == true ..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusiness == true ||BaseGame.Relations_Walter_Promise_Company == true == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  or Variable["BaseGame.Relations_Walter_Promise_Company"] == true == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Player: ""As a matter of fact, I did. What of it?""*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_BailBusiness == true ||BaseGame.Relations_Walter_Promise_Company == true == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  or Variable["BaseGame.Relations_Walter_Promise_Company"] == true == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[240]`
**[WYBÓR GRACZA: ""As a matter of fact, I did. What of it?""]** — Mówca: **Player**
> ""As a matter of fact, I did. What of it?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  or Variable["BaseGame.Relations_Walter_Promise_Company"] == true == true`
- **Kontekst wejściowy (poprzednik):** `[235]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Livia Suno: ""Are you sure it was a good idea? You've just given him l..."*)

### Węzeł `[241]`
**[WYBÓR GRACZA: ""That is absolutely none of your business.""]** — Mówca: **Player**
> ""That is absolutely none of your business.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[235]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Livia Suno: ""Of course. Sorry to intrude.""*)

### Węzeł `[242]`
**[WYBÓR GRACZA: ""Of course I didn't. How could you even ask me that?""]** — Mówca: **Player**
> ""Of course I didn't. How could you even ask me that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[235]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Livia Suno: ""The other girls have told me about all kinds of dealings..."*)

### Węzeł `[243]`
Mówca: **Livia Suno**
> ""Of course. Sorry to intrude.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "She and I took a moment to look out over the lights of th..."*)

### Węzeł `[244]`
Mówca: **Livia Suno**
> ""Are you sure it was a good idea? You've just given him leverage over you that he can use for the rest of your time in office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player: ""A valid concern. But I've made my decision.""*)
  - -> `[248]` (*Player: ""Don't worry your pretty head about it.""*)

### Węzeł `[245]`
**[WYBÓR GRACZA: ""Don't worry your pretty head about it.""]** — Mówca: **Player**
> ""Don't worry your pretty head about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[236]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "She and I took a moment to look out over the lights of th..."*)

### Węzeł `[246]`
**[WYBÓR GRACZA: ""I most certainly am not.""]** — Mówca: **Player**
> ""I most certainly am not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[236]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "She and I took a moment to look out over the lights of th..."*)

### Węzeł `[247]`
**[WYBÓR GRACZA: ""A valid concern. But I've made my decision.""]** — Mówca: **Player**
> ""A valid concern. But I've made my decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "She and I took a moment to look out over the lights of th..."*)

### Węzeł `[248]`
**[WYBÓR GRACZA: ""Don't worry your pretty head about it.""]** — Mówca: **Player**
> ""Don't worry your pretty head about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "She and I took a moment to look out over the lights of th..."*)

### Węzeł `[249]`
Mówca: **Livia Suno**
> ""I-- I'll check the supply room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Narrator: "Livia backed out of the office, shooting me an apologetic..."*)

### Węzeł `[250]`
Mówca: **Narrator**
> "Livia backed out of the office, shooting me an apologetic look as she did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Narrator: "Walter hung up his hat, which I could see was lined with ..."*)

### Węzeł `[251]`
Mówca: **Narrator**
> "Walter hung up his hat, which I could see was lined with mink. He fixed me with a long, hard stare, then broke into a toothy grin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Walter Tusk: ""Good evening, Mr. President. I am here to congratulate y..."*)

### Węzeł `[252]`
Mówca: **Narrator**
> "Walter took a conspicuous look at the diamond-encrusted watch on his wrist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Walter Tusk: ""Yes, that's true. But at the same time, patience and hum..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_A_ContractBribe_Smoked = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn01_A_ContractBribe_Smoked"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "I glanced downwards out the window and saw Serge and the ..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_A_ContractBribe_Smoked == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn01_A_ContractBribe_Smoked == true"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn01_A_ContractBribe_Smoked == true)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn01_A_ContractBribe_Smoked == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn01_A_ContractBribe_Smoked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Narrator: "Walter took a suspicious sniff at the lingering smoke in ..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn01_A_ContractBribe_Smoked == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn01_A_ContractBribe_Smoked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Walter Tusk: ""Sure. No problem.""*)

### Węzeł `[257]`
Mówca: **Narrator**
> "Walter took a suspicious sniff at the lingering smoke in the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Walter Tusk: ""Sure. No problem.""*)

### Węzeł `[258]`
**[WYBÓR GRACZA: ""Do not ever speak about it again. You didn't see anything.""]** — Mówca: **Player**
> ""Do not ever speak about it again. You didn't see anything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[235]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Livia Suno: ""Of course. Sorry to intrude.""*)

### Węzeł `[259]`
Mówca: **Narrator**
> "I'd met Sordland's most prominent businessman once or twice, but never alone. He had large jowls, blindingly shiny shoes and the air of someone who was used to getting his way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Livia Suno: ""Anything to drink, Mr. Tusk? Water, whiskey?""*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_FPnT_Consulate_Condemn == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_Consulate_Condemn == true"*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_FPnT_Consulate_Condemn == true)"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_FPnT_Consulate_Condemn == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn02_Narbel_SituationReport = true"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_FPnT_Consulate_Condemn == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn02_Narbel_TenseSituationReport..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn02_Narbel_TenseSituationReport = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Narbel_TenseSituationReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_R_BludishLynched = true"*)

### Węzeł `[264]`
Mówca: **Walter Tusk**
> ""Oh, and before I forget, a final token of my gratitude.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "Walter pulls a box of cigars out of his pocket. The label..."*)

### Węzeł `[265]`
Mówca: **Narrator**
> "Walter pulls a box of cigars out of his pocket. The label read: "Varo Benvinoto"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_CigarBox");"*)

### Węzeł `[266]`
Mówca: **Walter Tusk**
> ""Some of Lespia's finest, made by true craftsmen in the fabled city of San Verlon. You should visit someday, should the opportunity arise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Walter Tusk: "“We will be in touch.”"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_CigarBox");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_CigarBox");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Walter Tusk: ""Some of Lespia's finest, made by true craftsmen in the f..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
