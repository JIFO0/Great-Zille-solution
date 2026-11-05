# Sordland/Turn05/A_DamageControl

- **ID konwersacji:** `68`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/068_A_DamageControl.md`
- **Liczba węzłów dialogowych:** 207
- **Liczba wyborów gracza:** 51

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[14]** Marcel Koronti
- **[37]** Curtan Leste
- **[38]** Lucian Galade
- **[41]** Livia Suno

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Turn05_Admin_Media_Influenced`
- `BaseGame.Turn05_Admin_News_Contained`
- `BaseGame.Turn05_Personal_Festival_LesteKicked`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Turn05_Admin_Media_Influenced`
- `BaseGame.Turn05_Admin_Monica_Barred`
- `BaseGame.Turn05_Admin_News_Contained`
- `BaseGameIsolated.Turn05_Admin_Mayor_Apology`
- `BaseGameIsolated.Turn05_Admin_Mayor_Media`
- `BaseGameSupport.Journal_Turn05_Scandal_CurtanDeal`
- `BaseGameSupport.Journal_Turn05_Scandal_MediaUsed`
- `GameCondition.Turn05_A_DamageControl`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[12]` | **""You've got that right. How dare he insult my wife!”"** | `[11]` **Lucian Galade**: "“At the same time, you must not ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Petr Vectern**: "“It was unacceptable. Monica did..." |
| `[13]` | **"“We could talk with him. Try to defuse the situation.""** | `[11]` **Lucian Galade**: "“At the same time, you must not ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Lucian Galade**: "“Engaging in talks has a chance ..." |
| `[14]` | **"“He and his conservative cronies won't be able to stand up to the full force of ou..."** | `[11]` **Lucian Galade**: "“At the same time, you must not ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Lucian Galade**: "“Exactly. A show of force could ..." |
| `[22]` | **"“We will request a formal apology from Curtan.”"** | `[21]` **Lucian Galade**: "“How should we proceed, sir?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn05_Admin_Mayor_Apology"] =...` | `[30]` **Lucian Galade**: "“I don't expect much compliance ..."<br>`[172]` **Lucian Galade**: ""Considering he opted to leave t..." |
| `[23]` | **"“I'm going to call Marcel Koronti. We have our deal -- let's put it to use.""** | `[21]` **Lucian Galade**: "“How should we proceed, sir?"" | `Variable["BaseGame.Media_SordlandToday_Bias"] == true` | `Variable["BaseGameIsolated.Turn05_Admin_Mayor_Media"] = t...` | `[31]` **Lucian Galade**: ""Excellent choice. With his infl..." |
| `[27]` | **"“Our deal with Marcel Koronti might be a solution.”"** | `[11]` **Lucian Galade**: "“At the same time, you must not ..." | `Variable["BaseGame.Media_SordlandToday_Bias"] == true` | *Brak zmian stanu* | `[28]` **Lucian Galade**: "“That would be the most ideal op..." |
| `[36]` | **"“Were you expecting me to?”"** | `[32]` **Marcel Koronti**: "“I was wondering when you would ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Marcel Koronti**: "“Of course I was.”" |
| `[37]` | **"“You seem to have forgotten how to greet people with respect.”"** | `[32]` **Marcel Koronti**: "“I was wondering when you would ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Marcel Koronti**: "“We're running out of time for p..." |
| `[39]` | **"“Curtan. I am calling to extend the olive branch.”"** | `[40]` **Curtan Leste**: "“What do you want, Rayne?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Curtan Leste**: "“Is that so?”" |
| `[42]` | **"“You insulted my wife. Would you have acted differently if the roles were reversed?”"** | `[120]` **Curtan Leste**: "“What makes you think that I wil..."<br>`[142]` **Curtan Leste**: "“Why would I possibly apologize ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Curtan Leste**: "“She insulted our culture and he..." |
| `[43]` | **"“It was a mistake. A grave one at that.”"** | `[120]` **Curtan Leste**: "“What makes you think that I wil..."<br>`[142]` **Curtan Leste**: "“Why would I possibly apologize ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Curtan Leste**: "“At the very least, you have the..." |
| `[47]` | **"“Let's put all of this behind us.”"** | `[50]` **Narrator**: "He paused. The ball was in my co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Curtan Leste**: "“That depends on you.”" |
| `[48]` | **"“I called you for a resolution.”"** | `[50]` **Narrator**: "He paused. The ball was in my co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Curtan Leste**: "“That depends on you.”" |
| `[49]` | **"“Do you want a solution or not?”"** | `[50]` **Narrator**: "He paused. The ball was in my co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Curtan Leste**: "“That depends on you.”" |
| `[52]` | **"“You piece of shit!”"** | `[51]` **Curtan Leste**: "“Let's see how you like the pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Curtan Leste**: "“Manners, Mr. President.”" |
| `[53]` | **"“You just made a very powerful enemy.”"** | `[51]` **Curtan Leste**: "“Let's see how you like the pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Curtan Leste**: "“You seem to be surrounded by mo..." |
| `[55]` | **"Hang up the phone."** | `[51]` **Curtan Leste**: "“Let's see how you like the pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Lucian Galade**: "“That does not look like it went..." |
| `[68]` | **"“Think about this, Marcel. You don't want me on the other side of the fence.”"** | `[69]` **Marcel Koronti**: "“I've just seen the proofs for S..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Marcel Koronti**: "“I know I don't. We have a deal...." |
| `[70]` | **"“What about the other papers?”"** | `[69]` **Marcel Koronti**: "“I've just seen the proofs for S..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Marcel Koronti**: "“Deyr Journal, The Radical, Hols..." |
| `[71]` | **"“We had a deal. I hope you have not forgotten.”"** | `[69]` **Marcel Koronti**: "“I've just seen the proofs for S..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Marcel Koronti**: "“Of course not. Mutual respect b..." |
| `[76]` | **"“I only want to minimize the damage. The less prominent the story, the better.”"** | `[75]` **Marcel Koronti**: "“I take it that you want this co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Marcel Koronti**: "“That's certainly within the rea..." |
| `[77]` | **"“I want it gone.”"** | `[75]` **Marcel Koronti**: "“I take it that you want this co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Marcel Koronti**: "“Alas, the event is too newswort..." |
| `[81]` | **"“How disappointing.”"** | `[79]` **Marcel Koronti**: "“Alas, the event is too newswort..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Marcel Koronti**: "“I'm not a Saint, Mr. President...." |
| `[82]` | **"“Your promise was about erasing mistakes.”"** | `[79]` **Marcel Koronti**: "“Alas, the event is too newswort..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Marcel Koronti**: "“I'm not a Saint, Mr. President...." |
| `[83]` | **"“Do you think this could blow out of proportion?”"** | `[78]` **Marcel Koronti**: "“That's certainly within the rea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Marcel Koronti**: "“A president replacing an invite..." |
| `[84]` | **"“And what would you want from me in return?”"** | `[78]` **Marcel Koronti**: "“That's certainly within the rea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Marcel Koronti**: ""Oh, we'll worry about that when..." |
| `[88]` | **"“Thank you again.”"** | `[99]` **Marcel Koronti**: ""After that, making the necessar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Marcel Koronti**: "“Don't you worry. Until next tim..." |
| `[89]` | **"“Looking forward to the results.”"** | `[99]` **Marcel Koronti**: ""After that, making the necessar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Marcel Koronti**: "“Don't you worry. Until next tim..." |
| `[90]` | **"“If this... partnership comes to light, it would be an even bigger scandal.”"** | `[92]` **Marcel Koronti**: "“So, do you want me to get to wo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Marcel Koronti**: "“That is a big *if*, Mr. Preside..." |
| `[91]` | **"“Yes. Handle the situation immediately.”"** | `[92]` **Marcel Koronti**: "“So, do you want me to get to wo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn05_Admin_Media_Influenced"] = true;` | `[100]` **Marcel Koronti**: "“Perfect. I'll call my contacts ..." |
| `[107]` | **"“Any plans for the holiday next month?”"** | `[64]` **Narrator**: "Lucian departed, which left me a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Petr Vectern**: "“Ha. More of this, I suppose.”" |
| `[108]` | **"“How are things between you and Evelyn?”"** | `[64]` **Narrator**: "Lucian departed, which left me a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Petr Vectern**: "“They're a little better, thanks.”" |
| `[111]` | **"“How are the upcoming trade deals for Agnolia and Wehlen coming along?”"** | `[64]` **Narrator**: "Lucian departed, which left me a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Petr Vectern**: "“As well as expected. They had t..." |
| `[114]` | **"“Yes, it's been far too long. Shall we?”"** | `[113]` **Petr Vectern**: "“It's been a while since we had ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Narrator**: "At that very moment, the phone b..." |
| `[115]` | **"“Maybe later.”"** | `[113]` **Petr Vectern**: "“It's been a while since we had ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Narrator**: "At that very moment, the phone b..." |
| `[125]` | **"“Yes please.”"** | `[123]` **Livia Suno**: "“Mr. Vectern told me what happen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Livia Suno**: "“As you wish.”" |
| `[126]` | **"“That would be appreciated.”"** | `[123]` **Livia Suno**: "“Mr. Vectern told me what happen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Livia Suno**: "“I'll let you know once I have h..." |
| `[135]` | **"“Yes, please.”"** | `[134]` **Livia Suno**: "“Mr. Vectern told me what happen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Livia Suno**: "“As you wish.”" |
| `[136]` | **"“That would be appreciated.”"** | `[134]` **Livia Suno**: "“Mr. Vectern told me what happen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Livia Suno**: "“I'll let you know once I have h..." |
| `[140]` | **"“I demand a public and formal apology for your behavior at the festival.""** | `[40]` **Curtan Leste**: "“What do you want, Rayne?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Curtan Leste**: "“Is that so? You've got some ner..." |
| `[149]` | **"“You leave me no choice. I'll tell Monica she's out of politics.""** | `[148]` **Curtan Leste**: "“What will it be?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn05_Admin_Monica_Barred"] = true; V...` | `[152]` **Curtan Leste**: "“I'm glad that we came to terms.”" |
| `[150]` | **"“I refuse. You are the one who is in the wrong. I won't punish her for your crimes.”"** | `[148]` **Curtan Leste**: "“What will it be?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Curtan Leste**: "“Wrong decision. I am disappoint..." |
| `[156]` | **"“Thank you.”"** | `[153]` **Curtan Leste**: "“I will announce my public apolo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Curtan Leste**: "“Have a good day, Mr. President.”" |
| `[157]` | **"“I will be waiting for it.”"** | `[153]` **Curtan Leste**: "“I will announce my public apolo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Curtan Leste**: "“Have a good day, Mr. President.”" |
| `[158]` | **"“Don't get cocky.”"** | `[32]` **Marcel Koronti**: "“I was wondering when you would ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Marcel Koronti**: "“Apologies for my behaviour, Mr...." |
| `[163]` | **"“Handle the situation immediately.”"** | `[162]` **Marcel Koronti**: "“But it is your decision. So wha..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn05_Admin_Media_Influenced"] = true;` | `[100]` **Marcel Koronti**: "“Perfect. I'll call my contacts ..." |
| `[164]` | **"“I changed my mind. It's too risky.”"** | `[162]` **Marcel Koronti**: "“But it is your decision. So wha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Marcel Koronti**: "“Well in that case, I have no re..." |
| `[166]` | **"“For God's sake, Petr, it's six in the morning!”"** | `[113]` **Petr Vectern**: "“It's been a while since we had ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Narrator**: "At that very moment, the phone b..." |
| `[196]` | **"“Agreed. Let's do it.”"** | `[194]` **Lucian Galade**: "“We could give a call to Mr. Kor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Lucian Galade**: ""Excellent choice. With his infl..." |
| `[197]` | **"“No. We will manage without him.”"** | `[194]` **Lucian Galade**: "“We could give a call to Mr. Kor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[198]` **Lucian Galade**: "“Very well.”" |
| `[199]` | **"“Let's just talk to him. He can't stay angry forever.”"** | `[21]` **Lucian Galade**: "“How should we proceed, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Lucian Galade**: "“I don't expect much compliance ..."<br>`[200]` **Lucian Galade**: ""Considering he opted to leave t..." |

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
  - -> `[3]` (*Narrator: "The sun was just beginning to rise as Lucian, Petr and I ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The sun was just beginning to rise as Lucian, Petr and I gathered in my office to discuss the fallout of the Benfi Festival."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "Mayor Curtan Leste's untimely departure was bound to refl..."*)

