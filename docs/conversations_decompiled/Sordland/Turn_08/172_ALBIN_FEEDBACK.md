# Sordland/Turn08/ALBIN FEEDBACK

- **ID konwersacji:** `172`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/172_ALBIN_FEEDBACK.md`
- **Liczba węzłów dialogowych:** 259
- **Liczba wyborów gracza:** 54

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[61]** Albin Clavin

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
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
- `BaseGame.Turn08_Action_Court_GloriaJustice`
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
- Węzeł `[2]` -> **[171] Sordland/Turn08/A_PoliticalOverview2** (../Turn_08/171_A_PoliticalOverview2.md), Węzeł `[327]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[19]` | **"“That sounds great. I always wanted to be a television star.”"** | `[18]` **Albin Clavin**: "“This way, the people can feel c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Albin Clavin**: "“I'm not sure if you are joking,..." |
| `[20]` | **"“It's a good plan. Let's do it.”"** | `[18]` **Albin Clavin**: "“This way, the people can feel c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Albin Clavin**: "“Very well.”" |
| `[21]` | **"“I won't allow regular citizens to come in here. What's next? Hordes of tourists w..."** | `[18]` **Albin Clavin**: "“This way, the people can feel c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Albin Clavin**: "“Very well. Then that's a no.”" |
| `[27]` | **"“Not my favorite idea. But if it helps with the election, I have no choice.”"** | `[18]` **Albin Clavin**: "“This way, the people can feel c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Albin Clavin**: "“Very well.”" |
| `[34]` | **"“This better be good. For his own good.”"** | `[33]` **Albin Clavin**: "“He'll schedule a meeting soon t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Albin Clavin**: "“I am sure Mr. Holl will deliver..." |
| `[35]` | **"“Tell him to be quick. Our administration depends on it.”"** | `[33]` **Albin Clavin**: "“He'll schedule a meeting soon t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Albin Clavin**: "“I understand. I will relay this..." |
| `[36]` | **"“Symon can pull it off, I'm sure. He has never failed me before.”"** | `[33]` **Albin Clavin**: "“He'll schedule a meeting soon t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Albin Clavin**: "“Mr. Holl is a savvy man. I am s..." |
| `[37]` | **"“I will be expecting good ideas and even better outcomes.”"** | `[33]` **Albin Clavin**: "“He'll schedule a meeting soon t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Albin Clavin**: "“Of course. I will relay this to..." |
| `[42]` | **"“This is bad. He and Hawker are basically the same person.""** | `[52]` **Albin Clavin**: "“But more importantly... the cou..."<br>`[203]` **Albin Clavin**: "“But more importantly... the Cou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Albin Clavin**: "“I agree, Mr. President. However..." |
| `[44]` | **"“Excellent news! I'm glad our man made it.”"** | `[63]` **Albin Clavin**: "“However, this change should def..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Albin Clavin**: "“You're not the only one. Let's ..." |
| `[45]` | **"“Let's hope he is better than Orso.”"** | `[63]` **Albin Clavin**: "“However, this change should def..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Albin Clavin**: "“*Anyone* is better than Orso.”" |
| `[47]` | **"“This is still an important milestone for Sordish democracy.”"** | `[63]` **Albin Clavin**: "“However, this change should def..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Albin Clavin**: "“Maybe. Certainly a step in the ..." |
| `[59]` | **"“So they decided to betray me and the party. They will see their mistakes one day.”"** | `[57]` **Albin Clavin**: "“I think they are thinking about..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Albin Clavin**: "“If you say so, Mr. President.”" |
| `[60]` | **"“It was an unfortunate and a necessary sacrifice.”"** | `[57]` **Albin Clavin**: "“I think they are thinking about..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Albin Clavin**: "“If you say so, Mr. President.”" |
| `[61]` | **"“As I expected. We don't need anyone who won't stay by our side.”"** | `[57]` **Albin Clavin**: "“I think they are thinking about..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Albin Clavin**: "“If you say so, Mr. President.”" |
| `[62]` | **"“And you, Albin? Will you jump ship as well?""** | `[57]` **Albin Clavin**: "“I think they are thinking about..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Albin Clavin**: "“No, Mr. President. I still beli..." |
| `[64]` | **"“As I expected. We don't need anyone who won't stay by our side.”"** | `[69]` **Albin Clavin**: "“A good number of them might end..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Albin Clavin**: "“If you say so, Mr. President.”" |
| `[66]` | **"“So they decided to betray me and the party. They will see their mistakes one day.”"** | `[69]` **Albin Clavin**: "“A good number of them might end..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Albin Clavin**: "“If you say so, Mr. President.”" |
| `[71]` | **"“So they decided to betray me and the party. They will see their mistakes one day.”"** | `[75]` **Albin Clavin**: "“It could be they'll join the ra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Albin Clavin**: "“If you say so, Mr. President.”" |
| `[72]` | **"“It was an unfortunate and necessary sacrifice.”"** | `[75]` **Albin Clavin**: "“It could be they'll join the ra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Albin Clavin**: "“If you say so, Mr. President.”" |
| `[73]` | **"“As I expected. We don't need anyone who won't stay by our side.”"** | `[75]` **Albin Clavin**: "“It could be they'll join the ra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Albin Clavin**: "“If you say so, Mr. President.”" |
| `[78]` | **"“It was an unfortunate and a necessary sacrifice.”"** | `[69]` **Albin Clavin**: "“A good number of them might end..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Albin Clavin**: "“If you say so, Mr. President.”" |
| `[104]` | **"“I hope the money went into the right place instead of their pockets.”"** | `[103]` **Albin Clavin**: "“We are already seeing positive ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Albin Clavin**: "“I'm sure it did. Most of it, an..." |
| `[105]` | **"“Excellent. We need all the help we can get.""** | `[103]` **Albin Clavin**: "“We are already seeing positive ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Albin Clavin**: "“Agreed.”" |
| `[106]` | **"“Good work.”"** | `[103]` **Albin Clavin**: "“We are already seeing positive ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Albin Clavin**: "“Thank you. We are trying our be..." |
| `[107]` | **"“This is an important milestone for Sordish democracy.”"** | `[125]` **Albin Clavin**: "“He's a seasoned veteran with a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Albin Clavin**: "“Certainly one of the most impor..." |
| `[108]` | **"“Let's hope he will be better than Orso.”"** | `[125]` **Albin Clavin**: "“He's a seasoned veteran with a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Albin Clavin**: "“*Anyone* is better than Orso.”" |
| `[109]` | **"“Can he be trusted?”"** | `[125]` **Albin Clavin**: "“He's a seasoned veteran with a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Albin Clavin**: "“Everyone says he's one of the m..." |
| `[112]` | **"“Let's hope Heron is better than Orso.”"** | `[52]` **Albin Clavin**: "“But more importantly... the cou..."<br>`[203]` **Albin Clavin**: "“But more importantly... the Cou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Albin Clavin**: "“*Anyone* is better than Orso. T..." |
| `[126]` | **"“This is an important milestone for Sordish democracy.”"** | `[52]` **Albin Clavin**: "“But more importantly... the cou..."<br>`[203]` **Albin Clavin**: "“But more importantly... the Cou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Albin Clavin**: "“I wish I could be as optimistic..." |
| `[128]` | **"“What do you think about it?”"** | `[75]` **Albin Clavin**: "“It could be they'll join the ra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Albin Clavin**: "“I'd say we don't need them if t..." |
| `[132]` | **"“So they decided to betray me and the party. They will see their mistakes one day.”"** | `[137]` **Albin Clavin**: "“A good number of them might end..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Albin Clavin**: "“If you say so, Mr. President.”" |
| `[133]` | **"“It was an unfortunate and a necessary sacrifice.”"** | `[137]` **Albin Clavin**: "“A good number of them might end..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Albin Clavin**: "“If you say so, Mr. President.”" |
| `[134]` | **"“As I expected. We don't need anyone who won't stay by our side.”"** | `[137]` **Albin Clavin**: "“A good number of them might end..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Albin Clavin**: "“If you say so, Mr. President.”" |
| `[136]` | **"“What do you think about it?”"** | `[137]` **Albin Clavin**: "“A good number of them might end..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Albin Clavin**: "“Only that it was expected consi..." |
| `[142]` | **"“Excellent news. I am glad to see him elected.”"** | `[52]` **Albin Clavin**: "“But more importantly... the cou..."<br>`[203]` **Albin Clavin**: "“But more importantly... the Cou..." | `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true` | *Brak zmian stanu* | `[127]` **Albin Clavin**: "“I'm surprised you would trust a..." |
| `[149]` | **"“So, you don't trust him?”"** | `[63]` **Albin Clavin**: "“However, this change should def..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Albin Clavin**: "“I want to. Everyone says he's o..." |
| `[170]` | **"“We won't.”"** | `[169]` **Albin Clavin**: "“We shouldn't underestimate her.”"<br>`[258]` **Albin Clavin**: "“Then you know we shouldn't unde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Albin Clavin**: "“Just as I expected from you.”" |
| `[171]` | **"“What can she do when Frens couldn't do anything?”"** | `[169]` **Albin Clavin**: "“We shouldn't underestimate her.”"<br>`[258]` **Albin Clavin**: "“Then you know we shouldn't unde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Albin Clavin**: "“If she can tap into Ricter's ba..." |
| `[172]` | **"“It'd be a shame if the same thing happened to her as to Frens.”"** | `[169]` **Albin Clavin**: "“We shouldn't underestimate her.”"<br>`[258]` **Albin Clavin**: "“Then you know we shouldn't unde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Albin Clavin**: "“I'm just going to pretend I did..." |
| `[173]` | **"“Don't be alarmed. We have nothing to worry about.”"** | `[169]` **Albin Clavin**: "“We shouldn't underestimate her.”"<br>`[258]` **Albin Clavin**: "“Then you know we shouldn't unde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Albin Clavin**: "“You might be right. But better ..." |
| `[186]` | **"“If he is the *Iron Wall* then I will be the one that brings it down.”"** | `[192]` **Albin Clavin**: "“But I can say with certainty th..."<br>`[251]` **Albin Clavin**: "“Then you know that he *will* be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Albin Clavin**: "“Silly nicknames don't win polit..." |
| `[187]` | **"“He doesn't scare me. I have dealt with much worse.”"** | `[192]` **Albin Clavin**: "“But I can say with certainty th..."<br>`[251]` **Albin Clavin**: "“Then you know that he *will* be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Albin Clavin**: "“It's better to be on the side o..." |
| `[188]` | **"“Make sure he never becomes a big problem then.”"** | `[192]` **Albin Clavin**: "“But I can say with certainty th..."<br>`[251]` **Albin Clavin**: "“Then you know that he *will* be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Albin Clavin**: "“We will do our best.”" |
| `[189]` | **"“He can never *ever* hope to reach Kesaro's level.""** | `[192]` **Albin Clavin**: "“But I can say with certainty th..."<br>`[251]` **Albin Clavin**: "“Then you know that he *will* be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Albin Clavin**: "“As much as I don't like the man..." |
| `[214]` | **"“And you, Albin? Will you jump ship as well?""** | `[69]` **Albin Clavin**: "“A good number of them might end..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Albin Clavin**: "“No, Mr. President. I still beli..." |
| `[231]` | **""I'm already liking Chief Justice Grecer.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Albin Clavin**: ""This is surely great news."" |
| `[232]` | **""This is great news, Albin!""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Albin Clavin**: ""This is surely great news."" |
| `[233]` | **""Honestly, I don't even want to hear about Bergia anymore.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[236]` **Albin Clavin**: ""Well... Sure."" |
| `[234]` | **""This is a great development for Bludish rights in Sordland.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Albin Clavin**: ""This is surely great news."" |
| `[249]` | **""Yes, I already know all about him.""** | `[182]` **Albin Clavin**: "“Remus Holstron, also known as t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[251]` **Albin Clavin**: "“Then you know that he *will* be..." |
| `[250]` | **""What else can you tell me about him?""** | `[182]` **Albin Clavin**: "“Remus Holstron, also known as t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Albin Clavin**: "“He was recruited by Kesaro hims..."<br>`[183]` **Albin Clavin**: "“As one of the most brutally cut..." |
| `[256]` | **""Yes, say no more. I know all about her.""** | `[255]` **Albin Clavin**: ""You've met her before, I think."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Albin Clavin**: "“Then you know we shouldn't unde..." |
| `[257]` | **""Briefly. What can you tell me about her?""** | `[255]` **Albin Clavin**: ""You've met her before, I think."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Albin Clavin**: "“She was always a radical figure..." |

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
  - -> `[3]` (*Albin Clavin: "“This shouldn't take long. I just wanted to go over the c..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[3]`
Mówca: **Albin Clavin**
> "“This shouldn't take long. I just wanted to go over the current political climate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Focus_Campaign == true"*)

