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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **""My loyal subjects...""** | `[6]` **Narrator**: "When the hall fell silent, I too..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[70]` **Player_Romus**: ""Today, we stand at the dawn of ..."<br>`[78]` **Player_Romus**: ""Today, we reaffirm our unwaveri..."<br>*(oraz 3 innych odgałęzień)* |
| `[8]` | **""My esteemed countrymen and women...""** | `[6]` **Narrator**: "When the hall fell silent, I too..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[70]` **Player_Romus**: ""Today, we stand at the dawn of ..."<br>`[78]` **Player_Romus**: ""Today, we reaffirm our unwaveri..."<br>*(oraz 3 innych odgałęzień)* |
| `[9]` | **""My fellow citizens...""** | `[6]` **Narrator**: "When the hall fell silent, I too..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[70]` **Player_Romus**: ""Today, we stand at the dawn of ..."<br>`[78]` **Player_Romus**: ""Today, we reaffirm our unwaveri..."<br>*(oraz 3 innych odgałęzień)* |
| `[10]` | **""Great people of Rizia...""** | `[6]` **Narrator**: "When the hall fell silent, I too..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[70]` **Player_Romus**: ""Today, we stand at the dawn of ..."<br>`[78]` **Player_Romus**: ""Today, we reaffirm our unwaveri..."<br>*(oraz 3 innych odgałęzień)* |
| `[25]` | **"Sign the constitution without saying anything."** | `[24]` **Narrator**: "Journalists began snapping photo..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("SignAndApplause");`<br>`PlayLoopedMusic("R_FallingIntoPlace","R_FallingIntoPlace_...` | `[30]` **Narrator**: "The room broke into applause." |
| `[26]` | **""This delegation of legislative control -- this DLC -- has been a long time coming..."** | `[24]` **Narrator**: "Journalists began snapping photo..." | `Variable["RiziaDLC.DLCAcronymMentioned"] == true` | `PlaySoundEffect("SignAndApplause");`<br>`PlayLoopedMusic("R_FallingIntoPlace","R_FallingIntoPlace_...` | `[29]` **Narrator**: "The room broke into applause as ..." |
| `[27]` | **""Today, we entrust our future to the hands of those elected to represent Rizia. It..."** | `[24]` **Narrator**: "Journalists began snapping photo..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("SignAndApplause");`<br>`PlayLoopedMusic("R_FallingIntoPlace","R_FallingIntoPlace_...` | `[29]` **Narrator**: "The room broke into applause as ..." |
| `[28]` | **""You must understand it is very difficult for me to sign this and willingly transf..."** | `[24]` **Narrator**: "Journalists began snapping photo..." | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("SignAndApplause");`<br>`PlayLoopedMusic("R_FallingIntoPlace","R_FallingIntoPlace_...` | `[29]` **Narrator**: "The room broke into applause as ..." |
| `[41]` | **""Actually, Ms. De Rava... I have decided to appoint Manus instead. I believe this ..."** | `[39]` **Daria de Rava**: ""I will not let you or the Kingd..." | `Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false` | *Brak zmian stanu* | `[53]` **Daria de Rava**: ""What is the meaning of this? Yo..." |
| `[42]` | **""I hope so.""** | `[39]` **Daria de Rava**: ""I will not let you or the Kingd..."<br>`[40]` **Manus Sazon**: ""I will not let you down."" | `Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false` | *Brak zmian stanu* | `[68]` **Narrator**: "Suddenly, the aides opened the d..." |
| `[43]` | **""You have my trust.""** | `[39]` **Daria de Rava**: ""I will not let you or the Kingd..."<br>`[40]` **Manus Sazon**: ""I will not let you down."" | `Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false` | *Brak zmian stanu* | `[68]` **Narrator**: "Suddenly, the aides opened the d..." |
| `[44]` | **"Nod."** | `[39]` **Daria de Rava**: ""I will not let you or the Kingd..."<br>`[40]` **Manus Sazon**: ""I will not let you down."" | `Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false` | *Brak zmian stanu* | `[68]` **Narrator**: "Suddenly, the aides opened the d..." |
| `[45]` | **""Actually, Manus... I have decided to appoint Ms. Rava instead. I believe this is ..."** | `[40]` **Manus Sazon**: ""I will not let you down."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Manus Sazon**: ""What?""<br>`[55]` **Manus Sazon**: ""When did you decide on that, Yo..." |
| `[59]` | **""I've respected the will of the people enough today. As the monarch, I will appoin..."** | `[56]` **Manus Sazon**: ""I wish my party had been includ..."<br>`[58]` **Manus Sazon**: ""This does not reflect the will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Narrator**: "Suddenly, the aides opened the d..." |
| `[60]` | **""We are about to enter the hall, Manus. Please keep your act down.""** | `[56]` **Manus Sazon**: ""I wish my party had been includ..."<br>`[58]` **Manus Sazon**: ""This does not reflect the will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Narrator**: "Suddenly, the aides opened the d..." |
| `[61]` | **""I'm sorry.""** | `[58]` **Manus Sazon**: ""This does not reflect the will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Narrator**: "Suddenly, the aides opened the d..." |
| `[62]` | **""Madam de Rava was an integral figure in passing these reforms. I promised her she..."** | `[56]` **Manus Sazon**: ""I wish my party had been includ..."<br>`[58]` **Manus Sazon**: ""This does not reflect the will ..." | `Variable["RiziaDLC.Daria_PromisePrimeMinister"] == true` | *Brak zmian stanu* | `[68]` **Narrator**: "Suddenly, the aides opened the d..." |
| `[63]` | **""I've respected the will of the people enough today. As the monarch, I will appoin..."** | `[57]` **Daria de Rava**: ""I wish my party had been includ..."<br>`[183]` **Daria de Rava**: ""What you're doing is nepotism. ..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false` | *Brak zmian stanu* | `[68]` **Narrator**: "Suddenly, the aides opened the d..." |
| `[64]` | **""We are about to enter the hall, Daria. Please keep your act down.""** | `[57]` **Daria de Rava**: ""I wish my party had been includ..."<br>`[183]` **Daria de Rava**: ""What you're doing is nepotism. ..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false` | *Brak zmian stanu* | `[68]` **Narrator**: "Suddenly, the aides opened the d..." |
| `[65]` | **""I'm sorry.""** | `[57]` **Daria de Rava**: ""I wish my party had been includ..."<br>`[183]` **Daria de Rava**: ""What you're doing is nepotism. ..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false` | *Brak zmian stanu* | `[68]` **Narrator**: "Suddenly, the aides opened the d..." |
| `[66]` | **""Don't worry. It still does.""** | `[54]` **Daria de Rava**: ""I thought this constitution is ..." | `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false` | *Brak zmian stanu* | `[68]` **Narrator**: "Suddenly, the aides opened the d..." |
| `[67]` | **""There was no conversation. As the monarch, I will appoint whoever I want.""** | `[56]` **Manus Sazon**: ""I wish my party had been includ..."<br>`[57]` **Daria de Rava**: ""I wish my party had been includ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Narrator**: "Suddenly, the aides opened the d..." |
| `[70]` | **""Today, we stand at the dawn of a new era in the history of our nation.""** | `[7]` **Player_Romus**: ""My loyal subjects...""<br>`[8]` **Player_Romus**: ""My esteemed countrymen and wome..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[80]` **Player_Romus**: ""In the spirit of our timeless p..."<br>`[81]` **Player_Romus**: ""On this historic day, we are re..."<br>*(oraz 2 innych odgałęzień)* |
| `[71]` | **"Gesture for silence."** | `[5]` **Narrator**: "I stepped onto the podium as lou..."<br>`[248]` **Narrator**: "I stepped onto the podium as the..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Narrator**: "When the hall fell silent, I too..." |
| `[72]` | **"Wait for the applause to stop."** | `[5]` **Narrator**: "I stepped onto the podium as lou..."<br>`[248]` **Narrator**: "I stepped onto the podium as the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Narrator**: "When the hall fell silent, I too..." |
| `[73]` | **""It is with a heart full of hope and a mind conscious of the demands of the democr..."** | `[7]` **Player_Romus**: ""My loyal subjects...""<br>`[8]` **Player_Romus**: ""My esteemed countrymen and wome..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false` | `--;` | `[80]` **Player_Romus**: ""In the spirit of our timeless p..."<br>`[81]` **Player_Romus**: ""On this historic day, we are re..."<br>*(oraz 2 innych odgałęzień)* |
| `[77]` | **""It is with a heart full of hope and a mind conscious of the demands of a new cons..."** | `[7]` **Player_Romus**: ""My loyal subjects...""<br>`[8]` **Player_Romus**: ""My esteemed countrymen and wome..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Reform_Movement_Grows"] == true` | `--;` | `[80]` **Player_Romus**: ""In the spirit of our timeless p..."<br>`[81]` **Player_Romus**: ""On this historic day, we are re..."<br>*(oraz 2 innych odgałęzień)* |
| `[78]` | **""Today, we reaffirm our unwavering commitment to the principles that are the bedro..."** | `[7]` **Player_Romus**: ""My loyal subjects...""<br>`[8]` **Player_Romus**: ""My esteemed countrymen and wome..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[80]` **Player_Romus**: ""In the spirit of our timeless p..."<br>`[81]` **Player_Romus**: ""On this historic day, we are re..."<br>*(oraz 2 innych odgałęzień)* |
| `[80]` | **""In the spirit of our timeless principles, I stand before you, not as a ruler, but..."** | `[70]` **Player_Romus**: ""Today, we stand at the dawn of ..."<br>`[73]` **Player_Romus**: ""It is with a heart full of hope..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[87]` **Player_Romus**: ""Because the very essence of our..."<br>`[82]` **Player_Romus**: ""I believe Rizia was in need of ..."<br>*(oraz 2 innych odgałęzień)* |
| `[81]` | **""On this historic day, we are reminded of the enduring legacy of our kingdom—a leg..."** | `[70]` **Player_Romus**: ""Today, we stand at the dawn of ..."<br>`[73]` **Player_Romus**: ""It is with a heart full of hope..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[86]` **Player_Romus**: ""Yet, the very essence of our na..."<br>`[82]` **Player_Romus**: ""I believe Rizia was in need of ..."<br>*(oraz 2 innych odgałęzień)* |
| `[82]` | **""I believe Rizia was in need of a constitution that reflects our collective aspira..."** | `[80]` **Player_Romus**: ""In the spirit of our timeless p..."<br>`[81]` **Player_Romus**: ""On this historic day, we are re..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[92]` **Player_Romus**: ""It is in this light that I, you..."<br>`[93]` **Player_Romus**: ""Therefore, I decided to give my..."<br>*(oraz 2 innych odgałęzień)* |
| `[83]` | **""Change, as we know, is the only constant in the march of time. It is the harbinge..."** | `[70]` **Player_Romus**: ""Today, we stand at the dawn of ..."<br>`[73]` **Player_Romus**: ""It is with a heart full of hope..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[88]` **Player_Romus**: ""And the very essence of our nat..."<br>`[82]` **Player_Romus**: ""I believe Rizia was in need of ..."<br>*(oraz 2 innych odgałęzień)* |
| `[84]` | **""Embracing change is not just an option; it is our imperative if we are to stride ..."** | `[80]` **Player_Romus**: ""In the spirit of our timeless p..."<br>`[81]` **Player_Romus**: ""On this historic day, we are re..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[92]` **Player_Romus**: ""It is in this light that I, you..."<br>`[93]` **Player_Romus**: ""Therefore, I decided to give my..."<br>*(oraz 2 innych odgałęzień)* |
| `[85]` | **""Throughout the ages, our beloved country has been guided by the steady hand of th..."** | `[70]` **Player_Romus**: ""Today, we stand at the dawn of ..."<br>`[73]` **Player_Romus**: ""It is with a heart full of hope..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[86]` **Player_Romus**: ""Yet, the very essence of our na..."<br>`[82]` **Player_Romus**: ""I believe Rizia was in need of ..."<br>*(oraz 2 innych odgałęzień)* |
| `[86]` | **""Yet, the very essence of our nation is not defined by the constancy of its rulers..."** | `[81]` **Player_Romus**: ""On this historic day, we are re..."<br>`[85]` **Player_Romus**: ""Throughout the ages, our belove..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[92]` **Player_Romus**: ""It is in this light that I, you..."<br>`[93]` **Player_Romus**: ""Therefore, I decided to give my..."<br>*(oraz 2 innych odgałęzień)* |
| `[87]` | **""Because the very essence of our nation is not defined by the constancy of its rul..."** | `[80]` **Player_Romus**: ""In the spirit of our timeless p..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[92]` **Player_Romus**: ""It is in this light that I, you..."<br>`[93]` **Player_Romus**: ""Therefore, I decided to give my..."<br>*(oraz 2 innych odgałęzień)* |
| `[88]` | **""And the very essence of our nation is not defined by the constancy of its rulers ..."** | `[83]` **Player_Romus**: ""Change, as we know, is the only..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[92]` **Player_Romus**: ""It is in this light that I, you..."<br>`[93]` **Player_Romus**: ""Therefore, I decided to give my..."<br>*(oraz 2 innych odgałęzień)* |
| `[90]` | **""The world around us is changing. Nations are awakening to the clarion call of fre..."** | `[80]` **Player_Romus**: ""In the spirit of our timeless p..."<br>`[81]` **Player_Romus**: ""On this historic day, we are re..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[92]` **Player_Romus**: ""It is in this light that I, you..."<br>`[93]` **Player_Romus**: ""Therefore, I decided to give my..."<br>*(oraz 2 innych odgałęzień)* |
| `[92]` | **""It is in this light that I, your monarch, have resolved to embrace the winds of c..."** | `[82]` **Player_Romus**: ""I believe Rizia was in need of ..."<br>`[84]` **Player_Romus**: ""Embracing change is not just an..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[97]` **Narrator**: "As soon as I said that, the aide..." |
| `[93]` | **""Therefore, I decided to give my support to the democratic movement in drafting a ..."** | `[82]` **Player_Romus**: ""I believe Rizia was in need of ..."<br>`[84]` **Player_Romus**: ""Embracing change is not just an..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[97]` **Narrator**: "As soon as I said that, the aide..." |
| `[94]` | **""With this in mind, we all must give a solemn pledge to ensure that the voice of e..."** | `[82]` **Player_Romus**: ""I believe Rizia was in need of ..."<br>`[84]` **Player_Romus**: ""Embracing change is not just an..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[97]` **Narrator**: "As soon as I said that, the aide..." |
| `[96]` | **""By establishing a head of government and vesting legislative powers in this House..."** | `[97]` **Narrator**: "As soon as I said that, the aide..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[104]` **Player_Romus**: ""This act of endorsing this cons..."<br>`[105]` **Player_Romus**: ""This House will be the crucible..."<br>*(oraz 1 innych odgałęzień)* |
| `[98]` | **""We are gathered here, not to witness the diminishing of the crown, but to celebra..."** | `[82]` **Player_Romus**: ""I believe Rizia was in need of ..."<br>`[84]` **Player_Romus**: ""Embracing change is not just an..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[97]` **Narrator**: "As soon as I said that, the aide..." |
| `[99]` | **""We are establishing, for the first time in our history, the office of the Prime M..."** | `[97]` **Narrator**: "As soon as I said that, the aide..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[104]` **Player_Romus**: ""This act of endorsing this cons..."<br>`[105]` **Player_Romus**: ""This House will be the crucible..."<br>*(oraz 1 innych odgałęzień)* |
| `[100]` | **""In embracing these reforms, I am mindful of the profound responsibility that come..."** | `[97]` **Narrator**: "As soon as I said that, the aide..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[101]` **Player_Romus**: ""It is a responsibility that I e..."<br>`[104]` **Player_Romus**: ""This act of endorsing this cons..."<br>*(oraz 2 innych odgałęzień)* |
| `[101]` | **""It is a responsibility that I embrace not with a sense of loss, but with the deep..."** | `[100]` **Player_Romus**: ""In embracing these reforms, I a..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[110]` **Player_Romus**: ""At this moment, I am reminded t..."<br>`[108]` **Player_Romus**: ""Let the pages of history rememb..."<br>*(oraz 1 innych odgałęzień)* |
| `[102]` | **""I embrace this evolution, not as a departure from our cherished traditions, but a..."** | `[97]` **Narrator**: "As soon as I said that, the aide..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[104]` **Player_Romus**: ""This act of endorsing this cons..."<br>`[105]` **Player_Romus**: ""This House will be the crucible..."<br>*(oraz 1 innych odgałęzień)* |
| `[104]` | **""This act of endorsing this constitution is about ensuring that the legacy we leav..."** | `[96]` **Player_Romus**: ""By establishing a head of gover..."<br>`[99]` **Player_Romus**: ""We are establishing, for the fi..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[110]` **Player_Romus**: ""At this moment, I am reminded t..."<br>`[108]` **Player_Romus**: ""Let the pages of history rememb..."<br>*(oraz 1 innych odgałęzień)* |
| `[105]` | **""This House will be the crucible in which the laws of our land are forged, ensurin..."** | `[96]` **Player_Romus**: ""By establishing a head of gover..."<br>`[99]` **Player_Romus**: ""We are establishing, for the fi..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[110]` **Player_Romus**: ""At this moment, I am reminded t..."<br>`[108]` **Player_Romus**: ""Let the pages of history rememb..."<br>*(oraz 1 innych odgałęzień)* |
| `[106]` | **"In consenting to this constitution, I do not relinquish my love for this country; ..."** | `[96]` **Player_Romus**: ""By establishing a head of gover..."<br>`[99]` **Player_Romus**: ""We are establishing, for the fi..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[110]` **Player_Romus**: ""At this moment, I am reminded t..."<br>`[108]` **Player_Romus**: ""Let the pages of history rememb..."<br>*(oraz 1 innych odgałęzień)* |
| `[108]` | **""Let the pages of history remember this day as the moment when we chose not just t..."** | `[101]` **Player_Romus**: ""It is a responsibility that I e..."<br>`[104]` **Player_Romus**: ""This act of endorsing this cons..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[111]` **Player_Romus**: ""Honorable delegates, I now entr..."<br>`[113]` **Player_Romus**: ""With the power vested in me by ..."<br>*(oraz 1 innych odgałęzień)* |
| `[109]` | **""As we chart this new course, let us be guided by the democratic principles that a..."** | `[101]` **Player_Romus**: ""It is a responsibility that I e..."<br>`[104]` **Player_Romus**: ""This act of endorsing this cons..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[111]` **Player_Romus**: ""Honorable delegates, I now entr..."<br>`[113]` **Player_Romus**: ""With the power vested in me by ..."<br>*(oraz 1 innych odgałęzień)* |
| `[110]` | **""At this moment, I am reminded that true leadership is not about wielding power; i..."** | `[101]` **Player_Romus**: ""It is a responsibility that I e..."<br>`[104]` **Player_Romus**: ""This act of endorsing this cons..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[111]` **Player_Romus**: ""Honorable delegates, I now entr..."<br>`[113]` **Player_Romus**: ""With the power vested in me by ..."<br>*(oraz 1 innych odgałęzień)* |
| `[111]` | **""Honorable delegates, I now entrust my power to you, the elected voice of our peop..."** | `[108]` **Player_Romus**: ""Let the pages of history rememb..."<br>`[109]` **Player_Romus**: ""As we chart this new course, le..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[146]` **Player_Romus**: ""Glovurius axa Rizia!""<br>`[143]` **Player_Romus**: ""To the future -- a future that ..."<br>*(oraz 2 innych odgałęzień)* |
| `[113]` | **""With the power vested in me by tradition and lineage, I declare the Rizian Charte..."** | `[108]` **Player_Romus**: ""Let the pages of history rememb..."<br>`[109]` **Player_Romus**: ""As we chart this new course, le..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[146]` **Player_Romus**: ""Glovurius axa Rizia!""<br>`[143]` **Player_Romus**: ""To the future -- a future that ..."<br>*(oraz 2 innych odgałęzień)* |
| `[114]` | **""I hereby announce that the new constitution was signed and is currently in place.""** | `[108]` **Player_Romus**: ""Let the pages of history rememb..."<br>`[109]` **Player_Romus**: ""As we chart this new course, le..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `--;` | `[146]` **Player_Romus**: ""Glovurius axa Rizia!""<br>`[143]` **Player_Romus**: ""To the future -- a future that ..."<br>*(oraz 2 innych odgałęzień)* |
| `[116]` | **""In this spirit of renewal and with the power vested in me, I hereby announce the ..."** | `[115]` **Narrator**: "I held up the silk sash for ever..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Narrator**: "The room hung on my every word, ..." |
| `[117]` | **""In accordance with the new constitution, I shall appoint a new head of government..."** | `[115]` **Narrator**: "I held up the silk sash for ever..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Narrator**: "The room hung on my every word, ..." |
| `[118]` | **""In appointing a new head of government, we turn a page in our history, embracing ..."** | `[115]` **Narrator**: "I held up the silk sash for ever..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Narrator**: "The room hung on my every word, ..." |
| `[119]` | **""As for the first Prime Minister of Rizia... This individual is someone who embodi..."** | `[115]` **Narrator**: "I held up the silk sash for ever..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Narrator**: "The room hung on my every word, ..." |
| `[121]` | **""I appoint Manus Sazon as interim Prime Minister.""** | `[120]` **Narrator**: "The room hung on my every word, ..." | `Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false` | `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] = true; V...` | `[130]` **Narrator**: "Manus rose from his seat among t..." |
| `[122]` | **""I appoint Daria de Rava as interim Prime Minister.""** | `[120]` **Narrator**: "The room hung on my every word, ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] = true; V...` | `[134]` **Narrator**: "Daria rose from her seat among t..."<br>`[135]` **Narrator**: "Daria rose from her seat among t..." |
| `[143]` | **""To the future -- a future that we will build together, on the solid foundation of..."** | `[111]` **Player_Romus**: ""Honorable delegates, I now entr..."<br>`[113]` **Player_Romus**: ""With the power vested in me by ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Narrator**: "I held up the silk sash for ever..." |
| `[144]` | **""God bless Rizia, and long live the Kingdom.""** | `[111]` **Player_Romus**: ""Honorable delegates, I now entr..."<br>`[113]` **Player_Romus**: ""With the power vested in me by ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Narrator**: "I held up the silk sash for ever..." |
| `[145]` | **""May the bonds that unite us as a people grow ever stronger, and may our nation fl..."** | `[111]` **Player_Romus**: ""Honorable delegates, I now entr..."<br>`[113]` **Player_Romus**: ""With the power vested in me by ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Narrator**: "I held up the silk sash for ever..." |
| `[146]` | **""Glovurius axa Rizia!""** | `[111]` **Player_Romus**: ""Honorable delegates, I now entr..."<br>`[113]` **Player_Romus**: ""With the power vested in me by ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["R...` | `[115]` **Narrator**: "I held up the silk sash for ever..." |
| `[152]` | **"Stay next to him."** | `[151]` **Narrator**: "Another round of applause broke ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Manus Sazon**: ""Your Majesty, delegates, and fe..." |
| `[154]` | **"Stay next to her."** | `[153]` **Narrator**: "Another round of applause broke ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Daria de Rava**: ""Your Majesty, delegates, and fe..." |
| `[155]` | **"Take a step back."** | `[151]` **Narrator**: "Another round of applause broke ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Manus Sazon**: ""Your Majesty, delegates, and fe..." |
| `[156]` | **"Take a step back."** | `[153]` **Narrator**: "Another round of applause broke ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Daria de Rava**: ""Your Majesty, delegates, and fe..." |
| `[220]` | **"Watch him speak."** | `[223]` **Adarfo Sotelato**: ""I hereby announce that His Maje..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Narrator**: "Suddenly, the hall broke into ma..." |
| `[221]` | **"Follow him to the podium."** | `[223]` **Adarfo Sotelato**: ""I hereby announce that His Maje..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[230]` **Player_Romus_Italic**: "I did not resist them."<br>`[222]` **Player_Romus**: ""Unhand me! I am your King!""<br>*(oraz 2 innych odgałęzień)* |
| `[222]` | **""Unhand me! I am your King!""** | `[221]` **Player_Romus_Italic**: "When I started walking in the di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Narrator**: "Suddenly, the hall broke into ma..." |
| `[225]` | **""What the hell?""** | `[218]` **Narrator**: "Suddenly, he rushed towards the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Narrator**: "He immediately stepped onto the ..." |
| `[226]` | **""Mr. Sotelato! I have yet to officially appoint you.""** | `[218]` **Narrator**: "Suddenly, he rushed towards the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Narrator**: "He immediately stepped onto the ..." |
| `[227]` | **"Follow him."** | `[218]` **Narrator**: "Suddenly, he rushed towards the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Narrator**: "He immediately stepped onto the ..." |
| `[228]` | **""What do you think you're doing?""** | `[221]` **Player_Romus_Italic**: "When I started walking in the di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Narrator**: "Suddenly, the hall broke into ma..." |
| `[229]` | **""Let me go immediately and I'll forget this happened.""** | `[221]` **Player_Romus_Italic**: "When I started walking in the di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Narrator**: "Suddenly, the hall broke into ma..." |
| `[230]` | **"Don't resist."** | `[221]` **Player_Romus_Italic**: "When I started walking in the di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Narrator**: "Suddenly, the hall broke into ma..." |
| `[244]` | **""Circumstances have changed, Mr. Sazon. The only way to pass these reforms was to ..."** | `[40]` **Manus Sazon**: ""I will not let you down."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Manus Sazon**: ""What?""<br>`[55]` **Manus Sazon**: ""When did you decide on that, Yo..." |
| `[253]` | **"Wait for the applause to stop."** | `[252]` **Narrator**: "I stepped onto the podium to a r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Narrator**: "When the hall fell silent, I too..." |
| `[254]` | **""This speech is not mine to give. Having signed away my powers as monarch, I will ..."** | `[7]` **Player_Romus**: ""My loyal subjects...""<br>`[8]` **Player_Romus**: ""My esteemed countrymen and wome..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Narrator**: "I held up the silk sash for ever..." |

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
  - -> `[3]` (*Narrator: "In a few seconds, the convoy came to a graceful stop in f..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[3]`
Mówca: **Narrator**
> "In a few seconds, the convoy came to a graceful stop in front of the steps of the House. Titus held the door for me as I stepped out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion")"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "As I ascended the stairs, the doors swung open, revealing the bare-bones interior of the House. A chamber that my father was forced to form, now ready to script a new chapter with my support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "I stepped onto the podium as loud applause echoed around me, the faces of the delegates alight with the promise of the future."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player_Romus_Italic: "Gesture for silence."*)
  - -> `[72]` (*Player_Romus_Italic: "Wait for the applause to stop."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "When the hall fell silent, I took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Romus: ""My loyal subjects...""*)
  - -> `[8]` (*Player_Romus: ""My esteemed countrymen and women...""*)
  - -> `[9]` (*Player_Romus: ""My fellow citizens...""*)
  - -> `[10]` (*Player_Romus: ""Great people of Rizia...""*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My loyal subjects...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My esteemed countrymen and women...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My fellow citizens...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Great people of Rizia...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[11]`
Mówca: **Narrator**
> "When I joined the crowd of people gathered inside the building, I was immediately greeted by Manus and Daria, who took me to the ministerial chambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "Followed by security, we entered the room. The new consti..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "Followed by security, we entered the room. The new constitution of Rizia had been laid out on a table in the center."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "As we exchanged handshakes and formalities with each othe..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "As we exchanged handshakes and formalities with each other, Manus leaned in and whispered in my ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction == true"*)

### Węzeł `[14]`
Mówca: **Manus Sazon**
> ""Not a word from the nobles. Seems like everything is going according to plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "My aides guided me to the table, pulled out a chair for m..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Silent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Silent == true"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Silent == true)"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Silent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Silent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Manus Sazon: ""Not a word from the nobles. Seems like everything is goi..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Silent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Silent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Manus Sazon: ""Well... This is it, Your Majesty.""*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction == true )"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Manus Sazon: ""This is it, Your Majesty.""*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Silent == true"*)

### Węzeł `[21]`
Mówca: **Manus Sazon**
> ""Well... This is it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "My aides guided me to the table, pulled out a chair for m..."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "My aides guided me to the table, pulled out a chair for me and carried over a large leather box with golden etchings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "After I was seated, two aides opened the box and held it ..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "After I was seated, two aides opened the box and held it out for me. Inside, a single pen was cushioned in red velvet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Journalists began snapping photos as soon as I grabbed th..."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "Journalists began snapping photos as soon as I grabbed the pen. Everyone looked at me in excitement as they waited for my signature."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus_Italic: "Sign the constitution without saying anything."*)
  - -> `[27]` (*Player_Romus: ""Today, we entrust our future to the hands of those elect..."*)
  - -> `[28]` (*Player_Romus: ""You must understand it is very difficult for me to sign ..."*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DLCAcronymMentioned == true"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "Sign the constitution without saying anything."]** — Mówca: **Player_Romus_Italic**
> "I signed the ridiculously large papers."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("SignAndApplause");"*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This delegation of legislative control -- this DLC -- has been a long time coming. I hope it lives up to all of your expectations.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.DLCAcronymMentioned"] == true`
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("SignAndApplause");"*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Today, we entrust our future to the hands of those elected to represent Rizia. It's a bold step, but one I believe is right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("SignAndApplause");"*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You must understand it is very difficult for me to sign this and willingly transfer my powers away. It's a bold step, but one that must be taken.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("SignAndApplause");"*)

### Węzeł `[29]`
Mówca: **Narrator**
> "The room broke into applause as I signed the documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "That was it. With my signature, the new constitution was ..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "The room broke into applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "That was it. With my signature, the new constitution was ..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "That was it. With my signature, the new constitution was in place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "I gave no thought to the significance of what I had just ..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "After a long pause, I stood up. My next step was to declare the constitution in public and appoint Rizia's new head of government."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[33]`
Mówca: **Narrator**
> "I gave no thought to the significance of what I had just done. Instead, the simplicity of the process made me feel nervous -- as if I expected someone to have intervened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "After a long pause, I stood up. My next step was to decla..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Intention_PM_Daria == true || RiziaDLC.HouseElections_RPPWinsSeats == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Intention_PM_Daria == true || Riz..."*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Reform_Intention_PM_Daria == true || R..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Intention_PM_Daria == true || RiziaDLC.HouseElections_RPPWinsSeats == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Intention_PM_Daria"] == true  or  Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Daria de Rava: ""I will not let you or the Kingdom down, Your Majesty.""*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Reform_Intention_PM_Daria == true || RiziaDLC.HouseElections_RPPWinsSeats == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Intention_PM_Daria"] == true  or  Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Manus Sazon: ""I will not let you down.""*)

### Węzeł `[37]`
Mówca: **Narrator**
> "Daria and Manus guided me through the corridors of the parliament towards the main hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "Before we entered inside, the aides handed me a ceremonia..."*)

### Węzeł `[38]`
Mówca: **Narrator**
> "Before we entered inside, the aides handed me a ceremonial silk sash with blue and golden stripes, to be presented to the first prime minister."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Intention_PM_Daria == true || Riz..."*)

### Węzeł `[39]`
Mówca: **Daria de Rava**
> ""I will not let you or the Kingdom down, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player_Romus: ""I hope so.""*)
  - -> `[43]` (*Player_Romus: ""You have my trust.""*)
  - -> `[44]` (*Player_Romus_Italic: "Nod."*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Daria_PromisePrimeMinister == false"*)

### Węzeł `[40]`
Mówca: **Manus Sazon**
> ""I will not let you down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Daria_PromisePrimeMinister == false"*)
  - -> `[244]` (*Player_Romus: ""Circumstances have changed, Mr. Sazon. The only way to p..."*)
  - -> `[45]` (*Player_Romus: ""Actually, Manus... I have decided to appoint Ms. Rava in..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, Ms. De Rava... I have decided to appoint Manus instead. I believe this is for the best.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false`
- **Kontekst wejściowy (poprzednik):** `[39]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Daria de Rava: ""What is the meaning of this? You can't do that, Your Maj..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope so.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false`
- **Kontekst wejściowy (poprzednik):** `[39]` (Daria de Rava), `[40]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Suddenly, the aides opened the doors and we entered the h..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have my trust.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false`
- **Kontekst wejściowy (poprzednik):** `[39]` (Daria de Rava), `[40]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Suddenly, the aides opened the doors and we entered the h..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Romus_Italic**
> "I nodded."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false`
- **Kontekst wejściowy (poprzednik):** `[39]` (Daria de Rava), `[40]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Suddenly, the aides opened the doors and we entered the h..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, Manus... I have decided to appoint Ms. Rava instead. I believe this is for the best.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Manus Sazon: ""What?""*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Manus Sazon: ""When did you decide on that, Your Majesty?""*)

### Węzeł `[49]`
Mówca: **Manus Sazon**
> ""What?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Manus Sazon: ""This does not reflect the will of the people.""*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == false"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == false)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Daria de Rava: ""I thought this constitution is supposed to reflect the w..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Daria de Rava: ""I wish my party had been included in that conversation.""*)

### Węzeł `[53]`
Mówca: **Daria de Rava**
> ""What is the meaning of this? You can't do that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == false"*)

### Węzeł `[54]`
Mówca: **Daria de Rava**
> ""I thought this constitution is supposed to reflect the will of the Rizian people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)

### Węzeł `[55]`
Mówca: **Manus Sazon**
> ""When did you decide on that, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Manus Sazon: ""I wish my party had been included in that conversation.""*)

### Węzeł `[56]`
Mówca: **Manus Sazon**
> ""I wish my party had been included in that conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player_Romus: ""There was no conversation. As the monarch, I will appoin..."*)
  - -> `[59]` (*Player_Romus: ""I've respected the will of the people enough today. As t..."*)
  - -> `[60]` (*Player_Romus: ""We are about to enter the hall, Manus. Please keep your ..."*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Daria_PromisePrimeMinister == true"*)

### Węzeł `[57]`
Mówca: **Daria de Rava**
> ""I wish my party had been included in that conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player_Romus: ""I've respected the will of the people enough today. As t..."*)
  - -> `[64]` (*Player_Romus: ""We are about to enter the hall, Daria. Please keep your ..."*)
  - -> `[65]` (*Player_Romus: ""I'm sorry.""*)
  - -> `[67]` (*Player_Romus: ""There was no conversation. As the monarch, I will appoin..."*)

### Węzeł `[58]`
Mówca: **Manus Sazon**
> ""This does not reflect the will of the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player_Romus: ""I've respected the will of the people enough today. As t..."*)
  - -> `[60]` (*Player_Romus: ""We are about to enter the hall, Manus. Please keep your ..."*)
  - -> `[61]` (*Player_Romus: ""I'm sorry.""*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Daria_PromisePrimeMinister == true"*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've respected the will of the people enough today. As the monarch, I will appoint Daria as the prime minister. End of discussion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Manus Sazon), `[58]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Suddenly, the aides opened the doors and we entered the h..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are about to enter the hall, Manus. Please keep your act down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Manus Sazon), `[58]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Suddenly, the aides opened the doors and we entered the h..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Suddenly, the aides opened the doors and we entered the h..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Madam de Rava was an integral figure in passing these reforms. I promised her she would be rewarded, and I am keeping that promise.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Daria_PromisePrimeMinister"] == true`
- **Kontekst wejściowy (poprzednik):** `[56]` (Manus Sazon), `[58]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Suddenly, the aides opened the doors and we entered the h..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've respected the will of the people enough today. As the monarch, I will appoint Manus as the prime minister. End of discussion.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[57]` (Daria de Rava), `[183]` (Daria de Rava), `[54]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Suddenly, the aides opened the doors and we entered the h..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are about to enter the hall, Daria. Please keep your act down.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[57]` (Daria de Rava), `[183]` (Daria de Rava), `[54]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Suddenly, the aides opened the doors and we entered the h..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[57]` (Daria de Rava), `[183]` (Daria de Rava), `[54]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Suddenly, the aides opened the doors and we entered the h..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. It still does.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[54]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Suddenly, the aides opened the doors and we entered the h..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There was no conversation. As the monarch, I will appoint whoever I want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Manus Sazon), `[57]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Suddenly, the aides opened the doors and we entered the h..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "Suddenly, the aides opened the doors and we entered the hall. Massive cameras were filming us as we walked inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Daria ..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player_Romus: ""Today, we stand at the dawn of a new era in the history ..."*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)
  - -> `[78]` (*Player_Romus: ""Today, we reaffirm our unwavering commitment to the prin..."*)
  - -> `[254]` (*Player_Romus: ""This speech is not mine to give. Having signed away my p..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Today, we stand at the dawn of a new era in the history of our nation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Player_Romus), `[8]` (Player_Romus), `[9]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "Gesture for silence."]** — Mówca: **Player_Romus_Italic**
> "I gestured for silence."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator), `[248]` (Narrator), `[252]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "When the hall fell silent, I took a deep breath."*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "Wait for the applause to stop."]** — Mówca: **Player_Romus_Italic**
> "I stood there for a whole minute as the delegates applauded vigorously."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator), `[248]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "When the hall fell silent, I took a deep breath."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is with a heart full of hope and a mind conscious of the demands of the democratic movement that I address you on this momentous occasion.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[7]` (Player_Romus), `[8]` (Player_Romus), `[9]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player_Romus: ""It is with a heart full of hope and a mind conscious of ..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player_Romus: ""It is with a heart full of hope and a mind conscious of ..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is with a heart full of hope and a mind conscious of the demands of a new constitution made by the people, that I address you on this momentous occasion.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Kontekst wejściowy (poprzednik):** `[7]` (Player_Romus), `[8]` (Player_Romus), `[9]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Today, we reaffirm our unwavering commitment to the principles that are the bedrock of any great society—participation in politics, liberty, and the rule of law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Player_Romus), `[8]` (Player_Romus), `[9]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player_Romus: ""In the spirit of our timeless principles, I stand before..."*)
  - -> `[81]` (*Player_Romus: ""On this historic day, we are reminded of the enduring le..."*)
  - -> `[83]` (*Player_Romus: ""Change, as we know, is the only constant in the march of..."*)
  - -> `[85]` (*Player_Romus: ""Throughout the ages, our beloved country has been guided..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In the spirit of our timeless principles, I stand before you, not as a ruler, but as a fellow Rizian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Player_Romus), `[73]` (Player_Romus), `[77]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[87]` (*Player_Romus: ""Because the very essence of our nation is not defined by..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""On this historic day, we are reminded of the enduring legacy of our kingdom—a legacy rich in tradition and bound by the unbreakable spirit of these lands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Player_Romus), `[73]` (Player_Romus), `[77]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[86]` (*Player_Romus: ""Yet, the very essence of our nation is not defined by th..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe Rizia was in need of a constitution that reflects our collective aspirations for a just, equitable, and democratic society.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Player_Romus), `[81]` (Player_Romus), `[83]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Change, as we know, is the only constant in the march of time. It is the harbinger of progress, the catalyst for innovation, and the doorway to new possibilities.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Player_Romus), `[73]` (Player_Romus), `[77]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[88]` (*Player_Romus: ""And the very essence of our nation is not defined by the..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Embracing change is not just an option; it is our imperative if we are to stride confidently into the future that beckons us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Player_Romus), `[81]` (Player_Romus), `[83]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Throughout the ages, our beloved country has been guided by the steady hand of the monarchy, a lineage that has weathered the storms of time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Player_Romus), `[73]` (Player_Romus), `[77]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[86]` (*Player_Romus: ""Yet, the very essence of our nation is not defined by th..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yet, the very essence of our nation is not defined by the constancy of its rulers but by the indomitable spirit of its people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Player_Romus), `[85]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Because the very essence of our nation is not defined by the constancy of its rulers but by the indomitable spirit of its people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the very essence of our nation is not defined by the constancy of its rulers but by the indomitable spirit of its people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""I believe Rizia was in need of a constitution that refle..."*)
  - -> `[84]` (*Player_Romus: ""Embracing change is not just an option; it is our impera..."*)
  - -> `[90]` (*Player_Romus: ""The world around us is changing. Nations are awakening t..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The world around us is changing. Nations are awakening to the clarion call of freedom and representation, recognizing that the true strength of a country lies in the collective will of its citizens.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Player_Romus), `[81]` (Player_Romus), `[83]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player_Romus: ""It is in this light that I, your monarch, have resolved ..."*)
  - -> `[93]` (*Player_Romus: ""Therefore, I decided to give my support to the democrati..."*)
  - -> `[94]` (*Player_Romus: ""With this in mind, we all must give a solemn pledge to e..."*)
  - -> `[98]` (*Player_Romus: ""We are gathered here, not to witness the diminishing of ..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is in this light that I, your monarch, have resolved to embrace the winds of change.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Player_Romus), `[84]` (Player_Romus), `[86]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Therefore, I decided to give my support to the democratic movement in drafting a new constitution for Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Player_Romus), `[84]` (Player_Romus), `[86]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With this in mind, we all must give a solemn pledge to ensure that the voice of every citizen is heard, and the rights of every individual are protected.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Player_Romus), `[84]` (Player_Romus), `[86]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "As soon as I said that, the aides brought the constitutio..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By establishing a head of government and vesting legislative powers in this House, the people, we are not just reforming our governance. We are fixing it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[97]`