### Węzeł `[4]`
Mówca: **Lucian Galade**
> "“The news is about to break, even as we speak. We must act swiftly to protect the administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Petr Vectern: "“Agreed. This isn't good, Anton.”"*)

### Węzeł `[5]`
Mówca: **Petr Vectern**
> "“Agreed. This isn't good, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "“I'm going to call Marcel Koronti. We have our deal -- le..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[9]`
Mówca: **Lucian Galade**
> "“The most important thing is the narrative. We need to regain control of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Petr Vectern: ""He also has incredible influence over the USP's conserva..."*)

### Węzeł `[10]`
Mówca: **Petr Vectern**
> ""He also has incredible influence over the USP's conservative wing, including our MP's. We've got to act before he rallies the others against you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Lucian Galade: "“At the same time, you must not apologize yourself. Insul..."*)

### Węzeł `[11]`
Mówca: **Lucian Galade**
> "“At the same time, you must not apologize yourself. Insulting the First Lady is an act that should not go unpunished.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[14]` (*Player: "“He and his conservative cronies won't be able to stand u..."*)
  - -> `[12]` (*Player: ""You've got that right. How dare he insult my wife!”"*)
  - -> `[13]` (*Player: "“We could talk with him. Try to defuse the situation.""*)

### Węzeł `[12]`
**[WYBÓR GRACZA: ""You've got that right. How dare he insult my wife!”"]** — Mówca: **Player**
> ""You've got that right. How dare he insult my wife!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Petr Vectern: "“It was unacceptable. Monica didn't deserve that.”"*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“We could talk with him. Try to defuse the situation.""]** — Mówca: **Player**
> "“We could talk with him. Try to defuse the situation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucian Galade: "“Engaging in talks has a chance of backfiring, but it cou..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "“He and his conservative cronies won't be able to stand up to the full force of our administration.”"]** — Mówca: **Player**
> "“He and his conservative cronies won't be able to stand up to the full force of our administration.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: "“Exactly. A show of force could weaken his position.”"*)

### Węzeł `[15]`
Mówca: **Lucian Galade**
> "“Exactly. A show of force could weaken his position.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Petr Vectern: "“Maybe. Or just get him to dig in harder.”"*)

### Węzeł `[16]`
Mówca: **Petr Vectern**
> "“It was unacceptable. Monica didn't deserve that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lucian Galade: "“Perhaps she was allowed a little too much autonomy with ..."*)

### Węzeł `[17]`
Mówca: **Lucian Galade**
> "“Engaging in talks has a chance of backfiring, but it could be the simplest solution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Petr Vectern: ""He acted like an ass, too. Maybe you can both come out o..."*)

### Węzeł `[18]`
Mówca: **Lucian Galade**
> "“Perhaps she was allowed a little too much autonomy with her speech.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Lucian Galade: "“How should we proceed, sir?""*)

