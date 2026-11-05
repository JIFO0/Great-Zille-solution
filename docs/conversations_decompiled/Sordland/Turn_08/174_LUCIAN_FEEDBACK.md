# Sordland/Turn08/LUCIAN FEEDBACK

- **ID konwersacji:** `174`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/174_LUCIAN_FEEDBACK.md`
- **Liczba węzłów dialogowych:** 269
- **Liczba wyborów gracza:** 54

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Reform_Heron_PromisedChiefJustice`
- `BaseGame.Turn07_Investigate_Opposition`
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
- Węzeł `[2]` -> **[171] Sordland/Turn08/A_PoliticalOverview2** (../Turn_08/171_A_PoliticalOverview2.md), Węzeł `[811]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[20]` | **"“That sounds great. I always wanted to be a television star.”"** | `[19]` **Lucian Galade**: "“This way the people can feel cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Lucian Galade**: "“I'll assume you are joking and ..." |
| `[21]` | **"“It's a good plan. Let's do it.”"** | `[19]` **Lucian Galade**: "“This way the people can feel cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Lucian Galade**: "“Thank you, sir. I assure you it..." |
| `[22]` | **"“I won't allow regular citizens to come in here. What's next? Tourists roaming the..."** | `[19]` **Lucian Galade**: "“This way the people can feel cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Lucian Galade**: "“Very well. Then that's a no.”" |
| `[28]` | **"“It's not my favorite idea. But if it helps with the election, I have no choice.""** | `[19]` **Lucian Galade**: "“This way the people can feel cl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Lucian Galade**: "“Thank you, sir. I assure you it..." |
| `[36]` | **"“This better be good. For his own good.”"** | `[35]` **Lucian Galade**: "“He will schedule a meeting soon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Lucian Galade**: "“I am sure Mr. Holl will deliver..." |
| `[37]` | **"“Tell him to be quick. Our administration depends on it.”"** | `[35]` **Lucian Galade**: "“He will schedule a meeting soon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Lucian Galade**: "“I understand. I will relay this..." |
| `[38]` | **"“Symon can pull it off, I'm sure. He has never failed us before.”"** | `[35]` **Lucian Galade**: "“He will schedule a meeting soon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Lucian Galade**: "“Mr. Holl is exceptionally skill..." |
| `[39]` | **"“I will be expecting good ideas and even better outcomes.”"** | `[35]` **Lucian Galade**: "“He will schedule a meeting soon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Lucian Galade**: "“Of course. I will relay this to..." |
| `[45]` | **"“This is bad. He and Orso are basically the same person.""** | `[56]` **Lucian Galade**: "“More importantly, though, the c..."<br>`[219]` **Lucian Galade**: "“More importantly, though, the c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Lucian Galade**: "“I agree, Mr. President. However..." |
| `[47]` | **"“Excellent news! Our man made it.”"** | `[68]` **Lucian Galade**: "“With him at the helm, trust in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Lucian Galade**: "“I assure you, you are not the o..." |
| `[48]` | **"“Let's hope he is better than Orso.”"** | `[68]` **Lucian Galade**: "“With him at the helm, trust in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Lucian Galade**: "“That wouldn't be difficult, sir."" |
| `[50]` | **"“This is an important milestone for Sordish democracy.”"** | `[68]` **Lucian Galade**: "“With him at the helm, trust in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Lucian Galade**: "“Certainly a large step forward."" |
| `[64]` | **"“So they decided to betray me and the party. They will see their mistakes one day.”"** | `[62]` **Lucian Galade**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Lucian Galade**: ""Indeed, Mr. President.”" |
| `[65]` | **"“It was an unfortunate and a necessary sacrifice.”"** | `[62]` **Lucian Galade**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Lucian Galade**: ""Indeed, Mr. President.”" |
| `[66]` | **"“As I expected. We don't need anyone who won't stay by our side.”"** | `[62]` **Lucian Galade**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Lucian Galade**: ""Indeed, Mr. President.”" |
| `[67]` | **"“What do you think about it?”"** | `[62]` **Lucian Galade**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Lucian Galade**: "“The manifesto was never going t..." |
| `[69]` | **"“As I expected. We don't need anyone who won't stay by our side.”"** | `[75]` **Lucian Galade**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Lucian Galade**: "“Indeed, Mr. President.”" |
| `[71]` | **"“So they decided to betray me and the party. They will see their mistakes one day.”"** | `[75]` **Lucian Galade**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Lucian Galade**: "“Indeed, Mr. President.”" |
| `[77]` | **"“So they decided to betray me and the party. They will see their mistakes one day.”"** | `[81]` **Lucian Galade**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Lucian Galade**: ""Indeed, Mr. President.”" |
| `[78]` | **"“It was an unfortunate and a necessary sacrifice.”"** | `[81]` **Lucian Galade**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Lucian Galade**: ""Indeed, Mr. President.”" |
| `[79]` | **"“As I expected. We don't need anyone who won't stay by our side.”"** | `[81]` **Lucian Galade**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Lucian Galade**: ""Indeed, Mr. President.”" |
| `[85]` | **"“It was an unfortunate and a necessary sacrifice.”"** | `[75]` **Lucian Galade**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Lucian Galade**: "“Indeed, Mr. President.”" |
| `[112]` | **"“I hope the money went into the right place instead of their pockets.”"** | `[110]` **Lucian Galade**: "“This will surely boost our popu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Lucian Galade**: "“In either scenario, the mayors ..." |
| `[113]` | **"“Excellent. We need all the help we can get.""** | `[110]` **Lucian Galade**: "“This will surely boost our popu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Lucian Galade**: "“Agreed.”" |
| `[114]` | **"“Good work.”"** | `[110]` **Lucian Galade**: "“This will surely boost our popu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Lucian Galade**: "“Thank you. I do try my best."" |
| `[115]` | **"“This is an important milestone for Sordish democracy.”"** | `[133]` **Lucian Galade**: "“He is a seasoned veteran with a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Lucian Galade**: "“Certainly a large step forward."" |
| `[116]` | **"“Let's hope he will be better than Orso.”"** | `[133]` **Lucian Galade**: "“He is a seasoned veteran with a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Lucian Galade**: ""That wouldn't be difficult, sir."" |
| `[117]` | **"“Can he be trusted?”"** | `[133]` **Lucian Galade**: "“He is a seasoned veteran with a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Lucian Galade**: "“He appears to have a refreshing..." |
| `[120]` | **"“Let's hope Heron is better than Orso.”"** | `[56]` **Lucian Galade**: "“More importantly, though, the c..."<br>`[219]` **Lucian Galade**: "“More importantly, though, the c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Lucian Galade**: "“That wouldn't be difficult. But..." |
| `[134]` | **"“This is an important milestone for Sordish democracy.”"** | `[56]` **Lucian Galade**: "“More importantly, though, the c..."<br>`[219]` **Lucian Galade**: "“More importantly, though, the c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Lucian Galade**: "“I wish I could be as optimistic..." |
| `[136]` | **"“What do you think about it?”"** | `[81]` **Lucian Galade**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Lucian Galade**: "“The manifesto was never going t..." |
| `[140]` | **"“So they decided to betray me and the party. They will see their mistakes one day.”"** | `[145]` **Lucian Galade**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Lucian Galade**: "“Indeed, Mr. President.”" |
| `[141]` | **"“It was an unfortunate and a necessary sacrifice.”"** | `[145]` **Lucian Galade**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Lucian Galade**: "“Indeed, Mr. President.”" |
| `[142]` | **"“As I expected. We don't need anyone who won't stay by our side.”"** | `[145]` **Lucian Galade**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Lucian Galade**: "“Indeed, Mr. President.”" |
| `[144]` | **"“What do you think about it?”"** | `[145]` **Lucian Galade**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Lucian Galade**: "“The manifesto was never going t..." |
| `[150]` | **"“Excellent news. I am glad to see him elected.”"** | `[56]` **Lucian Galade**: "“More importantly, though, the c..."<br>`[219]` **Lucian Galade**: "“More importantly, though, the c..." | `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true` | *Brak zmian stanu* | `[135]` **Lucian Galade**: "“I'm surprised you would trust a..." |
| `[151]` | **"“What do you think about it?”"** | `[75]` **Lucian Galade**: "“Their places have been filled w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Lucian Galade**: "“The manifesto was never going t..." |
| `[158]` | **"“Can we trust him?”"** | `[68]` **Lucian Galade**: "“With him at the helm, trust in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Lucian Galade**: "“Certainly. He's renowned for hi..." |
| `[186]` | **"“We won't.”"** | `[185]` **Lucian Galade**: "“We shouldn't underestimate her.”"<br>`[268]` **Lucian Galade**: "“Then you know we shouldn't unde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Lucian Galade**: "“As I expected from you, sir.”" |
| `[187]` | **"“What can she do when Frens couldn't do anything?”"** | `[185]` **Lucian Galade**: "“We shouldn't underestimate her.”"<br>`[268]` **Lucian Galade**: "“Then you know we shouldn't unde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Lucian Galade**: "“If she can tap into Frens's bas..." |
| `[188]` | **"“Hypothetically, what if she were to meet the same fate as Frens?”"** | `[185]` **Lucian Galade**: "“We shouldn't underestimate her.”"<br>`[268]` **Lucian Galade**: "“Then you know we shouldn't unde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Lucian Galade**: "“That may yet be possible, depen..."<br>`[224]` **Lucian Galade**: "“No, I'm afraid it would look to..." |
| `[189]` | **"“Don't be alarmed. We have nothing to worry about.”"** | `[185]` **Lucian Galade**: "“We shouldn't underestimate her.”"<br>`[268]` **Lucian Galade**: "“Then you know we shouldn't unde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Lucian Galade**: "“Better safe than sorry.”" |
| `[199]` | **""What else can you tell me about him?""** | `[198]` **Lucian Galade**: "“You've met him. Remus Holstron,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Lucian Galade**: "“As a brutally efficient Young S..." |
| `[203]` | **"“If he is the 'Iron Wall', then I will be the one that brings it down.”"** | `[208]` **Lucian Galade**: "“I can say with certainty that h..."<br>`[261]` **Lucian Galade**: "“Then you know that as head of t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Lucian Galade**: "“It's a silly nickname, I agree.”" |
| `[204]` | **"“He doesn't scare me. I have dealt with much worse.”"** | `[208]` **Lucian Galade**: "“I can say with certainty that h..."<br>`[261]` **Lucian Galade**: "“Then you know that as head of t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[211]` **Lucian Galade**: "“It's better to be on the side o..." |
| `[205]` | **"“Make sure he never becomes a big problem, then.”"** | `[208]` **Lucian Galade**: "“I can say with certainty that h..."<br>`[261]` **Lucian Galade**: "“Then you know that as head of t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Lucian Galade**: "“We will do our best.”" |
| `[206]` | **"“He can never *ever* hope to reach Kesaro's level.”"** | `[208]` **Lucian Galade**: "“I can say with certainty that h..."<br>`[261]` **Lucian Galade**: "“Then you know that as head of t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Lucian Galade**: "“I never cared for either man. B..." |
| `[241]` | **""I'm already liking Chief Justice Grecer.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Lucian Galade**: ""He seems to be a good choice."" |
| `[242]` | **""This is great news, Lucian!""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[245]` **Lucian Galade**: ""Of course, sir."" |
| `[243]` | **""This is a great development for Bludish rights in Sordland.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[245]` **Lucian Galade**: ""Of course, sir."" |
| `[244]` | **""Honestly, I don't even want to hear about Bergia anymore.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[245]` **Lucian Galade**: ""Of course, sir."" |
| `[260]` | **""Oh, yes. I know all about him.""** | `[198]` **Lucian Galade**: "“You've met him. Remus Holstron,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[261]` **Lucian Galade**: "“Then you know that as head of t..." |
| `[266]` | **""Yes, say no more. I know all about her.""** | `[265]` **Lucian Galade**: ""We have met her before."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Lucian Galade**: "“Then you know we shouldn't unde..." |
| `[267]` | **""Briefly. What can you tell me about her?""** | `[265]` **Lucian Galade**: ""We have met her before."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Lucian Galade**: "“I don't know how she made it th..." |

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
  - -> `[3]` (*Lucian Galade: "“I wanted to provide you with some quick updates on the c..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[811]`

### Węzeł `[3]`
Mówca: **Lucian Galade**
> "“I wanted to provide you with some quick updates on the current political situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "He pulled out a few documents from a briefcase and laid t..."*)

### Węzeł `[4]`
Mówca: **Lucian Galade**
> "“The changes you ordered to the Supreme Court have now been implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Lucian Galade: "“The members you replaced were not happy, to put it very ..."*)

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
  - -> `[12]` (*Lucian Galade: "“As you know, I've been working on improving our public i..."*)

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
  - -> `[33]` (*Lucian Galade: "“Mr. Holl has reported to me that he has almost finished ..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Results_Focus_Economy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Results_Focus_Economy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Conservative == true"*)

### Węzeł `[11]`
Mówca: **Lucian Galade**
> "“The members you replaced were not happy, to put it very mildly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lucian Galade: "“The Court has been entirely reshuffled. This is the begi..."*)

### Węzeł `[12]`
Mówca: **Lucian Galade**
> "“As you know, I've been working on improving our public image.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Lucian Galade: "“However, there is a decision that needs to be made.”"*)

### Węzeł `[13]`
Mówca: **Lucian Galade**
> "“However, there is a decision that needs to be made.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lucian Galade: "“Our initial reports are showing that especially among th..."*)

### Węzeł `[14]`
Mówca: **Lucian Galade**
> "“Our initial reports are showing that especially among the youth, advertisement over television is becoming a very effective method.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucian Galade: "“I have consulted with a few advisors and we would like t..."*)

### Węzeł `[15]`
Mówca: **Lucian Galade**
> "“The entirety of the Old Guard has been purged from the Court. This is a historic occasion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Lucian Galade: "“The Court's new chief justice is mostly an unknown figur..."*)

### Węzeł `[16]`
Mówca: **Lucian Galade**
> "“I have consulted with a few advisors and we would like to put out a television campaign. Sordland's largest advertising agency is already on board to produce the spots.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucian Galade: "“For this, they will be given security clearance to come ..."*)

### Węzeł `[17]`
Mówca: **Lucian Galade**
> "“For this, they will be given security clearance to come in and take photos and videos in the Maroon Palace. Specifically they want footage of the president working and posing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lucian Galade: "“This way the people can feel closer to their leader in t..."*)

### Węzeł `[18]`
Mówca: **Lucian Galade**
> "“The members you replaced were not happy, to put it very mildly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: "“The entirety of the Old Guard has been purged from the C..."*)

### Węzeł `[19]`
Mówca: **Lucian Galade**
> "“This way the people can feel closer to their leader in their homes. What do you think?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: "“That sounds great. I always wanted to be a television st..."*)
  - -> `[21]` (*Player: "“It's a good plan. Let's do it.”"*)
  - -> `[22]` (*Player: "“I won't allow regular citizens to come in here. What's n..."*)
  - -> `[28]` (*Player: "“It's not my favorite idea. But if it helps with the elec..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“That sounds great. I always wanted to be a television star.”"]** — Mówca: **Player**
> "“That sounds great. I always wanted to be a television star.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucian Galade: "“I'll assume you are joking and note that down as a yes.”"*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“It's a good plan. Let's do it.”"]** — Mówca: **Player**
> "“It's a good plan. Let's do it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Lucian Galade: "“Thank you, sir. I assure you it will be of immense help.""*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“I won't allow regular citizens to come in here. What's next? Tourists roaming the palace halls?”"]** — Mówca: **Player**
> "“I won't allow regular citizens to come in here. What's next? Tourists roaming the palace halls?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lucian Galade: "“Very well. Then that's a no.”"*)

### Węzeł `[23]`
Mówca: **Lucian Galade**
> "“The changes you ordered to the Supreme Court have now been implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lucian Galade: "“The members you replaced were not happy, to put it very ..."*)

### Węzeł `[24]`
Mówca: **Lucian Galade**
> "“I'll assume you are joking and note that down as a yes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucian Galade: "“I will notify the filming crew.”"*)

### Węzeł `[25]`
Mówca: **Lucian Galade**
> "“Very well. Then that's a no.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Campaign_ExtraBudget == true"*)

