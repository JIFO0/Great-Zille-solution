# Sordland/Turn08/PETR FEEDBACK

- **ID konwersacji:** `175`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/175_PETR_FEEDBACK.md`
- **Liczba węzłów dialogowych:** 251
- **Liczba wyborów gracza:** 42

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[10]** Narrator

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
- Węzeł `[2]` -> **[171] Sordland/Turn08/A_PoliticalOverview2** (../Turn_08/171_A_PoliticalOverview2.md), Węzeł `[1011]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[19]` | **"“I say I'm ready for my close-up.”"** | `[18]` **Petr Vectern**: "“Think about it: Anton Rayne, in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Petr Vectern**: "“That's the spirit!”" |
| `[20]` | **"“It's a good plan. Let's do it.”"** | `[18]` **Petr Vectern**: "“Think about it: Anton Rayne, in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Petr Vectern**: "“Thanks! You won't regret it."" |
| `[21]` | **"“I won't allow regular citizens to come in here. What's next? Tourists roaming the..."** | `[18]` **Petr Vectern**: "“Think about it: Anton Rayne, in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Petr Vectern**: "“Fine, I get it. I'll look into ..." |
| `[28]` | **""It's not my favorite idea. But if it helps with the election, I guess I have no c..."** | `[18]` **Petr Vectern**: "“Think about it: Anton Rayne, in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Petr Vectern**: "“That's the spirit!”" |
| `[36]` | **"“This better be good. For his own good.”"** | `[35]` **Petr Vectern**: "“At any rate, he will schedule a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Petr Vectern**: "“I'm sure he'll deliver. But I'l..." |
| `[37]` | **"“Tell him to be quick. Our administration depends on it.”"** | `[35]` **Petr Vectern**: "“At any rate, he will schedule a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Petr Vectern**: "“I'll let him know.”" |
| `[38]` | **"“Symon can pull it off. I'm sure. He has never failed me before.”"** | `[35]` **Petr Vectern**: "“At any rate, he will schedule a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Petr Vectern**: "“Oh, I trust his capabilities. A..." |
| `[39]` | **"“I will be expecting good ideas and even better outcomes.”"** | `[35]` **Petr Vectern**: "“At any rate, he will schedule a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Petr Vectern**: "“I'm sure he'll deliver.”" |
| `[45]` | **"“This is bad. He's just the same as Orso Hawker.""** | `[56]` **Petr Vectern**: "“More importantly, though, Heron..."<br>`[198]` **Petr Vectern**: "“More importantly, though, Heron..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Petr Vectern**: "“We can only hope he isn't as sm..." |
| `[47]` | **"“Excellent news. Our man made it.”"** | `[68]` **Petr Vectern**: "“Good news for us, if you ask me."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Petr Vectern**: ""We're not the only ones who are..." |
| `[48]` | **"“Let's hope he is better than Orso.”"** | `[68]` **Petr Vectern**: "“Good news for us, if you ask me."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Petr Vectern**: "“Who isn't?"" |
| `[50]` | **"“This is an important milestone for Sordish democracy.”"** | `[68]` **Petr Vectern**: "“Good news for us, if you ask me."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Petr Vectern**: "“It's a big step forward, defini..." |
| `[64]` | **"“So they decided to betray me and the party. They will see their mistakes one day.”"** | `[63]` **Petr Vectern**: "“Their places have been filled w..."<br>`[72]` **Petr Vectern**: "“Their places have been filled w..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Petr Vectern**: "“If you say so, Mr. President.”" |
| `[65]` | **"“It was an unfortunate and necessary sacrifice.”"** | `[63]` **Petr Vectern**: "“Their places have been filled w..."<br>`[72]` **Petr Vectern**: "“Their places have been filled w..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Petr Vectern**: "“If you say so, Mr. President.”" |
| `[66]` | **"“As I expected. We don't need anyone who won't stay by our side.”"** | `[63]` **Petr Vectern**: "“Their places have been filled w..."<br>`[72]` **Petr Vectern**: "“Their places have been filled w..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Petr Vectern**: "“I agree."" |
| `[67]` | **"“What do you think about it?”"** | `[63]` **Petr Vectern**: "“Their places have been filled w..."<br>`[72]` **Petr Vectern**: "“Their places have been filled w..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Petr Vectern**: "“Well, the new manifesto was nev..." |
| `[104]` | **"“I hope the money went into the right place instead of their pockets.”"** | `[102]` **Petr Vectern**: "“This will definitely boost our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Petr Vectern**: "“If the mayors are happy, does i..." |
| `[105]` | **"“Excellent. We need all the help we can get.""** | `[102]` **Petr Vectern**: "“This will definitely boost our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Petr Vectern**: "“Agreed.”" |
| `[106]` | **"“Good work.”"** | `[102]` **Petr Vectern**: "“This will definitely boost our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Petr Vectern**: "“Thank you. You know I'm trying ..." |
| `[107]` | **"“This is an important milestone for Sordish democracy.”"** | `[124]` **Petr Vectern**: "“He's got a long, illustrious an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Petr Vectern**: "“It's definitely a big step forw..." |
| `[108]` | **"“Let's hope he will be better than Orso.”"** | `[124]` **Petr Vectern**: "“He's got a long, illustrious an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Petr Vectern**: "“Who isn't?"" |
| `[109]` | **"“Can he be trusted?”"** | `[124]` **Petr Vectern**: "“He's got a long, illustrious an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Petr Vectern**: "“He doesn't seem to have any ult..." |
| `[112]` | **"“Let's hope Heron is better than Orso.”"** | `[56]` **Petr Vectern**: "“More importantly, though, Heron..."<br>`[198]` **Petr Vectern**: "“More importantly, though, Heron..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Petr Vectern**: "“He's basically Orso in a differ..." |
| `[125]` | **"“This is an important milestone for Sordish democracy.”"** | `[56]` **Petr Vectern**: "“More importantly, though, Heron..."<br>`[198]` **Petr Vectern**: "“More importantly, though, Heron..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Petr Vectern**: "“I don't know about that. He's b..." |
| `[133]` | **"“Excellent news. I am glad to see him elected.”"** | `[56]` **Petr Vectern**: "“More importantly, though, Heron..."<br>`[198]` **Petr Vectern**: "“More importantly, though, Heron..." | `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true` | *Brak zmian stanu* | `[126]` **Petr Vectern**: "“You trust him? I wouldn't."" |
| `[139]` | **"“Can we trust him?”"** | `[68]` **Petr Vectern**: "“Good news for us, if you ask me."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Petr Vectern**: "“I'd trust him a lot more than, ..." |
| `[167]` | **"“'Not bad-looking?' Haven't you learned anything?""** | `[166]` **Petr Vectern**: "“We shouldn't underestimate her.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Petr Vectern**: "“Lighten up, Mr. President. It w..." |
| `[168]` | **"“What can she do when Frens couldn't do anything?”"** | `[166]` **Petr Vectern**: "“We shouldn't underestimate her.”"<br>`[250]` **Petr Vectern**: "“Then you know we shouldn't unde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Petr Vectern**: "“If she can tap into Frens's bas..." |
| `[169]` | **""Hypothetically, what if she were to meet the same fate as Frens?""** | `[166]` **Petr Vectern**: "“We shouldn't underestimate her.”"<br>`[250]` **Petr Vectern**: "“Then you know we shouldn't unde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Petr Vectern**: "“Don't you still have your inves..."<br>`[206]` **Petr Vectern**: "“Hypothetically, that might look..." |
| `[170]` | **"“Don't be alarmed. We have nothing to worry about.”"** | `[166]` **Petr Vectern**: "“We shouldn't underestimate her.”"<br>`[250]` **Petr Vectern**: "“Then you know we shouldn't unde..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Petr Vectern**: "“Better safe than sorry.”" |
| `[180]` | **"“What else can you tell me about him?""** | `[179]` **Petr Vectern**: "“You've met him. Remus Holstron,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Petr Vectern**: "“As a die-hard Young Sords membe..." |
| `[184]` | **"“It's time to bring down the 'Iron Wall'.”"** | `[190]` **Petr Vectern**: "“I can tell you right now he's g..."<br>`[243]` **Petr Vectern**: "“Then you know he's going to be ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Petr Vectern**: "“I agree. It's a stupid nickname."" |
| `[185]` | **"“He doesn't scare me. I have dealt with much worse.”"** | `[190]` **Petr Vectern**: "“I can tell you right now he's g..."<br>`[243]` **Petr Vectern**: "“Then you know he's going to be ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Petr Vectern**: "“It's better to be on the side o..." |
| `[186]` | **"“Make sure he never becomes a big problem then.”"** | `[190]` **Petr Vectern**: "“I can tell you right now he's g..."<br>`[243]` **Petr Vectern**: "“Then you know he's going to be ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Petr Vectern**: "“I'll try.”" |
| `[187]` | **"“He can never *ever* hope to reach Kesaro's level.""** | `[190]` **Petr Vectern**: "“I can tell you right now he's g..."<br>`[243]` **Petr Vectern**: "“Then you know he's going to be ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Petr Vectern**: "“Frankly, I could never stand ei..." |
| `[222]` | **""I'm already liking Chief Justice Grecer.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Petr Vectern**: ""Me too."" |
| `[223]` | **""This is great news, Petr!""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[226]` **Petr Vectern**: ""Exactly."" |
| `[224]` | **""Honestly, I don't even want to hear about Bergia anymore.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[228]` **Petr Vectern**: ""Sure."" |
| `[225]` | **""This is a great development for Bludish rights in Sordland.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[226]` **Petr Vectern**: ""Exactly."" |
| `[242]` | **"“Say no more. I know *all* about him.""** | `[179]` **Petr Vectern**: "“You've met him. Remus Holstron,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Petr Vectern**: "“Then you know he's going to be ..." |
| `[248]` | **""Yes, say no more. I know all about her.""** | `[247]` **Petr Vectern**: ""We met her before, remember?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[250]` **Petr Vectern**: "“Then you know we shouldn't unde..." |
| `[249]` | **""Vaguely. What can you tell me about her?""** | `[247]` **Petr Vectern**: ""We met her before, remember?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Petr Vectern**: "“I don't know how she was able t..." |

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
  - -> `[3]` (*Petr Vectern: "“All right. I've got some updates for you on what we're d..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1011]`

### Węzeł `[3]`
Mówca: **Petr Vectern**
> "“All right. I've got some updates for you on what we're dealing with politically.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "He pulled out a few documents from a briefcase and laid t..."*)

### Węzeł `[4]`
Mówca: **Petr Vectern**
> "“Those changes you ordered to the Supreme Court have been implemented.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Petr Vectern: "“The whole Court's been reshuffled. Swapped out. The now ..."*)

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
  - -> `[12]` (*Petr Vectern: "“As you know, I'm working on improving our public image.”"*)

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
  - -> `[33]` (*Petr Vectern: "“Symon told me that he's almost done with the new economi..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Results_Focus_Economy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Results_Focus_Economy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Conservative == true"*)

### Węzeł `[11]`
Mówca: **Petr Vectern**
> "“The whole Court's been reshuffled. Swapped out. The now ex-Justices are rather ticked off. To put it mildly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Petr Vectern: "“But who cares? The dinosaurs are gone. We finally have s..."*)

### Węzeł `[12]`
Mówca: **Petr Vectern**
> "“As you know, I'm working on improving our public image.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Petr Vectern: "“There's a decision you've got to make.""*)

