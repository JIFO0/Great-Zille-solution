# Sordland/Turn08/GLORIA FEEDBACK

- **ID konwersacji:** `173`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/173_GLORIA_FEEDBACK.md`
- **Liczba węzłów dialogowych:** 252
- **Liczba wyborów gracza:** 54

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[34]** Gloria Tory

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Reform_Heron_PromisedChiefJustice`
- `BaseGame.Turn07_Results_Focus_Campaign`
- `BaseGame.Turn07_Results_Focus_Economy`
- `BaseGame.Turn07_SecretState_Detained_FrensRicter`
- `BaseGame.Turn07_SecretState_Detained_KesaroKibener`
- `BaseGame.Turn07_SecretState_Kill_FrensRicter`
- `BaseGame.Turn07_SecretState_Kill_KesaroKibener`
- `BaseGame.Turn08_Action_Campaign_ExtraBudget`
- `BaseGame.Turn08_Action_Court_ExperiencedJustice`
- `BaseGame.Turn08_Action_Court_LoyalJustice`
- `BaseGame.Turn08_Action_Court_OldGuardReplaced`
- `BaseGame.Turn08_Action_Court_Shuffled`
- `BaseGame.Turn08_Action_Party_Conservative`
- `BaseGame.Turn08_Action_Party_Liberal`
- `BaseGame.Turn08_Action_Party_Socialist`
- `BaseGame.Turn08_Action_Party_Ultranationalist`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Bergia_Governor_Ersen`
- `BaseGame.Bergia_Governor_Krull`
- `BaseGame.Public_Opinion`
- `BaseGameIsolated.PoliticalOverview2_TvAd`
- `BaseGameSupport.Codex_Characters_Others_IshvalErsen`
- `BaseGameSupport.Codex_Characters_StateFigures_IshvalErsen_SpecialZone`
- `BaseGameSupport.Codex_Characters_StateFigures_PhelixBron`
- `BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_ReplacedByOvidGrecer`
- `BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Bron`
- `BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Ersen`
- `BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty`
- `BaseGameSupport.News_Turn08_R_OvidGrecerFindsBronGuilty`
- `BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Amended`
- `BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Default`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[171] Sordland/Turn08/A_PoliticalOverview2** (../Turn_08/171_A_PoliticalOverview2.md), Węzeł `[572]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[20]` | **"“That sounds great. I always wanted to be a television star.”"** | `[19]` **Gloria Tory**: "“This way the people can feel cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Gloria Tory**: "“I'll note that down as a yes, t..." |
| `[21]` | **"“It's a good plan. Let's do it.”"** | `[19]` **Gloria Tory**: "“This way the people can feel cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Gloria Tory**: "“Great. You won't regret it."" |
| `[22]` | **"“I won't allow regular citizens to come in here. What's next? Tourists roaming the..."** | `[19]` **Gloria Tory**: "“This way the people can feel cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Gloria Tory**: "“Very well. Then that's a no.”" |
| `[29]` | **"“It's not my favorite idea, but if it helps with the election, I guess I have no c..."** | `[19]` **Gloria Tory**: "“This way the people can feel cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Gloria Tory**: "“Great. You won't regret it."" |
| `[37]` | **"“This better be good. For his own good.”"** | `[36]` **Gloria Tory**: "“He will schedule a meeting soon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Gloria Tory**: "“I am sure Mr. Holl will deliver..." |
| `[38]` | **"“Tell him to be quick. Our administration depends on it.”"** | `[36]` **Gloria Tory**: "“He will schedule a meeting soon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Gloria Tory**: "“I understand. I'll make sure he..." |
| `[39]` | **"“Symon can pull it off, I'm sure. He has never failed me before.”"** | `[36]` **Gloria Tory**: "“He will schedule a meeting soon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Gloria Tory**: "“Mr. Holl knows what he's doing...." |
| `[40]` | **"“I will be expecting good ideas and even better outcomes.”"** | `[36]` **Gloria Tory**: "“He will schedule a meeting soon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Gloria Tory**: "“Of course. So am I."" |
| `[46]` | **"“This is very bad. He and Orso are basically the same person.""** | `[57]` **Gloria Tory**: "“More importantly, though, Heron..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Gloria Tory**: "“With a key difference: Orso was..." |
| `[48]` | **"“Excellent news. I'm happy our appointment got elected.""** | `[69]` **Gloria Tory**: "“This change should increase the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Gloria Tory**: "“I assure you, you're not the on..." |
| `[49]` | **"“Let's hope he is better than Orso.”"** | `[69]` **Gloria Tory**: "“This change should increase the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Gloria Tory**: "“That isn't a high mark to clear."" |
| `[51]` | **"“This is an important milestone for Sordish democracy.”"** | `[69]` **Gloria Tory**: "“This change should increase the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Gloria Tory**: "“It's progress, for sure."" |
| `[65]` | **"“So they decided to betray me and the party. They will see their mistakes one day.”"** | `[63]` **Gloria Tory**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Gloria Tory**: "“If you say so, Mr. President.”" |
| `[66]` | **"“It was an unfortunate and necessary sacrifice.”"** | `[63]` **Gloria Tory**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Gloria Tory**: "“If you say so, Mr. President.”" |
| `[67]` | **"“As I expected. We don't need anyone who won't stay by our side.”"** | `[63]` **Gloria Tory**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Gloria Tory**: "“If you say so, Mr. President.”" |
| `[68]` | **"“What do you think about it?”"** | `[63]` **Gloria Tory**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Gloria Tory**: "“I think we'll gain enough conse..." |
| `[70]` | **"“As I expected. We don't need anyone who won't stay by our side.”"** | `[76]` **Gloria Tory**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Gloria Tory**: "“If you say so, Mr. President.”" |
| `[72]` | **"“So they decided to betray me and the party. They will see their mistakes one day.”"** | `[76]` **Gloria Tory**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Gloria Tory**: "“If you say so, Mr. President.”" |
| `[78]` | **"“So they decided to betray me and the party. They will see their mistakes one day.”"** | `[82]` **Gloria Tory**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Gloria Tory**: "“If you say so, Mr. President.”" |
| `[79]` | **"“It was an unfortunate and a necessary sacrifice.”"** | `[82]` **Gloria Tory**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Gloria Tory**: "“If you say so, Mr. President.”" |
| `[80]` | **"“As I expected. We don't need anyone who won't stay by our side.”"** | `[82]` **Gloria Tory**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Gloria Tory**: "“If you say so, Mr. President.”" |
| `[86]` | **"“It was an unfortunate and necessary sacrifice.”"** | `[76]` **Gloria Tory**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Gloria Tory**: "“If you say so, Mr. President.”" |
| `[113]` | **"“I hope the money went into the right place instead of their pockets.”"** | `[111]` **Gloria Tory**: "“This will definitely boost our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Gloria Tory**: "“I am sure of it.”" |
| `[114]` | **"“Excellent. We need all the help we can get.""** | `[111]` **Gloria Tory**: "“This will definitely boost our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Gloria Tory**: "“Agreed.”" |
| `[115]` | **"“Good work.”"** | `[111]` **Gloria Tory**: "“This will definitely boost our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Gloria Tory**: "“Thank you. I'm trying my best.”" |
| `[116]` | **"“This is an important milestone for Sordish democracy.”"** | `[134]` **Gloria Tory**: "“He is a seasoned veteran with a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Gloria Tory**: "“It's certainly a step forward."" |
| `[117]` | **"“Let's hope he will be better than Orso.”"** | `[134]` **Gloria Tory**: "“He is a seasoned veteran with a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Gloria Tory**: "“That isn't a high mark to clear."" |
| `[118]` | **"“Can he be trusted?”"** | `[134]` **Gloria Tory**: "“He is a seasoned veteran with a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Gloria Tory**: "“He doesn't seem to have any pol..." |
| `[121]` | **"“Let's hope Heron is better than Orso.”"** | `[57]` **Gloria Tory**: "“More importantly, though, Heron..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Gloria Tory**: "“Not a high mark to clear. But w..." |
| `[135]` | **"“This is an important milestone for Sordish democracy.”"** | `[57]` **Gloria Tory**: "“More importantly, though, Heron..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Gloria Tory**: "“I wish I could be as optimistic..." |
| `[137]` | **"“What do you think about it?”"** | `[82]` **Gloria Tory**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Gloria Tory**: "“These members were with us for ..." |
| `[141]` | **"“So they decided to betray me and the party. They will see their mistakes one day.”"** | `[146]` **Gloria Tory**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Gloria Tory**: "“If you say so, Mr. President.”" |
| `[142]` | **"“It was an unfortunate and a necessary sacrifice.”"** | `[146]` **Gloria Tory**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Gloria Tory**: "“If you say so, Mr. President.”" |
| `[143]` | **"“As I expected. We don't need anyone who won't stay by our side.”"** | `[146]` **Gloria Tory**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Gloria Tory**: "“If you say so, Mr. President.”" |
| `[145]` | **"“What do you think about it?”"** | `[146]` **Gloria Tory**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Gloria Tory**: "“It wasn't unexpected. Socialism..." |
| `[151]` | **"“Excellent news. I am glad to see him elected.”"** | `[57]` **Gloria Tory**: "“More importantly, though, Heron..." | `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true` | *Brak zmian stanu* | `[136]` **Gloria Tory**: "“I'm surprised you would trust a..." |
| `[152]` | **"“What do you think about it?”"** | `[76]` **Gloria Tory**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Gloria Tory**: "“It wasn't unexpected. But our i..." |
| `[156]` | **"“Can we trust him?”"** | `[69]` **Gloria Tory**: "“This change should increase the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Gloria Tory**: "“I would. He's renowned for his ..." |
| `[180]` | **"“We won't.”"** | `[179]` **Gloria Tory**: "“We shouldn't underestimate her.”"<br>`[251]` **Gloria Tory**: "“Then you know we shouldn't unde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Gloria Tory**: "“I expected as much from you.”" |
| `[181]` | **"“What can she do when Frens couldn't do anything?”"** | `[179]` **Gloria Tory**: "“We shouldn't underestimate her.”"<br>`[251]` **Gloria Tory**: "“Then you know we shouldn't unde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Gloria Tory**: "“If she can tap into Frens' base..." |
| `[182]` | **"“What if she were to meet the same fate as Frens?""** | `[179]` **Gloria Tory**: "“We shouldn't underestimate her.”"<br>`[251]` **Gloria Tory**: "“Then you know we shouldn't unde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Gloria Tory**: "“I'm going to pretend I didn't h..." |
| `[183]` | **"“Don't be alarmed. We have nothing to worry about.”"** | `[179]` **Gloria Tory**: "“We shouldn't underestimate her.”"<br>`[251]` **Gloria Tory**: "“Then you know we shouldn't unde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Gloria Tory**: "“Better safe than sorry.”" |
| `[196]` | **""I'd say it's time for the 'Iron Wall' to come down.”"** | `[201]` **Gloria Tory**: "“I can say with certainty that h..."<br>`[244]` **Gloria Tory**: ""Then you know that he'll be a p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Gloria Tory**: "“Wordplay. Clever."" |
| `[197]` | **"“He doesn't scare me. I have dealt with much worse.”"** | `[201]` **Gloria Tory**: "“I can say with certainty that h..."<br>`[244]` **Gloria Tory**: ""Then you know that he'll be a p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Gloria Tory**: "“It's better to be on the side o..." |
| `[198]` | **"“Make sure he never becomes a big problem then.”"** | `[201]` **Gloria Tory**: "“I can say with certainty that h..."<br>`[244]` **Gloria Tory**: ""Then you know that he'll be a p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Gloria Tory**: "“We will do our best.”" |
| `[199]` | **"“He can never *ever* hope to reach Kesaro's level.”"** | `[201]` **Gloria Tory**: "“I can say with certainty that h..."<br>`[244]` **Gloria Tory**: ""Then you know that he'll be a p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[202]` **Gloria Tory**: "“As much as I don't like either ..." |
| `[225]` | **""I'm already liking Chief Justice Grecer.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Gloria Tory**: ""In any case..."" |
| `[226]` | **""This is great news, Gloria!""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Gloria Tory**: ""In any case..."" |
| `[227]` | **""Honestly, I don't even want to hear about Bergia anymore.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Gloria Tory**: ""In any case..."" |
| `[228]` | **""This is a great development for Bludish rights in Sordland.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Gloria Tory**: ""In any case..."" |
| `[242]` | **""I don't recall. What can you tell me about him?""** | `[192]` **Gloria Tory**: "“It's Remus Holstron, also known..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Gloria Tory**: "“As one of the most enthusiastic..." |
| `[243]` | **""Oh, yes. I know all about him.""** | `[192]` **Gloria Tory**: "“It's Remus Holstron, also known..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[244]` **Gloria Tory**: ""Then you know that he'll be a p..." |
| `[249]` | **""Yes, say no more. I know all about her.""** | `[248]` **Gloria Tory**: ""You've met her before, I think."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[251]` **Gloria Tory**: "“Then you know we shouldn't unde..." |
| `[250]` | **""Briefly. What can you tell me about her?""** | `[248]` **Gloria Tory**: ""You've met her before, I think."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Gloria Tory**: "“I don't know how she made it in..." |

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
  - -> `[3]` (*Gloria Tory: "“I wanted to provide you with some quick updates on the c..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`

### Węzeł `[3]`
Mówca: **Gloria Tory**
> "“I wanted to provide you with some quick updates on the current political situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "She pulled out a few documents from a briefcase and laid ..."*)

### Węzeł `[4]`
Mówca: **Gloria Tory**
> "“The changes you ordered to the Supreme Court have now been implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Gloria Tory: "“The entire Court has been reshuffled. We're starting a n..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Results_Focus_Campaign == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Focus_Campaign == true"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Results_Focus_Campaign == true)"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Results_Focus_Campaign == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Results_Focus_Campaign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Gloria Tory: "“As you know, I've redoubled my focus on improving our pu..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Results_Focus_Campaign == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Results_Focus_Campaign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Focus_Economy == true"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Results_Focus_Economy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Focus_Economy == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Results_Focus_Economy == true)"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Results_Focus_Economy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Results_Focus_Economy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Gloria Tory: "“Mr. Holl has reported to me that he is currently putting..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Results_Focus_Economy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Results_Focus_Economy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Conservative == true"*)

