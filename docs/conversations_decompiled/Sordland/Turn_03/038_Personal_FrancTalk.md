# Sordland/Turn03/Personal_FrancTalk

- **ID konwersacji:** `38`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/038_Personal_FrancTalk.md`
- **Liczba węzłów dialogowych:** 402
- **Liczba wyborów gracza:** 99

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[31]** Franc

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed`
- `BaseGame.Bill_Turn02_TourismCulturalPreservation_Vetoed`
- `BaseGame.Decision_Turn02_EconomicRelief_DontEnactPlan`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGame.Prologue_Protest_Girl_Crushed`
- `BaseGame.Prologue_Studyplace_Holsord_Law`
- `BaseGame.Prologue_Studyplace_Lachaven_Economics`
- `BaseGame.Prologue_University_1stCoup_Protested`
- `BaseGame.Prologue_University_Group_HumanRights`
- `BaseGame.Prologue_University_Group_StudentCouncil`
- `BaseGame.Prologue_University_Political_Active`
- `BaseGame.Prologue_University_Political_Nationalist`
- `BaseGame.Prologue_University_Political_Socialist`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Relations_Franc_MadAtDinner`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Situation_Law_MediaBias`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn02_InT_Corporation_SordishState`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`
- `BaseGameIsolated.Turn03_Franc_Coup27_Listened`
- `BaseGameIsolated.Turn03_Franc_Coup28_Listened`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Economy`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Situation_Law_FreedomOfPress`
- `BaseGame.Situation_Law_MediaBias`
- `BaseGameIsolated.Turn03_Franc_Coup27_Listened`
- `BaseGameIsolated.Turn03_Franc_Coup28_Listened`
- `BaseGameSupport.CountryReport_Turn03_Rizia_EnergyCooperationOffer`
- `BaseGameSupport.FactionReport_Turn03_ATO_AidSupportAgnolia`
- `BaseGameSupport.News_Turn03_E_Gasom_Critique`
- `BaseGameSupport.News_Turn03_E_GreenBill_BadForGrowth`
- `BaseGameSupport.News_Turn03_G_AnrakaDiversifiesInvestments`
- `BaseGameSupport.News_Turn03_G_CSPWorkerReportCritique`
- `BaseGameSupport.News_Turn03_HP_AttackerOpenedFire`
- `BaseGameSupport.News_Turn03_HP_GreenBillCritique`
- `BaseGameSupport.News_Turn03_LT_DerbyPostponedBanYS`
- `BaseGameSupport.News_Turn03_LT_DerbyPostponedNoRYBan`
- `BaseGameSupport.News_Turn03_LT_Gasom_RiziaInvestInterest`
- `BaseGameSupport.News_Turn03_R_GreenBill_Support`
- `BaseGameSupport.News_Turn03_R_UndemocraticElections`
- `BaseGameSupport.News_Turn03_ST_TourismBill_CritiqueVeto`
- `BaseGameSupport.News_Turn03_ST_TourismBill_SupportSign`
- `BaseGameSupport.Report_Turn03_Antel_PrisonRiot`
- `BaseGameSupport.Report_Turn03_Holsord_L1_SSC`
- `BaseGameSupport.Report_Turn03_Holsord_L1_Underhall`
- `BaseGameSupport.Report_Turn03_Holsord_USPReport`
- `BaseGameSupport.Report_Turn03_Lachaven_H3_SSC`
- `BaseGameSupport.Report_Turn03_Lachaven_H3_Underhall`
- `BaseGameSupport.Report_Turn03_Morna_IndustrialOutput`
- `GameCondition.Turn03_Personal_FrancTalk`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 42

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGameSupport.CountryReport_Turn03_Rizia_EnergyCooperationOffer`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[139]` (Franc): `Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] = true;`
- Węzeł `[140]` (Franc): `Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] = true;`
- Węzeł `[159]` (Franc): `Variable["BaseGameSupport.News_Turn03_HP_AttackerOpenedFire"] = true; Variable["BaseGameSupport.R...`
- Węzeł `[206]` (Franc): `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- Węzeł `[207]` (Franc): `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 2;`
- Węzeł `[210]` (Franc): `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 2;`
- Węzeł `[220]` (Franc): `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 2;`
- Węzeł `[231]` (Franc): `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- *...oraz 34 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Franc)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It was a Saturday afternoon, my first break from work in what felt like years, and the weather couldn't have been more perfect. Trying to keep my mind off the upheaval sparked by the Circas assassination, I lit the backyard grill."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Monica and Deana were out shopping for craft supplies, and I'd given the staff the day off. It was just myself and Franc at home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Sure enough, as soon as Franc glimpsed the grill and the meat, he stepped outside to join me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[6]`
Mówca: **Franc**
> ""Don't get any ideas, Dad. I'm only here for the ribs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[9]`
  - -> `[10]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "“And that, my boy, is how bribery works.”"]** — Mówca: **Player**
> "“And that, my boy, is how bribery works.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Franc**
> "“Ha. What a great example you're setting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`
  - -> `[204]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "“Well, you're going to have to work for them. Help me fan these flames.”"]** — Mówca: **Player**
> "“Well, you're going to have to work for them. Help me fan these flames.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "“Children who talk back to their fathers don't get dinner. Fan these flames, will you?”"]** — Mówca: **Player**
> "“Children who talk back to their fathers don't get dinner. Fan these flames, will you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[11]`
Mówca: **Narrator**
> "Franc sighed and waved the fan lazily, almost causing the fire to die out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[21]`
  - -> `[13]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "“You keep it up at that rate and we'll never have dinner. Put your back into it!”"]** — Mówca: **Player**
> "“You keep it up at that rate and we'll never have dinner. Put your back into it!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[13]`
**[WYBÓR GRACZA: ""Never mind, I'll do it myself. Just bring the large serving platter from the kitchen.”"]** — Mówca: **Player**
> ""Never mind, I'll do it myself. Just bring the large serving platter from the kitchen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""It worked, didn't it? Everyone has their price. Remember that.""]** — Mówca: **Player**
> ""It worked, didn't it? Everyone has their price. Remember that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“It's politics, Franc. You're old enough to learn the ways of the world.'"]** — Mówca: **Player**
> "“It's politics, Franc. You're old enough to learn the ways of the world.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Narrator**
> "He looked like he was going to say something, but quickly closed his mouth and nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Franc**
> "“Point taken.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[18]`
Mówca: **Franc**
> "“I am trying.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Narrator**
> "He continued just as listlessly as before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[13]`
  - -> `[224]`

