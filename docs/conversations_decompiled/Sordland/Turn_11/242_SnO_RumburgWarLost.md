# Sordland/Turn11/SnO_RumburgWarLost

- **ID konwersacji:** `242`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Sordland/Turn_11/242_SnO_RumburgWarLost.md`
- **Liczba węzłów dialogowych:** 411
- **Liczba wyborów gracza:** 80

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[20]** Deana
- **[31]** Franc
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_DivorceAfterElection`
- `BaseGame.RumburgWarLost_Alone`
- `BaseGame.RumburgWarLost_WholeFamilyWithYou`
- `BaseGame.Turn07_Personal_FrancConscripted`
- `BaseGame.Turn07_Personal_FrancMilitarySchool`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGame.Turn07_Personal_University_Home_Public`
- `BaseGame.Turn08_SecondScandal_LiviaTrialled`
- `BaseGame.Turn10_SnO_FrancPulledToHolsord`
- `BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh`
- `BaseGame.Turn10_SnO_Phase1_DigDown`
- `BaseGame.Turn10_SnO_Phase1_Success`
- `BaseGame.Turn10_SnO_Phase2_TakeDome`
- `BaseGameIsolated.Turn11_SnO_Chair`
- `BaseGameIsolated.Turn11_SnO_Curtain`
- `BaseGameIsolated.Turn11_SnO_Photo`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Franc_Died`
- `BaseGame.RumburgWarLost_Alone`
- `BaseGame.RumburgWarLost_MonicaDeanaWithYou`
- `BaseGame.RumburgWarLost_WholeFamilyWithYou`
- `BaseGameIsolated.Turn11_SnO_Chair`
- `BaseGameIsolated.Turn11_SnO_Curtain`
- `BaseGameIsolated.Turn11_SnO_Photo`
- `BaseGameIsolated.Turn11_SnO_PointGunToHead`
- `BaseGameIsolated.Turn11_SnO_PointGunToSoldier`
- `BaseGameIsolated.Turn11_SnO_Surrender`
- `GameCondition.Turn11_SnO_RumburgWarLost`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[9]` | **"“Tell me Iosef. What did I do wrong? What did I do to deserve this?”"** | `[112]` **Iosef Lancea**: "“Sir. The Palace is about to fal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Iosef Lancea**: "“I don't know, Mr. President. Ma..." |
| `[11]` | **"Point the gun towards the soldier."** | `[30]` **Narrator**: "The door burst open and a soldie..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn11_SnO_PointGunToSoldier"]...`<br>`Variable["GameCondition.Turn11_SnO_RumburgWarLost"] = true;`<br>*(+4 skryptów)* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[17]` | **"“Likewise, Iosef.”"** | `[16]` **Iosef Lancea**: "“No matter what, it was an honor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "He saluted me." |
| `[18]` | **"“I'll see you on the other side.""** | `[16]` **Iosef Lancea**: "“No matter what, it was an honor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "He saluted me." |
| `[19]` | **"Salute him."** | `[16]` **Iosef Lancea**: "“No matter what, it was an honor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Iosef Lancea**: "“A Morgna wes core!”" |
| `[22]` | **"“Vectern sis da!”"** | `[21]` **Iosef Lancea**: "“A Morgna wes core!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Narrator**: "Iosef ran to the door and opened..." |
| `[29]` | **"Point the gun towards your own head."** | `[30]` **Narrator**: "The door burst open and a soldie..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn11_SnO_PointGunToHead"] = ...`<br>`Variable["GameCondition.Turn11_SnO_RumburgWarLost"] = true;`<br>*(+4 skryptów)* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[65]` | **"“This can't be true.”"** | `[71]` **Iosef Lancea**: "“Monica and Deana are unharmed a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Iosef Lancea**: "“I'm afraid it is, sir. He valia..." |
| `[66]` | **"“I need a minute, Iosef.”"** | `[71]` **Iosef Lancea**: "“Monica and Deana are unharmed a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Iosef Lancea**: "“Of course, sir.”" |
| `[72]` | **"“This is all my fault. I caused my son's death.”"** | `[71]` **Iosef Lancea**: "“Monica and Deana are unharmed a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Iosef Lancea**: "“Please do not blame yourself, M..." |
| `[74]` | **"“Death is never the end, my dear daughter. It comes to all of us at one point in o..."** | `[42]` **Narrator**: "Monica started sobbing uncontrol..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Deana**: "“That's not the answer I was loo..." |
| `[75]` | **"“No. We will not die, Deana. As long as I am here, don't worry.”"** | `[42]` **Narrator**: "Monica started sobbing uncontrol..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Monica**: "“I don't know, Anton. Franc is g..." |
| `[76]` | **"Keep silent and hug her."** | `[42]` **Narrator**: "Monica started sobbing uncontrol..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Monica**: "“I don't know, Anton. Franc is g..." |
| `[79]` | **"“Deana is still here, Monica.”"** | `[78]` **Monica**: "“I don't know, Anton. Franc is g..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Narrator**: "Deana went to Monica and hugged ..." |
| `[80]` | **"“We still have each other. We need to live for his sake.”"** | `[78]` **Monica**: "“I don't know, Anton. Franc is g..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Narrator**: "Deana went to Monica and hugged ..." |
| `[81]` | **"“We have no choice.”"** | `[78]` **Monica**: "“I don't know, Anton. Franc is g..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Narrator**: "Deana went to Monica and hugged ..." |
| `[83]` | **"“Death is never the end, my dear daughter. It comes to all of us at one point in o..."** | `[58]` **Deana**: "“Papa. Are we going to die?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[394]` **Deana**: ""But I'm not even a grown-up yet..." |
| `[84]` | **"“No. We will not die, Deana. As long as I am here, don't worry.”"** | `[58]` **Deana**: "“Papa. Are we going to die?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Deana**: ""All right. I trust you, Papa."" |
| `[85]` | **"Keep silent and hug her."** | `[58]` **Deana**: "“Papa. Are we going to die?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Monica**: "“Anton, can you come here for a ..." |
| `[90]` | **"“We will make through this somehow. I promise.”"** | `[89]` **Monica**: "“What is really going on? Tell m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Monica**: "“You better keep that promise, A..." |
| `[91]` | **"“We are most likely done for.”"** | `[89]` **Monica**: "“What is really going on? Tell m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Monica**: "“But, Deana... Franc...”" |
| `[93]` | **"“How long until they find us?""** | `[92]` **Iosef Lancea**: "“The enemy is preparing to breac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[304]` **Iosef Lancea**: "“That depends, sir. If your ex-s..."<br>`[96]` **Iosef Lancea**: "“Don't worry, sir. Unless they s..." |
| `[94]` | **"“Are we safe here, Iosef?”"** | `[92]` **Iosef Lancea**: "“The enemy is preparing to breac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[304]` **Iosef Lancea**: "“That depends, sir. If your ex-s..."<br>`[96]` **Iosef Lancea**: "“Don't worry, sir. Unless they s..." |
| `[95]` | **"“What do you make of the situation?”"** | `[92]` **Iosef Lancea**: "“The enemy is preparing to breac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[304]` **Iosef Lancea**: "“That depends, sir. If your ex-s..."<br>`[96]` **Iosef Lancea**: "“Don't worry, sir. Unless they s..." |
| `[107]` | **"“I wish I knew that, son.”"** | `[106]` **Franc**: "“Dad. Seriously, tell me. Are we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Franc**: "“Not very reassuring.”" |
| `[108]` | **"“Don't fret. You are a Rayne. You have to be strong.”"** | `[106]` **Franc**: "“Dad. Seriously, tell me. Are we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Franc**: "“So, the answer is yes, then."" |
| `[113]` | **"“So is this the end?”"** | `[112]` **Iosef Lancea**: "“Sir. The Palace is about to fal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Iosef Lancea**: "“Looks like it. They've got troo..." |
| `[114]` | **"“What are we going to do?”"** | `[112]` **Iosef Lancea**: "“Sir. The Palace is about to fal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Iosef Lancea**: "“Our hands are tied. They've got..." |
| `[115]` | **"“I order you to get us out of here. Immediately.”"** | `[112]` **Iosef Lancea**: "“Sir. The Palace is about to fal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Iosef Lancea**: "“I'm afraid that is not possible..." |
| `[120]` | **"“I want to see my office one last time.”"** | `[122]` **Iosef Lancea**: "“Because this room will be our g..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Iosef Lancea**: "“Are you mad? Do you want to run..." |
| `[123]` | **"“We will barricade ourselves in and hope for the best.”"** | `[122]` **Iosef Lancea**: "“Because this room will be our g..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Iosef Lancea**: "“It's not like we have much of a..." |
| `[125]` | **"“At least I will die fighting instead of cowering down here.”"** | `[124]` **Iosef Lancea**: "“Are you mad? Do you want to run..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Iosef Lancea**: "“It's one last battle for me, th..." |
| `[126]` | **"“Why does it matter if we're going to die anyway?""** | `[124]` **Iosef Lancea**: "“Are you mad? Do you want to run..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Iosef Lancea**: "“I guess you have a point.”" |
| `[127]` | **"“You're right, I don't. Maybe we should stay here. Maybe someone will come to our ..."** | `[124]` **Iosef Lancea**: "“Are you mad? Do you want to run..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Iosef Lancea**: "“It's not like we have much of a..." |
| `[140]` | **"“I'm just going to have a quick look around. I'll be right back.""** | `[139]` **Monica**: "“Anton, don't you fucking dare."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Monica**: ""At the Palace? That's suicide."" |
| `[141]` | **"“I'm sorry, Monica. It's the only way to save you and Deana.""** | `[139]` **Monica**: "“Anton, don't you fucking dare."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Monica**: "“You don't get to decide that."" |
| `[150]` | **"Open the curtains to look outside."** | `[149]` **Iosef Lancea**: "“I'll go check the perimeter, Mr..."<br>`[175]` **Narrator**: "So this is what had become of Ho..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn11_SnO_Curtain"] == false` | *Brak zmian stanu* | `[173]` **Narrator**: "Black smoke was rising from down..." |
| `[151]` | **"Sit in your chair for one last time."** | `[149]` **Iosef Lancea**: "“I'll go check the perimeter, Mr..."<br>`[175]` **Narrator**: "So this is what had become of Ho..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn11_SnO_Chair"] == false` | *Brak zmian stanu* | `[170]` **Narrator**: "I ran my hands over the leather ..." |
| `[152]` | **"Pour yourself a glass of Erlory Maroon 30-year-old."** | `[149]` **Iosef Lancea**: "“I'll go check the perimeter, Mr..."<br>`[175]` **Narrator**: "So this is what had become of Ho..."<br>*(oraz 2 innych węzłów)* | `Variable["BaseGameIsolated.Turn11_SnO_Photo"] == false` | *Brak zmian stanu* | `[167]` **Narrator**: "The taste was as exquisite as ever." |
| `[177]` | **"“They only want *me*. I'm going to the Palace.""** | `[122]` **Iosef Lancea**: "“Because this room will be our g..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Iosef Lancea**: "“Are you mad? Do you want to run..." |
| `[179]` | **"“I have a duty to this nation.”"** | `[178]` **Iosef Lancea**: "“Are you mad? Do you want to run..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Iosef Lancea**: "“You have shown me you are not a..." |
| `[180]` | **"“I will not let anyone else die for me.”"** | `[178]` **Iosef Lancea**: "“Are you mad? Do you want to run..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Iosef Lancea**: "“You have shown me you are not a..." |
| `[188]` | **"“Calm down. It's going to be all right.”"** | `[194]` **Deana**: "“Papa!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Iosef Lancea**: "“Mr. President. What do we do?”" |
| `[193]` | **"“Quiet.”"** | `[194]` **Deana**: "“Papa!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Iosef Lancea**: "“Mr. President. What do we do?”" |
| `[201]` | **"“When they enter, we will declare surrender. Don't make any sudden moves.”"** | `[200]` **Narrator**: "He turned to me and gave me his ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Iosef Lancea**: "“I doubt they will let us, but l..." |
| `[202]` | **"“I hope I don't miss.”"** | `[200]` **Narrator**: "He turned to me and gave me his ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Iosef Lancea**: "“Now is the time to remember tha..." |
| `[204]` | **"“Ready?”"** | `[200]` **Narrator**: "He turned to me and gave me his ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Iosef Lancea**: "“As ready as I can be.”" |
| `[216]` | **"“Vectern sis da.”"** | `[215]` **Narrator**: "His head fell to the side, motio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Narrator**: "I closed his eyes with my hand." |
| `[220]` | **"“Iosef. Bring the pills. They won't take us alive.""** | `[195]` **Iosef Lancea**: "“Mr. President. What do we do?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[223]` **Iosef Lancea**: "“Roger that, sir.”" |
| `[221]` | **""We'll hold tight and hope for the best.""** | `[195]` **Iosef Lancea**: "“Mr. President. What do we do?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[222]` **Iosef Lancea**: "“Very well.”" |
| `[230]` | **"“Likewise, Iosef.”"** | `[228]` **Iosef Lancea**: "“No matter what, it was an honor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Narrator**: "He saluted me." |
| `[231]` | **"“I'll see you on the other side.""** | `[228]` **Iosef Lancea**: "“No matter what, it was an honor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Narrator**: "He saluted me." |
| `[232]` | **"Salute him."** | `[228]` **Iosef Lancea**: "“No matter what, it was an honor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[234]` **Iosef Lancea**: "“A Morgna wes core!”" |
| `[233]` | **"“Vectern sis da!”"** | `[234]` **Iosef Lancea**: "“A Morgna wes core!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Iosef Lancea**: "“I will be in the other room.”" |
| `[242]` | **"“Likewise, Iosef.”"** | `[244]` **Iosef Lancea**: "“No matter what, it was an honor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[245]` **Narrator**: "He saluted me." |
| `[243]` | **"Salute him."** | `[244]` **Iosef Lancea**: "“No matter what, it was an honor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[249]` **Iosef Lancea**: "“A Morgna wes core!”" |
| `[246]` | **"“I'll see you on the other side.""** | `[244]` **Iosef Lancea**: "“No matter what, it was an honor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[245]` **Narrator**: "He saluted me." |
| `[248]` | **"“Vectern sis da!”"** | `[249]` **Iosef Lancea**: "“A Morgna wes core!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Iosef Lancea**: "“I will be in the other room.”" |
| `[254]` | **"Point the gun towards the soldier."** | `[258]` **Narrator**: "The door swung open and a Rumbur..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn11_SnO_PointGunToSoldier"]...`<br>`Variable["GameCondition.Turn11_SnO_RumburgWarLost"] = true;`<br>*(+4 skryptów)* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[257]` | **"Point the gun towards your head."** | `[258]` **Narrator**: "The door swung open and a Rumbur..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn11_SnO_PointGunToHead"] = ...`<br>`Variable["GameCondition.Turn11_SnO_RumburgWarLost"] = true;`<br>*(+4 skryptów)* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[261]` | **"Point the gun towards the soldier."** | `[260]` **Narrator**: "I stood up, and one of the men t..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn11_SnO_PointGunToSoldier"]...`<br>`Variable["GameCondition.Turn11_SnO_RumburgWarLost"] = true;`<br>*(+4 skryptów)* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[262]` | **"Point the gun towards your head."** | `[260]` **Narrator**: "I stood up, and one of the men t..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn11_SnO_PointGunToHead"] = ...`<br>`Variable["GameCondition.Turn11_SnO_RumburgWarLost"] = true;`<br>*(+4 skryptów)* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[265]` | **"“I surrender! Please don't hurt my family! I beg you! Please!”"** | `[260]` **Narrator**: "I stood up, and one of the men t..." | `Variable["BaseGame.RumburgWarLost_Alone"] == false` | `Variable["BaseGameIsolated.Turn11_SnO_Surrender"] = true;`<br>`Variable["GameCondition.Turn11_SnO_RumburgWarLost"] = true;`<br>*(+4 skryptów)* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[269]` | **"“I surrender! Please don't hurt me! I beg you! Please!”"** | `[260]` **Narrator**: "I stood up, and one of the men t..." | `(Variable["BaseGame.RumburgWarLost_Alone"] == false) == false` | `Variable["BaseGameIsolated.Turn11_SnO_Surrender"] = true;`<br>`Variable["GameCondition.Turn11_SnO_RumburgWarLost"] = true;`<br>*(+4 skryptów)* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[271]` | **"“I surrender! Please don't hurt me! I beg you! Please!”"** | `[30]` **Narrator**: "The door burst open and a soldie..." | `(Variable["BaseGame.RumburgWarLost_Alone"] == false) == false` | `Variable["BaseGameIsolated.Turn11_SnO_Surrender"] = true;`<br>`Variable["GameCondition.Turn11_SnO_RumburgWarLost"] = true;`<br>*(+4 skryptów)* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[272]` | **"“I surrender! Please don't hurt my family! I beg you! Please!”"** | `[30]` **Narrator**: "The door burst open and a soldie..." | `Variable["BaseGame.RumburgWarLost_Alone"] == false` | `Variable["BaseGameIsolated.Turn11_SnO_Surrender"] = true;`<br>`Variable["GameCondition.Turn11_SnO_RumburgWarLost"] = true;`<br>*(+4 skryptów)* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[293]` | **"“Give 'em hell!""** | `[21]` **Iosef Lancea**: "“A Morgna wes core!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Narrator**: "Iosef ran to the door and opened..." |
| `[294]` | **""I love you.""** | `[142]` **Monica**: ""At the Palace? That's suicide.""<br>`[143]` **Monica**: "“You don't get to decide that."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Narrator**: "Iosef punched a code into the pa..." |
| `[295]` | **""Don't open this door after I leave. No matter what you hear.""** | `[142]` **Monica**: ""At the Palace? That's suicide.""<br>`[143]` **Monica**: "“You don't get to decide that."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Narrator**: "Iosef punched a code into the pa..." |
| `[296]` | **"“For Sordland!""** | `[234]` **Iosef Lancea**: "“A Morgna wes core!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Iosef Lancea**: "“I will be in the other room.”" |
| `[298]` | **"“For Sordland!""** | `[249]` **Iosef Lancea**: "“A Morgna wes core!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Iosef Lancea**: "“I will be in the other room.”" |
| `[299]` | **"“Goodbye, Iosef.""** | `[215]` **Narrator**: "His head fell to the side, motio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Narrator**: "I closed his eyes with my hand." |
| `[395]` | **""It's my fault, General. I got us into an unwinnable war.""** | `[369]` **Narrator**: "Iosef stared down at the floor, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[370]` **Narrator**: "I was interrupted by the sudden ..." |
| `[396]` | **""We can't do anything about that now. All we can do is make our last stand.""** | `[369]` **Narrator**: "Iosef stared down at the floor, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[370]` **Narrator**: "I was interrupted by the sudden ..." |
| `[397]` | **""You're right. This mess we're in is entirely your fault.""** | `[369]` **Narrator**: "Iosef stared down at the floor, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[370]` **Narrator**: "I was interrupted by the sudden ..." |
| `[398]` | **""It's my fault, General. I got us into an unwinnable war.""** | `[392]` **Narrator**: "Iosef stared down at the concret..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[401]` **Narrator**: "He didn't reply. We sat down in ..." |
| `[399]` | **""We can't do anything about that now. All we can do is try to survive.""** | `[392]` **Narrator**: "Iosef stared down at the concret..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[401]` **Narrator**: "He didn't reply. We sat down in ..." |
| `[400]` | **""You're right. This mess we're in is entirely your fault.""** | `[392]` **Narrator**: "Iosef stared down at the concret..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[401]` **Narrator**: "He didn't reply. We sat down in ..." |
| `[402]` | **"Don't say anything."** | `[392]` **Narrator**: "Iosef stared down at the concret..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Narrator**: "A half an hour passed, then an h..." |
| `[403]` | **"Don't say anything."** | `[369]` **Narrator**: "Iosef stared down at the floor, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[404]` **Narrator**: "The noise drew closer. The soldi..." |

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
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == tru..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I undid my tie slowly and rose from my seat in the protected bunker on the outskirts of Holsord. I increased the volume of the crackling radio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "“The enemy is advancing on us. Requesting backup. We are ..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Despite our location many meters underground, I felt the room shaking. It must've been the bombs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Iosef came out of the communications room and pulled me a..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "He stumbled inside, collapsed on the couch and took a huge slug of my whiskey."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Iosef Lancea: "“They are here, Mr. President.”"*)