Mówca: **Narrator**
> "As soon as I said that, the aides brought the constitution and displayed it to the delegates, prompting more applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Romus: ""By establishing a head of government and vesting legisla..."*)
  - -> `[99]` (*Player_Romus: ""We are establishing, for the first time in our history, ..."*)
  - -> `[100]` (*Player_Romus: ""In embracing these reforms, I am mindful of the profound..."*)
  - -> `[102]` (*Player_Romus: ""I embrace this evolution, not as a departure from our ch..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are gathered here, not to witness the diminishing of the crown, but to celebrate the empowerment of the people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Player_Romus), `[84]` (Player_Romus), `[86]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are establishing, for the first time in our history, the office of the Prime Minister, a head of government chosen from among the representatives of the people, to lead the executive branch with diligence and integrity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In embracing these reforms, I am mindful of the profound responsibility that comes with leadership -- the responsibility to put the welfare of the nation and its people above all else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "//"*)
  - -> `[101]` (*Player_Romus: ""It is a responsibility that I embrace not with a sense o..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is a responsibility that I embrace not with a sense of loss, but with the deepest sense of honor and purpose.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I embrace this evolution, not as a departure from our cherished traditions, but as an affirmation of their enduring relevance. This constitution does not signify an end but a beginning -- a harmonious blending of the old and the new.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player_Romus: ""This act of endorsing this constitution is about ensurin..."*)
  - -> `[105]` (*Player_Romus: ""This House will be the crucible in which the laws of our..."*)
  - -> `[106]` (*Player_Romus: "In consenting to this constitution, I do not relinquish m..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This act of endorsing this constitution is about ensuring that the legacy we leave for future generations is one of a society that values dialogue over decree, consensus over command, and the common good over individual gain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Player_Romus), `[99]` (Player_Romus), `[100]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This House will be the crucible in which the laws of our land are forged, ensuring that every statute reflects the collective will of the Rizian people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Player_Romus), `[99]` (Player_Romus), `[100]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "In consenting to this constitution, I do not relinquish my love for this country; rather, I reaffirm my commitment to serve it and its people with every fiber of my being.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[96]` (Player_Romus), `[99]` (Player_Romus), `[100]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player_Romus: ""At this moment, I am reminded that true leadership is no..."*)
  - -> `[108]` (*Player_Romus: ""Let the pages of history remember this day as the moment..."*)
  - -> `[109]` (*Player_Romus: ""As we chart this new course, let us be guided by the dem..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let the pages of history remember this day as the moment when we chose not just to change, but to evolve; not just to promise, but to deliver; not just to dream, but to achieve.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Player_Romus), `[104]` (Player_Romus), `[105]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As we chart this new course, let us be guided by the democratic principles that are now enshrined in our constitution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Player_Romus), `[104]` (Player_Romus), `[105]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""At this moment, I am reminded that true leadership is not about wielding power; it is about empowering others.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Player_Romus), `[104]` (Player_Romus), `[105]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Honorable delegates, I now entrust my power to you, the elected voice of our people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Player_Romus), `[109]` (Player_Romus), `[110]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player_Romus: ""Honorable delegates, I now entrust my power to you, the ..."*)
  - -> `[113]` (*Player_Romus: ""With the power vested in me by tradition and lineage, I ..."*)
  - -> `[114]` (*Player_Romus: ""I hereby announce that the new constitution was signed a..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With the power vested in me by tradition and lineage, I declare the Rizian Charter of Fundamental Law -- adopting a true constitutional monarchy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Player_Romus), `[109]` (Player_Romus), `[110]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hereby announce that the new constitution was signed and is currently in place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Player_Romus), `[109]` (Player_Romus), `[110]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[115]`
