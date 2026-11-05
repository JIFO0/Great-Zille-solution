# Rizia/Turn 6/A_BorderInvestigationResults

- **ID konwersacji:** `371`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/371_A_BorderInvestigationResults.md`
- **Liczba węzłów dialogowych:** 232
- **Liczba wyborów gracza:** 50

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[70]** Laurento Esquibel
- **[94]** Axel Reinhart
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Incident_Border_KillSoldiers`
- `RiziaDLC.Relations_Lucita_PromisedDate`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Taddeus_Arrested`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn05_MurderInvest_InvestigateLucita`
- `RiziaDLC.Vina_Hostage`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Faction_HouseAzaro_Carlos`
- `RiziaDLC.Faction_HouseAzaro_Lucita`
- `RiziaDLC.Faction_HouseAzaro_Taddeus`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Pales_PostIncident_Peace_Deal`
- `RiziaDLC.Pales_PostIncident_Peace_NoDeal`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PoisonInvestigator_Lucita`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Pales`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLCSupport.FactionReports_Turn06_ATO_ArrestLucita`
- `RiziaDLCSupport.FactionReports_Turn06_ATO_CondemsIgnoringInvestigation`
- `RiziaDLCSupport.Journal_Turn06_BorderInvestigation_ArrestLucita`
- `RiziaDLCSupport.Journal_Turn06_BorderInvestigation_DontArrestLucita`
- `RiziaDLCSupport.News_Turn06_G_BorderIncidentHandled`
- `RiziaDLCSupport.News_Turn06_G_LucitaExoneratedNoWar`
- `RiziaDLCSupport.News_Turn06_G_LucitaExoneratedWar`
- `RiziaDLCSupport.News_Turn06_RH_GeneralAzaroOnWar`
- `RiziaDLCSupport.News_Turn06_RH_LucitaArrested`
- `RiziaDLCSupport.News_Turn06_RH_LucitaExoneratedNoWar`
- `RiziaDLCSupport.News_Turn06_RH_LucitaExoneratedWar`
- `RiziaDLCSupport.Reports_Turn06_Pales_VinaKeptHostage`
- `RiziaDLCSupport.Reports_Turn06_PorteDrazon_LucitaArrested`
- `RiziaDLCSupport.Reports_Turn06_PorteDrazon_LucitaBehindIncident`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **""Mr. Esquibel, Your Grace. To what do I owe this interruption?""** | `[4]` **Narrator**: "I walked through the council cha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Narrator**: "The two men glanced at each other." |
| `[6]` | **""Please tell me there's good news.""** | `[4]` **Narrator**: "I walked through the council cha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Narrator**: "The two men glanced at each other." |
| `[7]` | **""I hope this is quick, gentlemen. Duchess Azaro and I are on a tight schedule.""** | `[4]` **Narrator**: "I walked through the council cha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Narrator**: "The two men glanced at each other." |
| `[13]` | **""By whom? Spit it out, man!""** | `[12]` **Narrator**: "He took a deep breath. He couldn..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Reports_Turn06_PorteDrazon_Luci...` | `[16]` **Hugo Toras**: ""The named culprit was Lucita Az..." |
| `[14]` | **""Come on, Mr. Esquibel. If there's a traitor in our midst, I need to know who it is.""** | `[12]` **Narrator**: "He took a deep breath. He couldn..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Reports_Turn06_PorteDrazon_Luci...` | `[16]` **Hugo Toras**: ""The named culprit was Lucita Az..." |
| `[15]` | **""Hugo?""** | `[12]` **Narrator**: "He took a deep breath. He couldn..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Reports_Turn06_PorteDrazon_Luci...` | `[16]` **Hugo Toras**: ""The named culprit was Lucita Az..." |
| `[17]` | **""How certain are they?""** | `[16]` **Hugo Toras**: ""The named culprit was Lucita Az..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "Laurento frowned." |
| `[18]` | **""What?! They'll pay for soiling the name of a capable councilor and esteemed noble..."** | `[16]` **Hugo Toras**: ""The named culprit was Lucita Az..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Hugo Toras**: ""That was my first thought as we..." |
| `[19]` | **""The Azaros have been working against me this whole time?""** | `[16]` **Hugo Toras**: ""The named culprit was Lucita Az..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Narrator**: "Laurento frowned." |
| `[20]` | **""I know Duchess Azaro well. She'd never do a thing like that.""** | `[16]` **Hugo Toras**: ""The named culprit was Lucita Az..." | `Variable["RiziaDLC.Relations_Lucita_Together"] == true` | *Brak zmian stanu* | `[24]` **Narrator**: "Laurento frowned." |
| `[34]` | **""Lucita would have to be an idiot to think that she could get away with that.""** | `[33]` **Laurento Esquibel**: ""He was then coerced into alteri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Hugo Toras**: ""It does seem rather obvious for..." |
| `[35]` | **""And we trust this officer? What if he's the one who organized everything?""** | `[33]` **Laurento Esquibel**: ""He was then coerced into alteri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Hugo Toras**: ""The man's record is spotless. B..." |
| `[36]` | **""I always did suspect Duchess Azaro of being disingenuous in her pacifism.""** | `[33]` **Laurento Esquibel**: ""He was then coerced into alteri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Hugo Toras**: ""If she was suspicious of the Pa..." |
| `[37]` | **""How could she do this while my daughter was still in Pales? She must have known t..."** | `[33]` **Laurento Esquibel**: ""He was then coerced into alteri..." | `Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[51]` **Hugo Toras**: ""Which gives more credence to th..." |
| `[45]` | **""Why would she plan such a thing? She always cautioned me to be diplomatic with th..."** | `[33]` **Laurento Esquibel**: ""He was then coerced into alteri..." | `(Variable["RiziaDLC.Vina_Hostage"] == true) == false` | *Brak zmian stanu* | `[44]` **Hugo Toras**: ""Yes. She is not her father's da..." |
| `[54]` | **""Are you suggesting we turn in a woman who may be innocent just to avoid conflict?""** | `[53]` **Laurento Esquibel**: ""But we still have a chance to s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Laurento Esquibel**: ""I don't see another way out of ..." |
| `[55]` | **""It's obvious to me that Lespia played a role. Most likely hoping that Pales would..."** | `[53]` **Laurento Esquibel**: ""But we still have a chance to s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Laurento Esquibel**: ""But if that's true, then denyin..." |
| `[56]` | **""Pales wants us to take our best military strategist off the chessboard. Rather su..."** | `[53]` **Laurento Esquibel**: ""But we still have a chance to s..." | `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false` | *Brak zmian stanu* | `[64]` **Hugo Toras**: ""It could well be the case that ..." |
| `[60]` | **""Reinhart demanded reparations, and I paid them. Now he wants our best military st..."** | `[53]` **Laurento Esquibel**: ""But we still have a chance to s..." | `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true` | *Brak zmian stanu* | `[64]` **Hugo Toras**: ""It could well be the case that ..." |
| `[68]` | **""That's great news. The Azaro traitor will face justice, and our deal can proceed ..."** | `[53]` **Laurento Esquibel**: ""But we still have a chance to s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Hugo Toras**: ""If she is innocent -- or even i..." |
| `[74]` | **""I received it. I'm still deciding what to make of it.""** | `[73]` **Axel Reinhart**: ""King Romus. I'm assuming you re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Axel Reinhart**: ""What is there to decide, Your M..." |
| `[75]` | **""Yes. I can't believe my own war councilor would betray me like that.""** | `[73]` **Axel Reinhart**: ""King Romus. I'm assuming you re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Axel Reinhart**: ""Were you really so surprised, Y..." |
| `[76]` | **""Tell me, Your Grace. Did Pales or Lespia have a hand in these investigation resul..."** | `[73]` **Axel Reinhart**: ""King Romus. I'm assuming you re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Axel Reinhart**: ""Are you trying to deflect the b..." |
| `[77]` | **""I'm hoping I didn't. Because this one is blaming an innocent woman for what happe..."** | `[73]` **Axel Reinhart**: ""King Romus. I'm assuming you re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Axel Reinhart**: ""Innocent? Are you serious?"" |
| `[84]` | **""Think about it for a second. Isn't it more likely that Lespia was behind the inci..."** | `[82]` **Axel Reinhart**: ""Your war councilor's father got..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Axel Reinhart**: ""Lespia didn't kill my soldiers...."<br>`[90]` **Axel Reinhart**: ""Are you suggesting we accuse an..." |
| `[89]` | **""Our fathers do not determine our destiny.""** | `[82]` **Axel Reinhart**: ""Your war councilor's father got..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Axel Reinhart**: ""In this case, they do. The evid..." |
| `[91]` | **""Whatever she did, she acted alone. Neither I nor my other councilors had any know..."** | `[82]` **Axel Reinhart**: ""Your war councilor's father got..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Axel Reinhart**: ""I believe you."" |
| `[92]` | **""Admit it. You don't *want* Rizia to acknowledge Palesian sovereignty. It's far mo..."** | `[82]` **Axel Reinhart**: ""Your war councilor's father got..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Axel Reinhart**: ""That's very dangerous ground yo..." |
| `[98]` | **""I still have my suspicions about the legitimacy of these findings. But for the sa..."** | `[94]` **Axel Reinhart**: ""Arrest the Azaro woman, and we ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Narrator**: "There was a long silence on the ..." |
| `[99]` | **""Rest assured that my war councilor will be punished for her treasonous act. I wil..."** | `[94]` **Axel Reinhart**: ""Arrest the Azaro woman, and we ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Narrator**: "There was a long silence on the ..." |
| `[100]` | **""I'm sorry, Your Grace, but I cannot acknowledge the investigation results. I full..."** | `[94]` **Axel Reinhart**: ""Arrest the Azaro woman, and we ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Narrator**: "There was a long silence on the ..." |
| `[101]` | **""No. Your Grand Duchy has double-crossed me for the last time. I don't know what s..."** | `[94]` **Axel Reinhart**: ""Arrest the Azaro woman, and we ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Narrator**: "There was a long silence on the ..." |
| `[107]` | **""This was your plan all along, wasn't it? Take our money, then steal back your gas..."** | `[106]` **Axel Reinhart**: ""The gas pipeline from the field..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Axel Reinhart**: ""The fact that you could even th..." |
| `[108]` | **""Who will buy the exploration rights from you, then? Lespia?""** | `[106]` **Axel Reinhart**: ""The gas pipeline from the field..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Axel Reinhart**: ""That is confidential."" |
| `[112]` | **""Arresting the heir to one of Rizia's most important noble families is far from a ..."** | `[111]` **Axel Reinhart**: ""I'm glad we were able to resolv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Axel Reinhart**: ""I do."" |
| `[114]` | **""So am I. I am certain this unpleasant affair won't even make it into the history ..."** | `[111]` **Axel Reinhart**: ""I'm glad we were able to resolv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Axel Reinhart**: ""It is nothing compared to the m..." |
| `[118]` | **""Now, will you send my daughter back home?""** | `[111]` **Axel Reinhart**: ""I'm glad we were able to resolv..." | `Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[119]` **Axel Reinhart**: ""Yes, yes, of course. Though I c..." |
| `[120]` | **""So our gas deal is still on? Exactly as before?""** | `[111]` **Axel Reinhart**: ""I'm glad we were able to resolv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Axel Reinhart**: ""Exactly as before."" |
| `[126]` | **""And Vina? What about her?""** | `[106]` **Axel Reinhart**: ""The gas pipeline from the field..." | `Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[129]` **Axel Reinhart**: ""Assuming you respect our decisi..." |
| `[127]` | **""Please, Your Grace. Surely we can still reach some sort of compromise?""** | `[106]` **Axel Reinhart**: ""The gas pipeline from the field..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Axel Reinhart**: ""Arresting Duchess Azaro *was* t..." |
| `[142]` | **""No. You signed the rights to the Aureus field over to Rizia. If we must take it b..."** | `[141]` **Axel Reinhart**: ""Now. Do we have an understanding?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Narrator**: "Laurento looked stricken. Hugo's..." |
| `[143]` | **""Listen here, you brat. Do you know what happens when you try to back a bull into ..."** | `[141]` **Axel Reinhart**: ""Now. Do we have an understanding?"" | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[147]` **Narrator**: "Laurento looked stricken. Hugo's..." |
| `[148]` | **""Yes. We will forfeit our right to the field.""** | `[141]` **Axel Reinhart**: ""Now. Do we have an understanding?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Narrator**: "Laurento looked defeated." |
| `[149]` | **""You are making a mistake. But I will not challenge your decision.""** | `[141]` **Axel Reinhart**: ""Now. Do we have an understanding?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Narrator**: "Laurento looked defeated." |
| `[168]` | **""We'll speak soon. For now, I have an arrest to make.""** | `[166]` **Axel Reinhart**: ""Thank you for seeing reason, Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Narrator**: "We hung up." |
| `[169]` | **""I'll see you at the deal signing.""** | `[166]` **Axel Reinhart**: ""Thank you for seeing reason, Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Narrator**: "We hung up." |
| `[170]` | **""I apologize for all this trouble.""** | `[166]` **Axel Reinhart**: ""Thank you for seeing reason, Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Narrator**: "We hung up." |
| `[174]` | **""Tell them to tell her I'm sorry.""** | `[173]` **Hugo Toras**: ""Well. As the Rizia Imperii poli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Narrator**: "He looked at me with sorrow in h..."<br>`[182]` **Hugo Toras**: ""I will."" |
| `[175]` | **""Tell them to use as much force as they need to.""** | `[173]` **Hugo Toras**: ""Well. As the Rizia Imperii poli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Hugo Toras**: ""Yes... Of course."" |
| `[176]` | **""I control the Golden Guard. I will give the orders.""** | `[173]` **Hugo Toras**: ""Well. As the Rizia Imperii poli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Narrator**: "He bowed his head." |

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
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Gridlock", "R_Gridlock_Loop");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It was early in the morning. Lucita and I were about to depart for a royal visit to Terador Air Force Base when I got an urgent summons from Hugo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "I walked through the council chamber doors to find my unc..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "I walked through the council chamber doors to find my uncle and my foreign affairs councilor waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "AddConversant("Hugo Toras"); AddConversant("Laurento Esqu..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Esquibel, Your Grace. To what do I owe this interruption?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "The two men glanced at each other."*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please tell me there's good news.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "The two men glanced at each other."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope this is quick, gentlemen. Duchess Azaro and I are on a tight schedule.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "The two men glanced at each other."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "The two men glanced at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Laurento Esquibel: ""Your Majesty... we have received the results from the jo..."*)

### Węzeł `[9]`
Mówca: **Laurento Esquibel**
> ""Your Majesty... we have received the results from the joint investigation into the Palesian border incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Laurento Esquibel: ""Quite simply, our earlier hypotheses that the attack was..."*)

### Węzeł `[10]`
Mówca: **Laurento Esquibel**
> ""Quite simply, our earlier hypotheses that the attack was incited by Pales or staged by a third party were not borne out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Laurento Esquibel: ""Instead, all evidence seemed to indicate an inside job, ..."*)

### Węzeł `[11]`
Mówca: **Laurento Esquibel**
> ""Instead, all evidence seemed to indicate an inside job, one masterminded by...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "He took a deep breath. He couldn't bring himself to go on."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "He took a deep breath. He couldn't bring himself to go on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player_Romus: ""By whom? Spit it out, man!""*)
  - -> `[14]` (*Player_Romus: ""Come on, Mr. Esquibel. If there's a traitor in our midst..."*)
  - -> `[15]` (*Player_Romus: ""Hugo?""*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By whom? Spit it out, man!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn06_PorteDrazon_LucitaBehindIn..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come on, Mr. Esquibel. If there's a traitor in our midst, I need to know who it is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn06_PorteDrazon_LucitaBehindIn..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn06_PorteDrazon_LucitaBehindIn..."*)

### Węzeł `[16]`
Mówca: **Hugo Toras**
> ""The named culprit was Lucita Azaro, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus: ""How certain are they?""*)
  - -> `[18]` (*Player_Romus: ""What?! They'll pay for soiling the name of a capable cou..."*)
  - -> `[19]` (*Player_Romus: ""The Azaros have been working against me this whole time?""*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How certain are they?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Laurento frowned."*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What?! They'll pay for soiling the name of a capable councilor and esteemed noblewoman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Hugo Toras: ""That was my first thought as well. I don't believe Duche..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Azaros have been working against me this whole time?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Laurento frowned."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know Duchess Azaro well. She'd never do a thing like that.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Kontekst wejściowy (poprzednik):** `[16]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Laurento frowned."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: ""I know Duchess Azaro well. She'd never do a thing like t..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[24]`
Mówca: **Narrator**
> "Laurento frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Laurento Esquibel: ""I'd like to believe the same. But you have to consider t..."*)

### Węzeł `[25]`
Mówca: **Laurento Esquibel**
> ""I'd like to believe the same. But you have to consider the possibility that the Duchess entered into your confidence precisely so that you'd take her side in the case of such an incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Laurento Esquibel: ""The investigators secured a testimony from the commandin..."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "Laurento frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Laurento Esquibel: ""We don't know the precise details. The Duchess could hav..."*)

### Węzeł `[27]`
Mówca: **Laurento Esquibel**
> ""We don't know the precise details. The Duchess could have been acting in cooperation with her house, or alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Laurento Esquibel: ""The investigators secured a testimony from the commandin..."*)

### Węzeł `[28]`
Mówca: **Hugo Toras**
> ""That was my first thought as well. I don't believe Duchess Azaro would commit such an act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Laurento Esquibel: ""I am unsure what to think. Honestly, this investigation ..."*)

### Węzeł `[29]`
Mówca: **Laurento Esquibel**
> ""I am unsure what to think. Honestly, this investigation has muddied more waters than it has cleared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Laurento Esquibel: ""The investigators secured a testimony from the commandin..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "Laurento frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Laurento Esquibel: ""The report they sent seems to heavily indicate Duchess A..."*)

### Węzeł `[31]`
Mówca: **Laurento Esquibel**
> ""The report they sent seems to heavily indicate Duchess Azaro's involvement in what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Laurento Esquibel: ""The investigators secured a testimony from the commandin..."*)

### Węzeł `[32]`
Mówca: **Laurento Esquibel**
> ""The investigators secured a testimony from the commanding officer at the Fort Ales garrison. Apparently he told his men to fire on the Palesians on Duchess Azaro's orders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Laurento Esquibel: ""He was then coerced into altering the reports of the inc..."*)

### Węzeł `[33]`
Mówca: **Laurento Esquibel**
> ""He was then coerced into altering the reports of the incident to suggest that was Pales who shot first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""Lucita would have to be an idiot to think that she could..."*)
  - -> `[35]` (*Player_Romus: ""And we trust this officer? What if he's the one who orga..."*)
  - -> `[36]` (*Player_Romus: ""I always did suspect Duchess Azaro of being disingenuous..."*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita would have to be an idiot to think that she could get away with that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Hugo Toras: ""It does seem rather obvious for a military officer of he..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And we trust this officer? What if he's the one who organized everything?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Hugo Toras: ""The man's record is spotless. But we cannot rule out tha..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I always did suspect Duchess Azaro of being disingenuous in her pacifism.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Hugo Toras: ""If she was suspicious of the Palesians, it was for a rea..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How could she do this while my daughter was still in Pales? She must have known there was a risk Vina would get caught up in it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[33]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Hugo Toras: ""Which gives more credence to the theory that the Duchess..."*)

### Węzeł `[38]`
Mówca: **Hugo Toras**
> ""It does seem rather obvious for a military officer of her caliber.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Laurento Esquibel: ""She may have been counting on Rizia to invade Pales firs..."*)

### Węzeł `[39]`
Mówca: **Hugo Toras**
> ""The man's record is spotless. But we cannot rule out that possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Hugo sighed heavily."*)

### Węzeł `[40]`
Mówca: **Hugo Toras**
> ""If she was suspicious of the Palesians, it was for a reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Laurento Esquibel: ""May I remind you of her suggestion to send a naval block..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player_Romus: ""How could she do this while my daughter was still in Pal..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player_Romus: ""Why would she plan such a thing? She always cautioned me..."*)

### Węzeł `[44]`
Mówca: **Hugo Toras**
> ""Yes. She is not her father's daughter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Laurento Esquibel: ""May I remind you of her suggestion to send a naval block..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why would she plan such a thing? She always cautioned me to be diplomatic with the Grand Duchy.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[33]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Hugo Toras: ""Yes. She is not her father's daughter.""*)

### Węzeł `[46]`
Mówca: **Narrator**
> "Hugo sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Hugo Toras: ""To me, these results don't add up. It is far more likely..."*)

### Węzeł `[47]`
Mówca: **Hugo Toras**
> ""To me, these results don't add up. It is far more likely that Pales -- or someone else -- is trying to paint Rizia as an aggressor to sabotage our gas deal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Laurento Esquibel: ""I agree that this is far from a clear-cut case. Lespia h..."*)

### Węzeł `[48]`
Mówca: **Laurento Esquibel**
> ""I agree that this is far from a clear-cut case. Lespia had officials on the investigation committee, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Laurento Esquibel: ""But we still have a chance to salvage our gas deal and o..."*)

### Węzeł `[49]`
Mówca: **Laurento Esquibel**
> ""May I remind you of her suggestion to send a naval blockade to Aureus? Had we agreed to that, we would be in far more trouble than we are right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Hugo sighed heavily."*)

### Węzeł `[50]`
Mówca: **Laurento Esquibel**
> ""She may have been counting on Rizia to invade Pales first and ask questions later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Hugo sighed heavily."*)

### Węzeł `[51]`
Mówca: **Hugo Toras**
> ""Which gives more credence to the theory that the Duchess is innocent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Laurento Esquibel: ""Or acting under extreme pressure from her own family.""*)

### Węzeł `[52]`
Mówca: **Laurento Esquibel**
> ""Or acting under extreme pressure from her own family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Hugo sighed heavily."*)

### Węzeł `[53]`
Mówca: **Laurento Esquibel**
> ""But we still have a chance to salvage our gas deal and our diplomatic relationship with Pales. We just have to ensure the blame for the border attack falls fully on Duchess Azaro's shoulders, not ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player_Romus: ""Are you suggesting we turn in a woman who may be innocen..."*)
  - -> `[55]` (*Player_Romus: ""It's obvious to me that Lespia played a role. Most likel..."*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)
  - -> `[68]` (*Player_Romus: ""That's great news. The Azaro traitor will face justice, ..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you suggesting we turn in a woman who may be innocent just to avoid conflict?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Laurento Esquibel: ""I don't see another way out of it, unfortunately.""*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's obvious to me that Lespia played a role. Most likely hoping that Pales would use the investigation results as grounds to cancel our gas deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Laurento Esquibel: ""But if that's true, then denying Duchess Azaro's involve..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales wants us to take our best military strategist off the chessboard. Rather suspicious, that.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[53]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Hugo Toras: ""It could well be the case that Pales and Lespia were in ..."*)

### Węzeł `[57]`
Mówca: **Laurento Esquibel**
> ""But if that's true, then denying Duchess Azaro's involvement is playing right into Lespia's hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Hugo Toras: ""Only if Pales is serious about honoring the terms of our..."*)

### Węzeł `[58]`
Mówca: **Laurento Esquibel**
> ""I don't see another way out of it, unfortunately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Laurento Esquibel: ""Arrest Duchess Azaro now, and we can claim the incident ..."*)

### Węzeł `[59]`
Mówca: **Laurento Esquibel**
> ""Arrest Duchess Azaro now, and we can claim the incident was the work of a sole actor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Laurento Esquibel: ""Defend her, on the other hand, and Pales as well as the ..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Reinhart demanded reparations, and I paid them. Now he wants our best military strategist?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Kontekst wejściowy (poprzednik):** `[53]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Hugo Toras: ""It could well be the case that Pales and Lespia were in ..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Border_KillSoldiers == true)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player_Romus: ""Reinhart demanded reparations, and I paid them. Now he w..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Border_KillSoldiers == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""Pales wants us to take our best military strategist off ..."*)

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""It could well be the case that Pales and Lespia were in cahoots all along. They may never have truly intended to sell us the gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Laurento Esquibel: ""Pales promised to honor the deal if Rizia's name was cle..."*)

### Węzeł `[65]`
Mówca: **Hugo Toras**
> ""Only if Pales is serious about honoring the terms of our deal. Which it may not be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Laurento Esquibel: ""Pales promised to honor the deal if Rizia's name was cle..."*)

### Węzeł `[66]`
Mówca: **Laurento Esquibel**
> ""Pales promised to honor the deal if Rizia's name was cleared. If we name Duchess Azaro as the sole actor responsible for the incident, Duke Reinhart will have to go through with the sale.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Laurento Esquibel: ""Defend her, on the other hand, and Pales as well as the ..."*)

### Węzeł `[67]`
Mówca: **Laurento Esquibel**
> ""Defend her, on the other hand, and Pales as well as the entire international community will believe the Rizian government was behind the border operation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "An aide rushed into the chambers with the blue telephone...."*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's great news. The Azaro traitor will face justice, and our deal can proceed as planned.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Hugo Toras: ""If she is innocent -- or even if she is not -- the fallo..."*)

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""If she is innocent -- or even if she is not -- the fallout from House Azaro will be disastrous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Laurento Esquibel: ""Not as disastrous as that from the international communi..."*)

### Węzeł `[70]`
Mówca: **Laurento Esquibel**
> ""Not as disastrous as that from the international community should we fail to acknowledge the results of the investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "An aide rushed into the chambers with the blue telephone...."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "An aide rushed into the chambers with the blue telephone. Duke Reinhart was calling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Hugo and Laurento stayed silent in the background as I pi..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "Hugo and Laurento stayed silent in the background as I picked up the receiver."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "AddConversant("Axel Reinhart");"*)

### Węzeł `[73]`
Mówca: **Axel Reinhart**
> ""King Romus. I'm assuming you received the same report that I did?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player_Romus: ""I received it. I'm still deciding what to make of it.""*)
  - -> `[75]` (*Player_Romus: ""Yes. I can't believe my own war councilor would betray m..."*)
  - -> `[76]` (*Player_Romus: ""Tell me, Your Grace. Did Pales or Lespia have a hand in ..."*)
  - -> `[77]` (*Player_Romus: ""I'm hoping I didn't. Because this one is blaming an inno..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I received it. I'm still deciding what to make of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Axel Reinhart: ""What is there to decide, Your Majesty?""*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. I can't believe my own war councilor would betray me like that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Axel Reinhart: ""Were you really so surprised, Your Majesty?""*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me, Your Grace. Did Pales or Lespia have a hand in these investigation results?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Axel Reinhart: ""Are you trying to deflect the blame, Your Majesty?""*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm hoping I didn't. Because this one is blaming an innocent woman for what happened.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Axel Reinhart: ""Innocent? Are you serious?""*)

### Węzeł `[78]`
Mówca: **Axel Reinhart**
> ""Were you really so surprised, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "The volume of his voice rose."*)

### Węzeł `[79]`
Mówca: **Axel Reinhart**
> ""What is there to decide, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "The volume of his voice rose."*)

### Węzeł `[80]`
Mówca: **Axel Reinhart**
> ""Are you trying to deflect the blame, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "The volume of his voice rose."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "The volume of his voice rose."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Axel Reinhart: ""Your war councilor's father got us into this entanglemen..."*)

### Węzeł `[82]`
Mówca: **Axel Reinhart**
> ""Your war councilor's father got us into this entanglement to begin with. With this gas deal, you were about to acknowledge my country's sovereignty and take the possibility of a second invasion completely off the table. Obviously she wouldn't stand for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Romus: ""Think about it for a second. Isn't it more likely that L..."*)
  - -> `[89]` (*Player_Romus: ""Our fathers do not determine our destiny.""*)
  - -> `[92]` (*Player_Romus: ""Admit it. You don't *want* Rizia to acknowledge Palesian..."*)
  - -> `[91]` (*Player_Romus: ""Whatever she did, she acted alone. Neither I nor my othe..."*)

### Węzeł `[83]`
Mówca: **Axel Reinhart**
> ""Innocent? Are you serious?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "The volume of his voice rose."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Think about it for a second. Isn't it more likely that Lespia was behind the incident?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Incident_Border_KillSoldiers == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Incident_Border_KillSoldiers == true)"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Incident_Border_KillSoldiers == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Axel Reinhart: ""Lespia didn't kill my soldiers. That was all Rizia's doi..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Incident_Border_KillSoldiers == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Incident_Border_KillSoldiers"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Axel Reinhart: ""Are you suggesting we accuse an ATO member state of fals..."*)

### Węzeł `[88]`
Mówca: **Axel Reinhart**
> ""Lespia didn't kill my soldiers. That was all Rizia's doing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Axel Reinhart: ""Please, Your Majesty. Make this easy for us both.""*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our fathers do not determine our destiny.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Axel Reinhart: ""In this case, they do. The evidence is right in front of..."*)

### Węzeł `[90]`
Mówca: **Axel Reinhart**
> ""Are you suggesting we accuse an ATO member state of falsifying investigation results?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Axel Reinhart: ""Please, Your Majesty. Make this easy for us both.""*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whatever she did, she acted alone. Neither I nor my other councilors had any knowledge of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Axel Reinhart: ""I believe you.""*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Admit it. You don't *want* Rizia to acknowledge Palesian sovereignty. It's far more convenient for you to play the victim.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Axel Reinhart: ""That's very dangerous ground you're treading.""*)

### Węzeł `[93]`
Mówca: **Axel Reinhart**
> ""Please, Your Majesty. Make this easy for us both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Axel Reinhart: ""Arrest the Azaro woman, and we can get on with this deal..."*)

### Węzeł `[94]`
Mówca: **Axel Reinhart**
> ""Arrest the Azaro woman, and we can get on with this deal and our lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player_Romus: ""I still have my suspicions about the legitimacy of these..."*)
  - -> `[99]` (*Player_Romus: ""Rest assured that my war councilor will be punished for ..."*)
  - -> `[100]` (*Player_Romus: ""I'm sorry, Your Grace, but I cannot acknowledge the inve..."*)
  - -> `[101]` (*Player_Romus: ""No. Your Grand Duchy has double-crossed me for the last ..."*)

### Węzeł `[95]`
Mówca: **Axel Reinhart**
> ""That's very dangerous ground you're treading.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Axel Reinhart: ""Please, Your Majesty. Make this easy for us both.""*)

### Węzeł `[96]`
Mówca: **Axel Reinhart**
> ""In this case, they do. The evidence is right in front of our faces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Axel Reinhart: ""Please, Your Majesty. Make this easy for us both.""*)

### Węzeł `[97]`
Mówca: **Axel Reinhart**
> ""I believe you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Axel Reinhart: ""Please, Your Majesty. Make this easy for us both.""*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still have my suspicions about the legitimacy of these findings. But for the sake of lasting peace between our nations, Duchess Azaro will face justice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "There was a long silence on the other end. Laurento and H..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rest assured that my war councilor will be punished for her treasonous act. I will personally make sure she is shown no mercy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "There was a long silence on the other end. Laurento and H..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, Your Grace, but I cannot acknowledge the investigation results. I fully believe that my councilor is innocent.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "There was a long silence on the other end. Laurento and H..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Your Grand Duchy has double-crossed me for the last time. I don't know what scheme you're trying to pull, but I won't go along with it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "There was a long silence on the other end. Laurento and H..."*)

### Węzeł `[102]`
Mówca: **Narrator**
> "There was a long silence on the other end. Laurento and Hugo sat by with bated breath as I awaited the Duke's response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Axel Reinhart: ""I am sorry you see it that way, Your Majesty.""*)

### Węzeł `[103]`
Mówca: **Axel Reinhart**
> ""I am sorry you see it that way, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Axel Reinhart: ""You have left me with no choice. The Aureus deal is off.""*)

### Węzeł `[104]`
Mówca: **Axel Reinhart**
> ""You have left me with no choice. The Aureus deal is off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "Laurento shook his head anxiously."*)

### Węzeł `[105]`
Mówca: **Narrator**
> "Laurento shook his head anxiously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Axel Reinhart: ""The gas pipeline from the field to Rizia will be dismant..."*)

### Węzeł `[106]`
Mówca: **Axel Reinhart**
> ""The gas pipeline from the field to Rizia will be dismantled at once. All Rizian vessels in the vicinity will be ordered to leave, and Rizian access to the field will be blocked indefinitely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player_Romus: ""This was your plan all along, wasn't it? Take our money,..."*)
  - -> `[108]` (*Player_Romus: ""Who will buy the exploration rights from you, then? Lesp..."*)
  - -> `[127]` (*Player_Romus: ""Please, Your Grace. Surely we can still reach some sort ..."*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This was your plan all along, wasn't it? Take our money, then steal back your gas field.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Axel Reinhart: ""The fact that you could even think that is proof your ki..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who will buy the exploration rights from you, then? Lespia?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Axel Reinhart: ""That is confidential.""*)

### Węzeł `[109]`
Mówca: **Narrator**
> "There was a long silence on the other end. Laurento and Hugo sat by with bated breath as I awaited the Duke's response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Axel Reinhart: ""Very good, Your Majesty.""*)

### Węzeł `[110]`
Mówca: **Axel Reinhart**
> ""Very good, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Axel Reinhart: ""I'm glad we were able to resolve this little hiccup in a..."*)

### Węzeł `[111]`
Mówca: **Axel Reinhart**
> ""I'm glad we were able to resolve this little hiccup in a civil manner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player_Romus: ""Arresting the heir to one of Rizia's most important nobl..."*)
  - -> `[114]` (*Player_Romus: ""So am I. I am certain this unpleasant affair won't even ..."*)
  - -> `[120]` (*Player_Romus: ""So our gas deal is still on? Exactly as before?""*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Arresting the heir to one of Rizia's most important noble families is far from a 'little hiccup', Duke Reinhart. I hope you appreciate that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Axel Reinhart: ""I do.""*)

### Węzeł `[113]`
Mówca: **Axel Reinhart**
> ""I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So am I. I am certain this unpleasant affair won't even make it into the history books.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Axel Reinhart: ""It is nothing compared to the magnitude of what we are a..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player_Romus: ""Now, will you send my daughter back home?""*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now, will you send my daughter back home?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[111]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Axel Reinhart: ""Yes, yes, of course. Though I confess I've grown rather ..."*)

### Węzeł `[119]`
Mówca: **Axel Reinhart**
> ""Yes, yes, of course. Though I confess I've grown rather fond of having her around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "Laurento let out a long exhale of relief. Hugo's expressi..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So our gas deal is still on? Exactly as before?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Axel Reinhart: ""Exactly as before.""*)

### Węzeł `[121]`
Mówca: **Axel Reinhart**
> ""Exactly as before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[122]`
Mówca: **Axel Reinhart**
> ""It is nothing compared to the magnitude of what we are about to accomplish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player_Romus: ""And Vina? What about her?""*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And Vina? What about her?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[106]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Axel Reinhart: ""Assuming you respect our decision to cancel our deal, I ..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, Your Grace. Surely we can still reach some sort of compromise?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Axel Reinhart: ""Arresting Duchess Azaro *was* the compromise, I'm afraid.""*)

### Węzeł `[128]`
Mówca: **Axel Reinhart**
> ""Arresting Duchess Azaro *was* the compromise, I'm afraid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[129]`
Mówca: **Axel Reinhart**
> ""Assuming you respect our decision to cancel our deal, I shall send her back immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Axel Reinhart: ""Although I confess I've grown rather fond of having her ..."*)

### Węzeł `[130]`
Mówca: **Axel Reinhart**
> ""Although I confess I've grown rather fond of having her around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Axel Reinhart: ""Now. Do we have an understanding?""*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Axel Reinhart: ""Needless to say, Princess Vina shall be returned home at..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "Laurento let out a long exhale of relief. Hugo's expressi..."*)

### Węzeł `[134]`
Mówca: **Axel Reinhart**
> ""Needless to say, Princess Vina shall be returned home at once. Although I confess I've grown rather fond of having her around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "Laurento let out a long exhale of relief. Hugo's expressi..."*)

### Węzeł `[135]`
Mówca: **Axel Reinhart**
> ""The fact that you could even think that is proof your kingdom never wanted to reconcile with Pales in the first place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[136]`
Mówca: **Axel Reinhart**
> ""That is confidential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Axel Reinhart: ""I will send your daughter back immediately, assuming you..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Axel Reinhart: ""Now. Do we have an understanding?""*)

### Węzeł `[140]`
Mówca: **Axel Reinhart**
> ""I will send your daughter back immediately, assuming you respect our decision to cancel the deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Axel Reinhart: ""Now. Do we have an understanding?""*)

### Węzeł `[141]`
Mówca: **Axel Reinhart**
> ""Now. Do we have an understanding?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player_Romus: ""No. You signed the rights to the Aureus field over to Ri..."*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[149]` (*Player_Romus: ""You are making a mistake. But I will not challenge your ..."*)
  - -> `[148]` (*Player_Romus: ""Yes. We will forfeit our right to the field.""*)

### Węzeł `[142]`
**[WYBÓR GRACZA: ""No. You signed the rights to the Aureus field over to Rizia. If we must take it by force, we will." [Declare War]"]** — Mówca: **Player_Romus**
> ""No. You signed the rights to the Aureus field over to Rizia. If we must take it by force, we will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "Laurento looked stricken. Hugo's expression had turned de..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA: ""Listen here, you brat. Do you know what happens when you try to back a bull into a corner? It charges." [Declare War]"]** — Mówca: **Player_Romus**
> ""Listen here, you brat. Do you know what happens when you try to back a bull into a corner? It charges.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[141]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "Laurento looked stricken. Hugo's expression had turned de..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player_Romus: ""Listen here, you brat. Do you know what happens when you..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[147]`
Mówca: **Narrator**
> "Laurento looked stricken. Hugo's expression had turned determined."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Axel Reinhart: ""I suppose it was always going to come to this.""*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. We will forfeit our right to the field.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "Laurento looked defeated."*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are making a mistake. But I will not challenge your decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "Laurento looked defeated."*)

### Węzeł `[150]`
Mówca: **Narrator**
> "Laurento looked defeated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Axel Reinhart: ""That's very wise of you.""*)

### Węzeł `[151]`
Mówca: **Axel Reinhart**
> ""I suppose it was always going to come to this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Axel Reinhart: ""We defended ourselves against Rizia once. We are ready t..."*)

### Węzeł `[152]`
Mówca: **Axel Reinhart**
> ""We defended ourselves against Rizia once. We are ready to do so again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Axel Reinhart: ""And this time, we have a very comely young bargaining ch..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Axel Reinhart: ""But are *you* ready, Your Majesty?""*)

### Węzeł `[156]`
Mówca: **Axel Reinhart**
> ""And this time, we have a very comely young bargaining chip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn06_Pales_VinaKeptHostage = true"*)

### Węzeł `[157]`
Mówca: **Axel Reinhart**
> ""But are *you* ready, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "He hung up."*)

### Węzeł `[158]`
Mówca: **Narrator**
> "He hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Axel Reinhart");"*)

### Węzeł `[159]`
Mówca: **Narrator**
> "I looked at the clock. It was time for our visit to Terador."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn06_BorderInvestigation_DontAr..."*)

### Węzeł `[160]`
Mówca: **Axel Reinhart**
> ""That's very wise of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Axel Reinhart: ""Of course, I will make sure every nation in Merkopa is a..."*)

### Węzeł `[161]`
Mówca: **Axel Reinhart**
> ""Of course, I will make sure every nation in Merkopa is aware that Rizia sheltered a known criminal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Axel Reinhart: ""But other than that... no hard feelings, Your Majesty.""*)

### Węzeł `[162]`
Mówca: **Axel Reinhart**
> ""But other than that... no hard feelings, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "He hung up."*)

