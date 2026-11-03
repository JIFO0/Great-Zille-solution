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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 11

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.PersonalWealth`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[157]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_GrantedShares_MarcelKoronti"] = true;`
- Węzeł `[158]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually"] = true;`
- Węzeł `[159]` (Paskal Beniwoll): `Variable["BaseGame.Turn07_GrantedShares_WalterTusk"] = true;`
- Węzeł `[185]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] = true;`
- Węzeł `[191]` (Paskal Beniwoll): `Variable["BaseGame.Media_SordlandToday_Bias"] = false;`
- Węzeł `[213]` (Paskal Beniwoll): `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;`
- Węzeł `[214]` (Paskal Beniwoll): `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;`
- Węzeł `[223]` (Paskal Beniwoll): `EnableCollectionItem("CollectionItem_CarKey"); ;`
- *...oraz 3 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `132` (*Sordland/Turn07/A_OligarchsFinalMeeting*), Węzeł `[309]`

### Węzeł `[3]`
Mówca: **Narrator**
> "The privatization process had begun. And as I had expected, Sordland's two most prominent oligarchs wanted to speak to me about it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The two men sat across the table from me, leaving an empty chair in between them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Lucian showed Marcel Koronti and Walter Tusk into the conference room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[6]`
Mówca: **Walter Tusk**
> "“Good to see you, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Walter Tusk**
> "“It's been a while.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[8]`
Mówca: **Walter Tusk**
> "“Well, of course!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[9]`
Mówca: **Marcel Koronti**
> "“It's all right, old man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[10]`
Mówca: **Marcel Koronti**
> "“Old man. You always think so small.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "“Straight to business, as always.”"]** — Mówca: **Player**
> "“Straight to business, as always.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[12]`
Mówca: **Walter Tusk**
> "“Haven't you heard a word of what I said?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[13]`
Mówca: **Walter Tusk**
> "“Here, take this. A gift.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[14]`
Mówca: **Narrator**
> "The two men packed their belongings and left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NedamMiningGroup_Privatization + BaseGame.SordishStateCorporation_Privatization > 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NedamMiningGroup_Privatization + BaseGame.SordishStateCorporation_Privatization > 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NedamMiningGroup_Privatization"] + Variable["BaseGame.SordishStateCorporation_Privatization"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NedamMiningGroup_Privatization + BaseGame.SordishStateCorporation_Privatization > 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NedamMiningGroup_Privatization"] + Variable["BaseGame.SordishStateCorporation_Privatization"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[18]`
Mówca: **Narrator**
> "He brought out a bottle of Erlory Maroon 30-year old."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Walter Tusk**
> "“I heard Petr say that you favour this one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[11]`
  - -> `[23]`
  - -> `[160]`

### Węzeł `[20]`
Mówca: **Marcel Koronti**
> "“Control over the media.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[21]`
Mówca: **Walter Tusk**
> "“As always.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“Thanks for the gift.”"]** — Mówca: **Player**
> "“Thanks for the gift.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "“What do you want in return?”"]** — Mówca: **Player**
> "“What do you want in return?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[24]`
Mówca: **Marcel Koronti**
> "“I will take my leave as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[25]`
Mówca: **Marcel Koronti**
> "“I can do so much more to sway the public in your favour.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[26]`
Mówca: **Walter Tusk**
> "“See you later, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[27]`
Mówca: **Walter Tusk**
> "“Hah. Nothing. It's just a token of friendship.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[28]`
Mówca: **Marcel Koronti**
> "“Power over the Assembly is nothing compared to power over the people!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[29]`
Mówca: **Walter Tusk**
> "“I will take my leave now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[30]`
Mówca: **Walter Tusk**
> "“Anytime.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Marcel Koronti**
> "“I can give you power over both the Assembly and the Sordish public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[32]`
Mówca: **Narrator**
> "Marcel burst out laughing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[33]`
Mówca: **Walter Tusk**
> "“I think we all have very busy schedules.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[34]`
Mówca: **Marcel Koronti**
> "“Don't forget that I have something that gives me an edge over this man and his archaic ways. A powerful tool.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[35]`
Mówca: **Narrator**
> "After the papers were signed, Marcel and Walter stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[36]`
Mówca: **Marcel Koronti**
> "“These shares will increase my already considerable influence over newspapers, radio and television.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[37]`
Mówca: **Marcel Koronti**
> "“You lack the vision to see the bigger picture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Lucian Galade**
> "“Anyway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[39]`
Mówca: **Narrator**
> "Marcel approached me and we shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Walter Tusk**
> "“Good. I hope you come to the right conclusion then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[41]`
Mówca: **Marcel Koronti**
> "“It's nice to see you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[42]`
Mówca: **Lucian Galade**
> "“You will need to sign here, here and here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[43]`
Mówca: **Marcel Koronti**
> "“A real gift.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Narrator**
> "He took a set of car keys from his pocket and gave them to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[45]`
Mówca: **Lucian Galade**
> "“You will need to sign here, here and here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[46]`
Mówca: **Marcel Koronti**
> "“Here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[47]`
Mówca: **Lucian Galade**
> "“You will need to sign here, here and here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[48]`
Mówca: **Marcel Koronti**
> "“But that is not all, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[49]`
Mówca: **Marcel Koronti**
> "“Come. Take a look.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Marcel Koronti**
> "“Public opinion means everything when it comes to elections. And guess what?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[51]`
Mówca: **Narrator**
> "I looked out the window. On the road leading to the palace, I saw a glittering, brand-new Randorfini sports car. A car that only the richest of the richest in Sordland could afford."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Marcel Koronti**
> "“Basically a guaranteed win.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[53]`
Mówca: **Marcel Koronti**
> "“It's yours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[56]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Narrator**
> "He pointed to various sections and pages in the stack of papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[55]`
**[WYBÓR GRACZA: "“I can't accept a luxury car while the people of Sordland go hungry.”"]** — Mówca: **Player**
> "“I can't accept a luxury car while the people of Sordland go hungry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "“Thank you, Marcel. I can't wait to drive it.""]** — Mówca: **Player**
> "“Thank you, Marcel. I can't wait to drive it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "“I can't take this.”"]** — Mówca: **Player**
> "“I can't take this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Marcel Koronti**
> "“Of course you can. It's a gift.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[59]`
Mówca: **Narrator**
> "He pointed to various sections and pages in the stack of papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[60]`
Mówca: **Narrator**
> "He pointed to various sections and pages in the stack of papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[61]`
Mówca: **Marcel Koronti**
> "“Basically a guaranteed win.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[62]`
Mówca: **Marcel Koronti**
> "“Control over the media.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[63]`
Mówca: **Marcel Koronti**
> "“Suit yourself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[64]`
Mówca: **Narrator**
> "Marcel shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“Why are you two showering me with gifts?”"]** — Mówca: **Player**
> "“Why are you two showering me with gifts?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[66]`
Mówca: **Marcel Koronti**
> "“I knew you would like it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[67]`
Mówca: **Marcel Koronti**
> "“Which means I will have the same influence he does over the Assembly. I can sway them as you like.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[68]`
Mówca: **Narrator**
> "Lucian put a stack of papers in front of Walter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[69]`
Mówca: **Narrator**
> "Lucian put a stack of papers in front of Marcel and Walter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[70]`
Mówca: **Marcel Koronti**
> "“Surely better than a bottle of whiskey.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[71]`
Mówca: **Narrator**
> "Lucian put a stack of papers in front of Marcel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[72]`
Mówca: **Lucian Galade**
> "“So, Mr. Tusk and Mr. Koronti. President Rayne is about to sell private shares in Sordland's two largest national corporations. And now you're here, showering him with gifts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[73]`
Mówca: **Walter Tusk**
> "“Little boy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Walter Tusk**
> "“Do you think I can't do better?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[75]`
Mówca: **Walter Tusk**
> "“Doesn't that sound great?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[112]`
  - -> `[138]`
  - -> `[161]`