Mówca: **Narrator**
> "I held up the silk sash for everyone to see."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player_Romus: ""In this spirit of renewal and with the power vested in m..."*)
  - -> `[117]` (*Player_Romus: ""In accordance with the new constitution, I shall appoint..."*)
  - -> `[118]` (*Player_Romus: ""In appointing a new head of government, we turn a page i..."*)
  - -> `[119]` (*Player_Romus: ""As for the first Prime Minister of Rizia... This individ..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In this spirit of renewal and with the power vested in me, I hereby announce the appointment of the new head of government...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "The room hung on my every word, the air thick with antici..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In accordance with the new constitution, I shall appoint a new head of government until the elections...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "The room hung on my every word, the air thick with antici..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In appointing a new head of government, we turn a page in our history, embracing a governance of the people, by the people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "The room hung on my every word, the air thick with antici..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As for the first Prime Minister of Rizia... This individual is someone who embodies the principles we hold dear and possesses the vision to lead our nation into a promising future...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "The room hung on my every word, the air thick with antici..."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "The room hung on my every word, the air thick with anticipation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Daria_PromisePrimeMinister == false"*)
  - -> `[122]` (*Player_Romus: ""I appoint Daria de Rava as interim Prime Minister.""*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appoint Manus Sazon as interim Prime Minister.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false`
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Manus = true; RiziaDLCSuppo..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appoint Daria de Rava as interim Prime Minister.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Daria = true; RiziaDLCSuppo..."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "A murmur of disapproval rippled through the chamber as he made his way to the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "I put the sash and the pin on him."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "A murmur of disapproval rippled through the chamber as sh..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "A murmur of approval rippled through the chamber as she m..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RNCWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RNCWinsSeats == true"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RNCWinsSeats == true)"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RNCWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RNCWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "A murmur of disapproval rippled through the chamber as he..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RNCWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RNCWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == false"*)

### Węzeł `[130]`
Mówca: **Narrator**
> "Manus rose from his seat among the delegates, his expression one of determination."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "AddConversant("Manus Sazon");"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Intention_PM_Daria == false && RiziaDLC.Daria_PromisePrimeMinister == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Intention_PM_Daria == false && Ri..."*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Reform_Intention_PM_Daria == false && ..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Intention_PM_Daria == false && RiziaDLC.Daria_PromisePrimeMinister == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Intention_PM_Daria"] == false  and  Variable["RiziaDLC.Daria_PromisePrimeMinister"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "Daria rose from her seat among the delegates, her express..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Reform_Intention_PM_Daria == false && RiziaDLC.Daria_PromisePrimeMinister == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Intention_PM_Daria"] == false  and  Variable["RiziaDLC.Daria_PromisePrimeMinister"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "Daria rose from her seat among the delegates, her express..."*)

### Węzeł `[134]`
Mówca: **Narrator**
> "Daria rose from her seat among the delegates, her expression one of surprise and excitement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "AddConversant("Daria de Rava");"*)

### Węzeł `[135]`
Mówca: **Narrator**
> "Daria rose from her seat among the delegates, her expression one of confidence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "AddConversant("Daria de Rava");"*)

### Węzeł `[136]`
Mówca: **Narrator**
> "A murmur of disapproval rippled through the chamber as she made her way to the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "I put the sash and the pin on her."*)

### Węzeł `[137]`
Mówca: **Narrator**
> "A murmur of approval rippled through the chamber as he made his way to the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "I put the sash and the pin on him."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == false"*)
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == false)"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "A murmur of disapproval rippled through the chamber as he..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "A murmur of approval rippled through the chamber as he ma..."*)

### Węzeł `[141]`
Mówca: **Narrator**
> "A murmur of approval rippled through the chamber as she made her way to the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "I put the sash and the pin on her."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player_Romus: ""Glovurius axa Rizia!""*)
  - -> `[143]` (*Player_Romus: ""To the future -- a future that we will build together, o..."*)
  - -> `[144]` (*Player_Romus: ""God bless Rizia, and long live the Kingdom.""*)
  - -> `[145]` (*Player_Romus: ""May the bonds that unite us as a people grow ever strong..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To the future -- a future that we will build together, on the solid foundation of this new charter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Player_Romus), `[113]` (Player_Romus), `[114]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "I held up the silk sash for everyone to see."*)

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God bless Rizia, and long live the Kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Player_Romus), `[113]` (Player_Romus), `[114]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "I held up the silk sash for everyone to see."*)

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May the bonds that unite us as a people grow ever stronger, and may our nation flourish under the guiding principles of this new constitution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Player_Romus), `[113]` (Player_Romus), `[114]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "I held up the silk sash for everyone to see."*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glovurius axa Rizia!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Player_Romus), `[113]` (Player_Romus), `[114]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_GlovuriusAxaRizia += 1"*)

### Węzeł `[147]`
Mówca: **Narrator**
> "I put the sash and the pin on him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Manus Sazon: ""Thank you, Your Majesty.""*)

### Węzeł `[148]`
Mówca: **Narrator**
> "I put the sash and the pin on her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Daria de Rava: ""Thank you, Your Majesty.""*)

### Węzeł `[149]`
Mówca: **Daria de Rava**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CheerCrowd");"*)

### Węzeł `[150]`
Mówca: **Manus Sazon**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CheerCrowd");"*)

### Węzeł `[151]`
Mówca: **Narrator**
> "Another round of applause broke out -- this time for much longer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player_Romus_Italic: "Stay next to him."*)
  - -> `[155]` (*Player_Romus_Italic: "Take a step back."*)

### Węzeł `[152]`
**[WYBÓR GRACZA: "Stay next to him."]** — Mówca: **Player_Romus_Italic**
> "I stood next to him as the applause subsided."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[151]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Manus Sazon: ""Your Majesty, delegates, and fellow citizens, I am deepl..."*)

### Węzeł `[153]`
Mówca: **Narrator**
> "Another round of applause broke out -- this time for much longer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Player_Romus_Italic: "Stay next to her."*)
  - -> `[156]` (*Player_Romus_Italic: "Take a step back."*)

### Węzeł `[154]`
**[WYBÓR GRACZA: "Stay next to her."]** — Mówca: **Player_Romus_Italic**
> "I stood next to her as the applause subsided."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Daria de Rava: ""Your Majesty, delegates, and fellow citizens, I am deepl..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA: "Take a step back."]** — Mówca: **Player_Romus_Italic**
> "I took a step back, allowing him to take center stage."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[151]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Manus Sazon: ""Your Majesty, delegates, and fellow citizens, I am deepl..."*)

### Węzeł `[156]`
**[WYBÓR GRACZA: "Take a step back."]** — Mówca: **Player_Romus_Italic**
> "I took a step back, allowing her to take center stage."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[153]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Daria de Rava: ""Your Majesty, delegates, and fellow citizens, I am deepl..."*)

### Węzeł `[157]`
Mówca: **Manus Sazon**
> ""Your Majesty, delegates, and fellow citizens, I am deeply honored by the trust placed in me. This is a momentous day for democracy and liberty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Manus Sazon: ""I am proud to have represented the democratic movement t..."*)

### Węzeł `[158]`
Mówca: **Manus Sazon**
> ""I am proud to have represented the democratic movement to this day, and I am overjoyed to see such a transfer of power finally take place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Manus Sazon: ""Our path forward will be built on dialogue, on the colle..."*)

### Węzeł `[159]`
Mówca: **Manus Sazon**
> ""Our path forward will be built on dialogue, on the collective wisdom of this assembly, and on the aspirations of our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "The delegates rose in a standing ovation."*)

### Węzeł `[160]`
Mówca: **Daria de Rava**
> ""Your Majesty, delegates, and fellow citizens, I am deeply honored by the trust placed in me. This is a momentous day, not only for me, but for our great kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Daria de Rava: ""Together, we will embark on a journey of transformation,..."*)

### Węzeł `[161]`
Mówca: **Daria de Rava**
> ""Together, we will embark on a journey of transformation, grounded in the principles of tradition, equity, and prosperity for all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Daria de Rava: ""We will face challenges, no doubt, but in our unity, we ..."*)

### Węzeł `[162]`
Mówca: **Daria de Rava**
> ""We will face challenges, no doubt, but in our unity, we will find strength.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "The delegates rose in a standing ovation."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Manus = true;
RiziaDLCSupport.News_Turn10_RH_NewConstitution_ManusPM = true;
RiziaDLCSupport.News_Turn10_V_NewConstitution_ManusPM = true;
RiziaDLCSupport.Reports_Turn10_Iza_ConstitutionCelebration_ManusPM = true;
RiziaDLCSupport.Journal_Turn10_ConstitutionSigned_Manus = true;
RiziaDLCText.PrimeMinister = "Manus Sazon"`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_PrimeMinister_Manus"] = true;
Variable["RiziaDLCSupport.News_Turn10_RH_NewConstitution_ManusPM"] = true;
Variable["RiziaDLCSupport.News_Turn10_V_NewConstitution_ManusPM"] = true;
Variable["RiziaDLCSupport.Reports_Turn10_Iza_ConstitutionCelebration_ManusPM"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_ConstitutionSigned_Manus"] = true;
Variable["RiziaDLCText.PrimeMinister"] ="Manus Sazon";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "Manus rose from his seat among the delegates, his express..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Daria = true;
RiziaDLCSupport.News_Turn10_RH_NewConstitution_DariaPM = true;
RiziaDLCSupport.News_Turn10_V_NewConstitution_DariaPM = true;
RiziaDLCSupport.Journal_Turn10_ConstitutionSigned_Daria = true;
RiziaDLCText.PrimeMinister = "Daria De Rava"`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_PrimeMinister_Daria"] = true;
Variable["RiziaDLCSupport.News_Turn10_RH_NewConstitution_DariaPM"] = true;
Variable["RiziaDLCSupport.News_Turn10_V_NewConstitution_DariaPM"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_ConstitutionSigned_Daria"] = true;
Variable["RiziaDLCText.PrimeMinister"] ="Daria De Rava";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Intention_PM_Daria == false && Ri..."*)

### Węzeł `[165]`
Mówca: **Narrator**
> "The delegates rose in a standing ovation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Manus Sazon: ""I promise to represent the interests of the Rizian peopl..."*)

### Węzeł `[166]`
Mówca: **Narrator**
> "The delegates rose in a standing ovation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Daria de Rava: ""I promise to represent the interests of the Rizian peopl..."*)

### Węzeł `[167]`
Mówca: **Manus Sazon**
> ""I promise to represent the interests of the Rizian people -- regardless of their economic or cultural backgrounds and uphold the Rizian Charter of Fundamental Law during my tenure as Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Manus Sazon: ""I swear that I will serve my duty with diligence until t..."*)

### Węzeł `[168]`
Mówca: **Manus Sazon**
> ""I swear that I will serve my duty with diligence until the upcoming elections, when Rizia will finally elect their own government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Manus Sazon: ""Thank you.""*)

### Węzeł `[169]`
Mówca: **Daria de Rava**
> ""I promise to represent the interests of the Rizian people and uphold the Rizian Charter of Fundamental Law during my tenure as Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Daria de Rava: ""I swear that I will serve my duty to the Crown with dili..."*)

### Węzeł `[170]`
Mówca: **Daria de Rava**
> ""I swear that I will serve my duty to the Crown with diligence until the upcoming elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Daria de Rava: ""Thank you. Glovurius axa Rizia!""*)

### Węzeł `[171]`
Mówca: **Daria de Rava**
> ""Thank you. Glovurius axa Rizia!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "After taking the applause in, together, we walked towards..."*)

### Węzeł `[172]`
Mówca: **Manus Sazon**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "After taking the applause in, together, we walked towards..."*)

### Węzeł `[173]`
Mówca: **Narrator**
> "After taking the applause in, together, we walked towards the balcony to face the crowd that had gathered outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "It was done. My signature, the House approval and now a b..."*)

### Węzeł `[174]`
Mówca: **Narrator**
> "It was done. My signature, the House approval and now a broadcast declaration. It was a point of no return."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion")`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "As I ascended the stairs, the doors swung open, revealing..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Manus Sazon");
AddConversant("Daria de Rava");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Manus Sazon");
AddConversant("Daria de Rava");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "When I joined the crowd of people gathered inside the bui..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Manus Sazon");
RemoveConversant("Daria de Rava");
RemoveConversant("Adarfo Sotelato");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Manus Sazon");
RemoveConversant("Daria de Rava");
RemoveConversant("Adarfo Sotelato");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic == true"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Daria de Rava");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Daria de Rava");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Manus Sazon");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Manus Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RNCWinsSeats == true"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Daria de Rava: ""What you're doing is nepotism. Pure and simple.""*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player_Romus: ""I've respected the will of the people enough today. As t..."*)
  - -> `[64]` (*Player_Romus: ""We are about to enter the hall, Daria. Please keep your ..."*)
  - -> `[65]` (*Player_Romus: ""I'm sorry.""*)
  - -> `[66]` (*Player_Romus: ""Don't worry. It still does.""*)

### Węzeł `[183]`
Mówca: **Daria de Rava**
> ""What you're doing is nepotism. Pure and simple.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player_Romus: ""I've respected the will of the people enough today. As t..."*)
  - -> `[64]` (*Player_Romus: ""We are about to enter the hall, Daria. Please keep your ..."*)
  - -> `[65]` (*Player_Romus: ""I'm sorry.""*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DLCAcronymMentioned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DLCAcronymMentioned == true"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.DLCAcronymMentioned == true)"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DLCAcronymMentioned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.DLCAcronymMentioned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""This delegation of legislative control -- this DLC -- ha..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.DLCAcronymMentioned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.DLCAcronymMentioned"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_FallingIntoPlace", "R_FallingIntoPlace_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_FallingIntoPlace","R_FallingIntoPlace_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "The room broke into applause as I signed the documents."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("CheerCrowd");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("CheerCrowd");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "Another round of applause broke out -- this time for much..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("CheerCrowd");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("CheerCrowd");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "Another round of applause broke out -- this time for much..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("SignAndApplause");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("SignAndApplause");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_FallingIntoPlace", "R_FallingIntoPlace..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_FallingIntoPlace", "R_FallingIntoPlace_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_FallingIntoPlace","R_FallingIntoPlace_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The room broke into applause."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("SignAndApplause");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("SignAndApplause");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_FallingIntoPlace", "R_FallingIntoPlace..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_GlovuriusAxaRizia += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["RiziaDLC.Said_GlovuriusAxaRizia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "I held up the silk sash for everyone to see."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Daria_PromisePrimeMinister == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Daria_PromisePrimeMinister == false"*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Daria_PromisePrimeMinister == false)"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Daria_PromisePrimeMinister == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player_Romus: ""I hope so.""*)
  - -> `[43]` (*Player_Romus: ""You have my trust.""*)
  - -> `[44]` (*Player_Romus_Italic: "Nod."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Daria_PromisePrimeMinister == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Daria_PromisePrimeMinister == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Daria_PromisePrimeMinister == true"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Daria_PromisePrimeMinister == true)"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Daria_PromisePrimeMinister == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Daria_PromisePrimeMinister"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player_Romus: ""Madam de Rava was an integral figure in passing these re..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Daria_PromisePrimeMinister == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Daria_PromisePrimeMinister"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Daria_PromisePrimeMinister == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Daria_PromisePrimeMinister == false"*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Daria_PromisePrimeMinister == false)"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Daria_PromisePrimeMinister == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player_Romus: ""Actually, Ms. De Rava... I have decided to appoint Manus..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Daria_PromisePrimeMinister == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "AddConversant("Adarfo Sotelato");"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "AddConversant("Manus Sazon"); AddConversant("Daria de Rav..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Adarfo Sotelato");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Adarfo Sotelato");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "When I joined the crowd of people gathered inside the bui..."*)

### Węzeł `[207]`
Mówca: **Narrator**
> "When I joined the crowd of people gathered inside the building, I was immediately greeted by Adarfo Sotelato, who took me to the ministerial chambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "Followed by security, we entered the room. The new consti..."*)

### Węzeł `[208]`
Mówca: **Narrator**
> "Followed by security, we entered the room. The new constitution of Rizia had been laid out on a table in the center."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "As we exchanged handshakes and formalities with each othe..."*)

### Węzeł `[209]`
Mówca: **Narrator**
> "As we exchanged handshakes and formalities with each other, Adarfo leaned in and whispered in my ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Adarfo Sotelato: ""Glad you made it. I half-expected you to backtrack at th..."*)

### Węzeł `[210]`
Mówca: **Adarfo Sotelato**
> ""Glad you made it. I half-expected you to backtrack at the last minute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "My aides guided me to the table, pulled out a chair for m..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "Adarfo guided me through the corridors of the parliament ..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Daria and Manus guided me through the corridors of the pa..."*)

### Węzeł `[214]`
Mówca: **Narrator**
> "Adarfo guided me through the corridors of the parliament towards the main hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "Before we entered inside, the aides handed me a ceremonia..."*)

### Węzeł `[215]`
Mówca: **Narrator**
> "Before we entered inside, the aides handed me a ceremonial silk sash with blue and golden stripes, to be presented to the first prime minister."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "Adarfo quickly snatched the sash from me."*)

### Węzeł `[216]`
Mówca: **Narrator**
> "Adarfo quickly snatched the sash from me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Adarfo Sotelato: ""I'll have that, thank you.""*)

### Węzeł `[217]`
Mówca: **Adarfo Sotelato**
> ""I'll have that, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "Suddenly, he rushed towards the doors and entered the hal..."*)

### Węzeł `[218]`
Mówca: **Narrator**
> "Suddenly, he rushed towards the doors and entered the hall without waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Player_Romus: ""What the hell?""*)
  - -> `[226]` (*Player_Romus: ""Mr. Sotelato! I have yet to officially appoint you.""*)
  - -> `[227]` (*Player_Romus_Italic: "Follow him."*)

### Węzeł `[219]`
Mówca: **Narrator**
> "He immediately stepped onto the podium and displayed his ceremonial sash as massive cameras filmed him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Adarfo Sotelato: ""Ladies and gentlemen!""*)

### Węzeł `[220]`
**[WYBÓR GRACZA: "Watch him speak."]** — Mówca: **Player_Romus_Italic**
> "I decided to let it be and positioned myself by the side of the hall."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "Suddenly, the hall broke into massive applause."*)

