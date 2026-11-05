# Rizia/FREEPRESS/FREEPRESS Conversation

- **ID konwersacji:** `581`
- **StoryPack:** `Rizia`
- **Tura:** `Decree (FREEPRESS)`
- **Lokalizacja pliku:** `Rizia/Decrees/581_FREEPRESS_Conversation.md`
- **Liczba węzłów dialogowych:** 217
- **Liczba wyborów gracza:** 55

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_Arrested`
- `RiziaDLC.Adarfo_Executed`
- `RiziaDLC.BirthdayGathering_ReformTalks`
- `RiziaDLC.HouseOfDelegates_Abolished`
- `RiziaDLC.Hugo_DecreeCounsel_Happened`
- `RiziaDLC.Manus_Gone`
- `RiziaDLC.Policy_RD_Welfare_ElectoralReform`
- `RiziaDLC.Reform_DeclareIntention_Public`
- `RiziaDLC.Reform_DeclareIntention_WeakStatement`
- `RiziaDLC.Reform_Movement_Grows`
- `RiziaDLC.Reform_Movement_Leader_Adarfo`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Relations_VinaManus_Approve`
- `RiziaDLC.Relations_VinaManus_ApproveAfterPales`
- `RiziaDLC.Relations_Vina_DancedWithManus`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax`
- `RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax`
- `RiziaDLCSetup.CurrentTurn`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Hugo_CounselIgnored`
- `RiziaDLC.PersonalValue_FunnyKing`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[356] Rizia/CouncilRoyalDecrees** (../Decrees/356_CouncilRoyalDecrees.md), Węzeł `[54]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[20]` | **""You give them too much credit, Hugo. My decisions are my own.""** | `[12]` **Hugo Toras**: ""I assume this is the Rizian Peo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Hugo Toras**: ""Of course they are."" |
| `[29]` | **""You give him too much credit, Hugo. My decisions are my own.""** | `[11]` **Hugo Toras**: ""I assume this is Manus Sazon wh..."<br>`[17]` **Hugo Toras**: ""Don't tell me it's that radical..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Hugo Toras**: ""Of course they are."" |
| `[30]` | **""And if it were? Does that make the idea wrong, or are you just opposed to it beca..."** | `[11]` **Hugo Toras**: ""I assume this is Manus Sazon wh..."<br>`[12]` **Hugo Toras**: ""I assume this is the Rizian Peo..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Hugo Toras**: ""I oppose it because I know what..." |
| `[31]` | **""Yes, Hugo, they've infiltrated the palace and now control my every move. I suspec..."** | `[11]` **Hugo Toras**: ""I assume this is Manus Sazon wh..."<br>`[12]` **Hugo Toras**: ""I assume this is the Rizian Peo..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Trait_FunnyKing"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] < 5` | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...` | `[53]` **Hugo Toras**: ""Mock all you like, but it won't..." |
| `[32]` | **""If giving the people something they want prevents greater unrest, then does it ma..."** | `[11]` **Hugo Toras**: ""I assume this is Manus Sazon wh..."<br>`[12]` **Hugo Toras**: ""I assume this is the Rizian Peo..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false` | *Brak zmian stanu* | `[55]` **Hugo Toras**: ""It matters if the *gift* you're..." |
| `[33]` | **""This is about modernizing Rizia, ensuring our people have access to information b..."** | `[11]` **Hugo Toras**: ""I assume this is Manus Sazon wh..."<br>`[12]` **Hugo Toras**: ""I assume this is the Rizian Peo..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Trait_TyrantKing"] == false` | *Brak zmian stanu* | `[50]` **Hugo Toras**: ""Or access to manipulation."" |
| `[45]` | **""Have you not seen the growing reform movement? This is what the people are demand..."** | `[11]` **Hugo Toras**: ""I assume this is Manus Sazon wh..."<br>`[12]` **Hugo Toras**: ""I assume this is the Rizian Peo..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Reform_Movement_Grows"] == true`<br>`(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false` | *Brak zmian stanu* | `[54]` **Hugo Toras**: ""I've also seen what happens whe..." |
| `[46]` | **""Have you not seen the unrest on the streets? We have to listen to the people to c..."** | `[11]` **Hugo Toras**: ""I assume this is Manus Sazon wh..."<br>`[12]` **Hugo Toras**: ""I assume this is the Rizian Peo..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true` | *Brak zmian stanu* | `[54]` **Hugo Toras**: ""I've also seen what happens whe..." |
| `[57]` | **""Change, Hugo. The kind we can guide, or the kind that will happen without us.""** | `[51]` **Hugo Toras**: ""Tell me, Your Majesty, what do ..." | `Variable["RiziaDLC.Trait_TyrantKing"] == false  or  Variable["RiziaDLC.Reform_Path"] == true` | *Brak zmian stanu* | `[67]` **Narrator**: "He raised an eyebrow." |
| `[65]` | **""The same thing that happens when it's kept under a lock and key. People will find..."** | `[51]` **Hugo Toras**: ""Tell me, Your Majesty, what do ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Hugo Toras**: ""Perhaps so."" |
| `[84]` | **""You were the one who advised me to move against Manus, Hugo.""** | `[68]` **Hugo Toras**: ""Tell me, Romus, will that reall..." | `Variable["RiziaDLC.Manus_Gone"] == true` | *Brak zmian stanu* | `[202]` **Hugo Toras**: ""I know."" |
| `[95]` | **""Just to be clear. I did not declare my full support. It was a strategic decision.""** | `[72]` **Hugo Toras**: ""May I speak freely on this subj..." | `Variable["RiziaDLC.Reform_DeclareIntention_WeakStatement"] == true  and  Variable["RiziaDLC.BirthdayGathering_ReformTalks"] == false` | *Brak zmian stanu* | `[108]` **Hugo Toras**: ""I see..."" |
| `[96]` | **""Of course you may, Hugo.""** | `[72]` **Hugo Toras**: ""May I speak freely on this subj..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Hugo Toras**: ""You didn't just support the mov..."<br>`[212]` **Hugo Toras**: ""Your words in public were... ca..." |
| `[97]` | **""Let them undermine us, Hugo. The people who shout out their opinions are far less..."** | `[81]` **Hugo Toras**: ""It is an enormous risk."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Narrator**: "He shook his head slightly. Afte..." |
| `[98]` | **""Maybe you're right. I'm prepared to hold off on this decree.""** | `[81]` **Hugo Toras**: ""It is an enormous risk."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Narrator**: "He looked at me with expecting e..." |
| `[99]` | **""If you must...""** | `[72]` **Hugo Toras**: ""May I speak freely on this subj..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Hugo Toras**: ""You didn't just support the mov..."<br>`[212]` **Hugo Toras**: ""Your words in public were... ca..." |
| `[103]` | **""Not everyone is a radical or demagogue, Hugo. But if we silence them completely, ..."** | `[81]` **Hugo Toras**: ""It is an enormous risk."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Narrator**: "He shook his head slightly. Afte..." |
| `[104]` | **""A King who cannot face criticism is no King at all. I must take the risk.""** | `[81]` **Hugo Toras**: ""It is an enormous risk."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Narrator**: "He shook his head slightly. Afte..." |
| `[116]` | **"Sign the decree."** | `[115]` **Narrator**: "I took a look at the decree."<br>`[143]` **Narrator**: "I ignored him and took a look at..." | *Brak (Dostępna bezwarunkowo)* | `EnactDecree("Welfare_HumanRights_AllowFreePress"); ;`<br>`Variable["RiziaDLC.Hugo_CounselIgnored"] = Variable["Rizi...` | `[117]` **Hugo Toras**: ""Very well... I truly hope you'r..." |
| `[119]` | **""You've given me a lot to consider. I'll hold off on the decree for now.""** | `[115]` **Narrator**: "I took a look at the decree."<br>`[143]` **Narrator**: "I ignored him and took a look at..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Hugo Toras**: ""Thank you."" |
| `[124]` | **""I didn't rise to this throne to be ruled by them. I will not be the one to kneel.""** | `[123]` **Hugo Toras**: ""Are you really prepared to face..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Hugo Toras**: ""It is not just the Houses, Romus."" |
| `[127]` | **""You're bringing up the other Houses again to warn me? Enough of this, Hugo.""** | `[123]` **Hugo Toras**: ""Are you really prepared to face..." | `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] > 1` | *Brak zmian stanu* | `[140]` **Hugo Toras**: ""Fine. I will speak of this no m..." |
| `[131]` | **""I am. And I'd be grateful to have my Grand Vizier standing behind me.""** | `[123]` **Hugo Toras**: ""Are you really prepared to face..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Hugo Toras**: ""Well, you know what I think, Ro..." |
| `[132]` | **""I thought you wanted to speak freely, Hugo. Don't play mind games with me. Just s..."** | `[123]` **Hugo Toras**: ""Are you really prepared to face..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Hugo Toras**: ""Well, you know what I think, Ro..." |
| `[136]` | **""Finally.""** | `[135]` **Hugo Toras**: ""But I will speak of this no mor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Narrator**: "I took a look at the decree." |
| `[137]` | **""Maybe you're right. I'm prepared to hold off on this decree.""** | `[135]` **Hugo Toras**: ""But I will speak of this no mor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Narrator**: "He looked at me with expecting e..." |
| `[138]` | **""I'm warning you, Hugo. I hope you're not thinking of anything rash.""** | `[135]` **Hugo Toras**: ""But I will speak of this no mor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Hugo Toras**: ""Rash? I am the Grand Vizier, Ro..." |
| `[139]` | **""Good.""** | `[135]` **Hugo Toras**: ""But I will speak of this no mor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Narrator**: "I took a look at the decree." |
| `[147]` | **""You make it sound like charity. I prefer to think of it as balance. Let them vent..."** | `[13]` **Hugo Toras**: ""So this is the trade, then? Dis..."<br>`[21]` **Hugo Toras**: ""So this is the trade, then? Get..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Hugo Toras**: ""A bold move, indeed."" |
| `[148]` | **""Their democracy was a shadow play. I simply turned on the lights.""** | `[13]` **Hugo Toras**: ""So this is the trade, then? Dis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Hugo Toras**: ""A bold move, indeed."" |
| `[149]` | **""I just removed a liability. Now the people can truly speak their minds, not just ..."** | `[21]` **Hugo Toras**: ""So this is the trade, then? Get..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Hugo Toras**: ""A bold move, indeed."" |
| `[150]` | **""That's precisely the plan.""** | `[179]` **Hugo Toras**: ""They lose their loudest voices,..."<br>`[180]` **Hugo Toras**: ""They lose their voice in govern..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Hugo Toras**: ""So, you shut down their leaders..."<br>`[19]` **Hugo Toras**: ""So, you shut their mouths in th..." |
| `[151]` | **""So, you approve of it?""** | `[179]` **Hugo Toras**: ""They lose their loudest voices,..."<br>`[180]` **Hugo Toras**: ""They lose their voice in govern..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Hugo Toras**: ""I don't approve of this decree ..." |
| `[152]` | **""So, this time you're not here to warn me?""** | `[179]` **Hugo Toras**: ""They lose their loudest voices,..."<br>`[180]` **Hugo Toras**: ""They lose their voice in govern..." | `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] > 0` | *Brak zmian stanu* | `[76]` **Hugo Toras**: ""I am."" |
| `[156]` | **""Illusions can be useful, Hugo. Let them believe they have a voice. It costs me no..."** | `[179]` **Hugo Toras**: ""They lose their loudest voices,..."<br>`[180]` **Hugo Toras**: ""They lose their voice in govern..." | `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false` | *Brak zmian stanu* | `[69]` **Hugo Toras**: ""So, you shut down their leaders..."<br>`[19]` **Hugo Toras**: ""So, you shut their mouths in th..." |
| `[161]` | **""Power has never been about volume. They can shout all they want in the papers, as..."** | `[179]` **Hugo Toras**: ""They lose their loudest voices,..."<br>`[180]` **Hugo Toras**: ""They lose their voice in govern..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Hugo Toras**: ""So, you shut down their leaders..."<br>`[19]` **Hugo Toras**: ""So, you shut their mouths in th..." |
| `[162]` | **""Exactly. And what is your opinion on this matter?""** | `[13]` **Hugo Toras**: ""So this is the trade, then? Dis..."<br>`[21]` **Hugo Toras**: ""So this is the trade, then? Get..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Hugo Toras**: ""It's a bold move."" |
| `[163]` | **""And what would you have me do instead, Hugo? Silence them entirely?""** | `[13]` **Hugo Toras**: ""So this is the trade, then? Dis..."<br>`[21]` **Hugo Toras**: ""So this is the trade, then? Get..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Hugo Toras**: ""No. I think it's a bold move."" |
| `[170]` | **""Have you not seen the growing reform movement? We have to give something back to ..."** | `[13]` **Hugo Toras**: ""So this is the trade, then? Dis..."<br>`[21]` **Hugo Toras**: ""So this is the trade, then? Get..." | `Variable["RiziaDLC.Reform_Movement_Grows"] == true`<br>`(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false` | *Brak zmian stanu* | `[172]` **Hugo Toras**: ""It's a bold move indeed. But I ..." |
| `[171]` | **""Have you not seen the unrest on the streets? We have to give something back to th..."** | `[13]` **Hugo Toras**: ""So this is the trade, then? Dis..."<br>`[21]` **Hugo Toras**: ""So this is the trade, then? Get..." | `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true` | *Brak zmian stanu* | `[172]` **Hugo Toras**: ""It's a bold move indeed. But I ..." |
| `[181]` | **""A little chaos, perhaps. A few angry columns, a few smug intellectuals thinking t..."** | `[51]` **Hugo Toras**: ""Tell me, Your Majesty, what do ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Hugo Toras**: ""Perhaps so."" |
| `[183]` | **""Let me guess. You believe the streets will rise and the monarchy will crumble ove..."** | `[51]` **Hugo Toras**: ""Tell me, Your Majesty, what do ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Hugo Toras**: ""Perhaps so."" |
| `[184]` | **""What happens? We let people speak. That's all. Not every decision is a step towar..."** | `[51]` **Hugo Toras**: ""Tell me, Your Majesty, what do ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Hugo Toras**: ""Perhaps so."" |
| `[185]` | **""Illusions can be useful in times of growing radicalism. Let them believe they hav..."** | `[179]` **Hugo Toras**: ""They lose their loudest voices,..."<br>`[180]` **Hugo Toras**: ""They lose their voice in govern..." | `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true` | *Brak zmian stanu* | `[69]` **Hugo Toras**: ""So, you shut down their leaders..."<br>`[19]` **Hugo Toras**: ""So, you shut their mouths in th..." |
| `[186]` | **""Of course they'll be antagonized. They were antagonized the moment I was crowned ..."** | `[123]` **Hugo Toras**: ""Are you really prepared to face..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Narrator**: "He shook his head slightly. Afte..." |
| `[187]` | **""You didn't protest when I got rid of Mr. Sotelato, now, did you?""** | `[68]` **Hugo Toras**: ""Tell me, Romus, will that reall..." | `Variable["RiziaDLC.Adarfo_Arrested"] == true  or  Variable["RiziaDLC.Adarfo_Executed"] == true` | *Brak zmian stanu* | `[202]` **Hugo Toras**: ""I know."" |
| `[188]` | **""The movement grew radical because I followed your advice to get rid of Mr. Sazon.""** | `[68]` **Hugo Toras**: ""Tell me, Romus, will that reall..." | `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true`<br>`Variable["RiziaDLC.Manus_Gone"] == true` | *Brak zmian stanu* | `[203]` **Hugo Toras**: ""Yes. I..."" |
| `[189]` | **""We are long past that stage. We're already losing control over the streets.""** | `[68]` **Hugo Toras**: ""Tell me, Romus, will that reall..." | `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true` | *Brak zmian stanu* | `[201]` **Hugo Toras**: ""You are right."" |
| `[190]` | **""The House of Delegates is already abolished, Hugo. This isn't helpful.""** | `[68]` **Hugo Toras**: ""Tell me, Romus, will that reall..." | `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true` | *Brak zmian stanu* | `[201]` **Hugo Toras**: ""You are right."" |
| `[197]` | **""I see your point.""** | `[68]` **Hugo Toras**: ""Tell me, Romus, will that reall..." | `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true) == false` | *Brak zmian stanu* | `[205]` **Hugo Toras**: ""Just think about it. This would..." |
| `[198]` | **""Neither is truly controllable, Hugo. But I can still guide what's happening.""** | `[68]` **Hugo Toras**: ""Tell me, Romus, will that reall..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Hugo Toras**: ""Perhaps so."" |
| `[199]` | **""Giving them a platform to rant instead of going out to the streets *is* control.""** | `[68]` **Hugo Toras**: ""Tell me, Romus, will that reall..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Hugo Toras**: ""Perhaps so."" |
| `[209]` | **""As if I could keep you from doing so.""** | `[72]` **Hugo Toras**: ""May I speak freely on this subj..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Hugo Toras**: ""You didn't just support the mov..."<br>`[212]` **Hugo Toras**: ""Your words in public were... ca..." |
| `[210]` | **""Ironically, no. I don't want to hear your opinion on this subject. I've already m..."** | `[72]` **Hugo Toras**: ""May I speak freely on this subj..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Narrator**: "He shook his head slightly. Afte..." |
| `[211]` | **""On the contrary, this is about giving citizens the illusion of power while keepin..."** | `[11]` **Hugo Toras**: ""I assume this is Manus Sazon wh..."<br>`[12]` **Hugo Toras**: ""I assume this is the Rizian Peo..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Trait_TyrantKing"] == false) == false` | *Brak zmian stanu* | `[207]` **Hugo Toras**: ""A bold idea. But..."" |

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
  - -> `[3]` (*Hugo Toras: ""So... freedom of press...""*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Hugo Toras: ""I've also seen what happens when rulers mistake concessi..."*)

### Węzeł `[3]`
Mówca: **Hugo Toras**
> ""So... freedom of press...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "He stepped forward but didn't sit. His hands were resting..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == false"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_Gone == false)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_Gone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true || RiziaD..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_Gone == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_Gone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_DeclareIntention_Public == true || RiziaD..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "He stepped forward but didn't sit. His hands were resting behind his back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == false"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == false"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseOfDelegates_Abolished == false)"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == false"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseOfDelegates_Abolished == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Hugo Toras: ""So this is the trade, then? Dismantle their so-called de..."*)