### Węzeł `[4]`
Mówca: **Albin Clavin**
> "“We've implemented the Supreme Court changes that you ordered. Replaced the lot of them with an all-new batch of justices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Albin Clavin: "“Saying that the now ex-members were furious would be an ..."*)

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
  - -> `[12]` (*Albin Clavin: "“As you know, I've been working on improving our public i..."*)

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
  - -> `[31]` (*Albin Clavin: "“Mr. Holl told me he's just about finished with his new p..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Results_Focus_Economy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Results_Focus_Economy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Conservative == true"*)

### Węzeł `[11]`
Mówca: **Albin Clavin**
> "“Saying that the now ex-members were furious would be an understatement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Albin Clavin: "“Me, I couldn't be more thrilled. It's high time the Cour..."*)

### Węzeł `[12]`
Mówca: **Albin Clavin**
> "“As you know, I've been working on improving our public image.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Albin Clavin: "“However, there is a decision that needs to be made.”"*)

### Węzeł `[13]`
Mówca: **Albin Clavin**
> "“However, there is a decision that needs to be made.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Albin Clavin: "“Our initial reports show that voters, especially younger..."*)

### Węzeł `[14]`
Mówca: **Albin Clavin**
> "“Our initial reports show that voters, especially younger ones, are extremely responsive to advertisement over television. Especially with the new techniques of today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Albin Clavin: "“I have consulted with a few advisors and we would like t..."*)

