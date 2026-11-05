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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[10]` | **"“It's okay Serge. I will hold my own umbrella.”"** | `[9]` **Narrator**: "Rain drops were running down the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Serge Wolkner**: "“As you wish sir.”" |
| `[11]` | **"“Thank you.”"** | `[9]` **Narrator**: "Rain drops were running down the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Serge Wolkner**: "“It's my duty, sir.”" |
| `[18]` | **"“We don't want something similar happening again, do we?”"** | `[17]` **Karl Greiser**: "“I just wanted to inform you tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Karl Greiser**: "“Absolutely not, Mr. President. ..." |
| `[19]` | **"“You better be right for your sake.”"** | `[17]` **Karl Greiser**: "“I just wanted to inform you tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Karl Greiser**: "“I have taken the necessary prec..." |
| `[20]` | **"“Good work. Thank you Karl.”"** | `[17]` **Karl Greiser**: "“I just wanted to inform you tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Narrator**: "Karl bowed his head with respect." |
| `[27]` | **"“Petr, you are being inconsiderate.”"** | `[26]` **Narrator**: "Petr let out a laugh, which drew..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Petr Vectern**: "“You are right. Sorry.”" |
| `[28]` | **"“I don't think any of us want that.”"** | `[26]` **Narrator**: "Petr let out a laugh, which drew..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Petr Vectern**: "“Indeed.”" |
| `[29]` | **"Gesture Petr to lower his voice."** | `[26]` **Narrator**: "Petr let out a laugh, which drew..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Petr Vectern**: "“You are right. Sorry.”" |
| `[37]` | **"“Let them in.”"** | `[36]` **Karl Greiser**: "“Should we let them in?”"<br>`[40]` **Karl Greiser**: "“No. They were thoroughly search..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_P_Funeral_AllowedRedYou...`<br>`Variable["BaseGame.Country_Unrest"] = Variable["BaseGame....` | `[41]` **Karl Greiser**: "“As you command.”" |
| `[38]` | **"“Absolutely not.”"** | `[36]` **Karl Greiser**: "“Should we let them in?”"<br>`[40]` **Karl Greiser**: "“No. They were thoroughly search..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_P_Funeral_AllowedRedYou...` | `[41]` **Karl Greiser**: "“As you command.”" |
| `[39]` | **"“Do you think they pose a security threat?”"** | `[36]` **Karl Greiser**: "“Should we let them in?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Karl Greiser**: "“No. They were thoroughly search..." |
| `[46]` | **"“Let them in but put a few guards on them.”"** | `[36]` **Karl Greiser**: "“Should we let them in?”"<br>`[40]` **Karl Greiser**: "“No. They were thoroughly search..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_P_Funeral_AllowedRedYou...`<br>`Variable["BaseGame.Country_Unrest"] = Variable["BaseGame....` | `[41]` **Karl Greiser**: "“As you command.”" |
| `[51]` | **"“Today, we are mourning Bernard Circas, a father, a husband and a loyal servant of..."** | `[50]` **Narrator**: "When the religious ceremony was ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "Towards the back of the crowd, I..."<br>`[56]` **Narrator**: "There was complete silence excep..." |
| `[57]` | **"“Regardless of his ideology, this was a heinous act made towards a good man. We mu..."** | `[56]` **Narrator**: "There was complete silence excep..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Player**: "“We will make sure that unfortun..."<br>`[97]` **Player**: "“Circas had a dream of a unified..."<br>*(oraz 2 innych odgałęzień)* |
| `[58]` | **"“I interpret this attack as an attack against Sordland and by extension, against m..."** | `[57]` **Player**: "“Regardless of his ideology, thi..."<br>`[82]` **Player**: "“This is a great loss for all of..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Player**: "“Let us all mourn the passing of..."<br>`[91]` **Player**: "“But, hatred begets hatred. Ther..."<br>*(oraz 1 innych odgałęzień)* |
| `[59]` | **"“We will make sure that unfortunate events such as this will never happen again.”"** | `[57]` **Player**: "“Regardless of his ideology, thi..."<br>`[82]` **Player**: "“This is a great loss for all of..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Player**: "“Let us all mourn the passing of..."<br>`[91]` **Player**: "“But, hatred begets hatred. Ther..."<br>*(oraz 1 innych odgałęzień)* |
| `[60]` | **"“He was a true comrade and he fought for what he believed in, his ideal vision of ..."** | `[56]` **Narrator**: "There was complete silence excep..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Mal...` | `[59]` **Player**: "“We will make sure that unfortun..."<br>`[97]` **Player**: "“Circas had a dream of a unified..."<br>*(oraz 2 innych odgałęzień)* |
| `[61]` | **"“A moment of silence please.”"** | `[64]` **Player**: "“Our only strength is the will t..."<br>`[113]` **Player**: "“We rise, toward the sun! Those ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Narrator**: "During the silence, all that was..." |
| `[62]` | **"“Thank you.”"** | `[89]` **Player**: "“The tears of the family he left..."<br>`[90]` **Player**: "“Let us all mourn the passing of..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Narrator**: "Some attendees started clapping,..." |
| `[63]` | **"“I would now like to recite one of the poems he left us.”"** | `[89]` **Player**: "“The tears of the family he left..."<br>`[90]` **Player**: "“Let us all mourn the passing of..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `EnableCollectionItem("CollectionItem_PoemBook");` | `[64]` **Player**: "“Our only strength is the will t..."<br>`[113]` **Player**: "“We rise, toward the sun! Those ..."<br>*(oraz 1 innych odgałęzień)* |
| `[64]` | **"“Our only strength is the will to survive, knowing that we will perish, knowing no..."** | `[63]` **Player**: "“I would now like to recite a pa..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_P_RecitedPoem"] = true;` | `[62]` **Player**: "“Thank you.”"<br>`[61]` **Player**: "“A moment of silence please.”" |
| `[65]` | **"“I promise you this. The blood of Bernard will not remain on the sacred ground of ..."** | `[57]` **Player**: "“Regardless of his ideology, thi..."<br>`[82]` **Player**: "“This is a great loss for all of..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Player**: "“Let us all mourn the passing of..."<br>`[91]` **Player**: "“But, hatred begets hatred. Ther..."<br>*(oraz 1 innych odgałęzień)* |
| `[78]` | **"“Thank you. I mean it.”"** | `[75]` **Narrator**: "I sensed only respect in his voice." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Petr Vectern**: "“I know you do.”" |
| `[82]` | **"“This is a great loss for all of us.”"** | `[56]` **Narrator**: "There was complete silence excep..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Player**: "“We will make sure that unfortun..."<br>`[97]` **Player**: "“Circas had a dream of a unified..."<br>*(oraz 2 innych odgałęzień)* |
| `[83]` | **"“As we bid farewell to Bernard, I want to close with the words every Sord lives by..."** | `[68]` **Narrator**: "The coffin was lowered into the ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame....` | `[85]` **Narrator**: "Everyone replied: “Vectern sis d..." |
| `[84]` | **"Step down from the podium."** | `[68]` **Narrator**: "The coffin was lowered into the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Narrator**: "The widow thanked me with a soft..." |
| `[88]` | **"Nod."** | `[75]` **Narrator**: "I sensed only respect in his voice." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Petr Vectern**: "“Come on, it's time to go.”" |
| `[89]` | **"“The tears of the family he left behind have a price that needs to be paid. I will..."** | `[58]` **Player**: "“I interpret this attack as an a..."<br>`[59]` **Player**: "“We will make sure that unfortun..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Player**: "“Thank you.”"<br>`[63]` **Player**: "“I would now like to recite a pa..." |
| `[90]` | **"“Let us all mourn the passing of Bernard Circas and remember him well.”"** | `[58]` **Player**: "“I interpret this attack as an a..."<br>`[59]` **Player**: "“We will make sure that unfortun..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Player**: "“Thank you.”"<br>`[63]` **Player**: "“I would now like to recite a pa..." |
| `[91]` | **"“But, hatred begets hatred. There is only one way to overcome this vicious cycle. ..."** | `[58]` **Player**: "“I interpret this attack as an a..."<br>`[59]` **Player**: "“We will make sure that unfortun..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Player**: "“Thank you.”"<br>`[63]` **Player**: "“I would now like to recite a pa..." |
| `[92]` | **"“It's time to go.”"** | `[75]` **Narrator**: "I sensed only respect in his voice." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Petr Vectern**: "“Agreed.”" |
| `[95]` | **"“You are the only one who can make me laugh at a funeral.”"** | `[26]` **Narrator**: "Petr let out a laugh, which drew..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Petr Vectern**: "“Hah! Right? I mean, life is ful..." |
| `[96]` | **"“I will confess that I disagreed with Bernard Circas almost entirely. But it doesn..."** | `[56]` **Narrator**: "There was complete silence excep..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Mal...` | `[59]` **Player**: "“We will make sure that unfortun..."<br>`[97]` **Player**: "“Circas had a dream of a unified..."<br>*(oraz 2 innych odgałęzień)* |
| `[97]` | **"“Circas had a dream of a unified Sordland. In these next months we need to fulfill..."** | `[57]` **Player**: "“Regardless of his ideology, thi..."<br>`[82]` **Player**: "“This is a great loss for all of..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Player**: "“Let us all mourn the passing of..."<br>`[91]` **Player**: "“But, hatred begets hatred. Ther..."<br>*(oraz 1 innych odgałęzień)* |
| `[113]` | **"“We rise, toward the sun! Those who died, died fighting. They are now buried in th..."** | `[63]` **Player**: "“I would now like to recite a pa..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_P_RecitedPoem2"] = true;` | `[62]` **Player**: "“Thank you.”"<br>`[61]` **Player**: "“A moment of silence please.”" |
| `[115]` | **""They did not let us sing our songs. They are afraid, afraid of the dawn. They are..."** | `[63]` **Player**: "“I would now like to recite a pa..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_P_RecitedPoem3"] = true;` | `[62]` **Player**: "“Thank you.”"<br>`[61]` **Player**: "“A moment of silence please.”" |

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
  - -> `[3]` (*Narrator: "Dark clouds were looming over Deyr. They looked daunting ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Dark clouds were looming over Deyr. They looked daunting as our convoy started approaching the century-old cemetery."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)