### Węzeł `[26]`
Mówca: **Lucian Galade**
> "“The Court has been entirely reshuffled. This is the beginning of a new era and the end of the Old Guard's tyranny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Lucian Galade: "“The Court's new chief justice is mostly an unknown figur..."*)

### Węzeł `[27]`
Mówca: **Lucian Galade**
> "“Thank you, sir. I assure you it will be of immense help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucian Galade: "“I will notify the filming crew.”"*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“It's not my favorite idea. But if it helps with the election, I have no choice.""]** — Mówca: **Player**
> "“It's not my favorite idea. But if it helps with the election, I have no choice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Lucian Galade: "“Thank you, sir. I assure you it will be of immense help.""*)

### Węzeł `[29]`
Mówca: **Lucian Galade**
> "“I will notify the filming crew.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 3"*)

### Węzeł `[30]`
Mówca: **Lucian Galade**
> "“I agree, Mr. President. However, I doubt Mr. Garaci is as capable as Mr. Hawker. This could still prove to be positive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "He closed the folder and put away the documents."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 3`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.PoliticalOverview2_TvAd = true"*)

### Węzeł `[32]`
Mówca: **Narrator**
> "He flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Lucian Galade: "“The changes you ordered to the Supreme Court have now be..."*)

### Węzeł `[33]`
Mówca: **Lucian Galade**
> "“Mr. Holl has reported to me that he has almost finished drafting his new plan for the economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lucian Galade: "“He said he wanted to solidify the plan before it is pres..."*)

