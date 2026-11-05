# Sordland/Turn11/Personal_Exile

- **ID konwersacji:** `255`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Sordland/Turn_11/255_Personal_Exile.md`
- **Liczba węzłów dialogowych:** 392
- **Liczba wyborów gracza:** 58

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[7]** Policeman
- **[10]** Narrator
- **[11]** Monica
- **[20]** Deana
- **[31]** Franc

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn10_MovePersonalWealth_Move`
- `BaseGame.Exile_LeaveNow`
- `BaseGame.Exile_MonicaDeanaWithYou`
- `BaseGame.Exile_PetrWithYou`
- `BaseGame.Exile_WholeFamilyWithYou`
- `BaseGame.PersonalWealth`
- `BaseGame.Reform_PresiPower_Strong_GunRights`
- `BaseGame.Relations_Lucian_Enemy`
- `BaseGame.Rumburg_GivenEstordAndNarbel`
- `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice`
- `BaseGame.Turn09_MilitaryParade_AssassinationAttempt`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGame.Turn10_PartyCongress_Lost`
- `BaseGameIsolated.Turn07_AcceptedMarcelCar`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.AMorgnaWesCore`
- `GameCondition.Turn11_P_Exile`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[29]` | **""That's all you're bringing?""** | `[25]` **Narrator**: "On the way out of Holsord, I pic..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Franc**: ""I didn't want to arouse suspici..." |
| `[30]` | **""Did you say your goodbyes?""** | `[25]` **Narrator**: "On the way out of Holsord, I pic..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Franc**: ""Just to Sheyna. Dad, she can co..." |
| `[33]` | **""I don't see why not.""** | `[32]` **Franc**: ""Just to Sheyna. Dad, she can co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Narrator**: "I kept driving." |
| `[34]` | **""We'll talk about that later.""** | `[32]` **Franc**: ""Just to Sheyna. Dad, she can co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Narrator**: "I kept driving." |
| `[36]` | **""You're too old for stuffed animals, Deana.""** | `[31]` **Deana**: ""Papa! I forgot Mr. Bunnybun."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Monica**: ""We don't have time, honey. Our ..." |
| `[37]` | **""All right. Let's go back and get him.""** | `[31]` **Deana**: ""Papa! I forgot Mr. Bunnybun."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Narrator**: "Monica put a hand on my arm." |
| `[46]` | **""Kyrute, here we come! Anton, I hope you're ready to live like a king.""** | `[21]` **Narrator**: "On the way out of Holsord, I pic..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Player**: ""No, I don't want to attract too..."<br>`[378]` **Player**: ""Shit. All my savings are still ..."<br>*(oraz 2 innych odgałęzień)* |
| `[47]` | **""I don't know about living like a king, but at least I'll be able to access my sav..."** | `[46]` **Petr Vectern**: ""Kyrute, here we come! Anton, I ..." | `Variable["BaseGame.PersonalWealth"] < 2`<br>`Variable["BaseGame.Decision_Turn10_MovePersonalWealth_Move"] == true` | *Brak zmian stanu* | `[53]` **Narrator**: "Petr unzipped his duffel bag. It..." |
| `[51]` | **""Yes, thankfully I managed to get my savings into an international account. It oug..."** | `[46]` **Petr Vectern**: ""Kyrute, here we come! Anton, I ..." | `(Variable["BaseGame.PersonalWealth"] < 2) == false`<br>`Variable["BaseGame.Decision_Turn10_MovePersonalWealth_Move"] == true` | *Brak zmian stanu* | `[53]` **Narrator**: "Petr unzipped his duffel bag. It..." |
| `[52]` | **""No, I don't want to attract too much attention.""** | `[46]` **Petr Vectern**: ""Kyrute, here we come! Anton, I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "Petr unzipped his duffel bag. It..." |
| `[92]` | **""Shit. I've got to go back.""** | `[77]` **Narrator**: "The military had taken my family..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Narrator**: "The car skidded as I violently s..." |
| `[93]` | **""I can't go back. That's exactly what they want.""** | `[77]` **Narrator**: "The military had taken my family..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Narrator**: "Petr shook his head." |
| `[103]` | **"Don't go back for them."** | `[105]` **Narrator**: "The military had taken my wife a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Narrator**: "This was just a scare tactic to ..." |
| `[106]` | **"Go back for them."** | `[105]` **Narrator**: "The military had taken my wife a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Narrator**: "After a few minutes, I saw flash..." |
| `[121]` | **""I'd like to see her try.""** | `[116]` **Narrator**: "Lileas was giving a campaign spe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Petr Vectern**: ""She won't last a month.""<br>`[130]` **Narrator**: "My ship from Benfi was leaving i..." |
| `[122]` | **""I can't wait to be out of this country.""** | `[116]` **Narrator**: "Lileas was giving a campaign spe..."<br>`[120]` **Narrator**: "A political commentator was disc..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Petr Vectern**: ""Amen to that.""<br>`[130]` **Narrator**: "My ship from Benfi was leaving i..." |
| `[124]` | **""They don't know the full story.""** | `[120]` **Narrator**: "A political commentator was disc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Petr Vectern**: ""You did your best. We all did.""<br>`[130]` **Narrator**: "My ship from Benfi was leaving i..." |
| `[125]` | **"Turn off the radio."** | `[123]` **Narrator**: "One of Sordland's most famous mu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Petr Vectern**: ""Hey, I was enjoying that!""<br>`[130]` **Narrator**: "My ship from Benfi was leaving i..." |
| `[150]` | **""I'd like to see her try.""** | `[146]` **Narrator**: "Lileas was giving a campaign spe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Monica**: ""She won't last a month."" |
| `[151]` | **""I can't wait to be out of this country.""** | `[146]` **Narrator**: "Lileas was giving a campaign spe..."<br>`[147]` **Narrator**: "A political commentator was disc..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Monica**: ""You'd better drive faster, then."" |
| `[152]` | **""They don't know the full story.""** | `[147]` **Narrator**: "A political commentator was disc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Monica**: ""You did your best. We all did."" |
| `[159]` | **"Turn off the radio."** | `[157]` **Narrator**: "One of Sordland's most famous mu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Franc**: ""Hey, I was enjoying that!""<br>`[148]` **Monica**: ""That was tasteless."" |
| `[166]` | **"Speed up."** | `[165]` **Narrator**: "Suddenly, I heard a siren blarin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[168]` **Narrator**: "With a reluctant sigh, I pulled ..." |
| `[167]` | **"Pull over."** | `[165]` **Narrator**: "Suddenly, I heard a siren blarin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[383]` **Narrator**: "I touched the gun I brought with..."<br>`[182]` **Narrator**: "A policeman tapped on the window..." |
| `[170]` | **""Whoever you think I am, I've got a wad of cash that says otherwise.""** | `[169]` **Policeman**: ""Sorry, sir, just a routine chec..." | `Variable["BaseGame.PersonalWealth"] > 0` | *Brak zmian stanu* | `[211]` **Narrator**: "I grabbed a handful of bills fro..." |
| `[177]` | **""Whoever you think I am, my friend here has a wad of cash that says otherwise.""** | `[169]` **Policeman**: ""Sorry, sir, just a routine chec..." | `Variable["BaseGame.Exile_PetrWithYou"] == true` | *Brak zmian stanu* | `[180]` **Petr Vectern**: ""Uh... yes, that's right."" |
| `[178]` | **"Say nothing."** | `[169]` **Policeman**: ""Sorry, sir, just a routine chec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Policeman**: ""I'm going to need to see your i..." |
| `[179]` | **""Whoever you think I am, I've got a gun here that says otherwise.""** | `[169]` **Policeman**: ""Sorry, sir, just a routine chec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Narrator**: "Petr looked at me incredulously."<br>`[184]` **Narrator**: "Monica turned pale. I could see ..."<br>*(oraz 2 innych odgałęzień)* |
| `[196]` | **"Hand him your passport."** | `[183]` **Policeman**: ""I'm going to need to see your i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[379]` **Narrator**: "He took a brief look at my passp..." |
| `[197]` | **"Do nothing."** | `[183]` **Policeman**: ""I'm going to need to see your i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[198]` **Petr Vectern**: ""Listen, sir, this is all a misu..."<br>`[205]` **Monica**: ""Anton, for God's sake...""<br>*(oraz 1 innych odgałęzień)* |
| `[230]` | **""That makes one of us.""** | `[229]` **Policeman**: ""Listen, I'm not supposed to let..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Policeman**: ""Good luck on the path, Mr. Rayn..." |
| `[231]` | **""Thanks. That means a lot.""** | `[229]` **Policeman**: ""Listen, I'm not supposed to let..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Policeman**: ""Good luck on the path, Mr. Rayn..." |
| `[236]` | **""Thank you.""** | `[208]` **Policeman**: ""Forgive me, I obviously mistook..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[271]` **Narrator**: "Once the police were out of my s..." |
| `[237]` | **"Nod."** | `[208]` **Policeman**: ""Forgive me, I obviously mistook..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Petr Vectern**: ""So much for fighting corruption.""<br>`[253]` **Petr Vectern**: ""That was a close one.""<br>*(oraz 1 innych odgałęzień)* |
| `[258]` | **""Thank you.""** | `[234]` **Policeman**: ""You keep fighting the good figh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Narrator**: "Once the police were out of my s..." |
| `[259]` | **"Nod."** | `[234]` **Policeman**: ""You keep fighting the good figh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Franc**: ""Whoa. Nice job, Mom!""<br>`[264]` **Deana**: ""That was amazing, Mama!"" |
| `[266]` | **""It was a special circumstance.""** | `[248]` **Deana**: ""Papa. That was illegal."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Narrator**: "Monica looked chagrined, but sai..." |
| `[267]` | **""Thanks, Mr. Moneybags.""** | `[247]` **Petr Vectern**: ""So much for fighting corruption.""<br>`[253]` **Petr Vectern**: ""That was a close one."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[307]` **Narrator**: "At last, there it was: the Port ..." |
| `[268]` | **""Let's just hope he doesn't have friends waiting at the port.""** | `[247]` **Petr Vectern**: ""So much for fighting corruption.""<br>`[253]` **Petr Vectern**: ""That was a close one."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[307]` **Narrator**: "At last, there it was: the Port ..." |
| `[269]` | **""I broke the law for you, sweetheart.""** | `[248]` **Deana**: ""Papa. That was illegal."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Narrator**: "Monica looked chagrined, but sai..." |
| `[275]` | **""Thank you.""** | `[210]` **Policeman**: ""Forgive me, I obviously mistook..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Narrator**: "Once the police were out of my s..." |
| `[276]` | **"Nod."** | `[210]` **Policeman**: ""Forgive me, I obviously mistook..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Petr Vectern**: ""Since when do you have a gun?""<br>`[294]` **Deana**: ""Papa? You have a gun?"" |
| `[289]` | **""Family heirloom.""** | `[288]` **Narrator**: "I opened the glove compartment t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Petr Vectern**: ""Why, Anton. You're just full of..."<br>`[308]` **Franc**: ""Can I have one?""<br>*(oraz 1 innych odgałęzień)* |
| `[290]` | **""I got it when I changed the gun ownership laws.""** | `[288]` **Narrator**: "I opened the glove compartment t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Petr Vectern**: ""Why, Anton. You're just full of..."<br>`[308]` **Franc**: ""Can I have one?""<br>*(oraz 1 innych odgałęzień)* |
| `[301]` | **""I guess my word as President still means something.""** | `[300]` **Narrator**: "I opened the glove compartment t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Petr Vectern**: ""Pretty gutsy, Anton.""<br>`[303]` **Franc**: ""Pretty gutsy, Dad.""<br>*(oraz 1 innych odgałęzień)* |
| `[302]` | **""We just got extremely lucky.""** | `[300]` **Narrator**: "I opened the glove compartment t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Petr Vectern**: ""Pretty gutsy, Anton.""<br>`[303]` **Franc**: ""Pretty gutsy, Dad.""<br>*(oraz 1 innych odgałęzień)* |
| `[339]` | **"Go to the back of the ship."** | `[337]` **Narrator**: "After looking it over very close..."<br>`[338]` **Narrator**: "After looking them over very clo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[350]` **Narrator**: "Petr and I stood there as we lef..."<br>`[351]` **Narrator**: "My family and I stood there as w..."<br>*(oraz 1 innych odgałęzień)* |
| `[340]` | **"Go to the front of the ship."** | `[337]` **Narrator**: "After looking it over very close..."<br>`[338]` **Narrator**: "After looking them over very clo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[373]` **Narrator**: "An impossibly wide expanse of wa..." |
| `[353]` | **""A Morgna wes core.""** | `[351]` **Narrator**: "My family and I stood there as w..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame....` | `[366]` **Monica**: ""Vectern sis da."" |
| `[354]` | **""We'll be back someday.""** | `[351]` **Narrator**: "My family and I stood there as w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[367]` **Monica**: ""What kind of country will it be..." |
| `[355]` | **""Goodbye, Sordland.""** | `[351]` **Narrator**: "My family and I stood there as w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Narrator**: "Monica and I looked at each othe..." |
| `[356]` | **""A Morgna wes core.""** | `[352]` **Narrator**: "I stood there as we left harbor,..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame....` | `[359]` **Narrator**: "My words floated out over the wa..." |
| `[357]` | **""I'll be back someday.""** | `[352]` **Narrator**: "I stood there as we left harbor,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[359]` **Narrator**: "My words floated out over the wa..." |
| `[358]` | **""Goodbye, Sordland.""** | `[352]` **Narrator**: "I stood there as we left harbor,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[359]` **Narrator**: "My words floated out over the wa..." |
| `[360]` | **""A Morgna wes core.""** | `[350]` **Narrator**: "Petr and I stood there as we lef..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame....` | `[363]` **Petr Vectern**: ""Vectern sis da, baby."" |
| `[361]` | **""We'll be back someday.""** | `[350]` **Narrator**: "Petr and I stood there as we lef..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[364]` **Petr Vectern**: ""I'm sure we will."" |
| `[362]` | **""I hope Monica and the kids will be all right.""** | `[350]` **Narrator**: "Petr and I stood there as we lef..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[365]` **Petr Vectern**: ""I'm sure they will."" |
| `[378]` | **""Shit. All my savings are still tied up in Sordland. We'll have to start from scra..."** | `[46]` **Petr Vectern**: ""Kyrute, here we come! Anton, I ..." | `(Variable["BaseGame.Decision_Turn10_MovePersonalWealth_Move"] == true) == false` | *Brak zmian stanu* | `[53]` **Narrator**: "Petr unzipped his duffel bag. It..." |

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
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_LeaveNow == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_LeaveNow"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_AcceptedMarcelCar == true"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_LeaveNow == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_LeaveNow"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_AcceptedMarcelCar == true"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Just one day after deciding to leave the country, I pulled out of the driveway in the Randolfini sports car Marcel had given me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_AcceptedMarcelCar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_AcceptedMarcelCar == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_AcceptedMarcelCar == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_AcceptedMarcelCar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Just one day after deciding to leave the country, I pulle..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_AcceptedMarcelCar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Just one day after deciding to leave the country, I pulle..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "Just one day after deciding to leave the country, I pulled out of the driveway in an unobtrusive-looking station wagon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)

