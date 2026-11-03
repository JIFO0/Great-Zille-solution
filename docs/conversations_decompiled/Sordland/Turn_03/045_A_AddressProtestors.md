# Sordland/Turn03/A_AddressProtestors

- **ID konwersacji:** `45`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/045_A_AddressProtestors.md`
- **Liczba węzłów dialogowych:** 484
- **Liczba wyborów gracza:** 115

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[22]** Denis Stahler
- **[35]** Gus Manger
- **[53]** Katarina Horten
- **[54]** Serge Wolkner
- **[57]** Reporter

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn01_CampaignFinance_Signed`
- `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses`
- `BaseGame.Decision_Turn02_Funeral_Attend`
- `BaseGame.Decision_Turn02_StatusReaction_BoostPolice`
- `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors`
- `BaseGame.Prologue_Party_Takeover_Backstab`
- `BaseGame.Prologue_University_Political_Nationalist`
- `BaseGame.Prologue_University_Political_Socialist`
- `BaseGame.Promise_TermFocus_Education`
- `BaseGame.Promise_TermFocus_Health`
- `BaseGame.Relations_Ewald_DonatedToFoundation`
- `BaseGame.Relations_Serge_Friend`
- `BaseGame.Situation_Law_MediaBias`
- `BaseGame.Turn03_A_Protestors_Mixed`
- `BaseGame.Turn03_A_Protestors_Uproar`
- `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia`
- `BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention`
- `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone`
- `BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits`
- `BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages`
- `BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation`
- `BaseGameIsolated.Turn03_AddressProtestors_Tension`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Country_Unrest`
- `BaseGame.Public_Opinion`
- `BaseGame.Turn03_A_Protestors_Calm`
- `BaseGame.Turn03_A_Protestors_Mixed`
- `BaseGame.Turn03_A_Protestors_Uproar`
- `BaseGameIsolated.Turn03_AddressProtestors_Tension`
- `BaseGameSupport.News_Turn03_HP_Address_CrowdHassle`
- `BaseGameSupport.News_Turn03_HP_Address_MalenyevistRYRebels`
- `BaseGameSupport.News_Turn03_HP_Workers_GasomExpandsCare`
- `BaseGameSupport.News_Turn03_HP_Workers_GasomGivesCharity`
- `BaseGameSupport.News_Turn03_HP_Workers_GasomIncreasesSalaries`
- `BaseGameSupport.News_Turn03_LT_Address_DramaticScenesUnfold`
- `BaseGameSupport.News_Turn03_LT_Address_LungedAtPresident`
- `BaseGameSupport.News_Turn03_LT_Address_PositiveCrowd`
- `BaseGameSupport.News_Turn03_LT_Workers_LUSCPSLose`
- `BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinCare`
- `BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinDonations`
- `BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinSalaries`
- `BaseGameSupport.News_Turn03_R_Address_OkaySpeechByPresident`
- `BaseGameSupport.News_Turn03_R_Address_PresidentAssaulted`
- `BaseGameSupport.News_Turn03_R_Workers_LUSCPSCondemn`
- `BaseGameSupport.News_Turn03_R_Workers_LUSCPSDisappointed`
- `BaseGameSupport.News_Turn03_R_Workers_LUSCPSInaction`
- `BaseGameSupport.News_Turn03_R_Workers_LUSCPSVictory`
- `BaseGameSupport.News_Turn03_ST_Address_AmazingSpeech`
- `BaseGameSupport.News_Turn03_ST_Address_BadSpeech`
- `BaseGameSupport.News_Turn03_ST_Address_PresidentDeaf`
- `BaseGameSupport.News_Turn03_ST_Address_PresidentListens`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 9
- **Węzły modyfikujące stan gry:** 66

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Country_Unrest`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[11]` (Paskal Beniwoll): `AddConversant("Gus Manger");`
- Węzeł `[12]` (Paskal Beniwoll): `AddConversant("Serge Wolkner");`
- Węzeł `[14]` (Paskal Beniwoll): `AddConversant("Katarina Horten");`
- Węzeł `[15]` (Paskal Beniwoll): `AddConversant("Denis Stahler");`
- Węzeł `[54]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03...`
- Węzeł `[55]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03...`
- Węzeł `[105]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03...`
- Węzeł `[106]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03...`
- *...oraz 58 innych węzłów ze skryptami.*

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
  - -> `[481]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“My fellow Sords, we are here today not as adversaries, but as collaborators. Our purpose? To invest in Gasom, and ensure it invests in you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`
  - -> `[21]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Gus Manger stood to my right, his silhouette barely distinguishable from the monolithic edifice behind us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Serge stood to my left, his eyes scanning the crowd with the precision of a hawk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "The Gasom security had drawn their weapons in anticipation, forming a bristling wall around the perimeter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "My Presidential Guard, in stark contrast, stood tall and unflinching at the entrance, shielding us from the sea of angry workers surrounding us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[8]`
Mówca: **Narrator**
> "The shouts of the crowd were deafening, the hostility palpable. Stahler and Horten stood at the forefront with fire in their eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Narrator**
> "With a deep breath, I prepared to address them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Narrator**
> "Gus extended a megaphone towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[453]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Gus Manger");)*
- **Efekt (`userScript`):** `AddConversant("Gus Manger");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Serge Wolkner");)*
- **Efekt (`userScript`):** `AddConversant("Serge Wolkner");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[13]`
Mówca: **Narrator**
> "As we stepped out of the towering front gate of the Gasom facility, I immediately became aware of how tense the situation was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Katarina Horten");)*
- **Efekt (`userScript`):** `AddConversant("Katarina Horten");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Denis Stahler");)*
- **Efekt (`userScript`):** `AddConversant("Denis Stahler");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“To the hard-working employees of Gasom, we stand with you today. Our shared goal is simple: to demand improved living and working conditions for everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`
  - -> `[21]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Good people of Narbel, we come here today seeking understanding and progress. We aim to bridge the gap between Gasom and its employees.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`
  - -> `[21]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Today my team and I are here to listen and engage. We are here to ensure Gasom becomes a beacon of growth, fairness, and prosperity for all its workers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[26]`
  - -> `[27]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We are not blind to your struggles. We seek to acknowledge them, address them, and above all, improve them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“This is not a hollow promise, but a step towards a stronger and more balanced Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Remember, we are united by a common goal: A prosperous Gasom that cares for its workers. It's a fight we all must face together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Let's turn this impasse into an opportunity -- a chance for real, impactful change. We are here to make that happen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[23]`
Mówca: **Narrator**
> "A group of figures emerged from the crowd, adorned in unmistakable scarlet attire. The Red Youth had arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“My fellow Sords, our presence today is not a guarantee of instant change, but rather an effort to better understand the complexity of the issues at hand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[26]`
  - -> `[27]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Good people of Narbel, we are here not to placate you with false promises, but to honestly assess the reality and work towards practical solutions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[26]`
  - -> `[27]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We recognize that words are not enough, and only through concrete action can we begin to address the challenges you face.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Today’s visit, let's be clear, does not mean all your problems will disappear overnight. It's an initial step to gauge the scope of the issues.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[28]`
