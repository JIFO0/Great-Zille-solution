# Rizia/Turn 1/EnT_CouncilBriefing

- **ID konwersacji:** `289`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Rizia/Turn_01/289_EnT_CouncilBriefing.md`
- **Liczba węzłów dialogowych:** 294
- **Liczba wyborów gracza:** 56

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[70]** Laurento Esquibel
- **[73]** Lucita Azaro
- **[75]** Manus Sazon
- **[79]** Vina Toras
- **[80]** Elena Werner
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Decision_Turn01_CoronationParty_Large`
- `RiziaDLC.Decision_Turn01_CoronationParty_Medium`
- `RiziaDLC.Focus_Economy_Diversification`
- `RiziaDLC.Focus_Economy_Mixed`
- `RiziaDLC.Prologue_FalloutWithDad`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_Monqiz_Rebuild`
- `RiziaDLC.Prologue_StayedOnCouncil`
- `RiziaDLC.Turn01_WineWithHugo`
- `RiziaDLC.Vina_OnCouncil`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Enable_Policy_RD_Economy_PublicRailTransportSubsidies`
- `RiziaDLC.Enable_Policy_RD_Economy_PublicSeaTransportSubsidies`
- `RiziaDLC.Enable_Policy_RD_Economy_PublicTransportInfraInvestment`
- `RiziaDLC.Enable_Policy_RD_Welfare_IncreasedWelfareFunding`
- `RiziaDLC.Enable_Policy_RD_Welfare_NaturalizationForForeigners`
- `RiziaDLC.PersonalValue_FunnyKing`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Relations_Manus_IgnoreFirstMeeting`
- `RiziaDLC.Relations_Manus_ThreatenFirstMeeting`
- `RiziaDLCSupport.News_Turn01_RH_Celebrations_Large`
- `RiziaDLCSupport.News_Turn01_RH_Celebrations_Medium`
- `RiziaDLCSupport.News_Turn01_RH_Celebrations_Small`
- `RiziaDLCSupport.News_Turn01_RH_ConsecrationOfKing`
- `RiziaDLCSupport.Reports_Turn01_Plavo_ConsecrationOfKingFest`
- `RiziaDLCSupport.Reports_Turn01_Topes_UnveilingLegacyOfRezenid`

### Skoki między-konwersacyjne:
- Węzeł `[48]` -> **[290] Rizia/Turn 1/Economy and Treasury Section** (../Turn_01/290_Economy_and_Treasury_Section.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **""Welcome to the council, Duchess.""** | `[4]` **Narrator**: "My uncle looked chastised." | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[9]` **Vina Toras**: ""Please don't mind me, Duchess A..."<br>`[57]` **Lucita Azaro**: ""My father always spoke highly o..."<br>*(oraz 1 innych odgałęzień)* |
| `[6]` | **""The Princess is part of this court now. I advise you to be more respectful.""** | `[49]` **Lucita Azaro**: ""Oh, hello, Princess Vina. Your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Lucita Azaro**: ""Apologies to you both. I meant ..." |
| `[35]` | **""Thank you, Ms. Werner and Mr. Esquibel. I look forward to working with you.""** | `[25]` **Elena Werner**: ""Your reputation precedes you, Y..."<br>`[26]` **Elena Werner**: ""I must say it makes me proud to..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Elena Werner**: ""And work we will. We have so mu..." |
| `[36]` | **""I don't need your approval, Ms. Werner. If anything, you're the one who should be..."** | `[15]` **Elena Werner**: ""I must say it makes me proud to..."<br>`[25]` **Elena Werner**: ""Your reputation precedes you, Y..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Elena Werner**: ""Of-- of course. I misspoke. For..." |
| `[37]` | **""This formality doesn't suit any of us. Elena, Laurento, it's great to see you bot..."** | `[15]` **Elena Werner**: ""I must say it makes me proud to..."<br>`[26]` **Elena Werner**: ""I must say it makes me proud to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Laurento Esquibel**: ""Protocol is protocol, Your Maje..." |
| `[42]` | **""I doubt my father ever praised me so highly. But thank you.""** | `[34]` **Elena Werner**: ""Yes, welcome, Your Majesty. If ..." | `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true` | *Brak zmian stanu* | `[276]` **Narrator**: "They looked at each other." |
| `[43]` | **""No need for flattery. With your years of experience, I'm the one who should be bo..."** | `[15]` **Elena Werner**: ""I must say it makes me proud to..."<br>`[25]` **Elena Werner**: ""Your reputation precedes you, Y..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Laurento Esquibel**: ""That's far too kind of you, You..." |
| `[45]` | **""She's right. Fix your shirt, Hugo.""** | `[4]` **Narrator**: "My uncle looked chastised." | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[58]` **Narrator**: "Hugo hastily rebuttoned his shirt." |
| `[54]` | **"Salute her."** | `[4]` **Narrator**: "My uncle looked chastised." | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[170]` **Lucita Azaro**: ""A military man. How could I for..."<br>`[206]` **Lucita Azaro**: ""Your form is slightly off. But ..." |
| `[55]` | **""Ask her yourself, Duchess Azaro.""** | `[49]` **Lucita Azaro**: ""Oh, hello, Princess Vina. Your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Lucita Azaro**: ""Oh, excuse me. What brings you ..." |
| `[56]` | **""House Toras accepts your congratulations.""** | `[4]` **Narrator**: "My uncle looked chastised." | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[174]` **Lucita Azaro**: ""I'm sorry I couldn't make it to..." |
| `[86]` | **""Duke Sazon, I presume?""** | `[84]` **Narrator**: "His face matched the photograph ..."<br>`[85]` **Narrator**: "His face matched the photograph ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Narrator**: "He smiled nervously." |
| `[87]` | **"Ignore him and keep walking."** | `[84]` **Narrator**: "His face matched the photograph ..."<br>`[85]` **Narrator**: "His face matched the photograph ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Manus_IgnoreFirstMeeting"] =...` | `[94]` **Vina Toras**: ""I think he wanted to talk to yo..."<br>`[106]` **Narrator**: "Even after I passed him, the sen..." |
| `[88]` | **""What are you doing here? Explain yourself.""** | `[84]` **Narrator**: "His face matched the photograph ..."<br>`[85]` **Narrator**: "His face matched the photograph ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Narrator**: "The man's face flushed. He looke..." |
| `[98]` | **""I don't talk to traitors.""** | `[94]` **Vina Toras**: ""I think he wanted to talk to yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Narrator**: "We kept walking. Oddly enough, I..." |
| `[99]` | **""Then he should request a formal audience with me like everyone else.""** | `[94]` **Vina Toras**: ""I think he wanted to talk to yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Narrator**: "We kept walking. Oddly enough, I..." |
| `[100]` | **""I don't have time. It's not kingly to be late, right?""** | `[94]` **Vina Toras**: ""I think he wanted to talk to yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Narrator**: "We kept walking. Oddly enough, I..." |
| `[101]` | **""I'm still a little drunk. I didn't want to embarrass myself.""** | `[94]` **Vina Toras**: ""I think he wanted to talk to yo..." | `Variable["RiziaDLC.Turn01_WineWithHugo"] == true` | *Brak zmian stanu* | `[105]` **Narrator**: "We kept walking. Oddly enough, I..." |
| `[109]` | **""The son of a traitor.""** | `[93]` **Manus Sazon**: ""I suppose you already know who ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Narrator**: "His fingers almost unconsciously..." |
| `[110]` | **""The man who would topple the monarchy.""** | `[93]` **Manus Sazon**: ""I suppose you already know who ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Narrator**: "His fingers almost unconsciously..." |
| `[111]` | **""Yes. It's brave of you to approach me.""** | `[93]` **Manus Sazon**: ""I suppose you already know who ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Narrator**: "He tugged at his suit lapel." |
| `[112]` | **""You're the traitor's son.""** | `[92]` **Manus Sazon**: ""I hold no land, Your Majesty. B..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Narrator**: "His fingers almost unconsciously..." |
| `[113]` | **""So you're the man who would topple the monarchy.""** | `[92]` **Manus Sazon**: ""I hold no land, Your Majesty. B..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Narrator**: "His fingers almost unconsciously..." |
| `[114]` | **""It's brave of you to approach me.""** | `[92]` **Manus Sazon**: ""I hold no land, Your Majesty. B..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Narrator**: "He tugged at his suit lapel." |
| `[129]` | **""I wish we could stay and talk, but the Princess and I must be going. Until next t..."** | `[128]` **Manus Sazon**: ""I know. A pleasure to make your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Manus Sazon**: ""I look forward to it, Your Maje..." |
| `[130]` | **""Don't speak to him, Vina. We're going to be late.""** | `[128]` **Manus Sazon**: ""I know. A pleasure to make your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Narrator**: "Vina's face fell." |
| `[131]` | **""You are to stay away from me, Mr. Sazon. And even further away from my daughter.""** | `[128]` **Manus Sazon**: ""I know. A pleasure to make your..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Manus_ThreatenFirstMeeting"]...` | `[133]` **Narrator**: "His face went pale." |
| `[132]` | **""I'm not uninterested in your proposition. But you'll have to request a formal aud..."** | `[128]` **Manus Sazon**: ""I know. A pleasure to make your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Manus Sazon**: ""I understand. Looking forward t..." |
| `[143]` | **""Nice, my foot. That man has all kinds of ulterior motives.""** | `[142]` **Vina Toras**: ""He was only trying to be nice.""<br>`[146]` **Vina Toras**: ""He seems nice."" | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Manus Sazon"); ;` | `[162]` **Narrator**: "We continued towards the council..." |
| `[144]` | **""I mean it, Vina. I don't want you talking to him.""** | `[142]` **Vina Toras**: ""He was only trying to be nice."" | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Manus Sazon"); ;` | `[162]` **Narrator**: "We continued towards the council..." |
| `[145]` | **""He shouldn't be cornering the King of Rizia on his way to an important meeting. T..."** | `[142]` **Vina Toras**: ""He was only trying to be nice."" | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Manus Sazon"); ;` | `[162]` **Narrator**: "We continued towards the council..." |
| `[147]` | **""Don't get too smitten. He's the opposition, after all.""** | `[146]` **Vina Toras**: ""He seems nice."" | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Manus Sazon"); ;` | `[162]` **Narrator**: "We continued towards the council..." |
| `[148]` | **""He's friendlier than I expected. I could imagine working together.""** | `[146]` **Vina Toras**: ""He seems nice."" | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Manus Sazon"); ;` | `[162]` **Narrator**: "We continued towards the council..." |
| `[150]` | **""I wish I could stay and talk, but I must be going. Until next time.""** | `[149]` **Narrator**: "He looked at me expectantly." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Manus Sazon**: ""I look forward to it, Your Maje..." |
| `[151]` | **""I'm not interested. If you'll excuse me, I'm going to be late.""** | `[149]` **Narrator**: "He looked at me expectantly." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Manus Sazon**: ""That's perfectly fine. I hope t..." |
| `[152]` | **""Don't approach me outside of work again, Mr. Sazon. This is my only warning.""** | `[149]` **Narrator**: "He looked at me expectantly." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Manus_ThreatenFirstMeeting"]...` | `[154]` **Narrator**: "His face went pale." |
| `[153]` | **""I'm not un-interested. But you'll have to request a formal audience with me like ..."** | `[149]` **Narrator**: "He looked at me expectantly." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Manus Sazon**: ""I understand. Looking forward t..." |
| `[178]` | **""I know the General. He's got some fight left in him yet.""** | `[179]` **Narrator**: "She was trying to be flippant, b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Narrator**: "Lucita smiled with pride." |
| `[180]` | **""This must be a difficult time for you. Let me know if there's anything I can do.""** | `[177]` **Narrator**: "She was trying to be flippant, b..."<br>`[179]` **Narrator**: "She was trying to be flippant, b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Narrator**: "The corners of her mouth twitche..." |
| `[181]` | **""No time for pleasantries. Where are the others?""** | `[177]` **Narrator**: "She was trying to be flippant, b..."<br>`[179]` **Narrator**: "She was trying to be flippant, b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Lucita Azaro**: ""Two of them were right behind m..." |
| `[182]` | **""I hope he heals swiftly. I was counting on his expertise as a councilor.""** | `[177]` **Narrator**: "She was trying to be flippant, b..."<br>`[179]` **Narrator**: "She was trying to be flippant, b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Narrator**: "She frowned briefly." |
| `[221]` | **""History shall know me as Romus the Fiscally Responsible.""** | `[220]` **Elena Werner**: ""But with a king of your caliber..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Elena Werner**: ""Very catchy, Your Majesty."" |
| `[222]` | **""Your hard work during my father's decline is to be commended.""** | `[220]` **Elena Werner**: ""But with a king of your caliber..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[226]` **Elena Werner**: ""Thank you. It was indeed quite ..." |
| `[223]` | **""Please leave my father out of this. I'd prefer to be judged on my own merits, not..."** | `[220]` **Elena Werner**: ""But with a king of your caliber..." | `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true` | *Brak zmian stanu* | `[231]` **Elena Werner**: ""Understandable, Your Majesty. I..." |
| `[224]` | **""Do not speak ill of His Majesty. He did the best he could in the face of his many..."** | `[220]` **Elena Werner**: ""But with a king of your caliber..." | `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false` | *Brak zmian stanu* | `[230]` **Elena Werner**: ""That is undoubtedly true, Your ..." |
| `[251]` | **""Of course, Duke Sazon.""** | `[93]` **Manus Sazon**: ""I suppose you already know who ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Narrator**: "He tugged at his suit lapel." |
| `[252]` | **""It's good to see you here in Porte Drazon.""** | `[92]` **Manus Sazon**: ""I hold no land, Your Majesty. B..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Narrator**: "He tugged at his suit lapel." |
| `[263]` | **""This information is invaluable, Elena. I appreciate your insights.""** | `[259]` **Elena Werner**: ""Lastly, energy management poses..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Elena Werner**: ""Frankly, I'm glad to see you ta..." |
| `[264]` | **""That'll be a long way off in the future. I have more pressing worries at the mome..."** | `[259]` **Elena Werner**: ""Lastly, energy management poses..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Elena Werner**: ""Frankly, I'm glad to see you ta..." |
| `[265]` | **""I have full confidence in your ability to handle these matters.""** | `[259]` **Elena Werner**: ""Lastly, energy management poses..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Elena Werner**: ""Frankly, I'm glad to see you ta..." |
| `[266]` | **""That's very good to know. I'll make my decisions accordingly.""** | `[259]` **Elena Werner**: ""Lastly, energy management poses..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Elena Werner**: ""Frankly, I'm glad to see you ta..." |
| `[267]` | **""Please elaborate.""** | `[261]` **Elena Werner**: ""I'd like to discuss several eco..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Elena Werner**: ""The first point to consider is ..." |
| `[268]` | **""We've covered enough ground for today. Let's adjourn the meeting soon.""** | `[261]` **Elena Werner**: ""I'd like to discuss several eco..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Elena Werner**: ""Very well. It seems like you've..." |
| `[269]` | **""I'm accustomed to handling unexpected challenges. A detailed explanation isn't ne..."** | `[261]` **Elena Werner**: ""I'd like to discuss several eco..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Elena Werner**: ""Very well. It seems like you've..." |
| `[270]` | **""She's here to learn from the King, as I learned from my father.""** | `[49]` **Lucita Azaro**: ""Oh, hello, Princess Vina. Your ..." | `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true` | *Brak zmian stanu* | `[9]` **Vina Toras**: ""Please don't mind me, Duchess A..." |
| `[274]` | **""She's here to receive tutelage from the best minds this kingdom has to offer. You..."** | `[49]` **Lucita Azaro**: ""Oh, hello, Princess Vina. Your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[275]` **Lucita Azaro**: ""I'm flattered."" |

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
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Presiding over their first council as Ki..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Lucita Azaro**
> ""Hugo, Your Grace. Your shirt's buttoned wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "My uncle looked chastised."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "My uncle looked chastised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Welcome to the council, Duchess.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Princess is part of this court now. I advise you to be more respectful.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Lucita Azaro: ""Apologies to you both. I meant no disrespect at all.""*)