### Węzeł `[221]`
**[WYBÓR GRACZA: "Follow him to the podium."]** — Mówca: **Player_Romus_Italic**
> "When I started walking in the direction of the podium, several men grabbed my arms and stopped me."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Adarfo Sotelato)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Player_Romus_Italic: "Don't resist."*)
  - -> `[222]` (*Player_Romus: ""Unhand me! I am your King!""*)
  - -> `[228]` (*Player_Romus: ""What do you think you're doing?""*)
  - -> `[229]` (*Player_Romus: ""Let me go immediately and I'll forget this happened.""*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unhand me! I am your King!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[221]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "Suddenly, the hall broke into massive applause."*)

### Węzeł `[223]`
Mówca: **Adarfo Sotelato**
> ""I hereby announce that His Majesty, King Romus Toras, has signed the Constitution and appointed me as the Prime Minister of Rizia!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Player_Romus_Italic: "Watch him speak."*)
  - -> `[221]` (*Player_Romus_Italic: "Follow him to the podium."*)

### Węzeł `[224]`
Mówca: **Adarfo Sotelato**
> ""Ladies and gentlemen!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Adarfo Sotelato: ""I hereby announce that His Majesty, King Romus Toras, ha..."*)

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What the hell?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "He immediately stepped onto the podium and displayed his ..."*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Sotelato! I have yet to officially appoint you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "He immediately stepped onto the podium and displayed his ..."*)

