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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[9]` | **""Homosexuals aren't freaks. They're people like you and me. Perhaps they're even l..."** | `[7]` **Hugo Toras**: ""You've already dismantled our s..."<br>`[8]` **Hugo Toras**: ""It is firmly enshrined in our s..." | `Variable["RiziaDLC.Relations_Pabel_Together"] == true` | *Brak zmian stanu* | `[13]` **Narrator**: "His eyes narrowed in suspicion. ..." |
| `[15]` | **""Look at my reign so far, Hugo. Am I a king who gives a damn about tradition?""** | `[14]` **Hugo Toras**: ""Be that as it may, the majority..."<br>`[40]` **Hugo Toras**: ""The majority of Rizians want th..." | `Variable["RiziaDLC.PersonalValue_BrokeTradition"] > 2` | *Brak zmian stanu* | `[41]` **Hugo Toras**: ""No, and your authority as monar..." |
| `[19]` | **""Tradition is important to me as well. But not when maintaining it leads to people..."** | `[14]` **Hugo Toras**: ""Be that as it may, the majority..."<br>`[40]` **Hugo Toras**: ""The majority of Rizians want th..." | `(Variable["RiziaDLC.PersonalValue_BrokeTradition"] > 2) == false` | *Brak zmian stanu* | `[47]` **Hugo Toras**: ""The repercussions of disregardi..." |
| `[20]` | **""I don't understand. It's not as if I'm proposing a ban on heterosexuality. This d..."** | `[14]` **Hugo Toras**: ""Be that as it may, the majority..."<br>`[40]` **Hugo Toras**: ""The majority of Rizians want th..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Hugo Toras**: ""It will hurt you, Romus."" |
| `[22]` | **""*If* Nur exists, He would want His creations to practice love and tolerance, not ..."** | `[7]` **Hugo Toras**: ""You've already dismantled our s..."<br>`[8]` **Hugo Toras**: ""It is firmly enshrined in our s..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[27]` **Narrator**: "Hugo shook his head." |
| `[26]` | **""The Nur I worship smiles upon all forms of love. He would not want His creations ..."** | `[7]` **Hugo Toras**: ""You've already dismantled our s..."<br>`[8]` **Hugo Toras**: ""It is firmly enshrined in our s..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[27]` **Narrator**: "Hugo shook his head." |
| `[28]` | **""Homosexuals are deviants, yes. But they deserve re-education, not prison.""** | `[8]` **Hugo Toras**: ""It is firmly enshrined in our s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Narrator**: "Hugo shook his head." |
| `[30]` | **""Innocent people are dying because of this law. It's my moral imperative to get ri..."** | `[7]` **Hugo Toras**: ""You've already dismantled our s..."<br>`[8]` **Hugo Toras**: ""It is firmly enshrined in our s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Hugo Toras**: ""The Montalvo affair... yes, tra..." |
| `[34]` | **""It does. They must fix their hearts or die.""** | `[33]` **Hugo Toras**: ""Watch your words, my nephew. Th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Hugo Toras**: ""And how long will they tolerate..." |
| `[35]` | **""It makes them misguided. Over time, they'll come to accept homosexuality, just as..."** | `[33]` **Hugo Toras**: ""Watch your words, my nephew. Th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Hugo Toras**: ""Your grandmother was a great re..." |
| `[36]` | **""They don't really believe that homosexuality is a sin. They've been brainwashed b..."** | `[33]` **Hugo Toras**: ""Watch your words, my nephew. Th..." | `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true` | *Brak zmian stanu* | `[46]` **Hugo Toras**: ""And how long will they tolerate..." |
| `[43]` | **""Are you sure that's what they want? What if they've just been afraid to speak out..."** | `[14]` **Hugo Toras**: ""Be that as it may, the majority..."<br>`[33]` **Hugo Toras**: ""Watch your words, my nephew. Th..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Hugo Toras**: ""Despite your efforts, your subj..."<br>`[57]` **Hugo Toras**: ""Most of your subjects are Wruhe..." |
| `[48]` | **""I want homosexuals in our kingdom to live without fear of oppression.""** | `[82]` **Hugo Toras**: ""Let me ask you this. What exact..." | `(Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 0) == false` | *Brak zmian stanu* | `[69]` **Hugo Toras**: ""So you would throw away your ot..." |
| `[62]` | **""I have... close friends in the homosexual community. I want them to live without ..."** | `[82]` **Hugo Toras**: ""Let me ask you this. What exact..." | `Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 0` | *Brak zmian stanu* | `[68]` **Hugo Toras**: ""So you would throw away your ot..." |
| `[63]` | **""I want to build a more enlightened and just society. If even one Rizian goes to j..."** | `[82]` **Hugo Toras**: ""Let me ask you this. What exact..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Hugo Toras**: ""You cannot enlighten society wi..." |
| `[64]` | **""It's all part of my geopolitical strategy. I'm looking to improve relations with ..."** | `[82]` **Hugo Toras**: ""Let me ask you this. What exact..." | `Variable["RiziaDLC.CountryRelation_Derdia_Allied"] == false` | *Brak zmian stanu* | `[73]` **Hugo Toras**: ""I understand the importance of ..." |
| `[72]` | **""I don't need to justify my decision to you. My mind is made up.""** | `[82]` **Hugo Toras**: ""Let me ask you this. What exact..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Narrator**: "My uncle sighed heavily." |
| `[83]` | **""Persecuting homosexuals isn't just morally wrong, it's bad for our global image. ..."** | `[82]` **Hugo Toras**: ""Let me ask you this. What exact..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Hugo Toras**: ""And by 'the rest of the world',..." |
| `[87]` | **""That's rich, coming from someone who wanted my daughter to enter into an incestuo..."** | `[7]` **Hugo Toras**: ""You've already dismantled our s..."<br>`[8]` **Hugo Toras**: ""It is firmly enshrined in our s..." | `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == false  and  (Variable["RiziaDLC.Rico_Arrested"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] > 7)` | *Brak zmian stanu* | `[88]` **Hugo Toras**: ""Whether or not you personally a..." |
| `[90]` | **""That's rich, coming from someone who wants my daughter to enter into an incestuou..."** | `[7]` **Hugo Toras**: ""You've already dismantled our s..."<br>`[8]` **Hugo Toras**: ""It is firmly enshrined in our s..." | `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == false  and  (Variable["RiziaDLC.Rico_Arrested"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] > 7)) == false` | *Brak zmian stanu* | `[88]` **Hugo Toras**: ""Whether or not you personally a..." |
| `[91]` | **""And you don't think that's a problem?""** | `[89]` **Hugo Toras**: ""Most Rizians wouldn't bat an ey..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Hugo Toras**: ""I am merely telling you how it ..." |
| `[92]` | **""Yes, because the Sanctuary has brainwashed them into feeling that way.""** | `[89]` **Hugo Toras**: ""Most Rizians wouldn't bat an ey..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[46]` **Hugo Toras**: ""And how long will they tolerate..." |
| `[96]` | **""You don't know that. Maybe Rizians are more supportive of homosexuality than you ..."** | `[89]` **Hugo Toras**: ""Most Rizians wouldn't bat an ey..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Hugo Toras**: ""Despite your efforts, your subj..."<br>`[57]` **Hugo Toras**: ""Most of your subjects are Wruhe..." |
| `[114]` | **"Sign the decree."** | `[125]` **Hugo Toras**: ""So be it, then.""<br>`[135]` **Hugo Toras**: ""Take all the time you need.""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `EnactDecree("Welfare_HumanRights_DecriminalizeHomosexuali...`<br>`Variable["RiziaDLC.Hugo_CounselIgnored"] = Variable["Rizi...` | `[115]` **Narrator**: "Hugo lifted it off the table by ..." |
| `[117]` | **""Have it your way, Your Grace. The law shall stay as it is for now.""** | `[135]` **Hugo Toras**: ""Take all the time you need.""<br>`[151]` **Hugo Toras**: ""So please, think carefully. Is ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Hugo Toras**: ""From the bottom of my heart, I ..." |
| `[122]` | **""It's not frivolous to me. You're on the wrong side of history.""** | `[110]` **Hugo Toras**: ""This is your decision to make. ..."<br>`[111]` **Hugo Toras**: ""This is your decision to make. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Narrator**: "He shot me a sharp glance."<br>`[141]` **Hugo Toras**: ""I had no idea this topic meant ..." |
| `[123]` | **""There's nothing 'divisive' about it to me. You're on the wrong side of history.""** | `[103]` **Hugo Toras**: ""This is your decision to make. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Narrator**: "He shot me a sharp glance."<br>`[141]` **Hugo Toras**: ""I had no idea this topic meant ..." |
| `[124]` | **""That doesn't matter. History will vindicate me.""** | `[71]` **Hugo Toras**: ""This is your decision to make. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Narrator**: "He shot me a sharp glance."<br>`[141]` **Hugo Toras**: ""I had no idea this topic meant ..." |
| `[126]` | **""You wouldn't think that way if you were homosexual yourself. Can't you empathize ..."** | `[71]` **Hugo Toras**: ""This is your decision to make. ..."<br>`[103]` **Hugo Toras**: ""This is your decision to make. ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Narrator**: "He shot me a sharp glance."<br>`[142]` **Narrator**: "His response came almost instantly." |
| `[131]` | **""I know I'm taking a risk. But nothing is more important to me than achieving equa..."** | `[71]` **Hugo Toras**: ""This is your decision to make. ..."<br>`[103]` **Hugo Toras**: ""This is your decision to make. ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Narrator**: "He shot me a sharp glance."<br>`[141]` **Hugo Toras**: ""I had no idea this topic meant ..." |
| `[134]` | **""You've made your point, Hugo. I need to think about this.""** | `[71]` **Hugo Toras**: ""This is your decision to make. ..."<br>`[103]` **Hugo Toras**: ""This is your decision to make. ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Hugo Toras**: ""Take all the time you need."" |
| `[148]` | **""You're my Grand Vizier. What do you think the repercussions will be?""** | `[132]` **Hugo Toras**: ""This is your decision to make. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Hugo Toras**: ""I'll be honest. If ever there w..."<br>`[147]` **Hugo Toras**: ""I will be honest. Decriminalizi..." |

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
  - -> `[3]` (*Hugo Toras: ""Your Majesty. I know I'm old and stuck in my ways. But t..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Hugo Toras: ""So you would throw away your other priorities as king to..."*)

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""Your Majesty. I know I'm old and stuck in my ways. But trust me when I tell you this decree is a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Hugo Toras: ""You've already dismantled our state religion. Now you wa..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Hugo Toras: ""It is firmly enshrined in our state religion that same-s..."*)

### Węzeł `[7]`
Mówca: **Hugo Toras**
> ""You've already dismantled our state religion. Now you want to take an axe to the laws of Nur and nature?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[30]` (*Player_Romus: ""Innocent people are dying because of this law. It's my m..."*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == false && (RiziaDLC..."*)

