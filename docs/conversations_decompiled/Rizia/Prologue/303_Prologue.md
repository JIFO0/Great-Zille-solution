# Rizia/Prologue

- **ID konwersacji:** `303`
- **StoryPack:** `Rizia`
- **Tura:** `Prologue`
- **Lokalizacja pliku:** `Rizia/Prologue/303_Prologue.md`
- **Liczba węzłów dialogowych:** 373
- **Liczba wyborów gracza:** 151

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Prologue_HadAffairs`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_StayedOnCouncil`
- `RiziaDLC.Prologue_Studied`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Army_Unit_Support_Total`
- `RiziaDLC.Army_Unit_Tank_Total`
- `RiziaDLC.Authority_Modifier_BaseMonarchRomus`
- `RiziaDLC.Budget_Modifier_RizianGoldIndustry`
- `RiziaDLC.Country_DrugTrade`
- `RiziaDLC.Country_PublicOpinion`
- `RiziaDLC.Country_Tourism`
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Diplomacy_Wehlen_NegotiatingPower`
- `RiziaDLC.Energy_Modifier_BaseEnergy`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.LeaningValue_ProBusiness`
- `RiziaDLC.PersonalValue_BrokeTradition`
- `RiziaDLC.PersonalValue_Pacifist`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Prologue_BetrayedAxel`
- `RiziaDLC.Prologue_DadLetter`
- `RiziaDLC.Prologue_DadLetter_ThrowAway`
- `RiziaDLC.Prologue_DistantAsDad`
- `RiziaDLC.Prologue_EasyLife`
- `RiziaDLC.Prologue_FalloutWithDad`
- `RiziaDLC.Prologue_Focus_ArmedForces`
- `RiziaDLC.Prologue_Focus_EnergyIndustry`
- `RiziaDLC.Prologue_Focus_PRCampaign`
- `RiziaDLC.Prologue_Focus_SecurityCouncil`
- `RiziaDLC.Prologue_Focus_TreasuryFinances`
- `RiziaDLC.Prologue_FriendlyToPales`
- `RiziaDLC.Prologue_HadAffairs`
- `RiziaDLC.Prologue_HardLife`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Prologue_InBoatAccident`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_JoinedSuOmina`
- `RiziaDLC.Prologue_Limp`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_MetAxel`
- `RiziaDLC.Prologue_Monqiz_Arrests`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Prologue_Monqiz_Rebuild`
- `RiziaDLC.Prologue_NormalLife`
- `RiziaDLC.Prologue_Relations_PabelBoss`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Prologue_Religious`
- `RiziaDLC.Prologue_Scar`
- `RiziaDLC.Prologue_StayedOnCouncil`
- `RiziaDLC.Prologue_Studied`
- `RiziaDLC.Prologue_Summer_Court`
- `RiziaDLC.Prologue_Summer_Hugo`
- `RiziaDLC.Prologue_Summer_Zille`
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_Energy`
- `RiziaDLC.Resources_Military_Equipment`
- `RiziaDLC.Resources_Military_Manpower`
- `RiziaDLC.Resources_Military_Ships`
- `RiziaDLCSupport.Journal_Prologue_War_Stop`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 139

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Authority_Modifier_BaseMonarchRomus`
- `RiziaDLC.Budget_Modifier_RizianGoldIndustry`
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.Energy_Modifier_BaseEnergy`
- `RiziaDLC.Prologue_Focus_EnergyIndustry`
- `RiziaDLC.Prologue_FriendlyToPales`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Prologue_Relations_PabelBoss`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Prologue_Summer_Zille`
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Pabel`
- *...oraz 4 innych wskaźników.*

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[10]` (Player_Romus): `Variable["RiziaDLC.Prologue_LovedWife"] = true`
- Węzeł `[69]` (Paskal Beniwoll): `Variable["RiziaDLC.Prologue_Summer_Zille"] = true; Variable["RiziaDLC.Diplomacy_Wehlen_Negotiatin...`
- Węzeł `[70]` (Paskal Beniwoll): `Variable["RiziaDLC.Prologue_Summer_Court"] = true; EnableJournalEntry("Prologue_Summer_Court"); ;`
- Węzeł `[71]` (Paskal Beniwoll): `Variable["RiziaDLC.Prologue_Summer_Hugo"] = true; Variable["RiziaDLC.Relations_Hugo"] = Variable[...`
- Węzeł `[78]` (Paskal Beniwoll): `Variable["RiziaDLC.Prologue_StayedOnCouncil"] = true; Variable["RiziaDLC.Country_PublicOpinion"] ...`
- Węzeł `[79]` (Paskal Beniwoll): `Variable["RiziaDLC.Prologue_Studied"] = true; Variable["RiziaDLC.Resources_Budget"] = Variable["R...`
- Węzeł `[80]` (Paskal Beniwoll): `Variable["RiziaDLC.Prologue_JoinedMilitary"] = true; Variable["RiziaDLC.Resources_Authority"] = V...`
- Węzeł `[93]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] + 1; Va...`
- *...oraz 131 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: "1905|Monqiz|Kingdom of Rizia"]** — Mówca: **Narrator**
> "You opened your eyes to this realm.

Becoming a king was never your choice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...quickly became close friends."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...enjoyed bossing him around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "1930|June 20|Monqiz"]** — Mówca: **Narrator**
> "Your region came to see you as a cruel but capable leader.

One day, the king came for an unannounced visit. He brought with him a pale-skinned young woman with striking blue eyes.

Hesitantly, she introduced herself as Lena Livingston -- the sister of Queen Beatrice of Rumburg, and your wife-to-be."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You demanded to know what was going on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Narrator**
> "King Valero told you that he had no choice. 

With Wehlen descending into civil war, Rizia needed a new ally.

A partnership with the Kingdom of Rumburg, cemented with an arranged marriage, was in the best interest of both monarchies.

Besides, he added, you would surely grow to love her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "He was right."
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_LovedWife"] = true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "He was wrong."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "1932|March 1|A Family Man"]** — Mówca: **Narrator**
> "You and Lena went on a few dates, but neither of you felt a spark. By the time you lifted her veil, you knew the marriage was a sham.

For your countries' sake, you slept together a few times. One of those resulted in the birth of your daughter, Vina. 

After she was born, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[155]`
  - -> `[156]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "1927|Porte Drazon|A Changed Country"]** — Mówca: **Narrator**
> "The uprising had other consequences.

The traitor Lucas Sazon was executed, and his pregnant wife sent into exile. As further punishment, Iza -- the capital city of Brenas, and the Sazons' ancestral home -- was handed over to your family.

Your uncle Hugo was sent to serve as its steward. In turn, you were to take his place as reigning Duke of Valenqiris.

At your childhood home in Monqiz, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...focused on finding and punishing the remaining traitors to the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...largely ignored your duties and lived a life of leisure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...did your best to help your region rebuild."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "1932|March 1|A Family Man"]** — Mówca: **Narrator**
> "You and Lena began having hours-long conversations about your royal upbringings, hopes and dreams.

By the time you lifted her veil, you knew it was true love.

The years after your wedding and the birth of your daughter Vina were the happiest of your life. 