### Węzeł `[11]`
Mówca: **Narrator**
> "One week after deciding to leave the country, I pulled out of the driveway in the Randolfini sports car Marcel had given me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_AcceptedMarcelCar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_AcceptedMarcelCar == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_AcceptedMarcelCar == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_AcceptedMarcelCar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "One week after deciding to leave the country, I pulled ou..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_AcceptedMarcelCar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "One week after deciding to leave the country, I pulled ou..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "One week after deciding to leave the country, I pulled out of the driveway in an unobtrusive-looking station wagon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)

### Węzeł `[16]`
Mówca: **Narrator**
> "Monica and Deana were with me. We'd all packed just one suitcase. I'd told the guards we were going to visit Monica's parents for the weekend."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_MonicaDeanaWithYou == true)"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Monica and Deana were with me. We'd all packed just one s..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_MonicaDeanaWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "I only had one suitcase with me. I had told the guards I ..."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "I only had one suitcase with me. I had told the guards I was going on a short personal trip for the weekend."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[21]`
Mówca: **Narrator**
> "On the way out of Holsord, I picked up Petr from his apartment. He was carrying a suitcase and a heavy-looking duffel bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Petr Vectern: ""Kyrute, here we come! Anton, I hope you're ready to live..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "On the way out of Holsord, I picked up Petr from his apar..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Enemy == true"*)