### Węzeł `[34]`
Mówca: **Lucian Galade**
> "“He said he wanted to solidify the plan before it is presented to you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Lucian Galade: "“He will schedule a meeting soon to go over our options.”"*)

### Węzeł `[35]`
Mówca: **Lucian Galade**
> "“He will schedule a meeting soon to go over our options.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: "“Tell him to be quick. Our administration depends on it.”"*)
  - -> `[38]` (*Player: "“Symon can pull it off, I'm sure. He has never failed us ..."*)
  - -> `[39]` (*Player: "“I will be expecting good ideas and even better outcomes.”"*)
  - -> `[36]` (*Player: "“This better be good. For his own good.”"*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“This better be good. For his own good.”"]** — Mówca: **Player**
> "“This better be good. For his own good.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: "“I am sure Mr. Holl will deliver. I will reiterate the im..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“Tell him to be quick. Our administration depends on it.”"]** — Mówca: **Player**
> "“Tell him to be quick. Our administration depends on it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lucian Galade: "“I understand. I will relay this to him as soon as possib..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Symon can pull it off, I'm sure. He has never failed us before.”"]** — Mówca: **Player**
> "“Symon can pull it off, I'm sure. He has never failed us before.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lucian Galade: "“Mr. Holl is exceptionally skilled. I am sure he will del..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“I will be expecting good ideas and even better outcomes.”"]** — Mówca: **Player**
> "“I will be expecting good ideas and even better outcomes.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Lucian Galade: "“Of course. I will relay this to him as soon as possible.”"*)

### Węzeł `[40]`
Mówca: **Lucian Galade**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "He flipped the page."*)

### Węzeł `[41]`
Mówca: **Lucian Galade**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "He flipped the page."*)

### Węzeł `[42]`
Mówca: **Lucian Galade**
> "“Of course. I will relay this to him as soon as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[43]`
Mówca: **Narrator**
> "He flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Lucian Galade: "“The changes you ordered to the Supreme Court have now be..."*)

