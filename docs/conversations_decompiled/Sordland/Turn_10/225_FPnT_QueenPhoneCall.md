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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 33

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.GovernmentBudget`
- `BaseGame.Relations_Iosef_Enemy`
- `BaseGame.Relations_Valken_Enemy`
- `BaseGame.Rumburg_War`
- `BaseGame.Situation_Diplomacy_Energy_ForeignInfluence`
- `BaseGame.Situation_Diplomacy_Energy_ForeignManipulation`
- `BaseGame.Situation_Diplomacy_Energy_Independence`
- `BaseGame.Situation_Diplomacy_Energy_PriceBalanced`
- `BaseGame.Situation_Diplomacy_Energy_PriceFluctuation`
- `BaseGame.Situation_Diplomacy_Energy_PriceSurge`
- `BaseGame.Situation_Military_War`
- `BaseGameSupport.News_Turn10_HP_RumburgInfluencesEnergy`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[68]` (Paskal Beniwoll): `Variable["BaseGame.Rumburg_PeaceSummit"] = true; Variable["BaseGame.Policy_Diplomacy_Rumburg_Trad...`
- Węzeł `[83]` (Paskal Beniwoll): `Variable["GameCondition.Turn10_FPnT_QueenPhoneCall"] = true;`
- Węzeł `[121]` (Paskal Beniwoll): `Variable["BaseGame.Rumburg_AttacksSordland"] = true;`
- Węzeł `[136]` (Paskal Beniwoll): `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] = true;`
- Węzeł `[153]` (Paskal Beniwoll): `Variable["BaseGame.Ending_Coup"] = true; Variable["BaseGame.Rumburg_War"] = false; Variable["Base...`
- Węzeł `[154]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn10_QueenCall_PeaceSummit"] = true;`
- Węzeł `[155]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn10_QueenCall_GivenEstordAndNarbel"] = true;`
- Węzeł `[156]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn10_QueenCall_RefusedSurrender"] = true;`
- *...oraz 25 innych węzłów ze skryptami.*

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
  - -> `[11]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The phone started ringing. I took a deep breath as I held it to my ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[4]`
Mówca: **Narrator**
> "She let out a laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[5]`
Mówca: **Beatrice Livingston**
> "“Mr. Rayne. How pleasing it is to finally get a chance to speak with you in person. ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Beatrice Livingston**
> "“Excellent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[7]`
Mówca: **Beatrice Livingston**
> "“I am Queen Beatrice Livingston. The Queen of the Four Corners of Merkopa, Defender of Castle Tzarsbourgh, Conqueror of the Tranquil Sea, Stout Protector of the Ancient Lands of Rum, Descendant of the Most Honorable King Edward the First and the Ruler of Rumburg. ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[8]`
  - -> `[15]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Aren't those titles a bit old-fashioned?”"]** — Mówca: **Player**
> "“Aren't those titles a bit old-fashioned?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "“It is very nice to finally talk to you as well.”"]** — Mówca: **Player**
> "“It is very nice to finally talk to you as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[10]`
Mówca: **Beatrice Livingston**
> "“I am afraid protocol must be observed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Narrator**
> "I was in my office, waiting for the call that could potentially change the future of Eastern Merkopa."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Am I supposed to be impressed?”"]** — Mówca: **Player**
> "“Am I supposed to be impressed?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Beatrice Livingston**
> "“Indeed. You should be.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[17]`
Mówca: **Beatrice Livingston**
> "“Now. I wanted to give you a call *personally* to thank you for your efforts in maintaining the peace in Eastern Merkopa.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Beatrice Livingston**
> "“The reparations Sordland paid were very well received by my people and we are forever thankful. Instead of burying the dark past, you are trying to heal the wounds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[19]`
Mówca: **Beatrice Livingston**
> "“Why now?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`
  - -> `[22]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“My aim is to have peace in Merkopa. Nothing more.”"]** — Mówca: **Player**
> "“My aim is to have peace in Merkopa. Nothing more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "“I decided that Sordland would benefit from better relationships with its neighbors.”"]** — Mówca: **Player**
> "“I decided that Sordland would benefit from better relationships with its neighbors.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“It was time to mend old wounds and rightfully pay for what we had done.”"]** — Mówca: **Player**
> "“It was time to mend old wounds and rightfully pay for what we had done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Beatrice Livingston**
> "“You are quite an unusual president for Sordland, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Beatrice Livingston**
> "“I applaud and thank you from the bottom of my heart.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`
  - -> `[27]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "“I am hoping this will mark an end to the aggressions between our countries.”"]** — Mówca: **Player**
> "“I am hoping this will mark an end to the aggressions between our countries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "“This is only the beginning. We have the potential to do so much more. Don't you think so?”"]** — Mówca: **Player**
> "“This is only the beginning. We have the potential to do so much more. Don't you think so?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[28]`
Mówca: **Beatrice Livingston**
> "“Of course. This is the beginning of a new era after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
Mówca: **Beatrice Livingston**
> "“You read my mind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Beatrice Livingston**
> "“You are very welcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Beatrice Livingston**
> "“I have an offer for you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Beatrice Livingston**
> "“An offer that has the potential to improve the relationship between our countries once and for all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`
  - -> `[36]`

