# Rizia/Turn 10/DECLARATION/DECLARATION Conversation

- **ID konwersacji:** `545`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/545_DECLARATION_Conversation.md`
- **Liczba węzłów dialogowych:** 260
- **Liczba wyborów gracza:** 82

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[102]** Adarfo Sotelato

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BirthdayGathering_ViolentAction`
- `RiziaDLC.DLCAcronymMentioned`
- `RiziaDLC.Daria_PromisePrimeMinister`
- `RiziaDLC.HouseElections_RNCWinsSeats`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.Reform_Diplomatic`
- `RiziaDLC.Reform_Movement_Grows`
- `RiziaDLC.Reform_Movement_Leader_Adarfo`
- `RiziaDLC.Reform_Silent`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLCIsolated.Reform_Intention_PM_Daria`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Reform_PrimeMinister_Adarfo`
- `RiziaDLC.Reform_PrimeMinister_Daria`
- `RiziaDLC.Reform_PrimeMinister_Manus`
- `RiziaDLC.Said_GlovuriusAxaRizia`
- `RiziaDLCSupport.Journal_Turn10_ConstitutionSigned_Adarfo`
- `RiziaDLCSupport.Journal_Turn10_ConstitutionSigned_Daria`
- `RiziaDLCSupport.Journal_Turn10_ConstitutionSigned_Manus`
- `RiziaDLCSupport.News_Turn10_RH_NewConstitution_AdarfoPM`
- `RiziaDLCSupport.News_Turn10_RH_NewConstitution_DariaPM`
- `RiziaDLCSupport.News_Turn10_RH_NewConstitution_ManusPM`
- `RiziaDLCSupport.News_Turn10_V_NewConstitution_AdarfoPM`
- `RiziaDLCSupport.News_Turn10_V_NewConstitution_DariaPM`
- `RiziaDLCSupport.News_Turn10_V_NewConstitution_ManusPM`
- `RiziaDLCSupport.Reports_Turn10_Iza_ConstitutionCelebration_ManusPM`
- `RiziaDLCText.PrimeMinister`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[347] Rizia/Turn 10/Reform_ConstitutionSigning** (../Turn_10/347_Reform_ConstitutionSigning.md), Węzeł `[370]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 25

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[69]` (Paskal Beniwoll): `--;`
- Węzeł `[79]` (Paskal Beniwoll): `--;`
- Węzeł `[89]` (Paskal Beniwoll): `--;`
- Węzeł `[91]` (Paskal Beniwoll): `--;`
- Węzeł `[95]` (Paskal Beniwoll): `--;`
- Węzeł `[103]` (Paskal Beniwoll): `--;`
- Węzeł `[107]` (Paskal Beniwoll): `--;`
- Węzeł `[112]` (Paskal Beniwoll): `--;`
- *...oraz 17 innych węzłów ze skryptami.*

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
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `347` (*Rizia/Turn 10/Reform_ConstitutionSigning*), Węzeł `[370]`

### Węzeł `[3]`
Mówca: **Narrator**
> "In a few seconds, the convoy came to a graceful stop in front of the steps of the House. Titus held the door for me as I stepped out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[4]`
Mówca: **Narrator**
> "As I ascended the stairs, the doors swung open, revealing the bare-bones interior of the House. A chamber that my father was forced to form, now ready to script a new chapter with my support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[5]`
Mówca: **Narrator**
> "I stepped onto the podium as loud applause echoed around me, the faces of the delegates alight with the promise of the future."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[6]`
Mówca: **Narrator**
> "When the hall fell silent, I took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`
  - -> `[9]`
  - -> `[10]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My loyal subjects...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My esteemed countrymen and women...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My fellow citizens...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great people of Rizia...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[11]`
