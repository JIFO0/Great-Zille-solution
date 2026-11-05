# Sordland/Turn10/FPnT_QueenPhoneCall

- **ID konwersacji:** `225`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/225_FPnT_QueenPhoneCall.md`
- **Liczba węzłów dialogowych:** 220
- **Liczba wyborów gracza:** 40

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[49]** Beatrice Livingston

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks`
- `BaseGame.Enable_Congress`
- `BaseGame.Gasom_Ownership_ForeignOwned`
- `BaseGame.Media_Censored`
- `BaseGame.RumburgIncident_DeclareWar`
- `BaseGame.RumburgIncident_RumburgKnows`
- `BaseGame.Security_Unrest_Military`
- `BaseGame.Situation_Diplomacy_Energy_PriceBalanced`
- `BaseGame.Situation_Diplomacy_Energy_PriceFluctuation`
- `BaseGame.Situation_Diplomacy_Energy_PriceSurge`
- `BaseGame.Situation_Law_MediaBias`
- `BaseGame.Situation_Law_MediaCensored`
- `BaseGame.Turn02_FPnT_Consulate_Condemn`
- `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment`
- `BaseGame.Turn09_Military_WeakAgainstRumburg`
- `BaseGame.Wehlen_JointOperation`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Ending_Coup`
- `BaseGame.GovernmentBudget`
- `BaseGame.Policy_Diplomacy_Rumburg_Trade`
- `BaseGame.Public_Opinion`
- `BaseGame.Relations_Iosef_Enemy`
- `BaseGame.Relations_Valken_Enemy`
- `BaseGame.Rumburg_AttacksSordland`
- `BaseGame.Rumburg_GivenEstordAndNarbel`
- `BaseGame.Rumburg_PeaceSummit`
- `BaseGame.Rumburg_War`
- `BaseGame.Situation_Diplomacy_Energy_ForeignInfluence`
- `BaseGame.Situation_Diplomacy_Energy_ForeignManipulation`
- `BaseGame.Situation_Diplomacy_Energy_Independence`
- `BaseGame.Situation_Diplomacy_Energy_PriceBalanced`
- `BaseGame.Situation_Diplomacy_Energy_PriceFluctuation`
- `BaseGame.Situation_Diplomacy_Energy_PriceSurge`
- `BaseGame.Situation_Diplomacy_RumburgAggression`
- `BaseGame.Situation_Diplomacy_Rumburg_GasPipeline`
- `BaseGame.Situation_Diplomacy_Rumburg_KA74`
- `BaseGame.Situation_Military_UnrulyGeneral`
- `BaseGame.Situation_Military_War`
- `BaseGameSupport.CountryReport_Turn10_Rumburg_RejectedSurrender`
- `BaseGameSupport.Journal_Turn10_QueenCall_GivenEstordAndNarbel`
- `BaseGameSupport.Journal_Turn10_QueenCall_PeaceSummit`
- `BaseGameSupport.Journal_Turn10_QueenCall_RefusedSurrender`
- `BaseGameSupport.News_Turn10_HP_CongressCancelled`
- `BaseGameSupport.News_Turn10_HP_RumburgInfluencesEnergy`
- `BaseGameSupport.News_Turn10_HP_Rumburg_GivenEstordAndNarbel`
- `BaseGameSupport.News_Turn10_LT_Rumburg_GivenEstordAndNarbel`
- `BaseGameSupport.News_Turn10_R_CongressCancelled`
- `BaseGameSupport.News_Turn10_R_Rumburg_GivenEstordAndNarbel`
- `BaseGameSupport.Report_Turn10_Estord_Surrendered`
- `BaseGameSupport.Report_Turn10_Narbel_Surrendered`
- `GameCondition.Turn10_FPnT_QueenPhoneCall`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **"“Aren't those titles a bit old-fashioned?”"** | `[7]` **Beatrice Livingston**: "“I am Queen Beatrice Livingston...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[4]` **Narrator**: "She let out a laugh." |
| `[9]` | **"“It is very nice to finally talk to you as well.”"** | `[7]` **Beatrice Livingston**: "“I am Queen Beatrice Livingston...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Beatrice Livingston**: "“Excellent.”" |
| `[15]` | **"“Am I supposed to be impressed?”"** | `[7]` **Beatrice Livingston**: "“I am Queen Beatrice Livingston...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Beatrice Livingston**: "“Indeed. You should be.”" |
| `[20]` | **"“My aim is to have peace in Merkopa. Nothing more.”"** | `[19]` **Beatrice Livingston**: "“Why now?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Beatrice Livingston**: "“You are quite an unusual presid..." |
| `[21]` | **"“I decided that Sordland would benefit from better relationships with its neighbors.”"** | `[19]` **Beatrice Livingston**: "“Why now?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Beatrice Livingston**: "“You are quite an unusual presid..." |
| `[22]` | **"“It was time to mend old wounds and rightfully pay for what we had done.”"** | `[19]` **Beatrice Livingston**: "“Why now?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Beatrice Livingston**: "“You are quite an unusual presid..." |
| `[25]` | **"“I am hoping this will mark an end to the aggressions between our countries.”"** | `[24]` **Beatrice Livingston**: "“I applaud and thank you from th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Beatrice Livingston**: "“Of course. This is the beginnin..." |
| `[26]` | **"“This is only the beginning. We have the potential to do so much more. Don't you t..."** | `[24]` **Beatrice Livingston**: "“I applaud and thank you from th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Beatrice Livingston**: "“You read my mind.”" |
| `[27]` | **"“Thank you.”"** | `[24]` **Beatrice Livingston**: "“I applaud and thank you from th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Beatrice Livingston**: "“You are very welcome.”" |
| `[34]` | **"“I don't like the sound of this.”"** | `[32]` **Beatrice Livingston**: "“An offer that has the potential..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Beatrice Livingston**: "“Don't be alarmed.”" |
| `[35]` | **"“Go on.”"** | `[32]` **Beatrice Livingston**: "“An offer that has the potential..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Beatrice Livingston**: "“Peace is very fragile and costl..." |
| `[36]` | **"“What kind of an offer?”"** | `[32]` **Beatrice Livingston**: "“An offer that has the potential..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Beatrice Livingston**: "“Peace is very fragile and costl..." |
| `[39]` | **"“There is always a but, isn't there?”"** | `[44]` **Beatrice Livingston**: "“But I do have a condition.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Beatrice Livingston**: "“I can't let my people suffer in..." |
| `[40]` | **"“What do you want?”"** | `[44]` **Beatrice Livingston**: "“But I do have a condition.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Beatrice Livingston**: "“I can't let my people suffer in..." |
| `[41]` | **"Let her continue."** | `[44]` **Beatrice Livingston**: "“But I do have a condition.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Beatrice Livingston**: "“I can't let my people suffer in..." |
| `[49]` | **"“If you want your peace, you'll need to come up with a better deal than that.”"** | `[52]` **Beatrice Livingston**: "“What do you think?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Beatrice Livingston**: "“A pity. Really.”" |
| `[50]` | **"“I'm afraid Sordland is not in a position to accept this deal. I must refuse.”"** | `[52]` **Beatrice Livingston**: "“What do you think?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Beatrice Livingston**: "“A pity. Really.”" |
| `[51]` | **"“Anything in the name of peace in East Merkopa. I accept.” [-1 Government Budget]"** | `[52]` **Beatrice Livingston**: "“What do you think?”" | `Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true` | `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGam...` | `[55]` **Beatrice Livingston**: "“Most exquisite.”" |
| `[63]` | **"“Have a good afternoon, Ms. Livingston.”"** | `[62]` **Beatrice Livingston**: "“If that is all, I wish you a go..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "The line dropped dead." |
| `[64]` | **"Hang up."** | `[62]` **Beatrice Livingston**: "“If that is all, I wish you a go..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Narrator**: "Just like that, I had thrown awa..." |
| `[70]` | **"“As long as Rumburg respects its boundaries.”"** | `[69]` **Beatrice Livingston**: "“I am certain that this will be ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Beatrice Livingston**: "“And as long as Sordland respect..." |
| `[71]` | **"“We have achieved so much in such a short span. It's been a pleasure.”"** | `[69]` **Beatrice Livingston**: "“I am certain that this will be ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Beatrice Livingston**: "“Likewise, Mr. Rayne.”" |
| `[72]` | **"“I sure hope so.”"** | `[69]` **Beatrice Livingston**: "“I am certain that this will be ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Beatrice Livingston**: "“Me too, Mr. Rayne.”" |
| `[87]` | **"“Why did you call?”"** | `[86]` **Beatrice Livingston**: "“Even after what Sordland has do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Beatrice Livingston**: "“Please listen to me carefully. ..." |
| `[88]` | **"“I did not hang up yet. That should show you *my* willingness to listen to your wh..."** | `[86]` **Beatrice Livingston**: "“Even after what Sordland has do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Beatrice Livingston**: "“Such vulgarity... as expected.”" |
| `[89]` | **"“You are so kind and generous.”"** | `[86]` **Beatrice Livingston**: "“Even after what Sordland has do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Beatrice Livingston**: "“I assure you, there is no need ..." |
| `[116]` | **"“You must be out of your mind if you thought I would give in to your threats.”"** | `[114]` **Beatrice Livingston**: "“Do not enter a war that you hav..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Rumburg_AttacksSordland"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn10_QueenCall_Refuse...`<br>*(+1 skryptów)* | `[120]` **Beatrice Livingston**: "“A pity. Really.”" |
| `[117]` | **"“Only Estord and Narbel? Nothing else?”"** | `[114]` **Beatrice Livingston**: "“Do not enter a war that you hav..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Beatrice Livingston**: "“That's all. Your two least impo..." |
| `[118]` | **"“You dare insult me? Your time is over, Your Highness. Along with your country. I ..."** | `[114]` **Beatrice Livingston**: "“Do not enter a war that you hav..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Rumburg_AttacksSordland"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn10_QueenCall_Refuse...`<br>*(+1 skryptów)* | `[120]` **Beatrice Livingston**: "“A pity. Really.”" |
| `[119]` | **"“I will not lead my country to a war. Peace must be maintained by any means necess..."** | `[114]` **Beatrice Livingston**: "“Do not enter a war that you hav..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Beatrice Livingston**: "“I am glad that you see it our w..." |
| `[131]` | **"“You must be joking. I have a duty to protect this nation. I will not sell pieces ..."** | `[130]` **Beatrice Livingston**: "“Do you comply with my demands?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Rumburg_AttacksSordland"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn10_QueenCall_Refuse...`<br>*(+1 skryptów)* | `[120]` **Beatrice Livingston**: "“A pity. Really.”" |
| `[132]` | **"“What are two backwater cities in the name of peace? I accept.”"** | `[130]` **Beatrice Livingston**: "“Do you comply with my demands?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Beatrice Livingston**: "“Most exquisite.”" |
| `[141]` | **"“Screw you.”"** | `[135]` **Beatrice Livingston**: "“You have protected your citizen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Beatrice Livingston**: "“I understand your frustration, ..." |
| `[143]` | **"“You will pay for this one day.”"** | `[135]` **Beatrice Livingston**: "“You have protected your citizen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Beatrice Livingston**: "“No need for additional adversit..." |
| `[146]` | **"“Thank you.”"** | `[135]` **Beatrice Livingston**: "“You have protected your citizen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Beatrice Livingston**: "“My people will talk to your peo..." |
| `[198]` | **"“Anything in the name of peace in East Merkopa. I accept.” [-2 Government Budget]"** | `[52]` **Beatrice Livingston**: "“What do you think?”" | `Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true`<br>`(Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true) == false` | `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGam...` | `[55]` **Beatrice Livingston**: "“Most exquisite.”" |
| `[199]` | **"“Anything in the name of peace in East Merkopa. I accept.” [-3 Government Budget]"** | `[52]` **Beatrice Livingston**: "“What do you think?”" | `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true) == false`<br>`(Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true) == false` | `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGam...` | `[55]` **Beatrice Livingston**: "“Most exquisite.”" |
| `[213]` | **"“Wait. Not so fast. I will accept your deal.” [-1 Government Budget]"** | `[62]` **Beatrice Livingston**: "“If that is all, I wish you a go..." | `Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true` | `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGam...` | `[55]` **Beatrice Livingston**: "“Most exquisite.”" |
| `[214]` | **"“Wait. Not so fast. I will accept your deal.” [-2 Government Budget]"** | `[62]` **Beatrice Livingston**: "“If that is all, I wish you a go..." | `Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true`<br>`(Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true) == false` | `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGam...` | `[55]` **Beatrice Livingston**: "“Most exquisite.”" |
| `[215]` | **"“Wait. Not so fast. I will accept your deal.” [-3 Government Budget]"** | `[62]` **Beatrice Livingston**: "“If that is all, I wish you a go..." | `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true) == false`<br>`(Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true) == false` | `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGam...` | `[55]` **Beatrice Livingston**: "“Most exquisite.”" |

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
  - -> `[11]` (*Narrator: "I was in my office, waiting for the call that could poten..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The phone started ringing. I took a deep breath as I held it to my ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "I heard the voice of the Queen of Rumburg from the other ..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "She let out a laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Beatrice Livingston: "“I am afraid protocol must be observed.”"*)

### Węzeł `[5]`
Mówca: **Beatrice Livingston**
> "“Mr. Rayne. How pleasing it is to finally get a chance to speak with you in person. ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Beatrice Livingston: "“I am Queen Beatrice Livingston. The Queen of the Four Co..."*)

### Węzeł `[6]`
Mówca: **Beatrice Livingston**
> "“Excellent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGam..."*)

### Węzeł `[7]`
Mówca: **Beatrice Livingston**
> "“I am Queen Beatrice Livingston. The Queen of the Four Corners of Merkopa, Defender of Castle Tzarsbourgh, Conqueror of the Tranquil Sea, Stout Protector of the Ancient Lands of Rum, Descendant of the Most Honorable King Edward the First and the Ruler of Rumburg. ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player: "“It is very nice to finally talk to you as well.”"*)
  - -> `[8]` (*Player: "“Aren't those titles a bit old-fashioned?”"*)
  - -> `[15]` (*Player: "“Am I supposed to be impressed?”"*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Aren't those titles a bit old-fashioned?”"]** — Mówca: **Player**
> "“Aren't those titles a bit old-fashioned?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "She let out a laugh."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "“It is very nice to finally talk to you as well.”"]** — Mówca: **Player**
> "“It is very nice to finally talk to you as well.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Beatrice Livingston: "“Excellent.”"*)

### Węzeł `[10]`
Mówca: **Beatrice Livingston**
> "“I am afraid protocol must be observed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGam..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "I was in my office, waiting for the call that could potentially change the future of Eastern Merkopa."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("PhoneRingPickUp");"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGam..."*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseG..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Beatrice Livingston: "“Now. I wanted to give you a call *personally* to thank y..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Beatrice Livingston: "“Now. Given the circumstances, I never thought I would be..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Am I supposed to be impressed?”"]** — Mówca: **Player**
> "“Am I supposed to be impressed?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Beatrice Livingston: "“Indeed. You should be.”"*)

### Węzeł `[16]`
Mówca: **Beatrice Livingston**
> "“Indeed. You should be.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGam..."*)

### Węzeł `[17]`
Mówca: **Beatrice Livingston**
> "“Now. I wanted to give you a call *personally* to thank you for your efforts in maintaining the peace in Eastern Merkopa.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Beatrice Livingston: "“The reparations Sordland paid were very well received by..."*)

### Węzeł `[18]`
Mówca: **Beatrice Livingston**
> "“The reparations Sordland paid were very well received by my people and we are forever thankful. Instead of burying the dark past, you are trying to heal the wounds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Beatrice Livingston: "“Forgive me for being so straightforward, but I have to a..."*)

### Węzeł `[19]`
Mówca: **Beatrice Livingston**
> "“Why now?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: "“My aim is to have peace in Merkopa. Nothing more.”"*)
  - -> `[21]` (*Player: "“I decided that Sordland would benefit from better relati..."*)
  - -> `[22]` (*Player: "“It was time to mend old wounds and rightfully pay for wh..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“My aim is to have peace in Merkopa. Nothing more.”"]** — Mówca: **Player**
> "“My aim is to have peace in Merkopa. Nothing more.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Beatrice Livingston: "“You are quite an unusual president for Sordland, Mr. Ray..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“I decided that Sordland would benefit from better relationships with its neighbors.”"]** — Mówca: **Player**
> "“I decided that Sordland would benefit from better relationships with its neighbors.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Beatrice Livingston: "“You are quite an unusual president for Sordland, Mr. Ray..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“It was time to mend old wounds and rightfully pay for what we had done.”"]** — Mówca: **Player**
> "“It was time to mend old wounds and rightfully pay for what we had done.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Beatrice Livingston: "“You are quite an unusual president for Sordland, Mr. Ray..."*)

### Węzeł `[23]`
Mówca: **Beatrice Livingston**
> "“You are quite an unusual president for Sordland, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Beatrice Livingston: "“I applaud and thank you from the bottom of my heart.”"*)

### Węzeł `[24]`
Mówca: **Beatrice Livingston**
> "“I applaud and thank you from the bottom of my heart.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: "“I am hoping this will mark an end to the aggressions bet..."*)
  - -> `[26]` (*Player: "“This is only the beginning. We have the potential to do ..."*)
  - -> `[27]` (*Player: "“Thank you.”"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "“I am hoping this will mark an end to the aggressions between our countries.”"]** — Mówca: **Player**
> "“I am hoping this will mark an end to the aggressions between our countries.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Beatrice Livingston: "“Of course. This is the beginning of a new era after all.”"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "“This is only the beginning. We have the potential to do so much more. Don't you think so?”"]** — Mówca: **Player**
> "“This is only the beginning. We have the potential to do so much more. Don't you think so?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Beatrice Livingston: "“You read my mind.”"*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Beatrice Livingston: "“You are very welcome.”"*)

### Węzeł `[28]`
Mówca: **Beatrice Livingston**
> "“Of course. This is the beginning of a new era after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Beatrice Livingston: "“I have an offer for you.”"*)

### Węzeł `[29]`
Mówca: **Beatrice Livingston**
> "“You read my mind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Beatrice Livingston: "“I have an offer for you.”"*)

### Węzeł `[30]`
Mówca: **Beatrice Livingston**
> "“You are very welcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Beatrice Livingston: "“I have an offer for you.”"*)

### Węzeł `[31]`
Mówca: **Beatrice Livingston**
> "“I have an offer for you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Beatrice Livingston: "“An offer that has the potential to improve the relations..."*)

### Węzeł `[32]`
Mówca: **Beatrice Livingston**
> "“An offer that has the potential to improve the relationship between our countries once and for all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: "“I don't like the sound of this.”"*)
  - -> `[35]` (*Player: "“Go on.”"*)
  - -> `[36]` (*Player: "“What kind of an offer?”"*)

### Węzeł `[33]`
Mówca: **Beatrice Livingston**
> "“Don't be alarmed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Beatrice Livingston: "“Peace is very fragile and costly, but I think we are off..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“I don't like the sound of this.”"]** — Mówca: **Player**
> "“I don't like the sound of this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Beatrice Livingston: "“Don't be alarmed.”"*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Go on.”"]** — Mówca: **Player**
> "“Go on.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Beatrice Livingston: "“Peace is very fragile and costly, but I think we are off..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“What kind of an offer?”"]** — Mówca: **Player**
> "“What kind of an offer?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Beatrice Livingston: "“Peace is very fragile and costly, but I think we are off..."*)

### Węzeł `[37]`
Mówca: **Beatrice Livingston**
> "“Peace is very fragile and costly, but I think we are off to a good start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Beatrice Livingston: "“I would like to hold a peace summit between Sordland and..."*)

### Węzeł `[38]`
Mówca: **Beatrice Livingston**
> "“I would like to hold a peace summit between Sordland and Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Beatrice Livingston: "“But I do have a condition.”"*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“There is always a but, isn't there?”"]** — Mówca: **Player**
> "“There is always a but, isn't there?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Beatrice Livingston: "“I can't let my people suffer in the name of peace with S..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "“What do you want?”"]** — Mówca: **Player**
> "“What do you want?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Beatrice Livingston: "“I can't let my people suffer in the name of peace with S..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: "Let her continue."]** — Mówca: **Player_Italic**
> "I let her continue."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Beatrice Livingston: "“I can't let my people suffer in the name of peace with S..."*)

### Węzeł `[42]`
Mówca: **Beatrice Livingston**
> "“I can't let my people suffer in the name of peace with Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Beatrice Livingston: "“I must admit your country has a resource that Rumburg ha..."*)

### Węzeł `[43]`
Mówca: **Beatrice Livingston**
> "“I must admit your country has a resource that Rumburg has long yearned for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Beatrice Livingston: "“Natural gas.”"*)

### Węzeł `[44]`
Mówca: **Beatrice Livingston**
> "“But I do have a condition.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: "“There is always a but, isn't there?”"*)
  - -> `[40]` (*Player: "“What do you want?”"*)
  - -> `[41]` (*Player_Italic: "Let her continue."*)

### Węzeł `[45]`
Mówca: **Beatrice Livingston**
> "“Natural gas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Beatrice Livingston: "“I want you to expand the Sordish natural gas pipeline to..."*)

### Węzeł `[46]`
Mówca: **Beatrice Livingston**
> "“I want you to expand the Sordish natural gas pipeline to Rumburg, and I want it 30% cheaper than your other neighbors.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Beatrice Livingston: "“If you accept, we will give Sordland licenses to make yo..."*)

### Węzeł `[47]`
Mówca: **Beatrice Livingston**
> "“If you accept, we will give Sordland licenses to make your own version of the KA-74. It should certainly be profitable in the long term, not to mention the aid it will give to your national defense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Beatrice Livingston: "“And then we will have our peace summit -- and perhaps st..."*)

### Węzeł `[48]`
Mówca: **Beatrice Livingston**
> "“And then we will have our peace summit -- and perhaps start talking about even more lucrative deals.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Beatrice Livingston: "“What do you think?”"*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "“If you want your peace, you'll need to come up with a better deal than that.”"]** — Mówca: **Player**
> "“If you want your peace, you'll need to come up with a better deal than that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Beatrice Livingston: "“A pity. Really.”"*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "“I'm afraid Sordland is not in a position to accept this deal. I must refuse.”"]** — Mówca: **Player**
> "“I'm afraid Sordland is not in a position to accept this deal. I must refuse.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Beatrice Livingston: "“A pity. Really.”"*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Anything in the name of peace in East Merkopa. I accept.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Anything in the name of peace in East Merkopa. I accept.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true`
- **Kontekst wejściowy (poprzednik):** `[52]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 1;"*)

### Węzeł `[52]`
Mówca: **Beatrice Livingston**
> "“What do you think?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true"*)
  - -> `[49]` (*Player: "“If you want your peace, you'll need to come up with a be..."*)
  - -> `[50]` (*Player: "“I'm afraid Sordland is not in a position to accept this ..."*)

### Węzeł `[53]`
Mówca: **Beatrice Livingston**
> "“A pity. Really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Beatrice Livingston: "“I thought you were different.”"*)

### Węzeł `[54]`
Mówca: **Beatrice Livingston**
> "“I thought you were different.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Beatrice Livingston: "“I'm afraid we are at the end of the reserved time for ou..."*)

### Węzeł `[55]`
Mówca: **Beatrice Livingston**
> "“Most exquisite.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_PeaceSummit = true; BaseGame.Policy_Dipl..."*)

### Węzeł `[56]`
Mówca: **Beatrice Livingston**
> "“Mr. Rayne, you have proven yourself to be a better leader than I thought.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Beatrice Livingston: "“We have just written history on this short call.”"*)

### Węzeł `[57]`
Mówca: **Beatrice Livingston**
> "“We have just written history on this short call.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Beatrice Livingston: "“My people will talk to your people, and we will make the..."*)

### Węzeł `[58]`
Mówca: **Beatrice Livingston**
> "“My people will talk to your people, and we will make the deal official.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Beatrice Livingston: "“I am certain that this will be the start of a lasting fr..."*)

### Węzeł `[59]`
Mówca: **Beatrice Livingston**
> "“A pity. Really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Beatrice Livingston: "“I thought you were different.”"*)

### Węzeł `[60]`
Mówca: **Beatrice Livingston**
> "“I thought you were different.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Beatrice Livingston: "“I'm afraid we are at the end of the reserved time for ou..."*)

### Węzeł `[61]`
Mówca: **Beatrice Livingston**
> "“I'm afraid we are at the end of the reserved time for our call.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Beatrice Livingston: "“If that is all, I wish you a good afternoon.”"*)

### Węzeł `[62]`
Mówca: **Beatrice Livingston**
> "“If that is all, I wish you a good afternoon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true"*)
  - -> `[63]` (*Player: "“Have a good afternoon, Ms. Livingston.”"*)
  - -> `[64]` (*Player_Italic: "Hang up."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“Have a good afternoon, Ms. Livingston.”"]** — Mówca: **Player**
> "“Have a good afternoon, Ms. Livingston.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "The line dropped dead."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "Hang up."]** — Mówca: **Player_Italic**
> "I hung up the phone."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "Just like that, I had thrown away any chance of a peace s..."*)

### Węzeł `[65]`
Mówca: **Beatrice Livingston**
> "“I'm afraid we are at the end of the reserved time for our call.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Beatrice Livingston: "“I wish you a good afternoon.”"*)

### Węzeł `[66]`
Mówca: **Beatrice Livingston**
> "“I wish you a good afternoon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "The line dropped dead."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "Just like that, I had thrown away any chance of a peace s..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_PeaceSummit = true;
BaseGame.Policy_Diplomacy_Rumburg_Trade = true;
BaseGame.Situation_Diplomacy_Rumburg_GasPipeline = true;
BaseGame.Situation_Diplomacy_Rumburg_KA74 = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Rumburg_PeaceSummit"] = true;
Variable["BaseGame.Policy_Diplomacy_Rumburg_Trade"] = true;
Variable["BaseGame.Situation_Diplomacy_Rumburg_GasPipeline"] = true;
Variable["BaseGame.Situation_Diplomacy_Rumburg_KA74"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[69]`
Mówca: **Beatrice Livingston**
> "“I am certain that this will be the start of a lasting friendship.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player: "“As long as Rumburg respects its boundaries.”"*)
  - -> `[71]` (*Player: "“We have achieved so much in such a short span. It's been..."*)
  - -> `[72]` (*Player: "“I sure hope so.”"*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "“As long as Rumburg respects its boundaries.”"]** — Mówca: **Player**