### Węzeł `[13]`
Mówca: **Petr Vectern**
> "“There's a decision you've got to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Petr Vectern: "“Our researchers are saying television is becoming an inc..."*)

### Węzeł `[14]`
Mówca: **Petr Vectern**
> "“Our researchers are saying television is becoming an increasingly effective method of reaching people, especially young people. Which, honestly, I could have told them that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Petr Vectern: "“So I talked to a few advisors and we want to put you on ..."*)

### Węzeł `[15]`
Mówca: **Petr Vectern**
> "“So I talked to a few advisors and we want to put you on TV. We've already got Sordland's largest ad agency on board for the job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Petr Vectern: "“We'd need to give them security clearance to come in and..."*)

### Węzeł `[16]`
Mówca: **Petr Vectern**
> "“We'd need to give them security clearance to come in and take photos and videos in the Maroon Palace. Specifically, they want footage of you, Anton. Working, posing, just being your pretty self.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Petr Vectern: "“Think about it: Anton Rayne, in every home in Sordland. ..."*)

### Węzeł `[17]`
Mówca: **Petr Vectern**
> "“The Old Guard is gone. Purged. The now ex-Justices are rather ticked off. To put it mildly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Petr Vectern: "“But good riddance! It's about time we got rid of those d..."*)

### Węzeł `[18]`
Mówca: **Petr Vectern**
> "“Think about it: Anton Rayne, in every home in Sordland. What do you say?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: "“I say I'm ready for my close-up.”"*)
  - -> `[20]` (*Player: "“It's a good plan. Let's do it.”"*)
  - -> `[21]` (*Player: "“I won't allow regular citizens to come in here. What's n..."*)
  - -> `[28]` (*Player: ""It's not my favorite idea. But if it helps with the elec..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "“I say I'm ready for my close-up.”"]** — Mówca: **Player**
> "“I say I'm ready for my close-up.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Petr Vectern: "“That's the spirit!”"*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“It's a good plan. Let's do it.”"]** — Mówca: **Player**
> "“It's a good plan. Let's do it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Petr Vectern: "“Thanks! You won't regret it.""*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“I won't allow regular citizens to come in here. What's next? Tourists roaming the halls of the Palace?”"]** — Mówca: **Player**
> "“I won't allow regular citizens to come in here. What's next? Tourists roaming the halls of the Palace?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Petr Vectern: "“Fine, I get it. I'll look into other strategies.”"*)

### Węzeł `[22]`
Mówca: **Petr Vectern**
> "“Those changes you ordered to the Supreme Court have been implemented.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Petr Vectern: "“The Old Guard is gone. Purged. The now ex-Justices are r..."*)

### Węzeł `[23]`
Mówca: **Petr Vectern**
> "“That's the spirit!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Petr Vectern: "“I'll notify the filming crew.”"*)

### Węzeł `[24]`
Mówca: **Petr Vectern**
> "“But good riddance! It's about time we got rid of those dinosaurs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Petr Vectern: "“The new Chief Justice elected by the Court is mostly an ..."*)

### Węzeł `[25]`
Mówca: **Petr Vectern**
> "“Fine, I get it. I'll look into other strategies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Campaign_ExtraBudget == true"*)

