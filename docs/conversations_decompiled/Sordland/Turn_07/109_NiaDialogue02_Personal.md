# Sordland/Turn07/NiaDialogue02_Personal

- **ID konwersacji:** `109`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/109_NiaDialogue02_Personal.md`
- **Liczba węzłów dialogowych:** 196
- **Liczba wyborów gracza:** 66

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Policy_Economy_PromoteMarket`
- `BaseGame.Policy_Order_AntiCorruptionPolice`
- `BaseGame.Prologue_Party_Congress_Soll`
- `BaseGame.Prologue_University_Political_Nationalist`
- `BaseGame.Prologue_University_Political_Socialist`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[107] Sordland/Turn07/A_ConvinceIsabel** (../Turn_07/107_A_ConvinceIsabel.md), Węzeł `[33]`
- Węzeł `[37]` -> **[107] Sordland/Turn07/A_ConvinceIsabel** (../Turn_07/107_A_ConvinceIsabel.md), Węzeł `[46]`
- Węzeł `[103]` -> **[107] Sordland/Turn07/A_ConvinceIsabel** (../Turn_07/107_A_ConvinceIsabel.md), Węzeł `[46]`
- Węzeł `[126]` -> **[107] Sordland/Turn07/A_ConvinceIsabel** (../Turn_07/107_A_ConvinceIsabel.md), Węzeł `[46]`
- Węzeł `[149]` -> **[107] Sordland/Turn07/A_ConvinceIsabel** (../Turn_07/107_A_ConvinceIsabel.md), Węzeł `[46]`
- Węzeł `[165]` -> **[107] Sordland/Turn07/A_ConvinceIsabel** (../Turn_07/107_A_ConvinceIsabel.md), Węzeł `[46]`
- Węzeł `[195]` -> **[107] Sordland/Turn07/A_ConvinceIsabel** (../Turn_07/107_A_ConvinceIsabel.md), Węzeł `[46]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **""So... let's just move on to our plan with Isabel.""** | `[9]` **Narrator**: "Nia took a sip from her glass of..."<br>`[35]` **Narrator**: "She didn't say anything and lean..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Player**: ""Soll wasn't that bad."" |
| `[6]` | **""But seriously, I want to know more about you.""** | `[146]` **Narrator**: "She let out a short laughter." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Nia Morgna**: ""I mean... I don't really know w..." |
| `[8]` | **""Let's talk about you a little.""** | `[9]` **Narrator**: "Nia took a sip from her glass of..."<br>`[35]` **Narrator**: "She didn't say anything and lean..."<br>*(oraz 5 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Nia Morgna**: ""Me?"" |
| `[10]` | **""Do you think we'll succeed?""** | `[9]` **Narrator**: "Nia took a sip from her glass of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Nia Morgna**: ""Yes. I believe we are in a good..."<br>`[17]` **Nia Morgna**: ""I'd like to hope so, yes."" |
| `[11]` | **"Stay silent."** | `[9]` **Narrator**: "Nia took a sip from her glass of..."<br>`[32]` **Narrator**: "She took another sip from her gl..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "She didn't say anything and lean..." |
| `[20]` | **""Where is Isabel? I don't like waiting.""** | `[4]` **Nia Morgna**: ""Thank you. That means a lot.""<br>`[95]` **Nia Morgna**: ""Thank you, Mr. President. I res..."<br>*(oraz 10 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Nia Morgna**: ""I'm sure she'll be here shortly."" |
| `[26]` | **""Anyway, let's talk about what we'll do with Isabel.""** | `[4]` **Nia Morgna**: ""Thank you. That means a lot.""<br>`[95]` **Nia Morgna**: ""Thank you, Mr. President. I res..."<br>*(oraz 10 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Player**: ""Soll wasn't that bad."" |
| `[28]` | **""I don't think they are what they used to be. It changed a lot.""** | `[186]` **Nia Morgna**: ""What do you think about them now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Nia Morgna**: ""I agree."" |
| `[31]` | **""Hmm. I used to be part of the Red Youth during my university years.""** | `[59]` **Nia Morgna**: ""How about you tell me something..." | `Variable["BaseGame.Prologue_University_Political_Socialist"] == true` | *Brak zmian stanu* | `[111]` **Nia Morgna**: ""Oh really?"" |
| `[36]` | **""Hmm. I used to be part of the Young Sords during my university years.""** | `[59]` **Nia Morgna**: ""How about you tell me something..." | `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true` | *Brak zmian stanu* | `[113]` **Nia Morgna**: ""Are you kidding me?"" |
| `[38]` | **"Keep staying silent."** | `[35]` **Narrator**: "She didn't say anything and lean..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Narrator**: "She watched the beautiful sunset..." |
| `[39]` | **""You and I. We are a strong team Nia. We will succeed.""** | `[114]` **Nia Morgna**: ""I hope we succeed."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Nia Morgna**: ""Do you really think we're a str..." |
| `[42]` | **""Alphonso was just a rich businessman. I couldn't trust him.""** | `[75]` **Nia Morgna**: ""So you really did support Tarqu..."<br>`[77]` **Nia Morgna**: ""So you really did support Tarqu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Nia Morgna**: ""Anyway... I think Isabel is goi..." |
| `[43]` | **"Look at her."** | `[40]` **Narrator**: "She watched the beautiful sunset..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Narrator**: "She smiled at me, then averted h..." |
| `[44]` | **""I didn't support Alphonso's free market policies.""** | `[75]` **Nia Morgna**: ""So you really did support Tarqu..."<br>`[77]` **Nia Morgna**: ""So you really did support Tarqu..." | `Variable["BaseGame.Policy_Economy_PromoteMarket"] == true` | *Brak zmian stanu* | `[24]` **Nia Morgna**: ""Anyway... I think Isabel is goi..." |
| `[45]` | **"Watch the sunset."** | `[40]` **Narrator**: "She watched the beautiful sunset..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Nia Morgna**: ""So..."" |
| `[46]` | **""Soll wasn't that bad.""** | `[75]` **Nia Morgna**: ""So you really did support Tarqu..."<br>`[77]` **Nia Morgna**: ""So you really did support Tarqu..."<br>*(oraz 9 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Nia Morgna**: ""Anyway... I think Isabel is goi..." |
| `[51]` | **""They became a militant extremist group that threatens Sordland.""** | `[186]` **Nia Morgna**: ""What do you think about them now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Nia Morgna**: ""It is true that they have a mil..." |
| `[53]` | **""You and I. We are a strong team Nia.""** | `[95]` **Nia Morgna**: ""Thank you, Mr. President. I res..."<br>`[174]` **Narrator**: "She smiled." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Nia Morgna**: ""Do you really think so?"" |
| `[56]` | **""Yes. How have you been holding up these rough days?""** | `[54]` **Nia Morgna**: ""Me?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Nia Morgna**: ""I'm fine, Mr. President. Thanks..." |
| `[57]` | **""So... How about you? How have you been holding up?""** | `[48]` **Nia Morgna**: ""So...""<br>`[50]` **Nia Morgna**: ""So...""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Nia Morgna**: ""I'm fine, Mr. President. Thanks..." |
| `[58]` | **""Is everything fine with you?""** | `[54]` **Nia Morgna**: ""Me?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Nia Morgna**: ""I'm fine, Mr. President. Thanks..." |
| `[60]` | **""I'm disappointed that you couldn't get the Court for me.""** | `[54]` **Nia Morgna**: ""Me?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Nia Morgna**: ""I thought you were aware about ..." |
| `[61]` | **""Honestly, I still support their cause.""** | `[186]` **Nia Morgna**: ""What do you think about them now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Nia Morgna**: ""Interesting..."" |
| `[62]` | **""Yes. I want to know more about you.""** | `[54]` **Nia Morgna**: ""Me?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Nia Morgna**: ""What do you want to know?"" |
| `[84]` | **""It's not the end of the world if it doesn't go through.""** | `[82]` **Nia Morgna**: ""I just... don't want to see ano..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Nia Morgna**: ""Great motivational speech, Mr. ..." |
| `[86]` | **""That's why we can't become another Alphonso administration.""** | `[82]` **Nia Morgna**: ""I just... don't want to see ano..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Nia Morgna**: ""You're exactly right. I've had ..." |
| `[90]` | **""Me neither, Mrs. Morgna. We have to make sure we succeed.""** | `[82]` **Nia Morgna**: ""I just... don't want to see ano..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Nia Morgna**: ""I've done my best so far, Mr. P..." |
| `[92]` | **""Don't let your emotions get in the way.""** | `[82]` **Nia Morgna**: ""I just... don't want to see ano..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Nia Morgna**: ""Of course, Mr. President."" |
| `[99]` | **""There is not much to tell. I am a pretty regular man outside politics.""** | `[59]` **Nia Morgna**: ""How about you tell me something..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Nia Morgna**: ""Well yes, that's the same for m..." |
| `[105]` | **""What do you want to know?""** | `[59]` **Nia Morgna**: ""How about you tell me something..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Nia Morgna**: ""Hmm... "" |
| `[109]` | **""Did you know that I am one of the top four best presidents of Sordland?""** | `[59]` **Nia Morgna**: ""How about you tell me something..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Narrator**: "She frowned at me first and then..." |
| `[116]` | **""It was obvious that he would win. I saw that as an investment.""** | `[134]` **Nia Morgna**: ""Tell me, Mr. President... Why d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Nia Morgna**: ""I see..."" |
| `[117]` | **""Tell me about your past.""** | `[78]` **Nia Morgna**: ""What do you want to know?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Nia Morgna**: ""My past? I thought you've read ..." |
| `[118]` | **""It was time for Soll to leave. He was the only alternative.""** | `[134]` **Nia Morgna**: ""Tell me, Mr. President... Why d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Nia Morgna**: ""That's true. He was the only op..." |
| `[119]` | **""We usually don't have time to talk alone. I was just interested to know more abou..."** | `[78]` **Nia Morgna**: ""What do you want to know?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Nia Morgna**: ""Oh, okay."" |
| `[120]` | **""At the time, I really believed that Alphonso would do great things.""** | `[134]` **Nia Morgna**: ""Tell me, Mr. President... Why d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Nia Morgna**: ""I had the exact same belief. He..." |
| `[121]` | **""What do you aim to achieve?""** | `[78]` **Nia Morgna**: ""What do you want to know?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Nia Morgna**: ""A fair and transparent justice ..." |
| `[125]` | **""We'll do it together.""** | `[135]` **Nia Morgna**: ""Thank you, Mr. President. I res..."<br>`[138]` **Nia Morgna**: ""Toppling Soll's Constitution wo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Nia Morgna**: ""Yes. We will, Mr. President!"" |
| `[127]` | **""I respect that.""** | `[49]` **Nia Morgna**: ""This was always what I've worke..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Nia Morgna**: ""Thank you, Mr. President. I res..." |
| `[128]` | **""At the time, I really wanted him to continue leading the party.""** | `[136]` **Nia Morgna**: ""Tell me, Mr. President... Why d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Nia Morgna**: ""So you really did support Tarqu..." |
| `[129]` | **""I meant other than that.""** | `[49]` **Nia Morgna**: ""This was always what I've worke..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Nia Morgna**: ""Hmm. You mean more personal aim..." |
| `[130]` | **""He promised me a seat in his cabinet. I couldn't say no.""** | `[136]` **Nia Morgna**: ""Tell me, Mr. President... Why d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Nia Morgna**: ""I see..."" |
| `[131]` | **""For some reason I'm sceptical about that.""** | `[49]` **Nia Morgna**: ""This was always what I've worke..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Nia Morgna**: ""What do you mean? Have you seen..." |
| `[132]` | **""I didn't want Alphonso's leadership.""** | `[136]` **Nia Morgna**: ""Tell me, Mr. President... Why d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Nia Morgna**: ""So you really did support Tarqu..." |
| `[140]` | **""I can achieve anything with a woman like you by my side.""** | `[4]` **Nia Morgna**: ""Thank you. That means a lot.""<br>`[12]` **Nia Morgna**: ""Do you really think we're a str..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Narrator**: "She took a while to respond." |
| `[150]` | **""If you don't want to share, it's okay.""** | `[146]` **Narrator**: "She let out a short laughter." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Nia Morgna**: ""I mean... I don't really know w..." |
| `[151]` | **""You are a strong woman, Nia.""** | `[135]` **Nia Morgna**: ""Thank you, Mr. President. I res..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[4]` **Nia Morgna**: ""Thank you. That means a lot."" |
| `[152]` | **""I guess that's correct.""** | `[146]` **Narrator**: "She let out a short laughter." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Nia Morgna**: ""I mean... I don't really know w..." |
| `[153]` | **""Of course. We have done a great deal so far.""** | `[12]` **Nia Morgna**: ""Do you really think we're a str..."<br>`[18]` **Nia Morgna**: ""Do you really think so?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Nia Morgna**: ""Thank you. It really means a lot."" |
| `[155]` | **""I couldn't do any of this without you.""** | `[12]` **Nia Morgna**: ""Do you really think we're a str..."<br>`[18]` **Nia Morgna**: ""Do you really think so?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Nia Morgna**: ""Thank you. It really means a lot."" |
| `[158]` | **""They became a militant extremist group that threatens Sordland.""** | `[107]` **Nia Morgna**: ""What do you think about them now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Nia Morgna**: ""I think it was always just *tha..." |
| `[159]` | **""Time will tell.""** | `[12]` **Nia Morgna**: ""Do you really think we're a str..."<br>`[18]` **Nia Morgna**: ""Do you really think so?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Nia Morgna**: ""I guess so."" |
| `[164]` | **""That's not what I meant.""** | `[115]` **Nia Morgna**: ""I don't really know what to say..."<br>`[160]` **Nia Morgna**: ""I mean... I don't really know w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Nia Morgna**: ""Well..."" |
| `[167]` | **""Anyway, let's talk about what we'll do with Isabel.""** | `[115]` **Nia Morgna**: ""I don't really know what to say..."<br>`[160]` **Nia Morgna**: ""I mean... I don't really know w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Player**: ""Soll wasn't that bad."" |
| `[170]` | **""It's okay, I didn't want to put you on the spot.""** | `[115]` **Nia Morgna**: ""I don't really know what to say..."<br>`[160]` **Nia Morgna**: ""I mean... I don't really know w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Nia Morgna**: ""It's fine, Mr. President."" |
| `[171]` | **""Anyway, let's talk about what we'll do with Isabel.""** | `[48]` **Nia Morgna**: ""So...""<br>`[50]` **Nia Morgna**: ""So..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Player**: ""Soll wasn't that bad."" |
| `[173]` | **""Where is Isabel? I don't like waiting.""** | `[48]` **Nia Morgna**: ""So...""<br>`[50]` **Nia Morgna**: ""So..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[163]` **Nia Morgna**: ""I'm sure she'll be here shortly."" |
| `[176]` | **""I respect that a lot.""** | `[138]` **Nia Morgna**: ""Toppling Soll's Constitution wo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Nia Morgna**: ""Thank you, Mr. President. I res..." |
| `[178]` | **""I'm sorry, you've got me wrong.""** | `[133]` **Nia Morgna**: ""What do you mean? Have you seen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Nia Morgna**: ""Really?"" |
| `[180]` | **""Come on, Nia. I'm just trying to have a conversation.""** | `[115]` **Nia Morgna**: ""I don't really know what to say..."<br>`[160]` **Nia Morgna**: ""I mean... I don't really know w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Nia Morgna**: ""Well..."" |
| `[181]` | **""The way you said it felt like it was a rehearsed statement.""** | `[133]` **Nia Morgna**: ""What do you mean? Have you seen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Nia Morgna**: ""Really?"" |
| `[189]` | **""Don't worry, we've got this.""** | `[104]` **Nia Morgna**: ""She's the last remaining piece ..."<br>`[106]` **Nia Morgna**: ""I'm slightly scared that Isabel..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Nia Morgna**: ""I hope we succeed."" |
| `[192]` | **""Honestly, I still support their cause.""** | `[107]` **Nia Morgna**: ""What do you think about them now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Nia Morgna**: ""You do?"" |
| `[193]` | **""Not really.""** | `[112]` **Nia Morgna**: ""I guess it's not so different t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Nia Morgna**: ""I hope we succeed."" |
| `[194]` | **""I don't think they are what they used to be. It changed a lot.""** | `[107]` **Nia Morgna**: ""What do you think about them now?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Nia Morgna**: ""Well, I guess that's true."" |

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
  - -> `[9]` (*Narrator: "Nia took a sip from her glass of water and looked at me."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "Jump to: [NiaHub2]"*)