### Węzeł `[19]`
Mówca: **Petr Vectern**
> ""He acted like an ass, too. Maybe you can both come out of this looking good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Lucian Galade: "“How should we proceed, sir?""*)

### Węzeł `[20]`
Mówca: **Petr Vectern**
> "“Maybe. Or just get him to dig in harder.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Lucian Galade: "“How should we proceed, sir?""*)

### Węzeł `[21]`
Mówca: **Lucian Galade**
> "“How should we proceed, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "“We will request a formal apology from Curtan.”"*)
  - -> `[199]` (*Player: "“Let's just talk to him. He can't stay angry forever.”"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“We will request a formal apology from Curtan.”"]** — Mówca: **Player**
> "“We will request a formal apology from Curtan.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_Admin_Mayor_Apology = true"*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "“I'm going to call Marcel Koronti. We have our deal -- let's put it to use.""]** — Mówca: **Player**
> "“I'm going to call Marcel Koronti. We have our deal -- let's put it to use.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Kontekst wejściowy (poprzednik):** `[21]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_Admin_Mayor_Media = true"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: "“Our deal with Marcel Koronti might be a solution.”"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Our deal with Marcel Koronti might be a solution.”"]** — Mówca: **Player**
> "“Our deal with Marcel Koronti might be a solution.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Kontekst wejściowy (poprzednik):** `[11]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucian Galade: "“That would be the most ideal option.”"*)

### Węzeł `[28]`
Mówca: **Lucian Galade**
> "“That would be the most ideal option.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lucian Galade: "“If Sordland Today paints you in a favorable light, other..."*)

### Węzeł `[29]`
Mówca: **Petr Vectern**
> ""I still don't trust that man further than I could throw him. But he might prove useful in this case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Lucian Galade: "“How should we proceed, sir?""*)

### Węzeł `[30]`
Mówca: **Lucian Galade**
> "“I don't expect much compliance after you forcefully removed him from the venue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Petr Vectern: "“Maybe he's had time to cool off. I'll ask Livia to get h..."*)

### Węzeł `[31]`
Mówca: **Lucian Galade**
> ""Excellent choice. With his influence on the media, this could be contained fairly easily.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Petr Vectern: ""I'm still skeptical about this. But fine. I'll fetch Liv..."*)

### Węzeł `[32]`
Mówca: **Marcel Koronti**
> "“I was wondering when you would call.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: "“Were you expecting me to?”"*)
  - -> `[37]` (*Player: "“You seem to have forgotten how to greet people with resp..."*)
  - -> `[158]` (*Player: "“Don't get cocky.”"*)

### Węzeł `[33]`
Mówca: **Narrator**
> "Petr left the room and came back with Livia. She had on a short dress and dark eyeliner -- clearly she'd been counting on me being away at the festival for longer. Still, her demeanor was nothing but professional."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Livia Suno: "“Mr. Vectern told me what happened. Should I connect you ..."*)

### Węzeł `[34]`
Mówca: **Petr Vectern**
> "“Maybe he's had time to cool off. I'll ask Livia to get him on the line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Petr left the room and came back with Livia. She had on a..."*)

### Węzeł `[35]`
Mówca: **Petr Vectern**
> ""I'm still skeptical about this. But fine. I'll fetch Livia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "Petr left the room and came back with my secretary. She h..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Were you expecting me to?”"]** — Mówca: **Player**
> "“Were you expecting me?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Marcel Koronti: "“Of course I was.”"*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“You seem to have forgotten how to greet people with respect.”"]** — Mówca: **Player**
> "“You seem to have forgotten how to greet people with respect.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Marcel Koronti: "“We're running out of time for pleasantries, aren't we, M..."*)