Mówca: **Narrator**
> "When I joined the crowd of people gathered inside the building, I was immediately greeted by Manus and Daria, who took me to the ministerial chambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Narrator**
> "Followed by security, we entered the room. The new constitution of Rizia had been laid out on a table in the center."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Narrator**
> "As we exchanged handshakes and formalities with each other, Manus leaned in and whispered in my ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[14]`
Mówca: **Manus Sazon**
> ""Not a word from the nobles. Seems like everything is going according to plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Silent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Silent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Silent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Silent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Silent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BirthdayGathering_ViolentAction == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BirthdayGathering_ViolentAction == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[21]`
Mówca: **Manus Sazon**
> ""Well... This is it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Narrator**
> "My aides guided me to the table, pulled out a chair for me and carried over a large leather box with golden etchings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Narrator**
> "After I was seated, two aides opened the box and held it out for me. Inside, a single pen was cushioned in red velvet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Narrator**
> "Journalists began snapping photos as soon as I grabbed the pen. Everyone looked at me in excitement as they waited for my signature."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[27]`
  - -> `[28]`
  - -> `[184]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "Sign the constitution without saying anything."]** — Mówca: **Player_Romus_Italic**
> "I signed the ridiculously large papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This delegation of legislative control -- this DLC -- has been a long time coming. I hope it lives up to all of your expectations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Today, we entrust our future to the hands of those elected to represent Rizia. It's a bold step, but one I believe is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You must understand it is very difficult for me to sign this and willingly transfer my powers away. It's a bold step, but one that must be taken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[29]`
Mówca: **Narrator**
> "The room broke into applause as I signed the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Narrator**
> "The room broke into applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Narrator**
> "That was it. With my signature, the new constitution was in place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Narrator**
> "After a long pause, I stood up. My next step was to declare the constitution in public and appoint Rizia's new head of government."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[33]`
Mówca: **Narrator**
> "I gave no thought to the significance of what I had just done. Instead, the simplicity of the process made me feel nervous -- as if I expected someone to have intervened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Intention_PM_Daria == true || RiziaDLC.HouseElections_RPPWinsSeats == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Intention_PM_Daria == true || RiziaDLC.HouseElections_RPPWinsSeats == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Intention_PM_Daria"] == true  or  Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Reform_Intention_PM_Daria == true || RiziaDLC.HouseElections_RPPWinsSeats == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Intention_PM_Daria"] == true  or  Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[37]`
Mówca: **Narrator**
> "Daria and Manus guided me through the corridors of the parliament towards the main hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Narrator**
> "Before we entered inside, the aides handed me a ceremonial silk sash with blue and golden stripes, to be presented to the first prime minister."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[39]`
Mówca: **Daria de Rava**
> ""I will not let you or the Kingdom down, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`
  - -> `[44]`
  - -> `[200]`

### Węzeł `[40]`
Mówca: **Manus Sazon**
> ""I will not let you down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[244]`
  - -> `[45]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, Ms. De Rava... I have decided to appoint Manus instead. I believe this is for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have my trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Romus_Italic**
> "I nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, Manus... I have decided to appoint Ms. Rava instead. I believe this is for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[49]`
Mówca: **Manus Sazon**
> ""What?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[53]`
Mówca: **Daria de Rava**
> ""What is the meaning of this? You can't do that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[54]`
Mówca: **Daria de Rava**
> ""I thought this constitution is supposed to reflect the will of the Rizian people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[55]`
Mówca: **Manus Sazon**
> ""When did you decide on that, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Manus Sazon**
> ""I wish my party had been included in that conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[59]`
  - -> `[60]`
  - -> `[197]`

