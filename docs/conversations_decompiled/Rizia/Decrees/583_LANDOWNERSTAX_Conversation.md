# Rizia/LANDOWNERSTAX/LANDOWNERSTAX Conversation

- **ID konwersacji:** `583`
- **StoryPack:** `Rizia`
- **Tura:** `Decree (LANDOWNERSTAX)`
- **Lokalizacja pliku:** `Rizia/Decrees/583_LANDOWNERSTAX_Conversation.md`
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
- `RiziaDLC.Policy_RD_Economy_EnactInheritanceTax`
- `RiziaDLC.Policy_RD_Economy_LandOwnersTax`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialPolice`
- `RiziaDLC.Policy_RD_Welfare_FreePress`
- `RiziaDLC.Reform_DeclareIntention_Public`
- `RiziaDLC.Reform_Movement_Grows`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Hugo_CounselIgnored`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[356] Rizia/CouncilRoyalDecrees** (../Decrees/356_CouncilRoyalDecrees.md), Węzeł `[56]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 5

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[46]` (Paskal Beniwoll): `--;`
- Węzeł `[48]` (Paskal Beniwoll): `--;`
- Węzeł `[62]` (Paskal Beniwoll): `--;`
- Węzeł `[132]` (Paskal Beniwoll): `--;`
- Węzeł `[139]` (Paskal Beniwoll): `EnactDecree("Economy_Taxes_LandOwnersTax"); Variable["RiziaDLC.Hugo_CounselIgnored"] = Variable["...`

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `356` (*Rizia/CouncilRoyalDecrees*), Węzeł `[56]`

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""Targeting wealthy landowners with a tax, I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Hugo Toras**
> ""We already talked about this, Romus. This is just another attempt by the RPP, like that free press proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_LandOwnersTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_FreePress == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_FreePress == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[17]`
Mówca: **Hugo Toras**
> ""We've been through this, Romus. These tax proposals were deliberate attempts by the RPP to attack the royals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""The Land Owners Tax, Inheritance Tax... What's going to be next?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""Your approval of the RPP's other tax proposal has already left you on thin ice with the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Hugo Toras**
> ""You shouldn't push it too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""Allowing the RPP to use the media against us has already created problems with the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Hugo Toras**
> ""Signing this would be a step too far for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[26]`
Mówca: **Hugo Toras**
> ""After what you've already taken away from them, this is simply overkill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""But this proposal was a deliberate attempt by the RPP to attack nobles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[42]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[31]`
Mówca: **Hugo Toras**
> ""You already weakened the Royal Houses with your decrees, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[32]`
Mówca: **Hugo Toras**
> ""Please don't let the RPP influence you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[50]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseOfDelegates_Abolished == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseOfDelegates_Abolished == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[36]`
Mówca: **Hugo Toras**
> ""These proposals lost all of their legitimacy when you closed down the House of Delegates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the nobility sees taxation as an attack, that says more about them really.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[38]`
Mówca: **Hugo Toras**
> ""There is no point in even considering them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[48]`

### Węzeł `[39]`
Mówca: **Hugo Toras**
> ""Please reconsider.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[51]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So taxation is only legitimate when it burdens the commoners? But when it reaches the nobility, it's suddenly a conspiracy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've already declared my support to the Rizian People's Party. I hope there is no confusion about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're being dramatic again, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_DeclareIntention_Public == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_DeclareIntention_Public == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_DeclareIntention_Public == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`
  - -> `[131]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't let who wrote the proposal influence you for once, Hugo. The nobility must pay its fair share of taxes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[37]`
  - -> `[53]`
  - -> `[43]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You said the exact same thing before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not letting anyone influence me. This is my own decision. And you better respect it as such.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry but no. I have already decided.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How convenient.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, Hugo, but this time I will be signing this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[57]`
Mówca: **Hugo Toras**
> ""Romus, I have watched you challenge traditions before. I have even defended you when others whispered that you were reaching too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[61]`
Mówca: **Hugo Toras**
> ""Tell me, Romus, was there even a conversation to be had about this? Or did the RPP simply write it for you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[64]`
  - -> `[66]`
  - -> `[65]`
  - -> `[68]`
  - -> `[67]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""My apologies if I caused offense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You give them too much credit, Hugo. My decisions are my own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So, are you just opposed to it because of who proposed it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Hugo... I am just a mouth piece for the reformists, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does that even mean, Hugo? I advise you to be more respectful towards me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So taxation is only legitimate when it burdens the commoners? But when it reaches the nobility, it's suddenly a conspiracy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Houses can take their grievances and shove them exactly where they belong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Hugo Toras**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[75]`
Mówca: **Hugo Toras**
> ""I didn't mean to suggest that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[76]`
Mówca: **Hugo Toras**
> ""I'm just saying, Your Majesty, that this is not merely about generating income.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Hugo Toras**
> ""This tax is clearly aimed at the nobility. They will see it as a *message* directed at them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[82]`
  - -> `[78]`
  - -> `[79]`
  - -> `[80]`
  - -> `[81]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are going to be making money for the treasury, Hugo. This is a necessary policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let them rage. Their approval was never a requirement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I cannot let the nobility dictate policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Hugo, because taxing the wealthiest estates is truly the gravest injustice in this kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think this will push them too far?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Hugo Toras**