### Węzeł `[3]`
**[WYBÓR GRACZA: ""So... let's just move on to our plan with Isabel.""]** — Mówca: **Player**
> ""So... let's just move on to our plan with Isabel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[35]` (Narrator), `[40]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "Jump to: [NiaHubEnd]"*)

### Węzeł `[4]`
Mówca: **Nia Morgna**
> ""Thank you. That means a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "NiaHub3"*)
  - -> `[140]` (*Player: ""I can achieve anything with a woman like you by my side.""*)

### Węzeł `[5]`
Mówca: **Nia Morgna**
> ""Hmm... ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "She took another sip from her glass."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: ""But seriously, I want to know more about you.""]** — Mówca: **Player**
> ""But seriously, I want to know more about you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Nia Morgna: ""I mean... I don't really know what to say. You already k..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "She looked at me with surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Nia Morgna: ""I didn't know that.""*)

### Węzeł `[8]`
**[WYBÓR GRACZA: ""Let's talk about you a little.""]** — Mówca: **Player**
> ""Let's talk about you a little.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[35]` (Narrator), `[40]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Nia Morgna: ""Me?""*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Nia took a sip from her glass of water and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player: ""So... let's just move on to our plan with Isabel.""*)
  - -> `[8]` (*Player: ""Let's talk about you a little.""*)
  - -> `[10]` (*Player: ""Do you think we'll succeed?""*)
  - -> `[11]` (*Player_Italic: "Stay silent."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: ""Do you think we'll succeed?""]** — Mówca: **Player**
> ""Do you think we'll succeed?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I stayed silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[32]` (Narrator), `[24]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "She didn't say anything and leaned over to look out the w..."*)

### Węzeł `[12]`
Mówca: **Nia Morgna**
> ""Do you really think we're a strong team though?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player: ""Of course. We have done a great deal so far.""*)
  - -> `[155]` (*Player: ""I couldn't do any of this without you.""*)
  - -> `[159]` (*Player: ""Time will tell.""*)
  - -> `[140]` (*Player: ""I can achieve anything with a woman like you by my side.""*)

### Węzeł `[13]`
Mówca: **Nia Morgna**
> ""Yes. I believe we are in a good position now. The anti-corruption force helped a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Nia Morgna: ""We only need either Isabel's or Heron's vote.""*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_AntiCorruptionPolice == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Nia Morgna: ""Yes. I believe we are in a good position now. The anti-c..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Nia Morgna: ""I'd like to hope so, yes.""*)

### Węzeł `[17]`
Mówca: **Nia Morgna**
> ""I'd like to hope so, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Nia Morgna: ""We might need to get both Isabel and Heron to work with ..."*)

### Węzeł `[18]`
Mówca: **Nia Morgna**
> ""Do you really think so?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player: ""Of course. We have done a great deal so far.""*)
  - -> `[155]` (*Player: ""I couldn't do any of this without you.""*)
  - -> `[159]` (*Player: ""Time will tell.""*)
  - -> `[140]` (*Player: ""I can achieve anything with a woman like you by my side.""*)

### Węzeł `[19]`
Mówca: **Nia Morgna**
> ""We only need either Isabel's or Heron's vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "She smiled."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""Where is Isabel? I don't like waiting.""]** — Mówca: **Player**
> ""Where is Isabel? I don't like waiting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Nia Morgna), `[95]` (Nia Morgna), `[96]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Nia Morgna: ""I'm sure she'll be here shortly.""*)

### Węzeł `[21]`
Mówca: **Nia Morgna**
> ""Come on, Mr. President. Don't overthink this. We just need to focus on Isabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Nia Morgna: ""But anyway...""*)

### Węzeł `[22]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Nia Morgna: ""Come on, Mr. President. Don't overthink this. We just ne..."*)

### Węzeł `[23]`
Mówca: **Nia Morgna**
> ""We might need to get both Isabel and Heron to work with us. I don't want to rely on Isabel to bring exactly three votes. It's risky.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Nia Morgna: ""Let's not overthink this though, Mr. President. We have ..."*)

### Węzeł `[24]`
Mówca: **Nia Morgna**
> ""Anyway... I think Isabel is going to be here very soon. Maybe we should return back to the topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `NiaHub2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player: ""So... let's just move on to our plan with Isabel.""*)
  - -> `[8]` (*Player: ""Let's talk about you a little.""*)
  - -> `[57]` (*Player: ""So... How about you? How have you been holding up?""*)
  - -> `[11]` (*Player_Italic: "Stay silent."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""Anyway, let's talk about what we'll do with Isabel.""]** — Mówca: **Player**
> ""Anyway, let's talk about what we'll do with Isabel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Nia Morgna), `[95]` (Nia Morgna), `[96]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "Jump to: [NiaHubEnd]"*)

### Węzeł `[27]`
Mówca: **Nia Morgna**
> ""But anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "She took another sip from her glass."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: ""I don't think they are what they used to be. It changed a lot.""]** — Mówca: **Player**
> ""I don't think they are what they used to be. It changed a lot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Nia Morgna: ""I agree.""*)

### Węzeł `[29]`
Mówca: **Nia Morgna**
> ""Let's not overthink this though, Mr. President. We have to focus on the meeting with Isabel now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Nia Morgna: ""But anyway...""*)

### Węzeł `[30]`
Mówca: **Nia Morgna**
> ""Very funny, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "She took another sip from her glass."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: ""Hmm. I used to be part of the Red Youth during my university years.""]** — Mówca: **Player**
> ""Hmm. I used to be part of the Red Youth during my university years.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Kontekst wejściowy (poprzednik):** `[59]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Nia Morgna: ""Oh really?""*)

### Węzeł `[32]`
Mówca: **Narrator**
> "She took another sip from her glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "Jump to: [NiaHub2]"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [NiaHub2]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "NiaHub2"*)

### Węzeł `[34]`
Mówca: **Nia Morgna**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Nia Morgna: ""How about you tell me something first?""*)

### Węzeł `[35]`
Mówca: **Narrator**
> "She didn't say anything and leaned over to look out the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player: ""So... let's just move on to our plan with Isabel.""*)
  - -> `[8]` (*Player: ""Let's talk about you a little.""*)
  - -> `[38]` (*Player_Italic: "Keep staying silent."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: ""Hmm. I used to be part of the Young Sords during my university years.""]** — Mówca: **Player**
> ""Hmm. I used to be part of the Young Sords during my university years.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Kontekst wejściowy (poprzednik):** `[59]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Nia Morgna: ""Are you kidding me?""*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [NiaHubEnd]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""Soll wasn't that bad.""*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "Keep staying silent."]** — Mówca: **Player_Italic**
> "I kept silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "She watched the beautiful sunset from the window. Then sh..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""You and I. We are a strong team Nia. We will succeed.""]** — Mówca: **Player**
> ""You and I. We are a strong team Nia. We will succeed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Nia Morgna: ""Do you really think we're a strong team though?""*)

### Węzeł `[40]`
Mówca: **Narrator**
> "She watched the beautiful sunset from the window. Then she brought her eyes back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player: ""So... let's just move on to our plan with Isabel.""*)
  - -> `[8]` (*Player: ""Let's talk about you a little.""*)
  - -> `[43]` (*Player_Italic: "Look at her."*)
  - -> `[45]` (*Player_Italic: "Watch the sunset."*)

### Węzeł `[41]`
Mówca: **Nia Morgna**
> ""I'm sure she'll be here shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "Jump to: [NiaHubEnd]"*)

### Węzeł `[42]`
**[WYBÓR GRACZA: ""Alphonso was just a rich businessman. I couldn't trust him.""]** — Mówca: **Player**
> ""Alphonso was just a rich businessman. I couldn't trust him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Nia Morgna), `[77]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Nia Morgna: ""Anyway... I think Isabel is going to be here very soon. ..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "Look at her."]** — Mówca: **Player_Italic**
> "I looked back at her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "She smiled at me, then averted her gaze."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: ""I didn't support Alphonso's free market policies.""]** — Mówca: **Player**
> ""I didn't support Alphonso's free market policies.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Economy_PromoteMarket"] == true`
- **Kontekst wejściowy (poprzednik):** `[75]` (Nia Morgna), `[77]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Nia Morgna: ""Anyway... I think Isabel is going to be here very soon. ..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "Watch the sunset."]** — Mówca: **Player_Italic**
> "I looked out the window and saw the crimson sky with almost maroon-colored clouds over the horizon."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Nia Morgna: ""So...""*)

### Węzeł `[46]`
**[WYBÓR GRACZA: ""Soll wasn't that bad.""]** — Mówca: **Player**
> ""Soll wasn't that bad.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Nia Morgna), `[77]` (Nia Morgna), `[26]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Nia Morgna: ""Anyway... I think Isabel is going to be here very soon. ..."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "She smiled at me, then averted her gaze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Nia Morgna: ""So...""*)

### Węzeł `[48]`
Mówca: **Nia Morgna**
> ""So...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player: ""Let's talk about you a little.""*)
  - -> `[57]` (*Player: ""So... How about you? How have you been holding up?""*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "NiaHub3"*)

### Węzeł `[49]`
Mówca: **Nia Morgna**
> ""This was always what I've worked towards. Nothing has changed one bit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player: ""I respect that.""*)
  - -> `[129]` (*Player: ""I meant other than that.""*)
  - -> `[131]` (*Player: ""For some reason I'm sceptical about that.""*)

### Węzeł `[50]`
Mówca: **Nia Morgna**
> ""So...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player: ""Let's talk about you a little.""*)
  - -> `[57]` (*Player: ""So... How about you? How have you been holding up?""*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "NiaHub3"*)

### Węzeł `[51]`
**[WYBÓR GRACZA: ""They became a militant extremist group that threatens Sordland.""]** — Mówca: **Player**
> ""They became a militant extremist group that threatens Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Nia Morgna: ""It is true that they have a militant wing but I wouldn't..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `NiaHub3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: ""Anyway, let's talk about what we'll do with Isabel.""*)
  - -> `[20]` (*Player: ""Where is Isabel? I don't like waiting.""*)

### Węzeł `[53]`
**[WYBÓR GRACZA: ""You and I. We are a strong team Nia.""]** — Mówca: **Player**
> ""You and I. We are a strong team Nia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Nia Morgna), `[174]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Nia Morgna: ""Do you really think so?""*)

### Węzeł `[54]`
Mówca: **Nia Morgna**
> ""Me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: ""Yes. I want to know more about you.""*)
  - -> `[56]` (*Player: ""Yes. How have you been holding up these rough days?""*)
  - -> `[58]` (*Player: ""Is everything fine with you?""*)
  - -> `[60]` (*Player: ""I'm disappointed that you couldn't get the Court for me.""*)

### Węzeł `[55]`
Mówca: **Nia Morgna**
> ""Well yes, that's the same for me too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "She took another sip from her glass."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: ""Yes. How have you been holding up these rough days?""]** — Mówca: **Player**
> ""Yes. How have you been holding up these rough days?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Nia Morgna: ""I'm fine, Mr. President. Thanks for asking.""*)

### Węzeł `[57]`
**[WYBÓR GRACZA: ""So... How about you? How have you been holding up?""]** — Mówca: **Player**
> ""So... How about you? How have you been holding up?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Nia Morgna), `[50]` (Nia Morgna), `[32]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Nia Morgna: ""I'm fine, Mr. President. Thanks for asking.""*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""Is everything fine with you?""]** — Mówca: **Player**
> ""Is everything fine with you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Nia Morgna: ""I'm fine, Mr. President. Thanks for asking.""*)

### Węzeł `[59]`
Mówca: **Nia Morgna**
> ""How about you tell me something first?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: ""What do you want to know?""*)
  - -> `[109]` (*Player: ""Did you know that I am one of the top four best presiden..."*)
  - -> `[99]` (*Player: ""There is not much to tell. I am a pretty regular man out..."*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)

### Węzeł `[60]`
**[WYBÓR GRACZA: ""I'm disappointed that you couldn't get the Court for me.""]** — Mówca: **Player**
> ""I'm disappointed that you couldn't get the Court for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Nia Morgna: ""I thought you were aware about the situation in the Court.""*)

### Węzeł `[61]`
**[WYBÓR GRACZA: ""Honestly, I still support their cause.""]** — Mówca: **Player**
> ""Honestly, I still support their cause.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Nia Morgna: ""Interesting...""*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""Yes. I want to know more about you.""]** — Mówca: **Player**
> ""Yes. I want to know more about you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Nia Morgna: ""What do you want to know?""*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_PromoteMarket == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromoteMarket == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_PromoteMarket == true)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_PromoteMarket == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_PromoteMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: ""I didn't support Alphonso's free market policies.""*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_PromoteMarket == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_PromoteMarket"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[66]`
Mówca: **Nia Morgna**
> ""I thought you were aware about the situation in the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Nia Morgna: ""I already have two Justices working with me. The court i..."*)