### Węzeł `[163]`
Mówca: **Narrator**
> "He hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Axel Reinhart");"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War = true;
RiziaDLC.Pales_PostIncident_Peace_Deal = false;
RiziaDLC.Diplomacy_Pales_NegotiatingPower = -100;
RiziaDLC.Policy_Diplomacy_TradeDeal_Pales = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pales_War"] = true;
Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] = false;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = -100;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Pales"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_G_LucitaExoneratedWar = true;..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy = false;
RiziaDLC.Policy_Diplomacy_TradeDeal_Pales = false;
RiziaDLC.Vina_Hostage = false; RiziaDLC.Pales_PostIncident_Peace_NoDeal = true; RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] = false;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Pales"] = false;
Variable["RiziaDLC.Vina_Hostage"] = false;
Variable["RiziaDLC.Pales_PostIncident_Peace_NoDeal"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn06_G_LucitaExoneratedNoWar = tru..."*)

### Węzeł `[166]`
Mówca: **Axel Reinhart**
> ""Thank you for seeing reason, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Player_Romus: ""We'll speak soon. For now, I have an arrest to make.""*)
  - -> `[169]` (*Player_Romus: ""I'll see you at the deal signing.""*)
  - -> `[170]` (*Player_Romus: ""I apologize for all this trouble.""*)

### Węzeł `[167]`
Mówca: **Narrator**
> "Laurento let out a long exhale of relief. Hugo's expression didn't change."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Axel Reinhart: ""Thank you for seeing reason, Your Majesty.""*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll speak soon. For now, I have an arrest to make.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "We hung up."*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll see you at the deal signing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "We hung up."*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I apologize for all this trouble.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "We hung up."*)

### Węzeł `[171]`
Mówca: **Narrator**
> "We hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Axel Reinhart");"*)

