# Rizia/Turn 1/Start_Coronation

- **ID konwersacji:** `288`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Rizia/Turn_01/288_Start_Coronation.md`
- **Liczba węzłów dialogowych:** 192
- **Liczba wyborów gracza:** 40

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[79]** Vina Toras
- **[87]** Sal Ignacius
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Coronation_GaveSpeech`
- `RiziaDLC.Coronation_Speech_AntiMonarchy`
- `RiziaDLC.Coronation_Speech_Diplomacy`
- `RiziaDLC.Coronation_Speech_TakeBackLand`
- `RiziaDLC.Coronation_Speech_UpholdMonarchy`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Prologue_JoinedSuOmina`
- `RiziaDLC.Prologue_Limp`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Prologue_Scar`
- `RiziaDLC.Prologue_Summer_Court`
- `RiziaDLC.Prologue_Summer_Hugo`
- `RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown`
- `RiziaDLCIsolated.Turn01_Coronation_LookedEstela`
- `RiziaDLCIsolated.Turn01_Coronation_RecitedOath`
- `RiziaDLCIsolated.Turn01_Coronation_TookOrb`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Coronation_GaveSpeech`
- `RiziaDLC.Coronation_Speech_AntiMonarchy`
- `RiziaDLC.Coronation_Speech_Diplomacy`
- `RiziaDLC.Coronation_Speech_TakeBackLand`
- `RiziaDLC.Coronation_Speech_UpholdMonarchy`
- `RiziaDLC.Diplomacy_Rumburg_NegotiatingPower`
- `RiziaDLC.PersonalValue_BrokeTradition`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Said_GlovuriusAxaRizia`
- `RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown`
- `RiziaDLCIsolated.Turn01_Coronation_LookedEstela`
- `RiziaDLCIsolated.Turn01_Coronation_RecitedOath`
- `RiziaDLCIsolated.Turn01_Coronation_TookOrb`
- `RiziaDLCSupport.News_Turn01_G_Coronation_DemocratSpeech`
- `RiziaDLCSupport.News_Turn01_G_Coronation_ExpansionistSpeech`
- `RiziaDLCSupport.News_Turn01_G_Coronation_GenericSpeech`
- `RiziaDLCSupport.News_Turn01_G_Coronation_GlobalistSpeech`
- `RiziaDLCSupport.News_Turn01_G_Coronation_MonarchistSpeech`
- `RiziaDLCSupport.News_Turn01_G_Coronation_NoSpeech`
- `RiziaDLCSupport.News_Turn01_RH_Coronation_NoSpeech`
- `RiziaDLCSupport.News_Turn01_RH_Coronation_Speech`
- `RiziaDLCSupport.News_Turn01_RH_Gossip_CoronationFashion`
- `RiziaDLCSupport.Reports_Turn01_Derdia_AzmalCongrats`
- `RiziaDLCSupport.Reports_Turn01_Monqiz_HubertusDuke`
- `RiziaDLCSupport.Reports_Turn01_Montaklar_AzaroCongrats`
- `RiziaDLCSupport.Reports_Turn01_Morella_AlmaCongrats`
- `RiziaDLCSupport.Reports_Turn01_Pales_DukeCongrats`
- `RiziaDLCSupport.Reports_Turn01_Rumburg_QueenCongrats`
- `RiziaDLCSupport.Reports_Turn01_Sallabes_SazonCongrats`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[14]` | **""Ready for the next chapter.""** | `[15]` **Vina Toras**: ""How are you feeling, Father?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Narrator**: "My daughter smiled." |
| `[16]` | **""My feelings are none of your business.""** | `[15]` **Vina Toras**: ""How are you feeling, Father?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Narrator**: "My daughter seemed to shrink in ..." |
| `[17]` | **""Shh. Stop fidgeting. The cameras are on us.""** | `[15]` **Vina Toras**: ""How are you feeling, Father?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Vina Toras**: ""Sorry!"" |
| `[18]` | **""Honestly? A little nervous.""** | `[15]` **Vina Toras**: ""How are you feeling, Father?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Narrator**: "My daughter smiled." |
| `[22]` | **"Recite the oath."** | `[21]` **Narrator**: "He presented it in front of me. ..." | `Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] == false`<br>`(Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] == true) == false` | *Brak zmian stanu* | `[27]` **Player_Romus**: ""I hereby pledge myself in servi..." |
| `[23]` | **"Take the orb."** | `[21]` **Narrator**: "He presented it in front of me. ..." | `Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] == false`<br>`(Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] == true) == false` | *Brak zmian stanu* | `[167]` **Narrator**: "It was inlaid with a trio of dia..." |
| `[24]` | **"Look at Estela."** | `[21]` **Narrator**: "He presented it in front of me. ..." | `Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] == false`<br>`(Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] == true) == false` | `Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela...` | `[90]` **Sal Ignacius**: ""May St. Wruhec fill you with hi..." |
| `[25]` | **"Look at the crown."** | `[21]` **Narrator**: "He presented it in front of me. ..." | `Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] == false`<br>`(Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] == true) == false` | *Brak zmian stanu* | `[166]` **Narrator**: "It was made of pure gold, adorne..." |
| `[27]` | **""I hereby pledge myself...""** | `[22]` **Player_Romus_Italic**: "I took the scroll off the cushio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Player_Romus**: ""I promise to guide my country w..." |
| `[28]` | **""I promise to guide my country with a steadfast hand.""** | `[27]` **Player_Romus**: ""I hereby pledge myself in servi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Player_Romus**: ""To uphold the laws of this land..." |
| `[29]` | **""To uphold the laws of this land under St. Wruhec's watchful eye.""** | `[28]` **Player_Romus**: ""I promise to guide my country w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Player_Romus**: ""To wield the sword of justice a..." |
| `[30]` | **""To wield the sword of justice and the shield of mercy in equal measure.""** | `[29]` **Player_Romus**: ""To uphold the laws of this land..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Player_Romus**: ""All this I shall do until the d..." |
| `[31]` | **""All this I shall do until the day I die.""** | `[30]` **Player_Romus**: ""To wield the sword of justice a..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"...` | `[90]` **Sal Ignacius**: ""May St. Wruhec fill you with hi..." |
| `[48]` | **"Stand up."** | `[96]` **Sal Ignacius**: ""Arise, King Romus."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Narrator**: "According to royal tradition, th..." |
| `[49]` | **"Break tradition and make a speech first."** | `[184]` **Narrator**: "According to royal tradition, th..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_BrokeTradition"] = Varia...` | `[54]` **Player_Romus**: ""I know this is highly unusual, ..."<br>`[55]` **Player_Romus**: ""Ladies and gentlemen of Rizia..."" |
| `[52]` | **""I've got to do this part alone.""** | `[51]` **Narrator**: "We reached the end of the hall, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "Leaving Vina behind, I walked up..." |
| `[53]` | **""Come, Vina, let's greet your future subjects.""** | `[51]` **Narrator**: "We reached the end of the hall, ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[79]` **Narrator**: "My daughter beamed and put her a..." |
| `[54]` | **""I know this is highly unusual, but we are living in unusual times.""** | `[49]` **Player_Romus_Italic**: "I held up my hand for silence. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Narrator**: "Uncle Hugo had been smiling prou..."<br>`[100]` **Narrator**: "Uncle Hugo had been smiling poli..." |
| `[55]` | **""Ladies and gentlemen of Rizia...""** | `[49]` **Player_Romus_Italic**: "I held up my hand for silence. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Narrator**: "Uncle Hugo had been smiling prou..."<br>`[100]` **Narrator**: "Uncle Hugo had been smiling poli..." |
| `[57]` | **""When my father died, I made a promise. One that I would like to share with you al..."** | `[56]` **Narrator**: "Uncle Hugo had been smiling prou..."<br>`[100]` **Narrator**: "Uncle Hugo had been smiling poli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Player_Romus**: ""Under my rule, Rizia will be tr..."<br>`[61]` **Player_Romus**: ""I will succeed where our previo..." |
| `[58]` | **""My father was a great but flawed man. His mistakes will not be repeated.""** | `[56]` **Narrator**: "Uncle Hugo had been smiling prou..."<br>`[100]` **Narrator**: "Uncle Hugo had been smiling poli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Player_Romus**: ""Under my rule, Rizia will be tr..."<br>`[61]` **Player_Romus**: ""I will succeed where our previo..."<br>*(oraz 1 innych odgałęzień)* |
| `[59]` | **""The reign of Valero Toras is over. A new day has dawned.""** | `[56]` **Narrator**: "Uncle Hugo had been smiling prou..."<br>`[100]` **Narrator**: "Uncle Hugo had been smiling poli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Player_Romus**: ""I will succeed where our previo..."<br>`[62]` **Player_Romus**: ""It is time to show all of Merko..." |
| `[60]` | **""Under my rule, Rizia will be transformed.""** | `[57]` **Player_Romus**: ""When my father died, I made a p..."<br>`[58]` **Player_Romus**: ""My father was a great but flawe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Player_Romus**: ""We must break with tradition an..."<br>`[86]` **Player_Romus**: ""We must stop letting our past g..."<br>*(oraz 2 innych odgałęzień)* |
| `[61]` | **""I will succeed where our previous king failed.""** | `[57]` **Player_Romus**: ""When my father died, I made a p..."<br>`[58]` **Player_Romus**: ""My father was a great but flawe..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Player_Romus**: ""We must break with tradition an..."<br>`[86]` **Player_Romus**: ""We must stop letting our past g..."<br>*(oraz 2 innych odgałęzień)* |
| `[62]` | **""It is time to show all of Merkopa what Rizia is capable of.""** | `[58]` **Player_Romus**: ""My father was a great but flawe..."<br>`[59]` **Player_Romus**: ""The reign of Valero Toras is ov..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Player_Romus**: ""We must break with tradition an..."<br>`[86]` **Player_Romus**: ""We must stop letting our past g..."<br>*(oraz 2 innych odgałęzień)* |
| `[63]` | **""We must break with tradition and enter the 20th century.""** | `[60]` **Player_Romus**: ""Under my rule, Rizia will be tr..."<br>`[61]` **Player_Romus**: ""I will succeed where our previo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Narrator**: "Hugo's stare intensified." |
| `[64]` | **""I will uphold the monarchy and restore the glory days of House Toras.""** | `[60]` **Player_Romus**: ""Under my rule, Rizia will be tr..."<br>`[61]` **Player_Romus**: ""I will succeed where our previo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Narrator**: "Hugo's expression relaxed. He sm..." |
| `[65]` | **""I promise I will take back the lands that have been stolen from us.""** | `[60]` **Player_Romus**: ""Under my rule, Rizia will be tr..."<br>`[61]` **Player_Romus**: ""I will succeed where our previo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Narrator**: "Hugo's expression relaxed. He sm..." |
| `[68]` | **""Only when Rizia is once again whole can a new era of peace and prosperity begin.""** | `[67]` **Narrator**: "Hugo's expression relaxed. He sm..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] = true;` | `[72]` **Player_Romus**: ""Thank you all.""<br>`[73]` **Player_Romus**: ""Long live House Toras.""<br>*(oraz 2 innych odgałęzień)* |
| `[69]` | **""Only by achieving harmony with our neighbors can a new era begin.""** | `[66]` **Narrator**: "Hugo's stare intensified." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Coronation_Speech_Diplomacy"] = true;` | `[72]` **Player_Romus**: ""Thank you all.""<br>`[73]` **Player_Romus**: ""Long live House Toras.""<br>*(oraz 2 innych odgałęzień)* |
| `[70]` | **""Only once Rizia is united under a strong king can a new era begin.""** | `[66]` **Narrator**: "Hugo's stare intensified."<br>`[67]` **Narrator**: "Hugo's expression relaxed. He sm..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Coronation_Speech_UpholdMonarchy"] = t...` | `[73]` **Player_Romus**: ""Long live House Toras.""<br>`[74]` **Player_Romus**: ""Glovurius axa Rizia.""<br>*(oraz 1 innych odgałęzień)* |
| `[71]` | **""A new era begins now.""** | `[66]` **Narrator**: "Hugo's stare intensified."<br>`[67]` **Narrator**: "Hugo's expression relaxed. He sm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Player_Romus**: ""Long live House Toras.""<br>`[74]` **Player_Romus**: ""Glovurius axa Rizia.""<br>*(oraz 1 innych odgałęzień)* |
| `[72]` | **""Thank you all.""** | `[68]` **Player_Romus**: ""Only when Rizia is once again w..."<br>`[69]` **Player_Romus**: ""Only by achieving harmony with ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Narrator**: "The hall fell silent again. My u..." |
| `[73]` | **""Long live House Toras.""** | `[71]` **Player_Romus**: ""A new era begins now.""<br>`[68]` **Player_Romus**: ""Only when Rizia is once again w..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Narrator**: "The hall fell silent again. My u..." |
| `[74]` | **""Glovurius axa Rizia.""** | `[71]` **Player_Romus**: ""A new era begins now.""<br>`[68]` **Player_Romus**: ""Only when Rizia is once again w..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["R...` | `[75]` **Narrator**: "The hall fell silent again. My u..." |
| `[81]` | **"Open it."** | `[80]` **Narrator**: "Leaving Vina behind, I walked up..."<br>`[79]` **Narrator**: "My daughter beamed and put her a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Narrator**: "When my eyes adjusted, I regarde..." |
| `[86]` | **""We must stop letting our past grudges dictate our future.""** | `[60]` **Player_Romus**: ""Under my rule, Rizia will be tr..."<br>`[61]` **Player_Romus**: ""I will succeed where our previo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Narrator**: "Hugo's stare intensified." |
| `[95]` | **"Proceed with the coronation."** | `[184]` **Narrator**: "According to royal tradition, th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Narrator**: "Everyone in the crowd bowed thei..." |
| `[113]` | **""Only when the people of Rizia are given a voice can a new era begin.""** | `[66]` **Narrator**: "Hugo's stare intensified." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] = true;` | `[72]` **Player_Romus**: ""Thank you all.""<br>`[73]` **Player_Romus**: ""Long live House Toras.""<br>*(oraz 2 innych odgałęzień)* |
| `[171]` | **""May God bless this country and its people.""** | `[71]` **Player_Romus**: ""A new era begins now.""<br>`[68]` **Player_Romus**: ""Only when Rizia is once again w..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[75]` **Narrator**: "The hall fell silent again. My u..." |

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
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Rising to the throne", "Coronation Celeb..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The angelic-sounding voices of a boys' choir echoed through the Great Hall of Palas Rezna."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "To most Rizians, this was the grandest room in the grande..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "To most Rizians, this was the grandest room in the grandest building in the entire country. To me, it was just home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Court == true"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "I remembered playing hide-and-seek among the mosaic-tiled columns while visiting my grandmother. Goofing off with Pabel in the upper gallery as my father met with foreign dignitaries."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "And of course, this was where I had married Lena..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "I remembered playing hide-and-seek among the mosaic-tiled..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "I remembered playing hide-and-seek among the mosaic-tiled..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "I remembered playing hide-and-seek among the mosaic-tiled columns while visiting my grandmother. Watching from the upper gallery as my father met with foreign dignitaries."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "And of course, this was where I had married Lena..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "And of course, this was where I had married Lena..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "I sat upright in the Sila Orica, the gold-plated wooden t..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "The hall before me was filled with nobles, politicians, business magnates, even movie stars. A television crew moved up and down the aisles, broadcasting the ceremony to the Rizian public for the first time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "My mother was sitting in the front row next to Uncle Hugo."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "My mother was sitting in the front row next to Uncle Hugo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "Tradition dictated that in the absence of a king or queen..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "Tradition dictated that in the absence of a king or queen consort, the seat next to me would be filled by the successor to the throne. Vina plucked at a stray thread in her gown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Vina Toras: ""How are you feeling, Father?""*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Ready for the next chapter.""]** — Mówca: **Player_Romus**
> ""Ready for the next chapter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "My daughter smiled."*)

