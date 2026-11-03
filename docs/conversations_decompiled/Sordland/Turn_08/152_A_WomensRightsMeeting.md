# Sordland/Turn08/A_WomensRightsMeeting

- **ID konwersacji:** `152`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/152_A_WomensRightsMeeting.md`
- **Liczba węzłów dialogowych:** 566
- **Liczba wyborów gracza:** 92

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[40]** Ciara Walda

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Decision_Turn08_ExtendEmergency_Extend`
- `BaseGame.Democratic`
- `BaseGame.Economy`
- `BaseGame.Faction_USP_Obstructionist`
- `BaseGame.PersonalWealth`
- `BaseGame.Policy_Law_Decree_Stronger`
- `BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism`
- `BaseGame.Policy_Welfare_EvolutionNotMandatory`
- `BaseGame.Prologue_Family_Important`
- `BaseGame.Prologue_University_SupportWomensRights`
- `BaseGame.Reform_Assembly_Vote`
- `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation`
- `BaseGame.Reform_Turn08_Decree_WomensRights`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Relations_Monica_Slapped`
- `BaseGame.Relations_Monica_SupportIntentionAtBall`
- `BaseGame.Situation_Welfare_FailedEducationReform`
- `BaseGame.Turn05_Admin_Monica_Barred`
- `BaseGame.Turn06_P_SupportedMonicaAtConfrontation`
- `BaseGame.Turn08_SecondScandal_DenyEverything`
- `BaseGame.Turn08_SecondScandal_PetrForcedResign`
- `BaseGame.Turn08_SecondScandal_PetrSelfResigned`
- `BaseGame.Turn08_SecondScandal_PetrTrialled`
- `BaseGame.Turn08_WomensRights_ThroughAssembly`
- `BaseGame.WomensRightCommission`
- `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation`
- `BaseGameIsolated.Turn08_WomensRights_Listened_Education`
- `BaseGameIsolated.Turn08_WomensRights_Listened_Mothers`
- `BaseGameIsolated.Turn08_WomensRights_Listened_Violence`
- `BaseGameIsolated.Turn08_WomensRights_Listened_Workplace`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bill_Turn09_StrongWomensRights_Signed`
- `BaseGame.Democratic`
- `BaseGame.Economy`
- `BaseGame.Enable_LeagueOfWomenDonation`
- `BaseGame.Enable_Turn08LeagueOfWomenDonationOption_Donate2`
- `BaseGame.Enable_WomensRightsBill_Strong`
- `BaseGame.Enable_WomensRightsBill_Weak`
- `BaseGame.GovernmentBudget`
- `BaseGame.Malenyevist`
- `BaseGame.Policy_Law_WomenLiberation`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_Turn08_Decree_WomensRights`
- `BaseGame.Relations_Monica_ConvincedNotToLeadWomensRights`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_LeadsWomensRights`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Situation_Law_AverageWomenRights`
- `BaseGame.Situation_Law_ExcellentWomenRights`
- `BaseGame.Situation_Law_LimitedWomenRights`
- `BaseGame.Situation_Welfare_GenderEqualityInEducation`
- `BaseGame.Sollist`
- `BaseGame.Turn08_WomensRights_ThroughAssembly`
- `BaseGame.WomensRightCommission`
- `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation`
- `BaseGameIsolated.Turn08_WomensRights_Listened_Education`
- `BaseGameIsolated.Turn08_WomensRights_Listened_Mothers`
- `BaseGameIsolated.Turn08_WomensRights_Listened_Violence`
- `BaseGameIsolated.Turn08_WomensRights_Listened_Workplace`
- `BaseGameSupport.Codex_Characters_Family_Monica`
- `BaseGameSupport.Codex_Characters_Family_Monica_WomensRights`
- `BaseGameSupport.Journal_Turn08_WomensRights_ComissionEstablished`
- `BaseGameSupport.Journal_Turn08_WomensRights_MonicaLeads`
- `GameCondition.Turn08_A_WomensRightsMeeting`
- `GameCondition.Turn08_Decision_LeagueOfWomenDonation`
- `GameCondition.Turn09_Bill_WomensRights`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 8
- **Węzły modyfikujące stan gry:** 36

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy`
- `BaseGame.GovernmentBudget`
- `BaseGame.Reform_Turn08_Decree_WomensRights`
- `BaseGame.Relations_Monica_ConvincedNotToLeadWomensRights`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_LeadsWomensRights`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Sollist`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[99]` (Monica): `Variable["BaseGame.Relations_Monica_Divorce"] = true;`
- Węzeł `[100]` (Monica): `Variable["BaseGame.Relations_Monica_Divorce"] = true;`
- Węzeł `[125]` (Monica): `Variable["BaseGame.Relations_Monica_ConvincedNotToLeadWomensRights"] = true;`
- Węzeł `[141]` (Monica): `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] = false;`
- Węzeł `[142]` (Monica): `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] = true;`
- Węzeł `[143]` (Monica): `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] = false;`
- Węzeł `[144]` (Monica): `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] = false;`
- Węzeł `[145]` (Monica): `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] = true;`
- *...oraz 28 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Monica)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_P_SupportedMonicaAtConfrontation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_P_SupportedMonicaAtConfrontation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn06_P_SupportedMonicaAtConfrontation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[5]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn06_P_SupportedMonicaAtConfrontation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn06_P_SupportedMonicaAtConfrontation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[6]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[8]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_Monica_Barred == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[9]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrSelfResigned == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true || BaseGame.Turn08_SecondScandal_PetrTrialled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrSelfResigned == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true || BaseGame.Turn08_SecondScandal_PetrTrialled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrSelfResigned"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[11]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_PetrSelfResigned == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true || BaseGame.Turn08_SecondScandal_PetrTrialled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrSelfResigned"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_DenyEverything == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_DenyEverything == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[14]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_DenyEverything == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[15]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_EvolutionNotMandatory == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_EvolutionNotMandatory == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Welfare_EvolutionNotMandatory"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[17]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Welfare_EvolutionNotMandatory == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Welfare_EvolutionNotMandatory"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[18]`
Mówca: **Narrator**
> "I was sitting in my office. I looked at the clock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[19]`
Mówca: **Ciara Walda**
> ""It's a pity your wife won't be joining us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[20]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_FailedEducationReform == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_FailedEducationReform == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_FailedEducationReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[22]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_FailedEducationReform == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_FailedEducationReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[23]`
Mówca: **Narrator**
> "2:26 PM. It was almost time for my appointment with Ciara on women's rights."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[24]`
Mówca: **Narrator**
> "There was a knock at the door. Ciara entered the room with folders in her hand. The door did not close behind her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[25]`
Mówca: **Narrator**
> "Monica entered the room and stood next to Ciara."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[26]`
Mówca: **Narrator**
> "Monica entered the room and stood next to Ciara. I was confused. This was the opposite of what we had agreed after the Benfi Festival."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`
  - -> `[250]`
  - -> `[251]`