### Węzeł `[4]`
Mówca: **Petr Vectern**
> "“Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Karl Greiser: "“Mr. President.”"*)

### Węzeł `[5]`
Mówca: **Serge Wolkner**
> "“Sir, we have arrived.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Rain");"*)

### Węzeł `[6]`
Mówca: **Karl Greiser**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Karl Greiser: "“I just wanted to inform you that the perimeter is clear ..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "It looked like it was going to rain. Certainly fitting weather for a funeral."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "As expected, Bernard Circas's passing maintained its medi..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "As expected, Bernard Circas's passing maintained its media traction and all of Sordland was paying attention to the ceremony. Especially to what I would say in my speech today."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Serge Wolkner: "“Sir, we have arrived.”"*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Rain drops were running down the car window when Serge opened my door and held an umbrella over my head. As soon as I got out, flashes from the cameras blinded me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "“It's okay Serge. I will hold my own umbrella.”"*)
  - -> `[11]` (*Player: "“Thank you.”"*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“It's okay Serge. I will hold my own umbrella.”"]** — Mówca: **Player**
> "“It's okay Serge. I will hold my own umbrella.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Serge Wolkner: "“As you wish sir.”"*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Serge Wolkner: "“It's my duty, sir.”"*)

### Węzeł `[12]`
Mówca: **Serge Wolkner**
> "“As you wish sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "He handed me the umbrella and started waiting next to the..."*)

### Węzeł `[13]`
Mówca: **Serge Wolkner**
> "“It's my duty, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "He silently started following me while holding the umbrella."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "He handed me the umbrella and started waiting next to the car with his own."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Petr and Karl exited from their own cars in the convoy. T..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "He silently started following me while holding the umbrella."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Petr and Karl exited from their own cars in the convoy. T..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "Petr and Karl exited from their own cars in the convoy. They made their way over to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Petr Vectern: "“Anton.”"*)

