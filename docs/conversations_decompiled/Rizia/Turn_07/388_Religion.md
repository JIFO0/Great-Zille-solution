# Rizia/Turn 7/Religion

- **ID konwersacji:** `388`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/388_Religion.md`
- **Liczba węzłów dialogowych:** 563
- **Liczba wyborów gracza:** 116

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[87]** Sal Ignacius
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Decision_Turn04_GolcondistPilgrimsPlavo_DeportDerdia`
- `RiziaDLC.Decision_Turn07_InviteSalToHOD`
- `RiziaDLC.Diplomacy_Wehlen_AgreementRefused`
- `RiziaDLC.Focus_Government_Absolutism`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Policy_Law_StateReligion_Wruhecism`
- `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax`
- `RiziaDLC.Policy_RD_Law_NurityStateReligion`
- `RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation`
- `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw`
- `RiziaDLC.Policy_RD_Religion_RemoveStateReligion`
- `RiziaDLC.Prologue_Religious`
- `RiziaDLC.Relations_VinaManus_Approve`
- `RiziaDLC.Relations_VinaManus_ApproveAfterPales`
- `RiziaDLC.Situation_Order_SuOmina_AlliedToCrown`
- `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan`
- `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[387] Rizia/Turn 7/Public Opinion** (../Turn_07/387_Public_Opinion.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[21]` | **""I don't need to hear the minority opinion. Thank you for your endorsement, Mr. Sp..."** | `[20]` **Daria de Rava**: ""The RNC has prepared a statemen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Narrator**: "Daria stepped away from her podi..." |
| `[22]` | **""You may proceed.""** | `[20]` **Daria de Rava**: ""The RNC has prepared a statemen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Daria de Rava**: ""Mr. Speaker, Your Majesty, the ..." |
| `[23]` | **""My decision was final. Any criticism of it will not be tolerated.""** | `[20]` **Daria de Rava**: ""The RNC has prepared a statemen..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[37]` **Narrator**: "Daria stepped away from her podi..." |
| `[27]` | **""'Destabilizing' is a little extreme, don't you think?""** | `[20]` **Daria de Rava**: ""The RNC has prepared a statemen..." | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[79]` **Daria de Rava**: ""I am not being hyperbolic. The ..." |
| `[39]` | **""It may be disruptive in the short term, but my decree is a vital part of my visio..."** | `[34]` **Hugo Toras**: ""The gentleman has a point, Your..."<br>`[36]` **Hugo Toras**: ""The Baroness has a point, Your ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Manus Sazon**: ""Absolutely, Your Majesty. Which..." |
| `[40]` | **""If we are to progress as a nation, we must break the chains of religious dogma th..."** | `[34]` **Hugo Toras**: ""The gentleman has a point, Your..."<br>`[36]` **Hugo Toras**: ""The Baroness has a point, Your ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Manus Sazon**: ""Respectfully, Your Majesty, we ..." |
| `[41]` | **""I do not wish to discount the importance of religion to Rizians. I am merely tryi..."** | `[34]` **Hugo Toras**: ""The gentleman has a point, Your..."<br>`[36]` **Hugo Toras**: ""The Baroness has a point, Your ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Manus Sazon**: ""I understand, Your Majesty. I h..." |
| `[45]` | **""As a God-fearing man myself, I am sensitive to the needs of Rizia's religious com..."** | `[34]` **Hugo Toras**: ""The gentleman has a point, Your..."<br>`[36]` **Hugo Toras**: ""The Baroness has a point, Your ..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Prologue_Religious"] == true` | *Brak zmian stanu* | `[48]` **Manus Sazon**: ""Thank you, Your Majesty. My con..." |
| `[62]` | **""Don't put words in my mouth, Mr. Sazon. A truly egalitarian Rizian society has no..."** | `[50]` **Manus Sazon**: ""But I am sure we can transition..." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0` | *Brak zmian stanu* | `[118]` **Daria de Rava**: ""Superstitions?! Your Majesty--"" |
| `[66]` | **""Certainly. As long as we don't place any one faith above the others.""** | `[50]` **Manus Sazon**: ""But I am sure we can transition..."<br>`[51]` **Manus Sazon**: ""I am sure we can transition awa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Manus Sazon**: ""The RPP agrees."" |
| `[67]` | **""So long as those faiths do not espouse destructive values -- like Golcondism, for..."** | `[51]` **Manus Sazon**: ""I am sure we can transition awa..." | `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true` | *Brak zmian stanu* | `[288]` **Manus Sazon**: ""While we are on that subject..."" |
| `[71]` | **""People may practice whatever they want in private. But they have no business forc..."** | `[50]` **Manus Sazon**: ""But I am sure we can transition..."<br>`[51]` **Manus Sazon**: ""I am sure we can transition awa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Manus Sazon**: ""The RPP agrees."" |
| `[72]` | **""I don't need to hear the minority opinion. Thank you for your endorsement, Mr. Sp..."** | `[61]` **Daria de Rava**: ""The RNC has prepared a statemen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Narrator**: "Daria stepped away from her podi..." |
| `[73]` | **""You may proceed.""** | `[61]` **Daria de Rava**: ""The RNC has prepared a statemen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Daria de Rava**: ""Mr. Speaker, Your Majesty, the ..." |
| `[74]` | **""My decision was final. Any criticism of it will not be tolerated.""** | `[61]` **Daria de Rava**: ""The RNC has prepared a statemen..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[122]` **Narrator**: "Hugo turned to me and spoke quie..." |
| `[78]` | **""'Destabilizing' is a little extreme, don't you think?""** | `[61]` **Daria de Rava**: ""The RNC has prepared a statemen..." | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[123]` **Daria de Rava**: ""I am not speaking hyperbolicall..." |
| `[89]` | **""It may be disruptive in the short term, but my decree is a vital part of my visio..."** | `[84]` **Hugo Toras**: ""The Baroness has a point, Your ..."<br>`[88]` **Hugo Toras**: ""He has a point, Your Majesty.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Manus Sazon**: ""Absolutely, Your Majesty. Which..." |
| `[91]` | **""Changing the state religion to Nurity was only the first step in breaking the cha..."** | `[84]` **Hugo Toras**: ""The Baroness has a point, Your ..."<br>`[88]` **Hugo Toras**: ""He has a point, Your Majesty.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Manus Sazon**: ""Respectfully, Your Majesty, we ..." |
| `[92]` | **""Acknowledging the existence of Dastunity does not mean erasing Wruhecism. This is..."** | `[84]` **Hugo Toras**: ""The Baroness has a point, Your ..."<br>`[88]` **Hugo Toras**: ""He has a point, Your Majesty.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Manus Sazon**: ""I understand, Your Majesty. I h..." |
| `[98]` | **""As a God-fearing Wruhecist myself, I understand these concerns. But spiritual ope..."** | `[84]` **Hugo Toras**: ""The Baroness has a point, Your ..."<br>`[88]` **Hugo Toras**: ""He has a point, Your Majesty.""<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Prologue_Religious"] == true` | *Brak zmian stanu* | `[93]` **Manus Sazon**: ""Well said, Your Majesty."" |
| `[101]` | **""For now, yes. But a truly egalitarian Rizian society has no room for archaic supe..."** | `[100]` **Manus Sazon**: ""I am sure we can transition awa..." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0` | *Brak zmian stanu* | `[118]` **Daria de Rava**: ""Superstitions?! Your Majesty--"" |
| `[110]` | **""I signed the decree with an eye towards Rizians of Rumburgian descent. The opinio..."** | `[105]` **Manus Sazon**: ""In light of our worsening tensi..."<br>`[109]` **Manus Sazon**: ""In light of our new agreement w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[290]` **Manus Sazon**: ""Well, the RPP regards it as an ..." |
| `[111]` | **""Indeed. Our nation must unify beneath the umbrella of the great Nur.""** | `[100]` **Manus Sazon**: ""I am sure we can transition awa..."<br>`[105]` **Manus Sazon**: ""In light of our worsening tensi..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Manus Sazon**: ""At the very least, we must not ..." |
| `[112]` | **""So long as those forms of Nurity do not espouse destructive values -- like Golcon..."** | `[100]` **Manus Sazon**: ""I am sure we can transition awa..." | `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true` | *Brak zmian stanu* | `[288]` **Manus Sazon**: ""While we are on that subject..."" |
| `[116]` | **""Yes, this will go a long way towards reducing animosity between ethnic Rizians an..."** | `[105]` **Manus Sazon**: ""In light of our worsening tensi..."<br>`[109]` **Manus Sazon**: ""In light of our new agreement w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[291]` **Manus Sazon**: ""The RPP agrees."" |
| `[117]` | **""Including Golcondism, as I'm sure I need not remind you.""** | `[100]` **Manus Sazon**: ""I am sure we can transition awa..." | `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false` | *Brak zmian stanu* | `[288]` **Manus Sazon**: ""While we are on that subject..."" |
| `[142]` | **""The Grand Wiseman speaks the truth. What is my reign for, if not to uphold and gl..."** | `[138]` **Sal Ignacius**: ""The King has decided to reinfor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Manus Sazon**: ""I... understand that, Your Maje..." |
| `[143]` | **""Now, Grand Wiseman. Skepticism is a tenet of our religion. I would not prohibit o..."** | `[138]` **Sal Ignacius**: ""The King has decided to reinfor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Manus Sazon**: ""Thank you, Your Majesty."" |
| `[144]` | **""I understand your worries, Mr. Sazon. But the alignment of Rizia's laws with its ..."** | `[138]` **Sal Ignacius**: ""The King has decided to reinfor..."<br>`[135]` **Manus Sazon**: ""And our educational system.""<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false` | *Brak zmian stanu* | `[155]` **Manus Sazon**: ""Where you see alignment, I see ..." |
| `[145]` | **""Sit down, Grand Wiseman. I did not invite you here to speak for me.""** | `[138]` **Sal Ignacius**: ""The King has decided to reinfor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Sal Ignacius**: ""Pardon my interruption. It was ..." |
| `[147]` | **""We are being inundated with non-Wruhecist newcomers. They must respect our state ..."** | `[135]` **Manus Sazon**: ""And our educational system.""<br>`[136]` **Manus Sazon**: ""Our educational system, for exa..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.LeaningValue_Democratic"] < 0  or  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true`<br>`(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false` | *Brak zmian stanu* | `[154]` **Manus Sazon**: ""Migrants cannot be forced into ..." |
| `[148]` | **""What is my reign for, if not to uphold and glorify the sacred laws of St. Wruhec?""** | `[135]` **Manus Sazon**: ""And our educational system.""<br>`[136]` **Manus Sazon**: ""Our educational system, for exa..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false` | *Brak zmian stanu* | `[157]` **Manus Sazon**: ""I... understand that, Your Maje..." |
| `[152]` | **""Need I remind you we are one of the few purely Wruhecist nations on this planet? ..."** | `[135]` **Manus Sazon**: ""And our educational system.""<br>`[136]` **Manus Sazon**: ""Our educational system, for exa..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false` | *Brak zmian stanu* | `[153]` **Manus Sazon**: ""I... understand that, Your Maje..." |
| `[170]` | **""Don't put words in my mouth, Mr. Sazon. I do not embrace any faith, and neither w..."** | `[312]` **Manus Sazon**: ""However... I am sure that under..." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0` | *Brak zmian stanu* | `[190]` **Daria de Rava**: ""The RNC has made our position c..." |
| `[174]` | **""Certainly. As long as we don't place any one faith above the others.""** | `[312]` **Manus Sazon**: ""However... I am sure that under..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Daria de Rava**: ""The RNC has made our position c..." |
| `[175]` | **""So long as those faiths do not espouse destructive values -- like Golcondism, for..."** | `[312]` **Manus Sazon**: ""However... I am sure that under..." | `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true` | *Brak zmian stanu* | `[313]` **Daria de Rava**: ""While we are on that subject..."" |
| `[179]` | **""People may practice whatever they want in private. But they have no business forc..."** | `[312]` **Manus Sazon**: ""However... I am sure that under..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Daria de Rava**: ""The RNC has made our position c..." |
| `[180]` | **""It may be disruptive in the short term, but my decree is a vital part of my visio..."** | `[319]` **Narrator**: "Manus gave me a nod." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Daria de Rava**: ""A kingdom that publicly panders..." |
| `[182]` | **""Changing the state religion to Nurity was only the first step in breaking the cha..."** | `[319]` **Narrator**: "Manus gave me a nod." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[324]` **Daria de Rava**: ""Your Majesty... Wruhecism is an..." |
| `[183]` | **""Acknowledging the existence of Dastunity does not mean erasing Wruhecism. This is..."** | `[319]` **Narrator**: "Manus gave me a nod." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Daria de Rava**: ""We can acknowledge Dastnurists ..." |
| `[189]` | **""As a God-fearing Wruhecist myself, I understand the opposition. But spiritual ope..."** | `[319]` **Narrator**: "Manus gave me a nod." | `Variable["RiziaDLC.Prologue_Religious"] == true` | *Brak zmian stanu* | `[184]` **Daria de Rava**: ""There is openness, and then the..." |
| `[191]` | **""The Grand Wiseman speaks the truth. What is my reign for, if not to uphold and gl..."** | `[237]` **Sal Ignacius**: ""The King has decided to reinfor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Manus Sazon**: ""I... understand that, Your Maje..." |
| `[192]` | **""Now, Grand Wiseman. Skepticism is a tenet of our religion. I would not prohibit o..."** | `[237]` **Sal Ignacius**: ""The King has decided to reinfor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Manus Sazon**: ""Thank you, Your Majesty."" |
| `[193]` | **""I understand your worries, Mr. Sazon. But the alignment of Rizia's laws with its ..."** | `[237]` **Sal Ignacius**: ""The King has decided to reinfor..."<br>`[216]` **Manus Sazon**: ""And our educational system.""<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false` | *Brak zmian stanu* | `[204]` **Manus Sazon**: ""Where you see alignment, I see ..." |
| `[194]` | **""Sit down, Grand Wiseman. I did not invite you here to speak for me.""** | `[237]` **Sal Ignacius**: ""The King has decided to reinfor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Sal Ignacius**: ""Pardon my interruption. It was ..." |
| `[196]` | **""We are being inundated with non-Wruhecist newcomers. They must respect our state ..."** | `[216]` **Manus Sazon**: ""And our educational system.""<br>`[225]` **Manus Sazon**: ""We see it in our educational sy..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.LeaningValue_Democratic"] < 0  or  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true`<br>`(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false` | *Brak zmian stanu* | `[203]` **Manus Sazon**: ""Forcing migrants to embrace Wru..." |
| `[197]` | **""What is my reign for, if not to uphold and glorify the sacred laws of St. Wruhec?""** | `[216]` **Manus Sazon**: ""And our educational system.""<br>`[225]` **Manus Sazon**: ""We see it in our educational sy..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false` | *Brak zmian stanu* | `[206]` **Manus Sazon**: ""I... understand that, Your Maje..." |
| `[201]` | **""Need I remind you we are one of the few purely Wruhecist nations on this planet? ..."** | `[216]` **Manus Sazon**: ""And our educational system.""<br>`[225]` **Manus Sazon**: ""We see it in our educational sy..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false` | *Brak zmian stanu* | `[202]` **Manus Sazon**: ""I... understand that, Your Maje..." |
| `[242]` | **""It may be disruptive in the short term, but my decree is a vital part of my visio..."** | `[210]` **Narrator**: "She banged her gavel." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[250]` **Daria de Rava**: ""A kingdom without its spiritual..." |
| `[246]` | **""As a God-fearing man myself, I am offended by your disproval. My intention was no..."** | `[210]` **Narrator**: "She banged her gavel." | `Variable["RiziaDLC.Prologue_Religious"] == true` | *Brak zmian stanu* | `[260]` **Daria de Rava**: ""Religions cannot flourish in a ..." |
| `[247]` | **""Your disproval has been noted. But Rizia will never return to the shackles of rel..."** | `[210]` **Narrator**: "She banged her gavel." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0` | *Brak zmian stanu* | `[255]` **Daria de Rava**: ""Your Majesty... Wruhecism is an..." |
| `[248]` | **""Mr. Sazon? No objections from your party?""** | `[210]` **Narrator**: "She banged her gavel." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Manus Sazon**: ""Actually, Your Majesty, many of..." |
| `[249]` | **""I am offended by your disproval. My intention was not to erase Wruhecism, but to ..."** | `[210]` **Narrator**: "She banged her gavel." | `(Variable["RiziaDLC.Prologue_Religious"] == true) == false` | *Brak zmian stanu* | `[260]` **Daria de Rava**: ""Religions cannot flourish in a ..." |
| `[256]` | **""The shackles are invisible. That's what makes them so dangerous.""** | `[255]` **Daria de Rava**: ""Your Majesty... Wruhecism is an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[309]` **Narrator**: "Manus hesitantly put up a hand." |
| `[257]` | **""A truly egalitarian society has no room for archaic superstitions of any kind.""** | `[255]` **Daria de Rava**: ""Your Majesty... Wruhecism is an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[309]` **Narrator**: "Manus hesitantly put up a hand." |
| `[259]` | **""I tire of this discussion, Madame Speaker. Please proceed to your next topic.""** | `[255]` **Daria de Rava**: ""Your Majesty... Wruhecism is an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[309]` **Narrator**: "Manus hesitantly put up a hand." |
| `[261]` | **""It is a meaningless distraction meant to keep the poor and downtrodden from quest..."** | `[255]` **Daria de Rava**: ""Your Majesty... Wruhecism is an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[309]` **Narrator**: "Manus hesitantly put up a hand." |
| `[267]` | **""I disagree. Our kingdom cannot prosper if it is suffering from spiritual bankrupt..."** | `[265]` **Manus Sazon**: ""Ultimately, religion should hav..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Daria de Rava**: ""Well said, Your Majesty."" |
| `[268]` | **""But look at the income the tax generates. It can be used to help the less fortuna..."** | `[265]` **Manus Sazon**: ""Ultimately, religion should hav..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[293]` **Daria de Rava**: ""Precisely, Your Majesty. The Ho..." |
| `[269]` | **""I stand by my decision. Businesses cannot take advantage of our resources while i..."** | `[265]` **Manus Sazon**: ""Ultimately, religion should hav..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Daria de Rava**: ""Well said, Your Majesty."" |
| `[270]` | **""Heathens and blasphemers have no place in our economy, Mr. Sazon. They must submi..."** | `[265]` **Manus Sazon**: ""Ultimately, religion should hav..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Daria de Rava**: ""Well said, Your Majesty."" |
| `[271]` | **""Parents do not always know what is best for their children.""** | `[266]` **Manus Sazon**: ""Ultimately, a child's religious..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Narrator**: "Manus choked back a laugh."<br>`[279]` **Manus Sazon**: ""No. But removing their right to..." |
| `[272]` | **""We are one of the few Wruhecist countries in this world. If we do not pass on our..."** | `[266]` **Manus Sazon**: ""Ultimately, a child's religious..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[281]` **Manus Sazon**: ""Isn't that what our religious i..." |
| `[273]` | **""The teachings of St. Wruhec are as valuable as reading, writing and arithmetic. T..."** | `[266]` **Manus Sazon**: ""Ultimately, a child's religious..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Manus Sazon**: ""I worry that will foster an atm..." |
| `[280]` | **""Providing each Rizian child with a Wruhecist education will foster a stronger sen..."** | `[266]` **Manus Sazon**: ""Ultimately, a child's religious..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Manus Sazon**: ""Or it will foster an atmosphere..." |
| `[316]` | **""No. I want to know the RPP's opinion.""** | `[315]` **Daria de Rava**: ""The Delegates have given their ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Daria de Rava**: ""Very well. You may proceed, Mr...." |
| `[317]` | **""Do not attempt to silence your fellow delegates, Madame Speaker.""** | `[315]` **Daria de Rava**: ""The Delegates have given their ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Daria de Rava**: ""Very well. You may proceed, Mr...." |
| `[318]` | **""I appreciate your support, Mr. Sazon, but your input is not needed. I stand by my..."** | `[315]` **Daria de Rava**: ""The Delegates have given their ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Narrator**: "Manus gave me a nod." |
| `[325]` | **""The shackles are invisible. That's what makes them so dangerous.""** | `[324]` **Daria de Rava**: ""Your Majesty... Wruhecism is an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[338]` **Narrator**: "She swallowed." |
| `[326]` | **""A truly egalitarian society has no room for archaic superstitions of any kind.""** | `[324]` **Daria de Rava**: ""Your Majesty... Wruhecism is an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Daria de Rava**: ""Superstitions?!"" |
| `[327]` | **""I tire of this discussion, Madame Speaker. Please proceed to your next topic.""** | `[324]` **Daria de Rava**: ""Your Majesty... Wruhecism is an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[338]` **Narrator**: "She swallowed." |
| `[328]` | **""It is a meaningless distraction meant to keep the poor and downtrodden from quest..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[330]` **Daria de Rava**: ""A meaningless distraction?!"" |
| `[345]` | **""I signed the decree with an eye towards Rizians of Rumburgian descent. The opinio..."** | `[340]` **Manus Sazon**: ""In light of our worsening tensi..."<br>`[344]` **Manus Sazon**: ""In light of our new agreement w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Manus Sazon**: ""Well, the RPP regards it as an ..." |
| `[346]` | **""Indeed. Our nation must unify beneath the umbrella of the great Nur.""** | `[340]` **Manus Sazon**: ""In light of our worsening tensi..."<br>`[344]` **Manus Sazon**: ""In light of our new agreement w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[350]` **Manus Sazon**: ""At the very least, we must not ..." |
| `[348]` | **""Yes, this will go a long way towards reducing animosity between ethnic Rizians an..."** | `[340]` **Manus Sazon**: ""In light of our worsening tensi..."<br>`[344]` **Manus Sazon**: ""In light of our new agreement w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[349]` **Manus Sazon**: ""The RPP agrees."" |
| `[365]` | **""It's always valuable to know the opposition's opinion. Go ahead, Mr. Sazon.""** | `[364]` **Daria de Rava**: ""I don't see the need to air the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Narrator**: "Manus cleared his throat. He gla..."<br>`[372]` **Narrator**: "Manus cleared his throat." |
| `[366]` | **""Nor do I. We shall not change the religious direction of this country, not when s..."** | `[364]` **Daria de Rava**: ""I don't see the need to air the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[373]` **Sal Ignacius**: ""Halaita, Your Majesty.""<br>`[377]` **Daria de Rava**: ""As the King proclaims, so it sh..." |
| `[367]` | **""I would be curious to know what blasphemous thoughts Mr. Sazon has rolling about ..."** | `[364]` **Daria de Rava**: ""I don't see the need to air the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Narrator**: "Manus cleared his throat. He gla..."<br>`[372]` **Narrator**: "Manus cleared his throat." |
| `[384]` | **""They will see the light, or they will pay the price.""** | `[380]` **Daria de Rava**: ""However, they have signalled th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Daria de Rava**: ""I have no doubt of that."" |
| `[385]` | **""Rumburgian corporations are wealthy. They can afford it.""** | `[380]` **Daria de Rava**: ""However, they have signalled th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Daria de Rava**: ""I have no doubt of that."" |
| `[386]` | **""I'm sure there are all sorts of loopholes they can exploit if need be.""** | `[380]` **Daria de Rava**: ""However, they have signalled th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Daria de Rava**: ""I have no doubt of that."" |
| `[387]` | **""Good. We still need Rumburg on our side.""** | `[380]` **Daria de Rava**: ""However, they have signalled th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[389]` **Daria de Rava**: ""The tax should not cost us the ..." |
| `[397]` | **""I disagree. Our kingdom cannot prosper if it is suffering from spiritual bankrupt..."** | `[395]` **Manus Sazon**: ""Ultimately, religion should hav..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[427]` **Daria de Rava**: ""Well said, Your Majesty."" |
| `[398]` | **""But look at the income the tax generates. It can be used to help the less fortuna..."** | `[395]` **Manus Sazon**: ""Ultimately, religion should hav..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[426]` **Daria de Rava**: ""Precisely, Your Majesty. The op..." |
| `[399]` | **""I stand by my decision. Businesses cannot take advantage of our resources while i..."** | `[395]` **Manus Sazon**: ""Ultimately, religion should hav..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[427]` **Daria de Rava**: ""Well said, Your Majesty."" |
| `[400]` | **""Heathens and blasphemers have no place in our economy, Mr. Sazon. They must submi..."** | `[395]` **Manus Sazon**: ""Ultimately, religion should hav..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[427]` **Daria de Rava**: ""Well said, Your Majesty."" |
| `[401]` | **""Parents do not always know what is best for their children.""** | `[396]` **Manus Sazon**: ""Ultimately, a child's religious..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Narrator**: "Manus choked back a laugh."<br>`[409]` **Manus Sazon**: ""No. But removing their right to..." |
| `[402]` | **""We are one of the few Wruhecist countries in this world. If we do not pass on our..."** | `[396]` **Manus Sazon**: ""Ultimately, a child's religious..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[411]` **Manus Sazon**: ""Isn't that what our religious i..." |
| `[403]` | **""The teachings of St. Wruhec are as valuable as reading, writing and arithmetic. T..."** | `[396]` **Manus Sazon**: ""Ultimately, a child's religious..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[412]` **Manus Sazon**: ""I worry that will foster an atm..." |
| `[410]` | **""Providing each Rizian child with a Wruhecist education will foster a stronger sen..."** | `[396]` **Manus Sazon**: ""Ultimately, a child's religious..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[413]` **Manus Sazon**: ""Or it will foster an atmosphere..." |
| `[441]` | **""A ridiculous accusation. Did I not allow Golcondist pilgrims to occupy the Plavo ..."** | `[440]` **Manus Sazon**: ""They point to it as evidence th..." | `Variable["RiziaDLC.Decision_Turn04_GolcondistPilgrimsPlavo_DeportDerdia"] == false` | *Brak zmian stanu* | `[448]` **Manus Sazon**: ""Yes, but it was expected that t..." |
| `[445]` | **""It is not discriminatory to crack down on terrorism.""** | `[436]` **Manus Sazon**: ""Together with the border ban we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[451]` **Manus Sazon**: ""We have no evidence that the Go..." |
| `[446]` | **""Yes, and what is wrong with that? Golcondism is totally incompatible with modern ..."** | `[436]` **Manus Sazon**: ""Together with the border ban we..."<br>`[440]` **Manus Sazon**: ""They point to it as evidence th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[452]` **Manus Sazon**: ""Some of its followers may hold ..." |
| `[447]` | **""Lifting the blasphemy law has long been on my agenda. I will make it my priority.""** | `[436]` **Manus Sazon**: ""Together with the border ban we..."<br>`[440]` **Manus Sazon**: ""They point to it as evidence th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[453]` **Manus Sazon**: ""Granting all citizens an equal ..." |
| `[449]` | **""Nonsense. I simply believe real Wruhecists have the right to worship in peace.""** | `[436]` **Manus Sazon**: ""Together with the border ban we..."<br>`[440]` **Manus Sazon**: ""They point to it as evidence th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[454]` **Manus Sazon**: ""Golcondists do consider themsel..." |
| `[450]` | **""Golcondists are Wruhecists like any others. Their beliefs are as valid as yours o..."** | `[468]` **Manus Sazon**: ""Especially if Rizia is to reope..." | `Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true` | *Brak zmian stanu* | `[473]` **Manus Sazon**: ""I agree, Your Majesty. I person..." |
| `[456]` | **""I gave all Rizians an equal right to worship, regardless of religion. It's not li..."** | `[468]` **Manus Sazon**: ""Especially if Rizia is to reope..." | `(Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true) == false` | *Brak zmian stanu* | `[473]` **Manus Sazon**: ""I agree, Your Majesty. I person..." |
| `[460]` | **""The public has been scared away by decades of harmful stereotypes. They'll warm u..."** | `[468]` **Manus Sazon**: ""Especially if Rizia is to reope..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[474]` **Manus Sazon**: ""That is my party's hope as well."" |
| `[461]` | **""We need Derdia's help in the war. Accepting Golcondists is all part of my strategy.""** | `[468]` **Manus Sazon**: ""Especially if Rizia is to reope..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[476]` **Manus Sazon**: ""Whatever the intention, I regar..." |
| `[469]` | **""The concerns are over nothing. I don't want to have anything to do with Derdia.""** | `[468]` **Manus Sazon**: ""Especially if Rizia is to reope..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[475]` **Manus Sazon**: ""The RPP is not opposed to deali..." |
| `[481]` | **""Even if the blasphemy law is revoked, Rizia will never turn into Derdia.""** | `[479]` **Manus Sazon**: ""But there are those who are wor..."<br>`[480]` **Manus Sazon**: ""There are those who are worried..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[489]` **Manus Sazon**: ""Yes, I also believe these fears..." |
| `[482]` | **""Would that be so bad? We have much to learn from our Derdian neighbors.""** | `[479]` **Manus Sazon**: ""But there are those who are wor..."<br>`[480]` **Manus Sazon**: ""There are those who are worried..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[490]` **Manus Sazon**: ""Your Majesty, there is a reason..." |
| `[486]` | **""We may need Derdia's help in the war. But I will not make any ideological concess..."** | `[479]` **Manus Sazon**: ""But there are those who are wor..."<br>`[480]` **Manus Sazon**: ""There are those who are worried..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[488]` **Manus Sazon**: ""I do not view the revocation of..." |
| `[487]` | **""These worries are unfounded. The blasphemy law is staying in place.""** | `[479]` **Manus Sazon**: ""But there are those who are wor..."<br>`[480]` **Manus Sazon**: ""There are those who are worried..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[491]` **Manus Sazon**: ""I still believe the benefits of..." |
| `[498]` | **""Golcondists are Wruhecists like any others. Their beliefs are as valid as yours o..."** | `[505]` **Daria de Rava**: ""Especially ahead of Rizia's upc..." | `Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true` | *Brak zmian stanu* | `[507]` **Daria de Rava**: ""Our respected religious leaders..." |
| `[499]` | **""I gave all Rizians an equal right to worship, regardless of religion. It's not li..."** | `[505]` **Daria de Rava**: ""Especially ahead of Rizia's upc..." | `(Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true) == false` | *Brak zmian stanu* | `[513]` **Daria de Rava**: ""Many religious leaders, our Gra..." |
| `[503]` | **""The public has been scared away by decades of harmful stereotypes. They'll warm u..."** | `[505]` **Daria de Rava**: ""Especially ahead of Rizia's upc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[514]` **Daria de Rava**: ""Their fears about Golcondists a..." |
| `[504]` | **""We need Derdia's help in the war. Accepting Golcondists is all part of my strategy.""** | `[505]` **Daria de Rava**: ""Especially ahead of Rizia's upc..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[516]` **Daria de Rava**: ""I respect that. But we must be ..." |
| `[506]` | **""The concerns are over nothing. Rizia will never turn into Derdia.""** | `[505]` **Daria de Rava**: ""Especially ahead of Rizia's upc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[515]` **Daria de Rava**: ""No. Not as long as the majority..." |
| `[526]` | **""Still, I find the accusations worrying. I do not want my citizens to feel discrim..."** | `[555]` **Narrator**: "My uncle looked relieved. He nod..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[530]` **Manus Sazon**: ""My party agrees, Your Majesty. ..." |
| `[527]` | **""Good. Because I have no intention of lifting it.""** | `[555]` **Narrator**: "My uncle looked relieved. He nod..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[531]` **Manus Sazon**: ""I must object, Your Majesty. Ev..." |
| `[536]` | **""What's wrong with discrimination against Golcondists? Their faith is totally inco..."** | `[555]` **Narrator**: "My uncle looked relieved. He nod..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[529]` **Manus Sazon**: ""I must object, Your Majesty. We..." |
| `[537]` | **""It is not discriminatory to crack down on terrorism.""** | `[555]` **Narrator**: "My uncle looked relieved. He nod..." | `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true` | *Brak zmian stanu* | `[528]` **Manus Sazon**: ""I must object, your Majesty. We..." |
| `[550]` | **""Even if the blasphemy law is revoked, Rizia will never turn into Derdia. Our trad..."** | `[549]` **Daria de Rava**: ""We have seen the influence of G..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[552]` **Daria de Rava**: ""I should hope so."" |
| `[551]` | **""Would that be so bad? We have much to learn from Supreme Wiseman Azmal and his pe..."** | `[549]` **Daria de Rava**: ""We have seen the influence of G..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[553]` **Daria de Rava**: ""Your Majesty, there is a reason..." |
| `[557]` | **""I admit we need Derdia's help in the war. But I will not make any ideological con..."** | `[549]` **Daria de Rava**: ""We have seen the influence of G..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[561]` **Daria de Rava**: ""Very good."" |

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
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[3]`
Mówca: **Manus Sazon**
> ""Next on the agenda is a discussion regarding the current religious climate in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Manus Sazon: ""Next on the agenda is a discussion regarding the current..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Daria de Rava: ""Next on the agenda was a discussion regarding the curren..."*)

### Węzeł `[7]`
Mówca: **Daria de Rava**
> ""Next on the agenda was a discussion regarding the current religious climate in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "He looked uneasily at Sal."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true"*)

### Węzeł `[11]`
Mówca: **Narrator**
> "He looked uneasily at Sal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Manus Sazon: ""More specifically, King Romus' decision to remove our ki..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Law_NurityStateReligion == true"*)

### Węzeł `[15]`
Mówca: **Manus Sazon**
> ""More specifically, King Romus' decision to remove our kingdom's state religion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Manus Sazon: ""We are acutely aware of the important role that Wruhecis..."*)

### Węzeł `[16]`
Mówca: **Manus Sazon**
> ""We are acutely aware of the important role that Wruhecism, and Nurity as a whole, plays in the lives of our citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Manus Sazon: ""And we know that this policy change has been met with re..."*)

### Węzeł `[17]`
Mówca: **Manus Sazon**
> ""However, the RPP cautiously welcomes our kingdom's move towards a more secular state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Manus Sazon: ""His Majesty's decree, however controversial, is a step t..."*)

### Węzeł `[18]`
Mówca: **Manus Sazon**
> ""His Majesty's decree, however controversial, is a step towards ensuring all Rizians are equal before the law, regardless of what they believe in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "Daria raised her hand to interject."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "Daria raised her hand to interject."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Daria de Rava: ""The RNC has prepared a statement opposing this unprecede..."*)

### Węzeł `[20]`
Mówca: **Daria de Rava**
> ""The RNC has prepared a statement opposing this unprecedented and potentially destabilizing separation of Sanctuary and state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""I don't need to hear the minority opinion. Thank you for..."*)
  - -> `[22]` (*Player_Romus: ""You may proceed.""*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't need to hear the minority opinion. Thank you for your endorsement, Mr. Speaker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "Daria stepped away from her podium, fuming. Manus frowned..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may proceed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Daria de Rava: ""Mr. Speaker, Your Majesty, the secularization of Rizia r..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My decision was final. Any criticism of it will not be tolerated.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[20]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "Daria stepped away from her podium, fuming. Manus frowned..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: ""My decision was final. Any criticism of it will not be t..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player_Romus: ""'Destabilizing' is a little extreme, don't you think?""*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Destabilizing' is a little extreme, don't you think?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[20]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Daria de Rava: ""I am not being hyperbolic. The secularization of Rizia h..."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "Daria stepped away from her podium, fuming. Manus frowned briefly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Manus Sazon: ""I will add that the opposition's arguments against the K..."*)

### Węzeł `[29]`
Mówca: **Daria de Rava**
> ""Mr. Speaker, Your Majesty, the secularization of Rizia risks creating vast rifts in a society that can hardly afford more division.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Daria de Rava: ""By erasing religious symbols and institutions from the p..."*)

### Węzeł `[30]`
Mówca: **Daria de Rava**
> ""By erasing religious symbols and institutions from the public sphere, we are telling millions of citizens that the government no longer cares about their faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Daria de Rava: ""If the goal is to create a more inclusive religious atmo..."*)

### Węzeł `[31]`
Mówca: **Daria de Rava**
> ""If the goal is to create a more inclusive religious atmosphere in Rizia, we can do that without negating the principles that have guided our kingdom since its foundation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "Hugo spoke quietly."*)

### Węzeł `[32]`
Mówca: **Manus Sazon**
> ""I will add that the opposition's arguments against the King's decree are not without merit. We must proceed with sensitivity or risk alienating a significant portion of Rizian society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Hugo spoke quietly."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "Hugo spoke quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Hugo Toras: ""The gentleman has a point, Your Majesty.""*)

### Węzeł `[34]`
Mówca: **Hugo Toras**
> ""The gentleman has a point, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player_Romus: ""I do not wish to discount the importance of religion to ..."*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[39]` (*Player_Romus: ""It may be disruptive in the short term, but my decree is..."*)
  - -> `[40]` (*Player_Romus: ""If we are to progress as a nation, we must break the cha..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "Hugo spoke quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Hugo Toras: ""The Baroness has a point, Your Majesty.""*)

### Węzeł `[36]`
Mówca: **Hugo Toras**
> ""The Baroness has a point, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player_Romus: ""I do not wish to discount the importance of religion to ..."*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[39]` (*Player_Romus: ""It may be disruptive in the short term, but my decree is..."*)
  - -> `[40]` (*Player_Romus: ""If we are to progress as a nation, we must break the cha..."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "Daria stepped away from her podium, fuming. Manus frowned briefly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "Hugo turned to me and spoke quietly."*)

### Węzeł `[38]`
Mówca: **Manus Sazon**
> ""And we know that this policy change has been met with resistance from all of Rizia's religious communities, be they Wruhecist, Golcondist or Dastnurist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Manus Sazon: ""However, the RPP cautiously welcomes our kingdom's move ..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It may be disruptive in the short term, but my decree is a vital part of my vision for a modern, globally connected kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Hugo Toras), `[36]` (Hugo Toras), `[120]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Manus Sazon: ""Absolutely, Your Majesty. Which is why we stand behind it.""*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we are to progress as a nation, we must break the chains of religious dogma that shackle us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Hugo Toras), `[36]` (Hugo Toras), `[120]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Manus Sazon: ""Respectfully, Your Majesty, we cannot force chains off o..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do not wish to discount the importance of religion to Rizians. I am merely trying to reduce its role in government.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Hugo Toras), `[36]` (Hugo Toras), `[120]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Manus Sazon: ""I understand, Your Majesty. I have no doubt that your de..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Religious == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player_Romus: ""As a God-fearing man myself, I am sensitive to the needs..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Religious == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a God-fearing man myself, I am sensitive to the needs of Rizia's religious communities. I will make sure nobody feels left out.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Kontekst wejściowy (poprzednik):** `[34]` (Hugo Toras), `[36]` (Hugo Toras), `[120]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Manus Sazon: ""Thank you, Your Majesty. My constituents will be comfort..."*)

