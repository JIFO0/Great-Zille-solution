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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **"Sign the decree."** | `[6]` **Narrator**: "I took a look at the decree."<br>`[130]` **Player_Romus**: ""No, Hugo. It's the other way ar..." | *Brak (Dostępna bezwarunkowo)* | `EnactDecree("Economy_Taxes_EnactInheritenceTax"); Variabl...` | `[8]` **Hugo Toras**: ""Very well... I hope we won't ha..." |
| `[10]` | **""You've given me a lot to consider. I'll hold off on the decree for now.""** | `[6]` **Narrator**: "I took a look at the decree." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Hugo Toras**: ""Thank you."" |
| `[26]` | **""So taxation is only legitimate when it burdens the commoners? But when it reaches..."** | `[22]` **Hugo Toras**: ""Please don't let the RPP influe..."<br>`[31]` **Hugo Toras**: ""But this proposal is a delibera..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true) == false` | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Romus, I have watched you chall..."<br>`[77]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[35]` | **""Don't be so dramatic, Hugo.""** | `[31]` **Hugo Toras**: ""But this proposal is a delibera..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Romus, I have watched you chall..."<br>`[77]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[36]` | **""This is not about the RPP, nor is it about punishing the nobility. This is for Ri..."** | `[22]` **Hugo Toras**: ""Please don't let the RPP influe..."<br>`[31]` **Hugo Toras**: ""But this proposal is a delibera..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Romus, I have watched you chall..."<br>`[77]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[53]` | **""You know by now that I support the Rizian People's Party, Hugo.""** | `[22]` **Hugo Toras**: ""Please don't let the RPP influe..."<br>`[31]` **Hugo Toras**: ""But this proposal is a delibera..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true` | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Romus, I have watched you chall..."<br>`[77]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[55]` | **""Just because this is proposed by the RPP doesn't make it wrong. The nobility must..."** | `[4]` **Narrator**: "He bowed and left the room."<br>`[12]` **Narrator**: "I gave him the unsigned decree a..."<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true) == false` | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Romus, I have watched you chall..."<br>`[77]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[56]` | **""There is nothing to reconsider. I have already decided.""** | `[52]` **Hugo Toras**: ""Please reconsider."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Romus, I have watched you chall..."<br>`[77]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[60]` | **""What does that even mean, Hugo? Are you implying I'm somehow a puppet of the RPP ..."** | `[22]` **Hugo Toras**: ""Please don't let the RPP influe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Romus, I have watched you chall..."<br>`[77]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[62]` | **""You already told me that, Uncle. Maybe it's time to let this go.""** | `[22]` **Hugo Toras**: ""Please don't let the RPP influe..."<br>`[31]` **Hugo Toras**: ""But this proposal is a delibera..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Romus, I have watched you chall..."<br>`[77]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[66]` | **""How convenient.""** | `[51]` **Hugo Toras**: ""There is no point in even consi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Romus, I have watched you chall..."<br>`[77]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[68]` | **""So taxation is only legitimate when it burdens the commoners? But when it reaches..."** | `[49]` **Hugo Toras**: ""Tell me, Romus, was there even ..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[77]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[72]` | **""You give them too much credit, Hugo. My decisions are my own.""** | `[49]` **Hugo Toras**: ""Tell me, Romus, was there even ..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[77]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[73]` | **""So, are you just opposed to the decree because of who proposed it?""** | `[49]` **Hugo Toras**: ""Tell me, Romus, was there even ..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[77]` **Hugo Toras**: ""I'm just saying, Your Majesty, ..." |
| `[76]` | **""Yes, Hugo... I am just a mouthpiece for the reformists, after all.""** | `[49]` **Hugo Toras**: ""Tell me, Romus, was there even ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Hugo Toras**: ""I didn't mean to suggest that."" |
| `[89]` | **""The Houses can take their grievances and shove them exactly where they belong.""** | `[49]` **Hugo Toras**: ""Tell me, Romus, was there even ..." | `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true` | *Brak zmian stanu* | `[90]` **Narrator**: "He sighed." |
| `[95]` | **""What does that even mean, Hugo? I advise you to be more respectful towards me.""** | `[49]` **Hugo Toras**: ""Tell me, Romus, was there even ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Hugo Toras**: ""My apologies if I caused offense."" |
| `[97]` | **""Do you think this will push them too far?""** | `[78]` **Hugo Toras**: ""This tax is clearly directed at..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Hugo Toras**: ""I do. And I believe you know it..." |
| `[98]` | **""Let them rage. Their approval was never a requirement.""** | `[78]` **Hugo Toras**: ""This tax is clearly directed at..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Hugo Toras**: ""No it wasn't..."" |
| `[99]` | **""I cannot let the nobility dictate policy.""** | `[78]` **Hugo Toras**: ""This tax is clearly directed at..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Hugo Toras**: ""And yet they do dictate much of..." |
| `[102]` | **""We are going to be making money for the treasury, Hugo. This is a necessary policy.""** | `[78]` **Hugo Toras**: ""This tax is clearly directed at..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Hugo Toras**: ""We cannot trade political stabi..." |
| `[104]` | **""Yes, Hugo, because taxing the wealthiest estates is truly the gravest injustice i..."** | `[78]` **Hugo Toras**: ""This tax is clearly directed at..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Hugo Toras**: ""I understand the sentiment..."" |
| `[106]` | **""We've been through this, Hugo. I've already weakened them. They can't fight back ..."** | `[78]` **Hugo Toras**: ""This tax is clearly directed at..." | `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true` | *Brak zmian stanu* | `[85]` **Hugo Toras**: ""Perhaps so."" |
| `[113]` | **""The nobility is not Rizia, Hugo. The people are. If the nobles have forgotten tha..."** | `[75]` **Hugo Toras**: ""But it's not only the Royal Hou..."<br>`[111]` **Hugo Toras**: ""And people like that do not sit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Hugo Toras**: ""The nobility are the pillars of..." |
| `[114]` | **""The disparity between nobles and commoners grows wider by the year. If we continu..."** | `[75]` **Hugo Toras**: ""But it's not only the Royal Hou..."<br>`[111]` **Hugo Toras**: ""And people like that do not sit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Hugo Toras**: ""We can't let the masses on the ..."<br>`[124]` **Hugo Toras**: ""We can help the poor without di..." |
| `[115]` | **""You're looking at this as a political move, Hugo. But I see it as an economic one.""** | `[75]` **Hugo Toras**: ""But it's not only the Royal Hou..."<br>`[111]` **Hugo Toras**: ""And people like that do not sit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Hugo Toras**: ""It seems it is only you and Ms...."<br>`[142]` **Hugo Toras**: ""I believe Ms. Werner also doesn..." |
| `[116]` | **""So, basically, men like you?""** | `[111]` **Hugo Toras**: ""And people like that do not sit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Narrator**: "He grunted in disapproval." |
| `[120]` | **""I don't care what they think. I will keep weakening them until they have no power..."** | `[75]` **Hugo Toras**: ""But it's not only the Royal Hou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Hugo Toras**: ""The nobility are the pillars of..." |
| `[129]` | **""You may have a point about the risk. I'll hold off on the decree for now.""** | `[87]` **Hugo Toras**: ""Don't forget they are holding t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Hugo Toras**: ""Thank you."" |
| `[130]` | **""No, Hugo. It's the other way around. And the nobility must pay their share of tax..."** | `[87]` **Hugo Toras**: ""Don't forget they are holding t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Player_Romus_Italic**: "I signed the decree." |
| `[131]` | **""I think I've heard enough.""** | `[87]` **Hugo Toras**: ""Don't forget they are holding t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Narrator**: "I took a look at the decree." |
| `[133]` | **""I'm sorry, Hugo, but this time I will be signing this.""** | `[96]` **Hugo Toras**: ""I want you to do the same with ..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[6]` **Narrator**: "I took a look at the decree." |
| `[134]` | **""No. Nobody is going to get away with not paying their share of taxes anymore.""** | `[86]` **Hugo Toras**: ""The Land Owners' Tax was a big ..."<br>`[96]` **Hugo Toras**: ""I want you to do the same with ..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[6]` **Narrator**: "I took a look at the decree." |
| `[136]` | **""You're repeating the same words, Hugo. I understand your concerns, but you have t..."** | `[86]` **Hugo Toras**: ""The Land Owners' Tax was a big ..."<br>`[96]` **Hugo Toras**: ""I want you to do the same with ..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[6]` **Narrator**: "I took a look at the decree." |
| `[137]` | **""I will add another one as I see fit. This is happening, Hugo. So please don't sta..."** | `[86]` **Hugo Toras**: ""The Land Owners' Tax was a big ..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[6]` **Narrator**: "I took a look at the decree." |
| `[138]` | **""Fine. Maybe you're right about this.""** | `[86]` **Hugo Toras**: ""The Land Owners' Tax was a big ..."<br>`[96]` **Hugo Toras**: ""I want you to do the same with ..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[6]` **Narrator**: "I took a look at the decree." |

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
  - -> `[3]` (*Hugo Toras: ""You would tax the dead now?""*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus: ""Just because this is proposed by the RPP doesn't make it..."*)

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""You would tax the dead now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "He bowed and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnactDecree("Economy_Taxes_EnactInheritenceTax");
RiziaDLC.Hugo_CounselIgnored += 1`
- **Efekt skryptowy (`userScript`):** `EnactDecree("Economy_Taxes_EnactInheritenceTax");
Variable["RiziaDLC.Hugo_CounselIgnored"] = Variable["RiziaDLC.Hugo_CounselIgnored"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Hugo Toras: ""Very well... I hope we won't have any trouble in its imp..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "I took a look at the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Romus_Italic: "Sign the decree."*)
  - -> `[10]` (*Player_Romus: ""You've given me a lot to consider. I'll hold off on the ..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "Sign the decree."]** — Mówca: **Player_Romus_Italic**
> "I signed the decree."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator), `[130]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "EnactDecree("Economy_Taxes_EnactInheritenceTax"); RiziaDL..."*)

### Węzeł `[8]`
Mówca: **Hugo Toras**
> ""Very well... I hope we won't have any trouble in its implementation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Hugo Toras: ""I'll see you later.""*)

### Węzeł `[9]`
Mówca: **Hugo Toras**
> ""I'll see you later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "He bowed and left the room."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've given me a lot to consider. I'll hold off on the decree for now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Hugo Toras: ""Thank you.""*)

### Węzeł `[11]`
Mówca: **Hugo Toras**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "I gave him the unsigned decree and left the room."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "I gave him the unsigned decree and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Hugo Toras: ""Your approval of the RPP's other tax proposal has alread..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Hugo Toras: ""We've been through this, Romus. These tax proposals were..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress == true"*)

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""We've been through this, Romus. These tax proposals were deliberate attempts by the RPP to attack the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Hugo Toras: ""The Land Owners' Tax, Inheritance Tax... What will they ..."*)

### Węzeł `[20]`
Mówca: **Hugo Toras**
> ""The Land Owners' Tax, Inheritance Tax... What will they try to take from us next?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true"*)

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""You already weakened the Royal Houses with your decrees, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Hugo Toras: ""But this proposal is a deliberate attempt by the RPP to ..."*)

### Węzeł `[22]`
Mówca: **Hugo Toras**
> ""Please don't let the RPP influence you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[60]` (*Player_Romus: ""What does that even mean, Hugo? Are you implying I'm som..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseOfDelegates_Abolished == true)"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Hugo Toras: ""These proposals already lost all of their legitimacy whe..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseOfDelegates_Abolished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Hugo Toras: ""Please don't let the RPP influence you.""*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So taxation is only legitimate when it burdens the commoners? But when it reaches the nobility, it's suddenly a conspiracy?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[22]` (Hugo Toras), `[31]` (Hugo Toras), `[51]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true"*)

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""Your approval of the RPP's other tax proposal has already left you on thin ice with the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Hugo Toras: ""You shouldn't push it too far.""*)

### Węzeł `[28]`
Mówca: **Hugo Toras**
> ""You shouldn't push it too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true |..."*)

### Węzeł `[29]`
Mówca: **Hugo Toras**
> ""Allowing the RPP to use the media against us has already led to problems with the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Hugo Toras: ""Signing this would be a step too far for them.""*)

