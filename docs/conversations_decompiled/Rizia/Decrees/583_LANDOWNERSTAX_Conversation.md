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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[37]` | **""If the nobility sees taxation as an attack, that says more about them really.""** | `[27]` **Hugo Toras**: ""But this proposal was a deliber..."<br>`[32]` **Hugo Toras**: ""Please don't let the RPP influe..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Hugo Toras**: ""Romus, I have watched you chall..."<br>`[76]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[40]` | **""So taxation is only legitimate when it burdens the commoners? But when it reaches..."** | `[27]` **Hugo Toras**: ""But this proposal was a deliber..."<br>`[32]` **Hugo Toras**: ""Please don't let the RPP influe..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true) == false` | *Brak zmian stanu* | `[57]` **Hugo Toras**: ""Romus, I have watched you chall..."<br>`[76]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[41]` | **""I've already declared my support to the Rizian People's Party. I hope there is no..."** | `[27]` **Hugo Toras**: ""But this proposal was a deliber..."<br>`[32]` **Hugo Toras**: ""Please don't let the RPP influe..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true` | *Brak zmian stanu* | `[57]` **Hugo Toras**: ""Romus, I have watched you chall..."<br>`[76]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[42]` | **""You're being dramatic again, Hugo.""** | `[27]` **Hugo Toras**: ""But this proposal was a deliber..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Hugo Toras**: ""Romus, I have watched you chall..."<br>`[76]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[47]` | **""Don't let who wrote the proposal influence you for once, Hugo. The nobility must ..."** | `[27]` **Hugo Toras**: ""But this proposal was a deliber..."<br>`[32]` **Hugo Toras**: ""Please don't let the RPP influe..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true) == false` | *Brak zmian stanu* | `[57]` **Hugo Toras**: ""Romus, I have watched you chall..."<br>`[76]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[49]` | **""You said the exact same thing before.""** | `[27]` **Hugo Toras**: ""But this proposal was a deliber..."<br>`[32]` **Hugo Toras**: ""Please don't let the RPP influe..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Hugo Toras**: ""Romus, I have watched you chall..."<br>`[76]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[50]` | **""I'm not letting anyone influence me. This is my own decision. And you better resp..."** | `[32]` **Hugo Toras**: ""Please don't let the RPP influe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Hugo Toras**: ""Romus, I have watched you chall..."<br>`[76]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[51]` | **""I'm sorry but no. I have already decided.""** | `[39]` **Hugo Toras**: ""Please reconsider."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Hugo Toras**: ""Romus, I have watched you chall..."<br>`[76]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[52]` | **""How convenient.""** | `[38]` **Hugo Toras**: ""There is no point in even consi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Hugo Toras**: ""Romus, I have watched you chall..."<br>`[76]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[56]` | **""I'm sorry, Hugo, but this time I will be signing this.""** | `[126]` **Hugo Toras**: ""I want you to do the same with ..."<br>`[133]` **Narrator**: "He bowed and left the room."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[137]` **Narrator**: "I took a look at the decree." |
| `[64]` | **""You give them too much credit, Hugo. My decisions are my own.""** | `[61]` **Hugo Toras**: ""Tell me, Romus, was there even ..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[76]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[65]` | **""So, are you just opposed to it because of who proposed it?""** | `[61]` **Hugo Toras**: ""Tell me, Romus, was there even ..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[76]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[66]` | **""Yes, Hugo... I am just a mouth piece for the reformists, after all.""** | `[61]` **Hugo Toras**: ""Tell me, Romus, was there even ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Hugo Toras**: ""I didn't mean to suggest that."" |
| `[67]` | **""What does that even mean, Hugo? I advise you to be more respectful towards me.""** | `[61]` **Hugo Toras**: ""Tell me, Romus, was there even ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Hugo Toras**: ""My apologies if I caused offense."" |
| `[68]` | **""So taxation is only legitimate when it burdens the commoners? But when it reaches..."** | `[61]` **Hugo Toras**: ""Tell me, Romus, was there even ..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[76]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[72]` | **""The Houses can take their grievances and shove them exactly where they belong.""** | `[61]` **Hugo Toras**: ""Tell me, Romus, was there even ..." | `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true` | *Brak zmian stanu* | `[73]` **Narrator**: "He sighed." |
| `[78]` | **""We are going to be making money for the treasury, Hugo. This is a necessary policy.""** | `[77]` **Hugo Toras**: ""This tax is clearly aimed at th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Hugo Toras**: ""We cannot trade political stabi..." |
| `[79]` | **""Let them rage. Their approval was never a requirement.""** | `[77]` **Hugo Toras**: ""This tax is clearly aimed at th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Hugo Toras**: ""No it wasn't..."" |
| `[80]` | **""I cannot let the nobility dictate policy.""** | `[77]` **Hugo Toras**: ""This tax is clearly aimed at th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Hugo Toras**: ""And yet they do dictate much of..." |
| `[81]` | **""Yes, Hugo, because taxing the wealthiest estates is truly the gravest injustice i..."** | `[77]` **Hugo Toras**: ""This tax is clearly aimed at th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Hugo Toras**: ""I understand the sentiment..."" |
| `[82]` | **""Do you think this will push them too far?""** | `[77]` **Hugo Toras**: ""This tax is clearly aimed at th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Hugo Toras**: ""I do. And I believe you know it..." |
| `[93]` | **""The nobility is not Rizia, Hugo. The people are. If the nobles have forgotten tha..."** | `[92]` **Hugo Toras**: ""And people like that do not sit..."<br>`[111]` **Hugo Toras**: ""But it's not only the Royal Hou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Hugo Toras**: ""The nobility are the pillars of..." |
| `[94]` | **""The disparity grows wider by the year. If we continue down this path of preservat..."** | `[92]` **Hugo Toras**: ""And people like that do not sit..."<br>`[111]` **Hugo Toras**: ""But it's not only the Royal Hou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Hugo Toras**: ""We can't let the masses on the ..."<br>`[116]` **Hugo Toras**: ""We can help the poor without di..." |
| `[98]` | **""You're looking at this as a political move, Hugo. But I see it as an economic one.""** | `[92]` **Hugo Toras**: ""And people like that do not sit..."<br>`[111]` **Hugo Toras**: ""But it's not only the Royal Hou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Hugo Toras**: ""It seems it is only you and Ms...."<br>`[117]` **Hugo Toras**: ""I believe Ms. Werner also doesn..." |
| `[99]` | **""So, basically, men like you?""** | `[92]` **Hugo Toras**: ""And people like that do not sit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Narrator**: "He grunted in disapproval." |
| `[103]` | **""We've been through this, Hugo. I've already weakened them. They can't resist this..."** | `[77]` **Hugo Toras**: ""This tax is clearly aimed at th..." | `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true` | *Brak zmian stanu* | `[102]` **Hugo Toras**: ""Perhaps so."" |
| `[112]` | **""I don't care what they think. I will keep weakening them until they have no power..."** | `[111]` **Hugo Toras**: ""But it's not only the Royal Hou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Hugo Toras**: ""The nobility are the pillars of..." |
| `[120]` | **""You may have a point about the risk. I'll hold off on the decree for now.""** | `[110]` **Hugo Toras**: ""Don't forget they are holding t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Hugo Toras**: ""Thank you."" |
| `[121]` | **""No, Hugo. It's the other way around. And the nobility must pay their share of tax..."** | `[110]` **Hugo Toras**: ""Don't forget they are holding t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Player_Romus_Italic**: "I signed the decree." |
| `[122]` | **""I think I've heard enough.""** | `[110]` **Hugo Toras**: ""Don't forget they are holding t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Narrator**: "I took a look at the decree." |
| `[128]` | **""I will add another one as I see fit. This is happening, Hugo. So please don't sta..."** | `[127]` **Hugo Toras**: ""Enacting the Inheritance Tax wa..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[137]` **Narrator**: "I took a look at the decree." |
| `[129]` | **""You're repeating the same words, Hugo. I get your concerns, but you have to trust..."** | `[126]` **Hugo Toras**: ""I want you to do the same with ..."<br>`[127]` **Hugo Toras**: ""Enacting the Inheritance Tax wa..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[137]` **Narrator**: "I took a look at the decree." |
| `[130]` | **""Fine. Maybe you're right about this.""** | `[126]` **Hugo Toras**: ""I want you to do the same with ..."<br>`[127]` **Hugo Toras**: ""Enacting the Inheritance Tax wa..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[137]` **Narrator**: "I took a look at the decree." |
| `[131]` | **""No. Nobody is going to get away with not paying their share of taxes anymore.""** | `[126]` **Hugo Toras**: ""I want you to do the same with ..."<br>`[127]` **Hugo Toras**: ""Enacting the Inheritance Tax wa..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[137]` **Narrator**: "I took a look at the decree." |
| `[138]` | **"Sign the decree."** | `[121]` **Player_Romus**: ""No, Hugo. It's the other way ar..."<br>`[137]` **Narrator**: "I took a look at the decree." | *Brak (Dostępna bezwarunkowo)* | `EnactDecree("Economy_Taxes_LandOwnersTax"); Variable["Riz...` | `[140]` **Hugo Toras**: ""Very well... I hope we won't ha..." |
| `[142]` | **""You've given me a lot to consider. I'll hold off on the decree for now.""** | `[137]` **Narrator**: "I took a look at the decree." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Hugo Toras**: ""Thank you."" |

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
  - -> `[3]` (*Hugo Toras: ""Targeting wealthy landowners with a tax, I see...""*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""I'm sorry, Hugo, but this time I will be signing this.""*)

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""Targeting wealthy landowners with a tax, I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true"*)

### Węzeł `[4]`
Mówca: **Hugo Toras**
> ""We already talked about this, Romus. This is just another attempt by the RPP, like that free press proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == t..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress == true"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress == true)"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Hugo Toras: ""Your Majesty, to tax nobles' estates is to attack the ve..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Hugo Toras: ""Your approval of the RPP's other tax proposal has alread..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Hugo Toras: ""We've been through this, Romus. These tax proposals were..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_FreePress == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Hugo Toras: ""Allowing the RPP to use the media against us has already..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_FreePress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Hugo Toras: ""We already talked about this, Romus. This is just anothe..."*)

### Węzeł `[17]`
Mówca: **Hugo Toras**
> ""We've been through this, Romus. These tax proposals were deliberate attempts by the RPP to attack the royals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Hugo Toras: ""The Land Owners Tax, Inheritance Tax... What's going to ..."*)

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""The Land Owners Tax, Inheritance Tax... What's going to be next?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true"*)

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""Your approval of the RPP's other tax proposal has already left you on thin ice with the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Hugo Toras: ""You shouldn't push it too far.""*)