### Węzeł `[46]`
Mówca: **Manus Sazon**
> ""Absolutely, Your Majesty. Which is why we stand behind it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Manus Sazon: ""But I am sure we can transition away from state-enshrine..."*)

### Węzeł `[47]`
Mówca: **Manus Sazon**
> ""Respectfully, Your Majesty, we cannot force chains off of those who do not see themselves as shackled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Manus Sazon: ""But I am sure we can transition away from state-enshrine..."*)

### Węzeł `[48]`
Mówca: **Manus Sazon**
> ""Thank you, Your Majesty. My constituents will be comforted to know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Manus Sazon: ""I am sure we can transition away from state-enshrined Wr..."*)

### Węzeł `[49]`
Mówca: **Manus Sazon**
> ""I understand, Your Majesty. I have no doubt that your decree will open more doors for us than it will close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Manus Sazon: ""I am sure we can transition away from state-enshrined Wr..."*)

### Węzeł `[50]`
Mówca: **Manus Sazon**
> ""But I am sure we can transition away from state-enshrined Wruhecism while continuing to embrace faith in all of its different forms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player_Romus: ""People may practice whatever they want in private. But t..."*)
  - -> `[66]` (*Player_Romus: ""Certainly. As long as we don't place any one faith above..."*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)

### Węzeł `[51]`
Mówca: **Manus Sazon**
> ""I am sure we can transition away from state-enshrined Wruhecism while embracing faith in all of its different forms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)
  - -> `[71]` (*Player_Romus: ""People may practice whatever they want in private. But t..."*)
  - -> `[66]` (*Player_Romus: ""Certainly. As long as we don't place any one faith above..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Law_NurityStateReligion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Law_NurityStateReligion == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Law_NurityStateReligion == true)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Law_NurityStateReligion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Law_NurityStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Manus Sazon: ""More specifically, King Romus' decision to change our st..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Law_NurityStateReligion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Law_NurityStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == tr..."*)

### Węzeł `[55]`
Mówca: **Manus Sazon**
> ""More specifically, King Romus' decision to change our state religion to encompass all denominations of Nurity, not only Wruhecism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Manus Sazon: ""We are acutely aware of the important role that Wruhecis..."*)

### Węzeł `[56]`
Mówca: **Manus Sazon**
> ""We are acutely aware of the important role that Wruhecism plays in the lives of many of our citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Manus Sazon: ""And we know that this policy change has been met with re..."*)

### Węzeł `[57]`
Mówca: **Manus Sazon**
> ""And we know that this policy change has been met with resistance from Wruhecist and Golcondist religious leaders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Manus Sazon: ""However, the RPP welcomes our kingdom's move towards rel..."*)

### Węzeł `[58]`
Mówca: **Manus Sazon**
> ""However, the RPP welcomes our kingdom's move towards religious inclusivity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Manus Sazon: ""His Majesty's decree is a step towards ensuring all Rizi..."*)

### Węzeł `[59]`
Mówca: **Manus Sazon**
> ""His Majesty's decree is a step towards ensuring all Rizians are equal before the law, regardless of belief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "Daria raised her hand to interject."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "Daria raised her hand to interject."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Daria de Rava: ""The RNC has prepared a statement opposing this unnecessa..."*)

### Węzeł `[61]`
Mówca: **Daria de Rava**
> ""The RNC has prepared a statement opposing this unnecessary and potentially destabilizing dilution of our religious policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player_Romus: ""I don't need to hear the minority opinion. Thank you for..."*)
  - -> `[73]` (*Player_Romus: ""You may proceed.""*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't put words in my mouth, Mr. Sazon. A truly egalitarian Rizian society has no room for archaic superstitions of any kind.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Kontekst wejściowy (poprzednik):** `[50]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Daria de Rava: ""Superstitions?! Your Majesty--""*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 0)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player_Romus: ""Don't put words in my mouth, Mr. Sazon. A truly egalitar..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Certainly. As long as we don't place any one faith above the others.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Manus Sazon), `[51]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Manus Sazon: ""The RPP agrees.""*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So long as those faiths do not espouse destructive values -- like Golcondism, for example.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Kontekst wejściowy (poprzednik):** `[51]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Manus Sazon: ""While we are on that subject...""*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLa..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player_Romus: ""So long as those faiths do not espouse destructive value..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""People may practice whatever they want in private. But they have no business forcing that practice on others.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Manus Sazon), `[51]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Manus Sazon: ""The RPP agrees.""*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't need to hear the minority opinion. Thank you for your endorsement, Mr. Speaker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "Daria stepped away from her podium, fuming. Manus frowned..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may proceed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Daria de Rava: ""Mr. Speaker, Your Majesty, the broadening of our state r..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My decision was final. Any criticism of it will not be tolerated.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[61]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "Hugo turned to me and spoke quietly."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player_Romus: ""My decision was final. Any criticism of it will not be t..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player_Romus: ""'Destabilizing' is a little extreme, don't you think?""*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Destabilizing' is a little extreme, don't you think?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[61]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Daria de Rava: ""I am not speaking hyperbolically. The broadening of our ..."*)

### Węzeł `[79]`
Mówca: **Daria de Rava**
> ""I am not being hyperbolic. The secularization of Rizia has the potential to create vast rifts in our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Daria de Rava: ""By erasing religious symbols and institutions from the p..."*)

### Węzeł `[80]`
Mówca: **Daria de Rava**
> ""Mr. Speaker, Your Majesty, the broadening of our state religion has the potential to create vast rifts in our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Daria de Rava: ""We are essentially telling the millions of Wruhecist bel..."*)

### Węzeł `[81]`
Mówca: **Daria de Rava**
> ""We are essentially telling the millions of Wruhecist believers in this country that their faith is no different from Dastnurity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Daria de Rava: ""If the goal is to create a more inclusive religious atmo..."*)

### Węzeł `[82]`
Mówca: **Daria de Rava**
> ""If the goal is to create a more inclusive religious atmosphere in Rizia, we can do that without negating the practices and traditions that have guided our kingdom since its foundation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "Hugo spoke quietly."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "Hugo spoke quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Hugo Toras: ""The Baroness has a point, Your Majesty.""*)

### Węzeł `[84]`
Mówca: **Hugo Toras**
> ""The Baroness has a point, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player_Romus: ""Acknowledging the existence of Dastunity does not mean e..."*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[89]` (*Player_Romus: ""It may be disruptive in the short term, but my decree is..."*)
  - -> `[91]` (*Player_Romus: ""Changing the state religion to Nurity was only the first..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "Daria stepped away from her podium, fuming. Manus frowned briefly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Manus Sazon: ""I will add that the opposition's arguments against the K..."*)

### Węzeł `[86]`
Mówca: **Manus Sazon**
> ""I will add that the opposition's arguments against the King's decree are not without merit. We must proceed with caution or risk alienating a significant portion of Rizian society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "Hugo spoke quietly."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "Hugo spoke quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Hugo Toras: ""He has a point, Your Majesty.""*)

### Węzeł `[88]`
Mówca: **Hugo Toras**
> ""He has a point, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player_Romus: ""Acknowledging the existence of Dastunity does not mean e..."*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[89]` (*Player_Romus: ""It may be disruptive in the short term, but my decree is..."*)
  - -> `[91]` (*Player_Romus: ""Changing the state religion to Nurity was only the first..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It may be disruptive in the short term, but my decree is a vital part of my vision for a modern, globally connected kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Hugo Toras), `[88]` (Hugo Toras), `[121]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Manus Sazon: ""Absolutely, Your Majesty. Which is why we stand behind it.""*)

### Węzeł `[90]`
Mówca: **Manus Sazon**
> ""Absolutely, Your Majesty. Which is why we stand behind it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Manus Sazon: ""I am sure we can transition away from state-enshrined Wr..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Changing the state religion to Nurity was only the first step in breaking the chains of religious dogma that shackle us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Hugo Toras), `[88]` (Hugo Toras), `[121]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Manus Sazon: ""Respectfully, Your Majesty, we cannot force chains off o..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Acknowledging the existence of Dastunity does not mean erasing Wruhecism. This is not a zero-sum game.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Hugo Toras), `[88]` (Hugo Toras), `[121]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Manus Sazon: ""I understand, Your Majesty. I have no doubt that your de..."*)

### Węzeł `[93]`
Mówca: **Manus Sazon**
> ""Well said, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true"*)

### Węzeł `[94]`
Mówca: **Manus Sazon**
> ""I understand, Your Majesty. I have no doubt that your decree will open more doors for us than it will close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Religious == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player_Romus: ""As a God-fearing Wruhecist myself, I understand these co..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Religious == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a God-fearing Wruhecist myself, I understand these concerns. But spiritual openness is one of our core principles. Limiting our state religion to only one branch of Nurity is a betrayal of that.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Kontekst wejściowy (poprzednik):** `[84]` (Hugo Toras), `[88]` (Hugo Toras), `[121]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Manus Sazon: ""Well said, Your Majesty.""*)