### Węzeł `[15]`
Mówca: **Vina Toras**
> ""How are you feeling, Father?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player_Romus: ""Ready for the next chapter.""*)
  - -> `[18]` (*Player_Romus: ""Honestly? A little nervous.""*)
  - -> `[16]` (*Player_Romus: ""My feelings are none of your business.""*)
  - -> `[17]` (*Player_Romus: ""Shh. Stop fidgeting. The cameras are on us.""*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""My feelings are none of your business.""]** — Mówca: **Player_Romus**
> ""My feelings are none of your business.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "My daughter seemed to shrink in her chair."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: ""Shh. Stop fidgeting. The cameras are on us.""]** — Mówca: **Player_Romus**
> ""Shh. Stop fidgeting. The cameras are on us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Vina Toras: ""Sorry!""*)

### Węzeł `[18]`
**[WYBÓR GRACZA: ""Honestly? A little nervous.""]** — Mówca: **Player_Romus**
> ""Honestly? A little nervous.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "My daughter smiled."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "The final notes of the coronation hymn "By His Sword I Live" rang out. An expectant silence filled the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "It was broken by the sound of shuffling footsteps. The ca..."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "It was broken by the sound of shuffling footsteps. The cameras followed Grand Wiseman Sal Ignacius as he walked slowly down the central aisle, bearing a velvet cushion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "He presented it in front of me. On it was the Toras crown..."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "He presented it in front of me. On it was the Toras crown, a black onyx orb and a scroll containing the words to the royal oath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "Coronation Hub"*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "Recite the oath."]** — Mówca: **Player_Romus_Italic**
> "I took the scroll off the cushion and read aloud from it."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] == false` AND `(Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player_Romus: ""I hereby pledge myself...""*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "Take the orb."]** — Mówca: **Player_Romus_Italic**
> "I lifted the orb off the cushion and ran my fingers across its smooth surface."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] == false` AND `(Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "It was inlaid with a trio of diamonds, representing the t..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "Look at Estela."]** — Mówca: **Player_Romus_Italic**
> "I caught my mother's eye. She gave me a conspiratorial wink."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] == false` AND `(Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Coronation_LookedEstela = true"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "Look at the crown."]** — Mówca: **Player_Romus_Italic**
> "I gazed at the Toras crown, forged when my family took the throne almost 150 years ago."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] == false` AND `(Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "It was made of pure gold, adorned with two twisting spire..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Coronation Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Coronation_RecitedOath == true &&..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""I hereby pledge myself...""]** — Mówca: **Player_Romus**
> ""I hereby pledge myself in service to the great nation of Rizia and its people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Romus: ""I promise to guide my country with a steadfast hand.""*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I promise to guide my country with a steadfast hand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus: ""To uphold the laws of this land under St. Wruhec's watch..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To uphold the laws of this land under St. Wruhec's watchful eye.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player_Romus: ""To wield the sword of justice and the shield of mercy in..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To wield the sword of justice and the shield of mercy in equal measure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player_Romus: ""All this I shall do until the day I die.""*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All this I shall do until the day I die.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Coronation_RecitedOath = true"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Coronation Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "Coronation Hub"*)

### Węzeł `[33]`
Mówca: **Narrator**
> "With trembling hands, Grand Wiseman Ignacius lifted the crown off the cushion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "I could spot a grey hair still clinging to its inner rim...."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown == false"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown == false)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus_Italic: "Look at the crown."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Coronation_LookedEstela == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Coronation_LookedEstela == false"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Coronation_LookedEstela == false)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Coronation_LookedEstela == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player_Romus_Italic: "Look at Estela."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Coronation_LookedEstela == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Coronation_TookOrb == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Coronation_TookOrb == false"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Coronation_TookOrb == false)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Coronation_TookOrb == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus_Italic: "Take the orb."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Coronation_TookOrb == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Coronation_RecitedOath == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Coronation_RecitedOath == false"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Coronation_RecitedOath == false)"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Coronation_RecitedOath == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus_Italic: "Recite the oath."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Coronation_RecitedOath == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[46]`
Mówca: **Narrator**
> "I could spot a grey hair still clinging to its inner rim. My father's."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Sal Ignacius: ""May you keep the promises you have made before God and y..."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "The crown came down on my head. Its heaviness surprised me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Sal Ignacius: ""By the divine power vested in me, I proclaim you soverei..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "Stand up."]** — Mówca: **Player_Romus_Italic**
> "I stood. The choir broke into "On Shores of Gold," the Rizian national anthem."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "According to royal tradition, this was my signal to march..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "Break tradition and make a speech first."]** — Mówca: **Player_Romus_Italic**
> "I held up my hand for silence. The choir stopped singing. Confused whispers ran through the crowd."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_BrokeTradition += 1"*)

### Węzeł `[50]`
Mówca: **Narrator**
> "I hoped my limp wasn't visible to television viewers. I thought about the kidnapper's bullet and how close I had come to never seeing this day."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)

### Węzeł `[51]`
Mówca: **Narrator**
> "We reached the end of the hall, where a spiral staircase led to the palace balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: ""Come, Vina, let's greet your future subjects.""*)
  - -> `[52]` (*Player_Romus: ""I've got to do this part alone.""*)

### Węzeł `[52]`
**[WYBÓR GRACZA: ""I've got to do this part alone.""]** — Mówca: **Player_Romus**
> ""I've got to do this part alone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Leaving Vina behind, I walked up and up the stairs until ..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: ""Come, Vina, let's greet your future subjects.""]** — Mówca: **Player_Romus**
> ""Come, Vina, let's greet your future subjects.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[54]`
**[WYBÓR GRACZA: ""I know this is highly unusual, but we are living in unusual times.""]** — Mówca: **Player_Romus**
> ""I know this is highly unusual, but we are living in unusual times.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)