### Węzeł `[17]`
Mówca: **Karl Greiser**
> "“I just wanted to inform you that the perimeter is clear and secured completely. There is no one getting in or out without our knowledge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: "“We don't want something similar happening again, do we?”"*)
  - -> `[19]` (*Player: "“You better be right for your sake.”"*)
  - -> `[20]` (*Player: "“Good work. Thank you Karl.”"*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“We don't want something similar happening again, do we?”"]** — Mówca: **Player**
> "“We don't want something similar happening again, do we?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Karl Greiser: "“Absolutely not, Mr. President. The same mistakes will ne..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "“You better be right for your sake.”"]** — Mówca: **Player**
> "“You better be right for your sake.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Karl Greiser: "“I have taken the necessary precautions. I personally mad..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“Good work. Thank you Karl.”"]** — Mówca: **Player**
> "“Good work. Thank you Karl.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Karl bowed his head with respect."*)

### Węzeł `[21]`
Mówca: **Karl Greiser**
> "“I have taken the necessary precautions. I personally made sure of that. We are all safe.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Petr Vectern: "“Good. If anything happens to Anton, you will have to ans..."*)

### Węzeł `[22]`
Mówca: **Karl Greiser**
> "“Absolutely not, Mr. President. The same mistakes will never happen again. I personally made sure of that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Petr Vectern: "“Good. If anything happens to Anton, you will have to ans..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "Karl bowed his head with respect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Petr Vectern: "“Good. If anything happens to Anton, you will have to ans..."*)