### Węzeł `[57]`
Mówca: **Daria de Rava**
> ""I wish my party had been included in that conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`
  - -> `[65]`
  - -> `[67]`

### Węzeł `[58]`
Mówca: **Manus Sazon**
> ""This does not reflect the will of the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`
  - -> `[61]`
  - -> `[197]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've respected the will of the people enough today. As the monarch, I will appoint Daria as the prime minister. End of discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are about to enter the hall, Manus. Please keep your act down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Madam de Rava was an integral figure in passing these reforms. I promised her she would be rewarded, and I am keeping that promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've respected the will of the people enough today. As the monarch, I will appoint Manus as the prime minister. End of discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are about to enter the hall, Daria. Please keep your act down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. It still does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There was no conversation. As the monarch, I will appoint whoever I want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Narrator**
> "Suddenly, the aides opened the doors and we entered the hall. Massive cameras were filming us as we walked inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[74]`
  - -> `[78]`
  - -> `[254]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Today, we stand at the dawn of a new era in the history of our nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "Gesture for silence."]** — Mówca: **Player_Romus_Italic**
> "I gestured for silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "Wait for the applause to stop."]** — Mówca: **Player_Romus_Italic**
> "I stood there for a whole minute as the delegates applauded vigorously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is with a heart full of hope and a mind conscious of the demands of the democratic movement that I address you on this momentous occasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Grows == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Grows == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is with a heart full of hope and a mind conscious of the demands of a new constitution made by the people, that I address you on this momentous occasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Today, we reaffirm our unwavering commitment to the principles that are the bedrock of any great society—participation in politics, liberty, and the rule of law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`
  - -> `[83]`
  - -> `[85]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In the spirit of our timeless principles, I stand before you, not as a ruler, but as a fellow Rizian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[87]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On this historic day, we are reminded of the enduring legacy of our kingdom—a legacy rich in tradition and bound by the unbreakable spirit of these lands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[86]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe Rizia was in need of a constitution that reflects our collective aspirations for a just, equitable, and democratic society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Change, as we know, is the only constant in the march of time. It is the harbinger of progress, the catalyst for innovation, and the doorway to new possibilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[88]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Embracing change is not just an option; it is our imperative if we are to stride confidently into the future that beckons us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Throughout the ages, our beloved country has been guided by the steady hand of the monarchy, a lineage that has weathered the storms of time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[86]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yet, the very essence of our nation is not defined by the constancy of its rulers but by the indomitable spirit of its people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Because the very essence of our nation is not defined by the constancy of its rulers but by the indomitable spirit of its people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the very essence of our nation is not defined by the constancy of its rulers but by the indomitable spirit of its people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[84]`
  - -> `[90]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The world around us is changing. Nations are awakening to the clarion call of freedom and representation, recognizing that the true strength of a country lies in the collective will of its citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`
  - -> `[94]`
  - -> `[98]`

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is in this light that I, your monarch, have resolved to embrace the winds of change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Therefore, I decided to give my support to the democratic movement in drafting a new constitution for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With this in mind, we all must give a solemn pledge to ensure that the voice of every citizen is heard, and the rights of every individual are protected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By establishing a head of government and vesting legislative powers in this House, the people, we are not just reforming our governance. We are fixing it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[97]`
Mówca: **Narrator**
> "As soon as I said that, the aides brought the constitution and displayed it to the delegates, prompting more applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[99]`
  - -> `[100]`
  - -> `[102]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are gathered here, not to witness the diminishing of the crown, but to celebrate the empowerment of the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are establishing, for the first time in our history, the office of the Prime Minister, a head of government chosen from among the representatives of the people, to lead the executive branch with diligence and integrity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In embracing these reforms, I am mindful of the profound responsibility that comes with leadership -- the responsibility to put the welfare of the nation and its people above all else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[101]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is a responsibility that I embrace not with a sense of loss, but with the deepest sense of honor and purpose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I embrace this evolution, not as a departure from our cherished traditions, but as an affirmation of their enduring relevance. This constitution does not signify an end but a beginning -- a harmonious blending of the old and the new.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`
  - -> `[106]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This act of endorsing this constitution is about ensuring that the legacy we leave for future generations is one of a society that values dialogue over decree, consensus over command, and the common good over individual gain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This House will be the crucible in which the laws of our land are forged, ensuring that every statute reflects the collective will of the Rizian people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "In consenting to this constitution, I do not relinquish my love for this country; rather, I reaffirm my commitment to serve it and its people with every fiber of my being.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let the pages of history remember this day as the moment when we chose not just to change, but to evolve; not just to promise, but to deliver; not just to dream, but to achieve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As we chart this new course, let us be guided by the democratic principles that are now enshrined in our constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""At this moment, I am reminded that true leadership is not about wielding power; it is about empowering others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Honorable delegates, I now entrust my power to you, the elected voice of our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the power vested in me by tradition and lineage, I declare the Rizian Charter of Fundamental Law -- adopting a true constitutional monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hereby announce that the new constitution was signed and is currently in place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[115]`