The only trouble was..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`
  - -> `[154]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "But it was too late."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[19]`
Mówca: **Narrator**
> "You were devastated.

After the funeral, your mother Estela came to visit and found you hardly able to function. She promptly moved in to help out with Vina. 

Hugo suggested you turn to Wruhecism, Rizia's official religion, to cope with your loss."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[20]`
  - -> `[332]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "If anything, you became less of a believer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[21]`
Mówca: **Narrator**
> "You mourned for a while.

But you also had a province to lead and a young daughter to care for. Your mother Estela moved in to help out with Vina. 

Hugo suggested you turn to Wruhecism, Rizia's official religion, to cope with your loss."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[20]`
  - -> `[332]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "1946|August|Porte Drazon"]** — Mówca: **Narrator**
> "Meanwhile, the situation in the capital worsened.

Rizian nationalists continued protesting the loss of Zille and the country’s growing pluralism. Rumors spread that an anti-monarchist movement was growing once more. Several long-operating gold mines were depleting as the expenses of the kingdom grew. 

Your father called Hugo back from Iza to keep an eye on his council."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You reasoned the King had brought his troubles on himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "1948|October|Porte Drazon"]** — Mówca: **Narrator**
> "Outsiders also took notice of the king's decline.

One of them was Axel Reinhart, the new ruler of the Grand Duchy of Pales.

He sent you an invitation to visit him, on two conditions: You were to go alone, and without your father's knowledge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[216]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You accepted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "1948|October 5|Pales|Confrontations"]** — Mówca: **Narrator**
> "It was your first time in Pales since childhood. You were surprised at how modern everything seemed now.

Duke Reinhart welcomed you to his palace. He said he was hoping to re-establish relations with Rizia once you became king.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`
  - -> `[29]`
  - -> `[208]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...told him that would only be possible once Pales rejoined Rizia, where it belonged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...said you were looking forward to putting the past behind you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...agreed that a thaw between Rizia and Pales could be lucrative on both sides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[30]`
Mówca: **Narrator**
> "The duke was taken aback and ordered you to leave at once.

Afterwards, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[31]`
Mówca: **Narrator**
> "The duke was satisfied with your answer. You spent the next few days getting to know him and the duchy better.

Afterwards, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[32]`
Mówca: **Narrator**
> "He'd gone straight to bed after dinner. When your mother went to check in on him later, she found him comatose in the bedroom.

The doctors suspected a heart attack."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You rushed to see him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You stayed where you were."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "1949|November 18|Porte Drazon"]** — Mówca: **Narrator**
> "Your father looked pale as a ghost. It took all his effort to speak.

In a hoarse whisper, he warned you not to follow in his footsteps.

Your reign would be a fresh start for House Toras. A new chance to take back the lands that were lost."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "1949|November 18|Porte Drazon"]** — Mówca: **Narrator**
> "The next day, King Valero Toras was no more.

You and Vina traveled to Porte Drazon to comfort your mother.

She handed you a note your father had written you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "He closed his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "His last words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Narrator**
> "In the letter, he warned you not to follow in his footsteps.

Your reign would be a fresh start for House Toras. A new chance to take back the lands that were lost."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Narrator**
> "Only after his funeral, gathered at the palace with your mother and daughter, did the realization begin to dawn on you.

From the day you were born, your entire life had been leading to this moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You fought back tears."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Now, it was finally here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You threw it away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It was your birthright."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It was your burden."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It was your calling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Narrator**
> "From a young age, you knew you were no ordinary child. 

You were Romus Toras. Grandson of Queen Lyza, ruler of all of Rizia. Son of Crown Prince Valero, the Duke of Valenqiris.

For most of the year, you lived with your father Valero and your mother Estela in a lavish palace atop the cliffs of Monqiz. Each summer, though, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...visited your mother's common-born family at their home by the Zille harbor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...stayed with the Queen at the royal residence in Porte Drazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...went hunting with your father's brother Hugo in the forests of Brenas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[51]`
Mówca: **Narrator**
> "Your uncle taught you more than just how to hold and aim a gun. 

You learned the value of staying patient and keeping your eyes and ears open at all times."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[313]`

### Węzeł `[52]`
Mówca: **Narrator**
> "You were fascinated by the splendor of your surroundings and the intricacies of your grandmother's court."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[313]`

### Węzeł `[53]`
Mówca: **Narrator**
> "Your grandparents were fisherpeople of modest means, and staying with them helped you feel grounded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[313]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "1918|January 28|Porte Drazon|A New King"]** — Mówca: **Narrator**
> "When Queen Lyza died, the whole country grieved.

But the mourning could only last for so long."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...asked him about the rumors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...didn't mention either."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[57]`
Mówca: **Narrator**
> "Your father laughed and told you certain other royals had never approved of him marrying a commoner.

But he and Estela were in love. And love conquered all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[72]`

### Węzeł `[58]`
Mówca: **Narrator**
> "Your father laughed and told you that some people had come to believe Rizia shouldn't be ruled by a monarch anymore.

But of course, he assured you, they were wrong."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[72]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You had your doubts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "1920"]** — Mówca: **Narrator**
> "Life in Porte Drazon was less exciting than you expected. You were tutored privately and rarely had contact with non-royals.

At the palace, the closest person to your age was Pabel, the groundskeeper's son -- a quiet but friendly kid who knew about every plant in the gardens. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...didn't have much to do with each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "1923|September"]** — Mówca: **Narrator**
> "When you came of age, your father invited you to start sitting in on royal council meetings. You decided..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...that you would love to join."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...to go to university instead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...to join the military instead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[66]`
Mówca: **Narrator**
> "The council members took you under their wing, catching you up on the issues of the day.

One of their main concerns was Pales, a former part of Rizia that had long belonged to the Empire of Valgos.

Now that the empire had fallen, war councilor General Taddeus Azaro was launching a military campaign to take the newly independent region back. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`
  - -> `[75]`

### Węzeł `[67]`
Mówca: **Narrator**
> "At the prestigious University of Iza, you studied history, politics and economics to prepare for your eventual reign.

In one of your classes, an argument broke out about Pales, a former part of Rizia that had long belonged to the Empire of Valgos.

Now that the empire had fallen, your father's government was launching a military campaign to take the newly independent region back. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`
  - -> `[75]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Every autumn, you returned home a little wiser."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Zille = true; RiziaDLC.Diplomacy_Wehlen_NegotiatingPower += 1;
EnableJournalEntry("Prologue_Summer_Zille");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_Summer_Zille"] = true;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] + 1;
EnableJournalEntry("Prologue_Summer_Zille");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Court = true;
EnableJournalEntry("Prologue_Summer_Court");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_Summer_Court"] = true;
EnableJournalEntry("Prologue_Summer_Court");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo = true;
RiziaDLC.Relations_Hugo += 1;
EnableJournalEntry("Prologue_Summer_Hugo");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] = true;
Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] + 1;
EnableJournalEntry("Prologue_Summer_Hugo");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You believed him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...thought it was a lost cause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...agreed that it was time to reconquer the territory."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...didn't have an opinion either way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[76]`
Mówca: **Narrator**
> "At the prestigious Camp Domus academy in the mountains of Montaklar, you learned about war strategy and combat tactics.