### Węzeł `[44]`
Mówca: **Lucian Galade**
> "“I understand. I will relay this to him as soon as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“This is bad. He and Orso are basically the same person.""]** — Mówca: **Player**
> "“This is bad. He and Orso are basically the same person.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Lucian Galade), `[219]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lucian Galade: "“I agree, Mr. President. However, I doubt Mr. Garaci is a..."*)

### Węzeł `[46]`
Mówca: **Lucian Galade**
> "“Mr. Holl is exceptionally skilled. I am sure he will deliver as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "“Excellent news! Our man made it.”"]** — Mówca: **Player**
> "“Excellent news! Our man made it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucian Galade: "“I assure you, you are not the only one rejoicing at the ..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Let's hope he is better than Orso.”"]** — Mówca: **Player**
> "“Let's hope he is better than Orso.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: "“That wouldn't be difficult, sir.""*)

### Węzeł `[49]`
Mówca: **Lucian Galade**
> "“I am sure Mr. Holl will deliver. I will reiterate the importance of his task to him as soon as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Lucian Galade: "“Certainly a large step forward.""*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Conservative == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Conservative == true"*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Party_Conservative == true)"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Conservative == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Conservative"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Lucian Galade: "“To begin with, your changes to the USP manifesto have ca..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Party_Conservative == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Conservative"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Liberal == true"*)

### Węzeł `[54]`
Mówca: **Narrator**
> "He pulled out a few documents from a briefcase and laid them on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Focus_Campaign == true"*)

### Węzeł `[55]`
Mówca: **Lucian Galade**
> "“He is certainly going to be loyal to us, and that will bring us considerable power and sway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucian Galade: "“More importantly, though, the court has selected Heron G..."*)

### Węzeł `[56]`
Mówca: **Lucian Galade**
> "“More importantly, though, the court has selected Heron Garaci as the new Chief Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true"*)
  - -> `[120]` (*Player: "“Let's hope Heron is better than Orso.”"*)
  - -> `[134]` (*Player: "“This is an important milestone for Sordish democracy.”"*)
  - -> `[45]` (*Player: "“This is bad. He and Orso are basically the same person.""*)

### Węzeł `[57]`
Mówca: **Lucian Galade**
> "“Mr. Didier Meye has begun his duty as a Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lucian Galade: "“He is certainly going to be loyal to us, and that will b..."*)

### Węzeł `[58]`
Mówca: **Lucian Galade**
> "“To begin with, your changes to the USP manifesto have caused quite the stir among the reformist wing of the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Lucian Galade: "“A portion of the reformist MPs have decided to quit the ..."*)

### Węzeł `[59]`
Mówca: **Lucian Galade**
> "“The changes you ordered to the Supreme Court have now been implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Lucian Galade: "“Mr. Didier Meye has begun his duty as a Justice.”"*)

### Węzeł `[60]`
Mówca: **Lucian Galade**
> "“A portion of the reformist MPs have decided to quit the USP. 13 to be exact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lucian Galade: "“Their places have been filled with people more aligned w..."*)

### Węzeł `[61]`
Mówca: **Lucian Galade**
> "“I assure you, you are not the only one rejoicing at the appointment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[62]`
Mówca: **Lucian Galade**
> "“Their places have been filled with people more aligned with the new manifesto.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: "“As I expected. We don't need anyone who won't stay by ou..."*)
  - -> `[65]` (*Player: "“It was an unfortunate and a necessary sacrifice.”"*)
  - -> `[64]` (*Player: "“So they decided to betray me and the party. They will se..."*)
  - -> `[67]` (*Player: "“What do you think about it?”"*)

### Węzeł `[63]`
Mówca: **Lucian Galade**
> "“Indeed, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucian Galade: ""Indeed, Mr. President.”"*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“It was an unfortunate and a necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and a necessary sacrifice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucian Galade: ""Indeed, Mr. President.”"*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucian Galade: ""Indeed, Mr. President.”"*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Lucian Galade: "“The manifesto was never going to please everyone. Our ne..."*)

### Węzeł `[68]`
Mówca: **Lucian Galade**
> "“With him at the helm, trust in the Supreme Court ought to increase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Player: "“Can we trust him?”"*)
  - -> `[47]` (*Player: "“Excellent news! Our man made it.”"*)
  - -> `[48]` (*Player: "“Let's hope he is better than Orso.”"*)
  - -> `[50]` (*Player: "“This is an important milestone for Sordish democracy.”"*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Lucian Galade: "“Indeed, Mr. President.”"*)

### Węzeł `[70]`
Mówca: **Lucian Galade**
> "“That wouldn't be difficult, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Lucian Galade: "“Indeed, Mr. President.”"*)

### Węzeł `[72]`
Mówca: **Lucian Galade**
> ""Indeed, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[73]`
Mówca: **Lucian Galade**
> "“The manifesto was never going to please everyone. Our newly strengthened conservative base will more than make up for the loss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[74]`
Mówca: **Lucian Galade**
> "“The manifesto was never going to please everyone. We can only hope the gains among nationalists will make up for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[75]`
Mówca: **Lucian Galade**
> "“Their places have been filled with people more aligned with the new manifesto.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: "“As I expected. We don't need anyone who won't stay by ou..."*)
  - -> `[85]` (*Player: "“It was an unfortunate and a necessary sacrifice.”"*)
  - -> `[71]` (*Player: "“So they decided to betray me and the party. They will se..."*)
  - -> `[151]` (*Player: "“What do you think about it?”"*)

### Węzeł `[76]`
Mówca: **Lucian Galade**
> ""Indeed, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lucian Galade: ""Indeed, Mr. President.”"*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "“It was an unfortunate and a necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and a necessary sacrifice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lucian Galade: ""Indeed, Mr. President.”"*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lucian Galade: ""Indeed, Mr. President.”"*)

### Węzeł `[80]`
Mówca: **Lucian Galade**
> "“To begin with, your changes to the USP manifesto have caused quite the stir among the conservative wing of the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lucian Galade: "“A portion of the MPs have decided to quit the USP. 26 to..."*)

### Węzeł `[81]`
Mówca: **Lucian Galade**
> "“Their places have been filled with people more aligned with the new manifesto.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: "“As I expected. We don't need anyone who won't stay by ou..."*)
  - -> `[78]` (*Player: "“It was an unfortunate and a necessary sacrifice.”"*)
  - -> `[77]` (*Player: "“So they decided to betray me and the party. They will se..."*)
  - -> `[136]` (*Player: "“What do you think about it?”"*)

### Węzeł `[82]`
Mówca: **Lucian Galade**
> "“A portion of the MPs have decided to quit the USP. 26 to be exact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lucian Galade: "“Their places have been filled with people more aligned w..."*)