### Węzeł `[11]`
Mówca: **Gloria Tory**
> "“The entire Court has been reshuffled. We're starting a new era.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Gloria Tory: "“Of course, the members we replaced are now furious, but ..."*)

### Węzeł `[12]`
Mówca: **Gloria Tory**
> "“As you know, I've redoubled my focus on improving our public image.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Gloria Tory: "“There's now a decision to be made.""*)

### Węzeł `[13]`
Mówca: **Gloria Tory**
> "“There's now a decision to be made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Gloria Tory: "“Our initial reports are showing that advertisement over ..."*)

### Węzeł `[14]`
Mówca: **Gloria Tory**
> "“Our initial reports are showing that advertisement over television is becoming a very effective method. Especially among young people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Gloria Tory: "“I have consulted with a few advisors and we would like t..."*)

### Węzeł `[15]`
Mówca: **Gloria Tory**
> ""Saying that the replaced members were furious would be an understatement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Gloria Tory: "“But there isn't much they can do about it now that they'..."*)

### Węzeł `[16]`
Mówca: **Gloria Tory**
> "“I have consulted with a few advisors and we would like to put out a television campaign. We've already got Sordland's biggest ad agency on board for the job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Gloria Tory: "“For this, they will be given security clearance to come ..."*)

### Węzeł `[17]`
Mówca: **Gloria Tory**
> "“For this, they will be given security clearance to come in and take photos and videos in the Maroon Palace. Specifically they want footage of the president working and posing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Gloria Tory: "“This way the people can feel closer to their leader in t..."*)