### Węzeł `[33]`
Mówca: **Beatrice Livingston**
> "“Don't be alarmed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“I don't like the sound of this.”"]** — Mówca: **Player**
> "“I don't like the sound of this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Go on.”"]** — Mówca: **Player**
> "“Go on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“What kind of an offer?”"]** — Mówca: **Player**
> "“What kind of an offer?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Beatrice Livingston**
> "“Peace is very fragile and costly, but I think we are off to a good start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Beatrice Livingston**
> "“I would like to hold a peace summit between Sordland and Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“There is always a but, isn't there?”"]** — Mówca: **Player**
> "“There is always a but, isn't there?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "“What do you want?”"]** — Mówca: **Player**
> "“What do you want?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
**[WYBÓR GRACZA: "Let her continue."]** — Mówca: **Player_Italic**
> "I let her continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Beatrice Livingston**
> "“I can't let my people suffer in the name of peace with Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Beatrice Livingston**
> "“I must admit your country has a resource that Rumburg has long yearned for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Beatrice Livingston**
> "“But I do have a condition.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`
  - -> `[41]`

### Węzeł `[45]`
Mówca: **Beatrice Livingston**
> "“Natural gas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Beatrice Livingston**
> "“I want you to expand the Sordish natural gas pipeline to Rumburg, and I want it 30% cheaper than your other neighbors.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Beatrice Livingston**
> "“If you accept, we will give Sordland licenses to make your own version of the KA-74. It should certainly be profitable in the long term, not to mention the aid it will give to your national defense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Beatrice Livingston**
> "“And then we will have our peace summit -- and perhaps start talking about even more lucrative deals.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "“If you want your peace, you'll need to come up with a better deal than that.”"]** — Mówca: **Player**
> "“If you want your peace, you'll need to come up with a better deal than that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "“I'm afraid Sordland is not in a position to accept this deal. I must refuse.”"]** — Mówca: **Player**
> "“I'm afraid Sordland is not in a position to accept this deal. I must refuse.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Anything in the name of peace in East Merkopa. I accept.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Anything in the name of peace in East Merkopa. I accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[52]`
Mówca: **Beatrice Livingston**
> "“What do you think?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[49]`
  - -> `[50]`