### Węzeł `[24]`
Mówca: **Petr Vectern**
> "“Good. If anything happens to Anton, you will have to answer to the First Lady.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Petr Vectern: "“And trust me Karl. You don't want that.”"*)

### Węzeł `[25]`
Mówca: **Petr Vectern**
> "“And trust me Karl. You don't want that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Petr let out a laugh, which drew some attention from bere..."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "Petr let out a laugh, which drew some attention from bereaved attendees."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: "“Petr, you are being inconsiderate.”"*)
  - -> `[28]` (*Player: "“I don't think any of us want that.”"*)
  - -> `[29]` (*Player_Italic: "Gesture Petr to lower his voice."*)
  - -> `[95]` (*Player: "“You are the only one who can make me laugh at a funeral.”"*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Petr, you are being inconsiderate.”"]** — Mówca: **Player**
> "“Petr, you are being inconsiderate.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Petr Vectern: "“You are right. Sorry.”"*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“I don't think any of us want that.”"]** — Mówca: **Player**
> "“I don't think any of us want that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Petr Vectern: "“Indeed.”"*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "Gesture Petr to lower his voice."]** — Mówca: **Player_Italic**
> "I gestured at Petr to lower his voice a bit."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Petr Vectern: "“You are right. Sorry.”"*)

### Węzeł `[30]`
Mówca: **Petr Vectern**
> "“You are right. Sorry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "It started to rain. Several unintelligible voices were he..."*)

### Węzeł `[31]`
Mówca: **Petr Vectern**
> "“You are right. Sorry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "It started to rain. Several unintelligible voices were he..."*)

### Węzeł `[32]`
Mówca: **Petr Vectern**
> "“Indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "It started to rain. Several unintelligible voices were he..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "It started to rain. Several unintelligible voices were heard from Karl's radio. He stepped out to reply and returned shortly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Karl Greiser: "“We have a small problem, sir.”"*)

### Węzeł `[34]`
Mówca: **Karl Greiser**
> "“We have a small problem, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Karl Greiser: "“A few -- five to be exact -- Red Youth members are here ..."*)

### Węzeł `[35]`
Mówca: **Karl Greiser**
> "“A few -- five to be exact -- Red Youth members are here to attend the funeral. They apparently said they wish to pay their respects to their fallen comrade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Karl Greiser: "“Should we let them in?”"*)

### Węzeł `[36]`
Mówca: **Karl Greiser**
> "“Should we let them in?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: "“Do you think they pose a security threat?”"*)
  - -> `[37]` (*Player: "“Let them in.”"*)
  - -> `[46]` (*Player: "“Let them in but put a few guards on them.”"*)
  - -> `[38]` (*Player: "“Absolutely not.”"*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“Let them in.”"]** — Mówca: **Player**
> "“Let them in.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Karl Greiser), `[40]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth = true"*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Absolutely not.”"]** — Mówca: **Player**
> "“Absolutely not, it is too risky.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Karl Greiser), `[40]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth = false..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Do you think they pose a security threat?”"]** — Mówca: **Player**
> "“Do you think they pose a security threat?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Karl Greiser: "“No. They were thoroughly searched. It looks like they re..."*)

### Węzeł `[40]`
Mówca: **Karl Greiser**
> "“No. They were thoroughly searched. It looks like they really are here to attend the funeral.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: "“Let them in.”"*)
  - -> `[46]` (*Player: "“Let them in but put a few guards on them.”"*)
  - -> `[38]` (*Player: "“Absolutely not.”"*)

### Węzeł `[41]`
Mówca: **Karl Greiser**
> "“As you command.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest += 1; BaseGame.Malenyevist += 1; ..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth = false;
BaseGame.Public_Opinion += 1;
BaseGame.Malenyevist -= 1;
BaseGame.Democratic -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth"] = false;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 1;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Karl Greiser: "“As you command.”"*)

