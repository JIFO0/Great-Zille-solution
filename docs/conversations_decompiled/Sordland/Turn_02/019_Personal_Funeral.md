# Sordland/Turn02/Personal_Funeral

- **ID konwersacji:** `19`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Sordland/Turn_02/019_Personal_Funeral.md`
- **Liczba węzłów dialogowych:** 156
- **Liczba wyborów gracza:** 36

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[54]** Serge Wolkner
- **[56]** Karl Greiser

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Accepted_MediaDeal`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Turn02_InT_Corporation_SordishState`
- `BaseGame.Turn02_InT_Corporation_TaurusHolding`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`
- `BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth`
- `BaseGameIsolated.Turn02_P_RecitedPoem`
- `BaseGameIsolated.Turn02_P_RecitedPoem2`
- `BaseGameIsolated.Turn02_P_RecitedPoem3`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.AMorgnaWesCore`
- `BaseGame.Capitalist`
- `BaseGame.Country_Unrest`
- `BaseGame.Democratic`
- `BaseGame.Malenyevist`
- `BaseGame.Public_Opinion`
- `BaseGame.Sollist`
- `BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth`
- `BaseGameIsolated.Turn02_P_RecitedPoem`
- `BaseGameIsolated.Turn02_P_RecitedPoem2`
- `BaseGameIsolated.Turn02_P_RecitedPoem3`
- `BaseGameSupport.Journal_Turn02_AttendedCircasFuneral`
- `BaseGameSupport.News_Turn02_HP_AttendFuneral`
- `BaseGameSupport.News_Turn02_HP_FuneralPoem`
- `BaseGameSupport.News_Turn02_HP_FuneralPoem2`
- `BaseGameSupport.News_Turn02_HP_FuneralPoem3`
- `BaseGameSupport.News_Turn02_R_ControversyAtFuneral`
- `BaseGameSupport.News_Turn02_R_ThousandsAttendFuneral`
- `BaseGameSupport.News_Turn02_ST_NoRYFuneralDeal`
- `BaseGameSupport.News_Turn02_ST_PresidentAttend`
- `BaseGameSupport.News_Turn02_ST_PresidentRY`
- `BaseGameSupport.News_Turn02_ST_RYFuneralDeal`
- `GameCondition.Turn02_Personal_Funeral`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 28

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Country_Unrest`
- `BaseGame.Sollist`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[42]` (Petr Vectern): `Variable["BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth"] = true;`
- Węzeł `[43]` (Petr Vectern): `Variable["BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth"] = false; Variable["BaseGame.Public_...`
- Węzeł `[77]` (Petr Vectern): `Variable["GameCondition.Turn02_Personal_Funeral"] = true;`
- Węzeł `[101]` (Petr Vectern): `Variable["BaseGameSupport.News_Turn02_R_ThousandsAttendFuneral"] = true;`
- Węzeł `[102]` (Petr Vectern): `Variable["BaseGameSupport.News_Turn02_R_ControversyAtFuneral"] = true;`
- Węzeł `[103]` (Petr Vectern): `Variable["BaseGameSupport.News_Turn02_ST_PresidentRY"] = true;`
- Węzeł `[104]` (Petr Vectern): `Variable["BaseGameIsolated.Turn02_P_RecitedPoem"] = true;`
- Węzeł `[108]` (Petr Vectern): `Variable["BaseGameSupport.News_Turn02_HP_FuneralPoem"] = true;`
- *...oraz 20 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Petr Vectern)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Dark clouds were looming over Deyr. They looked daunting as our convoy started approaching the century-old cemetery."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[4]`
Mówca: **Petr Vectern**
> "“Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Serge Wolkner**
> "“Sir, we have arrived.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[6]`
Mówca: **Karl Greiser**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[7]`
Mówca: **Narrator**
> "It looked like it was going to rain. Certainly fitting weather for a funeral."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "As expected, Bernard Circas's passing maintained its media traction and all of Sordland was paying attention to the ceremony. Especially to what I would say in my speech today."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Rain drops were running down the car window when Serge opened my door and held an umbrella over my head. As soon as I got out, flashes from the cameras blinded me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "“It's okay Serge. I will hold my own umbrella.”"]** — Mówca: **Player**
> "“It's okay Serge. I will hold my own umbrella.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Serge Wolkner**
> "“As you wish sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Serge Wolkner**
> "“It's my duty, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Narrator**
> "He handed me the umbrella and started waiting next to the car with his own."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Narrator**
> "He silently started following me while holding the umbrella."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Narrator**
> "Petr and Karl exited from their own cars in the convoy. They made their way over to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[17]`
Mówca: **Karl Greiser**
> "“I just wanted to inform you that the perimeter is clear and secured completely. There is no one getting in or out without our knowledge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`
  - -> `[20]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“We don't want something similar happening again, do we?”"]** — Mówca: **Player**
> "“We don't want something similar happening again, do we?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "“You better be right for your sake.”"]** — Mówca: **Player**
> "“You better be right for your sake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“Good work. Thank you Karl.”"]** — Mówca: **Player**
> "“Good work. Thank you Karl.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
Mówca: **Karl Greiser**
> "“I have taken the necessary precautions. I personally made sure of that. We are all safe.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
Mówca: **Karl Greiser**
> "“Absolutely not, Mr. President. The same mistakes will never happen again. I personally made sure of that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Narrator**
> "Karl bowed his head with respect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Petr Vectern**
> "“Good. If anything happens to Anton, you will have to answer to the First Lady.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Petr Vectern**
> "“And trust me Karl. You don't want that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Narrator**
> "Petr let out a laugh, which drew some attention from bereaved attendees."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`
  - -> `[29]`
  - -> `[95]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Petr, you are being inconsiderate.”"]** — Mówca: **Player**
> "“Petr, you are being inconsiderate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "“I don't think any of us want that.”"]** — Mówca: **Player**
> "“I don't think any of us want that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "Gesture Petr to lower his voice."]** — Mówca: **Player_Italic**
> "I gestured at Petr to lower his voice a bit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Petr Vectern**
> "“You are right. Sorry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[31]`
Mówca: **Petr Vectern**
> "“You are right. Sorry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Petr Vectern**
> "“Indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Narrator**
> "It started to rain. Several unintelligible voices were heard from Karl's radio. He stepped out to reply and returned shortly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Karl Greiser**
> "“We have a small problem, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Karl Greiser**
> "“A few -- five to be exact -- Red Youth members are here to attend the funeral. They apparently said they wish to pay their respects to their fallen comrade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Karl Greiser**
> "“Should we let them in?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[37]`
  - -> `[46]`
  - -> `[38]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“Let them in.”"]** — Mówca: **Player**
> "“Let them in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Absolutely not.”"]** — Mówca: **Player**
> "“Absolutely not, it is too risky.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Do you think they pose a security threat?”"]** — Mówca: **Player**
> "“Do you think they pose a security threat?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Karl Greiser**
> "“No. They were thoroughly searched. It looks like they really are here to attend the funeral.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[46]`
  - -> `[38]`