> "“As long as Rumburg respects its boundaries.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Beatrice Livingston: "“And as long as Sordland respects its own.”"*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "“We have achieved so much in such a short span. It's been a pleasure.”"]** — Mówca: **Player**
> "“We have achieved so much in such a short span. It's been a pleasure.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Beatrice Livingston: "“Likewise, Mr. Rayne.”"*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "“I sure hope so.”"]** — Mówca: **Player**
> "“I sure hope so.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Beatrice Livingston: "“Me too, Mr. Rayne.”"*)

### Węzeł `[73]`
Mówca: **Beatrice Livingston**
> "“And as long as Sordland respects its own.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Beatrice Livingston: "“I can't wait to meet with you in person at the peace sum..."*)

### Węzeł `[74]`
Mówca: **Beatrice Livingston**
> "“Likewise, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Beatrice Livingston: "“I can't wait to meet with you in person at the peace sum..."*)

### Węzeł `[75]`
Mówca: **Beatrice Livingston**
> "“Me too, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Beatrice Livingston: "“I can't wait to meet with you in person at the peace sum..."*)

### Węzeł `[76]`
Mówca: **Beatrice Livingston**
> "“I can't wait to meet with you in person at the peace summit. We have so much to talk about.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Beatrice Livingston: "“But for now, I'm afraid we are at the end of the reserve..."*)