### Węzeł `[83]`
Mówca: **Lucian Galade**
> "“Certainly a large step forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[84]`
Mówca: **Lucian Galade**
> "“The changes you ordered to the Supreme Court have now been implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Lucian Galade: "“Mr. Ovid Grecer has begun his duty in the Supreme Court ..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA: "“It was an unfortunate and a necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and a necessary sacrifice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Lucian Galade: "“Indeed, Mr. President.”"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_ExperiencedJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_ExperiencedJustice == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_ExperiencedJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_ExperiencedJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Lucian Galade: "“Moving on...”"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_ExperiencedJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_ExperiencedJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_LoyalJustice == true"*)

### Węzeł `[89]`
Mówca: **Lucian Galade**
> "“A portion of the reformist MPs have decided to quit the USP. 21 to be exact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lucian Galade: "“Their places have been filled with people more aligned w..."*)

### Węzeł `[90]`
Mówca: **Lucian Galade**
> "“Certainly a large step forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Liberal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Liberal == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Party_Liberal == true)"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Liberal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Liberal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucian Galade: "“To begin with, your changes to the USP manifesto have ca..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Party_Liberal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Liberal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Socialist == true"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Socialist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Socialist == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Party_Socialist == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Socialist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Lucian Galade: "“To begin with, your changes to the USP manifesto have ca..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Party_Socialist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Ultranationalist == true"*)

### Węzeł `[97]`
Mówca: **Lucian Galade**
> ""That wouldn't be difficult, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Ultranationalist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Ultranationalist == true"*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Party_Ultranationalist == true)"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Ultranationalist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lucian Galade: "“To begin with, your changes to the USP manifesto have ca..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Party_Ultranationalist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[101]`
Mówca: **Lucian Galade**
> "“He appears to have a refreshing lack of political motivations. I am hopeful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Campaign_ExtraBudget == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Campaign_ExtraBudget == true"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Campaign_ExtraBudget == true)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Campaign_ExtraBudget == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Campaign_ExtraBudget"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Lucian Galade: "“One more thing on this topic.”"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Campaign_ExtraBudget == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Campaign_ExtraBudget"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[105]`
Mówca: **Narrator**
> "He flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lucian Galade: "“The changes you ordered to the Supreme Court have now be..."*)

### Węzeł `[106]`
Mówca: **Lucian Galade**
> "“One more thing on this topic.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Lucian Galade: "“The mayors are extremely happy with the extra funds you ..."*)

### Węzeł `[107]`
Mówca: **Lucian Galade**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "He flipped the page."*)

### Węzeł `[108]`
Mówca: **Lucian Galade**
> "“The mayors are extremely happy with the extra funds you have provided them to assist with our campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lucian Galade: "“This will surely boost our popularity.”"*)

### Węzeł `[109]`
Mówca: **Lucian Galade**
> "“I wish I could be as optimistic. But I fear one Old Guard member has simply been swapped out for another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "He closed the folder and put away the documents."*)

### Węzeł `[110]`
Mówca: **Lucian Galade**
> "“This will surely boost our popularity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: "“I hope the money went into the right place instead of th..."*)
  - -> `[113]` (*Player: "“Excellent. We need all the help we can get.""*)
  - -> `[114]` (*Player: "“Good work.”"*)

### Węzeł `[111]`
Mówca: **Narrator**
> "He flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Lucian Galade: "“The changes you ordered to the Supreme Court have now be..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "“I hope the money went into the right place instead of their pockets.”"]** — Mówca: **Player**
> "“I hope the money went into the right place instead of their pockets.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lucian Galade: "“In either scenario, the mayors are happy. That will only..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "“Excellent. We need all the help we can get.""]** — Mówca: **Player**
> "“Excellent. We need all the help we can get.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Lucian Galade: "“Agreed.”"*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Good work.”"]** — Mówca: **Player**
> "“Good work.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lucian Galade: "“Thank you. I do try my best.""*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Lucian Galade: "“Certainly a large step forward.""*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "“Let's hope he will be better than Orso.”"]** — Mówca: **Player**
> "“Let's hope he will be better than Orso.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Lucian Galade: ""That wouldn't be difficult, sir.""*)

### Węzeł `[117]`
**[WYBÓR GRACZA: "“Can he be trusted?”"]** — Mówca: **Player**
> "“Can he be trusted?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lucian Galade: "“He appears to have a refreshing lack of political motiva..."*)

### Węzeł `[118]`
Mówca: **Lucian Galade**
> "“In either scenario, the mayors are happy. That will only help us going forward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 3;"*)

### Węzeł `[119]`
Mówca: **Lucian Galade**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 3;"*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "“Let's hope Heron is better than Orso.”"]** — Mówca: **Player**
> "“Let's hope Heron is better than Orso.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Lucian Galade), `[219]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Lucian Galade: "“That wouldn't be difficult. But I fear one Old Guard mem..."*)

### Węzeł `[121]`
Mówca: **Lucian Galade**
> "“Thank you. I do try my best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 3;"*)

### Węzeł `[122]`
Mówca: **Lucian Galade**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "He flipped the page."*)

### Węzeł `[123]`
Mówca: **Lucian Galade**
> "“To begin with, your changes to the USP manifesto have caused quite the stir among the reformist wing of the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lucian Galade: "“A portion of the reformist MPs have decided to quit the ..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_LoyalJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_LoyalJustice == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_LoyalJustice == true)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_LoyalJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_LoyalJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Lucian Galade: "“Moving on...”"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_LoyalJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_LoyalJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_OldGuardReplaced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_OldGuardReplaced == true"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_OldGuardReplaced == true)"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_OldGuardReplaced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: "“Moving on...”"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_OldGuardReplaced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_Shuffled == true"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_Shuffled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_Shuffled == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_Shuffled == true)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_Shuffled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Lucian Galade: "“Moving on...”"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_Shuffled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "He closed the folder and put away the documents."*)

### Węzeł `[133]`
Mówca: **Lucian Galade**
> "“He is a seasoned veteran with a career in law spanning more than 30 years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: "“Can he be trusted?”"*)
  - -> `[116]` (*Player: "“Let's hope he will be better than Orso.”"*)
  - -> `[115]` (*Player: "“This is an important milestone for Sordish democracy.”"*)

### Węzeł `[134]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Lucian Galade), `[219]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lucian Galade: "“I wish I could be as optimistic. But I fear one Old Guar..."*)

### Węzeł `[135]`
Mówca: **Lucian Galade**
> "“I'm surprised you would trust a man like Mr. Garaci.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "He closed the folder and put away the documents."*)

### Węzeł `[136]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Lucian Galade: "“The manifesto was never going to please everyone. The ga..."*)

### Węzeł `[137]`
Mówca: **Lucian Galade**
> "“The manifesto was never going to please everyone. The gains we make among reformists will surely make up for the loss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[138]`
Mówca: **Lucian Galade**
> "“The Court's new chief justice is mostly an unknown figure in politics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Lucian Galade: "“His name is Ovid Grecer.”"*)