### Węzeł `[99]`
Mówca: **Manus Sazon**
> ""Respectfully, Your Majesty, we cannot force chains off of those who do not see themselves as shackled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Manus Sazon: ""I am sure we can transition away from state-enshrined Wr..."*)

### Węzeł `[100]`
Mówca: **Manus Sazon**
> ""I am sure we can transition away from state-enshrined Wruhecism while continuing to embrace the Nurist faith in all of its forms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player_Romus: ""Indeed. Our nation must unify beneath the umbrella of th..."*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For now, yes. But a truly egalitarian Rizian society has no room for archaic superstitions of any kind.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Kontekst wejściowy (poprzednik):** `[100]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Daria de Rava: ""Superstitions?! Your Majesty--""*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 0)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player_Romus: ""For now, yes. But a truly egalitarian Rizian society has..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[105]`
Mówca: **Manus Sazon**
> ""In light of our worsening tensions with Wehlen, it's important to send our Wehzek citizens the signal that they are still welcome here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player_Romus: ""I signed the decree with an eye towards Rizians of Rumbu..."*)
  - -> `[116]` (*Player_Romus: ""Yes, this will go a long way towards reducing animosity ..."*)
  - -> `[111]` (*Player_Romus: ""Indeed. Our nation must unify beneath the umbrella of th..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Manus Sazon: ""In light of our worsening tensions with Wehlen, it's imp..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Manus Sazon: ""In light of our new agreement with Wehlen, it's importan..."*)

### Węzeł `[109]`
Mówca: **Manus Sazon**
> ""In light of our new agreement with Wehlen, it's important to send our Wehzek citizens the signal that they are welcome here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player_Romus: ""I signed the decree with an eye towards Rizians of Rumbu..."*)
  - -> `[116]` (*Player_Romus: ""Yes, this will go a long way towards reducing animosity ..."*)
  - -> `[111]` (*Player_Romus: ""Indeed. Our nation must unify beneath the umbrella of th..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I signed the decree with an eye towards Rizians of Rumburgian descent. The opinion of Wehzeks is of no consequence.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Manus Sazon), `[109]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Manus Sazon: ""Well, the RPP regards it as an important side effect.""*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. Our nation must unify beneath the umbrella of the great Nur.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Manus Sazon), `[105]` (Manus Sazon), `[109]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Manus Sazon: ""At the very least, we must not let religious differences..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So long as those forms of Nurity do not espouse destructive values -- like Golcondism, for example.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Kontekst wejściowy (poprzednik):** `[100]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Manus Sazon: ""While we are on that subject...""*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLa..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player_Romus: ""So long as those forms of Nurity do not espouse destruct..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player_Romus: ""Including Golcondism, as I'm sure I need not remind you.""*)

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, this will go a long way towards reducing animosity between ethnic Rizians and those of Wehzek descent.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Manus Sazon), `[109]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Manus Sazon: ""The RPP agrees.""*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Including Golcondism, as I'm sure I need not remind you.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[100]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Manus Sazon: ""While we are on that subject...""*)

### Węzeł `[118]`
Mówca: **Daria de Rava**
> ""Superstitions?! Your Majesty--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Narrator: "Manus gave her a look of warning. She closed her mouth."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "Hugo turned to me and spoke quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Hugo Toras: ""Your Majesty, I urge you to take the opposition to your ..."*)

### Węzeł `[120]`
Mówca: **Hugo Toras**
> ""Your Majesty, I urge you to take the opposition to your decree seriously. I too worry about its potential to alienate millions of our citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player_Romus: ""I do not wish to discount the importance of religion to ..."*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[39]` (*Player_Romus: ""It may be disruptive in the short term, but my decree is..."*)
  - -> `[40]` (*Player_Romus: ""If we are to progress as a nation, we must break the cha..."*)

### Węzeł `[121]`
Mówca: **Hugo Toras**
> ""Your Majesty, I urge you to take the opposition to your decree seriously. I too worry about its potential to alienate millions of our citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player_Romus: ""Acknowledging the existence of Dastunity does not mean e..."*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[89]` (*Player_Romus: ""It may be disruptive in the short term, but my decree is..."*)
  - -> `[91]` (*Player_Romus: ""Changing the state religion to Nurity was only the first..."*)

### Węzeł `[122]`
Mówca: **Narrator**
> "Hugo turned to me and spoke quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Hugo Toras: ""Your Majesty, I urge you to take the opposition to your ..."*)

### Węzeł `[123]`
Mówca: **Daria de Rava**
> ""I am not speaking hyperbolically. The broadening of our state religion has the potential to create vast rifts in our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Daria de Rava: ""We are essentially telling the millions of Wruhecist bel..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true || RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == tr..."*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == ..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true || RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true  or  Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Manus Sazon: ""More specifically, the encroachment of Wruhecism into pr..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true || RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true  or  Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)

### Węzeł `[127]`
Mówca: **Manus Sazon**
> ""More specifically, the encroachment of Wruhecism into previously secular areas of Rizian society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == ..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Manus Sazon: ""Our tax code, for example.""*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Manus Sazon: ""Our educational system, for example.""*)