### Węzeł `[15]`
Mówca: **Albin Clavin**
> "“I have consulted with a few advisors and we would like to put out a brand-new television campaign. We've already spoken with Sordland's biggest advertising agency, and they believe indirect messages work better than direct ones.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Albin Clavin: "“For this, they will be given security clearance to come ..."*)

### Węzeł `[16]`
Mówca: **Albin Clavin**
> "“For this, they will be given security clearance to come in and take photos and videos in the Maroon Palace. Specifically, they want footage of the president working and posing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Albin Clavin: "“This way, the people can feel closer to their leader in ..."*)

### Węzeł `[17]`
Mówca: **Albin Clavin**
> "“Saying that the now ex-members are furious would be an understatement. Me, I couldn't be happier to be rid of those dinosaurs. They've held Sordland in their iron grip for too long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Albin Clavin: "“So today, the new Court held an internal vote to select ..."*)

### Węzeł `[18]`
Mówca: **Albin Clavin**
> "“This way, the people can feel closer to their leader in their homes. What do you think?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: "“That sounds great. I always wanted to be a television st..."*)
  - -> `[20]` (*Player: "“It's a good plan. Let's do it.”"*)
  - -> `[21]` (*Player: "“I won't allow regular citizens to come in here. What's n..."*)
  - -> `[27]` (*Player: "“Not my favorite idea. But if it helps with the election,..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "“That sounds great. I always wanted to be a television star.”"]** — Mówca: **Player**
> "“That sounds great. I always wanted to be a television star.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Albin Clavin: "“I'm not sure if you are joking, but I will note that dow..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“It's a good plan. Let's do it.”"]** — Mówca: **Player**
> "“It's a good plan. Let's do it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Albin Clavin: "“Very well.”"*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“I won't allow regular citizens to come in here. What's next? Hordes of tourists walking around the palace?”"]** — Mówca: **Player**
> "“I won't allow regular citizens to come in here. What's next? Hordes of tourists walking around the palace?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Albin Clavin: "“Very well. Then that's a no.”"*)

### Węzeł `[22]`
Mówca: **Albin Clavin**
> "“We've implemented the Supreme Court changes that you ordered. The entirety of the Old Guard is gone. Purged.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Albin Clavin: "“Saying that the now ex-members are furious would be an u..."*)

### Węzeł `[23]`
Mówca: **Albin Clavin**
> "“I'm not sure if you are joking, but I will note that down as a yes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Albin Clavin: "“I will notify the film crew.”"*)

### Węzeł `[24]`
Mówca: **Albin Clavin**
> "“Very well. Then that's a no.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Campaign_ExtraBudget == true"*)

### Węzeł `[25]`
Mówca: **Albin Clavin**
> "“Me, I couldn't be more thrilled. It's high time the Court had some fresh faces. Truly neutral ones, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Albin Clavin: "“So today, the new Court held an internal vote to select ..."*)

### Węzeł `[26]`
Mówca: **Albin Clavin**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Albin Clavin: "“I will notify the film crew.”"*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Not my favorite idea. But if it helps with the election, I have no choice.”"]** — Mówca: **Player**
> "“Not my favorite idea. But if it helps with the election, I have no choice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Albin Clavin: "“Very well.”"*)

### Węzeł `[28]`
Mówca: **Albin Clavin**
> "“I will notify the film crew.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 3"*)

### Węzeł `[29]`
Mówca: **Albin Clavin**
> "“I agree, Mr. President. However, I doubt Mr. Garaci is as capable as his predecessor. This could still prove to be positive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Albin Clavin: "“In any case, we will have to wait and see.”"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 3`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.PoliticalOverview2_TvAd = true"*)

### Węzeł `[31]`
Mówca: **Albin Clavin**
> "“Mr. Holl told me he's just about finished with his new plan for the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Albin Clavin: "“He said he wanted to solidify the plan before it is pres..."*)

### Węzeł `[32]`
Mówca: **Albin Clavin**
> "“He said he wanted to solidify the plan before it is presented to you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Albin Clavin: "“He'll schedule a meeting soon to go over our options.”"*)

### Węzeł `[33]`
Mówca: **Albin Clavin**
> "“He'll schedule a meeting soon to go over our options.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: "“Tell him to be quick. Our administration depends on it.”"*)
  - -> `[36]` (*Player: "“Symon can pull it off, I'm sure. He has never failed me ..."*)
  - -> `[37]` (*Player: "“I will be expecting good ideas and even better outcomes.”"*)
  - -> `[34]` (*Player: "“This better be good. For his own good.”"*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“This better be good. For his own good.”"]** — Mówca: **Player**
> "“This better be good. For his own good.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Albin Clavin: "“I am sure Mr. Holl will deliver. But I'll remind him how..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Tell him to be quick. Our administration depends on it.”"]** — Mówca: **Player**
> "“Tell him to be quick. Our administration depends on it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Albin Clavin: "“I understand. I will relay this to him as soon as possib..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Symon can pull it off, I'm sure. He has never failed me before.”"]** — Mówca: **Player**
> "“Symon can pull it off, I'm sure. He has never failed me before.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Albin Clavin: "“Mr. Holl is a savvy man. I am sure he will deliver as we..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“I will be expecting good ideas and even better outcomes.”"]** — Mówca: **Player**
> "“I will be expecting good ideas and even better outcomes.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Albin Clavin: "“Of course. I will relay this to him as soon as possible.”"*)

### Węzeł `[38]`
Mówca: **Albin Clavin**
> "“There is something else you need to know...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Albin Clavin: "“We've implemented the Supreme Court changes that you ord..."*)

### Węzeł `[39]`
Mówca: **Albin Clavin**
> "“There is something else you need to know...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Albin Clavin: "“We've implemented the Supreme Court changes that you ord..."*)

### Węzeł `[40]`
Mówca: **Albin Clavin**
> "“Of course. I will relay this to him as soon as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[41]`
Mówca: **Albin Clavin**
> "“I understand. I will relay this to him as soon as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "“This is bad. He and Hawker are basically the same person.""]** — Mówca: **Player**
> "“This is bad. He and Hawker are basically the same person.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Albin Clavin), `[203]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Albin Clavin: "“I agree, Mr. President. However, I doubt Mr. Garaci is a..."*)