### Węzeł `[139]`
Mówca: **Lucian Galade**
> "“Indeed, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[140]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Lucian Galade: "“Indeed, Mr. President.”"*)

### Węzeł `[141]`
**[WYBÓR GRACZA: "“It was an unfortunate and a necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and a necessary sacrifice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Lucian Galade: "“Indeed, Mr. President.”"*)

### Węzeł `[142]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Lucian Galade: "“Indeed, Mr. President.”"*)

### Węzeł `[143]`
Mówca: **Lucian Galade**
> "“To begin with, your changes to the USP manifesto have caused quite the stir among party members.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“An alarming number of MPs have decided to quit the USP. ..."*)

### Węzeł `[144]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Lucian Galade: "“The manifesto was never going to please everyone. We can..."*)

### Węzeł `[145]`
Mówca: **Lucian Galade**
> "“Their places have been filled with people more aligned with the new manifesto.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player: "“As I expected. We don't need anyone who won't stay by ou..."*)
  - -> `[141]` (*Player: "“It was an unfortunate and a necessary sacrifice.”"*)
  - -> `[140]` (*Player: "“So they decided to betray me and the party. They will se..."*)
  - -> `[144]` (*Player: "“What do you think about it?”"*)

### Węzeł `[146]`
Mówca: **Lucian Galade**
> "“The manifesto was never going to please everyone. We can only hope the gains among socialists will make up for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[147]`
Mówca: **Lucian Galade**
> "“An alarming number of MPs have decided to quit the USP. 26 from the conservative wing, 13 from the reformist side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Lucian Galade: "“Their places have been filled with people more aligned w..."*)

### Węzeł `[148]`
Mówca: **Lucian Galade**
> "“His name is Ovid Grecer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Lucian Galade: "“He is a seasoned veteran with a career in law spanning m..."*)

### Węzeł `[149]`
Mówca: **Lucian Galade**
> "“That wouldn't be difficult. But I fear one Old Guard member has simply been swapped out for another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "He closed the folder and put away the documents."*)

### Węzeł `[150]`
**[WYBÓR GRACZA: "“Excellent news. I am glad to see him elected.”"]** — Mówca: **Player**
> "“Excellent news. I am glad to see him elected.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true`
- **Kontekst wejściowy (poprzednik):** `[56]` (Lucian Galade), `[219]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Lucian Galade: "“I'm surprised you would trust a man like Mr. Garaci.”"*)

### Węzeł `[151]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucian Galade: "“The manifesto was never going to please everyone. We can..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_GloriaJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true"*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_GloriaJustice == true)"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_GloriaJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Lucian Galade: "“Moving on...”"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_GloriaJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_OldGuardReplaced == true"*)

### Węzeł `[155]`
Mówca: **Lucian Galade**
> "“Mr. Ovid Grecer has begun his duty in the Supreme Court as a Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Lucian Galade: "“He is a seasoned veteran with a career in law spanning m..."*)

### Węzeł `[156]`
Mówca: **Lucian Galade**
> "“He is a seasoned veteran with a career in law spanning more than 30 years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Lucian Galade: "“Perhaps it is this experience which caused the Court to ..."*)

### Węzeł `[157]`
Mówca: **Lucian Galade**
> "“Perhaps it is this experience which caused the Court to select Mr. Grecer as the new Chief Justice directly after his appointment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lucian Galade: "“With him at the helm, trust in the Supreme Court ought t..."*)

### Węzeł `[158]`
**[WYBÓR GRACZA: "“Can we trust him?”"]** — Mówca: **Player**
> "“Can we trust him?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Lucian Galade: "“Certainly. He's renowned for his impartiality.""*)

### Węzeł `[159]`
Mówca: **Lucian Galade**
> "“Certainly. He's renowned for his impartiality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[160]`
Mówca: **Lucian Galade**
> "“The changes you ordered to the Supreme Court have now been implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Lucian Galade: "“Ms. Gloria Tory has now begun her duty in the Supreme Co..."*)

### Węzeł `[161]`
Mówca: **Narrator**
> "He flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Lucian Galade: "“The changes you ordered to the Supreme Court have now be..."*)

### Węzeł `[162]`
Mówca: **Lucian Galade**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "He flipped the page."*)

### Węzeł `[163]`
Mówca: **Lucian Galade**
> "“I think we both know what she brings to the table.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lucian Galade: "“More importantly, though, the court has selected Heron G..."*)

### Węzeł `[164]`
Mówca: **Lucian Galade**
> "“Ms. Gloria Tory has now begun her duty in the Supreme Court as a Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Lucian Galade: "“I think we both know what she brings to the table.”"*)

### Węzeł `[165]`
Mówca: **Narrator**
> "He closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Lucian Galade: "“That is all for the court updates.”"*)

### Węzeł `[166]`
Mówca: **Lucian Galade**
> "“That is all for the court updates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[167]`
Mówca: **Narrator**
> "He closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Lucian Galade: "“That is all for the court updates.”"*)

### Węzeł `[168]`
Mówca: **Lucian Galade**
> "“That is all for the court updates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[169]`
Mówca: **Narrator**
> "He closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Lucian Galade: "“That is all for the court updates.”"*)

### Węzeł `[170]`
Mówca: **Lucian Galade**
> "“That is all for the court updates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[171]`
Mówca: **Narrator**
> "He closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Detained_FrensRicter == tru..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Lucian Galade: "“Moving on to some updates from the Assembly.”"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Lucian Galade: "“Moving on...""*)

### Węzeł `[175]`
Mówca: **Lucian Galade**
> "“Moving on to some updates from the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Lucian Galade: "“As you know, the... *absence* of Frens Ricter has led to..."*)

### Węzeł `[176]`
Mówca: **Lucian Galade**
> "“As you know, the... *absence* of Frens Ricter has led to turmoil within the PFJP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Lucian Galade: "“They've been scrambling to keep the party intact without..."*)

### Węzeł `[177]`
Mówca: **Lucian Galade**
> "“They've been scrambling to keep the party intact without a leader.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Lucian Galade: "“Or at least, that was the case until yesterday's PFJP co..."*)

### Węzeł `[178]`
Mówca: **Lucian Galade**
> "“Or at least, that was the case until yesterday's PFJP congress.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Lucian Galade: "“Please, have a look.”"*)

### Węzeł `[179]`
Mówca: **Lucian Galade**
> "“Please, have a look.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "He handed me an official report from the PFJP."*)

### Węzeł `[180]`
Mówca: **Narrator**
> "He handed me an official report from the PFJP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Lucian Galade: "“It seems an unprecedented candidate from their ranks has..."*)