### Węzeł `[20]`
Mówca: **Franc**
> "“Oh, I'm one of your employees now?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[28]`
  - -> `[39]`
  - -> `[27]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "Show him how to do it properly."]** — Mówca: **Player_Italic**
> "I yanked the fan out of Franc's hands and started vigorously fanning the flames."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“See? It's easy.""]** — Mówca: **Player**
> "“See? It's easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "“My father would have slapped me for this.”"]** — Mówca: **Player**
> "“My father would have slapped me for this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Hard work usually pays off.”"]** — Mówca: **Player**
> "“Hard work usually pays off.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Franc**
> "“I guess I should be grateful that you don't...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[26]`
Mówca: **Franc**
> "“Right, Dad. *Usually*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Don't make me angry. Do as I say.”"]** — Mówca: **Player**
> "“Don't make me angry. Do as I say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "“Can't I even request something from my son now?”"]** — Mówca: **Player**
> "“Can't I request a favor from my son?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[29]`
Mówca: **Franc**
> "“Uh oh. I know that look.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Narrator**
> "Franc returned with a tray large enough to hold all the meat and vegetables. The fire was still burning weakly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Franc**
> "“Here, let me try.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Narrator**
> "He grabbed the fan and started quickly waving it over the coals. The fire roared to life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Good job.”"]** — Mówca: **Player**
> "“Good job.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“Not bad, son, not bad.”"]** — Mówca: **Player**
> "“Not bad, son, not bad.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[35]`
Mówca: **Narrator**
> "He turned to look at me with a grin on his face, as if he was expecting praise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`
  - -> `[283]`
  - -> `[36]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I said nothing and Franc's smile faded. We both stared into the fire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[37]`
Mówca: **Franc**
> "“Thank you, sir. It is in our utmost interest to fulfill our duties with precision. The grilling shall commence in exactly 1 minute and 32 seconds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Narrator**
> "That was a spot-on impersonation of Lucian. We looked at each other for a second, then burst out laughing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "Stare at Franc angrily."]** — Mówca: **Player_Italic**
> "I said nothing and turned to Franc, looking straight into his eyes. He immediately understood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[40]`
Mówca: **Narrator**
> "It was rare for Franc to agree with anything I said nowadays. I turmed to tend to the fire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[41]`
Mówca: **Narrator**
> "I realized my throat was parched. There was a six-pack of beer in the kitchen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`
  - -> `[45]`

### Węzeł `[42]`
**[WYBÓR GRACZA: ""Franc, can you get me a beer?""]** — Mówca: **Player**
> ""Franc, can you get me a beer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[43]`
**[WYBÓR GRACZA: ""Why don't you bring us a couple of beers?""]** — Mówca: **Player**
> ""Why don't you bring us a couple of beers?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Narrator**
> "He looked at me in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "Get up and grab a beer."]** — Mówca: **Player_Italic**
> "I got up, grabbed myself a beer and returned to the grill."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[46]`
Mówca: **Narrator**
> "Franc got up without saying anything, went to the kitchen and returned with a cold beer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "Open the beer."]** — Mówca: **Player_Italic**
> "I opened the beer and gazed out at the city skyline. Father and son, we enjoyed the silence together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[49]`
Mówca: **Franc**
> ""You mean, I can--? But Mom told me--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Narrator**
> "He stopped himself, quickly ran inside and returned with two beers. We cracked them open, clinked the bottles and gazed out at the city skyline."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[51]`
Mówca: **Narrator**
> "I opened the beer and gazed out at the city skyline. Father and son, we enjoyed the silence together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Narrator**
> "I opened it, sat down, and gazed out at the city skyline with my son."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Narrator**
> "For a moment, my thoughts flashed back to my childhood and my relationship with my own father."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Franc**
> "“Dad, can I ask you something?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`
  - -> `[69]`