### Węzeł `[41]`
Mówca: **Karl Greiser**
> "“As you command.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[42]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[43]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth = false;
BaseGame.Public_Opinion += 1;
BaseGame.Malenyevist -= 1;
BaseGame.Democratic -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth"] = false;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 1;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[44]`
Mówca: **Petr Vectern**
> "“Let's head over. They are about to start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Narrator**
> "We walked towards the crowd circled around the grave. Everyone in attendance was wearing black in mourning. The rain started pouring heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Let them in but put a few guards on them.”"]** — Mówca: **Player**
> "“Let them in but put a few guards on them to be safe.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[47]`
Mówca: **Narrator**
> "Bernard's widow and daughter were in the front row, staring at the coffin with a mixture of disbelief, confusion and above all, a cold, unforgiving sadness."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Narrator**
> "Before taking my place to observe the ceremony, I gave my condolences to Bernard's wife and his daughter who looked at me. She reminded me of Deana."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Narrator**
> "Both of their eyes were very red and swollen from weeping."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[50]`
Mówca: **Narrator**
> "When the religious ceremony was done, I was invited by the priest to deliver my speech. I took the podium. I felt like I had a lump in my throat. I couldn't get the daughter's eyes out of my head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Today, we are mourning Bernard Circas, a father, a husband and a loyal servant of this country.”"]** — Mówca: **Player**
> "“Today, we are mourning Bernard Circas, a father, a husband and a loyal servant of this country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Narrator**
> "Towards the back of the crowd, I spotted the members of the Red Youth, wearing red shirts and black bands of mourning on their arms. They seemed ruly and were respectfully bowing their heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[53]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[55]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Narrator**
> "There was complete silence except for the sound of raindrops."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[96]`
  - -> `[57]`
  - -> `[60]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "“Regardless of his ideology, this was a heinous act made towards a good man. We must end this cycle of violence.”"]** — Mówca: **Player**
> "“Regardless of his ideology, this was a heinous act made towards a good man. We must end this cycle of violence now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[97]`
  - -> `[58]`
  - -> `[65]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "“I interpret this attack as an attack against Sordland and by extension, against me personally.”"]** — Mówca: **Player**
> "“I interpret this attack as an attack against Sordland and by extension, against me personally.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`
  - -> `[89]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "“We will make sure that unfortunate events such as this will never happen again.”"]** — Mówca: **Player**
> "“We will make sure that unfortunate events such as this will never happen ever again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`
  - -> `[89]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“He was a true comrade and he fought for what he believed in, his ideal vision of Sordland, in every step of his life.”"]** — Mówca: **Player**
> "“He was a true comrade and he fought for what he believed in, his ideal vision of Sordland, in every step of his life. We must learn from him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "“A moment of silence please.”"]** — Mówca: **Player**
> "“A moment of silence please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "“I would now like to recite one of the poems he left us.”"]** — Mówca: **Player**
> "“I would now like to recite a part from one of the poems he left us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Our only strength is the will to survive, knowing that we will perish, knowing nothing more absolute.”"]** — Mówca: **Player**
> "“Our only strength is the will to survive, knowing that we will perish, knowing nothing more absolute.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“I promise you this. The blood of Bernard will not remain on the sacred ground of Sordland.”"]** — Mówca: **Player**
> "“I promise you this. The blood of Bernard will not remain on the sacred ground of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`
  - -> `[89]`