### Węzeł `[7]`
Mówca: **Lucita Azaro**
> ""Apologies to you both. I meant no disrespect at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "She gave Vina a broad smile."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "She gave Vina a broad smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Vina Toras: ""Please don't mind me, Duchess Azaro. I'm only here as an..."*)

### Węzeł `[9]`
Mówca: **Vina Toras**
> ""Please don't mind me, Duchess Azaro. I'm only here as an observer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Lucita's eyes darted to the door."*)

### Węzeł `[10]`
Mówca: **Hugo Toras**
> ""Thank you all for joining us. I'm pleased to have the entire council here for this first meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Hugo Toras: ""Well -- not the entire council. The Grand Wiseman is in ..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Lucita Azaro: ""My father always spoke highly of you, Your Majesty. I wi..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Lucita Azaro: ""General Taddeus sends his regards. Or he would if he wer..."*)

### Węzeł `[14]`
Mówca: **Laurento Esquibel**
> ""Your Majesty. It is a pleasure and an honor to be in this room with you once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "Elena nodded. Her businesslike demeanor briefly softened ..."*)

### Węzeł `[15]`
Mówca: **Elena Werner**
> ""I must say it makes me proud to see you in that seat. Between your time on this council and the fine work you did in Valenqiris, I can't think of a better man for the position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player_Romus: ""This formality doesn't suit any of us. Elena, Laurento, ..."*)
  - -> `[36]` (*Player_Romus: ""I don't need your approval, Ms. Werner. If anything, you..."*)
  - -> `[43]` (*Player_Romus: ""No need for flattery. With your years of experience, I'm..."*)

### Węzeł `[16]`
Mówca: **Laurento Esquibel**
> ""Your Majesty. It is a pleasure and an honor to serve on your council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "Elena nodded briskly. Despite her grandmotherly appearanc..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "Lucita's eyes darted to the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lucita Azaro: ""The King and his direct successor spending so much time ..."*)

### Węzeł `[18]`
Mówca: **Lucita Azaro**
> ""The King and his direct successor spending so much time in the same room... I hope the Golden Guard knows what's at stake in keeping these chambers secure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_Rebuild == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_Rebuild == true"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_Rebuild == true)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_Rebuild == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_Rebuild"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Elena Werner: ""I must say it makes me proud to see you in that seat. Be..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_Rebuild == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_Rebuild"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Elena Werner: ""I must say it makes me proud to see you in that seat. If..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_Rebuild == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_Rebuild == true"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_Rebuild == true)"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_Rebuild == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_Rebuild"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Elena Werner: ""Your reputation precedes you, Your Majesty. I've heard m..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_Rebuild == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_Rebuild"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Elena Werner: ""Yes, welcome, Your Majesty. If you're half the young man..."*)

### Węzeł `[25]`
Mówca: **Elena Werner**
> ""Your reputation precedes you, Your Majesty. I've heard marvelous things about the work you did in Valenqiris.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player_Romus: ""I don't need your approval, Ms. Werner. If anything, you..."*)
  - -> `[35]` (*Player_Romus: ""Thank you, Ms. Werner and Mr. Esquibel. I look forward t..."*)
  - -> `[43]` (*Player_Romus: ""No need for flattery. With your years of experience, I'm..."*)

### Węzeł `[26]`
Mówca: **Elena Werner**
> ""I must say it makes me proud to see you in that seat. If you show the same devotion as you did on King Valero's council, you'll make a fine ruler.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player_Romus: ""This formality doesn't suit any of us. Elena, Laurento, ..."*)
  - -> `[36]` (*Player_Romus: ""I don't need your approval, Ms. Werner. If anything, you..."*)
  - -> `[35]` (*Player_Romus: ""Thank you, Ms. Werner and Mr. Esquibel. I look forward t..."*)
  - -> `[43]` (*Player_Romus: ""No need for flattery. With your years of experience, I'm..."*)

### Węzeł `[27]`
Mówca: **Vina Toras**
> ""I wouldn't go that far. But I do hope you'll tell me about your time in Queen Lyza's court one day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Elena Werner: ""I'd love to. There are just a few updates I've got to sh..."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "Vina blushed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Vina Toras: ""I wouldn't go that far. But I do hope you'll tell me abo..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil"*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil)"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Elena looked fondly at Vina."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "Once all the councilors were seated, Hugo began."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "Elena looked fondly at Vina."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Elena Werner: ""I'm pleased to see the young heiress here as well. A new..."*)

### Węzeł `[33]`
Mówca: **Elena Werner**
> ""I'm pleased to see the young heiress here as well. A new Lyza the Great in the making.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "Vina blushed."*)

### Węzeł `[34]`
Mówca: **Elena Werner**
> ""Yes, welcome, Your Majesty. If you're half the young man your father made you out to be, you'll make a fine king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player_Romus: ""I don't need your approval, Ms. Werner. If anything, you..."*)
  - -> `[35]` (*Player_Romus: ""Thank you, Ms. Werner and Mr. Esquibel. I look forward t..."*)
  - -> `[43]` (*Player_Romus: ""No need for flattery. With your years of experience, I'm..."*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == true"*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Ms. Werner and Mr. Esquibel. I look forward to working with you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Elena Werner), `[26]` (Elena Werner), `[34]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Elena Werner: ""And work we will. We have so much ahead of us.""*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't need your approval, Ms. Werner. If anything, you're the one who should be seeking mine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Elena Werner), `[25]` (Elena Werner), `[26]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Elena Werner: ""Of-- of course. I misspoke. Forgive me.""*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This formality doesn't suit any of us. Elena, Laurento, it's great to see you both again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Elena Werner), `[26]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Laurento Esquibel: ""Protocol is protocol, Your Majesty. Even if we've both k..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_FalloutWithDad == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player_Romus: ""I doubt my father ever praised me so highly. But thank y..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_FalloutWithDad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[41]`
Mówca: **Laurento Esquibel**
> ""Protocol is protocol, Your Majesty. Even if we've both known you since you were in diapers.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil"*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I doubt my father ever praised me so highly. But thank you.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Kontekst wejściowy (poprzednik):** `[34]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Narrator: "They looked at each other."*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need for flattery. With your years of experience, I'm the one who should be bowing down to you both.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Elena Werner), `[25]` (Elena Werner), `[26]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Laurento Esquibel: ""That's far too kind of you, Your Majesty. But I hope we ..."*)

### Węzeł `[44]`
Mówca: **Elena Werner**
> ""Of-- of course. I misspoke. Forgive me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Tyrant += 1"*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's right. Fix your shirt, Hugo.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "Hugo hastily rebuttoned his shirt."*)

### Węzeł `[46]`
Mówca: **Laurento Esquibel**
> ""That's far too kind of you, Your Majesty. But I hope we old-timers can be of some assistance to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil"*)

### Węzeł `[47]`
Mówca: **Elena Werner**
> ""I'd love to. There are just a few updates I've got to share with your father first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "Once all the councilors were seated, Hugo began."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "She put on a pair of half-moon glasses, then reached down into her purse, pulled out a thick, leather-bound ledger and flipped it open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[49]`
Mówca: **Lucita Azaro**
> ""Oh, hello, Princess Vina. Your Majesty, may I ask what your daughter is doing here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)
  - -> `[274]` (*Player_Romus: ""She's here to receive tutelage from the best minds this ..."*)
  - -> `[55]` (*Player_Romus: ""Ask her yourself, Duchess Azaro.""*)
  - -> `[6]` (*Player_Romus: ""The Princess is part of this court now. I advise you to ..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucita Azaro: ""Oh, hello, Princess Vina. Your Majesty, may I ask what y..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player_Romus_Italic: "Salute her."*)
  - -> `[56]` (*Player_Romus: ""House Toras accepts your congratulations.""*)
  - -> `[5]` (*Player_Romus: ""Welcome to the council, Duchess.""*)
  - -> `[45]` (*Player_Romus: ""She's right. Fix your shirt, Hugo.""*)

### Węzeł `[53]`
Mówca: **Lucita Azaro**
> ""Please accept House Azaro's formal congratulations on your coronation, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Narrator: "I motioned for her to stand. Her eye was fixated on my un..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "Salute her."]** — Mówca: **Player_Romus_Italic**
> "I raised my hand in a salute. Lucita smiled in approval."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ask her yourself, Duchess Azaro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lucita Azaro: ""Oh, excuse me. What brings you to these chambers, Your H..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House Toras accepts your congratulations.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Lucita Azaro: ""I'm sorry I couldn't make it to the coronation. I heard ..."*)

### Węzeł `[57]`
Mówca: **Lucita Azaro**
> ""My father always spoke highly of you, Your Majesty. I wish he was the one greeting you today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Lucita Azaro: ""He sends his regards. Or he would if he were capable of ..."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "Hugo hastily rebuttoned his shirt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[59]`
Mówca: **Lucita Azaro**
> ""Oh, excuse me. What brings you to these chambers, Your Highness?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "She gave Vina a broad smile."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "As if on cue, I heard the voices of Elena Werner and Laurento Esquibel, my treasurer and the councilor of foreign affairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Elena Werner: ""For Dast's sake, Laurento, you don't need to hold the do..."*)

### Węzeł `[61]`
Mówca: **Elena Werner**
> ""For Dast's sake, Laurento, you don't need to hold the door open for me every single time. I'm not as fragile as I look.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Laurento Esquibel: ""I keep telling you, how could I allow a door to close on..."*)

### Węzeł `[62]`
Mówca: **Laurento Esquibel**
> ""I keep telling you, how could I allow a door to close on such a gorgeous face?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)

### Węzeł `[63]`
Mówca: **Narrator**
> "I remembered their flirtatious routine from my days on my father's council. Nobody knew whether the two of them had actually had an affair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "On seeing me, they dropped the act and assumed a look of ..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_StayedOnCouncil == true)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "I remembered their flirtatious routine from my days on my..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_StayedOnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "As the two senior councilors stepped in, they immediately..."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "As the two senior councilors stepped in, they immediately dropped the flirtatious routine and assumed a look of deference."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "Laurento smoothly removed his fedora, revealing a well-oi..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "It was late afternoon when Vina and I headed back to the chambers for the first council meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_WineWithHugo == true"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "It was late afternoon when Vina and I headed back to the ..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "It was late afternoon when I headed back to the chambers ..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "It was late afternoon when I headed back to the chambers for the first council meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_WineWithHugo == true"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_WineWithHugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_WineWithHugo == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn01_WineWithHugo == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_WineWithHugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn01_WineWithHugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "The day was sweltering, and a lingering haze from the win..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn01_WineWithHugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn01_WineWithHugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "The day was sweltering, and the morning meeting had left ..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "The day was sweltering, and a lingering haze from the wine we’d shared before lunch clouded my mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "I was about to be inundated with updates and reports from..."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "I was about to be inundated with updates and reports from my councilors -- I only hoped I could keep it all straight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[78]`
Mówca: **Narrator**
> "The day was sweltering, and the morning meeting had left me drained. I was glad I’d turned down Hugo’s offer of wine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[79]`
Mówca: **Narrator**
> "As we made our way through the palace gardens, an unsettling sense of being watched crept over me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "Then, suddenly, I caught sight of a young man standing by..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "As we made our way through the palace gardens, an unsettl..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "As I crossed the palace gardens, I had the feeling I was ..."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "As I crossed the palace gardens, I had the feeling I was being watched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Narrator: "Then, suddenly, I caught sight of a young man standing by..."*)

### Węzeł `[84]`
Mówca: **Narrator**
> "His face matched the photograph Hugo had shown me that morning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player_Romus: ""Duke Sazon, I presume?""*)
  - -> `[88]` (*Player_Romus: ""What are you doing here? Explain yourself.""*)
  - -> `[87]` (*Player_Romus_Italic: "Ignore him and keep walking."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "His face matched the photograph Hugo had shown me that morning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player_Romus: ""Duke Sazon, I presume?""*)
  - -> `[88]` (*Player_Romus: ""What are you doing here? Explain yourself.""*)
  - -> `[87]` (*Player_Romus_Italic: "Ignore him and keep walking."*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duke Sazon, I presume?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Narrator), `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "He smiled nervously."*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "Ignore him and keep walking."]** — Mówca: **Player_Romus_Italic**
> "I ignored Manus Sazon and continued towards the council chambers."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Narrator), `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_IgnoreFirstMeeting = true"*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you doing here? Explain yourself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Narrator), `[85]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "The man's face flushed. He looked down at the ground."*)

### Węzeł `[89]`
Mówca: **Manus Sazon**
> ""Pardon me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Manus Sazon: ""I suppose you already know who I am.""*)

### Węzeł `[90]`
Mówca: **Narrator**
> "The man's face flushed. He looked down at the ground."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Manus Sazon: ""Pardon me, Your Majesty.""*)

### Węzeł `[91]`
Mówca: **Narrator**
> "He smiled nervously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Manus Sazon: ""I hold no land, Your Majesty. But you may use the title ..."*)

### Węzeł `[92]`
Mówca: **Manus Sazon**
> ""I hold no land, Your Majesty. But you may use the title if you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player_Romus: ""You're the traitor's son.""*)
  - -> `[113]` (*Player_Romus: ""So you're the man who would topple the monarchy.""*)
  - -> `[114]` (*Player_Romus: ""It's brave of you to approach me.""*)
  - -> `[252]` (*Player_Romus: ""It's good to see you here in Porte Drazon.""*)

### Węzeł `[93]`
Mówca: **Manus Sazon**
> ""I suppose you already know who I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Player_Romus: ""Of course, Duke Sazon.""*)
  - -> `[109]` (*Player_Romus: ""The son of a traitor.""*)
  - -> `[110]` (*Player_Romus: ""The man who would topple the monarchy.""*)
  - -> `[111]` (*Player_Romus: ""Yes. It's brave of you to approach me.""*)

### Węzeł `[94]`
Mówca: **Vina Toras**
> ""I think he wanted to talk to you, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player_Romus: ""I don't talk to traitors.""*)
  - -> `[99]` (*Player_Romus: ""Then he should request a formal audience with me like ev..."*)
  - -> `[100]` (*Player_Romus: ""I don't have time. It's not kingly to be late, right?""*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_WineWithHugo == true"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Vina Toras: ""I think he wanted to talk to you, Father.""*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "Even after I passed him, the sensation that someone was w..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't talk to traitors.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "We kept walking. Oddly enough, I still felt like someone ..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then he should request a formal audience with me like everyone else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "We kept walking. Oddly enough, I still felt like someone ..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have time. It's not kingly to be late, right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "We kept walking. Oddly enough, I still felt like someone ..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still a little drunk. I didn't want to embarrass myself.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn01_WineWithHugo"] == true`
- **Kontekst wejściowy (poprzednik):** `[94]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "We kept walking. Oddly enough, I still felt like someone ..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_WineWithHugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_WineWithHugo == true"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn01_WineWithHugo == true)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_WineWithHugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn01_WineWithHugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player_Romus: ""I'm still a little drunk. I didn't want to embarrass mys..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn01_WineWithHugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn01_WineWithHugo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[105]`
Mówca: **Narrator**
> "We kept walking. Oddly enough, I still felt like someone had their eyes on us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "I looked back for just long enough to see a flash of gold..."*)

### Węzeł `[106]`
Mówca: **Narrator**
> "Even after I passed him, the sensation that someone was watching me continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "I looked back for just long enough to see a flash of gold..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "We entered the chambers, where Hugo was already waiting for us. No sooner had we sat down than a brief rap came at the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "Without waiting for an answer, Lucita Azaro rushed in."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "I entered the chambers, where Hugo was already waiting for me. No sooner had I sat down than a brief rap came on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "Without waiting for an answer, Lucita Azaro rushed in."*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The son of a traitor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "His fingers almost unconsciously began loosening his tie."*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The man who would topple the monarchy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "His fingers almost unconsciously began loosening his tie."*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. It's brave of you to approach me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "He tugged at his suit lapel."*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're the traitor's son.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "His fingers almost unconsciously began loosening his tie."*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you're the man who would topple the monarchy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "His fingers almost unconsciously began loosening his tie."*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's brave of you to approach me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "He tugged at his suit lapel."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "His fingers almost unconsciously began loosening his tie."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Manus Sazon: ""I don't know what you've heard. But I assure you that's ..."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "He tugged at his suit lapel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Manus Sazon: ""I wanted to introduce myself before our first official m..."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "His fingers almost unconsciously began loosening his tie."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Manus Sazon: ""I-- well, in a nutshell, yes.""*)

### Węzeł `[118]`
Mówca: **Manus Sazon**
> ""I wanted to introduce myself before our first official meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Manus Sazon: ""I may be the leader of the opposition, but I'm not your ..."*)

### Węzeł `[119]`
Mówca: **Manus Sazon**
> ""I don't know what you've heard. But I assure you that's not my aim.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Manus Sazon: ""I wanted to introduce myself before our first official m..."*)

### Węzeł `[120]`
Mówca: **Manus Sazon**
> ""I-- well, in a nutshell, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Manus Sazon: ""I wanted to introduce myself before our first official m..."*)

### Węzeł `[121]`
Mówca: **Manus Sazon**
> ""I may be the leader of the opposition, but I'm not your enemy. If you and I establish a dialogue, I believe we can work wonders for this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "Vina gave him an encouraging smile."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "He looked at me expectantly."*)

### Węzeł `[125]`
Mówca: **Narrator**
> "Vina gave him an encouraging smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Vina Toras: ""How lovely of you to say that. I'm Vina Toras, by the way.""*)

### Węzeł `[126]`
Mówca: **Vina Toras**
> ""How lovely of you to say that. I'm Vina Toras, by the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "He resisted the urge to laugh."*)

### Węzeł `[127]`
Mówca: **Narrator**
> "He resisted the urge to laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Manus Sazon: ""I know. A pleasure to make your acquaintance.""*)

### Węzeł `[128]`
Mówca: **Manus Sazon**
> ""I know. A pleasure to make your acquaintance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player_Romus: ""I'm not uninterested in your proposition. But you'll hav..."*)
  - -> `[129]` (*Player_Romus: ""I wish we could stay and talk, but the Princess and I mu..."*)
  - -> `[130]` (*Player_Romus: ""Don't speak to him, Vina. We're going to be late.""*)
  - -> `[131]` (*Player_Romus: ""You are to stay away from me, Mr. Sazon. And even furthe..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish we could stay and talk, but the Princess and I must be going. Until next time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Manus Sazon: ""I look forward to it, Your Majesty. Your Highness.""*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't speak to him, Vina. We're going to be late.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "Vina's face fell."*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are to stay away from me, Mr. Sazon. And even further away from my daughter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_ThreatenFirstMeeting = true"*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not uninterested in your proposition. But you'll have to request a formal audience with me like everyone else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Manus Sazon: ""I understand. Looking forward to it, Your Majesty. Your ..."*)

### Węzeł `[133]`
Mówca: **Narrator**
> "His face went pale."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Manus Sazon: ""I-- I'm sorry, Your Majesty. I won't trouble you again.""*)

### Węzeł `[134]`
Mówca: **Manus Sazon**
> ""I-- I'm sorry, Your Majesty. I won't trouble you again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "He rushed away. Vina watched him go, disappointed."*)

### Węzeł `[135]`
Mówca: **Manus Sazon**
> ""I look forward to it, Your Majesty. Your Highness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "Vina waved as we walked away."*)

### Węzeł `[136]`
Mówca: **Narrator**
> "Vina waved as we walked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Vina Toras: ""He seems nice.""*)

### Węzeł `[137]`
Mówca: **Manus Sazon**
> ""I understand. Looking forward to it, Your Majesty. Your Highness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "Vina waved as we walked away."*)

### Węzeł `[138]`
Mówca: **Vina Toras**
> ""But--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Manus Sazon: ""That's perfectly fine. I hope to speak again when it's m..."*)

### Węzeł `[139]`
Mówca: **Manus Sazon**
> ""That's perfectly fine. I hope to speak again when it's more convenient, Your Majesty. Your Highness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "He rushed away. Vina watched him go, disappointed."*)

### Węzeł `[140]`
Mówca: **Narrator**
> "Vina's face fell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Vina Toras: ""But--""*)

### Węzeł `[141]`
Mówca: **Narrator**
> "He rushed away. Vina watched him go, disappointed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Vina Toras: ""He was only trying to be nice.""*)

### Węzeł `[142]`
Mówca: **Vina Toras**
> ""He was only trying to be nice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player_Romus: ""Nice, my foot. That man has all kinds of ulterior motives.""*)
  - -> `[144]` (*Player_Romus: ""I mean it, Vina. I don't want you talking to him.""*)
  - -> `[145]` (*Player_Romus: ""He shouldn't be cornering the King of Rizia on his way t..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nice, my foot. That man has all kinds of ulterior motives.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Vina Toras), `[146]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon");"*)

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I mean it, Vina. I don't want you talking to him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon");"*)

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He shouldn't be cornering the King of Rizia on his way to an important meeting. The kid needs to learn decorum.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon");"*)

### Węzeł `[146]`
Mówca: **Vina Toras**
> ""He seems nice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player_Romus: ""He's friendlier than I expected. I could imagine working..."*)
  - -> `[147]` (*Player_Romus: ""Don't get too smitten. He's the opposition, after all.""*)
  - -> `[143]` (*Player_Romus: ""Nice, my foot. That man has all kinds of ulterior motives.""*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't get too smitten. He's the opposition, after all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon");"*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's friendlier than I expected. I could imagine working together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon");"*)

### Węzeł `[149]`
Mówca: **Narrator**
> "He looked at me expectantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player_Romus: ""I'm not un-interested. But you'll have to request a form..."*)
  - -> `[150]` (*Player_Romus: ""I wish I could stay and talk, but I must be going. Until..."*)
  - -> `[151]` (*Player_Romus: ""I'm not interested. If you'll excuse me, I'm going to be..."*)
  - -> `[152]` (*Player_Romus: ""Don't approach me outside of work again, Mr. Sazon. This..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish I could stay and talk, but I must be going. Until next time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Manus Sazon: ""I look forward to it, Your Majesty.""*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not interested. If you'll excuse me, I'm going to be late.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Manus Sazon: ""That's perfectly fine. I hope to speak again when it's m..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't approach me outside of work again, Mr. Sazon. This is my only warning.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_ThreatenFirstMeeting = true"*)

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not un-interested. But you'll have to request a formal audience with me like everyone else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Manus Sazon: ""I understand. Looking forward to it, Your Majesty.""*)

### Węzeł `[154]`
Mówca: **Narrator**
> "His face went pale."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Manus Sazon: ""I-- I'm sorry, Your Majesty. I won't trouble you again.""*)

### Węzeł `[155]`
Mówca: **Manus Sazon**
> ""I-- I'm sorry, Your Majesty. I won't trouble you again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "He rushed away."*)

### Węzeł `[156]`
Mówca: **Manus Sazon**
> ""I look forward to it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "He gave a small wave as he walked away."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "He gave a small wave as he walked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon");"*)

### Węzeł `[158]`
Mówca: **Manus Sazon**
> ""I understand. Looking forward to it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "He gave a small wave as he walked away."*)

### Węzeł `[159]`
Mówca: **Manus Sazon**
> ""That's perfectly fine. I hope to speak again when it's more convenient, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "He rushed away."*)

### Węzeł `[160]`
Mówca: **Narrator**
> "He rushed away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon");"*)

### Węzeł `[161]`
Mówca: **Narrator**
> "I continued towards the council chambers. Oddly enough, I still felt like someone had their eyes on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "I looked back for just long enough to see a flash of gold..."*)

### Węzeł `[162]`
Mówca: **Narrator**
> "We continued towards the council chambers. Oddly enough, I still felt like someone had their eyes on us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "I looked back for just long enough to see a flash of gold..."*)

### Węzeł `[163]`
Mówca: **Narrator**
> "Without waiting for an answer, Lucita Azaro rushed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "The new war and security councilor was younger than I'd i..."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "The new war and security councilor was younger than I'd imagined. She carried herself with a mix of regal elegance and soldierly authority."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Lucita Azaro: ""Gentlemen. Pardon my interruption.""*)

### Węzeł `[165]`
Mówca: **Lucita Azaro**
> ""Gentlemen. Pardon my interruption.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "She bowed towards me."*)

### Węzeł `[166]`
Mówca: **Narrator**
> "She bowed towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lucita Azaro: ""Please accept House Azaro's formal congratulations on yo..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Lucita Azaro: ""A military man. How could I forget?""*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Lucita Azaro: ""Your form is slightly off. But an admirable effort.""*)

### Węzeł `[170]`
Mówca: **Lucita Azaro**
> ""A military man. How could I forget?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Lucita Azaro: ""My father always spoke highly of you, Your Majesty. I wi..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Vina Toras: ""Please don't mind me, Duchess Azaro. I'm only here as an..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[174]`
Mówca: **Lucita Azaro**
> ""I'm sorry I couldn't make it to the coronation. I heard everything ran smoothly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[175]`
Mówca: **Lucita Azaro**
> ""General Taddeus sends his regards. Or he would if he were capable of speaking in full sentences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "She was trying to be flippant, but I could sense emotion ..."*)

### Węzeł `[176]`
Mówca: **Lucita Azaro**
> ""He sends his regards. Or he would if he were capable of speaking in full sentences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "She was trying to be flippant, but I could sense emotion ..."*)

### Węzeł `[177]`
Mówca: **Narrator**
> "She was trying to be flippant, but I could sense emotion behind her words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player_Romus: ""No time for pleasantries. Where are the others?""*)
  - -> `[182]` (*Player_Romus: ""I hope he heals swiftly. I was counting on his expertise..."*)
  - -> `[180]` (*Player_Romus: ""This must be a difficult time for you. Let me know if th..."*)

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know the General. He's got some fight left in him yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "Lucita smiled with pride."*)

### Węzeł `[179]`
Mówca: **Narrator**
> "She was trying to be flippant, but I could sense emotion behind her words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Player_Romus: ""I know the General. He's got some fight left in him yet.""*)
  - -> `[181]` (*Player_Romus: ""No time for pleasantries. Where are the others?""*)
  - -> `[182]` (*Player_Romus: ""I hope he heals swiftly. I was counting on his expertise..."*)
  - -> `[180]` (*Player_Romus: ""This must be a difficult time for you. Let me know if th..."*)

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This must be a difficult time for you. Let me know if there's anything I can do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Narrator), `[179]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "The corners of her mouth twitched downward."*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No time for pleasantries. Where are the others?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Narrator), `[179]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Lucita Azaro: ""Two of them were right behind me on the stairs.""*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope he heals swiftly. I was counting on his expertise as a councilor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Narrator), `[179]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "She frowned briefly."*)

### Węzeł `[183]`
Mówca: **Narrator**
> "Lucita smiled with pride."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Lucita Azaro: ""The others should be right behind me.""*)

### Węzeł `[184]`
Mówca: **Narrator**
> "She frowned briefly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Lucita Azaro: ""I'll do my best to serve in his stead.""*)

### Węzeł `[185]`
Mówca: **Lucita Azaro**
> ""Two of them were right behind me on the stairs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "As if on cue, I heard the voices of Elena Werner and Laur..."*)

### Węzeł `[186]`
Mówca: **Lucita Azaro**
> ""The others should be right behind me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "As if on cue, I heard the voices of Elena Werner and Laur..."*)

### Węzeł `[187]`
Mówca: **Lucita Azaro**
> ""I'll do my best to serve in his stead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Lucita Azaro: ""The others should be right behind me.""*)

### Węzeł `[188]`
Mówca: **Narrator**
> "The corners of her mouth twitched downward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Lucita Azaro: ""I'm not a porcelain doll, Your Majesty. My ability to pe..."*)

### Węzeł `[189]`
Mówca: **Lucita Azaro**
> ""I'm not a porcelain doll, Your Majesty. My ability to perform my duties is in no way compromised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Lucita Azaro: ""The others should be right behind me.""*)

### Węzeł `[190]`
Mówca: **Narrator**
> "On seeing me, they dropped the act and assumed a look of deference. Laurento smoothly removed his fedora, revealing a well-oiled mane of gray hair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Laurento Esquibel: ""Your Majesty. It is a pleasure and an honor to be in thi..."*)