### Węzeł `[131]`
Mówca: **Manus Sazon**
> ""Our tax code, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation ==..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation ==..."*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation ..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Manus Sazon: ""And our educational system.""*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[135]`
Mówca: **Manus Sazon**
> ""And our educational system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[136]`
Mówca: **Manus Sazon**
> ""Our educational system, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[137]`
Mówca: **Narrator**
> "Sal rose to his feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Sal Ignacius: ""The King has decided to reinforce the sacred laws of thi..."*)

### Węzeł `[138]`
Mówca: **Sal Ignacius**
> ""The King has decided to reinforce the sacred laws of this land. It is blasphemous to question him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player_Romus: ""The Grand Wiseman speaks the truth. What is my reign for..."*)
  - -> `[143]` (*Player_Romus: ""Now, Grand Wiseman. Skepticism is a tenet of our religio..."*)
  - -> `[145]` (*Player_Romus: ""Sit down, Grand Wiseman. I did not invite you here to sp..."*)
  - -> `[144]` (*Player_Romus: ""I understand your worries, Mr. Sazon. But the alignment ..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "Sal rose to his feet."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Player_Romus: ""I understand your worries, Mr. Sazon. But the alignment ..."*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situatio..."*)
  - -> `[148]` (*Player_Romus: ""What is my reign for, if not to uphold and glorify the s..."*)
  - -> `[152]` (*Player_Romus: ""Need I remind you we are one of the few purely Wruhecist..."*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Grand Wiseman speaks the truth. What is my reign for, if not to uphold and glorify the words of St. Wruhec?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Manus Sazon: ""I... understand that, Your Majesty.""*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now, Grand Wiseman. Skepticism is a tenet of our religion. I would not prohibit our House Speaker from expressing it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Manus Sazon: ""Thank you, Your Majesty.""*)

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand your worries, Mr. Sazon. But the alignment of Rizia's laws with its religious practices is essential for our spiritual health and unity.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[138]` (Sal Ignacius), `[135]` (Manus Sazon), `[136]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Manus Sazon: ""Where you see alignment, I see an attempt at forced indo..."*)

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sit down, Grand Wiseman. I did not invite you here to speak for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Sal Ignacius: ""Pardon my interruption. It was the Lord who compelled me..."*)

### Węzeł `[146]`
Mówca: **Manus Sazon**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Manus Sazon: ""Of course I acknowledge the long tradition of Wruhecism ..."*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are being inundated with non-Wruhecist newcomers. They must respect our state religion if they want to keep living here.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0  or  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true` AND `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[135]` (Manus Sazon), `[136]` (Manus Sazon), `[131]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Manus Sazon: ""Migrants cannot be forced into accepting a religion that..."*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is my reign for, if not to uphold and glorify the sacred laws of St. Wruhec?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[135]` (Manus Sazon), `[136]` (Manus Sazon), `[131]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Manus Sazon: ""I... understand that, Your Majesty.""*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Focus_Government_Absolutism == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situatio..."*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situat..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Focus_Government_Absolutism == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0  or  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player_Romus: ""We are being inundated with non-Wruhecist newcomers. The..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Focus_Government_Absolutism == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0  or  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Need I remind you we are one of the few purely Wruhecist nations on this planet? We must do all we can to preserve our holy practices.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[135]` (Manus Sazon), `[136]` (Manus Sazon), `[131]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Manus Sazon: ""I... understand that, Your Majesty.""*)

### Węzeł `[153]`
Mówca: **Manus Sazon**
> ""I... understand that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Manus Sazon: ""Of course I acknowledge the long tradition of Wruhecism ..."*)

### Węzeł `[154]`
Mówca: **Manus Sazon**
> ""Migrants cannot be forced into accepting a religion that is not their own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Manus Sazon: ""Of course I acknowledge the long tradition of Wruhecism ..."*)

### Węzeł `[155]`
Mówca: **Manus Sazon**
> ""Where you see alignment, I see an attempt at forced indoctrination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Manus Sazon: ""Of course I acknowledge the long tradition of Wruhecism ..."*)

### Węzeł `[156]`
Mówca: **Sal Ignacius**
> ""Pardon my interruption. It was the Lord who compelled me to defend our holy ways.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Manus Sazon: ""Of course I acknowledge the long tradition of Wruhecism ..."*)

### Węzeł `[157]`
Mówca: **Manus Sazon**
> ""I... understand that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Manus Sazon: ""Of course I acknowledge the long tradition of Wruhecism ..."*)

### Węzeł `[158]`
Mówca: **Manus Sazon**
> ""Of course I acknowledge the long tradition of Wruhecism in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true"*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == ..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Manus Sazon: ""But I have received complaints from Dastnurist-owned bus..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Manus Sazon: ""But I have received complaints from Dastnurist Rizians w..."*)

### Węzeł `[162]`
Mówca: **Manus Sazon**
> ""But I have received complaints from Dastnurist-owned businesses that have had to close since the tax on non-Wruhecists was introduced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Manus Sazon: ""Ultimately, religion should have no place in the economy..."*)

### Węzeł `[163]`
Mówca: **Manus Sazon**
> ""But I have received complaints from Dastnurist Rizians who have had to pull their children out of school since our reforms were implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Manus Sazon: ""Ultimately, a child's religious education should be deci..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true"*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Daria de Rava: ""More specifically, His Majesty's decision to remove our ..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Law_NurityStateReligion == true"*)

### Węzeł `[167]`
Mówca: **Daria de Rava**
> ""More specifically, His Majesty's decision to remove our kingdom's state religion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Daria de Rava: ""We all know that Rizia's Wruhecist roots can be traced b..."*)

### Węzeł `[168]`
Mówca: **Narrator**
> "Hugo spoke quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Hugo Toras: ""The Baroness has a point, Your Majesty.""*)

### Węzeł `[169]`
Mówca: **Hugo Toras**
> ""The Baroness has a point, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Narrator: "Manus hesitantly put up a hand."*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't put words in my mouth, Mr. Sazon. I do not embrace any faith, and neither will this kingdom.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Kontekst wejściowy (poprzednik):** `[312]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Daria de Rava: ""The RNC has made our position clear, Your Majesty. I wil..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 0)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player_Romus: ""Don't put words in my mouth, Mr. Sazon. I do not embrace..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Certainly. As long as we don't place any one faith above the others.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[312]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Daria de Rava: ""The RNC has made our position clear, Your Majesty. I wil..."*)

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So long as those faiths do not espouse destructive values -- like Golcondism, for example.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Kontekst wejściowy (poprzednik):** `[312]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Daria de Rava: ""While we are on that subject...""*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLa..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Player_Romus: ""So long as those faiths do not espouse destructive value..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""People may practice whatever they want in private. But they have no business forcing that practice on others.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[312]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Daria de Rava: ""The RNC has made our position clear, Your Majesty. I wil..."*)

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It may be disruptive in the short term, but my decree is a vital part of my vision for a modern, globally connected kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[319]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Daria de Rava: ""A kingdom that publicly panders to the interests of migr..."*)

### Węzeł `[181]`
Mówca: **Daria de Rava**
> ""A kingdom that publicly panders to the interests of migrants will never be seen as strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Daria de Rava: ""But very well, Your Majesty. You have made yourself clear.""*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Changing the state religion to Nurity was only the first step in breaking the chains of religious dogma that shackle us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[319]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Daria de Rava: ""Your Majesty... Wruhecism is an ancient denomination wit..."*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Acknowledging the existence of Dastunity does not mean erasing Wruhecism. This is not a zero-sum game.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[319]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Daria de Rava: ""We can acknowledge Dastnurists without enshrining their ..."*)

### Węzeł `[184]`
Mówca: **Daria de Rava**
> ""There is openness, and then there is the dilution of our values to a dangerous degree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Daria de Rava: ""But very well, Your Majesty. You have made yourself clear.""*)

### Węzeł `[185]`
Mówca: **Daria de Rava**
> ""We can acknowledge Dastnurists without enshrining their religion in national law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Daria de Rava: ""But very well, Your Majesty. You have made yourself clear.""*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Religious == true)"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Player_Romus: ""As a God-fearing Wruhecist myself, I understand the oppo..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Religious == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a God-fearing Wruhecist myself, I understand the opposition. But spiritual openness is one of our core principles. Limiting our state religion to only one branch of Nurity is a betrayal of that.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Kontekst wejściowy (poprzednik):** `[319]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Daria de Rava: ""There is openness, and then there is the dilution of our..."*)

### Węzeł `[190]`
Mówca: **Daria de Rava**
> ""The RNC has made our position clear, Your Majesty. I will say no more about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Daria de Rava: ""But while we are on the topic of religion...""*)

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Grand Wiseman speaks the truth. What is my reign for, if not to uphold and glorify the words of St. Wruhec?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Manus Sazon: ""I... understand that, Your Majesty.""*)

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now, Grand Wiseman. Skepticism is a tenet of our religion. I would not prohibit our House Speaker from expressing it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Manus Sazon: ""Thank you, Your Majesty.""*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand your worries, Mr. Sazon. But the alignment of Rizia's laws with its religious practices is essential for our spiritual health and unity.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[237]` (Sal Ignacius), `[216]` (Manus Sazon), `[225]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Manus Sazon: ""Where you see alignment, I see an attempt at forced indo..."*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sit down, Grand Wiseman. I did not invite you here to speak for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Sal Ignacius: ""Pardon my interruption. It was the Lord who compelled me..."*)

### Węzeł `[195]`
Mówca: **Manus Sazon**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Manus Sazon: ""Of course I acknowledge the long tradition of Wruhecism ..."*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are being inundated with non-Wruhecist newcomers. They must respect our state religion if they want to keep living here.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0  or  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true` AND `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[216]` (Manus Sazon), `[225]` (Manus Sazon), `[224]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Manus Sazon: ""Forcing migrants to embrace Wruhecism will only create r..."*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is my reign for, if not to uphold and glorify the sacred laws of St. Wruhec?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[216]` (Manus Sazon), `[225]` (Manus Sazon), `[224]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Manus Sazon: ""I... understand that, Your Majesty.""*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Focus_Government_Absolutism == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situatio..."*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situat..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Focus_Government_Absolutism == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0  or  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player_Romus: ""We are being inundated with non-Wruhecist newcomers. The..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situation_Order_SuOmina_AlliedToCrown == true || RiziaDLC.Focus_Government_Absolutism == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0  or  Variable["RiziaDLC.Situation_Order_SuOmina_AlliedToCrown"] == true  or  Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Need I remind you we are one of the few purely Wruhecist nations on this planet? We must do all we can to preserve our holy practices.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[216]` (Manus Sazon), `[225]` (Manus Sazon), `[224]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Manus Sazon: ""I... understand that, Your Majesty.""*)

### Węzeł `[202]`
Mówca: **Manus Sazon**
> ""I... understand that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Manus Sazon: ""Of course I acknowledge the long tradition of Wruhecism ..."*)

### Węzeł `[203]`
Mówca: **Manus Sazon**
> ""Forcing migrants to embrace Wruhecism will only create resentment in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Manus Sazon: ""Of course I acknowledge the long tradition of Wruhecism ..."*)

### Węzeł `[204]`
Mówca: **Manus Sazon**
> ""Where you see alignment, I see an attempt at forced indoctrination, which will only create resentment in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Manus Sazon: ""Of course I acknowledge the long tradition of Wruhecism ..."*)

### Węzeł `[205]`
Mówca: **Sal Ignacius**
> ""Pardon my interruption. It was the Lord who compelled me to defend our holy ways.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Manus Sazon: ""Of course I acknowledge the long tradition of Wruhecism ..."*)

### Węzeł `[206]`
Mówca: **Manus Sazon**
> ""I... understand that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Manus Sazon: ""Of course I acknowledge the long tradition of Wruhecism ..."*)

### Węzeł `[207]`
Mówca: **Manus Sazon**
> ""Of course I acknowledge the long tradition of Wruhecism in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true"*)

### Węzeł `[208]`
Mówca: **Daria de Rava**
> ""By erasing religious symbols and institutions from the public sphere, we are telling millions of citizens that the government no longer cares about their faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Daria de Rava: ""We in the House of Delegates have no choice but to issue..."*)

### Węzeł `[209]`
Mówca: **Daria de Rava**
> ""We in the House of Delegates have no choice but to issue an official disproval of the King's decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "She banged her gavel."*)

### Węzeł `[210]`
Mówca: **Narrator**
> "She banged her gavel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[242]` (*Player_Romus: ""It may be disruptive in the short term, but my decree is..."*)
  - -> `[248]` (*Player_Romus: ""Mr. Sazon? No objections from your party?""*)