### Węzeł `[172]`
Mówca: **Narrator**
> "Laurento, Hugo and I looked at each other. Nobody spoke for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Hugo Toras: ""Well. As the Rizia Imperii police are under Ms. Azaro's ..."*)

### Węzeł `[173]`
Mówca: **Hugo Toras**
> ""Well. As the Rizia Imperii police are under Ms. Azaro's command, I'll order the Golden Guard to detain the Duchess until a proper arrest can be made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player_Romus: ""Tell them to tell her I'm sorry.""*)
  - -> `[175]` (*Player_Romus: ""Tell them to use as much force as they need to.""*)
  - -> `[176]` (*Player_Romus: ""I control the Golden Guard. I will give the orders.""*)

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell them to tell her I'm sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell them to use as much force as they need to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Hugo Toras: ""Yes... Of course.""*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I control the Golden Guard. I will give the orders.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "He bowed his head."*)

### Węzeł `[177]`
Mówca: **Hugo Toras**
> ""Yes... Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "He looked at me with sorrow in his eyes."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Hugo Toras: ""I will.""*)

### Węzeł `[181]`
Mówca: **Narrator**
> "He looked at me with sorrow in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Hugo Toras: ""I will.""*)

### Węzeł `[182]`
Mówca: **Hugo Toras**
> ""I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[183]`
Mówca: **Narrator**
> "He bowed his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Hugo Toras: ""Yes, of course.""*)

### Węzeł `[184]`
Mówca: **Hugo Toras**
> ""Yes, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[185]`
Mówca: **Narrator**
> "I called Titus in and told him he had work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested = true; RiziaDLC.Council_Securit..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Narrator: "I thought about the night Lucita and I had spent in Qalus..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_PromisedDate == true"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_PromisedDate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_PromisedDate == true"*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_PromisedDate == true)"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_PromisedDate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_PromisedDate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "I thought about the way Lucita had looked at me back in Q..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_PromisedDate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_PromisedDate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "I thought about the conversation I'd had with Lucita in M..."*)