### Węzeł `[77]`
Mówca: **Beatrice Livingston**
> "“But for now, I'm afraid we are at the end of the reserved time for our call.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Beatrice Livingston: "“I wish you a wonderful afternoon.”"*)

### Węzeł `[78]`
Mówca: **Beatrice Livingston**
> "“I wish you a wonderful afternoon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "The line dropped dead."*)

### Węzeł `[79]`
Mówca: **Narrator**
> "Was this the start of a new era?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_RumburgAggression = false"*)

### Węzeł `[80]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "Just like that, I had thrown away any chance of a peace s..."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "Just like that, I had thrown away any chance of a peace summit between Rumburg and Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Would our countries ever be able to reconcile?"*)

### Węzeł `[82]`
Mówca: **Narrator**
> "Would our countries ever be able to reconcile?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_RumburgAggression = false"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn10_FPnT_QueenPhoneCall = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn10_FPnT_QueenPhoneCall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Map_Music_Tense");  // Plays a custom..."*)

### Węzeł `[84]`
Mówca: **Beatrice Livingston**
> "“Forgive me for being so straightforward, but I have to ask.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Beatrice Livingston: "“Why now?”"*)

### Węzeł `[85]`
Mówca: **Beatrice Livingston**
> "“Now. Given the circumstances, I never thought I would be giving you a personal phone call. Yet here we are.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Beatrice Livingston: "“Even after what Sordland has done, I am showing you my w..."*)

