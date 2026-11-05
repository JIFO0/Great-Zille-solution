# Sordland/Turn07/NEDAM OR SSC PRIVATISED

- **ID konwersacji:** `133`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/133_NEDAM_OR_SSC_PRIVATISED.md`
- **Liczba węzłów dialogowych:** 227
- **Liczba wyborów gracza:** 25

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[14]** Marcel Koronti
- **[19]** Walter Tusk
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.NedamMiningGroup_Privatization`
- `BaseGame.SordishStateCorporation_Privatization`
- `BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually`
- `BaseGame.Turn07_GrantedShares_WalterTusk`
- `BaseGame.Turn07_MarcelFavor_PrivateTakeover`
- `BaseGameIsolated.Turn07_AcceptedMarcelCar`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.PersonalWealth`
- `BaseGame.Turn07_GrantedShares_MarcelKoronti`
- `BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually`
- `BaseGame.Turn07_GrantedShares_WalterTusk`
- `BaseGameIsolated.Turn07_AcceptedMarcelCar`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[132] Sordland/Turn07/A_OligarchsFinalMeeting** (../Turn_07/132_A_OligarchsFinalMeeting.md), Węzeł `[309]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[11]` | **"“Straight to business, as always.”"** | `[19]` **Walter Tusk**: "“I heard Petr say that you favou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Walter Tusk**: "“As always.”" |
| `[22]` | **"“Thanks for the gift.”"** | `[19]` **Walter Tusk**: "“I heard Petr say that you favou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Walter Tusk**: "“Anytime.”" |
| `[23]` | **"“What do you want in return?”"** | `[19]` **Walter Tusk**: "“I heard Petr say that you favou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Walter Tusk**: "“Hah. Nothing. It's just a token..." |
| `[55]` | **"“I can't accept a luxury car while the people of Sordland go hungry.”"** | `[53]` **Marcel Koronti**: "“It's yours.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Narrator**: "Marcel shrugged." |
| `[56]` | **"“Thank you, Marcel. I can't wait to drive it.""** | `[53]` **Marcel Koronti**: "“It's yours.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Marcel Koronti**: "“I knew you would like it.”" |
| `[57]` | **"“I can't take this.”"** | `[53]` **Marcel Koronti**: "“It's yours.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Marcel Koronti**: "“Of course you can. It's a gift.”" |
| `[65]` | **"“Why are you two showering me with gifts?”"** | `[78]` **Walter Tusk**: "“Me? Walter Tusk?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Walter Tusk**: "“No reason.”" |
| `[80]` | **"“Whatever you want, bribery won't work.”"** | `[78]` **Walter Tusk**: "“Me? Walter Tusk?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Marcel Koronti**: "“This is absolutely no bribe, Mr..." |
| `[83]` | **"“Thank you both. Let's begin the meeting.”"** | `[78]` **Walter Tusk**: "“Me? Walter Tusk?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Walter Tusk**: "“Sounds good.”" |
| `[112]` | **"“Enticing. I will think about it.”"** | `[75]` **Walter Tusk**: "“Doesn't that sound great?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Walter Tusk**: "“Good. I hope you come to the ri..." |
| `[120]` | **"“What about you, Marcel?”"** | `[75]` **Walter Tusk**: "“Doesn't that sound great?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Walter Tusk**: "“He can't do anything. He is not..." |
| `[138]` | **"“If I win, I will win with my own strength.”"** | `[75]` **Walter Tusk**: "“Doesn't that sound great?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Walter Tusk**: "“Well, of course!”" |
| `[149]` | **"“The shares will be equally distributed between the two of you. [Insider Trading]""** | `[155]` **Narrator**: "Marcel leaned forward with antic..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn07_GrantedShares_WalterAndMarcelEq...` | `[142]` **Walter Tusk**: "“I see. So you decided to not pi..." |
| `[150]` | **"“The shares will go to Marcel. [Insider Trading +1 Personal Wealth]""** | `[155]` **Narrator**: "Marcel leaned forward with antic..." | `Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true` | `Variable["BaseGame.Turn07_GrantedShares_MarcelKoronti"] =...` | `[128]` **Walter Tusk**: "“What?!”" |
| `[153]` | **"“The shares will go to Walter. [Insider Trading +1 Personal Wealth]""** | `[155]` **Narrator**: "Marcel leaned forward with antic..." | `(Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true) == false` | `Variable["BaseGame.Turn07_GrantedShares_WalterTusk"] = true;` | `[174]` **Narrator**: "Marcel gaped at me."<br>`[140]` **Marcel Koronti**: "“What?!”" |
| `[160]` | **"“No matter how you bribe me, you won't get what you are here for.”"** | `[19]` **Walter Tusk**: "“I heard Petr say that you favou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Narrator**: "Marcel burst out laughing." |
| `[161]` | **"“No, it doesn't.”"** | `[75]` **Walter Tusk**: "“Doesn't that sound great?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Marcel Koronti**: "“Before you spew those big words..." |
| `[162]` | **""I'm sick of these shenanigans. You'll have to squabble over the shares when they ..."** | `[155]` **Narrator**: "Marcel leaned forward with antic..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Narrator**: "Marcel gaped at me."<br>`[164]` **Marcel Koronti**: "“What?!”" |
| `[180]` | **""Thanks for the car, Marcel.""** | `[179]` **Walter Tusk**: "“You had a what now?"" | `Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true` | *Brak zmian stanu* | `[184]` **Marcel Koronti**: ""Give me back those keys."" |
| `[181]` | **""I changed my mind.""** | `[179]` **Walter Tusk**: "“You had a what now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Marcel Koronti**: ""Then so did I."" |
| `[182]` | **""Deal's off. Sorry.""** | `[179]` **Walter Tusk**: "“You had a what now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Marcel Koronti**: ""Oh, you'd better believe it is."" |
| `[186]` | **"Give him the car keys."** | `[184]` **Marcel Koronti**: ""Give me back those keys."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Marcel Koronti**: ""Your days of being adored by th..." |
| `[187]` | **""Nope. You said the car was a gift.""** | `[184]` **Marcel Koronti**: ""Give me back those keys."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Narrator**: "Marcel slowly shook his head at ..." |
| `[221]` | **"“The shares will go to Marcel. [Insider Trading]""** | `[155]` **Narrator**: "Marcel leaned forward with antic..." | `(Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true) == false` | `Variable["BaseGame.Turn07_GrantedShares_MarcelKoronti"] =...` | `[128]` **Walter Tusk**: "“What?!”" |
| `[222]` | **"“The shares will go to Walter. [Insider Trading]""** | `[155]` **Narrator**: "Marcel leaned forward with antic..." | `Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true` | `Variable["BaseGame.Turn07_GrantedShares_WalterTusk"] = true;` | `[174]` **Narrator**: "Marcel gaped at me."<br>`[140]` **Marcel Koronti**: "“What?!”" |

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
  - -> `[3]` (*Narrator: "The privatization process had begun. And as I had expecte..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[3]`
Mówca: **Narrator**
> "The privatization process had begun. And as I had expected, Sordland's two most prominent oligarchs wanted to speak to me about it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Lucian showed Marcel Koronti and Walter Tusk into the con..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The two men sat across the table from me, leaving an empty chair in between them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Walter Tusk: "“Good to see you, President.”"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Lucian showed Marcel Koronti and Walter Tusk into the conference room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The two men sat across the table from me, leaving an empt..."*)

