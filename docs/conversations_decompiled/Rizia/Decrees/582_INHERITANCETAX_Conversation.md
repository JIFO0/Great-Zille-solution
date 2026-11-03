# Rizia/INHERITANCETAX/INHERITANCETAX Conversation

- **ID konwersacji:** `582`
- **StoryPack:** `Rizia`
- **Tura:** `Decree (INHERITANCETAX)`
- **Lokalizacja pliku:** `Rizia/Decrees/582_INHERITANCETAX_Conversation.md`
- **Liczba węzłów dialogowych:** 145
- **Liczba wyborów gracza:** 36

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Country_HouseAzaro`
- `RiziaDLC.Country_HouseSazon`
- `RiziaDLC.Country_HouseToras`
- `RiziaDLC.HouseOfDelegates_Abolished`
- `RiziaDLC.Policy_RD_Economy_LandOwnersTax`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialPolice`
- `RiziaDLC.Policy_RD_Welfare_FreePress`
- `RiziaDLC.Reform_DeclareIntention_Public`
- `RiziaDLC.Reform_Movement_Grows`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Hugo_CounselIgnored`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[356] Rizia/CouncilRoyalDecrees** (../Decrees/356_CouncilRoyalDecrees.md), Węzeł `[55]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 5

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[5]` (Paskal Beniwoll): `EnactDecree("Economy_Taxes_EnactInheritenceTax"); Variable["RiziaDLC.Hugo_CounselIgnored"] = Vari...`
- Węzeł `[37]` (Paskal Beniwoll): `--;`
- Węzeł `[54]` (Paskal Beniwoll): `--;`
- Węzeł `[132]` (Paskal Beniwoll): `--;`
- Węzeł `[135]` (Paskal Beniwoll): `--;`

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `356` (*Rizia/CouncilRoyalDecrees*), Węzeł `[55]`

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""You would tax the dead now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[4]`
Mówca: **Narrator**
> "He bowed and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnactDecree("Economy_Taxes_EnactInheritenceTax");
RiziaDLC.Hugo_CounselIgnored += 1)*
- **Efekt (`userScript`):** `EnactDecree("Economy_Taxes_EnactInheritenceTax");
Variable["RiziaDLC.Hugo_CounselIgnored"] = Variable["RiziaDLC.Hugo_CounselIgnored"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[6]`
Mówca: **Narrator**
> "I took a look at the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[10]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "Sign the decree."]** — Mówca: **Player_Romus_Italic**
> "I signed the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[8]`
Mówca: **Hugo Toras**
> ""Very well... I hope we won't have any trouble in its implementation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Hugo Toras**
> ""I'll see you later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've given me a lot to consider. I'll hold off on the decree for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Hugo Toras**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Narrator**
> "I gave him the unsigned decree and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""We've been through this, Romus. These tax proposals were deliberate attempts by the RPP to attack the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Hugo Toras**
> ""The Land Owners' Tax, Inheritance Tax... What will they try to take from us next?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""You already weakened the Royal Houses with your decrees, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[22]`
Mówca: **Hugo Toras**
> ""Please don't let the RPP influence you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[60]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseOfDelegates_Abolished == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So taxation is only legitimate when it burdens the commoners? But when it reaches the nobility, it's suddenly a conspiracy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""Your approval of the RPP's other tax proposal has already left you on thin ice with the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Hugo Toras**
> ""You shouldn't push it too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[29]`
Mówca: **Hugo Toras**
> ""Allowing the RPP to use the media against us has already led to problems with the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Hugo Toras**
> ""Signing this would be a step too far for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Hugo Toras**
> ""But this proposal is a deliberate attempt by the RPP to attack the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[35]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't be so dramatic, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is not about the RPP, nor is it about punishing the nobility. This is for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[36]`
  - -> `[63]`
  - -> `[57]`

### Węzeł `[38]`
Mówca: **Hugo Toras**
> ""We've already talked about this, Romus. This is just another attempt by the RPP to undermine the nobility, like that free press proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_FreePress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Hugo Toras**
> ""Especially not after what you've already taken from them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Hugo Toras**
> ""Tell me, Romus, was there even a conversation to be had about this? Or did the RPP simply write it for you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[72]`
  - -> `[76]`
  - -> `[73]`
  - -> `[68]`
  - -> `[95]`

### Węzeł `[50]`
Mówca: **Hugo Toras**
> ""These proposals already lost all of their legitimacy when you closed down the House of Delegates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Hugo Toras**
> ""There is no point in even considering them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[37]`

### Węzeł `[52]`
Mówca: **Hugo Toras**
> ""Please reconsider.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[56]`

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know by now that I support the Rizian People's Party, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just because this is proposed by the RPP doesn't make it wrong. The nobility must also pay its fair share of taxes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is nothing to reconsider. I have already decided.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_DeclareIntention_Public == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_DeclareIntention_Public == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_DeclareIntention_Public == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does that even mean, Hugo? Are you implying I'm somehow a puppet of the RPP now -- that I can't decide on my own?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[61]`
Mówca: **Hugo Toras**
> ""My apologies if I caused offense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You already told me that, Uncle. Maybe it's time to let this go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How convenient.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[67]`
Mówca: **Hugo Toras**
> ""Romus, I have watched you challenge traditions before. I have even defended you when others whispered that you were reaching too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So taxation is only legitimate when it burdens the commoners? But when it reaches the nobility, it's suddenly a conspiracy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You give them too much credit, Hugo. My decisions are my own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So, are you just opposed to the decree because of who proposed it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[74]`
Mówca: **Hugo Toras**
> ""You listened to my advice and held off on the Land Owners' Tax.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[75]`
Mówca: **Hugo Toras**
> ""But it's not only the Royal Houses, Romus. If the nobility unites against you, they can still wield considerable influence over key people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[113]`
  - -> `[114]`
  - -> `[115]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Hugo... I am just a mouthpiece for the reformists, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[77]`