### Węzeł `[20]`
Mówca: **Hugo Toras**
> ""You shouldn't push it too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true |..."*)

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""Allowing the RPP to use the media against us has already created problems with the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Hugo Toras: ""Signing this would be a step too far for them.""*)

### Węzeł `[22]`
Mówca: **Hugo Toras**
> ""Signing this would be a step too far for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true |..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true |..."*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Hugo Toras: ""After what you've already taken away from them, this is ..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Hugo Toras: ""Tell me, Romus, was there even a conversation to be had ..."*)

### Węzeł `[26]`
Mówca: **Hugo Toras**
> ""After what you've already taken away from them, this is simply overkill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Hugo Toras: ""Tell me, Romus, was there even a conversation to be had ..."*)

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""But this proposal was a deliberate attempt by the RPP to attack nobles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[42]` (*Player_Romus: ""You're being dramatic again, Hugo.""*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true |..."*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Hugo Toras: ""You already weakened the Royal Houses with your decrees,..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Hugo Toras: ""Please reconsider.""*)

### Węzeł `[31]`
Mówca: **Hugo Toras**
> ""You already weakened the Royal Houses with your decrees, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Hugo Toras: ""But this proposal was a deliberate attempt by the RPP to..."*)

### Węzeł `[32]`
Mówca: **Hugo Toras**
> ""Please don't let the RPP influence you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[50]` (*Player_Romus: ""I'm not letting anyone influence me. This is my own deci..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseOfDelegates_Abolished == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Hugo Toras: ""These proposals lost all of their legitimacy when you cl..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseOfDelegates_Abolished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Hugo Toras: ""Please don't let the RPP influence you.""*)