### Węzeł `[191]`
Mówca: **Narrator**
> "Once all the councilors were seated, Hugo began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Hugo Toras: ""Thank you all for joining us. I'm pleased to have the en..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_IgnoreFirstMeeting = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Manus_IgnoreFirstMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_ThreatenFirstMeeting = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Manus_ThreatenFirstMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "His face went pale."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_ThreatenFirstMeeting = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Manus_ThreatenFirstMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "His face went pale."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Manus Sazon");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Manus Sazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "We continued towards the council chambers. Oddly enough, ..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Manus Sazon");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Manus Sazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "I continued towards the council chambers. Oddly enough, I..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn01_RH_Celebrations_Large = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_Celebrations_Large"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_ConsecrationOfKing = true;..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn01_CoronationParty_Large == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn01_CoronationParty_Large == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn01_CoronationParty_Large == true)"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn01_CoronationParty_Large == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn01_CoronationParty_Large"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_Celebrations_Large = true"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn01_CoronationParty_Large == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn01_CoronationParty_Large"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn01_CoronationParty_Medium == true"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn01_CoronationParty_Medium == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn01_CoronationParty_Medium == true"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn01_CoronationParty_Medium == true)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn01_CoronationParty_Medium == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn01_CoronationParty_Medium"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_Celebrations_Medium = true"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn01_CoronationParty_Medium == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn01_CoronationParty_Medium"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_Celebrations_Small = true"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn01_RH_Celebrations_Medium = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_Celebrations_Medium"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_ConsecrationOfKing = true;..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn01_RH_Celebrations_Small = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_Celebrations_Small"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_ConsecrationOfKing = true;..."*)