### Węzeł `[44]`
Mówca: **Petr Vectern**
> "“Let's head over. They are about to start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "We walked towards the crowd circled around the grave. Eve..."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "We walked towards the crowd circled around the grave. Everyone in attendance was wearing black in mourning. The rain started pouring heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "Bernard's widow and daughter were in the front row, stari..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Let them in but put a few guards on them.”"]** — Mówca: **Player**
> "“Let them in but put a few guards on them to be safe.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Karl Greiser), `[40]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth = true"*)

### Węzeł `[47]`
Mówca: **Narrator**
> "Bernard's widow and daughter were in the front row, staring at the coffin with a mixture of disbelief, confusion and above all, a cold, unforgiving sadness."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Both of their eyes were very red and swollen from weeping."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "Before taking my place to observe the ceremony, I gave my condolences to Bernard's wife and his daughter who looked at me. She reminded me of Deana."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "When the religious ceremony was done, I was invited by th..."*)

### Węzeł `[49]`
Mówca: **Narrator**
> "Both of their eyes were very red and swollen from weeping."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "Before taking my place to observe the ceremony, I gave my..."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "When the religious ceremony was done, I was invited by the priest to deliver my speech. I took the podium. I felt like I had a lump in my throat. I couldn't get the daughter's eyes out of my head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“Today, we are mourning Bernard Circas, a father, a husba..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Today, we are mourning Bernard Circas, a father, a husband and a loyal servant of this country.”"]** — Mówca: **Player**
> "“Today, we are mourning Bernard Circas, a father, a husband and a loyal servant of this country.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true"*)

