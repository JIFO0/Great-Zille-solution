# Rizia/Turn 8/Heljiland Dispute

- **ID konwersacji:** `403`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/403_Heljiland_Dispute.md`
- **Liczba węzłów dialogowych:** 101
- **Liczba wyborów gracza:** 13

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[69]** Jorga Azmal
- **[70]** Laurento Esquibel
- **[71]** Leon Malenyev (R)
- **[74]** Maartin Van Hoorten (R)
- **[76]** Ephraim Nines (R)
- **[77]** Wiktor Smolak (R)
- **[78]** Emmerich Hegel (R)
- **[82]** Dwight Walker (R)
- **[92]** Beatrice Livingston (R)
- **[93]** Player_Romus_Italic *(Gracz)*
- **[94]** Axel Reinhart
- **[95]** Player_Romus *(Gracz)*
- **[96]** Anton Rayne (R)
- **[99]** Patricio Alvarez (R)
- **[100]** Alma Saltana

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Agnolia_HeljilandRecognised`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Vina_MarriageDecision_Axel`
- `RiziaDLC.War_Pales_Won`
- `RiziaDLC.ZilleReferendum_NotStoppedByAN`
- `RiziaDLC.ZilleReferendum_StoppedByAN`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLCSupport.Journal_Turn08_ANSession_HeljilandAye`
- `RiziaDLCSupport.Journal_Turn08_ANSession_HeljilandNay`
- `RiziaDLCSupport.News_Turn08_G_HeljilandRecognition`
- `RiziaDLCSupport.Reports_Turn08_Agnolia_HelijlandRecognition_Yes`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[401] Rizia/Turn 8/FPnT_ANSession** (../Turn_08/401_FPnT_ANSession.md), Węzeł `[29]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[15]` | **""What do you mean?""** | `[13]` **Laurento Esquibel**: ""This again. We're in for an int..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Laurento Esquibel**: ""He's reigniting Agnolia's feud ..." |
| `[16]` | **"Keep watching."** | `[13]` **Laurento Esquibel**: ""This again. We're in for an int..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Maartin Van Hoorten (R)**: ""The innocent Agnolians living o..." |
| `[32]` | **""Agnolia has no chance. Valgsland won't stand for this.""** | `[31]` **Laurento Esquibel**: ""He has a point."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Laurento Esquibel**: ""No, they won't. Especially not ..." |
| `[33]` | **""He speaks the truth, that's for sure.""** | `[31]` **Laurento Esquibel**: ""He has a point."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Laurento Esquibel**: ""I admire his pride and his brav..." |
| `[34]` | **""Having a point is not enough. There is more at play here.""** | `[31]` **Laurento Esquibel**: ""He has a point."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Laurento Esquibel**: ""As unfortunate as it is, we've ..." |
| `[56]` | **""Aye.""** | `[55]` **Narrator**: "It was finally my turn to cast a..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn08_ANSession_Heljil...` | `[58]` **Narrator**: "Gasps and hushed whispers circul..." |
| `[57]` | **""Nay.""** | `[55]` **Narrator**: "It was finally my turn to cast a..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn08_ANSession_Heljil...` | `[66]` **Narrator**: "The voting concluded and Preside..." |
| `[60]` | **""No need to thank me. I only did it because I thought it was right.""** | `[59]` **Maartin Van Hoorten (R)**: ""Thank you for your support, You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Maartin Van Hoorten (R)**: ""Thank you regardless. I won't f..." |
| `[62]` | **""That was a touching speech.""** | `[59]` **Maartin Van Hoorten (R)**: ""Thank you for your support, You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Maartin Van Hoorten (R)**: ""Thank you. I won't forget that ..." |
| `[63]` | **""Best of luck.""** | `[59]` **Maartin Van Hoorten (R)**: ""Thank you for your support, You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Maartin Van Hoorten (R)**: ""Thank you. I won't forget that ..." |
| `[82]` | **""The AN recognized Zille as Rizian territory. I suppose he thinks he has a shot.""** | `[31]` **Laurento Esquibel**: ""He has a point."" | `Variable["RiziaDLC.ZilleReferendum_StoppedByAN"] == true` | *Brak zmian stanu* | `[86]` **Laurento Esquibel**: ""Yes, although the circumstances..." |
| `[90]` | **""The AN wouldn't even recognize Zille as Rizian territory. What makes him think he..."** | `[31]` **Laurento Esquibel**: ""He has a point."" | `Variable["RiziaDLC.ZilleReferendum_NotStoppedByAN"] == true`<br>`(Variable["RiziaDLC.ZilleReferendum_StoppedByAN"] == true) == false` | *Brak zmian stanu* | `[91]` **Laurento Esquibel**: ""That's a good question."" |
| `[99]` | **""Perhaps you will also support me in the recognition of Pales as Rizia's rightful ..."** | `[59]` **Maartin Van Hoorten (R)**: ""Thank you for your support, You..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[100]` **Maartin Van Hoorten (R)**: ""I-- I can't promise anything. B..." |

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
  - -> `[3]` (*Ephraim Nines (R): ""The Alliance of Nations summons Maartin van Hoorten, Pri..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "I could see that Emmerich Hegel had a smirk on his face. ..."*)