### Węzeł `[192]`
Mówca: **Narrator**
> "I thought about the night Lucita and I had spent in Qalus and all the moments we'd stolen since then. Images of what could have been flashed through my mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true"*)

### Węzeł `[193]`
Mówca: **Narrator**
> "I thought about the way Lucita had looked at me back in Qalus. I had told her I'd take her on a date someday. We'd never get that chance now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true"*)

### Węzeł `[194]`
Mówca: **Narrator**
> "I thought about the night Lucita and I had spent in Qalus and all the moments we'd stolen since then. Images of what could have been flashed through my mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true"*)

### Węzeł `[195]`
Mówca: **Narrator**
> "I thought about the way Lucita had looked at me back in Qalus. I had told her I'd take her on a date someday. We'd never get that chance now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "I thought about the night Lucita and I had spent in Qalus..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_PromisedDate == true"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_PromisedDate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_PromisedDate == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_PromisedDate == true)"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_PromisedDate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_PromisedDate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "I thought about the way Lucita had looked at me back in Q..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_PromisedDate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_PromisedDate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "I thought about the conversation I'd had with Lucita in M..."*)

### Węzeł `[202]`
Mówca: **Narrator**
> "Still lost in my thoughts, I watched as Hugo called Titus into the room and told him he had work to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested = true; RiziaDLC.Council_Securit..."*)