### Węzeł `[227]`
**[WYBÓR GRACZA: "Follow him."]** — Mówca: **Player_Romus_Italic**
> "I followed behind him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "He immediately stepped onto the podium and displayed his ..."*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think you're doing?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[221]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "Suddenly, the hall broke into massive applause."*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let me go immediately and I'll forget this happened.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[221]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "Suddenly, the hall broke into massive applause."*)

### Węzeł `[230]`
**[WYBÓR GRACZA: "Don't resist."]** — Mówca: **Player_Romus_Italic**
> "I did not resist them."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[221]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "Suddenly, the hall broke into massive applause."*)

### Węzeł `[231]`
Mówca: **Narrator**
> "Suddenly, the hall broke into massive applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Adarfo Sotelato: ""Today, we stand at the dawn of a new era in the history ..."*)

### Węzeł `[232]`
Mówca: **Adarfo Sotelato**
> ""Today, we stand at the dawn of a new era in the history of our nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_PrimeMinister_Adarfo = true; RiziaDLCText..."*)

### Węzeł `[233]`
Mówca: **Adarfo Sotelato**
> ""I am deeply honored by the trust placed in me in overseeing this revolutionary change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Adarfo Sotelato: ""I am proud to have represented the common people of Rizi..."*)

### Węzeł `[234]`
Mówca: **Adarfo Sotelato**
> ""I am proud to have represented the common people of Rizia, and I am overjoyed to see such a transfer of power finally take place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Adarfo Sotelato: ""Our path forward will be built on great transformations ..."*)