One day, the royal war councillor, General Taddeus Azaro, came to visit. He announced a military campaign on Pales, a former part of Rizia that had long belonged to the Empire of Valgos.

Now that the empire had fallen, he said, the time was right to take the region back. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`
  - -> `[75]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "1925|War and Uncertainty"]** — Mówca: **Narrator**
> "As you continued to serve on the council, the Reclamation War dragged on.

It seemed like an easy victory until your northern neighbor Lespia got involved, sending weapons and financial aid to Pales.

Protests against the war sprouted up around the country. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`
  - -> `[91]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil = true;
RiziaDLC.Country_PublicOpinion += 2;
EnableJournalEntry("Prologue_Age_RoyalCouncil");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] = true;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] + 2;
EnableJournalEntry("Prologue_Age_RoyalCouncil");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied = true;
RiziaDLC.Resources_Budget += 1;
EnableJournalEntry("Prologue_Age_University");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_Studied"] = true;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 1;
EnableJournalEntry("Prologue_Age_University");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary = true;
RiziaDLC.Resources_Authority += 1;
EnableJournalEntry("Prologue_Age_Military");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] = true;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 1;
EnableJournalEntry("Prologue_Age_Military");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_StayedOnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Studied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "1925|War and Uncertainty"]** — Mówca: **Narrator**
> "As you continued your studies, the Reclamation War dragged on.

It seemed like an easy victory until your northern neighbor Lespia got involved, sending weapons and financial aid to Pales.

Protests against the war sprouted up on campus. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`
  - -> `[91]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "1925|War and Uncertainty"]** — Mówca: **Narrator**
> "You weren't allowed to fight on the ground, so you watched from General Azaro's headquarters as the Reclamation War dragged on.

It seemed like an easy victory until your northern neighbor Lespia got involved, sending weapons and financial aid to Pales.

Dissent began brewing among your fellow recruits. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`
  - -> `[91]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...asked your father to stop the bloodshed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...demanded that he crack down on the traitors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...refrained from taking sides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "1926|April 7|Porte Drazon"]** — Mówca: **Narrator**
> "Some troops were withdrawn, but the fire had been lit.