Mówca: **Narrator**
> "I held up the silk sash for everyone to see."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`
  - -> `[118]`
  - -> `[119]`

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In this spirit of renewal and with the power vested in me, I hereby announce the appointment of the new head of government...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In accordance with the new constitution, I shall appoint a new head of government until the elections...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In appointing a new head of government, we turn a page in our history, embracing a governance of the people, by the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As for the first Prime Minister of Rizia... This individual is someone who embodies the principles we hold dear and possesses the vision to lead our nation into a promising future...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Narrator**
> "The room hung on my every word, the air thick with anticipation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[122]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appoint Manus Sazon as interim Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appoint Daria de Rava as interim Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[123]`
Mówca: **Narrator**
> "A murmur of disapproval rippled through the chamber as he made his way to the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RNCWinsSeats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RNCWinsSeats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RNCWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RNCWinsSeats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RNCWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[130]`
Mówca: **Narrator**
> "Manus rose from his seat among the delegates, his expression one of determination."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Intention_PM_Daria == false && RiziaDLC.Daria_PromisePrimeMinister == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Reform_Intention_PM_Daria == false && RiziaDLC.Daria_PromisePrimeMinister == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Intention_PM_Daria"] == false  and  Variable["RiziaDLC.Daria_PromisePrimeMinister"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Reform_Intention_PM_Daria == false && RiziaDLC.Daria_PromisePrimeMinister == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Intention_PM_Daria"] == false  and  Variable["RiziaDLC.Daria_PromisePrimeMinister"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Narrator**
> "Daria rose from her seat among the delegates, her expression one of surprise and excitement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[135]`
Mówca: **Narrator**
> "Daria rose from her seat among the delegates, her expression one of confidence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[136]`
Mówca: **Narrator**
> "A murmur of disapproval rippled through the chamber as she made her way to the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[137]`
Mówca: **Narrator**
> "A murmur of approval rippled through the chamber as he made his way to the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.HouseElections_RPPWinsSeats == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.HouseElections_RPPWinsSeats == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[141]`
Mówca: **Narrator**
> "A murmur of approval rippled through the chamber as she made her way to the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[143]`
  - -> `[144]`
  - -> `[145]`

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To the future -- a future that we will build together, on the solid foundation of this new charter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God bless Rizia, and long live the Kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May the bonds that unite us as a people grow ever stronger, and may our nation flourish under the guiding principles of this new constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glovurius axa Rizia!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[147]`
Mówca: **Narrator**
> "I put the sash and the pin on him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[148]`
Mówca: **Narrator**
> "I put the sash and the pin on her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Daria de Rava**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[150]`
Mówca: **Manus Sazon**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[151]`
Mówca: **Narrator**
> "Another round of applause broke out -- this time for much longer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[155]`

### Węzeł `[152]`
**[WYBÓR GRACZA: "Stay next to him."]** — Mówca: **Player_Romus_Italic**
> "I stood next to him as the applause subsided."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[153]`
Mówca: **Narrator**
> "Another round of applause broke out -- this time for much longer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[156]`

### Węzeł `[154]`
**[WYBÓR GRACZA: "Stay next to her."]** — Mówca: **Player_Romus_Italic**
> "I stood next to her as the applause subsided."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[155]`
**[WYBÓR GRACZA: "Take a step back."]** — Mówca: **Player_Romus_Italic**
> "I took a step back, allowing him to take center stage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[156]`
**[WYBÓR GRACZA: "Take a step back."]** — Mówca: **Player_Romus_Italic**
> "I took a step back, allowing her to take center stage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[157]`
Mówca: **Manus Sazon**
> ""Your Majesty, delegates, and fellow citizens, I am deeply honored by the trust placed in me. This is a momentous day for democracy and liberty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Manus Sazon**
> ""I am proud to have represented the democratic movement to this day, and I am overjoyed to see such a transfer of power finally take place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Manus Sazon**
> ""Our path forward will be built on dialogue, on the collective wisdom of this assembly, and on the aspirations of our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[160]`
Mówca: **Daria de Rava**
> ""Your Majesty, delegates, and fellow citizens, I am deeply honored by the trust placed in me. This is a momentous day, not only for me, but for our great kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Daria de Rava**
> ""Together, we will embark on a journey of transformation, grounded in the principles of tradition, equity, and prosperity for all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Daria de Rava**
> ""We will face challenges, no doubt, but in our unity, we will find strength.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Manus = true;
RiziaDLCSupport.News_Turn10_RH_NewConstitution_ManusPM = true;
RiziaDLCSupport.News_Turn10_V_NewConstitution_ManusPM = true;
RiziaDLCSupport.Reports_Turn10_Iza_ConstitutionCelebration_ManusPM = true;
RiziaDLCSupport.Journal_Turn10_ConstitutionSigned_Manus = true;
RiziaDLCText.PrimeMinister = "Manus Sazon")*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] = true;
Variable["RiziaDLCSupport.News_Turn10_RH_NewConstitution_ManusPM"] = true;
Variable["RiziaDLCSupport.News_Turn10_V_NewConstitution_ManusPM"] = true;
Variable["RiziaDLCSupport.Reports_Turn10_Iza_ConstitutionCelebration_ManusPM"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_ConstitutionSigned_Manus"] = true;
Variable["RiziaDLCText.PrimeMinister"] ="Manus Sazon";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Daria = true;
RiziaDLCSupport.News_Turn10_RH_NewConstitution_DariaPM = true;
RiziaDLCSupport.News_Turn10_V_NewConstitution_DariaPM = true;
RiziaDLCSupport.Journal_Turn10_ConstitutionSigned_Daria = true;
RiziaDLCText.PrimeMinister = "Daria De Rava")*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] = true;
Variable["RiziaDLCSupport.News_Turn10_RH_NewConstitution_DariaPM"] = true;
Variable["RiziaDLCSupport.News_Turn10_V_NewConstitution_DariaPM"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_ConstitutionSigned_Daria"] = true;
Variable["RiziaDLCText.PrimeMinister"] ="Daria De Rava";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[165]`
Mówca: **Narrator**
> "The delegates rose in a standing ovation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Narrator**
> "The delegates rose in a standing ovation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[167]`
Mówca: **Manus Sazon**
> ""I promise to represent the interests of the Rizian people -- regardless of their economic or cultural backgrounds and uphold the Rizian Charter of Fundamental Law during my tenure as Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Manus Sazon**
> ""I swear that I will serve my duty with diligence until the upcoming elections, when Rizia will finally elect their own government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[169]`
Mówca: **Daria de Rava**
> ""I promise to represent the interests of the Rizian people and uphold the Rizian Charter of Fundamental Law during my tenure as Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Daria de Rava**
> ""I swear that I will serve my duty to the Crown with diligence until the upcoming elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Daria de Rava**
> ""Thank you. Glovurius axa Rizia!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Manus Sazon**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Narrator**
> "After taking the applause in, together, we walked towards the balcony to face the crowd that had gathered outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Narrator**
> "It was done. My signature, the House approval and now a broadcast declaration. It was a point of no return."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion"))*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Manus Sazon");
AddConversant("Daria de Rava");)*
- **Efekt (`userScript`):** `AddConversant("Manus Sazon");
AddConversant("Daria de Rava");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Manus Sazon");
RemoveConversant("Daria de Rava");
RemoveConversant("Adarfo Sotelato");)*
- **Efekt (`userScript`):** `RemoveConversant("Manus Sazon");
RemoveConversant("Daria de Rava");
RemoveConversant("Adarfo Sotelato");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Daria de Rava");)*
- **Efekt (`userScript`):** `AddConversant("Daria de Rava");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Manus Sazon");)*
- **Efekt (`userScript`):** `AddConversant("Manus Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_MarriageDecision_Manus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_MarriageDecision_Manus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`
  - -> `[65]`
  - -> `[66]`