### Węzeł `[26]`
Mówca: **Petr Vectern**
> "“But who cares? The dinosaurs are gone. We finally have some fresh blood on the bench.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Petr Vectern: "“The new Chief Justice elected by the Court is mostly an ..."*)

### Węzeł `[27]`
Mówca: **Petr Vectern**
> "“Thanks! You won't regret it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Petr Vectern: "“I'll notify the filming crew.”"*)

### Węzeł `[28]`
**[WYBÓR GRACZA: ""It's not my favorite idea. But if it helps with the election, I guess I have no choice.""]** — Mówca: **Player**
> ""It's not my favorite idea. But if it helps with the election, I guess I have no choice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Petr Vectern: "“That's the spirit!”"*)

### Węzeł `[29]`
Mówca: **Petr Vectern**
> "“I'll notify the filming crew.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 3"*)

### Węzeł `[30]`
Mówca: **Petr Vectern**
> "“We can only hope he isn't as smart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "He closed the folder and put away the documents."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 3`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.PoliticalOverview2_TvAd = true"*)

### Węzeł `[32]`
Mówca: **Narrator**
> "He flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Petr Vectern: "“Those changes you ordered to the Supreme Court have been..."*)

### Węzeł `[33]`
Mówca: **Petr Vectern**
> "“Symon told me that he's almost done with the new economic plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Petr Vectern: "“He said he still needs some time with it. Personally, I ..."*)

### Węzeł `[34]`
Mówca: **Petr Vectern**
> "“He said he still needs some time with it. Personally, I think he's just trying to avoid human contact for as long as possible, but what do I know?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Petr Vectern: "“At any rate, he will schedule a meeting soon to go over ..."*)

### Węzeł `[35]`
Mówca: **Petr Vectern**
> "“At any rate, he will schedule a meeting soon to go over our options.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: "“Tell him to be quick. Our administration depends on it.”"*)
  - -> `[38]` (*Player: "“Symon can pull it off. I'm sure. He has never failed me ..."*)
  - -> `[39]` (*Player: "“I will be expecting good ideas and even better outcomes.”"*)
  - -> `[36]` (*Player: "“This better be good. For his own good.”"*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“This better be good. For his own good.”"]** — Mówca: **Player**
> "“This better be good. For his own good.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Petr Vectern: "“I'm sure he'll deliver. But I'll go pester him anyway.""*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“Tell him to be quick. Our administration depends on it.”"]** — Mówca: **Player**
> "“Tell him to be quick. Our administration depends on it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Petr Vectern: "“I'll let him know.”"*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Symon can pull it off. I'm sure. He has never failed me before.”"]** — Mówca: **Player**
> "“Symon can pull it off. I'm sure. He has never failed me before.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Petr Vectern: "“Oh, I trust his capabilities. Although I'd never ask him..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“I will be expecting good ideas and even better outcomes.”"]** — Mówca: **Player**
> "“I will be expecting good ideas and even better outcomes.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Petr Vectern: "“I'm sure he'll deliver.”"*)

### Węzeł `[40]`
Mówca: **Petr Vectern**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "He flipped the page."*)

### Węzeł `[41]`
Mówca: **Petr Vectern**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "He flipped the page."*)

### Węzeł `[42]`
Mówca: **Petr Vectern**
> "“I'm sure he'll deliver.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[43]`
Mówca: **Narrator**
> "He flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Petr Vectern: "“Those changes you ordered to the Supreme Court have been..."*)

### Węzeł `[44]`
Mówca: **Petr Vectern**
> "“I'll let him know.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“This is bad. He's just the same as Orso Hawker.""]** — Mówca: **Player**
> "“This is bad. He's just the same as Orso Hawker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Petr Vectern), `[198]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Petr Vectern: "“We can only hope he isn't as smart.""*)

### Węzeł `[46]`
Mówca: **Petr Vectern**
> "“Oh, I trust his capabilities. Although I'd never ask him for dating advice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "“Excellent news. Our man made it.”"]** — Mówca: **Player**
> "“Excellent news. Our man made it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Petr Vectern: ""We're not the only ones who are happy about it, I can te..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Let's hope he is better than Orso.”"]** — Mówca: **Player**
> "“Let's hope he is better than Orso.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Petr Vectern: "“Who isn't?""*)