### Węzeł `[206]`
Mówca: **Lucita Azaro**
> ""Your form is slightly off. But an admirable effort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[207]`
Mówca: **Narrator**
> "Elena nodded. Her businesslike demeanor briefly softened as she looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_Rebuild == true"*)

### Węzeł `[208]`
Mówca: **Narrator**
> "Laurento smoothly removed his fedora, revealing a well-oiled mane of gray hair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Laurento Esquibel: ""Your Majesty. It is a pleasure and an honor to serve on ..."*)

### Węzeł `[209]`
Mówca: **Narrator**
> "Elena nodded briskly. Despite her grandmotherly appearance, her demeanor was all business."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_Rebuild == true"*)

### Węzeł `[210]`
Mówca: **Narrator**
> "Once all the councilors were seated, Hugo began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Hugo Toras: ""Thank you all for joining us. I'm pleased to have the en..."*)

### Węzeł `[211]`
Mówca: **Hugo Toras**
> ""Well -- not the entire council. The Grand Wiseman is in Plavo, preparing for the upcoming religious ceremony with His Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Hugo Toras: ""But he needn't involve himself in earthly concerns like ..."*)

### Węzeł `[212]`
Mówca: **Hugo Toras**
> ""But he needn't involve himself in earthly concerns like our royal treasury.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "He smiled to himself, then gestured to Elena."*)

### Węzeł `[213]`
Mówca: **Narrator**
> "He smiled to himself, then gestured to Elena."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Elena Werner: ""No, indeed. That's for me to worry about.""*)

### Węzeł `[214]`
Mówca: **Elena Werner**
> ""No, indeed. That's for me to worry about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "She put on a pair of half-moon glasses, then reached down..."*)

### Węzeł `[215]`
Mówca: **Elena Werner**
> ""And work we will. We have so much ahead of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil"*)

### Węzeł `[216]`
Mówca: **Narrator**
> "I looked back for just long enough to see a flash of gold. Titus. Of course."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "We entered the chambers, where Hugo was already waiting f..."*)

### Węzeł `[217]`
Mówca: **Narrator**
> "I looked back for just long enough to see a flash of gold. Titus. Of course."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "I entered the chambers, where Hugo was already waiting fo..."*)

### Węzeł `[218]`
Mówca: **Elena Werner**
> ""Frankly, I'm glad to see you taking such an interest in our financials.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Elena Werner: ""Between myself and the House of Delegates, we were able ..."*)

### Węzeł `[219]`
Mówca: **Elena Werner**
> ""Between myself and the House of Delegates, we were able to keep everything running smoothly in the absence of clear guidance from your father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Elena Werner: ""But with a king of your caliber at the helm, there's no ..."*)

### Węzeł `[220]`
Mówca: **Elena Werner**
> ""But with a king of your caliber at the helm, there's no telling how high we can soar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player_Romus: ""History shall know me as Romus the Fiscally Responsible.""*)
  - -> `[222]` (*Player_Romus: ""Your hard work during my father's decline is to be comme..."*)
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == true"*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""History shall know me as Romus the Fiscally Responsible.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Elena Werner: ""Very catchy, Your Majesty.""*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your hard work during my father's decline is to be commended.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Elena Werner: ""Thank you. It was indeed quite the stressful time for ev..."*)

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please leave my father out of this. I'd prefer to be judged on my own merits, not compared to him.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Kontekst wejściowy (poprzednik):** `[220]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Elena Werner: ""Understandable, Your Majesty. I'm sorry.""*)

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not speak ill of His Majesty. He did the best he could in the face of his many enemies.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[220]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Elena Werner: ""That is undoubtedly true, Your Majesty. I'm sorry.""*)