### Węzeł `[211]`
Mówca: **Daria de Rava**
> ""And this recent policy change has been met with resistance from all of the country's religious communities, be they Wruhecist, Golcondist or Dastnurist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Daria de Rava: ""By erasing religious symbols and institutions from the p..."*)

### Węzeł `[212]`
Mówca: **Daria de Rava**
> ""We all know that Rizia's Wruhecist roots can be traced back to the early years of the Rezenid Empire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Daria de Rava: ""With this policy change, we are essentially telling mill..."*)

### Węzeł `[213]`
Mówca: **Daria de Rava**
> ""With this policy change, we are essentially telling millions of Wruhecist believers that their -- our -- faith is no different from Dastnurity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Daria de Rava: ""In the name of 'inclusivity', we risk erasing the unique..."*)

### Węzeł `[214]`
Mówca: **Daria de Rava**
> ""In the name of 'inclusivity', we risk erasing the unique practices and traditions that have guided our kingdom since its foundation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Daria de Rava: ""The House of Delegates has therefore decided to issue an..."*)

### Węzeł `[215]`
Mówca: **Narrator**
> "She raised her hand to bang the gavel. Manus quickly interjected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Manus Sazon: ""Madame Speaker, my party has prepared a defense of the c..."*)

### Węzeł `[216]`
Mówca: **Manus Sazon**
> ""And our educational system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[217]`
Mówca: **Manus Sazon**
> ""Madame Speaker, my party has prepared a defense of the change in state religion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Daria de Rava: ""The Delegates have given their ruling. Please drop the i..."*)

### Węzeł `[218]`
Mówca: **Narrator**
> "Sal had risen to his feet. He gingerly sat back down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Daria de Rava: ""As the King proclaims, so it shall be.""*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Law_NurityStateReligion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Law_NurityStateReligion == true"*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Law_NurityStateReligion == true)"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Law_NurityStateReligion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Law_NurityStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Daria de Rava: ""More specifically, King Romus' decision to change our st..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Law_NurityStateReligion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Law_NurityStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == tr..."*)

### Węzeł `[222]`
Mówca: **Daria de Rava**
> ""More specifically, King Romus' decision to change our state religion to encompass all denominations of Nurity, not only Wruhecism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Daria de Rava: ""We all know that Rizia's Wruhecist roots can be traced b..."*)

### Węzeł `[223]`
Mówca: **Manus Sazon**
> ""As Madame Speaker mentioned, my party and our constituents are worried about the government's religious overreach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true"*)

### Węzeł `[224]`
Mówca: **Manus Sazon**
> ""We see it in our tax code, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation ==..."*)

### Węzeł `[225]`
Mówca: **Manus Sazon**
> ""We see it in our educational system, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[226]`
Mówca: **Daria de Rava**
> ""The House of Delegates has therefore decided to issue an official disproval of the King's decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "She raised her hand to bang the gavel. Manus quickly inte..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true || RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == tr..."*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == ..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true || RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true  or  Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Daria de Rava: ""The opposition speaker had some comments regarding what ..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true || RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true  or  Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true"*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == ..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Manus Sazon: ""We see it in our tax code, for example.""*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Manus Sazon: ""We see it in our educational system, for example.""*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation ==..."*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation ..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Manus Sazon: ""And our educational system.""*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[236]`
Mówca: **Narrator**
> "Sal rose to his feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Sal Ignacius: ""The King has decided to reinforce the sacred laws of thi..."*)

### Węzeł `[237]`
Mówca: **Sal Ignacius**
> ""The King has decided to reinforce the sacred laws of this land. It is treasonous to question him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Player_Romus: ""The Grand Wiseman speaks the truth. What is my reign for..."*)
  - -> `[192]` (*Player_Romus: ""Now, Grand Wiseman. Skepticism is a tenet of our religio..."*)
  - -> `[194]` (*Player_Romus: ""Sit down, Grand Wiseman. I did not invite you here to sp..."*)
  - -> `[193]` (*Player_Romus: ""I understand your worries, Mr. Sazon. But the alignment ..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "Sal rose to his feet."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Player_Romus: ""I understand your worries, Mr. Sazon. But the alignment ..."*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0 || RiziaDLC.Situatio..."*)
  - -> `[197]` (*Player_Romus: ""What is my reign for, if not to uphold and glorify the s..."*)
  - -> `[201]` (*Player_Romus: ""Need I remind you we are one of the few purely Wruhecist..."*)

### Węzeł `[241]`
Mówca: **Daria de Rava**
> ""We all know that Rizia's Wruhecist roots can be traced back to the early years of the Rezenid Empire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Daria de Rava: ""And this recent policy change has been met with resistan..."*)

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It may be disruptive in the short term, but my decree is a vital part of my vision for a modern, globally connected kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Daria de Rava: ""A kingdom without its spiritual center cannot survive.""*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Religious == true)"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player_Romus: ""As a God-fearing man myself, I am offended by your dispr..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Religious == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Player_Romus: ""I am offended by your disproval. My intention was not to..."*)

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a God-fearing man myself, I am offended by your disproval. My intention was not to erase Wruhecism, but to allow all religions to flourish.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Kontekst wejściowy (poprzednik):** `[210]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Daria de Rava: ""Religions cannot flourish in a kingdom that frowns on be..."*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your disproval has been noted. But Rizia will never return to the shackles of religious dogma.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Kontekst wejściowy (poprzednik):** `[210]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Daria de Rava: ""Your Majesty... Wruhecism is an ancient denomination wit..."*)

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Sazon? No objections from your party?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Manus Sazon: ""Actually, Your Majesty, many of us in the RPP harbor res..."*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am offended by your disproval. My intention was not to erase Wruhecism, but to allow all religions to flourish in Rizia.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[210]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Daria de Rava: ""Religions cannot flourish in a kingdom that frowns on be..."*)

### Węzeł `[250]`
Mówca: **Daria de Rava**
> ""A kingdom without its spiritual center cannot survive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Daria de Rava: ""Especially not in the middle of a war.""*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "Hugo spoke quietly."*)

### Węzeł `[254]`
Mówca: **Daria de Rava**
> ""Especially not in the middle of a war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "Hugo spoke quietly."*)

### Węzeł `[255]`
Mówca: **Daria de Rava**
> ""Your Majesty... Wruhecism is an ancient denomination with millions of followers, none of whom would call themselves shackled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player_Romus: ""A truly egalitarian society has no room for archaic supe..."*)
  - -> `[256]` (*Player_Romus: ""The shackles are invisible. That's what makes them so da..."*)
  - -> `[261]` (*Player_Romus: ""It is a meaningless distraction meant to keep the poor a..."*)
  - -> `[259]` (*Player_Romus: ""I tire of this discussion, Madame Speaker. Please procee..."*)

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The shackles are invisible. That's what makes them so dangerous.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Narrator: "Manus hesitantly put up a hand."*)

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A truly egalitarian society has no room for archaic superstitions of any kind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Narrator: "Manus hesitantly put up a hand."*)

### Węzeł `[258]`
Mówca: **Manus Sazon**
> ""Actually, Your Majesty, many of us in the RPP harbor reservations about your decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Manus Sazon: ""We are in favor of ending religious discrimination in Ri..."*)

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I tire of this discussion, Madame Speaker. Please proceed to your next topic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Narrator: "Manus hesitantly put up a hand."*)

### Węzeł `[260]`
Mówca: **Daria de Rava**
> ""Religions cannot flourish in a kingdom that frowns on belief systems of any kind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Narrator: "Manus hesitantly put up a hand."*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is a meaningless distraction meant to keep the poor and downtrodden from questioning their lot in life.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Narrator: "Manus hesitantly put up a hand."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 0)"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player_Romus: ""Your disproval has been noted. But Rizia will never retu..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[265]`
Mówca: **Manus Sazon**
> ""Ultimately, religion should have no place in the economy of a modern nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player_Romus: ""I disagree. Our kingdom cannot prosper if it is sufferin..."*)
  - -> `[268]` (*Player_Romus: ""But look at the income the tax generates. It can be used..."*)
  - -> `[269]` (*Player_Romus: ""I stand by my decision. Businesses cannot take advantage..."*)
  - -> `[270]` (*Player_Romus: ""Heathens and blasphemers have no place in our economy, M..."*)

### Węzeł `[266]`
Mówca: **Manus Sazon**
> ""Ultimately, a child's religious education should be decided on by their parents. Not mandated by the government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player_Romus: ""Parents do not always know what is best for their childr..."*)
  - -> `[272]` (*Player_Romus: ""We are one of the few Wruhecist countries in this world...."*)
  - -> `[280]` (*Player_Romus: ""Providing each Rizian child with a Wruhecist education w..."*)
  - -> `[273]` (*Player_Romus: ""The teachings of St. Wruhec are as valuable as reading, ..."*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I disagree. Our kingdom cannot prosper if it is suffering from spiritual bankruptcy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Daria de Rava: ""Well said, Your Majesty.""*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But look at the income the tax generates. It can be used to help the less fortunate, in line with Wruhecist principles.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Daria de Rava: ""Precisely, Your Majesty. The House Speaker is overlookin..."*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I stand by my decision. Businesses cannot take advantage of our resources while ignoring our values.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Daria de Rava: ""Well said, Your Majesty.""*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Heathens and blasphemers have no place in our economy, Mr. Sazon. They must submit to Wruhecism or pay the price.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Daria de Rava: ""Well said, Your Majesty.""*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Parents do not always know what is best for their children.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC..."*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are one of the few Wruhecist countries in this world. If we do not pass on our traditions, they will be lost.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Manus Sazon: ""Isn't that what our religious institutions are for? Usin..."*)

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The teachings of St. Wruhec are as valuable as reading, writing and arithmetic. They should be instilled in children regardless of what their parents believe.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Manus Sazon: ""I worry that will foster an atmosphere of exclusion and ..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC.Relations_VinaManus_ApproveAfterPales == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC..."*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_VinaManus_Approve == false && RiziaD..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC.Relations_VinaManus_ApproveAfterPales == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == false  and  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Narrator: "Manus choked back a laugh."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC.Relations_VinaManus_ApproveAfterPales == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == false  and  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Manus Sazon: ""No. But removing their right to determine their children..."*)

### Węzeł `[277]`
Mówca: **Manus Sazon**
> ""I cannot disagree with that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Manus Sazon: ""But removing their right to determine their children's s..."*)

### Węzeł `[278]`
Mówca: **Narrator**
> "Manus choked back a laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Manus Sazon: ""I cannot disagree with that, Your Majesty.""*)

### Węzeł `[279]`
Mówca: **Manus Sazon**
> ""No. But removing their right to determine their children's spiritual upbringing will foster resentment in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Providing each Rizian child with a Wruhecist education will foster a stronger sense of unity for future generations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Manus Sazon: ""Or it will foster an atmosphere of exclusion and resentm..."*)

### Węzeł `[281]`
Mówca: **Manus Sazon**
> ""Isn't that what our religious institutions are for? Using public schools for this purpose will only foster resentment in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[282]`
Mówca: **Manus Sazon**
> ""Or it will foster an atmosphere of exclusion and resentment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[283]`
Mówca: **Manus Sazon**
> ""I worry that will foster an atmosphere of exclusion and resentment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[284]`
Mówca: **Daria de Rava**
> ""I believe the King has made his position clear, Mr. Speaker. It is not up to us to debate it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "Frustration flashed across Manus' face. He kept it in check."*)

### Węzeł `[285]`
Mówca: **Manus Sazon**
> ""But removing their right to determine their children's spiritual upbringing will foster resentment in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[286]`
Mówca: **Narrator**
> "Manus gave her a look of warning. She closed her mouth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Manus Sazon: ""While we are on the subject of religion...""*)

### Węzeł `[287]`
Mówca: **Manus Sazon**
> ""The RPP agrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Manus Sazon: ""While we are on the subject of religion...""*)

### Węzeł `[288]`
Mówca: **Manus Sazon**
> ""While we are on that subject...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)

### Węzeł `[289]`
Mówca: **Manus Sazon**
> ""While we are on the subject of religion...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)