### Węzeł `[38]`
Mówca: **Marcel Koronti**
> "“Of course I was.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Marcel Koronti: "“I've just seen the proofs for Sordland Today. It seems y..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Curtan. I am calling to extend the olive branch.”"]** — Mówca: **Player**
> "“Curtan. I am calling to extend the olive branch.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Curtan Leste: "“Is that so?”"*)

### Węzeł `[40]`
Mówca: **Curtan Leste**
> "“What do you want, Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: "“Curtan. I am calling to extend the olive branch.”"*)
  - -> `[140]` (*Player: "“I demand a public and formal apology for your behavior a..."*)

### Węzeł `[41]`
Mówca: **Curtan Leste**
> "“Is that so?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true"*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "“You insulted my wife. Would you have acted differently if the roles were reversed?”"]** — Mówca: **Player**
> "“You insulted my wife. Would you have acted differently if the roles were reversed?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Curtan Leste), `[142]` (Curtan Leste), `[182]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Curtan Leste: "“She insulted our culture and heritage. I only protected ..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“It was a mistake. A grave one at that.”"]** — Mówca: **Player**
> "“It was a mistake. A grave one at that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Curtan Leste), `[142]` (Curtan Leste), `[182]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Curtan Leste: "“At the very least, you have the courage to accept that i..."*)

### Węzeł `[44]`
Mówca: **Curtan Leste**
> "“At the very least, you have the courage to accept that it was.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "He paused. The ball was in my court."*)

### Węzeł `[45]`
Mówca: **Curtan Leste**
> "“She insulted our culture and heritage. I only protected our values.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "He paused. The ball was in my court."*)

### Węzeł `[46]`
Mówca: **Curtan Leste**
> "“Wrong decision. I am disappointed, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Curtan Leste: "“Let's see how you like the press hearing about the loss ..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "“Let's put all of this behind us.”"]** — Mówca: **Player**
> "“Let's put all of this behind us.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Curtan Leste: "“That depends on you.”"*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "“I called you for a resolution.”"]** — Mówca: **Player**
> "“I called you for a resolution.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Curtan Leste: "“That depends on you.”"*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "“Do you want a solution or not?”"]** — Mówca: **Player**
> "“Do you want a solution or not?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Curtan Leste: "“That depends on you.”"*)

### Węzeł `[50]`
Mówca: **Narrator**
> "He paused. The ball was in my court."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: "“I called you for a resolution.”"*)
  - -> `[49]` (*Player: "“Do you want a solution or not?”"*)
  - -> `[47]` (*Player: "“Let's put all of this behind us.”"*)

### Węzeł `[51]`
Mówca: **Curtan Leste**
> "“Let's see how you like the press hearing about the loss of Anrica to the National Front.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: "“You piece of shit!”"*)
  - -> `[53]` (*Player: "“You just made a very powerful enemy.”"*)
  - -> `[55]` (*Player_Italic: "Hang up the phone."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "“You piece of shit!”"]** — Mówca: **Player**
> "“You piece of shit!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Curtan Leste: "“Manners, Mr. President.”"*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "“You just made a very powerful enemy.”"]** — Mówca: **Player**
> "“You just made a very powerful enemy. Don't forget that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Curtan Leste: "“You seem to be surrounded by more and more enemies these..."*)

### Węzeł `[54]`
Mówca: **Curtan Leste**
> "“You seem to be surrounded by more and more enemies these days, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Curtan Leste: "“Enjoy the fallout.”"*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "Hang up the phone."]** — Mówca: **Player_Italic**
> "I hung up the phone."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Lucian Galade: "“That does not look like it went good.”"*)

### Węzeł `[56]`
Mówca: **Narrator**
> "Curtan Leste hung up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_News_Contained == true"*)

### Węzeł `[57]`
Mówca: **Petr Vectern**
> "“That's going to have consequences. Is there anything else we can do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[58]`
Mówca: **Lucian Galade**
> "“That went worse than expected. We've lost the chance to control the narrative, and we've lost a city to another party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Petr Vectern: "“That's going to have consequences. Is there anything els..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_News_Contained == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_News_Contained == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_News_Contained == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_News_Contained == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_News_Contained"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lucian Galade: "“That went far better than expected. We have both our apo..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_News_Contained == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_News_Contained"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Lucian Galade: "“That went worse than expected. We've lost the chance to ..."*)

### Węzeł `[62]`
Mówca: **Lucian Galade**
> "“That went far better than expected. We have both our apology and a chance to change the narrative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Petr Vectern: "“I can't believe you agreed to keep Monica out of politic..."*)

### Węzeł `[63]`
Mówca: **Petr Vectern**
> "“I can't believe you agreed to keep Monica out of politics. She won't take that well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Lucian Galade: "“I'll start working on our official response to his apolo..."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "Lucian departed, which left me and Petr in the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player: "“How are the upcoming trade deals for Agnolia and Wehlen ..."*)
  - -> `[107]` (*Player: "“Any plans for the holiday next month?”"*)
  - -> `[108]` (*Player: "“How are things between you and Evelyn?”"*)

### Węzeł `[65]`
Mówca: **Lucian Galade**
> "“I'll start working on our official response to his apology, to paint us in the best light possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "Lucian departed, which left me and Petr in the room."*)

### Węzeł `[66]`
Mówca: **Curtan Leste**
> "“Manners, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Curtan Leste: "“Enjoy the fallout.”"*)

### Węzeł `[67]`
Mówca: **Marcel Koronti**
> "“We're running out of time for pleasantries, aren't we, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Marcel Koronti: "“I've just seen the proofs for Sordland Today. It seems y..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "“Think about this, Marcel. You don't want me on the other side of the fence.”"]** — Mówca: **Player**
> "“Think about this, Marcel. You don't want me on the other side of the fence.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Marcel Koronti: "“I know I don't. We have a deal. after all.""*)

### Węzeł `[69]`
Mówca: **Marcel Koronti**
> "“I've just seen the proofs for Sordland Today. It seems your incident with poor Mayor Leste is about to make headlines.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: "“Think about this, Marcel. You don't want me on the other..."*)
  - -> `[70]` (*Player: "“What about the other papers?”"*)
  - -> `[71]` (*Player: "“We had a deal. I hope you have not forgotten.”"*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "“What about the other papers?”"]** — Mówca: **Player**