### Węzeł `[43]`
Mówca: **Albin Clavin**
> "“Mr. Holl is a savvy man. I am sure he will deliver as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Excellent news! I'm glad our man made it.”"]** — Mówca: **Player**
> "“Excellent news! I'm glad our man made it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Albin Clavin: "“You're not the only one. Let's hope he really is as neut..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“Let's hope he is better than Orso.”"]** — Mówca: **Player**
> "“Let's hope he is better than Orso.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Albin Clavin: "“*Anyone* is better than Orso.”"*)

### Węzeł `[46]`
Mówca: **Albin Clavin**
> "“I am sure Mr. Holl will deliver. But I'll remind him how important this is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "“This is still an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is still an important milestone for Sordish democracy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Albin Clavin: "“Maybe. Certainly a step in the right direction.”"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Conservative == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Conservative == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Party_Conservative == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Conservative == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Conservative"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Albin Clavin: "“To begin with, a lot of reformist party members -- inclu..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Party_Conservative == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Conservative"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Liberal == true"*)

### Węzeł `[51]`
Mówca: **Albin Clavin**
> "“He is known for his loyalty, and that will hopefully bring us considerable power and sway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Albin Clavin: "“But more importantly... the court has selected Heron Gar..."*)

### Węzeł `[52]`
Mówca: **Albin Clavin**
> "“But more importantly... the court has selected Heron Garaci as the new Chief Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true"*)
  - -> `[112]` (*Player: "“Let's hope Heron is better than Orso.”"*)
  - -> `[126]` (*Player: "“This is an important milestone for Sordish democracy.”"*)
  - -> `[42]` (*Player: "“This is bad. He and Hawker are basically the same person.""*)

### Węzeł `[53]`
Mówca: **Albin Clavin**
> "“To begin with, a lot of reformist party members -- including me, to be honest -- have issues with your changes to the USP manifesto.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Albin Clavin: "“I tried to convince them otherwise, but a group of MPs h..."*)

### Węzeł `[54]`
Mówca: **Albin Clavin**
> "“Your new appointment to the Supreme Court, Mr. Didier Meye, began his duty as a Justice today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Albin Clavin: "“He is known for his loyalty, and that will hopefully bri..."*)

### Węzeł `[55]`
Mówca: **Albin Clavin**
> "“I tried to convince them otherwise, but a group of MPs have decided to quit the party. 13, to be exact. They handed in their resignation letters today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Albin Clavin: "“I think they are thinking about joining the PFJP.”"*)

### Węzeł `[56]`
Mówca: **Albin Clavin**
> "“You're not the only one. Let's hope he really is as neutral and just as everyone says.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[57]`
Mówca: **Albin Clavin**
> "“I think they are thinking about joining the PFJP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: "“As I expected. We don't need anyone who won't stay by ou..."*)
  - -> `[60]` (*Player: "“It was an unfortunate and a necessary sacrifice.”"*)
  - -> `[59]` (*Player: "“So they decided to betray me and the party. They will se..."*)
  - -> `[62]` (*Player: "“And you, Albin? Will you jump ship as well?""*)

### Węzeł `[58]`
Mówca: **Albin Clavin**
> "“If you say so, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Albin Clavin: "“If you say so, Mr. President.”"*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“It was an unfortunate and a necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and a necessary sacrifice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Albin Clavin: "“If you say so, Mr. President.”"*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Albin Clavin: "“If you say so, Mr. President.”"*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“And you, Albin? Will you jump ship as well?""]** — Mówca: **Player**
> "“And you, Albin? Will you jump ship as well?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Albin Clavin: "“No, Mr. President. I still believe I've got a greater sh..."*)

### Węzeł `[63]`
Mówca: **Albin Clavin**
> "“However, this change should definitely increase public trust in the capabilities of the Supreme Court.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player: "“So, you don't trust him?”"*)
  - -> `[44]` (*Player: "“Excellent news! I'm glad our man made it.”"*)
  - -> `[45]` (*Player: "“Let's hope he is better than Orso.”"*)
  - -> `[47]` (*Player: "“This is still an important milestone for Sordish democra..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Albin Clavin: "“If you say so, Mr. President.”"*)

### Węzeł `[65]`
Mówca: **Albin Clavin**
> "“*Anyone* is better than Orso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Albin Clavin: "“If you say so, Mr. President.”"*)

### Węzeł `[67]`
Mówca: **Albin Clavin**
> "“If you say so, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[68]`
Mówca: **Albin Clavin**
> "“No, Mr. President. I still believe I've got a greater shot at accomplishing change as your vice president than as a PFJP member.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[69]`
Mówca: **Albin Clavin**
> "“A good number of them might end up joining the PFJP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: "“As I expected. We don't need anyone who won't stay by ou..."*)
  - -> `[78]` (*Player: "“It was an unfortunate and a necessary sacrifice.”"*)
  - -> `[66]` (*Player: "“So they decided to betray me and the party. They will se..."*)
  - -> `[214]` (*Player: "“And you, Albin? Will you jump ship as well?""*)

### Węzeł `[70]`
Mówca: **Albin Clavin**
> "“If you say so, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Albin Clavin: "“If you say so, Mr. President.”"*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "“It was an unfortunate and necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and necessary sacrifice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Albin Clavin: "“If you say so, Mr. President.”"*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Albin Clavin: "“If you say so, Mr. President.”"*)

### Węzeł `[74]`
Mówca: **Albin Clavin**
> "“First off, your changes to the party manifesto -- which I fully applaud, by the way -- have been causing quite the ruckus among the conservative wing of the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Albin Clavin: "“A group of MPs have decided to quit the USP. 26, to be e..."*)

### Węzeł `[75]`
Mówca: **Albin Clavin**
> "“It could be they'll join the ranks of the NFP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: "“As I expected. We don't need anyone who won't stay by ou..."*)
  - -> `[72]` (*Player: "“It was an unfortunate and necessary sacrifice.”"*)
  - -> `[71]` (*Player: "“So they decided to betray me and the party. They will se..."*)
  - -> `[128]` (*Player: "“What do you think about it?”"*)

### Węzeł `[76]`
Mówca: **Albin Clavin**
> "“A group of MPs have decided to quit the USP. 26, to be exact. They gave their resignation letters today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Albin Clavin: "“It could be they'll join the ranks of the NFP.”"*)

### Węzeł `[77]`
Mówca: **Albin Clavin**
> "“Maybe. Certainly a step in the right direction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "“It was an unfortunate and a necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and a necessary sacrifice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Albin Clavin: "“If you say so, Mr. President.”"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_ExperiencedJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_ExperiencedJustice == true)"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_ExperiencedJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_ExperiencedJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Albin Clavin: "“There is something else you need to know...”"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_ExperiencedJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_ExperiencedJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_LoyalJustice == true"*)

### Węzeł `[82]`
Mówca: **Albin Clavin**
> "“This is a huge problem. Never before have so many people resigned together. This may have negative consequences on the upcoming elections.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Albin Clavin: "“A good number of them might end up joining the NFP.”"*)

### Węzeł `[83]`
Mówca: **Albin Clavin**
> "“A group of MPs have decided to quit the party. 26 to be exact. They gave their resignation letters today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Albin Clavin: "“A good number of them might end up joining the PFJP.”"*)

### Węzeł `[84]`
Mówca: **Albin Clavin**
> "“Certainly one of the most important ones in the past decade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Liberal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Liberal == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Party_Liberal == true)"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Liberal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Liberal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Albin Clavin: "“First off, your changes to the party manifesto -- which ..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Party_Liberal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Liberal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Socialist == true"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Socialist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Socialist == true"*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Party_Socialist == true)"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Socialist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Albin Clavin: "“To begin with, a lot of party members have issues with y..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Party_Socialist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Ultranationalist == true"*)

