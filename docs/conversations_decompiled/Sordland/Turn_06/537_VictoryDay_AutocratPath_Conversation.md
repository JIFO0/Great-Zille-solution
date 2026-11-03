# Sordland/Turn06/VictoryDay_AutocratPath/VictoryDay_AutocratPath Conversation

- **ID konwersacji:** `537`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Sordland/Turn_06/537_VictoryDay_AutocratPath_Conversation.md`
- **Liczba węzłów dialogowych:** 610
- **Liczba wyborów gracza:** 119

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[50]** Kesaro Kibener
- **[60]** Remus Holstron

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana`
- `BaseGame.GovernmentBudget`
- `BaseGame.Policy_Diplomacy_TightenedImmigration`
- `BaseGame.Policy_Economy_EnergyProtectionAct_Removed`
- `BaseGame.Policy_Military_IncreasedFunding`
- `BaseGame.Policy_Order_DecreasedInteriorFunding`
- `BaseGame.Policy_Order_IncreasedInteriorFunding`
- `BaseGame.Policy_Order_SecretStatePolice`
- `BaseGame.Prologue_University_Political_Nationalist`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Situation_Economy_FinancialInvestment_UC`
- `BaseGame.Turn03_EnT_Military_Budget_Increase`
- `BaseGame.Turn04_PSnW_Education_Progressive`
- `BaseGame.Turn04_SnO_LE_Interior_Increased`
- `BaseGame.Turn05_SnO_Investigate_Opposition`
- `BaseGame.Wehlen_DefendBorder`
- `BaseGame.Wehlen_JointOperation`
- `BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands`
- `BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer`
- `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1`
- `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2`
- `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3`
- `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4`
- `BaseGameIsolated.VictoryDay_YoungSords_Willing`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Autocrat_YoungSords_NFP_Deal`
- `BaseGame.EconomyDirection_Scale`
- `BaseGame.Gasom_Bankrupt`
- `BaseGame.Gasom_Booming`
- `BaseGame.Gasom_Default`
- `BaseGame.Gasom_Downsized`
- `BaseGame.Gasom_Ownership_ForeignOwned`
- `BaseGame.Gasom_Ownership_PrivatelyOwned`
- `BaseGame.Gasom_Ownership_StatePrivateCooperation`
- `BaseGame.GovernmentBudget`
- `BaseGame.Policy_Diplomacy_TightenedImmigration`
- `BaseGame.Policy_Economy_EnergyProtectionAct_10Percent`
- `BaseGame.Policy_Economy_EnergyProtectionAct_49Percent`
- `BaseGame.Policy_Economy_EnergyProtectionAct_Default`
- `BaseGame.Policy_Economy_EnergyProtectionAct_Removed`
- `BaseGame.Policy_Law_Ban_YoungSords`
- `BaseGame.Policy_Military_IncreasedFunding`
- `BaseGame.Policy_Order_IncreasedInteriorFunding`
- `BaseGame.Policy_Welfare_EducationReform`
- `BaseGame.Policy_Welfare_TraditionalEducation`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Relations_Ewald_Discontent`
- `BaseGame.Relations_Ewald_Friendly`
- `BaseGame.Relations_Ewald_Neutral`
- `BaseGame.Relations_NFP_Promised_LanguageBill`
- `BaseGame.Stopped_Investigations_NFP`
- `BaseGame.Turn03_EnT_Military_Budget_Increase`
- `BaseGame.Turn04_PSnW_Education_Progressive`
- `BaseGame.Turn04_SnO_LE_Interior_Increased`
- `BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands`
- `BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer`
- `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1`
- `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2`
- `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3`
- `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4`
- `BaseGameIsolated.VictoryDay_YoungSords_Willing`
- `BaseGameSupport.Journal_Turn06_VictoryDay_MadeDealWithYS`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[90] Sordland/Turn06/A_VictoryDayBludishMeeting** (../Turn_06/090_A_VictoryDayBludishMeeting.md), Węzeł `[60]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 12
- **Węzły modyfikujące stan gry:** 20

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.EconomyDirection_Scale`
- `BaseGame.GovernmentBudget`
- `BaseGame.Policy_Economy_EnergyProtectionAct_10Percent`
- `BaseGame.Policy_Economy_EnergyProtectionAct_49Percent`
- `BaseGame.Policy_Economy_EnergyProtectionAct_Default`
- `BaseGame.Policy_Economy_EnergyProtectionAct_Removed`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Relations_Ewald_Discontent`
- `BaseGame.Relations_Ewald_Friendly`
- `BaseGame.Relations_Ewald_Neutral`
- `BaseGame.Relations_NFP_Promised_LanguageBill`
- `BaseGame.Turn03_EnT_Military_Budget_Increase`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[360]` (Paskal Beniwoll): `Variable["BaseGameIsolated.VictoryDay_YoungSords_Willing"] = true;`
- Węzeł `[498]` (Paskal Beniwoll): `EnableCollectionItem("CollectionItem_KesaroLighter");`
- Węzeł `[500]` (Paskal Beniwoll): `Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer"] = true;`
- Węzeł `[501]` (Paskal Beniwoll): `Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands"] = true;`
- Węzeł `[553]` (Paskal Beniwoll): `Variable["BaseGame.Stopped_Investigations_NFP"] = true;`
- Węzeł `[554]` (Paskal Beniwoll): `Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] = true;`
- Węzeł `[555]` (Paskal Beniwoll): `Variable["BaseGame.Policy_Welfare_EducationReform"] = false; Variable["BaseGame.Policy_Welfare_Tr...`
- Węzeł `[556]` (Paskal Beniwoll): `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] = false; Variable["BaseGame.Policy_Law_Ban_...`
- *...oraz 12 innych węzłów ze skryptami.*

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
  - -> `[7]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `90` (*Sordland/Turn06/A_VictoryDayBludishMeeting*), Węzeł `[60]`

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[6]`
Mówca: **Kesaro Kibener**
> ""Thank you for being here so early on this glorious day in spite of the emergency, Mr. President and Mr. Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[10]`
Mówca: **Narrator**
> "We got out of the car and walked towards the entrance of the building, escorted by our guards. Besides our own security forces, I noticed a heavy police presence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Narrator**
> "The buildings around the plaza were decorated with a comically large amount of Sordish flags. Everywhere I looked, I saw a sea of maroon, white and gold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Narrator**
> "At the entrance, Kesaro Kibener, the head of the National Front Party, was waiting for us in his iconic brown suit, together with a group of local policemen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Petr Vectern**
> ""Huh. I thought we arrived way too early. Looks like our host -- the devil himself -- is already expecting us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Narrator**
> "We got out of the car and walked towards the entrance of the building, escorted by our guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[15]`
Mówca: **Petr Vectern**
> ""Why is he even in the spotlight? He's acting like he still governs the city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[16]`
  - -> `[18]`
  - -> `[19]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, I'm already regretting my decision to come here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""To be fair, his party still does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He's a dangerously competent man, Petr. We should be cautious with him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He can act however he wants, Petr. He is not a threat to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[20]`
Mówca: **Petr Vectern**
> ""Well, it was Lucian's idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[21]`
Mówca: **Petr Vectern**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[22]`
Mówca: **Petr Vectern**
> ""I hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[23]`
Mówca: **Petr Vectern**
> ""Yeah, that's true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[24]`
Mówca: **Kesaro Kibener**
> ""Thank you for being here so early on this glorious day, Mr. President and Mr. Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Kesaro Kibener**
> ""As the former mayor of Jen, it is an honor to welcome you to our fine city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`
  - -> `[26]`
  - -> `[32]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It is good to be here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Mr. Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It looks like you did a good job. Maybe you should think about running for local office again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Kesaro Kibener**