> "“What about the other papers?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Marcel Koronti: "“Deyr Journal, The Radical, Holsord Post and Lachaven Tim..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "“We had a deal. I hope you have not forgotten.”"]** — Mówca: **Player**
> "“We had a deal. I hope you have not forgotten.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Marcel Koronti: "“Of course not. Mutual respect between partners is a must.”"*)

### Węzeł `[72]`
Mówca: **Marcel Koronti**
> "“I know I don't. We have a deal. after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Marcel Koronti: "“I take it that you want this contained, if not completel..."*)

### Węzeł `[73]`
Mówca: **Marcel Koronti**
> "“Deyr Journal, The Radical, Holsord Post and Lachaven Times are all prepared to print the story on the front page.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Marcel Koronti: "“I take it that you want this contained, if not completel..."*)

### Węzeł `[74]`
Mówca: **Marcel Koronti**
> "“Of course not. Mutual respect between partners is a must.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Marcel Koronti: "“I take it that you want this contained, if not completel..."*)

### Węzeł `[75]`
Mówca: **Marcel Koronti**
> "“I take it that you want this contained, if not completely gone?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: "“I only want to minimize the damage. The less prominent t..."*)
  - -> `[77]` (*Player: "“I want it gone.”"*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“I only want to minimize the damage. The less prominent the story, the better.”"]** — Mówca: **Player**
> "“I only want to minimize the damage. The less prominent the story, the better.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Marcel Koronti: "“That's certainly within the realm of possibility. I can ..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“I want it gone.”"]** — Mówca: **Player**
> "“I want it gone.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Marcel Koronti: "“Alas, the event is too newsworthy to receive no coverage..."*)

### Węzeł `[78]`
Mówca: **Marcel Koronti**
> "“That's certainly within the realm of possibility. I can have you banished to the back pages in the next hour.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player: "“Do you think this could blow out of proportion?”"*)
  - -> `[84]` (*Player: "“And what would you want from me in return?”"*)

### Węzeł `[79]`
Mówca: **Marcel Koronti**
> "“Alas, the event is too newsworthy to receive no coverage. But I can have you banished to the back pages in the next hour.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: "“Your promise was about erasing mistakes.”"*)
  - -> `[81]` (*Player: "“How disappointing.”"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_News_Contained = true; BaseGameSupport.Journal_Turn05_Scandal_MediaUsed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn05_Admin_News_Contained"] = true;
Variable["BaseGameSupport.Journal_Turn05_Scandal_MediaUsed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: "“Looking forward to the results.”"*)
  - -> `[88]` (*Player: "“Thank you again.”"*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "“How disappointing.”"]** — Mówca: **Player**
> "“How disappointing.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Marcel Koronti: "“I'm not a Saint, Mr. President. I can not perform miracl..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "“Your promise was about erasing mistakes.”"]** — Mówca: **Player**
> "“Your promise was about erasing mistakes.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Marcel Koronti: "“I'm not a Saint, Mr. President. I can not perform miracl..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“Do you think this could blow out of proportion?”"]** — Mówca: **Player**
> "“Do you think this could blow out of proportion?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Marcel Koronti: "“A president replacing an invited speaker with his own wi..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“And what would you want from me in return?”"]** — Mówca: **Player**
> "“And what would you want from me in return?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Marcel Koronti: ""Oh, we'll worry about that when the time comes.”"*)

### Węzeł `[85]`
Mówca: **Marcel Koronti**
> ""Oh, we'll worry about that when the time comes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Marcel Koronti: "“So, do you want me to get to work?”"*)

### Węzeł `[86]`
Mówca: **Marcel Koronti**
> "“I'm not a Saint, Mr. President. I can not perform miracles. I too have my limits.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Marcel Koronti: "“But in times like these, I'm your personal lord and savi..."*)

### Węzeł `[87]`
Mówca: **Marcel Koronti**
> "“A president replacing an invited speaker with his own wife, then forcing him out of the ceremony itself? It might go international.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Marcel Koronti: "“So, do you want me to get to work?”"*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "“Thank you again.”"]** — Mówca: **Player**
> "“Thank you again. Have a good day.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Marcel Koronti: "“Don't you worry. Until next time, Mr. President.”"*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "“Looking forward to the results.”"]** — Mówca: **Player**
> "“Looking forward to the results. Enjoy your day, Marcel.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Marcel Koronti: "“Don't you worry. Until next time, Mr. President.”"*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "“If this... partnership comes to light, it would be an even bigger scandal.”"]** — Mówca: **Player**
> "“If this... partnership comes to light, it would be an even bigger scandal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Marcel Koronti: "“That is a big *if*, Mr. President, compared to what is h..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "“Yes. Handle the situation immediately.”"]** — Mówca: **Player**
> "“Yes. Handle the situation immediately.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Media_Influenced = true"*)

### Węzeł `[92]`
Mówca: **Marcel Koronti**
> "“So, do you want me to get to work?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: "“Yes. Handle the situation immediately.”"*)
  - -> `[90]` (*Player: "“If this... partnership comes to light, it would be an ev..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Media_Influenced = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn05_Admin_Media_Influenced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Marcel Koronti: "“Perfect. I'll call my contacts at the other papers first..."*)

### Węzeł `[94]`
Mówca: **Petr Vectern**
> "“Time to go into full damage control. This ought to end well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "Lucian departed, which left me and Petr in the room."*)

### Węzeł `[95]`
Mówca: **Lucian Galade**
> "“I know Mr. Koronti may have dubious intentions, but it's going to be difficult to contain this media backlash on our own.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Petr Vectern: "“Time to go into full damage control. This ought to end w..."*)

### Węzeł `[96]`
Mówca: **Marcel Koronti**
> "“Well in that case, I have no reason to be talking to you right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Marcel Koronti: "“Good luck to you.”"*)

### Węzeł `[97]`
Mówca: **Narrator**
> "Marcel hung up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Media_Influenced == true"*)

### Węzeł `[98]`
Mówca: **Marcel Koronti**
> "“Good luck to you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Marcel hung up the phone."*)

### Węzeł `[99]`
Mówca: **Marcel Koronti**
> ""After that, making the necessary changes to my own publication should be no trouble at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_News_Contained = true; BaseGameSupp..."*)

### Węzeł `[100]`
Mówca: **Marcel Koronti**
> "“Perfect. I'll call my contacts at the other papers first -- I should be able to persuade them to downplay the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Marcel Koronti: ""After that, making the necessary changes to my own publi..."*)

