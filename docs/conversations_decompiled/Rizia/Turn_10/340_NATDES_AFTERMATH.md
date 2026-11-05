# Rizia/Turn 10/NATDES AFTERMATH

- **ID konwersacji:** `340`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/340_NATDES_AFTERMATH.md`
- **Liczba węzłów dialogowych:** 337
- **Liczba wyborów gracza:** 42

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[70]** Laurento Esquibel
- **[73]** Lucita Azaro
- **[79]** Vina Toras
- **[80]** Elena Werner
- **[81]** Titus Gordion
- **[83]** Taddeus Azaro
- **[87]** Sal Ignacius
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_Arrested`
- `RiziaDLC.Adarfo_Executed`
- `RiziaDLC.Council_GrandVizier_Hugo`
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.Council_Security_Taddeus`
- `RiziaDLC.HouseOfDelegates_Abolished`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.NatDes_Appease`
- `RiziaDLC.NatDes_Oppress`
- `RiziaDLC.NatDes_UniteHousesAgainst_Azaro`
- `RiziaDLC.NatDes_UniteHousesAgainst_Sazon`
- `RiziaDLC.NatDes_UniteHousesAgainst_Toras`
- `RiziaDLC.Pales_PromisedToHouseAzaro`
- `RiziaDLC.Pales_Rizia_Unification`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PipelineNatDes_DeploySO`
- `RiziaDLC.PipelineNatDes_DeployWG`
- `RiziaDLC.PipelineNatDes_PipelineDontRepair`
- `RiziaDLC.Policy_Diplomacy_GRACEMember`
- `RiziaDLC.Policy_Diplomacy_Intermerkopum`
- `RiziaDLC.PromiseToAbdicate`
- `RiziaDLC.Promised_Succession_Son_RespectTradition`
- `RiziaDLC.Reform_Movement_Leader_Adarfo`
- `RiziaDLC.Religious_WruhecsGuardians_Sal`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Revolutionary_Pipeline_Sabotage`
- `RiziaDLC.Rusty_LoanAmount`
- `RiziaDLC.Sal_Arrested`
- `RiziaDLC.Situation_Economy_NewBusiness_Collapse`
- `RiziaDLC.Situation_Economy_NewBusiness_Reduction`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLCIsolated.Turn09_Pipline_NatDes_AppeaseOptions`
- `RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Adarfo_Arrested`
- `RiziaDLC.PromiseToAbdicate`
- `RiziaDLC.Turn10_CouncilGoodbyes_NoPromiseToAbdicate`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[338] Rizia/Turn 10/CouncilMeeting** (../Turn_10/338_CouncilMeeting.md), Węzeł `[120]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[28]` | **""God be praised!""** | `[23]` **Lucita Azaro**: ""I'm pleased to report that the ..."<br>`[25]` **Taddeus Azaro**: ""I'm pleased to report that the ..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[36]` **Narrator**: "My councilor nodded." |
| `[32]` | **""Are you quite sure?""** | `[23]` **Lucita Azaro**: ""I'm pleased to report that the ..."<br>`[25]` **Taddeus Azaro**: ""I'm pleased to report that the ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Narrator**: "My councilor nodded." |
| `[33]` | **""I want a full report.""** | `[23]` **Lucita Azaro**: ""I'm pleased to report that the ..."<br>`[25]` **Taddeus Azaro**: ""I'm pleased to report that the ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Narrator**: "My councilor handed me a copy of..." |
| `[34]` | **""What do you want, a medal? This is literally the least I expect from you.""** | `[23]` **Lucita Azaro**: ""I'm pleased to report that the ..."<br>`[25]` **Taddeus Azaro**: ""I'm pleased to report that the ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Narrator**: "My councilor frowned apologetica..." |
| `[35]` | **""Amazing news, Councilor. The nightmare is over.""** | `[23]` **Lucita Azaro**: ""I'm pleased to report that the ..."<br>`[25]` **Taddeus Azaro**: ""I'm pleased to report that the ..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[36]` **Narrator**: "My councilor nodded." |
| `[66]` | **""Sacrifices were made. But it was all worth it.""** | `[126]` **Lucita Azaro**: ""I admit I was skeptical that th..."<br>`[127]` **Taddeus Azaro**: ""I admit I was skeptical that th..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Hugo Toras**: ""Indeed it was, Your Majesty.""<br>`[81]` **Elena Werner**: ""Sacrifices indeed, Your Majesty."" |
| `[67]` | **""Now we can focus our attention where it belongs. On defeating Pales.""** | `[126]` **Lucita Azaro**: ""I admit I was skeptical that th..."<br>`[127]` **Taddeus Azaro**: ""I admit I was skeptical that th..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[76]` **Lucita Azaro**: ""Yes, you'll receive an update o..." |
| `[71]` | **""I must admit, I didn't think House Sazon had it in them.""** | `[126]` **Lucita Azaro**: ""I admit I was skeptical that th..."<br>`[127]` **Taddeus Azaro**: ""I admit I was skeptical that th..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true` | *Brak zmian stanu* | `[85]` **Narrator**: "I thought I saw disgust flash ac..."<br>`[86]` **Laurento Esquibel**: ""No. Nor did I."" |
| `[75]` | **""As in 1926, we must now turn our attention to restoring our citizens' trust in us.""** | `[126]` **Lucita Azaro**: ""I admit I was skeptical that th..."<br>`[127]` **Taddeus Azaro**: ""I admit I was skeptical that th..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Elena Werner**: ""We are already on our way to do..."<br>`[91]` **Elena Werner**: ""Yes, we can expect a rocky few ..." |
| `[92]` | **""This must never be allowed to happen again.""** | `[126]` **Lucita Azaro**: ""I admit I was skeptical that th..."<br>`[127]` **Taddeus Azaro**: ""I admit I was skeptical that th..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Elena Werner**: ""Agreed. It was difficult enough..." |
| `[193]` | **""Concerning news. But at least we're now in the position to begin working on our r..."** | `[180]` **Elena Werner**: ""And we remain in debt to Rizian..."<br>`[172]` **Elena Werner**: ""Our energy reserves are still r..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true`<br>`(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false` | *Brak zmian stanu* | `[201]` **Laurento Esquibel**: ""And work we will, Your Majesty."" |
| `[194]` | **""With the anti-monarchists out of the way, our economy will soar even higher than ..."** | `[180]` **Elena Werner**: ""And we remain in debt to Rizian..."<br>`[172]` **Elena Werner**: ""Our energy reserves are still r..."<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true) == false`<br>`(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false` | *Brak zmian stanu* | `[200]` **Laurento Esquibel**: ""I have no doubt it will, Your M..." |
| `[195]` | **""We handled the unrest. We can handle Rusty.""** | `[180]` **Elena Werner**: ""And we remain in debt to Rizian..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[202]` **Laurento Esquibel**: ""I am sure we can."" |
| `[196]` | **""There is still much work to be done. We've got to address the root cause of the u..."** | `[180]` **Elena Werner**: ""And we remain in debt to Rizian..."<br>`[172]` **Elena Werner**: ""Our energy reserves are still r..."<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false` | *Brak zmian stanu* | `[199]` **Laurento Esquibel**: ""Very prudent thinking, Your Maj..." |
| `[197]` | **""We should take some time to rest on our laurels. We defeated a revolution, after ..."** | `[180]` **Elena Werner**: ""And we remain in debt to Rizian..."<br>`[172]` **Elena Werner**: ""Our energy reserves are still r..."<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false` | *Brak zmian stanu* | `[198]` **Laurento Esquibel**: ""Indeed. No easy feat."" |
| `[221]` | **""Wise words, Grand Wiseman.""** | `[220]` **Sal Ignacius**: ""Our nation remains greatly divi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Narrator**: "I looked at my daughter. She sti..."<br>`[277]` **Narrator**: "Hugo cleared his throat."<br>*(oraz 1 innych odgałęzień)* |
| `[222]` | **""Halaita.""** | `[220]` **Sal Ignacius**: ""Our nation remains greatly divi..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[232]` **Narrator**: "I looked at my daughter. She sti..."<br>`[277]` **Narrator**: "Hugo cleared his throat."<br>*(oraz 1 innych odgałęzień)* |
| `[226]` | **""Nice try, but no. Faith still divides Rizia more than it unifies us.""** | `[220]` **Sal Ignacius**: ""Our nation remains greatly divi..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[232]` **Narrator**: "I looked at my daughter. She sti..."<br>`[277]` **Narrator**: "Hugo cleared his throat."<br>*(oraz 1 innych odgałęzień)* |
| `[227]` | **""Wruhec's Guardians will be integral to our recovery efforts. I want them to focus..."** | `[220]` **Sal Ignacius**: ""Our nation remains greatly divi..." | `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true` | *Brak zmian stanu* | `[232]` **Narrator**: "I looked at my daughter. She sti..."<br>`[277]` **Narrator**: "Hugo cleared his throat."<br>*(oraz 1 innych odgałęzień)* |
| `[231]` | **""The power of faith is second to the power of the Crown, Sal. Remember that.""** | `[220]` **Sal Ignacius**: ""Our nation remains greatly divi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Narrator**: "I looked at my daughter. She sti..."<br>`[277]` **Narrator**: "Hugo cleared his throat."<br>*(oraz 1 innych odgałęzień)* |
| `[242]` | **""Shall we begin?""** | `[3]` **Narrator**: "I looked around at my advisors. ..." | `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false` | *Brak zmian stanu* | `[19]` **Narrator**: "Lucita had a proud smile on her ..."<br>`[20]` **Narrator**: "Taddeus wore a proud expression ..."<br>*(oraz 1 innych odgałęzień)* |
| `[243]` | **""All right. What is this meeting about?""** | `[3]` **Narrator**: "I looked around at my advisors. ..." | `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false` | *Brak zmian stanu* | `[19]` **Narrator**: "Lucita had a proud smile on her ..."<br>`[20]` **Narrator**: "Taddeus wore a proud expression ..."<br>*(oraz 1 innych odgałęzień)* |
| `[244]` | **""Thank you all for joining me here today. I hope you've brought good news.""** | `[3]` **Narrator**: "I looked around at my advisors. ..." | `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false` | *Brak zmian stanu* | `[19]` **Narrator**: "Lucita had a proud smile on her ..."<br>`[20]` **Narrator**: "Taddeus wore a proud expression ..."<br>*(oraz 1 innych odgałęzień)* |
| `[245]` | **""Vina... I know mistakes were made. But I'll do better from now on.""** | `[232]` **Narrator**: "I looked at my daughter. She sti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[255]` **Vina Toras**: ""I'm pleased that the Crown and ..."<br>`[257]` **Vina Toras**: ""So much senseless bloodshed..."" |
| `[246]` | **""Cat got your tongue, Your Highness?""** | `[232]` **Narrator**: "I looked at my daughter. She sti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Narrator**: "She sighed and shook her head." |
| `[247]` | **""What does your husband have to say for himself? He's the reason all this happened..."** | `[232]` **Narrator**: "I looked at my daughter. She sti..." | `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true` | *Brak zmian stanu* | `[260]` **Vina Toras**: ""What? Father, that's not true a..." |
| `[251]` | **""If no one else has anything to say, we'll conclude the meeting.""** | `[232]` **Narrator**: "I looked at my daughter. She sti..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Narrator**: "Elena nodded sagely.." |
| `[261]` | **""You don't know that. Who's to say the people would have accepted his watered-down..."** | `[256]` **Vina Toras**: ""But if you'd only been willing ..."<br>`[258]` **Vina Toras**: ""If you'd only been willing to w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Vina Toras**: ""But you never even tried."" |
| `[262]` | **""Maybe. But we must look to the future now.""** | `[256]` **Vina Toras**: ""But if you'd only been willing ..."<br>`[258]` **Vina Toras**: ""If you'd only been willing to w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Narrator**: "Vina didn't respond. She gave a ..." |
| `[266]` | **""Now that Adarfo's out of the picture, I can see myself collaborating with the RPP.""** | `[256]` **Vina Toras**: ""But if you'd only been willing ..."<br>`[258]` **Vina Toras**: ""If you'd only been willing to w..." | `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`<br>`Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false` | *Brak zmian stanu* | `[275]` **Vina Toras**: ""Well... good. That's a start."" |
| `[267]` | **""I might still cooperate with the RPP in the future. Who knows?""** | `[256]` **Vina Toras**: ""But if you'd only been willing ..."<br>`[258]` **Vina Toras**: ""If you'd only been willing to w..." | `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`<br>`Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false` | *Brak zmian stanu* | `[275]` **Vina Toras**: ""Well... good. That's a start."" |
| `[271]` | **""Your sweetheart's no saint. He was stirring up trouble from day one.""** | `[256]` **Vina Toras**: ""But if you'd only been willing ..."<br>`[258]` **Vina Toras**: ""If you'd only been willing to w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Narrator**: "Vina didn't respond." |
| `[295]` | **""Glovurius axa Rizia.""** | `[293]` **Lucita Azaro**: ""Glovurius axa Rizia.""<br>`[276]` **Elena Werner**: ""I'm sure we're all eager to put..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false` | *Brak zmian stanu* | `[303]` **Narrator**: "One by one, my councilors bowed ..." |
| `[296]` | **""Long live the monarchy.""** | `[293]` **Lucita Azaro**: ""Glovurius axa Rizia.""<br>`[276]` **Elena Werner**: ""I'm sure we're all eager to put..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false` | *Brak zmian stanu* | `[303]` **Narrator**: "One by one, my councilors bowed ..." |
| `[297]` | **""Thank you, everyone.""** | `[293]` **Lucita Azaro**: ""Glovurius axa Rizia.""<br>`[276]` **Elena Werner**: ""I'm sure we're all eager to put..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false` | *Brak zmian stanu* | `[303]` **Narrator**: "One by one, my councilors bowed ..." |
| `[302]` | **""God be with you all.""** | `[293]` **Lucita Azaro**: ""Glovurius axa Rizia.""<br>`[276]` **Elena Werner**: ""I'm sure we're all eager to put..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true`<br>`(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false` | *Brak zmian stanu* | `[303]` **Narrator**: "One by one, my councilors bowed ..." |
| `[304]` | **""Don't get too cocky. We've still got a war to win.""** | `[293]` **Lucita Azaro**: ""Glovurius axa Rizia.""<br>`[276]` **Elena Werner**: ""I'm sure we're all eager to put..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Pales_War"] == true`<br>`(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false` | *Brak zmian stanu* | `[303]` **Narrator**: "One by one, my councilors bowed ..." |
| `[314]` | **""I have not forgotten, either. When the time comes, I will inform the nation that ..."** | `[313]` **Hugo Toras**: ""I trust it will not take too lo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[335]` **Hugo Toras**: ""Thank you."" |
| `[315]` | **""I must see the war to an end. After that, I will fulfill my promise.""** | `[313]` **Hugo Toras**: ""I trust it will not take too lo..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[334]` **Hugo Toras**: ""I understand. I would not ask y..." |
| `[319]` | **""Possibly even sooner. I don't have much to wrap up.""** | `[313]` **Hugo Toras**: ""I trust it will not take too lo..." | `(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[333]` **Hugo Toras**: ""Even better, then."" |
| `[320]` | **""Are you that hungry to take my place? Don't forget I have a daughter.""** | `[313]` **Hugo Toras**: ""I trust it will not take too lo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[327]` **Hugo Toras**: ""I did not mean to insinuate tha..." |
| `[321]` | **""My 'promise' counts for nothing. You should never have tried to demand my abdicat..."** | `[313]` **Hugo Toras**: ""I trust it will not take too lo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[322]` **Narrator**: "Shock and pain mixed in his eyes." |

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
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Taddeus Azaro: ""Wruhec's Guardians were especially helpful in neutralizi..."*)

### Węzeł `[3]`
Mówca: **Narrator**
> "I looked around at my advisors. Like me, they hadn't been getting much sleep lately."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Sal_Arrested == false)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "AddConversant("Sal Ignacius");"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Sal_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true"*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Sal Ignacius rushed into the room just as the clock struck four, bowing profusely in apology."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Sal Ignacius rushed into the room just as the clock struc..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == t..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "Vina followed him in and wordlessly took her seat."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "I looked around at my advisors. Like me, they hadn't been..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "Vina followed him in and wordlessly took her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "I looked around at my advisors. Like me, they hadn't been..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "Lucita had a proud smile on her face."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "Taddeus wore a proud expression on his face."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Titus wore a proud smile on his face."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "Lucita had a proud smile on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucita Azaro: ""Your Majesty.""*)