### Węzeł `[86]`
Mówca: **Beatrice Livingston**
> "“Even after what Sordland has done, I am showing you my willingness to talk instead of cutting off communication.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: "“You are so kind and generous.”"*)
  - -> `[88]` (*Player: "“I did not hang up yet. That should show you *my* willing..."*)
  - -> `[87]` (*Player: "“Why did you call?”"*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "“Why did you call?”"]** — Mówca: **Player**
> "“Why did you call?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Beatrice Livingston: "“Please listen to me carefully. This is your last chance.”"*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "“I did not hang up yet. That should show you *my* willingness to listen to your whining.”"]** — Mówca: **Player**
> "“I did not hang up yet. That should show you *my* willingness to listen to your whining.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Beatrice Livingston: "“Such vulgarity... as expected.”"*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "“You are so kind and generous.”"]** — Mówca: **Player**
> "“You are so kind and generous.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Beatrice Livingston: "“I assure you, there is no need for sarcasm, Mr. Rayne.”"*)

### Węzeł `[90]`
Mówca: **Beatrice Livingston**
> "“I assure you, there is no need for sarcasm, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Beatrice Livingston: "“Please listen to me carefully. This is your last chance.”"*)

### Węzeł `[91]`
Mówca: **Beatrice Livingston**
> "“Such vulgarity... as expected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Beatrice Livingston: "“Please listen to me carefully. This is your last chance.”"*)