> ""Thanks for the kind words, but I'll do an even better job as president. Besides, as you can see, our current mayor doesn't need my help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[31]`
Mówca: **Petr Vectern**
> ""Thank you for organizing this, Mr. Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "Shake his hand in silence."]** — Mówca: **Player_Italic**
> "I did not reply and simply shook his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[33]`
Mówca: **Narrator**
> "Seeing us arrive, Kesaro approached us with a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Kesaro pointed at the center of the plaza where a stage had been erected. He gestured at the blazing sun above us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Kesaro Kibener**
> ""It'll still be a while before the stage is ready. Why don't we find somewhere away from the sun?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[36]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Kesaro Kibener**
> ""Let's brighten up a little. It's Victory Day today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[38]`
Mówca: **Kesaro Kibener**
> ""Mr. Vice President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Petr Vectern**
> ""Sure. I'll take one too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Narrator**
> "After passing one more cigarette to Petr, he lit them up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[41]`
Mówca: **Kesaro Kibener**
> ""I just wanted to use this opportunity to make some comments on the administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Kesaro Kibener**
> ""It isn't everyday that one sees the president and the vice president together, let alone have a conversation with them. Surely you'd understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`
  - -> `[45]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Of course, Mr. Kibener. I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well, there's nothing better to do right now. Go ahead and make your comments if you have to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll be very honest. I don't want to hear your comments. Please keep them to yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Mr. Kibener. I appreciate your supportive words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm glad you approve. And frankly, I don't think you and I are so different from each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Mr. Kibener, but I don't need either your sympathy or your support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you serious? *Not enough*? It's an emergency, Mr. Kibener. What more can I do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[50]`
Mówca: **Kesaro Kibener**
> ""I meant no offense, Mr. President. You've done wonders to neutralize the Red Youth. But the Bludish separatists are just as dangerous as the commies, if not more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Kesaro Kibener**
> ""I meant no offense, Mr. President. You've done wonders to neutralize the separatists. But the Red Youth is as equally dangerous as the Bluds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Kesaro Kibener**
> ""If only something could be done against them as well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[56]`
Mówca: **Kesaro Kibener**
> ""I wouldn't dare to disagree with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[57]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Kesaro Kibener**
> ""Let's brighten up a little. It's Victory Day today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[59]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
Mówca: **Kesaro Kibener**
> ""Why so grouchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[61]`
Mówca: **Kesaro Kibener**
> ""Oh, come on, Mr. Rayne!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[62]`
Mówca: **Kesaro Kibener**
> ""Let's brighten up a little. It's Victory Day today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[63]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You'll be making a grave mistake if you keep supporting terrorists like the Young Sords, Mr. Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Kesaro Kibener**
> ""Just because you label them a terrorist organization doesn't make them one, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[66]`
Mówca: **Kesaro Kibener**
> ""That's for you to decide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It was a necessary decision. That's all I can say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mistakes were made, but the past is in the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Am I supposed to be impressed with these theatrics?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[70]`
Mówca: **Kesaro Kibener**
> ""It was hardly a *necessary* decision, Mr. President. You know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Kesaro Kibener**
> ""I'm glad you agree. But the wrongs of the past can still be undone by others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Narrator**
> "He sighed and looked at me with narrowed eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[73]`
Mówca: **Kesaro Kibener**
> ""I want to ask you to reconsider the targets of the emergency. It is still not too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Kesaro Kibener**
> ""I'll be clear. You can still make it up to us. And I think you should take that opportunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[75]`
  - -> `[76]`
  - -> `[78]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And what if I don't?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The Young Sords orchestrated an attack at the Maroon Palace and murdered a member of the Assembly in cold blood. There is nothing to reconsider here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't act like you have the upper hand, Mr. Kibener. You are the one who should make it up to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm listening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[79]`
Mówca: **Kesaro Kibener**
> ""No need for premature assumptions, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[80]`
Mówca: **Kesaro Kibener**
> ""Let's not imagine that scenario, Mr. President. Let me explain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[81]`
Mówca: **Kesaro Kibener**
> ""Yes, yes. A justified purge. A classic campaign of anti-Sordist propaganda from the establishment. I get it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Kesaro Kibener**
> ""We know how it goes. Hire a mentally damaged individual to wreak societal havoc and blame a whole group of individuals for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`
  - -> `[85]`
  - -> `[132]`
  - -> `[78]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Isn't it ironic that you're the one who's saying this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're the one putting undue blame on minorities. Particularly the Bludish community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sorry but I don't agree with that. The establishment is more aligned with your ideology than anything else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Kesaro Kibener**
> ""Are you saying I'm a hypocrite? Perhaps I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Kesaro Kibener**
> ""Maybe it does seem that way from your perspective. Doesn't mean it's the truth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Kesaro Kibener**
> ""Nonetheless, none of that matters if you cannot hold onto your newly attained powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Kesaro Kibener**
> ""Your emergency act may have you feeling invincible, but there are forces grander than you that are set on your destruction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Kesaro Kibener**
> ""I'll be straight with you. Your politics or intentions don't matter if you cannot hold onto your newly attained powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[91]`
Mówca: **Petr Vectern**
> ""You cannot speak that way to the president, Mr. Kibener. I hope -- for your sake -- that wasn't a threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[93]`
  - -> `[95]`
  - -> `[144]`