### Węzeł `[91]`
Mówca: **Albin Clavin**
> "“*Anyone* is better than Orso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Ultranationalist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Ultranationalist == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Party_Ultranationalist == true)"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Ultranationalist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Albin Clavin: "“To begin with, a lot of reformist party members -- inclu..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Party_Ultranationalist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[95]`
Mówca: **Albin Clavin**
> "“Everyone says he's one of the most impartial judges out there. I am hopeful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Campaign_ExtraBudget == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Campaign_ExtraBudget == true"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Campaign_ExtraBudget == true)"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Campaign_ExtraBudget == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Campaign_ExtraBudget"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Albin Clavin: "“One more thing on this topic.”"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Campaign_ExtraBudget == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Campaign_ExtraBudget"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[99]`
Mówca: **Albin Clavin**
> "“One more thing on this topic.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Albin Clavin: "“The mayors are very happy with your decision to provide ..."*)

### Węzeł `[100]`
Mówca: **Albin Clavin**
> "“There is something else you need to know...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Albin Clavin: "“Your new appointment to the Supreme Court, Mr. Didier Me..."*)

### Węzeł `[101]`
Mówca: **Albin Clavin**
> "“The mayors are very happy with your decision to provide them with extra funding to assist in the campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Albin Clavin: "“We are already seeing positive responses from the cities..."*)

### Węzeł `[102]`
Mówca: **Albin Clavin**
> "“I wish I could be as optimistic. He and Orso are cut from the same cloth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Albin Clavin: "“In any case, we will have to wait and see.”"*)

### Węzeł `[103]`
Mówca: **Albin Clavin**
> "“We are already seeing positive responses from the cities in Greater Holsord and Gelsland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player: "“I hope the money went into the right place instead of th..."*)
  - -> `[105]` (*Player: "“Excellent. We need all the help we can get.""*)
  - -> `[106]` (*Player: "“Good work.”"*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "“I hope the money went into the right place instead of their pockets.”"]** — Mówca: **Player**
> "“I hope the money went into the right place instead of their pockets.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Albin Clavin: "“I'm sure it did. Most of it, anyway.""*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "“Excellent. We need all the help we can get.""]** — Mówca: **Player**
> "“Excellent. We need all the help we can get.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Albin Clavin: "“Agreed.”"*)

### Węzeł `[106]`
**[WYBÓR GRACZA: "“Good work.”"]** — Mówca: **Player**
> "“Good work.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Albin Clavin: "“Thank you. We are trying our best.”"*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Albin Clavin: "“Certainly one of the most important ones in the past dec..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "“Let's hope he will be better than Orso.”"]** — Mówca: **Player**
> "“Let's hope he will be better than Orso.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Albin Clavin: "“*Anyone* is better than Orso.”"*)

### Węzeł `[109]`
**[WYBÓR GRACZA: "“Can he be trusted?”"]** — Mówca: **Player**
> "“Can he be trusted?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Albin Clavin: "“Everyone says he's one of the most impartial judges out ..."*)

### Węzeł `[110]`
Mówca: **Albin Clavin**
> "“I'm sure it did. Most of it, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 3;"*)

### Węzeł `[111]`
Mówca: **Albin Clavin**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 3;"*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "“Let's hope Heron is better than Orso.”"]** — Mówca: **Player**
> "“Let's hope Heron is better than Orso.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Albin Clavin), `[203]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Albin Clavin: "“*Anyone* is better than Orso. That said, now we have ano..."*)

### Węzeł `[113]`
Mówca: **Albin Clavin**
> "“Thank you. We are trying our best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 3;"*)

### Węzeł `[114]`
Mówca: **Albin Clavin**
> "“There is something else you need to know...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Albin Clavin: "“Your new appointment to the Supreme Court, Mr. Grecer, h..."*)

### Węzeł `[115]`
Mówca: **Albin Clavin**
> "“To begin with, a lot of reformist party members -- including me, to be honest -- have issues with your changes to the USP manifesto.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Albin Clavin: "“A group of MPs have decided to quit the party. 26 to be ..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_LoyalJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_LoyalJustice == true"*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_LoyalJustice == true)"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_LoyalJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_LoyalJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Albin Clavin: "“There is something else you need to know...”"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_LoyalJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_LoyalJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_OldGuardReplaced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_OldGuardReplaced == true"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_OldGuardReplaced == true)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_OldGuardReplaced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Albin Clavin: "“There is something else you need to know...”"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_OldGuardReplaced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_Shuffled == true"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_Shuffled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_Shuffled == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_Shuffled == true)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_Shuffled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Albin Clavin: "“There is something else you need to know...”"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_Shuffled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[125]`
Mówca: **Albin Clavin**
> "“He's a seasoned veteran with a career in law spanning over 30 years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: "“Can he be trusted?”"*)
  - -> `[108]` (*Player: "“Let's hope he will be better than Orso.”"*)
  - -> `[107]` (*Player: "“This is an important milestone for Sordish democracy.”"*)

### Węzeł `[126]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Albin Clavin), `[203]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Albin Clavin: "“I wish I could be as optimistic. He and Orso are cut fro..."*)

### Węzeł `[127]`
Mówca: **Albin Clavin**
> "“I'm surprised you would trust a man like Mr. Garaci.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Albin Clavin: "“In any case, we will have to wait and see.”"*)

### Węzeł `[128]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Albin Clavin: "“I'd say we don't need them if they can't accept the chan..."*)

### Węzeł `[129]`
Mówca: **Albin Clavin**
> "“I'd say we don't need them if they can't accept the change. We still hold the majority.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[130]`
Mówca: **Albin Clavin**
> "“So today, the new Court held an internal vote to select their new Chief Justice. He's mostly an unknown figure in politics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Albin Clavin: "“His name is Ovid Grecer.”"*)

### Węzeł `[131]`
Mówca: **Albin Clavin**
> "“If you say so, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Albin Clavin: "“If you say so, Mr. President.”"*)