### Węzeł `[55]`
**[WYBÓR GRACZA: ""Ladies and gentlemen of Rizia...""]** — Mówca: **Player_Romus**
> ""Ladies and gentlemen of Rizia...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)

### Węzeł `[56]`
Mówca: **Narrator**
> "Uncle Hugo had been smiling proudly up to this point. His expression now grew serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player_Romus: ""When my father died, I made a promise. One that I would ..."*)
  - -> `[58]` (*Player_Romus: ""My father was a great but flawed man. His mistakes will ..."*)
  - -> `[59]` (*Player_Romus: ""The reign of Valero Toras is over. A new day has dawned.""*)

### Węzeł `[57]`
**[WYBÓR GRACZA: ""When my father died, I made a promise. One that I would like to share with you all today.""]** — Mówca: **Player_Romus**
> ""When my father died, I made a promise. One that I would like to share with you today.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator), `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player_Romus: ""Under my rule, Rizia will be transformed.""*)
  - -> `[61]` (*Player_Romus: ""I will succeed where our previous king failed.""*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""My father was a great but flawed man. His mistakes will not be repeated.""]** — Mówca: **Player_Romus**
> ""My father was a great but flawed man. His mistakes will not be repeated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator), `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player_Romus: ""Under my rule, Rizia will be transformed.""*)
  - -> `[61]` (*Player_Romus: ""I will succeed where our previous king failed.""*)
  - -> `[62]` (*Player_Romus: ""It is time to show all of Merkopa what Rizia is capable ..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: ""The reign of Valero Toras is over. A new day has dawned.""]** — Mówca: **Player_Romus**