### Węzeł `[49]`
Mówca: **Petr Vectern**
> "“I'm sure he'll deliver. But I'll go pester him anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Petr Vectern: "“It's a big step forward, definitely.""*)

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
  - -> `[58]` (*Petr Vectern: "“To begin with, your changes to the USP manifesto have ca..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Party_Conservative == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Conservative"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Liberal == true"*)

### Węzeł `[54]`
Mówca: **Narrator**
> "He pulled out a few documents from a briefcase and laid them on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Focus_Campaign == true"*)

### Węzeł `[55]`
Mówca: **Petr Vectern**
> "“He is certainly going to be loyal to us, and that will only help us going forward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Petr Vectern: "“More importantly, though, Heron Garaci has been selected..."*)

### Węzeł `[56]`
Mówca: **Petr Vectern**
> "“More importantly, though, Heron Garaci has been selected as the new Chief Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true"*)
  - -> `[112]` (*Player: "“Let's hope Heron is better than Orso.”"*)
  - -> `[125]` (*Player: "“This is an important milestone for Sordish democracy.”"*)
  - -> `[45]` (*Player: "“This is bad. He's just the same as Orso Hawker.""*)

### Węzeł `[57]`
Mówca: **Petr Vectern**
> "“Mr. Didier Meye has now begun his duty as a Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Petr Vectern: "“He is certainly going to be loyal to us, and that will o..."*)

### Węzeł `[58]`
Mówca: **Petr Vectern**
> "“To begin with, your changes to the USP manifesto have caused quite the commotion among the reformist wing of the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Petr Vectern: "“I'm not particularly excited about them either -- I thou..."*)

### Węzeł `[59]`
Mówca: **Petr Vectern**
> "“Those changes you ordered to the Supreme Court have been implemented.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Petr Vectern: "“Mr. Didier Meye has now begun his duty as a Justice.”"*)

### Węzeł `[60]`
Mówca: **Petr Vectern**
> "“I'm not particularly excited about them either -- I thought we got elected to shake things up. But you know I'm behind you either way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Petr Vectern: "“Anyway, some of the reformist MPs have decided to quit t..."*)

### Węzeł `[61]`
Mówca: **Petr Vectern**
> "“Anyway, some of the reformist MPs have decided to quit the party. 13 to be exact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Petr Vectern: "“Their places have been filled with people more aligned w..."*)

### Węzeł `[62]`
Mówca: **Petr Vectern**
> ""We're not the only ones who are happy about it, I can tell you that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[63]`
Mówca: **Petr Vectern**
> "“Their places have been filled with people more aligned with the new manifesto.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: "“As I expected. We don't need anyone who won't stay by ou..."*)
  - -> `[65]` (*Player: "“It was an unfortunate and necessary sacrifice.”"*)
  - -> `[64]` (*Player: "“So they decided to betray me and the party. They will se..."*)
  - -> `[67]` (*Player: "“What do you think about it?”"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“So they decided to betray me and the party. They will see their mistakes one day.”"]** — Mówca: **Player**
> "“So they decided to betray me and the party. They will see their mistakes one day.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Petr Vectern), `[72]` (Petr Vectern), `[74]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Petr Vectern: "“If you say so, Mr. President.”"*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“It was an unfortunate and necessary sacrifice.”"]** — Mówca: **Player**
> "“It was an unfortunate and necessary sacrifice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Petr Vectern), `[72]` (Petr Vectern), `[74]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Petr Vectern: "“If you say so, Mr. President.”"*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“As I expected. We don't need anyone who won't stay by our side.”"]** — Mówca: **Player**
> "“As I expected. We don't need anyone who won't stay by our side.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Petr Vectern), `[72]` (Petr Vectern), `[74]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Petr Vectern: "“I agree.""*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "“What do you think about it?”"]** — Mówca: **Player**
> "“What do you think about it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Petr Vectern), `[72]` (Petr Vectern), `[74]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Petr Vectern: "“Well, the new manifesto was never going to make everyone..."*)

### Węzeł `[68]`
Mówca: **Petr Vectern**
> "“Good news for us, if you ask me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player: "“Can we trust him?”"*)
  - -> `[47]` (*Player: "“Excellent news. Our man made it.”"*)
  - -> `[48]` (*Player: "“Let's hope he is better than Orso.”"*)
  - -> `[50]` (*Player: "“This is an important milestone for Sordish democracy.”"*)

### Węzeł `[69]`
Mówca: **Petr Vectern**
> "“Who isn't?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[70]`
Mówca: **Petr Vectern**
> "“If you say so, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[71]`
Mówca: **Petr Vectern**
> "“Well, the new manifesto was never going to make everyone happy. We'll get by.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[72]`
Mówca: **Petr Vectern**
> "“Their places have been filled with people more aligned with our new direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: "“As I expected. We don't need anyone who won't stay by ou..."*)
  - -> `[65]` (*Player: "“It was an unfortunate and necessary sacrifice.”"*)
  - -> `[64]` (*Player: "“So they decided to betray me and the party. They will se..."*)
  - -> `[67]` (*Player: "“What do you think about it?”"*)

### Węzeł `[73]`
Mówca: **Petr Vectern**
> "“To begin with, your changes to the USP manifesto have caused quite the commotion among the reformist wing of the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Petr Vectern: "“Some of the conservative MPs have decided to quit the US..."*)

### Węzeł `[74]`
Mówca: **Petr Vectern**
> "“Their places have been filled with people more aligned with the new direction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: "“As I expected. We don't need anyone who won't stay by ou..."*)
  - -> `[65]` (*Player: "“It was an unfortunate and necessary sacrifice.”"*)
  - -> `[64]` (*Player: "“So they decided to betray me and the party. They will se..."*)
  - -> `[67]` (*Player: "“What do you think about it?”"*)

### Węzeł `[75]`
Mówca: **Petr Vectern**
> "“Some of the conservative MPs have decided to quit the USP. 26 to be exact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Petr Vectern: "“Their places have been filled with people more aligned w..."*)

### Węzeł `[76]`
Mówca: **Petr Vectern**
> "“It's a big step forward, definitely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[77]`
Mówca: **Petr Vectern**
> "“Those changes you ordered to the Supreme Court have been implemented.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Petr Vectern: "“Ovid Grecer has now begun his duty as a Justice.”"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_ExperiencedJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_ExperiencedJustice == true)"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_ExperiencedJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_ExperiencedJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Petr Vectern: "“Moving on...”"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_ExperiencedJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_ExperiencedJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_LoyalJustice == true"*)