### Węzeł `[30]`
Mówca: **Hugo Toras**
> ""Signing this would be a step too far for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true |..."*)

### Węzeł `[31]`
Mówca: **Hugo Toras**
> ""But this proposal is a deliberate attempt by the RPP to attack the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[35]` (*Player_Romus: ""Don't be so dramatic, Hugo.""*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true |..."*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Hugo Toras: ""You already weakened the Royal Houses with your decrees,..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Hugo Toras: ""Please reconsider.""*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't be so dramatic, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true"*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is not about the RPP, nor is it about punishing the nobility. This is for Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Hugo Toras), `[31]` (Hugo Toras), `[51]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player_Romus: ""You already told me that, Uncle. Maybe it's time to let ..."*)
  - -> `[36]` (*Player_Romus: ""This is not about the RPP, nor is it about punishing the..."*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_DeclareIntention_Public == true"*)

### Węzeł `[38]`
Mówca: **Hugo Toras**
> ""We've already talked about this, Romus. This is just another attempt by the RPP to undermine the nobility, like that free press proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress == true"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress == true)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Hugo Toras: ""The Houses' noble standing -- including our own, I'll re..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_FreePress == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Hugo Toras: ""Allowing the RPP to use the media against us has already..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_FreePress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Hugo Toras: ""We've already talked about this, Romus. This is just ano..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true |..."*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Hugo Toras: ""Especially not after what you've already taken from them.""*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Hugo Toras: ""Tell me, Romus, was there even a conversation to be had ..."*)