> ""I do. And I believe you know it too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[84]`
Mówca: **Hugo Toras**
> ""The numbers on the balance sheet won't matter if the nobility starts treating you as a threat rather than a king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[85]`
Mówca: **Hugo Toras**
> ""No it wasn't...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Hugo Toras**
> ""We cannot trade political stability for revenue, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[87]`
Mówca: **Hugo Toras**
> ""But their cooperation has kept this kingdom standing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[88]`
Mówca: **Hugo Toras**
> ""And yet they do dictate much of this kingdom, whether you acknowledge it or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Hugo Toras**
> ""I understand the sentiment...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Hugo Toras**
> ""But these are the men and women who fund armies, who own land, who control commerce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Hugo Toras**
> ""These are the men and women who fund armies, who own land, who control commerce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Hugo Toras**
> ""And people like that do not sit idly when they believe their future is at risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`
  - -> `[98]`
  - -> `[99]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The nobility is not Rizia, Hugo. The people are. If the nobles have forgotten that, then it is time they remembered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The disparity grows wider by the year. If we continue down this path of preservation over reform, we will not be the ones who decide when change comes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're looking at this as a political move, Hugo. But I see it as an economic one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So, basically, men like you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[100]`
Mówca: **Hugo Toras**
> ""The nobility are the pillars of this monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Hugo Toras**
> ""Cracked, perhaps. But pillars still.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[102]`
Mówca: **Hugo Toras**
> ""Perhaps so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've been through this, Hugo. I've already weakened them. They can't resist this change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[104]`
Mówca: **Hugo Toras**
> ""We can't let the masses on the streets dictate policy-making.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[105]`
Mówca: **Hugo Toras**
> ""I advise you to ignore her opinion on this topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[106]`
Mówca: **Hugo Toras**
> ""It seems it is only you and Ms. Werner who sees it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget <= 3 && RiziaDLC.Country_HouseAzaro > 5 && RiziaDLC.Country_HouseSazon > 5 && RiziaDLC.Country_HouseToras > 5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget <= 3 && RiziaDLC.Country_HouseAzaro > 5 && RiziaDLC.Country_HouseSazon > 5 && RiziaDLC.Country_HouseToras > 5)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] <= 3  and  Variable["RiziaDLC.Country_HouseAzaro"] > 5  and  Variable["RiziaDLC.Country_HouseSazon"] > 5  and  Variable["RiziaDLC.Country_HouseToras"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget <= 3 && RiziaDLC.Country_HouseAzaro > 5 && RiziaDLC.Country_HouseSazon > 5 && RiziaDLC.Country_HouseToras > 5))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] <= 3  and  Variable["RiziaDLC.Country_HouseAzaro"] > 5  and  Variable["RiziaDLC.Country_HouseSazon"] > 5  and  Variable["RiziaDLC.Country_HouseToras"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[110]`
Mówca: **Hugo Toras**
> ""Don't forget they are holding the roof of this palace above our heads.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[121]`
  - -> `[120]`

### Węzeł `[111]`
Mówca: **Hugo Toras**
> ""But it's not only the Royal Houses, Romus. If the nobility unites against you, they can still wield considerable influence over key people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[93]`
  - -> `[94]`
  - -> `[98]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care what they think. I will keep weakening them until they have no power over me nor the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Hugo Toras**
> ""We can help the poor without disrupting the whole system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[117]`
Mówca: **Hugo Toras**
> ""I believe Ms. Werner also doesn't support this decree, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Hugo Toras**
> ""I advise you not to ignore her opinion on this topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[119]`
Mówca: **Narrator**
> "He grunted in disapproval."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may have a point about the risk. I'll hold off on the decree for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Hugo. It's the other way around. And the nobility must pay their share of taxes just like everyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think I've heard enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[123]`
Mówca: **Hugo Toras**
> ""I'll see you later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[124]`
Mówca: **Hugo Toras**
> ""But with this... I have to be the one telling you that you would indeed be doing just that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[125]`
Mówca: **Hugo Toras**
> ""You listened to my advice and held off on the Inheritance Tax.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Hugo Toras**
> ""I want you to do the same with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[56]`

### Węzeł `[127]`
Mówca: **Hugo Toras**
> ""Enacting the Inheritance Tax was a big blow to the nobility already. Please don't add another one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[46]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will add another one as I see fit. This is happening, Hugo. So please don't stand against me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're repeating the same words, Hugo. I get your concerns, but you have to trust my judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Maybe you're right about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Nobody is going to get away with not paying their share of taxes anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[133]`
Mówca: **Narrator**
> "He bowed and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[137]`
Mówca: **Narrator**
> "I took a look at the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[142]`

### Węzeł `[138]`
**[WYBÓR GRACZA: "Sign the decree."]** — Mówca: **Player_Romus_Italic**
> "I signed the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnactDecree("Economy_Taxes_LandOwnersTax");
RiziaDLC.Hugo_CounselIgnored += 1)*
- **Efekt (`userScript`):** `EnactDecree("Economy_Taxes_LandOwnersTax");
Variable["RiziaDLC.Hugo_CounselIgnored"] = Variable["RiziaDLC.Hugo_CounselIgnored"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Hugo Toras**
> ""Very well... I hope we won't have any trouble in its implementation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[141]`
Mówca: **Narrator**
> "I gave him the unsigned decree and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've given me a lot to consider. I'll hold off on the decree for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Hugo Toras**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[144]`
Mówca: **Hugo Toras**
> ""Your Majesty, to tax nobles' estates is to attack the very foundations of the Royal Houses. Your own included, I will add.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