Mówca: **Katarina Horten**
> "“Speeches and more speeches, from President Rayne! But what exactly was decided today? We need more than pretty words; we need substance!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true || BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true || BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true  or  Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
  - -> `[16]`
  - -> `[17]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true || BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true  or  Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[24]`
  - -> `[25]`

### Węzeł `[32]`
Mówca: **Denis Stahler**
> "“She's right, Mr. President. We need details. What's going to change for the workers?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_HelpCitizensIntention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[36]`
Mówca: **Narrator**
> "I realized this was no longer a mere protest. It was a symbol of a broader, more potent struggle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[37]`
Mówca: **Katarina Horten**
> "“Empty words, Rayne! You've shown us nothing concrete today. We're fed up with your hollow rhetoric!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Denis Stahler**
> "“All talk and no action, isn't it, Mr. President? How long must the workers wait for real change?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[39]`
Mówca: **Gus Manger**
> "“Now hold on a moment. President Rayne is committed to bringing about real change. His actions and decisions demonstrate this clearly, even if it doesn't fit your narrative!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_Funeral_Attend == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_Funeral_Attend == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_Funeral_Attend"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_Funeral_Attend == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_Funeral_Attend"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[52]`
Mówca: **Katarina Horten**
> "“Wasn't it your government that bailed out the elites while workers were left to suffer? Where was our bailout, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[53]`
Mówca: **Denis Stahler**
> ""Let's not forget your conspicuous absence at Bernard Circas' funeral. Your silence spoke volumes. Do you endorse the killing of those who stand up for workers' rights?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Katarina Horten**
> ""Is that so, Manger? All we've seen are decisions that favor the likes of you and Ewald Alphonso, not the common workers!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Denis Stahler**
> ""It's not about narratives, Mr. Manger. It's about ensuring a fair, dignified life for the working class. Something your policies have consistently failed to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[143]`
  - -> `[144]`
  - -> `[145]`

### Węzeł `[58]`
Mówca: **Gus Manger**
> ""Now, now, let's not get too heated. We all know change doesn't happen overnight. President Rayne is doing what he can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Denis Stahler**
> ""Time is a luxury we don't have, Mr. President. Each passing day is another day our workers suffer under the heel of inequality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[60]`
Mówca: **Katarina Horten**
> ""Oh, we've seen how much he can do, Manger. A lot for you, President Alphonso and Gasom, nothing for the workers!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Denis Stahler**
> ""Change might not happen overnight, Mr. Manger, but it should at least happen! What we've seen so far is the same old corporate favoritism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[145]`
  - -> `[146]`
  - -> `[147]`