### Węzeł `[133]`
**[WYBÓR GRACZA: "“It was an unfortunate and a necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and a necessary sacrifice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Albin Clavin: "“If you say so, Mr. President.”"*)

### Węzeł `[134]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Albin Clavin: "“If you say so, Mr. President.”"*)

### Węzeł `[135]`
Mówca: **Albin Clavin**
> "“To begin with, a lot of party members have issues with your changes to the USP manifesto. I'm not so sure about them myself, to be honest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Albin Clavin: "“I did my best to convince them otherwise, but a group of..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Albin Clavin: "“Only that it was expected considering the direction you'..."*)

### Węzeł `[137]`
Mówca: **Albin Clavin**
> "“A good number of them might end up joining the NFP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player: "“As I expected. We don't need anyone who won't stay by ou..."*)
  - -> `[133]` (*Player: "“It was an unfortunate and a necessary sacrifice.”"*)
  - -> `[132]` (*Player: "“So they decided to betray me and the party. They will se..."*)
  - -> `[136]` (*Player: "“What do you think about it?”"*)

### Węzeł `[138]`
Mówca: **Albin Clavin**
> "“Only that it was expected considering the direction you've pointed the party in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[139]`
Mówca: **Albin Clavin**
> "“I did my best to convince them otherwise, but a group of MPs have decided to quit the party. 39 to be exact. They handed in their resignation letters today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Albin Clavin: "“This is a huge problem. Never before have so many people..."*)

### Węzeł `[140]`
Mówca: **Albin Clavin**
> "“His name is Ovid Grecer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Albin Clavin: "“He's a seasoned veteran with a career in law spanning ov..."*)

### Węzeł `[141]`
Mówca: **Albin Clavin**
> "“*Anyone* is better than Orso. That said, now we have another member of the Old Guard on our hands.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Albin Clavin: "“In any case, we will have to wait and see.”"*)

### Węzeł `[142]`
**[WYBÓR GRACZA: "“Excellent news. I am glad to see him elected.”"]** — Mówca: **Player**
> "“Excellent news. I am glad to see him elected.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true`
- **Kontekst wejściowy (poprzednik):** `[52]` (Albin Clavin), `[203]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Albin Clavin: "“I'm surprised you would trust a man like Mr. Garaci.”"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_GloriaJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_GloriaJustice == true)"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_GloriaJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Albin Clavin: "“There is something else you need to know...”"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_GloriaJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_OldGuardReplaced == true"*)

### Węzeł `[146]`
Mówca: **Albin Clavin**
> "“Honestly, this came as quite a shock to me. I wouldn't have thought a new Justice would be elected as the chief.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Albin Clavin: "“I know he is a seasoned veteran with a career in law spa..."*)

### Węzeł `[147]`
Mówca: **Albin Clavin**
> "“I know he is a seasoned veteran with a career in law spanning over 30 years, but...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Albin Clavin: "“I still can't picture how the Old Guard voted for him. I..."*)

### Węzeł `[148]`
Mówca: **Albin Clavin**
> "“Your new appointment to the Supreme Court, Mr. Grecer, has been elected Chief Justice following the internal vote today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Albin Clavin: "“Honestly, this came as quite a shock to me. I wouldn't h..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA: "“So, you don't trust him?”"]** — Mówca: **Player**
> "“So, you don't trust him?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Albin Clavin: "“I want to. Everyone says he's one of the most incorrupti..."*)

### Węzeł `[150]`
Mówca: **Albin Clavin**
> "“I want to. Everyone says he's one of the most incorruptible judges out there. But I do not know this man in person. Nor I can ignore the fact that the Supreme Court was so quick to elect him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[151]`
Mówca: **Albin Clavin**
> "“Your appointment to the Supreme Court, Mrs. Tory, has begun her duty as a Justice today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Albin Clavin: "“I think we both know what she brings to the table. And I..."*)

### Węzeł `[152]`
Mówca: **Albin Clavin**
> "“There is something else you need to know...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Albin Clavin: "“Your appointment to the Supreme Court, Mrs. Tory, has be..."*)

### Węzeł `[153]`
Mówca: **Albin Clavin**
> "“I think we both know what she brings to the table. And I have to say that it was clever of you to remove her from the Assembly. She was a thorn in our side as the Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Albin Clavin: "“But more importantly... the Court has selected Heron Gar..."*)

### Węzeł `[154]`
Mówca: **Albin Clavin**
> "“In any case, we will have to wait and see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[155]`
Mówca: **Albin Clavin**
> "“In any case, we'll have to wait and see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Detained_FrensRicter == tru..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Albin Clavin: "“There's also been a development in the opposition you sh..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[159]`
Mówca: **Albin Clavin**
> "“There's also been a development in the opposition you should know about.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Albin Clavin: "“As you know, Frens Ricter's... *absence* in the Assembly..."*)

### Węzeł `[160]`
Mówca: **Albin Clavin**
> "“As you know, Frens Ricter's... *absence* in the Assembly left the PFJP in turmoil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Albin Clavin: "“They've been scrambling to keep the party intact without..."*)

### Węzeł `[161]`
Mówca: **Albin Clavin**
> "“They've been scrambling to keep the party intact without its leader.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Albin Clavin: "“Or at least, that was the case until yesterday's PFJP co..."*)

### Węzeł `[162]`
Mówca: **Albin Clavin**
> "“Or at least, that was the case until yesterday's PFJP congress.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Albin Clavin: "“Here, take a look.”"*)

### Węzeł `[163]`
Mówca: **Albin Clavin**
> "“Here, take a look.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "He handed me an official report from the PFJP."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "He handed me an official report from the PFJP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Albin Clavin: "“An unprecedented candidate from their ranks has been ele..."*)

### Węzeł `[165]`
Mówca: **Albin Clavin**
> "“An unprecedented candidate from their ranks has been elected the new PFJP leader. Manoly Suheil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[166]`
Mówca: **Albin Clavin**
> "“She was always a radical figure in their party. She and Ricter butted heads on numerous occasions, as I recall.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Albin Clavin: "“Now that he's gone, she has been let loose. I still don'..."*)

### Węzeł `[167]`
Mówca: **Albin Clavin**
> "“Now that he's gone, she has been let loose. I still don't know how she made it to that position, but they must have had a reason to elect someone like her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Albin Clavin: "“We know she is quite popular both in the Assembly and am..."*)

### Węzeł `[168]`
Mówca: **Albin Clavin**
> "“We know she is quite popular both in the Assembly and among middle-class women. She definitely has the potential to expand the PFJP's influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Albin Clavin: "“We shouldn't underestimate her.”"*)

### Węzeł `[169]`
Mówca: **Albin Clavin**
> "“We shouldn't underestimate her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player: "“We won't.”"*)
  - -> `[171]` (*Player: "“What can she do when Frens couldn't do anything?”"*)
  - -> `[172]` (*Player: "“It'd be a shame if the same thing happened to her as to ..."*)
  - -> `[173]` (*Player: "“Don't be alarmed. We have nothing to worry about.”"*)