### Węzeł `[3]`
Mówca: **Ephraim Nines (R)**
> ""The Alliance of Nations summons Maartin van Hoorten, Prime Minister of Agnolia, to the stage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "I looked around the room. The attendees' attention had be..."*)

### Węzeł `[4]`
Mówca: **Maartin Van Hoorten (R)**
> ""Good morning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Maartin Van Hoorten (R): ""It is an honor to see you all in this chamber.""*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Maartin Van Hoorten (R)");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Maartin Van Hoorten (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Maartin Van Hoorten (R): ""Thank you, President Nines.""*)

### Węzeł `[6]`
Mówca: **Maartin Van Hoorten (R)**
> ""It is an honor to see you all in this chamber.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Maartin Van Hoorten (R): ""The Alliance of Nations and its position is paramount to..."*)

### Węzeł `[7]`
Mówca: **Maartin Van Hoorten (R)**
> ""The Alliance of Nations and its position is paramount to maintaining peace in the world. It is the sole organization that can bring all of us together...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Maartin Van Hoorten (R): ""Not only for constructive discussions, but for collectiv..."*)

### Węzeł `[8]`
Mówca: **Maartin Van Hoorten (R)**
> ""Thank you, President Nines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Maartin Van Hoorten (R): ""Good morning.""*)

### Węzeł `[9]`
Mówca: **Maartin Van Hoorten (R)**
> ""Not only for constructive discussions, but for collective problem-solving.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Maartin Van Hoorten (R): ""With our combined will and desire for justice, there is ..."*)

### Węzeł `[10]`
Mówca: **Maartin Van Hoorten (R)**
> ""With our combined will and desire for justice, there is no issue we cannot resolve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Maartin Van Hoorten (R): ""I therefore ask for your assistance in the fair and just..."*)

### Węzeł `[11]`
Mówca: **Maartin Van Hoorten (R)**
> ""I therefore ask for your assistance in the fair and just resolution of a dilemma faced by my proud nation of Agnolia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Maartin Van Hoorten (R): ""It concerns Helji Island.""*)

### Węzeł `[12]`
Mówca: **Maartin Van Hoorten (R)**
> ""It concerns Helji Island.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Upon hearing the name of the island, everyone in the room..."*)