### Węzeł `[6]`
Mówca: **Iosef Lancea**
> "“They are here, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Iosef Lancea: "“They are inside the Palace. They are coming for you.”"*)

### Węzeł `[7]`
Mówca: **Iosef Lancea**
> "“They are inside the Palace. They are coming for you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "I heard gunfire and more screams from the floor beneath us."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "I heard gunfire and more screams from the floor beneath us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Iosef Lancea: "“Don't forget about that handgun I gave you. Of course, i..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "“Tell me Iosef. What did I do wrong? What did I do to deserve this?”"]** — Mówca: **Player**
> "“Tell me Iosef. What did I do wrong? What did I do to deserve this?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Iosef Lancea: "“I don't know, Mr. President. Maybe you were just at the ..."*)

### Węzeł `[10]`
Mówca: **Iosef Lancea**
> "“I don't know, Mr. President. Maybe you were just at the wrong place at the wrong time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Iosef Lancea: "“If I were you I would start saying my prayers, sir.”"*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "Point the gun towards the soldier."]** — Mówca: **Player_Italic**
> "I pointed the gun towards the soldier."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_PointGunToSoldier = true"*)

### Węzeł `[12]`
Mówca: **Iosef Lancea**
> "“Don't forget about that handgun I gave you. Of course, it's up to you how you want to use it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Iosef Lancea: ""Mr. President, before I go...""*)