### Węzeł `[55]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[57]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Deyr_Poor == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Lachaven_Rich == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[61]`
Mówca: **Narrator**
> "My father was a poor man who struggled to provide for us on his meager income. He put me to work on the farm long before I was Franc's age, and even then, we couldn't always make ends meet. Yet, we were always close as a family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[62]`
Mówca: **Narrator**
> "My father was a rich man. We never had to worry about food, clothes, or anything else. Yet he was nearly always away -- and constantly distracted on the rare occasions when he was at home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[63]`
Mówca: **Narrator**
> "My father was a hard-working man and always had our best interests in mind -- or at least, that's what he always said. But he had a temper, and would lash out at my mother in fights I could hear from my bedroom. By the time I was Franc's age, we seldom spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[64]`
Mówca: **Narrator**
> "Now that I was the president, I knew Franc would never face the same hardships I had. I couldn't deny that I felt a bit jealous."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[65]`
Mówca: **Narrator**
> "Now that I was the president, I was worried that I would end up just like my father. Distant and absent from Franc's life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[66]`
Mówca: **Narrator**
> "Now that I was the president, I was facing more stress than my father ever had. I would have to work hard not to take my frustrations out on my family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "“Go on.”"]** — Mówca: **Player**
> "“Go on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "“We are family. You can ask anything.”"]** — Mówca: **Player**
> "“We are family. You can ask anything.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "Wait for him to continue."]** — Mówca: **Player_Italic**
> "I waited for him to think about what to say."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Franc**
> "“It's just... I feel like there's so much you've been hiding from me. About your past, and about what's going on right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[71]`
Mówca: **Franc**
> "“But... what was it like, back then? Uncle Petr said the two of you went through a lot...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Franc**
> "“I'm not a kid anymore. You can tell me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Narrator**
> "Before I could gather my thoughts, the familiar images started flashing before my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Narrator**
> "Images of soldiers advancing towards me and my friends, weapons drawn. Of people I knew -- friends and neighbors -- being dragged through streets and murdered in alleyways."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[75]`
Mówca: **Narrator**
> "And that little girl's face..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[76]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "“I don't want to talk about it.”"]** — Mówca: **Player**
> "“I don't want to talk about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“Those were dark times.”"]** — Mówca: **Player**
> "“Those were dark times.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Narrator**
> "Hearing the faint trembling in my voice, Franc understood and pushed no further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[79]`
Mówca: **Franc**
> "“It seems like it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "“But you're nearly a grown man. Let's talk about it.”"]** — Mówca: **Player**
> "“But you're nearly a grown man. Let's talk about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "“Let's change the subject.”"]** — Mówca: **Player**
> "“Let's change the subject.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Franc**
> "“It's okay. I'm sorry. I shouldn't have asked you about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[83]`
**[WYBÓR GRACZA: ""I was barely older than you are now...""]** — Mówca: **Player**
> ""I was barely older than you are now, studying law at the Holsord State University. I was a freshman. Excited and young.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[84]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Holsord_Law == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Holsord_Law == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[86]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Studyplace_Holsord_Law == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Lachaven_Economics == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Lachaven_Economics == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Studyplace_Lachaven_Economics == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[90]`
**[WYBÓR GRACZA: ""I was barely older than you are now...""]** — Mówca: **Player**
> ""I was barely older than you are now, studying economics at the Lachaven Business School. I was a freshman. Excited and young.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[91]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: Presidents Past Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[198]`
  - -> `[141]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "Tell Franc about the coup of 1927."]** — Mówca: **Player_Italic**
> "It was time to tell him about the coup of 1927."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "Tell Franc about the civil war."]** — Mówca: **Player_Italic**
> "It was time to tell him about the civil war."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[94]`
**[WYBÓR GRACZA: "“Actually, never mind. Now is not the time to talk about the past.”"]** — Mówca: **Player**
> "“Actually, never mind. Now is not the time to talk about the past.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[95]`
**[WYBÓR GRACZA: ""I had just left the classroom...""]** — Mówca: **Player**
> ""I had just left the classroom to go back home as I heard the sound of multiple vehicles approaching the campus gates. As they got closer, I realized they were military camouflaged trucks and tanks, carrying hundreds of soldiers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
**[WYBÓR GRACZA: ""The same soldiers that were supposed to protect Sordland's citizens pointed their guns at us...""]** — Mówca: **Player**
> ""The same soldiers that were supposed to protect Sordland's citizens pointed their guns at us. They immediately took control of the facilities. One of my friends asked what was going on and was arrested immediately. More people got angry and gathered in protest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[97]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_1stCoup_Protested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_1stCoup_Protested == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_1stCoup_Protested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[99]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_1stCoup_Protested == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_1stCoup_Protested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[100]`
Mówca: **Narrator**
> "I stopped there and turned my head away from Franc."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[101]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: Jump to: [Presidents Past Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[102]`
**[WYBÓR GRACZA: ""It was right after I met your mother...""]** — Mówca: **Player**
> ""It was right after I met your mother -- we had both joined the same human rights group to push for change after the coup of '27. Eventually, I became convinced I wasn't doing enough. So I joined the Red Youth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[103]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Group_HumanRights == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Group_HumanRights == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Group_HumanRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[105]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Group_HumanRights == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Group_HumanRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Group_StudentCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Group_StudentCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Group_StudentCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[108]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Group_StudentCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Group_StudentCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[109]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[111]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Socialist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[114]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Nationalist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[115]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[117]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Socialist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[120]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Nationalist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[121]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[123]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Socialist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[126]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Nationalist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[127]`
**[WYBÓR GRACZA: ""It was right after I met your mother...""]** — Mówca: **Player**
> ""It was right after I met your mother -- we had both joined the same human rights group to push for change after the coup of '27. Eventually, I became convinced I wasn't doing enough. So I joined the Young Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[128]`
**[WYBÓR GRACZA: ""It was right after I met your mother...""]** — Mówca: **Player**
> ""It was right after I met your mother -- we had both joined the same human rights group to push for change after the coup of '27. But over the next year, the state of Sordland deteriorated. People started picking sides, and I tried to stay away as much as I could.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[129]`
**[WYBÓR GRACZA: ""It was right after I met your mother...""]** — Mówca: **Player**
> ""It was right after I met your mother. We had both joined the student council to push for change after the coup of '27. Eventually, I became convinced I wasn't doing enough. So I joined the Red Youth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[130]`
**[WYBÓR GRACZA: ""It was right after I met your mother...""]** — Mówca: **Player**
> ""It was right after I met your mother. We had both joined the student council to push for change after the coup of '27. Eventually, I became convinced I wasn't doing enough. So I joined the Young Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
**[WYBÓR GRACZA: ""It was right after I met your mother...""]** — Mówca: **Player**
> ""It was right after I met your mother -- we had both joined the student council to push for change after the coup of '27. But over the next year, the state of Sordland deteriorated. People started picking sides, and I tried to stay away as much as I could.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
**[WYBÓR GRACZA: "Tell Franc about the clash between Luderin and Rikard."]** — Mówca: **Player_Italic**
> ""Then, one night, it happened. Two different factions in the army, one of them led by maximist general Luderin and the other by socialist general Rikard, started fighting against each other. It was a bloodbath. Nowhere was safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[133]`
**[WYBÓR GRACZA: ""So we organized a protest...""]** — Mówca: **Player**
> ""So we organised a protest one day in support of Rikard. In our minds, he was the better of the two and a true socialist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[134]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[136]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Socialist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
**[WYBÓR GRACZA: ""So we organized a protest...""]** — Mówca: **Player**
> ""So we organised a protest one day against Rikard. We were fed up with the army toying with the country again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[138]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: Jump to: [Presidents Past Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[139]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_Franc_Coup28_Listened = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[140]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_Franc_Coup27_Listened = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[141]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_Franc_Coup27_Listened == true || BaseGameIsolated.Turn03_Franc_Coup28_Listened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_Franc_Coup27_Listened == true || BaseGameIsolated.Turn03_Franc_Coup28_Listened == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] == true  or  Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_Franc_Coup27_Listened == true || BaseGameIsolated.Turn03_Franc_Coup28_Listened == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] == true  or  Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[144]`
**[WYBÓR GRACZA: "“That's enough for today.”"]** — Mówca: **Player**
> "“That's enough for today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[145]`
Mówca: **Franc**
> "“I know I don't understand how easy my life is sometimes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[146]`
Mówca: **Narrator**
> "Franc hesitated, then moved over to where I was sitting and gave me an awkward pat on the back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[147]`
Mówca: **Franc**
> ""I know I complain sometimes, but my problems are nothing compared to what you went through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`
  - -> `[148]`
  - -> `[350]`

### Węzeł `[148]`
**[WYBÓR GRACZA: "“What problems?”"]** — Mówca: **Player**
> "“What problems?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Narrator**
> "Before Franc could say anything else, I heard the front door unlock. Deana and Monica's voices and the sounds of rustling shopping bags filled the house."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[150]`
Mówca: **Franc**
> "“I should get some studying done before dinner. But thanks for this, Dad. I mean it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Narrator**
> "Franc went in and dashed upstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Narrator**
> "I took a long sip from my beer, looking at the city and the now-setting sun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[153]`
Mówca: **Narrator**
> "I hoped that talking to Franc about my past had been the right decision. Part of me felt as if some sort of burden had been lifted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[156]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Railway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Narrator**
> "But I had the same nightmares again that night."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Narrator**
> "But I had the same nightmares again that night."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_AttackerOpenedFire = true;
BaseGameSupport.Report_Turn03_Antel_PrisonRiot = true;
BaseGameSupport.Report_Turn03_Morna_IndustrialOutput = true;
BaseGameSupport.Report_Turn03_Holsord_USPReport = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_AttackerOpenedFire"] = true;
Variable["BaseGameSupport.Report_Turn03_Antel_PrisonRiot"] = true;
Variable["BaseGameSupport.Report_Turn03_Morna_IndustrialOutput"] = true;
Variable["BaseGameSupport.Report_Turn03_Holsord_USPReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[160]`
Mówca: **Narrator**
> "Franc leaned forward in his chair, his eyes wide."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[161]`
**[WYBÓR GRACZA: "Tell him about the soldiers beating you."]** — Mówca: **Player_Italic**
> ""I was there with the protesters as they declared martial law. We marched towards them. They threatened to use force, but we stood our ground. So they started beating anyone they saw, including me. The physical wounds took a few weeks to heal, but the mental scars have stayed with me to this day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[357]`

### Węzeł `[162]`
**[WYBÓR GRACZA: "Refrain from telling him the brutality."]** — Mówca: **Player_Italic**
> ""I was there with the protesters as they declared martial law. We marched towards them. They threatened to use force but we stood our ground. ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[163]`
**[WYBÓR GRACZA: "Tell him that you ran for your life like a coward."]** — Mówca: **Player_Italic**
> ""Seeing the crowd gathering, I knew something was going to happen. Something bad. I decided that it was impossible to go against armed men and ran away from the scene. Ran away from my friends who were getting arrested and shot to save my own dear life like a coward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[356]`

### Węzeł `[164]`
**[WYBÓR GRACZA: "Refrain from telling him about your quick escape."]** — Mówca: **Player_Italic**
> ""Seeing the crowd gathering, I knew something was going to happen. Something bad. I decided that it was impossible to go against armed men and departed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[165]`
**[WYBÓR GRACZA: ""I was lucky...""]** — Mówca: **Player**
> ""I was still one of the lucky ones. Some of my friends were shot; many more were arrested. I can't forget the screams to this day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[166]`
**[WYBÓR GRACZA: ""I still feel my flight was justified -- anyone would do the same...""]** — Mówca: **Player**
> ""I still feel my flight was justified -- anyone would do the same. No one could sleep that night because of gunshots and sounds of boots. I can't forget the screams to this day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[167]`
Mówca: **Narrator**
> "I stopped there and turned my head away from Franc."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[168]`
**[WYBÓR GRACZA: "Tell him about the girl."]** — Mówca: **Player_Italic**
> "I paused for a moment before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[169]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Protest_Girl_Crushed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Protest_Girl_Crushed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Protest_Girl_Crushed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Protest_Girl_Crushed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Protest_Girl_Crushed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[181]`

### Węzeł `[172]`
**[WYBÓR GRACZA: "Refrain from telling him about the girl."]** — Mówca: **Player_Italic**
> "I paused for a moment before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[173]`
Mówca: **Narrator**
> "I trailed off. There were some things my son didn't have to know."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[174]`
Mówca: **Narrator**
> "Franc leaned back in his chair. His shoulders slumped heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[175]`
Mówca: **Narrator**
> "Franc leaned back in his chair. His shoulders slumped heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[176]`
Mówca: **Narrator**
> "Franc's face had grown pale. He turned his eyes away from me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[177]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Active == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Active == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Active"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[179]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Active == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Active"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
**[WYBÓR GRACZA: ""I stayed out of it...""]** — Mówca: **Player**
> ""People organised protests either for or against Rikard. I heard about the clashes the next day. Many of my friends were shot or arrested. I isolated myself for months.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[181]`
**[WYBÓR GRACZA: "Refrain from telling him about your escape."]** — Mówca: **Player_Italic**
> "I paused for a moment before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[182]`
**[WYBÓR GRACZA: "Tell him that you ran away."]** — Mówca: **Player_Italic**
> "I paused for a moment before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[183]`
Mówca: **Narrator**
> "I trailed off, hoping Franc wouldn't ask for any more details."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[184]`
Mówca: **Narrator**
> "Years later, I still felt that I was right. How could mere civilians go against a fully trained army, regardless of how just their cause was?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Narrator**
> "Franc turned away, lost in his own thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[186]`
Mówca: **Narrator**
> "Franc shifted in his seat, visibly uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[187]`
Mówca: **Narrator**
> "Sure enough, as soon as Franc glimpsed the grill and the meat, he stepped outside to join me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[188]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[190]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Highway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[191]`
Mówca: **Franc**
> "“Dad, is there going to be a civil war in Sordland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`
  - -> `[194]`

### Węzeł `[192]`
**[WYBÓR GRACZA: "“I hope not.”"]** — Mówca: **Player**
> "“I hope not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[193]`
**[WYBÓR GRACZA: "“No. I will never let that happen.”"]** — Mówca: **Player**
> "“No. I will never let that happen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
**[WYBÓR GRACZA: "Say nothing and avoid his question."]** — Mówca: **Player_Italic**
> "I said nothing and turned my head away from him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[195]`
Mówca: **Franc**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[196]`
Mówca: **Narrator**
> "He let out a sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[197]`
Mówca: **Narrator**
> "He let out a sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[198]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_Franc_Coup28_Listened == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_Franc_Coup28_Listened == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[200]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_Franc_Coup28_Listened == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[201]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_Franc_Coup27_Listened == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_Franc_Coup27_Listened == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[203]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_Franc_Coup27_Listened == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[204]`
**[WYBÓR GRACZA: "“I didn't say bribery was good, did I? You can always make the moral choice and turn these delicious ribs down...”"]** — Mówca: **Player**
> "“I didn't say bribery was good, did I? You can always make the moral choice and turn these delicious ribs down...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Narrator**
> "Franc smiled for a second. I turned to tend to the fire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[207]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[208]`
Mówca: **Franc**
> "“Geez, you're barely ever here, and when you are you order me around like I'm the butler?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[213]`
  - -> `[215]`

### Węzeł `[209]`
Mówca: **Franc**
> "“As long as it's a request, not an order.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[210]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[211]`
**[WYBÓR GRACZA: "Ask again more politely."]** — Mówca: **Player_Italic**
> "“Let me try again. Franc, it would be a great help if you would bring the tray from the kitchen. Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[212]`
Mówca: **Franc**
> "“See, was that so hard?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[213]`
**[WYBÓR GRACZA: "“Franc! I said don't make me angry!”"]** — Mówca: **Player**
> "<shout>“Franc! I said don't make me angry!”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[214]`
Mówca: **Franc**
> "“Stop yelling at me. Why are you always like this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[215]`
**[WYBÓR GRACZA: "“I'm sorry. Work is overwhelming sometimes. I shouldn't have taken it out on you.”"]** — Mówca: **Player**
> "“I'm sorry. Work has been overwhelming, but I shouldn't take that out on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[216]`
Mówca: **Franc**
> "“Yeah, sure, it's okay. You know, being the president's son isn't exactly a picnic either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[217]`
**[WYBÓR GRACZA: "“I can only imagine. I'm proud of how well you've been handling everything.”"]** — Mówca: **Player**
> "“I can only imagine. I'm proud of how you've been handling all the changes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[218]`
**[WYBÓR GRACZA: "“We can talk about it more later. For now, will you please go fetch the tray so we can eat?”"]** — Mówca: **Player**
> "“We can talk about it more later. For now, will you please go fetch the tray so we can eat?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Franc**
> "“Aye aye, cap'n.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[220]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[221]`
**[WYBÓR GRACZA: "“No. You're my son and I'm asking you. Can you bring the tray now, please?”"]** — Mówca: **Player**
> "“No. You're my son and I'm asking you. Can you bring the tray now, please?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[222]`
Mówca: **Franc**
> "“Ah. *Please*. The magic word.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Franc**
> "“Fine, I'll be back.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[224]`
**[WYBÓR GRACZA: "“Damn your generation. You are all the same. Weak.”"]** — Mówca: **Player**
> "“Damn your generation. You are all the same. Weak.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[225]`
Mówca: **Franc**
> ""Weak?! Dad, can't you see you're not the only one having a hard time here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Franc**
> ""You never even asked me how it feels -- being treated differently in school, everyone asking me about the riots all the time, not even being able to take a piss without those guards following me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`
  - -> `[227]`
  - -> `[234]`

### Węzeł `[227]`
**[WYBÓR GRACZA: "“Oh, cry me a river. Grow a spine and make something of yourself.”"]** — Mówca: **Player**
> "“Oh, cry me a river. Grow a spine and make something of yourself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[228]`
Mówca: **Franc**
> "“I'm sorry for being spineless, okay? Are you happy now? I'll get your goddamn tray.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Narrator**
> "Franc returned with a tray large enough to hold all the meat and vegetables. He shoved it at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Franc**
> "“I'm going to my room.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[232]`
Mówca: **Narrator**
> "He ran inside the house before I could say anything. The door slammed behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Narrator**
> "I took a long sip from my beer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[234]`
**[WYBÓR GRACZA: "“I've warned you. Shut up and do as I say -- or else.”"]** — Mówca: **Player**
> "“I've warned you. Shut up and do as I say -- or else.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Franc**
> "“Or else what? You're going to slap me? Beat me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Franc**
> "“Fine. I'll go get your goddamn tray.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[238]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion <= -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion <= -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion <= -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[241]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[242]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion <= -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion <= -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[244]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion <= -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Franc**
> "“Alright. I'll be upstairs until dinner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[246]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion <= -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion <= -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion <= -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[249]`
Mówca: **Franc**
> "“Yes, Father.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[250]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion <= -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion <= -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[252]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion <= -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[253]`
Mówca: **Franc**
> "“You will have to go through my secretary first.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Narrator**
> "He laughed and started making his way to the kitchen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[255]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion <= -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion <= -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[257]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion <= -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Franc**
> "“One more thing, though -- I know you joined the Young Sords back then. Do you mind if I ask why?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`
  - -> `[271]`

### Węzeł `[259]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[261]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Nationalist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Socialist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Franc**
> "“One more thing, though -- I know that you joined Red Youth back then. Do you mind if I ask why?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[274]`
  - -> `[276]`

### Węzeł `[266]`
Mówca: **Franc**
> "“One more thing, though -- I know that you managed to not take any sides. Do you mind if I ask why?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[280]`
  - -> `[281]`

### Węzeł `[267]`
**[WYBÓR GRACZA: "“Yes, I do mind. I don't want to talk about it.”"]** — Mówca: **Player**
> "“Yes, I do mind. I don't want to talk about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[268]`
**[WYBÓR GRACZA: "“Sordland was under attack by communists and I had to defend the country.”"]** — Mówca: **Player**
> "“Sordland was under attack by communists and I had to defend the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Franc**
> "“Okay. I was just curious, that's all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[270]`
Mówca: **Narrator**
> "Franc raised his eyebrows, his curiosity still not satisfied. But sensing my reluctance to go on, he simply nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[271]`
**[WYBÓR GRACZA: "“I had to survive somehow in that environment and I made a choice.”"]** — Mówca: **Player**
> "“I had to survive somehow in that environment and I made a choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[272]`
**[WYBÓR GRACZA: "“Yes, I do mind. I don't want to talk about it.”"]** — Mówca: **Player**
> "“Yes, I do mind. I don't want to talk about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Franc**
> "“Okay. I was just curious, that's all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[274]`
**[WYBÓR GRACZA: "“A communist revolution for Sordland was and still is the only way.”"]** — Mówca: **Player**
> "“A communist revolution for Sordland was and still is the only way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[275]`
Mówca: **Narrator**
> "Franc raised his eyebrows, his curiosity still not satisfied. But sensing my reluctance to go on, he simply nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[276]`
**[WYBÓR GRACZA: "“I had to survive somehow in that environment, and I made a choice.”"]** — Mówca: **Player**
> "“I had to survive somehow in that environment, and I made a choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[277]`
**[WYBÓR GRACZA: "“Yes, I do mind. I don't want to talk about it.”"]** — Mówca: **Player**
> "“Yes, I do mind. I don't want to talk about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Franc**
> "“Okay. I was just curious, that's all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[279]`
Mówca: **Narrator**
> "Franc raised his eyebrows, his curiosity still not satisfied. But sensing my reluctance to go on, he simply nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[280]`
**[WYBÓR GRACZA: "“I didn't want to be part of the violence.""]** — Mówca: **Player**
> "“I didn't want to be part of the violence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[281]`
**[WYBÓR GRACZA: "“They are two sides of the same coin.”"]** — Mówca: **Player**
> "“They are two sides of the same coin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[282]`
Mówca: **Franc**
> "“Sorry for bombarding you with questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[283]`
**[WYBÓR GRACZA: "“Don't act like you've done something special, Franc.”"]** — Mówca: **Player**
> "“Don't act like you've done anything special, Franc.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[284]`
Mówca: **Narrator**
> "He gave me a blank stare and then turned his eyes away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[285]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[286]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_R_UndemocraticElections = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_R_UndemocraticElections"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[287]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[290]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_FreedomOfPress = false; BaseGame.Situation_Law_MediaBias = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Law_FreedomOfPress"] = false;
Variable["BaseGame.Situation_Law_MediaBias"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[291]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_Personal_FrancTalk = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_Personal_FrancTalk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[292]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Highway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[295]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[297]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_SordishState == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[298]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Railway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[301]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_SordishState == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[304]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn03_Holsord_L1_SSC = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn03_Holsord_L1_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[305]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn03_Lachaven_H3_SSC = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn03_Lachaven_H3_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[306]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn03_Lachaven_H3_Underhall = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn03_Lachaven_H3_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[307]`
Mówca: **Narrator**
> "I wasn't sure how he felt about me at the moment. But I did know how he felt about barbecued ribs. Our cook had left some marinating in the refrigerator."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[308]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_MadAtDinner)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_MadAtDinner)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_MadAtDinner"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`

### Węzeł `[310]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_MadAtDinner))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_MadAtDinner"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[313]`

### Węzeł `[311]`
**[WYBÓR GRACZA: ""So, you've finally decided to speak to me again?""]** — Mówca: **Player**
> ""So, you've decided to speak to me again?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[312]`
**[WYBÓR GRACZA: ""Well, look who's finally out of his room.""]** — Mówca: **Player**
> ""Well, look who's finally out of his room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[313]`
**[WYBÓR GRACZA: ""Come to spend some quality time with your old man, have you?""]** — Mówca: **Player**
> ""Come to spend some quality time with your old man, have you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[314]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion <= -1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion <= -1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] <= -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[316]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion <= -1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] <= -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[317]`
Mówca: **Franc**
> ""You should talk, Dad. I never see you at home anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[322]`

### Węzeł `[318]`
Mówca: **Franc**
> ""Sure, if you can spare a few minutes out of your busy schedule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[323]`
  - -> `[322]`

### Węzeł `[319]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion <= -1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion <= -1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] <= -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[321]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_Opinion <= -1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] <= -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[322]`
**[WYBÓR GRACZA: ""I'm sorry, I know I haven't been around very often lately. But I'm happy to see you now.""]** — Mówca: **Player**
> ""I'm sorry, I know I haven't been around very often lately. But I'm happy to see you now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[323]`
**[WYBÓR GRACZA: ""Look, son, I'm preoccupied with matters of national importance.""]** — Mówca: **Player**
> ""Look, son, I'm preoccupied with matters of national importance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[324]`
Mówca: **Franc**
> ""Yes, Mr. President. Whatever you say, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[326]`
**[WYBÓR GRACZA: ""But right now, nothing's more important than these ribs.""]** — Mówca: **Player**
> ""But right now, nothing's more important than these ribs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[327]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[328]`
Mówca: **Franc**
> ""It's okay. I know you've got the most stressful job in the country. And you've got to feed your family on top of it all...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Narrator**
> "We both chuckled. I turned to tend to the fire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[330]`
Mówca: **Franc**
> ""Like at dinner that night after the ball. You told me everything was under control, but it wasn't, was it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[331]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_MadAtDinner == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_MadAtDinner == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_MadAtDinner"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[333]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_MadAtDinner == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_MadAtDinner"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[334]`
Mówca: **Franc**
> ""I know what happened in the '20s -- we learned all about it in school. Now, with the protests and the riots, is it going to be the same thing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[335]`
Mówca: **Franc**
> ""Like at dinner that night after the ball. Maybe I shouldn't have brought it up in front of Deana, but I was right, wasn't I? It's bad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[336]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Protest_Girl_Crushed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[338]`

### Węzeł `[337]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Protest_Girl_Crushed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Protest_Girl_Crushed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[338]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Protest_Girl_Crushed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Protest_Girl_Crushed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[339]`
Mówca: **Narrator**
> "The shock and grief on the faces of fathers, mothers and orphaned children."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[76]`

### Węzeł `[340]`
**[WYBÓR GRACZA: ""It was right after I met your mother...""]** — Mówca: **Player**
> ""It was right after I met your mother -- we had both joined the same political debate group to push for change after the coup of '27. But over the next year, the state of Sordland deteriorated. People started picking sides, and I tried to stay away as much as I could.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[341]`
**[WYBÓR GRACZA: ""It was right after I met your mother...""]** — Mówca: **Player**
> ""It was right after I met your mother -- we had both joined the same political debate group to push for change after the coup of '27. Eventually, I became convinced I wasn't doing enough. So I joined the Young Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[342]`
**[WYBÓR GRACZA: ""It was right after I met your mother...""]** — Mówca: **Player**
> ""It was right after I met your mother -- we had both joined the same political debate group to push for change after the coup of '27. Eventually, I became convinced I wasn't doing enough. So I joined the Red Youth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[343]`
**[WYBÓR GRACZA: ""It was horrible...""]** — Mówca: **Player**
> ""It was horrible. They were waiting for us. Soldiers started beating and shooting at everyone, and plowing their tanks into the crowd. Amid the chaos, there was this girl. I never forgot her face. I tried to save her, but I couldn't reach her in time...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[344]`
**[WYBÓR GRACZA: ""It was horrible...""]** — Mówca: **Player**
> ""It was horrible. They were waiting for us. Everything plunged into chaos. Soldiers started beating and shooting at everyone....""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[345]`
**[WYBÓR GRACZA: ""Soldiers were waiting for us...""]** — Mówca: **Player**
> ""Soldiers were waiting for us. I knew something was going to happen. Something bad. I decided that it was impossible to go against armed men and ran away from the scene.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[346]`
**[WYBÓR GRACZA: ""We were ready to face them...""]** — Mówca: **Player**
> ""We were ready to face them. I had no time for bad feelings, they rushed at us. We stood and fought but many were arrested and shot...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[347]`
**[WYBÓR GRACZA: ""I was barely older than you are now...""]** — Mówca: **Player**
> ""I was barely older than you are now, studying history at the Deyr University of Culture. I was a freshman. Excited and young.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[348]`
Mówca: **Narrator**
> "Franc kept listening, a shocked look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[349]`
**[WYBÓR GRACZA: ""I'm here to listen to them, no matter what they are.""]** — Mówca: **Player**
> ""I'm here to listen to them, no matter what they are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[350]`
**[WYBÓR GRACZA: ""You're damn right. Your generation will never understand.""]** — Mówca: **Player**
> ""You're damn right. Your generation will never understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[351]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[352]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[353]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_Franc_Coup27_Listened == true || BaseGameIsolated.Turn03_Franc_Coup28_Listened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_Franc_Coup27_Listened == true || BaseGameIsolated.Turn03_Franc_Coup28_Listened == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] == true  or  Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[355]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_Franc_Coup27_Listened == true || BaseGameIsolated.Turn03_Franc_Coup28_Listened == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] == true  or  Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[356]`
**[WYBÓR GRACZA: ""I still feel my flight was shameful -- I should have stood my ground...""]** — Mówca: **Player**
> ""I still feel my flight was shameful -- I should have stood my ground. No one could sleep that night because of gunshots and sounds of boots. I can't forget the screams to this day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[357]`
**[WYBÓR GRACZA: ""I stayed strong...""]** — Mówca: **Player**
> ""I tried my best to stay strong. Some of my friends were shot; many more were arrested. I can't forget the screams to this day. But I'm proud not to have faltered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[358]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_DontEnactPlan == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_DontEnactPlan == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_DontEnactPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[360]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_EconomicRelief_DontEnactPlan == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_DontEnactPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[361]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Economy -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[362]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[363]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[364]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`
  - -> `[24]`

### Węzeł `[365]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[366]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[367]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[368]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[369]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[370]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[371]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[372]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[373]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[374]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[375]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`
  - -> `[377]`

### Węzeł `[376]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[377]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[378]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[380]`

### Węzeł `[379]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[381]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn03_Holsord_L1_Underhall = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn03_Holsord_L1_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[382]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[385]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_LT_DerbyPostponedBanYS = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_DerbyPostponedBanYS"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[386]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_LT_DerbyPostponedNoRYBan = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_DerbyPostponedNoRYBan"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[387]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[389]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[390]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Morna", "City_LowIndustrialOutput");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Morna","City_LowIndustrialOutput");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[391]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameSupport.FactionReport_Turn03_ATO_AidSupportAgnolia = true;
BaseGameSupport.CountryReport_Turn03_Rizia_EnergyCooperationOffer = true;
BaseGameSupport.News_Turn03_E_Gasom_Critique = true;
BaseGameSupport.News_Turn03_E_GreenBill_BadForGrowth = true;
BaseGameSupport.News_Turn03_G_AnrakaDiversifiesInvestments = true;
BaseGameSupport.News_Turn03_G_CSPWorkerReportCritique = true;
BaseGameSupport.News_Turn03_HP_GreenBillCritique = true;
BaseGameSupport.News_Turn03_R_GreenBill_Support = true;
BaseGameSupport.News_Turn03_LT_Gasom_RiziaInvestInterest = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.FactionReport_Turn03_ATO_AidSupportAgnolia"] = true;
Variable["BaseGameSupport.CountryReport_Turn03_Rizia_EnergyCooperationOffer"] = true;
Variable["BaseGameSupport.News_Turn03_E_Gasom_Critique"] = true;
Variable["BaseGameSupport.News_Turn03_E_GreenBill_BadForGrowth"] = true;
Variable["BaseGameSupport.News_Turn03_G_AnrakaDiversifiesInvestments"] = true;
Variable["BaseGameSupport.News_Turn03_G_CSPWorkerReportCritique"] = true;
Variable["BaseGameSupport.News_Turn03_HP_GreenBillCritique"] = true;
Variable["BaseGameSupport.News_Turn03_R_GreenBill_Support"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Gasom_RiziaInvestInterest"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[392]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[393]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_TourismBill_SupportSign = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_TourismBill_SupportSign"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[394]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_TourismBill_CritiqueVeto = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_TourismBill_CritiqueVeto"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[395]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true && BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`
  - -> `[397]`

### Węzeł `[396]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true && BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true  and  Variable["BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[397]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == true && BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true  and  Variable["BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[398]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == false && BaseGame.Bill_Turn02_TourismCulturalPreservation_Vetoed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`
  - -> `[400]`

### Węzeł `[399]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == false && BaseGame.Bill_Turn02_TourismCulturalPreservation_Vetoed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == false  and  Variable["BaseGame.Bill_Turn02_TourismCulturalPreservation_Vetoed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[400]`
Mówca: **Franc**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == false && BaseGame.Bill_Turn02_TourismCulturalPreservation_Vetoed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == false  and  Variable["BaseGame.Bill_Turn02_TourismCulturalPreservation_Vetoed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[401]`
Mówca: **Franc**
> "“Looks like it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