### Węzeł `[13]`
Mówca: **Laurento Esquibel**
> ""This again. We're in for an interesting time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player_Romus: ""What do you mean?""*)
  - -> `[16]` (*Player_Romus_Italic: "Keep watching."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "Upon hearing the name of the island, everyone in the room woke up and sprang to attention. I heard Laurento mutter under his breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Laurento Esquibel: ""This again. We're in for an interesting time.""*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Laurento Esquibel: ""He's reigniting Agnolia's feud with Valgsland. If you as..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "Keep watching."]** — Mówca: **Player_Romus_Italic**
> "I kept watching the speech."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Maartin Van Hoorten (R): ""The innocent Agnolians living on this island are current..."*)

### Węzeł `[17]`
Mówca: **Laurento Esquibel**
> ""He's reigniting Agnolia's feud with Valgsland. If you ask me, now is neither the time nor place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Maartin Van Hoorten (R): ""The innocent Agnolians living on this island are current..."*)

### Węzeł `[18]`
Mówca: **Maartin Van Hoorten (R)**
> ""The innocent Agnolians living on this island are currently living under the long shadow cast by Valgsland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Maartin Van Hoorten (R): ""Their territorial ambitions know no bounds. They will no..."*)

### Węzeł `[19]`
Mówca: **Maartin Van Hoorten (R)**
> ""Their territorial ambitions know no bounds. They will not rest until they have subdued every Agnolian soul on the land they have unlawfully claimed as theirs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Maartin Van Hoorten (R): ""Helji Island is a vital piece of our heritage that Chanc..."*)

### Węzeł `[20]`
Mówca: **Maartin Van Hoorten (R)**
> ""I pose you this question. What would you have done if it was your own land under threat?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Our eyes randomly met before he turned his gaze away."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "Our eyes randomly met before he turned his gaze away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Maartin Van Hoorten (R): ""The place where your great-grandfather was born, where y..."*)

### Węzeł `[22]`
Mówca: **Maartin Van Hoorten (R)**
> ""The place where your great-grandfather was born, where your father was born...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Maartin Van Hoorten (R): ""Would you not defend it? Would you not protect it with y..."*)

### Węzeł `[23]`
Mówca: **Maartin Van Hoorten (R)**
> ""For peace in Eastern Merkopa, Heljiland has to be recognized as Agnolian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Maartin Van Hoorten (R): ""Don't forget. If you tolerate this happening to us, your..."*)

### Węzeł `[24]`
Mówca: **Maartin Van Hoorten (R)**
> ""I urge you to do the right thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Maartin Van Hoorten (R): ""Thank you.""*)

### Węzeł `[25]`
Mówca: **Maartin Van Hoorten (R)**
> ""Helji Island is a vital piece of our heritage that Chancellor Hegel is trying to take away from us by force.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Maartin Van Hoorten (R): ""I pose you this question. What would you have done if it..."*)

### Węzeł `[26]`
Mówca: **Maartin Van Hoorten (R)**
> ""Would you not defend it? Would you not protect it with your life?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Laurento Esquibel: ""He has a point.""*)

### Węzeł `[27]`
Mówca: **Maartin Van Hoorten (R)**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "I could see that Emmerich Hegel had a smirk on his face. ..."*)

### Węzeł `[28]`
Mówca: **Maartin Van Hoorten (R)**
> ""Don't forget. If you tolerate this happening to us, your own nations will be next.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Maartin Van Hoorten (R): ""I urge you to do the right thing.""*)

### Węzeł `[29]`
Mówca: **Narrator**
> "I could see that Emmerich Hegel had a smirk on his face. He seemed confident."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Ephraim Nines (R): ""Thank you, Mr. Prime Minister. The voting will now comme..."*)

### Węzeł `[30]`
Mówca: **Ephraim Nines (R)**
> ""Thank you, Mr. Prime Minister. The voting will now commence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "AddConversant("Jorga Azmal"); AddConversant("Patricio Alv..."*)