### Węzeł `[290]`
Mówca: **Manus Sazon**
> ""Well, the RPP regards it as an important side effect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Manus Sazon: ""While we are on the subject of religion...""*)

### Węzeł `[291]`
Mówca: **Manus Sazon**
> ""The RPP agrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Manus Sazon: ""While we are on the subject of religion...""*)

### Węzeł `[292]`
Mówca: **Manus Sazon**
> ""At the very least, we must not let religious differences divide us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Manus Sazon: ""While we are on the subject of religion...""*)

### Węzeł `[293]`
Mówca: **Daria de Rava**
> ""Precisely, Your Majesty. The House Speaker is overlooking the decree's obvious benefits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Daria de Rava: ""I will caution that several of the major Rumburgian corp..."*)

### Węzeł `[294]`
Mówca: **Daria de Rava**
> ""Well said, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Daria de Rava: ""I will caution that several of the major Rumburgian corp..."*)

### Węzeł `[295]`
Mówca: **Daria de Rava**
> ""I will caution that several of the major Rumburgian corporations based in Rizia Imperii have voiced objections to the new tax.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Daria de Rava: ""However, they have signalled their willingness to comply..."*)

### Węzeł `[296]`
Mówca: **Daria de Rava**
> ""However, they have signalled their willingness to comply for the sake of maintaining friendly business relations between our kingdoms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Manus Sazon: ""By installing token Wruhecist CEOs, no doubt. But never ..."*)

### Węzeł `[297]`
Mówca: **Narrator**
> "Manus looked down at his notes again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Manus Sazon: ""While we are on the subject of religion...""*)

### Węzeł `[298]`
Mówca: **Manus Sazon**
> ""By installing token Wruhecist CEOs, no doubt. But never mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "Manus looked down at his notes again."*)

### Węzeł `[299]`
Mówca: **Sal Ignacius**
> ""There will be no exclusion when all accept Wruhecism as the one true faith, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "Frustration flashed across Manus' face. He kept it in check."*)

### Węzeł `[300]`
Mówca: **Sal Ignacius**
> ""There will be no resentment when all accept Wruhecism as the one true faith, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "Frustration flashed across Manus' face. He kept it in check."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Sal Ignacius: ""There will be no resentment when all accept Wruhecism as..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Daria de Rava: ""I believe the King has made his position clear, Mr. Spea..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Sal Ignacius: ""There will be no exclusion when all accept Wruhecism as ..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Daria de Rava: ""I believe the King has made his position clear, Mr. Spea..."*)

### Węzeł `[307]`
Mówca: **Narrator**
> "Frustration flashed across Manus' face. He kept it in check."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Manus Sazon: ""Very well. But while we are on the subject of religion...""*)

### Węzeł `[308]`
Mówca: **Manus Sazon**
> ""Very well. But while we are on the subject of religion...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)

### Węzeł `[309]`
Mówca: **Narrator**
> "Manus hesitantly put up a hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Manus Sazon: ""I must say that my party has reservations about this dec..."*)

### Węzeł `[310]`
Mówca: **Manus Sazon**
> ""I must say that my party has reservations about this decree as well, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Manus Sazon: ""We are in favor of ending religious discrimination in Ri..."*)

### Węzeł `[311]`
Mówca: **Manus Sazon**
> ""We are in favor of ending religious discrimination in Rizia. But we must proceed with caution. We can't simply scrub religion from public life from one day to the next.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Manus Sazon: ""However... I am sure that under your leadership, we can ..."*)

### Węzeł `[312]`
Mówca: **Manus Sazon**
> ""However... I am sure that under your leadership, we can transition away from state-enshrined Wruhecism while continuing to embrace faith in all of its different forms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)
  - -> `[179]` (*Player_Romus: ""People may practice whatever they want in private. But t..."*)
  - -> `[174]` (*Player_Romus: ""Certainly. As long as we don't place any one faith above..."*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)

### Węzeł `[313]`
Mówca: **Daria de Rava**
> ""While we are on that subject...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)

### Węzeł `[314]`
Mówca: **Daria de Rava**
> ""But while we are on the topic of religion...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)

### Węzeł `[315]`
Mówca: **Daria de Rava**
> ""The Delegates have given their ruling. Please drop the issue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Player_Romus: ""No. I want to know the RPP's opinion.""*)
  - -> `[317]` (*Player_Romus: ""Do not attempt to silence your fellow delegates, Madame ..."*)
  - -> `[318]` (*Player_Romus: ""I appreciate your support, Mr. Sazon, but your input is ..."*)

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I want to know the RPP's opinion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Daria de Rava: ""Very well. You may proceed, Mr. Sazon.""*)

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not attempt to silence your fellow delegates, Madame Speaker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Daria de Rava: ""Very well. You may proceed, Mr. Sazon.""*)

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your support, Mr. Sazon, but your input is not needed. I stand by my decree.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "Manus gave me a nod."*)

### Węzeł `[319]`
Mówca: **Narrator**
> "Manus gave me a nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player_Romus: ""Acknowledging the existence of Dastunity does not mean e..."*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[180]` (*Player_Romus: ""It may be disruptive in the short term, but my decree is..."*)
  - -> `[182]` (*Player_Romus: ""Changing the state religion to Nurity was only the first..."*)

### Węzeł `[320]`
Mówca: **Daria de Rava**
> ""Very well. You may proceed, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Manus Sazon: ""Thank you.""*)

### Węzeł `[321]`
Mówca: **Manus Sazon**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "He glanced at me."*)

### Węzeł `[322]`
Mówca: **Narrator**
> "He glanced at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Manus Sazon: ""The RPP welcomes this long-overdue move towards religiou..."*)

### Węzeł `[323]`
Mówca: **Manus Sazon**
> ""The RPP welcomes this long-overdue move towards religious inclusivity in our kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Manus Sazon: ""It is long past time we acknowledge the growing numbers ..."*)

### Węzeł `[324]`
Mówca: **Daria de Rava**
> ""Your Majesty... Wruhecism is an ancient denomination with millions of followers, none of whom would call themselves shackled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Player_Romus: ""A truly egalitarian society has no room for archaic supe..."*)
  - -> `[325]` (*Player_Romus: ""The shackles are invisible. That's what makes them so da..."*)
  - -> `[327]` (*Player_Romus: ""I tire of this discussion, Madame Speaker. Please procee..."*)

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The shackles are invisible. That's what makes them so dangerous.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[324]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Narrator: "She swallowed."*)

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A truly egalitarian society has no room for archaic superstitions of any kind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[324]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Daria de Rava: ""Superstitions?!""*)

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I tire of this discussion, Madame Speaker. Please proceed to your next topic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[324]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Narrator: "She swallowed."*)

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is a meaningless distraction meant to keep the poor and downtrodden from questioning their lot in life.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Daria de Rava: ""A meaningless distraction?!""*)

### Węzeł `[329]`
Mówca: **Daria de Rava**
> ""Superstitions?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Narrator: "She swallowed."*)

### Węzeł `[330]`
Mówca: **Daria de Rava**
> ""A meaningless distraction?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Narrator: "She swallowed."*)

### Węzeł `[331]`
Mówca: **Daria de Rava**
> ""But very well, Your Majesty. You have made yourself clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Daria de Rava: ""While we are on the topic of religion...""*)

### Węzeł `[332]`
Mówca: **Daria de Rava**
> ""Very well, Your Majesty. You have made yourself clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Daria de Rava: ""While we are on the topic of religion...""*)

### Węzeł `[333]`
Mówca: **Manus Sazon**
> ""It is long past time we acknowledge the growing numbers of Dastnurists in our society, and the contributions they make to this nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Manus Sazon: ""And from what I can tell, the populace has welcomed the ..."*)

### Węzeł `[334]`
Mówca: **Manus Sazon**
> ""And from what I can tell, the populace has welcomed the chance to celebrate twice as many public holidays as before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "There was some polite laughter among the RPP delegates. D..."*)

### Węzeł `[335]`
Mówca: **Narrator**
> "There was some polite laughter among the RPP delegates. Daria frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Daria de Rava: ""The King is diluting our thousand-year-old religious tra..."*)

### Węzeł `[336]`
Mówca: **Daria de Rava**
> ""The King is diluting our thousand-year-old religious traditions, and you speak of holidays?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Manus Sazon: ""Of course that isn't the only benefit. We foresee great ..."*)

### Węzeł `[337]`
Mówca: **Narrator**
> "She swallowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Daria de Rava: ""But very well, Your Majesty. You have made yourself clear.""*)

### Węzeł `[338]`
Mówca: **Narrator**
> "She swallowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Daria de Rava: ""Very well, Your Majesty. You have made yourself clear.""*)

### Węzeł `[339]`
Mówca: **Manus Sazon**
> ""Of course that isn't the only benefit. We foresee great strides in Rizia's international relations in the wake of this decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true"*)

### Węzeł `[340]`
Mówca: **Manus Sazon**
> ""In light of our worsening tensions with Wehlen, it's important to send our Wehzek citizens the signal that they are still welcome here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Player_Romus: ""I signed the decree with an eye towards Rizians of Rumbu..."*)
  - -> `[348]` (*Player_Romus: ""Yes, this will go a long way towards reducing animosity ..."*)
  - -> `[346]` (*Player_Romus: ""Indeed. Our nation must unify beneath the umbrella of th..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true"*)
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Manus Sazon: ""In light of our worsening tensions with Wehlen, it's imp..."*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Wehlen_AgreementRefused == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_AgreementRefused"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Manus Sazon: ""In light of our new agreement with Wehlen, it's importan..."*)

### Węzeł `[344]`
Mówca: **Manus Sazon**
> ""In light of our new agreement with Wehlen, it's important to send our Wehzek citizens the signal that they are welcome here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Player_Romus: ""I signed the decree with an eye towards Rizians of Rumbu..."*)
  - -> `[348]` (*Player_Romus: ""Yes, this will go a long way towards reducing animosity ..."*)
  - -> `[346]` (*Player_Romus: ""Indeed. Our nation must unify beneath the umbrella of th..."*)

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I signed the decree with an eye towards Rizians of Rumburgian descent. The opinion of Wehzeks is of no consequence.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[340]` (Manus Sazon), `[344]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Manus Sazon: ""Well, the RPP regards it as an important side effect.""*)

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. Our nation must unify beneath the umbrella of the great Nur.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[340]` (Manus Sazon), `[344]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Manus Sazon: ""At the very least, we must not let religious differences..."*)

### Węzeł `[347]`
Mówca: **Manus Sazon**
> ""Well, the RPP regards it as an important side effect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Daria de Rava: ""Thank you, Mr. Sazon. You have made your position clear.""*)

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, this will go a long way towards reducing animosity between ethnic Rizians and those of Wehzek descent.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[340]` (Manus Sazon), `[344]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Manus Sazon: ""The RPP agrees.""*)

### Węzeł `[349]`
Mówca: **Manus Sazon**
> ""The RPP agrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Daria de Rava: ""Thank you, Mr. Sazon. You have made your position clear.""*)

### Węzeł `[350]`
Mówca: **Manus Sazon**
> ""At the very least, we must not let religious differences divide us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Daria de Rava: ""Thank you, Mr. Sazon. You have made your position clear.""*)

### Węzeł `[351]`
Mówca: **Daria de Rava**
> ""Thank you, Mr. Sazon. You have made your position clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Daria de Rava: ""While we are on the topic of religion...""*)

### Węzeł `[352]`
Mówca: **Daria de Rava**
> ""While we are on the topic of religion...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLa..."*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Daria de Rava: ""I must bring His Majesty's attention to to the aftermath..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Daria de Rava: ""I must mention the growing pressure from Golcondist comm..."*)

### Węzeł `[356]`
Mówca: **Daria de Rava**
> ""I must mention the growing pressure from Golcondist communities to lift Rizia's blasphemy law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Narrator: "I saw Hugo raise his eyebrow."*)

### Węzeł `[357]`
Mówca: **Daria de Rava**
> ""I must bring His Majesty's attention to to the aftermath of our lifting the Golcondist blasphemy law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Daria de Rava: ""Naturally, the sudden acceptance of Derdian and Bludish ..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLa..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Manus Sazon: ""I must bring His Majesty's attention to the aftermath of..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Manus Sazon: ""I must mention the growing pressure from Bludish and Der..."*)

### Węzeł `[361]`
Mówca: **Manus Sazon**
> ""I must mention the growing pressure from Bludish and Derdian communities to lift our so-called blasphemy law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianB..."*)

### Węzeł `[362]`
Mówca: **Manus Sazon**
> ""I must bring His Majesty's attention to the aftermath of our lifting the Golcondist blasphemy law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Manus Sazon: ""Naturally, the Derdian and Bludish natives residing in R..."*)

### Węzeł `[363]`
Mówca: **Daria de Rava**
> ""The opposition speaker had some comments regarding what he sees as an 'encroachment of Wruhecism' onto everyday life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Daria de Rava: ""I don't see the need to air these complaints.""*)

### Węzeł `[364]`
Mówca: **Daria de Rava**
> ""I don't see the need to air these complaints.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Player_Romus: ""It's always valuable to know the opposition's opinion. G..."*)
  - -> `[367]` (*Player_Romus: ""I would be curious to know what blasphemous thoughts Mr...."*)
  - -> `[366]` (*Player_Romus: ""Nor do I. We shall not change the religious direction of..."*)

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's always valuable to know the opposition's opinion. Go ahead, Mr. Sazon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[364]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true && RiziaDLC.Decision..."*)

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nor do I. We shall not change the religious direction of this country, not when so many of our citizens are finally starting to welcome God into their lives.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[364]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would be curious to know what blasphemous thoughts Mr. Sazon has rolling about in his head.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[364]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true && RiziaDLC.Decision..."*)

### Węzeł `[368]`
Mówca: **Narrator**
> "Manus cleared his throat. He glanced uneasily at Sal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Manus Sazon: ""As Madame Speaker mentioned, my party and our constituen..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true && RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true && RiziaDLC.Decision..."*)
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true && RiziaDLC.Decisi..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true && RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true  and  Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Narrator: "Manus cleared his throat. He glanced uneasily at Sal."*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true && RiziaDLC.Decision_Turn07_InviteSalToHOD == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true  and  Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Narrator: "Manus cleared his throat."*)

### Węzeł `[372]`
Mówca: **Narrator**
> "Manus cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Manus Sazon: ""As Madame Speaker mentioned, my party and our constituen..."*)

### Węzeł `[373]`
Mówca: **Sal Ignacius**
> ""Halaita, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "Sal had risen to his feet. He gingerly sat back down."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Sal Ignacius: ""Halaita, Your Majesty.""*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Daria de Rava: ""As the King proclaims, so it shall be.""*)

### Węzeł `[377]`
Mówca: **Daria de Rava**
> ""As the King proclaims, so it shall be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true"*)

### Węzeł `[378]`
Mówca: **Narrator**
> "She paused for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Daria de Rava: ""I will caution that several of the major Rumburgian corp..."*)

### Węzeł `[379]`
Mówca: **Daria de Rava**
> ""I will caution that several of the major Rumburgian corporations based in Rizia Imperii have voiced objections to the recently imposed tax on non-Wruhecists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Daria de Rava: ""However, they have signalled their willingness to comply..."*)

### Węzeł `[380]`
Mówca: **Daria de Rava**
> ""However, they have signalled their willingness to comply for the sake of maintaining friendly business relations between our kingdoms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Player_Romus: ""They will see the light, or they will pay the price.""*)
  - -> `[385]` (*Player_Romus: ""Rumburgian corporations are wealthy. They can afford it.""*)
  - -> `[386]` (*Player_Romus: ""I'm sure there are all sorts of loopholes they can explo..."*)
  - -> `[387]` (*Player_Romus: ""Good. We still need Rumburg on our side.""*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true"*)
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == ..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Narrator: "She paused for a moment."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Daria de Rava: ""While we are on the topic of religion...""*)

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They will see the light, or they will pay the price.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[380]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Daria de Rava: ""I have no doubt of that.""*)

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rumburgian corporations are wealthy. They can afford it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[380]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Daria de Rava: ""I have no doubt of that.""*)

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure there are all sorts of loopholes they can exploit if need be.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[380]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Daria de Rava: ""I have no doubt of that.""*)

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. We still need Rumburg on our side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[380]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Daria de Rava: ""The tax should not cost us the Queen's support. Not if w..."*)

### Węzeł `[388]`
Mówca: **Daria de Rava**
> ""I have no doubt of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Daria de Rava: ""While we are on the topic of religion...""*)

### Węzeł `[389]`
Mówca: **Daria de Rava**
> ""The tax should not cost us the Queen's support. Not if we continue to help Rumburg in other ways.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Daria de Rava: ""While we are on the topic of religion...""*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true"*)
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == ..."*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Manus Sazon: ""But I have received complaints from Dastnurist-owned bus..."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_NonWruhecistReligiousTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Manus Sazon: ""But I have received complaints from Dastnurist Rizians w..."*)

### Węzeł `[393]`
Mówca: **Manus Sazon**
> ""But I have received complaints from Dastnurist-owned businesses that have had to close since the tax on non-Wruhecists was introduced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Manus Sazon: ""Ultimately, religion should have no place in the economy..."*)

### Węzeł `[394]`
Mówca: **Manus Sazon**
> ""But I have received complaints from Dastnurist Rizians who have had to pull their children out of school since our reforms were implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Manus Sazon: ""Ultimately, a child's religious education should be deci..."*)

### Węzeł `[395]`
Mówca: **Manus Sazon**
> ""Ultimately, religion should have no place in the economy of a modern nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Player_Romus: ""I disagree. Our kingdom cannot prosper if it is sufferin..."*)
  - -> `[398]` (*Player_Romus: ""But look at the income the tax generates. It can be used..."*)
  - -> `[399]` (*Player_Romus: ""I stand by my decision. Businesses cannot take advantage..."*)
  - -> `[400]` (*Player_Romus: ""Heathens and blasphemers have no place in our economy, M..."*)

### Węzeł `[396]`
Mówca: **Manus Sazon**
> ""Ultimately, a child's religious education should be decided on by their parents. Not mandated by the government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Player_Romus: ""Parents do not always know what is best for their childr..."*)
  - -> `[402]` (*Player_Romus: ""We are one of the few Wruhecist countries in this world...."*)
  - -> `[410]` (*Player_Romus: ""Providing each Rizian child with a Wruhecist education w..."*)
  - -> `[403]` (*Player_Romus: ""The teachings of St. Wruhec are as valuable as reading, ..."*)

### Węzeł `[397]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I disagree. Our kingdom cannot prosper if it is suffering from spiritual bankruptcy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[395]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Daria de Rava: ""Well said, Your Majesty.""*)

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But look at the income the tax generates. It can be used to help the less fortunate, in line with Wruhecist principles.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[395]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Daria de Rava: ""Precisely, Your Majesty. The opposition is overlooking t..."*)