### Węzeł `[11]`
Mówca: **Hugo Toras**
> ""I assume this is Manus Sazon whispering in your ear again?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus: ""You give him too much credit, Hugo. My decisions are my ..."*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[12]`
Mówca: **Hugo Toras**
> ""I assume this is the Rizian People's Party whispering in your ear again?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: ""You give them too much credit, Hugo. My decisions are my..."*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[13]`
Mówca: **Hugo Toras**
> ""So this is the trade, then? Dismantle their so-called democracy with one hand and toss them a printing press with the other?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[148]` (*Player_Romus: ""Their democracy was a shadow play. I simply turned on th..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true || RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true || RiziaDLC.Reform_DeclareIntention_Public == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true || RiziaD..."*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_DancedWithManus == true || Rizi..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true || RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true || RiziaDLC.Reform_DeclareIntention_Public == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true  or  Variable["RiziaDLC.Relations_VinaManus_Approve"] == true  or  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true  or  Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Hugo Toras: ""I assume this is Manus Sazon whispering in your ear again?""*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_DancedWithManus == true || RiziaDLC.Relations_VinaManus_Approve == true || RiziaDLC.Relations_VinaManus_ApproveAfterPales == true || RiziaDLC.Reform_DeclareIntention_Public == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true  or  Variable["RiziaDLC.Relations_VinaManus_Approve"] == true  or  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == true  or  Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Hugo Toras: ""I assume this is Manus Sazon whispering in your ear?""*)

### Węzeł `[17]`
Mówca: **Hugo Toras**
> ""Don't tell me it's that radical Sotelato who's whispering in your ear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus: ""You give him too much credit, Hugo. My decisions are my ..."*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""I don't approve of this decree in principle...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Hugo Toras: ""However, I understand your intentions.""*)

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""So, you shut their mouths in the Delegate chamber but let them reach a larger audience in the streets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Hugo Toras: ""Tell me, Romus, will that really make them easier to con..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You give them too much credit, Hugo. My decisions are my own.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Hugo Toras: ""Of course they are.""*)

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""So this is the trade, then? Get rid of their leaders with one hand and toss them a printing press with the other?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[149]` (*Player_Romus: ""I just removed a liability. Now the people can truly spe..."*)

### Węzeł `[22]`
Mówca: **Hugo Toras**
> ""I assume this is Manus Sazon whispering in your ear?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus: ""You give him too much credit, Hugo. My decisions are my ..."*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_DeclareIntention_Public == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_DeclareIntention_Public == true || RiziaD..."*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_DeclareIntention_Public == true || Rizi..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_DeclareIntention_Public == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Hugo Toras: ""I assume this is the Rizian People's Party whispering in..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_DeclareIntention_Public == true || RiziaDLC.Policy_RD_Welfare_ElectoralReform == true || RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax == true || RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_LandOwnersTax"] == true  or  Variable["RiziaDLCIsolated.Hugo_DecreeCounsel_InheritanceTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDL..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDL..."*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true && Rizia..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true  and  Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Hugo Toras: ""Don't tell me it's that radical Sotelato who's whisperin..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true && RiziaDLC.Adarfo_Arrested == false && RiziaDLC.Adarfo_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true  and  Variable["RiziaDLC.Adarfo_Arrested"] == false  and  Variable["RiziaDLC.Adarfo_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Hugo Toras: ""So this is the trade, then? Get rid of their leaders wit..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You give him too much credit, Hugo. My decisions are my own.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Hugo Toras), `[17]` (Hugo Toras), `[22]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Hugo Toras: ""Of course they are.""*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And if it were? Does that make the idea wrong, or are you just opposed to it because of who supports it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Hugo Toras), `[12]` (Hugo Toras), `[17]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Hugo Toras: ""I oppose it because I know what will follow it. Permit t..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Hugo, they've infiltrated the palace and now control my every move. I suspect they're hiding under my desk as we speak.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] < 5`
- **Kontekst wejściowy (poprzednik):** `[11]` (Hugo Toras), `[12]` (Hugo Toras), `[17]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1"*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If giving the people something they want prevents greater unrest, then does it matter whose idea it was first?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[11]` (Hugo Toras), `[12]` (Hugo Toras), `[17]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Hugo Toras: ""It matters if the *gift* you're giving them will one day..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is about modernizing Rizia, ensuring our people have access to information beyond what the state allows.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == false`
- **Kontekst wejściowy (poprzednik):** `[11]` (Hugo Toras), `[12]` (Hugo Toras), `[17]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Hugo Toras: ""Or access to manipulation.""*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == false"*)
  - -> `[30]` (*Player_Romus: ""And if it were? Does that make the idea wrong, or are yo..."*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true || RiziaDLCSetup.Current..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true || RiziaDLCSetup.CurrentTurn < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true || RiziaDLCSetup.Current..."*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true || RiziaDLCSetup.Curre..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true || RiziaDLCSetup.CurrentTurn < 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] < 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player_Romus: ""Yes, Hugo, they've infiltrated the palace and now contro..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true || RiziaDLCSetup.CurrentTurn < 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true  or  Variable["RiziaDLCSetup.CurrentTurn"] < 5) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Hugo Toras: ""Mock all you like, but it won't be so funny when their w..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Romus: ""Have you not seen the unrest on the streets? We have to ..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player_Romus: ""If giving the people something they want prevents greate..."*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player_Romus: ""Have you not seen the growing reform movement? This is w..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you not seen the growing reform movement? This is what the people are demanding.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true` AND `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[11]` (Hugo Toras), `[12]` (Hugo Toras), `[17]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Hugo Toras: ""I've also seen what happens when rulers mistake concessi..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you not seen the unrest on the streets? We have to listen to the people to calm the situation.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Kontekst wejściowy (poprzednik):** `[11]` (Hugo Toras), `[12]` (Hugo Toras), `[17]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Hugo Toras: ""I've also seen what happens when rulers mistake concessi..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == false"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == false)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player_Romus: ""This is about modernizing Rizia, ensuring our people hav..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Player_Romus: ""On the contrary, this is about giving citizens the illus..."*)

### Węzeł `[50]`
Mówca: **Hugo Toras**
> ""Or access to manipulation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Hugo Toras: ""Tell me, Your Majesty, what do you think happens the mom..."*)

### Węzeł `[51]`
Mówca: **Hugo Toras**
> ""Tell me, Your Majesty, what do you think happens the moment you allow 'free press' to operate unchecked?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == false || RiziaDLC.Reform_Pat..."*)
  - -> `[65]` (*Player_Romus: ""The same thing that happens when it's kept under a lock ..."*)
  - -> `[181]` (*Player_Romus: ""A little chaos, perhaps. A few angry columns, a few smug..."*)
  - -> `[184]` (*Player_Romus: ""What happens? We let people speak. That's all. Not every..."*)
  - -> `[183]` (*Player_Romus: ""Let me guess. You believe the streets will rise and the ..."*)

### Węzeł `[52]`
Mówca: **Hugo Toras**
> ""I oppose it because I know what will follow it. Permit the media to criticize you, and the RPP will only be the first to jump at the opportunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Hugo Toras: ""Tell me, Your Majesty, what do you think happens the mom..."*)

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""Mock all you like, but it won't be so funny when their words start carrying more weight than ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Hugo Toras: ""Tell me, Your Majesty, what do you think happens the mom..."*)

### Węzeł `[54]`
Mówca: **Hugo Toras**
> ""I've also seen what happens when rulers mistake concessions for control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Hugo Toras: ""Tell me, Your Majesty, what do you think happens the mom..."*)

### Węzeł `[55]`
Mówca: **Hugo Toras**
> ""It matters if the *gift* you're giving them will one day be used to tear down the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Hugo Toras: ""Tell me, Your Majesty, what do you think happens the mom..."*)

### Węzeł `[56]`
Mówca: **Hugo Toras**
> ""Of course they are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Hugo Toras: ""But I can't help but notice that this decree was first p..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Change, Hugo. The kind we can guide, or the kind that will happen without us.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == false  or  Variable["RiziaDLC.Reform_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[51]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "He raised an eyebrow."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_DeclareIntention_Public == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_DeclareIntention_Public == true"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_DeclareIntention_Public == true)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_DeclareIntention_Public == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Hugo Toras: ""I am worried, Romus. You've already thrown your weight b..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_DeclareIntention_Public == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Hugo Toras: ""Or maybe it would be like giving your enemies a megaphon..."*)

### Węzeł `[61]`
Mówca: **Hugo Toras**
> ""But I can't help but notice that this decree was first proposed by the Rizian People's Party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Hugo Toras: ""Tell me, Your Majesty, what do you think happens the mom..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == false || RiziaDLC.Reform_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == false || RiziaDLC.Reform_Pat..."*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == false || RiziaDLC.Reform_P..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == false || RiziaDLC.Reform_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == false  or  Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player_Romus: ""Change, Hugo. The kind we can guide, or the kind that wi..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == false || RiziaDLC.Reform_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == false  or  Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The same thing that happens when it's kept under a lock and key. People will find a way to speak. At least this way, I can see what they're saying.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Hugo Toras: ""Perhaps so.""*)

### Węzeł `[66]`
Mówca: **Hugo Toras**
> ""I am worried, Romus. You've already thrown your weight behind the reform movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "He exhaled slowly, as if holding back his immediate thoug..."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "He raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_DeclareIntention_Public == true"*)

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""Tell me, Romus, will that really make them easier to control?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Execu..."*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[199]` (*Player_Romus: ""Giving them a platform to rant instead of going out to t..."*)
  - -> `[198]` (*Player_Romus: ""Neither is truly controllable, Hugo. But I can still gui..."*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true"*)

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""So, you shut down their leadership but let them reach a larger audience in the streets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Hugo Toras: ""Tell me, Romus, will that really make them easier to con..."*)

### Węzeł `[70]`
Mówca: **Hugo Toras**
> ""Or maybe it would be like giving your enemies a megaphone. An invitation to the radicals and demagogues to undermine you in broad daylight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Hugo Toras: ""And for what? The illusion of transparency? The satisfac..."*)

### Węzeł `[71]`
Mówca: **Hugo Toras**
> ""And for what? The illusion of transparency? The satisfaction of appeasing the RPP?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[72]`
Mówca: **Hugo Toras**
> ""May I speak freely on this subject?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_DeclareIntention_WeakStatement == true &&..."*)
  - -> `[99]` (*Player_Romus: ""If you must...""*)
  - -> `[96]` (*Player_Romus: ""Of course you may, Hugo.""*)
  - -> `[209]` (*Player_Romus: ""As if I could keep you from doing so.""*)
  - -> `[210]` (*Player_Romus: ""Ironically, no. I don't want to hear your opinion on thi..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == false"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseOfDelegates_Abolished == false)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Hugo Toras: ""So, you shut down their leadership but let them reach a ..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseOfDelegates_Abolished == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Hugo Toras: ""So, you shut their mouths in the Delegate chamber but le..."*)

### Węzeł `[76]`
Mówca: **Hugo Toras**
> ""I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Hugo Toras: ""However, I understand your intentions.""*)

### Węzeł `[77]`
Mówca: **Hugo Toras**
> ""However, I understand your intentions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Hugo Toras: ""But I suspect that after your move against the oppositio..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Manus_Gone == true"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Manus_Gone == true)"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Manus_Gone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Manus_Gone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[84]` (*Player_Romus: ""You were the one who advised me to move against Manus, H..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Manus_Gone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Manus_Gone"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[81]`
Mówca: **Hugo Toras**
> ""It is an enormous risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player_Romus: ""A King who cannot face criticism is no King at all. I mu..."*)
  - -> `[98]` (*Player_Romus: ""Maybe you're right. I'm prepared to hold off on this dec..."*)
  - -> `[97]` (*Player_Romus: ""Let them undermine us, Hugo. The people who shout out th..."*)
  - -> `[103]` (*Player_Romus: ""Not everyone is a radical or demagogue, Hugo. But if we ..."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "He exhaled slowly, as if holding back his immediate thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Hugo Toras: ""May I speak freely on this subject?""*)

### Węzeł `[83]`
Mówca: **Hugo Toras**
> ""But I suspect that after your move against the opposition, giving them the means to reach a larger audience may backfire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Hugo Toras: ""Tell me, Romus, will that really make them easier to con..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were the one who advised me to move against Manus, Hugo.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Manus_Gone"] == true`
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Hugo Toras: ""I know.""*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Execu..."*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Exe..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_Arrested"] == true  or  Variable["RiziaDLC.Adarfo_Executed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Player_Romus: ""You didn't protest when I got rid of Mr. Sotelato, now, ..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_Arrested == true || RiziaDLC.Adarfo_Executed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_Arrested"] == true  or  Variable["RiziaDLC.Adarfo_Executed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player_Romus: ""The movement grew radical because I followed your advice..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[91]`
Mówca: **Hugo Toras**
> ""This is an invitation to the radicals and demagogues to undermine you in broad daylight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_DeclareIntention_WeakStatement == true && RiziaDLC.BirthdayGathering_ReformTalks == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_DeclareIntention_WeakStatement == true &&..."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_DeclareIntention_WeakStatement == true ..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_DeclareIntention_WeakStatement == true && RiziaDLC.BirthdayGathering_ReformTalks == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_DeclareIntention_WeakStatement"] == true  and  Variable["RiziaDLC.BirthdayGathering_ReformTalks"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player_Romus: ""Just to be clear. I did not declare my full support. It ..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_DeclareIntention_WeakStatement == true && RiziaDLC.BirthdayGathering_ReformTalks == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_DeclareIntention_WeakStatement"] == true  and  Variable["RiziaDLC.BirthdayGathering_ReformTalks"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just to be clear. I did not declare my full support. It was a strategic decision.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_DeclareIntention_WeakStatement"] == true  and  Variable["RiziaDLC.BirthdayGathering_ReformTalks"] == false`
- **Kontekst wejściowy (poprzednik):** `[72]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Hugo Toras: ""I see...""*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course you may, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_DeclareIntention_Public == true && RiziaD..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let them undermine us, Hugo. The people who shout out their opinions are far less dangerous than the ones who whisper behind our backs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "He shook his head slightly. After a brief pause, he nodded."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe you're right. I'm prepared to hold off on this decree.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "He looked at me with expecting eyes."*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you must...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_DeclareIntention_Public == true && RiziaD..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_DeclareIntention_Public == true && RiziaDLC.Reform_DeclareIntention_WeakStatement == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_DeclareIntention_Public == true && RiziaD..."*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_DeclareIntention_Public == true && Rizi..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_DeclareIntention_Public == true && RiziaDLC.Reform_DeclareIntention_WeakStatement == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true  and  Variable["RiziaDLC.Reform_DeclareIntention_WeakStatement"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Hugo Toras: ""You didn't just support the movement, but validated it. ..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_DeclareIntention_Public == true && RiziaDLC.Reform_DeclareIntention_WeakStatement == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_DeclareIntention_Public"] == true  and  Variable["RiziaDLC.Reform_DeclareIntention_WeakStatement"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Hugo Toras: ""Your words in public were... careful. But you offered th..."*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not everyone is a radical or demagogue, Hugo. But if we silence them completely, it will only grow the radicalism more. Let's listen instead of suppressing them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "He shook his head slightly. After a brief pause, he nodded."*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A King who cannot face criticism is no King at all. I must take the risk.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "He shook his head slightly. After a brief pause, he nodded."*)

### Węzeł `[105]`
Mówca: **Hugo Toras**
> ""This is a dangerous game, Romus. But one you seem eager to play.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Hugo Toras: ""If that's the path you're set on, then so be it.""*)

### Węzeł `[106]`
Mówca: **Narrator**
> "He shook his head slightly. After a brief pause, he nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Hugo Toras: ""This is a dangerous game, Romus. But one you seem eager ..."*)

### Węzeł `[107]`
Mówca: **Hugo Toras**
> ""If that's the path you're set on, then so be it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "I took a look at the decree."*)

### Węzeł `[108]`
Mówca: **Hugo Toras**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Hugo Toras: ""Even if that's the case, your words offered them hope, a..."*)

### Węzeł `[109]`
Mówca: **Hugo Toras**
> ""And now you're pushing this proposal...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Hugo Toras: ""I am worried that this will antagonize our fellow Houses..."*)

### Węzeł `[110]`
Mówca: **Hugo Toras**
> ""Even if that's the case, your words offered them hope, and made the nobility uneasy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Hugo Toras: ""And now you're pushing this proposal...""*)

### Węzeł `[111]`
Mówca: **Hugo Toras**
> ""You didn't just support the movement, but validated it. The nobility is very concerned about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Hugo Toras: ""And now you're pushing this proposal...""*)

### Węzeł `[112]`
Mówca: **Hugo Toras**
> ""I am worried that this will antagonize our fellow Houses against you -- and what you're trying to do...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Hugo Toras: ""So tell me, if I am to stand beside you in what comes ne..."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "He bowed and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnactDecree("Welfare_HumanRights_AllowFreePress");`
- **Efekt skryptowy (`userScript`):** `EnactDecree("Welfare_HumanRights_AllowFreePress");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_CounselIgnored += 1"*)

### Węzeł `[115]`
Mówca: **Narrator**
> "I took a look at the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player_Romus_Italic: "Sign the decree."*)
  - -> `[119]` (*Player_Romus: ""You've given me a lot to consider. I'll hold off on the ..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "Sign the decree."]** — Mówca: **Player_Romus_Italic**
> "I signed the decree."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator), `[143]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "EnactDecree("Welfare_HumanRights_AllowFreePress");"*)

### Węzeł `[117]`
Mówca: **Hugo Toras**
> ""Very well... I truly hope you're ready for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Hugo Toras: ""Goodbye for now.""*)

### Węzeł `[118]`
Mówca: **Hugo Toras**
> ""Goodbye for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "He bowed and left the room."*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've given me a lot to consider. I'll hold off on the decree for now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator), `[143]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Hugo Toras: ""Thank you.""*)

### Węzeł `[120]`
Mówca: **Hugo Toras**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Hugo Toras: ""This is for the best.""*)

### Węzeł `[121]`
Mówca: **Narrator**
> "I gave him the unsigned decree and ended our meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "He bowed and left the room."*)

### Węzeł `[122]`
Mówca: **Hugo Toras**
> ""So tell me, if I am to stand beside you in what comes next…""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Hugo Toras: ""Are you really prepared to face that?""*)

### Węzeł `[123]`
Mówca: **Hugo Toras**
> ""Are you really prepared to face that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player_Romus: ""I am. And I'd be grateful to have my Grand Vizier standi..."*)
  - -> `[124]` (*Player_Romus: ""I didn't rise to this throne to be ruled by them. I will..."*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_DecreeCounsel_Happened > 1"*)
  - -> `[186]` (*Player_Romus: ""Of course they'll be antagonized. They were antagonized ..."*)
  - -> `[132]` (*Player_Romus: ""I thought you wanted to speak freely, Hugo. Don't play m..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't rise to this throne to be ruled by them. I will not be the one to kneel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Hugo Toras: ""It is not just the Houses, Romus.""*)

### Węzeł `[125]`
Mówca: **Hugo Toras**
> ""This is for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "I gave him the unsigned decree and ended our meeting."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "He looked at me with expecting eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "I took a look at the decree."*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're bringing up the other Houses again to warn me? Enough of this, Hugo.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] > 1`
- **Kontekst wejściowy (poprzednik):** `[123]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Hugo Toras: ""Fine. I will speak of this no more.""*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_DecreeCounsel_Happened > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_DecreeCounsel_Happened > 1"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_DecreeCounsel_Happened > 1)"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_DecreeCounsel_Happened > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player_Romus: ""You're bringing up the other Houses again to warn me? En..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_DecreeCounsel_Happened > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] > 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am. And I'd be grateful to have my Grand Vizier standing behind me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Hugo Toras: ""Well, you know what I think, Romus.""*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thought you wanted to speak freely, Hugo. Don't play mind games with me. Just say it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Hugo Toras: ""Well, you know what I think, Romus.""*)

### Węzeł `[133]`
Mówca: **Hugo Toras**
> ""Well, you know what I think, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Hugo Toras: ""I am against this decree. And I am against working with ..."*)

### Węzeł `[134]`
Mówca: **Hugo Toras**
> ""I am against this decree. And I am against working with the RPP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Hugo Toras: ""But I will speak of this no more. I will support you in ..."*)

### Węzeł `[135]`
Mówca: **Hugo Toras**
> ""But I will speak of this no more. I will support you in whatever you decide to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: ""Good.""*)
  - -> `[137]` (*Player_Romus: ""Maybe you're right. I'm prepared to hold off on this dec..."*)
  - -> `[136]` (*Player_Romus: ""Finally.""*)
  - -> `[138]` (*Player_Romus: ""I'm warning you, Hugo. I hope you're not thinking of any..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Finally.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "I took a look at the decree."*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe you're right. I'm prepared to hold off on this decree.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "He looked at me with expecting eyes."*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm warning you, Hugo. I hope you're not thinking of anything rash.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Hugo Toras: ""Rash? I am the Grand Vizier, Romus. Your uncle. If I can..."*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "I took a look at the decree."*)

### Węzeł `[140]`
Mówca: **Hugo Toras**
> ""Fine. I will speak of this no more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "He shook his head slightly. After a brief pause, he nodded."*)

### Węzeł `[141]`
Mówca: **Hugo Toras**
> ""This decree is an invitation to the radicals and demagogues to undermine you in broad daylight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[142]`
Mówca: **Hugo Toras**
> ""Rash? I am the Grand Vizier, Romus. Your uncle. If I cannot question your path, then who can?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Hugo Toras: ""I serve this House and this throne, as I always have. I ..."*)