### Węzeł `[67]`
Mówca: **Nia Morgna**
> ""It's fine, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Nia Morgna: ""How about you tell me something first?""*)

### Węzeł `[68]`
Mówca: **Nia Morgna**
> ""I already have two Justices working with me. The court is dominated by Orso's crew so there's not much room to work with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Nia Morgna: ""Also, let's not forget that I persuaded Isabel into meet..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "She frowned at me first and then smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Nia Morgna: ""Very funny, Mr. President.""*)

### Węzeł `[70]`
Mówca: **Nia Morgna**
> ""Also, let's not forget that I persuaded Isabel into meeting with you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Nia Morgna: ""But anyway, she'll be here soon.""*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Nationalist == t..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: ""Hmm. I used to be part of the Young Sords during my univ..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Nationalist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[74]`
Mówca: **Nia Morgna**
> ""But anyway, she'll be here soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "Jump to: [NiaHubEnd]"*)

### Węzeł `[75]`
Mówca: **Nia Morgna**
> ""So you really did support Tarquin Soll...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""Soll wasn't that bad.""*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromoteMarket == true"*)
  - -> `[42]` (*Player: ""Alphonso was just a rich businessman. I couldn't trust h..."*)

### Węzeł `[76]`
Mówca: **Nia Morgna**
> ""I'm fine, Mr. President. Thanks for asking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Nia Morgna: ""I'm just focused on our proposal. If it passes the Supre..."*)

### Węzeł `[77]`
Mówca: **Nia Morgna**
> ""So you really did support Tarquin Soll...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""Soll wasn't that bad.""*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromoteMarket == true"*)
  - -> `[42]` (*Player: ""Alphonso was just a rich businessman. I couldn't trust h..."*)

### Węzeł `[78]`
Mówca: **Nia Morgna**
> ""What do you want to know?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: ""Tell me about your past.""*)
  - -> `[119]` (*Player: ""We usually don't have time to talk alone. I was just int..."*)
  - -> `[121]` (*Player: ""What do you aim to achieve?""*)

### Węzeł `[79]`
Mówca: **Narrator**
> "She was not at all impressed with my reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Nia Morgna: ""Anyway... I think Isabel is going to be here very soon. ..."*)

### Węzeł `[80]`
Mówca: **Nia Morgna**
> ""I'm just focused on our proposal. If it passes the Supreme Court, this will be a historical moment for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Nia Morgna: ""I just... don't want to see another failure trying to ch..."*)

### Węzeł `[81]`
Mówca: **Nia Morgna**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "She was not at all impressed with my reply."*)

### Węzeł `[82]`
Mówca: **Nia Morgna**
> ""I just... don't want to see another failure trying to change this Constitution anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: ""That's why we can't become another Alphonso administrati..."*)
  - -> `[90]` (*Player: ""Me neither, Mrs. Morgna. We have to make sure we succeed.""*)
  - -> `[84]` (*Player: ""It's not the end of the world if it doesn't go through.""*)
  - -> `[92]` (*Player: ""Don't let your emotions get in the way.""*)

### Węzeł `[83]`
Mówca: **Nia Morgna**
> ""I had the exact same belief. He proved us wrong very quickly though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Nia Morgna: ""Anyway... I think Isabel is going to be here very soon. ..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: ""It's not the end of the world if it doesn't go through.""]** — Mówca: **Player**
> ""It's not the end of the world if it doesn't go through.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Nia Morgna: ""Great motivational speech, Mr. President.""*)

### Węzeł `[85]`
Mówca: **Nia Morgna**
> ""That's true. He was the only option for sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Nia Morgna: ""Anyway... I think Isabel is going to be here very soon. ..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""That's why we can't become another Alphonso administration.""]** — Mówca: **Player**
> ""That's why we can't become another Alphonso administration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Nia Morgna: ""You're exactly right. I've had my experience with his ad..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Socialist == true)"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: ""Hmm. I used to be part of the Red Youth during my univer..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Socialist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[90]`
**[WYBÓR GRACZA: ""Me neither, Mrs. Morgna. We have to make sure we succeed.""]** — Mówca: **Player**
> ""Me neither, Mrs. Morgna. We have to make sure we succeed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Nia Morgna: ""I've done my best so far, Mr. President. It's up to you ..."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "She was not at all impressed with my reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Nia Morgna: ""Anyway... I think Isabel is going to be here very soon. ..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA: ""Don't let your emotions get in the way.""]** — Mówca: **Player**
> ""Don't let your emotions get in the way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Nia Morgna: ""Of course, Mr. President.""*)