> ""The reign of Valero Toras is over. A new day has dawned in this country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator), `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player_Romus: ""I will succeed where our previous king failed.""*)
  - -> `[62]` (*Player_Romus: ""It is time to show all of Merkopa what Rizia is capable ..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: ""Under my rule, Rizia will be transformed.""]** — Mówca: **Player_Romus**
> ""Under my rule, Rizia will be transformed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Player_Romus), `[58]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player_Romus: ""We must break with tradition and enter the 20th century.""*)
  - -> `[86]` (*Player_Romus: ""We must stop letting our past grudges dictate our future.""*)
  - -> `[64]` (*Player_Romus: ""I will uphold the monarchy and restore the glory days of..."*)
  - -> `[65]` (*Player_Romus: ""I promise I will take back the lands that have been stol..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA: ""I will succeed where our previous king failed.""]** — Mówca: **Player_Romus**
> ""I will succeed where our previous king failed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Player_Romus), `[58]` (Player_Romus), `[59]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player_Romus: ""We must break with tradition and enter the 20th century.""*)
  - -> `[86]` (*Player_Romus: ""We must stop letting our past grudges dictate our future.""*)
  - -> `[64]` (*Player_Romus: ""I will uphold the monarchy and restore the glory days of..."*)
  - -> `[65]` (*Player_Romus: ""I promise I will take back the lands that have been stol..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""It is time to show all of Merkopa what Rizia is capable of.""]** — Mówca: **Player_Romus**
> ""It is time to show all of Merkopa what Rizia is capable of.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Player_Romus), `[59]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player_Romus: ""We must break with tradition and enter the 20th century.""*)
  - -> `[86]` (*Player_Romus: ""We must stop letting our past grudges dictate our future.""*)
  - -> `[64]` (*Player_Romus: ""I will uphold the monarchy and restore the glory days of..."*)
  - -> `[65]` (*Player_Romus: ""I promise I will take back the lands that have been stol..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""We must break with tradition and enter the 20th century.""]** — Mówca: **Player_Romus**
> ""We must break with tradition and enter the 20th century.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Player_Romus), `[61]` (Player_Romus), `[62]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "Hugo's stare intensified."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""I will uphold the monarchy and restore the glory days of House Toras.""]** — Mówca: **Player_Romus**
> ""I will uphold the monarchy and restore the glory days of House Toras.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Player_Romus), `[61]` (Player_Romus), `[62]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "Hugo's expression relaxed. He smiled."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: ""I promise I will take back the lands that have been stolen from us.""]** — Mówca: **Player_Romus**
> ""I promise I will take back the lands that have been stolen from us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Player_Romus), `[61]` (Player_Romus), `[62]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "Hugo's expression relaxed. He smiled."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "Hugo's stare intensified."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player_Romus: ""Only by achieving harmony with our neighbors can a new e..."*)
  - -> `[70]` (*Player_Romus: ""Only once Rizia is united under a strong king can a new ..."*)
  - -> `[113]` (*Player_Romus: ""Only when the people of Rizia are given a voice can a ne..."*)
  - -> `[71]` (*Player_Romus: ""A new era begins now.""*)

### Węzeł `[67]`
Mówca: **Narrator**
> "Hugo's expression relaxed. He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus: ""Only when Rizia is once again whole can a new era of pea..."*)
  - -> `[70]` (*Player_Romus: ""Only once Rizia is united under a strong king can a new ..."*)
  - -> `[71]` (*Player_Romus: ""A new era begins now.""*)

### Węzeł `[68]`
**[WYBÓR GRACZA: ""Only when Rizia is once again whole can a new era of peace and prosperity begin.""]** — Mówca: **Player_Romus**
> ""Only when Rizia is once again whole can a new era of peace and prosperity begin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_TakeBackLand = true"*)

### Węzeł `[69]`
**[WYBÓR GRACZA: ""Only by achieving harmony with our neighbors can a new era begin.""]** — Mówca: **Player_Romus**
> ""Only by achieving harmony with our neighbors can a new era begin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_Diplomacy = true"*)

### Węzeł `[70]`
**[WYBÓR GRACZA: ""Only once Rizia is united under a strong king can a new era begin.""]** — Mówca: **Player_Romus**
> ""Only once Rizia is united under a strong king can a new era begin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator), `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_UpholdMonarchy = true"*)