### Węzeł `[25]`
Mówca: **Narrator**
> "On the way out of Holsord, I picked up Franc from university. He was carrying a small backpack and nothing else."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: ""That's all you're bringing?""*)
  - -> `[30]` (*Player: ""Did you say your goodbyes?""*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true)"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "On the way out of Holsord, I picked up Franc from univers..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Deana: ""Papa! I forgot Mr. Bunnybun.""*)

### Węzeł `[29]`
**[WYBÓR GRACZA: ""That's all you're bringing?""]** — Mówca: **Player**
> ""That's all you're bringing?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Franc: ""I didn't want to arouse suspicion. There were some older..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: ""Did you say your goodbyes?""]** — Mówca: **Player**
> ""Did you say your goodbyes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Franc: ""Just to Sheyna. Dad, she can come visit me in Kyrute, ri..."*)

### Węzeł `[31]`
Mówca: **Deana**
> ""Papa! I forgot Mr. Bunnybun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: ""You're too old for stuffed animals, Deana.""*)
  - -> `[37]` (*Player: ""All right. Let's go back and get him.""*)

### Węzeł `[32]`
Mówca: **Franc**
> ""Just to Sheyna. Dad, she can come visit me in Kyrute, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: ""I don't see why not.""*)
  - -> `[34]` (*Player: ""We'll talk about that later.""*)

### Węzeł `[33]`
**[WYBÓR GRACZA: ""I don't see why not.""]** — Mówca: **Player**
> ""I don't see why not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "I kept driving."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: ""We'll talk about that later.""]** — Mówca: **Player**
> ""We'll talk about that later.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "I kept driving."*)

### Węzeł `[35]`
Mówca: **Franc**
> ""I didn't want to arouse suspicion. There were some older guys lurking around campus who looked like they might've been military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "I kept driving."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: ""You're too old for stuffed animals, Deana.""]** — Mówca: **Player**
> ""You're too old for stuffed animals, Deana.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Monica: ""We don't have time, honey. Our ship leaves from Benfi Po..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: ""All right. Let's go back and get him.""]** — Mówca: **Player**
> ""All right. Let's go back and get him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "Monica put a hand on my arm."*)

### Węzeł `[38]`
Mówca: **Narrator**
> "Monica put a hand on my arm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Monica: ""We don't have time, honey. Our ship leaves from Benfi Po..."*)

### Węzeł `[39]`
Mówca: **Monica**
> ""We don't have time, honey. Our ship leaves from Benfi Port in a few hours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "I kept driving."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "I kept driving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)

### Węzeł `[41]`
Mówca: **Narrator**
> "As I drove out of Holsord, I could see the domed roof of the Maroon Palace looming in the rear-view mirror. I felt bad I hadn't said goodbye to Lucian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Enemy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lucian_Enemy == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Lucian_Enemy == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lucian_Enemy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Lucian_Enemy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "As I drove out of Holsord, I could see the domed roof of ..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Lucian_Enemy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Lucian_Enemy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "As I drove out of Holsord, I could see the domed roof of ..."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "As I drove out of Holsord, I could see the domed roof of the Maroon Palace looming in the rear-view mirror."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[46]`
**[WYBÓR GRACZA: ""Kyrute, here we come! Anton, I hope you're ready to live like a king.""]** — Mówca: **Petr Vectern**
> ""Kyrute, here we come! Anton, I hope you're ready to live like a king.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn10_MovePersonalWealth_Move == true"*)
  - -> `[52]` (*Player: ""No, I don't want to attract too much attention.""*)

### Węzeł `[47]`
**[WYBÓR GRACZA: ""I don't know about living like a king, but at least I'll be able to access my savings.""]** — Mówca: **Player**
> ""I don't know about living like a king, but at least I'll be able to access my savings.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] < 2` AND `Variable["BaseGame.Decision_Turn10_MovePersonalWealth_Move"] == true`
- **Kontekst wejściowy (poprzednik):** `[46]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "Petr unzipped his duffel bag. It was full of cash -- what..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth < 2"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth < 2)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth < 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player: ""I don't know about living like a king, but at least I'll..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth < 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] < 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: ""Yes, thankfully I managed to get my savings into an inte..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: ""Yes, thankfully I managed to get my savings into an international account. It ought to tide us over for a good long while.""]** — Mówca: **Player**
> ""Yes, thankfully I managed to get my savings into an international account. It ought to tide us over for a good long while.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.PersonalWealth"] < 2) == false` AND `Variable["BaseGame.Decision_Turn10_MovePersonalWealth_Move"] == true`
- **Kontekst wejściowy (poprzednik):** `[46]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "Petr unzipped his duffel bag. It was full of cash -- what..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: ""No, I don't want to attract too much attention.""]** — Mówca: **Player**
> ""No, I don't want to attract too much attention.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "Petr unzipped his duffel bag. It was full of cash -- what..."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "Petr unzipped his duffel bag. It was full of cash -- what must have been millions of Sordish Ren. He winked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Petr Vectern: ""Just in case.""*)

### Węzeł `[54]`
Mówca: **Petr Vectern**
> ""Just in case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "I kept driving."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead == true)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "Driving past the graveyard where Serge was buried, I said..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "I hadn't said goodbye to Serge either. I hoped he'd be okay."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "Driving past the graveyard where Serge was buried, I said a silent farewell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "I kept driving."*)

### Węzeł `[59]`
Mówca: **Narrator**
> "I hadn't said goodbye to Serge either. I hoped he'd be okay."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "I kept driving."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "After an hour or so of silence, Monica switched on the radio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_Milita..."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "After about an hour or so of silence, Petr switched on the radio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_Milita..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_MonicaDeanaWithYou == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "After an hour or so of silence, Monica switched on the ra..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_MonicaDeanaWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "After an hour or so of silence, Franc asked if we could s..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[68]`
Mówca: **Narrator**
> "After an hour or so of silence, Franc asked if we could switch on the radio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_Milita..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "After about an hour or so of silence, Petr switched on th..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "After about an hour or so of silence, I switched on the r..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "After about an hour or so of silence, I switched on the radio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_Milita..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_Milita..."*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_Mili..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_LeaveNow"] == true  and  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "I wasn't paying attention until I heard the words "Monica..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_LeaveNow"] == true  and  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "I wasn't paying attention until I heard the words "Anton ..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "I wasn't paying attention until I heard the words "Monica and Deana Rayne"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "The military had taken my family into custody."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "The military had taken my family into custody."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: ""Shit. I've got to go back.""*)
  - -> `[93]` (*Player: ""I can't go back. That's exactly what they want.""*)

### Węzeł `[78]`
Mówca: **Narrator**
> "I wasn't paying attention until I heard the words "Franc Rayne"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "A boy who looked like my son had been taken into military..."*)