### Węzeł `[13]`
Mówca: **Iosef Lancea**
> "“Well, that's my cue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "He pointed to his belt. I saw several grenades hanging fr..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "He pointed to his belt. I saw several grenades hanging from it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Iosef Lancea: "“Out with a bang, right?""*)

### Węzeł `[15]`
Mówca: **Narrator**
> "Iosef turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Iosef Lancea: "“No matter what, it was an honor to serve you, sir.”"*)

### Węzeł `[16]`
Mówca: **Iosef Lancea**
> "“No matter what, it was an honor to serve you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: "“Likewise, Iosef.”"*)
  - -> `[18]` (*Player: "“I'll see you on the other side.""*)
  - -> `[19]` (*Player_Italic: "Salute him."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Likewise, Iosef.”"]** — Mówca: **Player**
> "“Likewise, Iosef.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "He saluted me."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“I'll see you on the other side.""]** — Mówca: **Player**
> "“I'll see you on the other side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "He saluted me."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "Salute him."]** — Mówca: **Player_Italic**
> "I saluted him and he saluted me back."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Iosef Lancea: "“A Morgna wes core!”"*)

### Węzeł `[20]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Iosef Lancea: "“A Morgna wes core!”"*)

### Węzeł `[21]`
Mówca: **Iosef Lancea**
> "“A Morgna wes core!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "“Vectern sis da!”"*)
  - -> `[293]` (*Player: "“Give 'em hell!""*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“Vectern sis da!”"]** — Mówca: **Player**
> "“Vectern sis da!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Iosef ran to the door and opened it. I heard the metallic..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "Iosef ran to the door and opened it. I heard the metallic sounds of the pins being removed from the grenades."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Iosef Lancea: "<shout>“Greci Sordland!”</shout>"*)

### Węzeł `[24]`
Mówca: **Iosef Lancea**
> "<shout>“Greci Sordland!”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("GunshotExplosion");"*)

### Węzeł `[25]`
Mówca: **Narrator**
> "Gunshots rang out, then an ear-splitting explosion, followed by silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "A good long minute passed. Then, I heard the faint sound ..."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "A good long minute passed. Then, I heard the faint sound of approaching footsteps."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "I redid my tie and looked at myself in the mirror before ..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "I redid my tie and looked at myself in the mirror before sitting down at my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "I looked down at the gun Iosef had given me and shifted i..."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "I looked down at the gun Iosef had given me and shifted it from one hand to the other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The door burst open and a soldier in Rumburgian uniform s..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "Point the gun towards your own head."]** — Mówca: **Player_Italic**
> "I pointed the gun towards my own head."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_PointGunToHead = true"*)

### Węzeł `[30]`
Mówca: **Narrator**
> "The door burst open and a soldier in Rumburgian uniform stormed in. He turned his rifle on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player_Italic: "Point the gun towards the soldier."*)
  - -> `[29]` (*Player_Italic: "Point the gun towards your own head."*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone == false"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn11_SnO_RumburgWarLost = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn11_SnO_RumburgWarLost"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "DisableToken("Sordland_Event_RumburgWar");"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_PointGunToSoldier = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_PointGunToSoldier"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_SnO_RumburgWarLost = true"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_PointGunToHead = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_PointGunToHead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_SnO_RumburgWarLost = true"*)

### Węzeł `[34]`
Mówca: **Narrator**
> "“The enemy is advancing on us. Requesting backup. We are surrounded from all sides. I repeat, we are surro--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "“They are using some kind of a gas. Our soldiers' eyes an..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "“They are using some kind of a gas. Our soldiers' eyes and ears are bleeding. We need immediate assistance on Victory Avenue. Medics! We need more medics!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "“They are approaching the Maroon Palace. We must protect ..."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "“They are coming in through the outer gates. They killed everyone. We surrendered our weapons but they won't stop shooting. If there is a God, I beg you. Please end this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "“If there is anyone listening right now... please. The wo..."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "“They are approaching the Maroon Palace. We must protect the president at all costs. Squad 6 will initiate the final charge while we barricade the palace. Please tell my wife I love her. Greci Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "“They are coming in through the outer gates. They killed ..."*)

### Węzeł `[38]`
Mówca: **Narrator**
> "Right now, he was monitoring communications in the adjoining room. I walked in and he saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Iosef Lancea: "“The enemy is preparing to breach the Palace. It's only a..."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "“If there is anyone listening right now... please. The world needs to know what is going on. This is no longer a war. This is a massacre! Squad 2 out.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Narrator: "I turned the radio off and swallowed hard. Nobody knew I ..."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "I looked at Monica and Deana. Deana's face was streaked with tears."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Deana: "“Papa, are we going to die like Franc did?”"*)

### Węzeł `[41]`
Mówca: **Deana**
> "“Papa, are we going to die like Franc did?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "Monica started sobbing uncontrollably. But there were no ..."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "Monica started sobbing uncontrollably. But there were no tears. She ran out many days ago, when we received the news of Franc's death near the border."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: "“Death is never the end, my dear daughter. It comes to al..."*)
  - -> `[75]` (*Player: "“No. We will not die, Deana. As long as I am here, don't ..."*)
  - -> `[76]` (*Player_Italic: "Keep silent and hug her."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "I breathed a sigh of relief that Monica and Deana were safely on their way to Arcasia, where they would meet up with Franc. My family wouldn't be paying for my mistakes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Despite our location many meters underground, I felt the ..."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "I breathed a sigh of relief that Monica and Deana were safely on their way to United Contana, where they would meet up with Franc. My family wouldn't be paying for my mistakes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Despite our location many meters underground, I felt the ..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "I breathed a sigh of relief that Monica and Deana were sa..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Home_Public == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Home_Public == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Home_Public == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Home_Public == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Home_Public == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_FrancPulledToHolsord == true"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "I breathed a sigh of relief that Monica and Deana were sa..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Home_Public == true"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_FrancPulledToHolsord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_FrancPulledToHolsord == true"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_FrancPulledToHolsord == true)"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_FrancPulledToHolsord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_DivorceAfterElection == true ||..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_FrancPulledToHolsord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_DivorceAfterElection == true ||..."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "I looked at Monica, Deana and Franc. Deana started running to me, crying. I wiped her tears away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Deana: "“Papa. Are we going to die?”"*)

### Węzeł `[58]`
Mówca: **Deana**
> "“Papa. Are we going to die?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player: "“Death is never the end, my dear daughter. It comes to al..."*)
  - -> `[84]` (*Player: "“No. We will not die, Deana. As long as I am here, don't ..."*)
  - -> `[85]` (*Player_Italic: "Keep silent and hug her."*)

### Węzeł `[59]`
Mówca: **Narrator**
> "I breathed a sigh of relief that Monica, Deana and Franc were on their way to Benfi, where they'd be safe from the bloodshed. I had sent them there under the protection of Franc's army squad."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "They were supposed to have gotten there right about now."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "They were supposed to have gotten there right about now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "Iosef walked back over to me."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "Iosef walked back over to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Iosef Lancea: "“Mr. President. I am afraid I have bad news.”"*)

### Węzeł `[62]`
Mówca: **Iosef Lancea**
> "“Mr. President. I am afraid I have bad news.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_DivorceAfterElection == true ||..."*)

### Węzeł `[63]`
Mówca: **Iosef Lancea**
> "“The military convoy carrying your children and ex-wife was ambushed by Rumburg troops on its way out of Holsord. Franc sacrificed his life in order to grant safe passage to Monica, your daughter, and the rest of his squad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Iosef Lancea: "“He died a hero, sir.”"*)

### Węzeł `[64]`
Mówca: **Iosef Lancea**
> "“He died a hero, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Iosef Lancea: "“Monica and Deana are unharmed and will be arriving in Be..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“This can't be true.”"]** — Mówca: **Player**
> "“This can't be true.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Iosef Lancea: "“I'm afraid it is, sir. He valiantly gave his life for So..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“I need a minute, Iosef.”"]** — Mówca: **Player**
> "“I need a minute, Iosef.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Iosef Lancea: "“Of course, sir.”"*)

### Węzeł `[67]`
Mówca: **Iosef Lancea**
> "“I'm afraid it is, sir. He valiantly gave his life for Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Iosef Lancea: "“I will give you some time.”"*)

### Węzeł `[68]`
Mówca: **Iosef Lancea**
> "“Of course, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "He left me alone in the room. I wept uncontrollably until..."*)

### Węzeł `[69]`
Mówca: **Iosef Lancea**
> "“I will give you some time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "He left me alone in the room. I wept uncontrollably until..."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "He left me alone in the room. I wept uncontrollably until I exhausted myself and passed out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Franc_Died = true"*)

### Węzeł `[71]`
Mówca: **Iosef Lancea**
> "“Monica and Deana are unharmed and will be arriving in Benfi soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: "“This can't be true.”"*)
  - -> `[72]` (*Player: "“This is all my fault. I caused my son's death.”"*)
  - -> `[66]` (*Player: "“I need a minute, Iosef.”"*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "“This is all my fault. I caused my son's death.”"]** — Mówca: **Player**
> "“This is all my fault. I caused my son's death.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Iosef Lancea: "“Please do not blame yourself, Mr. President. We need you..."*)

### Węzeł `[73]`
Mówca: **Iosef Lancea**
> "“Please do not blame yourself, Mr. President. We need you to be strong. Your country needs you to be strong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "He left me alone in the room. I wept uncontrollably until..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "“Death is never the end, my dear daughter. It comes to all of us at one point in our lives.”"]** — Mówca: **Player**
> "“Death is never the end, my dear daughter. It comes to all of us at one point in our lives.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Deana: "“That's not the answer I was looking for.""*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“No. We will not die, Deana. As long as I am here, don't worry.”"]** — Mówca: **Player**
> "“No. We will not die, Deana. As long as I am here, don't worry.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Monica: "“I don't know, Anton. Franc is gone and Sordland's a wrec..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "Keep silent and hug her."]** — Mówca: **Player_Italic**
> "I kept silent and hugged her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Monica: "“I don't know, Anton. Franc is gone and Sordland's a wrec..."*)

### Węzeł `[77]`
Mówca: **Deana**
> "“That's not the answer I was looking for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Monica: "“I don't know, Anton. Franc is gone and Sordland's a wrec..."*)

### Węzeł `[78]`
Mówca: **Monica**
> "“I don't know, Anton. Franc is gone and Sordland's a wreck... how are we supposed to go on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: "“Deana is still here, Monica.”"*)
  - -> `[80]` (*Player: "“We still have each other. We need to live for his sake.”"*)
  - -> `[81]` (*Player: "“We have no choice.”"*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "“Deana is still here, Monica.”"]** — Mówca: **Player**