### Węzeł `[6]`
Mówca: **Walter Tusk**
> "“Good to see you, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Walter Tusk: "“It's been a while.”"*)

### Węzeł `[7]`
Mówca: **Walter Tusk**
> "“It's been a while.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Walter Tusk: "“Here, take this. A gift.”"*)

### Węzeł `[8]`
Mówca: **Walter Tusk**
> "“Well, of course!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Walter Tusk: "“Don't make light of me, President. I am saying this prec..."*)

### Węzeł `[9]`
Mówca: **Marcel Koronti**
> "“It's all right, old man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Marcel Koronti: "“You learned your place today.”"*)

### Węzeł `[10]`
Mówca: **Marcel Koronti**
> "“Old man. You always think so small.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Marcel Koronti: "“You lack the vision to see the bigger picture.""*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "“Straight to business, as always.”"]** — Mówca: **Player**
> "“Straight to business, as always.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Walter Tusk: "“As always.”"*)

### Węzeł `[12]`
Mówca: **Walter Tusk**
> "“Haven't you heard a word of what I said?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Marcel Koronti: "“It's all right, old man.”"*)

### Węzeł `[13]`
Mówca: **Walter Tusk**
> "“Here, take this. A gift.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "He brought out a bottle of Erlory Maroon 30-year old."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "The two men packed their belongings and left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NedamMiningGroup_Privatization + BaseGame.SordishStateCorporation_Privatization > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.NedamMiningGroup_Privatization + BaseGame.Sordis..."*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NedamMiningGroup_Privatization + BaseGame.Sord..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NedamMiningGroup_Privatization + BaseGame.SordishStateCorporation_Privatization > 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NedamMiningGroup_Privatization"] + Variable["BaseGame.SordishStateCorporation_Privatization"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Marcel Koronti: "“If you give me the shares, I will topple this old man.”"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NedamMiningGroup_Privatization + BaseGame.SordishStateCorporation_Privatization > 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NedamMiningGroup_Privatization"] + Variable["BaseGame.SordishStateCorporation_Privatization"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Marcel Koronti: "“Don't forget that I have something that gives me an edge..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "He brought out a bottle of Erlory Maroon 30-year old."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Walter Tusk: "“I heard Petr say that you favour this one.”"*)

### Węzeł `[19]`
Mówca: **Walter Tusk**
> "“I heard Petr say that you favour this one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "“Thanks for the gift.”"*)
  - -> `[11]` (*Player: "“Straight to business, as always.”"*)
  - -> `[23]` (*Player: "“What do you want in return?”"*)
  - -> `[160]` (*Player: "“No matter how you bribe me, you won't get what you are h..."*)

### Węzeł `[20]`
Mówca: **Marcel Koronti**
> "“Control over the media.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Marcel Koronti: "“I can give you power over both the Assembly and the Sord..."*)

### Węzeł `[21]`
Mówca: **Walter Tusk**
> "“As always.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Marcel burst out laughing."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“Thanks for the gift.”"]** — Mówca: **Player**
> "“Thanks for the gift.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Walter Tusk: "“Anytime.”"*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "“What do you want in return?”"]** — Mówca: **Player**
> "“What do you want in return?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Walter Tusk: "“Hah. Nothing. It's just a token of friendship.”"*)

### Węzeł `[24]`
Mówca: **Marcel Koronti**
> "“I will take my leave as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "The two men packed their belongings and left the meeting ..."*)

### Węzeł `[25]`
Mówca: **Marcel Koronti**
> "“I can do so much more to sway the public in your favour.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Marcel Koronti: "“Power over the Assembly is nothing compared to power ove..."*)

### Węzeł `[26]`
Mówca: **Walter Tusk**
> "“See you later, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Marcel Koronti: "“I will take my leave as well.”"*)

### Węzeł `[27]`
Mówca: **Walter Tusk**
> "“Hah. Nothing. It's just a token of friendship.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Marcel burst out laughing."*)

### Węzeł `[28]`
Mówca: **Marcel Koronti**
> "“Power over the Assembly is nothing compared to power over the people!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Marcel Koronti: "“Basically a guaranteed win.”"*)