### Węzeł `[203]`
Mówca: **Narrator**
> "I thought about the conversation I'd had with Lucita in Montaklar. If House Toras and House Azaro ever were truly allied, they weren't now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn06_BorderInvestigation_ArrestLucita = true; RiziaDLCSupport.News_Turn06_RH_LucitaArrested = true;
RiziaDLC.Pales_PostIncident_Peace_Deal = true;
RiziaDLCSupport.News_Turn06_G_BorderIncidentHandled = true;
RiziaDLCSupport.Reports_Turn06_PorteDrazon_LucitaArrested = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn06_BorderInvestigation_ArrestLucita"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_LucitaArrested"] = true;
Variable["RiziaDLC.Pales_PostIncident_Peace_Deal"] = true;
Variable["RiziaDLCSupport.News_Turn06_G_BorderIncidentHandled"] = true;
Variable["RiziaDLCSupport.Reports_Turn06_PorteDrazon_LucitaArrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Hugo Toras");
AddConversant("Laurento Esquibel");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Hugo Toras");
AddConversant("Laurento Esquibel");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player_Romus: ""Mr. Esquibel, Your Grace. To what do I owe this interrup..."*)
  - -> `[6]` (*Player_Romus: ""Please tell me there's good news.""*)
  - -> `[7]` (*Player_Romus: ""I hope this is quick, gentlemen. Duchess Azaro and I are..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Axel Reinhart");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Axel Reinhart: ""King Romus. I'm assuming you received the same report th..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Axel Reinhart");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Axel Reinhart");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "Laurento, Hugo and I looked at each other. Nobody spoke f..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Axel Reinhart");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Axel Reinhart");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War = true; RiziaDLC.Pales_PostIncident_Pe..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Axel Reinhart");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Axel Reinhart");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy = false; RiziaDLC.P..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn06_BorderInvestigation_DontArrestLucita = true;