### Węzeł `[62]`
Mówca: **Narrator**
> "Quiet murmurs of discontent began to ripple through the crowd. The workers' faces seemed to turn even stonier."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Narrator**
> "Despite the sharp words exchanged, the crowd remained eerily calm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Narrator**
> "I could feel the tension growing. The presence of our guards did little to reassure me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[65]`
Mówca: **Narrator**
> "It seemed like they were waiting, their collective breath held in anticipation of something more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[66]`
Mówca: **Katarina Horten**
> "“Your boost to the police force? A disaster! Inexperienced personnel are not only useless, they are dangerous. They're making the situation worse!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[67]`
Mówca: **Denis Stahler**
> ""You label peaceful protestors as traitors? These are ordinary citizens expressing their discontent, not some foreign enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The business bailout was a necessary step to protect the livelihoods of millions of Sords. It was not a decision made lightly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“My absence at Bernard Circas's funeral was not an endorsement of his murder. It was a time of mourning, and political statements were uncalled for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I have always valued the right to peaceful protest. Any assertion otherwise is a misunderstanding.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The discussions with Gasom are an ongoing process, and I am committed to finding the best possible outcome for the workers of Narbel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[72]`
Mówca: **Denis Stahler**
> ""And what about the recent campaign finance bill, Mr. President? It's a direct attack on democracy, effectively silencing smaller parties like ours!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[73]`
Mówca: **Katarina Horten**
> ""Mr. President, we demand that you support the upcoming Worker's Rights Bill. The labor force of Sordland will be watching your next move closely!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[95]`
  - -> `[96]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[97]`
  - -> `[98]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[99]`
  - -> `[100]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[101]`
  - -> `[102]`
  - -> `[466]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn01_CampaignFinance_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“As a result of our negotiations, Gasom has committed to improving the living conditions for its workers. This includes providing private housing and ensuring access to healthcare and education.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`
  - -> `[89]`
  - -> `[92]`
  - -> `[118]`

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Gasom has recognized the value of its blue-collar workers and agreed to increase their wages. These hardworking individuals are the backbone of their operations and deserve fair compensation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[93]`
  - -> `[119]`
  - -> `[464]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I am pleased to announce that Gasom will play a crucial role in the recovery of Narbel. They have pledged a significant contribution to local charities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[94]`
  - -> `[120]`
  - -> `[465]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I know it's hard to believe. But today was a victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“A wage increase is not a mere possibility, but a fact. This is a landmark moment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“With this contribution, Gasom is stepping up to play an essential part in the recovery and development of Narbel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“This is a vital step towards building a more resilient workforce.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“This is a substantial step towards ensuring well-being and prosperity for all workers, not just Gasom's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The worst-off will benefit under these new initiatives.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Our efforts have borne fruit. Gasom will now provide better housing, healthcare, and education for every worker.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`
  - -> `[89]`
  - -> `[92]`
  - -> `[118]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Through hard negotiations, we've secured a commitment from Gasom to significantly better the lives of its employees. Upgraded housing, assured healthcare, and opportunities for education are now guaranteed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`
  - -> `[89]`
  - -> `[92]`
  - -> `[118]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“After much deliberation, Gasom has agreed to increase the wages of the blue-collar workers on whose labor its success rests.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[93]`
  - -> `[119]`
  - -> `[464]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“In acknowledgment of their indispensable workforce, Gasom has decided to raise the wages of its blue-collar workers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[93]`
  - -> `[119]`
  - -> `[464]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I have exciting news: Gasom has promised a substantial contribution to local charities, a move that will play a central role in the recovery efforts for Narbel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[94]`
  - -> `[120]`
  - -> `[465]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Gasom's dedication to Narbel's recovery has been cemented with their promise of a large contribution to local charities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[94]`
  - -> `[120]`
  - -> `[465]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I must admit, we haven't been able to make as much progress with Gasom as we had hoped. But I remain committed to finding a solution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Rest assured, we are in continuous dialogue with Gasom. I remain steadfast in my pursuit of better conditions for Narbel's workers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I understand your frustration. Be assured, I will push harder in the negotiations. The well-being of Narbel's workers is my priority.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The journey may be challenging, but I remain dedicated. Our workers deserve better, and I won't rest until we achieve that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`
  - -> `[263]`
  - -> `[264]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`
  - -> `[267]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[269]`
  - -> `[270]`

### Węzeł `[113]`
Mówca: **Narrator**
> "A change came over the crowd. The angry shouts were replaced with cries of disbelief, then joy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[114]`
Mówca: **Narrator**
> "The air suddenly felt somewhat lighter. Murmurs of conversation started to percolate through the crowd, signs of animosity dwindling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[115]`
Mówca: **Narrator**
> "I could hear the crowd growing restless. They once again broke into discontented murmurs, punctuated by the occasional shout."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[116]`
Mówca: **Narrator**
> "The crowd roared back to life. I could practically feel the raw anger emanating from them. My guards took a step forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension += 2)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The effort of this government will go down in history.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We have all achieved a victory today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“This marks the beginning of a new era for the city.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_DonatedToFoundation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_DonatedToFoundation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_DonatedToFoundation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`
  - -> `[126]`
  - -> `[130]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_DonatedToFoundation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_DonatedToFoundation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I would like to announce that I've personally donated a portion of my salary to the Alphonso Foundation. It's a small step, but one that I believe can help those struggling with homelessness and income inequality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I have made the decision to donate part of my own income to the Alphonso Foundation. In a position of power, it's important to lead by example, isn't it? Together, we can make a difference.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“You'll be pleased to know that I've allocated a portion of my rather substantial salary to the Alphonso Foundation. It's the least I can do, considering my privileged position.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[127]`