### Węzeł `[181]`
Mówca: **Lucian Galade**
> "“It seems an unprecedented candidate from their ranks has been selected as the new leader.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Lucian Galade: "“Her name is Manoly Suheil.”"*)

### Węzeł `[182]`
Mówca: **Lucian Galade**
> "“Her name is Manoly Suheil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[183]`
Mówca: **Lucian Galade**
> "“I don't know how she made it that far in the PFJP, but one thing is for certain.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Lucian Galade: "“She is popular both in the Assembly and among the people.”"*)

### Węzeł `[184]`
Mówca: **Lucian Galade**
> "“She is popular both in the Assembly and among the people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Lucian Galade: "“We shouldn't underestimate her.”"*)

### Węzeł `[185]`
Mówca: **Lucian Galade**
> "“We shouldn't underestimate her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player: "“We won't.”"*)
  - -> `[187]` (*Player: "“What can she do when Frens couldn't do anything?”"*)
  - -> `[189]` (*Player: "“Don't be alarmed. We have nothing to worry about.”"*)
  - -> `[188]` (*Player: "“Hypothetically, what if she were to meet the same fate a..."*)

### Węzeł `[186]`
**[WYBÓR GRACZA: "“We won't.”"]** — Mówca: **Player**
> "“We won't.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Lucian Galade), `[268]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Lucian Galade: "“As I expected from you, sir.”"*)

### Węzeł `[187]`
**[WYBÓR GRACZA: "“What can she do when Frens couldn't do anything?”"]** — Mówca: **Player**
> "“What can she do when Frens couldn't do anything?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Lucian Galade), `[268]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Lucian Galade: "“If she can tap into Frens's base, she will have as much ..."*)

### Węzeł `[188]`
**[WYBÓR GRACZA: "“Hypothetically, what if she were to meet the same fate as Frens?”"]** — Mówca: **Player**
> "“Hypothetically, what if she were to meet the same fate as Frens?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Lucian Galade), `[268]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Opposition == true"*)

### Węzeł `[189]`
**[WYBÓR GRACZA: "“Don't be alarmed. We have nothing to worry about.”"]** — Mówca: **Player**
> "“Don't be alarmed. We have nothing to worry about.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Lucian Galade), `[268]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Lucian Galade: "“Better safe than sorry.”"*)

### Węzeł `[190]`
Mówca: **Lucian Galade**
> "“Better safe than sorry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[191]`
Mówca: **Lucian Galade**
> "“That may yet be possible, depending on the results of your investigation on the opposition. I shall keep you updated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[192]`
Mówca: **Lucian Galade**
> "“If she can tap into Frens's base, she will have as much power as him. We will be watching her moves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[193]`
Mówca: **Lucian Galade**
> "“As I expected from you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Detained_KesaroKibener == t..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Lucian Galade: "“I have received multiple reports that the NFP has chosen..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[197]`
Mówca: **Lucian Galade**
> "“I have received multiple reports that the NFP has chosen a new leader following Kesaro Kibener's... untimely exit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Lucian Galade: "“You've met him. Remus Holstron, also known as the 'Iron ..."*)

### Węzeł `[198]`
Mówca: **Lucian Galade**
> "“You've met him. Remus Holstron, also known as the 'Iron Wall'. Mr. Kibener's former right-hand man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player: ""What else can you tell me about him?""*)
  - -> `[260]` (*Player: ""Oh, yes. I know all about him.""*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What else can you tell me about him?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Lucian Galade: "“As a brutally efficient Young Sords member, he was recru..."*)

### Węzeł `[200]`
Mówca: **Lucian Galade**
> "“As a brutally efficient Young Sords member, he was recruited by Kesaro himself during the coup when he was still in the military.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Lucian Galade: "“Not the most charming gentleman you or I have met.""*)

### Węzeł `[201]`
Mówca: **Lucian Galade**
> "“Not the most charming gentleman you or I have met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Lucian Galade: "“Some say that he might be even more extreme than Kesaro ..."*)

### Węzeł `[202]`
Mówca: **Lucian Galade**
> "“Some say that he might be even more extreme than Kesaro in his xenophobic sentiments.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Lucian Galade: "“On top of that, he has a fervent following among the You..."*)

### Węzeł `[203]`
**[WYBÓR GRACZA: "“If he is the 'Iron Wall', then I will be the one that brings it down.”"]** — Mówca: **Player**
> "“If he is the 'Iron Wall', then I will be the one that brings it down.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Lucian Galade), `[261]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Lucian Galade: "“It's a silly nickname, I agree.”"*)

### Węzeł `[204]`
**[WYBÓR GRACZA: "“He doesn't scare me. I have dealt with much worse.”"]** — Mówca: **Player**
> "“He doesn't scare me. I have dealt with much worse.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Lucian Galade), `[261]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Lucian Galade: "“It's better to be on the side of caution.”"*)

### Węzeł `[205]`
**[WYBÓR GRACZA: "“Make sure he never becomes a big problem, then.”"]** — Mówca: **Player**
> "“Make sure he never becomes a big problem, then.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Lucian Galade), `[261]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Lucian Galade: "“We will do our best.”"*)

### Węzeł `[206]`
**[WYBÓR GRACZA: "“He can never *ever* hope to reach Kesaro's level.”"]** — Mówca: **Player**
> "“He can never *ever* hope to reach Kesaro's level.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Lucian Galade), `[261]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Lucian Galade: "“I never cared for either man. But you may be right.”"*)

### Węzeł `[207]`
Mówca: **Lucian Galade**
> "“On top of that, he has a fervent following among the Young Sords.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Lucian Galade: "“I can say with certainty that he *will* be a problem.”"*)

### Węzeł `[208]`
Mówca: **Lucian Galade**
> "“I can say with certainty that he *will* be a problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Player: "“If he is the 'Iron Wall', then I will be the one that br..."*)
  - -> `[204]` (*Player: "“He doesn't scare me. I have dealt with much worse.”"*)
  - -> `[205]` (*Player: "“Make sure he never becomes a big problem, then.”"*)
  - -> `[206]` (*Player: "“He can never *ever* hope to reach Kesaro's level.”"*)