Your next council meeting was interrupted by the announcement that the navy had mutinied. Bloody clashes between pro- and anti-monarchists were erupting across the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Pacifist += 1;
RiziaDLCSupport.Journal_Prologue_War_Stop = true;
EnableJournalEntry("Prologue_War_Stop");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] + 1;
Variable["RiziaDLCSupport.Journal_Prologue_War_Stop"] = true;
EnableJournalEntry("Prologue_War_Stop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority += 1;
RiziaDLC.PersonalValue_Pacifist -= 1;
RiziaDLC.PersonalValue_Tyrant += 1;
RiziaDLC.LeaningValue_Democratic -= 1;
EnableJournalEntry("Prologue_War_Crackdown");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 1;
Variable["RiziaDLC.PersonalValue_Pacifist"] = Variable["RiziaDLC.PersonalValue_Pacifist"] - 1;
Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
EnableJournalEntry("Prologue_War_Crackdown");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_StayedOnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Studied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_StayedOnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Studied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The Century of Revolutions had reached Rizia at last."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[108]`
**[WYBÓR GRACZA: "1926|April 7|Iza"]** — Mówca: **Narrator**
> "Some troops were withdrawn, but the fire had been lit.

The next day, class was interrupted by the announcement that the navy had mutinied. Bloody clashes between pro- and anti-monarchists were erupting across the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[109]`
**[WYBÓR GRACZA: "1926|April 7|Montaklar"]** — Mówca: **Narrator**
> "Some troops were withdrawn, but the fire had been lit.

The next day, General Azaro burst into headquarters with the news that the navy had mutinied. Bloody clashes between pro- and anti-monarchists were erupting across the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "1926|April 7|Porte Drazon"]** — Mówca: **Narrator**
> "A few arrests were made, but the fire had been lit.

Your next council meeting was interrupted by the announcement that the navy had mutinied. Bloody clashes between pro- and anti-monarchists were erupting across the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[111]`
**[WYBÓR GRACZA: "1926|April 7|Iza"]** — Mówca: **Narrator**
> "A few arrests were made, but the fire had been lit.

The next day, class was interrupted by the announcement that the navy had mutinied. Bloody clashes between pro- and anti-monarchists were erupting across the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[112]`
**[WYBÓR GRACZA: "1926|April 7|Montaklar"]** — Mówca: **Narrator**
> "A few arrests were made, but the fire had been lit.

The next day, General Azaro burst into headquarters with the news that the navy had mutinied. Bloody clashes between pro- and anti-monarchists were erupting across the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_StayedOnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "1926|April 7|Montaklar"]** — Mówca: **Narrator**
> "You hoped it would all pass, but the fire had been lit.

One day, General Azaro burst into headquarters with the news that the navy had mutinied. Bloody clashes between pro- and anti-monarchists were erupting across the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Studied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "1926|April 7|Iza"]** — Mówca: **Narrator**
> "You hoped it would all pass, but the fire had been lit.

One day, class was interrupted by the announcement that the navy had mutinied. Bloody clashes between pro- and anti-monarchists were erupting across the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[121]`
**[WYBÓR GRACZA: "1926|April 7|Porte Drazon"]** — Mówca: **Narrator**
> "You hoped it would all pass, but the fire had been lit.

Your next council meeting was interrupted by the announcement that the navy had mutinied. Bloody clashes between pro- and anti-monarchists were erupting across the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[122]`
Mówca: **Narrator**
> "The head of palace security insisted you be driven to a safehouse outside of Porte Drazon.

As you left city limits, though, an unmarked car swerved in front of you, blocking the road.

A trio of masked men with guns jumped out, quickly overpowered your guards and forced you out of the vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_StayedOnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Studied == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Studied == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You tried to fight them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You complied with their demands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You tried to run away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[132]`
Mówca: **Narrator**
> "The king insisted you be driven back to the capital immediately.

As you left Iza city limits, though, an unmarked car swerved in front of you, blocking the road.

A trio of masked men with guns jumped out, quickly overpowered your guards and forced you out of the vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[133]`
Mówca: **Narrator**
> "The king insisted you be driven back to the capital immediately.

As you left Montaklar, though, an unmarked car swerved in front of you, blocking the road.

A trio of masked men with guns jumped out, quickly overpowered your guards and forced you out of the vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You tried to fight them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Narrator**
> "Your military training kicked in and you put up a serious struggle. They shot you in the shoulder before you were finally subdued.

As your consciousness faded, you recognized one of your captors' voices: Lucas Sazon, Duke of Brenas and the head of Rizia's third royal house.

A hood went over your head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[136]`
Mówca: **Narrator**
> "You ran for your life. But before you could get far, you felt a sharp pain in your leg and collapsed.

As your captors caught up with you, you recognized one of their voices: Lucas Sazon, Duke of Brenas and the head of Rizia's third royal house.

A hood went over your head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[137]`
Mówca: **Narrator**
> "You recognized one of their voices: Lucas Sazon, Duke of Brenas and the head of Rizia's third royal house.

A hood went over your head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[138]`
Mówca: **Narrator**
> "Your captors subdued you after only the slightest struggle. 

You recognized one of their voices: Lucas Sazon, Duke of Brenas and the head of Rizia's third royal house.

A hood went over your head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Then, darkness."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
**[WYBÓR GRACZA: "1926|April 13"]** — Mówca: **Narrator**
> "They held you captive for nearly a week.

When rescue finally came, it was in the form of a man with a white, blue and magenta flag on his fatigues."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Scar = true;
EnableJournalEntry("Prologue_Kidnapping_FightMilitary");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_Scar"] = true;
EnableJournalEntry("Prologue_Kidnapping_FightMilitary");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Limp = true;
EnableJournalEntry("Prologue_Kidnapping_Run");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_Limp"] = true;
EnableJournalEntry("Prologue_Kidnapping_Run");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Wehlen's flag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[144]`
**[WYBÓR GRACZA: "1926|April 13|Porte Drazon"]** — Mówca: **Narrator**
> "At the palace, you pieced together what had happened.

In desperation, your father had pleaded for the aid of Rizia's northern neighbor, Wehlen, to neutralize the uprising.

But that help came at a price. Over the next year, the two nations worked out an agreement to transfer control of the port of Zille and its surrounding region -- home to rich natural resources and millions of people.

For the next 25 years, Zille would belong to Wehlen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`
  - -> `[147]`

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You wondered how King Valero could have been so stupid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You thanked him for restoring order."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You were just happy to be alive."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[148]`
**[WYBÓR GRACZA: "1930|June 20|Monqiz"]** — Mówca: **Narrator**
> "You were a constant newspaper fixture. They called you the "Party Prince".

One day, the king came for an unannounced visit. He brought with him a pale-skinned young woman with striking blue eyes.

Hesitantly, she introduced herself as Lena Livingston -- the sister of Queen Beatrice of Rumburg, and your wife-to-be."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[149]`
**[WYBÓR GRACZA: "1930|June 20|Monqiz"]** — Mówca: **Narrator**
> "Valenqiris came to see you as a generous, capable leader.

One day, the king came for an unannounced visit. He brought with him a pale-skinned young woman with striking blue eyes.

Hesitantly, she introduced herself as Lena Livingston -- the sister of Queen Beatrice of Rumburg, and your wife-to-be."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You kissed her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife = true;
EnableJournalEntry("Prologue_Marriage_Love");
EnableJournalEntry("Prologue_Marriage_VinaBirth");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_LovedWife"] = true;
EnableJournalEntry("Prologue_Marriage_Love");
EnableJournalEntry("Prologue_Marriage_VinaBirth");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...that your royal duties left you too busy to spend time with family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...that your commitment to being a good husband and father sometimes meant you neglected your work."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...that you couldn't stop yourself from having the occasional affair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...tried your best to be a good father."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...ignored your family and threw yourself into your work."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...had a string of affairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[158]`
**[WYBÓR GRACZA: "1933"]** — Mówca: **Narrator**
> "With Rumburg's help, Rizia's economy bounced back to levels it hadn't seen since the glory days of Queen Lyza.

Wealthy Rumburgians started moving to the cities. So did economic migrants from neighboring Morella and Derdia, and Wehzeks seeking asylum from the civil war.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[160]`
  - -> `[231]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HadAffairs = true;
EnableJournalEntry("Prologue_MarriageIssue_Affairs");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_HadAffairs"] = true;
EnableJournalEntry("Prologue_MarriageIssue_Affairs");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...were suspicious of these newcomers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[161]`
**[WYBÓR GRACZA: "1939|Iza"]** — Mówca: **Narrator**
> "Many of the foreigners ended up in the province of Brenas, where a nationalist movement called Su Omina began demanding that the King put Rizia "above all".

As Duke of Iza, your uncle Hugo turned a blind eye to Su Omina's activities, while his teenage son Ricardus became a vocal supporter.

Eventually, Ricardus -- better known as Rico -- approached you about speaking at one of the group's rallies."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You agreed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You refused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[164]`
Mówca: **Narrator**
> "You threw your weight behind Su Omina, increasing the group's legitimacy and following.

Your parents were displeased, but said nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...happily came along."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[166]`
Mówca: **Narrator**
> "You distanced yourself from the organization and from Rico. 

Your uncle was displeased, but said nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...went, but only for your daughter's sake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...decided to get some work done instead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HadAffairs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HadAffairs == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HadAffairs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HadAffairs == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HadAffairs"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[175]`
**[WYBÓR GRACZA: "1942|May 20|Monqiz"]** — Mówca: **Narrator**
> "You were putting your clothes back on when you got the call.

The weather had turned stormy in the middle of the Gulf of Valenqiris. When the captain tried to turn the boat around, it was hit by a breaking wave and cracked in half.

The Coast Guard managed to save Vina on time. But by the time they pulled your wife out, she was barely breathing.

You rushed to the hospital."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "A few years passed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[177]`
**[WYBÓR GRACZA: "1942|May|Monqiz"]** — Mówca: **Narrator**
> "You found yourself under more and more pressure to make up for your father's shortcomings. 

Lena was patient and understanding -- one of the many things you loved about her.

For her 10th birthday, Vina asked to go on a sailing trip with the two of you. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[171]`
  - -> `[172]`

### Węzeł `[178]`
**[WYBÓR GRACZA: "1942|May|Monqiz"]** — Mówca: **Narrator**
> "You found yourself under more and more pressure to make up for your father's shortcomings. 

Between that and your loveless marriage, you had few sources of joy in your life -- except for Vina.

For her 10th birthday, she asked you and Lena to take her on a sailing trip. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[170]`
  - -> `[171]`
  - -> `[172]`

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...decided to meet your latest lover instead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[180]`
**[WYBÓR GRACZA: "1942|May 20|Monqiz"]** — Mówca: **Narrator**
> "You were in your office when you got the call.

The weather had turned stormy in the middle of the Gulf of Valenqiris. When the captain tried to turn the boat around, it was hit by a breaking wave and cracked in half.

The coast guard managed to save Vina on time. But by the time they pulled your wife out, she was barely breathing.

You rushed to the hospital."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[181]`
**[WYBÓR GRACZA: "1942|May 20|Monqiz"]** — Mówca: **Narrator**
> "In the middle of the Gulf of Valenqiris, the weather turned unexpectedly stormy. 

When the captain tried to turn the boat around, it was hit by a breaking wave and cracked in half.

The coast guard got to you and your daughter on time, but by the time they pulled Lena out, she was barely breathing.

They rushed her to the hospital."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_LovedWife == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_LovedWife == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "She died holding your hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You began to get suspicious as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You wondered what the country was coming to."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales = true; RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 1;
EnableJournalEntry("Prologue_AxelVisit_Hostile");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_HostileToPales"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - 1;
EnableJournalEntry("Prologue_AxelVisit_Hostile");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...told your father about your trip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...lied to him about where you'd been."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
**[WYBÓR GRACZA: "1948|October 8|Porte Drazon"]** — Mówca: **Narrator**
> "The king was pleased you'd stood up to the duke, but furious you had gone behind his back.

He accused you of betrayal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[198]`
  - -> `[197]`
  - -> `[196]`

### Węzeł `[195]`
**[WYBÓR GRACZA: "1948|October 8|Porte Drazon"]** — Mówca: **Narrator**
> "The king was furious. He accused you of betrayal.

He ordered you to tell him about your meeting with the Duke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`
  - -> `[197]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You said nothing and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You exploded at him for being an incompetent ruler."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You begged for his forgiveness."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You assured him you were on his side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[200]`
**[WYBÓR GRACZA: "1949|November|Monqiz|Farewells"]** — Mówca: **Narrator**
> "As Vina grew into an intelligent, self-reliant young woman, your mother moved from Monqiz back to the capital.

She called you one night, her voice shaking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[201]`
**[WYBÓR GRACZA: "1949|November|Monqiz|Farewells"]** — Mówca: **Narrator**
> "You had only occasional contact with your father in the months that followed.

As Vina grew into an intelligent, self-reliant young woman, your mother moved from Monqiz back to the capital.

She called you one night, her voice shaking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The king was dying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FalloutWithDad = true;
EnableJournalEntry("Prologue_Axel_FatherFallout");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] = true;
EnableJournalEntry("Prologue_Axel_FatherFallout");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_DistantAsDad = true;
EnableJournalEntry("Prologue_MarriageIssue_AbsentFather");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_DistantAsDad"] = true;
EnableJournalEntry("Prologue_MarriageIssue_AbsentFather");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend = true; RiziaDLC.Relations_Pabel += 1;
EnableJournalEntry("Prologue_Pabel_Friends");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] = true;
Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] + 1;
EnableJournalEntry("Prologue_Pabel_Friends");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelBoss = true; RiziaDLC.Relations_Pabel -= 1;
EnableJournalEntry("Prologue_Pabel_Boss");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_Relations_PabelBoss"] = true;
Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;
EnableJournalEntry("Prologue_Pabel_Boss");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_DadLetter = true;
EnableJournalEntry("Prologue_FatherDeath_Stay");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_DadLetter"] = true;
EnableJournalEntry("Prologue_FatherDeath_Stay");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...refused to promise anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[209]`
Mówca: **Narrator**
> "The duke accepted your answer. Despite his disappointment, he invited you to spend the next few days getting to know him and the duchy better.

Afterwards, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
**[WYBÓR GRACZA: "1948|October 8|Porte Drazon"]** — Mówca: **Narrator**
> "A few days later, the King summoned you to the capital for a confrontation.

He'd had his personal security force, the Golden Guard, surveil you in Pales. 

He accused you of betrayal and ordered you to tell him about your meeting with the Duke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`
  - -> `[197]`

### Węzeł `[214]`
**[WYBÓR GRACZA: "1948|October 8|Porte Drazon"]** — Mówca: **Narrator**
> "A few days later, the King summoned you to the capital for a confrontation.

He'd had his personal security force, the Golden Guard, surveil you in Pales. 

He was pleased you'd stood up to the duke, but furious you had lied to him. He accused you of betrayal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[198]`
  - -> `[197]`
  - -> `[196]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina = true; RiziaDLC.LeaningValue_Democratic -= 1;
EnableJournalEntry("Prologue_SuOmina_Agreed");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] = true;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
EnableJournalEntry("Prologue_SuOmina_Agreed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You declined."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[217]`
Mówca: **Narrator**
> "A few days later, you received a letter from Pales.

Duke Reinhart expressed his disappointment that you couldn't meet him, and wrote that he hoped to re-establish relations between Pales and Rizia once you took the throne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You showed it to the king."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You kept it to yourself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[220]`
**[WYBÓR GRACZA: "1948|October 8|Porte Drazon"]** — Mówca: **Narrator**
> "Valero thanked you for your honesty. He confided in you that you were one of the only people he trusted now.

He wrote back to Duke Reinhart that his ploy had failed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[221]`
**[WYBÓR GRACZA: "1948|October 8|Porte Drazon"]** — Mówca: **Narrator**
> "A few days later, the King summoned you to the capital for a confrontation.

He'd ordered his personal security force, the Golden Guard, to begin inspecting family members' mail.

He accused you of betrayal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_Arrests = true; 
RiziaDLC.PersonalValue_Tyrant += 1;
RiziaDLC.Resources_Authority += 1;
EnableJournalEntry("Prologue_Duke_Punish");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_Monqiz_Arrests"] = true;
Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 1;
EnableJournalEntry("Prologue_Duke_Punish");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince = true; RiziaDLC.PersonalValue_BrokeTradition += 1;
RiziaDLC.Country_PublicOpinion += 1;
EnableJournalEntry("Prologue_Duke_Leisure");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] = true;
Variable["RiziaDLC.PersonalValue_BrokeTradition"] = Variable["RiziaDLC.PersonalValue_BrokeTradition"] + 1;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] + 1;
EnableJournalEntry("Prologue_Duke_Leisure");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_Rebuild = true; 
RiziaDLC.Resources_Budget += 1;
EnableJournalEntry("Prologue_Duke_Rebuild");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_Monqiz_Rebuild"] = true;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 1;
EnableJournalEntry("Prologue_Duke_Rebuild");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_InBoatAccident = true;
EnableJournalEntry("Prologue_BoatTrip_CameAlong");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_InBoatAccident"] = true;
EnableJournalEntry("Prologue_BoatTrip_CameAlong");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...asked him about the protests."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: DontPlayMapMusic();)*
- **Efekt (`userScript`):** `DontPlayMapMusic();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "In faith, you finally found solace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious = true;
RiziaDLC.PersonalValue_Religious += 2;
EnableJournalEntry("Prologue_DeadWife_Religious");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_Religious"] = true;
Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 2;
EnableJournalEntry("Prologue_DeadWife_Religious");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...celebrated Rizia's new diversity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...welcomed the new arrivals, but were secretly glad that few of them settled in your province."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[232]`
**[WYBÓR GRACZA: "1942|Porte Drazon|Dark Horizons"]** — Mówca: **Narrator**
> "You slowly realized that the uprising had broken something in your father.

He began neglecting his duties as he became increasingly preoccupied with threats, both real and imaginary. 

Outside of the country, he gained a new nickname."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Valero the Frail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_FriendlyToPales = true; RiziaDLC.Diplomacy_Pales_NegotiatingPower += 1;
EnableJournalEntry("Prologue_AxelVisit_Friendly");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_FriendlyToPales"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] + 1;
EnableJournalEntry("Prologue_AxelVisit_Friendly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_MetAxel = true;
EnableJournalEntry("Prologue_AxelInvitation_Accepted");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_MetAxel"] = true;
EnableJournalEntry("Prologue_AxelInvitation_Accepted");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales = true; RiziaDLC.Prologue_BetrayedAxel = true; RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 1;
EnableJournalEntry("Prologue_AxelLetter_Truth");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_HostileToPales"] = true;
Variable["RiziaDLC.Prologue_BetrayedAxel"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - 1;
EnableJournalEntry("Prologue_AxelLetter_Truth");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_princebirth");)*
- **Efekt (`userScript`):** `PrologueImage("pe_princebirth");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`
  - -> `[46]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_death of queen Lyza");)*
- **Efekt (`userScript`):** `PrologueImage("pe_death of queen Lyza");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_children_playing");)*
- **Efekt (`userScript`):** `PrologueImage("pe_children_playing");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`
  - -> `[61]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_innercircle");)*
- **Efekt (`userScript`):** `PrologueImage("pe_innercircle");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`
  - -> `[65]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_pales_war_begins");)*
- **Efekt (`userScript`):** `PrologueImage("pe_pales_war_begins");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_navy_mutiny");)*
- **Efekt (`userScript`):** `PrologueImage("pe_navy_mutiny");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_kidnapping");)*
- **Efekt (`userScript`):** `PrologueImage("pe_kidnapping");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_dealsigning");)*
- **Efekt (`userScript`):** `PrologueImage("pe_dealsigning");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_hanging");)*
- **Efekt (`userScript`):** `PrologueImage("pe_hanging");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`
  - -> `[16]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_royalwedding");)*
- **Efekt (`userScript`):** `PrologueImage("pe_royalwedding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[150]`
  - -> `[8]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_refugees");)*
- **Efekt (`userScript`):** `PrologueImage("pe_refugees");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_suomina");)*
- **Efekt (`userScript`):** `PrologueImage("pe_suomina");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[334]`
  - -> `[163]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_frailking");)*
- **Efekt (`userScript`):** `PrologueImage("pe_frailking");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_sailboat");)*
- **Efekt (`userScript`):** `PrologueImage("pe_sailboat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_suomina2");)*
- **Efekt (`userScript`):** `PrologueImage("pe_suomina2");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[23]`
  - -> `[333]`
  - -> `[186]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_palesvisit");)*
- **Efekt (`userScript`):** `PrologueImage("pe_palesvisit");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_palesalt");)*
- **Efekt (`userScript`):** `PrologueImage("pe_palesalt");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[271]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_letter");)*
- **Efekt (`userScript`):** `PrologueImage("pe_letter");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[272]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_meetking");)*
- **Efekt (`userScript`):** `PrologueImage("pe_meetking");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[198]`
  - -> `[197]`
  - -> `[196]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_deadking");)*
- **Efekt (`userScript`):** `PrologueImage("pe_deadking");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_coronation");)*
- **Efekt (`userScript`):** `PrologueImage("pe_coronation");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: DontPlayMapAmbience();)*
- **Efekt (`userScript`):** `DontPlayMapAmbience();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_gun_at_car");)*
- **Efekt (`userScript`):** `PrologueImage("pe_gun_at_car");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`
  - -> `[308]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_sailboat");)*
- **Efekt (`userScript`):** `PrologueImage("pe_sailboat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_sailboat");)*
- **Efekt (`userScript`):** `PrologueImage("pe_sailboat");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_mourning");)*
- **Efekt (`userScript`):** `PrologueImage("pe_mourning");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_religious");)*
- **Efekt (`userScript`):** `PrologueImage("pe_religious");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_mourning");)*
- **Efekt (`userScript`):** `PrologueImage("pe_mourning");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_meetking");)*
- **Efekt (`userScript`):** `PrologueImage("pe_meetking");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_monqiz");)*
- **Efekt (`userScript`):** `PrologueImage("pe_monqiz");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`
  - -> `[50]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_meetking");)*
- **Efekt (`userScript`):** `PrologueImage("pe_meetking");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PrologueImage("pe_meetking");)*
- **Efekt (`userScript`):** `PrologueImage("pe_meetking");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Monqiz");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Monqiz");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("QueenDeath");)*
- **Efekt (`userScript`):** `PlaySoundEffect("QueenDeath");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("WarSpeech");)*
- **Efekt (`userScript`):** `PlaySoundEffect("WarSpeech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("ProtestorsAngry");)*
- **Efekt (`userScript`):** `PlaySoundEffect("ProtestorsAngry");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Kidnap");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Kidnap");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("DealSigning");)*
- **Efekt (`userScript`):** `PlaySoundEffect("DealSigning");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Hanging");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Hanging");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("RoyalWedding");)*
- **Efekt (`userScript`):** `PlaySoundEffect("RoyalWedding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("RoyalWedding");)*
- **Efekt (`userScript`):** `PlaySoundEffect("RoyalWedding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("SuOmina1");)*
- **Efekt (`userScript`):** `PlaySoundEffect("SuOmina1");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("StormAtSea");)*
- **Efekt (`userScript`):** `PlaySoundEffect("StormAtSea");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("StormAtSea");)*
- **Efekt (`userScript`):** `PlaySoundEffect("StormAtSea");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("StormAtSea");)*
- **Efekt (`userScript`):** `PlaySoundEffect("StormAtSea");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("SuOmina2");)*
- **Efekt (`userScript`):** `PlaySoundEffect("SuOmina2");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You went against Duke Reinhart's wishes and gave your father every last detail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You kept your mouth shut."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales = true; RiziaDLC.Prologue_BetrayedAxel = true; RiziaDLC.Diplomacy_Pales_NegotiatingPower -= -1;
EnableJournalEntry("Prologue_Axel_FatherPloyFailed");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_HostileToPales"] = true;
Variable["RiziaDLC.Prologue_BetrayedAxel"] = true;
Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - -1;
EnableJournalEntry("Prologue_Axel_FatherPloyFailed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
Mówca: **Narrator**
> "Valero wrote to Duke Reinhart that his ploy had failed. You heard nothing from Pales after that."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[304]`
Mówca: **Narrator**
> "Valero banished you from his sights. You didn't speak to him at all in the months that followed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_DadLetter_ThrowAway = true;
EnableJournalEntry("Prologue_FatherLastWords_NoteDiscard");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] = true;
EnableJournalEntry("Prologue_FatherLastWords_NoteDiscard");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[306]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_DadLetter_ThrowAway = false;
EnableJournalEntry("Prologue_FatherLastWords_NoteKeep");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_DadLetter_ThrowAway"] = false;
EnableJournalEntry("Prologue_FatherLastWords_NoteKeep");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[307]`
**[WYBÓR GRACZA: "1949|November|Monqiz|Farewells"]** — Mówca: **Narrator**
> "You stayed close with your father in the months that followed, though you were both too busy to see each other as often as you would have liked. 

As Vina grew into an intelligent, self-reliant young woman, your mother moved from Monqiz back to the capital.

She called you one night, her voice shaking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "There was a new king to crown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[312]`
Mówca: **Narrator**
> "You remember two things about King Valero's coronation: the whispers that Hugo, now the Duke of Valenqiris, was actually the rightful king. And the shouts of protesters outside the palace gates.

Alone with your father after the ceremony, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[226]`
  - -> `[56]`

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "It felt good to have caring relatives."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_WeddingRing");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_WeddingRing");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("PalesVisit");)*
- **Efekt (`userScript`):** `PlaySoundEffect("PalesVisit");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_MainTheme", "R_MainTheme_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_MainTheme","R_MainTheme_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UnlockAchievement("RiziaPrologue_Finish");)*
- **Efekt (`userScript`):** `UnlockAchievement("RiziaPrologue_Finish");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[320]`
**[WYBÓR GRACZA: "1947|October|Porte Drazon"]** — Mówca: **Narrator**
> "Even with Hugo advising him as Grand Vizier, King Valero seemed powerless to address the escalating tensions. 