### Węzeł `[36]`
Mówca: **Hugo Toras**
> ""These proposals lost all of their legitimacy when you closed down the House of Delegates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Hugo Toras: ""There is no point in even considering them.""*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the nobility sees taxation as an attack, that says more about them really.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Hugo Toras), `[32]` (Hugo Toras), `[38]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true"*)

### Węzeł `[38]`
Mówca: **Hugo Toras**
> ""There is no point in even considering them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player_Romus: ""How convenient.""*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[39]`
Mówca: **Hugo Toras**
> ""Please reconsider.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[51]` (*Player_Romus: ""I'm sorry but no. I have already decided.""*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So taxation is only legitimate when it burdens the commoners? But when it reaches the nobility, it's suddenly a conspiracy?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[27]` (Hugo Toras), `[32]` (Hugo Toras), `[38]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true"*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've already declared my support to the Rizian People's Party. I hope there is no confusion about this.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true`
- **Kontekst wejściowy (poprzednik):** `[27]` (Hugo Toras), `[32]` (Hugo Toras), `[38]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true"*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're being dramatic again, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_DeclareIntention_Public == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_DeclareIntention_Public == true"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_DeclareIntention_Public == true)"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_DeclareIntention_Public == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player_Romus: ""I've already declared my support to the Rizian People's ..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_DeclareIntention_Public == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player_Romus: ""Don't let who wrote the proposal influence you for once,..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player_Romus: ""You're repeating the same words, Hugo. I get your concer..."*)
  - -> `[130]` (*Player_Romus: ""Fine. Maybe you're right about this.""*)
  - -> `[131]` (*Player_Romus: ""No. Nobody is going to get away with not paying their sh..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't let who wrote the proposal influence you for once, Hugo. The nobility must pay its fair share of taxes.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[27]` (Hugo Toras), `[32]` (Hugo Toras), `[38]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player_Romus: ""You said the exact same thing before.""*)
  - -> `[37]` (*Player_Romus: ""If the nobility sees taxation as an attack, that says mo..."*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true"*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_DeclareIntention_Public == true"*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You said the exact same thing before.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Hugo Toras), `[32]` (Hugo Toras), `[38]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true"*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not letting anyone influence me. This is my own decision. And you better respect it as such.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true"*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry but no. I have already decided.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true"*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How convenient.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == t..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player_Romus: ""So taxation is only legitimate when it burdens the commo..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, Hugo, but this time I will be signing this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Hugo Toras), `[133]` (Narrator), `[141]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[57]`