### Węzeł `[76]`
Mówca: **Marcel Koronti**
> "“Don't forget that I have something that gives me an edge over this man and his archaic ways. A powerful tool.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[77]`
Mówca: **Lucian Galade**
> "“Very well. Here is the paperwork.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[78]`
Mówca: **Walter Tusk**
> "“Me? Walter Tusk?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[80]`
  - -> `[83]`

### Węzeł `[79]`
Mówca: **Lucian Galade**
> "“Very well. Here is the paperwork.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "“Whatever you want, bribery won't work.”"]** — Mówca: **Player**
> "“Whatever you want, bribery won't work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[81]`
Mówca: **Lucian Galade**
> "“Very well. Here is the paperwork.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[82]`
Mówca: **Marcel Koronti**
> "“If you give me the shares, I will topple this old man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "“Thank you both. Let's begin the meeting.”"]** — Mówca: **Player**
> "“Thank you both. Let's begin the meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[84]`
Mówca: **Marcel Koronti**
> "“He could never *ever* hope to beat this offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[85]`
Mówca: **Walter Tusk**
> "“No reason.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[86]`
Mówca: **Marcel Koronti**
> "“He can never *ever* hope to beat this offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[87]`
Mówca: **Marcel Koronti**
> "“This is absolutely no bribe, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[88]`
Mówca: **Lucian Galade**
> "“Perhaps, but Marcel has a point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[89]`
Mówca: **Walter Tusk**
> "“Sounds good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[90]`
Mówca: **Marcel Koronti**
> "“No complaints here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[91]`
Mówca: **Narrator**
> "They sat down. Lucian produced a set of documents from his briefcase. He put on his reading glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[92]`
Mówca: **Lucian Galade**
> "“Really? No reason?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[93]`
Mówca: **Walter Tusk**
> "“He can't do anything. He is not capable enough to--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[94]`
Mówca: **Marcel Koronti**
> "“It's a simple gift. That's all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Marcel Koronti**
> "“I want to be straightforward with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[96]`
Mówca: **Lucian Galade**
> "“Really? A simple gift?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Marcel Koronti**
> "“You learned your place today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Lucian Galade**
> "“I bet this has nothing to do with the recent privatizations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[99]`
Mówca: **Marcel Koronti**
> "“Thank you for the wise decision, Mr. President. I will arrange a small transfer as a personal thanks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[100]`
Mówca: **Lucian Galade**
> "“What is the decision, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[101]`
Mówca: **Lucian Galade**
> "“Media is a powerful tool after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[102]`
Mówca: **Marcel Koronti**
> "“But what he is sitting on top of right now was built by my father, Konrath Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[103]`
Mówca: **Lucian Galade**
> "“Gentlemen. Please take your seats.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[104]`
Mówca: **Walter Tusk**
> "“Thank you for the wise decision, President. I'll send a token of my appreciation to your account.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[105]`
Mówca: **Walter Tusk**
> "“You learned your place today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[106]`
Mówca: **Walter Tusk**
> "“You little snake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[107]`
Mówca: **Walter Tusk**
> "“You little snake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[108]`
Mówca: **Marcel Koronti**
> "“True, he might have command over some people in the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NedamMiningGroup_Privatization > 0 && BaseGame.SordishStateCorporation_Privatization > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NedamMiningGroup_Privatization > 0 && BaseGame.SordishStateCorporation_Privatization > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NedamMiningGroup_Privatization"] > 0  and  Variable["BaseGame.SordishStateCorporation_Privatization"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NedamMiningGroup_Privatization > 0 && BaseGame.SordishStateCorporation_Privatization > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NedamMiningGroup_Privatization"] > 0  and  Variable["BaseGame.SordishStateCorporation_Privatization"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[112]`
**[WYBÓR GRACZA: "“Enticing. I will think about it.”"]** — Mówca: **Player**
> "“Enticing. I will think about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[113]`
Mówca: **Walter Tusk**
> "“President. Listen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NedamMiningGroup_Privatization > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.NedamMiningGroup_Privatization > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.NedamMiningGroup_Privatization"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.NedamMiningGroup_Privatization > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.NedamMiningGroup_Privatization"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[117]`
Mówca: **Marcel Koronti**
> "“Likewise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[118]`
Mówca: **Walter Tusk**
> "“Although I would've preferred you pick me, I respect that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[119]`
Mówca: **Lucian Galade**
> "“So, Mr. Tusk and Mr. Koronti. President Rayne is about to sell private shares in Nedam Mining Group. And now you're here, showering him with gifts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "“What about you, Marcel?”"]** — Mówca: **Player**
> "“What about you, Marcel?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[121]`
Mówca: **Lucian Galade**
> "“So, Mr. Tusk and Mr. Koronti. President Rayne is about to sell private shares in the Sordish State Corporation. And now you're here, showering him with gifts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Walter Tusk**
> "“It's alright, kiddo.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[123]`
Mówca: **Lucian Galade**
> "“You're both clearly more skilled at business than you are at subterfuge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[124]`
Mówca: **Marcel Koronti**
> "“Haven't you heard a word of what I said?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[125]`
Mówca: **Walter Tusk**
> "“You are twenty years early to be the head of the Lotherberg Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[126]`
Mówca: **Marcel Koronti**
> "“Before you spew those big words, make sure you can actually do it, Walter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[127]`
Mówca: **Lucian Galade**
> "“So tell us: Why do you deserve to claim these shares before they go on the general market?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Walter Tusk**
> "“What?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[129]`
Mówca: **Narrator**
> "Walter cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Marcel Koronti**
> "“Mr. President. First off, Mr. Tusk here is lying about the extent his influence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Content == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[134]`
Mówca: **Lucian Galade**
> "“Marcel has a point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[135]`
Mówca: **Walter Tusk**
> "“President. Listen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[136]`
Mówca: **Walter Tusk**
> "“That's why I want to help you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[137]`
Mówca: **Walter Tusk**
> "“Don't make light of me, President. I am saying this precisely because I believe you are capable of doing it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[138]`
**[WYBÓR GRACZA: "“If I win, I will win with my own strength.”"]** — Mówca: **Player**
> "“If I win, I will win with my own strength.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[139]`
Mówca: **Walter Tusk**
> "“We, you and I, have been getting along like gangbusters recently.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[140]`
Mówca: **Marcel Koronti**
> "“What?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[141]`
Mówca: **Walter Tusk**
> "“We, you and I, haven't been on the best of terms lately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[142]`
Mówca: **Walter Tusk**
> "“I see. So you decided to not pick a side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[143]`
Mówca: **Walter Tusk**
> "“Yeah, what's it going to be?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[144]`
Mówca: **Marcel Koronti**
> "“Mr. President asked me, not you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[145]`
Mówca: **Walter Tusk**
> "“I want to continue this profitable relationship between us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Walter Tusk**
> "“But I want to nurture a profitable relationship between us where we both win.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Walter Tusk**
> "“These shares are very important to me. If I had them, I could do so much more for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[148]`
Mówca: **Walter Tusk**
> "“*I* made The Group what it is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[149]`
**[WYBÓR GRACZA: "“The shares will be equally distributed between the two of you. [Insider Trading]""]** — Mówca: **Player**
> "“The shares will be equally distributed between the two of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[150]`
**[WYBÓR GRACZA: "“The shares will go to Marcel. [Insider Trading +1 Personal Wealth]""]** — Mówca: **Player**
> "“The shares will go to Marcel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[151]`
Mówca: **Walter Tusk**
> "“So much more for you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Walter Tusk**
> "“You haven't even seen what I and my connections are capable of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[153]`
**[WYBÓR GRACZA: "“The shares will go to Walter. [Insider Trading +1 Personal Wealth]""]** — Mówca: **Player**
> "“The shares will go to Walter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[154]`
Mówca: **Walter Tusk**
> "“Do you want to get re-elected? No problem. I will make sure of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Narrator**
> "Marcel leaned forward with anticipation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[149]`
  - -> `[162]`

### Węzeł `[156]`
Mówca: **Walter Tusk**
> "“This is my offer to you. I will do whatever it takes to make you President for another term.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_GrantedShares_MarcelKoronti = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_GrantedShares_MarcelKoronti"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_GrantedShares_WalterTusk = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn07_GrantedShares_WalterTusk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[160]`
**[WYBÓR GRACZA: "“No matter how you bribe me, you won't get what you are here for.”"]** — Mówca: **Player**
> "“No matter how you bribe me, you won't get what you are here for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[161]`
**[WYBÓR GRACZA: "“No, it doesn't.”"]** — Mówca: **Player**
> "“No, it doesn't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[162]`
**[WYBÓR GRACZA: ""I'm sick of these shenanigans. You'll have to squabble over the shares when they enter the market, just like everyone else.""]** — Mówca: **Player**
> ""I'm sick of these shenanigans. You'll have to squabble over the shares when they enter the market, just like everyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[163]`
Mówca: **Marcel Koronti**
> "“Haven't you heard a word of what I said?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Marcel Koronti**
> "“What?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[165]`
Mówca: **Walter Tusk**
> "“Yeah. Can't you see how good of a deal I'm offering here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Lucian Galade**
> "“I believe the President has already told you his decision, Mr. Tusk, Mr. Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Lucian Galade**
> "“We are terribly busy today, so I would like to wish you a good day as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Lucian Galade**
> "“I hope you know where the door is. If you don't, you can ask a security guard to show you out.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Walter Tusk**
> "“This is not the end, President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Marcel Koronti**
> "“You will hear from us again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_MarcelFavor_PrivateTakeover == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_MarcelFavor_PrivateTakeover == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_MarcelFavor_PrivateTakeover == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[174]`
Mówca: **Narrator**
> "Marcel gaped at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Marcel Koronti**
> "“You bastard. We had a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_MarcelFavor_PrivateTakeover == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_MarcelFavor_PrivateTakeover == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_MarcelFavor_PrivateTakeover == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[179]`
Mówca: **Walter Tusk**
> "“You had a what now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[181]`
  - -> `[182]`

### Węzeł `[180]`
**[WYBÓR GRACZA: ""Thanks for the car, Marcel.""]** — Mówca: **Player**
> ""Thanks for the car, Marcel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[181]`
**[WYBÓR GRACZA: ""I changed my mind.""]** — Mówca: **Player**
> ""I changed my mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[182]`
**[WYBÓR GRACZA: ""Deal's off. Sorry.""]** — Mówca: **Player**
> ""Deal's off. Sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Marcel Koronti**
> ""Oh, you'd better believe it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[184]`
Mówca: **Marcel Koronti**
> ""Give me back those keys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_AcceptedMarcelCar = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[186]`
**[WYBÓR GRACZA: "Give him the car keys."]** — Mówca: **Player_Italic**
> "I threw the car keys on the table. Marcel snatched them up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[187]`
**[WYBÓR GRACZA: ""Nope. You said the car was a gift.""]** — Mówca: **Player**
> ""Nope. You said the car was a gift.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Marcel Koronti**
> ""Then so did I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[189]`
Mówca: **Narrator**
> "Marcel slowly shook his head at me. There were storm clouds gathering in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Marcel Koronti**
> ""Your days of being adored by the media are over, Rayne. And so is your presidency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Media_SordlandToday_Bias"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_MarcelFavor_PrivateTakeover == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_MarcelFavor_PrivateTakeover == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_MarcelFavor_PrivateTakeover == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_AcceptedMarcelCar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_AcceptedMarcelCar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_AcceptedMarcelCar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_AcceptedMarcelCar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn07_AcceptedMarcelCar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn07_AcceptedMarcelCar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_AcceptedMarcelCar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[201]`
Mówca: **Walter Tusk**
> ""Nice try, brat. But you're not half the man your father was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_GrantedShares_WalterTusk == true || BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_GrantedShares_WalterTusk == true || BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_GrantedShares_WalterTusk"] == true  or  Variable["BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_GrantedShares_WalterTusk == true || BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_GrantedShares_WalterTusk"] == true  or  Variable["BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[205]`
Mówca: **Walter Tusk**
> ""Thanks for the shares, President. As the current and future leader of the Lotherberg Group, I shall not let you down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[206]`
Mówca: **Narrator**
> "Walter turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[207]`
Mówca: **Walter Tusk**
> ""Enjoy the whiskey, President. While you can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_GrantedShares_WalterTusk == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_GrantedShares_WalterTusk == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_GrantedShares_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_GrantedShares_WalterTusk == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_GrantedShares_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[211]`
Mówca: **Narrator**
> "Lucian handed him the paperwork. He made a big show of signing it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[212]`
Mówca: **Narrator**
> "Lucian handed him the paperwork. He made a big show of signing it, then passed it on to Marcel, who begrudgingly signed as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[214]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_MarcelFavor_PrivateTakeover == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_MarcelFavor_PrivateTakeover == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_MarcelFavor_PrivateTakeover == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_MarcelFavor_PrivateTakeover == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_MarcelFavor_PrivateTakeover == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[222]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_MarcelFavor_PrivateTakeover == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_MarcelFavor_PrivateTakeover"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[153]`

### Węzeł `[221]`
**[WYBÓR GRACZA: "“The shares will go to Marcel. [Insider Trading]""]** — Mówca: **Player**
> "“The shares will go to Marcel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[222]`
**[WYBÓR GRACZA: "“The shares will go to Walter. [Insider Trading]""]** — Mówca: **Player**
> "“The shares will go to Walter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[223]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_CarKey");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_CarKey");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Signing");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Signing");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Signing");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Signing");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Signing");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Signing");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
