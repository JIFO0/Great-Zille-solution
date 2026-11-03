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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 8

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[5]` (Paskal Beniwoll): `AddConversant("Maartin Van Hoorten (R)");`
- Węzeł `[50]` (Paskal Beniwoll): `AddConversant("Jorga Azmal"); AddConversant("Patricio Alvarez (R)"); AddConversant("Dwight Walker...`
- Węzeł `[51]` (Paskal Beniwoll): `RemoveConversant("Jorga Azmal"); RemoveConversant("Patricio Alvarez (R)"); RemoveConversant("Dwig...`
- Węzeł `[72]` (Paskal Beniwoll): `AddConversant("Maartin Van Hoorten (R)");`
- Węzeł `[73]` (Paskal Beniwoll): `RemoveConversant("Maartin Van Hoorten (R)");`
- Węzeł `[75]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Journal_Turn08_ANSession_HeljilandAye"] = true; Variable["RiziaDLCSuppo...`
- Węzeł `[76]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.Journal_Turn08_ANSession_HeljilandNay"] = true;`
- Węzeł `[77]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn08_G_HeljilandRecognition"] = true;`

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `401` (*Rizia/Turn 8/FPnT_ANSession*), Węzeł `[29]`

### Węzeł `[3]`
Mówca: **Ephraim Nines (R)**
> ""The Alliance of Nations summons Maartin van Hoorten, Prime Minister of Agnolia, to the stage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[4]`
Mówca: **Maartin Van Hoorten (R)**
> ""Good morning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Maartin Van Hoorten (R)");)*
- **Efekt (`userScript`):** `AddConversant("Maartin Van Hoorten (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[6]`
Mówca: **Maartin Van Hoorten (R)**
> ""It is an honor to see you all in this chamber.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Maartin Van Hoorten (R)**
> ""The Alliance of Nations and its position is paramount to maintaining peace in the world. It is the sole organization that can bring all of us together...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Maartin Van Hoorten (R)**
> ""Thank you, President Nines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[9]`
Mówca: **Maartin Van Hoorten (R)**
> ""Not only for constructive discussions, but for collective problem-solving.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Maartin Van Hoorten (R)**
> ""With our combined will and desire for justice, there is no issue we cannot resolve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Maartin Van Hoorten (R)**
> ""I therefore ask for your assistance in the fair and just resolution of a dilemma faced by my proud nation of Agnolia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Maartin Van Hoorten (R)**
> ""It concerns Helji Island.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Laurento Esquibel**
> ""This again. We're in for an interesting time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[14]`
Mówca: **Narrator**
> "Upon hearing the name of the island, everyone in the room woke up and sprang to attention. I heard Laurento mutter under his breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "Keep watching."]** — Mówca: **Player_Romus_Italic**
> "I kept watching the speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Laurento Esquibel**
> ""He's reigniting Agnolia's feud with Valgsland. If you ask me, now is neither the time nor place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Maartin Van Hoorten (R)**
> ""The innocent Agnolians living on this island are currently living under the long shadow cast by Valgsland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Maartin Van Hoorten (R)**
> ""Their territorial ambitions know no bounds. They will not rest until they have subdued every Agnolian soul on the land they have unlawfully claimed as theirs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[20]`
Mówca: **Maartin Van Hoorten (R)**
> ""I pose you this question. What would you have done if it was your own land under threat?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Narrator**
> "Our eyes randomly met before he turned his gaze away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Maartin Van Hoorten (R)**
> ""The place where your great-grandfather was born, where your father was born...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[23]`
Mówca: **Maartin Van Hoorten (R)**
> ""For peace in Eastern Merkopa, Heljiland has to be recognized as Agnolian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[24]`
Mówca: **Maartin Van Hoorten (R)**
> ""I urge you to do the right thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[25]`
Mówca: **Maartin Van Hoorten (R)**
> ""Helji Island is a vital piece of our heritage that Chancellor Hegel is trying to take away from us by force.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[26]`
Mówca: **Maartin Van Hoorten (R)**
> ""Would you not defend it? Would you not protect it with your life?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[27]`
Mówca: **Maartin Van Hoorten (R)**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Maartin Van Hoorten (R)**
> ""Don't forget. If you tolerate this happening to us, your own nations will be next.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[29]`
Mówca: **Narrator**
> "I could see that Emmerich Hegel had a smirk on his face. He seemed confident."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Ephraim Nines (R)**
> ""Thank you, Mr. Prime Minister. The voting will now commence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[31]`
Mówca: **Laurento Esquibel**
> ""He has a point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[32]`
  - -> `[34]`
  - -> `[83]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Agnolia has no chance. Valgsland won't stand for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He speaks the truth, that's for sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Having a point is not enough. There is more at play here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[35]`
Mówca: **Laurento Esquibel**
> ""I admire his pride and his bravery. Even if they will not help him here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[36]`
Mówca: **Laurento Esquibel**
> ""No, they won't. Especially not with United Contana backing them up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[37]`
Mówca: **Laurento Esquibel**
> ""As unfortunate as it is, we've seen firsthand how often might makes right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[38]`
Mówca: **Jorga Azmal**
> ""Nay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Patricio Alvarez (R)**
> ""Aye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_HeljilandRecognised == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Anton Rayne (R)**
> ""Aye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[44]`
Mówca: **Anton Rayne (R)**
> ""Nay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[45]`
Mówca: **Axel Reinhart**
> ""Nay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Alma Saltana**
> ""Nay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Beatrice Livingston (R)**
> ""Nay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Emmerich Hegel (R)**
> ""Nay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[49]`
Mówca: **Wiktor Smolak (R)**
> ""Nay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Jorga Azmal");
AddConversant("Patricio Alvarez (R)");
AddConversant("Dwight Walker (R)");
AddConversant("Maartin Van Hoorten (R)");
AddConversant("Anton Rayne (R)");
AddConversant("Axel Reinhart");
AddConversant("Alma Saltana");
AddConversant("Beatrice Livingston (R)");
AddConversant("Emmerich Hegel (R)");
AddConversant("Leon Malenyev (R)");
AddConversant("Wiktor Smolak (R)");)*
- **Efekt (`userScript`):** `AddConversant("Jorga Azmal");
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
  - -> `[38]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Jorga Azmal");
RemoveConversant("Patricio Alvarez (R)");
RemoveConversant("Dwight Walker (R)");
RemoveConversant("Maartin Van Hoorten (R)");
RemoveConversant("Anton Rayne (R)");
RemoveConversant("Axel Reinhart");
RemoveConversant("Alma Saltana");
RemoveConversant("Beatrice Livingston (R)");
RemoveConversant("Emmerich Hegel (R)");
RemoveConversant("Leon Malenyev (R)");
RemoveConversant("Wiktor Smolak (R)");)*
- **Efekt (`userScript`):** `RemoveConversant("Jorga Azmal");
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
  - -> `[55]`

### Węzeł `[52]`
Mówca: **Dwight Walker (R)**
> ""Abstain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Leon Malenyev (R)**
> ""Nay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[54]`
Mówca: **Maartin Van Hoorten (R)**
> ""Aye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[55]`
Mówca: **Narrator**
> "It was finally my turn to cast a vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Aye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[58]`
Mówca: **Narrator**
> "Gasps and hushed whispers circulated around the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[59]`
Mówca: **Maartin Van Hoorten (R)**
> ""Thank you for your support, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[60]`
  - -> `[62]`
  - -> `[63]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to thank me. I only did it because I thought it was right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[61]`
Mówca: **Narrator**
> "Maartin Van Hoorten came over to my side to personally shake my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That was a touching speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Best of luck.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Maartin Van Hoorten (R)**
> ""Thank you regardless. I won't forget that you stood by our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[65]`
Mówca: **Maartin Van Hoorten (R)**
> ""Thank you. I won't forget that you stood by our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[66]`
Mówca: **Narrator**
> "The voting concluded and President Nines took his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Ephraim Nines (R)**
> ""By a large margin, the Nays have won. Helji Island will not be recognized as Agnolian territory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Narrator**
> "Defeated, Maartin Van Hoorten shook his head in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Narrator**
> "His shoulders dropped. Who knew how he felt in that moment?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Narrator**
> "Nines signaled for a break. Laurento stood up to catch a minister he wanted to talk to."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Narrator**
> "I enjoyed the Kyrutian circular pastry with sesame seeds -- apparently named 'Rekgev' -- that was handed out as a snack as we waited for the session to continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Maartin Van Hoorten (R)");)*
- **Efekt (`userScript`):** `AddConversant("Maartin Van Hoorten (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Maartin Van Hoorten (R)");)*
- **Efekt (`userScript`):** `RemoveConversant("Maartin Van Hoorten (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[74]`
Mówca: **Narrator**
> "He left to talk to his aides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn08_ANSession_HeljilandAye = true;
RiziaDLCSupport.Reports_Turn08_Agnolia_HelijlandRecognition_Yes = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn08_ANSession_HeljilandAye"] = true;
Variable["RiziaDLCSupport.Reports_Turn08_Agnolia_HelijlandRecognition_Yes"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn08_ANSession_HeljilandNay = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn08_ANSession_HeljilandNay"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn08_G_HeljilandRecognition = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn08_G_HeljilandRecognition"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Won == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Pales_Won == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Pales_Won == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[81]`
Mówca: **Narrator**
> "I looked around the room. The attendees' attention had begun to flag. A few didn't even bother to disguise their yawns."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The AN recognized Zille as Rizian territory. I suppose he thinks he has a shot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_StoppedByAN == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_StoppedByAN == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_StoppedByAN"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_StoppedByAN == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_StoppedByAN"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Laurento Esquibel**
> ""Yes, although the circumstances surrounding Helji Island are quite different.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_NotStoppedByAN == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReferendum_NotStoppedByAN == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_NotStoppedByAN"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReferendum_NotStoppedByAN == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_NotStoppedByAN"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The AN wouldn't even recognize Zille as Rizian territory. What makes him think he has a shot?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Laurento Esquibel**
> ""That's a good question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Axel == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Axel == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Axel == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Axel Reinhart**
> ""Aye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps you will also support me in the recognition of Pales as Rizia's rightful territory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Maartin Van Hoorten (R)**
> ""I-- I can't promise anything. But I won't forget that you stood by our side today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