### Węzeł `[18]`
Mówca: **Gloria Tory**
> "“The entirety of the Old Guard has been purged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Gloria Tory: ""Saying that the replaced members were furious would be a..."*)

### Węzeł `[19]`
Mówca: **Gloria Tory**
> "“This way the people can feel closer to their leader in their homes. What do you think?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: "“That sounds great. I always wanted to be a television st..."*)
  - -> `[21]` (*Player: "“It's a good plan. Let's do it.”"*)
  - -> `[22]` (*Player: "“I won't allow regular citizens to come in here. What's n..."*)
  - -> `[29]` (*Player: "“It's not my favorite idea, but if it helps with the elec..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“That sounds great. I always wanted to be a television star.”"]** — Mówca: **Player**
> "“That sounds great. I always wanted to be a television star.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Gloria Tory: "“I'll note that down as a yes, then.""*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“It's a good plan. Let's do it.”"]** — Mówca: **Player**
> "“It's a good plan. Let's do it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Gloria Tory: "“Great. You won't regret it.""*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“I won't allow regular citizens to come in here. What's next? Tourists roaming the Palace halls?""]** — Mówca: **Player**
> "“I won't allow regular citizens to come in here. What's next? Tourists roaming the Palace halls?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Gloria Tory: "“Very well. Then that's a no.”"*)

### Węzeł `[23]`
Mówca: **Gloria Tory**
> "“The changes you ordered to the Supreme Court have now been implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Gloria Tory: "“The entirety of the Old Guard has been purged.""*)

### Węzeł `[24]`
Mówca: **Gloria Tory**
> "“I'll note that down as a yes, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Gloria Tory: "“I will notify the filming crew.”"*)

### Węzeł `[25]`
Mówca: **Gloria Tory**
> "“But there isn't much they can do about it now that they've been stripped of power.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Gloria Tory: "“The new Chief Justice elected by the Court is mostly an ..."*)

### Węzeł `[26]`
Mówca: **Gloria Tory**
> "“Very well. Then that's a no.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Campaign_ExtraBudget == true"*)

### Węzeł `[27]`
Mówca: **Gloria Tory**
> "“Of course, the members we replaced are now furious, but there's not much they can do to act upon it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Gloria Tory: "“The new Chief Justice elected by the Court is mostly an ..."*)

### Węzeł `[28]`
Mówca: **Gloria Tory**
> "“Great. You won't regret it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Gloria Tory: "“I will notify the filming crew.”"*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“It's not my favorite idea, but if it helps with the election, I guess I have no choice.""]** — Mówca: **Player**
> "“It's not my favorite idea, but if it helps with the election, I guess I have no choice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Gloria Tory: "“Great. You won't regret it.""*)

### Węzeł `[30]`
Mówca: **Gloria Tory**
> "“I will notify the filming crew.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 3"*)

### Węzeł `[31]`
Mówca: **Gloria Tory**
> "“With a key difference: Orso was smarter. This could still prove to be positive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "She closed the folder and put away the documents."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 3`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.PoliticalOverview2_TvAd = true"*)

### Węzeł `[33]`
Mówca: **Narrator**
> "She flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Gloria Tory: "“The changes you ordered to the Supreme Court have now be..."*)

### Węzeł `[34]`
Mówca: **Gloria Tory**
> "“Mr. Holl has reported to me that he is currently putting the finishing touches on his new economic plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Gloria Tory: "“He said he wanted to solidify the plan before it is pres..."*)

### Węzeł `[35]`
Mówca: **Gloria Tory**
> "“He said he wanted to solidify the plan before it is presented to you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Gloria Tory: "“He will schedule a meeting soon to go over our options.”"*)