### Węzeł `[143]`
Mówca: **Narrator**
> "I ignored him and took a look at the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player_Romus_Italic: "Sign the decree."*)
  - -> `[119]` (*Player_Romus: ""You've given me a lot to consider. I'll hold off on the ..."*)

### Węzeł `[144]`
Mówca: **Hugo Toras**
> ""I serve this House and this throne, as I always have. I do not need to prove that to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "I ignored him and took a look at the decree."*)

### Węzeł `[145]`
Mówca: **Hugo Toras**
> ""It is not just the Houses, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Hugo Toras: ""This decree is an invitation to the radicals and demagog..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player_Romus: ""You make it sound like charity. I prefer to think of it ..."*)
  - -> `[162]` (*Player_Romus: ""Exactly. And what is your opinion on this matter?""*)
  - -> `[163]` (*Player_Romus: ""And what would you have me do instead, Hugo? Silence the..."*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You make it sound like charity. I prefer to think of it as balance. Let them vent, let them shout. It's easier to rule those who believe they still have choices.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Hugo Toras), `[21]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Hugo Toras: ""A bold move, indeed.""*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Their democracy was a shadow play. I simply turned on the lights.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Hugo Toras: ""A bold move, indeed.""*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I just removed a liability. Now the people can truly speak their minds, not just repeat the words of their puppetmasters.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Hugo Toras: ""A bold move, indeed.""*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's precisely the plan.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Hugo Toras), `[180]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == false"*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So, you approve of it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Hugo Toras), `[180]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Hugo Toras: ""I don't approve of this decree in principle...""*)

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So, this time you're not here to warn me?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] > 0`
- **Kontekst wejściowy (poprzednik):** `[179]` (Hugo Toras), `[180]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Hugo Toras: ""I am.""*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_DecreeCounsel_Happened > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_DecreeCounsel_Happened > 0"*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_DecreeCounsel_Happened > 0)"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_DecreeCounsel_Happened > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player_Romus: ""So, this time you're not here to warn me?""*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_DecreeCounsel_Happened > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_DecreeCounsel_Happened"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Illusions can be useful, Hugo. Let them believe they have a voice. It costs me nothing, and it keeps them from demanding more.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[179]` (Hugo Toras), `[180]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == false"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player_Romus: ""Power has never been about volume. They can shout all th..."*)
  - -> `[150]` (*Player_Romus: ""That's precisely the plan.""*)
  - -> `[151]` (*Player_Romus: ""So, you approve of it?""*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_DecreeCounsel_Happened > 0"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player_Romus: ""Illusions can be useful in times of growing radicalism. ..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Player_Romus: ""Illusions can be useful, Hugo. Let them believe they hav..."*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Power has never been about volume. They can shout all they want in the papers, as long as they remember by whose grace they are printed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Hugo Toras), `[180]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == false"*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Exactly. And what is your opinion on this matter?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Hugo Toras), `[21]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Hugo Toras: ""It's a bold move.""*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what would you have me do instead, Hugo? Silence them entirely?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Hugo Toras), `[21]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Hugo Toras: ""No. I think it's a bold move.""*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player_Romus: ""Have you not seen the unrest on the streets? We have to ..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true)"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player_Romus: ""Have you not seen the growing reform movement? We have t..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you not seen the growing reform movement? We have to give something back to the people to calm the situation.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true` AND `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[13]` (Hugo Toras), `[21]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Hugo Toras: ""It's a bold move indeed. But I disagree that we *have to*."*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you not seen the unrest on the streets? We have to give something back to the people to calm the situation.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Kontekst wejściowy (poprzednik):** `[13]` (Hugo Toras), `[21]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Hugo Toras: ""It's a bold move indeed. But I disagree that we *have to*."*)