### Węzeł `[29]`
Mówca: **Walter Tusk**
> "“I will take my leave now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Walter Tusk: "“See you later, President.”"*)

### Węzeł `[30]`
Mówca: **Walter Tusk**
> "“Anytime.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Marcel burst out laughing."*)

### Węzeł `[31]`
Mówca: **Marcel Koronti**
> "“I can give you power over both the Assembly and the Sordish public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Marcel Koronti: "“Basically a guaranteed win.”"*)

### Węzeł `[32]`
Mówca: **Narrator**
> "Marcel burst out laughing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Marcel Koronti: "“Old man. You always think so small.”"*)

### Węzeł `[33]`
Mówca: **Walter Tusk**
> "“I think we all have very busy schedules.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Walter Tusk: "“I will take my leave now.”"*)

### Węzeł `[34]`
Mówca: **Marcel Koronti**
> "“Don't forget that I have something that gives me an edge over this man and his archaic ways. A powerful tool.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Marcel Koronti: "“Control over the media.”"*)

### Węzeł `[35]`
Mówca: **Narrator**
> "After the papers were signed, Marcel and Walter stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Walter Tusk: "“I think we all have very busy schedules.”"*)

### Węzeł `[36]`
Mówca: **Marcel Koronti**
> "“These shares will increase my already considerable influence over newspapers, radio and television.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Marcel Koronti: "“I can do so much more to sway the public in your favour.”"*)

### Węzeł `[37]`
Mówca: **Marcel Koronti**
> "“You lack the vision to see the bigger picture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "Marcel approached me and we shook hands."*)

### Węzeł `[38]`
Mówca: **Lucian Galade**
> "“Anyway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucian Galade: "“Gentlemen. Please take your seats.”"*)

### Węzeł `[39]`
Mówca: **Narrator**
> "Marcel approached me and we shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Marcel Koronti: "“It's nice to see you, Mr. President.”"*)

### Węzeł `[40]`
Mówca: **Walter Tusk**
> "“Good. I hope you come to the right conclusion then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Marcel Koronti: "“Before you spew those big words, make sure you can actua..."*)

### Węzeł `[41]`
Mówca: **Marcel Koronti**
> "“It's nice to see you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Marcel Koronti: "“Here.”"*)

### Węzeł `[42]`
Mówca: **Lucian Galade**
> "“You will need to sign here, here and here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Signing");"*)

### Węzeł `[43]`
Mówca: **Marcel Koronti**
> "“A real gift.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "He took a set of car keys from his pocket and gave them t..."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "He took a set of car keys from his pocket and gave them to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Marcel Koronti: "“Come. Take a look.”"*)

### Węzeł `[45]`
Mówca: **Lucian Galade**
> "“You will need to sign here, here and here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Signing");"*)

### Węzeł `[46]`
Mówca: **Marcel Koronti**
> "“Here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Marcel Koronti: "“A real gift.”"*)

### Węzeł `[47]`
Mówca: **Lucian Galade**
> "“You will need to sign here, here and here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Signing");"*)

### Węzeł `[48]`
Mówca: **Marcel Koronti**
> "“But that is not all, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Marcel Koronti: "“Don't forget that I have something that gives me an edge..."*)

### Węzeł `[49]`
Mówca: **Marcel Koronti**
> "“Come. Take a look.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "I looked out the window. On the road leading to the palac..."*)

### Węzeł `[50]`
Mówca: **Marcel Koronti**
> "“Public opinion means everything when it comes to elections. And guess what?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Marcel Koronti: "“These shares will increase my already considerable influ..."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "I looked out the window. On the road leading to the palace, I saw a glittering, brand-new Randorfini sports car. A car that only the richest of the richest in Sordland could afford."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Marcel Koronti: "“It's yours.”"*)

### Węzeł `[52]`
Mówca: **Marcel Koronti**
> "“Basically a guaranteed win.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Marcel Koronti: "“He could never *ever* hope to beat this offer.”"*)

### Węzeł `[53]`
Mówca: **Marcel Koronti**
> "“It's yours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: "“I can't take this.”"*)
  - -> `[56]` (*Player: "“Thank you, Marcel. I can't wait to drive it.""*)
  - -> `[55]` (*Player: "“I can't accept a luxury car while the people of Sordland..."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "He pointed to various sections and pages in the stack of papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Lucian Galade: "“You will need to sign here, here and here.”"*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "“I can't accept a luxury car while the people of Sordland go hungry.”"]** — Mówca: **Player**
> "“I can't accept a luxury car while the people of Sordland go hungry.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "Marcel shrugged."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "“Thank you, Marcel. I can't wait to drive it.""]** — Mówca: **Player**
> "“Thank you, Marcel. I can't wait to drive it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Marcel Koronti: "“I knew you would like it.”"*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "“I can't take this.”"]** — Mówca: **Player**
> "“I can't take this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Marcel Koronti: "“Of course you can. It's a gift.”"*)

### Węzeł `[58]`
Mówca: **Marcel Koronti**
> "“Of course you can. It's a gift.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Marcel Koronti: "“Surely better than a bottle of whiskey.”"*)

### Węzeł `[59]`
Mówca: **Narrator**
> "He pointed to various sections and pages in the stack of papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucian Galade: "“You will need to sign here, here and here.”"*)

### Węzeł `[60]`
Mówca: **Narrator**
> "He pointed to various sections and pages in the stack of papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucian Galade: "“You will need to sign here, here and here.”"*)

### Węzeł `[61]`
Mówca: **Marcel Koronti**
> "“Basically a guaranteed win.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Marcel Koronti: "“He can never *ever* hope to beat this offer.”"*)

### Węzeł `[62]`
Mówca: **Marcel Koronti**
> "“Control over the media.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Marcel Koronti: "“Public opinion means everything when it comes to electio..."*)

### Węzeł `[63]`
Mówca: **Marcel Koronti**
> "“Suit yourself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Walter Tusk: "“Little boy.”"*)

### Węzeł `[64]`
Mówca: **Narrator**
> "Marcel shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Marcel Koronti: "“Suit yourself.”"*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“Why are you two showering me with gifts?”"]** — Mówca: **Player**
> "“Why are you two showering me with gifts?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Walter Tusk: "“No reason.”"*)

### Węzeł `[66]`
Mówca: **Marcel Koronti**
> "“I knew you would like it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Marcel Koronti: "“Surely better than a bottle of whiskey.”"*)

### Węzeł `[67]`
Mówca: **Marcel Koronti**
> "“Which means I will have the same influence he does over the Assembly. I can sway them as you like.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Marcel Koronti: "“But that is not all, Mr. President.”"*)

### Węzeł `[68]`
Mówca: **Narrator**
> "Lucian put a stack of papers in front of Walter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "He pointed to various sections and pages in the stack of ..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "Lucian put a stack of papers in front of Marcel and Walter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "He pointed to various sections and pages in the stack of ..."*)

### Węzeł `[70]`
Mówca: **Marcel Koronti**
> "“Surely better than a bottle of whiskey.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_AcceptedMarcelCar = true"*)