Hugo suggested to the King that you be entrusted with certain responsibilities. Upon agreement from the King and the Royal Council, you were granted the opportunity to aid as the Crown Prince. 

You chose to concentrate on..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[330]`
  - -> `[323]`
  - -> `[324]`
  - -> `[325]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_SecurityCouncil = true;
RiziaDLC.Resources_Authority += 2;
EvaluateConditionalInstruction("DrugTrade_Start");
RiziaDLC.Country_DrugTrade -= 1;
RiziaDLC.Authority_Modifier_BaseMonarchRomus += 1;
RiziaDLC.Country_PublicOpinion += 1;
EnableJournalEntry("Prologue_HelpFather_Security");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_Focus_SecurityCouncil"] = true;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 2;
EvaluateConditionalInstruction("DrugTrade_Start");
Variable["RiziaDLC.Country_DrugTrade"] = Variable["RiziaDLC.Country_DrugTrade"] - 1;
Variable["RiziaDLC.Authority_Modifier_BaseMonarchRomus"] = Variable["RiziaDLC.Authority_Modifier_BaseMonarchRomus"] + 1;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] + 1;
EnableJournalEntry("Prologue_HelpFather_Security");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...enforcing internal security and the passing of necessary royal decrees."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...increasing gold extraction and improving tax efficiency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...enhancing the extraction of oil, coal, and gas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...spearheading a public relations campaign to boost national opinion of the Royal Family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_TreasuryFinances = true;
RiziaDLC.Resources_Budget += 3;
RiziaDLC.Country_PublicOpinion -= 2;
RiziaDLC.Budget_Modifier_RizianGoldIndustry += 1;
EnableJournalEntry("Prologue_HelpFather_GoldExtractionAndTaxEfficiency");
EvaluateConditionalInstruction("DrugTrade_Start");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_Focus_TreasuryFinances"] = true;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 3;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] - 2;
Variable["RiziaDLC.Budget_Modifier_RizianGoldIndustry"] = Variable["RiziaDLC.Budget_Modifier_RizianGoldIndustry"] + 1;
EnableJournalEntry("Prologue_HelpFather_GoldExtractionAndTaxEfficiency");
EvaluateConditionalInstruction("DrugTrade_Start");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_EnergyIndustry = true;
RiziaDLC.Resources_Energy += 2;
RiziaDLC.Energy_Modifier_BaseEnergy += 1;
RiziaDLC.LeaningValue_ProBusiness += 1;
RiziaDLC.Country_Tourism -= 1;
EnableJournalEntry("Prologue_HelpFather_EnergyProduction");
EvaluateConditionalInstruction("DrugTrade_Start");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_Focus_EnergyIndustry"] = true;
Variable["RiziaDLC.Resources_Energy"] = Variable["RiziaDLC.Resources_Energy"] + 2;
Variable["RiziaDLC.Energy_Modifier_BaseEnergy"] = Variable["RiziaDLC.Energy_Modifier_BaseEnergy"] + 1;
Variable["RiziaDLC.LeaningValue_ProBusiness"] = Variable["RiziaDLC.LeaningValue_ProBusiness"] + 1;
Variable["RiziaDLC.Country_Tourism"] = Variable["RiziaDLC.Country_Tourism"] - 1;
EnableJournalEntry("Prologue_HelpFather_EnergyProduction");
EvaluateConditionalInstruction("DrugTrade_Start");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_PRCampaign = true;
RiziaDLC.Resources_Authority += 1;
RiziaDLC.Country_Tourism += 1;
RiziaDLC.PersonalValue_BrokeTradition -= 1;
RiziaDLC.Country_PublicOpinion += 5;
EnableJournalEntry("Prologue_HelpFather_PublicRelations");
EvaluateConditionalInstruction("DrugTrade_Start");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_Focus_PRCampaign"] = true;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 1;
Variable["RiziaDLC.Country_Tourism"] = Variable["RiziaDLC.Country_Tourism"] + 1;
Variable["RiziaDLC.PersonalValue_BrokeTradition"] = Variable["RiziaDLC.PersonalValue_BrokeTradition"] - 1;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] + 5;
EnableJournalEntry("Prologue_HelpFather_PublicRelations");
EvaluateConditionalInstruction("DrugTrade_Start");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AdvanceTimeline();)*
- **Efekt (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "...strengthening the armed forces and building new military formations."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Focus_ArmedForces = true;
RiziaDLC.Army_Unit_Support_Total += 2;
RiziaDLC.Army_Unit_Tank_Total += 1;
RiziaDLC.Resources_Military_Ships += 1;
RiziaDLC.Resources_Military_Equipment += 1000;
RiziaDLC.Resources_Military_Manpower += 500;
EnableJournalEntry("Prologue_HelpFather_ArmedForces");
EvaluateConditionalInstruction("DrugTrade_Start");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_Focus_ArmedForces"] = true;
Variable["RiziaDLC.Army_Unit_Support_Total"] = Variable["RiziaDLC.Army_Unit_Support_Total"] + 2;
Variable["RiziaDLC.Army_Unit_Tank_Total"] = Variable["RiziaDLC.Army_Unit_Tank_Total"] + 1;
Variable["RiziaDLC.Resources_Military_Ships"] = Variable["RiziaDLC.Resources_Military_Ships"] + 1;
Variable["RiziaDLC.Resources_Military_Equipment"] = Variable["RiziaDLC.Resources_Military_Equipment"] + 1000;
Variable["RiziaDLC.Resources_Military_Manpower"] = Variable["RiziaDLC.Resources_Military_Manpower"] + 500;
EnableJournalEntry("Prologue_HelpFather_ArmedForces");
EvaluateConditionalInstruction("DrugTrade_Start");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "The world seemed dull and meaningless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You believed that things could be better."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You attended, but did not speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[335]`
Mówca: **Narrator**
> "You watched as the organizations' leaders bemoaned the loss of Rizian territory, identity and values.

They stopped just short of blaming King Valero directly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "You heard nothing from Pales after that."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableJournalEntry("Prologue_Kidnapping_Comply");)*
- **Efekt (`userScript`):** `EnableJournalEntry("Prologue_Kidnapping_Comply");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableJournalEntry("Prologue_Kidnapping_Fight");)*
- **Efekt (`userScript`):** `EnableJournalEntry("Prologue_Kidnapping_Fight");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableJournalEntry("Prologue_Marriage_DontLove");
EnableJournalEntry("Prologue_Marriage_VinaBirth");)*
- **Efekt (`userScript`):** `EnableJournalEntry("Prologue_Marriage_DontLove");
EnableJournalEntry("Prologue_Marriage_VinaBirth");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableJournalEntry("Prologue_MarriageIssue_NeglectedWork");)*
- **Efekt (`userScript`):** `EnableJournalEntry("Prologue_MarriageIssue_NeglectedWork");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableJournalEntry("Prologue_MarriageIssue_GoodFather");)*
- **Efekt (`userScript`):** `EnableJournalEntry("Prologue_MarriageIssue_GoodFather");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableJournalEntry("Prologue_Immigrants_Celebrate");)*
- **Efekt (`userScript`):** `EnableJournalEntry("Prologue_Immigrants_Celebrate");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableJournalEntry("Prologue_Immigrants_Suspicion");)*
- **Efekt (`userScript`):** `EnableJournalEntry("Prologue_Immigrants_Suspicion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableJournalEntry("Prologue_Immigrants_Welcomed");)*
- **Efekt (`userScript`):** `EnableJournalEntry("Prologue_Immigrants_Welcomed");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableJournalEntry("Prologue_SuOmina_Attended");)*
- **Efekt (`userScript`):** `EnableJournalEntry("Prologue_SuOmina_Attended");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableJournalEntry("Prologue_SuOmina_Refused");)*
- **Efekt (`userScript`):** `EnableJournalEntry("Prologue_SuOmina_Refused");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableJournalEntry("Prologue_BoatTrip_Worked");)*
- **Efekt (`userScript`):** `EnableJournalEntry("Prologue_BoatTrip_Worked");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableJournalEntry("Prologue_BoatTrip_Lover");)*
- **Efekt (`userScript`):** `EnableJournalEntry("Prologue_BoatTrip_Lover");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableJournalEntry("Prologue_AxelInvitation_Declined");)*
- **Efekt (`userScript`):** `EnableJournalEntry("Prologue_AxelInvitation_Declined");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableJournalEntry("Prologue_AxelVisit_Neutral");)*
- **Efekt (`userScript`):** `EnableJournalEntry("Prologue_AxelVisit_Neutral");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableJournalEntry("Prologue_AxelVisitReturn_Lied");)*
- **Efekt (`userScript`):** `EnableJournalEntry("Prologue_AxelVisitReturn_Lied");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableJournalEntry("Prologue_AxelVisitReturn_Truth");)*
- **Efekt (`userScript`):** `EnableJournalEntry("Prologue_AxelVisitReturn_Truth");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableJournalEntry("Prologue_AxelLetter_Lie");)*
- **Efekt (`userScript`):** `EnableJournalEntry("Prologue_AxelLetter_Lie");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_DadLetter = false;
EnableJournalEntry("Prologue_FatherDeath_Visit");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_DadLetter"] = false;
EnableJournalEntry("Prologue_FatherDeath_Visit");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableJournalEntry("Prologue_FatherLastWords_Hear");)*
- **Efekt (`userScript`):** `EnableJournalEntry("Prologue_FatherLastWords_Hear");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableJournalEntry("Prologue_End");)*
- **Efekt (`userScript`):** `EnableJournalEntry("Prologue_End");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableJournalEntry("Prologue_WehlenRescue");)*
- **Efekt (`userScript`):** `EnableJournalEntry("Prologue_WehlenRescue");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Visiting their common-born family", "Family Home", "Zille Province");)*
- **Efekt (`userScript`):** `SetRichPresence("Visiting their common-born family","Family Home","Zille Province");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Spending summers with Queen Lyza", "Royal residence", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Spending summers with Queen Lyza","Royal residence","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Hunting with Uncle Hugo", "forest", "Brenas Province");)*
- **Efekt (`userScript`):** `SetRichPresence("Hunting with Uncle Hugo","forest","Brenas Province");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Pushing the groundskeeper’s kid around", "Palace Rezna", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Pushing the groundskeeper’s kid around","Palace Rezna","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Making a lifelong friend in the palace gardens", "Palace Rezna", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Making a lifelong friend in the palace gardens","Palace Rezna","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Stepping into the Royal Council as the king's heir", "Council Chambers", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Stepping into the Royal Council as the king's heir","Council Chambers","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Being dragged away by masked men", "Palace Rezna", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Being dragged away by masked men","Palace Rezna","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Wedded to Princess Lena of the Kingdom of Rumburg", "Plavo Archsanctuary", "Plavo");)*
- **Efekt (`userScript`):** `SetRichPresence("Wedded to Princess Lena of the Kingdom of Rumburg","Plavo Archsanctuary","Plavo");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[366]`
Mówca: **Narrator**
> "You were cut off from the world beyond the palace walls, but it gave you more time for self-reflection.

During those formative years, you realized..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`
  - -> `[368]`
  - -> `[369]`