> "“Deana is still here, Monica.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Deana went to Monica and hugged her."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "“We still have each other. We need to live for his sake.”"]** — Mówca: **Player**
> "“We still have each other. We need to live for his sake.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Deana went to Monica and hugged her."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "“We have no choice.”"]** — Mówca: **Player**
> "“We have no choice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "Deana went to Monica and hugged her."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "Deana went to Monica and hugged her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Franc_Died = true"*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“Death is never the end, my dear daughter. It comes to all of us at one point in our lives.”"]** — Mówca: **Player**
> "“Death is never the end, my dear daughter. It comes to all of us at one point in our lives.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Deana: ""But I'm not even a grown-up yet! I'm not ready...""*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“No. We will not die, Deana. As long as I am here, don't worry.”"]** — Mówca: **Player**
> "“No. We will not die, Deana. As long as I am here, don't worry.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Deana: ""All right. I trust you, Papa.""*)

### Węzeł `[85]`
**[WYBÓR GRACZA: "Keep silent and hug her."]** — Mówca: **Player_Italic**
> "I kept silent and hugged her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Monica: "“Anton, can you come here for a second?”"*)

### Węzeł `[86]`
Mówca: **Deana**
> ""All right. I trust you, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Monica: "“Anton, can you come here for a second?”"*)

### Węzeł `[87]`
Mówca: **Narrator**
> "We went to a corner where Deana wouldn't be able to hear us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Monica: "“What is really going on? Tell me the truth.”"*)

### Węzeł `[88]`
Mówca: **Monica**
> "“Anton, can you come here for a second?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "We went to a corner where Deana wouldn't be able to hear us."*)

### Węzeł `[89]`
Mówca: **Monica**
> "“What is really going on? Tell me the truth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: "“We are most likely done for.”"*)
  - -> `[90]` (*Player: "“We will make through this somehow. I promise.”"*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "“We will make through this somehow. I promise.”"]** — Mówca: **Player**
> "“We will make through this somehow. I promise.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Monica: "“You better keep that promise, Anton.”"*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "“We are most likely done for.”"]** — Mówca: **Player**
> "“We are most likely done for.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Monica: "“But, Deana... Franc...”"*)

### Węzeł `[92]`
Mówca: **Iosef Lancea**
> "“The enemy is preparing to breach the Palace. It's only a matter of time before they realize you're not there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "“How long until they find us?""*)
  - -> `[94]` (*Player: "“Are we safe here, Iosef?”"*)
  - -> `[95]` (*Player: "“What do you make of the situation?”"*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "“How long until they find us?""]** — Mówca: **Player**
> "“How long until they find us?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaTrialled == true"*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "“Are we safe here, Iosef?”"]** — Mówca: **Player**
> "“Are we safe here, Iosef?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaTrialled == true"*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "“What do you make of the situation?”"]** — Mówca: **Player**
> "“What do you make of the situation?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaTrialled == true"*)

### Węzeł `[96]`
Mówca: **Iosef Lancea**
> "“Don't worry, sir. Unless they somehow got their hands on the Palace schematics, they don't know about the secret tunnel that leads here from the Situation Room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Iosef Lancea: "“And besides, this room was built to withstand nuclear at..."*)

### Węzeł `[97]`
Mówca: **Iosef Lancea**
> "“And besides, this room was built to withstand nuclear attacks. We should be safe here for the moment. The diversion at the Palace should buy us some time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Iosef Lancea: "“Of course, the question is how much time. We have lost c..."*)

### Węzeł `[98]`
Mówca: **Iosef Lancea**
> "“Of course, the question is how much time. We have lost contact with the squadrons protecting the outer perimeter of the palace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Iosef Lancea: "“Your guess is as good as my own at this point.”"*)

### Węzeł `[99]`
Mówca: **Iosef Lancea**
> "“Your guess is as good as my own at this point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "After thanking Iosef, I went back to the main room."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "After thanking Iosef, I went back to the main room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[101]`
Mówca: **Monica**
> "“You better keep that promise, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "She went back near Deana."*)

### Węzeł `[102]`
Mówca: **Narrator**
> "She walked to Deana and Franc to hug them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "Franc walked up to me."*)

### Węzeł `[103]`
Mówca: **Monica**
> "“But, Deana... Franc...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "She walked to Deana and Franc to hug them."*)

### Węzeł `[104]`
Mówca: **Narrator**
> "She went back near Deana."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "Franc walked up to me."*)

### Węzeł `[105]`
Mówca: **Narrator**
> "Franc walked up to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Franc: "“Dad. Seriously, tell me. Are we screwed?""*)

### Węzeł `[106]`
Mówca: **Franc**
> "“Dad. Seriously, tell me. Are we screwed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player: "“Don't fret. You are a Rayne. You have to be strong.”"*)
  - -> `[107]` (*Player: "“I wish I knew that, son.”"*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "“I wish I knew that, son.”"]** — Mówca: **Player**
> "“I wish I knew that, son.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Franc: "“Not very reassuring.”"*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "“Don't fret. You are a Rayne. You have to be strong.”"]** — Mówca: **Player**
> "“Don't fret. You are a Rayne. You have to be strong.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Franc: "“So, the answer is yes, then.""*)

### Węzeł `[109]`
Mówca: **Franc**
> "“So, the answer is yes, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Despite our location many meters underground, I felt the ..."*)

### Węzeł `[110]`
Mówca: **Franc**
> "“Not very reassuring.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Despite our location many meters underground, I felt the ..."*)

### Węzeł `[111]`
Mówca: **Narrator**
> "Iosef came out of the communications room and pulled me aside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Iosef Lancea: "“Sir. The Palace is about to fall. And one of the Rumburg..."*)

### Węzeł `[112]`
Mówca: **Iosef Lancea**
> "“Sir. The Palace is about to fall. And one of the Rumburg combatants was overheard saying he'd located the tunnel entrance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player: "“Tell me Iosef. What did I do wrong? What did I do to des..."*)
  - -> `[113]` (*Player: "“So is this the end?”"*)
  - -> `[114]` (*Player: "“What are we going to do?”"*)
  - -> `[115]` (*Player: "“I order you to get us out of here. Immediately.”"*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "“So is this the end?”"]** — Mówca: **Player**
> "“So is this the end?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Iosef Lancea: "“Looks like it. They've got troops stationed in the woods..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "“What are we going to do?”"]** — Mówca: **Player**
> "“What are we going to do?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Iosef Lancea: "“Our hands are tied. They've got troops stationed in the ..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "“I order you to get us out of here. Immediately.”"]** — Mówca: **Player**
> "“I order you to get us out of here. Immediately.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Iosef Lancea: "“I'm afraid that is not possible. They've got troops stat..."*)

### Węzeł `[116]`
Mówca: **Iosef Lancea**
> "“I'm afraid that is not possible. They've got troops stationed in the woods above us. The only way to get out is through the Palace or not at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Iosef Lancea: "“If I were you I would start saying my prayers, sir.”"*)

### Węzeł `[117]`
Mówca: **Iosef Lancea**
> "“Our hands are tied. They've got troops stationed in the woods above us. The only way to get out is through the Palace or not at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Iosef Lancea: "“If I were you I would start saying my prayers, sir.”"*)

### Węzeł `[118]`
Mówca: **Iosef Lancea**
> "“Looks like it. They've got troops stationed in the woods above us. The only way to get out is through the Palace or not at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Iosef Lancea: "“If I were you I would start saying my prayers, sir.”"*)

### Węzeł `[119]`
Mówca: **Iosef Lancea**
> "“If I were you I would start saying my prayers, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Iosef Lancea: "“Look around. Get comfortable.”"*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "“I want to see my office one last time.”"]** — Mówca: **Player**
> "“I want to see my office one last time.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Iosef Lancea: "“Are you mad? Do you want to run straight into the enemy'..."*)

### Węzeł `[121]`
Mówca: **Iosef Lancea**
> "“Look around. Get comfortable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Iosef Lancea: "“Because this room will be our grave.”"*)

### Węzeł `[122]`
Mówca: **Iosef Lancea**
> "“Because this room will be our grave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Player: "“They only want *me*. I'm going to the Palace.""*)
  - -> `[120]` (*Player: "“I want to see my office one last time.”"*)
  - -> `[123]` (*Player: "“We will barricade ourselves in and hope for the best.”"*)

### Węzeł `[123]`
**[WYBÓR GRACZA: "“We will barricade ourselves in and hope for the best.”"]** — Mówca: **Player**
> "“We will barricade ourselves in and hope for the best.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Iosef Lancea: "“It's not like we have much of a choice.""*)

### Węzeł `[124]`
Mówca: **Iosef Lancea**
> "“Are you mad? Do you want to run straight into the enemy's sights?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player: "“Why does it matter if we're going to die anyway?""*)
  - -> `[125]` (*Player: "“At least I will die fighting instead of cowering down he..."*)
  - -> `[127]` (*Player: "“You're right, I don't. Maybe we should stay here. Maybe ..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "“At least I will die fighting instead of cowering down here.”"]** — Mówca: **Player**
> "“At least I will die fighting instead of cowering down here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Iosef Lancea: "“It's one last battle for me, then.""*)

### Węzeł `[126]`
**[WYBÓR GRACZA: "“Why does it matter if we're going to die anyway?""]** — Mówca: **Player**
> "“Why does it matter if we're going to die anyway?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Iosef Lancea: "“I guess you have a point.”"*)

### Węzeł `[127]`
**[WYBÓR GRACZA: "“You're right, I don't. Maybe we should stay here. Maybe someone will come to our rescue.”"]** — Mówca: **Player**
> "“You're right, I don't. Maybe we should stay here. Maybe someone will come to our rescue.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Iosef Lancea: "“It's not like we have much of a choice.""*)

### Węzeł `[128]`
Mówca: **Iosef Lancea**
> "“I guess you have a point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Iosef Lancea: "“It's one last battle for me, then.""*)

### Węzeł `[129]`
Mówca: **Iosef Lancea**
> "“It's not like we have much of a choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "We sat and waited. A grim silence descended."*)

### Węzeł `[130]`
Mówca: **Iosef Lancea**
> "“It's one last battle for me, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "His eyes started shining."*)

### Węzeł `[131]`
Mówca: **Narrator**
> "His eyes started shining."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Iosef Lancea: "“Yes! I always wanted to go out with a bang anyway!”"*)

### Węzeł `[132]`
Mówca: **Iosef Lancea**
> "“Yes! I always wanted to go out with a bang anyway!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "He took off his jacket and walked over to the bunker's we..."*)

### Węzeł `[133]`
Mówca: **Narrator**
> "He took off his jacket and walked over to the bunker's weapons cache, loading himself up with everything that was left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "He turned to me and gave me his handgun."*)

### Węzeł `[134]`
Mówca: **Narrator**
> "He turned to me and gave me his handgun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone == false"*)

### Węzeł `[135]`
Mówca: **Narrator**
> "The door to my office flew open. It was Iosef. His shoulder was bleeding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "He stumbled inside, collapsed on the couch and took a hug..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_Alone == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone == false"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgWarLost_Alone == false)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_Alone == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgWarLost_Alone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Monica: "“Anton, don't you fucking dare.""*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgWarLost_Alone == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgWarLost_Alone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "Iosef punched a code into the panel on the door, and it s..."*)

### Węzeł `[139]`
Mówca: **Monica**
> "“Anton, don't you fucking dare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player: "“I'm just going to have a quick look around. I'll be righ..."*)
  - -> `[141]` (*Player: "“I'm sorry, Monica. It's the only way to save you and Dea..."*)

### Węzeł `[140]`
**[WYBÓR GRACZA: "“I'm just going to have a quick look around. I'll be right back.""]** — Mówca: **Player**
> "“I'm just going to have a quick look around. I'll be right back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Monica: ""At the Palace? That's suicide.""*)

### Węzeł `[141]`
**[WYBÓR GRACZA: "“I'm sorry, Monica. It's the only way to save you and Deana.""]** — Mówca: **Player**
> "“I'm sorry, Monica. It's the only way to save you and Deana.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Monica: "“You don't get to decide that.""*)

### Węzeł `[142]`
Mówca: **Monica**
> ""At the Palace? That's suicide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Player: ""I love you.""*)
  - -> `[295]` (*Player: ""Don't open this door after I leave. No matter what you h..."*)

### Węzeł `[143]`
Mówca: **Monica**
> "“You don't get to decide that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Player: ""I love you.""*)
  - -> `[295]` (*Player: ""Don't open this door after I leave. No matter what you h..."*)

### Węzeł `[144]`
Mówca: **Narrator**
> "Iosef punched a code into the panel on the door, and it slid open. As we left the bunker, it closed behind us with a final-sounding thud."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "The small electric vehicle Iosef had used to get me here ..."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "The small electric vehicle Iosef had used to get me here from the Palace was still outside. We got in and drove down the dark passageway for several minutes, until we reached the secret entrance to the situation room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "We disembarked and cautiously approached the door. Voices..."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "We disembarked and cautiously approached the door. Voices could be heard on the other side. Iosef shouldered his machine gun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Iosef Lancea: ""Wait here, Mr. President.""*)

### Węzeł `[147]`
Mówca: **Iosef Lancea**
> ""Wait here, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Narrator: "Iosef flung open the door and, in a flurry of gunfire, ea..."*)

### Węzeł `[148]`
Mówca: **Narrator**
> "Everything was the same as I had left it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Iosef Lancea: "“I'll go check the perimeter, Mr. President. Be right back.”"*)

### Węzeł `[149]`
Mówca: **Iosef Lancea**
> "“I'll go check the perimeter, Mr. President. Be right back.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "Office Hub"*)

### Węzeł `[150]`
**[WYBÓR GRACZA: "Open the curtains to look outside."]** — Mówca: **Player_Italic**
> "I opened the curtains and looked out the window."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn11_SnO_Curtain"] == false`
- **Kontekst wejściowy (poprzednik):** `[149]` (Iosef Lancea), `[175]` (Narrator), `[172]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "Black smoke was rising from downtown Holsord. Buildings s..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA: "Sit in your chair for one last time."]** — Mówca: **Player_Italic**
> "I sat down in my chair."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn11_SnO_Chair"] == false`
- **Kontekst wejściowy (poprzednik):** `[149]` (Iosef Lancea), `[175]` (Narrator), `[172]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "I ran my hands over the leather armrests. I had always fe..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA: "Pour yourself a glass of Erlory Maroon 30-year-old."]** — Mówca: **Player_Italic**
> "I poured myself a glass of Erlory Maroon 30-year-old."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn11_SnO_Photo"] == false`
- **Kontekst wejściowy (poprzednik):** `[149]` (Iosef Lancea), `[175]` (Narrator), `[172]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "The taste was as exquisite as ever."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Office Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Curtain == false"*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Chair == false"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Photo == false"*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Photo == true && BaseGameIsol..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Curtain == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Curtain == false"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn11_SnO_Curtain == false)"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Curtain == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Curtain"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player_Italic: "Open the curtains to look outside."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn11_SnO_Curtain == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Curtain"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Chair == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Chair == false"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn11_SnO_Chair == false)"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Chair == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Chair"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player_Italic: "Sit in your chair for one last time."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn11_SnO_Chair == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Chair"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Photo == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Photo == false"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn11_SnO_Photo == false)"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Photo == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Photo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player_Italic: "Pour yourself a glass of Erlory Maroon 30-year-old."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn11_SnO_Photo == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Photo"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Photo == true && BaseGameIsolated.Turn11_SnO_Chair == true && BaseGameIsolated.Turn11_SnO_Curtain == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Photo == true && BaseGameIsol..."*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn11_SnO_Photo == true && BaseGameIs..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Photo == true && BaseGameIsolated.Turn11_SnO_Chair == true && BaseGameIsolated.Turn11_SnO_Curtain == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Photo"] == true  and  Variable["BaseGameIsolated.Turn11_SnO_Chair"] == true  and  Variable["BaseGameIsolated.Turn11_SnO_Curtain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "The door to my office flew open. It was Iosef. His should..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn11_SnO_Photo == true && BaseGameIsolated.Turn11_SnO_Chair == true && BaseGameIsolated.Turn11_SnO_Curtain == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Photo"] == true  and  Variable["BaseGameIsolated.Turn11_SnO_Chair"] == true  and  Variable["BaseGameIsolated.Turn11_SnO_Curtain"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[166]`
Mówca: **Iosef Lancea**
> "“Out with a bang, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "Iosef turned to me."*)