### Węzeł `[36]`
Mówca: **Gloria Tory**
> "“He will schedule a meeting soon to go over our options.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "“Tell him to be quick. Our administration depends on it.”"*)
  - -> `[39]` (*Player: "“Symon can pull it off, I'm sure. He has never failed me ..."*)
  - -> `[40]` (*Player: "“I will be expecting good ideas and even better outcomes.”"*)
  - -> `[37]` (*Player: "“This better be good. For his own good.”"*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“This better be good. For his own good.”"]** — Mówca: **Player**
> "“This better be good. For his own good.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Gloria Tory: "“I am sure Mr. Holl will deliver. But I'll remind him of ..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Tell him to be quick. Our administration depends on it.”"]** — Mówca: **Player**
> "“Tell him to be quick. Our administration depends on it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Gloria Tory: "“I understand. I'll make sure he's aware of the urgency o..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Symon can pull it off, I'm sure. He has never failed me before.”"]** — Mówca: **Player**
> "“Symon can pull it off. I'm sure. He has never failed me before.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Gloria Tory: "“Mr. Holl knows what he's doing. I am sure he will delive..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "“I will be expecting good ideas and even better outcomes.”"]** — Mówca: **Player**
> "“I will be expecting good ideas and even better outcomes.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Gloria Tory: "“Of course. So am I.""*)

### Węzeł `[41]`
Mówca: **Gloria Tory**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "She flipped the page."*)

### Węzeł `[42]`
Mówca: **Gloria Tory**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "She flipped the page."*)

### Węzeł `[43]`
Mówca: **Gloria Tory**
> "“Of course. So am I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[44]`
Mówca: **Narrator**
> "She flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Gloria Tory: "“The changes you ordered to the Supreme Court have now be..."*)

### Węzeł `[45]`
Mówca: **Gloria Tory**
> "“I understand. I'll make sure he's aware of the urgency of the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "“This is very bad. He and Orso are basically the same person.""]** — Mówca: **Player**
> "“This is very bad. He and Orso are basically the same person.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Gloria Tory: "“With a key difference: Orso was smarter. This could stil..."*)

### Węzeł `[47]`
Mówca: **Gloria Tory**
> "“Mr. Holl knows what he's doing. I am sure he will deliver as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Excellent news. I'm happy our appointment got elected.""]** — Mówca: **Player**
> "“Excellent news. I'm happy our appointment got elected.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Gloria Tory: "“I assure you, you're not the only one.""*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "“Let's hope he is better than Orso.”"]** — Mówca: **Player**
> "“Let's hope he is better than Orso.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Gloria Tory: "“That isn't a high mark to clear.""*)

### Węzeł `[50]`
Mówca: **Gloria Tory**
> "“I am sure Mr. Holl will deliver. But I'll remind him of the importance of his task.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Gloria Tory: "“It's progress, for sure.""*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Conservative == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Conservative == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Party_Conservative == true)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Conservative == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Conservative"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Gloria Tory: "“To begin with, your changes to the party manifesto have ..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Party_Conservative == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Conservative"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Liberal == true"*)

### Węzeł `[55]`
Mówca: **Narrator**
> "She pulled out a few documents from a briefcase and laid them on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Focus_Campaign == true"*)

### Węzeł `[56]`
Mówca: **Gloria Tory**
> "“He is certainly going to be loyal to us, and that means considerable power and sway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Gloria Tory: "“More importantly, though, Heron Garaci has been selected..."*)

### Węzeł `[57]`
Mówca: **Gloria Tory**
> "“More importantly, though, Heron Garaci has been selected as the new Chief Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true"*)
  - -> `[121]` (*Player: "“Let's hope Heron is better than Orso.”"*)
  - -> `[135]` (*Player: "“This is an important milestone for Sordish democracy.”"*)
  - -> `[46]` (*Player: "“This is very bad. He and Orso are basically the same per..."*)

### Węzeł `[58]`
Mówca: **Gloria Tory**
> "“Mr. Didier Meye has begun his duty as a Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Gloria Tory: "“He is certainly going to be loyal to us, and that means ..."*)

### Węzeł `[59]`
Mówca: **Gloria Tory**
> "“To begin with, your changes to the party manifesto have angered quite a few members of the reformist wing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Gloria Tory: "“Some of the reformist MPs have decided to quit the party..."*)

### Węzeł `[60]`
Mówca: **Gloria Tory**
> "“The changes you ordered to the Supreme Court have now been implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Gloria Tory: "“Mr. Didier Meye has begun his duty as a Justice.”"*)

### Węzeł `[61]`
Mówca: **Gloria Tory**
> "“Some of the reformist MPs have decided to quit the party. 13 to be exact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Gloria Tory: "“Their places have been filled with people more aligned w..."*)

### Węzeł `[62]`
Mówca: **Gloria Tory**
> "“I assure you, you're not the only one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[63]`
Mówca: **Gloria Tory**
> "“Their places have been filled with people more aligned with our new direction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: "“As I expected. We don't need anyone who won't stay by ou..."*)
  - -> `[66]` (*Player: "“It was an unfortunate and necessary sacrifice.”"*)
  - -> `[65]` (*Player: "“So they decided to betray me and the party. They will se..."*)
  - -> `[68]` (*Player: "“What do you think about it?”"*)

### Węzeł `[64]`
Mówca: **Gloria Tory**
> "“If you say so, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Gloria Tory: "“If you say so, Mr. President.”"*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“It was an unfortunate and necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and necessary sacrifice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Gloria Tory: "“If you say so, Mr. President.”"*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Gloria Tory: "“If you say so, Mr. President.”"*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Gloria Tory: "“I think we'll gain enough conservative support to withst..."*)

### Węzeł `[69]`
Mówca: **Gloria Tory**
> "“This change should increase the trust in the capabilities of the Supreme Court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Player: "“Can we trust him?”"*)
  - -> `[48]` (*Player: "“Excellent news. I'm happy our appointment got elected.""*)
  - -> `[49]` (*Player: "“Let's hope he is better than Orso.”"*)
  - -> `[51]` (*Player: "“This is an important milestone for Sordish democracy.”"*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Gloria Tory: "“If you say so, Mr. President.”"*)

### Węzeł `[71]`
Mówca: **Gloria Tory**
> "“That isn't a high mark to clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Gloria Tory: "“If you say so, Mr. President.”"*)

### Węzeł `[73]`
Mówca: **Gloria Tory**
> "“If you say so, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[74]`
Mówca: **Gloria Tory**
> "“I think we'll gain enough conservative support to withstand the loss. Especially with me as Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[75]`
Mówca: **Gloria Tory**
> "“It wasn't unexpected. But our increased support among nationalists might make up for the loss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[76]`
Mówca: **Gloria Tory**
> "“Their places have been filled with people more aligned with the new manifesto.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player: "“As I expected. We don't need anyone who won't stay by ou..."*)
  - -> `[86]` (*Player: "“It was an unfortunate and necessary sacrifice.”"*)
  - -> `[72]` (*Player: "“So they decided to betray me and the party. They will se..."*)
  - -> `[152]` (*Player: "“What do you think about it?”"*)

### Węzeł `[77]`
Mówca: **Gloria Tory**
> "“If you say so, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Gloria Tory: "“If you say so, Mr. President.”"*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "“It was an unfortunate and a necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and necessary sacrifice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Gloria Tory: "“If you say so, Mr. President.”"*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Gloria Tory: "“If you say so, Mr. President.”"*)

