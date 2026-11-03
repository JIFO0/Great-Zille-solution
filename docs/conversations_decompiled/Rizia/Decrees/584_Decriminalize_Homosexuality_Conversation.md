# Rizia/Decriminalize Homosexuality/Decriminalize Homosexuality Conversation

- **ID konwersacji:** `584`
- **StoryPack:** `Rizia`
- **Tura:** `Decree (Decriminalize Homosexuality)`
- **Lokalizacja pliku:** `Rizia/Decrees/584_Decriminalize_Homosexuality_Conversation.md`
- **Liczba węzłów dialogowych:** 155
- **Liczba wyborów gracza:** 32

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.CountryRelation_Derdia_Allied`
- `RiziaDLC.Country_HouseAzaro_Enemy`
- `RiziaDLC.Country_HouseToras_Friendly`
- `RiziaDLC.Country_PublicOpinion`
- `RiziaDLC.Pabel_Gone`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PersonalValue_BrokeTradition`
- `RiziaDLC.Policy_RD_Religion_RemoveStateReligion`
- `RiziaDLC.Reform_DeclareIntention_Public`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Pabel_OutedToPlayer`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_AuthorityModifiersTotal`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied`
- `RiziaDLC.Situation_Welfare_LivingStandards_Bad`
- `RiziaDLC.Situation_Welfare_LivingStandards_Horrible`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_MarriageDecision_Rico`
- `RiziaDLCSetup.CurrentTurn`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Hugo_CounselIgnored`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[356] Rizia/CouncilRoyalDecrees** (../Decrees/356_CouncilRoyalDecrees.md), Węzeł `[69]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 2

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[113]` (Paskal Beniwoll): `EnactDecree("Welfare_HumanRights_DecriminalizeHomosexuality"); ;`
- Węzeł `[154]` (Paskal Beniwoll): `Variable["RiziaDLC.Hugo_CounselIgnored"] = Variable["RiziaDLC.Hugo_CounselIgnored"] + 1;`

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
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `356` (*Rizia/CouncilRoyalDecrees*), Węzeł `[69]`

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""Your Majesty. I know I'm old and stuck in my ways. But trust me when I tell you this decree is a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Hugo Toras**
> ""You've already dismantled our state religion. Now you want to take an axe to the laws of Nur and nature?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[10]`
  - -> `[30]`
  - -> `[84]`

### Węzeł `[8]`
Mówca: **Hugo Toras**
> ""It is firmly enshrined in our state religion that same-sex relations are in defiance of the laws of both Nur and nature.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[10]`
  - -> `[28]`
  - -> `[30]`
  - -> `[84]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Homosexuals aren't freaks. They're people like you and me. Perhaps they're even living right under your nose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[13]`
Mówca: **Narrator**
> "His eyes narrowed in suspicion. He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Hugo Toras**
> ""Be that as it may, the majority of Rizians do not want this law to change. They wish to see our traditional values preserved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[16]`
  - -> `[20]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look at my reign so far, Hugo. Am I a king who gives a damn about tradition?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_BrokeTradition > 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_BrokeTradition > 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_BrokeTradition"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_BrokeTradition > 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_BrokeTradition"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tradition is important to me as well. But not when maintaining it leads to people suffering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't understand. It's not as if I'm proposing a ban on heterosexuality. This decree will help thousands while hurting no one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""It will hurt you, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""*If* Nur exists, He would want His creations to practice love and tolerance, not hate and bigotry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Nur I worship smiles upon all forms of love. He would not want His creations to practice hate and bigotry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Narrator**
> "Hugo shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Homosexuals are deviants, yes. But they deserve re-education, not prison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Narrator**
> "Hugo shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Innocent people are dying because of this law. It's my moral imperative to get rid of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Hugo Toras**
> ""The Montalvo affair... yes, tragic. I read about it as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Hugo Toras**
> ""But the man was killed by a rogue prison guard. Not our laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[33]`
Mówca: **Hugo Toras**
> ""Watch your words, my nephew. The majority of Rizians wish to preserve our traditional values. Does that make them hateful or bigoted?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`
  - -> `[37]`
  - -> `[43]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It does. They must fix their hearts or die.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It makes them misguided. Over time, they'll come to accept homosexuality, just as Queen Lyza led them to accept women in the workforce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They don't really believe that homosexuality is a sin. They've been brainwashed by the Sanctuary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[40]`