### Węzeł `[367]`
**[WYBÓR GRACZA: "…you desired an easy life, one where you seized every advantage you were entitled to. [Easier Resources]"]** — Mówca: **Player_Romus**
> "…you desired an easy life, one where you seized every advantage you were entitled to."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "…your royal privilege came with unbelievable pressure, and balancing the two would be your life's work."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[369]`
**[WYBÓR GRACZA: "…the years ahead would be full of challenges, but they would make your triumphs all the sweeter. [Harder Resources]"]** — Mówca: **Player_Romus**
> "…the years ahead would be full of challenges, but they would make your triumphs all the sweeter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_EasyLife = true; 
RiziaDLC.Authority_Modifier_BaseMonarchRomus += 4;
RiziaDLC.Energy_Modifier_BaseEnergy += 3;
RiziaDLC.Budget_Modifier_RizianGoldIndustry += 2;
RiziaDLC.Country_PublicOpinion += 5;
RiziaDLC.Resources_Energy += 3;
RiziaDLC.Resources_Budget += 4;
// House relations and Religious groups in cond.instr.)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_EasyLife"] = true;
Variable["RiziaDLC.Authority_Modifier_BaseMonarchRomus"] = Variable["RiziaDLC.Authority_Modifier_BaseMonarchRomus"] + 4;
Variable["RiziaDLC.Energy_Modifier_BaseEnergy"] = Variable["RiziaDLC.Energy_Modifier_BaseEnergy"] + 3;
Variable["RiziaDLC.Budget_Modifier_RizianGoldIndustry"] = Variable["RiziaDLC.Budget_Modifier_RizianGoldIndustry"] + 2;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] + 5;
Variable["RiziaDLC.Resources_Energy"] = Variable["RiziaDLC.Resources_Energy"] + 3;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] + 4;
-- House relations and Religious groups in cond.instr.;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_NormalLife = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_NormalLife"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HardLife = true; 
RiziaDLC.Authority_Modifier_BaseMonarchRomus -= 3;
RiziaDLC.Energy_Modifier_BaseEnergy -= 1;
RiziaDLC.Budget_Modifier_RizianGoldIndustry -= 1;
RiziaDLC.Country_PublicOpinion -= 3;
RiziaDLC.Resources_Energy -= 3;
RiziaDLC.Resources_Budget -= 2;
// House relations and Religious groups in cond.instr.)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Prologue_HardLife"] = true;
Variable["RiziaDLC.Authority_Modifier_BaseMonarchRomus"] = Variable["RiziaDLC.Authority_Modifier_BaseMonarchRomus"] - 3;
Variable["RiziaDLC.Energy_Modifier_BaseEnergy"] = Variable["RiziaDLC.Energy_Modifier_BaseEnergy"] - 1;
Variable["RiziaDLC.Budget_Modifier_RizianGoldIndustry"] = Variable["RiziaDLC.Budget_Modifier_RizianGoldIndustry"] - 1;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] - 3;
Variable["RiziaDLC.Resources_Energy"] = Variable["RiziaDLC.Resources_Energy"] - 3;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;
-- House relations and Religious groups in cond.instr.;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