### Węzeł `[81]`
Mówca: **Gloria Tory**
> "“To begin with, your changes to the party manifesto have angered quite a few members of the conservative wing. I'm not so sure about them myself, to be honest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Gloria Tory: "“A portion of the conservative MPs have decided to quit t..."*)

### Węzeł `[82]`
Mówca: **Gloria Tory**
> "“Their places have been filled with people more aligned with the new manifesto.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: "“As I expected. We don't need anyone who won't stay by ou..."*)
  - -> `[79]` (*Player: "“It was an unfortunate and a necessary sacrifice.”"*)
  - -> `[78]` (*Player: "“So they decided to betray me and the party. They will se..."*)
  - -> `[137]` (*Player: "“What do you think about it?”"*)

### Węzeł `[83]`
Mówca: **Gloria Tory**
> "“A portion of the conservative MPs have decided to quit the USP. 26, to be exact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Gloria Tory: "“Their places have been filled with people more aligned w..."*)

### Węzeł `[84]`
Mówca: **Gloria Tory**
> "“It's progress, for sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[85]`
Mówca: **Gloria Tory**
> "“The changes you ordered to the Supreme Court have now been implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Gloria Tory: "“Mr. Ovid Grecer has now begun his duty as a Justice.”"*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "“It was an unfortunate and necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and necessary sacrifice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Gloria Tory: "“If you say so, Mr. President.”"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_ExperiencedJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_ExperiencedJustice == true)"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_ExperiencedJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_ExperiencedJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Gloria Tory: "“Moving on...”"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_ExperiencedJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_ExperiencedJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_LoyalJustice == true"*)

### Węzeł `[90]`
Mówca: **Gloria Tory**
> "“A portion of the reformist MPs have decided to quit the party. 21 to be exact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Gloria Tory: "“Their places have been filled with people more aligned w..."*)

### Węzeł `[91]`
Mówca: **Gloria Tory**
> "“It's certainly a step forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Liberal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Liberal == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Party_Liberal == true)"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Liberal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Liberal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Gloria Tory: "“To begin with, your changes to the party manifesto have ..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Party_Liberal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Liberal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Socialist == true"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Socialist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Socialist == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Party_Socialist == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Socialist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Gloria Tory: "“To begin with, your changes to the party manifesto have ..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Party_Socialist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Ultranationalist == true"*)

### Węzeł `[98]`
Mówca: **Gloria Tory**
> "“That isn't a high mark to clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Ultranationalist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Ultranationalist == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Party_Ultranationalist == true)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Ultranationalist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Gloria Tory: "“To begin with, your changes to the party manifesto have ..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Party_Ultranationalist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[102]`
Mówca: **Gloria Tory**
> "“He doesn't seem to have any political motivations, one way or another. I am hopeful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Campaign_ExtraBudget == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Campaign_ExtraBudget == true"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Campaign_ExtraBudget == true)"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Campaign_ExtraBudget == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Campaign_ExtraBudget"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Gloria Tory: "“One more thing on this topic.”"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Campaign_ExtraBudget == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Campaign_ExtraBudget"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[106]`
Mówca: **Narrator**
> "She flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Gloria Tory: "“The changes you ordered to the Supreme Court have now be..."*)

### Węzeł `[107]`
Mówca: **Gloria Tory**
> "“One more thing on this topic.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Gloria Tory: "“The mayors are very happy with your decision to provide ..."*)

### Węzeł `[108]`
Mówca: **Gloria Tory**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "She flipped the page."*)

### Węzeł `[109]`
Mówca: **Gloria Tory**
> "“The mayors are very happy with your decision to provide them with extra funding to assist with the campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Gloria Tory: "“This will definitely boost our popularity.”"*)

### Węzeł `[110]`
Mówca: **Gloria Tory**
> "“I wish I could be as optimistic. This is still the Old Guard we're talking about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "She closed the folder and put away the documents."*)

### Węzeł `[111]`
Mówca: **Gloria Tory**
> "“This will definitely boost our popularity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player: "“I hope the money went into the right place instead of th..."*)
  - -> `[114]` (*Player: "“Excellent. We need all the help we can get.""*)
  - -> `[115]` (*Player: "“Good work.”"*)

### Węzeł `[112]`
Mówca: **Narrator**
> "She flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Gloria Tory: "“The changes you ordered to the Supreme Court have now be..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "“I hope the money went into the right place instead of their pockets.”"]** — Mówca: **Player**
> "“I hope the money went into the right place instead of their pockets.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Gloria Tory: "“I am sure of it.”"*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Excellent. We need all the help we can get.""]** — Mówca: **Player**
> "“Excellent. We need all the help we can get.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Gloria Tory: "“Agreed.”"*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Good work.”"]** — Mówca: **Player**
> "“Good work.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Gloria Tory: "“Thank you. I'm trying my best.”"*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Gloria Tory: "“It's certainly a step forward.""*)

### Węzeł `[117]`
**[WYBÓR GRACZA: "“Let's hope he will be better than Orso.”"]** — Mówca: **Player**
> "“Let's hope he will be better than Orso.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Gloria Tory: "“That isn't a high mark to clear.""*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "“Can he be trusted?”"]** — Mówca: **Player**
> "“Can he be trusted?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Gloria Tory: "“He doesn't seem to have any political motivations, one w..."*)

### Węzeł `[119]`
Mówca: **Gloria Tory**
> "“I am sure of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 3;"*)

### Węzeł `[120]`
Mówca: **Gloria Tory**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 3;"*)

### Węzeł `[121]`
**[WYBÓR GRACZA: "“Let's hope Heron is better than Orso.”"]** — Mówca: **Player**
> "“Let's hope Heron is better than Orso.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Gloria Tory: "“Not a high mark to clear. But we're still dealing with t..."*)

### Węzeł `[122]`
Mówca: **Gloria Tory**
> "“Thank you. I'm trying my best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 3;"*)

### Węzeł `[123]`
Mówca: **Gloria Tory**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "She flipped the page."*)