### Węzeł `[71]`
**[WYBÓR GRACZA: ""A new era begins now.""]** — Mówca: **Player_Romus**
> ""A new era begins now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator), `[67]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player_Romus: ""Long live House Toras.""*)
  - -> `[74]` (*Player_Romus: ""Glovurius axa Rizia.""*)
  - -> `[171]` (*Player_Romus: ""May God bless this country and its people.""*)

### Węzeł `[72]`
**[WYBÓR GRACZA: ""Thank you all.""]** — Mówca: **Player_Romus**
> ""Thank you all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Player_Romus), `[69]` (Player_Romus), `[113]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "The hall fell silent again. My uncle was the first to speak."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: ""Long live House Toras.""]** — Mówca: **Player_Romus**
> ""Long live House Toras.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Player_Romus), `[68]` (Player_Romus), `[69]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "The hall fell silent again. My uncle was the first to speak."*)

### Węzeł `[74]`
**[WYBÓR GRACZA: ""Glovurius axa Rizia.""]** — Mówca: **Player_Romus**
> ""Glovurius axa Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Player_Romus), `[68]` (Player_Romus), `[69]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_GlovuriusAxaRizia += 1"*)

### Węzeł `[75]`
Mówca: **Narrator**
> "The hall fell silent again. My uncle was the first to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Hugo Toras: ""Glovurius axa Rizia!""*)