### Węzeł `[31]`
Mówca: **Laurento Esquibel**
> ""He has a point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player_Romus: ""He speaks the truth, that's for sure.""*)
  - -> `[32]` (*Player_Romus: ""Agnolia has no chance. Valgsland won't stand for this.""*)
  - -> `[34]` (*Player_Romus: ""Having a point is not enough. There is more at play here.""*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_StoppedByAN == true"*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Agnolia has no chance. Valgsland won't stand for this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Laurento Esquibel: ""No, they won't. Especially not with United Contana backi..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He speaks the truth, that's for sure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Laurento Esquibel: ""I admire his pride and his bravery. Even if they will no..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Having a point is not enough. There is more at play here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Laurento Esquibel: ""As unfortunate as it is, we've seen firsthand how often ..."*)

### Węzeł `[35]`
Mówca: **Laurento Esquibel**
> ""I admire his pride and his bravery. Even if they will not help him here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Maartin Van Hoorten (R): ""For peace in Eastern Merkopa, Heljiland has to be recogn..."*)

### Węzeł `[36]`
Mówca: **Laurento Esquibel**
> ""No, they won't. Especially not with United Contana backing them up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Maartin Van Hoorten (R): ""For peace in Eastern Merkopa, Heljiland has to be recogn..."*)

### Węzeł `[37]`
Mówca: **Laurento Esquibel**
> ""As unfortunate as it is, we've seen firsthand how often might makes right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Maartin Van Hoorten (R): ""For peace in Eastern Merkopa, Heljiland has to be recogn..."*)

### Węzeł `[38]`
Mówca: **Jorga Azmal**
> ""Nay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Patricio Alvarez (R): ""Aye.""*)

### Węzeł `[39]`
Mówca: **Patricio Alvarez (R)**
> ""Aye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Dwight Walker (R): ""Abstain.""*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_HeljilandRecognised == true)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Anton Rayne (R): ""Aye.""*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Anton Rayne (R): ""Nay.""*)

### Węzeł `[43]`
Mówca: **Anton Rayne (R)**
> ""Aye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Won == true"*)

### Węzeł `[44]`
Mówca: **Anton Rayne (R)**
> ""Nay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Won == true"*)

### Węzeł `[45]`
Mówca: **Axel Reinhart**
> ""Nay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Alma Saltana: ""Nay.""*)

### Węzeł `[46]`
Mówca: **Alma Saltana**
> ""Nay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Beatrice Livingston (R): ""Nay.""*)

### Węzeł `[47]`
Mówca: **Beatrice Livingston (R)**
> ""Nay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Emmerich Hegel (R): ""Nay.""*)

### Węzeł `[48]`
Mówca: **Emmerich Hegel (R)**
> ""Nay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Leon Malenyev (R): ""Nay.""*)

### Węzeł `[49]`
Mówca: **Wiktor Smolak (R)**
> ""Nay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Jorga Azmal"); RemoveConversant("Patric..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Jorga Azmal");
AddConversant("Patricio Alvarez (R)");
AddConversant("Dwight Walker (R)");
AddConversant("Maartin Van Hoorten (R)");
AddConversant("Anton Rayne (R)");
AddConversant("Axel Reinhart");
AddConversant("Alma Saltana");
AddConversant("Beatrice Livingston (R)");
AddConversant("Emmerich Hegel (R)");
AddConversant("Leon Malenyev (R)");
AddConversant("Wiktor Smolak (R)");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Jorga Azmal");
AddConversant("Patricio Alvarez (R)");
AddConversant("Dwight Walker (R)");
AddConversant("Maartin Van Hoorten (R)");
AddConversant("Anton Rayne (R)");
AddConversant("Axel Reinhart");
AddConversant("Alma Saltana");
AddConversant("Beatrice Livingston (R)");
AddConversant("Emmerich Hegel (R)");
AddConversant("Leon Malenyev (R)");
AddConversant("Wiktor Smolak (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Jorga Azmal: ""Nay.""*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Jorga Azmal");
RemoveConversant("Patricio Alvarez (R)");
RemoveConversant("Dwight Walker (R)");
RemoveConversant("Maartin Van Hoorten (R)");
RemoveConversant("Anton Rayne (R)");
RemoveConversant("Axel Reinhart");
RemoveConversant("Alma Saltana");
RemoveConversant("Beatrice Livingston (R)");
RemoveConversant("Emmerich Hegel (R)");
RemoveConversant("Leon Malenyev (R)");
RemoveConversant("Wiktor Smolak (R)");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Jorga Azmal");
RemoveConversant("Patricio Alvarez (R)");
RemoveConversant("Dwight Walker (R)");
RemoveConversant("Maartin Van Hoorten (R)");
RemoveConversant("Anton Rayne (R)");
RemoveConversant("Axel Reinhart");
RemoveConversant("Alma Saltana");
RemoveConversant("Beatrice Livingston (R)");
RemoveConversant("Emmerich Hegel (R)");
RemoveConversant("Leon Malenyev (R)");
RemoveConversant("Wiktor Smolak (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "It was finally my turn to cast a vote."*)

### Węzeł `[52]`
Mówca: **Dwight Walker (R)**
> ""Abstain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Maartin Van Hoorten (R): ""Aye.""*)