### Węzeł `[92]`
Mówca: **Beatrice Livingston**
> "“My demands are simple. You will give us control of our stolen ancestral homelands, Estord and Narbel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Beatrice Livingston: "“Those cities are surely of lesser importance to you judg..."*)

### Węzeł `[93]`
Mówca: **Beatrice Livingston**
> "“Those cities are surely of lesser importance to you judging by the way your country has treated them. That's all I ask.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Beatrice Livingston: "“If you fail to comply, to put it simply, we will take th..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_RumburgKnows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_RumburgKnows == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_RumburgKnows == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_RumburgKnows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_RumburgKnows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Beatrice Livingston: "“I know it all, Mr. Rayne. I know all about your plans. I..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_RumburgKnows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_RumburgKnows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[97]`
Mówca: **Beatrice Livingston**
> "“I know it all, Mr. Rayne. I know all about your plans. I can read your every move.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[98]`
Mówca: **Beatrice Livingston**
> "“I know that your military is weak and crumbling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Beatrice Livingston: "“I know that your military is weak and crumbling.”"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Security_Unrest_Military == true)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Beatrice Livingston: "“I know that Sordland is on the verge of being completely..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Security_Unrest_Military == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Beatrice Livingston: "“I am offering you a peaceful way out of your dire situat..."*)