### Węzeł `[71]`
Mówca: **Narrator**
> "Lucian put a stack of papers in front of Marcel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "He pointed to various sections and pages in the stack of ..."*)

### Węzeł `[72]`
Mówca: **Lucian Galade**
> "“So, Mr. Tusk and Mr. Koronti. President Rayne is about to sell private shares in Sordland's two largest national corporations. And now you're here, showering him with gifts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lucian Galade: "“You're both clearly more skilled at business than you ar..."*)

### Węzeł `[73]`
Mówca: **Walter Tusk**
> "“Little boy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Walter Tusk: "“Do you think I can't do better?”"*)

### Węzeł `[74]`
Mówca: **Walter Tusk**
> "“Do you think I can't do better?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Walter Tusk: "“Me? Walter Tusk?”"*)

### Węzeł `[75]`
Mówca: **Walter Tusk**
> "“Doesn't that sound great?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: "“What about you, Marcel?”"*)
  - -> `[112]` (*Player: "“Enticing. I will think about it.”"*)
  - -> `[138]` (*Player: "“If I win, I will win with my own strength.”"*)
  - -> `[161]` (*Player: "“No, it doesn't.”"*)

### Węzeł `[76]`
Mówca: **Marcel Koronti**
> "“Don't forget that I have something that gives me an edge over this man and his archaic ways. A powerful tool.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Marcel Koronti: "“Control over the media.”"*)

### Węzeł `[77]`
Mówca: **Lucian Galade**
> "“Very well. Here is the paperwork.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Lucian put a stack of papers in front of Walter."*)

### Węzeł `[78]`
Mówca: **Walter Tusk**
> "“Me? Walter Tusk?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: "“Why are you two showering me with gifts?”"*)
  - -> `[80]` (*Player: "“Whatever you want, bribery won't work.”"*)
  - -> `[83]` (*Player: "“Thank you both. Let's begin the meeting.”"*)

### Węzeł `[79]`
Mówca: **Lucian Galade**
> "“Very well. Here is the paperwork.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "Lucian put a stack of papers in front of Marcel and Walter."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "“Whatever you want, bribery won't work.”"]** — Mówca: **Player**
> "“Whatever you want, bribery won't work.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Marcel Koronti: "“This is absolutely no bribe, Mr. President.”"*)

### Węzeł `[81]`
Mówca: **Lucian Galade**
> "“Very well. Here is the paperwork.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "Lucian put a stack of papers in front of Marcel."*)

### Węzeł `[82]`
Mówca: **Marcel Koronti**
> "“If you give me the shares, I will topple this old man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Marcel Koronti: "“Which means I will have the same influence he does over ..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“Thank you both. Let's begin the meeting.”"]** — Mówca: **Player**
> "“Thank you both. Let's begin the meeting.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Walter Tusk: "“Sounds good.”"*)

### Węzeł `[84]`
Mówca: **Marcel Koronti**
> "“He could never *ever* hope to beat this offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Walter Tusk: "“You little snake.”"*)

### Węzeł `[85]`
Mówca: **Walter Tusk**
> "“No reason.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucian Galade: "“Really? No reason?”"*)

### Węzeł `[86]`
Mówca: **Marcel Koronti**
> "“He can never *ever* hope to beat this offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Walter Tusk: "“You little snake.”"*)

### Węzeł `[87]`
Mówca: **Marcel Koronti**
> "“This is absolutely no bribe, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Marcel Koronti: "“It's a simple gift. That's all.”"*)

### Węzeł `[88]`
Mówca: **Lucian Galade**
> "“Perhaps, but Marcel has a point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucian Galade: "“What is the decision, Mr. President?”"*)

### Węzeł `[89]`
Mówca: **Walter Tusk**
> "“Sounds good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucian Galade: "“Gentlemen. Please take your seats.”"*)

### Węzeł `[90]`
Mówca: **Marcel Koronti**
> "“No complaints here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucian Galade: "“Very well. Here is the paperwork.”"*)

### Węzeł `[91]`
Mówca: **Narrator**
> "They sat down. Lucian produced a set of documents from his briefcase. He put on his reading glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.NedamMiningGroup_Privatization > 0 && BaseGame.S..."*)

### Węzeł `[92]`
Mówca: **Lucian Galade**
> "“Really? No reason?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lucian Galade: "“I bet this has nothing to do with the recent privatizati..."*)

