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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 4

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Enable_Policy_RD_Economy_WarProfitsTax`
- `RiziaDLC.Resources_Authority`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[153]` (Paskal Beniwoll): `Variable["RiziaDLC.Enable_Policy_RD_Economy_WarProfitsTax"] = true;`
- Węzeł `[154]` (Paskal Beniwoll): `EnactDecree("Economy_Taxes_WarProfitsTax"); Variable["RiziaDLC.Resources_Authority"] = Variable["...`
- Węzeł `[156]` (Paskal Beniwoll): `Variable["RiziaDLC.Enable_Policy_RD_Economy_WarProfitsTax"] = true;`
- Węzeł `[157]` (Paskal Beniwoll): `EnactDecree("Economy_Taxes_WarProfitsTax"); ;`

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
  - -> `[150]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `386` (*Rizia/Turn 7/Zille Treaty Discussion*), Węzeł `[1]`

### Węzeł `[3]`
Mówca: **Manus Sazon**
> ""The first item on our agenda concerns the war with Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Daria de Rava**
> ""The first item on our agenda concerns the war with Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[5]`
Mówca: **Manus Sazon**
> ""I must state that my party harbors reservations about the current conflict. As do many Rizian citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == false && RiziaDLC.War_Incident_Naval == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == false && RiziaDLC.War_Incident_Naval == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == false  and  Variable["RiziaDLC.War_Incident_Naval"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Incident_Border == false && RiziaDLC.War_Incident_Naval == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == false  and  Variable["RiziaDLC.War_Incident_Naval"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Manus Sazon**
> ""They are suspicious of the motives for our invasion, and fear a repeat of the 1920s.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[10]`
Mówca: **Manus Sazon**
> ""Though our invasion could be seen as justified, many fear a repeat of the 1920s.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[11]`
Mówca: **Daria de Rava**
> ""Objection. His Majesty's decision to go to war was made in full accordance with the Royal Council, and is not up for discussion today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Manus Sazon**
> ""I am not contesting the King's decision. Merely reflecting the point of view of his subjects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[25]`
  - -> `[26]`
  - -> `[27]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did not want to go to war myself. But I did what I had to for the good of my kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_TakeBackLand == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_TakeBackLand == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coronation_Speech_TakeBackLand == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_TakeBackLand"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[17]`
Mówca: **Manus Sazon**
> ""While the King's intention to reclaim Rizia's lost territory was well-received at his coronation, the temperature in this country has changed. As has the international climate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Manus Sazon**
> ""It is difficult for my party to support an all-out attack on the Grand Duchy, especially when the future of Zille is still in doubt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[19]`
Mówca: **Manus Sazon**
> ""At the beginning of his reign, His Majesty hinted he would take a conciliatory approach towards international politics. Unfortunately, that no longer appears to be true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_Diplomacy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Coronation_Speech_Diplomacy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_Diplomacy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Coronation_Speech_Diplomacy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_Diplomacy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Manus Sazon**
> ""While some Rizians do still hold out hope for the annexation of Pales, the temperature in this country has changed. As has the international climate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[24]`
Mówca: **Daria de Rava**
> ""Needless to say, we in the RNC stand fully behind our troops, as does the rest of the country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, that's completely fair. Please continue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And your subjects would rather we roll over in submission to the Palesians and their greedy puppetmasters?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I am sending my people to fight for a cause they do not fully believe in, that's indeed troubling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[28]`
Mówca: **Manus Sazon**
> ""I understand that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[29]`
Mówca: **Manus Sazon**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[30]`
Mówca: **Manus Sazon**
> ""There must surely have been a middle ground between that and outright war. But it is now too late to find it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[31]`
Mówca: **Daria de Rava**
> ""Your concern is valid, Mr. Sazon, but the tax your party is proposing will only damage Rizia's wartime morale, not boost it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[32]`
Mówca: **Manus Sazon**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[33]`
Mówca: **Narrator**
> "He looked directly at Daria."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Several yellow-sashed representatives from Cardesse-Montaklar immediately stood up in objection."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Manus Sazon**
> ""In this way, we can ensure continued funding for our domestic programs, including care for our veterans, in spite of the heavy costs of the war effort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[36]`
Mówca: **Daria de Rava**
> ""Even if we needed the money... these are the same industries that have been working tirelessly to supply our troops with weapons and equipment. They should be lauded, not penalized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[81]`
  - -> `[82]`
  - -> `[83]`

### Węzeł `[37]`
Mówca: **Daria de Rava**
> ""Keep in mind that these are the same industries that have been working tirelessly to supply our troops with weapons and equipment. They should be lauded, not penalized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[81]`
  - -> `[82]`
  - -> `[83]`

### Węzeł `[38]`
Mówca: **Manus Sazon**
> ""As I was saying. Now that we are engaged in this unfortunate conflict, measures must be taken to mitigate its impact on ordinary citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
Mówca: **Manus Sazon**
> ""If we are to remain engaged in this unfortunate conflict, measures must be taken to mitigate its impact on ordinary citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Manus Sazon**
> ""It is a simple fact that war is a source of suffering for many and enormous financial windfalls for an elite few.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[41]`
Mówca: **Manus Sazon**
> ""In the name of equity, the RPP is proposing an excess profits tax on the businesses and industries that stand to generate the most revenue from the Pales campaign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget > 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[45]`
Mówca: **Daria de Rava**
> ""With all due respect, Mr. Sazon, what you're proposing is utterly unnecessary. Rizia can fund both its internal programs and the military without going into the red.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[46]`
Mówca: **Daria de Rava**
> ""There have been some isolated anti-war protests at universities, particularly in Brenas. But those do not represent the general opinion of the Rizian populace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Manus Sazon**
> ""Objection. Madame Speaker is downplaying the amount of opposition to the Pales conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == false && RiziaDLC.War_Incident_Naval == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.War_Incident_Border == false && RiziaDLC.War_Incident_Naval == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.War_Incident_Border"] == false  and  Variable["RiziaDLC.War_Incident_Naval"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.War_Incident_Border == false && RiziaDLC.War_Incident_Naval == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.War_Incident_Border"] == false  and  Variable["RiziaDLC.War_Incident_Naval"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Manus Sazon**
> ""A great many citizens are suspicious of the motives for our invasion, and fear a repeat of the 1920s.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Manus Sazon**
> ""Though Pales seems to have been the instigator this time around, a great many citizens fear a repeat of the 1920s.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Manus Sazon**
> ""It is difficult for the RPP to support an all-out attack on the Grand Duchy, especially when the future of Zille is still in doubt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Daria de Rava**
> ""Nobody is asking your party to support the war. We only ask you to respect the will of the majority of citizens who do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[61]`
  - -> `[55]`
  - -> `[57]`

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am receptive to your concerns, Mr. Sazon. But what's done is done. We are at war whether we like it or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On the contrary, Madame Speaker, the members of the RPP *will* support the war or face the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_Hostage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_Hostage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you forgetting they have taken my daughter hostage? Would you rather I leave her to die?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Precisely. Do not fool yourself into thinking a few fringe movements represent the masses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Manus Sazon**
> ""Regardless of how many Rizians support the military operation, we can all agree that it will take an enormous amount of resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.LeaningValue_Democratic < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[66]`
Mówca: **Manus Sazon**
> ""We will support the war if we can find a way to mitigate its impact on our internal welfare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Manus Sazon**
> ""Which brings me to the proposal I submitted--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Manus Sazon**
> ""Yes, I agree. Which is why we must take steps to mitigate the conflict's impact on ordinary citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[69]`
Mówca: **Narrator**
> "Daria banged her gavel sharply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Daria de Rava**
> ""Yes, Mr. Sazon. We were getting to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Manus Sazon**
> ""Of course not, Your Majesty. Her Highness' return is of the utmost priority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[72]`
Mówca: **Narrator**
> "She cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[73]`
Mówca: **Manus Sazon**
> ""Of course not, Your Majesty. Everyone in this room knows how much Her Highness means to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_VinaManus_Approve == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_VinaManus_Approve == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[77]`
Mówca: **Narrator**
> "His face paled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[78]`
Mówca: **Manus Sazon**
> ""At the same time, we cannot ignore the impact the war will have on ordinary citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[79]`
Mówca: **Daria de Rava**
> ""To generate funding for domestic programs during wartime, the Rizian People's Party has proposed a 'war profits tax' on those very same businesses and industries that are working tirelessly to equip our troops.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[80]`
Mówca: **Manus Sazon**
> ""Such as what, Ms. de Rava? Your party refused to consider the RPP's inheritance and landowner tax proposals. Is your only solution to place the burden on those who can least afford it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. We are relying on these companies to help win the war. To levy unfair taxes upon them would be to bite the hand that feeds us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If our business owners truly support Rizia, they will do their part to keep the rest of the kingdom afloat during these difficult times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That income they're making is blood money. If they have any sort of conscience, they won't want to keep it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will refrain from commenting out of turn, Madam *Minority* Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Narrator**
> "Next to me, Hugo spoke through gritted teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[86]`
Mówca: **Daria de Rava**
> ""I am sorry. But it's important that you get the full picture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[87]`
Mówca: **Daria de Rava**
> ""Precisely. If we need to pad out our budget, there are other ways to go about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == false && RiziaDLC.Policy_RD_Economy_LandOwnersTax == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == false && RiziaDLC.Policy_RD_Economy_LandOwnersTax == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == false  and  Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == false && RiziaDLC.Policy_RD_Economy_LandOwnersTax == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == false  and  Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[91]`
Mówca: **Daria de Rava**
> ""Your Majesty, the RNC does not condone this decree at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[92]`
Mówca: **Hugo Toras**
> ""Your Majesty, this tax would disproportionately affect House Azaro, as well as the de Ravas themselves. I don't think it's a good idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[93]`
Mówca: **Manus Sazon**
> ""The full picture is that if Rizia fails its citizens, we will have nobody willing to fight our wars.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Economy_LandOwnersTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Economy_LandOwnersTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true && RiziaDLC.Policy_RD_Economy_LandOwnersTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[97]`
Mówca: **Daria de Rava**
> ""I do not dispute that we all must make sacrifices in times of war. But this particular one could severely hinder our chances of victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[98]`
Mówca: **Manus Sazon**
> ""Ms. de Rava, I know you are used to being in charge of these proceedings, but I beg you to remember that is no longer the case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_EnactInheritanceTax == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_EnactInheritanceTax"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 4)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Budget > 4)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] > 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Budget > 4))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] > 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[108]`
Mówca: **Manus Sazon**
> ""Such as what, Ms. de Rava? Your party issued an official disproval of His Majesty's landowner tax decree. Is your only solution to place the burden on those who can least afford it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[109]`
Mówca: **Manus Sazon**
> ""Such as what, Ms. de Rava? Your party issued an official disproval of His Majesty's inheritance tax decree. Is your only solution to place the burden on those who can least afford it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Narrator**
> "Manus banged his gavel sharply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[111]`
Mówca: **Manus Sazon**
> ""The House of Delegates supports this proposal by a high margin. Therefore, it will be passed on to the King to enact as he sees fit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[136]`
  - -> `[160]`

### Węzeł `[112]`
Mówca: **Manus Sazon**
> ""Ms. de Rava's party issued an official disproval of His Majesty's inheritance tax decree. Her preferred solution, it seems, is to place the burden on those who can least afford it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[113]`
Mówca: **Manus Sazon**
> ""Ms. de Rava's party issued an official disproval of His Majesty's landowner tax decree. Her preferred solution, it seems, is to place the burden on those who can least afford it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[114]`
Mówca: **Daria de Rava**
> ""According to the latest treasury numbers from Councilor Werner, Rizia can fund both its internal programs and the military without going into the red.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will refrain from commenting out of turn, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Manus Sazon**
> ""I'm sorry. But I wanted you to get the full picture.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are relying on these companies to help win the war. To levy unfair taxes upon them would be to bite the hand that feeds us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Daria de Rava**
> ""Precisely, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That income they're making is blood money. If they have any sort of conscience, they won't want to keep it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Narrator**
> "Manus nodded. Next to me, Hugo spoke through gritted teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If our business owners truly support Rizia, they will do their part to keep the rest of the kingdom afloat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[122]`
Mówca: **Hugo Toras**
> ""Your Majesty, this tax would disproportionately affect House Azaro, as well as the de Ravas themselves. I don't think it's a good idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Daria de Rava**
> ""I do not dispute that fighting for our country requires sacrifice. But this particular one could severely hinder our chances of victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Daria de Rava**
> ""The full picture is that if we punish the companies responsible for our national defense, we will lose this war even worse than the last one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Narrator**
> "She turned to face me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Daria de Rava**
> ""The House of Delegates has already voted down this proposal by a high margin. We recommend that the King ignore it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[134]`
  - -> `[167]`
  - -> `[165]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sensible. No need for it to go any further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[128]`
Mówca: **Narrator**
> "She turned a page in her binder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[129]`
Mówca: **Daria de Rava**
> ""Certainly, Your Majesty. I'll make sure it reaches your desk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[130]`
Mówca: **Hugo Toras**
> ""Certainly, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[131]`
Mówca: **Daria de Rava**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[132]`
Mówca: **Manus Sazon**
> ""I had hoped you would at least allow it to reach your desk. But as you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[133]`
Mówca: **Manus Sazon**
> ""I had hoped it would go through some sort of legislative process. But good news regardless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Send it to me regardless. I will decide what to do with it later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[135]`
**[WYBÓR GRACZA: ""I'm afraid I have to go against your recommendation. Rizia will implement the war profits tax that the RPP proposed." [-3 Authority]"]** — Mówca: **Player_Romus**
> ""I'm afraid I have to go against your recommendation. Rizia will implement the war profits tax that the RPP proposed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very good. My Grand Vizier will make sure it crosses my desk. Won't you, Your Grace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need, Mr. Speaker. I have no interest in passing such a decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Narrator**
> "He frowned in consternation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why go through all that trouble? I'll sign the war profits tax decree immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Narrator**
> "He frowned in consternation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[141]`
Mówca: **Narrator**
> "Hugo lowered his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[142]`
Mówca: **Daria de Rava**
> ""I'm glad you're in agreement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[143]`
Mówca: **Narrator**
> "Daria frowned in consternation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[144]`
Mówca: **Narrator**
> "Daria frowned in consternation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[145]`
Mówca: **Daria de Rava**
> ""If we need funding, we can get it another way. The companies in question should be lauded for their contribution to the cause, not penalized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[146]`
Mówca: **Daria de Rava**
> ""And even if that wasn't the case, the companies in question should be lauded for their contribution to the cause, not penalized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Manus Sazon**
> ""You are misrepresenting our proposal, Madam Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Manus Sazon**
> ""It is an undeniable fact that war is a source of suffering for many and enormous financial windfalls for an elite few.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Manus Sazon**
> ""What we are proposing is a move towards equity. It is not fair that our military operation will put a strain on social welfare while fattening the pockets of weapons executives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[117]`
  - -> `[121]`
  - -> `[119]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Enable_Policy_RD_Economy_WarProfitsTax = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Enable_Policy_RD_Economy_WarProfitsTax"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnactDecree("Economy_Taxes_WarProfitsTax");
RiziaDLC.Resources_Authority += 3;)*
- **Efekt (`userScript`):** `EnactDecree("Economy_Taxes_WarProfitsTax");
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Narrator**
> "Manus turned a page in his binder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Enable_Policy_RD_Economy_WarProfitsTax = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Enable_Policy_RD_Economy_WarProfitsTax"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnactDecree("Economy_Taxes_WarProfitsTax");)*
- **Efekt (`userScript`):** `EnactDecree("Economy_Taxes_WarProfitsTax");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[158]`
Mówca: **Manus Sazon**
> ""The next item is an update on our progress with Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[159]`
Mówca: **Daria de Rava**
> ""The next item is an update on our progress with Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Authority >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Sazon, I am confident that our victory in Pales will be swift enough that such a measure will not be called for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Manus Sazon**
> ""I hope so as well. But I will send you the proposal in case you choose to enact it in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am confident that our victory in Pales will be swift enough that such a measure will not be called for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Daria de Rava**
> ""So am I, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Resources_Authority >= 3)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Resources_Authority >= 3))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 3) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[170]`
Mówca: **Manus Sazon**
> ""Ms. de Rava's party issued an official disproval of His Majesty's landowner and inheritance tax decrees. Her preferred solution, it seems, is to place the burden on those who can least afford it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