### Węzeł `[20]`
Mówca: **Narrator**
> "Taddeus wore a proud expression on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Taddeus Azaro: ""Your Majesty.""*)

### Węzeł `[21]`
Mówca: **Narrator**
> "Titus wore a proud smile on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Titus Gordion: ""Your Majesty.""*)

### Węzeł `[22]`
Mówca: **Lucita Azaro**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Lucita Azaro: ""I'm pleased to report that the unrest that has plagued o..."*)

### Węzeł `[23]`
Mówca: **Lucita Azaro**
> ""I'm pleased to report that the unrest that has plagued our kingdom for so long is finally coming to an end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[32]` (*Player_Romus: ""Are you quite sure?""*)
  - -> `[33]` (*Player_Romus: ""I want a full report.""*)
  - -> `[34]` (*Player_Romus: ""What do you want, a medal? This is literally the least I..."*)

### Węzeł `[24]`
Mówca: **Taddeus Azaro**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Taddeus Azaro: ""I'm pleased to report that the unrest that has plagued o..."*)

### Węzeł `[25]`
Mówca: **Taddeus Azaro**
> ""I'm pleased to report that the unrest that has plagued our kingdom for so long is finally coming to an end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[32]` (*Player_Romus: ""Are you quite sure?""*)
  - -> `[33]` (*Player_Romus: ""I want a full report.""*)
  - -> `[34]` (*Player_Romus: ""What do you want, a medal? This is literally the least I..."*)

### Węzeł `[26]`
Mówca: **Titus Gordion**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Titus Gordion: ""I'm pleased to report that the unrest that has plagued o..."*)

### Węzeł `[27]`
Mówca: **Titus Gordion**
> ""I'm pleased to report that the unrest that has plagued our kingdom for so long is finally coming to an end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[32]` (*Player_Romus: ""Are you quite sure?""*)
  - -> `[33]` (*Player_Romus: ""I want a full report.""*)
  - -> `[34]` (*Player_Romus: ""What do you want, a medal? This is literally the least I..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God be praised!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[23]` (Lucita Azaro), `[25]` (Taddeus Azaro), `[27]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "My councilor nodded."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Romus: ""God be praised!""*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player_Romus: ""Amazing news, Councilor. The nightmare is over.""*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you quite sure?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Lucita Azaro), `[25]` (Taddeus Azaro), `[27]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "My councilor nodded."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want a full report.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Lucita Azaro), `[25]` (Taddeus Azaro), `[27]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "My councilor handed me a copy of a dossier."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you want, a medal? This is literally the least I expect from you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Lucita Azaro), `[25]` (Taddeus Azaro), `[27]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "My councilor frowned apologetically and handed me a copy ..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Amazing news, Councilor. The nightmare is over.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[23]` (Lucita Azaro), `[25]` (Taddeus Azaro), `[27]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "My councilor nodded."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "My councilor nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[37]`
Mówca: **Narrator**
> "My councilor handed me a copy of a dossier."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[38]`
Mówca: **Narrator**
> "My councilor frowned apologetically and handed me a copy of a dossier."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && Rizia..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && Rizia..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && Rizia..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && Rizia..."*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && Riz..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NatDes_UniteHousesAgainst_Azaro"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Lucita Azaro: ""With the cooperation of all three noble houses, we manag..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NatDes_UniteHousesAgainst_Azaro"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Oppress == true"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && Rizia..."*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && Riz..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NatDes_UniteHousesAgainst_Azaro"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Taddeus Azaro: ""With the cooperation of all three noble houses, we manag..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NatDes_UniteHousesAgainst_Azaro"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Oppress == true"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && Rizia..."*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && Riz..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NatDes_UniteHousesAgainst_Azaro"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Titus Gordion: ""With the cooperation of all three noble houses, we manag..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NatDes_UniteHousesAgainst_Azaro == true && RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true && RiziaDLC.NatDes_UniteHousesAgainst_Toras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NatDes_UniteHousesAgainst_Azaro"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true  and  Variable["RiziaDLC.NatDes_UniteHousesAgainst_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Oppress == true"*)

### Węzeł `[54]`
Mówca: **Lucita Azaro**
> ""With the cooperation of all three noble houses, we managed to hold back the tide of revolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucita Azaro: ""My cousin Carlos marshalled Azaro troops to drive the ri..."*)

### Węzeł `[55]`
Mówca: **Lucita Azaro**
> ""My cousin Carlos marshalled Azaro troops to drive the rioters out of Cardesse-Montaklar's cities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucita Azaro: ""Hubertus convinced the nobles of Valenqiris to lend thei..."*)

### Węzeł `[56]`
Mówca: **Lucita Azaro**
> ""Hubertus convinced the nobles of Valenqiris to lend their private armies to the cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Lucita Azaro: ""And I'd be remiss not to mention the bravery of my fello..."*)

### Węzeł `[57]`
Mówca: **Lucita Azaro**
> ""And I'd be remiss not to mention the bravery of my fellow noblewoman Angelica Sazon, who spurred her loyalists in Brenas into immediate action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Execu..."*)

### Węzeł `[58]`
Mówca: **Taddeus Azaro**
> ""With the cooperation of all three noble houses, we managed to hold back the tide of revolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Taddeus Azaro: ""General Carlos marshalled Azaro troops to drive the riot..."*)

### Węzeł `[59]`
Mówca: **Taddeus Azaro**
> ""General Carlos marshalled Azaro troops to drive the rioters out of Cardesse-Montaklar's cities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Taddeus Azaro: ""Hubertus convinced the nobles of Valenqiris to lend thei..."*)

### Węzeł `[60]`
Mówca: **Taddeus Azaro**
> ""Hubertus convinced the nobles of Valenqiris to lend their private armies to the cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Taddeus Azaro: ""And I'd be remiss not to mention the bravery of Angelica..."*)

### Węzeł `[61]`
Mówca: **Taddeus Azaro**
> ""And I'd be remiss not to mention the bravery of Angelica Sazon, who spurred her loyalists in Brenas into immediate action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Execu..."*)

### Węzeł `[62]`
Mówca: **Titus Gordion**
> ""With the cooperation of all three noble houses, we managed to hold back the tide of revolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Titus Gordion: ""General Carlos Azaro marshalled Azaro troops to drive th..."*)

### Węzeł `[63]`
Mówca: **Titus Gordion**
> ""General Carlos Azaro marshalled Azaro troops to drive the rioters out of Cardesse-Montaklar's cities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Titus Gordion: ""Your cousin Hubertus convinced the nobles of Valenqiris ..."*)

### Węzeł `[64]`
Mówca: **Titus Gordion**
> ""Your cousin Hubertus convinced the nobles of Valenqiris to lend their private armies to the cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Titus Gordion: ""And I'd be remiss not to mention the bravery of Angelica..."*)

### Węzeł `[65]`
Mówca: **Titus Gordion**
> ""And I'd be remiss not to mention the bravery of Angelica Sazon, who spurred her loyalists in Brenas into immediate action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Execu..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sacrifices were made. But it was all worth it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Lucita Azaro), `[127]` (Taddeus Azaro), `[140]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now we can focus our attention where it belongs. On defeating Pales.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[126]` (Lucita Azaro), `[127]` (Taddeus Azaro), `[140]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lucita Azaro: ""Yes, you'll receive an update on that front very soon.""*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player_Romus: ""Now we can focus our attention where it belongs. On defe..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must admit, I didn't think House Sazon had it in them.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true`
- **Kontekst wejściowy (poprzednik):** `[126]` (Lucita Azaro), `[127]` (Taddeus Azaro), `[140]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true"*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true )"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player_Romus: ""I must admit, I didn't think House Sazon had it in them.""*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NatDes_UniteHousesAgainst_Sazon"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As in 1926, we must now turn our attention to restoring our citizens' trust in us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Lucita Azaro), `[127]` (Taddeus Azaro), `[140]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_Pipline_NatDes_AppeaseOptions"*)

### Węzeł `[76]`
Mówca: **Lucita Azaro**
> ""Yes, you'll receive an update on that front very soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Appease == true"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Hugo == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Hugo Toras: ""Indeed it was, Your Majesty.""*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Elena Werner: ""Sacrifices indeed, Your Majesty.""*)

### Węzeł `[80]`
Mówca: **Hugo Toras**
> ""Indeed it was, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Appease == true"*)

### Węzeł `[81]`
Mówca: **Elena Werner**
> ""Sacrifices indeed, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Appease == true"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent"*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent)"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "I thought I saw disgust flash across my daughter's face."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Laurento Esquibel: ""No. Nor did I.""*)

### Węzeł `[85]`
Mówca: **Narrator**
> "I thought I saw disgust flash across my daughter's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Appease == true"*)

### Węzeł `[86]`
Mówca: **Laurento Esquibel**
> ""No. Nor did I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Appease == true"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_Pipline_NatDes_AppeaseOptions`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_Pipline_NatDes_AppeaseOptions"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn09_Pipline_NatDes_AppeaseOptions)"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_Pipline_NatDes_AppeaseOptions`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_Pipline_NatDes_AppeaseOptions"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Elena Werner: ""We are already on our way to doing so.""*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn09_Pipline_NatDes_AppeaseOptions)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_Pipline_NatDes_AppeaseOptions"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Elena Werner: ""Yes, we can expect a rocky few months at least.""*)

### Węzeł `[90]`
Mówca: **Elena Werner**
> ""We are already on our way to doing so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Appease == true"*)

### Węzeł `[91]`
Mówca: **Elena Werner**
> ""Yes, we can expect a rocky few months at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Appease == true"*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This must never be allowed to happen again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Lucita Azaro), `[127]` (Taddeus Azaro), `[140]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Elena Werner: ""Agreed. It was difficult enough for us to bounce back th..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Execu..."*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Exe..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == true  or  Variable["RiziaDLC.Adarfo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Lucita Azaro: ""We have rounded up as many of the movement ringleaders a..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == true  or  Variable["RiziaDLC.Adarfo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucita Azaro: ""As for Adarfo Sotelato, he has been apprehended and now ..."*)