### Węzeł `[183]`
Mówca: **Daria de Rava**
> ""What you're doing is nepotism. Pure and simple.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`
  - -> `[65]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DLCAcronymMentioned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.DLCAcronymMentioned == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.DLCAcronymMentioned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.DLCAcronymMentioned == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.DLCAcronymMentioned"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_FallingIntoPlace", "R_FallingIntoPlace_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_FallingIntoPlace","R_FallingIntoPlace_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("CheerCrowd");)*
- **Efekt (`userScript`):** `PlaySoundEffect("CheerCrowd");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("CheerCrowd");)*
- **Efekt (`userScript`):** `PlaySoundEffect("CheerCrowd");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("SignAndApplause");)*
- **Efekt (`userScript`):** `PlaySoundEffect("SignAndApplause");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_FallingIntoPlace", "R_FallingIntoPlace_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_FallingIntoPlace","R_FallingIntoPlace_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("SignAndApplause");)*
- **Efekt (`userScript`):** `PlaySoundEffect("SignAndApplause");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_GlovuriusAxaRizia += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["RiziaDLC.Said_GlovuriusAxaRizia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Daria_PromisePrimeMinister == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Daria_PromisePrimeMinister == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[43]`
  - -> `[44]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Daria_PromisePrimeMinister == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Daria_PromisePrimeMinister == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Daria_PromisePrimeMinister == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Daria_PromisePrimeMinister"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Daria_PromisePrimeMinister == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Daria_PromisePrimeMinister"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[200]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Daria_PromisePrimeMinister == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Daria_PromisePrimeMinister == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Daria_PromisePrimeMinister == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Adarfo Sotelato");)*
- **Efekt (`userScript`):** `AddConversant("Adarfo Sotelato");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Narrator**
> "When I joined the crowd of people gathered inside the building, I was immediately greeted by Adarfo Sotelato, who took me to the ministerial chambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Narrator**
> "Followed by security, we entered the room. The new constitution of Rizia had been laid out on a table in the center."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Narrator**
> "As we exchanged handshakes and formalities with each other, Adarfo leaned in and whispered in my ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Adarfo Sotelato**
> ""Glad you made it. I half-expected you to backtrack at the last minute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[214]`
Mówca: **Narrator**
> "Adarfo guided me through the corridors of the parliament towards the main hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Narrator**
> "Before we entered inside, the aides handed me a ceremonial silk sash with blue and golden stripes, to be presented to the first prime minister."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Narrator**
> "Adarfo quickly snatched the sash from me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Adarfo Sotelato**
> ""I'll have that, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Narrator**
> "Suddenly, he rushed towards the doors and entered the hall without waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`
  - -> `[227]`

