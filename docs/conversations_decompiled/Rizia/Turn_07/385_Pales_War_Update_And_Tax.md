# Rizia/Turn 7/Pales War Update And Tax

- **ID konwersacji:** `385`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/385_Pales_War_Update_And_Tax.md`
- **Liczba węzłów dialogowych:** 171
- **Liczba wyborów gracza:** 24

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Coronation_Speech_Diplomacy`
- `RiziaDLC.Coronation_Speech_TakeBackLand`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Policy_RD_Economy_EnactInheritanceTax`
- `RiziaDLC.Policy_RD_Economy_LandOwnersTax`
- `RiziaDLC.Relations_VinaManus_Approve`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.War_Incident_Border`
- `RiziaDLC.War_Incident_Naval`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Enable_Policy_RD_Economy_WarProfitsTax`
- `RiziaDLC.Resources_Authority`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[386] Rizia/Turn 7/Zille Treaty Discussion** (../Turn_07/386_Zille_Treaty_Discussion.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[13]` | **""I did not want to go to war myself. But I did what I had to for the good of my ki..."** | `[12]` **Manus Sazon**: ""I am not contesting the King's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Manus Sazon**: ""I understand that, Your Majesty."" |
| `[25]` | **""Yes, that's completely fair. Please continue.""** | `[12]` **Manus Sazon**: ""I am not contesting the King's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Manus Sazon**: ""Thank you, Your Majesty."" |
| `[26]` | **""And your subjects would rather we roll over in submission to the Palesians and th..."** | `[12]` **Manus Sazon**: ""I am not contesting the King's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Manus Sazon**: ""There must surely have been a m..." |
| `[27]` | **""If I am sending my people to fight for a cause they do not fully believe in, that..."** | `[12]` **Manus Sazon**: ""I am not contesting the King's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Manus Sazon**: ""I agree."" |
| `[55]` | **""I am receptive to your concerns, Mr. Sazon. But what's done is done. We are at wa..."** | `[54]` **Daria de Rava**: ""Nobody is asking your party to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Manus Sazon**: ""Yes, I agree. Which is why we m..." |
| `[56]` | **""On the contrary, Madame Speaker, the members of the RPP *will* support the war or..."** | `[54]` **Daria de Rava**: ""Nobody is asking your party to ..." | `Variable["RiziaDLC.LeaningValue_Democratic"] < 0` | *Brak zmian stanu* | `[66]` **Manus Sazon**: ""We will support the war if we c..." |
| `[60]` | **""Are you forgetting they have taken my daughter hostage? Would you rather I leave ..."** | `[54]` **Daria de Rava**: ""Nobody is asking your party to ..." | `Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[77]` **Narrator**: "His face paled." |
| `[61]` | **""Precisely. Do not fool yourself into thinking a few fringe movements represent th..."** | `[54]` **Daria de Rava**: ""Nobody is asking your party to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Manus Sazon**: ""Regardless of how many Rizians ..." |
| `[81]` | **""I agree. We are relying on these companies to help win the war. To levy unfair ta..."** | `[36]` **Daria de Rava**: ""Even if we needed the money... ..."<br>`[37]` **Daria de Rava**: ""Keep in mind that these are the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Daria de Rava**: ""Precisely. If we need to pad ou..." |
| `[82]` | **""If our business owners truly support Rizia, they will do their part to keep the r..."** | `[36]` **Daria de Rava**: ""Even if we needed the money... ..."<br>`[37]` **Daria de Rava**: ""Keep in mind that these are the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Narrator**: "Next to me, Hugo spoke through g..." |
| `[83]` | **""That income they're making is blood money. If they have any sort of conscience, t..."** | `[36]` **Daria de Rava**: ""Even if we needed the money... ..."<br>`[37]` **Daria de Rava**: ""Keep in mind that these are the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Narrator**: "Next to me, Hugo spoke through g..." |
| `[84]` | **""You will refrain from commenting out of turn, Madam *Minority* Speaker.""** | `[36]` **Daria de Rava**: ""Even if we needed the money... ..."<br>`[37]` **Daria de Rava**: ""Keep in mind that these are the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Daria de Rava**: ""I am sorry. But it's important ..." |
| `[115]` | **""You will refrain from commenting out of turn, Mr. Sazon.""** | `[149]` **Manus Sazon**: ""What we are proposing is a move..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Manus Sazon**: ""I'm sorry. But I wanted you to ..." |
| `[117]` | **""We are relying on these companies to help win the war. To levy unfair taxes upon ..."** | `[149]` **Manus Sazon**: ""What we are proposing is a move..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Daria de Rava**: ""Precisely, Your Majesty."" |
| `[119]` | **""That income they're making is blood money. If they have any sort of conscience, t..."** | `[149]` **Manus Sazon**: ""What we are proposing is a move..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Narrator**: "Manus nodded. Next to me, Hugo s..." |
| `[121]` | **""If our business owners truly support Rizia, they will do their part to keep the r..."** | `[149]` **Manus Sazon**: ""What we are proposing is a move..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Narrator**: "Manus nodded. Next to me, Hugo s..." |
| `[127]` | **""Sensible. No need for it to go any further.""** | `[126]` **Daria de Rava**: ""The House of Delegates has alre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Daria de Rava**: ""I'm glad you're in agreement."" |
| `[134]` | **""Send it to me regardless. I will decide what to do with it later.""** | `[126]` **Daria de Rava**: ""The House of Delegates has alre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Narrator**: "Daria frowned in consternation." |
| `[135]` | **""I'm afraid I have to go against your recommendation. Rizia will implement the war..."** | `[126]` **Daria de Rava**: ""The House of Delegates has alre..." | `Variable["RiziaDLC.Resources_Authority"] >= 3` | *Brak zmian stanu* | `[144]` **Narrator**: "Daria frowned in consternation." |
| `[136]` | **""Very good. My Grand Vizier will make sure it crosses my desk. Won't you, Your Gra..."** | `[111]` **Manus Sazon**: ""The House of Delegates supports..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Narrator**: "Hugo lowered his head." |
| `[137]` | **""No need, Mr. Speaker. I have no interest in passing such a decree.""** | `[111]` **Manus Sazon**: ""The House of Delegates supports..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Narrator**: "He frowned in consternation." |
| `[139]` | **""Why go through all that trouble? I'll sign the war profits tax decree immediately.""** | `[111]` **Manus Sazon**: ""The House of Delegates supports..." | `Variable["RiziaDLC.Resources_Authority"] >= 3` | *Brak zmian stanu* | `[140]` **Narrator**: "He frowned in consternation." |
| `[163]` | **""Mr. Sazon, I am confident that our victory in Pales will be swift enough that suc..."** | `[111]` **Manus Sazon**: ""The House of Delegates supports..." | `(Variable["RiziaDLC.Resources_Authority"] >= 3) == false` | *Brak zmian stanu* | `[164]` **Manus Sazon**: ""I hope so as well. But I will s..." |
| `[165]` | **""I am confident that our victory in Pales will be swift enough that such a measure..."** | `[126]` **Daria de Rava**: ""The House of Delegates has alre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Daria de Rava**: ""So am I, Your Majesty."" |

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
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[3]`
Mówca: **Manus Sazon**
> ""The first item on our agenda concerns the war with Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Manus Sazon: ""I must state that my party harbors reservations about th..."*)

### Węzeł `[4]`
Mówca: **Daria de Rava**
> ""The first item on our agenda concerns the war with Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Daria de Rava: ""Needless to say, we in the RNC stand fully behind our tr..."*)

### Węzeł `[5]`
Mówca: **Manus Sazon**
> ""I must state that my party harbors reservations about the current conflict. As do many Rizian citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == false && RiziaDLC.War_Inc..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == false && RiziaDLC.War_Incident_Naval == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == false && RiziaDLC.War_Inc..."*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Incident_Border == false && RiziaDLC.War_I..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == false && RiziaDLC.War_Incident_Naval == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == false  and  Variable["RiziaDLC.War_Incident_Naval"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Manus Sazon: ""They are suspicious of the motives for our invasion, and..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Incident_Border == false && RiziaDLC.War_Incident_Naval == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == false  and  Variable["RiziaDLC.War_Incident_Naval"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Manus Sazon: ""Though our invasion could be seen as justified, many fea..."*)

### Węzeł `[9]`
Mówca: **Manus Sazon**
> ""They are suspicious of the motives for our invasion, and fear a repeat of the 1920s.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_TakeBackLand == true"*)

### Węzeł `[10]`
Mówca: **Manus Sazon**
> ""Though our invasion could be seen as justified, many fear a repeat of the 1920s.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_TakeBackLand == true"*)

### Węzeł `[11]`
Mówca: **Daria de Rava**
> ""Objection. His Majesty's decision to go to war was made in full accordance with the Royal Council, and is not up for discussion today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Manus Sazon: ""I am not contesting the King's decision. Merely reflecti..."*)

### Węzeł `[12]`
Mówca: **Manus Sazon**
> ""I am not contesting the King's decision. Merely reflecting the point of view of his subjects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player_Romus: ""I did not want to go to war myself. But I did what I had..."*)
  - -> `[25]` (*Player_Romus: ""Yes, that's completely fair. Please continue.""*)
  - -> `[26]` (*Player_Romus: ""And your subjects would rather we roll over in submissio..."*)
  - -> `[27]` (*Player_Romus: ""If I am sending my people to fight for a cause they do n..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did not want to go to war myself. But I did what I had to for the good of my kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Manus Sazon: ""I understand that, Your Majesty.""*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_TakeBackLand == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_TakeBackLand == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coronation_Speech_TakeBackLand == true )"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_TakeBackLand == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Manus Sazon: ""While the King's intention to reclaim Rizia's lost terri..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coronation_Speech_TakeBackLand == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_Diplomacy == true"*)

### Węzeł `[17]`
Mówca: **Manus Sazon**
> ""While the King's intention to reclaim Rizia's lost territory was well-received at his coronation, the temperature in this country has changed. As has the international climate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Manus Sazon: ""It is difficult for my party to support an all-out attac..."*)

### Węzeł `[18]`
Mówca: **Manus Sazon**
> ""It is difficult for my party to support an all-out attack on the Grand Duchy, especially when the future of Zille is still in doubt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Daria de Rava: ""Objection. His Majesty's decision to go to war was made ..."*)

### Węzeł `[19]`
Mówca: **Manus Sazon**
> ""At the beginning of his reign, His Majesty hinted he would take a conciliatory approach towards international politics. Unfortunately, that no longer appears to be true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Manus Sazon: ""It is difficult for my party to support an all-out attac..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_Diplomacy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_Diplomacy == true"*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coronation_Speech_Diplomacy == true)"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_Diplomacy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_Diplomacy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Manus Sazon: ""At the beginning of his reign, His Majesty hinted he wou..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coronation_Speech_Diplomacy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_Diplomacy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Manus Sazon: ""While some Rizians do still hold out hope for the annexa..."*)

### Węzeł `[23]`
Mówca: **Manus Sazon**
> ""While some Rizians do still hold out hope for the annexation of Pales, the temperature in this country has changed. As has the international climate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Manus Sazon: ""It is difficult for my party to support an all-out attac..."*)

### Węzeł `[24]`
Mówca: **Daria de Rava**
> ""Needless to say, we in the RNC stand fully behind our troops, as does the rest of the country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Daria de Rava: ""There have been some isolated anti-war protests at unive..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, that's completely fair. Please continue.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Manus Sazon: ""Thank you, Your Majesty.""*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And your subjects would rather we roll over in submission to the Palesians and their greedy puppetmasters?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Manus Sazon: ""There must surely have been a middle ground between that..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I am sending my people to fight for a cause they do not fully believe in, that's indeed troubling.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Manus Sazon: ""I agree.""*)

### Węzeł `[28]`
Mówca: **Manus Sazon**
> ""I understand that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Manus Sazon: ""As I was saying. Now that we are engaged in this unfortu..."*)

### Węzeł `[29]`
Mówca: **Manus Sazon**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Manus Sazon: ""As I was saying. Now that we are engaged in this unfortu..."*)

### Węzeł `[30]`
Mówca: **Manus Sazon**
> ""There must surely have been a middle ground between that and outright war. But it is now too late to find it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Manus Sazon: ""As I was saying. Now that we are engaged in this unfortu..."*)

### Węzeł `[31]`
Mówca: **Daria de Rava**
> ""Your concern is valid, Mr. Sazon, but the tax your party is proposing will only damage Rizia's wartime morale, not boost it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Daria de Rava: ""Keep in mind that these are the same industries that hav..."*)

### Węzeł `[32]`
Mówca: **Manus Sazon**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Manus Sazon: ""If we are to remain engaged in this unfortunate conflict..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "He looked directly at Daria."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Manus Sazon: ""In the name of equity, the RPP is proposing an excess pr..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Several yellow-sashed representatives from Cardesse-Montaklar immediately stood up in objection."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Manus Sazon: ""In this way, we can ensure continued funding for our dom..."*)

### Węzeł `[35]`
Mówca: **Manus Sazon**
> ""In this way, we can ensure continued funding for our domestic programs, including care for our veterans, in spite of the heavy costs of the war effort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 3"*)

### Węzeł `[36]`
Mówca: **Daria de Rava**
> ""Even if we needed the money... these are the same industries that have been working tirelessly to supply our troops with weapons and equipment. They should be lauded, not penalized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Romus: ""You will refrain from commenting out of turn, Madam *Min..."*)
  - -> `[81]` (*Player_Romus: ""I agree. We are relying on these companies to help win t..."*)
  - -> `[82]` (*Player_Romus: ""If our business owners truly support Rizia, they will do..."*)
  - -> `[83]` (*Player_Romus: ""That income they're making is blood money. If they have ..."*)

### Węzeł `[37]`
Mówca: **Daria de Rava**
> ""Keep in mind that these are the same industries that have been working tirelessly to supply our troops with weapons and equipment. They should be lauded, not penalized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Romus: ""You will refrain from commenting out of turn, Madam *Min..."*)
  - -> `[81]` (*Player_Romus: ""I agree. We are relying on these companies to help win t..."*)
  - -> `[82]` (*Player_Romus: ""If our business owners truly support Rizia, they will do..."*)
  - -> `[83]` (*Player_Romus: ""That income they're making is blood money. If they have ..."*)

### Węzeł `[38]`
Mówca: **Manus Sazon**
> ""As I was saying. Now that we are engaged in this unfortunate conflict, measures must be taken to mitigate its impact on ordinary citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Manus Sazon: ""It is a simple fact that war is a source of suffering fo..."*)

### Węzeł `[39]`
Mówca: **Manus Sazon**
> ""If we are to remain engaged in this unfortunate conflict, measures must be taken to mitigate its impact on ordinary citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Manus Sazon: ""It is a simple fact that war is a source of suffering fo..."*)

### Węzeł `[40]`
Mówca: **Manus Sazon**
> ""It is a simple fact that war is a source of suffering for many and enormous financial windfalls for an elite few.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "He looked directly at Daria."*)

### Węzeł `[41]`
Mówca: **Manus Sazon**
> ""In the name of equity, the RPP is proposing an excess profits tax on the businesses and industries that stand to generate the most revenue from the Pales campaign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Several yellow-sashed representatives from Cardesse-Monta..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 3"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget > 3)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Daria de Rava: ""With all due respect, Mr. Sazon, what you're proposing i..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Daria de Rava: ""Your concern is valid, Mr. Sazon, but the tax your party..."*)

### Węzeł `[45]`
Mówca: **Daria de Rava**
> ""With all due respect, Mr. Sazon, what you're proposing is utterly unnecessary. Rizia can fund both its internal programs and the military without going into the red.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Daria de Rava: ""Even if we needed the money... these are the same indust..."*)

### Węzeł `[46]`
Mówca: **Daria de Rava**
> ""There have been some isolated anti-war protests at universities, particularly in Brenas. But those do not represent the general opinion of the Rizian populace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Manus Sazon: ""Objection. Madame Speaker is downplaying the amount of o..."*)

### Węzeł `[47]`
Mówca: **Manus Sazon**
> ""Objection. Madame Speaker is downplaying the amount of opposition to the Pales conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == false && RiziaDLC.War_Inc..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == false && RiziaDLC.War_Incident_Naval == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Incident_Border == false && RiziaDLC.War_Inc..."*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Incident_Border == false && RiziaDLC.War_I..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Incident_Border == false && RiziaDLC.War_Incident_Naval == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == false  and  Variable["RiziaDLC.War_Incident_Naval"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Manus Sazon: ""A great many citizens are suspicious of the motives for ..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Incident_Border == false && RiziaDLC.War_Incident_Naval == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == false  and  Variable["RiziaDLC.War_Incident_Naval"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Manus Sazon: ""Though Pales seems to have been the instigator this time..."*)

### Węzeł `[51]`
Mówca: **Manus Sazon**
> ""A great many citizens are suspicious of the motives for our invasion, and fear a repeat of the 1920s.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Manus Sazon: ""It is difficult for the RPP to support an all-out attack..."*)

### Węzeł `[52]`
Mówca: **Manus Sazon**
> ""Though Pales seems to have been the instigator this time around, a great many citizens fear a repeat of the 1920s.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Manus Sazon: ""It is difficult for the RPP to support an all-out attack..."*)

### Węzeł `[53]`
Mówca: **Manus Sazon**
> ""It is difficult for the RPP to support an all-out attack on the Grand Duchy, especially when the future of Zille is still in doubt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Daria de Rava: ""Nobody is asking your party to support the war. We only ..."*)

### Węzeł `[54]`
Mówca: **Daria de Rava**
> ""Nobody is asking your party to support the war. We only ask you to respect the will of the majority of citizens who do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)
  - -> `[61]` (*Player_Romus: ""Precisely. Do not fool yourself into thinking a few frin..."*)
  - -> `[55]` (*Player_Romus: ""I am receptive to your concerns, Mr. Sazon. But what's d..."*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am receptive to your concerns, Mr. Sazon. But what's done is done. We are at war whether we like it or not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Manus Sazon: ""Yes, I agree. Which is why we must take steps to mitigat..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On the contrary, Madame Speaker, the members of the RPP *will* support the war or face the consequences.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Kontekst wejściowy (poprzednik):** `[54]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Manus Sazon: ""We will support the war if we can find a way to mitigate..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player_Romus: ""Are you forgetting they have taken my daughter hostage? ..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you forgetting they have taken my daughter hostage? Would you rather I leave her to die?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[54]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "His face paled."*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Precisely. Do not fool yourself into thinking a few fringe movements represent the masses.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Manus Sazon: ""Regardless of how many Rizians support the military oper..."*)