### Węzeł `[8]`
Mówca: **Hugo Toras**
> ""It is firmly enshrined in our state religion that same-sex relations are in defiance of the laws of both Nur and nature.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[28]` (*Player_Romus: ""Homosexuals are deviants, yes. But they deserve re-educa..."*)
  - -> `[30]` (*Player_Romus: ""Innocent people are dying because of this law. It's my m..."*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == false && (RiziaDLC..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Homosexuals aren't freaks. They're people like you and me. Perhaps they're even living right under your nose.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Kontekst wejściowy (poprzednik):** `[7]` (Hugo Toras), `[8]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "His eyes narrowed in suspicion. He shook his head."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus: ""Homosexuals aren't freaks. They're people like you and m..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[13]`
Mówca: **Narrator**
> "His eyes narrowed in suspicion. He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Hugo Toras: ""Be that as it may, the majority of Rizians do not want t..."*)

### Węzeł `[14]`
Mówca: **Hugo Toras**
> ""Be that as it may, the majority of Rizians do not want this law to change. They wish to see our traditional values preserved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player_Romus: ""Are you sure that's what they want? What if they've just..."*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_BrokeTradition > 2"*)
  - -> `[20]` (*Player_Romus: ""I don't understand. It's not as if I'm proposing a ban o..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look at my reign so far, Hugo. Am I a king who gives a damn about tradition?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_BrokeTradition"] > 2`