### Węzeł `[225]`
Mówca: **Elena Werner**
> ""Very catchy, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1"*)

### Węzeł `[226]`
Mówca: **Elena Werner**
> ""Thank you. It was indeed quite the stressful time for everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Elena Werner: ""I think that's enough for today. But we will have to com..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == true"*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_FalloutWithDad == true)"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Player_Romus: ""Please leave my father out of this. I'd prefer to be jud..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_FalloutWithDad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Player_Romus: ""Do not speak ill of His Majesty. He did the best he coul..."*)

### Węzeł `[230]`
Mówca: **Elena Werner**
> ""That is undoubtedly true, Your Majesty. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Elena Werner: ""I think that's enough for today. But we will have to com..."*)

### Węzeł `[231]`
Mówca: **Elena Werner**
> ""Understandable, Your Majesty. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Elena Werner: ""I think that's enough for today. But we will have to com..."*)

### Węzeł `[232]`
Mówca: **Elena Werner**
> ""I think that's enough for today. But we will have to come to a decision regarding our resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Economy_Diversification == true"*)

### Węzeł `[233]`
Mówca: **Elena Werner**
> ""Gold and energy exports have gotten us to where we are today, but if we are to stay relevant and protect our economy from global fluctuations, we need to diversify. I suspect you agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Elena Werner: ""I'll let you think about it, Your Majesty.""*)