### Węzeł `[93]`
Mówca: **Nia Morgna**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "She was not at all impressed with my reply."*)

### Węzeł `[94]`
Mówca: **Nia Morgna**
> ""Great motivational speech, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "She let out a short laugh followed by a sigh."*)

### Węzeł `[95]`
Mówca: **Nia Morgna**
> ""Thank you, Mr. President. I respect your ideals too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: ""You and I. We are a strong team Nia.""*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "NiaHub3"*)
  - -> `[140]` (*Player: ""I can achieve anything with a woman like you by my side.""*)

### Węzeł `[96]`
Mówca: **Narrator**
> "She let out a short laugh followed by a sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "NiaHub3"*)

### Węzeł `[97]`
Mówca: **Nia Morgna**
> ""Of course, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "NiaHub3"*)

### Węzeł `[98]`
Mówca: **Nia Morgna**
> ""I've done my best so far, Mr. President. It's up to you now to persuade Isabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)

### Węzeł `[99]`
**[WYBÓR GRACZA: ""There is not much to tell. I am a pretty regular man outside politics.""]** — Mówca: **Player**
> ""There is not much to tell. I am a pretty regular man outside politics.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Nia Morgna: ""Well yes, that's the same for me too.""*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_AntiCorruptionPolice == true"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_AntiCorruptionPolice == true)"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_AntiCorruptionPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Nia Morgna: ""She's the last remaining piece of the puzzle. We are clo..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_AntiCorruptionPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Nia Morgna: ""I'm slightly scared that Isabel's help might not be enou..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [NiaHubEnd]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""Soll wasn't that bad.""*)