### Węzeł `[167]`
Mówca: **Narrator**
> "The taste was as exquisite as ever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "I looked at the chair in front of my desk and remembered ..."*)

### Węzeł `[168]`
Mówca: **Narrator**
> "I looked at the chair in front of my desk and remembered happier times with Petr."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "I raised my glass and finished it all."*)

### Węzeł `[169]`
Mówca: **Narrator**
> "I raised my glass and finished it all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Photo = true"*)

### Węzeł `[170]`
Mówca: **Narrator**
> "I ran my hands over the leather armrests. I had always felt comfortable sitting here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "My mind went back to all the conversations I'd had in thi..."*)

### Węzeł `[171]`
Mówca: **Narrator**
> "My mind went back to all the conversations I'd had in this chair, all the important decisions I'd made."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "I wondered which of them had led me to this miserable end."*)

### Węzeł `[172]`
Mówca: **Narrator**
> "I wondered which of them had led me to this miserable end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Chair = true"*)

### Węzeł `[173]`
Mówca: **Narrator**
> "Black smoke was rising from downtown Holsord. Buildings shook, groaned and collapsed as bombs went off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "From afar, I saw the bodies of people -- civilians --stre..."*)

### Węzeł `[174]`
Mówca: **Narrator**
> "From afar, I saw the bodies of people -- civilians --strewn across roads and sidewalks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "So this is what had become of Holsord. Of Sordland."*)

### Węzeł `[175]`
Mówca: **Narrator**
> "So this is what had become of Holsord. Of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Curtain = true"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Office Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "Office Hub"*)

### Węzeł `[177]`
**[WYBÓR GRACZA: "“They only want *me*. I'm going to the Palace.""]** — Mówca: **Player**
> "“They only want *me*. I'm going to the Palace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Iosef Lancea: "“Are you mad? Do you want to run straight into the enemy'..."*)

### Węzeł `[178]`
Mówca: **Iosef Lancea**
> "“Are you mad? Do you want to run straight into the enemy's sights?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player: "“I have a duty to this nation.”"*)
  - -> `[180]` (*Player: "“I will not let anyone else die for me.”"*)

### Węzeł `[179]`
**[WYBÓR GRACZA: "“I have a duty to this nation.”"]** — Mówca: **Player**
> "“I have a duty to this nation.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Iosef Lancea: "“You have shown me you are not a coward, Mr. President.”"*)

### Węzeł `[180]`
**[WYBÓR GRACZA: "“I will not let anyone else die for me.”"]** — Mówca: **Player**
> "“I will not let anyone else die for me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Iosef Lancea: "“You have shown me you are not a coward, Mr. President.”"*)

### Węzeł `[181]`
Mówca: **Iosef Lancea**
> "“You have shown me you are not a coward, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Iosef Lancea: "“It's one last battle for me, then.""*)

### Węzeł `[182]`
Mówca: **Narrator**
> "We sat and waited. A grim silence descended."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Iosef Lancea: ""Mr. President, I just wanted to say...""*)

### Węzeł `[183]`
Mówca: **Narrator**
> "A half an hour passed, then an hour, then an hour and a half."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Suddenly, Iosef stood bolt upright."*)

### Węzeł `[184]`
Mówca: **Iosef Lancea**
> "“Quiet. They are here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "I could hear soldiers shouting on the other side of the h..."*)

### Węzeł `[185]`
Mówca: **Narrator**
> "Suddenly, Iosef stood bolt upright."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Iosef Lancea: "“Quiet. They are here.”"*)

### Węzeł `[186]`
Mówca: **Narrator**
> "I could hear soldiers shouting on the other side of the heavy door. Then, a mechanical whirring sound."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Drill");"*)

### Węzeł `[187]`
Mówca: **Narrator**
> "They were drilling their way through to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone == false"*)

### Węzeł `[188]`
**[WYBÓR GRACZA: "“Calm down. It's going to be all right.”"]** — Mówca: **Player**
> "“Calm down. It's going to be all right.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Iosef Lancea: "“Mr. President. What do we do?”"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_Alone == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone == false"*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgWarLost_Alone == false)"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_Alone == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgWarLost_Alone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Monica: "“Anton! We can't let them get in!""*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgWarLost_Alone == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgWarLost_Alone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Iosef Lancea: "“Mr. President. What do we do?”"*)

### Węzeł `[192]`
Mówca: **Monica**
> "“Anton! We can't let them get in!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_WholeFamilyWithYou == true"*)

### Węzeł `[193]`
**[WYBÓR GRACZA: "“Quiet.”"]** — Mówca: **Player**
> "“Quiet.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Iosef Lancea: "“Mr. President. What do we do?”"*)

### Węzeł `[194]`
Mówca: **Deana**
> "“Papa!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player: "“Calm down. It's going to be all right.”"*)
  - -> `[193]` (*Player: "“Quiet.”"*)

### Węzeł `[195]`
Mówca: **Iosef Lancea**
> "“Mr. President. What do we do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Player: "“Iosef. Bring the pills. They won't take us alive.""*)
  - -> `[221]` (*Player: ""We'll hold tight and hope for the best.""*)

### Węzeł `[196]`
Mówca: **Franc**
> "“Dad!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Deana: "“Papa!”"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_WholeFamilyWithYou == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_WholeFamilyWithYou == true"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgWarLost_WholeFamilyWithYou == true)"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_WholeFamilyWithYou == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgWarLost_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Franc: "“Dad!”"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgWarLost_WholeFamilyWithYou == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgWarLost_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Deana: "“Papa!”"*)