### Węzeł `[96]`
Mówca: **Lucita Azaro**
> ""As for Adarfo Sotelato, he has been apprehended and now sits in the Porte Drazon Citadel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested = true; EnableCodexEntry("Charac..."*)

### Węzeł `[97]`
Mówca: **Taddeus Azaro**
> ""As for Adarfo Sotelato, he has been apprehended and now sits in the Porte Drazon Citadel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested = true; EnableCodexEntry("Charac..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Execu..."*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Exe..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == true  or  Variable["RiziaDLC.Adarfo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Titus Gordion: ""We have rounded up as many of the ringleaders as we coul..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == true  or  Variable["RiziaDLC.Adarfo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Titus Gordion: ""As for Adarfo Sotelato, he has been apprehended and now ..."*)

### Węzeł `[101]`
Mówca: **Titus Gordion**
> ""As for Adarfo Sotelato, he has been apprehended and now sits in the Porte Drazon citadel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested = true; EnableCodexEntry("Charac..."*)

### Węzeł `[102]`
Mówca: **Lucita Azaro**
> ""Our crackdown on the protests was a total success. The movement is fractured, and has shown no sign of resurgence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PipelineNatDes_DeploySO == true"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PipelineNatDes_DeploySO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PipelineNatDes_DeploySO == true"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PipelineNatDes_DeploySO == true)"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PipelineNatDes_DeploySO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PipelineNatDes_DeploySO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Lucita Azaro: ""Su Omina was especially helpful in neutralizing the more..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PipelineNatDes_DeploySO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PipelineNatDes_DeploySO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PipelineNatDes_DeployWG == true"*)