### Węzeł `[234]`
Mówca: **Elena Werner**
> ""I'll let you think about it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Hugo Toras: ""Thank you, Ms. Werner. This was indeed enlightening.""*)

### Węzeł `[235]`
Mówca: **Hugo Toras**
> ""Thank you, Ms. Werner. This was indeed enlightening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)

### Węzeł `[236]`
Mówca: **Laurento Esquibel**
> ""A pleasure to share these chambers with you once more, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Lucita Azaro: ""Yes. I'm looking forward to our upcoming security briefi..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_StayedOnCouncil == true)"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Laurento Esquibel: ""A pleasure to share these chambers with you once more, K..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_StayedOnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Laurento Esquibel: ""A pleasure to finally share these chambers with you, Kin..."*)

### Węzeł `[240]`
Mówca: **Laurento Esquibel**
> ""A pleasure to finally share these chambers with you, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Lucita Azaro: ""Yes. I'm looking forward to our upcoming security briefi..."*)

### Węzeł `[241]`
Mówca: **Lucita Azaro**
> ""Yes. I'm looking forward to our upcoming security briefing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[242]`
Mówca: **Narrator**
> "My councilors left. I sat for a few more minutes, reflecting on what Elena and the others had said."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Enable_Policy_RD_Economy_PublicTransportInfraInv..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Lucita Azaro: ""And congratulations on surviving your first council meet..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "My councilors left. I sat for a few more minutes, reflect..."*)