Mówca: **Hugo Toras**
> ""The majority of Rizians want the law to stay as it is. Not out of a desire to punish homosexuals, but because they wish to preserve our traditional values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[16]`
  - -> `[20]`

### Węzeł `[41]`
Mówca: **Hugo Toras**
> ""No, and your authority as monarch has suffered for it. There is a limit to the amount of radical change our kingdom will tolerate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[42]`
Mówca: **Hugo Toras**
> ""This is not only about what the Royal Houses will think. Your authority as monarch is at stake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you sure that's what they want? What if they've just been afraid to speak out for all this time?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[44]`
Mówca: **Hugo Toras**
> ""And how long will they tolerate being ruled by a King who views them that way?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[45]`
Mówca: **Hugo Toras**
> ""Your grandmother was a great reformer. But even she would not go this far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[46]`
Mówca: **Hugo Toras**
> ""And how long will they tolerate being ruled by a King who sees their cherished religion as 'brainwashing'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[47]`
Mówca: **Hugo Toras**
> ""The repercussions of disregarding it will be even worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want homosexuals in our kingdom to live without fear of oppression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[49]`
Mówca: **Hugo Toras**
> ""Your authority as monarch is slipping. You're losing the people's respect -- and once that's lost, so is your power over them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_AuthorityModifiersTotal <= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_AuthorityModifiersTotal <= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_AuthorityModifiersTotal"] <= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_AuthorityModifiersTotal <= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_AuthorityModifiersTotal"] <= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""Despite your efforts, your subjects hold fast to their faith. Some may tolerate homosexuality. But nobody is clamoring for its legalization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Hugo Toras**
> ""Most of your subjects are Wruhecists who hold fast to their faith. Some may tolerate homosexuality. But nobody is clamoring for its legalization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Hugo Toras**
> ""Except Golcondists, of course. But you shouldn't betray the tenets of Wruhecism on *their* behalf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_OutedToPlayer == true && RiziaDLC.Relations_Pabel > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_OutedToPlayer == true && RiziaDLC.Relations_Pabel > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_OutedToPlayer == true && RiziaDLC.Relations_Pabel > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have... close friends in the homosexual community. I want them to live without fear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want to build a more enlightened and just society. If even one Rizian goes to jail simply for loving the wrong person, I have failed at that goal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's all part of my geopolitical strategy. I'm looking to improve relations with Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Derdia_Allied == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Derdia_Allied == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Derdia_Allied"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.CountryRelation_Derdia_Allied == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Derdia_Allied"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""So you would throw away your other priorities as king to make your 'friends' happy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""So you would throw away your other priorities as king to appease a small minority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[70]`
Mówca: **Hugo Toras**
> ""You cannot enlighten society with the stroke of a pen, Romus. They will resist your attempt to force progressivism on them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[71]`
Mówca: **Hugo Toras**
> ""This is your decision to make. But I warn you that legalizing homosexuality will not calm the unrest on the streets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[131]`
  - -> `[126]`
  - -> `[134]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't need to justify my decision to you. My mind is made up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[73]`
Mówca: **Hugo Toras**
> ""I understand the importance of diplomacy, Your Majesty, but it shouldn't come at the cost of upending society in one's own country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[77]`
Mówca: **Hugo Toras**
> ""You must take care, Your Majesty. It's not only the Royal Houses who will disapprove of this move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_AuthorityModifiersTotal <= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_AuthorityModifiersTotal <= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_AuthorityModifiersTotal"] <= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_AuthorityModifiersTotal <= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_AuthorityModifiersTotal"] <= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[81]`
Mówca: **Hugo Toras**
> ""You must be more careful, Your Majesty. Your authority as monarch is already slipping.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Hugo Toras**
> ""Let me ask you this. What exactly are you trying to accomplish by signing this decree?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[59]`
  - -> `[63]`
  - -> `[65]`
  - -> `[83]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Persecuting homosexuals isn't just morally wrong, it's bad for our global image. I'm trying to bring our values in line with those of the rest of the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == false && (RiziaDLC.Rico_Arrested == true || RiziaDLCSetup.CurrentTurn > 7))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Rico == false && (RiziaDLC.Rico_Arrested == true || RiziaDLCSetup.CurrentTurn > 7))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == false  and  (Variable["RiziaDLC.Rico_Arrested"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] > 7)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Rico == false && (RiziaDLC.Rico_Arrested == true || RiziaDLCSetup.CurrentTurn > 7)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == false  and  (Variable["RiziaDLC.Rico_Arrested"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] > 7)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's rich, coming from someone who wanted my daughter to enter into an incestuous marriage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Hugo Toras**