Mówca: **Hugo Toras**
> ""I'm just saying, Your Majesty, that this is not just a tax.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Hugo Toras**
> ""This tax is clearly directed at the nobility. They will see it as a *message* directed at them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[97]`
  - -> `[102]`
  - -> `[98]`
  - -> `[99]`
  - -> `[104]`

### Węzeł `[79]`
Mówca: **Hugo Toras**
> ""The nobility are the pillars of this monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Hugo Toras**
> ""Cracked, perhaps. But pillars still.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[81]`
Mówca: **Hugo Toras**
> ""I didn't mean to suggest that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[85]`
Mówca: **Hugo Toras**
> ""Perhaps so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[86]`
Mówca: **Hugo Toras**
> ""The Land Owners' Tax was a big blow to the nobility already. Please don't add insult to injury.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[137]`

### Węzeł `[87]`
Mówca: **Hugo Toras**
> ""Don't forget they are holding the roof of this palace above our heads.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[130]`
  - -> `[129]`

### Węzeł `[88]`
Mówca: **Hugo Toras**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Houses can take their grievances and shove them exactly where they belong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[94]`
Mówca: **Hugo Toras**
> ""But with this... I have to be the one telling you that you would indeed be doing just that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does that even mean, Hugo? I advise you to be more respectful towards me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[96]`
Mówca: **Hugo Toras**
> ""I want you to do the same with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think this will push them too far?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let them rage. Their approval was never a requirement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I cannot let the nobility dictate policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[100]`
Mówca: **Hugo Toras**
> ""The numbers on the balance sheet won't matter if the nobility starts treating you as a threat rather than a king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[101]`
Mówca: **Hugo Toras**
> ""We cannot trade political stability for revenue, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are going to be making money for the treasury, Hugo. This is a necessary policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[103]`
Mówca: **Hugo Toras**
> ""No it wasn't...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Hugo, because taxing the wealthiest estates is truly the gravest injustice in this kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[105]`
Mówca: **Hugo Toras**
> ""I do. And I believe you know it too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've been through this, Hugo. I've already weakened them. They can't fight back against this change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[107]`
Mówca: **Hugo Toras**
> ""But their cooperation has kept this kingdom standing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[108]`
Mówca: **Hugo Toras**
> ""I understand the sentiment...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Hugo Toras**
> ""But these are the men and women who fund armies, who own land, who control commerce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Hugo Toras**
> ""These are the men and women who fund armies, who own land, who control commerce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Hugo Toras**
> ""And people like that do not sit idly when they believe their future is at risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`
  - -> `[115]`
  - -> `[116]`

### Węzeł `[112]`
Mówca: **Hugo Toras**
> ""And yet they do dictate much of this kingdom, whether you acknowledge it or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The nobility is not Rizia, Hugo. The people are. If the nobles have forgotten that, then it is time they remembered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The disparity between nobles and commoners grows wider by the year. If we continue down this path of preservation over reform, we will not be the ones who decide when change comes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're looking at this as a political move, Hugo. But I see it as an economic one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So, basically, men like you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care what they think. I will keep weakening them until they have no power over me nor the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Hugo Toras**
> ""We can help the poor without disrupting the whole system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget <= 3 && RiziaDLC.Country_HouseAzaro > 5 && RiziaDLC.Country_HouseSazon > 5 && RiziaDLC.Country_HouseToras > 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget <= 3 && RiziaDLC.Country_HouseAzaro > 5 && RiziaDLC.Country_HouseSazon > 5 && RiziaDLC.Country_HouseToras > 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] <= 3  and  Variable["RiziaDLC.Country_HouseAzaro"] > 5  and  Variable["RiziaDLC.Country_HouseSazon"] > 5  and  Variable["RiziaDLC.Country_HouseToras"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget <= 3 && RiziaDLC.Country_HouseAzaro > 5 && RiziaDLC.Country_HouseSazon > 5 && RiziaDLC.Country_HouseToras > 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] <= 3  and  Variable["RiziaDLC.Country_HouseAzaro"] > 5  and  Variable["RiziaDLC.Country_HouseSazon"] > 5  and  Variable["RiziaDLC.Country_HouseToras"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[128]`
Mówca: **Narrator**
> "He grunted in disapproval."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may have a point about the risk. I'll hold off on the decree for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Hugo. It's the other way around. And the nobility must pay their share of taxes just like everyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think I've heard enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[138]`
  - -> `[134]`

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, Hugo, but this time I will be signing this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Nobody is going to get away with not paying their share of taxes anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're repeating the same words, Hugo. I understand your concerns, but you have to trust my judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will add another one as I see fit. This is happening, Hugo. So please don't stand against me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Maybe you're right about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[139]`
Mówca: **Hugo Toras**
> ""I advise you to ignore her opinion on this topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[140]`
Mówca: **Hugo Toras**
> ""We can't let the masses on the streets dictate policy-making.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[141]`
Mówca: **Hugo Toras**
> ""It seems it is only you and Ms. Werner who see it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[142]`
Mówca: **Hugo Toras**
> ""I believe Ms. Werner also doesn't support this decree, Your Majesty. Despite its potential impact on the treasury.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Hugo Toras**
> ""I advise you not to ignore her opinion on this topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[144]`
Mówca: **Hugo Toras**
> ""The Houses' noble standing -- including our own, I'll remind you -- depends on the flow of wealth from generation to generation. You cannot simply take that away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