### Węzeł `[101]`
Mówca: **Marcel Koronti**
> "“Don't you worry. Until next time, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Marcel hung up the phone."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Media_Influenced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Media_Influenced == true"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_Media_Influenced == true)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Media_Influenced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Media_Influenced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Lucian Galade: "“I knew this partnership was the right decision. Mr. Koro..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_Media_Influenced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Media_Influenced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Lucian Galade: "“I know Mr. Koronti may have dubious intentions, but it's..."*)

### Węzeł `[105]`
Mówca: **Petr Vectern**
> "“I'm surprised he was so enthusiastic about it. But either way, he just made our lives easier.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "Lucian departed, which left me and Petr in the room."*)

### Węzeł `[106]`
Mówca: **Lucian Galade**
> "“I knew this partnership was the right decision. Mr. Koronti should be able to keep the incident under control.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Petr Vectern: "“I'm surprised he was so enthusiastic about it. But eithe..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "“Any plans for the holiday next month?”"]** — Mówca: **Player**
> "“Any plans for the holiday next month?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Petr Vectern: "“Ha. More of this, I suppose.”"*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "“How are things between you and Evelyn?”"]** — Mówca: **Player**
> "“How are things between you and Evelyn?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Petr Vectern: "“They're a little better, thanks.”"*)

### Węzeł `[109]`
Mówca: **Petr Vectern**
> "“Ha. More of this, I suppose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "He leaned back in his chair."*)

### Węzeł `[110]`
Mówca: **Petr Vectern**
> "“They're a little better, thanks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "He leaned back in his chair."*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "“How are the upcoming trade deals for Agnolia and Wehlen coming along?”"]** — Mówca: **Player**
> "“How are the upcoming trade deals for Agnolia and Wehlen coming along?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Petr Vectern: "“As well as expected. They had their own concerns, but th..."*)

### Węzeł `[112]`
Mówca: **Petr Vectern**
> "“As well as expected. They had their own concerns, but they'll fall in line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "He leaned back in his chair."*)

### Węzeł `[113]`
Mówca: **Petr Vectern**
> "“It's been a while since we had a drink or two together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player: "“Yes, it's been far too long. Shall we?”"*)
  - -> `[115]` (*Player: "“Maybe later.”"*)
  - -> `[166]` (*Player: "“For God's sake, Petr, it's six in the morning!”"*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Yes, it's been far too long. Shall we?”"]** — Mówca: **Player**
> "“Yes, it's been far too long. Shall we?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "At that very moment, the phone began to ring. The news wa..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Maybe later.”"]** — Mówca: **Player**
> "“Maybe later.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "At that very moment, the phone began to ring. The news wa..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn05_A_DamageControl = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn05_A_DamageControl"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[117]`
Mówca: **Petr Vectern**
> "“Right now Leste looks like the victim -- harangued for defending Sordland's precious cultural values until he had no choice but to leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Lucian Galade: "“The most important thing is the narrative. We need to re..."*)

### Węzeł `[118]`
Mówca: **Lucian Galade**
> "“If Sordland Today paints you in a favorable light, other publications are bound to follow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Petr Vectern: ""I still don't trust that man further than I could throw ..."*)

### Węzeł `[119]`
Mówca: **Curtan Leste**
> "“Enjoy the fallout.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "Curtan Leste hung up the phone."*)

### Węzeł `[120]`
Mówca: **Curtan Leste**
> "“What makes you think that I will hear anything you say? You had me thrown out, for God's sake!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "“It was a mistake. A grave one at that.”"*)
  - -> `[42]` (*Player: "“You insulted my wife. Would you have acted differently i..."*)

### Węzeł `[121]`
Mówca: **Narrator**
> "At that very moment, the phone began to ring. The news was out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Map_Music_Tense");  // Plays a custom..."*)

### Węzeł `[122]`
Mówca: **Livia Suno**
> "“I'll let you know once I have him on the line.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Livia Suno: "“I hope you won't make any compromises with Mr. Leste. He..."*)

### Węzeł `[123]`
Mówca: **Livia Suno**
> "“Mr. Vectern told me what happened. Should I connect you with the mayor directly?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: "“Yes please.”"*)
  - -> `[126]` (*Player: "“That would be appreciated.”"*)

### Węzeł `[124]`
Mówca: **Narrator**
> "Curtan had definitely not cooled off. I did not like his tone at all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Curtan Leste: "“What do you want, Rayne?""*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "“Yes please.”"]** — Mówca: **Player**
> "“Yes please.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Livia Suno: "“As you wish.”"*)

### Węzeł `[126]`
**[WYBÓR GRACZA: "“That would be appreciated.”"]** — Mówca: **Player**
> "“That would be appreciated.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Livia Suno: "“I'll let you know once I have him on the line.”"*)

### Węzeł `[127]`
Mówca: **Narrator**
> "Livia left the room to arrange the call. A few minutes later, the phone line lit up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "Curtan had definitely not cooled off. I did not like his ..."*)

### Węzeł `[128]`
Mówca: **Livia Suno**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Livia Suno: "“I hope you won't make any compromises with Mr. Leste. He..."*)

### Węzeł `[129]`
Mówca: **Livia Suno**
> "“I hope you won't make any compromises with Mr. Leste. He behaved like a pig at the festival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "Petr grinned. Lucian looked outraged."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "Marcel Koronti, the CEO of the HOS Conglomerate, was on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Marcel Koronti: "“I was wondering when you would call.”"*)

### Węzeł `[131]`
Mówca: **Narrator**
> "Livia left the room to arrange the call. A few minutes later, the telephone lit up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "Marcel Koronti, the CEO of the HOS Conglomerate, was on t..."*)

### Węzeł `[132]`
Mówca: **Livia Suno**
> "“To be honest, though, I think you should keep this deal in your pocket until you have a scandal worth covering up. Leste was completely in the wrong here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Petr grinned. Lucian looked outraged."*)

### Węzeł `[133]`
Mówca: **Livia Suno**
> "“I'll let you know once I have him on the line.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Livia Suno: "“To be honest, though, I think you should keep this deal ..."*)

### Węzeł `[134]`
Mówca: **Livia Suno**
> "“Mr. Vectern told me what happened. Should I connect you to Mr. Koronti directly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Player: "“Yes, please.”"*)
  - -> `[136]` (*Player: "“That would be appreciated.”"*)