### Węzeł `[219]`
Mówca: **Narrator**
> "He immediately stepped onto the podium and displayed his ceremonial sash as massive cameras filmed him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[220]`
**[WYBÓR GRACZA: "Watch him speak."]** — Mówca: **Player_Romus_Italic**
> "I decided to let it be and positioned myself by the side of the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[221]`
**[WYBÓR GRACZA: "Follow him to the podium."]** — Mówca: **Player_Romus_Italic**
> "When I started walking in the direction of the podium, several men grabbed my arms and stopped me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[222]`
  - -> `[228]`
  - -> `[229]`

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unhand me! I am your King!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[223]`
Mówca: **Adarfo Sotelato**
> ""I hereby announce that His Majesty, King Romus Toras, has signed the Constitution and appointed me as the Prime Minister of Rizia!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`

### Węzeł `[224]`
Mówca: **Adarfo Sotelato**
> ""Ladies and gentlemen!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What the hell?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Sotelato! I have yet to officially appoint you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[227]`
**[WYBÓR GRACZA: "Follow him."]** — Mówca: **Player_Romus_Italic**
> "I followed behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think you're doing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let me go immediately and I'll forget this happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[230]`
**[WYBÓR GRACZA: "Don't resist."]** — Mówca: **Player_Romus_Italic**
> "I did not resist them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Narrator**
> "Suddenly, the hall broke into massive applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Adarfo Sotelato**
> ""Today, we stand at the dawn of a new era in the history of our nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[233]`
Mówca: **Adarfo Sotelato**
> ""I am deeply honored by the trust placed in me in overseeing this revolutionary change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[234]`
Mówca: **Adarfo Sotelato**
> ""I am proud to have represented the common people of Rizia, and I am overjoyed to see such a transfer of power finally take place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Adarfo Sotelato**
> ""Our path forward will be built on great transformations and reversal of historical injustices, all for the benefit of the Rizian people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Narrator**
> "The RPP delegates rose in a standing ovation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Adarfo Sotelato**
> ""I promise to fight for the interests of the Rizian working class, and uphold the Rizian Charter of Fundamental Law during my tenure as Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Adarfo Sotelato**
> ""I swear that I will serve my duty with diligence until the upcoming elections, when the citizens of Rizia will finally elect their own government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[239]`
Mówca: **Adarfo Sotelato**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[240]`
Mówca: **Adarfo Sotelato**
> ""According to this new constitution, the nobility will no longer have any power nor privilege over the governance of this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_PrimeMinister_Adarfo = true;
RiziaDLCText.PrimeMinister = "Adarfo Sotelato";
RiziaDLCSupport.News_Turn10_RH_NewConstitution_AdarfoPM = true;
RiziaDLCSupport.News_Turn10_V_NewConstitution_AdarfoPM = true;
RiziaDLCSupport.Journal_Turn10_ConstitutionSigned_Adarfo = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] = true;
Variable["RiziaDLCText.PrimeMinister"] ="Adarfo Sotelato";
Variable["RiziaDLCSupport.News_Turn10_RH_NewConstitution_AdarfoPM"] = true;
Variable["RiziaDLCSupport.News_Turn10_V_NewConstitution_AdarfoPM"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_ConstitutionSigned_Adarfo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[242]`
Mówca: **Manus Sazon**
> ""This is it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Manus Sazon**
> ""I hope everything was worth it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Circumstances have changed, Mr. Sazon. The only way to pass these reforms was to guarantee Baroness De Rava the position of Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Diplomatic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Diplomatic == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Diplomatic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Diplomatic == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Diplomatic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Narrator**
> "I stepped onto the podium as the RPP delegates burst into applause. Those from the RNC were pointedly silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Silent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Silent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Silent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Silent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Silent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[252]`
Mówca: **Narrator**
> "I stepped onto the podium to a round of applause from the delegates. Some appeared hopeful for the future; others wore fearful expressions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[253]`

### Węzeł `[253]`
**[WYBÓR GRACZA: "Wait for the applause to stop."]** — Mówca: **Player_Romus_Italic**
> "I stood there for a few seconds as the applause died down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This speech is not mine to give. Having signed away my powers as monarch, I will now yield the floor to Rizia's new head of government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[255]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Daria_PromisePrimeMinister == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Daria_PromisePrimeMinister == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Daria_PromisePrimeMinister == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Reform Speech Skipped)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Reform Speech Skipped])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`