### Węzeł `[124]`
Mówca: **Gloria Tory**
> "“To begin with, your changes to the party manifesto have angered quite a few members of the reformist wing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Gloria Tory: "“A portion of the reformist MPs have decided to quit the ..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_LoyalJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_LoyalJustice == true"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_LoyalJustice == true)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_LoyalJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_LoyalJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Gloria Tory: "“Moving on...”"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_LoyalJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_LoyalJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_OldGuardReplaced == true"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_OldGuardReplaced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_OldGuardReplaced == true"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_OldGuardReplaced == true)"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_OldGuardReplaced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Gloria Tory: "“Moving on...”"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_OldGuardReplaced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_Shuffled == true"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_Shuffled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_Shuffled == true"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_Shuffled == true)"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_Shuffled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Gloria Tory: "“Moving on...”"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_Shuffled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "She closed the folder and put away the documents."*)

### Węzeł `[134]`
Mówca: **Gloria Tory**
> "“He is a seasoned veteran with a career in law spanning more than 30 years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: "“Can he be trusted?”"*)
  - -> `[117]` (*Player: "“Let's hope he will be better than Orso.”"*)
  - -> `[116]` (*Player: "“This is an important milestone for Sordish democracy.”"*)

### Węzeł `[135]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Gloria Tory: "“I wish I could be as optimistic. This is still the Old G..."*)

### Węzeł `[136]`
Mówca: **Gloria Tory**
> "“I'm surprised you would trust a man like Mr. Garaci.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "She closed the folder and put away the documents."*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Gloria Tory: "“These members were with us for a long time. I hope the g..."*)

### Węzeł `[138]`
Mówca: **Gloria Tory**
> "“These members were with us for a long time. I hope the gains in support among reformists can make up for the loss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[139]`
Mówca: **Gloria Tory**
> "“The new Chief Justice elected by the Court is mostly an unknown figure in politics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Gloria Tory: "“His name is Ovid Grecer.”"*)

### Węzeł `[140]`
Mówca: **Gloria Tory**
> "“If you say so, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[141]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Gloria Tory: "“If you say so, Mr. President.”"*)

### Węzeł `[142]`
**[WYBÓR GRACZA: "“It was an unfortunate and a necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and necessary sacrifice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Gloria Tory: "“If you say so, Mr. President.”"*)

### Węzeł `[143]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Gloria Tory: "“If you say so, Mr. President.”"*)

### Węzeł `[144]`
Mówca: **Gloria Tory**
> "“To begin with, your changes to the party manifesto have angered MPs from both wings. I'm not so sure about them myself, to be honest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Gloria Tory: "“We've lost 26 conservative MPs and 13 reformist ones.""*)

### Węzeł `[145]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Gloria Tory: "“It wasn't unexpected. Socialism has never been one of th..."*)

### Węzeł `[146]`
Mówca: **Gloria Tory**
> "“Their places have been filled with people more aligned with the new manifesto.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player: "“As I expected. We don't need anyone who won't stay by ou..."*)
  - -> `[142]` (*Player: "“It was an unfortunate and a necessary sacrifice.”"*)
  - -> `[141]` (*Player: "“So they decided to betray me and the party. They will se..."*)
  - -> `[145]` (*Player: "“What do you think about it?”"*)

### Węzeł `[147]`
Mówca: **Gloria Tory**
> "“It wasn't unexpected. Socialism has never been one of the USP's core values.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[148]`
Mówca: **Gloria Tory**
> "“We've lost 26 conservative MPs and 13 reformist ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Gloria Tory: "“Their places have been filled with people more aligned w..."*)

### Węzeł `[149]`
Mówca: **Gloria Tory**
> "“His name is Ovid Grecer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Gloria Tory: "“He is a seasoned veteran with a career in law spanning m..."*)

### Węzeł `[150]`
Mówca: **Gloria Tory**
> "“Not a high mark to clear. But we're still dealing with the Old Guard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "She closed the folder and put away the documents."*)

### Węzeł `[151]`
**[WYBÓR GRACZA: "“Excellent news. I am glad to see him elected.”"]** — Mówca: **Player**
> "“Excellent news. I am glad to see him elected.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true`
- **Kontekst wejściowy (poprzednik):** `[57]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Gloria Tory: "“I'm surprised you would trust a man like Mr. Garaci.”"*)

### Węzeł `[152]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Gloria Tory: "“It wasn't unexpected. But our increased support among na..."*)

### Węzeł `[153]`
Mówca: **Gloria Tory**
> "“Mr. Ovid Grecer has now begun his duty as a Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Gloria Tory: "“He is a seasoned veteran with a career in law spanning o..."*)

### Węzeł `[154]`
Mówca: **Gloria Tory**
> "“He is a seasoned veteran with a career in law spanning over 30 years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Gloria Tory: "“As a matter of fact, shortly after his appointment, the ..."*)

### Węzeł `[155]`
Mówca: **Gloria Tory**
> "“As a matter of fact, shortly after his appointment, the Court selected Mr. Grecer as the new Chief Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Gloria Tory: "“This change should increase the trust in the capabilitie..."*)

### Węzeł `[156]`
**[WYBÓR GRACZA: "“Can we trust him?”"]** — Mówca: **Player**
> "“Can we trust him?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Gloria Tory: "“I would. He's renowned for his impartiality.""*)

### Węzeł `[157]`
Mówca: **Gloria Tory**
> "“I would. He's renowned for his impartiality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[158]`
Mówca: **Narrator**
> "She closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Gloria Tory: "“That is all for the court updates.”"*)

### Węzeł `[159]`
Mówca: **Gloria Tory**
> "“That is all for the court updates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[160]`
Mówca: **Narrator**
> "She closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Gloria Tory: "“That is all for the court updates.”"*)

### Węzeł `[161]`
Mówca: **Gloria Tory**
> "“That is all for the court updates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[162]`
Mówca: **Narrator**
> "She closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Gloria Tory: "“That is all for the court updates.”"*)

### Węzeł `[163]`
Mówca: **Gloria Tory**
> "“That is all for the court updates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "She closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Gloria Tory: ""Next up on the docket...""*)