### Węzeł `[246]`
Mówca: **Lucita Azaro**
> ""And congratulations on surviving your first council meeting, Your Highness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Vina Toras: ""I found it fascinating, Your Grace.""*)

### Węzeł `[247]`
Mówca: **Vina Toras**
> ""I found it fascinating, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "They smiled at each other, not altogether sincerely."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[249]`
Mówca: **Narrator**
> "They smiled at each other, not altogether sincerely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "My councilors left. I sat for a few more minutes, reflect..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_UpInTheAir", "R_UpInTheAir_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_UpInTheAir","R_UpInTheAir_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course, Duke Sazon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "He tugged at his suit lapel."*)

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's good to see you here in Porte Drazon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "He tugged at his suit lapel."*)

### Węzeł `[253]`
Mówca: **Narrator**
> "I motioned for her to stand. Her eye was fixated on my uncle's shirt as she raised herself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Lucita Azaro: ""Hugo, Your Grace. Your shirt's buttoned wrong.""*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn01_Topes_UnveilingLegacyOfRezenid = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Topes_UnveilingLegacyOfRezenid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn01_CoronationParty_Large == true"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn01_RH_ConsecrationOfKing = true; RiziaDLCSupport.Reports_Turn01_Plavo_ConsecrationOfKingFest = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_ConsecrationOfKing"] = true;
Variable["RiziaDLCSupport.Reports_Turn01_Plavo_ConsecrationOfKingFest"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Enable_Policy_RD_Economy_PublicTransportInfraInvestment = true;
RiziaDLC.Enable_Policy_RD_Economy_PublicSeaTransportSubsidies = true;
RiziaDLC.Enable_Policy_RD_Economy_PublicRailTransportSubsidies = true;
RiziaDLC.Enable_Policy_RD_Welfare_NaturalizationForForeigners = true;
RiziaDLC.Enable_Policy_RD_Welfare_IncreasedWelfareFunding = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Enable_Policy_RD_Economy_PublicTransportInfraInvestment"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Economy_PublicSeaTransportSubsidies"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Economy_PublicRailTransportSubsidies"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Welfare_NaturalizationForForeigners"] = true;
Variable["RiziaDLC.Enable_Policy_RD_Welfare_IncreasedWelfareFunding"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn01_Topes_UnveilingLegacyOfRez..."*)

### Węzeł `[257]`
Mówca: **Elena Werner**
> ""Secondly, there's the matter of living standards. Improving the quality of life for our citizens naturally leads to higher administrative expenditures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Elena Werner: ""Thirdly, if you do decide to listen to Duchess Azaro and..."*)

### Węzeł `[258]`
Mówca: **Elena Werner**
> ""Thirdly, if you do decide to listen to Duchess Azaro and expand our defense capabilities, keep in mind that the cost of upkeep for our armed forces will rise accordingly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Elena Werner: ""Lastly, energy management poses its own challenges. As w..."*)

### Węzeł `[259]`
Mówca: **Elena Werner**
> ""Lastly, energy management poses its own challenges. As we approach the limits of our grid's capacity, we may incur additional storage costs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Player_Romus: ""This information is invaluable, Elena. I appreciate your..."*)
  - -> `[264]` (*Player_Romus: ""That'll be a long way off in the future. I have more pre..."*)
  - -> `[265]` (*Player_Romus: ""I have full confidence in your ability to handle these m..."*)
  - -> `[266]` (*Player_Romus: ""That's very good to know. I'll make my decisions accordi..."*)

### Węzeł `[260]`
Mówca: **Elena Werner**
> ""The first point to consider is industrial growth. I am all for expanding production and construction, but we should make sure we have the energy to keep our facilities humming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Elena Werner: ""Secondly, there's the matter of living standards. Improv..."*)

### Węzeł `[261]`
Mówca: **Elena Werner**
> ""I'd like to discuss several economic considerations. We should anticipate potential expenses arising from our impending fiscal policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player_Romus: ""Please elaborate.""*)
  - -> `[269]` (*Player_Romus: ""I'm accustomed to handling unexpected challenges. A deta..."*)
  - -> `[268]` (*Player_Romus: ""We've covered enough ground for today. Let's adjourn the..."*)

### Węzeł `[262]`
Mówca: **Narrator**
> "Elena glanced down at her notes, her expression contemplative."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Elena Werner: ""I'd like to discuss several economic considerations. We ..."*)

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This information is invaluable, Elena. I appreciate your insights.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Elena Werner: ""Frankly, I'm glad to see you taking such an interest in ..."*)

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That'll be a long way off in the future. I have more pressing worries at the moment.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Elena Werner: ""Frankly, I'm glad to see you taking such an interest in ..."*)

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have full confidence in your ability to handle these matters.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Elena Werner: ""Frankly, I'm glad to see you taking such an interest in ..."*)

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's very good to know. I'll make my decisions accordingly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Elena Werner: ""Frankly, I'm glad to see you taking such an interest in ..."*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please elaborate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Elena Werner: ""The first point to consider is industrial growth. I am a..."*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've covered enough ground for today. Let's adjourn the meeting soon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Elena Werner: ""Very well. It seems like you've got a good grasp on our ..."*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm accustomed to handling unexpected challenges. A detailed explanation isn't necessary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Elena Werner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Elena Werner: ""Very well. It seems like you've got a good grasp on our ..."*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's here to learn from the King, as I learned from my father.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Kontekst wejściowy (poprzednik):** `[49]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Vina Toras: ""Please don't mind me, Duchess Azaro. I'm only here as an..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_StayedOnCouncil == true)"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_StayedOnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Player_Romus: ""She's here to learn from the King, as I learned from my ..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_StayedOnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's here to receive tutelage from the best minds this kingdom has to offer. Yours included.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Lucita Azaro: ""I'm flattered.""*)