### Węzeł `[53]`
Mówca: **Leon Malenyev (R)**
> ""Nay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Wiktor Smolak (R): ""Nay.""*)

### Węzeł `[54]`
Mówca: **Maartin Van Hoorten (R)**
> ""Aye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[55]`
Mówca: **Narrator**
> "It was finally my turn to cast a vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""Aye.""*)
  - -> `[57]` (*Player_Romus: ""Nay.""*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Aye.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn08_ANSession_HeljilandAye = t..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nay.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn08_ANSession_HeljilandNay = true"*)

### Węzeł `[58]`
Mówca: **Narrator**
> "Gasps and hushed whispers circulated around the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "AddConversant("Maartin Van Hoorten (R)");"*)

### Węzeł `[59]`
Mówca: **Maartin Van Hoorten (R)**
> ""Thank you for your support, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[60]` (*Player_Romus: ""No need to thank me. I only did it because I thought it ..."*)
  - -> `[62]` (*Player_Romus: ""That was a touching speech.""*)
  - -> `[63]` (*Player_Romus: ""Best of luck.""*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to thank me. I only did it because I thought it was right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Maartin Van Hoorten (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Maartin Van Hoorten (R): ""Thank you regardless. I won't forget that you stood by o..."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "Maartin Van Hoorten came over to my side to personally shake my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Maartin Van Hoorten (R): ""Thank you for your support, Your Majesty.""*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That was a touching speech.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Maartin Van Hoorten (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Maartin Van Hoorten (R): ""Thank you. I won't forget that you stood by our side.""*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Best of luck.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Maartin Van Hoorten (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Maartin Van Hoorten (R): ""Thank you. I won't forget that you stood by our side.""*)

### Węzeł `[64]`
Mówca: **Maartin Van Hoorten (R)**
> ""Thank you regardless. I won't forget that you stood by our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "He left to talk to his aides."*)

### Węzeł `[65]`
Mówca: **Maartin Van Hoorten (R)**
> ""Thank you. I won't forget that you stood by our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "He left to talk to his aides."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "The voting concluded and President Nines took his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Ephraim Nines (R): ""By a large margin, the Nays have won. Helji Island will ..."*)

### Węzeł `[67]`
Mówca: **Ephraim Nines (R)**
> ""By a large margin, the Nays have won. Helji Island will not be recognized as Agnolian territory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Defeated, Maartin Van Hoorten shook his head in disbelief."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "Defeated, Maartin Van Hoorten shook his head in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "His shoulders dropped. Who knew how he felt in that moment?"*)

### Węzeł `[69]`
Mówca: **Narrator**
> "His shoulders dropped. Who knew how he felt in that moment?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Nines signaled for a break. Laurento stood up to catch a ..."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "Nines signaled for a break. Laurento stood up to catch a minister he wanted to talk to."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "I enjoyed the Kyrutian circular pastry with sesame seeds ..."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "I enjoyed the Kyrutian circular pastry with sesame seeds -- apparently named 'Rekgev' -- that was handed out as a snack as we waited for the session to continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn08_G_HeljilandRecognition = true"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Maartin Van Hoorten (R)");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Maartin Van Hoorten (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "Maartin Van Hoorten came over to my side to personally sh..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Maartin Van Hoorten (R)");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Maartin Van Hoorten (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The voting concluded and President Nines took his seat."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "He left to talk to his aides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Maartin Van Hoorten (R)");"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn08_ANSession_HeljilandAye = true;
RiziaDLCSupport.Reports_Turn08_Agnolia_HelijlandRecognition_Yes = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn08_ANSession_HeljilandAye"] = true;
Variable["RiziaDLCSupport.Reports_Turn08_Agnolia_HelijlandRecognition_Yes"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "Gasps and hushed whispers circulated around the room."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn08_ANSession_HeljilandNay = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn08_ANSession_HeljilandNay"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The voting concluded and President Nines took his seat."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn08_G_HeljilandRecognition = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn08_G_HeljilandRecognition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Won == true"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Won == true)"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Alma Saltana: ""Nay.""*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Axel == true"*)

### Węzeł `[81]`
Mówca: **Narrator**
> "I looked around the room. The attendees' attention had begun to flag. A few didn't even bother to disguise their yawns."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "AddConversant("Maartin Van Hoorten (R)");"*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The AN recognized Zille as Rizian territory. I suppose he thinks he has a shot.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.ZilleReferendum_StoppedByAN"] == true`
- **Kontekst wejściowy (poprzednik):** `[31]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Laurento Esquibel: ""Yes, although the circumstances surrounding Helji Island..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_StoppedByAN == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_StoppedByAN == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_StoppedByAN == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_StoppedByAN == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_StoppedByAN"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""The AN recognized Zille as Rizian territory. I suppose h..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_StoppedByAN == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_StoppedByAN"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_NotStoppedByAN == true"*)

### Węzeł `[86]`
Mówca: **Laurento Esquibel**
> ""Yes, although the circumstances surrounding Helji Island are quite different.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Maartin Van Hoorten (R): ""For peace in Eastern Merkopa, Heljiland has to be recogn..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_NotStoppedByAN == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_NotStoppedByAN == true"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_NotStoppedByAN == true)"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_NotStoppedByAN == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_NotStoppedByAN"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player_Romus: ""The AN wouldn't even recognize Zille as Rizian territory..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_NotStoppedByAN == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_NotStoppedByAN"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The AN wouldn't even recognize Zille as Rizian territory. What makes him think he has a shot?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.ZilleReferendum_NotStoppedByAN"] == true` AND `(Variable["RiziaDLC.ZilleReferendum_StoppedByAN"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[31]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Laurento Esquibel: ""That's a good question.""*)

### Węzeł `[91]`
Mówca: **Laurento Esquibel**
> ""That's a good question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Maartin Van Hoorten (R): ""For peace in Eastern Merkopa, Heljiland has to be recogn..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Axel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Axel == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Axel == true)"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Axel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Axel Reinhart: ""Nay.""*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Axel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Axel Reinhart: ""Aye.""*)

### Węzeł `[95]`
Mówca: **Axel Reinhart**
> ""Aye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Alma Saltana: ""Nay.""*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player_Romus: ""Perhaps you will also support me in the recognition of P..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps you will also support me in the recognition of Pales as Rizia's rightful territory.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[59]` (Maartin Van Hoorten (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Maartin Van Hoorten (R): ""I-- I can't promise anything. But I won't forget that yo..."*)

### Węzeł `[100]`
Mówca: **Maartin Van Hoorten (R)**
> ""I-- I can't promise anything. But I won't forget that you stood by our side today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "He left to talk to his aides."*)