### Węzeł `[27]`
Mówca: **Narrator**
> "Monica turned to Ciara."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Monica**
> "“Could you give us a minute?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Ciara Walda**
> "“Of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Narrator**
> "Right before she made her way out, her eyes met with Monica's and the two women exchanged nods. The door closed, leaving Monica and me alone in the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`
  - -> `[31]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“You could've at least told me.”"]** — Mówca: **Player**
> "“You could've at least told me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[32]`
**[WYBÓR GRACZA: ""How dare you show up here after what we agreed!""]** — Mówca: **Player**
> ""How dare you show up here after what we agreed!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Explain yourself.""]** — Mówca: **Player**
> "“Explain yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[34]`
Mówca: **Monica**
> "“I know, but...I just thought you would say no again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[37]`
  - -> `[36]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“You were damn right. I would say no, and I am saying no.""]** — Mówca: **Player**
> "“You were damn right. I would say no, and I am saying no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Don't we have any trust in each other anymore?”"]** — Mówca: **Player**
> "“Don't we have any trust in each other anymore?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“So you went behind my back to join this meeting?”"]** — Mówca: **Player**
> "“So you went behind my back to join this meeting?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[38]`
Mówca: **Monica**
> "“You know how much I want to help women in Sordland. I had an opportunity and I couldn't let it pass.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Monica**
> "“You also know how stubborn I am. Once I set my mind on something, I won't budge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[40]`
Mówca: **Monica**
> "“You have my trust always. But this is a greater cause than just the two of us. I wouldn't have done this if I didn't believe that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Monica**
> "“We finally have the chance to change things for Sordish women. There's no way I was going to let that opportunity pass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[42]`
Mówca: **Monica**
> "“Anton, please try to understand. I wouldn't do this if I didn't think this was necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Monica**
> "“We're at a place where we can finally change the status of Sordish women. I couldn't let this opportunity pass.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Monica**
> "“So when Ciara asked me to join her today, I had to accept.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[47]`
  - -> `[46]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“Ciara needs to learn that she can't interfere with my family.”"]** — Mówca: **Player**
> "“Ciara needs to learn that she can't interfere with my family.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "“This doesn't change the fact that you didn't trust me.”"]** — Mówca: **Player**
> "“This doesn't change the fact that you didn't trust me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "“To be honest, I would've done the same if that is what it took to get my word across.”"]** — Mówca: **Player**
> "“To be honest, I would've done the same if that was what it took to get my word across.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[48]`
Mówca: **Monica**
> "“I know. And I'm sorry. Will you...will you forgive me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`
  - -> `[55]`