### Węzeł `[235]`
Mówca: **Adarfo Sotelato**
> ""Our path forward will be built on great transformations and reversal of historical injustices, all for the benefit of the Rizian people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "The RPP delegates rose in a standing ovation."*)

### Węzeł `[236]`
Mówca: **Narrator**
> "The RPP delegates rose in a standing ovation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Adarfo Sotelato: ""I promise to fight for the interests of the Rizian worki..."*)

### Węzeł `[237]`
Mówca: **Adarfo Sotelato**
> ""I promise to fight for the interests of the Rizian working class, and uphold the Rizian Charter of Fundamental Law during my tenure as Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Adarfo Sotelato: ""I swear that I will serve my duty with diligence until t..."*)

### Węzeł `[238]`
Mówca: **Adarfo Sotelato**
> ""I swear that I will serve my duty with diligence until the upcoming elections, when the citizens of Rizia will finally elect their own government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Adarfo Sotelato: ""Thank you.""*)

### Węzeł `[239]`
Mówca: **Adarfo Sotelato**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "It was done. My signature, the House approval and now a b..."*)

### Węzeł `[240]`
Mówca: **Adarfo Sotelato**
> ""According to this new constitution, the nobility will no longer have any power nor privilege over the governance of this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Adarfo Sotelato: ""I am deeply honored by the trust placed in me in oversee..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_PrimeMinister_Adarfo = true;
RiziaDLCText.PrimeMinister = "Adarfo Sotelato";
RiziaDLCSupport.News_Turn10_RH_NewConstitution_AdarfoPM = true;
RiziaDLCSupport.News_Turn10_V_NewConstitution_AdarfoPM = true;
RiziaDLCSupport.Journal_Turn10_ConstitutionSigned_Adarfo = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_PrimeMinister_Adarfo"] = true;
Variable["RiziaDLCText.PrimeMinister"] ="Adarfo Sotelato";
Variable["RiziaDLCSupport.News_Turn10_RH_NewConstitution_AdarfoPM"] = true;
Variable["RiziaDLCSupport.News_Turn10_V_NewConstitution_AdarfoPM"] = true;
Variable["RiziaDLCSupport.Journal_Turn10_ConstitutionSigned_Adarfo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Adarfo Sotelato: ""According to this new constitution, the nobility will no..."*)