> ""Whether or not you personally approve of it, marriage between cousins is a well-established royal tradition. And one that has no impact on the larger populace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Hugo Toras**
> ""Most Rizians wouldn't bat an eye if Her Highness married Rico. But if their children saw their two male neighbors holding hands in public, they'd perceive it as an attack on their values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[96]`
  - -> `[93]`
  - -> `[91]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's rich, coming from someone who wants my daughter to enter into an incestuous marriage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you don't think that's a problem?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, because the Sanctuary has brainwashed them into feeling that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't know that. Maybe Rizians are more supportive of homosexuality than you think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[97]`
Mówca: **Hugo Toras**
> ""And by 'the rest of the world', you mean ATO.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Narrator**
> "He folded his arms with a frown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Hugo Toras**
> ""It isn't enough for Arcasia and its cronies to undermine the world's last existing monarchies. They must claim they're doing so out of moral superiority...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_DeclareIntention_Public == true && RiziaDLC.Reform_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_DeclareIntention_Public == true && RiziaDLC.Reform_Path == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true  and  Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_DeclareIntention_Public == true && RiziaDLC.Reform_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true  and  Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[103]`
Mówca: **Hugo Toras**
> ""This is your decision to make. But if you're trying to unite the kingdom behind your reforms, I'd advise you to steer clear of such a divisive act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[131]`
  - -> `[126]`
  - -> `[134]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[110]`
Mówca: **Hugo Toras**
> ""This is your decision to make. But I warn you that passing such a frivolous act in the midst of a war will win you no favors. With House Toras or anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[131]`
  - -> `[126]`
  - -> `[134]`