### Węzeł `[52]`
Mówca: **Narrator**
> "Towards the back of the crowd, I spotted the members of the Red Youth, wearing red shirts and black bands of mourning on their arms. They seemed ruly and were respectfully bowing their heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "There was complete silence except for the sound of raindr..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Towards the back of the crowd, I spotted the members of t..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "There was complete silence except for the sound of raindr..."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "There was complete silence except for the sound of raindrops."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: "“This is a great loss for all of us.”"*)
  - -> `[96]` (*Player: "“I will confess that I disagreed with Bernard Circas almo..."*)
  - -> `[57]` (*Player: "“Regardless of his ideology, this was a heinous act made ..."*)
  - -> `[60]` (*Player: "“He was a true comrade and he fought for what he believed..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "“Regardless of his ideology, this was a heinous act made towards a good man. We must end this cycle of violence.”"]** — Mówca: **Player**
> "“Regardless of his ideology, this was a heinous act made towards a good man. We must end this cycle of violence now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: "“We will make sure that unfortunate events such as this w..."*)
  - -> `[97]` (*Player: "“Circas had a dream of a unified Sordland. In these next ..."*)
  - -> `[58]` (*Player: "“I interpret this attack as an attack against Sordland an..."*)
  - -> `[65]` (*Player: "“I promise you this. The blood of Bernard will not remain..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "“I interpret this attack as an attack against Sordland and by extension, against me personally.”"]** — Mówca: **Player**
> "“I interpret this attack as an attack against Sordland and by extension, against me personally.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Player), `[82]` (Player), `[60]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: "“Let us all mourn the passing of Bernard Circas and remem..."*)
  - -> `[91]` (*Player: "“But, hatred begets hatred. There is only one way to over..."*)
  - -> `[89]` (*Player: "“The tears of the family he left behind have a price that..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“We will make sure that unfortunate events such as this will never happen again.”"]** — Mówca: **Player**
> "“We will make sure that unfortunate events such as this will never happen ever again.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Player), `[82]` (Player), `[60]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: "“Let us all mourn the passing of Bernard Circas and remem..."*)
  - -> `[91]` (*Player: "“But, hatred begets hatred. There is only one way to over..."*)
  - -> `[89]` (*Player: "“The tears of the family he left behind have a price that..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“He was a true comrade and he fought for what he believed in, his ideal vision of Sordland, in every step of his life.”"]** — Mówca: **Player**
> "“He was a true comrade and he fought for what he believed in, his ideal vision of Sordland, in every step of his life. We must learn from him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist += 1; BaseGame.Sollist -= 1;"*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "“A moment of silence please.”"]** — Mówca: **Player**
> "“A moment of silence please.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Player), `[113]` (Player), `[115]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "During the silence, all that was heard were the ravens."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Player), `[90]` (Player), `[91]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "Some attendees started clapping, some crying."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“I would now like to recite one of the poems he left us.”"]** — Mówca: **Player**
> "“I would now like to recite a part from one of the poems he left us.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Player), `[90]` (Player), `[91]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_PoemBook");"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Our only strength is the will to survive, knowing that we will perish, knowing nothing more absolute.”"]** — Mówca: **Player**
> "“Our only strength is the will to survive, knowing that we will perish, knowing nothing more absolute.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_P_RecitedPoem = true"*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“I promise you this. The blood of Bernard will not remain on the sacred ground of Sordland.”"]** — Mówca: **Player**
> "“I promise you this. The blood of Bernard will not remain on the sacred ground of Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Player), `[82]` (Player), `[60]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: "“Let us all mourn the passing of Bernard Circas and remem..."*)
  - -> `[91]` (*Player: "“But, hatred begets hatred. There is only one way to over..."*)
  - -> `[89]` (*Player: "“The tears of the family he left behind have a price that..."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "During the silence, all that was heard were the ravens."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "Some attendees started clapping, some crying."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "Some attendees started clapping, some crying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "The coffin was lowered into the grave by the gravekeepers..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "The coffin was lowered into the grave by the gravekeepers. After a couple of minutes, Bernard Circas was with the soil, no more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player: "“As we bid farewell to Bernard, I want to close with the ..."*)
  - -> `[84]` (*Player_Italic: "Step down from the podium."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "The widow thanked me with a soft and defeated voice before we dispersed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "On my way back to the car, I still couldn't get the eyes ..."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "On my way back to the car, I still couldn't get the eyes of Bernard's daughter, nor the faltering voice of his wife, out of my head. Would Deana, Monica and Franc look the same way if something happened to me?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "Petr put his hand on my shoulder."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "Petr put his hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Petr Vectern: "“That was a good speech.”"*)

### Węzeł `[72]`
Mówca: **Petr Vectern**
> "“That was a good speech.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "I sensed only respect in his voice."*)

### Węzeł `[73]`
Mówca: **Petr Vectern**
> "“Come on, it's time to go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Petr Vectern: "“We've got work to do.”"*)

### Węzeł `[74]`
Mówca: **Petr Vectern**
> "“We've got work to do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "He was right. We had work to do. So much more to do."*)

### Węzeł `[75]`
Mówca: **Narrator**
> "I sensed only respect in his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: "“It's time to go.”"*)
  - -> `[78]` (*Player: "“Thank you. I mean it.”"*)
  - -> `[88]` (*Player_Italic: "Nod."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "He was right. We had work to do. So much more to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "I realized that the rain had stopped, and I looked up."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn02_Personal_Funeral = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn02_Personal_Funeral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "“Thank you. I mean it.”"]** — Mówca: **Player**
> "“Thank you. I mean it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Petr Vectern: "“I know you do.”"*)

### Węzeł `[79]`
Mówca: **Petr Vectern**
> "“I know you do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Petr Vectern: "“Come on, it's time to go.”"*)

### Węzeł `[80]`
Mówca: **Narrator**
> "I realized that the rain had stopped, and I looked up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "The black clouds slowly dispersed and sunbeams enlightene..."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "The black clouds slowly dispersed and sunbeams enlightened our surroundings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "As someone once said: 'Even the darkest night will end an..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "“This is a great loss for all of us.”"]** — Mówca: **Player**
> "“This is a great loss for all of us, for our country.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: "“We will make sure that unfortunate events such as this w..."*)
  - -> `[97]` (*Player: "“Circas had a dream of a unified Sordland. In these next ..."*)
  - -> `[58]` (*Player: "“I interpret this attack as an attack against Sordland an..."*)
  - -> `[65]` (*Player: "“I promise you this. The blood of Bernard will not remain..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“As we bid farewell to Bernard, I want to close with the words every Sord lives by: A Morgna wes core!”"]** — Mówca: **Player**
> "“As we bid farewell to Bernard, I want to close with the words every Sord lives by: A Morgna wes core!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.AMorgnaWesCore += 1"*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "Step down from the podium."]** — Mówca: **Player_Italic**
> "I stepped down from the podium. It was time to leave."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "The widow thanked me with a soft and defeated voice befor..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "Everyone replied: “Vectern sis da!”. Victory is close."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "With applauses, I stepped down from the podium. It was ti..."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "With applauses, I stepped down from the podium. It was time to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "The widow thanked me with a soft and defeated voice befor..."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "As someone once said: 'Even the darkest night will end and the sun will rise.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "Hope was still on the horizon."*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Petr Vectern: "“Come on, it's time to go.”"*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "“The tears of the family he left behind have a price that needs to be paid. I will not stop until it is paid in full.”"]** — Mówca: **Player**
> "“The tears of the family he left behind have a price that needs to be paid. I will not stop until it is paid in full.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Player), `[59]` (Player), `[65]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: "“Thank you.”"*)
  - -> `[63]` (*Player: "“I would now like to recite one of the poems he left us.”"*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "“Let us all mourn the passing of Bernard Circas and remember him well.”"]** — Mówca: **Player**
> "“Let us all mourn the passing of Bernard Circas and remember him well.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Player), `[59]` (Player), `[65]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: "“Thank you.”"*)
  - -> `[63]` (*Player: "“I would now like to recite one of the poems he left us.”"*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "“But, hatred begets hatred. There is only one way to overcome this vicious cycle. We must unite against the evil of this world.”"]** — Mówca: **Player**
> "“But, hatred begets hatred. There is only one way to overcome this vicious cycle. We must unite against the evil of this world.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Player), `[59]` (Player), `[65]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: "“Thank you.”"*)
  - -> `[63]` (*Player: "“I would now like to recite one of the poems he left us.”"*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "“It's time to go.”"]** — Mówca: **Player**
> "“It's time to go.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Petr Vectern: "“Agreed.”"*)

### Węzeł `[93]`
Mówca: **Petr Vectern**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Petr Vectern: "“We've got work to do.”"*)

### Węzeł `[94]`
Mówca: **Petr Vectern**
> "“Hah! Right? I mean, life is full of tragedy. We should try to take it easy if we can.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "It started to rain. Several unintelligible voices were he..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "“You are the only one who can make me laugh at a funeral.”"]** — Mówca: **Player**
> "“You are the only one that can make me laugh at a funeral.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Petr Vectern: "“Hah! Right? I mean, life is full of tragedy. We should t..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA: "“I will confess that I disagreed with Bernard Circas almost entirely. But it doesn't mean that he deserved this. Our country can be a better place.”"]** — Mówca: **Player**
> "“I will confess that I disagreed with Bernard Circas almost entirely. But it doesn't mean that he deserved this. Our country can be a better place.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist -= 1"*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "“Circas had a dream of a unified Sordland. In these next months we need to fulfill his dream and band together.”"]** — Mówca: **Player**
> "“Circas had a dream of a unified Sordland. In these next months we need to fulfill his dream and band together.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Player), `[82]` (Player), `[60]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: "“Let us all mourn the passing of Bernard Circas and remem..."*)
  - -> `[91]` (*Player: "“But, hatred begets hatred. There is only one way to over..."*)
  - -> `[89]` (*Player: "“The tears of the family he left behind have a price that..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true"*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true)"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_R_ThousandsAttendFuneral = true"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_R_ControversyAtFuneral = true"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_R_ThousandsAttendFuneral = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_R_ThousandsAttendFuneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == false"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_R_ControversyAtFuneral = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_R_ControversyAtFuneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == false"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_ST_PresidentRY = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_ST_PresidentRY"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_Personal_Funeral = true"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_P_RecitedPoem = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_P_RecitedPoem"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: "“Thank you.”"*)
  - -> `[61]` (*Player: "“A moment of silence please.”"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_P_RecitedPoem == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_P_RecitedPoem == true"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_P_RecitedPoem == true)"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_P_RecitedPoem == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_P_RecitedPoem"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_HP_FuneralPoem = true"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_P_RecitedPoem == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_P_RecitedPoem"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_P_RecitedPoem2 == true"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_HP_FuneralPoem = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_FuneralPoem"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_HP_AttendFuneral = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_AttendFuneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true"*)