### Węzeł `[76]`
Mówca: **Hugo Toras**
> ""Glovurius axa Rizia!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "Glory to Rizia. His shout reverberated throughout the hall."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "The attendees hurriedly broke into enthusiastic applause. The choir restarted the national anthem."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_GaveSpeech = true"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Coronation End]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "Coronation End"*)

### Węzeł `[79]`
Mówca: **Narrator**
> "My daughter beamed and put her arm through mine. We walked up and up the stairs until we came to a door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");"*)

### Węzeł `[80]`
Mówca: **Narrator**
> "Leaving Vina behind, I walked up and up the stairs until I came to a door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras"); RemoveConversant("Sal Ign..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "Open it."]** — Mówca: **Player_Romus_Italic**
> "I stepped out onto the balcony. The sunlight was so dazzling I was almost blinded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Narrator), `[79]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "When my eyes adjusted, I regarded the scene below me. Tho..."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "When my eyes adjusted, I regarded the scene below me. Thousands and thousands of people were packed onto the palace grounds, some waving the Rizian flag, others the House Toras banner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "Just beyond them, at the gates, the police easily held ba..."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "Just beyond them, at the gates, the police easily held back a small pocket of protesters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "I paid little attention to them. I was focused on the noi..."*)

### Węzeł `[84]`
Mówca: **Narrator**
> "I paid little attention to them. I was focused on the noise of the crowd, an overwhelming roar that gradually cohered into a single chant: "Salutenas axa regu novus!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "All hail the new king."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "All hail the new king."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_AntiMonarchy == true"*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""We must stop letting our past grudges dictate our future.""]** — Mówca: **Player_Romus**
> ""We must stop letting our past grudges dictate our future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Player_Romus), `[61]` (Player_Romus), `[62]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "Hugo's stare intensified."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "I sat upright in the Sila Orica, the gold-plated wooden throne on which all monarchs of Rizia were coronated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Scar == true"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Coronation_TookOrb = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "Jump to: [Coronation Hub]"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Coronation_RecitedOath = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "Jump to: [Coronation Hub]"*)

### Węzeł `[90]`
Mówca: **Sal Ignacius**
> ""May St. Wruhec fill you with his holy spirit on this day, as he did your ancestors before you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "With trembling hands, Grand Wiseman Ignacius lifted the c..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "Jump to: [Coronation Hub]"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Coronation_LookedEstela = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "Jump to: [Coronation Hub]"*)

### Węzeł `[93]`
Mówca: **Sal Ignacius**
> ""May you keep the promises you have made before God and your people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "The crown came down on my head. Its heaviness surprised me."*)

### Węzeł `[94]`
Mówca: **Sal Ignacius**
> ""By the divine power vested in me, I proclaim you sovereign king of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Sal Ignacius: ""Arise, King Romus.""*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "Proceed with the coronation."]** — Mówca: **Player_Romus_Italic**
> "I decided to proceed without making a speech."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "Coronation End"*)

### Węzeł `[96]`
Mówca: **Sal Ignacius**
> ""Arise, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("RizianNationalAnthem");"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Hugo == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Hugo == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "Uncle Hugo had been smiling proudly up to this point. His..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Uncle Hugo had been smiling politely up to this point. Hi..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "Uncle Hugo had been smiling politely up to this point. His expression now grew serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player_Romus: ""When my father died, I made a promise. One that I would ..."*)
  - -> `[58]` (*Player_Romus: ""My father was a great but flawed man. His mistakes will ..."*)
  - -> `[59]` (*Player_Romus: ""The reign of Valero Toras is over. A new day has dawned.""*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Court == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Summer_Court == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Summer_Court == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Summer_Court == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Court"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Summer_Court == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Court"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[104]`
Mówca: **Narrator**
> "I remembered wandering between the mosaic-tiled columns as a bored teenager. Goofing off with Pabel in the upper gallery as my father met with foreign dignitaries."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "And of course, this was where I had married Lena..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "I remembered wandering between the mosaic-tiled columns a..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "I remembered wandering between the mosaic-tiled columns a..."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "I remembered wandering between the mosaic-tiled columns as a bored teenager. Watching from the upper gallery as my father met with foreign dignitaries."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "And of course, this was where I had married Lena..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_GaveSpeech = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Coronation_GaveSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "Jump to: [Coronation End]"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_TakeBackLand = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player_Romus: ""Thank you all.""*)
  - -> `[73]` (*Player_Romus: ""Long live House Toras.""*)
  - -> `[74]` (*Player_Romus: ""Glovurius axa Rizia.""*)
  - -> `[171]` (*Player_Romus: ""May God bless this country and its people.""*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_Diplomacy = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Coronation_Speech_Diplomacy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player_Romus: ""Thank you all.""*)
  - -> `[73]` (*Player_Romus: ""Long live House Toras.""*)
  - -> `[74]` (*Player_Romus: ""Glovurius axa Rizia.""*)
  - -> `[171]` (*Player_Romus: ""May God bless this country and its people.""*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_UpholdMonarchy = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Coronation_Speech_UpholdMonarchy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player_Romus: ""Long live House Toras.""*)
  - -> `[74]` (*Player_Romus: ""Glovurius axa Rizia.""*)
  - -> `[171]` (*Player_Romus: ""May God bless this country and its people.""*)