### Węzeł `[165]`
Mówca: **Gloria Tory**
> ""Next up on the docket...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Detained_FrensRicter == tru..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Gloria Tory: "“I have some updates from the Assembly.”"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[169]`
Mówca: **Gloria Tory**
> "“I have some updates from the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Gloria Tory: "“I'm sure you were aware that the PFJP has been strugglin..."*)

### Węzeł `[170]`
Mówca: **Gloria Tory**
> "“I'm sure you were aware that the PFJP has been struggling to cope with the... absence of Frens Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Gloria Tory: "“Without a leader, they've been scrambling to keep the pa..."*)

### Węzeł `[171]`
Mówca: **Gloria Tory**
> "“Without a leader, they've been scrambling to keep the party intact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Gloria Tory: "“Or at least, that was the case until yesterday's PFJP co..."*)

### Węzeł `[172]`
Mówca: **Gloria Tory**
> "“Or at least, that was the case until yesterday's PFJP congress.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Gloria Tory: "“Here, take a look.”"*)

### Węzeł `[173]`
Mówca: **Gloria Tory**
> "“Here, take a look.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "She handed me an official report from the PFJP."*)

### Węzeł `[174]`
Mówca: **Narrator**
> "She handed me an official report from the PFJP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Gloria Tory: "“They've elected a relatively untested member of their ra..."*)

### Węzeł `[175]`
Mówca: **Gloria Tory**
> "“They've elected a relatively untested member of their ranks as the new leader.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Gloria Tory: "“Her name is Manoly Suheil.”"*)

### Węzeł `[176]`
Mówca: **Gloria Tory**
> "“Her name is Manoly Suheil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[177]`
Mówca: **Gloria Tory**
> "“I don't know how she made it into the highest ranks of the PFJP, but one thing is for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Gloria Tory: "“She is popular both in the Assembly and among the people..."*)

### Węzeł `[178]`
Mówca: **Gloria Tory**
> "“She is popular both in the Assembly and among the people. She also happens to have quite a large female following.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Gloria Tory: "“We shouldn't underestimate her.”"*)

### Węzeł `[179]`
Mówca: **Gloria Tory**
> "“We shouldn't underestimate her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Player: "“We won't.”"*)
  - -> `[181]` (*Player: "“What can she do when Frens couldn't do anything?”"*)
  - -> `[182]` (*Player: "“What if she were to meet the same fate as Frens?""*)
  - -> `[183]` (*Player: "“Don't be alarmed. We have nothing to worry about.”"*)

### Węzeł `[180]`
**[WYBÓR GRACZA: "“We won't.”"]** — Mówca: **Player**
> "“We won't.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Gloria Tory), `[251]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Gloria Tory: "“I expected as much from you.”"*)

### Węzeł `[181]`
**[WYBÓR GRACZA: "“What can she do when Frens couldn't do anything?”"]** — Mówca: **Player**
> "“What can she do when Frens couldn't do anything?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Gloria Tory), `[251]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Gloria Tory: "“If she can tap into Frens' base, she will have as much p..."*)

### Węzeł `[182]`
**[WYBÓR GRACZA: "“What if she were to meet the same fate as Frens?""]** — Mówca: **Player**
> "“What if she were to meet the same fate as Frens?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Gloria Tory), `[251]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Gloria Tory: "“I'm going to pretend I didn't hear that.""*)

### Węzeł `[183]`
**[WYBÓR GRACZA: "“Don't be alarmed. We have nothing to worry about.”"]** — Mówca: **Player**
> "“Don't be alarmed. We have nothing to worry about.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Gloria Tory), `[251]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Gloria Tory: "“Better safe than sorry.”"*)

### Węzeł `[184]`
Mówca: **Gloria Tory**
> "“Better safe than sorry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[185]`
Mówca: **Gloria Tory**
> "“I'm going to pretend I didn't hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[186]`
Mówca: **Gloria Tory**
> "“If she can tap into Frens' base, she will have as much power as him. We will be watching her moves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[187]`
Mówca: **Gloria Tory**
> "“I expected as much from you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Detained_KesaroKibener == t..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Gloria Tory: "“I have received multiple reports that the NFP has electe..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[191]`
Mówca: **Gloria Tory**
> "“I have received multiple reports that the NFP has elected a new leader following Kesaro Kibener's... untimely leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Gloria Tory: "“It's Remus Holstron, also known as the 'Iron Wall'. Kibe..."*)

### Węzeł `[192]`
Mówca: **Gloria Tory**
> "“It's Remus Holstron, also known as the 'Iron Wall'. Kibener's former right-hand man. I believe you've met him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Player: ""I don't recall. What can you tell me about him?""*)
  - -> `[243]` (*Player: ""Oh, yes. I know all about him.""*)

### Węzeł `[193]`
Mówca: **Gloria Tory**
> "“As one of the most enthusiastic Young Sords members, he was recruited by Kesaro himself during the coup when he was still in the military.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Gloria Tory: "“Not the most charming fellow I've ever met.”"*)

### Węzeł `[194]`
Mówca: **Gloria Tory**
> "“Not the most charming fellow I've ever met.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Gloria Tory: "“Some say that he might be even more extreme than Kibener..."*)

### Węzeł `[195]`
Mówca: **Gloria Tory**
> "“Some say that he might be even more extreme than Kibener in his hardline anti-Bludish sentiments.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Gloria Tory: "“What's more, he is fervently worshipped among the Young ..."*)

### Węzeł `[196]`
**[WYBÓR GRACZA: ""I'd say it's time for the 'Iron Wall' to come down.”"]** — Mówca: **Player**
> ""I'd say it's time for the 'Iron Wall' to come down.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Gloria Tory), `[244]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Gloria Tory: "“Wordplay. Clever.""*)

### Węzeł `[197]`
**[WYBÓR GRACZA: "“He doesn't scare me. I have dealt with much worse.”"]** — Mówca: **Player**
> "“He doesn't scare me. I have dealt with much worse.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Gloria Tory), `[244]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Gloria Tory: "“It's better to be on the side of caution.”"*)

### Węzeł `[198]`
**[WYBÓR GRACZA: "“Make sure he never becomes a big problem then.”"]** — Mówca: **Player**
> "“Make sure he never becomes a big problem then.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Gloria Tory), `[244]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Gloria Tory: "“We will do our best.”"*)

### Węzeł `[199]`
**[WYBÓR GRACZA: "“He can never *ever* hope to reach Kesaro's level.”"]** — Mówca: **Player**
> "“He can never *ever* hope to reach Kesaro's level.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Gloria Tory), `[244]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Gloria Tory: "“As much as I don't like either of them, you are right.”"*)

### Węzeł `[200]`
Mówca: **Gloria Tory**
> "“What's more, he is fervently worshipped among the Young Sords.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Gloria Tory: "“I can say with certainty that he *will* be a problem.”"*)

### Węzeł `[201]`
Mówca: **Gloria Tory**
> "“I can say with certainty that he *will* be a problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player: ""I'd say it's time for the 'Iron Wall' to come down.”"*)
  - -> `[197]` (*Player: "“He doesn't scare me. I have dealt with much worse.”"*)
  - -> `[198]` (*Player: "“Make sure he never becomes a big problem then.”"*)
  - -> `[199]` (*Player: "“He can never *ever* hope to reach Kesaro's level.”"*)