### Węzeł `[105]`
Mówca: **Beatrice Livingston**
> "“I know that Sordland is on the verge of being completely under the control of your general staff.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Beatrice Livingston: "“I am offering you a peaceful way out of your dire situat..."*)

### Węzeł `[106]`
Mówca: **Beatrice Livingston**
> "“I am offering you a peaceful way out of your dire situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Beatrice Livingston: "“My demands are simple. You will give us control of our s..."*)

### Węzeł `[107]`
Mówca: **Beatrice Livingston**
> "“One does not have to look far to see the situation your military is in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Beatrice Livingston: "“I am offering you a peaceful way out of your dire situat..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Beatrice Livingston: "“One does not have to look far to see the situation your ..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Beatrice Livingston: "“I am offering you a peaceful way out of your dire situat..."*)

### Węzeł `[111]`
Mówca: **Beatrice Livingston**
> "“So, please. I beg you to have reason. Think of your citizens. Think of your people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Beatrice Livingston: "“Do not enter a war that you have no chance of winning.”"*)

### Węzeł `[112]`
Mówca: **Beatrice Livingston**
> "“If you fail to comply, to put it simply, we will take them by force.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Beatrice Livingston: "“A war, Mr. Rayne.”"*)

### Węzeł `[113]`
Mówca: **Beatrice Livingston**
> "“A war, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Beatrice Livingston: "“So, please. I beg you to have reason. Think of your citi..."*)

### Węzeł `[114]`
Mówca: **Beatrice Livingston**
> "“Do not enter a war that you have no chance of winning.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player: "“You must be out of your mind if you thought I would give..."*)
  - -> `[118]` (*Player: "“You dare insult me? Your time is over, Your Highness. Al..."*)
  - -> `[119]` (*Player: "“I will not lead my country to a war. Peace must be maint..."*)
  - -> `[117]` (*Player: "“Only Estord and Narbel? Nothing else?”"*)

### Węzeł `[115]`
Mówca: **Beatrice Livingston**
> "“Please listen to me carefully. This is your last chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_RumburgKnows == true"*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "“You must be out of your mind if you thought I would give in to your threats.”"]** — Mówca: **Player**
> "“You must be out of your mind if you thought I would give in to your threats.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_AttacksSordland = true"*)

### Węzeł `[117]`
**[WYBÓR GRACZA: "“Only Estord and Narbel? Nothing else?”"]** — Mówca: **Player**
> "“Only Estord and Narbel? Nothing else?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Beatrice Livingston: "“That's all. Your two least important cities.”"*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "“You dare insult me? Your time is over, Your Highness. Along with your country. I will see you on the battlefield.”"]** — Mówca: **Player**
> "“You dare insult me? Your time is over, Your Highness. Along with your country. I will see you on the battlefield.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_AttacksSordland = true"*)

### Węzeł `[119]`
**[WYBÓR GRACZA: "“I will not lead my country to a war. Peace must be maintained by any means necessary.”"]** — Mówca: **Player**
> "“I will not lead my country to a war. Peace must be maintained by any means necessary.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Beatrice Livingston: "“I am glad that you see it our way.”"*)

### Węzeł `[120]`
Mówca: **Beatrice Livingston**
> "“A pity. Really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Beatrice Livingston: "“At least my conscience is clear.”"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_AttacksSordland = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Rumburg_AttacksSordland"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_QueenCall_RefusedSurrender..."*)

### Węzeł `[122]`
Mówca: **Beatrice Livingston**
> "“At least my conscience is clear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Beatrice Livingston: "“I have given you a chance and you refused. You have fail..."*)

### Węzeł `[123]`
Mówca: **Beatrice Livingston**
> "“I have given you a chance and you refused. You have failed your people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Beatrice Livingston: "“War it is then, Mr. Rayne.”"*)

### Węzeł `[124]`
Mówca: **Beatrice Livingston**
> "“War it is then, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Beatrice Livingston: "“You will regret your decision until your last breath.”"*)

### Węzeł `[125]`
Mówca: **Beatrice Livingston**
> "“You will regret your decision until your last breath.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "The line dropped dead."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "And just like that, the Rumburg War had begun."*)

### Węzeł `[127]`
Mówca: **Narrator**
> "And just like that, the Rumburg War had begun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_Congress == false && BaseGame.RumburgInci..."*)

### Węzeł `[128]`
Mówca: **Beatrice Livingston**
> "“That's all. Your two least important cities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Beatrice Livingston: "“Do you comply with my demands?”"*)

### Węzeł `[129]`
Mówca: **Beatrice Livingston**
> "“I am glad that you see it our way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Beatrice Livingston: "“Do you comply with my demands?”"*)