Mówca: **Denis Stahler**
> ""At least you're not hiding your lack of progress anymore. Mere determination won't solve the workers' problems. We need results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[128]`
Mówca: **Katarina Horten**
> ""And until we get them, we will continue to fight!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[129]`
Mówca: **Narrator**
> "The undercurrent of unrest swelled, threatening to surge into a full-blown tempest. The previous calm seemed like a distant memory, an illusion shattered by the harsh reality of discontent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“What if I told you I decided to give away a fraction of my salary to the Alphonso Foundation? Would that make you happy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[131]`
Mówca: **Reporter**
> ""Mr. President, it's no secret that there was a significant divide during the party leadership campaign involving you and former President Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Nationalist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Socialist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[138]`
Mówca: **Narrator**
> "The sight of them transported me back to my days among the Young Sords, when face-offs with those clad in crimson were frequent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[139]`
Mówca: **Narrator**
> "The sight of them triggered nostalgia, memories of days filled with protests and camaraderie during our time at university."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[140]`
Mówca: **Narrator**
> "I saw a few officers with nervous faces, belying their inexperience. They stood at attention, visibly on edge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[141]`
Mówca: **Narrator**
> "Out of nowhere, a man lunged towards me from the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[142]`
Mówca: **Narrator**
> "The reporter jumped in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Denis, the focus here is not on narratives or images but on real, tangible changes. It's a process, and we are on the right track.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I understand your skepticism, Denis. But I assure you my administration is devoted to bringing about better conditions for our workers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“You're an academic and a lawyer, Mr. Stahler. What do you really know about the struggles of the working class?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“You're right, Denis. The days of corporate favoritism must come to an end. If not overnight, then soon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Change may not come as quickly as you want, Denis. But your claims of corporate favoritism don't reflect the complexity of the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[148]`
Mówca: **Denis Stahler**
> ""Words, words, and more words, President Rayne. What the workers need are actions, not promises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[149]`
Mówca: **Denis Stahler**
> ""Your words are compelling, President Rayne. But can they truly outweigh the years of corporate dominance?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[150]`
Mówca: **Denis Stahler**
> ""I know that they deserve better than a president who puts corporate interests over human well-being.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Change is often slow and gradual. Not all solutions are as immediate and straightforward as you make them out to be.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Denis Stahler**
> ""Your indifference is appalling, President Rayne! The working class can't afford the luxury of time you're so fond of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Katarina Horten**
> ""We have had it with excuses, President Rayne! The workers of Sordland need immediate solutions!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[155]`
Mówca: **Katarina Horten**
> ""Exactly, Denis. The working class of Sordland is still waiting for those actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[156]`
Mówca: **Katarina Horten**
> ""Your intentions sound noble, President Rayne. But intentions alone don't feed families or pay bills. We need concrete actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[157]`
Mówca: **Katarina Horten**
> ""Attacking Mr. Stahler's personal background accomplishes nothing, Mr. President. What do you have to say to the workers of this nation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[158]`
Mówca: **Denis Stahler**
> ""Then what just happened in that building, President Rayne? Did you advocate for Gasom's workers, or will its executives only be getting richer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[159]`
Mówca: **Denis Stahler**
> ""Finally, Rayne, you acknowledge the problem! But acknowledging is not enough. We need action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Katarina Horten**
> ""So, President Rayne agrees with Denis! But will this realization actually result in action?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[161]`
Mówca: **Katarina Horten**
> ""There are mothers in Narbel who cannot afford to feed their children. Where is the complexity in that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] <= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] <= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Education == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Education == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Education"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Education == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Education"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Health == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[177]`
Mówca: **Katarina Horten**
> ""It's clear from your lack of commitment to education that you don't fully comprehend the scope of the challenges faced by our workers' families.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[178]`
Mówca: **Denis Stahler**
> ""Your neglect of our nation's healthcare system will harm millions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == false && BaseGame.Promise_TermFocus_Education == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == false && BaseGame.Promise_TermFocus_Education == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == false  and  Variable["BaseGame.Promise_TermFocus_Education"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Health == false && BaseGame.Promise_TermFocus_Education == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == false  and  Variable["BaseGame.Promise_TermFocus_Education"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_Funeral_Attend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_Funeral_Attend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_Funeral_Attend"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_Funeral_Attend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_Funeral_Attend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[195]`
Mówca: **Denis Stahler**
> ""Furthermore, we want reform! Reduce the election threshold and change the constitution to make a more democratic and fairer nation!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[192]`
  - -> `[189]`
  - -> `[186]`
  - -> `[183]`
  - -> `[201]`
  - -> `[204]`
  - -> `[197]`
  - -> `[198]`
  - -> `[461]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The people of Sordland have elected me to lead. I believe it's crucial to trust the government's judgement in these times of crisis.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand the concerns and frustrations many of you have. Rest assured, we are here, we are listening, and we are committed to addressing these issues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We must recognize that our country can't solve all its problems at once. We are working hard and making progress, but our troubles won't simply vanish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The campaign finance bill ensures fair funding for democratically elected parties. It's not an attack on democracy but a measure to safeguard it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""While the increased police force may have its challenges, it's crucial for maintaining peace and order in our society. Their training and experience will improve over time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn01_CampaignFinance_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn01_CampaignFinance_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == false && BaseGame.Promise_TermFocus_Education == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Health == false && BaseGame.Promise_TermFocus_Education == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Health"] == false  and  Variable["BaseGame.Promise_TermFocus_Education"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Health == false && BaseGame.Promise_TermFocus_Education == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Health"] == false  and  Variable["BaseGame.Promise_TermFocus_Education"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""On healthcare and education, I hear your concerns. While these areas may not be our immediate focus, we are yet to finalize the government budget and are giving thoughtful consideration to those areas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Backstab == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Backstab == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Party_Takeover_Backstab == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[214]`
Mówca: **Narrator**
> "Suddenly, a reporter pushed through the crowd, brandishing a microphone towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Reporter**
> ""The locals of Narbel have suffered under the impact of Gasom for years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Reporter");)*
- **Efekt (`userScript`):** `AddConversant("Reporter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[217]`
Mówca: **Reporter**
> ""What concrete steps is Gasom going to take for the benefit of the local community?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_A_Protestors_Uproar = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn03_A_Protestors_Uproar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_A_Protestors_Mixed = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn03_A_Protestors_Mixed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_A_Protestors_Calm = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn03_A_Protestors_Calm"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[221]`
Mówca: **Narrator**
> "Katarina and Denis raised their hands in a plea for calm, their words nearly lost amidst the turmoil."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[227]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[228]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[234]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[235]`
Mówca: **Katarina Horten**
> ""Private housing, healthcare, and education? That's indeed a shift from the status quo, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Denis Stahler**
> ""If these promises materialize, it could mean a significant improvement in the lives of our comrades at Gasom. This is a start, albeit late. Let's hope it's not mere lip service.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[237]`
Mówca: **Katarina Horten**
> ""While I commend this commitment to improve the lives of our Gasom workers, we can only hope this is not just another political gambit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[238]`
Mówca: **Denis Stahler**
> ""So our blue-collar comrades are finally getting the attention they deserve, are they? I must admit, that's a step forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Katarina Horten**
> ""An increase in wages, finally! It's about time, Mr. President. While I appreciate this apparent commitment, let's not pat ourselves on the back just yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Denis Stahler**
> ""But let's not forget, President Rayne, that this is only correcting a long-standing injustice. We will wait and see if these are empty promises or if you truly intend to uphold the rights of our working class.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[241]`
Mówca: **Katarina Horten**
> ""Real success will be measured in the paychecks of the workers, not in words spoken here today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[242]`
Mówca: **Denis Stahler**
> ""Charitable contributions, Mr. President? Is that all Gasom can offer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Katarina Horten**
> ""What we need, Mr. President, is not a one-time act of charity, but a sustained commitment to improving the living conditions and wage disparity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Denis Stahler**
> ""While the effort is appreciated, these gestures do little to address the structural inequalities faced by the workers. We need systemic change, not charity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[245]`
Mówca: **Katarina Horten**
> ""Gasom's 'charity' must not be used as a smokescreen to cover their ongoing exploitation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[249]`
Mówca: **Katarina Horten**
> ""That's rich, Mr. President! Donating a fraction of your salary while our people continue to suffer. How generous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Denis Stahler**
> ""The Alphonso Foundation? More like the President's personal PR project. Let's not forget the true struggles of the Sordish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[252]`
Mówca: **Narrator**
> "The police began reorganizing their ranks, adopting defensive postures."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The past is the past. Personal disagreements have no place in matters of national importance. Our discussions were focused solely on what was best for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We did have our disagreements, but I won't allow personal matters to obstruct progress. We're both professional enough to separate politics from the welfare of the nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The rift between former President Alphonso and myself did present obstacles in the negotiations. His reluctance to find common ground was a hurdle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[256]`
Mówca: **Reporter**
> ""Could you shed some light on the possible deal between the Sordish government and Gasom?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[257]`
Mówca: **Reporter**
> ""Did this 'bad blood' influence your negotiations with Gasom?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`
  - -> `[255]`
  - -> `[258]`

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“No comment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[259]`
Mówca: **Gus Manger**
> "“To clarify, we tried our best to mediate and negotiate a best possible outcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[260]`
Mówca: **Narrator**
> "Gus stepped in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[261]`
Mówca: **Reporter**
> ""What role does the Kingdom of Rizia play in this arrangement?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[478]`
  - -> `[473]`

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""With all due respect to the Kingdom, I believe Sordland knows whats best for Sordish companies. That's why our government is investing in Gasom alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Our nation will shoulder the investment for Gasom. It's a bold step, but one that underscores our commitment to self-reliance and autonomy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The government of Sordland has decided to solely invest in Gasom. We believe this will lead to a direct positive impact on the citizens of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""In a show of international cooperation, Sordland and Rizia will jointly invest in Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We are sharing the costs and stakes with Rizia. This way, we're reducing financial pressure and fostering international relationships.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sordland is renewing its ties with the Kingdom of Rizia. Together, we will provide the funding that Gasom and its workers need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Our government has chosen not to invest at this time. We believe Rizia is capable of handling the investment, giving us the opportunity to focus our resources on other pressing issues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Rizia has invested in Sordland before, and they will do it once again. I have faith in the Kingdom and its vision for Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""At this time, we won't be investing in Gasom. This decision isn't made lightly, but we're confident Rizia can handle the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[271]`
Mówca: **Katarina Horten**
> ""Encouraging, President Rayne. As long as your government's drive to recoup your investment doesn't take precedent over Gasom's struggling labor force.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[272]`
Mówca: **Denis Stahler**
> ""A surprising but potentially promising decision, Mr. President. Let's hope your confidence isn't misplaced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[273]`
Mówca: **Katarina Horten**
> ""We will be watching this co-investment closely. Your government will be responsible for keeping its partner's worst tendencies in check.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[274]`
Mówca: **Denis Stahler**
> ""A partnership with Rizia? You are aware of the monarchy's history of stamping out disagreements with brute force.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[275]`
Mówca: **Katarina Horten**
> ""Relinquishing control to a monarchy!? You are aware of Rizia's history of stamping out disagreements with brute force.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[276]`
Mówca: **Denis Stahler**
> ""So, you're putting the fate of our workers in the King of Rizia's hands? That's a dangerous game you're playing, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 && BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 && BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] >= 5  and  Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 && BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] >= 5  and  Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You speak of double standards and yet fail to understand the complexities of governance! It's easy to criticize from the sidelines, but real change requires pragmatism, not idealism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You claim to advocate for the workers, yet undermine our efforts to better their condition. Shouldn't you be supporting the initiatives we've fought for, instead of spreading discontent?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The utopia you dream of won't materialize by mere rhetoric or by attacking those striving for change. It requires understanding the political and economic landscape and making informed decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's all remember that we're here for the same reason -- to better the lives of our citizens. Let's not allow our differences to blind us to our common goals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The path to progress is challenging and fraught with disagreement, but we must not let this divide us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand your frustrations and the urge to voice your concerns. However, let's keep our discourse respectful and constructive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`
  - -> `[351]`
  - -> `[285]`
  - -> `[286]`
  - -> `[364]`

### Węzeł `[288]`
Mówca: **Serge Wolkner**
> ""I recommend that we expedite your departure. We must prioritize your safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`
  - -> `[314]`