RiziaDLCSupport.FactionReports_Turn06_ATO_CondemsIgnoringInvestigation = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn06_BorderInvestigation_DontArrestLucita"] = true;
Variable["RiziaDLCSupport.FactionReports_Turn06_ATO_CondemsIgnoringInvestigation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn06_G_LucitaExoneratedNoWar = true; RiziaDLCSupport.News_Turn06_RH_LucitaExoneratedNoWar = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_G_LucitaExoneratedNoWar"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_LucitaExoneratedNoWar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "I looked at the clock. It was time for our visit to Terador."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn06_G_LucitaExoneratedWar = true; RiziaDLCSupport.News_Turn06_RH_LucitaExoneratedWar = true; RiziaDLCSupport.News_Turn06_RH_GeneralAzaroOnWar = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn06_G_LucitaExoneratedWar"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_LucitaExoneratedWar"] = true;
Variable["RiziaDLCSupport.News_Turn06_RH_GeneralAzaroOnWar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "I looked at the clock. It was time for our visit to Terador."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Gridlock", "R_Gridlock_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Gridlock","R_Gridlock_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "It was early in the morning. Lucita and I were about to d..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn06_PorteDrazon_LucitaBehindIncident = true;
RiziaDLCSupport.FactionReports_Turn06_ATO_ArrestLucita = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_PorteDrazon_LucitaBehindIncident"] = true;
Variable["RiziaDLCSupport.FactionReports_Turn06_ATO_ArrestLucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Hugo Toras: ""The named culprit was Lucita Azaro, Your Majesty.""*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested = true;
RiziaDLC.Council_Security_Lucita = false; 
RiziaDLC.PoisonInvestigator_Lucita = false;
RiziaDLC.Relations_Lucita_Together = false;
EnableCodexEntry("Characters_Council_LucitaAzaro_Arrested"); RiziaDLC.Vina_Hostage = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Lucita_Arrested"] = true;
Variable["RiziaDLC.Council_Security_Lucita"] = false;
Variable["RiziaDLC.PoisonInvestigator_Lucita"] = false;
Variable["RiziaDLC.Relations_Lucita_Together"] = false;
EnableCodexEntry("Characters_Council_LucitaAzaro_Arrested");
Variable["RiziaDLC.Vina_Hostage"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Faction_HouseAzaro_Lucita = false;
RiziaDLC.Faction_HouseAzaro_Taddeus = true;
RiziaDLC.Faction_HouseAzaro_Carlos = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Faction_HouseAzaro_Lucita"] = false;
Variable["RiziaDLC.Faction_HouseAzaro_Taddeus"] = true;
Variable["RiziaDLC.Faction_HouseAzaro_Carlos"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn06_BorderInvestigation_Arrest..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Arrested == false"*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Arrested == false)"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Faction_HouseAzaro_Lucita = false; RiziaDLC.Fact..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Faction_HouseAzaro_Lucita = false; RiziaDLC.Fact..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Faction_HouseAzaro_Lucita = false;
RiziaDLC.Faction_HouseAzaro_Taddeus = false;
RiziaDLC.Faction_HouseAzaro_Carlos = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Faction_HouseAzaro_Lucita"] = false;
Variable["RiziaDLC.Faction_HouseAzaro_Taddeus"] = false;
Variable["RiziaDLC.Faction_HouseAzaro_Carlos"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn06_BorderInvestigation_Arrest..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true)"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Narrator: "As for what role, if any, she had played in my father's d..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "Still lost in my thoughts, I watched as Hugo called Titus..."*)

### Węzeł `[225]`
Mówca: **Narrator**
> "As for what role, if any, she had played in my father's death... I would probably never know."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "Still lost in my thoughts, I watched as Hugo called Titus..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true"*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true)"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "As for what role, if any, she had played in my father's d..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "I called Titus in and told him he had work to do."*)

### Węzeł `[229]`
Mówca: **Narrator**
> "As for what role, if any, she had played in my father's death... I would probably never know."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "I called Titus in and told him he had work to do."*)

### Węzeł `[230]`
Mówca: **Narrator**
> "I thought about the conversation I'd had with Lucita in Montaklar. If House Toras and House Azaro ever were truly allied, they weren't now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn06_Pales_VinaKeptHostage = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn06_Pales_VinaKeptHostage"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "He hung up."*)