### Węzeł `[275]`
Mówca: **Lucita Azaro**
> ""I'm flattered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "She gave Vina a broad smile."*)

### Węzeł `[276]`
Mówca: **Narrator**
> "They looked at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Elena Werner: ""You are most welcome.""*)

### Węzeł `[277]`
Mówca: **Elena Werner**
> ""You are most welcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Tyrant += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil"*)

### Węzeł `[279]`
Mówca: **Elena Werner**
> ""Very well. It seems like you've got a good grasp on our financials.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Elena Werner: ""Between myself and the House of Delegates, we were able ..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Elena Werner: ""I think that's enough for today. But we will have to com..."*)

### Węzeł `[281]`
Mówca: **Narrator**
> "Then, suddenly, I caught sight of a young man standing by the path."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "His face matched the photograph Hugo had shown me that mo..."*)

### Węzeł `[282]`
Mówca: **Narrator**
> "Then, suddenly, I caught sight of a young man standing by the path."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "His face matched the photograph Hugo had shown me that mo..."*)

### Węzeł `[283]`
Mówca: **Hugo Toras**
> ""Thank you anyway, Ms. Werner. I'll be sure to deliver your reports to His Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_StayedOnCouncil == true"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Briefing Skipped`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Hugo Toras: ""Thank you anyway, Ms. Werner. I'll be sure to deliver yo..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Presiding over their first council as King", "Council Chambers", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Presiding over their first council as King","Council Chambers","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_UpInTheAir", "R_UpInTheAir_Loop");"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Economy_Diversification == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Economy_Diversification == true"*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Economy_Diversification == true)"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Economy_Diversification == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Economy_Diversification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Elena Werner: ""Gold and energy exports have gotten us to where we are t..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Economy_Diversification == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Economy_Diversification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Economy_Mixed == true"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Economy_Mixed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Economy_Mixed == true"*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Economy_Mixed == true)"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Economy_Mixed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Economy_Mixed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Elena Werner: ""While gold and energy exports remain the backbone of our..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Economy_Mixed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Economy_Mixed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Elena Werner: ""If gold and energy exports are to remain the backbone of..."*)

### Węzeł `[292]`
Mówca: **Elena Werner**
> ""While gold and energy exports remain the backbone of our economy, supplementing them with other industries will make us more robust and less vulnerable to global fluctuations. I suspect you agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Elena Werner: ""I'll let you think about it, Your Majesty.""*)

### Węzeł `[293]`
Mówca: **Elena Werner**
> ""If gold and energy exports are to remain the backbone of our economy, we need to focus on finding new sources. Of course, we could also try to develop other industries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Elena Werner: ""I'll let you think about it, Your Majesty.""*)