### Węzeł `[81]`
Mówca: **Petr Vectern**
> "“Anyway, some of the reformist MPs are quitting the party. 21, to be exact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Petr Vectern: "“Their places have been filled with people more aligned w..."*)

### Węzeł `[82]`
Mówca: **Petr Vectern**
> "“It's definitely a big step forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Liberal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Liberal == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Party_Liberal == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Liberal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Liberal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Petr Vectern: "“To begin with, your changes to the USP manifesto have ca..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Party_Liberal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Liberal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Socialist == true"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Socialist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Socialist == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Party_Socialist == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Socialist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Petr Vectern: "“To begin with, your changes to the USP manifesto have ca..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Party_Socialist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Ultranationalist == true"*)

### Węzeł `[89]`
Mówca: **Petr Vectern**
> "“Who isn't?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Ultranationalist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Party_Ultranationalist == true"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Party_Ultranationalist == true)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Party_Ultranationalist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Petr Vectern: "“To begin with, your changes to the USP manifesto have ca..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Party_Ultranationalist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Party_Ultranationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[93]`
Mówca: **Petr Vectern**
> "“He doesn't seem to have any ulterior motives, unlike most people around here. I'm hopeful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Campaign_ExtraBudget == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Campaign_ExtraBudget == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Campaign_ExtraBudget == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Campaign_ExtraBudget == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Campaign_ExtraBudget"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Petr Vectern: "“One more thing while we're on the subject...""*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Campaign_ExtraBudget == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Campaign_ExtraBudget"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[97]`
Mówca: **Narrator**
> "He flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Petr Vectern: "“Those changes you ordered to the Supreme Court have been..."*)

### Węzeł `[98]`
Mówca: **Petr Vectern**
> "“One more thing while we're on the subject...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Petr Vectern: "“The mayors were thrilled with your decision to provide t..."*)

### Węzeł `[99]`
Mówca: **Petr Vectern**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "He flipped the page."*)

### Węzeł `[100]`
Mówca: **Petr Vectern**
> "“The mayors were thrilled with your decision to provide them with extra funding to assist with the campaign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Petr Vectern: "“This will definitely boost our popularity.”"*)

### Węzeł `[101]`
Mówca: **Petr Vectern**
> "“I don't know about that. He's basically Orso in a different robe with better hair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "He closed the folder and put away the documents."*)

### Węzeł `[102]`
Mówca: **Petr Vectern**
> "“This will definitely boost our popularity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player: "“I hope the money went into the right place instead of th..."*)
  - -> `[105]` (*Player: "“Excellent. We need all the help we can get.""*)
  - -> `[106]` (*Player: "“Good work.”"*)

### Węzeł `[103]`
Mówca: **Narrator**
> "He flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Petr Vectern: "“Those changes you ordered to the Supreme Court have been..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "“I hope the money went into the right place instead of their pockets.”"]** — Mówca: **Player**
> "“I hope the money went into the right place instead of their pockets.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Petr Vectern: "“If the mayors are happy, does it matter?""*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "“Excellent. We need all the help we can get.""]** — Mówca: **Player**
> "“Excellent. We need all the help we can get.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Petr Vectern: "“Agreed.”"*)

### Węzeł `[106]`
**[WYBÓR GRACZA: "“Good work.”"]** — Mówca: **Player**
> "“Good work.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Petr Vectern: "“Thank you. You know I'm trying my best.""*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Petr Vectern: "“It's definitely a big step forward.""*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "“Let's hope he will be better than Orso.”"]** — Mówca: **Player**
> "“Let's hope he will be better than Orso.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Petr Vectern: "“Who isn't?""*)

### Węzeł `[109]`
**[WYBÓR GRACZA: "“Can he be trusted?”"]** — Mówca: **Player**
> "“Can he be trusted?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Petr Vectern: "“He doesn't seem to have any ulterior motives, unlike mos..."*)

### Węzeł `[110]`
Mówca: **Petr Vectern**
> "“If the mayors are happy, does it matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 3;"*)

### Węzeł `[111]`
Mówca: **Petr Vectern**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 3;"*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "“Let's hope Heron is better than Orso.”"]** — Mówca: **Player**
> "“Let's hope Heron is better than Orso.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Petr Vectern), `[198]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Petr Vectern: "“He's basically Orso in a different robe with better hair..."*)

### Węzeł `[113]`
Mówca: **Petr Vectern**
> "“Thank you. You know I'm trying my best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 3;"*)

### Węzeł `[114]`
Mówca: **Petr Vectern**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "He flipped the page."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_LoyalJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_LoyalJustice == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_LoyalJustice == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_LoyalJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_LoyalJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Petr Vectern: "“Moving on...”"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_LoyalJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_LoyalJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_OldGuardReplaced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_OldGuardReplaced == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_OldGuardReplaced == true)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_OldGuardReplaced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Petr Vectern: "“Moving on...”"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_OldGuardReplaced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_Shuffled == true"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_Shuffled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_Shuffled == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_Shuffled == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_Shuffled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Petr Vectern: "“Moving on...”"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_Shuffled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "He closed the folder and put away the documents."*)

### Węzeł `[124]`
Mówca: **Petr Vectern**
> "“He's got a long, illustrious and boring career in law spanning over 30 years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: "“Can he be trusted?”"*)
  - -> `[108]` (*Player: "“Let's hope he will be better than Orso.”"*)
  - -> `[107]` (*Player: "“This is an important milestone for Sordish democracy.”"*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "“This is an important milestone for Sordish democracy.”"]** — Mówca: **Player**
> "“This is an important milestone for Sordish democracy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Petr Vectern), `[198]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Petr Vectern: "“I don't know about that. He's basically Orso in a differ..."*)

### Węzeł `[126]`
Mówca: **Petr Vectern**
> "“You trust him? I wouldn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "He closed the folder and put away the documents."*)

### Węzeł `[127]`
Mówca: **Petr Vectern**
> "“The new Chief Justice elected by the Court is mostly an unknown figure in politics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Petr Vectern: "“His name is Ovid Grecer.”"*)

### Węzeł `[128]`
Mówca: **Petr Vectern**
> "“To begin with, your changes to the USP manifesto have caused quite the commotion within the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Petr Vectern: "“We're losing MPs on both sides. 26 from the conservative..."*)