### Węzeł `[104]`
Mówca: **Nia Morgna**
> ""She's the last remaining piece of the puzzle. We are close to finalizing it but that idea alone is enough to make me a little stressed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "NiaHub3"*)
  - -> `[189]` (*Player: ""Don't worry, we've got this.""*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""What do you want to know?""]** — Mówca: **Player**
> ""What do you want to know?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Nia Morgna: ""Hmm... ""*)

### Węzeł `[106]`
Mówca: **Nia Morgna**
> ""I'm slightly scared that Isabel's help might not be enough. That we might need Heron's help one way or another...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "NiaHub3"*)
  - -> `[189]` (*Player: ""Don't worry, we've got this.""*)

### Węzeł `[107]`
Mówca: **Nia Morgna**
> ""What do you think about them now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Player: ""Honestly, I still support their cause.""*)
  - -> `[194]` (*Player: ""I don't think they are what they used to be. It changed ..."*)
  - -> `[158]` (*Player: ""They became a militant extremist group that threatens So..."*)

### Węzeł `[108]`
Mówca: **Nia Morgna**
> ""You're exactly right. I've had my experience with his administration when I worked as a vice minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Nia Morgna: ""But it was not Alphonso who was to blame. The Old Guard ..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA: ""Did you know that I am one of the top four best presidents of Sordland?""]** — Mówca: **Player**
> ""Did you know that I am one of the top four best presidents of Sordland?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "She frowned at me first and then smiled."*)