### Węzeł `[289]`
Mówca: **Serge Wolkner**
> ""It might be a good time to make our way to the convoy, before any potential escalation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[312]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension >= 3 && (BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true || BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension >= 3 && (BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true || BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == false))*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] >= 3  and  (Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true  or  Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_AddressProtestors_Tension >= 3 && (BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true || BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == false)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] >= 3  and  (Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true  or  Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[293]`
Mówca: **Serge Wolkner**
> ""It may be best to conclude your address and proceed to the vehicle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[294]`
Mówca: **Narrator**
> "Close by, I noticed a terse exchange between a security officer from Gasom and a member of the Presidential Guard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[295]`
Mówca: **Narrator**
> "Serge craned his neck, his face deep in concentration as he listened to their whispers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[296]`
Mówca: **Narrator**
> "Nearby, a quick, hushed conversation was being had between a Gasom security officer and a Presidential Guard. I followed their eyes to the protestors. Some had calmed down; others still seemed agitated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Narrator**
> "Serge craned his neck, his face deep in concentration as he listened to their whispers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[298]`
Mówca: **Narrator**
> "Nearby, a Gasom security officer and a Presidential Guard member were conversing in hushed tones."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[299]`
Mówca: **Narrator**
> "I saw them glance over the crowd, now calmer but still restless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[300]`
Mówca: **Gus Manger**
> ""I'll stay back and handle things here. You should head to safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[301]`
Mówca: **Gus Manger**
> ""Mr. President, I'll stay on to further address the crowd. The mood is still tense, but I think I can manage. You should get on your way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[302]`
Mówca: **Gus Manger**
> ""I'll remain here, Mr. President. The crowd seems calmer now, and I believe I can answer their queries and maintain the peace. You should go ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[303]`
Mówca: **Katarina Horten**
> ""You can't even face your own people, can you, Mr. President? We expected better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[283]`
  - -> `[284]`
  - -> `[325]`

### Węzeł `[304]`
Mówca: **Denis Stahler**
> ""Leaving so soon, Rayne? I guess you know when you've been defeated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[305]`
Mówca: **Katarina Horten**
> ""We will hold you accountable to your promises. The troubles of the laborers continue and our union is here to solve them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[306]`
Mówca: **Denis Stahler**
> ""I'm impressed you even came out to speak to us, President Rayne. Most wouldn't. However, this conversation isn't over yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[307]`
Mówca: **Katarina Horten**
> ""Mr. President, thank you for your willingness to address us. Let's continue these important conversations moving forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[308]`
Mówca: **Denis Stahler**
> ""You've shown courage today. We'll see if your actions match your words. Until next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you for looking out for me, Serge. Let's get out of here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you sure? Won't running away from this only make the protestors angrier?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I agree, Serge. Tensions can rise quickly in such environments. It's better we make our exit now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you sure? Won't running away from this only make the protestors angrier?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're absolutely right, Serge. Let's not stay here any longer than necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you sure? Won't running away from this only make the protestors angrier?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[315]`
Mówca: **Serge Wolkner**
> ""Mr. President, the situation is growing increasingly volatile.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[316]`
Mówca: **Serge Wolkner**
> ""Sir, the crowd is no longer entirely hostile, but there's still an undercurrent of tension.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[317]`
Mówca: **Serge Wolkner**
> ""President Rayne, while the crowd appears somewhat subdued, I would advise we exercise caution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[318]`
Mówca: **Reporter**
> ""Can you clarify the current status of your personal relationship with Ewa-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[319]`
Mówca: **Reporter**
> ""One final question, what is your true personal relationship with Ew-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[320]`
**[WYBÓR GRACZA: "Shake their hands."]** — Mówca: **Player_Italic**
> "I reached out my hand, and Katarina shook it with a smile. Denis followed suit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] <= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_AddressProtestors_Tension <= 3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] <= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[324]`
**[WYBÓR GRACZA: "Shake their hands."]** — Mówca: **Player_Italic**
> "I reached out my hand, and Katarina reluctantly shook it. Denis followed suit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No further comments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_A_Protestors_Mixed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`
  - -> `[328]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_A_Protestors_Mixed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_A_Protestors_Mixed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_A_Protestors_Mixed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_A_Protestors_Mixed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[329]`
Mówca: **Narrator**
> "Serge left my dazed attacker on the ground and turned to the guards with a look of authority I'd never seen before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[330]`
Mówca: **Narrator**
> "His voice carried over the screams of the crowd. The guards tightened their circle around me, hurriedly pushing me towards the safety of the convoy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[331]`
Mówca: **Narrator**
> "Police and security forces rushed into the melee, swinging batons with indiscriminate ferocity. The Red Youth rushed at them head-on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[332]`
Mówca: **Katarina Horten**
> ""Stop the cops! This isn't going to help!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[333]`
Mówca: **Denis Stahler**
> ""Everyone, remain calm!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[334]`
Mówca: **Narrator**
> "Their screams receded into the background as we left the chaotic scene behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Give him hell, Serge!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's get out of here!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Everyone calm down!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[338]`
Mówca: **Gus Manger**
> ""Back off! You're only making things worse!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[339]`
Mówca: **Narrator**
> "The staff and I were swiftly escorted into the convoy. The protestors and police scattered as our vehicles plowed through the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[340]`
Mówca: **Serge Wolkner**
> ""Into the car, Mr. President! We are leaving NOW!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[341]`
Mówca: **Narrator**
> "Before I could react, Serge sprang in front of me. He swiftly tackled the man to the ground and pinned his hands behind his back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`
  - -> `[336]`
  - -> `[337]`
  - -> `[342]`

### Węzeł `[342]`
**[WYBÓR GRACZA: "Freeze in panic."]** — Mówca: **Player_Italic**
> "I froze in panic."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[343]`
Mówca: **Narrator**
> "The nervous officers I'd seen before now looked completely overwhelmed. They lashed out left and right, hitting protestors, Red Youth members and their own colleagues alike."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thanks to both of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[345]`
Mówca: **Serge Wolkner**
> ""No more questions, please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[346]`
Mówca: **Serge Wolkner**
> ""Mr. President, if you could please proceed to the vehicle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[347]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, the dialogue has only started. I assure you both, my commitment to progress and change is unwavering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`
  - -> `[351]`
  - -> `[285]`
  - -> `[286]`
  - -> `[364]`

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Indeed, accountability is the cornerstone of democracy. As your president, I understand that responsibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`
  - -> `[351]`
  - -> `[285]`
  - -> `[286]`
  - -> `[364]`

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Most wouldn't come out because most fear facing the truth. As for the conversation, it's always been going on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`
  - -> `[351]`
  - -> `[285]`
  - -> `[286]`
  - -> `[364]`

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My job is to listen and act. As for accountability, isn't that what all governments should be held to? You have my word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`
  - -> `[351]`
  - -> `[285]`
  - -> `[286]`
  - -> `[364]`

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Denis, Katarina, I look forward to our continuing conversations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is a marathon, not a sprint.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Socialist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As an old Red Youth member, I can personally say that the work you do is of utmost importance. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[357]`
Mówca: **Narrator**
> "Almost immediately, the remaining tension in the crowd dissipated. A few workers nearby broke into scattered applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[358]`
Mówca: **Narrator**
> "A flutter of whispers rippled through the sea of onlookers, their eyes darting back and forth between us in surprise. A few broke into scattered applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[359]`
Mówca: **Narrator**
> "Their collective gaze bore into me, awaiting my words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`
  - -> `[348]`
  - -> `[349]`
  - -> `[287]`

### Węzeł `[360]`
Mówca: **Narrator**
> "I turned to the crowd one last time. In their eyes, I saw both flashes of anger and glimmers of hope."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[361]`
Mówca: **Katarina Horten**
> ""We have shown courage together. Now we will hold you accountable to your promises. The troubles of the laborers are not over, and neither is the work of our union.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[344]`
  - -> `[353]`

### Węzeł `[362]`
Mówca: **Narrator**
> "As I readied myself to leave, I turned back to Katarina and Denis a last time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`
  - -> `[349]`
  - -> `[350]`
  - -> `[287]`

### Węzeł `[363]`
Mówca: **Narrator**
> "The initially hesitant clapping grew louder, and jubilant cheers and whistles filled the air. I saw the Red Youth members standing at the edge of the crowd with their arms folded, a hint of approval in their eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[364]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Together, we can ensure a prosperous future for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[365]`
Mówca: **Narrator**
> "Serge opened the door of the car and I lowered myself into the seat. The door closed behind me with a thud, sealing off the external noise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[366]`
Mówca: **Narrator**
> "The crowd began to disperse, the individuals breaking away to let our convoy through. The guards took their position nonetheless, forming a human barrier around the vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[367]`
Mówca: **Narrator**
> "The engine purred to life, and we began to move."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_Friend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_Friend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Serge_Friend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Serge_Friend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Serge_Friend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Serge Wolkner**
> ""I had no doubt about your capability to handle this, President Rayne. Still, I was worried for your safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[380]`
  - -> `[381]`
  - -> `[384]`

### Węzeł `[372]`
Mówca: **Serge Wolkner**
> ""I'm glad we are safely on our way, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`
  - -> `[384]`
  - -> `[382]`
  - -> `[383]`

### Węzeł `[373]`
Mówca: **Narrator**
> "As we started moving, some disgruntled protestors rushed towards us. I could hear shouts and jeers as their fists pounded against the glass windows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[374]`
Mówca: **Narrator**
> "The guards sprang into action, pushing back the unruly crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[375]`
Mówca: **Narrator**
> "It was a tense few moments before the convoy was able to navigate away from the tumult."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[378]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thanks for your concern, Serge. It was tense, but knowing you and the team were there made all the difference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Serge, in this role, danger comes with the territory. But your concern is appreciated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[381]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't forget, a President has to face these situations head-on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Serge. I don't know what I'd do without you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Agreed, Serge. A job well done by you and the team.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A little excitement to keep us on our toes, wasn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[385]`
Mówca: **Serge Wolkner**
> ""We're here to serve and protect, Mr. President. It's a duty we don't take lightly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[386]`
Mówca: **Serge Wolkner**
> ""It's not just part of the job, sir. It's a matter of personal commitment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[387]`
Mówca: **Serge Wolkner**
> ""You're right, sir. It's part of the job, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[388]`
Mówca: **Serge Wolkner**
> ""I'm merely doing my job, Mr. President. Ensuring your safety is my top priority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[389]`
Mówca: **Serge Wolkner**
> ""We appreciate your acknowledgement, Mr. President. It's our duty and honor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[390]`
Mówca: **Serge Wolkner**
> ""That's one way to look at it, Mr. President. Keeps the job interesting, to say the least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[391]`
Mówca: **Narrator**
> "The echoing voices of the protesters gradually subsided as we retreated from the scene and left Narbel behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Reporter");)*
- **Efekt (`userScript`):** `RemoveConversant("Reporter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Gus Manger");)*
- **Efekt (`userScript`):** `RemoveConversant("Gus Manger");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Katarina Horten");)*
- **Efekt (`userScript`):** `RemoveConversant("Katarina Horten");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Denis Stahler");)*
- **Efekt (`userScript`):** `RemoveConversant("Denis Stahler");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Reporter");)*
- **Efekt (`userScript`):** `RemoveConversant("Reporter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Gus Manger");)*
- **Efekt (`userScript`):** `RemoveConversant("Gus Manger");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Katarina Horten");)*
- **Efekt (`userScript`):** `RemoveConversant("Katarina Horten");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[399]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Denis Stahler");)*
- **Efekt (`userScript`):** `RemoveConversant("Denis Stahler");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayMusic("Reform");)*
- **Efekt (`userScript`):** `PlayMusic("Reform");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayCustomMapMusic("Map_Music_Tense");)*
- **Efekt (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[402]`
Mówca: **Narrator**
> "Eventually, all fell silent as they waited for Denis and Katarina to respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[403]`
Mówca: **Gus Manger**
> ""Serge is right, Mr. President. The crowd won't get any calmer if you stick around. You've got to get to safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[404]`
Mówca: **Serge Wolkner**
> "<shout>""PROTECT THE PRESIDENT!"</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayMusic("Suspense");)*
- **Efekt (`userScript`):** `PlayMusic("Suspense");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`
  - -> `[408]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Country_Unrest += 1;