### Węzeł `[130]`
Mówca: **Beatrice Livingston**
> "“Do you comply with my demands?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: "“You must be joking. I have a duty to protect this nation..."*)
  - -> `[132]` (*Player: "“What are two backwater cities in the name of peace? I ac..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "“You must be joking. I have a duty to protect this nation. I will not sell pieces of it.”"]** — Mówca: **Player**
> "“You must be joking. I have a duty to protect this nation. I will not sell pieces of it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_AttacksSordland = true"*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "“What are two backwater cities in the name of peace? I accept.”"]** — Mówca: **Player**
> "“What are two backwater cities in the name of peace? I accept.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Beatrice Livingston: "“Most exquisite.”"*)

### Węzeł `[133]`
Mówca: **Beatrice Livingston**
> "“Most exquisite.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel = true;"*)

### Węzeł `[134]`
Mówca: **Beatrice Livingston**
> "“Mr. Rayne, you have proven yourself to be a better leader than I thought.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Beatrice Livingston: "“You have protected your citizens and fulfilled your duty..."*)

### Węzeł `[135]`
Mówca: **Beatrice Livingston**
> "“You have protected your citizens and fulfilled your duty. For that, I applaud you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player: "“You will pay for this one day.”"*)
  - -> `[141]` (*Player: "“Screw you.”"*)
  - -> `[146]` (*Player: "“Thank you.”"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup = true; BaseGame.Rumburg_War = false..."*)

### Węzeł `[137]`
Mówca: **Beatrice Livingston**
> "“My people will talk to your people and we will make the deal official.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Beatrice Livingston: "“For now, I'm afraid we are at the end of the reserved ti..."*)

### Węzeł `[138]`
Mówca: **Beatrice Livingston**
> "“For now, I'm afraid we are at the end of the reserved time for our call.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Beatrice Livingston: "“I wish you a wonderful afternoon.”"*)

### Węzeł `[139]`
Mówca: **Beatrice Livingston**
> "“I wish you a wonderful afternoon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Beatrice Livingston: "“Goodbye, Mr. Rayne.”"*)

### Węzeł `[140]`
Mówca: **Narrator**
> "And just like that, part of my country was now Rumburg territory."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "The decision wouldn't make me popular. But it was better ..."*)

### Węzeł `[141]`
**[WYBÓR GRACZA: "“Screw you.”"]** — Mówca: **Player**
> "“Screw you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Beatrice Livingston: "“I understand your frustration, but you have made the bet..."*)

### Węzeł `[142]`
Mówca: **Beatrice Livingston**
> "“I understand your frustration, but you have made the better choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Beatrice Livingston: "“My people will talk to your people and we will make the ..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA: "“You will pay for this one day.”"]** — Mówca: **Player**
> "“You will pay for this one day.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Beatrice Livingston: "“No need for additional adversity at this point.”"*)

### Węzeł `[144]`
Mówca: **Beatrice Livingston**
> "“No need for additional adversity at this point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Beatrice Livingston: "“My people will talk to your people and we will make the ..."*)

### Węzeł `[145]`
Mówca: **Beatrice Livingston**
> "“Goodbye, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "The line dropped dead."*)

### Węzeł `[146]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Beatrice Livingston: "“My people will talk to your people and we will make the ..."*)

### Węzeł `[147]`
Mówca: **Narrator**
> "I heard the voice of the Queen of Rumburg from the other side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Beatrice Livingston: "“Mr. Rayne. How pleasing it is to finally get a chance to..."*)

### Węzeł `[148]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Ownership_ForeignOwned == true && BaseGame..."*)

### Węzeł `[149]`
Mówca: **Narrator**
> "Just like that, I had thrown away any chance of a peace summit between Rumburg and Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Would our countries ever be able to reconcile?"*)

### Węzeł `[150]`
Mówca: **Narrator**
> "Just like that, there was about to be peace between Rumburg and Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "Was this the start of a new era?"*)