### Węzeł `[129]`
Mówca: **Petr Vectern**
> "“Their places have been filled with people more aligned with our new direction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: "“As I expected. We don't need anyone who won't stay by ou..."*)
  - -> `[65]` (*Player: "“It was an unfortunate and necessary sacrifice.”"*)
  - -> `[64]` (*Player: "“So they decided to betray me and the party. They will se..."*)
  - -> `[67]` (*Player: "“What do you think about it?”"*)

### Węzeł `[130]`
Mówca: **Petr Vectern**
> "“We're losing MPs on both sides. 26 from the conservative wing, 13 reformers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Petr Vectern: "“Their places have been filled with people more aligned w..."*)

### Węzeł `[131]`
Mówca: **Petr Vectern**
> "“His name is Ovid Grecer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Petr Vectern: "“He's got a long, illustrious and boring career in law sp..."*)

### Węzeł `[132]`
Mówca: **Petr Vectern**
> "“He's basically Orso in a different robe with better hair. But we'll see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "He closed the folder and put away the documents."*)

### Węzeł `[133]`
**[WYBÓR GRACZA: "“Excellent news. I am glad to see him elected.”"]** — Mówca: **Player**
> "“Excellent news. I am glad to see him elected.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true`
- **Kontekst wejściowy (poprzednik):** `[56]` (Petr Vectern), `[198]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Petr Vectern: "“You trust him? I wouldn't.""*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_GloriaJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_GloriaJustice == true)"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_GloriaJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Petr Vectern: "“Moving on...”"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_GloriaJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_OldGuardReplaced == true"*)

### Węzeł `[137]`
Mówca: **Petr Vectern**
> "“Ovid Grecer has now begun his duty as a Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Petr Vectern: "“Seems like his long and boring history of upholding the ..."*)

### Węzeł `[138]`
Mówca: **Petr Vectern**
> "“Seems like his long and boring history of upholding the law did the trick. The Court elected him Chief Justice right after his appointment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Petr Vectern: "“Good news for us, if you ask me.""*)

### Węzeł `[139]`
**[WYBÓR GRACZA: "“Can we trust him?”"]** — Mówca: **Player**
> "“Can we trust him?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Petr Vectern: "“I'd trust him a lot more than, say, Lucian. To give a co..."*)

### Węzeł `[140]`
Mówca: **Petr Vectern**
> "“I'd trust him a lot more than, say, Lucian. To give a completely random example.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)

### Węzeł `[141]`
Mówca: **Petr Vectern**
> "“Those changes you ordered to the Supreme Court have been implemented.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Petr Vectern: "“The honorable Ms. Gloria Tory has now begun her duty as ..."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "He flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Petr Vectern: "“Those changes you ordered to the Supreme Court have been..."*)

### Węzeł `[143]`
Mówca: **Petr Vectern**
> "“Moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "He flipped the page."*)

### Węzeł `[144]`
Mówca: **Petr Vectern**
> "“I think we both know what she brings to the table.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Petr Vectern: "“More importantly, though, Heron Garaci has been selected..."*)

### Węzeł `[145]`
Mówca: **Petr Vectern**
> "“The honorable Ms. Gloria Tory has now begun her duty as a Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Petr Vectern: "“I think we both know what she brings to the table.”"*)

### Węzeł `[146]`
Mówca: **Narrator**
> "He closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Petr Vectern: "“That is all for the court updates.”"*)

### Węzeł `[147]`
Mówca: **Petr Vectern**
> "“That is all for the court updates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[148]`
Mówca: **Narrator**
> "He closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Petr Vectern: "“That is all for the court updates.”"*)

### Węzeł `[149]`
Mówca: **Petr Vectern**
> "“That is all for the court updates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[150]`
Mówca: **Narrator**
> "He closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Petr Vectern: "“That is all for the court updates.”"*)

### Węzeł `[151]`
Mówca: **Petr Vectern**
> "“That is all for the court updates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "He closed the folder and put away the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Petr Vectern: "“Next on the docket...""*)

### Węzeł `[153]`
Mówca: **Petr Vectern**
> "“Next on the docket...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true ..."*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Detained_FrensRicter == tru..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Petr Vectern: "“I have some updates from the Assembly.”"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Detained_FrensRicter == true || BaseGame.Turn07_SecretState_Kill_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[157]`
Mówca: **Petr Vectern**
> "“I have some updates from the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Petr Vectern: "“As you know, the... *absence* of Frens Ricter left the P..."*)

### Węzeł `[158]`
Mówca: **Petr Vectern**
> "“As you know, the... *absence* of Frens Ricter left the PFJP in a state of turmoil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Petr Vectern: "“In short, they've been running around like a chicken wit..."*)

### Węzeł `[159]`
Mówca: **Petr Vectern**
> "“In short, they've been running around like a chicken with its head cut off.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Petr Vectern: "“Or at least they were, until yesterday's PFJP congress.”"*)

### Węzeł `[160]`
Mówca: **Petr Vectern**
> "“Or at least they were, until yesterday's PFJP congress.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Petr Vectern: "“Here, take a look.”"*)

### Węzeł `[161]`
Mówca: **Petr Vectern**
> "“Here, take a look.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "He handed me an official report from the PFJP."*)

### Węzeł `[162]`
Mówca: **Narrator**
> "He handed me an official report from the PFJP."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Petr Vectern: "“It seems they've selected a new leader. Manoly Suheil.”"*)

### Węzeł `[163]`
Mówca: **Petr Vectern**
> "“It seems they've selected a new leader. Manoly Suheil.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[164]`
Mówca: **Petr Vectern**
> "“I don't know how she was able to get that far in the PFJP, but one thing's for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Petr Vectern: "“She is popular both in the Assembly and among the people..."*)

### Węzeł `[165]`
Mówca: **Petr Vectern**
> "“She is popular both in the Assembly and among the people. Not bad-looking, either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Petr Vectern: "“We shouldn't underestimate her.”"*)