### Węzeł `[110]`
Mówca: **Narrator**
> "Hope was still on the horizon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_AttendedCircasFuneral = true"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_AttendedCircasFuneral = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_AttendedCircasFuneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_P_RecitedPoem == true"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist += 1;
BaseGame.Sollist -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: "“We will make sure that unfortunate events such as this w..."*)
  - -> `[97]` (*Player: "“Circas had a dream of a unified Sordland. In these next ..."*)
  - -> `[58]` (*Player: "“I interpret this attack as an attack against Sordland an..."*)
  - -> `[65]` (*Player: "“I promise you this. The blood of Bernard will not remain..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "“We rise, toward the sun! Those who died, died fighting. They are now buried in the sun. No need to mourn, there is a raid to the sun.""]** — Mówca: **Player**
> "“We rise, toward the sun! Those who died, died fighting. They are now buried in the sun. No need to mourn, there is a raid to the sun.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_P_RecitedPoem2 = true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_P_RecitedPoem2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_P_RecitedPoem2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: "“Thank you.”"*)
  - -> `[61]` (*Player: "“A moment of silence please.”"*)

### Węzeł `[115]`
**[WYBÓR GRACZA: ""They did not let us sing our songs. They are afraid, afraid of the dawn. They are afraid of hope, but our songs will be sung.""]** — Mówca: **Player**
> ""They did not let us sing our songs. They are afraid, afraid of the dawn. They are afraid of hope, but our songs will be sung.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_P_RecitedPoem3 = true"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_P_RecitedPoem3 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_P_RecitedPoem3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: "“Thank you.”"*)
  - -> `[61]` (*Player: "“A moment of silence please.”"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_P_RecitedPoem2 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_P_RecitedPoem2 == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_P_RecitedPoem2 == true)"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_P_RecitedPoem2 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_P_RecitedPoem2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_HP_FuneralPoem2 = true"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_P_RecitedPoem2 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_P_RecitedPoem2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_P_RecitedPoem3 == true"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_P_RecitedPoem3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_P_RecitedPoem3 == true"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_P_RecitedPoem3 == true)"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_P_RecitedPoem3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_P_RecitedPoem3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_HP_FuneralPoem3 = true"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_P_RecitedPoem3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_P_RecitedPoem3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_HP_AttendFuneral = true"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_HP_FuneralPoem2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_FuneralPoem2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_HP_FuneralPoem3 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_FuneralPoem3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_P_Funeral_AllowedRedYouth == true"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Country_Unrest += 1;