### Węzeł `[93]`
Mówca: **Walter Tusk**
> "“He can't do anything. He is not capable enough to--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Marcel Koronti: "“Mr. President asked me, not you.”"*)

### Węzeł `[94]`
Mówca: **Marcel Koronti**
> "“It's a simple gift. That's all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucian Galade: "“Really? A simple gift?”"*)

### Węzeł `[95]`
Mówca: **Marcel Koronti**
> "“I want to be straightforward with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.NedamMiningGroup_Privatization + BaseGame.Sordis..."*)

### Węzeł `[96]`
Mówca: **Lucian Galade**
> "“Really? A simple gift?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lucian Galade: "“I bet this has nothing to do with the recent privatizati..."*)

### Węzeł `[97]`
Mówca: **Marcel Koronti**
> "“You learned your place today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Marcel Koronti: "“Thank you for the wise decision, Mr. President. I will a..."*)

### Węzeł `[98]`
Mówca: **Lucian Galade**
> "“I bet this has nothing to do with the recent privatizations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Lucian Galade: "“Anyway.”"*)

### Węzeł `[99]`
Mówca: **Marcel Koronti**
> "“Thank you for the wise decision, Mr. President. I will arrange a small transfer as a personal thanks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_MarcelFavor_PrivateTakeover == true"*)

### Węzeł `[100]`
Mówca: **Lucian Galade**
> "“What is the decision, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Walter Tusk: "“Yeah, what's it going to be?”"*)

### Węzeł `[101]`
Mówca: **Lucian Galade**
> "“Media is a powerful tool after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucian Galade: "“What is the decision, Mr. President?”"*)

### Węzeł `[102]`
Mówca: **Marcel Koronti**
> "“But what he is sitting on top of right now was built by my father, Konrath Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Marcel Koronti: "“I want to be straightforward with you.”"*)

### Węzeł `[103]`
Mówca: **Lucian Galade**
> "“Gentlemen. Please take your seats.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "They sat down. Lucian produced a set of documents from hi..."*)

### Węzeł `[104]`
Mówca: **Walter Tusk**
> "“Thank you for the wise decision, President. I'll send a token of my appreciation to your account.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 1"*)

### Węzeł `[105]`
Mówca: **Walter Tusk**
> "“You learned your place today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Walter Tusk: "“Thank you for the wise decision, President. I'll send a ..."*)

### Węzeł `[106]`
Mówca: **Walter Tusk**
> "“You little snake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Walter Tusk: "“You are twenty years early to be the head of the Lotherb..."*)

### Węzeł `[107]`
Mówca: **Walter Tusk**
> "“You little snake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Lucian Galade: "“Marcel has a point.”"*)

### Węzeł `[108]`
Mówca: **Marcel Koronti**
> "“True, he might have command over some people in the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Marcel Koronti: "“But what he is sitting on top of right now was built by ..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NedamMiningGroup_Privatization > 0 && BaseGame.SordishStateCorporation_Privatization > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.NedamMiningGroup_Privatization > 0 && BaseGame.S..."*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NedamMiningGroup_Privatization > 0 && BaseGame..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NedamMiningGroup_Privatization > 0 && BaseGame.SordishStateCorporation_Privatization > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NedamMiningGroup_Privatization"] > 0  and  Variable["BaseGame.SordishStateCorporation_Privatization"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucian Galade: "“So, Mr. Tusk and Mr. Koronti. President Rayne is about t..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NedamMiningGroup_Privatization > 0 && BaseGame.SordishStateCorporation_Privatization > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NedamMiningGroup_Privatization"] > 0  and  Variable["BaseGame.SordishStateCorporation_Privatization"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.NedamMiningGroup_Privatization > 0"*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "“Enticing. I will think about it.”"]** — Mówca: **Player**
> "“Enticing. I will think about it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Walter Tusk: "“Good. I hope you come to the right conclusion then.”"*)

### Węzeł `[113]`
Mówca: **Walter Tusk**
> "“President. Listen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Walter Tusk: "“We, you and I, haven't been on the best of terms lately.”"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NedamMiningGroup_Privatization > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.NedamMiningGroup_Privatization > 0"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NedamMiningGroup_Privatization > 0)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NedamMiningGroup_Privatization > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NedamMiningGroup_Privatization"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Lucian Galade: "“So, Mr. Tusk and Mr. Koronti. President Rayne is about t..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NedamMiningGroup_Privatization > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NedamMiningGroup_Privatization"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lucian Galade: "“So, Mr. Tusk and Mr. Koronti. President Rayne is about t..."*)

### Węzeł `[117]`
Mówca: **Marcel Koronti**
> "“Likewise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Marcel Koronti: "“No complaints here.”"*)

### Węzeł `[118]`
Mówca: **Walter Tusk**
> "“Although I would've preferred you pick me, I respect that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_MarcelFavor_PrivateTakeover == true"*)

### Węzeł `[119]`
Mówca: **Lucian Galade**
> "“So, Mr. Tusk and Mr. Koronti. President Rayne is about to sell private shares in Nedam Mining Group. And now you're here, showering him with gifts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lucian Galade: "“You're both clearly more skilled at business than you ar..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "“What about you, Marcel?”"]** — Mówca: **Player**
> "“What about you, Marcel?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Walter Tusk: "“He can't do anything. He is not capable enough to--”"*)

### Węzeł `[121]`
Mówca: **Lucian Galade**
> "“So, Mr. Tusk and Mr. Koronti. President Rayne is about to sell private shares in the Sordish State Corporation. And now you're here, showering him with gifts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lucian Galade: "“You're both clearly more skilled at business than you ar..."*)

### Węzeł `[122]`
Mówca: **Walter Tusk**
> "“It's alright, kiddo.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Walter Tusk: "“You learned your place today.”"*)