### Węzeł `[92]`
Mówca: **Kesaro Kibener**
> ""I'll be straight with you. Your politics or intentions don't matter if you cannot hold onto your newly attained powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Vice President is right. Be careful with your choice of words, Mr. Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's okay, Petr. I want to know where he'll go with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[95]`
**[WYBÓR GRACZA: "(Point at your armed security.) "I think you're forgetting that we're in an emergency. I advise you not to bite off any more than you can chew.""]** — Mówca: **Player**
> ""I think you're forgetting that we're in an emergency. I advise you not to bite off any more than you can chew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Narrator**
> "I pointed at the heavily armed security forces that followed us from a distance. Kesaro took a long look at them and turned to us, smiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Kesaro Kibener**
> ""Now, that was an actual threat. Wouldn't you agree, Mr. Vectern?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[98]`
Mówca: **Narrator**
> "Petr nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[99]`
Mówca: **Kesaro Kibener**
> ""I actually wanted you to meet someone. We both have much to discuss with you. He'll be here any second now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[100]`
Mówca: **Kesaro Kibener**
> ""What would be a more fitting act on such a day of unity than the establishment of mutual respect and cooperation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[101]`
Mówca: **Kesaro Kibener**
> ""I wish people would focus more on actions than words. But I will do my best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[102]`
Mówca: **Petr Vectern**
> ""Well... Feel free to file a lawsuit, Mr. Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Narrator**
> "Kesaro laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Kesaro Kibener**
> ""As I said... The president is far from safe during this emergency. I am aware of the fissures forming between the administration and the Supreme Court. The Old Guard have you at their whim.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Kesaro Kibener**
> ""I just wanted to confirm whether you are insistent on committing your own political suicide or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[107]`
  - -> `[106]`
  - -> `[108]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not going to entertain you by taking part in your word games, Mr. Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You've heard wrong. There are no cracks between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why would you care if it is a political suicide for me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The answer is: I am not. I am aware of the threat the Court poses but I won't be intimidated by it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[110]`
Mówca: **Kesaro Kibener**
> ""I'm an honest man, so don't get me wrong. If it was only about you or the USP, I wouldn't care at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Kesaro Kibener**
> ""But if the nationalist movement is getting the short end of the stick in this process, then we have a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[112]`
Mówca: **Kesaro Kibener**
> ""Suit yourself, Mr. Rayne. But hear me out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[113]`
Mówca: **Kesaro Kibener**
> ""Yes... I'm sure there aren't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[114]`
Mówca: **Kesaro Kibener**
> ""Is that supposed to be noble?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Kesaro Kibener**
> ""Look. I never questioned your courage. Your logic, on the other hand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[116]`
Mówca: **Kesaro Kibener**
> ""Our suggestion is to finally enforce the official language of our country as stated in the constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Kesaro Kibener**
> ""We are working on the Unified Language Act. It is directly aimed at the breeding grounds of the Bludish Freedom Front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[118]`
Mówca: **Kesaro Kibener**
> ""The bill will give the state a way to control the radicalization in these schools that teach Bludish nationalist propaganda. Without taking any rights away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[119]`
Mówca: **Kesaro Kibener**
> ""I believe we already have the support of all the patriots within the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You seem very confident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[121]`
Mówca: **Kesaro Kibener**
> ""The police have infiltrated 32 BFF training grounds in remote towns around Bergia that posed as middle schools. Despite all the evidence, similar schools keep popping up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Kesaro Kibener**
> ""And so-called activists are constantly blocking Governor Bron's attempts to stop these schools, claiming he is attacking their *right to language*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Even if the Assembly supports it, I will surely be using my veto on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll sign the bill if it reaches me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll have to read it in detail to decide if I can support it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Narrator**
> "Suddenly, a man with a large build in a brown suit approached us. When we turned to greet him, I realized he was Remus Holstron. The Deputy of the National Front Party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[127]`
Mówca: **Kesaro Kibener**
> ""That shouldn't come as a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[128]`
Mówca: **Kesaro Kibener**
> ""If I were you, I wouldn't stand in the way of the majority, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[129]`
Mówca: **Petr Vectern**
> ""So you want the support of the USP?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[130]`
Mówca: **Kesaro Kibener**
> ""Your emergency is directly aimed at the proud nationalists of this country, Mr. Rayne. People are finally waking up to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Kesaro Kibener**
> ""You had your own justification, of course. A classic campaign of anti-Sordist propaganda from the establishment. I get it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Really, Mr. Kibener? When it's a Bludish person, it's Bludish terror, but when it's Sordish nationalists, it's a few mentally handicapped individuals?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[133]`
Mówca: **Kesaro Kibener**
> ""You made an enemy out of Sordish nationalists -- people who have the deepest love for this nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && BaseGame.Reform_EmergencyDecree_Banned_RY == false && BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && BaseGame.Reform_EmergencyDecree_Banned_RY == false && BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == false  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && BaseGame.Reform_EmergencyDecree_Banned_RY == false && BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == false  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[137]`
Mówca: **Kesaro Kibener**
> ""Don't put words in my mouth, President Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[138]`
Mówca: **Kesaro Kibener**
> ""You cannot win a fight against the core values of Sords and Sordland. I hope you are aware of that mistake now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[139]`
Mówca: **Kesaro Kibener**
> ""The Young Sords aren't some kind of a 'fringe group of militants' as your administration claims. You know whom they represent and how many stand behind them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""An ally? Tell me more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[141]`
Mówca: **Kesaro Kibener**
> ""What, are you bored already, Mr. Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[143]`
Mówca: **Kesaro Kibener**
> ""You are making an enemy out of Sordish nationalists -- people who have the deepest love for this nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No. Please tell me about these *grander* forces. I want to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[145]`
Mówca: **Petr Vectern**
> ""And who might that be, Mr. Kibener?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Kesaro Kibener**
> ""My deputy, Remus Holstron. He wanted to personally congratulate you for your emergency policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Petr Vectern**
> ""Oh. The Iron Wall himself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[174]`
  - -> `[164]`
  - -> `[161]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Who?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[152]`
Mówca: **Kesaro Kibener**
> ""Especially after you isolated yourself and made everyone your enemy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[153]`
Mówca: **Kesaro Kibener**
> ""What do you want me to say? You know your enemies better than me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's interesting to see you speak on behalf of an outlawed terror organization, Mr. Kibener. To be clear, are you admitting your ties to the Young Sords?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If you really thought I'd be interested in such an offer, you're living in your dreams.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's too late for that, Mr. Kibener. The Young Sords have overstepped and organized a political assassination in the heart of the capital. I cannot simply reverse my decision after that fact.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[160]`
Mówca: **Kesaro Kibener**
> ""I want you to reconsider your orders about the Young Sords. It's not too late to make amends. Besides, if there's an ally to be made, it is the nationalist youth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[140]`
  - -> `[155]`
  - -> `[156]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What in the world is the *Iron Wall*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[162]`
Mówca: **Kesaro Kibener**
> ""You made an enemy of Sordland. I hope you are aware of that now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[333]`
  - -> `[331]`
  - -> `[332]`

### Węzeł `[163]`
Mówca: **Remus Holstron**
> ""It's nice to finally meet you in person, Mr. President and Mr. Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[186]`
  - -> `[173]`
  - -> `[373]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's great to see your party's wholehearted support. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[165]`
Mówca: **Petr Vectern**
> ""The Iron Wall. The man behind... well, many things. Let's just say he's a bit of a legend within the nationalist movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[166]`
Mówca: **Kesaro Kibener**
> ""He'll be happy to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[167]`
Mówca: **Kesaro Kibener**
> ""No need to thank us, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Kesaro Kibener**
> ""It's just an old nickname that stuck around. Nobody really calls him that anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Kesaro Kibener**
> ""While we wait, I wanted to quickly mention a few things that were occupying my mind recently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Jump_KesarosComments])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[171]`
Mówca: **Kesaro Kibener**
> ""I am sure that it will pass and arrive on your desk, Mr. President. All I'm asking is for you not to veto it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`
  - -> `[120]`
  - -> `[123]`

### Węzeł `[172]`
Mówca: **Kesaro Kibener**
> ""Ah. There he is! Welcome, Mr. Holstron.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Happy Victory Day, Mr. Holstron.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'd also be happy to meet with him, Mr. Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[175]`
Mówca: **Kesaro Kibener**
> ""Thank you. There are a few things that have been occupying my mind recently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump_KesarosComments)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Jump_KesarosComments])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[178]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Kesaro Kibener: ""Look. I don't mean to corner you o..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[180]`
Mówca: **Kesaro Kibener**
> ""Fine. No comments. But at least hear this out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[181]`
Mówca: **Kesaro Kibener**
> ""The Young Sords aren't some kind of a 'fringe group of militants' as your administration claimed. You know whom they represent and how many are behind them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Likewise, Mr. Holstron.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[183]`
Mówca: **Kesaro Kibener**
> ""Please. This way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Narrator**
> "We walked until we found a shady spot just outside the Jen Center of Culture."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Narrator**
> "Kesaro leaned against the wall, pulled out a cigarette and lit it up with his Rippo lighter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`
  - -> `[192]`

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I always wanted to meet the Iron Wall himself. Today's my lucky day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Remus Holstron**
> ""Well. It's Victory Day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Remus Holstron**
> ""Likewise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is that an original Rippo?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Have you forgotten common courtesy, Mr. Kibener? Are we not offering cigarettes to friends anymore?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""How long are we going to be waiting here exactly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[193]`
Mówca: **Kesaro Kibener**
> ""You bet, Mr. President. It's one of the first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[194]`
Mówca: **Narrator**
> "He passed a cigarette to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[195]`
Mówca: **Kesaro Kibener**
> ""Apologies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[196]`
Mówca: **Kesaro Kibener**
> ""Our flags fly above the clouds, Mr. Rayne. And from up there, our fallen brothers, our national pride, the Sordish spirit... They're all watching over us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[197]`
Mówca: **Kesaro Kibener**
> ""And they surely watched in shame when the true patriots of this country were targeted with purely political reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[201]`
Mówca: **Kesaro Kibener**
> ""The Bludish independence movement, for example... Not only do the separatists pose an existential risk to us, they also threaten our neighbors in Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[205]`
Mówca: **Kesaro Kibener**
> ""I may not be fond of President Smolak, but our joint operation with the Wehzeks was certainly successful in stamping out the BFF. I consider that a great success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[206]`
Mówca: **Kesaro Kibener**
> ""That's from a bullet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Kesaro Kibener**
> ""Don't worry. It won't take too long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Kesaro Kibener**
> ""Believe it or not, this lighter is the reason I'm alive today. I should be thankful that the damn assassin was a Blud. No wonder he was incompetent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[209]`
Mówca: **Narrator**
> "I took a look at his lighter as he closed its lid. It was a regular Rippo, but its shape appeared to be malformed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Narrator**
> "Looking more closely, I could see a large circular dent in the chrome plating."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[211]`
Mówca: **Narrator**
> "He pulled on his collar to reveal a scar on his neck."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[212]`
Mówca: **Kesaro Kibener**
> ""Maybe I'll tell you the full story some other time. For now, I have some other things in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Narrator**
> "He took a drag from his cigarette and pointed at the giant flagpole in the plaza. I had to crane my neck to see the enormous Sordish flag flying from it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[214]`
Mówca: **Narrator**
> "He gave me the lighter. It was obviously high-quality, but its shape appeared to be malformed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_JointOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[221]`
Mówca: **Kesaro Kibener**
> ""And they are surely ashamed of what we Sords are living through today. Ashamed of how the true patriots of this country are being targeted for purely political reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[222]`
Mówca: **Kesaro Kibener**
> ""The lighter took the first shot. The second one grazed me right here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[226]`
Mówca: **Kesaro Kibener**
> ""That brings me to the Religious Harmony Bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[227]`
Mówca: **Kesaro Kibener**
> ""Now, Rumburg will have a harder time trying to influence us from within. Let's not forget their caches of KA-74s in our country. You've done the right thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[246]`
  - -> `[242]`
  - -> `[239]`