### Węzeł `[399]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I stand by my decision. Businesses cannot take advantage of our resources while ignoring our values.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[395]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Daria de Rava: ""Well said, Your Majesty.""*)

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Heathens and blasphemers have no place in our economy, Mr. Sazon. They must submit to Wruhecism or pay the price.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[395]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Daria de Rava: ""Well said, Your Majesty.""*)

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Parents do not always know what is best for their children.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[396]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC..."*)

### Węzeł `[402]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are one of the few Wruhecist countries in this world. If we do not pass on our traditions, they will be lost.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[396]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Manus Sazon: ""Isn't that what our religious institutions are for? Usin..."*)

### Węzeł `[403]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The teachings of St. Wruhec are as valuable as reading, writing and arithmetic. They should be instilled in children regardless of what their parents believe.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[396]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Manus Sazon: ""I worry that will foster an atmosphere of exclusion and ..."*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC.Relations_VinaManus_ApproveAfterPales == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC..."*)
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_VinaManus_Approve == false && RiziaD..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC.Relations_VinaManus_ApproveAfterPales == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == false  and  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Narrator: "Manus choked back a laugh."*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_VinaManus_Approve == false && RiziaDLC.Relations_VinaManus_ApproveAfterPales == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == false  and  Variable["RiziaDLC.Relations_VinaManus_ApproveAfterPales"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Manus Sazon: ""No. But removing their right to determine their children..."*)

### Węzeł `[407]`
Mówca: **Manus Sazon**
> ""I cannot disagree with that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Manus Sazon: ""But removing their right to determine their children's s..."*)

### Węzeł `[408]`
Mówca: **Narrator**
> "Manus choked back a laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Manus Sazon: ""I cannot disagree with that, Your Majesty.""*)

### Węzeł `[409]`
Mówca: **Manus Sazon**
> ""No. But removing their right to determine their children's spiritual upbringing will foster resentment in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Providing each Rizian child with a Wruhecist education will foster a stronger sense of unity for future generations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[396]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Manus Sazon: ""Or it will foster an atmosphere of exclusion and resentm..."*)

### Węzeł `[411]`
Mówca: **Manus Sazon**
> ""Isn't that what our religious institutions are for? Using public schools for this purpose will only foster resentment in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[412]`
Mówca: **Manus Sazon**
> ""I worry that will foster an atmosphere of exclusion and resentment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[413]`
Mówca: **Manus Sazon**
> ""Or it will foster an atmosphere of exclusion and resentment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[414]`
Mówca: **Daria de Rava**
> ""I believe the King has made his position clear, Mr. Sazon. It is not up to you to debate it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Narrator: "Frustration flashed across Manus' face. He kept it in check."*)

### Węzeł `[415]`
Mówca: **Manus Sazon**
> ""But removing their right to determine their children's spiritual upbringing will foster resentment in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)"*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Sal Ignacius: ""There will be no resentment when all accept Wruhecism as..."*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Daria de Rava: ""I believe the King has made his position clear, Mr. Sazo..."*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)"*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Sal Ignacius: ""There will be no exclusion when all accept Wruhecism as ..."*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Daria de Rava: ""I believe the King has made his position clear, Mr. Sazo..."*)

### Węzeł `[422]`
Mówca: **Narrator**
> "Manus looked down. Daria smoothly continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Daria de Rava: ""While we are on the topic of religion...""*)

### Węzeł `[423]`
Mówca: **Daria de Rava**
> ""I will caution that several of the major Rumburgian corporations based in Rizia Imperii have voiced objections to the new tax.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Daria de Rava: ""However, they have signalled their willingness to comply..."*)

### Węzeł `[424]`
Mówca: **Sal Ignacius**
> ""There will be no exclusion when all accept Wruhecism as the one true faith, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Narrator: "Frustration flashed across Manus' face. He kept it in check."*)

### Węzeł `[425]`
Mówca: **Sal Ignacius**
> ""There will be no resentment when all accept Wruhecism as the one true faith, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Narrator: "Frustration flashed across Manus' face. He kept it in check."*)

### Węzeł `[426]`
Mówca: **Daria de Rava**
> ""Precisely, Your Majesty. The opposition is overlooking the decree's obvious benefits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Daria de Rava: ""I will caution that several of the major Rumburgian corp..."*)

### Węzeł `[427]`
Mówca: **Daria de Rava**
> ""Well said, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Daria de Rava: ""I will caution that several of the major Rumburgian corp..."*)

### Węzeł `[428]`
Mówca: **Daria de Rava**
> ""However, they have signalled their willingness to comply for the sake of maintaining friendly business relations between our kingdoms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Narrator: "Manus looked down. Daria smoothly continued."*)

### Węzeł `[429]`
Mówca: **Narrator**
> "Frustration flashed across Manus' face. He kept it in check."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Daria de Rava: ""While we are on the topic of religion...""*)

### Węzeł `[430]`
Mówca: **Manus Sazon**
> ""Naturally, the Derdian and Bludish natives residing in Rizia have rejoiced at the opportunity to worship alongside their fellow Wruhecists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianB..."*)

### Węzeł `[431]`
Mówca: **Manus Sazon**
> ""However, the general public remains skeptical about what they see as a legitimization of an extremist sect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Manus Sazon: ""Especially if Rizia is to reopen relations with Derdia, ..."*)

### Węzeł `[432]`
Mówca: **Manus Sazon**
> ""It has helped soften the backlash against our border ban, which many say unfairly targets Golcondists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Manus Sazon: ""However, the general public remains skeptical about what..."*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianB..."*)
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdia..."*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Manus Sazon: ""It has helped soften the backlash against our border ban..."*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Manus Sazon: ""However, the general public remains skeptical about what..."*)

### Węzeł `[436]`
Mówca: **Manus Sazon**
> ""Together with the border ban we implemented in agreement with Wehlen, they point to it as evidence that the Crown discriminates against Golcondism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Player_Romus: ""It is not discriminatory to crack down on terrorism.""*)
  - -> `[446]` (*Player_Romus: ""Yes, and what is wrong with that? Golcondism is totally ..."*)
  - -> `[447]` (*Player_Romus: ""Lifting the blasphemy law has long been on my agenda. I ..."*)
  - -> `[449]` (*Player_Romus: ""Nonsense. I simply believe real Wruhecists have the righ..."*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianB..."*)
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdia..."*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Manus Sazon: ""Together with the border ban we implemented in agreement..."*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Manus Sazon: ""They point to it as evidence that the Crown discriminate..."*)

### Węzeł `[440]`
Mówca: **Manus Sazon**
> ""They point to it as evidence that the Crown discriminates against Golcondism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Player_Romus: ""Yes, and what is wrong with that? Golcondism is totally ..."*)
  - -> `[447]` (*Player_Romus: ""Lifting the blasphemy law has long been on my agenda. I ..."*)
  - -> `[449]` (*Player_Romus: ""Nonsense. I simply believe real Wruhecists have the righ..."*)
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn04_GolcondistPilgrimsPlavo_DeportDe..."*)

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A ridiculous accusation. Did I not allow Golcondist pilgrims to occupy the Plavo Archsanctuary?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Decision_Turn04_GolcondistPilgrimsPlavo_DeportDerdia"] == false`
- **Kontekst wejściowy (poprzednik):** `[440]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Manus Sazon: ""Yes, but it was expected that that action would be follo..."*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn04_GolcondistPilgrimsPlavo_DeportDerdia == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn04_GolcondistPilgrimsPlavo_DeportDe..."*)
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn04_GolcondistPilgrimsPlavo_Deport..."*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn04_GolcondistPilgrimsPlavo_DeportDerdia == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn04_GolcondistPilgrimsPlavo_DeportDerdia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Player_Romus: ""A ridiculous accusation. Did I not allow Golcondist pilg..."*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn04_GolcondistPilgrimsPlavo_DeportDerdia == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn04_GolcondistPilgrimsPlavo_DeportDerdia"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is not discriminatory to crack down on terrorism.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Manus Sazon: ""We have no evidence that the Golcondists we are turning ..."*)

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, and what is wrong with that? Golcondism is totally incompatible with modern Rizian society.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Manus Sazon), `[440]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Manus Sazon: ""Some of its followers may hold problematic views. We can..."*)

### Węzeł `[447]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lifting the blasphemy law has long been on my agenda. I will make it my priority.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Manus Sazon), `[440]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Manus Sazon: ""Granting all citizens an equal right to worship would be..."*)

### Węzeł `[448]`
Mówca: **Manus Sazon**
> ""Yes, but it was expected that that action would be followed by a more general easing of restrictions on Golcondist worship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Manus Sazon: ""On the other hand, I understand public concerns about le..."*)

### Węzeł `[449]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nonsense. I simply believe real Wruhecists have the right to worship in peace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Manus Sazon), `[440]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Manus Sazon: ""Golcondists do consider themselves 'real' Wruhecists, Yo..."*)

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Golcondists are Wruhecists like any others. Their beliefs are as valid as yours or mine.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true`
- **Kontekst wejściowy (poprzednik):** `[468]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Manus Sazon: ""I agree, Your Majesty. I personally supported the liftin..."*)

### Węzeł `[451]`
Mówca: **Manus Sazon**
> ""We have no evidence that the Golcondists we are turning away are terrorists, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Manus Sazon: ""On the other hand, I understand public concerns about le..."*)

### Węzeł `[452]`
Mówca: **Manus Sazon**
> ""Some of its followers may hold problematic views. We cannot use that to justify denying rights to the Golcondist community as a whole.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Manus Sazon: ""On the other hand, I understand public concerns about le..."*)

### Węzeł `[453]`
Mówca: **Manus Sazon**
> ""Granting all citizens an equal right to worship would be a great step forward for freedom in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Manus Sazon: ""On the other hand, I understand public concerns about le..."*)

### Węzeł `[454]`
Mówca: **Manus Sazon**
> ""Golcondists do consider themselves 'real' Wruhecists, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Manus Sazon: ""On the other hand, I understand public concerns about le..."*)

### Węzeł `[455]`
Mówca: **Manus Sazon**
> ""On the other hand, I understand public concerns about legitimizing what some see as an extremist sect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I gave all Rizians an equal right to worship, regardless of religion. It's not like Golcondists are receiving special treatment.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[468]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Manus Sazon: ""I agree, Your Majesty. I personally supported the liftin..."*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_StateReligion_Wruhecism == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_StateReligion_Wruhecism == true"*)
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Law_StateReligion_Wruhecism == true)"*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_StateReligion_Wruhecism == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Player_Romus: ""Golcondists are Wruhecists like any others. Their belief..."*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Law_StateReligion_Wruhecism == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Player_Romus: ""I gave all Rizians an equal right to worship, regardless..."*)

### Węzeł `[460]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The public has been scared away by decades of harmful stereotypes. They'll warm up to Golcondists in time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[468]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Manus Sazon: ""That is my party's hope as well.""*)

### Węzeł `[461]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We need Derdia's help in the war. Accepting Golcondists is all part of my strategy.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[468]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Manus Sazon: ""Whatever the intention, I regard the lifting of the ban ..."*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)"*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Sal Ignacius: ""Precisely, Mr. Speaker.""*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Manus Sazon: ""There are those who are worried that if Rizia grants mor..."*)

### Węzeł `[465]`
Mówca: **Sal Ignacius**
> ""Precisely, Mr. Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Narrator: "The delegates turned to look at Sal."*)

### Węzeł `[466]`
Mówca: **Narrator**
> "The delegates turned to look at Sal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Sal Ignacius: ""I have made myself clear on this subject time and time a..."*)

### Węzeł `[467]`
Mówca: **Sal Ignacius**
> ""I have made myself clear on this subject time and time again. By allowing Golcondists to flood our holy sites, we would be opening the door to darkness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Manus Sazon: ""I... wouldn't say that.""*)

### Węzeł `[468]`
Mówca: **Manus Sazon**
> ""Especially if Rizia is to reopen relations with Derdia, there are concerns about giving too much credence to Golcondist beliefs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_StateReligion_Wruhecism == true"*)
  - -> `[460]` (*Player_Romus: ""The public has been scared away by decades of harmful st..."*)
  - -> `[469]` (*Player_Romus: ""The concerns are over nothing. I don't want to have anyt..."*)
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The concerns are over nothing. I don't want to have anything to do with Derdia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[468]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Manus Sazon: ""The RPP is not opposed to dealing with Golcondist nations.""*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Player_Romus: ""We need Derdia's help in the war. Accepting Golcondists ..."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[473]`
Mówca: **Manus Sazon**
> ""I agree, Your Majesty. I personally supported the lifting of the ban as a step forward for freedom in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Manus Sazon: ""But we must take care to ensure practitioners of other r..."*)

### Węzeł `[474]`
Mówca: **Manus Sazon**
> ""That is my party's hope as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Manus Sazon: ""But we must take care to ensure practitioners of other r..."*)

### Węzeł `[475]`
Mówca: **Manus Sazon**
> ""The RPP is not opposed to dealing with Golcondist nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Manus Sazon: ""But we must take care to ensure practitioners of other r..."*)

### Węzeł `[476]`
Mówca: **Manus Sazon**
> ""Whatever the intention, I regard the lifting of the ban as a step forward for freedom in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Manus Sazon: ""But we must take care to ensure practitioners of other r..."*)

### Węzeł `[477]`
Mówca: **Manus Sazon**
> ""But we must take care to ensure practitioners of other religions do not feel neglected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");  // Removes the convers..."*)

### Węzeł `[478]`
Mówca: **Manus Sazon**
> ""I... wouldn't say that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Manus Sazon: ""But there are those who are worried that if Rizia grants..."*)

### Węzeł `[479]`
Mówca: **Manus Sazon**
> ""But there are those who are worried that if Rizia grants more rights to Golcondists, the kingdom will fall victim to the same ideologies as Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Player_Romus: ""Even if the blasphemy law is revoked, Rizia will never t..."*)
  - -> `[482]` (*Player_Romus: ""Would that be so bad? We have much to learn from our Der..."*)
  - -> `[487]` (*Player_Romus: ""These worries are unfounded. The blasphemy law is stayin..."*)
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[480]`
Mówca: **Manus Sazon**
> ""There are those who are worried that if Rizia grants more rights to Golcondists, the kingdom will fall victim to the same ideologies as Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Player_Romus: ""Even if the blasphemy law is revoked, Rizia will never t..."*)
  - -> `[482]` (*Player_Romus: ""Would that be so bad? We have much to learn from our Der..."*)
  - -> `[487]` (*Player_Romus: ""These worries are unfounded. The blasphemy law is stayin..."*)
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[481]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even if the blasphemy law is revoked, Rizia will never turn into Derdia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[479]` (Manus Sazon), `[480]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Manus Sazon: ""Yes, I also believe these fears are unfounded. The benef..."*)

### Węzeł `[482]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would that be so bad? We have much to learn from our Derdian neighbors.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[479]` (Manus Sazon), `[480]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Manus Sazon: ""Your Majesty, there is a reason the Nurist republic has ..."*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Player_Romus: ""We may need Derdia's help in the war. But I will not mak..."*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[486]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We may need Derdia's help in the war. But I will not make any ideological concessions to the Nurist republic.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[479]` (Manus Sazon), `[480]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Manus Sazon: ""I do not view the revocation of the blasphemy law as a c..."*)

### Węzeł `[487]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""These worries are unfounded. The blasphemy law is staying in place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[479]` (Manus Sazon), `[480]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Manus Sazon: ""I still believe the benefits of revoking it outweigh the..."*)

### Węzeł `[488]`
Mówca: **Manus Sazon**
> ""I do not view the revocation of the blasphemy law as a concession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");  // Removes the convers..."*)

### Węzeł `[489]`
Mówca: **Manus Sazon**
> ""Yes, I also believe these fears are unfounded. The benefits of revoking the law outweigh the drawbacks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");  // Removes the convers..."*)

### Węzeł `[490]`
Mówca: **Manus Sazon**
> ""Your Majesty, there is a reason the Nurist republic has been diplomatically isolated since its founding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");  // Removes the convers..."*)

### Węzeł `[491]`
Mówca: **Manus Sazon**
> ""I still believe the benefits of revoking it outweigh the drawbacks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");  // Removes the convers..."*)