### Węzeł `[123]`
Mówca: **Lucian Galade**
> "“You're both clearly more skilled at business than you are at subterfuge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Lucian Galade: "“So tell us: Why do you deserve to claim these shares bef..."*)

### Węzeł `[124]`
Mówca: **Marcel Koronti**
> "“Haven't you heard a word of what I said?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Walter Tusk: "“It's alright, kiddo.”"*)

### Węzeł `[125]`
Mówca: **Walter Tusk**
> "“You are twenty years early to be the head of the Lotherberg Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Walter Tusk: "“*I* made The Group what it is.”"*)

### Węzeł `[126]`
Mówca: **Marcel Koronti**
> "“Before you spew those big words, make sure you can actually do it, Walter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Marcel Koronti: "“Mr. President. First off, Mr. Tusk here is lying about t..."*)

### Węzeł `[127]`
Mówca: **Lucian Galade**
> "“So tell us: Why do you deserve to claim these shares before they go on the general market?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "Walter cleared his throat."*)

### Węzeł `[128]`
Mówca: **Walter Tusk**
> "“What?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Walter Tusk: "“Haven't you heard a word of what I said?”"*)

### Węzeł `[129]`
Mówca: **Narrator**
> "Walter cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[130]`
Mówca: **Marcel Koronti**
> "“Mr. President. First off, Mr. Tusk here is lying about the extent his influence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Marcel Koronti: "“True, he might have command over some people in the Asse..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Content == true)"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Walter Tusk: "“President. Listen.”"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Walter Tusk: "“President. Listen.”"*)

### Węzeł `[134]`
Mówca: **Lucian Galade**
> "“Marcel has a point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lucian Galade: "“Media is a powerful tool after all.”"*)

### Węzeł `[135]`
Mówca: **Walter Tusk**
> "“President. Listen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Walter Tusk: "“We, you and I, have been getting along like gangbusters ..."*)

### Węzeł `[136]`
Mówca: **Walter Tusk**
> "“That's why I want to help you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Marcel Koronti: "“Before you spew those big words, make sure you can actua..."*)

### Węzeł `[137]`
Mówca: **Walter Tusk**
> "“Don't make light of me, President. I am saying this precisely because I believe you are capable of doing it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Walter Tusk: "“That's why I want to help you.”"*)

### Węzeł `[138]`
**[WYBÓR GRACZA: "“If I win, I will win with my own strength.”"]** — Mówca: **Player**
> "“If I win, I will win with my own strength.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Walter Tusk: "“Well, of course!”"*)

### Węzeł `[139]`
Mówca: **Walter Tusk**
> "“We, you and I, have been getting along like gangbusters recently.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Walter Tusk: "“I want to continue this profitable relationship between ..."*)

### Węzeł `[140]`
Mówca: **Marcel Koronti**
> "“What?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Marcel Koronti: "“Haven't you heard a word of what I said?”"*)

### Węzeł `[141]`
Mówca: **Walter Tusk**
> "“We, you and I, haven't been on the best of terms lately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Walter Tusk: "“But I want to nurture a profitable relationship between ..."*)

### Węzeł `[142]`
Mówca: **Walter Tusk**
> "“I see. So you decided to not pick a side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Walter Tusk: "“Although I would've preferred you pick me, I respect that.”"*)

### Węzeł `[143]`
Mówca: **Walter Tusk**
> "“Yeah, what's it going to be?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "Marcel leaned forward with anticipation."*)

### Węzeł `[144]`
Mówca: **Marcel Koronti**
> "“Mr. President asked me, not you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Marcel Koronti: "“Before you spew those big words, make sure you can actua..."*)

### Węzeł `[145]`
Mówca: **Walter Tusk**
> "“I want to continue this profitable relationship between us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Walter Tusk: "“These shares are very important to me. If I had them, I ..."*)

### Węzeł `[146]`
Mówca: **Walter Tusk**
> "“But I want to nurture a profitable relationship between us where we both win.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Walter Tusk: "“These shares are very important to me. If I had them, I ..."*)

### Węzeł `[147]`
Mówca: **Walter Tusk**
> "“These shares are very important to me. If I had them, I could do so much more for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Walter Tusk: "“So much more for you.”"*)

### Węzeł `[148]`
Mówca: **Walter Tusk**
> "“*I* made The Group what it is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lucian Galade: "“Perhaps, but Marcel has a point.”"*)

### Węzeł `[149]`
**[WYBÓR GRACZA: "“The shares will be equally distributed between the two of you. [Insider Trading]""]** — Mówca: **Player**
> "“The shares will be equally distributed between the two of you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually = true"*)