### Węzeł `[53]`
Mówca: **Beatrice Livingston**
> "“A pity. Really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Beatrice Livingston**
> "“I thought you were different.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[55]`
Mówca: **Beatrice Livingston**
> "“Most exquisite.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[56]`
Mówca: **Beatrice Livingston**
> "“Mr. Rayne, you have proven yourself to be a better leader than I thought.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Beatrice Livingston**
> "“We have just written history on this short call.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Beatrice Livingston**
> "“My people will talk to your people, and we will make the deal official.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[59]`
Mówca: **Beatrice Livingston**
> "“A pity. Really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Beatrice Livingston**
> "“I thought you were different.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Beatrice Livingston**
> "“I'm afraid we are at the end of the reserved time for our call.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Beatrice Livingston**
> "“If that is all, I wish you a good afternoon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "“Have a good afternoon, Ms. Livingston.”"]** — Mówca: **Player**
> "“Have a good afternoon, Ms. Livingston.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "Hang up."]** — Mówca: **Player_Italic**
> "I hung up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[65]`
Mówca: **Beatrice Livingston**
> "“I'm afraid we are at the end of the reserved time for our call.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Beatrice Livingston**
> "“I wish you a good afternoon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_PeaceSummit = true;
BaseGame.Policy_Diplomacy_Rumburg_Trade = true;
BaseGame.Situation_Diplomacy_Rumburg_GasPipeline = true;
BaseGame.Situation_Diplomacy_Rumburg_KA74 = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Rumburg_PeaceSummit"] = true;
Variable["BaseGame.Policy_Diplomacy_Rumburg_Trade"] = true;
Variable["BaseGame.Situation_Diplomacy_Rumburg_GasPipeline"] = true;
Variable["BaseGame.Situation_Diplomacy_Rumburg_KA74"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[69]`
Mówca: **Beatrice Livingston**
> "“I am certain that this will be the start of a lasting friendship.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`
  - -> `[72]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "“As long as Rumburg respects its boundaries.”"]** — Mówca: **Player**
> "“As long as Rumburg respects its boundaries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "“We have achieved so much in such a short span. It's been a pleasure.”"]** — Mówca: **Player**
> "“We have achieved so much in such a short span. It's been a pleasure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "“I sure hope so.”"]** — Mówca: **Player**
> "“I sure hope so.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[73]`
Mówca: **Beatrice Livingston**
> "“And as long as Sordland respects its own.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[74]`
Mówca: **Beatrice Livingston**
> "“Likewise, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Beatrice Livingston**
> "“Me too, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Beatrice Livingston**
> "“I can't wait to meet with you in person at the peace summit. We have so much to talk about.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Beatrice Livingston**
> "“But for now, I'm afraid we are at the end of the reserved time for our call.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Beatrice Livingston**
> "“I wish you a wonderful afternoon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[79]`
Mówca: **Narrator**
> "Was this the start of a new era?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[80]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Narrator**
> "Just like that, I had thrown away any chance of a peace summit between Rumburg and Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Narrator**
> "Would our countries ever be able to reconcile?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn10_FPnT_QueenPhoneCall = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn10_FPnT_QueenPhoneCall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[84]`
Mówca: **Beatrice Livingston**
> "“Forgive me for being so straightforward, but I have to ask.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[85]`
Mówca: **Beatrice Livingston**
> "“Now. Given the circumstances, I never thought I would be giving you a personal phone call. Yet here we are.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Beatrice Livingston**
> "“Even after what Sordland has done, I am showing you my willingness to talk instead of cutting off communication.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[88]`
  - -> `[87]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "“Why did you call?”"]** — Mówca: **Player**
> "“Why did you call?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "“I did not hang up yet. That should show you *my* willingness to listen to your whining.”"]** — Mówca: **Player**
> "“I did not hang up yet. That should show you *my* willingness to listen to your whining.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "“You are so kind and generous.”"]** — Mówca: **Player**
> "“You are so kind and generous.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Beatrice Livingston**
> "“I assure you, there is no need for sarcasm, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[91]`
Mówca: **Beatrice Livingston**
> "“Such vulgarity... as expected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[92]`
Mówca: **Beatrice Livingston**
> "“My demands are simple. You will give us control of our stolen ancestral homelands, Estord and Narbel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Beatrice Livingston**
> "“Those cities are surely of lesser importance to you judging by the way your country has treated them. That's all I ask.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_RumburgKnows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_RumburgKnows == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_RumburgKnows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_RumburgKnows == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_RumburgKnows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[97]`
Mówca: **Beatrice Livingston**
> "“I know it all, Mr. Rayne. I know all about your plans. I can read your every move.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Beatrice Livingston**
> "“I know that your military is weak and crumbling.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Military == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Security_Unrest_Military == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Security_Unrest_Military == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Beatrice Livingston**
> "“I know that Sordland is on the verge of being completely under the control of your general staff.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Beatrice Livingston**
> "“I am offering you a peaceful way out of your dire situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[107]`
Mówca: **Beatrice Livingston**
> "“One does not have to look far to see the situation your military is in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_Military_WeakAgainstRumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_Military_WeakAgainstRumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[111]`
Mówca: **Beatrice Livingston**
> "“So, please. I beg you to have reason. Think of your citizens. Think of your people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[112]`
Mówca: **Beatrice Livingston**
> "“If you fail to comply, to put it simply, we will take them by force.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Beatrice Livingston**
> "“A war, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[114]`
Mówca: **Beatrice Livingston**
> "“Do not enter a war that you have no chance of winning.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[118]`
  - -> `[119]`
  - -> `[117]`

### Węzeł `[115]`
Mówca: **Beatrice Livingston**
> "“Please listen to me carefully. This is your last chance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "“You must be out of your mind if you thought I would give in to your threats.”"]** — Mówca: **Player**
> "“You must be out of your mind if you thought I would give in to your threats.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[117]`
**[WYBÓR GRACZA: "“Only Estord and Narbel? Nothing else?”"]** — Mówca: **Player**
> "“Only Estord and Narbel? Nothing else?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[118]`
**[WYBÓR GRACZA: "“You dare insult me? Your time is over, Your Highness. Along with your country. I will see you on the battlefield.”"]** — Mówca: **Player**
> "“You dare insult me? Your time is over, Your Highness. Along with your country. I will see you on the battlefield.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[119]`
**[WYBÓR GRACZA: "“I will not lead my country to a war. Peace must be maintained by any means necessary.”"]** — Mówca: **Player**
> "“I will not lead my country to a war. Peace must be maintained by any means necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[120]`
Mówca: **Beatrice Livingston**
> "“A pity. Really.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_AttacksSordland = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Rumburg_AttacksSordland"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[122]`
Mówca: **Beatrice Livingston**
> "“At least my conscience is clear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Beatrice Livingston**
> "“I have given you a chance and you refused. You have failed your people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Beatrice Livingston**
> "“War it is then, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Beatrice Livingston**
> "“You will regret your decision until your last breath.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Narrator**
> "And just like that, the Rumburg War had begun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[128]`
Mówca: **Beatrice Livingston**
> "“That's all. Your two least important cities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Beatrice Livingston**
> "“I am glad that you see it our way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Beatrice Livingston**
> "“Do you comply with my demands?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
**[WYBÓR GRACZA: "“You must be joking. I have a duty to protect this nation. I will not sell pieces of it.”"]** — Mówca: **Player**
> "“You must be joking. I have a duty to protect this nation. I will not sell pieces of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[132]`
**[WYBÓR GRACZA: "“What are two backwater cities in the name of peace? I accept.”"]** — Mówca: **Player**
> "“What are two backwater cities in the name of peace? I accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Beatrice Livingston**
> "“Most exquisite.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[134]`
Mówca: **Beatrice Livingston**
> "“Mr. Rayne, you have proven yourself to be a better leader than I thought.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Beatrice Livingston**
> "“You have protected your citizens and fulfilled your duty. For that, I applaud you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[141]`
  - -> `[146]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_GivenEstordAndNarbel = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Rumburg_GivenEstordAndNarbel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[137]`
Mówca: **Beatrice Livingston**
> "“My people will talk to your people and we will make the deal official.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Beatrice Livingston**
> "“For now, I'm afraid we are at the end of the reserved time for our call.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Beatrice Livingston**
> "“I wish you a wonderful afternoon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[140]`
Mówca: **Narrator**
> "And just like that, part of my country was now Rumburg territory."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[141]`
**[WYBÓR GRACZA: "“Screw you.”"]** — Mówca: **Player**
> "“Screw you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Beatrice Livingston**
> "“I understand your frustration, but you have made the better choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[143]`
**[WYBÓR GRACZA: "“You will pay for this one day.”"]** — Mówca: **Player**
> "“You will pay for this one day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Beatrice Livingston**
> "“No need for additional adversity at this point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[145]`
Mówca: **Beatrice Livingston**
> "“Goodbye, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[146]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[147]`
Mówca: **Narrator**
> "I heard the voice of the Queen of Rumburg from the other side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[148]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[149]`
Mówca: **Narrator**
> "Just like that, I had thrown away any chance of a peace summit between Rumburg and Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[150]`
Mówca: **Narrator**
> "Just like that, there was about to be peace between Rumburg and Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[151]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[152]`
Mówca: **Narrator**
> "The decision wouldn't make me popular. But it was better than the alternative."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup = true;
BaseGame.Rumburg_War = false;
BaseGame.Situation_Military_War = false;
BaseGame.Relations_Iosef_Enemy = true; BaseGame.Relations_Valken_Enemy = true; BaseGame.Situation_Military_UnrulyGeneral = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Ending_Coup"] = true;
Variable["BaseGame.Rumburg_War"] = false;
Variable["BaseGame.Situation_Military_War"] = false;
Variable["BaseGame.Relations_Iosef_Enemy"] = true;
Variable["BaseGame.Relations_Valken_Enemy"] = true;
Variable["BaseGame.Situation_Military_UnrulyGeneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_QueenCall_PeaceSummit = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_QueenCall_PeaceSummit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_QueenCall_GivenEstordAndNarbel = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_QueenCall_GivenEstordAndNarbel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn10_QueenCall_RefusedSurrender = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn10_QueenCall_RefusedSurrender"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_RumburgAggression = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_RumburgAggression"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.CountryReport_Turn10_Rumburg_RejectedSurrender = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn10_Rumburg_RejectedSurrender"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn10_Narbel_Surrendered = true; BaseGameSupport.Report_Turn10_Estord_Surrendered = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn10_Narbel_Surrendered"] = true;
Variable["BaseGameSupport.Report_Turn10_Estord_Surrendered"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableNews("G_Rumburg_TradeDeal");)*
- **Efekt (`userScript`):** `EnableNews("G_Rumburg_TradeDeal");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_R_Rumburg_GivenEstordAndNarbel = true; BaseGameSupport.News_Turn10_HP_Rumburg_GivenEstordAndNarbel = true; BaseGameSupport.News_Turn10_LT_Rumburg_GivenEstordAndNarbel = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_R_Rumburg_GivenEstordAndNarbel"] = true;
Variable["BaseGameSupport.News_Turn10_HP_Rumburg_GivenEstordAndNarbel"] = true;
Variable["BaseGameSupport.News_Turn10_LT_Rumburg_GivenEstordAndNarbel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Enable_Congress == false && BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Enable_Congress == false && BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Enable_Congress"] == false  and  Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Enable_Congress == false && BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Enable_Congress"] == false  and  Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_HP_CongressCancelled = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_HP_CongressCancelled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaCensored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaCensored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaCensored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaCensored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaCensored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_R_CongressCancelled = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_R_CongressCancelled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateCountryRelationship("Sordland_Country_Rumburg", "Friendly");)*
- **Efekt (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Rumburg","Friendly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("PhoneRingPickUp");)*
- **Efekt (`userScript`):** `PlaySoundEffect("PhoneRingPickUp");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayCustomMapMusic("Map_Music_Tense");

// Plays a custom map music after conversation is done. This works only once for one conversation)*
- **Efekt (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");
-- Plays a custom map music after conversation is done. This works only once for one conversation;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceSurge == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Diplomacy_Energy_PriceSurge == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceBalanced = false; 
BaseGame.Situation_Diplomacy_Energy_PriceSurge = false;
BaseGame.Situation_Diplomacy_Energy_PriceFluctuation = true;
BaseGameSupport.News_Turn10_HP_RumburgInfluencesEnergy = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] = true;
Variable["BaseGameSupport.News_Turn10_HP_RumburgInfluencesEnergy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_ForeignInfluence = true; BaseGame.Situation_Diplomacy_Energy_ForeignManipulation = false; 
BaseGame.Situation_Diplomacy_Energy_Independence = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Energy_ForeignInfluence"] = true;
Variable["BaseGame.Situation_Diplomacy_Energy_ForeignManipulation"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_Independence"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_ForeignManipulation = true; 
BaseGame.Situation_Diplomacy_Energy_ForeignInfluence = false;
BaseGame.Situation_Diplomacy_Energy_Independence = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Energy_ForeignManipulation"] = true;
Variable["BaseGame.Situation_Diplomacy_Energy_ForeignInfluence"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_Independence"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Gasom_Ownership_ForeignOwned == true && BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Gasom_Ownership_ForeignOwned == true && BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Gasom_Ownership_ForeignOwned"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Gasom_Ownership_ForeignOwned == true && BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Gasom_Ownership_ForeignOwned"] == true  and  Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 3;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 8;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 8;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[198]`
**[WYBÓR GRACZA: "“Anything in the name of peace in East Merkopa. I accept.” [-2 Government Budget]"]** — Mówca: **Player**
> "“Anything in the name of peace in East Merkopa. I accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[199]`
**[WYBÓR GRACZA: "“Anything in the name of peace in East Merkopa. I accept.” [-3 Government Budget]"]** — Mówca: **Player**
> "“Anything in the name of peace in East Merkopa. I accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 3;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 6;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 6;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateCountryRelationship("Sordland_Country_Rizia", "Friendly");)*
- **Efekt (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Rizia","Friendly");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[213]`
**[WYBÓR GRACZA: "“Wait. Not so fast. I will accept your deal.” [-1 Government Budget]"]** — Mówca: **Player**
> "“Wait. Not so fast. I will accept your deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[214]`
**[WYBÓR GRACZA: "“Wait. Not so fast. I will accept your deal.” [-2 Government Budget]"]** — Mówca: **Player**
> "“Wait. Not so fast. I will accept your deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[215]`
**[WYBÓR GRACZA: "“Wait. Not so fast. I will accept your deal.” [-3 Government Budget]"]** — Mówca: **Player**
> "“Wait. Not so fast. I will accept your deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 3;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableNews("G_Rumburg_GivenEstordAndNarbel");)*
- **Efekt (`userScript`):** `EnableNews("G_Rumburg_GivenEstordAndNarbel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