### Węzeł `[113]`
**[WYBÓR GRACZA: ""Only when the people of Rizia are given a voice can a new era begin.""]** — Mówca: **Player_Romus**
> ""Only when the people of Rizia are given a voice can a new era begin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_AntiMonarchy = true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_AntiMonarchy = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player_Romus: ""Thank you all.""*)
  - -> `[73]` (*Player_Romus: ""Long live House Toras.""*)
  - -> `[74]` (*Player_Romus: ""Glovurius axa Rizia.""*)
  - -> `[171]` (*Player_Romus: ""May God bless this country and its people.""*)

### Węzeł `[115]`
Mówca: **Vina Toras**
> ""Don't worry, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Vina Toras: ""You are the king now.""*)

### Węzeł `[116]`
Mówca: **Narrator**
> "My daughter smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Vina Toras: ""Don't worry, Father.""*)

### Węzeł `[117]`
Mówca: **Vina Toras**
> ""Me, too. I wish Mother was the one sitting here, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "The final notes of the coronation hymn "By His Sword I Li..."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "My daughter smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Vina Toras: ""Me, too. I wish Mother was the one sitting here, though.""*)

### Węzeł `[119]`
Mówca: **Vina Toras**
> ""Sorry!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "My daughter sat up straight and folded her hands in her lap."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "My daughter sat up straight and folded her hands in her lap."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "The final notes of the coronation hymn "By His Sword I Li..."*)

### Węzeł `[121]`
Mówca: **Narrator**
> "My daughter seemed to shrink in her chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Vina Toras: ""You're right, Father. Sorry.""*)

### Węzeł `[122]`
Mówca: **Vina Toras**
> ""You're right, Father. Sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "The final notes of the coronation hymn "By His Sword I Li..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Coronation_RecitedOath == true && RiziaDLCIsolated.Turn01_Coronation_TookOrb == true && RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown == true && RiziaDLCIsolated.Turn01_Coronation_LookedEstela == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Coronation_RecitedOath == true &&..."*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Coronation_RecitedOath == true ..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Coronation_RecitedOath == true && RiziaDLCIsolated.Turn01_Coronation_TookOrb == true && RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown == true && RiziaDLCIsolated.Turn01_Coronation_LookedEstela == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Sal Ignacius: ""May St. Wruhec fill you with his holy spirit on this day..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Coronation_RecitedOath == true && RiziaDLCIsolated.Turn01_Coronation_TookOrb == true && RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown == true && RiziaDLCIsolated.Turn01_Coronation_LookedEstela == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Coronation_RecitedOath"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_TookOrb"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown"] == true  and  Variable["RiziaDLCIsolated.Turn01_Coronation_LookedEstela"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Coronation_RecitedOath == false"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Coronation_TookOrb == false"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown == false"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Coronation_LookedEstela == false"*)