### Węzeł `[66]`
Mówca: **Narrator**
> "During the silence, all that was heard were the ravens."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Narrator**
> "Some attendees started clapping, some crying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Narrator**
> "The coffin was lowered into the grave by the gravekeepers. After a couple of minutes, Bernard Circas was with the soil, no more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[69]`
Mówca: **Narrator**
> "The widow thanked me with a soft and defeated voice before we dispersed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Narrator**
> "On my way back to the car, I still couldn't get the eyes of Bernard's daughter, nor the faltering voice of his wife, out of my head. Would Deana, Monica and Franc look the same way if something happened to me?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Narrator**
> "Petr put his hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Petr Vectern**
> "“That was a good speech.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[73]`
Mówca: **Petr Vectern**
> "“Come on, it's time to go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Petr Vectern**
> "“We've got work to do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Narrator**
> "I sensed only respect in his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[78]`
  - -> `[88]`

### Węzeł `[76]`
Mówca: **Narrator**
> "He was right. We had work to do. So much more to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[77]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: GameCondition.Turn02_Personal_Funeral = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn02_Personal_Funeral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "“Thank you. I mean it.”"]** — Mówca: **Player**
> "“Thank you. I mean it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Petr Vectern**
> "“I know you do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[80]`
Mówca: **Narrator**
> "I realized that the rain had stopped, and I looked up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Narrator**
> "The black clouds slowly dispersed and sunbeams enlightened our surroundings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "“This is a great loss for all of us.”"]** — Mówca: **Player**
> "“This is a great loss for all of us, for our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[97]`
  - -> `[58]`
  - -> `[65]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "“As we bid farewell to Bernard, I want to close with the words every Sord lives by: A Morgna wes core!”"]** — Mówca: **Player**
> "“As we bid farewell to Bernard, I want to close with the words every Sord lives by: A Morgna wes core!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "Step down from the podium."]** — Mówca: **Player_Italic**
> "I stepped down from the podium. It was time to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[85]`
Mówca: **Narrator**
> "Everyone replied: “Vectern sis da!”. Victory is close."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Narrator**
> "With applauses, I stepped down from the podium. It was time to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[87]`
Mówca: **Narrator**
> "As someone once said: 'Even the darkest night will end and the sun will rise.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "“The tears of the family he left behind have a price that needs to be paid. I will not stop until it is paid in full.”"]** — Mówca: **Player**
> "“The tears of the family he left behind have a price that needs to be paid. I will not stop until it is paid in full.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[90]`
**[WYBÓR GRACZA: "“Let us all mourn the passing of Bernard Circas and remember him well.”"]** — Mówca: **Player**
> "“Let us all mourn the passing of Bernard Circas and remember him well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "“But, hatred begets hatred. There is only one way to overcome this vicious cycle. We must unite against the evil of this world.”"]** — Mówca: **Player**
> "“But, hatred begets hatred. There is only one way to overcome this vicious cycle. We must unite against the evil of this world.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "“It's time to go.”"]** — Mówca: **Player**
> "“It's time to go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Petr Vectern**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[94]`
Mówca: **Petr Vectern**
> "“Hah! Right? I mean, life is full of tragedy. We should try to take it easy if we can.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[95]`
**[WYBÓR GRACZA: "“You are the only one who can make me laugh at a funeral.”"]** — Mówca: **Player**
> "“You are the only one that can make me laugh at a funeral.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[96]`
**[WYBÓR GRACZA: "“I will confess that I disagreed with Bernard Circas almost entirely. But it doesn't mean that he deserved this. Our country can be a better place.”"]** — Mówca: **Player**
> "“I will confess that I disagreed with Bernard Circas almost entirely. But it doesn't mean that he deserved this. Our country can be a better place.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[97]`
**[WYBÓR GRACZA: "“Circas had a dream of a unified Sordland. In these next months we need to fulfill his dream and band together.”"]** — Mówca: **Player**
> "“Circas had a dream of a unified Sordland. In these next months we need to fulfill his dream and band together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`
  - -> `[89]`