### Węzeł `[79]`
Mówca: **Narrator**
> "A boy who looked like my son had been taken into military custody at Holsord State, then released when his identity was confirmed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Franc: ""I knew there was something fishy about those guys on cam..."*)

### Węzeł `[80]`
Mówca: **Franc**
> ""I knew there was something fishy about those guys on campus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "Monica gritted her teeth."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "I wasn't paying attention until I heard the words "Deana Rayne"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "The military had come to Deana's school and taken a girl ..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_Milita..."*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_Mili..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_LeaveNow"] == true  and  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "I wasn't paying attention until I heard the words "Franc ..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_LeaveNow"] == true  and  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "I wasn't paying attention until I heard the words "Anton ..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_Milita..."*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_Mili..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_LeaveNow"] == true  and  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "I wasn't paying attention until I heard the words "Deana ..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_LeaveNow"] == true  and  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "I wasn't paying attention until I heard the words "Anton ..."*)

### Węzeł `[88]`
Mówca: **Narrator**
> "The military had come to Deana's school and taken a girl who looked like her into custody. They released her once her identity was confirmed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Deana: ""I guess we left just in time, Papa.""*)

### Węzeł `[89]`
Mówca: **Deana**
> ""I guess we left just in time, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "Monica gritted her teeth."*)

### Węzeł `[90]`
Mówca: **Narrator**
> "Monica gritted her teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Monica: ""Keep driving, Anton.""*)

### Węzeł `[91]`
Mówca: **Monica**
> ""Keep driving, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "I pressed my foot to the gas pedal."*)

### Węzeł `[92]`
**[WYBÓR GRACZA: ""Shit. I've got to go back.""]** — Mówca: **Player**
> ""Shit. I've got to go back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "The car skidded as I violently spun the wheel. We began r..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA: ""I can't go back. That's exactly what they want.""]** — Mówca: **Player**
> ""I can't go back. That's exactly what they want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Petr shook his head."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "Petr shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Petr Vectern: ""They're trying to use Monica and Deana as a bargaining c..."*)

### Węzeł `[95]`
Mówca: **Petr Vectern**
> ""They're trying to use Monica and Deana as a bargaining chip. They'll let them go once they realize they can't reach you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "I pressed my foot to the gas pedal."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "The car skidded as I violently spun the wheel. We began racing back the way we'd come."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "After a few minutes, I saw flashing lights on the road ah..."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "After a few minutes, I saw flashing lights on the road ahead of us. The military had set up a checkpoint."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Petr Vectern: ""Don't do it, Anton. They won't hurt Monica and Deana. Bu..."*)

### Węzeł `[98]`
Mówca: **Petr Vectern**
> ""Don't do it, Anton. They won't hurt Monica and Deana. But they'll kill you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "I pressed my foot to the gas pedal."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_Milita..."*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_Mili..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_LeaveNow"] == true  and  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "I wasn't paying attention until I heard the words "Monica..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_LeaveNow == true && BaseGame.Turn09_MilitaryParade_AssassinationAttempt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_LeaveNow"] == true  and  Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "I wasn't paying attention until I heard the words "Anton ..."*)

### Węzeł `[102]`
Mówca: **Narrator**
> "I wasn't paying attention until I heard the words "Monica and Deana Rayne"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "The military had taken my wife and daughter into custody."*)

### Węzeł `[103]`
**[WYBÓR GRACZA: "Don't go back for them."]** — Mówca: **Player_Italic**
> "I switched the radio off."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "This was just a scare tactic to get to me. The military w..."*)

### Węzeł `[104]`
Mówca: **Narrator**
> "After a few minutes, I saw flashing lights on the road ahead. The military had set up a checkpoint."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "I couldn't go back. I had to keep going."*)

### Węzeł `[105]`
Mówca: **Narrator**
> "The military had taken my wife and daughter into custody."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player_Italic: "Go back for them."*)
  - -> `[103]` (*Player_Italic: "Don't go back for them."*)

### Węzeł `[106]`
**[WYBÓR GRACZA: "Go back for them."]** — Mówca: **Player_Italic**
> "The car skidded as I violently spun the wheel. I began racing back the way I'd come."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "After a few minutes, I saw flashing lights on the road ah..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "This was just a scare tactic to get to me. The military wouldn't hurt my family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "I hoped."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "I couldn't go back. I had to keep going."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "I pressed my foot to the gas pedal."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "I hoped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "I pressed my foot to the gas pedal."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "I pressed my foot to the gas pedal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "After what seemed like forever, I passed the Benfi city l..."*)

### Węzeł `[111]`
Mówca: **Narrator**
> "I wasn't paying attention until I heard the words "Anton Rayne"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)

### Węzeł `[112]`
Mówca: **Narrator**
> "I wasn't paying attention until I heard the words "Anton Rayne"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Lileas was giving a campaign speech, promising to fix all..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)