### Węzeł `[202]`
Mówca: **Gloria Tory**
> "“As much as I don't like either of them, you are right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[203]`
Mówca: **Gloria Tory**
> "“We will do our best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[204]`
Mówca: **Gloria Tory**
> "“It's better to be on the side of caution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[205]`
Mówca: **Gloria Tory**
> "“Wordplay. Clever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true"*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player: "“Excellent news. I am glad to see him elected.”"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.PoliticalOverview2_TvAd = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.PoliticalOverview2_TvAd"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Campaign_ExtraBudget == true"*)

### Węzeł `[211]`
Mówca: **Gloria Tory**
> ""The indefinitely delayed case of Ishval Ersen against Governor Phelix Bron has finally reached to a conclusion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == false && BaseGame.Berg..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Gloria Tory: ""I must say... He already gave a landmark ruling as his f..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "She closed the folder and put away the documents."*)

### Węzeł `[215]`
Mówca: **Gloria Tory**
> ""He was found guilty of abusing his powers to enable discrimination against the citizens of Sordland and found guilty of breaking the constitutional laws of the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Gloria Tory: ""He was promptly stripped from his duties as governor of ..."*)

### Węzeł `[216]`
Mówca: **Gloria Tory**
> ""I must say... He already gave a landmark ruling as his first act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Gloria Tory: ""The indefinitely delayed case of Ishval Ersen against Go..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == tru..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Gloria Tory: ""He was found guilty of abusing his powers to enable disc..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Gloria Tory: ""He was found guilty of abusing his powers to enable disc..."*)

### Węzeł `[220]`
Mówca: **Gloria Tory**
> ""He was found guilty of abusing his powers to enable discrimination against the citizens of Sordland which directly goes against the new Constitution. He was therefore found guilty of breaking the constitutional laws of the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Gloria Tory: ""He was promptly stripped from his duties as governor of ..."*)

### Węzeł `[221]`
Mówca: **Gloria Tory**
> ""He was promptly stripped from his duties as governor of the Special Zone and was sent directly to Antel Rock Prison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Gloria Tory: ""As for his replacement, the Court argued that since it w..."*)

### Węzeł `[222]`
Mówca: **Gloria Tory**
> ""As for his replacement, the Court argued that since it was an extraordinary circumstance and the elections are already nearby, a transitionary council must take charge of the governance of the Special Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Gloria Tory: ""According to the decisions made in that council, Ishval ..."*)

### Węzeł `[223]`
Mówca: **Gloria Tory**
> ""According to the decisions made in that council, Ishval Ersen was already picked as the most suitable governor choice, arguably as a Bludish rights activist from Bergia who became extremely famous for bringing up the issues to the governmental level.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true && BaseGame...."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player: ""This is great news, Gloria!""*)
  - -> `[225]` (*Player: ""I'm already liking Chief Justice Grecer.""*)
  - -> `[228]` (*Player: ""This is a great development for Bludish rights in Sordla..."*)
  - -> `[227]` (*Player: ""Honestly, I don't even want to hear about Bergia anymore.""*)

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm already liking Chief Justice Grecer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Gloria Tory: ""In any case...""*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is great news, Gloria!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Gloria Tory: ""In any case...""*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, I don't even want to hear about Bergia anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Gloria Tory: ""In any case...""*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is a great development for Bludish rights in Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Gloria Tory: ""In any case...""*)

### Węzeł `[229]`
Mówca: **Gloria Tory**
> ""In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "She closed the folder and put away the documents."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Gloria Tory: ""I must say... He already gave a la..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Gloria Tory: ""I must say... He already gave a landmark ruling as his f..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == false && BaseGame.Berg..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "Jump to: [Gloria Tory: ""I must say... He already gave a ..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "She closed the folder and put away the documents."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron = false;
BaseGame.Bergia_Governor_Krull = false;
BaseGame.Bergia_Governor_Ersen = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Bergia_Governor_Bron"] = false;
Variable["BaseGame.Bergia_Governor_Krull"] = false;
Variable["BaseGame.Bergia_Governor_Ersen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty = true;
BaseGameSupport.News_Turn08_R_OvidGrecerFindsBronGuilty = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty"] = true;
Variable["BaseGameSupport.News_Turn08_R_OvidGrecerFindsBronGuilty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron = false; BaseGame.Bergia_Go..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true && BaseGame...."*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true && BaseGam..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBr..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBr..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Amended = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Amended"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty ..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty ..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_ReplacedByOvidGrecer = true;
BaseGameSupport.Codex_Characters_StateFigures_PhelixBron = false;
BaseGameSupport.Codex_Characters_Others_IshvalErsen = false;
BaseGameSupport.Codex_Characters_StateFigures_IshvalErsen_SpecialZone = true;
BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Ersen = true;
BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Bron = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_ReplacedByOvidGrecer"] = true;
Variable["BaseGameSupport.Codex_Characters_StateFigures_PhelixBron"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_IshvalErsen"] = false;
Variable["BaseGameSupport.Codex_Characters_StateFigures_IshvalErsen_SpecialZone"] = true;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Ersen"] = true;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SpecialZone_Bron"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't recall. What can you tell me about him?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Gloria Tory: "“As one of the most enthusiastic Young Sords members, he ..."*)

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh, yes. I know all about him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Gloria Tory: ""Then you know that he'll be a problem.""*)

### Węzeł `[244]`
Mówca: **Gloria Tory**
> ""Then you know that he'll be a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player: ""I'd say it's time for the 'Iron Wall' to come down.”"*)
  - -> `[197]` (*Player: "“He doesn't scare me. I have dealt with much worse.”"*)
  - -> `[198]` (*Player: "“Make sure he never becomes a big problem then.”"*)
  - -> `[199]` (*Player: "“He can never *ever* hope to reach Kesaro's level.”"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Gloria Tory: ""You've met her before, I think.""*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Gloria Tory: "“I don't know how she made it into the highest ranks of t..."*)

### Węzeł `[248]`
Mówca: **Gloria Tory**
> ""You've met her before, I think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player: ""Briefly. What can you tell me about her?""*)
  - -> `[249]` (*Player: ""Yes, say no more. I know all about her.""*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, say no more. I know all about her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[248]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Gloria Tory: "“Then you know we shouldn't underestimate her.”"*)

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Briefly. What can you tell me about her?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[248]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Gloria Tory: "“I don't know how she made it into the highest ranks of t..."*)

### Węzeł `[251]`
Mówca: **Gloria Tory**
> "“Then you know we shouldn't underestimate her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Player: "“We won't.”"*)
  - -> `[181]` (*Player: "“What can she do when Frens couldn't do anything?”"*)
  - -> `[182]` (*Player: "“What if she were to meet the same fate as Frens?""*)
  - -> `[183]` (*Player: "“Don't be alarmed. We have nothing to worry about.”"*)