### Węzeł `[98]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_R_ThousandsAttendFuneral = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_R_ThousandsAttendFuneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[102]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_R_ControversyAtFuneral = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_R_ControversyAtFuneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[103]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_ST_PresidentRY = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_ST_PresidentRY"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[104]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_P_RecitedPoem = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_P_RecitedPoem"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[61]`

### Węzeł `[105]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_P_RecitedPoem == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_P_RecitedPoem == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_P_RecitedPoem"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_P_RecitedPoem == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_P_RecitedPoem"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[108]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_HP_FuneralPoem = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_FuneralPoem"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[109]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_HP_AttendFuneral = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_AttendFuneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[110]`
Mówca: **Narrator**
> "Hope was still on the horizon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn02_AttendedCircasFuneral = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_AttendedCircasFuneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[112]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist += 1;
BaseGame.Sollist -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[97]`
  - -> `[58]`
  - -> `[65]`

### Węzeł `[113]`
**[WYBÓR GRACZA: "“We rise, toward the sun! Those who died, died fighting. They are now buried in the sun. No need to mourn, there is a raid to the sun.""]** — Mówca: **Player**
> "“We rise, toward the sun! Those who died, died fighting. They are now buried in the sun. No need to mourn, there is a raid to the sun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_P_RecitedPoem2 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_P_RecitedPoem2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[61]`

### Węzeł `[115]`
**[WYBÓR GRACZA: ""They did not let us sing our songs. They are afraid, afraid of the dawn. They are afraid of hope, but our songs will be sung.""]** — Mówca: **Player**
> ""They did not let us sing our songs. They are afraid, afraid of the dawn. They are afraid of hope, but our songs will be sung.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_P_RecitedPoem3 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn02_P_RecitedPoem3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[61]`

### Węzeł `[117]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_P_RecitedPoem2 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_P_RecitedPoem2 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_P_RecitedPoem2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[119]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_P_RecitedPoem2 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_P_RecitedPoem2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_P_RecitedPoem3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn02_P_RecitedPoem3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_P_RecitedPoem3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[122]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn02_P_RecitedPoem3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_P_RecitedPoem3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[123]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_HP_FuneralPoem2 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_FuneralPoem2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[124]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_HP_FuneralPoem3 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_FuneralPoem3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[125]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Country_Unrest += 1;
BaseGame.Malenyevist += 1;
BaseGame.Democratic += 1;
BaseGame.Sollist -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Country_Unrest"] = Variable["BaseGame.Country_Unrest"] + 1;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[126]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_SordishState == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[128]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_SordishState == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_TaurusHolding == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_TaurusHolding == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[131]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_TaurusHolding == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[134]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[135]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist += 1;
BaseGame.Sollist += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[136]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Capitalist += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[137]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[139]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[140]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_ST_PresidentAttend = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_ST_PresidentAttend"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[141]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[143]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[144]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[148]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[149]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[97]`
  - -> `[58]`
  - -> `[65]`

### Węzeł `[150]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_ST_RYFuneralDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_ST_RYFuneralDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[151]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_ST_NoRYFuneralDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_ST_NoRYFuneralDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[152]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.AMorgnaWesCore += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[153]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Rain");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Rain");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[154]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_PoemBook");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_PoemBook");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[113]`
  - -> `[115]`

### Węzeł `[155]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