### Węzeł `[111]`
Mówca: **Hugo Toras**
> ""This is your decision to make. But I warn you that passing such a frivolous act while ordinary citizens go hungry will win you no favors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[131]`
  - -> `[126]`
  - -> `[134]`

### Węzeł `[112]`
Mówca: **Narrator**
> "He bowed and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnactDecree("Welfare_HumanRights_DecriminalizeHomosexuality");)*
- **Efekt (`userScript`):** `EnactDecree("Welfare_HumanRights_DecriminalizeHomosexuality");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[114]`
**[WYBÓR GRACZA: "Sign the decree."]** — Mówca: **Player_Romus_Italic**
> "I signed the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[115]`
Mówca: **Narrator**
> "Hugo lifted it off the table by its corner, as if the paper itself were poisonous."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Hugo Toras**
> ""I'll see to it that this gets enacted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have it your way, Your Grace. The law shall stay as it is for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Hugo Toras**
> ""From the bottom of my heart, I thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Narrator**
> "He lifted the unsigned decree by its corner, as if the paper itself were poisonous."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[120]`
Mówca: **Hugo Toras**
> ""I am merely telling you how it is. If you believe your subjects will support you in this, you are mistaken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[121]`
Mówca: **Narrator**
> "My uncle sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not frivolous to me. You're on the wrong side of history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's nothing 'divisive' about it to me. You're on the wrong side of history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That doesn't matter. History will vindicate me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[125]`
Mówca: **Hugo Toras**
> ""So be it, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You wouldn't think that way if you were homosexual yourself. Can't you empathize with them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Pabel_Gone == true && RiziaDLC.Vina_Escapes == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Pabel_Gone == true && RiziaDLC.Vina_Escapes == false))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true  or  (Variable["RiziaDLC.Pabel_Gone"] == true  and  Variable["RiziaDLC.Vina_Escapes"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Pabel_Gone == true && RiziaDLC.Vina_Escapes == false)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true  or  (Variable["RiziaDLC.Pabel_Gone"] == true  and  Variable["RiziaDLC.Vina_Escapes"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[130]`
Mówca: **Narrator**
> "He shot me a sharp glance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know I'm taking a risk. But nothing is more important to me than achieving equal rights for all citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[132]`
Mówca: **Hugo Toras**
> ""This is your decision to make. But I advise you to think carefully about whether your reign can weather the repercussions of such an act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[126]`
  - -> `[148]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Hugo Toras**
> ""If I were unfortunate enough to be burdened with such desires, I would have the good sense to keep them to myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've made your point, Hugo. I need to think about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Hugo Toras**
> ""Take all the time you need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[117]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Pabel_Gone == true && RiziaDLC.Vina_Escapes == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Pabel_Gone == true && RiziaDLC.Vina_Escapes == false))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true  or  (Variable["RiziaDLC.Pabel_Gone"] == true  and  Variable["RiziaDLC.Vina_Escapes"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Pabel_Gone == true && RiziaDLC.Vina_Escapes == false)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true  or  (Variable["RiziaDLC.Pabel_Gone"] == true  and  Variable["RiziaDLC.Vina_Escapes"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[139]`
Mówca: **Narrator**
> "He shot me a sharp glance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Hugo Toras**
> ""You care about this topic more than I realized, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[141]`
Mówca: **Hugo Toras**
> ""I had no idea this topic meant so much to you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Narrator**
> "His response came almost instantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 7 && (RiziaDLC.Country_HouseToras_Friendly == true && RiziaDLC.Country_HouseAzaro_Enemy == false) && RiziaDLC.Country_PublicOpinion > 2 && RiziaDLC.Situation_Order_Unrest_NationalDestabilization == false && RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 7 && (RiziaDLC.Country_HouseToras_Friendly == true && RiziaDLC.Country_HouseAzaro_Enemy == false) && RiziaDLC.Country_PublicOpinion > 2 && RiziaDLC.Situation_Order_Unrest_NationalDestabilization == false && RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 7  and  (Variable["RiziaDLC.Country_HouseToras_Friendly"] == true  and  Variable["RiziaDLC.Country_HouseAzaro_Enemy"] == false)  and  Variable["RiziaDLC.Country_PublicOpinion"] > 2  and  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == false  and  Variable["RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Authority >= 7 && (RiziaDLC.Country_HouseToras_Friendly == true && RiziaDLC.Country_HouseAzaro_Enemy == false) && RiziaDLC.Country_PublicOpinion > 2 && RiziaDLC.Situation_Order_Unrest_NationalDestabilization == false && RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 7  and  (Variable["RiziaDLC.Country_HouseToras_Friendly"] == true  and  Variable["RiziaDLC.Country_HouseAzaro_Enemy"] == false)  and  Variable["RiziaDLC.Country_PublicOpinion"] > 2  and  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == false  and  Variable["RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Hugo Toras**
> ""I'll be honest. If ever there were a time to pass this decree, it would be now, while you're still in good standing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[147]`
Mówca: **Hugo Toras**
> ""I will be honest. Decriminalizing homosexuality may be seen as 'progress' in foreign circles. But here in Rizia, it will damage your standing beyond repair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're my Grand Vizier. What do you think the repercussions will be?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[149]`
Mówca: **Hugo Toras**
> ""But as a practicing Wruhecist and a member of House Toras, I cannot and will not endorse it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[150]`
Mówca: **Hugo Toras**
> ""And if passing it leads to your downfall, whoever leads Rizia in your stead will surely reverse it. Leaving homosexuals no better off than before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Hugo Toras**
> ""So please, think carefully. Is this truly what you want for the kingdom?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[117]`

### Węzeł `[152]`
Mówca: **Narrator**
> "I took one more look at the document in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[117]`

### Węzeł `[153]`
Mówca: **Hugo Toras**
> ""I'll file this away safely for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Hugo_CounselIgnored += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Hugo_CounselIgnored"] = Variable["RiziaDLC.Hugo_CounselIgnored"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