### Węzeł `[116]`
Mówca: **Narrator**
> "Lileas was giving a campaign speech, promising to fix all the mistakes I'd made."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: ""I'd like to see her try.""*)
  - -> `[122]` (*Player: ""I can't wait to be out of this country.""*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_GivenEstordAndNarbel == true)"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "A political commentator was discussing how my mishandling..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_GivenEstordAndNarbel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "One of Sordland's most famous musical comedians was warbl..."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "A political commentator was discussing how my mishandling of the Rumburg crisis would set Sordland back at least a century."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: ""I can't wait to be out of this country.""*)
  - -> `[124]` (*Player: ""They don't know the full story.""*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""I'd like to see her try.""]** — Mówca: **Player**
> ""I'd like to see her try.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[122]`
**[WYBÓR GRACZA: ""I can't wait to be out of this country.""]** — Mówca: **Player**
> ""I can't wait to get out of this country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Narrator), `[120]` (Narrator), `[123]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[123]`
Mówca: **Narrator**
> "One of Sordland's most famous musical comedians was warbling a song parody about me entitled "A Hard Rayne's Gonna Fall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: ""I can't wait to be out of this country.""*)
  - -> `[125]` (*Player_Italic: "Turn off the radio."*)

### Węzeł `[124]`
**[WYBÓR GRACZA: ""They don't know the full story.""]** — Mówca: **Player**
> ""They don't know the full story.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "Turn off the radio."]** — Mówca: **Player_Italic**
> "I turned off the radio."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[126]`
Mówca: **Petr Vectern**
> ""Hey, I was enjoying that!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "I pressed my foot to the gas pedal."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Petr Vectern: ""Hey, I was enjoying that!""*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "My ship from Benfi was leaving in just two hours."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "My ship from Benfi was leaving in just two hours."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "I pressed my foot to the gas pedal."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Petr Vectern: ""Amen to that.""*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "My ship from Benfi was leaving in just two hours."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Petr Vectern: ""She won't last a month.""*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "My ship from Benfi was leaving in just two hours."*)

### Węzeł `[137]`
Mówca: **Petr Vectern**
> ""She won't last a month.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "I pressed my foot to the gas pedal."*)

### Węzeł `[138]`
Mówca: **Petr Vectern**
> ""Amen to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "I pressed my foot to the gas pedal."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Petr Vectern: ""You did your best. We all did.""*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "My ship from Benfi was leaving in just two hours."*)

### Węzeł `[142]`
Mówca: **Petr Vectern**
> ""You did your best. We all did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "I pressed my foot to the gas pedal."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_PartyCongress_Lost == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_PartyCongress_Lost == true)"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_PartyCongress_Lost == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_PartyCongress_Lost"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "Lileas was giving a campaign speech, promising to fix all..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_PartyCongress_Lost == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_PartyCongress_Lost"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)

### Węzeł `[146]`
Mówca: **Narrator**
> "Lileas was giving a campaign speech, promising to fix all the mistakes I'd made."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: ""I'd like to see her try.""*)
  - -> `[151]` (*Player: ""I can't wait to be out of this country.""*)

### Węzeł `[147]`
Mówca: **Narrator**
> "A political commentator was discussing how my mishandling of the Rumburg crisis would set Sordland back at least a century. War didn't break out but thousands of Sordish were displaced from Narbel and Estord after hearing about the atrocities committed by Rumburg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player: ""I can't wait to be out of this country.""*)
  - -> `[152]` (*Player: ""They don't know the full story.""*)

### Węzeł `[148]`
Mówca: **Monica**
> ""That was tasteless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "I pressed my foot to the gas pedal."*)

### Węzeł `[149]`
Mówca: **Franc**
> ""Hey, I was enjoying that!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "I pressed my foot to the gas pedal."*)

### Węzeł `[150]`
**[WYBÓR GRACZA: ""I'd like to see her try.""]** — Mówca: **Player**
> ""I'd like to see her try.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Monica: ""She won't last a month.""*)

### Węzeł `[151]`
**[WYBÓR GRACZA: ""I can't wait to be out of this country.""]** — Mówca: **Player**
> ""I can't wait to get out of this country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Narrator), `[147]` (Narrator), `[157]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Monica: ""You'd better drive faster, then.""*)

### Węzeł `[152]`
**[WYBÓR GRACZA: ""They don't know the full story.""]** — Mówca: **Player**
> ""They don't know the full story.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Monica: ""You did your best. We all did.""*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true)"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Franc: ""Hey, I was enjoying that!""*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Monica: ""That was tasteless.""*)

### Węzeł `[156]`
Mówca: **Monica**
> ""You'd better drive faster, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "I pressed my foot to the gas pedal."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "One of Sordland's most famous musical comedians was warbling a song parody about me entitled "A Hard Rayne's Gonna Fall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player: ""I can't wait to be out of this country.""*)
  - -> `[159]` (*Player_Italic: "Turn off the radio."*)

### Węzeł `[158]`
Mówca: **Monica**
> ""She won't last a month.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "I pressed my foot to the gas pedal."*)

### Węzeł `[159]`
**[WYBÓR GRACZA: "Turn off the radio."]** — Mówca: **Player_Italic**
> "I turned off the radio."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)

### Węzeł `[160]`
Mówca: **Monica**
> ""You did your best. We all did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "I pressed my foot to the gas pedal."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_GivenEstordAndNarbel == true"*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_GivenEstordAndNarbel == true)"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_GivenEstordAndNarbel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "A political commentator was discussing how my mishandling..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_GivenEstordAndNarbel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "One of Sordland's most famous musical comedians was warbl..."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "After what seemed like forever, I passed the Benfi city limits sign. The port was in sight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CarSiren");"*)

### Węzeł `[165]`
Mówca: **Narrator**
> "Suddenly, I heard a siren blaring from behind me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player_Italic: "Speed up."*)
  - -> `[167]` (*Player_Italic: "Pull over."*)

### Węzeł `[166]`
**[WYBÓR GRACZA: "Speed up."]** — Mówca: **Player_Italic**
> "I floored it, only to see that the road ahead of me was blocked."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "With a reluctant sigh, I pulled the car over."*)

### Węzeł `[167]`
**[WYBÓR GRACZA: "Pull over."]** — Mówca: **Player_Italic**
> "With a reluctant sigh, I pulled the car over."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_GunRights == true"*)

### Węzeł `[168]`
Mówca: **Narrator**
> "With a reluctant sigh, I pulled the car over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_GunRights == true"*)

### Węzeł `[169]`
Mówca: **Policeman**
> ""Sorry, sir, just a routine checkpoint-- Wait a minute, are you...?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[178]` (*Player_Italic: "Say nothing."*)
  - -> `[179]` (*Player: ""Whoever you think I am, I've got a gun here that says ot..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA: ""Whoever you think I am, I've got a wad of cash that says otherwise.""]** — Mówca: **Player**
> ""Whoever you think I am, I've got a wad of cash that says otherwise.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Kontekst wejściowy (poprzednik):** `[169]` (Policeman)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Narrator: "I grabbed a handful of bills from my suit pocket and wave..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 0)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player: ""Whoever you think I am, I've got a wad of cash that says..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Player: ""Whoever you think I am, my friend here has a wad of cash..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[177]`
**[WYBÓR GRACZA: ""Whoever you think I am, my friend here has a wad of cash that says otherwise.""]** — Mówca: **Player**
> ""Whoever you think I am, my friend here has a wad of cash that says otherwise.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Kontekst wejściowy (poprzednik):** `[169]` (Policeman)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Petr Vectern: ""Uh... yes, that's right.""*)

### Węzeł `[178]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I said nothing."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Policeman)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Policeman: ""I'm going to need to see your identification.""*)

### Węzeł `[179]`
**[WYBÓR GRACZA: ""Whoever you think I am, I've got a gun here that says otherwise.""]** — Mówca: **Player**
> ""Whoever you think I am, I've got a gun here that says otherwise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Policeman)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[180]`
Mówca: **Petr Vectern**
> ""Uh... yes, that's right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "Petr reached into his duffel bag and pulled out a handful..."*)

### Węzeł `[181]`
Mówca: **Narrator**
> "Petr reached into his duffel bag and pulled out a handful of bills. The policeman looked uneasy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "After a few agonizing moments, he quickly snatched the mo..."*)

### Węzeł `[182]`
Mówca: **Narrator**
> "A policeman tapped on the window. I rolled it down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Policeman: ""Sorry, sir, just a routine checkpoint-- Wait a minute, a..."*)