BaseGame.Malenyevist += 1;
BaseGame.Democratic += 1;
BaseGame.Sollist -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Country_Unrest"] = Variable["BaseGame.Country_Unrest"] + 1;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Karl Greiser: "“As you command.”"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_SordishState == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist += 1; BaseGame.Sollist += 1"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_SordishState == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_TaurusHolding == true"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_TaurusHolding == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_TaurusHolding == true"*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_TaurusHolding == true)"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_TaurusHolding == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist += 1"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_TaurusHolding == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction =..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Capitalist += 1"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "It looked like it was going to rain. Certainly fitting we..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist += 1;
BaseGame.Sollist += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "It looked like it was going to rain. Certainly fitting we..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Capitalist += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "It looked like it was going to rain. Certainly fitting we..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == false"*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == false)"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_ST_PresidentRY = true"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_ST_RYFuneralDeal = true"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_ST_PresidentAttend = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_ST_PresidentAttend"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_Personal_Funeral = true"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == false"*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == false)"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_ST_PresidentAttend = true"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_ST_NoRYFuneralDeal = true"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true)"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 1;"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1;"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Petr Vectern: "“Let's head over. They are about to start.”"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Petr Vectern: "“Let's head over. They are about to start.”"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: "“We will make sure that unfortunate events such as this w..."*)
  - -> `[97]` (*Player: "“Circas had a dream of a unified Sordland. In these next ..."*)
  - -> `[58]` (*Player: "“I interpret this attack as an attack against Sordland an..."*)
  - -> `[65]` (*Player: "“I promise you this. The blood of Bernard will not remain..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_ST_RYFuneralDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_ST_RYFuneralDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_Personal_Funeral = true"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_ST_NoRYFuneralDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_ST_NoRYFuneralDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_Personal_Funeral = true"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AMorgnaWesCore += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "Everyone replied: “Vectern sis da!”. Victory is close."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Rain");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Rain");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Rain drops were running down the car window when Serge op..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_PoemBook");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_PoemBook");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: "“Our only strength is the will to survive, knowing that w..."*)
  - -> `[113]` (*Player: "“We rise, toward the sun! Those who died, died fighting. ..."*)
  - -> `[115]` (*Player: ""They did not let us sing our songs. They are afraid, afr..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