### Węzeł `[170]`
**[WYBÓR GRACZA: "“We won't.”"]** — Mówca: **Player**
> "“We won't.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Albin Clavin), `[258]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Albin Clavin: "“Just as I expected from you.”"*)

### Węzeł `[171]`
**[WYBÓR GRACZA: "“What can she do when Frens couldn't do anything?”"]** — Mówca: **Player**
> "“What can she do when Frens couldn't do anything?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Albin Clavin), `[258]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Albin Clavin: "“If she can tap into Ricter's base, she will have as much..."*)

### Węzeł `[172]`
**[WYBÓR GRACZA: "“It'd be a shame if the same thing happened to her as to Frens.”"]** — Mówca: **Player**
> "“It'd be a shame if the same thing happened to her as to Frens.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Albin Clavin), `[258]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Albin Clavin: "“I'm just going to pretend I didn't hear that.""*)

### Węzeł `[173]`
**[WYBÓR GRACZA: "“Don't be alarmed. We have nothing to worry about.”"]** — Mówca: **Player**
> "“Don't be alarmed. We have nothing to worry about.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Albin Clavin), `[258]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Albin Clavin: "“You might be right. But better be safe than sorry.”"*)

### Węzeł `[174]`
Mówca: **Albin Clavin**
> "“You might be right. But better be safe than sorry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[175]`
Mówca: **Albin Clavin**
> "“I'm just going to pretend I didn't hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[176]`
Mówca: **Albin Clavin**
> "“If she can tap into Ricter's base, she will have as much power as him or more. We will be watching her moves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[177]`
Mówca: **Albin Clavin**
> "“Just as I expected from you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Detained_KesaroKibener == t..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Albin Clavin: "“Another thing. I have received multiple reports that the..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[181]`
Mówca: **Albin Clavin**
> "“Another thing. I have received multiple reports that the NFP has chosen a replacement to lead in Kesaro Kibener's stead. It seems to be his former right-hand man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Albin Clavin: "“Remus Holstron, also known as the 'Iron Wall'. I believe..."*)

### Węzeł `[182]`
Mówca: **Albin Clavin**
> "“Remus Holstron, also known as the 'Iron Wall'. I believe you two have met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player: ""What else can you tell me about him?""*)
  - -> `[249]` (*Player: ""Yes, I already know all about him.""*)

### Węzeł `[183]`
Mówca: **Albin Clavin**
> "“As one of the most brutally cutthroat Young Sords members, he was recruited by Kesaro himself during the coup when he was still in the military.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Albin Clavin: "“Not the most charming fellow I've ever met...”"*)

### Węzeł `[184]`
Mówca: **Albin Clavin**
> "“Not the most charming fellow I've ever met...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Albin Clavin: "“He is a ticking time bomb. Some nationalists think he is..."*)

### Węzeł `[185]`
Mówca: **Albin Clavin**
> "“He is a ticking time bomb. Some nationalists think he is *too extreme* compared to Mr. Kibener, especially for his deeply troubling anti-minority rhetoric.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Albin Clavin: "“What's more, he is basically worshipped among the Young ..."*)

### Węzeł `[186]`
**[WYBÓR GRACZA: "“If he is the *Iron Wall* then I will be the one that brings it down.”"]** — Mówca: **Player**
> "“If he is the *Iron Wall* then I will be the one that brings him down.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Albin Clavin), `[251]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Albin Clavin: "“Silly nicknames don't win politics after all.”"*)

### Węzeł `[187]`
**[WYBÓR GRACZA: "“He doesn't scare me. I have dealt with much worse.”"]** — Mówca: **Player**
> "“He doesn't scare me. I have dealt with much worse.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Albin Clavin), `[251]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Albin Clavin: "“It's better to be on the side of caution.”"*)

### Węzeł `[188]`
**[WYBÓR GRACZA: "“Make sure he never becomes a big problem then.”"]** — Mówca: **Player**
> "“Make sure he never becomes a big problem then.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Albin Clavin), `[251]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Albin Clavin: "“We will do our best.”"*)

