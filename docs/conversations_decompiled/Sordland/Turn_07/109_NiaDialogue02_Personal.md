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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 0

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `107` (*Sordland/Turn07/A_ConvinceIsabel*), Węzeł `[33]`

### Węzeł `[3]`
**[WYBÓR GRACZA: ""So... let's just move on to our plan with Isabel.""]** — Mówca: **Player**
> ""So... let's just move on to our plan with Isabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[4]`
Mówca: **Nia Morgna**
> ""Thank you. That means a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[140]`

### Węzeł `[5]`
Mówca: **Nia Morgna**
> ""Hmm... ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[6]`
**[WYBÓR GRACZA: ""But seriously, I want to know more about you.""]** — Mówca: **Player**
> ""But seriously, I want to know more about you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[7]`
Mówca: **Narrator**
> "She looked at me with surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[8]`
**[WYBÓR GRACZA: ""Let's talk about you a little.""]** — Mówca: **Player**
> ""Let's talk about you a little.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Nia took a sip from her glass of water and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
  - -> `[8]`
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
**[WYBÓR GRACZA: ""Do you think we'll succeed?""]** — Mówca: **Player**
> ""Do you think we'll succeed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I stayed silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[12]`
Mówca: **Nia Morgna**
> ""Do you really think we're a strong team though?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[155]`
  - -> `[159]`
  - -> `[140]`

### Węzeł `[13]`
Mówca: **Nia Morgna**
> ""Yes. I believe we are in a good position now. The anti-corruption force helped a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Nia Morgna**
> ""I'd like to hope so, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[18]`
Mówca: **Nia Morgna**
> ""Do you really think so?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[155]`
  - -> `[159]`
  - -> `[140]`

### Węzeł `[19]`
Mówca: **Nia Morgna**
> ""We only need either Isabel's or Heron's vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[20]`
**[WYBÓR GRACZA: ""Where is Isabel? I don't like waiting.""]** — Mówca: **Player**
> ""Where is Isabel? I don't like waiting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[21]`
Mówca: **Nia Morgna**
> ""Come on, Mr. President. Don't overthink this. We just need to focus on Isabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[22]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[23]`
Mówca: **Nia Morgna**
> ""We might need to get both Isabel and Heron to work with us. I don't want to rely on Isabel to bring exactly three votes. It's risky.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[24]`
Mówca: **Nia Morgna**
> ""Anyway... I think Isabel is going to be here very soon. Maybe we should return back to the topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: NiaHub2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
  - -> `[8]`
  - -> `[57]`
  - -> `[11]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""Anyway, let's talk about what we'll do with Isabel.""]** — Mówca: **Player**
> ""Anyway, let's talk about what we'll do with Isabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[27]`
Mówca: **Nia Morgna**
> ""But anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[28]`
**[WYBÓR GRACZA: ""I don't think they are what they used to be. It changed a lot.""]** — Mówca: **Player**
> ""I don't think they are what they used to be. It changed a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[29]`
Mówca: **Nia Morgna**
> ""Let's not overthink this though, Mr. President. We have to focus on the meeting with Isabel now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[30]`
Mówca: **Nia Morgna**
> ""Very funny, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[31]`
**[WYBÓR GRACZA: ""Hmm. I used to be part of the Red Youth during my university years.""]** — Mówca: **Player**
> ""Hmm. I used to be part of the Red Youth during my university years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[32]`
Mówca: **Narrator**
> "She took another sip from her glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [NiaHub2])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[34]`
Mówca: **Nia Morgna**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[35]`
Mówca: **Narrator**
> "She didn't say anything and leaned over to look out the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
  - -> `[8]`
  - -> `[38]`

### Węzeł `[36]`
**[WYBÓR GRACZA: ""Hmm. I used to be part of the Young Sords during my university years.""]** — Mówca: **Player**
> ""Hmm. I used to be part of the Young Sords during my university years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [NiaHubEnd])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `107` (*Sordland/Turn07/A_ConvinceIsabel*), Węzeł `[46]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "Keep staying silent."]** — Mówca: **Player_Italic**
> "I kept silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""You and I. We are a strong team Nia. We will succeed.""]** — Mówca: **Player**
> ""You and I. We are a strong team Nia. We will succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[40]`
Mówca: **Narrator**
> "She watched the beautiful sunset from the window. Then she brought her eyes back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
  - -> `[8]`
  - -> `[43]`
  - -> `[45]`

### Węzeł `[41]`
Mówca: **Nia Morgna**
> ""I'm sure she'll be here shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[42]`
**[WYBÓR GRACZA: ""Alphonso was just a rich businessman. I couldn't trust him.""]** — Mówca: **Player**
> ""Alphonso was just a rich businessman. I couldn't trust him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "Look at her."]** — Mówca: **Player_Italic**
> "I looked back at her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[44]`
**[WYBÓR GRACZA: ""I didn't support Alphonso's free market policies.""]** — Mówca: **Player**
> ""I didn't support Alphonso's free market policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "Watch the sunset."]** — Mówca: **Player_Italic**
> "I looked out the window and saw the crimson sky with almost maroon-colored clouds over the horizon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[46]`
**[WYBÓR GRACZA: ""Soll wasn't that bad.""]** — Mówca: **Player**
> ""Soll wasn't that bad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[47]`
Mówca: **Narrator**
> "She smiled at me, then averted her gaze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Nia Morgna**
> ""So...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[57]`
  - -> `[168]`

### Węzeł `[49]`
Mówca: **Nia Morgna**
> ""This was always what I've worked towards. Nothing has changed one bit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[129]`
  - -> `[131]`

### Węzeł `[50]`
Mówca: **Nia Morgna**
> ""So...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[57]`
  - -> `[168]`

### Węzeł `[51]`
**[WYBÓR GRACZA: ""They became a militant extremist group that threatens Sordland.""]** — Mówca: **Player**
> ""They became a militant extremist group that threatens Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: NiaHub3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[20]`

### Węzeł `[53]`
**[WYBÓR GRACZA: ""You and I. We are a strong team Nia.""]** — Mówca: **Player**
> ""You and I. We are a strong team Nia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[54]`
Mówca: **Nia Morgna**
> ""Me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[56]`
  - -> `[58]`
  - -> `[60]`

### Węzeł `[55]`
Mówca: **Nia Morgna**
> ""Well yes, that's the same for me too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[56]`
**[WYBÓR GRACZA: ""Yes. How have you been holding up these rough days?""]** — Mówca: **Player**
> ""Yes. How have you been holding up these rough days?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[57]`
**[WYBÓR GRACZA: ""So... How about you? How have you been holding up?""]** — Mówca: **Player**
> ""So... How about you? How have you been holding up?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[58]`
**[WYBÓR GRACZA: ""Is everything fine with you?""]** — Mówca: **Player**
> ""Is everything fine with you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[59]`
Mówca: **Nia Morgna**
> ""How about you tell me something first?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[109]`
  - -> `[99]`
  - -> `[87]`
  - -> `[71]`

### Węzeł `[60]`
**[WYBÓR GRACZA: ""I'm disappointed that you couldn't get the Court for me.""]** — Mówca: **Player**
> ""I'm disappointed that you couldn't get the Court for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[61]`
**[WYBÓR GRACZA: ""Honestly, I still support their cause.""]** — Mówca: **Player**
> ""Honestly, I still support their cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[62]`
**[WYBÓR GRACZA: ""Yes. I want to know more about you.""]** — Mówca: **Player**
> ""Yes. I want to know more about you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_PromoteMarket == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_PromoteMarket == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_PromoteMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_PromoteMarket == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_PromoteMarket"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[66]`
Mówca: **Nia Morgna**
> ""I thought you were aware about the situation in the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Nia Morgna**
> ""It's fine, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[68]`
Mówca: **Nia Morgna**
> ""I already have two Justices working with me. The court is dominated by Orso's crew so there's not much room to work with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Narrator**
> "She frowned at me first and then smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[70]`
Mówca: **Nia Morgna**
> ""Also, let's not forget that I persuaded Isabel into meeting with you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Nationalist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[74]`
Mówca: **Nia Morgna**
> ""But anyway, she'll be here soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[75]`
Mówca: **Nia Morgna**
> ""So you really did support Tarquin Soll...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[63]`
  - -> `[42]`

### Węzeł `[76]`
Mówca: **Nia Morgna**
> ""I'm fine, Mr. President. Thanks for asking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[77]`
Mówca: **Nia Morgna**
> ""So you really did support Tarquin Soll...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[63]`
  - -> `[42]`

### Węzeł `[78]`
Mówca: **Nia Morgna**
> ""What do you want to know?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[119]`
  - -> `[121]`

### Węzeł `[79]`
Mówca: **Narrator**
> "She was not at all impressed with my reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[80]`
Mówca: **Nia Morgna**
> ""I'm just focused on our proposal. If it passes the Supreme Court, this will be a historical moment for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Nia Morgna**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[82]`
Mówca: **Nia Morgna**
> ""I just... don't want to see another failure trying to change this Constitution anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[90]`
  - -> `[84]`
  - -> `[92]`

### Węzeł `[83]`
Mówca: **Nia Morgna**
> ""I had the exact same belief. He proved us wrong very quickly though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[84]`
**[WYBÓR GRACZA: ""It's not the end of the world if it doesn't go through.""]** — Mówca: **Player**
> ""It's not the end of the world if it doesn't go through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[85]`
Mówca: **Nia Morgna**
> ""That's true. He was the only option for sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""That's why we can't become another Alphonso administration.""]** — Mówca: **Player**
> ""That's why we can't become another Alphonso administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Socialist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[90]`
**[WYBÓR GRACZA: ""Me neither, Mrs. Morgna. We have to make sure we succeed.""]** — Mówca: **Player**
> ""Me neither, Mrs. Morgna. We have to make sure we succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[91]`
Mówca: **Narrator**
> "She was not at all impressed with my reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[92]`
**[WYBÓR GRACZA: ""Don't let your emotions get in the way.""]** — Mówca: **Player**
> ""Don't let your emotions get in the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[93]`
Mówca: **Nia Morgna**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[94]`
Mówca: **Nia Morgna**
> ""Great motivational speech, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Nia Morgna**
> ""Thank you, Mr. President. I respect your ideals too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[52]`
  - -> `[140]`

### Węzeł `[96]`
Mówca: **Narrator**
> "She let out a short laugh followed by a sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[97]`
Mówca: **Nia Morgna**
> ""Of course, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[98]`
Mówca: **Nia Morgna**
> ""I've done my best so far, Mr. President. It's up to you now to persuade Isabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
**[WYBÓR GRACZA: ""There is not much to tell. I am a pretty regular man outside politics.""]** — Mówca: **Player**
> ""There is not much to tell. I am a pretty regular man outside politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Order_AntiCorruptionPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Order_AntiCorruptionPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Order_AntiCorruptionPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [NiaHubEnd])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `107` (*Sordland/Turn07/A_ConvinceIsabel*), Węzeł `[46]`

### Węzeł `[104]`
Mówca: **Nia Morgna**
> ""She's the last remaining piece of the puzzle. We are close to finalizing it but that idea alone is enough to make me a little stressed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[189]`

### Węzeł `[105]`
**[WYBÓR GRACZA: ""What do you want to know?""]** — Mówca: **Player**
> ""What do you want to know?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[106]`
Mówca: **Nia Morgna**
> ""I'm slightly scared that Isabel's help might not be enough. That we might need Heron's help one way or another...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[189]`

### Węzeł `[107]`
Mówca: **Nia Morgna**
> ""What do you think about them now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[194]`
  - -> `[158]`

### Węzeł `[108]`
Mówca: **Nia Morgna**
> ""You're exactly right. I've had my experience with his administration when I worked as a vice minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
**[WYBÓR GRACZA: ""Did you know that I am one of the top four best presidents of Sordland?""]** — Mówca: **Player**
> ""Did you know that I am one of the top four best presidents of Sordland?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[110]`
Mówca: **Nia Morgna**
> ""But it was not Alphonso who was to blame. The Old Guard put enormous pressure on him and the Justice Ministry back then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Nia Morgna**
> ""Oh really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[112]`
Mówca: **Nia Morgna**
> ""I guess it's not so different today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[193]`
  - -> `[189]`

### Węzeł `[113]`
Mówca: **Nia Morgna**
> ""Are you kidding me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[114]`
Mówca: **Nia Morgna**
> ""I hope we succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[39]`

### Węzeł `[115]`
Mówca: **Nia Morgna**
> ""I don't really know what to say. You already know about my background experience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[164]`
  - -> `[167]`
  - -> `[170]`

### Węzeł `[116]`
**[WYBÓR GRACZA: ""It was obvious that he would win. I saw that as an investment.""]** — Mówca: **Player**
> ""It was obvious that he would win. I saw that as an investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[117]`
**[WYBÓR GRACZA: ""Tell me about your past.""]** — Mówca: **Player**
> ""Tell me about your past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[118]`
**[WYBÓR GRACZA: ""It was time for Soll to leave. He was the only alternative.""]** — Mówca: **Player**
> ""It was time for Soll to leave. He was the only alternative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[119]`
**[WYBÓR GRACZA: ""We usually don't have time to talk alone. I was just interested to know more about you.""]** — Mówca: **Player**
> ""We usually don't have time to talk alone. I was just interested to know more about you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[120]`
**[WYBÓR GRACZA: ""At the time, I really believed that Alphonso would do great things.""]** — Mówca: **Player**
> ""At the time, I really believed that Alphonso would do great things.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[121]`
**[WYBÓR GRACZA: ""What do you aim to achieve?""]** — Mówca: **Player**
> ""What do you aim to achieve?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Nia Morgna**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[123]`
Mówca: **Nia Morgna**
> ""A fair and transparent justice system for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[124]`
Mówca: **Narrator**
> "She took another sip from her water."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[125]`
**[WYBÓR GRACZA: ""We'll do it together.""]** — Mówca: **Player**
> ""We'll do it together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [NiaHubEnd])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `107` (*Sordland/Turn07/A_ConvinceIsabel*), Węzeł `[46]`

### Węzeł `[127]`
**[WYBÓR GRACZA: ""I respect that.""]** — Mówca: **Player**
> ""I respect that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[128]`
**[WYBÓR GRACZA: ""At the time, I really wanted him to continue leading the party.""]** — Mówca: **Player**
> ""At the time, I really wanted him to continue leading the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[129]`
**[WYBÓR GRACZA: ""I meant other than that.""]** — Mówca: **Player**
> ""I meant other than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[130]`
**[WYBÓR GRACZA: ""He promised me a seat in his cabinet. I couldn't say no.""]** — Mówca: **Player**
> ""He promised me a seat in his cabinet. I couldn't say no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[131]`
**[WYBÓR GRACZA: ""For some reason I'm sceptical about that.""]** — Mówca: **Player**
> ""For some reason I'm sceptical about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
**[WYBÓR GRACZA: ""I didn't want Alphonso's leadership.""]** — Mówca: **Player**
> ""I didn't want Alphonso's leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[133]`
Mówca: **Nia Morgna**
> ""What do you mean? Have you seen any hypocrisy from me? I doubt that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[181]`
  - -> `[52]`

### Węzeł `[134]`
Mówca: **Nia Morgna**
> ""Tell me, Mr. President... Why did you vote for Alphonso in the '46 Congress?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[118]`
  - -> `[120]`

### Węzeł `[135]`
Mówca: **Nia Morgna**
> ""Thank you, Mr. President. I respect your ideals too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[125]`
  - -> `[52]`

### Węzeł `[136]`
Mówca: **Nia Morgna**
> ""Tell me, Mr. President... Why did you vote for Soll in the '46 Congress?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[132]`
  - -> `[128]`

### Węzeł `[137]`
Mówca: **Nia Morgna**
> ""Hmm. You mean more personal aims? I might want to settle down at some point in a coastal town like Lachaven. I'd like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Nia Morgna**
> ""Toppling Soll's Constitution would be the grandest thing that I can achieve. Other dreams will come later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[125]`
  - -> `[52]`

### Węzeł `[139]`
Mówca: **Nia Morgna**
> ""But I really can't think of anything personal these days. My dream is to see real democracy in Sordland. The republic's history has been pitch black.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[140]`
**[WYBÓR GRACZA: ""I can achieve anything with a woman like you by my side.""]** — Mówca: **Player**
> ""I can achieve anything with a woman like you by my side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[141]`
Mówca: **Nia Morgna**
> ""Oh, you're being too nice, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[142]`
Mówca: **Nia Morgna**
> ""My past? I thought you've read my biography before you chose me for the cabinet, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Congress_Soll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Congress_Soll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Congress_Soll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Party_Congress_Soll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Congress_Soll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[146]`
Mówca: **Narrator**
> "She let out a short laughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[150]`
  - -> `[152]`

### Węzeł `[147]`
Mówca: **Narrator**
> "She took a while to respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[148]`
Mówca: **Nia Morgna**
> ""It is true that they have a militant wing but I wouldn't call them a real threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [NiaHubEnd])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `107` (*Sordland/Turn07/A_ConvinceIsabel*), Węzeł `[46]`

### Węzeł `[150]`
**[WYBÓR GRACZA: ""If you don't want to share, it's okay.""]** — Mówca: **Player**
> ""If you don't want to share, it's okay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[151]`
**[WYBÓR GRACZA: ""You are a strong woman, Nia.""]** — Mówca: **Player**
> ""You are a strong woman, Nia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[152]`
**[WYBÓR GRACZA: ""I guess that's correct.""]** — Mówca: **Player**
> ""I guess that's correct.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[153]`
**[WYBÓR GRACZA: ""Of course. We have done a great deal so far.""]** — Mówca: **Player**
> ""Of course. We have done a great deal so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[154]`
Mówca: **Nia Morgna**
> ""Oh, okay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[155]`
**[WYBÓR GRACZA: ""I couldn't do any of this without you.""]** — Mówca: **Player**
> ""I couldn't do any of this without you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[156]`
Mówca: **Narrator**
> "She frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[157]`
Mówca: **Narrator**
> "She gave me an inscrutable look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[158]`
**[WYBÓR GRACZA: ""They became a militant extremist group that threatens Sordland.""]** — Mówca: **Player**
> ""They became a militant extremist group that threatens Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[159]`
**[WYBÓR GRACZA: ""Time will tell.""]** — Mówca: **Player**
> ""Time will tell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[160]`
Mówca: **Nia Morgna**
> ""I mean... I don't really know what to say. You already know about my background experience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[164]`
  - -> `[167]`
  - -> `[170]`

### Węzeł `[161]`
Mówca: **Nia Morgna**
> ""Anyway... Isabel's going to be here any minute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[162]`
Mówca: **Nia Morgna**
> ""I guess so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[163]`
Mówca: **Nia Morgna**
> ""I'm sure she'll be here shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[164]`
**[WYBÓR GRACZA: ""That's not what I meant.""]** — Mówca: **Player**
> ""That's not what I meant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [NiaHubEnd])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `107` (*Sordland/Turn07/A_ConvinceIsabel*), Węzeł `[46]`

### Węzeł `[166]`
Mówca: **Nia Morgna**
> ""But I think it was always a ultranationalist group, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[167]`
**[WYBÓR GRACZA: ""Anyway, let's talk about what we'll do with Isabel.""]** — Mówca: **Player**
> ""Anyway, let's talk about what we'll do with Isabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: NiaHub3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[173]`

### Węzeł `[169]`
Mówca: **Nia Morgna**
> ""I think it was always just *that*, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[170]`
**[WYBÓR GRACZA: ""It's okay, I didn't want to put you on the spot.""]** — Mówca: **Player**
> ""It's okay, I didn't want to put you on the spot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[171]`
**[WYBÓR GRACZA: ""Anyway, let's talk about what we'll do with Isabel.""]** — Mówca: **Player**
> ""Anyway, let's talk about what we'll do with Isabel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[172]`
Mówca: **Nia Morgna**
> ""Well, I guess that's true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[173]`
**[WYBÓR GRACZA: ""Where is Isabel? I don't like waiting.""]** — Mówca: **Player**
> ""Where is Isabel? I don't like waiting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[174]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[52]`
  - -> `[140]`

### Węzeł `[175]`
Mówca: **Nia Morgna**
> ""Thank you. It really means a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[176]`
**[WYBÓR GRACZA: ""I respect that a lot.""]** — Mówca: **Player**
> ""I respect that a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[177]`
Mówca: **Nia Morgna**
> ""You do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[178]`
**[WYBÓR GRACZA: ""I'm sorry, you've got me wrong.""]** — Mówca: **Player**
> ""I'm sorry, you've got me wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[179]`
Mówca: **Narrator**
> "Nia took another sip from her glass of water and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[180]`
**[WYBÓR GRACZA: ""Come on, Nia. I'm just trying to have a conversation.""]** — Mówca: **Player**
> ""Come on, Nia. I'm just trying to have a conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[181]`
**[WYBÓR GRACZA: ""The way you said it felt like it was a rehearsed statement.""]** — Mówca: **Player**
> ""The way you said it felt like it was a rehearsed statement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Nia Morgna**
> ""Yes. We will, Mr. President!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[183]`
Mówca: **Nia Morgna**
> ""Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Narrator**
> "She took another sip from her glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[185]`
Mówca: **Narrator**
> "She was visibly annoyed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Nia Morgna**
> ""What do you think about them now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[28]`
  - -> `[51]`

### Węzeł `[187]`
Mówca: **Nia Morgna**
> ""But anyway, Isabel will be here soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[188]`
Mówca: **Nia Morgna**
> ""I didn't know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[189]`
**[WYBÓR GRACZA: ""Don't worry, we've got this.""]** — Mówca: **Player**
> ""Don't worry, we've got this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[190]`
Mówca: **Narrator**
> "She took another sip from her glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[191]`
Mówca: **Nia Morgna**
> ""Interesting...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[192]`
**[WYBÓR GRACZA: ""Honestly, I still support their cause.""]** — Mówca: **Player**
> ""Honestly, I still support their cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[193]`
**[WYBÓR GRACZA: ""Not really.""]** — Mówca: **Player**
> ""Not really.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[194]`
**[WYBÓR GRACZA: ""I don't think they are what they used to be. It changed a lot.""]** — Mówca: **Player**
> ""I don't think they are what they used to be. It changed a lot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [NiaHubEnd])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `107` (*Sordland/Turn07/A_ConvinceIsabel*), Węzeł `[46]`