### Węzeł `[183]`
Mówca: **Policeman**
> ""I'm going to need to see your identification.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player_Italic: "Hand him your passport."*)
  - -> `[197]` (*Player_Italic: "Do nothing."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "Monica turned pale. I could see Deana squirming in the backseat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "The policeman took a few steps back."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "Petr looked at me incredulously."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_MonicaDeanaWithYou == true)"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Monica turned pale. I could see Deana squirming in the ba..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_MonicaDeanaWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "Monica turned pale. I could see Franc and Deana squirming..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "I began reaching towards the car's glove compartment."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "Monica turned pale. I could see Franc and Deana squirming in the backseat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "The policeman took a few steps back."*)

### Węzeł `[195]`
Mówca: **Narrator**
> "Petr looked at me incredulously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "The policeman took a few steps back."*)

### Węzeł `[196]`
**[WYBÓR GRACZA: "Hand him your passport."]** — Mówca: **Player_Italic**
> "I handed him my passport."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[183]` (Policeman)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Narrator: "He took a brief look at my passport."*)

### Węzeł `[197]`
**[WYBÓR GRACZA: "Do nothing."]** — Mówca: **Player_Italic**
> "I didn't move."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[183]` (Policeman)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[198]`
Mówca: **Petr Vectern**
> ""Listen, sir, this is all a misunderstanding. Please allow me to help clear it up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "Petr reached into his duffel bag and pulled out a handful..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Petr Vectern: ""Listen, sir, this is all a misunderstanding. Please allo..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true || BaseGame.Exi..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou == true || BaseGame.Exile_WholeFamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true || BaseGame.Exi..."*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_MonicaDeanaWithYou == true || BaseGame.E..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou == true || BaseGame.Exile_WholeFamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true  or  Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Monica: ""Anton, for God's sake...""*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_MonicaDeanaWithYou == true || BaseGame.Exile_WholeFamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true  or  Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Policeman: ""Please step out of the vehicle, sir.""*)

### Węzeł `[205]`
Mówca: **Monica**
> ""Anton, for God's sake...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Policeman: ""Monica Rayne?""*)

### Węzeł `[206]`
Mówca: **Policeman**
> ""Please step out of the vehicle, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Narrator: "I slowly began to open the car door."*)

### Węzeł `[207]`
Mówca: **Narrator**
> "After a few agonizing moments, he quickly snatched the money and stuffed it in his pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Policeman: ""Forgive me, I obviously mistook you for someone else. Yo..."*)

### Węzeł `[208]`
Mówca: **Policeman**
> ""Forgive me, I obviously mistook you for someone else. You may proceed to your destination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Player: ""Thank you.""*)
  - -> `[237]` (*Player_Italic: "Nod."*)

### Węzeł `[209]`
Mówca: **Narrator**
> "The policeman took a few steps back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Policeman: ""Forgive me, I obviously mistook you for someone else. Yo..."*)

### Węzeł `[210]`
Mówca: **Policeman**
> ""Forgive me, I obviously mistook you for someone else. You may proceed to your destination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Player: ""Thank you.""*)
  - -> `[276]` (*Player_Italic: "Nod."*)

### Węzeł `[211]`
Mówca: **Narrator**
> "I grabbed a handful of bills from my suit pocket and waved them in the policeman's direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Narrator: "Petr looked at me incredulously."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_MonicaDeanaWithYou == true)"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Narrator: "Monica turned pale. I could see Deana squirming in the ba..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_MonicaDeanaWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)

### Węzeł `[218]`
Mówca: **Narrator**
> "Monica turned pale. I could see Franc and Deana squirming in the backseat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "The policeman seemed uneasy."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true)"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "Monica turned pale. I could see Franc and Deana squirming..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "The policeman seemed uneasy."*)

### Węzeł `[222]`
Mówca: **Narrator**
> "Monica turned pale. I could see Deana squirming in the backseat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "The policeman seemed uneasy."*)

### Węzeł `[223]`
Mówca: **Narrator**
> "Petr looked at me incredulously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "The policeman seemed uneasy."*)

### Węzeł `[224]`
Mówca: **Narrator**
> "The policeman seemed uneasy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "After a few agonizing moments, he quickly snatched the mo..."*)

### Węzeł `[225]`
Mówca: **Policeman**
> ""Monica Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Policeman: ""Listen, I'm not supposed to let anyone through here. But..."*)

### Węzeł `[226]`
Mówca: **Policeman**
> ""Listen, I'm not supposed to let anyone through here. But my wife-- she absolutely loves you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "Monica looked startled. It took her a few seconds to reply."*)

### Węzeł `[227]`
Mówca: **Narrator**
> "I slowly began to open the car door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Policeman: ""I was right! You're Anton Rayne!""*)

### Węzeł `[228]`
Mówca: **Policeman**
> ""I was right! You're Anton Rayne!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Policeman: ""Listen, I'm not supposed to let anyone through here. But..."*)

### Węzeł `[229]`
Mówca: **Policeman**
> ""Listen, I'm not supposed to let anyone through here. But I voted for you back in '53. I still think you're a great man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Player: ""That makes one of us.""*)
  - -> `[231]` (*Player: ""Thanks. That means a lot.""*)

### Węzeł `[230]`
**[WYBÓR GRACZA: ""That makes one of us.""]** — Mówca: **Player**
> ""That makes one of us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[229]` (Policeman)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Policeman: ""Good luck on the path, Mr. Rayne. I didn't see anything.""*)

### Węzeł `[231]`
**[WYBÓR GRACZA: ""Thanks. That means a lot.""]** — Mówca: **Player**
> ""Thanks. That means a lot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[229]` (Policeman)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Policeman: ""Good luck on the path, Mr. Rayne. I didn't see anything.""*)

### Węzeł `[232]`
Mówca: **Narrator**
> "Monica looked startled. It took her a few seconds to reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Monica: ""I'm happy to hear that.""*)

### Węzeł `[233]`
Mówca: **Monica**
> ""I'm happy to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Policeman: ""You keep fighting the good fight, Mrs. First Lady. And y..."*)

### Węzeł `[234]`
Mówca: **Policeman**
> ""You keep fighting the good fight, Mrs. First Lady. And you folks enjoy... wherever it is you're off to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Player: ""Thank you.""*)
  - -> `[259]` (*Player_Italic: "Nod."*)

### Węzeł `[235]`
Mówca: **Narrator**
> "I began reaching towards the car's glove compartment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "The policeman took a few steps back."*)

### Węzeł `[236]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Policeman)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "Once the police were out of my sights, I breathed a sigh ..."*)

### Węzeł `[237]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded and drove off."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Policeman)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_MonicaDeanaWithYou == true)"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Deana: ""Papa. That was illegal.""*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_MonicaDeanaWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true)"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Deana: ""Papa. That was illegal.""*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)

### Węzeł `[247]`
Mówca: **Petr Vectern**
> ""So much for fighting corruption.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player: ""Thanks, Mr. Moneybags.""*)
  - -> `[268]` (*Player: ""Let's just hope he doesn't have friends waiting at the p..."*)

### Węzeł `[248]`
Mówca: **Deana**
> ""Papa. That was illegal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Player: ""It was a special circumstance.""*)
  - -> `[269]` (*Player: ""I broke the law for you, sweetheart.""*)

### Węzeł `[249]`
Mówca: **Narrator**
> "So the police were still corrupt. I hadn't even managed to change that."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "At last, there it was: the Port of Benfi. The ship to Kyr..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == t..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Petr Vectern: ""So much for fighting corruption.""*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Petr Vectern: ""That was a close one.""*)

### Węzeł `[253]`
Mówca: **Petr Vectern**
> ""That was a close one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player: ""Thanks, Mr. Moneybags.""*)
  - -> `[268]` (*Player: ""Let's just hope he doesn't have friends waiting at the p..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == t..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "So the police were still corrupt. I hadn't even managed t..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Narrator: "Once the police were out of my sights, I breathed a sigh ..."*)

### Węzeł `[257]`
Mówca: **Narrator**
> "Once the police were out of my sights, I breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "At last, there it was: the Port of Benfi. The ship to Kyr..."*)

### Węzeł `[258]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Policeman)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "Once the police were out of my sights, I breathed a sigh ..."*)

### Węzeł `[259]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded and drove off."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Policeman)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)

### Węzeł `[260]`
Mówca: **Franc**
> ""Whoa. Nice job, Mom!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Monica: ""We got lucky, Let's just hope he doesn't have friends wa..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true)"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Franc: ""Whoa. Nice job, Mom!""*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Deana: ""That was amazing, Mama!""*)

### Węzeł `[264]`
Mówca: **Deana**
> ""That was amazing, Mama!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Monica: ""We got lucky, Let's just hope he doesn't have friends wa..."*)

### Węzeł `[265]`
Mówca: **Monica**
> ""We got lucky, Let's just hope he doesn't have friends waiting at the port.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Narrator: "I could see Monica trying hard to suppress a smile."*)

### Węzeł `[266]`
**[WYBÓR GRACZA: ""It was a special circumstance.""]** — Mówca: **Player**
> ""It was a special circumstance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[248]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "Monica looked chagrined, but said nothing."*)

### Węzeł `[267]`
**[WYBÓR GRACZA: ""Thanks, Mr. Moneybags.""]** — Mówca: **Player**
> ""Thanks, Mr. Moneybags.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Petr Vectern), `[253]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "At last, there it was: the Port of Benfi. The ship to Kyr..."*)

### Węzeł `[268]`
**[WYBÓR GRACZA: ""Let's just hope he doesn't have friends waiting at the port.""]** — Mówca: **Player**
> ""Let's just hope he doesn't have friends waiting at the port.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Petr Vectern), `[253]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "At last, there it was: the Port of Benfi. The ship to Kyr..."*)

### Węzeł `[269]`
**[WYBÓR GRACZA: ""I broke the law for you, sweetheart.""]** — Mówca: **Player**
> ""I broke the law for you, sweetheart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[248]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "Monica looked chagrined, but said nothing."*)

### Węzeł `[270]`
Mówca: **Narrator**
> "Monica looked chagrined, but said nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "At last, there it was: the Port of Benfi. The ship to Kyr..."*)