### Węzeł `[106]`
Mówca: **Lucita Azaro**
> ""Su Omina was especially helpful in neutralizing the more troublesome individuals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "Hugo smiled."*)

### Węzeł `[107]`
Mówca: **Lucita Azaro**
> ""Wruhec's Guardians were especially helpful in neutralizing the more troublesome individuals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "Titus gave a salute from the doorway."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PipelineNatDes_DeployWG == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PipelineNatDes_DeployWG == true"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PipelineNatDes_DeployWG == true)"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PipelineNatDes_DeployWG == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PipelineNatDes_DeployWG"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Lucita Azaro: ""Wruhec's Guardians were especially helpful in neutralizi..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PipelineNatDes_DeployWG == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PipelineNatDes_DeployWG"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Lucita Azaro: ""The Golden Guard was especially helpful in neutralizing ..."*)

### Węzeł `[111]`
Mówca: **Lucita Azaro**
> ""The Golden Guard was especially helpful in neutralizing the more troublesome individuals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "Titus gave a salute from the doorway."*)

### Węzeł `[112]`
Mówca: **Narrator**
> "Titus gave a salute from the doorway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Execu..."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "Hugo smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Execu..."*)

### Węzeł `[114]`
Mówca: **Taddeus Azaro**
> ""Our crackdown on the protests was a total success. The movement is fractured, and has shown no sign of resurgence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PipelineNatDes_DeploySO == true"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PipelineNatDes_DeploySO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PipelineNatDes_DeploySO == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PipelineNatDes_DeploySO == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PipelineNatDes_DeploySO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PipelineNatDes_DeploySO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Taddeus Azaro: ""Su Omina was especially helpful in neutralizing the more..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PipelineNatDes_DeploySO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PipelineNatDes_DeploySO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PipelineNatDes_DeployWG == true"*)