### Węzeł `[110]`
Mówca: **Nia Morgna**
> ""But it was not Alphonso who was to blame. The Old Guard put enormous pressure on him and the Justice Ministry back then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Nia Morgna: ""I guess it's not so different today.""*)

### Węzeł `[111]`
Mówca: **Nia Morgna**
> ""Oh really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Nia Morgna: ""What do you think about them now?""*)

### Węzeł `[112]`
Mówca: **Nia Morgna**
> ""I guess it's not so different today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "NiaHub3"*)
  - -> `[193]` (*Player: ""Not really.""*)
  - -> `[189]` (*Player: ""Don't worry, we've got this.""*)

### Węzeł `[113]`
Mówca: **Nia Morgna**
> ""Are you kidding me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "She looked at me with surprise."*)

### Węzeł `[114]`
Mówca: **Nia Morgna**
> ""I hope we succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "NiaHub3"*)
  - -> `[39]` (*Player: ""You and I. We are a strong team Nia. We will succeed.""*)

### Węzeł `[115]`
Mówca: **Nia Morgna**
> ""I don't really know what to say. You already know about my background experience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Player: ""Come on, Nia. I'm just trying to have a conversation.""*)
  - -> `[164]` (*Player: ""That's not what I meant.""*)
  - -> `[167]` (*Player: ""Anyway, let's talk about what we'll do with Isabel.""*)
  - -> `[170]` (*Player: ""It's okay, I didn't want to put you on the spot.""*)

### Węzeł `[116]`
**[WYBÓR GRACZA: ""It was obvious that he would win. I saw that as an investment.""]** — Mówca: **Player**
> ""It was obvious that he would win. I saw that as an investment.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Nia Morgna: ""I see...""*)

### Węzeł `[117]`
**[WYBÓR GRACZA: ""Tell me about your past.""]** — Mówca: **Player**
> ""Tell me about your past.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Nia Morgna: ""My past? I thought you've read my biography before you c..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: ""It was time for Soll to leave. He was the only alternative.""]** — Mówca: **Player**
> ""It was time for Soll to leave. He was the only alternative.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Nia Morgna: ""That's true. He was the only option for sure.""*)

### Węzeł `[119]`
**[WYBÓR GRACZA: ""We usually don't have time to talk alone. I was just interested to know more about you.""]** — Mówca: **Player**
> ""We usually don't have time to talk alone. I was just interested to know more about you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Nia Morgna: ""Oh, okay.""*)

### Węzeł `[120]`
**[WYBÓR GRACZA: ""At the time, I really believed that Alphonso would do great things.""]** — Mówca: **Player**
> ""At the time, I really believed that Alphonso would do great things.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Nia Morgna: ""I had the exact same belief. He proved us wrong very qui..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""What do you aim to achieve?""]** — Mówca: **Player**
> ""What do you aim to achieve?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Nia Morgna: ""A fair and transparent justice system for Sordland.""*)

### Węzeł `[122]`
Mówca: **Nia Morgna**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "She took another sip from her glass."*)

### Węzeł `[123]`
Mówca: **Nia Morgna**
> ""A fair and transparent justice system for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Nia Morgna: ""This was always what I've worked towards. Nothing has ch..."*)

### Węzeł `[124]`
Mówca: **Narrator**
> "She took another sip from her water."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Nia Morgna: ""I don't really know what to say. You already know about ..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA: ""We'll do it together.""]** — Mówca: **Player**
> ""We'll do it together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Nia Morgna), `[138]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Nia Morgna: ""Yes. We will, Mr. President!""*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [NiaHubEnd]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""Soll wasn't that bad.""*)

### Węzeł `[127]`
**[WYBÓR GRACZA: ""I respect that.""]** — Mówca: **Player**
> ""I respect that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Nia Morgna: ""Thank you, Mr. President. I respect your ideals too.""*)

### Węzeł `[128]`
**[WYBÓR GRACZA: ""At the time, I really wanted him to continue leading the party.""]** — Mówca: **Player**
> ""At the time, I really wanted him to continue leading the party.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Nia Morgna: ""So you really did support Tarquin Soll...""*)