### Węzeł `[271]`
Mówca: **Narrator**
> "Once the police were out of my sights, I breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[272]`
Mówca: **Narrator**
> "Once the police were out of my sights, I breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)

### Węzeł `[273]`
Mówca: **Narrator**
> "I could see Monica trying hard to suppress a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "At last, there it was: the Port of Benfi. The ship to Kyr..."*)

### Węzeł `[274]`
Mówca: **Narrator**
> "Once the police were out of my sights, I breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Narrator: "I had a hard time suppressing a smile as I drove off towa..."*)

### Węzeł `[275]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Policeman)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "Once the police were out of my sights, I breathed a sigh ..."*)

### Węzeł `[276]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded and drove off."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Policeman)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[277]`
Mówca: **Narrator**
> "Once the police were out of my sights, I breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Petr Vectern: ""Since when do you have a gun?""*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_MonicaDeanaWithYou == true)"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Deana: ""Papa? You have a gun?""*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_MonicaDeanaWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true)"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Deana: ""Papa? You have a gun?""*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_GunRights == true"*)

### Węzeł `[287]`
Mówca: **Petr Vectern**
> ""Since when do you have a gun?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_GunRights == true"*)

### Węzeł `[288]`
Mówca: **Narrator**
> "I opened the glove compartment to reveal a shiny revolver."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Player: ""I got it when I changed the gun ownership laws.""*)
  - -> `[289]` (*Player: ""Family heirloom.""*)

### Węzeł `[289]`
**[WYBÓR GRACZA: ""Family heirloom.""]** — Mówca: **Player**
> ""Family heirloom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[290]`
**[WYBÓR GRACZA: ""I got it when I changed the gun ownership laws.""]** — Mówca: **Player**
> ""I got it when I changed the gun ownership laws.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_GunRights == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_GunRights == true"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_GunRights == true)"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_GunRights == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_GunRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "I opened the glove compartment to reveal a shiny revolver."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_GunRights == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_GunRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Narrator: "I opened the glove compartment to reveal the car's manual..."*)

### Węzeł `[294]`
Mówca: **Deana**
> ""Papa? You have a gun?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_GunRights == true"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_GunRights == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_GunRights == true"*)
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_GunRights == true)"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_GunRights == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_GunRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Narrator: "I inwardly thanked myself for changing Sordland's gun own..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_GunRights == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_GunRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Narrator: "He'd bought my lie. Maybe I still had some power left in ..."*)

### Węzeł `[298]`
Mówca: **Narrator**
> "I inwardly thanked myself for changing Sordland's gun ownership laws."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "At last, there it was: the Port of Benfi. The ship to Kyr..."*)

### Węzeł `[299]`
Mówca: **Narrator**
> "He'd bought my lie. Maybe I still had some power left in me as President."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "At last, there it was: the Port of Benfi. The ship to Kyr..."*)

### Węzeł `[300]`
Mówca: **Narrator**
> "I opened the glove compartment to reveal the car's manual and a few candy wrappers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Player: ""I guess my word as President still means something.""*)
  - -> `[302]` (*Player: ""We just got extremely lucky.""*)

### Węzeł `[301]`
**[WYBÓR GRACZA: ""I guess my word as President still means something.""]** — Mówca: **Player**
> ""I guess my word as President still means something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[302]`
**[WYBÓR GRACZA: ""We just got extremely lucky.""]** — Mówca: **Player**
> ""We just got extremely lucky.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[300]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[303]`
Mówca: **Franc**
> ""Pretty gutsy, Dad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Narrator: "Monica turned to look out the window. She said nothing fo..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true)"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Franc: ""Pretty gutsy, Dad.""*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Monica: ""That could've gone very badly.""*)

### Węzeł `[307]`
Mówca: **Narrator**
> "At last, there it was: the Port of Benfi. The ship to Kyrute was already docked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[308]`
Mówca: **Franc**
> ""Can I have one?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Monica: ""No!""*)

### Węzeł `[309]`
Mówca: **Monica**
> ""No!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Monica: ""You're getting rid of that in Kyrute, Anton.""*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true)"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Franc: ""Can I have one?""*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Monica: ""You're getting rid of that in Kyrute, Anton.""*)

### Węzeł `[313]`
Mówca: **Monica**
> ""You're getting rid of that in Kyrute, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "At last, there it was: the Port of Benfi. The ship to Kyr..."*)

### Węzeł `[314]`
Mówca: **Monica**
> ""That could've gone very badly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Narrator: "Monica turned to look out the window. She said nothing fo..."*)

### Węzeł `[315]`
Mówca: **Narrator**
> "Monica turned to look out the window. She said nothing for the rest of the ride."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "At last, there it was: the Port of Benfi. The ship to Kyr..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Petr Vectern: ""Why, Anton. You're just full of surprises today.""*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)

### Węzeł `[319]`
Mówca: **Petr Vectern**
> ""Why, Anton. You're just full of surprises today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "At last, there it was: the Port of Benfi. The ship to Kyr..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Petr Vectern: ""Pretty gutsy, Anton.""*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)

### Węzeł `[323]`
Mówca: **Petr Vectern**
> ""Pretty gutsy, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "At last, there it was: the Port of Benfi. The ship to Kyr..."*)

### Węzeł `[324]`
Mówca: **Narrator**
> "Petr and I grabbed our belongings and left the car in the lot. I presented the ticket officer with the passes I'd booked under a fake name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Narrator: "After looking them over very closely, he let us on board."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Narrator: "Petr and I grabbed our belongings and left the car in the..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true)"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Narrator: "Monica, Franc, Deana and I grabbed our belongings and lef..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_MonicaDeanaWithYou == true)"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "Monica, Deana and I grabbed our belongings and left the c..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_MonicaDeanaWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Narrator: "I grabbed my belongings and left the car in the lot. I pr..."*)

### Węzeł `[334]`
Mówca: **Narrator**
> "Monica, Franc, Deana and I grabbed our belongings and left the car in the lot. I presented the ticket officer with the passes I'd booked under a fake name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Narrator: "After looking them over very closely, he let us on board."*)

### Węzeł `[335]`
Mówca: **Narrator**
> "Monica, Deana and I grabbed our belongings and left the car in the lot. I presented the ticket officer with the passes I'd booked under a fake name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Narrator: "After looking them over very closely, he let us on board."*)

### Węzeł `[336]`
Mówca: **Narrator**
> "I grabbed my belongings and left the car in the lot. I presented the ticket officer with the passes I'd booked under a fake name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Narrator: "After looking it over very closely, he let me on board."*)

### Węzeł `[337]`
Mówca: **Narrator**
> "After looking it over very closely, he let me on board."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Player_Italic: "Go to the back of the ship."*)
  - -> `[340]` (*Player_Italic: "Go to the front of the ship."*)

### Węzeł `[338]`
Mówca: **Narrator**
> "After looking them over very closely, he let us on board."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Player_Italic: "Go to the back of the ship."*)
  - -> `[340]` (*Player_Italic: "Go to the front of the ship."*)

### Węzeł `[339]`
**[WYBÓR GRACZA: "Go to the back of the ship."]** — Mówca: **Player_Italic**
> "I made my way to the back of the ship."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[337]` (Narrator), `[338]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)

### Węzeł `[340]`
**[WYBÓR GRACZA: "Go to the front of the ship."]** — Mówca: **Player_Italic**
> "I made my way to the front of the ship. A strong sea breeze was blowing."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[337]` (Narrator), `[338]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Narrator: "An impossibly wide expanse of water stretched out before ..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_PetrWithYou == true"*)
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_PetrWithYou == true)"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_PetrWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_PetrWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Narrator: "Petr and I stood there as we left harbor, watching Sordla..."*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_PetrWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_PetrWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_WholeFamilyWithYou == true"*)
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_WholeFamilyWithYou == true)"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_WholeFamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Narrator: "My family and I stood there as we left harbor, watching S..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_WholeFamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGame.Exile_MonicaDeanaWithYou == true"*)
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Exile_MonicaDeanaWithYou == true)"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Exile_MonicaDeanaWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Narrator: "My family and I stood there as we left harbor, watching S..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Exile_MonicaDeanaWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Exile_MonicaDeanaWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Narrator: "I stood there as we left harbor, watching my home country..."*)