### Węzeł `[49]`
Mówca: **Monica**
> "“Don't blame her. She just did what was necessary for the future of Sordish women.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[50]`
Mówca: **Monica**
> "“I knew you would understand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“No.”"]** — Mówca: **Player**
> "“No.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "“If you promise never to surprise me like this again.""]** — Mówca: **Player**
> "“If you promise never to surprise me like this again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Monica**
> "“I promise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Narrator**
> "Her eyes were shining."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[55]`
**[WYBÓR GRACZA: "“Yes. I forgive you.”"]** — Mówca: **Player**
> "“Yes. I forgive you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Monica**
> "“Thank you, Anton. I will tell you everything from now on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[57]`
Mówca: **Monica**
> "“Please, Anton. Let me stay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[107]`
  - -> `[59]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "“All right. Let's discuss this together.”"]** — Mówca: **Player**
> "“All right. Let's discuss this together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "“My answer is still no. You will not go into politics.”"]** — Mówca: **Player**
> "“My answer is still no. You will not go into politics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Monica**
> "“But why? This is about Sordish women. This is bigger than just politics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[62]`
  - -> `[61]`
  - -> `[253]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "“It's simply too dangerous. I don't want you to get hurt.”"]** — Mówca: **Player**
> "“It's simply too dangerous. I don't want you to get hurt.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Don't be naive. Everything comes down to politics in the end.”"]** — Mówca: **Player**
> "“Don't be naive. Everything comes down to politics in the end.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[63]`
Mówca: **Monica**
> "“I understand the danger, but someone has to do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[64]`
Mówca: **Monica**
> "“Right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[65]`
Mówca: **Narrator**
> "She hugged me and kissed me on the cheek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“No canoodling at work, Mrs. First Lady.”"]** — Mówca: **Player**
> "“No canoodling at work, Mrs. First Lady.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "“All right. Can you call Ciara back?”"]** — Mówca: **Player**
> "“All right. Can you call Ciara back?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Monica**
> "“I'll fetch Ciara so we can get started.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Monica**
> "“Of course. I'll go get her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Narrator**
> "Monica left the office and returned with Ciara. Both women were smiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[71]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Ciara Womens Rights Monica Feedback)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[72]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Womens Rights Discussion])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[73]`
Mówca: **Monica**
> "“I know I don't understand politics the way you and Ciara do. But my role would be that of a spokeswoman. That's all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[74]`
Mówca: **Monica**
> "“You know how much I want to help women in Sordland. I had an opportunity, and I couldn't let it pass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[75]`
Mówca: **Monica**
> "“Ciara approached me about it. I had to accept.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`
  - -> `[79]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "“Without asking my permission!?""]** — Mówca: **Player**
> "“Without asking my permission!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[77]`
**[WYBÓR GRACZA: ""Why didn't you tell her I forbade it?""]** — Mówca: **Player**
> ""Why didn't you tell her I forbade it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Monica**
> "“Do you think she'd take that for an answer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "“Look, I'm sorry for yelling. But we talked about this before and I clearly said it would be a bad idea.""]** — Mówca: **Player**
> "“Look, I'm sorry for yelling. But we talked about this before and I clearly said it would be a bad idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Monica**
> "“I know it was a surprise to you. I'm sorry. I will tell you everything from now on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Monica**
> "“Can you forgive me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`
  - -> `[55]`

### Węzeł `[82]`
Mówca: **Monica**
> "“Why should a wife need her husband's permission to do something?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[256]`
  - -> `[257]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "“What are you going to do? Leave me? You wouldn't dare.""]** — Mówca: **Player**
> "“What are you going to do? Leave me? You wouldn't dare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[84]`
Mówca: **Monica**
> "“Just watch me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Narrator**
> "She walked to the door and wrenched it open. She walked away and closed the door with a loud slam."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[86]`
**[WYBÓR GRACZA: "“Please don't say that. I'm sorry.”"]** — Mówca: **Player**
> "“Please don't say that. I'm sorry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Monica**
> "“There are things at play here that are greater than just us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Monica**
> "“Look. I will be blunt. If you want to remain happily married, you will let me do this. I need this. Sordish women need this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Monica**
> "“I want to be their voice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[90]`

### Węzeł `[90]`
**[WYBÓR GRACZA: "“Can't you let Ciara do that? She is more experienced.”"]** — Mówca: **Player**
> "“Can't you let Ciara do that? She is more experienced.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "“You don't know how hard it is to be in that position. I'm trying to protect you.”"]** — Mówca: **Player**
> "“You don't know how hard it is to be in that position. I'm trying to protect you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Monica**
> "“I understand that. At least I think I do. But I really need to do this. For my own dignity as a Sordish woman and to root out the evil inside people like Curtan Leste.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[93]`
Mówca: **Monica**
> "“Ciara has the experience, but people think she's a radical, and un-feminine at that. She's not popular enough with the public to get this message across. I am.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
**[WYBÓR GRACZA: "“I'm sorry, but I can't let you do that. Please understand.”"]** — Mówca: **Player**
> "“I'm sorry, but I can't let you do that. Please understand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[95]`
Mówca: **Monica**
> "“This is my line in the sand, Anton. Now that I'm here, I won't back down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[96]`

### Węzeł `[96]`
**[WYBÓR GRACZA: "“Very well. If it's that important to you, stay.""]** — Mówca: **Player**
> "“Very well. If it's that important to you, stay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[97]`
Mówca: **Monica**
> "“Then I hope you will understand this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Narrator**
> "Before I could say anything, she got up and left my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Divorce"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[100]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Divorce"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[101]`
Mówca: **Monica**
> "“Thank you, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Monica**
> "“I'll go fetch Ciara so we can get started.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Narrator**
> "Monica briefly left the office and returned with Ciara. The two women were smiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[104]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Womens Rights Discussion])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[105]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Ciara Womens Rights Monica Feedback])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[106]`
Mówca: **Narrator**
> "Monica looked down at the floor, then back up at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[107]`
**[WYBÓR GRACZA: "“Do you trust me?”"]** — Mówca: **Player**
> "“Do you trust me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Monica**
> "“Yes, of course I do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[109]`

### Węzeł `[109]`
**[WYBÓR GRACZA: "“Then believe me when I say: don't get involved in politics.""]** — Mówca: **Player**
> "“Then believe me when I say: don't get involved in politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "“Very well. I will allow it.”"]** — Mówca: **Player**
> "“Very well. I will allow it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[111]`
Mówca: **Narrator**
> "I stood there for a few minutes as I contemplated what had just happened. Eventually, Ciara knocked and entered my office again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[112]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Ciara Womens Rights Monica Feedback])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[113]`
Mówca: **Narrator**
> "I stood in silence for a few minutes, contemplating what had just happened, Eventually, Ciara knocked and entered my office again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[114]`
Mówca: **Narrator**
> "Monica left the office. A short time later, Ciara knocked on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[115]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Ciara Womens Rights Monica Feedback])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "“We are getting close to the elections. I can't handle any possible bad press.”"]** — Mówca: **Player**
> "“We are getting close to the elections. I can't handle any possible bad press.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Monica**
> "“I know Benfi may have crossed a line, but this is different.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[118]`
**[WYBÓR GRACZA: "“This is my final answer. You will not do it.”"]** — Mówca: **Player**
> "“This is my final answer. You will not do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[119]`
**[WYBÓR GRACZA: "“All right. If you are willing to take the risk, I will let you do it.”"]** — Mówca: **Player**
> "“All right. If you are willing to take the risk, I will let you do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[120]`
Mówca: **Narrator**
> "I leaned forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[118]`

### Węzeł `[121]`
Mówca: **Narrator**
> "Monica's eyes narrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Monica**
> ""All right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[123]`
Mówca: **Monica**
> "“I was born ready.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[124]`
Mówca: **Narrator**
> "She made her way to the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[125]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_ConvincedNotToLeadWomensRights = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_ConvincedNotToLeadWomensRights"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[126]`
Mówca: **Monica**
> "“Anton, before we start...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Monica**
> "“I just wanted to thank you for agreeing to this meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Ciara Walda**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[129]`
Mówca: **Monica**
> "“I've been dreaming about this ever since I volunteered with the Sordish League of Women. I can't believe the moment's finally here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`
  - -> `[134]`
  - -> `[244]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "“Anything to make you happy.""]** — Mówca: **Player**
> "“Anything to make you happy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[131]`
**[WYBÓR GRACZA: "“I think both of you together could finally bring change to Sordland.”"]** — Mówca: **Player**
> "“I think both of you together could finally bring change to Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Monica**
> "“I hope you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[133]`
Mówca: **Monica**
> ""Not just me, Anton. All of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[134]`
**[WYBÓR GRACZA: "“I hope you thought this through. Real change requires carefully considered plans.”"]** — Mówca: **Player**
> "“I hope you thought this through. Real change requires carefully considered plans.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Monica**
> "“We did.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[136]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Womens Rights Discussion])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[137]`
Mówca: **Narrator**
> "After a couple of knocks at the door, Ciara entered the room with folders in her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Ciara Walda**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[139]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Ciara Womens Rights Monica Feedback])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[140]`
Mówca: **Ciara Walda**
> "“Not a particularly auspicious start to this meeting. But let's begin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[141]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation = false)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[142]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[143]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation = false)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[144]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation = false)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[145]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[146]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[147]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation = false)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[148]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Womens Rights Discussion)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[149]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Womens Rights Discussion])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[150]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[152]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Decree_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`
  - -> `[434]`

### Węzeł `[153]`
Mówca: **Ciara Walda**
> "“And this isn't only a moral issue. I have seen enough revolutions in this world to understand the main driver of any change.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[154]`
Mówca: **Narrator**
> "Ciara sat down on a chair and laid down the folder she was holding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[155]`
Mówca: **Narrator**
> "She flipped a folder open and started pulling out documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Ciara Walda**
> "“In United Contana, law dictates that women earn the same wages as men in their respective fields. My research shows that this led to a 15.5% increase in productivity. You could say this had a direct influence on their superpower status.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Ciara Walda**
> ""Arcasia passed laws ensuring maternity leave rights, child day care centers and tax deductions for working families. In turn, they experienced a 12.6% productivity boost and a flourishing economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Ciara Walda**
> "“Both countries also have significantly lower infant mortality rates, a statistic I believe is directly linked to the improved status of women.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Ciara Walda**
> "“Our administration has successfully managed to pull Sordland back from the brink of economic ruin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[160]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Economy > 6)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Economy > 6)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] > 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[162]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy > 6))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] > 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Ciara Walda**
> "“Our administration has thus far failed to pull Sordland out of its economic recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[164]`
Mówca: **Ciara Walda**
> "“So I am asking: Why stop there? Why not improve our economy and modernize our society at the same time?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[165]`
Mówca: **Ciara Walda**
> "“So I am asking: Why not try passing similar laws? At worst, even if they fail to improve the economy, it'll still be a significant step forward for our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[166]`
Mówca: **Narrator**
> "She leaned back in her chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[167]`
Mówca: **Narrator**
> "She leaned back in her chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[168]`
Mówca: **Ciara Walda**
> "“It's only logical.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[169]`
**[WYBÓR GRACZA: "“It feels too much like you're comparing Sordland to other nations. We must choose our own path.”"]** — Mówca: **Player**
> "“It feels too much like you're comparing Sordland to other nations. We must choose our own path.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[170]`
**[WYBÓR GRACZA: "“You've made a good case for all of these changes.”"]** — Mówca: **Player**
> "“You've made a good case for all of these changes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[171]`
Mówca: **Ciara Walda**
> "“I want to establish a commission for women's rights in Sordland with me as its head. Our goal shall be passing and implementing a set of laws to solve the problems we just discussed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[172]`
Mówca: **Narrator**
> "Ciara handed me one of the documents. It had a list of bullet points on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[173]`
Mówca: **Monica**
> "“Or even as their counterparts in Arcasia and United Contana. We've been lagging behind on this for decades, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[174]`
Mówca: **Ciara Walda**
> "“What are your thoughts so far?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[175]`
  - -> `[169]`

### Węzeł `[175]`
**[WYBÓR GRACZA: "“I'm not sure I can risk passing laws like these so close to the election.”"]** — Mówca: **Player**
> "“I'm not sure I can risk passing laws like these so close to the election.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Ciara Walda**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Ciara Walda**
> "“These laws would result in greater productivity, a better economy *and* happier women -- to be frank, Mr. President, you'd have to be a fool not to pass them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Ciara Walda**
> "“If we can pull this off before the elections, the Rayne administration will make history.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[179]`
Mówca: **Ciara Walda**
> "“I agree completely. We must aim to be better than them. Better than all the superpowers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Ciara Walda**
> "“None of them have yet managed to achieve true parity among the sexes. If we can do that, we'll make history.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Ciara Walda**
> "“Let's talk about how to proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[182]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[184]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Ciara Walda**
> "“Or even as their counterparts in Arcasia and United Contana. We've been lagging behind on this for decades.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[186]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[189]`
Mówca: **Narrator**
> "Monica handed me one of the documents. It had a list of bullet points on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[190]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[193]`
Mówca: **Monica**
> "“As the commission's spokeswoman, my responsibility will be to make speeches and organize fundraisers. I will be the face of this movement while Ciara handles the groundwork.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Monica**
> "“If I can show that the First Lady is behind this movement, many women will feel encouraged.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Narrator**
> "Ciara gestured down at her outfit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[196]`
Mówca: **Ciara Walda**
> "“The organization's name will be 'Commission on the Status of Women'.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[197]`
**[WYBÓR GRACZA: "“Why bother with a commission? I can pass the laws you want here and now.""]** — Mówca: **Player**
> "“Why bother with a commission? I can pass the laws you want here and now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[198]`
**[WYBÓR GRACZA: "“It's going to be damn hard getting your laws past the Assembly.""]** — Mówca: **Player**
> "“It's going to be damn hard getting your laws past the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[199]`
Mówca: **Ciara Walda**
> "“You'll still need to make sure they're effectively implemented.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[200]`
Mówca: **Ciara Walda**
> "“Mr. President, I know we've had friction in the past -- whether over the failed education reform, or the teaching of creationism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Ciara Walda**
> "“This is a completely separate topic and it should be handled as such.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[202]`
Mówca: **Ciara Walda**
> "“Mr. President, I know we've had friction in the past. But this has nothing to do with the failed education reform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[203]`
Mówca: **Ciara Walda**
> "“Mr. President, I know we've had friction in the past. But this has nothing to do with your decisions on creationism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[204]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_FailedEducationReform == true && BaseGame.Policy_Welfare_EvolutionNotMandatory == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Welfare_FailedEducationReform == true && BaseGame.Policy_Welfare_EvolutionNotMandatory == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_FailedEducationReform"] == true  and  Variable["BaseGame.Policy_Welfare_EvolutionNotMandatory"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[206]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Welfare_FailedEducationReform == true && BaseGame.Policy_Welfare_EvolutionNotMandatory == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_FailedEducationReform"] == true  and  Variable["BaseGame.Policy_Welfare_EvolutionNotMandatory"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[207]`
Mówca: **Ciara Walda**
> "“One more thing to consider before making your decision. This could help silence any of the public's lingering questions regarding your former vice president and the Livia Suno affair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[208]`
Mówca: **Ciara Walda**
> "“One more thing to consider before making your decision. This could help silence any of the public's lingering questions regarding your vice president and the Livia Suno affair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[209]`
Mówca: **Ciara Walda**
> "“You have the chance to be a hero. Think about your daughter and her future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Ciara Walda**
> "“I hope you will make the right decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[211]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[213]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[214]`
Mówca: **Monica**
> "“And that man would want a better future for his daughter and her daughters. No matter what else he's said or done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Monica**
> "“I hope you'll make the right decision. We both do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[216]`
Mówca: **Narrator**
> "They rose from their seats expectantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Narrator**
> "Ciara rose from her seat expectantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Narrator**
> "I took a few minutes to think."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[222]`
  - -> `[450]`

### Węzeł `[221]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Decree_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[454]`

### Węzeł `[222]`
**[WYBÓR GRACZA: "“I'm on your side. But I want to go through the Assembly. Can't risk a backlash this close to the election.”"]** — Mówca: **Player**
> "“I'm on your side. But I want to go through the Assembly. Can't risk a backlash this close to the election.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[223]`
**[WYBÓR GRACZA: "“I hereby declare your laws passed and your commission established. Good luck." [Sign Decree. -2 Government Budget]"]** — Mówca: **Player**
> "“Very well. I hereby decree your laws passed and your commission established. Good luck.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[224]`
**[WYBÓR GRACZA: "“I will approve the creation of the commission and support your bill in the Assembly.”"]** — Mówca: **Player**
> "“I will approve the creation of the commission and support your bill in the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[225]`
Mówca: **Ciara Walda**
> "“Great. Amazing. You won't regret this, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`

### Węzeł `[226]`
Mówca: **Ciara Walda**
> "“Then all is lost for the future of women in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Ciara Walda**
> "“Your female constituents will remember you as a failure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Ciara Walda**
> "“And so will I.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[232]`
Mówca: **Narrator**
> "She looked at Monica. She was silent for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Monica**
> "“How do I explain this to Deana, once she's old enough to understand? How do I tell her about all the opportunities she could have had, that her own father denied her?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[234]`
Mówca: **Narrator**
> "Without waiting for my answer, she pushed her chair aside and stormed out. Ciara followed suit, and I could hear the two of them talking angrily as the door closed behind them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Narrator**
> "Ciara furiously gathered up her documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[236]`
Mówca: **Narrator**
> "I sagged back in my chair and exhaled. It was a clear day outside, but the perfect view over Holsord provided little comfort."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[237]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: GameCondition.Turn08_A_WomensRightsMeeting = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn08_A_WomensRightsMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Ciara Walda**
> "“Money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[239]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Enable_LeagueOfWomenDonation = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_LeagueOfWomenDonation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[243]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: GameCondition.Turn08_Decision_LeagueOfWomenDonation = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn08_Decision_LeagueOfWomenDonation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[244]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[247]`
**[WYBÓR GRACZA: "“I know. That's why I already signed the decree to give women an equal education.""]** — Mówca: **Player**
> "“I know. That's why I already signed the decree to give women an equal education.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Monica**
> "“Yes, and that was a major step forward. But there's so much more work that must be done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[249]`
**[WYBÓR GRACZA: ""What are you doing here?""]** — Mówca: **Player**
> ""What are you doing here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[250]`
**[WYBÓR GRACZA: ""Ciara, what is she doing here?""]** — Mówca: **Player**
> ""Ciara, what is she doing here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[251]`
**[WYBÓR GRACZA: ""No. No! Monica, go home!""]** — Mówca: **Player**
> ""No. No! Monica, go home!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[252]`
Mówca: **Monica**
> "“See, that's why this meeting is so necessary!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[253]`
**[WYBÓR GRACZA: "“Someone has to stay home and look after Deana.”"]** — Mówca: **Player**
> "“Someone has to stay home and look after Deana.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Monica**
> "“I'm doing this *for* Deana. And for so many other girls like her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[255]`
**[WYBÓR GRACZA: ""This isn't about joining a knitting circle or having a friend for tea. It's about my career!""]** — Mówca: **Player**
> ""This isn't about joining a knitting circle or having a friend for tea. It's about my career!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[256]`
**[WYBÓR GRACZA: ""I promise I take women's rights seriously. Just let Ciara handle this.""]** — Mówca: **Player**
> ""I promise I take women's rights seriously. Just let Ciara handle this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[257]`
**[WYBÓR GRACZA: ""Because you'll make me look foolish otherwise -- like you did at the Benfi Festival.""]** — Mówca: **Player**
> ""Because you'll make me look foolish otherwise -- like you did at the Benfi Festival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[258]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Family_Important == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Family_Important == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Family_Important"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[260]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Family_Important == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Family_Important"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
**[WYBÓR GRACZA: ""Your career. For which you have consistently sidelined me and your children.""]** — Mówca: **Monica**
> ""Your career. For which you have consistently sidelined me and your children.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
**[WYBÓR GRACZA: ""I had dreams of a career too, back in university. But I gave those up for you.""]** — Mówca: **Monica**
> ""I had dreams of a career too, back in university. But I gave those up for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[263]`
**[WYBÓR GRACZA: ""I'm starting to think it wasn't worth it.""]** — Mówca: **Monica**
> ""I'm starting to think it wasn't worth it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[264]`
  - -> `[86]`

### Węzeł `[264]`
**[WYBÓR GRACZA: "“I gave you a life most woman can only dream of, and this is how you thank me?”"]** — Mówca: **Player**
> "“I gave you a life most woman can only dream of, and this is how you thank me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[265]`
Mówca: **Monica**
> ""I'll fetch Ciara so you two can get on with your business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[266]`
Mówca: **Ciara Walda**
> ""I did ask her to come to the meeting, as I thought her media traction after the Benfi Festival would make her a valuable spokeswoman. But she told me she was, and I quote, 'barred from politics'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Narrator**
> "She shot me a sharp, meaningful look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[272]`
  - -> `[273]`
  - -> `[274]`

### Węzeł `[268]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[270]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_Monica_Barred == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[272]`
  - -> `[273]`
  - -> `[274]`

### Węzeł `[271]`
**[WYBÓR GRACZA: "“It's for her own good.”"]** — Mówca: **Player**
> "“It's for her own good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[272]`
**[WYBÓR GRACZA: "“This is between Monica and myself. Stay out of it.”"]** — Mówca: **Player**
> "“This is between Monica and myself. Stay out of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[273]`
**[WYBÓR GRACZA: ""Monica would only be a liability to your cause.”"]** — Mówca: **Player**
> ""Monica would only be a liability to your cause.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[274]`
**[WYBÓR GRACZA: ""Be thankful I'm not firing you for approaching her behind my back.”"]** — Mówca: **Player**
> ""Be thankful I'm not firing you for approaching her behind my back.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[275]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[278]`
Mówca: **Ciara Walda**
> ""First off, Mr. President, I wish to thank you for pushing a decree on establishing gender equality in education. You know this is something I've been trying to accomplish since my appointment as minister. The situation in the public schools was disturbing for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[279]`
Mówca: **Ciara Walda**
> ""With that said, we still have a long way to go before Sordish women are able to enjoy the same rights and privileges as men.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[280]`
Mówca: **Ciara Walda**
> ""These are the measures I believe are most urgently needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[281]`
Mówca: **Monica**
> ""The two of us talked it over, and these are the measures we believe are most urgently needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[282]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Women's Issues Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Women's Issues Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[295]`
  - -> `[292]`
  - -> `[289]`
  - -> `[487]`

### Węzeł `[284]`
Mówca: **Narrator**
> "I let my eyes wander down the list."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[285]`
**[WYBÓR GRACZA: ""Criminalizing domestic violence.""]** — Mówca: **Player**
> ""Criminalizing domestic violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[286]`
**[WYBÓR GRACZA: ""Support for working mothers.""]** — Mówca: **Player**
> ""Support for working mothers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[287]`
**[WYBÓR GRACZA: ""Equal treatment in the workforce.""]** — Mówca: **Player**
> ""Equal treatment in the workforce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[288]`
**[WYBÓR GRACZA: ""Gender equality in public education.""]** — Mówca: **Player**
> ""Gender equality in public education.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[289]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == false && BaseGameIsolated.Turn08_WomensRights_Listened_Education == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == false && BaseGameIsolated.Turn08_WomensRights_Listened_Education == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == false  and  Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Education"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[291]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == false && BaseGameIsolated.Turn08_WomensRights_Listened_Education == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == false  and  Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Education"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[292]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_WomensRights_Listened_Workplace == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_WomensRights_Listened_Workplace == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Workplace"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[294]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_WomensRights_Listened_Workplace == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Workplace"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[295]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_WomensRights_Listened_Mothers == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_WomensRights_Listened_Mothers == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Mothers"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[297]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_WomensRights_Listened_Mothers == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Mothers"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[298]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_WomensRights_Listened_Violence == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_WomensRights_Listened_Violence == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Violence"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[300]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_WomensRights_Listened_Violence == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Violence"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[301]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Slapped == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Slapped == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Slapped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[303]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Slapped == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Slapped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[304]`
Mówca: **Ciara Walda**
> ""I shouldn't have to tell you how crucial this is. It is utterly unbelievable that, in this day and age, Sordish men are legally allowed to beat their wives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[305]`
Mówca: **Narrator**
> "Ciara looked at me closely, as if she were scrutinizing my reaction. How much had Monica told her?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[306]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[308]`

### Węzeł `[307]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[308]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[309]`
**[WYBÓR GRACZA: ""I agree. It's a travesty.""]** — Mówca: **Player**
> ""I agree. It's a travesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[310]`
**[WYBÓR GRACZA: ""What families do in their own homes is none of our concern.""]** — Mówca: **Player**
> ""What families do in their own homes is none of our concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[313]`

### Węzeł `[312]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[313]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[314]`
Mówca: **Monica**
> ""I'm happy we're on the same page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[315]`
Mówca: **Ciara Walda**
> ""I'm happy we're on the same page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[316]`
Mówca: **Narrator**
> "Monica and Ciara both looked disgusted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Narrator**
> "Ciara looked disgusted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[318]`
Mówca: **Ciara Walda**
> ""With all due respect, Mr. President, it is. By staying lenient on this we are essentially telling Sordish women that the state doesn't care about them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[319]`
Mówca: **Ciara Walda**
> ""As incidences are especially high within Bludish communities, I would also advocate for setting up a special domestic violence task force in collaboration with Bludish women's rights organizations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[320]`
Mówca: **Monica**
> ""Are you sure that's something we ought to focus on? The Bluds are... different. They have their own rules.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Narrator**
> "Monica looked at her strangely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[322]`
Mówca: **Ciara Walda**
> ""Monica, I'm surprised at you! We can't let women suffer under the patriarchy, no matter their ethnicity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[323]`
**[WYBÓR GRACZA: ""Interfering in Bludish matters has landed us in enough trouble already.""]** — Mówca: **Player**
> ""Interfering in Bludish matters has landed us in enough trouble already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[324]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion < 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Bludish_Opinion < 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[329]`
  - -> `[330]`

### Węzeł `[326]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Bludish_Opinion < 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] < 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`
  - -> `[328]`
  - -> `[327]`

### Węzeł `[327]`
**[WYBÓR GRACZA: ""The Bluds have their own ways of settling these issues.""]** — Mówca: **Player**
> ""The Bluds have their own ways of settling these issues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[328]`
**[WYBÓR GRACZA: ""We should lift up all Sordish women, Bluds included.""]** — Mówca: **Player**
> ""We should lift up all Sordish women, Bluds included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[329]`
**[WYBÓR GRACZA: ""The Bluds must conform to Sordish law.""]** — Mówca: **Player**
> ""The Bluds must conform to Sordish law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[330]`
**[WYBÓR GRACZA: ""I'm still not sure criminalizing domestic violence is a good idea. For the Bluds or anyone else.""]** — Mówca: **Player**
> ""I'm still not sure criminalizing domestic violence is a good idea. For the Bluds or anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[331]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[333]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[334]`
Mówca: **Ciara Walda**
> ""We can discuss the particulars once the law has passed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[335]`
Mówca: **Ciara Walda**
> ""I assure you it is. But I'll give you some time to think about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[336]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Women's Issues Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[337]`
Mówca: **Narrator**
> "Ciara nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[338]`
Mówca: **Ciara Walda**
> ""It simply isn't fair that women in the workforce are punished for having children.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[339]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`
  - -> `[341]`

### Węzeł `[340]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Monica**
> ""Remember what I told you about Janice? My friend who basically got fired for becoming pregnant? That would never happen to a man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[343]`
Mówca: **Ciara Walda**
> ""Paid maternity leave and state-subsidized daycare centers could be key to keeping more mothers employed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`
  - -> `[345]`
  - -> `[346]`
  - -> `[347]`

### Węzeł `[344]`
**[WYBÓR GRACZA: ""I don't want to reward women for choosing work over raising their children.""]** — Mówca: **Player**
> ""I don't want to reward women for choosing work over raising their children.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[345]`
**[WYBÓR GRACZA: ""It's true -- having children never hindered my career prospects. It shouldn't hinder a woman either.""]** — Mówca: **Player**
> ""It's true -- having children never hindered my career prospects. It shouldn't hinder a woman either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[346]`
**[WYBÓR GRACZA: ""I'll have to think about this.""]** — Mówca: **Player**
> ""I'll have to think about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[347]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[349]`

### Węzeł `[348]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[349]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[350]`
**[WYBÓR GRACZA: ""Monica, you always said you never regretted giving up a career to raise Franc and Deana.""]** — Mówca: **Player**
> ""Monica, you always said you never regretted giving up a career to raise Franc and Deana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[351]`
Mówca: **Monica**
> ""Anton, I never had a choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[352]`
Mówca: **Ciara Walda**
> ""Please do. Moving on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[353]`
Mówca: **Ciara Walda**
> ""What about women who have to work to provide for their children? This could lead to healthier families and a healthier economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Ciara Walda**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[355]`
Mówca: **Ciara Walda**
> ""Moving on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[356]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_WomensRights_Listened_Mothers = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Mothers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[357]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_WomensRights_Listened_Violence = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Violence"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[358]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Slapped == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Slapped == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Slapped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[360]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Slapped == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Slapped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[361]`
Mówca: **Ciara Walda**
> ""I'm happy you agree. In theory, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[362]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Women's Issues Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[363]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`
  - -> `[365]`

### Węzeł `[364]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[365]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[366]`
Mówca: **Monica**
> ""That's an easy one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[367]`
Mówca: **Ciara Walda**
> ""Right now, Sordland has one of the continent's largest pay gaps between men and women. We need legislation ensuring that a woman doing the same job as a man is paid the same wage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[368]`
Mówca: **Monica**
> ""We would also introduce quotas to get more women into positions of power -- in the Assembly, for instance, or on the boards of corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[369]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`
  - -> `[371]`

### Węzeł `[370]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[371]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[372]`
Mówca: **Ciara Walda**
> ""Eventually. Narrowing the pay gap is a far more pressing issue, as it would bring financial independence to countless lower-income women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[373]`
Mówca: **Monica**
> ""Ciara, we never talked about this. But I always thought that with more women in power, higher status for all women would naturally follow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[374]`
Mówca: **Ciara Walda**
> ""Women are starving because they don't make a living wage. That's a damn sight more important than your friend Janice being passed over for a promotion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[378]`
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Ciara Walda**
> ""A quota for women in positions of power -- on the boards of large corporations, for instance, or even within the Assembly -- would also be advisable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[378]`
  - -> `[376]`

### Węzeł `[376]`
**[WYBÓR GRACZA: ""Quotas are a terrible idea. People should be hired on merit, not simply because of their sex.""]** — Mówca: **Player**
> ""Quotas are a terrible idea. People should be hired on merit, not simply because of their sex.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[377]`
**[WYBÓR GRACZA: ""I don't see a problem with quotas, but tackling the pay gap is much more urgent.""]** — Mówca: **Player**
> ""I don't see a problem with quotas, but tackling the pay gap is much more urgent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[378]`
**[WYBÓR GRACZA: ""Quotas seem far easier to implement than equal pay laws. We should start there.""]** — Mówca: **Player**
> ""Quotas seem far easier to implement than equal pay laws. We should start there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[379]`
Mówca: **Narrator**
> "Ciara gritted her teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[380]`
Mówca: **Narrator**
> "Ciara smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[381]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[384]`
Mówca: **Narrator**
> "Monica gritted her teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Ciara Walda**
> ""My thoughts exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[386]`
Mówca: **Ciara Walda**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[387]`
Mówca: **Ciara Walda**
> ""We'll see about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[388]`
Mówca: **Narrator**
> "Monica and Ciara looked at me strangely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[389]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`
  - -> `[391]`

### Węzeł `[390]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[391]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[392]`
Mówca: **Monica**
> ""Men are hired on the basis of their sex all the time. Just not consciously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[393]`
Mówca: **Narrator**
> "Ciara looked at me strangely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[394]`
Mówca: **Ciara Walda**
> ""Men are hired on the basis of their sex all the time. Just not consciously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[395]`
Mówca: **Ciara Walda**
> ""There are more than enough qualified women to fill any position you can think of. It's up to us to give them the opportunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[396]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_WomensRights_Listened_Workplace = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Workplace"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[397]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Women's Issues Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[398]`
Mówca: **Narrator**
> "Ciara grinned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[399]`
Mówca: **Ciara Walda**
> ""You know how much this means to me. And you've witnessed the dangers firsthand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[400]`
Mówca: **Ciara Walda**
> ""The way girls are shut out of a real education unless their parents have the means to get them out of the public school system -- so many bright minds are being lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[401]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`
  - -> `[403]`

### Węzeł `[402]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[403]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`
  - -> `[409]`
  - -> `[410]`

### Węzeł `[404]`
Mówca: **Monica**
> ""I wouldn't entirely demean the old system, Ciara. Deana still loves her handicrafts classes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[405]`
Mówca: **Ciara Walda**
> ""I'm not saying we'll take those away. Maybe boys should learn handicrafts too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[406]`
Mówca: **Narrator**
> "Monica burst out laughing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[407]`
Mówca: **Monica**
> ""Imagine Franc in an apron!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`
  - -> `[408]`

### Węzeł `[408]`
**[WYBÓR GRACZA: ""We can't force schools what to teach to whom.""]** — Mówca: **Player**
> ""We can't force schools what to teach to whom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[409]`
**[WYBÓR GRACZA: ""Yes, we've had this conversation. I'm entirely on your side.""]** — Mówca: **Player**
> ""Yes, we've had this conversation. I'm entirely on your side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[410]`
**[WYBÓR GRACZA: ""But Deana loves her handicrafts classes.""]** — Mówca: **Player**
> ""But Deana loves her handicrafts classes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[411]`
Mówca: **Ciara Walda**
> ""I'm not saying we'll take those away. Maybe boys should learn handicrafts too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`
  - -> `[414]`

### Węzeł `[412]`
**[WYBÓR GRACZA: ""We've had this conversation, Ciara. I'm entirely on your side.""]** — Mówca: **Player**
> ""We've had this conversation, Ciara. I'm entirely on your side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[413]`
**[WYBÓR GRACZA: ""My voters won't want to see their sons in an apron.""]** — Mówca: **Player**
> ""My voters won't want to see their sons in an apron.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[414]`
**[WYBÓR GRACZA: ""You've got a point.""]** — Mówca: **Player**
> ""You've got a point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[415]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`
  - -> `[417]`

### Węzeł `[416]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[417]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[418]`
Mówca: **Ciara Walda**
> ""We can if not doing so puts us on the wrong side of history. Have you forgotten what we decided about evolution?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[419]`
Mówca: **Ciara Walda**
> ""We can if not doing so puts us on the wrong side of history. I still believe you made a mistake with your creationism decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[420]`
Mówca: **Ciara Walda**
> ""Good. Then we see eye to eye on the matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[421]`
Mówca: **Ciara Walda**
> ""But maybe they'll want to see their daughters become the next Artvin Einstavn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[422]`
Mówca: **Ciara Walda**
> ""Let's move on for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[423]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_WomensRights_Listened_Education = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Education"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[424]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Women's Issues Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[425]`
Mówca: **Ciara Walda**
> ""That covers all subjects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[426]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Listened to Issues - Next Steps)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[427]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Listened to Issues - Next Steps])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[428]`
Mówca: **Ciara Walda**
> ""Especially those who aren't keen on pantsuits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[429]`
Mówca: **Monica**
> ""And convince the public the changes will be beneficial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[430]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`
  - -> `[432]`

### Węzeł `[431]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[432]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[433]`
**[WYBÓR GRACZA: "“It's going to be damn hard getting your laws past the Assembly.""]** — Mówca: **Player**
> "“It's going to be damn hard getting your laws past the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[434]`
**[WYBÓR GRACZA: ""What do you need a commission for? I'll run your laws past the Assembly.""]** — Mówca: **Player**
> ""What do you need a commission for? I'll run your laws past the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[435]`
Mówca: **Narrator**
> "Ciara leaned toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[436]`
Mówca: **Ciara Walda**
> ""Nia would kill me for saying this, but... this is one case where using your decree powers would be fully justified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`
  - -> `[440]`
  - -> `[441]`
  - -> `[442]`

### Węzeł `[437]`
**[WYBÓR GRACZA: ""What exactly is going on between you and Mrs. Morgna, anyway?""]** — Mówca: **Player**
> ""What exactly is going on between you and Mrs. Morgna, anyway?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[438]`
Mówca: **Narrator**
> "She shrugged uncomfortably."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[439]`
Mówca: **Ciara Walda**
> ""We're friends. That's all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[440]`
**[WYBÓR GRACZA: ""I'll be the judge of that.""]** — Mówca: **Player**
> ""I'll be the judge of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[441]`
**[WYBÓR GRACZA: ""Look who's suddenly off her moral high horse.""]** — Mówca: **Player**
> ""Look who's suddenly off her moral high horse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[442]`
**[WYBÓR GRACZA: ""You're right. The Assembly would only pass a weak version of these laws, if at all.""]** — Mówca: **Player**
> ""You're right. The Assembly would only pass a weak version of these laws, if at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[443]`
Mówca: **Ciara Walda**
> ""I know. But even a watered-down version would be better than nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[444]`
Mówca: **Ciara Walda**
> ""If it's for the greater good, I have no problem bypassing the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[445]`
Mówca: **Ciara Walda**
> ""Even if that's successful, you'll still need the commission to ensure the laws are successfully implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[446]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`
  - -> `[448]`

### Węzeł `[447]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[448]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[449]`
Mówca: **Monica**
> ""And convince the public the changes will be beneficial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[450]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`
  - -> `[452]`

### Węzeł `[451]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[452]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[453]`
**[WYBÓR GRACZA: ""I've already given women equal access to education. I want to see how that decision shakes out before making any new laws.""]** — Mówca: **Player**
> ""I've already given women equal access to education. I want to see how that decision shakes out before making any new laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[454]`
**[WYBÓR GRACZA: ""Sorry, but the answer is no. You can try and run your laws by the Assembly, but they'll get no support from me.""]** — Mówca: **Player**
> ""Sorry, but the answer is no. You can try and run your laws by the Assembly, but they'll get no support from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[455]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Turn08_Decree_WomensRights = true; BaseGame.Policy_Law_WomenLiberation = true; BaseGame.Situation_Law_ExcellentWomenRights = true; BaseGame.Situation_Law_AverageWomenRights = false; BaseGame.Situation_Law_LimitedWomenRights = false;
BaseGame.Situation_Welfare_GenderEqualityInEducation = true;
BaseGame.Bill_Turn09_StrongWomensRights_Signed = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] = true;
Variable["BaseGame.Policy_Law_WomenLiberation"] = true;
Variable["BaseGame.Situation_Law_ExcellentWomenRights"] = true;
Variable["BaseGame.Situation_Law_AverageWomenRights"] = false;
Variable["BaseGame.Situation_Law_LimitedWomenRights"] = false;
Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] = true;
Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[456]`
Mówca: **Narrator**
> "Monica turned to her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[457]`
Mówca: **Monica**
> ""That's all the excitement you can muster? You did it! We did it!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[458]`
Mówca: **Narrator**
> "Monica hugged Ciara. She smiled uncomfortably."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[459]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.WomensRightCommission = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.WomensRightCommission"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[460]`
Mówca: **Ciara Walda**
> ""You're making a mistake by not pushing this through right away. But I'm happy for your support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[461]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`
  - -> `[463]`

### Węzeł `[462]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[463]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[464]`
Mówca: **Ciara Walda**
> ""We still have a long way to go. I'll start gathering names for the commission tonight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[465]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_LeadsWomensRights = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_LeadsWomensRights"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[466]`
Mówca: **Narrator**
> "Ciara started collecting her documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[467]`
Mówca: **Narrator**
> "She and Monica headed towards the door. Monica paused before leaving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[468]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`
  - -> `[470]`

### Węzeł `[469]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[470]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[471]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`
  - -> `[473]`

### Węzeł `[472]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Opinion"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[473]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Opinion > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Opinion"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[474]`
Mówca: **Monica**
> ""I love you, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[475]`
Mówca: **Monica**
> ""Whatever our differences, I'm glad you were able to set them aside and act for the good of Sordish women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[476]`
Mówca: **Monica**
> ""I'll see you at home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[477]`
Mówca: **Narrator**
> "She headed towards the door, then paused and turned back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[478]`
Mówca: **Ciara Walda**
> ""I wish your wife could be here right now to celebrate your decision. We both know how much this means to her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[479]`
Mówca: **Narrator**
> "She looked at me one last time before walking out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[480]`
Mówca: **Narrator**
> "I could hear Monica and Ciara talking excitedly to each other as the door closed behind them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[481]`
Mówca: **Narrator**
> "Ciara folded her arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[482]`
Mówca: **Ciara Walda**
> ""We've waited long enough, Mr. President. If you aren't re-elected, this opportunity will be lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[483]`
Mówca: **Ciara Walda**
> ""I suggest you think long and hard about how you're going to explain yourself to your wife. We both know how much this means to her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[484]`
Mówca: **Narrator**
> "She looked at me one last time before leaving the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[485]`
Mówca: **Narrator**
> "I took a long sip from the bottle of whiskey in my office desk drawer, then picked up the phone and called Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[486]`
Mówca: **Narrator**
> "I looked out my window over the city of Holsord. It was a clear day outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[487]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_WomensRights_Listened_Violence == true && BaseGameIsolated.Turn08_WomensRights_Listened_Mothers == true && BaseGameIsolated.Turn08_WomensRights_Listened_Workplace == true && BaseGameIsolated.Turn08_WomensRights_Listened_Education == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`
  - -> `[489]`

### Węzeł `[488]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_WomensRights_Listened_Violence == true && BaseGameIsolated.Turn08_WomensRights_Listened_Mothers == true && BaseGameIsolated.Turn08_WomensRights_Listened_Workplace == true && BaseGameIsolated.Turn08_WomensRights_Listened_Education == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Violence"] == true  and  Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Mothers"] == true  and  Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Workplace"] == true  and  Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[489]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_WomensRights_Listened_Violence == true && BaseGameIsolated.Turn08_WomensRights_Listened_Mothers == true && BaseGameIsolated.Turn08_WomensRights_Listened_Workplace == true && BaseGameIsolated.Turn08_WomensRights_Listened_Education == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Violence"] == true  and  Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Mothers"] == true  and  Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Workplace"] == true  and  Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Education"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[490]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_WomensRights_Listened_Education = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Education"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[491]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`
  - -> `[493]`

### Węzeł `[492]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[493]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[494]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Enable_WomensRightsBill_Weak = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_WomensRightsBill_Weak"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[495]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote >= 13)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`
  - -> `[497]`

### Węzeł `[496]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote >= 13)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Assembly_Vote"] >= 13`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[497]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Assembly_Vote >= 13))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Assembly_Vote"] >= 13) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[498]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote >= 17)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`
  - -> `[500]`

### Węzeł `[499]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Assembly_Vote >= 17)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Assembly_Vote"] >= 17`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[500]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Assembly_Vote >= 17))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Assembly_Vote"] >= 17) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[501]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Enable_WomensRightsBill_Strong = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_WomensRightsBill_Strong"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[502]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`
  - -> `[504]`

### Węzeł `[503]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[504]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[505]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: GameCondition.Turn09_Bill_WomensRights = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn09_Bill_WomensRights"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[506]`
Mówca: **Ciara Walda**
> ""We still have a long way to go before Sordish women are able to enjoy the same rights and privileges as men.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[507]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_WomensRights_ComissionEstablished = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_WomensRights_ComissionEstablished"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[508]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_WomensRights_MonicaLeads = true;
BaseGameSupport.Codex_Characters_Family_Monica_WomensRights = true;
BaseGameSupport.Codex_Characters_Family_Monica = false)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_WomensRights_MonicaLeads"] = true;
Variable["BaseGameSupport.Codex_Characters_Family_Monica_WomensRights"] = true;
Variable["BaseGameSupport.Codex_Characters_Family_Monica"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[509]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1;
BaseGame.Democratic += 2;
BaseGame.Malenyevist += 1;
BaseGame.Sollist -= 1;
BaseGame.GovernmentBudget -= 2;
BaseGame.Economy -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 2;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;
Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[510]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[511]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[512]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 5;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[513]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[514]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[515]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[516]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`
  - -> `[518]`

### Węzeł `[517]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[518]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth >= 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[519]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Enable_Turn08LeagueOfWomenDonationOption_Donate2 = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_Turn08LeagueOfWomenDonationOption_Donate2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[520]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_WomensRights_ThroughAssembly = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_WomensRights_ThroughAssembly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[521]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`
  - -> `[523]`

### Węzeł `[522]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Law_Decree_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[523]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Law_Decree_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[524]`
Mówca: **Narrator**
> "Ciara let out a lengthy exhale. Her face had started to turn red from holding her breath for so long."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[525]`
Mówca: **Narrator**
> "As she made eye contact with me, her professional side took hold. She swiftly straightened her posture and put on the icy mask of an experienced politician."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[526]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_WomensRights_ThroughAssembly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`
  - -> `[528]`

### Węzeł `[527]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_WomensRights_ThroughAssembly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_WomensRights_ThroughAssembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[528]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_WomensRights_ThroughAssembly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_WomensRights_ThroughAssembly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[529]`
Mówca: **Ciara Walda**
> ""It's not over yet, Monica. The true battle is in the Assembly. We'll celebrate once that's over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[530]`
Mówca: **Ciara Walda**
> ""I'll start gathering names for the commission tonight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[531]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_SupportWomensRights == true || BaseGame.Relations_Monica_SupportIntentionAtBall == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`
  - -> `[533]`

### Węzeł `[532]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_SupportWomensRights == true || BaseGame.Relations_Monica_SupportIntentionAtBall == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_SupportWomensRights"] == true  or  Variable["BaseGame.Relations_Monica_SupportIntentionAtBall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`

### Węzeł `[533]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_SupportWomensRights == true || BaseGame.Relations_Monica_SupportIntentionAtBall == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_SupportWomensRights"] == true  or  Variable["BaseGame.Relations_Monica_SupportIntentionAtBall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[534]`
Mówca: **Monica**
> ""I hope this is still as important to you as it used to be. And I trust you to do the right thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[535]`
Mówca: **Monica**
> ""You never did listen to me about the importance of woman's rights. Maybe you'll take your own minister more seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[536]`
Mówca: **Narrator**
> "Monica lowered her voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[537]`
Mówca: **Monica**
> ""Anton, I think you'll agree that I've put up with quite a lot over the course of your presidency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[538]`
Mówca: **Monica**
> ""And that man would want a better future for his daughter and her daughters. Just like you told me you did all those years ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[539]`
Mówca: **Monica**
> ""But despite it all, I look at you and I still see the idealistic, driven man I married.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[540]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_SupportWomensRights == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`
  - -> `[542]`

### Węzeł `[541]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_SupportWomensRights == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_SupportWomensRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[542]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_SupportWomensRights == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_SupportWomensRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[543]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion < -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`
  - -> `[545]`

### Węzeł `[544]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion < -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[545]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Opinion < -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[546]`
Mówca: **Narrator**
> "Monica lowered her voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[547]`
Mówca: **Monica**
> ""Anton, I think you'll agree that I've put up with quite a lot over the course of our marriage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[548]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true || BaseGame.Democratic < -10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`
  - -> `[550]`

### Węzeł `[549]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn08_ExtendEmergency_Extend == true || BaseGame.Democratic < -10)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  or  Variable["BaseGame.Democratic"] < -10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[550]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true || BaseGame.Democratic < -10))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  or  Variable["BaseGame.Democratic"] < -10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[551]`
Mówca: **Monica**
> ""But some part of me still sees you as the idealistic, driven man I married.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[552]`
Mówca: **Narrator**
> "Monica lowered her voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[553]`
Mówca: **Monica**
> ""Anton, I'm not completely naive. I know what we're proposing would have its downsides.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[554]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_SupportWomensRights == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`
  - -> `[556]`

### Węzeł `[555]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_SupportWomensRights == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_SupportWomensRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[556]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_SupportWomensRights == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_SupportWomensRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[557]`
Mówca: **Monica**
> ""But every time I look at our daughter, I think about how I'd do anything to grant her a better future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[558]`
Mówca: **Monica**
> "“I know you would too. Even if you might not admit it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[559]`
Mówca: **Monica**
> ""I know you would too. Just like you told me all those years ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[560]`
Mówca: **Narrator**
> "Ciara was looking studiously at a scratch on my desk. She blinked and turned back to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[561]`
Mówca: **Ciara Walda**
> "“That's right, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[562]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[563]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Faction_USP_Obstructionist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`
  - -> `[565]`

### Węzeł `[564]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Faction_USP_Obstructionist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_USP_Obstructionist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[565]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_USP_Obstructionist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_USP_Obstructionist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`