### Węzeł `[129]`
**[WYBÓR GRACZA: ""I meant other than that.""]** — Mówca: **Player**
> ""I meant other than that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Nia Morgna: ""Hmm. You mean more personal aims? I might want to settle..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: ""He promised me a seat in his cabinet. I couldn't say no.""]** — Mówca: **Player**
> ""He promised me a seat in his cabinet. I couldn't say no.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Nia Morgna: ""I see...""*)

### Węzeł `[131]`
**[WYBÓR GRACZA: ""For some reason I'm sceptical about that.""]** — Mówca: **Player**
> ""For some reason I'm sceptical about that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Nia Morgna: ""What do you mean? Have you seen any hypocrisy from me? I..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: ""I didn't want Alphonso's leadership.""]** — Mówca: **Player**
> ""I didn't want Alphonso's leadership.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Nia Morgna: ""So you really did support Tarquin Soll...""*)

### Węzeł `[133]`
Mówca: **Nia Morgna**
> ""What do you mean? Have you seen any hypocrisy from me? I doubt that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Player: ""I'm sorry, you've got me wrong.""*)
  - -> `[181]` (*Player: ""The way you said it felt like it was a rehearsed stateme..."*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "NiaHub3"*)

### Węzeł `[134]`
Mówca: **Nia Morgna**
> ""Tell me, Mr. President... Why did you vote for Alphonso in the '46 Congress?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player: ""It was obvious that he would win. I saw that as an inves..."*)
  - -> `[118]` (*Player: ""It was time for Soll to leave. He was the only alternati..."*)
  - -> `[120]` (*Player: ""At the time, I really believed that Alphonso would do gr..."*)

### Węzeł `[135]`
Mówca: **Nia Morgna**
> ""Thank you, Mr. President. I respect your ideals too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player: ""You are a strong woman, Nia.""*)
  - -> `[125]` (*Player: ""We'll do it together.""*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "NiaHub3"*)

### Węzeł `[136]`
Mówca: **Nia Morgna**
> ""Tell me, Mr. President... Why did you vote for Soll in the '46 Congress?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player: ""He promised me a seat in his cabinet. I couldn't say no.""*)
  - -> `[132]` (*Player: ""I didn't want Alphonso's leadership.""*)
  - -> `[128]` (*Player: ""At the time, I really wanted him to continue leading the..."*)

### Węzeł `[137]`
Mówca: **Nia Morgna**
> ""Hmm. You mean more personal aims? I might want to settle down at some point in a coastal town like Lachaven. I'd like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Nia Morgna: ""But I really can't think of anything personal these days..."*)

### Węzeł `[138]`
Mówca: **Nia Morgna**
> ""Toppling Soll's Constitution would be the grandest thing that I can achieve. Other dreams will come later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player: ""I respect that a lot.""*)
  - -> `[125]` (*Player: ""We'll do it together.""*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "NiaHub3"*)

### Węzeł `[139]`
Mówca: **Nia Morgna**
> ""But I really can't think of anything personal these days. My dream is to see real democracy in Sordland. The republic's history has been pitch black.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Nia Morgna: ""Toppling Soll's Constitution would be the grandest thing..."*)

### Węzeł `[140]`
**[WYBÓR GRACZA: ""I can achieve anything with a woman like you by my side.""]** — Mówca: **Player**
> ""I can achieve anything with a woman like you by my side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Nia Morgna), `[12]` (Nia Morgna), `[18]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "She took a while to respond."*)

### Węzeł `[141]`
Mówca: **Nia Morgna**
> ""Oh, you're being too nice, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "Nia took another sip from her glass of water and looked a..."*)

### Węzeł `[142]`
Mówca: **Nia Morgna**
> ""My past? I thought you've read my biography before you chose me for the cabinet, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "She let out a short laughter."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Congress_Soll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Congress_Soll == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Congress_Soll == true)"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Congress_Soll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Congress_Soll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Nia Morgna: ""Tell me, Mr. President... Why did you vote for Soll in t..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Congress_Soll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Congress_Soll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Nia Morgna: ""Tell me, Mr. President... Why did you vote for Alphonso ..."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "She let out a short laughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: ""But seriously, I want to know more about you.""*)
  - -> `[150]` (*Player: ""If you don't want to share, it's okay.""*)
  - -> `[152]` (*Player: ""I guess that's correct.""*)

### Węzeł `[147]`
Mówca: **Narrator**
> "She took a while to respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Nia Morgna: ""Oh, you're being too nice, Mr. President.""*)

### Węzeł `[148]`
Mówca: **Nia Morgna**
> ""It is true that they have a militant wing but I wouldn't call them a real threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "She took another sip from her glass."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [NiaHubEnd]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""Soll wasn't that bad.""*)

### Węzeł `[150]`
**[WYBÓR GRACZA: ""If you don't want to share, it's okay.""]** — Mówca: **Player**
> ""If you don't want to share, it's okay.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Nia Morgna: ""I mean... I don't really know what to say. You already k..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA: ""You are a strong woman, Nia.""]** — Mówca: **Player**
> ""You are a strong woman, Nia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Nia Morgna: ""Thank you. That means a lot.""*)

### Węzeł `[152]`
**[WYBÓR GRACZA: ""I guess that's correct.""]** — Mówca: **Player**
> ""I guess that's correct.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Nia Morgna: ""I mean... I don't really know what to say. You already k..."*)

### Węzeł `[153]`
**[WYBÓR GRACZA: ""Of course. We have done a great deal so far.""]** — Mówca: **Player**
> ""Of course. We have done a great deal so far.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Nia Morgna), `[18]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Nia Morgna: ""Thank you. It really means a lot.""*)

### Węzeł `[154]`
Mówca: **Nia Morgna**
> ""Oh, okay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "She took another sip from her water."*)

### Węzeł `[155]`
**[WYBÓR GRACZA: ""I couldn't do any of this without you.""]** — Mówca: **Player**
> ""I couldn't do any of this without you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Nia Morgna), `[18]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Nia Morgna: ""Thank you. It really means a lot.""*)

### Węzeł `[156]`
Mówca: **Narrator**
> "She frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Nia Morgna: ""Anyway... Isabel's going to be here any minute.""*)

### Węzeł `[157]`
Mówca: **Narrator**
> "She gave me an inscrutable look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Congress_Soll == true"*)

### Węzeł `[158]`
**[WYBÓR GRACZA: ""They became a militant extremist group that threatens Sordland.""]** — Mówca: **Player**
> ""They became a militant extremist group that threatens Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Nia Morgna: ""I think it was always just *that*, Mr. President.""*)