### Węzeł `[228]`
Mówca: **Kesaro Kibener**
> ""That's right. They don't even know whom they are dealing with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[229]`
Mówca: **Kesaro Kibener**
> ""Closing the borders with Wehlen has helped, but the countryside of Nargis and Bergia continues to be plagued by the BFF.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[230]`
Mówca: **Kesaro Kibener**
> ""Wehlen continues to be plagued by the BFF. They use their secret bases in the mountains to launch infiltrations into Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[231]`
Mówca: **Kesaro Kibener**
> ""I doubt it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[232]`
**[WYBÓR GRACZA: ""Thanks for the compliment.""]** — Mówca: **Player**
> ""Thanks for the compliment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_DefendBorder == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[236]`
Mówca: **Kesaro Kibener**
> ""They are a weaker nation both in heart and might. They won't have the capacity to handle the Bludish threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[237]`
Mówca: **Kesaro Kibener**
> ""Rumburg is using them to weaken us, and they might succeed if we do nothing to stop them. Let's not forget their caches of KA-74s in our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[240]`
  - -> `[244]`

### Węzeł `[238]`
**[WYBÓR GRACZA: ""The support President Smolak received from United Contana was a concern, but realpolitik was the victor.""]** — Mówca: **Player**
> ""The support President Smolak received from United Contana was a concern, but realpolitik was the victor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[239]`
**[WYBÓR GRACZA: ""Rumburg and the BFF will both meet a bad end if they dare to divide Sordland.""]** — Mówca: **Player**
> ""Rumburg and the BFF will both meet a bad end if they dare to divide Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[240]`
**[WYBÓR GRACZA: ""We can't intervene in other countries. It would destabilize the region.""]** — Mówca: **Player**
> ""We can't intervene in other countries. It would destabilize the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Kesaro Kibener**
> ""A Sordish president has to do whatever is necessary to protect his people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[242]`
**[WYBÓR GRACZA: ""Wehlen could be a valuable ally in the future, now that we have established a closer relationship.""]** — Mówca: **Player**
> ""Wehlen could be a valuable ally in the future, now that we have established a closer relationship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[243]`
Mówca: **Kesaro Kibener**
> ""Rumburg is using them to weaken us. Hopefully, our increased military funding will make sure their efforts won't bear fruit. But we need to stay vigilant. Let's not forget their caches of KA-74s in our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[240]`
  - -> `[244]`

### Węzeł `[244]`
**[WYBÓR GRACZA: ""Wehlen can take care of their own problems, and we will take care of ours.""]** — Mówca: **Player**
> ""Wehlen can take care of their own problems, and we will take care of ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[245]`
Mówca: **Kesaro Kibener**
> ""Their time will come too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[252]`
Mówca: **Kesaro Kibener**
> ""Thanks to your support, the BFF and other extremist groups won't be able to use religion to organize and gain support among the common folk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[263]`
  - -> `[265]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Kesaro Kibener**
> ""But you decided to veto it. Why are you ignoring the problem? The Bludish are using Nurity as a tool in their quest for independence. This is a direct threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[261]`
  - -> `[259]`

### Węzeł `[257]`
Mówca: **Kesaro Kibener**
> ""If anything, we are not restrictive enough. But I will not dive into this further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[258]`
Mówca: **Kesaro Kibener**
> ""In this case, doing nothing is far worse. The BFF is actively using priests in majority-Bludish areas. But let's not get off track.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[259]`
**[WYBÓR GRACZA: ""The bill was practically a recruitment flyer for the BFF. The more of these we pass, the more followers they get.""]** — Mówca: **Player**
> ""The bill was practically a recruitment flyer for the BFF. The more of these we pass, the more followers they get.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[260]`
Mówca: **Kesaro Kibener**
> ""Thank you. I led the effort. I was happy but not surprised to receive so much support from my fellow MPs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[261]`
**[WYBÓR GRACZA: ""It was too restrictive on the Bludish people. I couldn't let it pass.""]** — Mówca: **Player**
> ""It was too restrictive on the Bludish people. I couldn't let it pass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[262]`
**[WYBÓR GRACZA: ""The Bludish problem must be solved. We can't have an independence movement inside Sordland.""]** — Mówca: **Player**
> ""The Bludish problem must be solved. We can't have an independence movement inside Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[263]`
**[WYBÓR GRACZA: ""It was a well-written and strong bill. It would have been wrong to veto it.""]** — Mówca: **Player**
> ""It was a well-written and strong bill. It would have been wrong to veto it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[264]`
Mówca: **Kesaro Kibener**
> ""In an ideal world, yes. But as long as the BFF exists, that is not the world we live in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[265]`
**[WYBÓR GRACZA: ""We need to find a way where we can coexist without violence.""]** — Mówca: **Player**
> ""We need to find a way where we can coexist without violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[266]`
Mówca: **Kesaro Kibener**
> ""I'm glad you and I agree on this issue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[267]`
Mówca: **Kesaro Kibener**
> ""Our party and many members of parliament worked extremely hard on the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[268]`
Mówca: **Kesaro Kibener**
> ""Look. I don't mean to corner you on Victory Day like this, but I have to mention an important bill in the making.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[269]`
**[WYBÓR GRACZA: ""Is your national pride so fragile that this will destroy it? I don't think so.""]** — Mówca: **Player**
> ""Is your national pride so fragile that this will destroy it? I don't think so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[270]`
Mówca: **Kesaro Kibener**
> ""You were fooled. They saw Sordland battling the recession and they pounced on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[271]`
**[WYBÓR GRACZA: ""It was a necessary evil. Don't expect me to sit by while my people suffer.""]** — Mówca: **Player**
> ""It was a necessary evil. Don't expect me to sit by while my people suffer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[272]`
**[WYBÓR GRACZA: ""Kesaro. I am the President. I won't allow you to talk to me like this.""]** — Mówca: **Player**
> ""Kesaro. I am the President. I won't allow you to talk to me like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Kesaro Kibener**
> ""Of course. My apologies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[274]`
Mówca: **Kesaro Kibener**
> ""I fought for my country many times, and I have the scars to prove it. Can you say the same?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[275]`
**[WYBÓR GRACZA: ""I don't see anything wrong with accepting a helping hand.""]** — Mówca: **Player**
> ""I don't see anything wrong with accepting a helping hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[276]`
Mówca: **Kesaro Kibener**
> ""You are naive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Kesaro Kibener**
> ""The NFP believes you sold our national pride for money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[275]`
  - -> `[269]`
  - -> `[272]`

### Węzeł `[278]`
Mówca: **Kesaro Kibener**
> ""I won't waste my breath further on this matter, since you clearly don't understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[282]`
Mówca: **Kesaro Kibener**
> ""I also wanted to talk about the aid you received from United Contana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Kesaro Kibener**
> ""Do you think that's just free money? Do you think they offered it out of sheer goodwill?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[284]`
Mówca: **Kesaro Kibener**
> ""Oh, it's nothing, Mr. Rayne!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[285]`
Mówca: **Kesaro Kibener**
> ""I think it didn't last long enough to make a difference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[286]`
Mówca: **Kesaro Kibener**
> ""Oh, you made more than one of those.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[287]`
Mówca: **Kesaro Kibener**
> ""The emergency was the right call but it didn't last long enough to make a difference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[289]`
Mówca: **Kesaro Kibener**
> ""Oh, I was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[290]`
Mówca: **Kesaro Kibener**
> ""And they are surely concerned of the current circumstances the Sords have to go live through. One day you have an emergency, the next day the rules are different again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[291]`
Mówca: **Kesaro Kibener**
> ""And they are surely applauding you for your determination in maintaining stability in this nation. Applauding how its true patriots are finally taking it back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[292]`
Mówca: **Kesaro Kibener**
> ""Luckily that time is behind us now. Thankfully, you revoked that emergency before it was too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[302]`
  - -> `[303]`
  - -> `[307]`

### Węzeł `[293]`
Mówca: **Kesaro Kibener**
> ""Political uncertainty inside and exploitative pressures outside. It is an unusual time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`
  - -> `[311]`
  - -> `[305]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[297]`
Mówca: **Kesaro Kibener**
> ""Your fight against Bludish separatists and radical Malenyevists has been commendable, Mr. Rayne. I must thank you for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`
  - -> `[48]`

### Węzeł `[298]`
Mówca: **Kesaro Kibener**
> ""You are making a grave mistake targeting the wrong people, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[67]`
  - -> `[68]`
  - -> `[69]`

### Węzeł `[299]`
Mówca: **Kesaro Kibener**
> ""Albeit not enough by any means, your fight against the radical Malenyevists has been commendable, Mr. Rayne. I must thank you for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`
  - -> `[48]`
  - -> `[49]`

### Węzeł `[300]`
Mówca: **Kesaro Kibener**
> ""Albeit not enough by any means, your fight against Bludish separatists has been commendable, Mr. Rayne. I must thank you for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`
  - -> `[48]`
  - -> `[49]`

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Would you have thought the same if it wasn't your boys who were being targeted?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It was a necessary decision to make. For the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mistakes were made but the past is in the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[304]`
Mówca: **Kesaro Kibener**
> ""I wouldn't, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Am I supposed to be impressed with the theatrics?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Kesaro Kibener**
> ""Oh, come on, Mr. Rayne!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Am I supposed to be impressed with the theatrics?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[308]`
Mówca: **Kesaro Kibener**
> ""What? You expected me to come up with a witty response claiming I would?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What are you insinuating, Mr. Kibener?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Were you not supportive of the emergency?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mistakes were made but the past is in the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[312]`
Mówca: **Kesaro Kibener**
> ""It's true. And I respect you for admitting that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[313]`
Mówca: **Kesaro Kibener**
> ""It was hardly a *necessary* decision, Mr. President. You know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[314]`
Mówca: **Kesaro Kibener**
> ""Why so grouchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[315]`
Mówca: **Kesaro Kibener**
> ""Does that mean you completely trust the Old Guard and will not budge on your position?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[322]`
  - -> `[323]`
  - -> `[324]`

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why don't you answer my question first?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[317]`
Mówca: **Kesaro Kibener**
> ""Well, are you telling me that you completely trust the Old Guard and will not budge on your position?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`
  - -> `[321]`
  - -> `[323]`
  - -> `[324]`

### Węzeł `[318]`
Mówca: **Narrator**
> "Petr looked at me in surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[319]`
Mówca: **Kesaro Kibener**
> ""Don't you have the power to fabricate an answer to that question yourself and do whatever you wish with it? I refuse to play that game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Kesaro Kibener**
> ""You answer me. Do you or don't you trust the Old Guard? And is your position flexible?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[323]`
  - -> `[324]`

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I didn't say anything about trusting the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't trust the Old Guard the same way I don't trust you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No. I won't budge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know what? Let's hear what you're exactly offering here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[325]`
Mówca: **Kesaro Kibener**
> ""The Old Guard will not let you free from their hook. You know they can strike back at you at any time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Kesaro Kibener**
> ""If the nationalists supported you, the emergency would have been much more effective against its 'true' targets. And you wouldn't need to fear Hawker as much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[327]`
Mówca: **Petr Vectern**
> ""'Effective' in what way, exactly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[328]`
Mówca: **Kesaro Kibener**
> ""The Old Guard will not let you free from their hook. You know that they can strike back at you at any time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Kesaro Kibener**
> ""It is a shame to see you make enemies of everybody. But if you're willing to continue on this path, I'll gladly watch your demise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Enough with your threats. If you're delaying the celebrations for this talk, I'll take my leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You are making an enemy of Sordland at this very moment, Mr. Kibener. I advise you to back off before it's too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's too late to complain, Mr. Kibener. The Young Sords have overstepped and organized a political assassination in the heart of the capital. I cannot simply reverse my decision after that fact.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's interesting to see you speak on behalf of an outlawed terror organization, Mr. Kibener. To be clear, are you admitting your ties to the Young Sords?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[334]`
Mówca: **Kesaro Kibener**
> ""I'm not delaying anything. If you're willing to abandon Sordland's largest Victory Day celebrations, feel free to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[335]`
Mówca: **Kesaro Kibener**
> ""That would only harm your reputation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[336]`
Mówca: **Kesaro Kibener**
> ""Don't you have the power to fabricate an answer to that question yourself and do whatever you wish with it? I refuse to play that game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[337]`
Mówca: **Kesaro Kibener**
> ""I may back off but others may not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[340]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Nationalist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Kesaro Kibener**
> ""You are a traitor to the cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[342]`
Mówca: **Kesaro Kibener**
> ""Nobody expected you to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[343]`
Mówca: **Kesaro Kibener**
> ""You know what I'm trying to say... But are you willing to have that conversation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`
  - -> `[345]`

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know what? I am willing to hear you out. I will consider a reversal on the ban of the Young Sords -- if you can *convince* me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, I'm definitely not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[346]`
Mówca: **Kesaro Kibener**
> ""But know this. The Sordists wi-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[347]`
Mówca: **Kesaro Kibener**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`
  - -> `[350]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Narrator: "Suddenly, a man with a large build..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[352]`
Mówca: **Remus Holstron**
> ""I must say I am very supportive of the emergency, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Remus Holstron**
> ""The Sordists and the wider Sordish nationalist movement hold the consensus view that the act was justified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[357]`
Mówca: **Remus Holstron**
> ""I must say you are very lucky to survive the journey to central Jen, Mr. Rayne. This city is the stronghold of the Sordists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[358]`
Mówca: **Remus Holstron**
> ""It is good to see you both in Jen today. This means a lot to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[359]`
Mówca: **Remus Holstron**
> ""The Sordists and the wider Sordish nationalist movement hold the consensus view that this emergency is targeting them as a whole.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_YoungSords_Willing = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_YoungSords_Willing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_YoungSords_Willing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`
  - -> `[363]`

### Węzeł `[362]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_YoungSords_Willing == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_YoungSords_Willing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_YoungSords_Willing == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_YoungSords_Willing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[364]`
Mówca: **Kesaro Kibener**
> ""I've already talked to Mr. President about a possible reversal of the wrongs that have been made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[365]`
Mówca: **Kesaro Kibener**
> ""He is willing to compromise for our support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[366]`
Mówca: **Remus Holstron**
> ""That is great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[367]`
Mówca: **Remus Holstron**
> ""The event is about to begin. Why don't we slowly walk over to the plaza?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[368]`
Mówca: **Petr Vectern**
> ""About time. Let's go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[369]`
Mówca: **Remus Holstron**
> ""You will regret your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[372]`
  - -> `[370]`
  - -> `[374]`

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't care what the nationalists think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[371]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you threatening the President of Sordland?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No more threats! Both of you will face consequences for your actions today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[373]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[374]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Look at the time. Is the event starting already?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[375]`
Mówca: **Remus Holstron**
> ""It is about to start...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[376]`
Mówca: **Remus Holstron**
> ""Let me show you the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[377]`
Mówca: **Petr Vectern**
> ""About damn time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[378]`
Mówca: **Petr Vectern**
> ""Enough of this, you three. Let's go to the damn plaza and get this event over with already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[379]`
Mówca: **Remus Holstron**
> ""That's very brave of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]`

### Węzeł `[380]`
Mówca: **Remus Holstron**
> ""Agreed. Our presence is expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[381]`
Mówca: **Narrator**
> "He looked at me straight in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[382]`
Mówca: **Remus Holstron**
> ""Mr. Rayne. The nationalists are willing to give you their support if you are willing to protect them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[383]`
Mówca: **Remus Holstron**
> ""And if you reverse the ban on the Young Sords, and give your support to the group, you will be in a much stronger position enforcing your emergency powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[384]`
Mówca: **Remus Holstron**
> ""If you're willing to do that, and help us with a few requests, we can have this conversation in detail. I can answer any questions you have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[401]`
  - -> `[385]`
  - -> `[386]`

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""On a second thought, I don't want to involve myself with the Young Sords. We are not having this conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""On a second thought, I think I should report you both for supporting terrorism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[387]`
Mówca: **Remus Holstron**
> ""Go ahead, Mr. Rayne. We have done nothing wrong and the police knows this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[388]`
Mówca: **Kesaro Kibener**
> ""It's actually about to begin. Follow me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[389]`
Mówca: **Remus Holstron**
> ""Go ahead, Mr. Rayne. Remain a puppet of the Sollists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[390]`
Mówca: **Remus Holstron**
> ""Good luck with your masters in the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Petr Vectern**
> ""It's a celebration, remember? Let's go to the damn plaza and get this event over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[392]`
Mówca: **Petr Vectern**
> ""Enough!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[393]`
Mówca: **Narrator**
> "Everybody went silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm willing to consider it but I need to know about these additional requests and exactly what you are offering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[395]`
Mówca: **Remus Holstron**
> ""In return for giving you full support, the nationalists would expect you to show them that you are a true patriot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[396]`
Mówca: **Remus Holstron**
> ""Great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[397]`
Mówca: **Narrator**
> "He looked me straight in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[398]`
Mówca: **Remus Holstron**
> ""President Rayne. The nationalists are willing to give you their support if you are willing to protect them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[399]`
Mówca: **Remus Holstron**
> ""I'm referring particularly to the Young Sords. Many in the organization feel the urge to support you directly in your efforts against our enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[400]`
Mówca: **Remus Holstron**
> ""If you're willing to cooperate with the Young Sords, we can have this conversation in detail. I can answer any questions you have about a possible alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`
  - -> `[419]`
  - -> `[416]`
  - -> `[417]`

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I thought you only wanted to unban the Young Sords. What are these requests?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[402]`
Mówca: **Remus Holstron**
> ""However, revoking the ban alone won't be enough to erase the trauma you brought upon them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[403]`
Mówca: **Remus Holstron**
> ""And finally, we want you to sign the Unified Education Act when it reaches you. We already have the support of the Assembly and it would be a step in the right direction if you do not use your veto powers on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`
  - -> `[406]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Progressive == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[407]`
Mówca: **Remus Holstron**
> ""What do you want to know about first?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[408]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""First, tell me what the Young Sords can offer me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[409]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""First, I want to hear your demands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[410]`
Mówca: **Remus Holstron**
> ""First and foremost, you will revoke the ban on the Young Sords and recognize them as a legal organization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_TightenedImmigration == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`
  - -> `[413]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_TightenedImmigration == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_TightenedImmigration == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[414]`
Mówca: **Remus Holstron**
> ""With the Young Sords on your side, you will be in a much stronger position to enforce your emergency powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[415]`
Mówca: **Remus Holstron**
> ""And judging by the current relationship you have with the Supreme Court, it would be a good idea for you to have strong allies outside of their direct reach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Very intriguing. I'm willing to discuss the possibilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's talk about how we can help each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sorry, but I don't want to involve myself with the Young Sords.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Petr. What do you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[420]`
Mówca: **Narrator**
> "Petr leaned in and whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[421]`
Mówca: **Petr Vectern**
> ""You know I don't necessarily enjoy the emergency. But at this point, why not hear the Iron Wall out?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[422]`
Mówca: **Petr Vectern**
> ""As much as I hate to involve ourselves with the Young Sords, he has a point about the Court. You need strong allies against them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`
  - -> `[416]`
  - -> `[417]`

### Węzeł `[423]`
Mówca: **Kesaro Kibener**
> ""The Old Guard will not let you free from their hook. You know they can strike back at you at any time. We can help each other out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[424]`
Mówca: **Kesaro Kibener**
> ""If the nationalists supported you, the emergency would be much more effective against its targets. And you wouldn't need to fear Hawker as much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[425]`
Mówca: **Petr Vectern**
> ""'Effective' in what way exactly, Mr. Kibener?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[426]`
Mówca: **Kesaro Kibener**
> ""You know what I'm trying to say... But are you willing to have that conversation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`
  - -> `[428]`

### Węzeł `[427]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know what? Having the Young Sords support me is not a bad idea. Let's talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[428]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, I'm definitely not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[429]`
Mówca: **Remus Holstron**
> ""That's a shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[430]`
Mówca: **Remus Holstron**
> ""The Young Sords can give you on-the-ground support that the state institutions cannot provide. A helping hand to steer the country towards your cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`

### Węzeł `[431]`
Mówca: **Kesaro Kibener**
> ""Well... I guess we can start walking towards the plaza. The event is about to start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[432]`
Mówca: **Petr Vectern**
> ""About time. Let's go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`
  - -> `[435]`

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_Investigate_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[436]`
Mówca: **Remus Holstron**
> ""You should already have an idea of what they're capable of. With protection from the President himself, they will surely have the power to eliminate any obstacle that stands in your way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`
  - -> `[438]`
  - -> `[437]`
  - -> `[440]`

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Quit beating around the bush, Mr. Holstron. You are offering me an extrajudicial solution to political problems. Isn't that right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Can you give me more concrete examples?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""But how do I know they won't turn against me one day?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[440]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I like the idea already, Mr. Holstron.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[441]`
Mówca: **Remus Holstron**
> ""You don't. Neither do I. Who truly knows what the future will bring?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[442]`
Mówca: **Remus Holstron**
> ""Trust is mutual, Mr. Rayne. As long as both sides understand each other, there would be no reason to end a beneficial cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[443]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[444]`
Mówca: **Remus Holstron**
> ""No, I cannot. But I can tell you whether what's on your mind can be done or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[445]`
Mówca: **Remus Holstron**
> ""Me? No.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[446]`
Mówca: **Remus Holstron**
> ""But I'm not responsible for anything the Young Sords might or might not want to offer you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[447]`
Mówca: **Remus Holstron**
> ""Beautiful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Questions_YSDeal)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`
  - -> `[409]`

### Węzeł `[449]`
Mówca: **Kesaro Kibener**
> ""The support of a such a massive non-governmental organization would surely be useful to you, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[450]`
Mówca: **Kesaro Kibener**
> ""Ask away and we'll try our best to answer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""How can the Young Sords help us enforce the emergency?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[452]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I know the Young Sords are well-connected with the NFP. How can they support me if they're aligned with our rivals?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[453]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What if there are problematic individuals who require... being handled?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The Court is a problem. What can we do to protect the emergency and the administration?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[455]`
Mówca: **Remus Holstron**
> ""The enemies of the state are the enemies of the Young Sords, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[456]`
Mówca: **Remus Holstron**
> ""Ms. Graf's security forces are doing a good job enforcing the rules on the ground, but they might still have some gaps that need filling in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`
  - -> `[459]`

### Węzeł `[458]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Interior_Increased == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[460]`
Mówca: **Remus Holstron**
> ""They can help the security forces on the ground where necessary. I'm sure that would be very valuable, considering the current lack of funding for the police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[461]`
Mówca: **Kesaro Kibener**
> ""An alliance with the Young Sords means an unofficial alliance with the nationalist movement, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[462]`
Mówca: **Kesaro Kibener**
> ""As long as our policies stay aligned, we are no rivals. Nationalists being in charge of this nation has only benefits for both of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[463]`
Mówca: **Kesaro Kibener**
> ""Hell, maybe it's even about time for the USP to form an official alliance with the NFP. We'd be stronger together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[464]`
Mówca: **Remus Holstron**
> ""If it's the elections you're worried about, don't. If you sustain the emergency until that point, let's just say we'd be happy to support your campaign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]`

### Węzeł `[465]`
Mówca: **Kesaro Kibener**
> ""I've heard rumors that you already have the means to handle that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[466]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`
  - -> `[468]`

### Węzeł `[467]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[468]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[469]`
Mówca: **Remus Holstron**
> ""If your definition of 'problematic' aligns with ours, I don't think it would be difficult to arrange something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`

### Węzeł `[470]`
Mówca: **Kesaro Kibener**
> ""But of course, even you probably don't have absolute control over those forces. If they prove to be unreliable, the nationalist youth would be happy to help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[471]`
Mówca: **Remus Holstron**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[472]`
Mówca: **Kesaro Kibener**
> ""The Court itself isn't the main problem. It's certain individuals who hold the power to impeach you whenever necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[473]`
Mówca: **Remus Holstron**
> ""And their adulterated Sollist philosophy, of course... This illusion of *unity* they fabricated has long poisoned our nation. It is time the true Sords take the power back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[474]`
Mówca: **Remus Holstron**
> ""I believe the Sordists are done cooperating with them. If you prove to be the strong leader you're portraying yourself as, they'd be happy to plan a move against the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`
  - -> `[477]`

### Węzeł `[476]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[477]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`
  - -> `[480]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[480]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[481]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_IncreasedInteriorFunding == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`
  - -> `[483]`

### Węzeł `[482]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_IncreasedInteriorFunding == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_IncreasedInteriorFunding == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_IncreasedFunding == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`
  - -> `[486]`

### Węzeł `[485]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_IncreasedFunding == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Military_IncreasedFunding"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[486]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Military_IncreasedFunding == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Military_IncreasedFunding"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[487]`
Mówca: **Remus Holstron**
> ""They'll need resources to be able to rebuild again. You'll need to arrange a 'transfer' of finances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[488]`
Mówca: **Remus Holstron**
> ""We are also aware of the investigations being conducted on both opposition parties. You will immediately stop the investigations into the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[489]`
Mówca: **Remus Holstron**
> ""You will write a decree to tighten immigration. Effective immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[490]`
Mówca: **Remus Holstron**
> ""And you will order the complete halt of your education reforms. There is no possible way we can accept the removal of nationalist doctrines from our curriculums.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[491]`
Mówca: **Remus Holstron**
> ""Finally, you will reinstate the Energy Protection Act as it was enacted by Tarquin Soll. We have to reverse this exploitative scheme immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[492]`
Mówca: **Remus Holstron**
> ""If you can do that, you will have the nationalist movement and the Young Sords behind you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[493]`
Mówca: **Remus Holstron**
> ""Finally, you will make use of the remaining government budget and transfer emergency funds to the Ministry of Interior to strengthen the emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[494]`
Mówca: **Remus Holstron**
> ""Finally, you will make use of the remaining government budget and transfer emergency funds to the Sordish Armed Forces to strengthen our defense against Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[495]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_TightenedImmigration == false && BaseGame.Turn04_PSnW_Education_Progressive == true && (BaseGame.Situation_Economy_FinancialInvestment_UC == true || BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true || BaseGame.Policy_Order_DecreasedInteriorFunding == true) == true && BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`
  - -> `[497]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_TightenedImmigration == false && BaseGame.Turn04_PSnW_Education_Progressive == true && (BaseGame.Situation_Economy_FinancialInvestment_UC == true || BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true || BaseGame.Policy_Order_DecreasedInteriorFunding == true) == true && BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == false  and  Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true  and  (Variable["BaseGame.Situation_Economy_FinancialInvestment_UC"] == true  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  or  Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == true) == true  and  Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[497]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_TightenedImmigration == false && BaseGame.Turn04_PSnW_Education_Progressive == true && (BaseGame.Situation_Economy_FinancialInvestment_UC == true || BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true || BaseGame.Policy_Order_DecreasedInteriorFunding == true) == true && BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == false  and  Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true  and  (Variable["BaseGame.Situation_Economy_FinancialInvestment_UC"] == true  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  or  Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == true) == true  and  Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[498]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_KesaroLighter");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_KesaroLighter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[499]`
Mówca: **Kesaro Kibener**
> ""Please. Keep it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[500]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[502]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: VictoryDay_AutocratOfferHub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`
  - -> `[599]`
  - -> `[602]`
  - -> `[605]`
  - -> `[504]`

### Węzeł `[503]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [VictoryDay_AutocratOfferHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[504]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I think I get the idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[505]`
Mówca: **Remus Holstron**
> ""Good. And we have important requests from you in return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[506]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Remus Holstron: ""Good. And we have important reques..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[507]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`
  - -> `[509]`

### Węzeł `[508]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[509]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[510]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`
  - -> `[512]`

### Węzeł `[511]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[512]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`
  - -> `[513]`

### Węzeł `[513]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's hear what the Young Sords can offer me in return now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[514]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Remus Holstron: ""The Young Sords can give you on-th..."])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[515]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: OfferComplete)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`
  - -> `[519]`

### Węzeł `[516]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`
  - -> `[518]`

### Węzeł `[517]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[518]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[519]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I think you're asking too much. I don't think we can make a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[520]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Fine. I agree to your demands. It's a deal." [-2 Government Budget]"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`

### Węzeł `[521]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're asking too much. I don't even want to hear about your offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[522]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`
  - -> `[524]`

### Węzeł `[523]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[524]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[525]`
Mówca: **Remus Holstron**
> ""We are aware of the investigations being conducted on both opposition parties. You will immediately stop the investigation into the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[526]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`
  - -> `[528]`

### Węzeł `[527]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[528]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_Investigate_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[529]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_TightenedImmigration == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`
  - -> `[531]`

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_TightenedImmigration == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_TightenedImmigration == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[532]`
Mówca: **Remus Holstron**
> ""You will write a decree to tighten immigration. Effective immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`
  - -> `[535]`

### Węzeł `[534]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[535]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Progressive == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[536]`
Mówca: **Remus Holstron**
> ""You will order the complete halt of your education reforms. There is no possible way we can accept the removal of nationalist doctrines from our curriculums.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`
  - -> `[537]`

### Węzeł `[537]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Opposition == true || BaseGame.Policy_Diplomacy_TightenedImmigration == false || BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`
  - -> `[539]`

### Węzeł `[538]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Opposition == true || BaseGame.Policy_Diplomacy_TightenedImmigration == false || BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] == true  or  Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == false  or  Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_Investigate_Opposition == true || BaseGame.Policy_Diplomacy_TightenedImmigration == false || BaseGame.Turn04_PSnW_Education_Progressive == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] == true  or  Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == false  or  Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[540]`
Mówca: **Remus Holstron**
> ""We just want you to sign the Unified Education Act when it reaches you. We already have the support of the Assembly and it would be a step in the right direction if you do not use your veto powers on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[541]`
Mówca: **Kesaro Kibener**
> ""Agreed. But the event is about to begin. Why don't we head back over to the plaza?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[542]`
Mówca: **Petr Vectern**
> ""About time. Let's go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[543]`
Mówca: **Remus Holstron**
> ""That's a shame. A big mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[544]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Opposition == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`
  - -> `[546]`

### Węzeł `[545]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_Investigate_Opposition == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[546]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_Investigate_Opposition == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_TightenedImmigration == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`
  - -> `[549]`

### Węzeł `[548]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_TightenedImmigration == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[549]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_TightenedImmigration == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[550]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`
  - -> `[552]`

### Węzeł `[551]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Progressive == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[552]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Progressive == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[553]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Stopped_Investigations_NFP = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Stopped_Investigations_NFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[554]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_TightenedImmigration = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[555]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_EducationReform = false;
BaseGame.Policy_Welfare_TraditionalEducation = true;
BaseGame.Turn04_PSnW_Education_Progressive = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Welfare_EducationReform"] = false;
Variable["BaseGame.Policy_Welfare_TraditionalEducation"] = true;
Variable["BaseGame.Turn04_PSnW_Education_Progressive"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[556]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS = false; BaseGame.Policy_Law_Ban_YoungSords = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] = false;
Variable["BaseGame.Policy_Law_Ban_YoungSords"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[557]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`
  - -> `[559]`

### Węzeł `[558]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]`

### Węzeł `[559]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[560]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`
  - -> `[562]`

### Węzeł `[561]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`

### Węzeł `[562]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.GovernmentBudget > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_IncreasedInteriorFunding == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`
  - -> `[565]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_IncreasedInteriorFunding == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[565]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_IncreasedInteriorFunding == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[566]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_IncreasedFunding == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]`
  - -> `[568]`

### Węzeł `[567]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_IncreasedFunding == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Military_IncreasedFunding"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[568]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Military_IncreasedFunding == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Military_IncreasedFunding"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[569]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_NFP_Promised_LanguageBill = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_NFP_Promised_LanguageBill"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[570]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Autocrat_YoungSords_NFP_Deal = true;
BaseGameSupport.Journal_Turn06_VictoryDay_MadeDealWithYS = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] = true;
Variable["BaseGameSupport.Journal_Turn06_VictoryDay_MadeDealWithYS"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[571]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.EconomyDirection_Scale -= 4;
BaseGame.Policy_Economy_EnergyProtectionAct_10Percent = true;
BaseGame.Policy_Economy_EnergyProtectionAct_49Percent = false;
BaseGame.Policy_Economy_EnergyProtectionAct_Default = false;
BaseGame.Policy_Economy_EnergyProtectionAct_Removed = false;
BaseGame.Relations_Ewald_Discontent = true;
BaseGame.Relations_Ewald_Neutral = false;
BaseGame.Relations_Ewald_Friendly = false;
BaseGame.Gasom_Bankrupt = true;
BaseGame.Gasom_Default = false;
BaseGame.Gasom_Downsized = false;
BaseGame.Gasom_Booming = false;
BaseGame.Gasom_Ownership_PrivatelyOwned = true;
BaseGame.Gasom_Ownership_ForeignOwned = false;
BaseGame.Gasom_Ownership_StatePrivateCooperation = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.EconomyDirection_Scale"] = Variable["BaseGame.EconomyDirection_Scale"] - 4;
Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] = true;
Variable["BaseGame.Policy_Economy_EnergyProtectionAct_49Percent"] = false;
Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Default"] = false;
Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] = false;
Variable["BaseGame.Relations_Ewald_Discontent"] = true;
Variable["BaseGame.Relations_Ewald_Neutral"] = false;
Variable["BaseGame.Relations_Ewald_Friendly"] = false;
Variable["BaseGame.Gasom_Bankrupt"] = true;
Variable["BaseGame.Gasom_Default"] = false;
Variable["BaseGame.Gasom_Downsized"] = false;
Variable["BaseGame.Gasom_Booming"] = false;
Variable["BaseGame.Gasom_Ownership_PrivatelyOwned"] = true;
Variable["BaseGame.Gasom_Ownership_ForeignOwned"] = false;
Variable["BaseGame.Gasom_Ownership_StatePrivateCooperation"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[572]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_IncreasedInteriorFunding = true;
BaseGame.Turn04_SnO_LE_Interior_Increased = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] = true;
Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[573]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Military_IncreasedFunding = true;
BaseGame.Turn03_EnT_Military_Budget_Increase = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Policy_Military_IncreasedFunding"] = true;
Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[574]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true && BaseGame.GovernmentBudget > 0 && (BaseGame.Policy_Military_IncreasedFunding == false || BaseGame.Policy_Order_IncreasedInteriorFunding == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`
  - -> `[576]`

### Węzeł `[575]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true && BaseGame.GovernmentBudget > 0 && (BaseGame.Policy_Military_IncreasedFunding == false || BaseGame.Policy_Order_IncreasedInteriorFunding == false))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true  and  Variable["BaseGame.GovernmentBudget"] > 0  and  (Variable["BaseGame.Policy_Military_IncreasedFunding"] == false  or  Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[576]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true && BaseGame.GovernmentBudget > 0 && (BaseGame.Policy_Military_IncreasedFunding == false || BaseGame.Policy_Order_IncreasedInteriorFunding == false)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true  and  Variable["BaseGame.GovernmentBudget"] > 0  and  (Variable["BaseGame.Policy_Military_IncreasedFunding"] == false  or  Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[577]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`
  - -> `[579]`

### Węzeł `[578]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[579]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[580]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Fine. I agree to your demands. It's a deal." [-1 Government Budget]"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`

### Węzeł `[581]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Fine. I agree to your demands. It's a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[582]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[583]`
Mówca: **Kesaro Kibener**
> ""That's great to hear!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[584]`
Mówca: **Remus Holstron**
> ""It was a pleasure, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[585]`
Mówca: **Kesaro Kibener**
> ""Now why don't we head back towards the plaza? The event is about to start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`

### Węzeł `[586]`
Mówca: **Petr Vectern**
> ""Great. Let's go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[587]`
Mówca: **Remus Holstron**
> ""Anyway, our presence is expected at the plaza. Shall we make our way over?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[588]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`
  - -> `[590]`

### Węzeł `[589]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]`

### Węzeł `[590]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Nationalist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[591]`
Mówca: **Remus Holstron**
> ""Good to see you again after a long time, Mr. President and Mr. Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[173]`
  - -> `[373]`

### Węzeł `[592]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[593]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[594]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[595]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[596]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`
  - -> `[598]`

### Węzeł `[597]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[598]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[599]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`
  - -> `[601]`

### Węzeł `[600]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[601]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[602]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`
  - -> `[604]`

### Węzeł `[603]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[604]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[605]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`
  - -> `[607]`

### Węzeł `[606]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[607]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[608]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[609]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.GovernmentBudget -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`