### Węzeł `[200]`
Mówca: **Narrator**
> "He turned to me and gave me his handgun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Player: "“When they enter, we will declare surrender. Don't make a..."*)
  - -> `[202]` (*Player: "“I hope I don't miss.”"*)
  - -> `[204]` (*Player: "“Ready?”"*)

### Węzeł `[201]`
**[WYBÓR GRACZA: "“When they enter, we will declare surrender. Don't make any sudden moves.”"]** — Mówca: **Player**
> "“When they enter, we will declare surrender. Don't make any sudden moves.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Iosef Lancea: "“I doubt they will let us, but let's see.”"*)

### Węzeł `[202]`
**[WYBÓR GRACZA: "“I hope I don't miss.”"]** — Mówca: **Player**
> "“I hope I don't miss.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Iosef Lancea: "“Now is the time to remember that military training.”"*)

### Węzeł `[203]`
Mówca: **Iosef Lancea**
> "“I doubt they will let us, but let's see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "Iosef and I turned the table on its side to create cover."*)

### Węzeł `[204]`
**[WYBÓR GRACZA: "“Ready?”"]** — Mówca: **Player**
> "“Ready?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Iosef Lancea: "“As ready as I can be.”"*)

### Węzeł `[205]`
Mówca: **Iosef Lancea**
> "“Now is the time to remember that military training.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "Iosef and I turned the table on its side to create cover."*)

### Węzeł `[206]`
Mówca: **Iosef Lancea**
> "“As ready as I can be.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "Iosef and I turned the table on its side to create cover."*)

### Węzeł `[207]`
Mówca: **Narrator**
> "Iosef and I turned the table on its side to create cover."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "The drill stopped and the door opened. Heavy footsteps fi..."*)

### Węzeł `[208]`
Mówca: **Narrator**
> "The drill stopped and the door opened. Heavy footsteps filled the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "A man yelled in broken Sordish. "Hands up!""*)

### Węzeł `[209]`
Mówca: **Narrator**
> "A man yelled in broken Sordish. "Hands up!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "Iosef held his hands up and stood up from behind the table."*)

### Węzeł `[210]`
Mówca: **Narrator**
> "Iosef held his hands up and stood up from behind the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Narrator: "A gunshot rang out. Iosef collapsed next to me in a pool ..."*)

### Węzeł `[211]`
Mówca: **Narrator**
> "A gunshot rang out. Iosef collapsed next to me in a pool of blood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "He grabbed my shirt collar and spoke to me very softly."*)

### Węzeł `[212]`
Mówca: **Iosef Lancea**
> "“I'm sorry, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Iosef Lancea: "“A Morgna wes core.”"*)

### Węzeł `[213]`
Mówca: **Iosef Lancea**
> "“A Morgna wes core.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "His head fell to the side, motionless."*)

### Węzeł `[214]`
Mówca: **Narrator**
> "He grabbed my shirt collar and spoke to me very softly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Iosef Lancea: "“I'm sorry, Mr. President.”"*)

### Węzeł `[215]`
Mówca: **Narrator**
> "His head fell to the side, motionless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Player: "“Vectern sis da.”"*)
  - -> `[299]` (*Player: "“Goodbye, Iosef.""*)

### Węzeł `[216]`
**[WYBÓR GRACZA: "“Vectern sis da.”"]** — Mówca: **Player**
> "“Vectern sis da.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[215]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "I closed his eyes with my hand."*)

### Węzeł `[217]`
Mówca: **Narrator**
> "I closed his eyes with my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "The soldiers approached the table. I had no choice but to..."*)

### Węzeł `[218]`
Mówca: **Narrator**
> "The soldiers approached the table. I had no choice but to reveal myself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Narrator: "I stood up, and one of the men turned his rifle on me."*)

### Węzeł `[219]`
Mówca: **Iosef Lancea**
> "“Mr. President. Take this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "He turned to me and gave me his handgun."*)

### Węzeł `[220]`
**[WYBÓR GRACZA: "“Iosef. Bring the pills. They won't take us alive.""]** — Mówca: **Player**
> "“Iosef. Bring the pills. They won't take us alive.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Iosef Lancea: "“Roger that, sir.”"*)

### Węzeł `[221]`
**[WYBÓR GRACZA: ""We'll hold tight and hope for the best.""]** — Mówca: **Player**
> ""We'll hold tight and hope for the best.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Iosef Lancea: "“Very well.”"*)

### Węzeł `[222]`
Mówca: **Iosef Lancea**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Iosef Lancea: "“Mr. President. Take this.”"*)

### Węzeł `[223]`
Mówca: **Iosef Lancea**
> "“Roger that, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone == false"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_Alone == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone == false"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgWarLost_Alone == false)"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_Alone == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgWarLost_Alone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "Iosef soon returned with a couple of small pills."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgWarLost_Alone == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgWarLost_Alone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "Iosef walked away. He returned after just a few short min..."*)

### Węzeł `[227]`
Mówca: **Iosef Lancea**
> "“All ready, sir?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Iosef Lancea: "“No matter what, it was an honor to serve you, sir.”"*)

### Węzeł `[228]`
Mówca: **Iosef Lancea**
> "“No matter what, it was an honor to serve you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Player: "“Likewise, Iosef.”"*)
  - -> `[231]` (*Player: "“I'll see you on the other side.""*)
  - -> `[232]` (*Player_Italic: "Salute him."*)

### Węzeł `[229]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Iosef Lancea: "“A Morgna wes core!”"*)

### Węzeł `[230]`
**[WYBÓR GRACZA: "“Likewise, Iosef.”"]** — Mówca: **Player**
> "“Likewise, Iosef.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "He saluted me."*)

### Węzeł `[231]`
**[WYBÓR GRACZA: "“I'll see you on the other side.""]** — Mówca: **Player**
> "“I'll see you on the other side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "He saluted me."*)

### Węzeł `[232]`
**[WYBÓR GRACZA: "Salute him."]** — Mówca: **Player_Italic**
> "I saluted him and he saluted me back."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Iosef Lancea: "“A Morgna wes core!”"*)

### Węzeł `[233]`
**[WYBÓR GRACZA: "“Vectern sis da!”"]** — Mówca: **Player**
> "“Vectern sis da!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Iosef Lancea: "“I will be in the other room.”"*)

### Węzeł `[234]`
Mówca: **Iosef Lancea**
> "“A Morgna wes core!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Player: "“Vectern sis da!”"*)
  - -> `[296]` (*Player: "“For Sordland!""*)

### Węzeł `[235]`
Mówca: **Iosef Lancea**
> "“I will be in the other room.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Narrator: "A minute later, I heard a solitary gunshot."*)

### Węzeł `[236]`
Mówca: **Narrator**
> "Iosef soon returned with a couple of small pills."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Iosef Lancea: ""Give these to your family. We don't have enough for ever..."*)

### Węzeł `[237]`
Mówca: **Iosef Lancea**
> "“Unfortunately, there are no pills, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Iosef Lancea: "“We will have to do this the old-fashioned way.”"*)

### Węzeł `[238]`
Mówca: **Iosef Lancea**
> "“We will have to do this the old-fashioned way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "He turned to me and gave me a handgun."*)

### Węzeł `[239]`
Mówca: **Iosef Lancea**
> ""Give these to your family. We don't have enough for everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Iosef Lancea: "“You and I will have to do this the old-fashioned way.”"*)

### Węzeł `[240]`
Mówca: **Iosef Lancea**
> "“You and I will have to do this the old-fashioned way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "I thanked Iosef and turned to my family."*)

### Węzeł `[241]`
Mówca: **Narrator**
> "He turned to me and gave me a handgun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Iosef Lancea: "“No matter what, it was an honor to serve you, sir.”"*)

### Węzeł `[242]`
**[WYBÓR GRACZA: "“Likewise, Iosef.”"]** — Mówca: **Player**
> "“Likewise, Iosef.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Narrator: "He saluted me."*)

### Węzeł `[243]`
**[WYBÓR GRACZA: "Salute him."]** — Mówca: **Player_Italic**
> "I saluted him and he saluted me back."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Iosef Lancea: "“A Morgna wes core!”"*)

### Węzeł `[244]`
Mówca: **Iosef Lancea**
> "“No matter what, it was an honor to serve you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Player: "“Likewise, Iosef.”"*)
  - -> `[246]` (*Player: "“I'll see you on the other side.""*)
  - -> `[243]` (*Player_Italic: "Salute him."*)

### Węzeł `[245]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Iosef Lancea: "“A Morgna wes core!”"*)

### Węzeł `[246]`
**[WYBÓR GRACZA: "“I'll see you on the other side.""]** — Mówca: **Player**
> "“I'll see you on the other side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Narrator: "He saluted me."*)

### Węzeł `[247]`
Mówca: **Iosef Lancea**
> "“I will be in the other room.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Narrator: "A minute later, I heard a solitary gunshot."*)

### Węzeł `[248]`
**[WYBÓR GRACZA: "“Vectern sis da!”"]** — Mówca: **Player**
> "“Vectern sis da!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[249]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Iosef Lancea: "“I will be in the other room.”"*)

### Węzeł `[249]`
Mówca: **Iosef Lancea**
> "“A Morgna wes core!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Player: "“Vectern sis da!”"*)
  - -> `[298]` (*Player: "“For Sordland!""*)

### Węzeł `[250]`
Mówca: **Narrator**
> "A minute later, I heard a solitary gunshot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "The drill stopped."*)

### Węzeł `[251]`
Mówca: **Narrator**
> "A minute later, I heard a solitary gunshot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "The drill stopped."*)

### Węzeł `[252]`
Mówca: **Narrator**
> "The drill stopped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Narrator: "I re-did my tie and turned to face the door."*)

### Węzeł `[253]`
Mówca: **Narrator**
> "I re-did my tie and turned to face the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Narrator: "I looked down at the gun Iosef had given me."*)

### Węzeł `[254]`
**[WYBÓR GRACZA: "Point the gun towards the soldier."]** — Mówca: **Player_Italic**
> "I pointed the gun towards the soldier."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_PointGunToSoldier = true"*)

### Węzeł `[255]`
Mówca: **Narrator**
> "I looked down at the gun Iosef had given me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "The door swung open and a Rumburgian soldier entered. He ..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_PointGunToHead = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_PointGunToHead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_SnO_RumburgWarLost = true"*)

### Węzeł `[257]`
**[WYBÓR GRACZA: "Point the gun towards your head."]** — Mówca: **Player_Italic**
> "I pointed the gun towards my own head."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_PointGunToHead = true"*)

### Węzeł `[258]`
Mówca: **Narrator**
> "The door swung open and a Rumburgian soldier entered. He trained his rifle on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Player_Italic: "Point the gun towards the soldier."*)
  - -> `[257]` (*Player_Italic: "Point the gun towards your head."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_PointGunToSoldier = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_PointGunToSoldier"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_SnO_RumburgWarLost = true"*)

### Węzeł `[260]`
Mówca: **Narrator**
> "I stood up, and one of the men turned his rifle on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Player_Italic: "Point the gun towards the soldier."*)
  - -> `[262]` (*Player_Italic: "Point the gun towards your head."*)
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone == false"*)

### Węzeł `[261]`
**[WYBÓR GRACZA: "Point the gun towards the soldier."]** — Mówca: **Player_Italic**
> "I pointed the gun towards the soldier."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_PointGunToSoldier = true"*)

### Węzeł `[262]`
**[WYBÓR GRACZA: "Point the gun towards your head."]** — Mówca: **Player_Italic**
> "I pointed the gun towards my head."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_PointGunToHead = true"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_PointGunToSoldier = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_PointGunToSoldier"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_SnO_RumburgWarLost = true"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_PointGunToHead = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_PointGunToHead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_SnO_RumburgWarLost = true"*)

### Węzeł `[265]`
**[WYBÓR GRACZA: "“I surrender! Please don't hurt my family! I beg you! Please!”"]** — Mówca: **Player**
> "“I surrender! Please don't hurt my family! I beg you! Please!”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.RumburgWarLost_Alone"] == false`
- **Kontekst wejściowy (poprzednik):** `[260]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Surrender = true"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_Alone == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone == false"*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgWarLost_Alone == false)"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_Alone == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgWarLost_Alone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Player: "“I surrender! Please don't hurt my family! I beg you! Ple..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgWarLost_Alone == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgWarLost_Alone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player: "“I surrender! Please don't hurt me! I beg you! Please!”"*)

### Węzeł `[269]`
**[WYBÓR GRACZA: "“I surrender! Please don't hurt me! I beg you! Please!”"]** — Mówca: **Player**
> "“I surrender! Please don't hurt me! I beg you! Please!”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.RumburgWarLost_Alone"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[260]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Surrender = true"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Surrender = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_Surrender"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_SnO_RumburgWarLost = true"*)

### Węzeł `[271]`
**[WYBÓR GRACZA: "“I surrender! Please don't hurt me! I beg you! Please!”"]** — Mówca: **Player**
> "“I surrender! Please don't hurt me! I beg you! Please!”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.RumburgWarLost_Alone"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Surrender = true"*)

### Węzeł `[272]`
**[WYBÓR GRACZA: "“I surrender! Please don't hurt my family! I beg you! Please!”"]** — Mówca: **Player**
> "“I surrender! Please don't hurt my family! I beg you! Please!”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.RumburgWarLost_Alone"] == false`
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Surrender = true"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_Alone == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone == false"*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgWarLost_Alone == false)"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_Alone == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgWarLost_Alone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Player: "“I surrender! Please don't hurt my family! I beg you! Ple..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgWarLost_Alone == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgWarLost_Alone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player: "“I surrender! Please don't hurt me! I beg you! Please!”"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Surrender = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_Surrender"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_SnO_RumburgWarLost = true"*)

### Węzeł `[277]`
Mówca: **Narrator**
> "I thanked Iosef and turned to my family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Narrator: "I told them what they had to do."*)

### Węzeł `[278]`
Mówca: **Narrator**
> "I told them what they had to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Narrator: "A couple of minutes later, Iosef appeared at the doorstep."*)

### Węzeł `[279]`
Mówca: **Narrator**
> "A couple of minutes later, Iosef appeared at the doorstep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Iosef Lancea: "“All ready, sir?”"*)

### Węzeł `[280]`
Mówca: **Narrator**
> "Iosef punched a code into the panel on the door, and it slid open. As we left the bunker, it closed behind us with a final-sounding thud."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "The small electric vehicle Iosef had used to get me here ..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Curtain = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_Curtain"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "Jump to: [Office Hub]"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Chair = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_Chair"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "Jump to: [Office Hub]"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Photo = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_Photo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "Jump to: [Office Hub]"*)

### Węzeł `[284]`
Mówca: **Narrator**
> "I breathed a sigh of relief that Deana and her mother were on their way to safety in Benfi, under the protection of Franc and his army squad. Monica had angrily protested my order at first, but relented when I told her the children's lives were on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "They were supposed to have gotten there right about now."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_DivorceAfterElection == true ||..."*)
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_DivorceAfterElection == true ..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true  or  Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "I breathed a sigh of relief that Deana and her mother wer..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true  or  Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "I breathed a sigh of relief that Monica, Deana and Franc ..."*)

### Węzeł `[288]`
Mówca: **Narrator**
> "They were supposed to have gotten there right about now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "Iosef walked back over to me."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_DivorceAfterElection == true ||..."*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_DivorceAfterElection == true ..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true  or  Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Iosef Lancea: "“The military convoy carrying your children and ex-wife w..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true  or  Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Iosef Lancea: "“The military convoy carrying your wife and children was ..."*)

### Węzeł `[292]`
Mówca: **Iosef Lancea**
> "“The military convoy carrying your wife and children was ambushed by Rumburg troops on its way out of Holsord. Franc sacrificed his life in order to grant safe passage to Monica, your daughter, and the rest of his squad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Iosef Lancea: "“He died a hero, sir.”"*)

### Węzeł `[293]`
**[WYBÓR GRACZA: "“Give 'em hell!""]** — Mówca: **Player**
> "“Give 'em hell!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Iosef ran to the door and opened it. I heard the metallic..."*)

### Węzeł `[294]`
**[WYBÓR GRACZA: ""I love you.""]** — Mówca: **Player**
> ""I love you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Monica), `[143]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "Iosef punched a code into the panel on the door, and it s..."*)