### Węzeł `[242]`
Mówca: **Manus Sazon**
> ""This is it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Manus Sazon: ""I hope everything was worth it.""*)

### Węzeł `[243]`
Mówca: **Manus Sazon**
> ""I hope everything was worth it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "My aides guided me to the table, pulled out a chair for m..."*)

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Circumstances have changed, Mr. Sazon. The only way to pass these reforms was to guarantee Baroness De Rava the position of Prime Minister.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic == true"*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Diplomatic == true)"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Diplomatic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "I stepped onto the podium as loud applause echoed around ..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Diplomatic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Diplomatic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Silent == true"*)

### Węzeł `[248]`
Mówca: **Narrator**
> "I stepped onto the podium as the RPP delegates burst into applause. Those from the RNC were pointedly silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player_Romus_Italic: "Gesture for silence."*)
  - -> `[72]` (*Player_Romus_Italic: "Wait for the applause to stop."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Silent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Silent == true"*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Silent == true)"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Silent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Silent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "I stepped onto the podium as the RPP delegates burst into..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Silent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Silent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "I stepped onto the podium to a round of applause from the..."*)

### Węzeł `[252]`
Mówca: **Narrator**
> "I stepped onto the podium to a round of applause from the delegates. Some appeared hopeful for the future; others wore fearful expressions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player_Romus_Italic: "Gesture for silence."*)
  - -> `[253]` (*Player_Romus_Italic: "Wait for the applause to stop."*)

### Węzeł `[253]`
**[WYBÓR GRACZA: "Wait for the applause to stop."]** — Mówca: **Player_Romus_Italic**
> "I stood there for a few seconds as the applause died down."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[252]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "When the hall fell silent, I took a deep breath."*)

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This speech is not mine to give. Having signed away my powers as monarch, I will now yield the floor to Rizia's new head of government.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Player_Romus), `[8]` (Player_Romus), `[9]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "Jump to: [Reform Speech Skipped]"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Daria_PromisePrimeMinister == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Daria_PromisePrimeMinister == false"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Daria_PromisePrimeMinister == false)"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Daria_PromisePrimeMinister == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player_Romus: ""I appoint Manus Sazon as interim Prime Minister.""*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Daria_PromisePrimeMinister == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Daria_PromisePrimeMinister"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Reform Speech Skipped`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "I held up the silk sash for everyone to see."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Reform Speech Skipped]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "Reform Speech Skipped"*)