### Węzeł `[150]`
**[WYBÓR GRACZA: "“The shares will go to Marcel. [Insider Trading +1 Personal Wealth]""]** — Mówca: **Player**
> "“The shares will go to Marcel.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true`
- **Kontekst wejściowy (poprzednik):** `[155]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_GrantedShares_MarcelKoronti = true"*)

### Węzeł `[151]`
Mówca: **Walter Tusk**
> "“So much more for you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Walter Tusk: "“You haven't even seen what I and my connections are capa..."*)

### Węzeł `[152]`
Mówca: **Walter Tusk**
> "“You haven't even seen what I and my connections are capable of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Walter Tusk: "“Do you want to get re-elected? No problem. I will make s..."*)

### Węzeł `[153]`
**[WYBÓR GRACZA: "“The shares will go to Walter. [Insider Trading +1 Personal Wealth]""]** — Mówca: **Player**
> "“The shares will go to Walter.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[155]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_GrantedShares_WalterTusk = true"*)

### Węzeł `[154]`
Mówca: **Walter Tusk**
> "“Do you want to get re-elected? No problem. I will make sure of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Walter Tusk: "“This is my offer to you. I will do whatever it takes to ..."*)

### Węzeł `[155]`
Mówca: **Narrator**
> "Marcel leaned forward with anticipation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_MarcelFavor_PrivateTakeover == true"*)
  - -> `[149]` (*Player: "“The shares will be equally distributed between the two o..."*)
  - -> `[162]` (*Player: ""I'm sick of these shenanigans. You'll have to squabble o..."*)

### Węzeł `[156]`
Mówca: **Walter Tusk**
> "“This is my offer to you. I will do whatever it takes to make you President for another term.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Walter Tusk: "“Doesn't that sound great?”"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_GrantedShares_MarcelKoronti = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_GrantedShares_MarcelKoronti"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Walter Tusk: "“What?!”"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Walter Tusk: "“I see. So you decided to not pick a side.”"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_GrantedShares_WalterTusk = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn07_GrantedShares_WalterTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_MarcelFavor_PrivateTakeover == true"*)

### Węzeł `[160]`
**[WYBÓR GRACZA: "“No matter how you bribe me, you won't get what you are here for.”"]** — Mówca: **Player**
> "“No matter how you bribe me, you won't get what you are here for.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Marcel burst out laughing."*)

### Węzeł `[161]`
**[WYBÓR GRACZA: "“No, it doesn't.”"]** — Mówca: **Player**
> "“No, it doesn't.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Marcel Koronti: "“Before you spew those big words, make sure you can actua..."*)

### Węzeł `[162]`
**[WYBÓR GRACZA: ""I'm sick of these shenanigans. You'll have to squabble over the shares when they enter the market, just like everyone else.""]** — Mówca: **Player**
> ""I'm sick of these shenanigans. You'll have to squabble over the shares when they enter the market, just like everyone else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_MarcelFavor_PrivateTakeover == true"*)

### Węzeł `[163]`
Mówca: **Marcel Koronti**
> "“Haven't you heard a word of what I said?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Walter Tusk: "“Yeah. Can't you see how good of a deal I'm offering here?""*)

### Węzeł `[164]`
Mówca: **Marcel Koronti**
> "“What?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Marcel Koronti: "“Haven't you heard a word of what I said?”"*)

### Węzeł `[165]`
Mówca: **Walter Tusk**
> "“Yeah. Can't you see how good of a deal I'm offering here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Lucian Galade: "“I believe the President has already told you his decisio..."*)

### Węzeł `[166]`
Mówca: **Lucian Galade**
> "“I believe the President has already told you his decision, Mr. Tusk, Mr. Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Lucian Galade: "“We are terribly busy today, so I would like to wish you ..."*)

### Węzeł `[167]`
Mówca: **Lucian Galade**
> "“We are terribly busy today, so I would like to wish you a good day as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Lucian Galade: "“I hope you know where the door is. If you don't, you can..."*)

### Węzeł `[168]`
Mówca: **Lucian Galade**
> "“I hope you know where the door is. If you don't, you can ask a security guard to show you out.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Walter Tusk: "“This is not the end, President.”"*)

### Węzeł `[169]`
Mówca: **Walter Tusk**
> "“This is not the end, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Marcel Koronti: "“You will hear from us again.”"*)

### Węzeł `[170]`
Mówca: **Marcel Koronti**
> "“You will hear from us again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "The two men packed their belongings and left the meeting ..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_MarcelFavor_PrivateTakeover == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_MarcelFavor_PrivateTakeover == true"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_MarcelFavor_PrivateTakeover == true)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_MarcelFavor_PrivateTakeover == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "Marcel gaped at me."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_MarcelFavor_PrivateTakeover == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Marcel Koronti: "“Likewise.”"*)

### Węzeł `[174]`
Mówca: **Narrator**
> "Marcel gaped at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Marcel Koronti: "“You bastard. We had a deal.""*)

### Węzeł `[175]`
Mówca: **Marcel Koronti**
> "“You bastard. We had a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Walter Tusk: "“You had a what now?""*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_MarcelFavor_PrivateTakeover == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_MarcelFavor_PrivateTakeover == true"*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_MarcelFavor_PrivateTakeover == true)"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_MarcelFavor_PrivateTakeover == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "Marcel gaped at me."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_MarcelFavor_PrivateTakeover == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Marcel Koronti: "“What?!”"*)

### Węzeł `[179]`
Mówca: **Walter Tusk**
> "“You had a what now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_AcceptedMarcelCar == true"*)
  - -> `[181]` (*Player: ""I changed my mind.""*)
  - -> `[182]` (*Player: ""Deal's off. Sorry.""*)

### Węzeł `[180]`
**[WYBÓR GRACZA: ""Thanks for the car, Marcel.""]** — Mówca: **Player**
> ""Thanks for the car, Marcel.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true`
- **Kontekst wejściowy (poprzednik):** `[179]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Marcel Koronti: ""Give me back those keys.""*)

### Węzeł `[181]`
**[WYBÓR GRACZA: ""I changed my mind.""]** — Mówca: **Player**
> ""I changed my mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Marcel Koronti: ""Then so did I.""*)

### Węzeł `[182]`
**[WYBÓR GRACZA: ""Deal's off. Sorry.""]** — Mówca: **Player**
> ""Deal's off. Sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Walter Tusk)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Marcel Koronti: ""Oh, you'd better believe it is.""*)

### Węzeł `[183]`
Mówca: **Marcel Koronti**
> ""Oh, you'd better believe it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_AcceptedMarcelCar == true"*)

### Węzeł `[184]`
Mówca: **Marcel Koronti**
> ""Give me back those keys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player_Italic: "Give him the car keys."*)
  - -> `[187]` (*Player: ""Nope. You said the car was a gift.""*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_AcceptedMarcelCar = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_CarKey");"*)

### Węzeł `[186]`
**[WYBÓR GRACZA: "Give him the car keys."]** — Mówca: **Player_Italic**
> "I threw the car keys on the table. Marcel snatched them up."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Marcel Koronti: ""Your days of being adored by the media are over, Rayne. ..."*)

### Węzeł `[187]`
**[WYBÓR GRACZA: ""Nope. You said the car was a gift.""]** — Mówca: **Player**
> ""Nope. You said the car was a gift.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "Marcel slowly shook his head at me. There were storm clou..."*)

### Węzeł `[188]`
Mówca: **Marcel Koronti**
> ""Then so did I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_AcceptedMarcelCar == true"*)

### Węzeł `[189]`
Mówca: **Narrator**
> "Marcel slowly shook his head at me. There were storm clouds gathering in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Marcel Koronti: ""Your days of being adored by the media are over, Rayne. ..."*)

### Węzeł `[190]`
Mówca: **Marcel Koronti**
> ""Your days of being adored by the media are over, Rayne. And so is your presidency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias = false"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Media_SordlandToday_Bias"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Walter Tusk: ""Nice try, brat. But you're not half the man your father ..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_MarcelFavor_PrivateTakeover == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_MarcelFavor_PrivateTakeover == true"*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_MarcelFavor_PrivateTakeover == true)"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_MarcelFavor_PrivateTakeover == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "Marcel gaped at me."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_MarcelFavor_PrivateTakeover == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Marcel Koronti: "“What?!”"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_AcceptedMarcelCar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_AcceptedMarcelCar == true"*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_AcceptedMarcelCar == true)"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_AcceptedMarcelCar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Player: ""Thanks for the car, Marcel.""*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_AcceptedMarcelCar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_AcceptedMarcelCar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_AcceptedMarcelCar == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_AcceptedMarcelCar == true)"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_AcceptedMarcelCar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Marcel Koronti: ""Give me back those keys.""*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_AcceptedMarcelCar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "Marcel slowly shook his head at me. There were storm clou..."*)

### Węzeł `[201]`
Mówca: **Walter Tusk**
> ""Nice try, brat. But you're not half the man your father was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Walter turned to me."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_GrantedShares_WalterTusk == true || BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_GrantedShares_WalterTusk == true || BaseG..."*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_GrantedShares_WalterTusk == true || Bas..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_GrantedShares_WalterTusk == true || BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_GrantedShares_WalterTusk"] == true  or  Variable["BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Walter Tusk: ""Thanks for the shares, President. As the current and fut..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_GrantedShares_WalterTusk == true || BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_GrantedShares_WalterTusk"] == true  or  Variable["BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Walter Tusk: ""Enjoy the whiskey, President. While you can.""*)

### Węzeł `[205]`
Mówca: **Walter Tusk**
> ""Thanks for the shares, President. As the current and future leader of the Lotherberg Group, I shall not let you down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_GrantedShares_WalterTusk == true"*)

### Węzeł `[206]`
Mówca: **Narrator**
> "Walter turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_GrantedShares_WalterTusk == true || BaseG..."*)

### Węzeł `[207]`
Mówca: **Walter Tusk**
> ""Enjoy the whiskey, President. While you can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "The two men packed their belongings and left the meeting ..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_GrantedShares_WalterTusk == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_GrantedShares_WalterTusk == true"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_GrantedShares_WalterTusk == true)"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_GrantedShares_WalterTusk == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_GrantedShares_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Signing");"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_GrantedShares_WalterTusk == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_GrantedShares_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Signing");"*)

### Węzeł `[211]`
Mówca: **Narrator**
> "Lucian handed him the paperwork. He made a big show of signing it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "The two men packed their belongings and left the meeting ..."*)

### Węzeł `[212]`
Mówca: **Narrator**
> "Lucian handed him the paperwork. He made a big show of signing it, then passed it on to Marcel, who begrudgingly signed as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "The two men packed their belongings and left the meeting ..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lucian Galade: "“Very well. Here is the paperwork.”"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lucian Galade: "“Very well. Here is the paperwork.”"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_MarcelFavor_PrivateTakeover == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_MarcelFavor_PrivateTakeover == true"*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_MarcelFavor_PrivateTakeover == true)"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_MarcelFavor_PrivateTakeover == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 1"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_MarcelFavor_PrivateTakeover == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lucian Galade: "“Very well. Here is the paperwork.”"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_MarcelFavor_PrivateTakeover == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_MarcelFavor_PrivateTakeover == true"*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_MarcelFavor_PrivateTakeover == true)"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_MarcelFavor_PrivateTakeover == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: "“The shares will go to Marcel. [Insider Trading +1 Person..."*)
  - -> `[222]` (*Player: "“The shares will go to Walter. [Insider Trading]""*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_MarcelFavor_PrivateTakeover == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player: "“The shares will go to Marcel. [Insider Trading]""*)
  - -> `[153]` (*Player: "“The shares will go to Walter. [Insider Trading +1 Person..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA: "“The shares will go to Marcel. [Insider Trading]""]** — Mówca: **Player**
> "“The shares will go to Marcel.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[155]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_GrantedShares_MarcelKoronti = true"*)

### Węzeł `[222]`
**[WYBÓR GRACZA: "“The shares will go to Walter. [Insider Trading]""]** — Mówca: **Player**
> "“The shares will go to Walter.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true`
- **Kontekst wejściowy (poprzednik):** `[155]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_GrantedShares_WalterTusk = true"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_CarKey");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_CarKey");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Walter Tusk: "“Little boy.”"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Signing");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Signing");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "After the papers were signed, Marcel and Walter stood up."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Signing");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Signing");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Narrator: "Lucian handed him the paperwork. He made a big show of si..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Signing");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Signing");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "Lucian handed him the paperwork. He made a big show of si..."*)