### Węzeł `[135]`
**[WYBÓR GRACZA: "“Yes, please.”"]** — Mówca: **Player**
> "“Yes, please.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Livia Suno: "“As you wish.”"*)

### Węzeł `[136]`
**[WYBÓR GRACZA: "“That would be appreciated.”"]** — Mówca: **Player**
> "“That would be appreciated.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Livia Suno: "“I'll let you know once I have him on the line.”"*)

### Węzeł `[137]`
Mówca: **Livia Suno**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Livia Suno: "“To be honest, though, I think you should keep this deal ..."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "Petr left the room and came back with my secretary. She had on a short dress and dark eyeliner -- clearly she'd been counting on me being away at the festival for longer. Still, her demeanor was nothing but professional."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Livia Suno: "“Mr. Vectern told me what happened. Should I connect you ..."*)

### Węzeł `[139]`
Mówca: **Narrator**
> "Mayor Curtan Leste's untimely departure was bound to reflect badly on me. The only question was how much damage the incident would cause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Lucian Galade: "“The news is about to break, even as we speak. We must ac..."*)

### Węzeł `[140]`
**[WYBÓR GRACZA: "“I demand a public and formal apology for your behavior at the festival.""]** — Mówca: **Player**
> "“I demand a public and formal apology for your behavior at the festival.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Curtan Leste: "“Is that so? You've got some nerve.”"*)

### Węzeł `[141]`
Mówca: **Curtan Leste**
> "“Is that so? You've got some nerve.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true"*)

### Węzeł `[142]`
Mówca: **Curtan Leste**
> "“Why would I possibly apologize to you? You had me thrown out, for God's sake!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "“It was a mistake. A grave one at that.”"*)
  - -> `[42]` (*Player: "“You insulted my wife. Would you have acted differently i..."*)

### Węzeł `[143]`
Mówca: **Curtan Leste**
> "“That depends on you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Curtan Leste: "“Here is my demand.”"*)

### Węzeł `[144]`
Mówca: **Curtan Leste**
> "“Here is my demand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Curtan Leste: "“The First Lady won't be allowed to meddle in politics fr..."*)

### Węzeł `[145]`
Mówca: **Curtan Leste**
> "“The First Lady won't be allowed to meddle in politics from now on. No meetings. No advocating for her little causes. And certainly no speeches.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Curtan Leste: "“Should you fail to keep her from doing so, you can say y..."*)

### Węzeł `[146]`
Mówca: **Curtan Leste**
> "“Should you fail to keep her from doing so, you can say your goodbyes to Anrica.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Curtan Leste: ""On the other hand, if you do this, I will issue a full a..."*)

### Węzeł `[147]`
Mówca: **Curtan Leste**
> ""On the other hand, if you do this, I will issue a full apology and your party will retain my support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Curtan Leste: "“What will it be?”"*)

### Węzeł `[148]`
Mówca: **Curtan Leste**
> "“What will it be?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: "“I refuse. You are the one who is in the wrong. I won't p..."*)
  - -> `[149]` (*Player: "“You leave me no choice. I'll tell Monica she's out of po..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA: "“You leave me no choice. I'll tell Monica she's out of politics.""]** — Mówca: **Player**
> "“You leave me no choice. I'll tell Monica she's out of politics.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred = true; BaseGameSuppo..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA: "“I refuse. You are the one who is in the wrong. I won't punish her for your crimes.”"]** — Mówca: **Player**
> "“I refuse. You are the one who is in the wrong. I won't punish her for your crimes.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Curtan Leste: "“Wrong decision. I am disappointed, Mr. President.”"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred = true; BaseGameSupport.Journal_Turn05_Scandal_CurtanDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] = true;
Variable["BaseGameSupport.Journal_Turn05_Scandal_CurtanDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Curtan Leste: "“I'm glad that we came to terms.”"*)

### Węzeł `[152]`
Mówca: **Curtan Leste**
> "“I'm glad that we came to terms.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Curtan Leste: "“I will announce my public apology to the press immediate..."*)

### Węzeł `[153]`
Mówca: **Curtan Leste**
> "“I will announce my public apology to the press immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_News_Contained = true"*)

### Węzeł `[154]`
Mówca: **Curtan Leste**
> "“Have a good day, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "Curtan Leste hung up the phone."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_News_Contained = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn05_Admin_News_Contained"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Player: "“Thank you.”"*)
  - -> `[157]` (*Player: "“I will be waiting for it.”"*)

### Węzeł `[156]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you. Goodbye.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Curtan Leste: "“Have a good day, Mr. President.”"*)

### Węzeł `[157]`
**[WYBÓR GRACZA: "“I will be waiting for it.”"]** — Mówca: **Player**
> "“I will be waiting for it. Goodbye.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Curtan Leste: "“Have a good day, Mr. President.”"*)

### Węzeł `[158]`
**[WYBÓR GRACZA: "“Don't get cocky.”"]** — Mówca: **Player**
> "“Don't get cocky.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Marcel Koronti: "“Apologies for my behaviour, Mr. President, but we both k..."*)

### Węzeł `[159]`
Mówca: **Marcel Koronti**
> "“Apologies for my behaviour, Mr. President, but we both know that time is of the essence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Marcel Koronti: "“I've just seen the proofs for Sordland Today. It seems y..."*)

### Węzeł `[160]`
Mówca: **Marcel Koronti**
> "“But in times like these, I'm your personal lord and savior. You know that. Otherwise you wouldn't have called.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Marcel Koronti: "“So, do you want me to get to work?”"*)

### Węzeł `[161]`
Mówca: **Marcel Koronti**
> "“That is a big *if*, Mr. President, compared to what is happening *now*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Marcel Koronti: "“But it is your decision. So what will it be?”"*)

### Węzeł `[162]`
Mówca: **Marcel Koronti**
> "“But it is your decision. So what will it be?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player: "“Handle the situation immediately.”"*)
  - -> `[164]` (*Player: "“I changed my mind. It's too risky.”"*)

### Węzeł `[163]`
**[WYBÓR GRACZA: "“Handle the situation immediately.”"]** — Mówca: **Player**
> "“Handle the situation immediately.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Media_Influenced = true"*)

### Węzeł `[164]`
**[WYBÓR GRACZA: "“I changed my mind. It's too risky.”"]** — Mówca: **Player**
> "“I changed my mind. It's too risky.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Marcel Koronti: "“Well in that case, I have no reason to be talking to you..."*)