### Węzeł `[166]`
Mówca: **Petr Vectern**
> "“We shouldn't underestimate her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player: "“'Not bad-looking?' Haven't you learned anything?""*)
  - -> `[168]` (*Player: "“What can she do when Frens couldn't do anything?”"*)
  - -> `[169]` (*Player: ""Hypothetically, what if she were to meet the same fate a..."*)
  - -> `[170]` (*Player: "“Don't be alarmed. We have nothing to worry about.”"*)

### Węzeł `[167]`
**[WYBÓR GRACZA: "“'Not bad-looking?' Haven't you learned anything?""]** — Mówca: **Player**
> "“'Not bad-looking?' Haven't you learned anything?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Petr Vectern: "“Lighten up, Mr. President. It was a joke.""*)

### Węzeł `[168]`
**[WYBÓR GRACZA: "“What can she do when Frens couldn't do anything?”"]** — Mówca: **Player**
> "“What can she do when Frens couldn't do anything?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Petr Vectern), `[250]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Petr Vectern: "“If she can tap into Frens's base, she will have as much ..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA: ""Hypothetically, what if she were to meet the same fate as Frens?""]** — Mówca: **Player**
> ""Hypothetically, what if she were to meet the same fate as Frens?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Petr Vectern), `[250]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Opposition == true"*)

### Węzeł `[170]`
**[WYBÓR GRACZA: "“Don't be alarmed. We have nothing to worry about.”"]** — Mówca: **Player**
> "“Don't be alarmed. We have nothing to worry about.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Petr Vectern), `[250]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Petr Vectern: "“Better safe than sorry.”"*)

### Węzeł `[171]`
Mówca: **Petr Vectern**
> "“Better safe than sorry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[172]`
Mówca: **Petr Vectern**
> "“Don't you still have your investigation going? Maybe they'll dig up some dirt on her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[173]`
Mówca: **Petr Vectern**
> "“If she can tap into Frens's base, she will have as much power as him. We will be watching her moves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[174]`
Mówca: **Petr Vectern**
> "“Lighten up, Mr. President. It was a joke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Detained_KesaroKibener == t..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Petr Vectern: "“I've received multiple reports that the NFP has chosen a..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Detained_KesaroKibener == true || BaseGame.Turn07_SecretState_Kill_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true  or  Variable["BaseGame.Turn07_SecretState_Kill_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[178]`
Mówca: **Petr Vectern**
> "“I've received multiple reports that the NFP has chosen a new leader following the, uh, 'untimely leave' of Kesaro Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Petr Vectern: "“You've met him. Remus Holstron, the 'Iron Wall'. Kibener..."*)

### Węzeł `[179]`
Mówca: **Petr Vectern**
> "“You've met him. Remus Holstron, the 'Iron Wall'. Kibener's former right-hand man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Player: "“What else can you tell me about him?""*)
  - -> `[242]` (*Player: "“Say no more. I know *all* about him.""*)

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“What else can you tell me about him?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Petr Vectern: "“As a die-hard Young Sords member, he was recruited by Ke..."*)

### Węzeł `[181]`
Mówca: **Petr Vectern**
> "“As a die-hard Young Sords member, he was recruited by Kesaro himself during the coup when he was still in the military.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Petr Vectern: "“Not a lot of fun at parties, I would guess.""*)

### Węzeł `[182]`
Mówca: **Petr Vectern**
> "“Not a lot of fun at parties, I would guess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Petr Vectern: "“Some say that he's an even bigger anti-Bludish zealot th..."*)

### Węzeł `[183]`
Mówca: **Petr Vectern**
> "“Some say that he's an even bigger anti-Bludish zealot than Kesaro.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Petr Vectern: "“Not to mention that he's practically worshipped among th..."*)

### Węzeł `[184]`
**[WYBÓR GRACZA: "“It's time to bring down the 'Iron Wall'.”"]** — Mówca: **Player**
> "“It's time to bring down the 'Iron Wall'.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Petr Vectern), `[243]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Petr Vectern: "“I agree. It's a stupid nickname.""*)

### Węzeł `[185]`
**[WYBÓR GRACZA: "“He doesn't scare me. I have dealt with much worse.”"]** — Mówca: **Player**
> "“He doesn't scare me. I have dealt with much worse.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Petr Vectern), `[243]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Petr Vectern: "“It's better to be on the side of caution.”"*)

### Węzeł `[186]`
**[WYBÓR GRACZA: "“Make sure he never becomes a big problem then.”"]** — Mówca: **Player**
> "“Make sure he never becomes a big problem then.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Petr Vectern), `[243]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Petr Vectern: "“I'll try.”"*)

### Węzeł `[187]`
**[WYBÓR GRACZA: "“He can never *ever* hope to reach Kesaro's level.""]** — Mówca: **Player**
> "“He can never *ever* hope to reach Kesaro's level.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Petr Vectern), `[243]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Petr Vectern: "“Frankly, I could never stand either of them. But you're ..."*)

### Węzeł `[188]`
Mówca: **Petr Vectern**
> "“Not to mention that he's practically worshipped among the Young Sords.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Petr Vectern: "“He comes with a baked-in base and foundation.”"*)

### Węzeł `[189]`
Mówca: **Petr Vectern**
> "“He comes with a baked-in base and foundation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Petr Vectern: "“I can tell you right now he's going to be a problem.”"*)

### Węzeł `[190]`
Mówca: **Petr Vectern**
> "“I can tell you right now he's going to be a problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Player: "“It's time to bring down the 'Iron Wall'.”"*)
  - -> `[185]` (*Player: "“He doesn't scare me. I have dealt with much worse.”"*)
  - -> `[186]` (*Player: "“Make sure he never becomes a big problem then.”"*)
  - -> `[187]` (*Player: "“He can never *ever* hope to reach Kesaro's level.""*)

### Węzeł `[191]`
Mówca: **Petr Vectern**
> "“Frankly, I could never stand either of them. But you're probably right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[192]`
Mówca: **Petr Vectern**
> "“I'll try.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[193]`
Mówca: **Petr Vectern**
> "“It's better to be on the side of caution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[194]`
Mówca: **Petr Vectern**
> "“I agree. It's a stupid nickname.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true"*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player: "“Excellent news. I am glad to see him elected.”"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Heron_PromisedChiefJustice"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[198]`
Mówca: **Petr Vectern**
> "“More importantly, though, Heron Garaci has been selected as the new Chief Justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Heron_PromisedChiefJustice == true"*)
  - -> `[112]` (*Player: "“Let's hope Heron is better than Orso.”"*)
  - -> `[125]` (*Player: "“This is an important milestone for Sordish democracy.”"*)
  - -> `[45]` (*Player: "“This is bad. He's just the same as Orso Hawker.""*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[200]`
Mówca: **Petr Vectern**
> "“I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_ExperiencedJustice == true"*)

### Węzeł `[201]`
Mówca: **Petr Vectern**
> "“To begin with, your changes to the USP manifesto have caused quite the commotion among the reformist wing of the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Petr Vectern: "“I'm not particularly excited about them either, but you ..."*)

### Węzeł `[202]`
Mówca: **Petr Vectern**
> "“I'm not particularly excited about them either, but you know I'm behind you either way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Petr Vectern: "“Anyway, some of the reformist MPs are quitting the party..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Investigate_Opposition == true"*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Investigate_Opposition == true)"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Investigate_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Investigate_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Petr Vectern: "“Don't you still have your investigation going? Maybe the..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Investigate_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Investigate_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Petr Vectern: "“Hypothetically, that might look a little too suspicious.""*)