### Węzeł `[126]`
Mówca: **Narrator**
> "The ceremonial robes I was wearing chafed against the scar on my shoulder. I thought about the kidnapper's bullet and how close I had come to never seeing this day."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "The hall before me was filled with nobles, politicians, b..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Scar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Scar == true"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Scar == true)"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Scar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Scar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "The ceremonial robes I was wearing chafed against the sca..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Scar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Scar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "The hall before me was filled with nobles, politicians, b..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Vina Toras");
RemoveConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Vina Toras");
RemoveConversant("Sal Ignacius");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player_Romus_Italic: "Open it."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Rumburg_NegotiatingPower -= 1;
RiziaDLCSupport.News_Turn01_G_Coronation_DemocratSpeech = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] - 1;
Variable["RiziaDLCSupport.News_Turn01_G_Coronation_DemocratSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_Coronation_Speech = true"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_AntiMonarchy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_AntiMonarchy == true"*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coronation_Speech_AntiMonarchy == true)"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_AntiMonarchy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_NegotiatingPower -= 1; RiziaDL..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coronation_Speech_AntiMonarchy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_Diplomacy == true"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_Diplomacy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_Diplomacy == true"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coronation_Speech_Diplomacy == true)"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_Diplomacy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_Diplomacy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_G_Coronation_GlobalistSpeech ..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coronation_Speech_Diplomacy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_Diplomacy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_UpholdMonarchy == true"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn01_G_Coronation_GlobalistSpeech = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_G_Coronation_GlobalistSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_Coronation_Speech = true"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_UpholdMonarchy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_UpholdMonarchy == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coronation_Speech_UpholdMonarchy == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_UpholdMonarchy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_UpholdMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_NegotiatingPower += 1; RiziaDL..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coronation_Speech_UpholdMonarchy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_UpholdMonarchy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_TakeBackLand == true"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Rumburg_NegotiatingPower += 1;
RiziaDLCSupport.News_Turn01_G_Coronation_MonarchistSpeech = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] + 1;
Variable["RiziaDLCSupport.News_Turn01_G_Coronation_MonarchistSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_Coronation_Speech = true"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_TakeBackLand == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_TakeBackLand == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coronation_Speech_TakeBackLand == true)"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_TakeBackLand == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_G_Coronation_ExpansionistSpee..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coronation_Speech_TakeBackLand == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_GaveSpeech == true"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn01_G_Coronation_ExpansionistSpeech = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_G_Coronation_ExpansionistSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_Coronation_Speech = true"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn01_G_Coronation_NoSpeech = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_G_Coronation_NoSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_Coronation_NoSpeech = true"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn01_RH_Coronation_NoSpeech = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_Coronation_NoSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_Gossip_CoronationFashion =..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn01_RH_Coronation_Speech = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_Coronation_Speech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_Gossip_CoronationFashion =..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn01_RH_Gossip_CoronationFashion = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_Gossip_CoronationFashion"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn01_Rumburg_QueenCongrats = true"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn01_Rumburg_QueenCongrats = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Rumburg_QueenCongrats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn01_Monqiz_HubertusDuke = true"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn01_Monqiz_HubertusDuke = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Monqiz_HubertusDuke"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn01_Derdia_AzmalCongrats = true"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn01_Derdia_AzmalCongrats = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Derdia_AzmalCongrats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn01_Morella_AlmaCongrats = true"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn01_Morella_AlmaCongrats = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Morella_AlmaCongrats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true)"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn01_Pales_DukeCongrats = true"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn01_Sallabes_SazonCongrats = true"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn01_Pales_DukeCongrats = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Pales_DukeCongrats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn01_Sallabes_SazonCongrats = true"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn01_Sallabes_SazonCongrats = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Sallabes_SazonCongrats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn01_Montaklar_AzaroCongrats = ..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn01_Montaklar_AzaroCongrats = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Montaklar_AzaroCongrats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[161]`
Mówca: **Vina Toras**
> ""You are the king now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "The final notes of the coronation hymn "By His Sword I Li..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Limp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Limp == true)"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Limp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Limp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "I hoped my limp wasn't visible to television viewers. I t..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Limp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Limp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Sal Ignacius");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player_Romus_Italic: "Open it."*)

### Węzeł `[166]`
Mówca: **Narrator**
> "It was made of pure gold, adorned with two twisting spires resembling bull's horns."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Coronation_LookedAtCrown = true"*)

### Węzeł `[167]`
Mówca: **Narrator**
> "It was inlaid with a trio of diamonds, representing the three royal houses of Rizia: Toras, Azaro and Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Coronation_TookOrb = true"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_ForThePeople", "R_ForThePeople_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_ForThePeople","R_ForThePeople_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The angelic-sounding voices of a boys' choir echoed throu..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_BrokeTradition += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_BrokeTradition"] = Variable["RiziaDLC.PersonalValue_BrokeTradition"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player_Romus: ""I know this is highly unusual, but we are living in unus..."*)
  - -> `[55]` (*Player_Romus: ""Ladies and gentlemen of Rizia...""*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May God bless this country and its people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Player_Romus), `[68]` (Player_Romus), `[69]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1"*)

### Węzeł `[172]`
Mówca: **Narrator**
> "Glory to Rizia. His shout reverberated throughout the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "The attendees hurriedly broke into enthusiastic applause...."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Coronation End`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "Everyone in the crowd bowed their heads as Vina and I mad..."*)

### Węzeł `[174]`
Mówca: **Narrator**
> "Everyone in the crowd bowed their heads as Vina and I made our way down the aisle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)

### Węzeł `[175]`
Mówca: **Narrator**
> "I passed my cousin Rico in the second row. He looked up at me and smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "As we kept walking, I recognized various other members of..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedSuOmina == true"*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedSuOmina == true)"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedSuOmina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "I passed my cousin Rico in the second row. He looked up a..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedSuOmina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "I passed my cousin Rico in the second row. He kept his he..."*)

### Węzeł `[179]`
Mówca: **Narrator**
> "I passed my cousin Rico in the second row. He kept his head down and didn't acknowledge me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "As we kept walking, I recognized various other members of..."*)

### Węzeł `[180]`
Mówca: **Narrator**
> "The entire back row was reserved for the Rumburgian royal family and their entourage. I could feel my sister-in-law Beatrice's eyes on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "We reached the end of the hall, where a spiral staircase ..."*)

### Węzeł `[181]`
Mówca: **Narrator**
> "As we kept walking, I recognized various other members of Rizia's three royal houses as well as monarchs from distant kingdoms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "The entire back row was reserved for the Rumburgian royal..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "My daughter beamed and put her arm through mine. We walke..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("RizianNationalAnthem");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("RizianNationalAnthem");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player_Romus_Italic: "Stand up."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "According to royal tradition, this was my signal to march down the aisle and up to the palace balcony to greet the public."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player_Romus_Italic: "Break tradition and make a speech first."*)
  - -> `[95]` (*Player_Romus_Italic: "Proceed with the coronation."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_GlovuriusAxaRizia += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["RiziaDLC.Said_GlovuriusAxaRizia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "The hall fell silent again. My uncle was the first to speak."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "The hall fell silent again. My uncle was the first to speak."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_GaveSpeech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_GaveSpeech == true"*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coronation_GaveSpeech == true)"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_GaveSpeech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coronation_GaveSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_G_Coronation_GenericSpeech = ..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coronation_GaveSpeech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coronation_GaveSpeech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_G_Coronation_NoSpeech = true"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn01_G_Coronation_GenericSpeech = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_G_Coronation_GenericSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_Coronation_Speech = true"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Rising to the throne", "Coronation Celebration", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Rising to the throne","Coronation Celebration","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_ForThePeople", "R_ForThePeople_Loop");"*)