- **Kontekst wejściowy (poprzednik):** `[14]` (Hugo Toras), `[40]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Hugo Toras: ""No, and your authority as monarch has suffered for it. T..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_BrokeTradition > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_BrokeTradition > 2"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_BrokeTradition > 2)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_BrokeTradition > 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_BrokeTradition"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player_Romus: ""Look at my reign so far, Hugo. Am I a king who gives a d..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_BrokeTradition > 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_BrokeTradition"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: ""Tradition is important to me as well. But not when maint..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tradition is important to me as well. But not when maintaining it leads to people suffering.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PersonalValue_BrokeTradition"] > 2) == false`
- **Kontekst wejściowy (poprzednik):** `[14]` (Hugo Toras), `[40]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Hugo Toras: ""The repercussions of disregarding it will be even worse.""*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't understand. It's not as if I'm proposing a ban on heterosexuality. This decree will help thousands while hurting no one.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Hugo Toras), `[40]` (Hugo Toras), `[89]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Hugo Toras: ""It will hurt you, Romus.""*)

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""It will hurt you, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_AuthorityModifiersTotal <= 2"*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""*If* Nur exists, He would want His creations to practice love and tolerance, not hate and bigotry.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[7]` (Hugo Toras), `[8]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Hugo shook his head."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""The Nur I worship smiles upon all forms of love. He woul..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus: ""*If* Nur exists, He would want His creations to practice..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Nur I worship smiles upon all forms of love. He would not want His creations to practice hate and bigotry.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[7]` (Hugo Toras), `[8]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Hugo shook his head."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "Hugo shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Hugo Toras: ""Watch your words, my nephew. The majority of Rizians wis..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Homosexuals are deviants, yes. But they deserve re-education, not prison.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "Hugo shook his head."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "Hugo shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Hugo Toras: ""The majority of Rizians want the law to stay as it is. N..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Innocent people are dying because of this law. It's my moral imperative to get rid of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Hugo Toras), `[8]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Hugo Toras: ""The Montalvo affair... yes, tragic. I read about it as w..."*)

### Węzeł `[31]`
Mówca: **Hugo Toras**
> ""The Montalvo affair... yes, tragic. I read about it as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Hugo Toras: ""But the man was killed by a rogue prison guard. Not our ..."*)