### Węzeł `[189]`
**[WYBÓR GRACZA: "“He can never *ever* hope to reach Kesaro's level.""]** — Mówca: **Player**
> "“He can never *ever* hope to reach Kesaro's level.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Albin Clavin), `[251]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Albin Clavin: "“As much as I don't like the man, you might be right. How..."*)

### Węzeł `[190]`
Mówca: **Albin Clavin**
> "“What's more, he is basically worshipped among the Young Sords.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Albin Clavin: "“He comes with an already strong base and foundation. He ..."*)

### Węzeł `[191]`
Mówca: **Albin Clavin**
> "“He comes with an already strong base and foundation. He will either expand the NFP's influence, or destroy what Kesaro had achieved.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Albin Clavin: "“But I can say with certainty that he *will* be a problem.”"*)

### Węzeł `[192]`
Mówca: **Albin Clavin**
> "“But I can say with certainty that he *will* be a problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player: "“If he is the *Iron Wall* then I will be the one that bri..."*)
  - -> `[187]` (*Player: "“He doesn't scare me. I have dealt with much worse.”"*)
  - -> `[188]` (*Player: "“Make sure he never becomes a big problem then.”"*)
  - -> `[189]` (*Player: "“He can never *ever* hope to reach Kesaro's level.""*)

### Węzeł `[193]`
Mówca: **Albin Clavin**
> "“As much as I don't like the man, you might be right. However, let's not forget that Kesaro was labelled as *moderate* by NFP supporters...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[194]`
Mówca: **Albin Clavin**
> "“We will do our best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[195]`
Mówca: **Albin Clavin**
> "“It's better to be on the side of caution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[196]`
Mówca: **Albin Clavin**
> "“Silly nicknames don't win politics after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player: "“Excellent news. I am glad to see him elected.”"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true"*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player: "“Excellent news. I am glad to see him elected.”"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[203]`
Mówca: **Albin Clavin**
> "“But more importantly... the Court has selected Heron Garaci as the new Chief Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: "“Let's hope Heron is better than Orso.”"*)
  - -> `[126]` (*Player: "“This is an important milestone for Sordish democracy.”"*)
  - -> `[42]` (*Player: "“This is bad. He and Hawker are basically the same person.""*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true"*)

### Węzeł `[204]`
Mówca: **Albin Clavin**
> "“I still can't picture how the Old Guard voted for him. I know you like this guy, but I wouldn't trust the situation completely if I were you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Albin Clavin: "“However, this change should definitely increase public t..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Albin Clavin: "“He was recruited by Kesaro himself during the coup when ..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Albin Clavin: "“As one of the most brutally cutthroat Young Sords member..."*)

### Węzeł `[208]`
Mówca: **Albin Clavin**
> "“He was recruited by Kesaro himself during the coup when he was still in the military. There were already a few investigations opened on him for his suspected ties to the banned Young Sords, but they were suspended due to lack of evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Albin Clavin: "“Not the most charming fellow I've ever met...”"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Detained_FrensRicter == tru..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Albin Clavin: ""Speaking of which, I've got some very interesting news a..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[213]`
Mówca: **Albin Clavin**
> ""Speaking of which, I've got some very interesting news about the PFJP. But I'll get to that later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[214]`
**[WYBÓR GRACZA: "“And you, Albin? Will you jump ship as well?""]** — Mówca: **Player**
> "“And you, Albin? Will you jump ship as well?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Albin Clavin: "“No, Mr. President. I still believe I've got a greater sh..."*)

### Węzeł `[215]`
Mówca: **Albin Clavin**
> "“No, Mr. President. I still believe I've got a greater shot at accomplishing change as your vice president than as a PFJP member.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.PoliticalOverview2_TvAd = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.PoliticalOverview2_TvAd"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Campaign_ExtraBudget == true"*)

### Węzeł `[217]`
Mówca: **Albin Clavin**
> ""The indefinitely delayed case of Ishval Ersen against Governor Phelix Bron has finally reached to a conclusion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == false && BaseGame.Berg..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Albin Clavin: ""I must say... He already gave a landmark ruling as his f..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Albin Clavin: "“In any case, we'll have to wait and see.”"*)

### Węzeł `[221]`
Mówca: **Albin Clavin**
> ""He was found guilty of abusing his powers to enable discrimination against the citizens of Sordland and found guilty of breaking the constitutional laws of the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Albin Clavin: ""He was promptly stripped from his duties as governor of ..."*)

### Węzeł `[222]`
Mówca: **Albin Clavin**
> ""I must say... He already gave a landmark ruling as his first act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Albin Clavin: ""The indefinitely delayed case of Ishval Ersen against Go..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == tru..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Albin Clavin: ""He was found guilty of abusing his powers to enable disc..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Albin Clavin: ""He was found guilty of abusing his powers to enable disc..."*)

### Węzeł `[226]`
Mówca: **Albin Clavin**
> ""He was found guilty of abusing his powers to enable discrimination against the citizens of Sordland which directly goes against the new Constitution. He was therefore found guilty of breaking the constitutional laws of the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Albin Clavin: ""He was promptly stripped from his duties as governor of ..."*)

### Węzeł `[227]`
Mówca: **Albin Clavin**
> ""He was promptly stripped from his duties as governor of the Special Zone and was sent directly to Antel Rock Prison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Albin Clavin: ""As for his replacement, the Court argued that since it w..."*)

### Węzeł `[228]`
Mówca: **Albin Clavin**
> ""As for his replacement, the Court argued that since it was an extraordinary circumstance and the elections are already nearby, a transitionary council must take charge of the governance of the Special Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Albin Clavin: ""According to the decisions made in that council, Ishval ..."*)

### Węzeł `[229]`
Mówca: **Albin Clavin**
> ""According to the decisions made in that council, Ishval Ersen was already picked as the most suitable governor choice, arguably as a Bludish rights activist from Bergia who became extremely famous for bringing up the issues to the governmental level.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true && BaseGame...."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Player: ""This is great news, Albin!""*)
  - -> `[231]` (*Player: ""I'm already liking Chief Justice Grecer.""*)
  - -> `[234]` (*Player: ""This is a great development for Bludish rights in Sordla..."*)
  - -> `[233]` (*Player: ""Honestly, I don't even want to hear about Bergia anymore.""*)

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm already liking Chief Justice Grecer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Albin Clavin: ""This is surely great news.""*)

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is great news, Albin!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Albin Clavin: ""This is surely great news.""*)

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, I don't even want to hear about Bergia anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Albin Clavin: ""Well... Sure.""*)

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is a great development for Bludish rights in Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Albin Clavin: ""This is surely great news.""*)

### Węzeł `[235]`
Mówca: **Albin Clavin**
> ""This is surely great news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Albin Clavin: "“In any case, we'll have to wait and see.”"*)

### Węzeł `[236]`
Mówca: **Albin Clavin**
> ""Well... Sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Albin Clavin: "“In any case, we'll have to wait and see.”"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == false && BaseGame.Berg..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "Jump to: [Albin Clavin: ""I must say... He already gave a..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Albin Clavin: "“In any case, we'll have to wait and see.”"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Albin Clavin: ""I must say... He already gave a la..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Albin Clavin: ""I must say... He already gave a landmark ruling as his f..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron = false;
BaseGame.Bergia_Governor_Krull = false;
BaseGame.Bergia_Governor_Ersen = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Bergia_Governor_Bron"] = false;
Variable["BaseGame.Bergia_Governor_Krull"] = false;
Variable["BaseGame.Bergia_Governor_Ersen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty = true;
BaseGameSupport.News_Turn08_R_OvidGrecerFindsBronGuilty = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty"] = true;
Variable["BaseGameSupport.News_Turn08_R_OvidGrecerFindsBronGuilty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron = false; BaseGame.Bergia_Go..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true && BaseGame...."*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true && BaseGam..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBr..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBr..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Amended = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Amended"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty ..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty ..."*)

### Węzeł `[248]`
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
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, I already know all about him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Albin Clavin: "“Then you know that he *will* be a problem.""*)

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What else can you tell me about him?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[251]`
Mówca: **Albin Clavin**
> "“Then you know that he *will* be a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player: "“If he is the *Iron Wall* then I will be the one that bri..."*)
  - -> `[187]` (*Player: "“He doesn't scare me. I have dealt with much worse.”"*)
  - -> `[188]` (*Player: "“Make sure he never becomes a big problem then.”"*)
  - -> `[189]` (*Player: "“He can never *ever* hope to reach Kesaro's level.""*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Albin Clavin: ""You've met her before, I think.""*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Albin Clavin: "“She was always a radical figure in their party. She and ..."*)

### Węzeł `[255]`
Mówca: **Albin Clavin**
> ""You've met her before, I think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player: ""Briefly. What can you tell me about her?""*)
  - -> `[256]` (*Player: ""Yes, say no more. I know all about her.""*)

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, say no more. I know all about her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Albin Clavin: "“Then you know we shouldn't underestimate her.”"*)

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Briefly. What can you tell me about her?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Albin Clavin)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Albin Clavin: "“She was always a radical figure in their party. She and ..."*)

### Węzeł `[258]`
Mówca: **Albin Clavin**
> "“Then you know we shouldn't underestimate her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player: "“We won't.”"*)
  - -> `[171]` (*Player: "“What can she do when Frens couldn't do anything?”"*)
  - -> `[172]` (*Player: "“It'd be a shame if the same thing happened to her as to ..."*)
  - -> `[173]` (*Player: "“Don't be alarmed. We have nothing to worry about.”"*)