### Węzeł `[295]`
**[WYBÓR GRACZA: ""Don't open this door after I leave. No matter what you hear.""]** — Mówca: **Player**
> ""Don't open this door after I leave. No matter what you hear.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Monica), `[143]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "Iosef punched a code into the panel on the door, and it s..."*)

### Węzeł `[296]`
**[WYBÓR GRACZA: "“For Sordland!""]** — Mówca: **Player**
> "“For Sordland!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Iosef Lancea: "“I will be in the other room.”"*)

### Węzeł `[297]`
Mówca: **Narrator**
> "Iosef walked away. He returned after just a few short minutes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Iosef Lancea: "“Unfortunately, there are no pills, Mr. President.”"*)

### Węzeł `[298]`
**[WYBÓR GRACZA: "“For Sordland!""]** — Mówca: **Player**
> "“For Sordland!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[249]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Iosef Lancea: "“I will be in the other room.”"*)

### Węzeł `[299]`
**[WYBÓR GRACZA: "“Goodbye, Iosef.""]** — Mówca: **Player**
> "“Goodbye, Iosef.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[215]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "I closed his eyes with my hand."*)

### Węzeł `[300]`
Mówca: **Narrator**
> "I turned the radio off and swallowed hard. Nobody knew I wasn't at the Palace. Except for Iosef."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaTrialled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaTrialled == true"*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_LiviaTrialled == true)"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaTrialled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Iosef Lancea: "“That depends, sir. If your ex-secretary handed Rumburg t..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_LiviaTrialled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Iosef Lancea: "“Don't worry, sir. Unless they somehow got their hands on..."*)

### Węzeł `[304]`
Mówca: **Iosef Lancea**
> "“That depends, sir. If your ex-secretary handed Rumburg the Palace schematics, they might know about the tunnel that leads here from the Situation Room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Iosef Lancea: "“But even if they do, this room was built to withstand nu..."*)

### Węzeł `[305]`
Mówca: **Iosef Lancea**
> "“But even if they do, this room was built to withstand nuclear attacks. We should be safe here for the moment. The diversion at the Palace should buy us some time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Iosef Lancea: "“Of course, the question is how much time. We have lost c..."*)

### Węzeł `[306]`
Mówca: **Narrator**
> "My Minister of Defense had sprung into action the moment Rumburg began strafing Holsord, smuggling me out of the Palace into this remote bunker."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "Right now, he was monitoring communications in the adjoin..."*)

### Węzeł `[307]`
Mówca: **Narrator**
> "He'd managed to get my family here as well. What was left of it, anyway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "Right now, he was monitoring communications in the adjoin..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "My Minister of Defense had sprung into action the moment ..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn07_Personal_FrancConscripted == true || Bas..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true) && BaseGame.Turn10_SnO_FrancPulledToHolsord == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn07_Personal_FrancConscripted == true || Bas..."*)
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Turn07_Personal_FrancConscripted == true || B..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true) && BaseGame.Turn10_SnO_FrancPulledToHolsord == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true)  and  Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "He'd managed to get my family here as well. What was left..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true) && BaseGame.Turn10_SnO_FrancPulledToHolsord == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true)  and  Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Home_Public == true"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Home_Public == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Home_Public == true"*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Home_Public == true)"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Home_Public == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "Miraculously, he'd managed to get my family here as well."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Home_Public == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "My Minister of Defense had sprung into action the moment ..."*)

### Węzeł `[317]`
Mówca: **Narrator**
> "Miraculously, he'd managed to get my family here as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "Right now, he was monitoring communications in the adjoin..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Narrator: "I breathed a sigh of relief that the children were out of..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "I looked at Monica, Deana and Franc. Deana started runnin..."*)

### Węzeł `[321]`
Mówca: **Narrator**
> "I breathed a sigh of relief that the children were out of the country with their mother, staying with a distant relative of Monica's in Arcasia. My ex-wife had the good sense to flee long before the invasion started."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Despite our location many meters underground, I felt the ..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_DivorceAfterElection == true ||..."*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_DivorceAfterElection == true ..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true  or  Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Narrator: "I breathed a sigh of relief that Deana was safely out of ..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true  or  Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "I looked at Monica and Deana. Deana's face was streaked w..."*)

### Węzeł `[325]`
Mówca: **Narrator**
> "I breathed a sigh of relief that Deana was safely out of the country with her mother. Monica had taken our daughter and fled to a distant relative's house in Arcasia, shortly after Franc..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "Franc..."*)

### Węzeł `[326]`
Mówca: **Narrator**
> "Franc..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Narrator: "I still couldn't bear to think about what had happened to..."*)

### Węzeł `[327]`
Mówca: **Narrator**
> "I still couldn't bear to think about what had happened to Franc."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Franc_Died = true"*)

### Węzeł `[328]`
Mówca: **Narrator**
> "Iosef flung open the door and, in a flurry of gunfire, easily dispatched the small group of soldiers outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Narrator: "The two of us cautiously crept through the room, then up ..."*)