### Węzeł `[159]`
**[WYBÓR GRACZA: ""Time will tell.""]** — Mówca: **Player**
> ""Time will tell.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Nia Morgna), `[18]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Nia Morgna: ""I guess so.""*)

### Węzeł `[160]`
Mówca: **Nia Morgna**
> ""I mean... I don't really know what to say. You already know about my background experience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Player: ""Come on, Nia. I'm just trying to have a conversation.""*)
  - -> `[164]` (*Player: ""That's not what I meant.""*)
  - -> `[167]` (*Player: ""Anyway, let's talk about what we'll do with Isabel.""*)
  - -> `[170]` (*Player: ""It's okay, I didn't want to put you on the spot.""*)

### Węzeł `[161]`
Mówca: **Nia Morgna**
> ""Anyway... Isabel's going to be here any minute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "Jump to: [NiaHubEnd]"*)

### Węzeł `[162]`
Mówca: **Nia Morgna**
> ""I guess so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "Nia took another sip from her glass of water and looked a..."*)

### Węzeł `[163]`
Mówca: **Nia Morgna**
> ""I'm sure she'll be here shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "Jump to: [NiaHubEnd]"*)

### Węzeł `[164]`
**[WYBÓR GRACZA: ""That's not what I meant.""]** — Mówca: **Player**
> ""That's not what I meant.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Nia Morgna), `[160]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Nia Morgna: ""Well...""*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [NiaHubEnd]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""Soll wasn't that bad.""*)

### Węzeł `[166]`
Mówca: **Nia Morgna**
> ""But I think it was always a ultranationalist group, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "Nia took another sip from her glass of water and looked a..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA: ""Anyway, let's talk about what we'll do with Isabel.""]** — Mówca: **Player**
> ""Anyway, let's talk about what we'll do with Isabel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Nia Morgna), `[160]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "Jump to: [NiaHubEnd]"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `NiaHub3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player: ""Anyway, let's talk about what we'll do with Isabel.""*)
  - -> `[173]` (*Player: ""Where is Isabel? I don't like waiting.""*)

### Węzeł `[169]`
Mówca: **Nia Morgna**
> ""I think it was always just *that*, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "Nia took another sip from her glass of water and looked a..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA: ""It's okay, I didn't want to put you on the spot.""]** — Mówca: **Player**
> ""It's okay, I didn't want to put you on the spot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Nia Morgna), `[160]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Nia Morgna: ""It's fine, Mr. President.""*)

### Węzeł `[171]`
**[WYBÓR GRACZA: ""Anyway, let's talk about what we'll do with Isabel.""]** — Mówca: **Player**
> ""Anyway, let's talk about what we'll do with Isabel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Nia Morgna), `[50]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "Jump to: [NiaHubEnd]"*)

### Węzeł `[172]`
Mówca: **Nia Morgna**
> ""Well, I guess that's true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Nia Morgna: ""But I think it was always a ultranationalist group, Mr. ..."*)

### Węzeł `[173]`
**[WYBÓR GRACZA: ""Where is Isabel? I don't like waiting.""]** — Mówca: **Player**
> ""Where is Isabel? I don't like waiting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Nia Morgna), `[50]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Nia Morgna: ""I'm sure she'll be here shortly.""*)

### Węzeł `[174]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: ""You and I. We are a strong team Nia.""*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "NiaHub3"*)
  - -> `[140]` (*Player: ""I can achieve anything with a woman like you by my side.""*)

### Węzeł `[175]`
Mówca: **Nia Morgna**
> ""Thank you. It really means a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "Nia took another sip from her glass of water and looked a..."*)

### Węzeł `[176]`
**[WYBÓR GRACZA: ""I respect that a lot.""]** — Mówca: **Player**
> ""I respect that a lot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Nia Morgna: ""Thank you, Mr. President. I respect your ideals too.""*)

### Węzeł `[177]`
Mówca: **Nia Morgna**
> ""You do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "She frowned."*)

### Węzeł `[178]`
**[WYBÓR GRACZA: ""I'm sorry, you've got me wrong.""]** — Mówca: **Player**
> ""I'm sorry, you've got me wrong.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Nia Morgna: ""Really?""*)

### Węzeł `[179]`
Mówca: **Narrator**
> "Nia took another sip from her glass of water and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Congress_Soll == true"*)

### Węzeł `[180]`
**[WYBÓR GRACZA: ""Come on, Nia. I'm just trying to have a conversation.""]** — Mówca: **Player**
> ""Come on, Nia. I'm just trying to have a conversation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Nia Morgna), `[160]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Nia Morgna: ""Well...""*)

### Węzeł `[181]`
**[WYBÓR GRACZA: ""The way you said it felt like it was a rehearsed statement.""]** — Mówca: **Player**
> ""The way you said it felt like it was a rehearsed statement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Nia Morgna: ""Really?""*)

### Węzeł `[182]`
Mówca: **Nia Morgna**
> ""Yes. We will, Mr. President!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "She smiled."*)

### Węzeł `[183]`
Mówca: **Nia Morgna**
> ""Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "She was visibly annoyed."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "She took another sip from her glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Congress_Soll == true"*)

### Węzeł `[185]`
Mówca: **Narrator**
> "She was visibly annoyed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Nia Morgna: ""But anyway, Isabel will be here soon.""*)

### Węzeł `[186]`
Mówca: **Nia Morgna**
> ""What do you think about them now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: ""Honestly, I still support their cause.""*)
  - -> `[28]` (*Player: ""I don't think they are what they used to be. It changed ..."*)
  - -> `[51]` (*Player: ""They became a militant extremist group that threatens So..."*)

### Węzeł `[187]`
Mówca: **Nia Morgna**
> ""But anyway, Isabel will be here soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "Jump to: [NiaHubEnd]"*)

### Węzeł `[188]`
Mówca: **Nia Morgna**
> ""I didn't know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Nia Morgna: ""What do you think about them now?""*)

### Węzeł `[189]`
**[WYBÓR GRACZA: ""Don't worry, we've got this.""]** — Mówca: **Player**
> ""Don't worry, we've got this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Nia Morgna), `[106]` (Nia Morgna), `[112]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Nia Morgna: ""I hope we succeed.""*)

### Węzeł `[190]`
Mówca: **Narrator**
> "She took another sip from her glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Congress_Soll == true"*)

### Węzeł `[191]`
Mówca: **Nia Morgna**
> ""Interesting...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "She gave me an inscrutable look."*)

### Węzeł `[192]`
**[WYBÓR GRACZA: ""Honestly, I still support their cause.""]** — Mówca: **Player**
> ""Honestly, I still support their cause.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Nia Morgna: ""You do?""*)

### Węzeł `[193]`
**[WYBÓR GRACZA: ""Not really.""]** — Mówca: **Player**
> ""Not really.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Nia Morgna: ""I hope we succeed.""*)

### Węzeł `[194]`
**[WYBÓR GRACZA: ""I don't think they are what they used to be. It changed a lot.""]** — Mówca: **Player**
> ""I don't think they are what they used to be. It changed a lot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Nia Morgna: ""Well, I guess that's true.""*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [NiaHubEnd]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""Soll wasn't that bad.""*)