### Węzeł `[492]`
Mówca: **Daria de Rava**
> ""Naturally, the sudden acceptance of Derdian and Bludish worshippers in our sacred archsanctuaries has caused chaos within the Wruhecist community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Narrator: "Out of the corner of my eye, I saw Hugo nod emphatically."*)

### Węzeł `[493]`
Mówca: **Daria de Rava**
> ""However, the general public remains worried about the growing legitimization of this extremist sect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Daria de Rava: ""Especially ahead of Rizia's upcoming diplomatic visit to..."*)

### Węzeł `[494]`
Mówca: **Daria de Rava**
> ""Admittedly, it has helped soften the backlash against our border ban on natives of those countries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Daria de Rava: ""However, the general public remains worried about the gr..."*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianB..."*)
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdia..."*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Daria de Rava: ""Admittedly, it has helped soften the backlash against ou..."*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Daria de Rava: ""However, the general public remains worried about the gr..."*)

### Węzeł `[498]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Golcondists are Wruhecists like any others. Their beliefs are as valid as yours or mine.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true`
- **Kontekst wejściowy (poprzednik):** `[505]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Daria de Rava: ""Our respected religious leaders would beg to disagree. I..."*)

### Węzeł `[499]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I gave all Rizians an equal right to worship, regardless of religion. It's not like Golcondists are receiving special treatment.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[505]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Daria de Rava: ""Many religious leaders, our Grand Wiseman included, woul..."*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_StateReligion_Wruhecism == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_StateReligion_Wruhecism == true"*)
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Law_StateReligion_Wruhecism == true)"*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_StateReligion_Wruhecism == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Player_Romus: ""Golcondists are Wruhecists like any others. Their belief..."*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Law_StateReligion_Wruhecism == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Player_Romus: ""I gave all Rizians an equal right to worship, regardless..."*)

### Węzeł `[503]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The public has been scared away by decades of harmful stereotypes. They'll warm up to Golcondists in time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[505]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Daria de Rava: ""Their fears about Golcondists are based on more than mer..."*)

### Węzeł `[504]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We need Derdia's help in the war. Accepting Golcondists is all part of my strategy.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[505]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Daria de Rava: ""I respect that. But we must be careful not to align with..."*)

### Węzeł `[505]`
Mówca: **Daria de Rava**
> ""Especially ahead of Rizia's upcoming diplomatic visit to Derdia, there are concerns about giving too much credence to Golcondist beliefs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_StateReligion_Wruhecism == true"*)
  - -> `[503]` (*Player_Romus: ""The public has been scared away by decades of harmful st..."*)
  - -> `[506]` (*Player_Romus: ""The concerns are over nothing. Rizia will never turn int..."*)
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[506]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The concerns are over nothing. Rizia will never turn into Derdia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[505]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Daria de Rava: ""No. Not as long as the majority of our citizens still op..."*)

### Węzeł `[507]`
Mówca: **Daria de Rava**
> ""Our respected religious leaders would beg to disagree. Including the Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[508]`
Mówca: **Sal Ignacius**
> ""I warned you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Narrator: "The Delegates turned to look at Sal."*)

### Węzeł `[509]`
Mówca: **Narrator**
> "The Delegates turned to look at Sal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Sal Ignacius: ""By accepting Golcondist worshippers, we have opened the ..."*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Player_Romus: ""We need Derdia's help in the war. Accepting Golcondists ..."*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[513]`
Mówca: **Daria de Rava**
> ""Many religious leaders, our Grand Wiseman included, would call their presence a threat to mainstream Wruhecism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[514]`
Mówca: **Daria de Rava**
> ""Their fears about Golcondists are based on more than mere stereotypes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[515]`
Mówca: **Daria de Rava**
> ""No. Not as long as the majority of our citizens still oppose Golcondism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[516]`
Mówca: **Daria de Rava**
> ""I respect that. But we must be careful not to align with them too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)"*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Sal Ignacius: ""I warned you, Your Majesty.""*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");  // Removes the convers..."*)

### Węzeł `[520]`
Mówca: **Sal Ignacius**
> ""By accepting Golcondist worshippers, we have opened the door to darkness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Daria de Rava: ""Thank you, Grand Wiseman.""*)

### Węzeł `[521]`
Mówca: **Daria de Rava**
> ""Thank you, Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");  // Removes the convers..."*)

### Węzeł `[522]`
Mówca: **Daria de Rava**
> ""Together with the border ban we implemented in agreement with Wehlen, they point to it as evidence that the Crown discriminates against Golcondism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Daria de Rava: ""However, these complaints are only coming from a fractio..."*)

### Węzeł `[523]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianB..."*)
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdia..."*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Daria de Rava: ""Together with the border ban we implemented in agreement..."*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Daria de Rava: ""They point to it as evidence that the Crown discriminate..."*)

### Węzeł `[526]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, I find the accusations worrying. I do not want my citizens to feel discriminated against.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[555]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Manus Sazon: ""My party agrees, Your Majesty. Granting all citizens an ..."*)

### Węzeł `[527]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. Because I have no intention of lifting it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[555]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Manus Sazon: ""I must object, Your Majesty. Even if Golcondists make up..."*)

### Węzeł `[528]`
Mówca: **Manus Sazon**
> ""I must object, your Majesty. We have no proof that the Golcondists we are turning away at the border are terrorists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[529]`
Mówca: **Manus Sazon**
> ""I must object, Your Majesty. We cannot use the problematic views of a few followers to justify denying rights to the Golcondist community as a whole.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[530]`
Mówca: **Manus Sazon**
> ""My party agrees, Your Majesty. Granting all citizens an equal right to worship would be a great step forward for freedom in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[531]`
Mówca: **Manus Sazon**
> ""I must object, Your Majesty. Even if Golcondists make up a minority of society, they deserve the right to worship like anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)"*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Sal Ignacius: ""Foolish words, Mr. Sazon.""*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Daria de Rava: ""Silence, Mr. Sazon.""*)

### Węzeł `[535]`
Mówca: **Daria de Rava**
> ""They point to it as evidence that the Crown discriminates against Golcondism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Daria de Rava: ""However, these complaints are only coming from a fractio..."*)

### Węzeł `[536]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's wrong with discrimination against Golcondists? Their faith is totally incompatible with modern Rizian society.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[555]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Manus Sazon: ""I must object, Your Majesty. We cannot use the problemat..."*)

### Węzeł `[537]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is not discriminatory to crack down on terrorism.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true`
- **Kontekst wejściowy (poprzednik):** `[555]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Manus Sazon: ""I must object, your Majesty. We have no proof that the G..."*)

### Węzeł `[538]`
Mówca: **Daria de Rava**
> ""However, these complaints are only coming from a fraction of the populace. The majority want our law to stay in place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Narrator: "My uncle looked relieved. He nodded emphatically."*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianB..."*)
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdia..."*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Player_Romus: ""It is not discriminatory to crack down on terrorism.""*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan == true || RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianBan"] == true  or  Variable["RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishBan"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[542]`
Mówca: **Sal Ignacius**
> ""Foolish words, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Narrator: "The delegates turned to look at Sal."*)

### Węzeł `[543]`
Mówca: **Narrator**
> "The delegates turned to look at Sal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Sal Ignacius: ""I have made myself clear on this subject time and time a..."*)

### Węzeł `[544]`
Mówca: **Sal Ignacius**
> ""I have made myself clear on this subject time and time again. By allowing Golcondists to flood our holy sites, we would be opening the door to darkness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Daria de Rava: ""We have seen the influence of Golcondism on our neighbor..."*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)"*)

### Węzeł `[546]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Sal Ignacius: ""Foolish words, Mr. Sazon.""*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Daria de Rava: ""Silence, Mr. Sazon.""*)

### Węzeł `[548]`
Mówca: **Daria de Rava**
> ""Silence, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Daria de Rava: ""We have seen the influence of Golcondism on our neighbor..."*)

### Węzeł `[549]`
Mówca: **Daria de Rava**
> ""We have seen the influence of Golcondism on our neighbor Derdia. Our citizens do not want Rizia to fall victim to the same fate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Player_Romus: ""Even if the blasphemy law is revoked, Rizia will never t..."*)
  - -> `[551]` (*Player_Romus: ""Would that be so bad? We have much to learn from Supreme..."*)
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[550]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even if the blasphemy law is revoked, Rizia will never turn into Derdia. Our traditions are too strong.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[549]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Daria de Rava: ""I should hope so.""*)

### Węzeł `[551]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would that be so bad? We have much to learn from Supreme Wiseman Azmal and his people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[549]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Daria de Rava: ""Your Majesty, there is a reason the Nurist republic has ..."*)

### Węzeł `[552]`
Mówca: **Daria de Rava**
> ""I should hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");  // Removes the convers..."*)

### Węzeł `[553]`
Mówca: **Daria de Rava**
> ""Your Majesty, there is a reason the Nurist republic has been diplomatically isolated since its founding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");  // Removes the convers..."*)

### Węzeł `[554]`
Mówca: **Narrator**
> "I saw Hugo raise his eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianB..."*)

### Węzeł `[555]`
Mówca: **Narrator**
> "My uncle looked relieved. He nodded emphatically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianB..."*)
  - -> `[536]` (*Player_Romus: ""What's wrong with discrimination against Golcondists? Th..."*)
  - -> `[526]` (*Player_Romus: ""Still, I find the accusations worrying. I do not want my..."*)
  - -> `[527]` (*Player_Romus: ""Good. Because I have no intention of lifting it.""*)

### Węzeł `[556]`
Mówca: **Narrator**
> "Out of the corner of my eye, I saw Hugo nod emphatically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Wehlen_Terrorism_BludishDerdianB..."*)

### Węzeł `[557]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I admit we need Derdia's help in the war. But I will not make any ideological concessions to them.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[549]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Daria de Rava: ""Very good.""*)

### Węzeł `[558]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Player_Romus: ""I admit we need Derdia's help in the war. But I will not..."*)

### Węzeł `[560]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[561]`
Mówca: **Daria de Rava**
> ""Very good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");  // Removes the convers..."*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Sal Ignacius");

// Removes the conversant with the character name in database`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Sal Ignacius");
-- Removes the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