### Węzeł `[206]`
Mówca: **Petr Vectern**
> "“Hypothetically, that might look a little too suspicious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == tru..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.PoliticalOverview2_TvAd = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.PoliticalOverview2_TvAd"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Campaign_ExtraBudget == true"*)

### Węzeł `[208]`
Mówca: **Petr Vectern**
> ""The indefinitely delayed case of Ishval Ersen against Governor Phelix Bron has finally reached to a conclusion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == false && BaseGame.Berg..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Petr Vectern: ""I must say... He already gave a landmark ruling as his f..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "He closed the folder and put away the documents."*)

### Węzeł `[212]`
Mówca: **Petr Vectern**
> ""He was found guilty of abusing his powers to enable discrimination against the citizens of Sordland and found guilty of breaking the constitutional laws of the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Petr Vectern: ""He was promptly stripped from his duties as governor of ..."*)

### Węzeł `[213]`
Mówca: **Petr Vectern**
> ""I must say... He already gave a landmark ruling as his first act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Petr Vectern: ""The indefinitely delayed case of Ishval Ersen against Go..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == tru..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Petr Vectern: ""He was found guilty of abusing his powers to enable disc..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Petr Vectern: ""He was found guilty of abusing his powers to enable disc..."*)

### Węzeł `[217]`
Mówca: **Petr Vectern**
> ""He was found guilty of abusing his powers to enable discrimination against the citizens of Sordland which directly goes against the new Constitution. He was therefore found guilty of breaking the constitutional laws of the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Petr Vectern: ""He was promptly stripped from his duties as governor of ..."*)

### Węzeł `[218]`
Mówca: **Petr Vectern**
> ""He was promptly stripped from his duties as governor of the Special Zone and was sent directly to Antel Rock Prison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Petr Vectern: ""As for his replacement, the Court argued that since it w..."*)

### Węzeł `[219]`
Mówca: **Petr Vectern**
> ""As for his replacement, the Court argued that since it was an extraordinary circumstance and the elections are already nearby, a transitionary council must take charge of the governance of the Special Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Petr Vectern: ""According to the decisions made in that council, Ishval ..."*)

### Węzeł `[220]`
Mówca: **Petr Vectern**
> ""According to the decisions made in that council, Ishval Ersen was already picked as the most suitable governor choice, arguably as a Bludish rights activist from Bergia who became extremely famous for bringing up the issues to the governmental level.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true && BaseGame...."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Player: ""This is great news, Petr!""*)
  - -> `[222]` (*Player: ""I'm already liking Chief Justice Grecer.""*)
  - -> `[225]` (*Player: ""This is a great development for Bludish rights in Sordla..."*)
  - -> `[224]` (*Player: ""Honestly, I don't even want to hear about Bergia anymore.""*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm already liking Chief Justice Grecer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Petr Vectern: ""Me too.""*)

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is great news, Petr!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Petr Vectern: ""Exactly.""*)

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, I don't even want to hear about Bergia anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Petr Vectern: ""Sure.""*)

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is a great development for Bludish rights in Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Petr Vectern: ""Exactly.""*)

### Węzeł `[226]`
Mówca: **Petr Vectern**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Petr Vectern: ""In any case...""*)

### Węzeł `[227]`
Mówca: **Petr Vectern**
> ""Me too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Petr Vectern: ""In any case...""*)

### Węzeł `[228]`
Mówca: **Petr Vectern**
> ""Sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Petr Vectern: ""In any case...""*)

### Węzeł `[229]`
Mówca: **Petr Vectern**
> ""In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "He closed the folder and put away the documents."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia..."*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == false && BaseGame.Berg..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "Jump to: [Petr Vectern: ""I must say... He already gave a..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == false && BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == false  and  Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "He closed the folder and put away the documents."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Petr Vectern: ""I must say... He already gave a la..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Petr Vectern: ""I must say... He already gave a landmark ruling as his f..."*)

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
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Say no more. I know *all* about him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Petr Vectern: "“Then you know he's going to be a problem.”"*)

### Węzeł `[243]`
Mówca: **Petr Vectern**
> "“Then you know he's going to be a problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Player: "“It's time to bring down the 'Iron Wall'.”"*)
  - -> `[185]` (*Player: "“He doesn't scare me. I have dealt with much worse.”"*)
  - -> `[186]` (*Player: "“Make sure he never becomes a big problem then.”"*)
  - -> `[187]` (*Player: "“He can never *ever* hope to reach Kesaro's level.""*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Petr Vectern: ""We met her before, remember?""*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Petr Vectern: "“I don't know how she was able to get that far in the PFJ..."*)

### Węzeł `[247]`
Mówca: **Petr Vectern**
> ""We met her before, remember?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Player: ""Vaguely. What can you tell me about her?""*)
  - -> `[248]` (*Player: ""Yes, say no more. I know all about her.""*)

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, say no more. I know all about her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Petr Vectern: "“Then you know we shouldn't underestimate her.”"*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Vaguely. What can you tell me about her?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Petr Vectern: "“I don't know how she was able to get that far in the PFJ..."*)

### Węzeł `[250]`
Mówca: **Petr Vectern**
> "“Then you know we shouldn't underestimate her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Player: "“What can she do when Frens couldn't do anything?”"*)
  - -> `[169]` (*Player: ""Hypothetically, what if she were to meet the same fate a..."*)
  - -> `[170]` (*Player: "“Don't be alarmed. We have nothing to worry about.”"*)