### Węzeł `[151]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "And just like that, part of my country was now Rumburg te..."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "The decision wouldn't make me popular. But it was better than the alternative."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_Congress == false && BaseGame.RumburgInci..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup = true;
BaseGame.Rumburg_War = false;
BaseGame.Situation_Military_War = false;
BaseGame.Relations_Iosef_Enemy = true; BaseGame.Relations_Valken_Enemy = true; BaseGame.Situation_Military_UnrulyGeneral = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Ending_Coup"] = true;
Variable["BaseGame.Rumburg_War"] = false;
Variable["BaseGame.Situation_Military_War"] = false;
Variable["BaseGame.Relations_Iosef_Enemy"] = true;
Variable["BaseGame.Relations_Valken_Enemy"] = true;
Variable["BaseGame.Situation_Military_UnrulyGeneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_QueenCall_GivenEstordAndNa..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_QueenCall_PeaceSummit = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_QueenCall_PeaceSummit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "EnableNews("G_Rumburg_TradeDeal");"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_QueenCall_GivenEstordAndNarbel = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_QueenCall_GivenEstordAndNarbel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn10_Narbel_Surrendered = true; ..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn10_QueenCall_RefusedSurrender = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_QueenCall_RefusedSurrender"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.CountryReport_Turn10_Rumburg_RejectedSurr..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_RumburgAggression = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_RumburgAggression"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_Congress == false && BaseGame.RumburgInci..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.CountryReport_Turn10_Rumburg_RejectedSurrender = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn10_Rumburg_RejectedSurrender"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Beatrice Livingston: "“A pity. Really.”"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn10_Narbel_Surrendered = true; BaseGameSupport.Report_Turn10_Estord_Surrendered = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn10_Narbel_Surrendered"] = true;
Variable["BaseGameSupport.Report_Turn10_Estord_Surrendered"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_R_Rumburg_GivenEstordAndNarbe..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableNews("G_Rumburg_TradeDeal");`
- **Efekt skryptowy (`userScript`):** `EnableNews("G_Rumburg_TradeDeal");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Beatrice Livingston: "“Mr. Rayne, you have proven yourself to be a better leade..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_R_Rumburg_GivenEstordAndNarbel = true; BaseGameSupport.News_Turn10_HP_Rumburg_GivenEstordAndNarbel = true; BaseGameSupport.News_Turn10_LT_Rumburg_GivenEstordAndNarbel = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_R_Rumburg_GivenEstordAndNarbel"] = true;
Variable["BaseGameSupport.News_Turn10_HP_Rumburg_GivenEstordAndNarbel"] = true;
Variable["BaseGameSupport.News_Turn10_LT_Rumburg_GivenEstordAndNarbel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "EnableNews("G_Rumburg_GivenEstordAndNarbel");"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_Congress == false && BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_Congress == false && BaseGame.RumburgInci..."*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Enable_Congress == false && BaseGame.RumburgIn..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_Congress == false && BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Enable_Congress"] == false  and  Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_HP_CongressCancelled = true"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Enable_Congress == false && BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Enable_Congress"] == false  and  Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn10_FPnT_QueenPhoneCall = true"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_HP_CongressCancelled = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_HP_CongressCancelled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaCensored == false"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaCensored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaCensored == false"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaCensored == false)"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaCensored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaCensored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_R_CongressCancelled = true"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaCensored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaCensored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn10_FPnT_QueenPhoneCall = true"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_R_CongressCancelled = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_R_CongressCancelled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn10_FPnT_QueenPhoneCall = true"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Rumburg", "Friendly");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Rumburg","Friendly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Rizia", "Frie..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("PhoneRingPickUp");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("PhoneRingPickUp");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The phone started ringing. I took a deep breath as I held..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayCustomMapMusic("Map_Music_Tense");

// Plays a custom map music after conversation is done. This works only once for one conversation`
- **Efekt skryptowy (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");
-- Plays a custom map music after conversation is done. This works only once for one conversation;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceSurge == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceSurge == true"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceSurge == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_ForeignInfluence = tr..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceBalanced = false; 
BaseGame.Situation_Diplomacy_Energy_PriceSurge = false;
BaseGame.Situation_Diplomacy_Energy_PriceFluctuation = true;
BaseGameSupport.News_Turn10_HP_RumburgInfluencesEnergy = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] = true;
Variable["BaseGameSupport.News_Turn10_HP_RumburgInfluencesEnergy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Rumburg", "Fr..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_ForeignInfluence = true; BaseGame.Situation_Diplomacy_Energy_ForeignManipulation = false; 
BaseGame.Situation_Diplomacy_Energy_Independence = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Energy_ForeignInfluence"] = true;
Variable["BaseGame.Situation_Diplomacy_Energy_ForeignManipulation"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_Independence"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceBalanced = false..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true"*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Energy_PriceFluctuation ==..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_ForeignInfluence = tr..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_ForeignManipulation =..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_ForeignManipulation = true; 
BaseGame.Situation_Diplomacy_Energy_ForeignInfluence = false;
BaseGame.Situation_Diplomacy_Energy_Independence = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Energy_ForeignManipulation"] = true;
Variable["BaseGame.Situation_Diplomacy_Energy_ForeignInfluence"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_Independence"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceBalanced = false..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Ownership_ForeignOwned == true && BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Ownership_ForeignOwned == true && BaseGame..."*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Gasom_Ownership_ForeignOwned == true && BaseGa..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Ownership_ForeignOwned == true && BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Gasom_Ownership_ForeignOwned"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_ForeignInfluence = tr..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Gasom_Ownership_ForeignOwned == true && BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Gasom_Ownership_ForeignOwned"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceSurge == true"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true)"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 3;"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_QueenCall_PeaceSummit = true"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 8;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 8;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_QueenCall_PeaceSummit = true"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“Anything in the name of peace in East Merkopa. I accept...."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Beatrice Livingston: "“Most exquisite.”"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true"*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Energy_PriceFluctuation ==..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Player: "“Anything in the name of peace in East Merkopa. I accept...."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player: "“Anything in the name of peace in East Merkopa. I accept...."*)

### Węzeł `[198]`
**[WYBÓR GRACZA: "“Anything in the name of peace in East Merkopa. I accept.” [-2 Government Budget]"]** — Mówca: **Player**
> "“Anything in the name of peace in East Merkopa. I accept.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true` AND `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[52]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 2;"*)

### Węzeł `[199]`
**[WYBÓR GRACZA: "“Anything in the name of peace in East Merkopa. I accept.” [-3 Government Budget]"]** — Mówca: **Player**
> "“Anything in the name of peace in East Merkopa. I accept.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true) == false` AND `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[52]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 3;"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Beatrice Livingston: "“Most exquisite.”"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Beatrice Livingston: "“Most exquisite.”"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaBias == true)"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 6;"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 8;"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 6;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 6;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn10_QueenCall_PeaceSummit = true"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Rizia", "Friendly");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Rizia","Friendly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "Just like that, there was about to be peace between Rumbu..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true)"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Player: "“Wait. Not so fast. I will accept your deal.” [-1 Governm..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Energy_PriceFluctuation ==..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Player: "“Wait. Not so fast. I will accept your deal.” [-2 Governm..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Player: "“Wait. Not so fast. I will accept your deal.” [-3 Governm..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA: "“Wait. Not so fast. I will accept your deal.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Wait. Not so fast. I will accept your deal.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true`
- **Kontekst wejściowy (poprzednik):** `[62]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 1;"*)

### Węzeł `[214]`
**[WYBÓR GRACZA: "“Wait. Not so fast. I will accept your deal.” [-2 Government Budget]"]** — Mówca: **Player**
> "“Wait. Not so fast. I will accept your deal.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true` AND `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[62]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 2;"*)

### Węzeł `[215]`
**[WYBÓR GRACZA: "“Wait. Not so fast. I will accept your deal.” [-3 Government Budget]"]** — Mówca: **Player**
> "“Wait. Not so fast. I will accept your deal.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true) == false` AND `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[62]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 3;"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Beatrice Livingston: "“Most exquisite.”"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Beatrice Livingston: "“Most exquisite.”"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Beatrice Livingston: "“Most exquisite.”"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableNews("G_Rumburg_GivenEstordAndNarbel");`
- **Efekt skryptowy (`userScript`):** `EnableNews("G_Rumburg_GivenEstordAndNarbel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Beatrice Livingston: "“Mr. Rayne, you have proven yourself to be a better leade..."*)