Mówca: **Hugo Toras**
> ""Romus, I have watched you challenge traditions before. I have even defended you when others whispered that you were reaching too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == t..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Hugo Toras: ""Romus, I have watched you challenge traditions before. I..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Hugo Toras: ""I'm just saying, Your Majesty, that this is not merely a..."*)

### Węzeł `[61]`
Mówca: **Hugo Toras**
> ""Tell me, Romus, was there even a conversation to be had about this? Or did the RPP simply write it for you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true |..."*)
  - -> `[64]` (*Player_Romus: ""You give them too much credit, Hugo. My decisions are my..."*)
  - -> `[66]` (*Player_Romus: ""Yes, Hugo... I am just a mouth piece for the reformists,..."*)
  - -> `[65]` (*Player_Romus: ""So, are you just opposed to it because of who proposed it?""*)
  - -> `[68]` (*Player_Romus: ""So taxation is only legitimate when it burdens the commo..."*)
  - -> `[67]` (*Player_Romus: ""What does that even mean, Hugo? I advise you to be more ..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Hugo Toras: ""I'm just saying, Your Majesty, that this is not merely a..."*)

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""My apologies if I caused offense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You give them too much credit, Hugo. My decisions are my own.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So, are you just opposed to it because of who proposed it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Hugo... I am just a mouth piece for the reformists, after all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Hugo Toras: ""I didn't mean to suggest that.""*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does that even mean, Hugo? I advise you to be more respectful towards me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Hugo Toras: ""My apologies if I caused offense.""*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So taxation is only legitimate when it burdens the commoners? But when it reaches the nobility, it's suddenly a conspiracy?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true |..."*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player_Romus: ""The Houses can take their grievances and shove them exac..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Houses can take their grievances and shove them exactly where they belong.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Kontekst wejściowy (poprzednik):** `[61]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "He sighed."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Hugo Toras: ""I see.""*)

### Węzeł `[74]`
Mówca: **Hugo Toras**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[75]`
Mówca: **Hugo Toras**
> ""I didn't mean to suggest that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[76]`
Mówca: **Hugo Toras**
> ""I'm just saying, Your Majesty, that this is not merely about generating income.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Hugo Toras: ""This tax is clearly aimed at the nobility. They will see..."*)

### Węzeł `[77]`
Mówca: **Hugo Toras**
> ""This tax is clearly aimed at the nobility. They will see it as a *message* directed at them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true |..."*)
  - -> `[82]` (*Player_Romus: ""Do you think this will push them too far?""*)
  - -> `[78]` (*Player_Romus: ""We are going to be making money for the treasury, Hugo. ..."*)
  - -> `[79]` (*Player_Romus: ""Let them rage. Their approval was never a requirement.""*)
  - -> `[80]` (*Player_Romus: ""I cannot let the nobility dictate policy.""*)
  - -> `[81]` (*Player_Romus: ""Yes, Hugo, because taxing the wealthiest estates is trul..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are going to be making money for the treasury, Hugo. This is a necessary policy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Hugo Toras: ""We cannot trade political stability for revenue, Romus.""*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let them rage. Their approval was never a requirement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Hugo Toras: ""No it wasn't...""*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I cannot let the nobility dictate policy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Hugo Toras: ""And yet they do dictate much of this kingdom, whether yo..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Hugo, because taxing the wealthiest estates is truly the gravest injustice in this kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Hugo Toras: ""I understand the sentiment...""*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think this will push them too far?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Hugo Toras: ""I do. And I believe you know it too.""*)

### Węzeł `[83]`
Mówca: **Hugo Toras**
> ""I do. And I believe you know it too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Hugo Toras: ""These are the men and women who fund armies, who own lan..."*)

### Węzeł `[84]`
Mówca: **Hugo Toras**
> ""The numbers on the balance sheet won't matter if the nobility starts treating you as a threat rather than a king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Hugo Toras: ""These are the men and women who fund armies, who own lan..."*)

### Węzeł `[85]`
Mówca: **Hugo Toras**
> ""No it wasn't...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Hugo Toras: ""But their cooperation has kept this kingdom standing.""*)

### Węzeł `[86]`
Mówca: **Hugo Toras**
> ""We cannot trade political stability for revenue, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Hugo Toras: ""The numbers on the balance sheet won't matter if the nob..."*)

### Węzeł `[87]`
Mówca: **Hugo Toras**
> ""But their cooperation has kept this kingdom standing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Hugo Toras: ""These are the men and women who fund armies, who own lan..."*)

### Węzeł `[88]`
Mówca: **Hugo Toras**
> ""And yet they do dictate much of this kingdom, whether you acknowledge it or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Hugo Toras: ""But these are the men and women who fund armies, who own..."*)

### Węzeł `[89]`
Mówca: **Hugo Toras**
> ""I understand the sentiment...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Hugo Toras: ""But these are the men and women who fund armies, who own..."*)

### Węzeł `[90]`
Mówca: **Hugo Toras**
> ""But these are the men and women who fund armies, who own land, who control commerce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Hugo Toras: ""And people like that do not sit idly when they believe t..."*)

### Węzeł `[91]`
Mówca: **Hugo Toras**
> ""These are the men and women who fund armies, who own land, who control commerce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Hugo Toras: ""And people like that do not sit idly when they believe t..."*)

### Węzeł `[92]`
Mówca: **Hugo Toras**
> ""And people like that do not sit idly when they believe their future is at risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player_Romus: ""The nobility is not Rizia, Hugo. The people are. If the ..."*)
  - -> `[94]` (*Player_Romus: ""The disparity grows wider by the year. If we continue do..."*)
  - -> `[98]` (*Player_Romus: ""You're looking at this as a political move, Hugo. But I ..."*)
  - -> `[99]` (*Player_Romus: ""So, basically, men like you?""*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The nobility is not Rizia, Hugo. The people are. If the nobles have forgotten that, then it is time they remembered.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Hugo Toras), `[111]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Hugo Toras: ""The nobility are the pillars of this monarchy.""*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The disparity grows wider by the year. If we continue down this path of preservation over reform, we will not be the ones who decide when change comes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Hugo Toras), `[111]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Situat..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true |..."*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player_Romus: ""We've been through this, Hugo. I've already weakened the..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're looking at this as a political move, Hugo. But I see it as an economic one.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Hugo Toras), `[111]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget <= 3 && RiziaDLC.Country_HouseA..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So, basically, men like you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "He grunted in disapproval."*)

### Węzeł `[100]`
Mówca: **Hugo Toras**
> ""The nobility are the pillars of this monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Hugo Toras: ""Cracked, perhaps. But pillars still.""*)

### Węzeł `[101]`
Mówca: **Hugo Toras**
> ""Cracked, perhaps. But pillars still.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Hugo Toras: ""Don't forget they are holding the roof of this palace ab..."*)

### Węzeł `[102]`
Mówca: **Hugo Toras**
> ""Perhaps so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Hugo Toras: ""But it's not only the Royal Houses, Romus. If the nobili..."*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've been through this, Hugo. I've already weakened them. They can't resist this change.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Kontekst wejściowy (poprzednik):** `[77]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Hugo Toras: ""Perhaps so.""*)

### Węzeł `[104]`
Mówca: **Hugo Toras**
> ""We can't let the masses on the streets dictate policy-making.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Hugo Toras: ""The nobility are the pillars of this monarchy.""*)

### Węzeł `[105]`
Mówca: **Hugo Toras**
> ""I advise you to ignore her opinion on this topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Hugo Toras: ""The nobility are the pillars of this monarchy.""*)

### Węzeł `[106]`
Mówca: **Hugo Toras**
> ""It seems it is only you and Ms. Werner who sees it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Hugo Toras: ""I advise you to ignore her opinion on this topic.""*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget <= 3 && RiziaDLC.Country_HouseAzaro > 5 && RiziaDLC.Country_HouseSazon > 5 && RiziaDLC.Country_HouseToras > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget <= 3 && RiziaDLC.Country_HouseA..."*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget <= 3 && RiziaDLC.Country_Hous..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget <= 3 && RiziaDLC.Country_HouseAzaro > 5 && RiziaDLC.Country_HouseSazon > 5 && RiziaDLC.Country_HouseToras > 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] <= 3  and  Variable["RiziaDLC.Country_HouseAzaro"] > 5  and  Variable["RiziaDLC.Country_HouseSazon"] > 5  and  Variable["RiziaDLC.Country_HouseToras"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Hugo Toras: ""It seems it is only you and Ms. Werner who sees it that ..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget <= 3 && RiziaDLC.Country_HouseAzaro > 5 && RiziaDLC.Country_HouseSazon > 5 && RiziaDLC.Country_HouseToras > 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] <= 3  and  Variable["RiziaDLC.Country_HouseAzaro"] > 5  and  Variable["RiziaDLC.Country_HouseSazon"] > 5  and  Variable["RiziaDLC.Country_HouseToras"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Hugo Toras: ""I believe Ms. Werner also doesn't support this decree, Y..."*)

### Węzeł `[110]`
Mówca: **Hugo Toras**
> ""Don't forget they are holding the roof of this palace above our heads.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player_Romus: ""I think I've heard enough.""*)
  - -> `[121]` (*Player_Romus: ""No, Hugo. It's the other way around. And the nobility mu..."*)
  - -> `[120]` (*Player_Romus: ""You may have a point about the risk. I'll hold off on th..."*)

### Węzeł `[111]`
Mówca: **Hugo Toras**
> ""But it's not only the Royal Houses, Romus. If the nobility unites against you, they can still wield considerable influence over key people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player_Romus: ""I don't care what they think. I will keep weakening them..."*)
  - -> `[93]` (*Player_Romus: ""The nobility is not Rizia, Hugo. The people are. If the ..."*)
  - -> `[94]` (*Player_Romus: ""The disparity grows wider by the year. If we continue do..."*)
  - -> `[98]` (*Player_Romus: ""You're looking at this as a political move, Hugo. But I ..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care what they think. I will keep weakening them until they have no power over me nor the people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Hugo Toras: ""The nobility are the pillars of this monarchy.""*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Situat..."*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Situ..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Hugo Toras: ""We can't let the masses on the streets dictate policy-ma..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Hugo Toras: ""We can help the poor without disrupting the whole system.""*)

### Węzeł `[116]`
Mówca: **Hugo Toras**
> ""We can help the poor without disrupting the whole system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Hugo Toras: ""The nobility are the pillars of this monarchy.""*)

### Węzeł `[117]`
Mówca: **Hugo Toras**
> ""I believe Ms. Werner also doesn't support this decree, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Hugo Toras: ""I advise you not to ignore her opinion on this topic.""*)

### Węzeł `[118]`
Mówca: **Hugo Toras**
> ""I advise you not to ignore her opinion on this topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Hugo Toras: ""The nobility are the pillars of this monarchy.""*)

### Węzeł `[119]`
Mówca: **Narrator**
> "He grunted in disapproval."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Hugo Toras: ""The nobility are the pillars of this monarchy.""*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may have a point about the risk. I'll hold off on the decree for now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Hugo Toras: ""Thank you.""*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Hugo. It's the other way around. And the nobility must pay their share of taxes just like everyone else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player_Romus_Italic: "Sign the decree."*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think I've heard enough.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "I took a look at the decree."*)

### Węzeł `[123]`
Mówca: **Hugo Toras**
> ""I'll see you later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "He bowed and left the room."*)

### Węzeł `[124]`
Mówca: **Hugo Toras**
> ""But with this... I have to be the one telling you that you would indeed be doing just that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Hugo Toras: ""Enacting the Inheritance Tax was a big blow to the nobil..."*)

### Węzeł `[125]`
Mówca: **Hugo Toras**
> ""You listened to my advice and held off on the Inheritance Tax.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Hugo Toras: ""I want you to do the same with this.""*)

### Węzeł `[126]`
Mówca: **Hugo Toras**
> ""I want you to do the same with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[56]` (*Player_Romus: ""I'm sorry, Hugo, but this time I will be signing this.""*)

### Węzeł `[127]`
Mówca: **Hugo Toras**
> ""Enacting the Inheritance Tax was a big blow to the nobility already. Please don't add another one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player_Romus: ""I will add another one as I see fit. This is happening, ..."*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will add another one as I see fit. This is happening, Hugo. So please don't stand against me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're repeating the same words, Hugo. I get your concerns, but you have to trust my judgement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Hugo Toras), `[127]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Maybe you're right about this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Hugo Toras), `[127]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Nobody is going to get away with not paying their share of taxes anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Hugo Toras), `[127]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "I took a look at the decree."*)

### Węzeł `[133]`
Mówca: **Narrator**
> "He bowed and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true)"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Hugo Toras: ""But with this... I have to be the one telling you that y..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Hugo Toras: ""You listened to my advice and held off on the Inheritanc..."*)

### Węzeł `[137]`
Mówca: **Narrator**
> "I took a look at the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player_Romus_Italic: "Sign the decree."*)
  - -> `[142]` (*Player_Romus: ""You've given me a lot to consider. I'll hold off on the ..."*)

### Węzeł `[138]`
**[WYBÓR GRACZA: "Sign the decree."]** — Mówca: **Player_Romus_Italic**
> "I signed the decree."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Player_Romus), `[137]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "EnactDecree("Economy_Taxes_LandOwnersTax"); RiziaDLC.Hugo..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnactDecree("Economy_Taxes_LandOwnersTax");
RiziaDLC.Hugo_CounselIgnored += 1`
- **Efekt skryptowy (`userScript`):** `EnactDecree("Economy_Taxes_LandOwnersTax");
Variable["RiziaDLC.Hugo_CounselIgnored"] = Variable["RiziaDLC.Hugo_CounselIgnored"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Hugo Toras: ""Very well... I hope we won't have any trouble in its imp..."*)

### Węzeł `[140]`
Mówca: **Hugo Toras**
> ""Very well... I hope we won't have any trouble in its implementation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Hugo Toras: ""I'll see you later.""*)

### Węzeł `[141]`
Mówca: **Narrator**
> "I gave him the unsigned decree and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've given me a lot to consider. I'll hold off on the decree for now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Hugo Toras: ""Thank you.""*)

### Węzeł `[143]`
Mówca: **Hugo Toras**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "I gave him the unsigned decree and left the room."*)

### Węzeł `[144]`
Mówca: **Hugo Toras**
> ""Your Majesty, to tax nobles' estates is to attack the very foundations of the Royal Houses. Your own included, I will add.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true |..."*)