### Węzeł `[329]`
Mówca: **Narrator**
> "The two of us cautiously crept through the room, then up through the Palace's winding halls and staircases, avoiding footsteps when we heard them. Eventually, we finally reached my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "Everything was the same as I had left it."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == tru..."*)
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone = true"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Home_Public == true"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true || BaseGame.R..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone = true"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_WholeFamilyWithYou = true"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Home_Public == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Home_Public == true"*)
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Home_Public == true)"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Home_Public == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true || BaseGame.Rel..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Home_Public == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_FrancPulledToHolsord == true"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_FrancPulledToHolsord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_FrancPulledToHolsord == true"*)
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_FrancPulledToHolsord == true)"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_FrancPulledToHolsord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone = true"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_FrancPulledToHolsord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_DivorceAfterElection == true ||..."*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_DivorceAfterElection == true ||..."*)
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_DivorceAfterElection == true ..."*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true  or  Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_Alone = true"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true  or  Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWarLost_MonicaDeanaWithYou = true"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_MonicaDeanaWithYou = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.RumburgWarLost_MonicaDeanaWithYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "I undid my tie slowly and rose from my seat in the protec..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_WholeFamilyWithYou = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.RumburgWarLost_WholeFamilyWithYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "I undid my tie slowly and rose from my seat in the protec..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWarLost_Alone = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.RumburgWarLost_Alone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "I undid my tie slowly and rose from my seat in the protec..."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase1_Success == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase1_Success == false"*)
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_Phase1_Success == false)"*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase1_Success == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase1_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true"*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_Phase1_Success == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase1_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Iosef Lancea: ""It feels like just yesterday we were raising Sordland's ..."*)

### Węzeł `[351]`
Mówca: **Iosef Lancea**
> ""Mr. President, before I go...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Narrator: "Iosef tightened his grip on his handgun."*)

### Węzeł `[352]`
Mówca: **Iosef Lancea**
> ""I'm sorry. I'm sorry for failing our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase1_Success == false"*)

### Węzeł `[353]`
Mówca: **Iosef Lancea**
> ""Our failure at Tzarsbourgh triggered a string of events that we could not imagine...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "Iosef stared down at the floor, lost in regrets."*)

### Węzeł `[354]`
Mówca: **Narrator**
> "Iosef tightened his grip on his handgun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Iosef Lancea: ""I'm sorry. I'm sorry for failing our country.""*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true"*)
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true)"*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Iosef Lancea: ""Our failure at Tzarsbourgh triggered a string of events ..."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase1_DigDown == true"*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase1_DigDown == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase1_DigDown == true"*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_Phase1_DigDown == true)"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase1_DigDown == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase1_DigDown"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Iosef Lancea: ""We thought we could hold on and fight off Rumburg's firs..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_Phase1_DigDown == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase1_DigDown"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Iosef Lancea: ""We thought we had them trapped at Estord... ""*)

### Węzeł `[361]`
Mówca: **Iosef Lancea**
> ""We thought we could hold on and fight off Rumburg's first wave. Even with our best efforts, we failed...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "Iosef stared down at the floor, lost in regrets."*)

### Węzeł `[362]`
Mówca: **Iosef Lancea**
> ""We thought we had them trapped at Estord... ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "Iosef stared down at the floor, lost in regrets."*)

### Węzeł `[363]`
Mówca: **Iosef Lancea**
> ""It feels like just yesterday we were raising Sordland's banner over Tzarsbourgh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase2_TakeDome == false"*)

### Węzeł `[364]`
Mówca: **Iosef Lancea**
> ""But then our attempt to capture Thornbourgh ended in failure...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "Iosef stared down at the floor, lost in regrets."*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase2_TakeDome == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase2_TakeDome == false"*)
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_Phase2_TakeDome == false)"*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase2_TakeDome == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Iosef Lancea: ""But then our attempt to capture Thornbourgh ended in fai..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_Phase2_TakeDome == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Iosef Lancea: ""But then we failed to take Dome, and before we knew it, ..."*)

### Węzeł `[368]`
Mówca: **Iosef Lancea**
> ""But then we failed to take Dome, and before we knew it, all our hard-fought progress was lost...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "Iosef stared down at the floor, lost in regrets."*)

### Węzeł `[369]`
Mówca: **Narrator**
> "Iosef stared down at the floor, lost in regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Player: ""It's my fault, General. I got us into an unwinnable war.""*)
  - -> `[396]` (*Player: ""We can't do anything about that now. All we can do is ma..."*)
  - -> `[397]` (*Player: ""You're right. This mess we're in is entirely your fault.""*)
  - -> `[403]` (*Player_Italic: "Don't say anything."*)

### Węzeł `[370]`
Mówca: **Narrator**
> "I was interrupted by the sudden loud noise of gunfire in the hall outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Iosef Lancea: "“Well, that's my cue.”"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true"*)
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true)"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Iosef Lancea: ""Our failure at Tzarsbourgh triggered a string of events ..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase1_DigDown == true"*)

### Węzeł `[374]`
Mówca: **Iosef Lancea**
> ""But then we failed to take Dome, and before we knew it, all our hard-fought progress was lost...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Narrator: "Iosef stared down at the concrete floor, lost in regrets."*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase1_DigDown == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase1_DigDown == true"*)
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_Phase1_DigDown == true)"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase1_DigDown == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase1_DigDown"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Iosef Lancea: ""We thought we could hold on and fight off Rumburg's firs..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_Phase1_DigDown == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase1_DigDown"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Iosef Lancea: ""We thought we had them trapped at Estord...""*)

### Węzeł `[378]`
Mówca: **Iosef Lancea**
> ""Feels like just yesterday that we were raising Sordland's banner over Tzarsbourgh...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase2_TakeDome == false"*)

### Węzeł `[379]`
Mówca: **Iosef Lancea**
> ""But then our attempt to capture Thornbourgh ended in failure...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Narrator: "Iosef stared down at the concrete floor, lost in regrets."*)

### Węzeł `[380]`
Mówca: **Iosef Lancea**
> ""Mr. President, I just wanted to say...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Narrator: "Iosef tightened his grip on his handgun."*)

### Węzeł `[381]`
Mówca: **Iosef Lancea**
> ""I'm sorry. I'm sorry for failing our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase1_Success == false"*)

### Węzeł `[382]`
Mówca: **Narrator**
> "Iosef tightened his grip on his handgun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Iosef Lancea: ""I'm sorry. I'm sorry for failing our country.""*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase1_Success == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase1_Success == false"*)
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_Phase1_Success == false)"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase1_Success == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase1_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_Phase1_Success == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase1_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Iosef Lancea: ""Feels like just yesterday that we were raising Sordland'..."*)

### Węzeł `[386]`
Mówca: **Iosef Lancea**
> ""We thought we had them trapped at Estord...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Narrator: "Iosef stared down at the concrete floor, lost in regrets."*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase2_TakeDome == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase2_TakeDome == false"*)
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_Phase2_TakeDome == false)"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase2_TakeDome == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Iosef Lancea: ""But then our attempt to capture Thornbourgh ended in fai..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_Phase2_TakeDome == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Iosef Lancea: ""But then we failed to take Dome, and before we knew it, ..."*)

### Węzeł `[390]`
Mówca: **Iosef Lancea**
> ""Our failure at Tzarsbourgh triggered a string of events that we could not have imagined...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Narrator: "Iosef stared down at the concrete floor, lost in regrets."*)

### Węzeł `[391]`
Mówca: **Iosef Lancea**
> ""We thought we could hold on and fight off Rumburg's first wave. Even with our best efforts, we failed...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Narrator: "Iosef stared down at the concrete floor, lost in regrets."*)

### Węzeł `[392]`
Mówca: **Narrator**
> "Iosef stared down at the concrete floor, lost in regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Player: ""It's my fault, General. I got us into an unwinnable war.""*)
  - -> `[399]` (*Player: ""We can't do anything about that now. All we can do is tr..."*)
  - -> `[400]` (*Player: ""You're right. This mess we're in is entirely your fault.""*)
  - -> `[402]` (*Player_Italic: "Don't say anything."*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Franc_Died = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Franc_Died"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Despite our location many meters underground, I felt the ..."*)

### Węzeł `[394]`
Mówca: **Deana**
> ""But I'm not even a grown-up yet! I'm not ready...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Monica: "“Anton, can you come here for a second?”"*)

### Węzeł `[395]`
**[WYBÓR GRACZA: ""It's my fault, General. I got us into an unwinnable war.""]** — Mówca: **Player**
> ""It's my fault, General. I got us into--""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[369]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Narrator: "I was interrupted by the sudden loud noise of gunfire in ..."*)

### Węzeł `[396]`
**[WYBÓR GRACZA: ""We can't do anything about that now. All we can do is make our last stand.""]** — Mówca: **Player**
> ""We can't do anything about that now. All we can do is make our last--""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[369]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Narrator: "I was interrupted by the sudden loud noise of gunfire in ..."*)

### Węzeł `[397]`
**[WYBÓR GRACZA: ""You're right. This mess we're in is entirely your fault.""]** — Mówca: **Player**
> ""You're right. This mess we're in--""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[369]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Narrator: "I was interrupted by the sudden loud noise of gunfire in ..."*)

### Węzeł `[398]`
**[WYBÓR GRACZA: ""It's my fault, General. I got us into an unwinnable war.""]** — Mówca: **Player**
> ""It's my fault, General. I got us into an unwinnable war.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[392]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Narrator: "He didn't reply. We sat down in opposite corners of the r..."*)

### Węzeł `[399]`
**[WYBÓR GRACZA: ""We can't do anything about that now. All we can do is try to survive.""]** — Mówca: **Player**
> ""We can't do anything about that now. All we can do is try to survive.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[392]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Narrator: "He didn't reply. We sat down in opposite corners of the r..."*)

### Węzeł `[400]`
**[WYBÓR GRACZA: ""You're right. This mess we're in is entirely your fault.""]** — Mówca: **Player**
> ""You're right. This mess we're in is entirely your fault.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[392]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Narrator: "He didn't reply. We sat down in opposite corners of the r..."*)

### Węzeł `[401]`
Mówca: **Narrator**
> "He didn't reply. We sat down in opposite corners of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "A half an hour passed, then an hour, then an hour and a h..."*)

### Węzeł `[402]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Italic**
> "I didn't reply. We sat down in opposite corners of the room."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[392]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "A half an hour passed, then an hour, then an hour and a h..."*)

### Węzeł `[403]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Italic**
> "I kept silent, listening to the sounds of the battle below us."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[369]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "The noise drew closer. The soldiers had reached our floor."*)

### Węzeł `[404]`
Mówca: **Narrator**
> "The noise drew closer. The soldiers had reached our floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Iosef Lancea: "“Well, that's my cue.”"*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("GunshotExplosion");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("GunshotExplosion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "Gunshots rang out, then an ear-splitting explosion, follo..."*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Drill");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Drill");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "They were drilling their way through to us."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `DisableToken("Sordland_Event_RumburgWar");`
- **Efekt skryptowy (`userScript`):** `DisableToken("Sordland_Event_RumburgWar");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "DisableToken("Sordland_Event_RumburgInvasion");"*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `DisableToken("Sordland_Event_RumburgInvasion");`
- **Efekt skryptowy (`userScript`):** `DisableToken("Sordland_Event_RumburgInvasion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Rumburg", "Ho..."*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Rumburg", "Hostile");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Rumburg","Hostile");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "End();"*)