### Węzeł `[172]`
Mówca: **Hugo Toras**
> ""It's a bold move indeed. But I disagree that we *have to*."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == false"*)

### Węzeł `[173]`
Mówca: **Hugo Toras**
> ""It's a bold move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == false"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == false"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseOfDelegates_Abolished == false)"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Hugo Toras: ""They lose their loudest voices, but gain some in the pap..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseOfDelegates_Abolished == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Hugo Toras: ""They lose their voice in government, but gain some in th..."*)

### Węzeł `[177]`
Mówca: **Hugo Toras**
> ""No. I think it's a bold move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == false"*)

### Węzeł `[178]`
Mówca: **Hugo Toras**
> ""A bold move, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == false"*)

### Węzeł `[179]`
Mówca: **Hugo Toras**
> ""They lose their loudest voices, but gain some in the papers. You're giving them the illusion of power, while keeping it away from them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[180]`
Mówca: **Hugo Toras**
> ""They lose their voice in government, but gain some in the papers. You're giving them the illusion of power, while keeping it away from them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A little chaos, perhaps. A few angry columns, a few smug intellectuals thinking they've won something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Hugo Toras: ""Perhaps so.""*)

### Węzeł `[182]`
Mówca: **Hugo Toras**
> ""Perhaps so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_DeclareIntention_Public == true"*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let me guess. You believe the streets will rise and the monarchy will crumble overnight. Or, perhaps, people will just read the news over breakfast and carry on with their lives.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Hugo Toras: ""Perhaps so.""*)

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What happens? We let people speak. That's all. Not every decision is a step toward revolution, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Hugo Toras: ""Perhaps so.""*)

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Illusions can be useful in times of growing radicalism. Let them believe they have a voice. It costs me nothing, and it hopefully keeps them from demanding more.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Kontekst wejściowy (poprzednik):** `[179]` (Hugo Toras), `[180]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == false"*)

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course they'll be antagonized. They were antagonized the moment I was crowned and refused to be their puppet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "He shook his head slightly. After a brief pause, he nodded."*)

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You didn't protest when I got rid of Mr. Sotelato, now, did you?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Adarfo_Arrested"] == true  or  Variable["RiziaDLC.Adarfo_Executed"] == true`
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Hugo Toras: ""I know.""*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The movement grew radical because I followed your advice to get rid of Mr. Sazon.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true` AND `Variable["RiziaDLC.Manus_Gone"] == true`
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Hugo Toras: ""Yes. I...""*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are long past that stage. We're already losing control over the streets.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Hugo Toras: ""You are right.""*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The House of Delegates is already abolished, Hugo. This isn't helpful.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true`
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Hugo Toras: ""You are right.""*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Player_Romus: ""We are long past that stage. We're already losing contro..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true"*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseOfDelegates_Abolished == true)"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player_Romus: ""The House of Delegates is already abolished, Hugo. This ..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseOfDelegates_Abolished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Player_Romus: ""I see your point.""*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see your point.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Hugo Toras: ""Just think about it. This would be an invitation to radi..."*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Neither is truly controllable, Hugo. But I can still guide what's happening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Hugo Toras: ""Perhaps so.""*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Giving them a platform to rant instead of going out to the streets *is* control.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Hugo Toras: ""Perhaps so.""*)