### Węzeł `[118]`
Mówca: **Taddeus Azaro**
> ""Su Omina was especially helpful in neutralizing the more troublesome individuals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "Hugo smiled."*)

### Węzeł `[119]`
Mówca: **Taddeus Azaro**
> ""The Golden Guard was especially helpful in neutralizing the more troublesome individuals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "Titus gave a salute from the doorway."*)

### Węzeł `[120]`
Mówca: **Taddeus Azaro**
> ""Wruhec's Guardians were especially helpful in neutralizing the more troublesome individuals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "Titus gave a salute from the doorway."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PipelineNatDes_DeployWG == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PipelineNatDes_DeployWG == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PipelineNatDes_DeployWG == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PipelineNatDes_DeployWG == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PipelineNatDes_DeployWG"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Taddeus Azaro: ""Wruhec's Guardians were especially helpful in neutralizi..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PipelineNatDes_DeployWG == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PipelineNatDes_DeployWG"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Taddeus Azaro: ""The Golden Guard was especially helpful in neutralizing ..."*)

### Węzeł `[124]`
Mówca: **Narrator**
> "Titus gave a salute from the doorway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Execu..."*)

### Węzeł `[125]`
Mówca: **Narrator**
> "Hugo smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Execu..."*)

### Węzeł `[126]`
Mówca: **Lucita Azaro**
> ""I admit I was skeptical that the movement could be calmed without the need for harsh measures. But that seems to be exactly what's happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[127]`
Mówca: **Taddeus Azaro**
> ""I admit I was skeptical that the movement could be calmed without the need for harsh measures. But that seems to be exactly what's happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[128]`
Mówca: **Titus Gordion**
> ""Our crackdown on the protests was a total success. The movement is fractured, and has shown no sign of resurgence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PipelineNatDes_DeploySO == true"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PipelineNatDes_DeploySO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PipelineNatDes_DeploySO == true"*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PipelineNatDes_DeploySO == true)"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PipelineNatDes_DeploySO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PipelineNatDes_DeploySO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Titus Gordion: ""Su Omina was especially helpful in neutralizing the more..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PipelineNatDes_DeploySO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PipelineNatDes_DeploySO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PipelineNatDes_DeployWG == true"*)

### Węzeł `[132]`
Mówca: **Titus Gordion**
> ""Su Omina was especially helpful in neutralizing the more troublesome individuals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "Hugo smiled."*)

### Węzeł `[133]`
Mówca: **Titus Gordion**
> ""The Golden Guard was especially helpful in neutralizing the more troublesome individuals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "He smiled broadly."*)

### Węzeł `[134]`
Mówca: **Titus Gordion**
> ""Wruhec's Guardians were especially helpful in neutralizing the more troublesome individuals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "He smiled broadly."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PipelineNatDes_DeployWG == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PipelineNatDes_DeployWG == true"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PipelineNatDes_DeployWG == true)"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PipelineNatDes_DeployWG == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PipelineNatDes_DeployWG"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Titus Gordion: ""Wruhec's Guardians were especially helpful in neutralizi..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PipelineNatDes_DeployWG == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PipelineNatDes_DeployWG"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Titus Gordion: ""The Golden Guard was especially helpful in neutralizing ..."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "He smiled broadly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Execu..."*)

### Węzeł `[139]`
Mówca: **Narrator**
> "Hugo smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Execu..."*)