### Węzeł `[165]`
Mówca: **Narrator**
> "He leaned back in his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Petr Vectern: "“It's been a while since we had a drink or two together.”"*)

### Węzeł `[166]`
**[WYBÓR GRACZA: "“For God's sake, Petr, it's six in the morning!”"]** — Mówca: **Player**
> "“For God's sake, Petr, it's six in the morning!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "At that very moment, the phone began to ring. The news wa..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_Admin_Mayor_Media = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_Admin_Mayor_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucian Galade: ""Excellent choice. With his influence on the media, this ..."*)

### Węzeł `[168]`
Mówca: **Petr Vectern**
> "“Right now Leste looks like the victim, thrown out of the festival for defending Sordland's precious cultural values.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Lucian Galade: "“The most important thing is the narrative. We need to re..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteKicked == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Personal_Festival_LesteKicked == true)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteKicked == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Petr Vectern: "“Right now Leste looks like the victim, thrown out of the..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Personal_Festival_LesteKicked == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Petr Vectern: "“Right now Leste looks like the victim -- harangued for d..."*)

### Węzeł `[172]`
Mówca: **Lucian Galade**
> ""Considering he opted to leave the venue rather than deliver an apology last night, I would hardly expect one from him now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Petr Vectern: "“Maybe he's had time to cool off. I'll ask Livia to get h..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteKicked == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true"*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Personal_Festival_LesteKicked == true)"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteKicked == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lucian Galade: "“I don't expect much compliance after you forcefully remo..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Personal_Festival_LesteKicked == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Lucian Galade: ""Considering he opted to leave the venue rather than deli..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteKicked == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true"*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Personal_Festival_LesteKicked == true)"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteKicked == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Curtan Leste: "“Why would I possibly apologize to you? You had me thrown..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Personal_Festival_LesteKicked == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Curtan Leste: "“Why would I possibly apologize to you? You humiliated me..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteKicked == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true"*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Personal_Festival_LesteKicked == true)"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteKicked == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Curtan Leste: "“What makes you think that I will hear anything you say? ..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Personal_Festival_LesteKicked == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Curtan Leste: "“What makes you think that I will hear anything you say? ..."*)

### Węzeł `[182]`
Mówca: **Curtan Leste**
> "“What makes you think that I will hear anything you say? You humiliated me in front of my entire home city!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "“It was a mistake. A grave one at that.”"*)
  - -> `[42]` (*Player: "“You insulted my wife. Would you have acted differently i..."*)

### Węzeł `[183]`
Mówca: **Curtan Leste**
> "“Why would I possibly apologize to you? You humiliated me in front of my entire home city!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "“It was a mistake. A grave one at that.”"*)
  - -> `[42]` (*Player: "“You insulted my wife. Would you have acted differently i..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_Admin_Mayor_Apology = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_Admin_Mayor_Apology"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true"*)

### Węzeł `[185]`
Mówca: **Narrator**
> "Petr grinned. Lucian looked outraged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Lucian Galade: ""Talk to Koronti, Mr. President. Unless you'd rather take..."*)

### Węzeł `[186]`
Mówca: **Lucian Galade**
> ""Talk to Koronti, Mr. President. Unless you'd rather take advice from someone in a conical brassiere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "Livia left the room to arrange the call. A few minutes la..."*)

### Węzeł `[187]`
Mówca: **Lucian Galade**
> ""A compromise may be necessary, Mr. President. Unless you'd rather take advice from someone in a conical brassiere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "Livia left the room to arrange the call. A few minutes la..."*)

### Węzeł `[188]`
Mówca: **Narrator**
> "Petr grinned. Lucian looked outraged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Lucian Galade: ""A compromise may be necessary, Mr. President. Unless you..."*)

### Węzeł `[189]`
Mówca: **Lucian Galade**
> "“That does not look like it went good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Petr Vectern: "“Is there anything else we can do?”"*)

### Węzeł `[190]`
Mówca: **Petr Vectern**
> "“Is there anything else we can do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Lucian Galade: "“We could give a call to Mr. Koronti.”"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Lucian Galade: "“Unfortunately, I don't think so.”"*)

### Węzeł `[194]`
Mówca: **Lucian Galade**
> "“We could give a call to Mr. Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player: "“Agreed. Let's do it.”"*)
  - -> `[197]` (*Player: "“No. We will manage without him.”"*)

### Węzeł `[195]`
Mówca: **Lucian Galade**
> "“Unfortunately, I don't think so.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Lucian Galade: "“I'll start working on our official response to his apolo..."*)

### Węzeł `[196]`
**[WYBÓR GRACZA: "“Agreed. Let's do it.”"]** — Mówca: **Player**
> "“Agreed. Let's do it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucian Galade: ""Excellent choice. With his influence on the media, this ..."*)

### Węzeł `[197]`
**[WYBÓR GRACZA: "“No. We will manage without him.”"]** — Mówca: **Player**
> "“No. We will manage without him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Lucian Galade: "“Very well.”"*)

### Węzeł `[198]`
Mówca: **Lucian Galade**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Lucian Galade: "“I'll start working on our official response to his apolo..."*)

### Węzeł `[199]`
**[WYBÓR GRACZA: "“Let's just talk to him. He can't stay angry forever.”"]** — Mówca: **Player**
> "“Let's just talk to him. He can't stay angry forever.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true"*)

### Węzeł `[200]`
Mówca: **Lucian Galade**
> ""Considering he opted to leave the venue rather than deliver an apology last night, I would hardly expect anything from him now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Petr Vectern: "“Maybe he's had time to cool off. I'll ask Livia to get h..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteKicked == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Personal_Festival_LesteKicked == true)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteKicked == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Lucian Galade: "“I don't expect much compliance after you forcefully remo..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Personal_Festival_LesteKicked == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Lucian Galade: ""Considering he opted to leave the venue rather than deli..."*)

### Węzeł `[204]`
Mówca: **Lucian Galade**
> "“I don't expect much compliance after you forcefully removed him from the venue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Petr Vectern: "“Maybe he's had time to cool off. I'll ask Livia to get h..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayCustomMapMusic("Map_Music_Tense");

// Plays a custom map music after conversation is done. This works only once for one conversation`
- **Efekt skryptowy (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");
-- Plays a custom map music after conversation is done. This works only once for one conversation;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_A_DamageControl = true"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