### Węzeł `[62]`
Mówca: **Manus Sazon**
> ""Regardless of how many Rizians support the military operation, we can all agree that it will take an enormous amount of resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Manus Sazon: ""Which brings me to the proposal I submitted--""*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic < 0)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""On the contrary, Madame Speaker, the members of the RPP ..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[66]`
Mówca: **Manus Sazon**
> ""We will support the war if we can find a way to mitigate its impact on our internal welfare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Manus Sazon: ""Which brings me to the proposal I submitted--""*)

### Węzeł `[67]`
Mówca: **Manus Sazon**
> ""Which brings me to the proposal I submitted--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "Daria banged her gavel sharply."*)

### Węzeł `[68]`
Mówca: **Manus Sazon**
> ""Yes, I agree. Which is why we must take steps to mitigate the conflict's impact on ordinary citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Manus Sazon: ""Which brings me to the proposal I submitted--""*)

### Węzeł `[69]`
Mówca: **Narrator**
> "Daria banged her gavel sharply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Daria de Rava: ""Yes, Mr. Sazon. We were getting to that.""*)

### Węzeł `[70]`
Mówca: **Daria de Rava**
> ""Yes, Mr. Sazon. We were getting to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "She cleared her throat."*)

### Węzeł `[71]`
Mówca: **Manus Sazon**
> ""Of course not, Your Majesty. Her Highness' return is of the utmost priority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Manus Sazon: ""At the same time, we cannot ignore the impact the war wi..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "She cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Daria de Rava: ""To generate funding for domestic programs during wartime..."*)

### Węzeł `[73]`
Mówca: **Manus Sazon**
> ""Of course not, Your Majesty. Everyone in this room knows how much Her Highness means to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Manus Sazon: ""At the same time, we cannot ignore the impact the war wi..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_VinaManus_Approve == true)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Manus Sazon: ""Of course not, Your Majesty. Everyone in this room knows..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_VinaManus_Approve == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Manus Sazon: ""Of course not, Your Majesty. Her Highness' return is of ..."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "His face paled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true"*)

### Węzeł `[78]`
Mówca: **Manus Sazon**
> ""At the same time, we cannot ignore the impact the war will have on ordinary citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Manus Sazon: ""Which brings me to the proposal I submitted--""*)

### Węzeł `[79]`
Mówca: **Daria de Rava**
> ""To generate funding for domestic programs during wartime, the Rizian People's Party has proposed a 'war profits tax' on those very same businesses and industries that are working tirelessly to equip our troops.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Daria de Rava: ""Your Majesty, the RNC does not condone this decree at all.""*)

### Węzeł `[80]`
Mówca: **Manus Sazon**
> ""Such as what, Ms. de Rava? Your party refused to consider the RPP's inheritance and landowner tax proposals. Is your only solution to place the burden on those who can least afford it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Manus Sazon: ""The House of Delegates supports this proposal by a high ..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. We are relying on these companies to help win the war. To levy unfair taxes upon them would be to bite the hand that feeds us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Daria de Rava), `[37]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Daria de Rava: ""Precisely. If we need to pad out our budget, there are o..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If our business owners truly support Rizia, they will do their part to keep the rest of the kingdom afloat during these difficult times.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Daria de Rava), `[37]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "Next to me, Hugo spoke through gritted teeth."*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That income they're making is blood money. If they have any sort of conscience, they won't want to keep it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Daria de Rava), `[37]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "Next to me, Hugo spoke through gritted teeth."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will refrain from commenting out of turn, Madam *Minority* Speaker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Daria de Rava), `[37]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Daria de Rava: ""I am sorry. But it's important that you get the full pic..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "Next to me, Hugo spoke through gritted teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Hugo Toras: ""Your Majesty, this tax would disproportionately affect H..."*)

### Węzeł `[86]`
Mówca: **Daria de Rava**
> ""I am sorry. But it's important that you get the full picture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Manus Sazon: ""The full picture is that if Rizia fails its citizens, we..."*)

### Węzeł `[87]`
Mówca: **Daria de Rava**
> ""Precisely. If we need to pad out our budget, there are other ways to go about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == false &..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == false && RiziaDLC.Policy_RD_Economy_LandOwnersTax == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == false &..."*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == false..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == false && RiziaDLC.Policy_RD_Economy_LandOwnersTax == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == false  and  Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Manus Sazon: ""Such as what, Ms. de Rava? Your party refused to conside..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == false && RiziaDLC.Policy_RD_Economy_LandOwnersTax == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == false  and  Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == false"*)

### Węzeł `[91]`
Mówca: **Daria de Rava**
> ""Your Majesty, the RNC does not condone this decree at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 4"*)

### Węzeł `[92]`
Mówca: **Hugo Toras**
> ""Your Majesty, this tax would disproportionately affect House Azaro, as well as the de Ravas themselves. I don't think it's a good idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Daria de Rava: ""I do not dispute that we all must make sacrifices in tim..."*)

### Węzeł `[93]`
Mówca: **Manus Sazon**
> ""The full picture is that if Rizia fails its citizens, we will have nobody willing to fight our wars.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true &&..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Economy_LandOwnersTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true &&..."*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true ..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Economy_LandOwnersTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Manus Sazon: ""Ms. de Rava's party issued an official disproval of His ..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Economy_LandOwnersTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true"*)

### Węzeł `[97]`
Mówca: **Daria de Rava**
> ""I do not dispute that we all must make sacrifices in times of war. But this particular one could severely hinder our chances of victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "Manus banged his gavel sharply."*)

### Węzeł `[98]`
Mówca: **Manus Sazon**
> ""Ms. de Rava, I know you are used to being in charge of these proceedings, but I beg you to remember that is no longer the case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Manus Sazon: ""The House of Delegates supports this proposal by a high ..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Manus Sazon: ""Ms. de Rava's party issued an official disproval of His ..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Manus Sazon: ""Ms. de Rava's party issued an official disproval of His ..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == false"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == false)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Manus Sazon: ""Such as what, Ms. de Rava? Your party issued an official..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Manus Sazon: ""Such as what, Ms. de Rava? Your party issued an official..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget > 4"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget > 4)"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget > 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Daria de Rava: ""According to the latest treasury numbers from Councilor ..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget > 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Daria de Rava: ""If we need funding, we can get it another way. The compa..."*)

### Węzeł `[108]`
Mówca: **Manus Sazon**
> ""Such as what, Ms. de Rava? Your party issued an official disproval of His Majesty's landowner tax decree. Is your only solution to place the burden on those who can least afford it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Manus Sazon: ""The House of Delegates supports this proposal by a high ..."*)

### Węzeł `[109]`
Mówca: **Manus Sazon**
> ""Such as what, Ms. de Rava? Your party issued an official disproval of His Majesty's inheritance tax decree. Is your only solution to place the burden on those who can least afford it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Manus Sazon: ""The House of Delegates supports this proposal by a high ..."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "Manus banged his gavel sharply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Manus Sazon: ""Ms. de Rava, I know you are used to being in charge of t..."*)

### Węzeł `[111]`
Mówca: **Manus Sazon**
> ""The House of Delegates supports this proposal by a high margin. Therefore, it will be passed on to the King to enact as he sees fit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player_Romus: ""No need, Mr. Speaker. I have no interest in passing such..."*)
  - -> `[136]` (*Player_Romus: ""Very good. My Grand Vizier will make sure it crosses my ..."*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 3"*)

### Węzeł `[112]`
Mówca: **Manus Sazon**
> ""Ms. de Rava's party issued an official disproval of His Majesty's inheritance tax decree. Her preferred solution, it seems, is to place the burden on those who can least afford it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Manus Sazon: ""The House of Delegates supports this proposal by a high ..."*)

### Węzeł `[113]`
Mówca: **Manus Sazon**
> ""Ms. de Rava's party issued an official disproval of His Majesty's landowner tax decree. Her preferred solution, it seems, is to place the burden on those who can least afford it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Manus Sazon: ""The House of Delegates supports this proposal by a high ..."*)

### Węzeł `[114]`
Mówca: **Daria de Rava**
> ""According to the latest treasury numbers from Councilor Werner, Rizia can fund both its internal programs and the military without going into the red.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Daria de Rava: ""And even if that wasn't the case, the companies in quest..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will refrain from commenting out of turn, Mr. Sazon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Manus Sazon: ""I'm sorry. But I wanted you to get the full picture.""*)

### Węzeł `[116]`
Mówca: **Manus Sazon**
> ""I'm sorry. But I wanted you to get the full picture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Daria de Rava: ""The full picture is that if we punish the companies resp..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are relying on these companies to help win the war. To levy unfair taxes upon them would be to bite the hand that feeds us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Daria de Rava: ""Precisely, Your Majesty.""*)

### Węzeł `[118]`
Mówca: **Daria de Rava**
> ""Precisely, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Daria de Rava: ""I do not dispute that fighting for our country requires ..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That income they're making is blood money. If they have any sort of conscience, they won't want to keep it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "Manus nodded. Next to me, Hugo spoke through gritted teeth."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "Manus nodded. Next to me, Hugo spoke through gritted teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Hugo Toras: ""Your Majesty, this tax would disproportionately affect H..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If our business owners truly support Rizia, they will do their part to keep the rest of the kingdom afloat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "Manus nodded. Next to me, Hugo spoke through gritted teeth."*)

### Węzeł `[122]`
Mówca: **Hugo Toras**
> ""Your Majesty, this tax would disproportionately affect House Azaro, as well as the de Ravas themselves. I don't think it's a good idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Daria de Rava: ""I do not dispute that fighting for our country requires ..."*)

### Węzeł `[123]`
Mówca: **Daria de Rava**
> ""I do not dispute that fighting for our country requires sacrifice. But this particular one could severely hinder our chances of victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "She turned to face me."*)

### Węzeł `[124]`
Mówca: **Daria de Rava**
> ""The full picture is that if we punish the companies responsible for our national defense, we will lose this war even worse than the last one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "She turned to face me."*)

### Węzeł `[125]`
Mówca: **Narrator**
> "She turned to face me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Daria de Rava: ""The House of Delegates has already voted down this propo..."*)

### Węzeł `[126]`
Mówca: **Daria de Rava**
> ""The House of Delegates has already voted down this proposal by a high margin. We recommend that the King ignore it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player_Romus: ""Sensible. No need for it to go any further.""*)
  - -> `[134]` (*Player_Romus: ""Send it to me regardless. I will decide what to do with ..."*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 3"*)
  - -> `[165]` (*Player_Romus: ""I am confident that our victory in Pales will be swift e..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sensible. No need for it to go any further.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Daria de Rava: ""I'm glad you're in agreement.""*)

### Węzeł `[128]`
Mówca: **Narrator**
> "She turned a page in her binder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Daria de Rava: ""The next item is an update on our progress with Zille.""*)

### Węzeł `[129]`
Mówca: **Daria de Rava**
> ""Certainly, Your Majesty. I'll make sure it reaches your desk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "She turned a page in her binder."*)

### Węzeł `[130]`
Mówca: **Hugo Toras**
> ""Certainly, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Enable_Policy_RD_Economy_WarProfitsTax = true"*)

### Węzeł `[131]`
Mówca: **Daria de Rava**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "She turned a page in her binder."*)

### Węzeł `[132]`
Mówca: **Manus Sazon**
> ""I had hoped you would at least allow it to reach your desk. But as you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "Manus turned a page in his binder."*)

### Węzeł `[133]`
Mówca: **Manus Sazon**
> ""I had hoped it would go through some sort of legislative process. But good news regardless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "EnactDecree("Economy_Taxes_WarProfitsTax"); RiziaDLC.Reso..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Send it to me regardless. I will decide what to do with it later.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "Daria frowned in consternation."*)

### Węzeł `[135]`
**[WYBÓR GRACZA: ""I'm afraid I have to go against your recommendation. Rizia will implement the war profits tax that the RPP proposed." [-3 Authority]"]** — Mówca: **Player_Romus**
> ""I'm afraid I have to go against your recommendation. Rizia will implement the war profits tax that the RPP proposed.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Authority"] >= 3`
- **Kontekst wejściowy (poprzednik):** `[126]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "Daria frowned in consternation."*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very good. My Grand Vizier will make sure it crosses my desk. Won't you, Your Grace?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "Hugo lowered his head."*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need, Mr. Speaker. I have no interest in passing such a decree.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "He frowned in consternation."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "He frowned in consternation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Manus Sazon: ""I had hoped you would at least allow it to reach your de..."*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why go through all that trouble? I'll sign the war profits tax decree immediately.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Authority"] >= 3`
- **Kontekst wejściowy (poprzednik):** `[111]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "He frowned in consternation."*)

### Węzeł `[140]`
Mówca: **Narrator**
> "He frowned in consternation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Manus Sazon: ""I had hoped it would go through some sort of legislative..."*)

### Węzeł `[141]`
Mówca: **Narrator**
> "Hugo lowered his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Hugo Toras: ""Certainly, Your Majesty.""*)

### Węzeł `[142]`
Mówca: **Daria de Rava**
> ""I'm glad you're in agreement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "She turned a page in her binder."*)

### Węzeł `[143]`
Mówca: **Narrator**
> "Daria frowned in consternation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Enable_Policy_RD_Economy_WarProfitsTax = true"*)

### Węzeł `[144]`
Mówca: **Narrator**
> "Daria frowned in consternation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "EnactDecree("Economy_Taxes_WarProfitsTax");"*)

### Węzeł `[145]`
Mówca: **Daria de Rava**
> ""If we need funding, we can get it another way. The companies in question should be lauded for their contribution to the cause, not penalized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Manus Sazon: ""You are misrepresenting our proposal, Madam Speaker.""*)

### Węzeł `[146]`
Mówca: **Daria de Rava**
> ""And even if that wasn't the case, the companies in question should be lauded for their contribution to the cause, not penalized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Manus Sazon: ""You are misrepresenting our proposal, Madam Speaker.""*)

### Węzeł `[147]`
Mówca: **Manus Sazon**
> ""You are misrepresenting our proposal, Madam Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Manus Sazon: ""It is an undeniable fact that war is a source of sufferi..."*)

### Węzeł `[148]`
Mówca: **Manus Sazon**
> ""It is an undeniable fact that war is a source of suffering for many and enormous financial windfalls for an elite few.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Manus Sazon: ""What we are proposing is a move towards equity. It is no..."*)

### Węzeł `[149]`
Mówca: **Manus Sazon**
> ""What we are proposing is a move towards equity. It is not fair that our military operation will put a strain on social welfare while fattening the pockets of weapons executives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player_Romus: ""You will refrain from commenting out of turn, Mr. Sazon.""*)
  - -> `[117]` (*Player_Romus: ""We are relying on these companies to help win the war. T..."*)
  - -> `[121]` (*Player_Romus: ""If our business owners truly support Rizia, they will do..."*)
  - -> `[119]` (*Player_Romus: ""That income they're making is blood money. If they have ..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Manus Sazon: ""The first item on our agenda concerns the war with Pales.""*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Daria de Rava: ""The first item on our agenda concerns the war with Pales.""*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Enable_Policy_RD_Economy_WarProfitsTax = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Enable_Policy_RD_Economy_WarProfitsTax"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "Manus turned a page in his binder."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnactDecree("Economy_Taxes_WarProfitsTax");
RiziaDLC.Resources_Authority += 3;`
- **Efekt skryptowy (`userScript`):** `EnactDecree("Economy_Taxes_WarProfitsTax");
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "Manus turned a page in his binder."*)

### Węzeł `[155]`
Mówca: **Narrator**
> "Manus turned a page in his binder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Manus Sazon: ""The next item is an update on our progress with Zille.""*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Enable_Policy_RD_Economy_WarProfitsTax = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Enable_Policy_RD_Economy_WarProfitsTax"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Daria de Rava: ""Certainly, Your Majesty. I'll make sure it reaches your ..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnactDecree("Economy_Taxes_WarProfitsTax");`
- **Efekt skryptowy (`userScript`):** `EnactDecree("Economy_Taxes_WarProfitsTax");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Daria de Rava: ""As you wish, Your Majesty.""*)

### Węzeł `[158]`
Mówca: **Manus Sazon**
> ""The next item is an update on our progress with Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[159]`
Mówca: **Daria de Rava**
> ""The next item is an update on our progress with Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 3"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Authority >= 3)"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: ""Why go through all that trouble? I'll sign the war profi..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Authority >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player_Romus: ""Mr. Sazon, I am confident that our victory in Pales will..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Sazon, I am confident that our victory in Pales will be swift enough that such a measure will not be called for.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Authority"] >= 3) == false`
- **Kontekst wejściowy (poprzednik):** `[111]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Manus Sazon: ""I hope so as well. But I will send you the proposal in c..."*)

### Węzeł `[164]`
Mówca: **Manus Sazon**
> ""I hope so as well. But I will send you the proposal in case you choose to enact it in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Enable_Policy_RD_Economy_WarProfitsTax = true"*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am confident that our victory in Pales will be swift enough that such a measure will not be called for.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Daria de Rava: ""So am I, Your Majesty.""*)

### Węzeł `[166]`
Mówca: **Daria de Rava**
> ""So am I, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "She turned a page in her binder."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 3"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Authority >= 3)"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Player_Romus: ""I'm afraid I have to go against your recommendation. Riz..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Authority >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 3) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[170]`
Mówca: **Manus Sazon**
> ""Ms. de Rava's party issued an official disproval of His Majesty's landowner and inheritance tax decrees. Her preferred solution, it seems, is to place the burden on those who can least afford it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Manus Sazon: ""The House of Delegates supports this proposal by a high ..."*)