BaseGame.Public_Opinion -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Country_Unrest"] = Variable["BaseGame.Country_Unrest"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`
  - -> `[413]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`
  - -> `[417]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 2;
BaseGame.Country_Unrest -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;
Variable["BaseGame.Country_Unrest"] = Variable["BaseGame.Country_Unrest"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[419]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`
  - -> `[423]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[423]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[424]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`
  - -> `[426]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`
  - -> `[429]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[430]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Workers_GasomExpandsCare = true;
BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinCare = true;
BaseGameSupport.News_Turn03_R_Workers_LUSCPSVictory = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Workers_GasomExpandsCare"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinCare"] = true;
Variable["BaseGameSupport.News_Turn03_R_Workers_LUSCPSVictory"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Workers_GasomIncreasesSalaries = true;
BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinSalaries = true;
BaseGameSupport.News_Turn03_R_Workers_LUSCPSDisappointed = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Workers_GasomIncreasesSalaries"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinSalaries"] = true;
Variable["BaseGameSupport.News_Turn03_R_Workers_LUSCPSDisappointed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[432]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Workers_GasomGivesCharity = true;
BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinDonations = true;
BaseGameSupport.News_Turn03_R_Workers_LUSCPSCondemn = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Workers_GasomGivesCharity"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinDonations"] = true;
Variable["BaseGameSupport.News_Turn03_R_Workers_LUSCPSCondemn"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[433]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_LT_Workers_LUSCPSLose = true;
BaseGameSupport.News_Turn03_R_Workers_LUSCPSInaction = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_Workers_LUSCPSLose"] = true;
Variable["BaseGameSupport.News_Turn03_R_Workers_LUSCPSInaction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[434]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_A_Protestors_Uproar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`
  - -> `[436]`

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_A_Protestors_Uproar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_A_Protestors_Uproar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_A_Protestors_Uproar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_A_Protestors_Uproar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_A_Protestors_Mixed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`
  - -> `[439]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_A_Protestors_Mixed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_A_Protestors_Mixed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[439]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_A_Protestors_Mixed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_A_Protestors_Mixed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[440]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`
  - -> `[442]`

### Węzeł `[441]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_R_Address_PresidentAssaulted = true;
BaseGameSupport.News_Turn03_LT_Address_LungedAtPresident = true;
BaseGameSupport.News_Turn03_HP_Address_MalenyevistRYRebels = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_R_Address_PresidentAssaulted"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Address_LungedAtPresident"] = true;
Variable["BaseGameSupport.News_Turn03_HP_Address_MalenyevistRYRebels"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Address_CrowdHassle = true;
BaseGameSupport.News_Turn03_LT_Address_DramaticScenesUnfold = true;
BaseGameSupport.News_Turn03_R_Address_OkaySpeechByPresident = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Address_CrowdHassle"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Address_DramaticScenesUnfold"] = true;
Variable["BaseGameSupport.News_Turn03_R_Address_OkaySpeechByPresident"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_LT_Address_PositiveCrowd = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_Address_PositiveCrowd"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[446]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_Address_AmazingSpeech = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Address_AmazingSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[447]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_Address_BadSpeech = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Address_BadSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`
  - -> `[450]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_Address_PresidentListens = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Address_PresidentListens"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[452]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_ST_Address_PresidentDeaf = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_Address_PresidentDeaf"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[453]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Before any of you do anything too rash, I want you to take a good look around you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`
  - -> `[455]`
  - -> `[457]`

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You are surrounded by police and armed guards. Realistically, what do you hope to accomplish here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You cannot rise up against the President of Sordland without facing consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We are all brothers and sisters in the struggle against greed and exploitation. We must not let ourselves become divided.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[458]`
Mówca: **Denis Stahler**
> ""You're going to jump directly to threatening us, President Rayne? Whatever happened to the right to peaceful protest?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[459]`
Mówca: **Katarina Horten**
> "“This only proves that we are right to stand here today. We will not budge until you commit to real change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[460]`
Mówca: **Denis Stahler**
> ""Divided? You're the one walking out of Gasom headquarters surrounded by armed guards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[461]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""How dare you speak that way to your president! You ingrates have no idea how much I have sacrificed for this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[462]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension += 3)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[463]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“See, Mr. Stahler and Ms. Horten? I'm on your side. You can stop whining now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[464]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“See, Mr. Stahler and Ms. Horten? I'm on your side. You can stop whining now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[465]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“See, Mr. Stahler and Ms. Horten? I'm on your side. You can stop whining now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[466]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I'm not going to dignify that with a response. Gasom has done so much for this shithole region, and this is how you people repay it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`
  - -> `[468]`
  - -> `[469]`

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, these workers are lucky to even have jobs. They shouldn't get greedy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm warning you all. Back off now, or there *will* be consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why don't you talk to an actual Gasom employee, Madam Reporter? They'll tell you how grateful they are to work for the best company in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[470]`
Mówca: **Denis Stahler**
> ""Your arrogance is unbelievable, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension += 3)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[472]`
Mówca: **Katarina Horten**
> ""Clearly, we are past the time for reasonable discussion. We must fight for what we believe in!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[473]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 && BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`
  - -> `[475]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 && BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] >= 5  and  Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn03_AddressProtestors_Tension >= 5 && BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] >= 5  and  Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[476]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What the hell are you still doing here, lady? Can't you see it's about to get ugly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[477]`
Mówca: **Denis Stahler**
> ""The sight of the common people speaking truth to power is anything but 'ugly', Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[478]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's confidential, ma'am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn03_AddressProtestors_Tension += 1)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] = Variable["BaseGameIsolated.Turn03_AddressProtestors_Tension"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[480]`
Mówca: **Katarina Horten**
> ""I see. The President won't divulge any information about his closed-door dealings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[481]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Addressing a crowd of displeased workers and unionists", "Gates of Gasom Branch", "Narbel");)*
- **Efekt (`userScript`):** `SetRichPresence("Addressing a crowd of displeased workers and unionists","Gates of Gasom Branch","Narbel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[482]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Escaping from an aggressive crowd of riled-up workers and unionists", "Gates of Gasom Branch", "Narbel");)*
- **Efekt (`userScript`):** `SetRichPresence("Escaping from an aggressive crowd of riled-up workers and unionists","Gates of Gasom Branch","Narbel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Calming down a displeased crowd of workers and unionists", "Gates of Gasom Branch", "Narbel");)*
- **Efekt (`userScript`):** `SetRichPresence("Calming down a displeased crowd of workers and unionists","Gates of Gasom Branch","Narbel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`