### Węzeł `[350]`
Mówca: **Narrator**
> "Petr and I stood there as we left harbor, watching Sordland recede into the distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Player: ""A Morgna wes core.""*)
  - -> `[361]` (*Player: ""We'll be back someday.""*)
  - -> `[362]` (*Player: ""I hope Monica and the kids will be all right.""*)

### Węzeł `[351]`
Mówca: **Narrator**
> "My family and I stood there as we left harbor, watching Sordland recede into the distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Player: ""A Morgna wes core.""*)
  - -> `[354]` (*Player: ""We'll be back someday.""*)
  - -> `[355]` (*Player: ""Goodbye, Sordland.""*)

### Węzeł `[352]`
Mówca: **Narrator**
> "I stood there as we left harbor, watching my home country recede into the distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Player: ""A Morgna wes core.""*)
  - -> `[357]` (*Player: ""I'll be back someday.""*)
  - -> `[358]` (*Player: ""Goodbye, Sordland.""*)

### Węzeł `[353]`
**[WYBÓR GRACZA: ""A Morgna wes core.""]** — Mówca: **Player**
> ""A Morgna wes core.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[351]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "BaseGame.AMorgnaWesCore += 1"*)

### Węzeł `[354]`
**[WYBÓR GRACZA: ""We'll be back someday.""]** — Mówca: **Player**
> ""We'll be back someday.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[351]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Monica: ""What kind of country will it be by then, though?""*)

### Węzeł `[355]`
**[WYBÓR GRACZA: ""Goodbye, Sordland.""]** — Mówca: **Player**
> ""Goodbye, Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[351]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Narrator: "Monica and I looked at each other. My wife had tears in h..."*)

### Węzeł `[356]`
**[WYBÓR GRACZA: ""A Morgna wes core.""]** — Mówca: **Player**
> ""A Morgna wes core.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "BaseGame.AMorgnaWesCore += 1"*)

### Węzeł `[357]`
**[WYBÓR GRACZA: ""I'll be back someday.""]** — Mówca: **Player**
> ""I'll be back someday.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Narrator: "My words floated out over the water, unanswered."*)

### Węzeł `[358]`
**[WYBÓR GRACZA: ""Goodbye, Sordland.""]** — Mówca: **Player**
> ""Goodbye, Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Narrator: "My words floated out over the water, unanswered."*)

### Węzeł `[359]`
Mówca: **Narrator**
> "My words floated out over the water, unanswered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "I walked to the ship's bow. A strong sea breeze was blowing."*)

### Węzeł `[360]`
**[WYBÓR GRACZA: ""A Morgna wes core.""]** — Mówca: **Player**
> ""A Morgna wes core.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGame.AMorgnaWesCore += 1"*)

### Węzeł `[361]`
**[WYBÓR GRACZA: ""We'll be back someday.""]** — Mówca: **Player**
> ""We'll be back someday.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Petr Vectern: ""I'm sure we will.""*)

### Węzeł `[362]`
**[WYBÓR GRACZA: ""I hope Monica and the kids will be all right.""]** — Mówca: **Player**
> ""I hope Monica and the kids will be all right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Petr Vectern: ""I'm sure they will.""*)

### Węzeł `[363]`
Mówca: **Petr Vectern**
> ""Vectern sis da, baby.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Petr Vectern: ""Come on, let's go to the front.""*)

### Węzeł `[364]`
Mówca: **Petr Vectern**
> ""I'm sure we will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Petr Vectern: ""Come on, let's go to the front.""*)

### Węzeł `[365]`
Mówca: **Petr Vectern**
> ""I'm sure they will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Petr Vectern: ""Come on, let's go to the front.""*)

### Węzeł `[366]`
Mówca: **Monica**
> ""Vectern sis da.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Narrator: "Monica and I looked at each other. My wife had tears in h..."*)

### Węzeł `[367]`
Mówca: **Monica**
> ""What kind of country will it be by then, though?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Narrator: "Monica and I looked at each other. My wife had tears in h..."*)

### Węzeł `[368]`
Mówca: **Narrator**
> "Monica and I looked at each other. My wife had tears in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Monica: ""Let's go to the front.""*)

### Węzeł `[369]`
Mówca: **Petr Vectern**
> ""Come on, let's go to the front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Narrator: "We walked to the ship's bow. A strong sea breeze was blow..."*)

### Węzeł `[370]`
Mówca: **Monica**
> ""Let's go to the front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Narrator: "We walked to the ship's bow. A strong sea breeze was blow..."*)

### Węzeł `[371]`
Mówca: **Narrator**
> "I walked to the ship's bow. A strong sea breeze was blowing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Narrator: "An impossibly wide expanse of water stretched out before ..."*)

### Węzeł `[372]`
Mówca: **Narrator**
> "We walked to the ship's bow. A strong sea breeze was blowing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Narrator: "An impossibly wide expanse of water stretched out before ..."*)

### Węzeł `[373]`
Mówca: **Narrator**
> "An impossibly wide expanse of water stretched out before me. I closed my eyes, listening to the roar of the waves and the cries of seagulls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_P_Exile = true"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn11_P_Exile = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn11_P_Exile"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn10_MovePersonalWealth_Move == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn10_MovePersonalWealth_Move == true"*)
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn10_MovePersonalWealth_Move == true)"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn10_MovePersonalWealth_Move == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn10_MovePersonalWealth_Move"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth < 2"*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn10_MovePersonalWealth_Move == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn10_MovePersonalWealth_Move"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Player: ""Shit. All my savings are still tied up in Sordland. We'l..."*)

### Węzeł `[378]`
**[WYBÓR GRACZA: ""Shit. All my savings are still tied up in Sordland. We'll have to start from scratch.""]** — Mówca: **Player**
> ""Shit. All my savings are still tied up in Sordland. We'll have to start from scratch.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Decision_Turn10_MovePersonalWealth_Move"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[46]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "Petr unzipped his duffel bag. It was full of cash -- what..."*)

### Węzeł `[379]`
Mówca: **Narrator**
> "He took a brief look at my passport."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Policeman: ""Please step out of the vehicle, sir.""*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_GunRights == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_GunRights == true"*)
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_GunRights == true)"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_GunRights == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_GunRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Narrator: "I touched the gun I brought with me. The cold steel gave ..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_GunRights == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_GunRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "A policeman tapped on the window. I rolled it down."*)

### Węzeł `[383]`
Mówca: **Narrator**
> "I touched the gun I brought with me. The cold steel gave me confidence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "A policeman tapped on the window. I rolled it down."*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AMorgnaWesCore += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Monica: ""Vectern sis da.""*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AMorgnaWesCore += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Narrator: "My words floated out over the water, unanswered."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AMorgnaWesCore += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Petr Vectern: ""Vectern sis da, baby.""*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("CarSiren");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("CarSiren");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "Suddenly, I heard a siren blaring from behind me."*)

### Węzeł `[388]`
Mówca: **Policeman**
> ""Good luck on the path, Mr. Rayne. I didn't see anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Narrator: "He smiled. Then went back to his car and drove off."*)

### Węzeł `[389]`
Mówca: **Narrator**
> "He smiled. Then went back to his car and drove off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Narrator: "Once the police were out of my sights, I breathed a sigh ..."*)

### Węzeł `[390]`
Mówca: **Narrator**
> "I had a hard time suppressing a smile as I drove off towards the city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "At last, there it was: the Port of Benfi. The ship to Kyr..."*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