### Węzeł `[48]`
Mówca: **Hugo Toras**
> ""Especially not after what you've already taken from them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Hugo Toras: ""Tell me, Romus, was there even a conversation to be had ..."*)

### Węzeł `[49]`
Mówca: **Hugo Toras**
> ""Tell me, Romus, was there even a conversation to be had about this? Or did the RPP simply write it for you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true |..."*)
  - -> `[72]` (*Player_Romus: ""You give them too much credit, Hugo. My decisions are my..."*)
  - -> `[76]` (*Player_Romus: ""Yes, Hugo... I am just a mouthpiece for the reformists, ..."*)
  - -> `[73]` (*Player_Romus: ""So, are you just opposed to the decree because of who pr..."*)
  - -> `[68]` (*Player_Romus: ""So taxation is only legitimate when it burdens the commo..."*)
  - -> `[95]` (*Player_Romus: ""What does that even mean, Hugo? I advise you to be more ..."*)

### Węzeł `[50]`
Mówca: **Hugo Toras**
> ""These proposals already lost all of their legitimacy when you closed down the House of Delegates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Hugo Toras: ""There is no point in even considering them.""*)

### Węzeł `[51]`
Mówca: **Hugo Toras**
> ""There is no point in even considering them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player_Romus: ""How convenient.""*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[52]`
Mówca: **Hugo Toras**
> ""Please reconsider.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[56]` (*Player_Romus: ""There is nothing to reconsider. I have already decided.""*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know by now that I support the Rizian People's Party, Hugo.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true`
- **Kontekst wejściowy (poprzednik):** `[22]` (Hugo Toras), `[31]` (Hugo Toras), `[51]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Hugo Toras: ""I'm just saying, Your Majesty, that this is not just a t..."*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just because this is proposed by the RPP doesn't make it wrong. The nobility must also pay its fair share of taxes.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator), `[12]` (Narrator), `[22]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true"*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is nothing to reconsider. I have already decided.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_DeclareIntention_Public == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_DeclareIntention_Public == true"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_DeclareIntention_Public == true)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_DeclareIntention_Public == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: ""You know by now that I support the Rizian People's Party..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_DeclareIntention_Public == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus: ""Just because this is proposed by the RPP doesn't make it..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does that even mean, Hugo? Are you implying I'm somehow a puppet of the RPP now -- that I can't decide on my own?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true"*)

### Węzeł `[61]`
Mówca: **Hugo Toras**
> ""My apologies if I caused offense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You already told me that, Uncle. Maybe it's time to let this go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Hugo Toras), `[31]` (Hugo Toras), `[51]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""So taxation is only legitimate when it burdens the commo..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How convenient.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true"*)

### Węzeł `[67]`
Mówca: **Hugo Toras**
> ""Romus, I have watched you challenge traditions before. I have even defended you when others whispered that you were reaching too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true"*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So taxation is only legitimate when it burdens the commoners? But when it reaches the nobility, it's suddenly a conspiracy?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Romus, I have watched you challenge traditions before. I..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Hugo Toras: ""I'm just saying, Your Majesty, that this is not just a t..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You give them too much credit, Hugo. My decisions are my own.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So, are you just opposed to the decree because of who proposed it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[74]`
Mówca: **Hugo Toras**
> ""You listened to my advice and held off on the Land Owners' Tax.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Hugo Toras: ""I want you to do the same with this.""*)

### Węzeł `[75]`
Mówca: **Hugo Toras**
> ""But it's not only the Royal Houses, Romus. If the nobility unites against you, they can still wield considerable influence over key people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player_Romus: ""I don't care what they think. I will keep weakening them..."*)
  - -> `[113]` (*Player_Romus: ""The nobility is not Rizia, Hugo. The people are. If the ..."*)
  - -> `[114]` (*Player_Romus: ""The disparity between nobles and commoners grows wider b..."*)
  - -> `[115]` (*Player_Romus: ""You're looking at this as a political move, Hugo. But I ..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Hugo... I am just a mouthpiece for the reformists, after all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Hugo Toras: ""I didn't mean to suggest that.""*)

### Węzeł `[77]`
Mówca: **Hugo Toras**
> ""I'm just saying, Your Majesty, that this is not just a tax.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Hugo Toras: ""This tax is clearly directed at the nobility. They will ..."*)

### Węzeł `[78]`
Mówca: **Hugo Toras**
> ""This tax is clearly directed at the nobility. They will see it as a *message* directed at them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true |..."*)
  - -> `[97]` (*Player_Romus: ""Do you think this will push them too far?""*)
  - -> `[102]` (*Player_Romus: ""We are going to be making money for the treasury, Hugo. ..."*)
  - -> `[98]` (*Player_Romus: ""Let them rage. Their approval was never a requirement.""*)
  - -> `[99]` (*Player_Romus: ""I cannot let the nobility dictate policy.""*)
  - -> `[104]` (*Player_Romus: ""Yes, Hugo, because taxing the wealthiest estates is trul..."*)

### Węzeł `[79]`
Mówca: **Hugo Toras**
> ""The nobility are the pillars of this monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Hugo Toras: ""Cracked, perhaps. But pillars still.""*)

### Węzeł `[80]`
Mówca: **Hugo Toras**
> ""Cracked, perhaps. But pillars still.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Hugo Toras: ""Don't forget they are holding the roof of this palace ab..."*)

### Węzeł `[81]`
Mówca: **Hugo Toras**
> ""I didn't mean to suggest that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true"*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true)"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Hugo Toras: ""But with this... I have to be the one telling you that y..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Hugo Toras: ""You listened to my advice and held off on the Land Owner..."*)

### Węzeł `[85]`
Mówca: **Hugo Toras**
> ""Perhaps so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Hugo Toras: ""But it's not only the Royal Houses, Romus. If the nobili..."*)

### Węzeł `[86]`
Mówca: **Hugo Toras**
> ""The Land Owners' Tax was a big blow to the nobility already. Please don't add insult to injury.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[137]` (*Player_Romus: ""I will add another one as I see fit. This is happening, ..."*)

### Węzeł `[87]`
Mówca: **Hugo Toras**
> ""Don't forget they are holding the roof of this palace above our heads.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player_Romus: ""I think I've heard enough.""*)
  - -> `[130]` (*Player_Romus: ""No, Hugo. It's the other way around. And the nobility mu..."*)
  - -> `[129]` (*Player_Romus: ""You may have a point about the risk. I'll hold off on th..."*)

### Węzeł `[88]`
Mówca: **Hugo Toras**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Houses can take their grievances and shove them exactly where they belong.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Kontekst wejściowy (poprzednik):** `[49]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "He sighed."*)

### Węzeł `[90]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Hugo Toras: ""I see.""*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true |..."*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""The Houses can take their grievances and shove them exac..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[94]`
Mówca: **Hugo Toras**
> ""But with this... I have to be the one telling you that you would indeed be doing just that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Hugo Toras: ""The Land Owners' Tax was a big blow to the nobility alre..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does that even mean, Hugo? I advise you to be more respectful towards me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Hugo Toras: ""My apologies if I caused offense.""*)

### Węzeł `[96]`
Mówca: **Hugo Toras**
> ""I want you to do the same with this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[133]` (*Player_Romus: ""I'm sorry, Hugo, but this time I will be signing this.""*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think this will push them too far?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Hugo Toras: ""I do. And I believe you know it too.""*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let them rage. Their approval was never a requirement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Hugo Toras: ""No it wasn't...""*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I cannot let the nobility dictate policy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Hugo Toras: ""And yet they do dictate much of this kingdom, whether yo..."*)

### Węzeł `[100]`
Mówca: **Hugo Toras**
> ""The numbers on the balance sheet won't matter if the nobility starts treating you as a threat rather than a king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Hugo Toras: ""These are the men and women who fund armies, who own lan..."*)

### Węzeł `[101]`
Mówca: **Hugo Toras**
> ""We cannot trade political stability for revenue, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Hugo Toras: ""The numbers on the balance sheet won't matter if the nob..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are going to be making money for the treasury, Hugo. This is a necessary policy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Hugo Toras: ""We cannot trade political stability for revenue, Romus.""*)

### Węzeł `[103]`
Mówca: **Hugo Toras**
> ""No it wasn't...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Hugo Toras: ""But their cooperation has kept this kingdom standing.""*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Hugo, because taxing the wealthiest estates is truly the gravest injustice in this kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Hugo Toras: ""I understand the sentiment...""*)

### Węzeł `[105]`
Mówca: **Hugo Toras**
> ""I do. And I believe you know it too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Hugo Toras: ""These are the men and women who fund armies, who own lan..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've been through this, Hugo. I've already weakened them. They can't fight back against this change.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Kontekst wejściowy (poprzednik):** `[78]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Hugo Toras: ""Perhaps so.""*)

### Węzeł `[107]`
Mówca: **Hugo Toras**
> ""But their cooperation has kept this kingdom standing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Hugo Toras: ""These are the men and women who fund armies, who own lan..."*)

### Węzeł `[108]`
Mówca: **Hugo Toras**
> ""I understand the sentiment...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Hugo Toras: ""But these are the men and women who fund armies, who own..."*)

### Węzeł `[109]`
Mówca: **Hugo Toras**
> ""But these are the men and women who fund armies, who own land, who control commerce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Hugo Toras: ""And people like that do not sit idly when they believe t..."*)

### Węzeł `[110]`
Mówca: **Hugo Toras**
> ""These are the men and women who fund armies, who own land, who control commerce.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Hugo Toras: ""And people like that do not sit idly when they believe t..."*)

### Węzeł `[111]`
Mówca: **Hugo Toras**
> ""And people like that do not sit idly when they believe their future is at risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player_Romus: ""The nobility is not Rizia, Hugo. The people are. If the ..."*)
  - -> `[114]` (*Player_Romus: ""The disparity between nobles and commoners grows wider b..."*)
  - -> `[115]` (*Player_Romus: ""You're looking at this as a political move, Hugo. But I ..."*)
  - -> `[116]` (*Player_Romus: ""So, basically, men like you?""*)

### Węzeł `[112]`
Mówca: **Hugo Toras**
> ""And yet they do dictate much of this kingdom, whether you acknowledge it or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Hugo Toras: ""But these are the men and women who fund armies, who own..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The nobility is not Rizia, Hugo. The people are. If the nobles have forgotten that, then it is time they remembered.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Hugo Toras), `[111]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Hugo Toras: ""The nobility are the pillars of this monarchy.""*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The disparity between nobles and commoners grows wider by the year. If we continue down this path of preservation over reform, we will not be the ones who decide when change comes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Hugo Toras), `[111]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Situat..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're looking at this as a political move, Hugo. But I see it as an economic one.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Hugo Toras), `[111]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget <= 3 && RiziaDLC.Country_HouseA..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So, basically, men like you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "He grunted in disapproval."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true |..."*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player_Romus: ""We've been through this, Hugo. I've already weakened the..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true || RiziaDLC.Policy_RD_Order_RemoveProvincialPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true  or  Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialPolice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care what they think. I will keep weakening them until they have no power over me nor the people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Hugo Toras: ""The nobility are the pillars of this monarchy.""*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Situat..."*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Situ..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Hugo Toras: ""We can't let the masses on the streets dictate policy-ma..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Grows == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Hugo Toras: ""We can help the poor without disrupting the whole system.""*)

### Węzeł `[124]`
Mówca: **Hugo Toras**
> ""We can help the poor without disrupting the whole system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Hugo Toras: ""The nobility are the pillars of this monarchy.""*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget <= 3 && RiziaDLC.Country_HouseAzaro > 5 && RiziaDLC.Country_HouseSazon > 5 && RiziaDLC.Country_HouseToras > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget <= 3 && RiziaDLC.Country_HouseA..."*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget <= 3 && RiziaDLC.Country_Hous..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget <= 3 && RiziaDLC.Country_HouseAzaro > 5 && RiziaDLC.Country_HouseSazon > 5 && RiziaDLC.Country_HouseToras > 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] <= 3  and  Variable["RiziaDLC.Country_HouseAzaro"] > 5  and  Variable["RiziaDLC.Country_HouseSazon"] > 5  and  Variable["RiziaDLC.Country_HouseToras"] > 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Hugo Toras: ""It seems it is only you and Ms. Werner who see it that w..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget <= 3 && RiziaDLC.Country_HouseAzaro > 5 && RiziaDLC.Country_HouseSazon > 5 && RiziaDLC.Country_HouseToras > 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] <= 3  and  Variable["RiziaDLC.Country_HouseAzaro"] > 5  and  Variable["RiziaDLC.Country_HouseSazon"] > 5  and  Variable["RiziaDLC.Country_HouseToras"] > 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Hugo Toras: ""I believe Ms. Werner also doesn't support this decree, Y..."*)

### Węzeł `[128]`
Mówca: **Narrator**
> "He grunted in disapproval."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Hugo Toras: ""The nobility are the pillars of this monarchy.""*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may have a point about the risk. I'll hold off on the decree for now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Hugo Toras: ""Thank you.""*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Hugo. It's the other way around. And the nobility must pay their share of taxes just like everyone else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Romus_Italic: "Sign the decree."*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think I've heard enough.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "I took a look at the decree."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player_Romus: ""You're repeating the same words, Hugo. I understand your..."*)
  - -> `[138]` (*Player_Romus: ""Fine. Maybe you're right about this.""*)
  - -> `[134]` (*Player_Romus: ""No. Nobody is going to get away with not paying their sh..."*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, Hugo, but this time I will be signing this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Nobody is going to get away with not paying their share of taxes anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Hugo Toras), `[96]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "I took a look at the decree."*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're repeating the same words, Hugo. I understand your concerns, but you have to trust my judgement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Hugo Toras), `[96]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will add another one as I see fit. This is happening, Hugo. So please don't stand against me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Maybe you're right about this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Hugo Toras), `[96]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[139]`
Mówca: **Hugo Toras**
> ""I advise you to ignore her opinion on this topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Hugo Toras: ""The nobility are the pillars of this monarchy.""*)

### Węzeł `[140]`
Mówca: **Hugo Toras**
> ""We can't let the masses on the streets dictate policy-making.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Hugo Toras: ""The nobility are the pillars of this monarchy.""*)

### Węzeł `[141]`
Mówca: **Hugo Toras**
> ""It seems it is only you and Ms. Werner who see it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Hugo Toras: ""I advise you to ignore her opinion on this topic.""*)

### Węzeł `[142]`
Mówca: **Hugo Toras**
> ""I believe Ms. Werner also doesn't support this decree, Your Majesty. Despite its potential impact on the treasury.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Hugo Toras: ""I advise you not to ignore her opinion on this topic.""*)

### Węzeł `[143]`
Mówca: **Hugo Toras**
> ""I advise you not to ignore her opinion on this topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Hugo Toras: ""The nobility are the pillars of this monarchy.""*)

### Węzeł `[144]`
Mówca: **Hugo Toras**
> ""The Houses' noble standing -- including our own, I'll remind you -- depends on the flow of wealth from generation to generation. You cannot simply take that away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true |..."*)