### Węzeł `[209]`
Mówca: **Lucian Galade**
> "“I never cared for either man. But you may be right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[210]`
Mówca: **Lucian Galade**
> "“We will do our best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[211]`
Mówca: **Lucian Galade**
> "“It's better to be on the side of caution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[212]`
Mówca: **Lucian Galade**
> "“It's a silly nickname, I agree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true"*)
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: "“Excellent news. I am glad to see him elected.”"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true"*)
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: "“Excellent news. I am glad to see him elected.”"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[219]`
Mówca: **Lucian Galade**
> "“More importantly, though, the court has selected Heron Garaci as the new Chief Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: "“Let's hope Heron is better than Orso.”"*)
  - -> `[134]` (*Player: "“This is an important milestone for Sordish democracy.”"*)
  - -> `[45]` (*Player: "“This is bad. He and Orso are basically the same person.""*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Opposition == true"*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Investigate_Opposition == true)"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Lucian Galade: "“That may yet be possible, depending on the results of yo..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Investigate_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Lucian Galade: "“No, I'm afraid it would look too suspicious. Hypothetica..."*)

### Węzeł `[224]`
Mówca: **Lucian Galade**
> "“No, I'm afraid it would look too suspicious. Hypothetically.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[225]`
Mówca: **Lucian Galade**
> "“Moving on...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.PoliticalOverview2_TvAd = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.PoliticalOverview2_TvAd"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Campaign_ExtraBudget == true"*)

### Węzeł `[227]`
Mówca: **Lucian Galade**
> ""Oh. And he already gave a landmark ruling as his first act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Lucian Galade: ""The indefinitely delayed case of Ishval Ersen against Go..."*)

### Węzeł `[228]`
Mówca: **Lucian Galade**
> ""The indefinitely delayed case of Ishval Ersen against Governor Phelix Bron has finally reached to a conclusion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == false && BaseGame.Berg..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Lucian Galade: ""Oh. And he already gave a landmark ruling as his first a..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "He closed the folder and put away the documents."*)

### Węzeł `[232]`
Mówca: **Lucian Galade**
> ""He was found guilty of abusing his powers to enable discrimination against the citizens of Sordland and found guilty of breaking the constitutional laws of the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Lucian Galade: ""He was promptly stripped from his duties as governor of ..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == tru..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Lucian Galade: ""He was found guilty of abusing his powers to enable disc..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Lucian Galade: ""He was found guilty of abusing his powers to enable disc..."*)

### Węzeł `[236]`
Mówca: **Lucian Galade**
> ""He was found guilty of abusing his powers to enable discrimination against the citizens of Sordland which directly goes against the new Constitution. He was therefore found guilty of breaking the constitutional laws of the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Lucian Galade: ""He was promptly stripped from his duties as governor of ..."*)

### Węzeł `[237]`
Mówca: **Lucian Galade**
> ""He was promptly stripped from his duties as governor of the Special Zone and was sent directly to Antel Rock Prison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Lucian Galade: ""As for his replacement, the Court argued that since it w..."*)

### Węzeł `[238]`
Mówca: **Lucian Galade**
> ""As for his replacement, the Court argued that since it was an extraordinary circumstance and the elections are already nearby, a transitionary council must take charge of the governance of the Special Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Lucian Galade: ""According to the decisions made in that council, Ishval ..."*)

### Węzeł `[239]`
Mówca: **Lucian Galade**
> ""According to the decisions made in that council, Ishval Ersen was already picked as the most suitable governor choice, arguably as a Bludish rights activist from Bergia who became extremely famous for bringing up the issues to the governmental level.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true && BaseGame...."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Player: ""This is great news, Lucian!""*)
  - -> `[241]` (*Player: ""I'm already liking Chief Justice Grecer.""*)
  - -> `[243]` (*Player: ""This is a great development for Bludish rights in Sordla..."*)
  - -> `[244]` (*Player: ""Honestly, I don't even want to hear about Bergia anymore.""*)

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm already liking Chief Justice Grecer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Lucian Galade: ""He seems to be a good choice.""*)

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is great news, Lucian!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is a great development for Bludish rights in Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, I don't even want to hear about Bergia anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[245]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "He closed the folder and put away the documents."*)

### Węzeł `[246]`
Mówca: **Lucian Galade**
> ""He seems to be a good choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "He closed the folder and put away the documents."*)

### Węzeł `[247]`
Mówca: **Lucian Galade**
> ""I must say... He already gave a landmark ruling as his first act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lucian Galade: ""The indefinitely delayed case ..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == false && BaseGame.Berg..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Lucian Galade: ""I must say... He already gave a landmark ruling as his f..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "He closed the folder and put away the documents."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron = false;
BaseGame.Bergia_Governor_Krull = false;
BaseGame.Bergia_Governor_Ersen = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Bergia_Governor_Bron"] = false;
Variable["BaseGame.Bergia_Governor_Krull"] = false;
Variable["BaseGame.Bergia_Governor_Ersen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_StateFigures_PhelixBron_..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lucian Galade: ""The indefinitely delayed case of I..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Lucian Galade: ""The indefinitely delayed case of Ishval Ersen against Go..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty = true;
BaseGameSupport.News_Turn08_R_OvidGrecerFindsBronGuilty = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty"] = true;
Variable["BaseGameSupport.News_Turn08_R_OvidGrecerFindsBronGuilty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron = false; BaseGame.Bergia_Go..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true && BaseGame...."*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true && BaseGam..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBr..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBr..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Amended = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Amended"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty ..."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Default = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Holsord_OvidGrecerChargesBron_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_OvidGrecerFindsBronGuilty ..."*)

### Węzeł `[259]`
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
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh, yes. I know all about him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Lucian Galade: "“Then you know that as head of the NFP, he will pose a pr..."*)

### Węzeł `[261]`
Mówca: **Lucian Galade**
> "“Then you know that as head of the NFP, he will pose a problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Player: "“If he is the 'Iron Wall', then I will be the one that br..."*)
  - -> `[204]` (*Player: "“He doesn't scare me. I have dealt with much worse.”"*)
  - -> `[205]` (*Player: "“Make sure he never becomes a big problem, then.”"*)
  - -> `[206]` (*Player: "“He can never *ever* hope to reach Kesaro's level.”"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Lucian Galade: ""We have met her before.""*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Lucian Galade: "“I don't know how she made it that far in the PFJP, but o..."*)

### Węzeł `[265]`
Mówca: **Lucian Galade**
> ""We have met her before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player: ""Briefly. What can you tell me about her?""*)
  - -> `[266]` (*Player: ""Yes, say no more. I know all about her.""*)

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, say no more. I know all about her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Lucian Galade: "“Then you know we shouldn't underestimate her.”"*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Briefly. What can you tell me about her?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Lucian Galade: "“I don't know how she made it that far in the PFJP, but o..."*)

### Węzeł `[268]`
Mówca: **Lucian Galade**
> "“Then you know we shouldn't underestimate her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player: "“We won't.”"*)
  - -> `[187]` (*Player: "“What can she do when Frens couldn't do anything?”"*)
  - -> `[189]` (*Player: "“Don't be alarmed. We have nothing to worry about.”"*)
  - -> `[188]` (*Player: "“Hypothetically, what if she were to meet the same fate a..."*)