### Węzeł `[200]`
Mówca: **Hugo Toras**
> ""Perhaps so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Hugo Toras: ""But I still think this will be an invitation to the radi..."*)

### Węzeł `[201]`
Mówca: **Hugo Toras**
> ""You are right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Hugo Toras: ""But I still think this will be an invitation to the radi..."*)

### Węzeł `[202]`
Mówca: **Hugo Toras**
> ""I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "He sighed."*)

### Węzeł `[203]`
Mówca: **Hugo Toras**
> ""Yes. I...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "He sighed."*)

### Węzeł `[204]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Hugo Toras: ""But I didn't think you'd now give them the chance to rev..."*)

### Węzeł `[205]`
Mówca: **Hugo Toras**
> ""Just think about it. This would be an invitation to radicals and demagogues to undermine you in broad daylight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[206]`
Mówca: **Hugo Toras**
> ""But I didn't think you'd now give them the chance to reveal to everyone how the Crown moved against their leader.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Hugo Toras: ""This is an invitation to the radicals and demagogues to ..."*)

### Węzeł `[207]`
Mówca: **Hugo Toras**
> ""A bold idea. But...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Hugo Toras: ""Tell me, Your Majesty, what do you think happens the mom..."*)

### Węzeł `[208]`
Mówca: **Hugo Toras**
> ""But I still think this will be an invitation to the radicals and demagogues to undermine you in broad daylight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As if I could keep you from doing so.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_DeclareIntention_Public == true && RiziaD..."*)

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ironically, no. I don't want to hear your opinion on this subject. I've already made up my mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "He shook his head slightly. After a brief pause, he nodded."*)

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On the contrary, this is about giving citizens the illusion of power while keeping them under our control.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[11]` (Hugo Toras), `[12]` (Hugo Toras), `[17]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Hugo Toras: ""A bold idea. But...""*)

### Węzeł `[212]`
Mówca: **Hugo Toras**
> ""Your words in public were... careful. But you offered them hope, and made the nobility uneasy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Hugo Toras: ""And now you're pushing this proposal...""*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Hugo Toras: ""You're too young to remember the Voice of Rizia. But I do.""*)

### Węzeł `[214]`
Mówca: **Hugo Toras**
> ""You're too young to remember the Voice of Rizia. But I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Hugo Toras: ""Its writers didn't only attack the King's policies. They..."*)

### Węzeł `[215]`
Mówca: **Hugo Toras**
> ""Its writers didn't only attack the King's policies. They went after his personal life... even his family members.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Hugo Toras: ""It is an enormous risk.""*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_CounselIgnored += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Hugo_CounselIgnored"] = Variable["RiziaDLC.Hugo_CounselIgnored"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Hugo Toras: ""Very well... I truly hope you're ready for this.""*)