### Węzeł `[32]`
Mówca: **Hugo Toras**
> ""But the man was killed by a rogue prison guard. Not our laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Hugo Toras: ""The majority of Rizians want the law to stay as it is. N..."*)

### Węzeł `[33]`
Mówca: **Hugo Toras**
> ""Watch your words, my nephew. The majority of Rizians wish to preserve our traditional values. Does that make them hateful or bigoted?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""It does. They must fix their hearts or die.""*)
  - -> `[35]` (*Player_Romus: ""It makes them misguided. Over time, they'll come to acce..."*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true"*)
  - -> `[43]` (*Player_Romus: ""Are you sure that's what they want? What if they've just..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It does. They must fix their hearts or die.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Hugo Toras: ""And how long will they tolerate being ruled by a King wh..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It makes them misguided. Over time, they'll come to accept homosexuality, just as Queen Lyza led them to accept women in the workforce.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Hugo Toras: ""Your grandmother was a great reformer. But even she woul..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They don't really believe that homosexuality is a sin. They've been brainwashed by the Sanctuary.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true`
- **Kontekst wejściowy (poprzednik):** `[33]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Hugo Toras: ""And how long will they tolerate being ruled by a King wh..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player_Romus: ""They don't really believe that homosexuality is a sin. T..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[40]`
Mówca: **Hugo Toras**
> ""The majority of Rizians want the law to stay as it is. Not out of a desire to punish homosexuals, but because they wish to preserve our traditional values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player_Romus: ""Are you sure that's what they want? What if they've just..."*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_BrokeTradition > 2"*)
  - -> `[20]` (*Player_Romus: ""I don't understand. It's not as if I'm proposing a ban o..."*)

### Węzeł `[41]`
Mówca: **Hugo Toras**
> ""No, and your authority as monarch has suffered for it. There is a limit to the amount of radical change our kingdom will tolerate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Hugo Toras: ""Let me ask you this. What exactly are you trying to acco..."*)

### Węzeł `[42]`
Mówca: **Hugo Toras**
> ""This is not only about what the Royal Houses will think. Your authority as monarch is at stake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Hugo Toras: ""Let me ask you this. What exactly are you trying to acco..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you sure that's what they want? What if they've just been afraid to speak out for all this time?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Hugo Toras), `[33]` (Hugo Toras), `[40]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true"*)

### Węzeł `[44]`
Mówca: **Hugo Toras**
> ""And how long will they tolerate being ruled by a King who views them that way?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_AuthorityModifiersTotal <= 2"*)

### Węzeł `[45]`
Mówca: **Hugo Toras**
> ""Your grandmother was a great reformer. But even she would not go this far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_AuthorityModifiersTotal <= 2"*)

### Węzeł `[46]`
Mówca: **Hugo Toras**
> ""And how long will they tolerate being ruled by a King who sees their cherished religion as 'brainwashing'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_AuthorityModifiersTotal <= 2"*)

### Węzeł `[47]`
Mówca: **Hugo Toras**
> ""The repercussions of disregarding it will be even worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_AuthorityModifiersTotal <= 2"*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want homosexuals in our kingdom to live without fear of oppression.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[82]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Hugo Toras: ""So you would throw away your other priorities as king to..."*)

### Węzeł `[49]`
Mówca: **Hugo Toras**
> ""Your authority as monarch is slipping. You're losing the people's respect -- and once that's lost, so is your power over them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Hugo Toras: ""Let me ask you this. What exactly are you trying to acco..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_AuthorityModifiersTotal <= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_AuthorityModifiersTotal <= 2"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_AuthorityModifiersTotal <= 2)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_AuthorityModifiersTotal <= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_AuthorityModifiersTotal"] <= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Hugo Toras: ""Your authority as monarch is slipping. You're losing the..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_AuthorityModifiersTotal <= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_AuthorityModifiersTotal"] <= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Hugo Toras: ""This is not only about what the Royal Houses will think...."*)

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""Despite your efforts, your subjects hold fast to their faith. Some may tolerate homosexuality. But nobody is clamoring for its legalization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Hugo Toras: ""Except Golcondists, of course. But you shouldn't betray ..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Hugo Toras: ""Despite your efforts, your subjects hold fast to their f..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Hugo Toras: ""Most of your subjects are Wruhecists who hold fast to th..."*)

### Węzeł `[57]`
Mówca: **Hugo Toras**
> ""Most of your subjects are Wruhecists who hold fast to their faith. Some may tolerate homosexuality. But nobody is clamoring for its legalization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Hugo Toras: ""Except Golcondists, of course. But you shouldn't betray ..."*)

### Węzeł `[58]`
Mówca: **Hugo Toras**
> ""Except Golcondists, of course. But you shouldn't betray the tenets of Wruhecism on *their* behalf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Hugo Toras: ""Let me ask you this. What exactly are you trying to acco..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_OutedToPlayer == true && RiziaDLC.Relations_Pabel > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_OutedToPlayer == true && RiziaDL..."*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_OutedToPlayer == true && Rizia..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_OutedToPlayer == true && RiziaDLC.Relations_Pabel > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player_Romus: ""I have... close friends in the homosexual community. I w..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_OutedToPlayer == true && RiziaDLC.Relations_Pabel > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player_Romus: ""I want homosexuals in our kingdom to live without fear o..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have... close friends in the homosexual community. I want them to live without fear.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 0`
- **Kontekst wejściowy (poprzednik):** `[82]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Hugo Toras: ""So you would throw away your other priorities as king to..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want to build a more enlightened and just society. If even one Rizian goes to jail simply for loving the wrong person, I have failed at that goal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Hugo Toras: ""You cannot enlighten society with the stroke of a pen, R..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's all part of my geopolitical strategy. I'm looking to improve relations with Derdia.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.CountryRelation_Derdia_Allied"] == false`
- **Kontekst wejściowy (poprzednik):** `[82]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Hugo Toras: ""I understand the importance of diplomacy, Your Majesty, ..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Derdia_Allied == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Derdia_Allied == false"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.CountryRelation_Derdia_Allied == false)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Derdia_Allied == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Derdia_Allied"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player_Romus: ""It's all part of my geopolitical strategy. I'm looking t..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.CountryRelation_Derdia_Allied == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Derdia_Allied"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""So you would throw away your other priorities as king to make your 'friends' happy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""So you would throw away your other priorities as king to appease a small minority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[70]`
Mówca: **Hugo Toras**
> ""You cannot enlighten society with the stroke of a pen, Romus. They will resist your attempt to force progressivism on them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[71]`
Mówca: **Hugo Toras**
> ""This is your decision to make. But I warn you that legalizing homosexuality will not calm the unrest on the streets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player_Romus: ""That doesn't matter. History will vindicate me.""*)
  - -> `[131]` (*Player_Romus: ""I know I'm taking a risk. But nothing is more important ..."*)
  - -> `[126]` (*Player_Romus: ""You wouldn't think that way if you were homosexual yours..."*)
  - -> `[134]` (*Player_Romus: ""You've made your point, Hugo. I need to think about this.""*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't need to justify my decision to you. My mind is made up.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "My uncle sighed heavily."*)

### Węzeł `[73]`
Mówca: **Hugo Toras**
> ""I understand the importance of diplomacy, Your Majesty, but it shouldn't come at the cost of upending society in one's own country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Hugo Toras: ""This is your decision to make. But I warn you that legal..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_DeclareIntention_Public == true && RiziaD..."*)

### Węzeł `[77]`
Mówca: **Hugo Toras**
> ""You must take care, Your Majesty. It's not only the Royal Houses who will disapprove of this move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Hugo Toras: ""Let me ask you this. What exactly are you trying to acco..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_AuthorityModifiersTotal <= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_AuthorityModifiersTotal <= 2"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_AuthorityModifiersTotal <= 2)"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_AuthorityModifiersTotal <= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_AuthorityModifiersTotal"] <= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Hugo Toras: ""You must be more careful, Your Majesty. Your authority a..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_AuthorityModifiersTotal <= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_AuthorityModifiersTotal"] <= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Hugo Toras: ""You must take care, Your Majesty. It's not only the Roya..."*)

### Węzeł `[81]`
Mówca: **Hugo Toras**
> ""You must be more careful, Your Majesty. Your authority as monarch is already slipping.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Hugo Toras: ""Let me ask you this. What exactly are you trying to acco..."*)

### Węzeł `[82]`
Mówca: **Hugo Toras**
> ""Let me ask you this. What exactly are you trying to accomplish by signing this decree?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player_Romus: ""I don't need to justify my decision to you. My mind is m..."*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_OutedToPlayer == true && RiziaDL..."*)
  - -> `[63]` (*Player_Romus: ""I want to build a more enlightened and just society. If ..."*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Derdia_Allied == false"*)
  - -> `[83]` (*Player_Romus: ""Persecuting homosexuals isn't just morally wrong, it's b..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Persecuting homosexuals isn't just morally wrong, it's bad for our global image. I'm trying to bring our values in line with those of the rest of the world.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Hugo Toras: ""And by 'the rest of the world', you mean ATO.""*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == false && (RiziaDLC.Rico_Arrested == true || RiziaDLCSetup.CurrentTurn > 7)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == false && (RiziaDLC..."*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Rico == false && (RiziaD..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == false && (RiziaDLC.Rico_Arrested == true || RiziaDLCSetup.CurrentTurn > 7)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == false  and  (Variable["RiziaDLC.Rico_Arrested"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] > 7)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player_Romus: ""That's rich, coming from someone who wanted my daughter ..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Rico == false && (RiziaDLC.Rico_Arrested == true || RiziaDLCSetup.CurrentTurn > 7))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == false  and  (Variable["RiziaDLC.Rico_Arrested"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] > 7)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player_Romus: ""That's rich, coming from someone who wants my daughter t..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's rich, coming from someone who wanted my daughter to enter into an incestuous marriage.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == false  and  (Variable["RiziaDLC.Rico_Arrested"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] > 7)`
- **Kontekst wejściowy (poprzednik):** `[7]` (Hugo Toras), `[8]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Hugo Toras: ""Whether or not you personally approve of it, marriage be..."*)

### Węzeł `[88]`
Mówca: **Hugo Toras**
> ""Whether or not you personally approve of it, marriage between cousins is a well-established royal tradition. And one that has no impact on the larger populace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Hugo Toras: ""Most Rizians wouldn't bat an eye if Her Highness married..."*)

### Węzeł `[89]`
Mówca: **Hugo Toras**
> ""Most Rizians wouldn't bat an eye if Her Highness married Rico. But if their children saw their two male neighbors holding hands in public, they'd perceive it as an attack on their values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: ""I don't understand. It's not as if I'm proposing a ban o..."*)
  - -> `[96]` (*Player_Romus: ""You don't know that. Maybe Rizians are more supportive o..."*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[91]` (*Player_Romus: ""And you don't think that's a problem?""*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's rich, coming from someone who wants my daughter to enter into an incestuous marriage.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == false  and  (Variable["RiziaDLC.Rico_Arrested"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] > 7)) == false`
- **Kontekst wejściowy (poprzednik):** `[7]` (Hugo Toras), `[8]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Hugo Toras: ""Whether or not you personally approve of it, marriage be..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you don't think that's a problem?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Hugo Toras: ""I am merely telling you how it is. If you believe your s..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, because the Sanctuary has brainwashed them into feeling that way.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[89]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Hugo Toras: ""And how long will they tolerate being ruled by a King wh..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player_Romus: ""Yes, because the Sanctuary has brainwashed them into fee..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't know that. Maybe Rizians are more supportive of homosexuality than you think.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true"*)

### Węzeł `[97]`
Mówca: **Hugo Toras**
> ""And by 'the rest of the world', you mean ATO.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "He folded his arms with a frown."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "He folded his arms with a frown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Hugo Toras: ""It isn't enough for Arcasia and its cronies to undermine..."*)

### Węzeł `[99]`
Mówca: **Hugo Toras**
> ""It isn't enough for Arcasia and its cronies to undermine the world's last existing monarchies. They must claim they're doing so out of moral superiority...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_DeclareIntention_Public == true && RiziaDLC.Reform_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_DeclareIntention_Public == true && RiziaD..."*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_DeclareIntention_Public == true && Rizi..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_DeclareIntention_Public == true && RiziaDLC.Reform_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true  and  Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Hugo Toras: ""This is your decision to make. But if you're trying to u..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_DeclareIntention_Public == true && RiziaDLC.Reform_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true  and  Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[103]`
Mówca: **Hugo Toras**
> ""This is your decision to make. But if you're trying to unite the kingdom behind your reforms, I'd advise you to steer clear of such a divisive act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player_Romus: ""There's nothing 'divisive' about it to me. You're on the..."*)
  - -> `[131]` (*Player_Romus: ""I know I'm taking a risk. But nothing is more important ..."*)
  - -> `[126]` (*Player_Romus: ""You wouldn't think that way if you were homosexual yours..."*)
  - -> `[134]` (*Player_Romus: ""You've made your point, Hugo. I need to think about this.""*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Hugo Toras: ""This is your decision to make. But I warn you that passi..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Welfare_LivingStandards_Bad == true || RiziaDLC.Situation_Welfare_LivingStandards_Horrible == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Welfare_LivingStandards_Bad"] == true  or  Variable["RiziaDLC.Situation_Welfare_LivingStandards_Horrible"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Hugo Toras: ""This is your decision to make. But I advise you to think..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Hugo Toras: ""This is your decision to make. But I warn you that passi..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Welfare_LivingStandards_Bad == true ||..."*)

### Węzeł `[110]`
Mówca: **Hugo Toras**
> ""This is your decision to make. But I warn you that passing such a frivolous act in the midst of a war will win you no favors. With House Toras or anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player_Romus: ""It's not frivolous to me. You're on the wrong side of hi..."*)
  - -> `[131]` (*Player_Romus: ""I know I'm taking a risk. But nothing is more important ..."*)
  - -> `[126]` (*Player_Romus: ""You wouldn't think that way if you were homosexual yours..."*)
  - -> `[134]` (*Player_Romus: ""You've made your point, Hugo. I need to think about this.""*)

### Węzeł `[111]`
Mówca: **Hugo Toras**
> ""This is your decision to make. But I warn you that passing such a frivolous act while ordinary citizens go hungry will win you no favors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player_Romus: ""It's not frivolous to me. You're on the wrong side of hi..."*)
  - -> `[131]` (*Player_Romus: ""I know I'm taking a risk. But nothing is more important ..."*)
  - -> `[126]` (*Player_Romus: ""You wouldn't think that way if you were homosexual yours..."*)
  - -> `[134]` (*Player_Romus: ""You've made your point, Hugo. I need to think about this.""*)

### Węzeł `[112]`
Mówca: **Narrator**
> "He bowed and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnactDecree("Welfare_HumanRights_DecriminalizeHomosexuality");`
- **Efekt skryptowy (`userScript`):** `EnactDecree("Welfare_HumanRights_DecriminalizeHomosexuality");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_CounselIgnored += 1"*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "Sign the decree."]** — Mówca: **Player_Romus_Italic**
> "I signed the decree."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Hugo Toras), `[135]` (Hugo Toras), `[151]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "EnactDecree("Welfare_HumanRights_DecriminalizeHomosexuali..."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "Hugo lifted it off the table by its corner, as if the paper itself were poisonous."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Hugo Toras: ""I'll see to it that this gets enacted.""*)

### Węzeł `[116]`
Mówca: **Hugo Toras**
> ""I'll see to it that this gets enacted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "He bowed and left the room."*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have it your way, Your Grace. The law shall stay as it is for now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Hugo Toras), `[151]` (Hugo Toras), `[152]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Hugo Toras: ""From the bottom of my heart, I thank you.""*)

### Węzeł `[118]`
Mówca: **Hugo Toras**
> ""From the bottom of my heart, I thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "He lifted the unsigned decree by its corner, as if the pa..."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "He lifted the unsigned decree by its corner, as if the paper itself were poisonous."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Hugo Toras: ""I'll file this away safely for now.""*)

### Węzeł `[120]`
Mówca: **Hugo Toras**
> ""I am merely telling you how it is. If you believe your subjects will support you in this, you are mistaken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_AuthorityModifiersTotal <= 2"*)

### Węzeł `[121]`
Mówca: **Narrator**
> "My uncle sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Hugo Toras: ""So be it, then.""*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not frivolous to me. You're on the wrong side of history.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Hugo Toras), `[111]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Pa..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's nothing 'divisive' about it to me. You're on the wrong side of history.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Pa..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That doesn't matter. History will vindicate me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Pa..."*)

### Węzeł `[125]`
Mówca: **Hugo Toras**
> ""So be it, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player_Romus_Italic: "Sign the decree."*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You wouldn't think that way if you were homosexual yourself. Can't you empathize with them?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Hugo Toras), `[103]` (Hugo Toras), `[110]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Pa..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Pabel_Gone == true && RiziaDLC.Vina_Escapes == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Pa..."*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC...."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Pabel_Gone == true && RiziaDLC.Vina_Escapes == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true  or  (Variable["RiziaDLC.Pabel_Gone"] == true  and  Variable["RiziaDLC.Vina_Escapes"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "He shot me a sharp glance."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Pabel_Gone == true && RiziaDLC.Vina_Escapes == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true  or  (Variable["RiziaDLC.Pabel_Gone"] == true  and  Variable["RiziaDLC.Vina_Escapes"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "His response came almost instantly."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "He shot me a sharp glance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Hugo Toras: ""If I were unfortunate enough to be burdened with such de..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know I'm taking a risk. But nothing is more important to me than achieving equal rights for all citizens.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Hugo Toras), `[103]` (Hugo Toras), `[110]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Pa..."*)

### Węzeł `[132]`
Mówca: **Hugo Toras**
> ""This is your decision to make. But I advise you to think carefully about whether your reign can weather the repercussions of such an act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player_Romus: ""I know I'm taking a risk. But nothing is more important ..."*)
  - -> `[126]` (*Player_Romus: ""You wouldn't think that way if you were homosexual yours..."*)
  - -> `[148]` (*Player_Romus: ""You're my Grand Vizier. What do you think the repercussi..."*)
  - -> `[134]` (*Player_Romus: ""You've made your point, Hugo. I need to think about this.""*)

### Węzeł `[133]`
Mówca: **Hugo Toras**
> ""If I were unfortunate enough to be burdened with such desires, I would have the good sense to keep them to myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 7 && (RiziaDLC.Country_Ho..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've made your point, Hugo. I need to think about this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Hugo Toras), `[103]` (Hugo Toras), `[110]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Hugo Toras: ""Take all the time you need.""*)

### Węzeł `[135]`
Mówca: **Hugo Toras**
> ""Take all the time you need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player_Romus_Italic: "Sign the decree."*)
  - -> `[117]` (*Player_Romus: ""Have it your way, Your Grace. The law shall stay as it i..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Pabel_Gone == true && RiziaDLC.Vina_Escapes == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Pa..."*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC...."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Pabel_Gone == true && RiziaDLC.Vina_Escapes == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true  or  (Variable["RiziaDLC.Pabel_Gone"] == true  and  Variable["RiziaDLC.Vina_Escapes"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "He shot me a sharp glance."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Pabel_Gone == true && RiziaDLC.Vina_Escapes == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true  or  (Variable["RiziaDLC.Pabel_Gone"] == true  and  Variable["RiziaDLC.Vina_Escapes"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Hugo Toras: ""I had no idea this topic meant so much to you, Your Maje..."*)

### Węzeł `[139]`
Mówca: **Narrator**
> "He shot me a sharp glance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Hugo Toras: ""You care about this topic more than I realized, Your Maj..."*)

### Węzeł `[140]`
Mówca: **Hugo Toras**
> ""You care about this topic more than I realized, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 7 && (RiziaDLC.Country_Ho..."*)

### Węzeł `[141]`
Mówca: **Hugo Toras**
> ""I had no idea this topic meant so much to you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 7 && (RiziaDLC.Country_Ho..."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "His response came almost instantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Hugo Toras: ""If I were unfortunate enough to be burdened with such de..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 7 && (RiziaDLC.Country_HouseToras_Friendly == true && RiziaDLC.Country_HouseAzaro_Enemy == false) && RiziaDLC.Country_PublicOpinion > 2 && RiziaDLC.Situation_Order_Unrest_NationalDestabilization == false && RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 7 && (RiziaDLC.Country_Ho..."*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Authority >= 7 && (RiziaDLC.Country_..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 7 && (RiziaDLC.Country_HouseToras_Friendly == true && RiziaDLC.Country_HouseAzaro_Enemy == false) && RiziaDLC.Country_PublicOpinion > 2 && RiziaDLC.Situation_Order_Unrest_NationalDestabilization == false && RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 7  and  (Variable["RiziaDLC.Country_HouseToras_Friendly"] == true  and  Variable["RiziaDLC.Country_HouseAzaro_Enemy"] == false)  and  Variable["RiziaDLC.Country_PublicOpinion"] > 2  and  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == false  and  Variable["RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Hugo Toras: ""I'll be honest. If ever there were a time to pass this d..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Authority >= 7 && (RiziaDLC.Country_HouseToras_Friendly == true && RiziaDLC.Country_HouseAzaro_Enemy == false) && RiziaDLC.Country_PublicOpinion > 2 && RiziaDLC.Situation_Order_Unrest_NationalDestabilization == false && RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 7  and  (Variable["RiziaDLC.Country_HouseToras_Friendly"] == true  and  Variable["RiziaDLC.Country_HouseAzaro_Enemy"] == false)  and  Variable["RiziaDLC.Country_PublicOpinion"] > 2  and  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == false  and  Variable["RiziaDLC.Situation_Order_WruhecistCommunity_Dissatisfied"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Hugo Toras: ""I will be honest. Decriminalizing homosexuality may be s..."*)

### Węzeł `[146]`
Mówca: **Hugo Toras**
> ""I'll be honest. If ever there were a time to pass this decree, it would be now, while you're still in good standing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Hugo Toras: ""But as a practicing Wruhecist and a member of House Tora..."*)

### Węzeł `[147]`
Mówca: **Hugo Toras**
> ""I will be honest. Decriminalizing homosexuality may be seen as 'progress' in foreign circles. But here in Rizia, it will damage your standing beyond repair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Hugo Toras: ""And if passing it leads to your downfall, whoever leads ..."*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're my Grand Vizier. What do you think the repercussions will be?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 7 && (RiziaDLC.Country_Ho..."*)

### Węzeł `[149]`
Mówca: **Hugo Toras**
> ""But as a practicing Wruhecist and a member of House Toras, I cannot and will not endorse it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "I took one more look at the document in front of me."*)

### Węzeł `[150]`
Mówca: **Hugo Toras**
> ""And if passing it leads to your downfall, whoever leads Rizia in your stead will surely reverse it. Leaving homosexuals no better off than before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Hugo Toras: ""So please, think carefully. Is this truly what you want ..."*)

### Węzeł `[151]`
Mówca: **Hugo Toras**
> ""So please, think carefully. Is this truly what you want for the kingdom?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player_Romus_Italic: "Sign the decree."*)
  - -> `[117]` (*Player_Romus: ""Have it your way, Your Grace. The law shall stay as it i..."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "I took one more look at the document in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player_Romus_Italic: "Sign the decree."*)
  - -> `[117]` (*Player_Romus: ""Have it your way, Your Grace. The law shall stay as it i..."*)

### Węzeł `[153]`
Mówca: **Hugo Toras**
> ""I'll file this away safely for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "He bowed and left the room."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_CounselIgnored += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Hugo_CounselIgnored"] = Variable["RiziaDLC.Hugo_CounselIgnored"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "Hugo lifted it off the table by its corner, as if the pap..."*)