### Węzeł `[140]`
Mówca: **Titus Gordion**
> ""I admit I was skeptical that the movement could be calmed without the need for harsh measures. But that seems to be exactly what's happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player_Romus: ""This must never be allowed to happen again.""*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[66]` (*Player_Romus: ""Sacrifices were made. But it was all worth it.""*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_UniteHousesAgainst_Sazon == true"*)
  - -> `[75]` (*Player_Romus: ""As in 1926, we must now turn our attention to restoring ..."*)

### Węzeł `[142]`
Mówca: **Elena Werner**
> ""Agreed. It was difficult enough for us to bounce back the first time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Appease == true"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested = true;
EnableCodexEntry("Characters_PartyLeaders_AdarfoSotelato_Arrested");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Adarfo_Arrested"] = true;
EnableCodexEntry("Characters_PartyLeaders_AdarfoSotelato_Arrested");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[144]`
Mówca: **Lucita Azaro**
> ""We have rounded up as many of the movement ringleaders as we could and plan on making an example of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[145]`
Mówca: **Taddeus Azaro**
> ""We have rounded up as many of the movement ringleaders as we could and plan on making an example of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[146]`
Mówca: **Titus Gordion**
> ""We have rounded up as many of the ringleaders as we could and plan on making an example of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Oppress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Oppress == true"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NatDes_Oppress == true)"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Oppress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NatDes_Oppress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Taddeus Azaro: ""Our crackdown on the protests was a total success. The m..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NatDes_Oppress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Oppress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Taddeus Azaro: ""I admit I was skeptical that the movement could be calme..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Oppress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Oppress == true"*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NatDes_Oppress == true)"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Oppress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NatDes_Oppress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucita Azaro: ""Our crackdown on the protests was a total success. The m..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NatDes_Oppress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Oppress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Lucita Azaro: ""I admit I was skeptical that the movement could be calme..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Oppress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Oppress == true"*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NatDes_Oppress == true)"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Oppress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NatDes_Oppress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Titus Gordion: ""Our crackdown on the protests was a total success. The m..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NatDes_Oppress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Oppress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Titus Gordion: ""I admit I was skeptical that the movement could be calme..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Execu..."*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Exe..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == true  or  Variable["RiziaDLC.Adarfo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Taddeus Azaro: ""We have rounded up as many of the movement ringleaders a..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == true  or  Variable["RiziaDLC.Adarfo_Executed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Taddeus Azaro: ""As for Adarfo Sotelato, he has been apprehended and now ..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Collapse == true |..."*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_NewBusiness_Collapse == true..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Elena Werner: ""The concessions we were forced to make to the protesters..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Elena Werner: ""Miraculously, the concessions we were forced to make to ..."*)

### Węzeł `[162]`
Mówca: **Elena Werner**
> ""The concessions we were forced to make to the protesters did negatively impact our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Revolutionary_Pipeline_Sabotage == true"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Appease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Appease == true"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NatDes_Appease == true)"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Appease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NatDes_Appease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Collapse == true |..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NatDes_Appease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Appease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Elena Werner: ""The upheaval we experienced did negatively impact our ec..."*)
  - -> `[168]` (*Elena Werner: ""Miraculously, the upheaval we experienced barely dented ..."*)

### Węzeł `[166]`
Mówca: **Elena Werner**
> ""Miraculously, the concessions we were forced to make to the protesters barely dented our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Revolutionary_Pipeline_Sabotage == true"*)

### Węzeł `[167]`
Mówca: **Elena Werner**
> ""The upheaval we experienced did negatively impact our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Revolutionary_Pipeline_Sabotage == true"*)

### Węzeł `[168]`
Mówca: **Elena Werner**
> ""Miraculously, the upheaval we experienced barely dented our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Revolutionary_Pipeline_Sabotage == true"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Revolutionary_Pipeline_Sabotage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Revolutionary_Pipeline_Sabotage == true"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Revolutionary_Pipeline_Sabotage == true)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Revolutionary_Pipeline_Sabotage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Revolutionary_Pipeline_Sabotage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PipelineNatDes_PipelineDontRepair == true"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Revolutionary_Pipeline_Sabotage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Revolutionary_Pipeline_Sabotage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy > 10"*)

### Węzeł `[172]`
Mówca: **Elena Werner**
> ""Our energy reserves are still recovering from the sabotage incident. It may take some time before we're at our former capacity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanAmount > 0"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PipelineNatDes_PipelineDontRepair == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PipelineNatDes_PipelineDontRepair == true"*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PipelineNatDes_PipelineDontRepair == true)"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PipelineNatDes_PipelineDontRepair == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PipelineNatDes_PipelineDontRepair"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Elena Werner: ""Our energy reserves are still recovering from the sabota..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PipelineNatDes_PipelineDontRepair == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PipelineNatDes_PipelineDontRepair"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Elena Werner: ""Thanks to your quick actions after the sabotage incident..."*)

### Węzeł `[176]`
Mówca: **Elena Werner**
> ""Thanks to your quick actions after the sabotage incident, our energy reserves are on track to reach their former capacity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanAmount > 0"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy > 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy > 10"*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Energy > 10)"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy > 10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] > 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Elena Werner: ""Our robust energy reserves will undoubtedly help us weat..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Energy > 10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] > 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy > 5"*)

### Węzeł `[180]`
Mówca: **Elena Werner**
> ""And we remain in debt to Rizian Royal Gold. I hope it isn't too late for that to be squared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Player_Romus: ""We handled the unrest. We can handle Rusty.""*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Collapse == true |..."*)
  - -> `[196]` (*Player_Romus: ""There is still much work to be done. We've got to addres..."*)
  - -> `[197]` (*Player_Romus: ""We should take some time to rest on our laurels. We defe..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_LoanAmount > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanAmount > 0"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_LoanAmount > 0)"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_LoanAmount > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_LoanAmount"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Elena Werner: ""And we remain in debt to Rizian Royal Gold. I hope it is..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_LoanAmount > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Collapse == true |..."*)
  - -> `[196]` (*Player_Romus: ""There is still much work to be done. We've got to addres..."*)
  - -> `[197]` (*Player_Romus: ""We should take some time to rest on our laurels. We defe..."*)

### Węzeł `[184]`
Mówca: **Elena Werner**
> ""Our robust energy reserves will undoubtedly help us weather the months ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanAmount > 0"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Energy > 5"*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Energy > 5)"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Energy > 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Energy"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Elena Werner: ""Thankfully, we have adequate energy reserves to weather ..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Energy > 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Energy"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Elena Werner: ""I am concerned that our energy reserves are insufficient..."*)

### Węzeł `[188]`
Mówca: **Elena Werner**
> ""Thankfully, we have adequate energy reserves to weather the months ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanAmount > 0"*)

### Węzeł `[189]`
Mówca: **Elena Werner**
> ""I am concerned that our energy reserves are insufficient to weather the months ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanAmount > 0"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_NewBusiness_Collapse == true |..."*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_NewBusiness_Collapse == true..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Player_Romus: ""Concerning news. But at least we're now in the position ..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_NewBusiness_Collapse == true || RiziaDLC.Situation_Economy_NewBusiness_Reduction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player_Romus: ""With the anti-monarchists out of the way, our economy wi..."*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Concerning news. But at least we're now in the position to begin working on our recovery.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true` AND `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[180]` (Elena Werner), `[172]` (Elena Werner), `[176]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Laurento Esquibel: ""And work we will, Your Majesty.""*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the anti-monarchists out of the way, our economy will soar even higher than before.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Economy_NewBusiness_Collapse"] == true  or  Variable["RiziaDLC.Situation_Economy_NewBusiness_Reduction"] == true) == false` AND `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[180]` (Elena Werner), `[172]` (Elena Werner), `[176]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Laurento Esquibel: ""I have no doubt it will, Your Majesty.""*)

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We handled the unrest. We can handle Rusty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Laurento Esquibel: ""I am sure we can.""*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is still much work to be done. We've got to address the root cause of the uprising, not just recover from it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[180]` (Elena Werner), `[172]` (Elena Werner), `[176]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Laurento Esquibel: ""Very prudent thinking, Your Majesty.""*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We should take some time to rest on our laurels. We defeated a revolution, after all.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[180]` (Elena Werner), `[172]` (Elena Werner), `[176]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Laurento Esquibel: ""Indeed. No easy feat.""*)

### Węzeł `[198]`
Mówca: **Laurento Esquibel**
> ""Indeed. No easy feat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "He scribbled something on a notepad in front of him."*)

### Węzeł `[199]`
Mówca: **Laurento Esquibel**
> ""Very prudent thinking, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "He scribbled something on a notepad in front of him."*)

### Węzeł `[200]`
Mówca: **Laurento Esquibel**
> ""I have no doubt it will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "He scribbled something on a notepad in front of him."*)

### Węzeł `[201]`
Mówca: **Laurento Esquibel**
> ""And work we will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "He scribbled something on a notepad in front of him."*)

### Węzeł `[202]`
Mówca: **Laurento Esquibel**
> ""I am sure we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "He scribbled something on a notepad in front of him."*)

### Węzeł `[203]`
Mówca: **Narrator**
> "He scribbled something on a notepad in front of him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true"*)

### Węzeł `[204]`
Mówca: **Laurento Esquibel**
> ""I will get word to our partners in GRACE that the threat of destabilization is over. I know they were beginning to worry about our trade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_GRACEMember == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_GRACEMember == true)"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_GRACEMember == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Laurento Esquibel: ""I will get word to our partners in GRACE that the threat..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_GRACEMember == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Intermerkopum == true"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Intermerkopum == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Intermerkopum == true"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_Intermerkopum == true)"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Intermerkopum == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Laurento Esquibel: ""I will get word to our partners in Intermerkopum that th..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_Intermerkopum == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Laurento Esquibel: ""I will get word to our trading partners that the threat ..."*)

### Węzeł `[211]`
Mówca: **Laurento Esquibel**
> ""I will get word to our partners in Intermerkopum that the threat of destabilization is over. I know they were beginning to worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)

### Węzeł `[212]`
Mówca: **Laurento Esquibel**
> ""I will get word to our trading partners that the threat of destabilization is over. I know they were beginning to worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)

### Węzeł `[213]`
Mówca: **Laurento Esquibel**
> ""And I will speak with the Duke and Duchess of Pales about resuming our reunification efforts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification == true"*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_Rizia_Unification == true)"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_Rizia_Unification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Laurento Esquibel: ""And I will speak with the Duke and Duchess of Pales abou..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_Rizia_Unification == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Sal_Arrested == false)"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Sal Ignacius: ""Our nation remains greatly divided. Only the power of fa..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Sal_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true"*)

### Węzeł `[220]`
Mówca: **Sal Ignacius**
> ""Our nation remains greatly divided. Only the power of faith will heal it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player_Romus: ""Wise words, Grand Wiseman.""*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[231]` (*Player_Romus: ""The power of faith is second to the power of the Crown, ..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wise words, Grand Wiseman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true"*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[220]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Player_Romus: ""Halaita.""*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player_Romus: ""Nice try, but no. Faith still divides Rizia more than it..."*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nice try, but no. Faith still divides Rizia more than it unifies us.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[220]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true"*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wruhec's Guardians will be integral to our recovery efforts. I want them to focus on outreach to our disaffected citizens.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Kontekst wejściowy (poprzednik):** `[220]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Player_Romus: ""Wruhec's Guardians will be integral to our recovery effo..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The power of faith is second to the power of the Crown, Sal. Remember that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true"*)

### Węzeł `[232]`
Mówca: **Narrator**
> "I looked at my daughter. She still hadn't said a word."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player_Romus: ""Vina... I know mistakes were made. But I'll do better fr..."*)
  - -> `[246]` (*Player_Romus: ""Cat got your tongue, Your Highness?""*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[251]` (*Player_Romus: ""If no one else has anything to say, we'll conclude the m..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true"*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == t..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "I looked at my daughter. She still hadn't said a word."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_CouncilMeeting_VinaPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Hugo == true)"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Hugo Toras: ""Thank you all for joining us today.""*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Player_Romus: ""Shall we begin?""*)
  - -> `[243]` (*Player_Romus: ""All right. What is this meeting about?""*)
  - -> `[244]` (*Player_Romus: ""Thank you all for joining me here today. I hope you've b..."*)

### Węzeł `[239]`
Mówca: **Hugo Toras**
> ""Thank you all for joining us today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Hugo Toras: ""And for your loyalty and hard work during these recent t..."*)

### Węzeł `[240]`
Mówca: **Hugo Toras**
> ""And for your loyalty and hard work during these recent trying times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Hugo Toras: ""Now. I will let our Councilor of War and Security share ..."*)

### Węzeł `[241]`
Mówca: **Hugo Toras**
> ""Now. I will let our Councilor of War and Security share the good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shall we begin?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right. What is this meeting about?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you all for joining me here today. I hope you've brought good news.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina... I know mistakes were made. But I'll do better from now on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Appease == true"*)

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Cat got your tongue, Your Highness?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Narrator: "She sighed and shook her head."*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does your husband have to say for himself? He's the reason all this happened, after all.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Kontekst wejściowy (poprzednik):** `[232]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Vina Toras: ""What? Father, that's not true at all.""*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player_Romus: ""What does your husband have to say for himself? He's the..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If no one else has anything to say, we'll conclude the meeting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Narrator: "Elena nodded sagely.."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Appease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Appease == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.NatDes_Appease == true)"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.NatDes_Appease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.NatDes_Appease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Vina Toras: ""I'm pleased that the Crown and the protesters could find..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.NatDes_Appease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.NatDes_Appease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Vina Toras: ""So much senseless bloodshed...""*)

### Węzeł `[255]`
Mówca: **Vina Toras**
> ""I'm pleased that the Crown and the protesters could find a compromise, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Vina Toras: ""But if you'd only been willing to work with Manus, none ..."*)

### Węzeł `[256]`
Mówca: **Vina Toras**
> ""But if you'd only been willing to work with Manus, none of this would have happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player_Romus: ""Your sweetheart's no saint. He was stirring up trouble f..."*)
  - -> `[261]` (*Player_Romus: ""You don't know that. Who's to say the people would have ..."*)
  - -> `[262]` (*Player_Romus: ""Maybe. But we must look to the future now.""*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == false"*)

### Węzeł `[257]`
Mówca: **Vina Toras**
> ""So much senseless bloodshed...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Vina Toras: ""If you'd only been willing to work with Manus, none of t..."*)

### Węzeł `[258]`
Mówca: **Vina Toras**
> ""If you'd only been willing to work with Manus, none of this would have happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player_Romus: ""Your sweetheart's no saint. He was stirring up trouble f..."*)
  - -> `[261]` (*Player_Romus: ""You don't know that. Who's to say the people would have ..."*)
  - -> `[262]` (*Player_Romus: ""Maybe. But we must look to the future now.""*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == false"*)

### Węzeł `[259]`
Mówca: **Narrator**
> "She sighed and shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.NatDes_Appease == true"*)

### Węzeł `[260]`
Mówca: **Vina Toras**
> ""What? Father, that's not true at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Vina Toras: ""If you'd only been willing to work with Manus, none of t..."*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't know that. Who's to say the people would have accepted his watered-down reform attempts?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Vina Toras), `[258]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Vina Toras: ""But you never even tried.""*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe. But we must look to the future now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Vina Toras), `[258]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "Vina didn't respond. She gave a tight nod."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Player_Romus: ""Now that Adarfo's out of the picture, I can see myself c..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player_Romus: ""I might still cooperate with the RPP in the future. Who ..."*)

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now that Adarfo's out of the picture, I can see myself collaborating with the RPP.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true` AND `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false`
- **Kontekst wejściowy (poprzednik):** `[256]` (Vina Toras), `[258]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Vina Toras: ""Well... good. That's a start.""*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I might still cooperate with the RPP in the future. Who knows?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false` AND `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false`
- **Kontekst wejściowy (poprzednik):** `[256]` (Vina Toras), `[258]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Vina Toras: ""Well... good. That's a start.""*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == false"*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseOfDelegates_Abolished == false)"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseOfDelegates_Abolished == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your sweetheart's no saint. He was stirring up trouble from day one.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Vina Toras), `[258]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Narrator: "Vina didn't respond."*)

### Węzeł `[272]`
Mówca: **Narrator**
> "Vina didn't respond. She gave a tight nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[273]`
Mówca: **Narrator**
> "Vina didn't respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[274]`
Mówca: **Vina Toras**
> ""But you never even tried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[275]`
Mówca: **Vina Toras**
> ""Well... good. That's a start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)

### Węzeł `[276]`
Mówca: **Elena Werner**
> ""I'm sure we're all eager to put this nightmare behind us and get back to our jobs. I suggest we adjourn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[277]`
Mówca: **Narrator**
> "Hugo cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Hugo Toras: ""We've all got work to do. I suggest we adjourn.""*)

### Węzeł `[278]`
Mówca: **Narrator**
> "Elena cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Elena Werner: ""I'm sure we're all eager to put this nightmare behind us..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Hugo == true)"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "Hugo cleared his throat."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Narrator: "Elena cleared her throat."*)

### Węzeł `[282]`
Mówca: **Narrator**
> "Elena nodded sagely.."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Elena Werner: ""Yes, I'm sure we're all eager to put this nightmare behi..."*)

### Węzeł `[283]`
Mówca: **Elena Werner**
> ""Yes, I'm sure we're all eager to put this nightmare behind us and get back to our jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[284]`
Mówca: **Hugo Toras**
> ""We've all got work to do. I suggest we adjourn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[285]`
Mówca: **Narrator**
> "Lucita came over to stand by my side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Promised_Succession_Son_RespectTradition == true..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "Lucita came over to stand by my side."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Promised_Succession_Son_RespectTradition == true || RiziaDLC.Pales_PromisedToHouseAzaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Promised_Succession_Son_RespectTradition == true..."*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Promised_Succession_Son_RespectTradition == tr..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Promised_Succession_Son_RespectTradition == true || RiziaDLC.Pales_PromisedToHouseAzaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Promised_Succession_Son_RespectTradition"] == true  or  Variable["RiziaDLC.Pales_PromisedToHouseAzaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "Her eyes were gleaming as she took my hand."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Promised_Succession_Son_RespectTradition == true || RiziaDLC.Pales_PromisedToHouseAzaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Promised_Succession_Son_RespectTradition"] == true  or  Variable["RiziaDLC.Pales_PromisedToHouseAzaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "She took my hand and turned to face the others."*)

### Węzeł `[292]`
Mówca: **Narrator**
> "Her eyes were gleaming as she took my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Lucita Azaro: ""Glovurius axa Rizia.""*)

### Węzeł `[293]`
Mówca: **Lucita Azaro**
> ""Glovurius axa Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[294]`
Mówca: **Narrator**
> "She took my hand and turned to face the others."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Lucita Azaro: ""Glovurius axa Rizia.""*)

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glovurius axa Rizia.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[293]` (Lucita Azaro), `[276]` (Elena Werner), `[283]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "One by one, my councilors bowed before me and departed."*)

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Long live the monarchy.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[293]` (Lucita Azaro), `[276]` (Elena Werner), `[283]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "One by one, my councilors bowed before me and departed."*)

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, everyone.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[293]` (Lucita Azaro), `[276]` (Elena Werner), `[283]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "One by one, my councilors bowed before me and departed."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[296]` (*Player_Romus: ""Long live the monarchy.""*)
  - -> `[295]` (*Player_Romus: ""Glovurius axa Rizia.""*)
  - -> `[297]` (*Player_Romus: ""Thank you, everyone.""*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Player_Romus: ""God be with you all.""*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God be with you all.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true` AND `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[293]` (Lucita Azaro), `[276]` (Elena Werner), `[283]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "One by one, my councilors bowed before me and departed."*)

### Węzeł `[303]`
Mówca: **Narrator**
> "One by one, my councilors bowed before me and departed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true && RiziaDLC.Pro..."*)

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't get too cocky. We've still got a war to win.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true` AND `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[293]` (Lucita Azaro), `[276]` (Elena Werner), `[283]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "One by one, my councilors bowed before me and departed."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Player_Romus: ""Don't get too cocky. We've still got a war to win.""*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true && RiziaDLC.PromiseToAbdicate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true && RiziaDLC.Pro..."*)
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Hugo == true && RiziaDLC.P..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true && RiziaDLC.PromiseToAbdicate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true  and  Variable["RiziaDLC.PromiseToAbdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Narrator: "Only Hugo was left."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Hugo == true && RiziaDLC.PromiseToAbdicate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true  and  Variable["RiziaDLC.PromiseToAbdicate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[311]`
Mówca: **Narrator**
> "Only Hugo was left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Hugo Toras: ""I have not forgotten your promise, Your Majesty.""*)

### Węzeł `[312]`
Mówca: **Hugo Toras**
> ""I have not forgotten your promise, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Hugo Toras: ""I trust it will not take too long to get your affairs in..."*)

### Węzeł `[313]`
Mówca: **Hugo Toras**
> ""I trust it will not take too long to get your affairs in order. Six months, perhaps?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Player_Romus: ""I have not forgotten, either. When the time comes, I wil..."*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[320]` (*Player_Romus: ""Are you that hungry to take my place? Don't forget I hav..."*)
  - -> `[321]` (*Player_Romus: ""My 'promise' counts for nothing. You should never have t..."*)

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have not forgotten, either. When the time comes, I will inform the nation that my reign is over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[313]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Hugo Toras: ""Thank you.""*)

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must see the war to an end. After that, I will fulfill my promise.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[313]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Hugo Toras: ""I understand. I would not ask you to abandon our chances..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Player_Romus: ""I must see the war to an end. After that, I will fulfill..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Player_Romus: ""Possibly even sooner. I don't have much to wrap up.""*)

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Possibly even sooner. I don't have much to wrap up.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[313]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Hugo Toras: ""Even better, then.""*)

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you that hungry to take my place? Don't forget I have a daughter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[313]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Hugo Toras: ""I did not mean to insinuate that your successor should b..."*)

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My 'promise' counts for nothing. You should never have tried to demand my abdication in exchange for my own family's loyalty. I am going nowhere.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[313]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "Shock and pain mixed in his eyes."*)

### Węzeł `[322]`
Mówca: **Narrator**
> "Shock and pain mixed in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Hugo Toras: ""I see.""*)

### Węzeł `[323]`
Mówca: **Hugo Toras**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Hugo Toras: ""Then good day to you, my nephew. And all the best to you..."*)

### Węzeł `[324]`
Mówca: **Hugo Toras**
> ""Then good day to you, my nephew. And all the best to your... companion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PromiseToAbdicate = false; RiziaDLC.Turn10_Counc..."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PromiseToAbdicate = false;
RiziaDLC.Turn10_CouncilGoodbyes_NoPromiseToAbdicate = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PromiseToAbdicate"] = false;
Variable["RiziaDLC.Turn10_CouncilGoodbyes_NoPromiseToAbdicate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "He turned and walked out without saying another word."*)

### Węzeł `[326]`
Mówca: **Narrator**
> "He turned and walked out without saying another word."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[327]`
Mówca: **Hugo Toras**
> ""I did not mean to insinuate that your successor should be me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ==..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ==..."*)
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes ..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Hugo Toras: ""Though with Vina's whereabouts unknown... well. It is yo..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true || RiziaDLC.Vina_Escapes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true  or  Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Hugo Toras: ""I wish you a good day, my nephew. And all the best to yo..."*)

### Węzeł `[331]`
Mówca: **Hugo Toras**
> ""Though with Vina's whereabouts unknown... well. It is your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Hugo Toras: ""I wish you a good day, my nephew. And all the best to yo..."*)

### Węzeł `[332]`
Mówca: **Hugo Toras**
> ""I wish you a good day, my nephew. And all the best to your... companion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Narrator: "He bowed respectfully and walked out."*)

### Węzeł `[333]`
Mówca: **Hugo Toras**
> ""Even better, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Hugo Toras: ""I wish you a good day, my nephew. And all the best to yo..."*)

### Węzeł `[334]`
Mówca: **Hugo Toras**
> ""I understand. I would not ask you to abandon our chances at recapturing Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Hugo Toras: ""I wish you a good day, my nephew. And all the best to yo..."*)

### Węzeł `[335]`
Mówca: **Hugo Toras**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Hugo Toras: ""I wish you a good day, my nephew. And all the best to yo..."*)

### Węzeł `[336]`
Mówca: **Narrator**
> "He bowed respectfully and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
