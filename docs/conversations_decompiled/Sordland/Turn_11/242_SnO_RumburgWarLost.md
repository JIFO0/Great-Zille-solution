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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 22

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.RumburgWarLost_Alone`
- `BaseGame.RumburgWarLost_MonicaDeanaWithYou`
- `BaseGame.RumburgWarLost_WholeFamilyWithYou`
- `GameCondition.Turn11_SnO_RumburgWarLost`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[31]` (Paskal Beniwoll): `Variable["GameCondition.Turn11_SnO_RumburgWarLost"] = true;`
- Węzeł `[32]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn11_SnO_PointGunToSoldier"] = true;`
- Węzeł `[33]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn11_SnO_PointGunToHead"] = true;`
- Węzeł `[256]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn11_SnO_PointGunToHead"] = true;`
- Węzeł `[259]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn11_SnO_PointGunToSoldier"] = true;`
- Węzeł `[263]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn11_SnO_PointGunToSoldier"] = true;`
- Węzeł `[264]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn11_SnO_PointGunToHead"] = true;`
- Węzeł `[270]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn11_SnO_Surrender"] = true;`
- *...oraz 14 innych węzłów ze skryptami.*

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
  - -> `[330]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I undid my tie slowly and rose from my seat in the protected bunker on the outskirts of Holsord. I increased the volume of the crackling radio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Despite our location many meters underground, I felt the room shaking. It must've been the bombs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[5]`
Mówca: **Narrator**
> "He stumbled inside, collapsed on the couch and took a huge slug of my whiskey."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Iosef Lancea**
> "“They are here, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Iosef Lancea**
> "“They are inside the Palace. They are coming for you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "I heard gunfire and more screams from the floor beneath us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "“Tell me Iosef. What did I do wrong? What did I do to deserve this?”"]** — Mówca: **Player**
> "“Tell me Iosef. What did I do wrong? What did I do to deserve this?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Iosef Lancea**
> "“I don't know, Mr. President. Maybe you were just at the wrong place at the wrong time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "Point the gun towards the soldier."]** — Mówca: **Player_Italic**
> "I pointed the gun towards the soldier."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[12]`
Mówca: **Iosef Lancea**
> "“Don't forget about that handgun I gave you. Of course, it's up to you how you want to use it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[13]`
Mówca: **Iosef Lancea**
> "“Well, that's my cue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Narrator**
> "He pointed to his belt. I saw several grenades hanging from it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[15]`
Mówca: **Narrator**
> "Iosef turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Iosef Lancea**
> "“No matter what, it was an honor to serve you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`
  - -> `[19]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Likewise, Iosef.”"]** — Mówca: **Player**
> "“Likewise, Iosef.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“I'll see you on the other side.""]** — Mówca: **Player**
> "“I'll see you on the other side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "Salute him."]** — Mówca: **Player_Italic**
> "I saluted him and he saluted me back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Iosef Lancea**
> "“A Morgna wes core!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[293]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“Vectern sis da!”"]** — Mówca: **Player**
> "“Vectern sis da!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Narrator**
> "Iosef ran to the door and opened it. I heard the metallic sounds of the pins being removed from the grenades."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Iosef Lancea**
> "<shout>“Greci Sordland!”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[25]`
Mówca: **Narrator**
> "Gunshots rang out, then an ear-splitting explosion, followed by silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Narrator**
> "A good long minute passed. Then, I heard the faint sound of approaching footsteps."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Narrator**
> "I redid my tie and looked at myself in the mirror before sitting down at my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Narrator**
> "I looked down at the gun Iosef had given me and shifted it from one hand to the other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "Point the gun towards your own head."]** — Mówca: **Player_Italic**
> "I pointed the gun towards my own head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[30]`
Mówca: **Narrator**
> "The door burst open and a soldier in Rumburgian uniform stormed in. He turned his rifle on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[29]`
  - -> `[273]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn11_SnO_RumburgWarLost = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn11_SnO_RumburgWarLost"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_PointGunToSoldier = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_PointGunToSoldier"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_PointGunToHead = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_PointGunToHead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[34]`
Mówca: **Narrator**
> "“The enemy is advancing on us. Requesting backup. We are surrounded from all sides. I repeat, we are surro--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Narrator**
> "“They are using some kind of a gas. Our soldiers' eyes and ears are bleeding. We need immediate assistance on Victory Avenue. Medics! We need more medics!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Narrator**
> "“They are coming in through the outer gates. They killed everyone. We surrendered our weapons but they won't stop shooting. If there is a God, I beg you. Please end this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[37]`
Mówca: **Narrator**
> "“They are approaching the Maroon Palace. We must protect the president at all costs. Squad 6 will initiate the final charge while we barricade the palace. Please tell my wife I love her. Greci Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[38]`
Mówca: **Narrator**
> "Right now, he was monitoring communications in the adjoining room. I walked in and he saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[39]`
Mówca: **Narrator**
> "“If there is anyone listening right now... please. The world needs to know what is going on. This is no longer a war. This is a massacre! Squad 2 out.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[40]`
Mówca: **Narrator**
> "I looked at Monica and Deana. Deana's face was streaked with tears."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Deana**
> "“Papa, are we going to die like Franc did?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Narrator**
> "Monica started sobbing uncontrollably. But there were no tears. She ran out many days ago, when we received the news of Franc's death near the border."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`
  - -> `[76]`

### Węzeł `[43]`
Mówca: **Narrator**
> "I breathed a sigh of relief that Monica and Deana were safely on their way to Arcasia, where they would meet up with Franc. My family wouldn't be paying for my mistakes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[44]`
Mówca: **Narrator**
> "I breathed a sigh of relief that Monica and Deana were safely on their way to United Contana, where they would meet up with Franc. My family wouldn't be paying for my mistakes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Home_Public == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Home_Public == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Home_Public == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_FrancPulledToHolsord == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_FrancPulledToHolsord == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_FrancPulledToHolsord == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[57]`
Mówca: **Narrator**
> "I looked at Monica, Deana and Franc. Deana started running to me, crying. I wiped her tears away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Deana**
> "“Papa. Are we going to die?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`
  - -> `[85]`

### Węzeł `[59]`
Mówca: **Narrator**
> "I breathed a sigh of relief that Monica, Deana and Franc were on their way to Benfi, where they'd be safe from the bloodshed. I had sent them there under the protection of Franc's army squad."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Narrator**
> "They were supposed to have gotten there right about now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Narrator**
> "Iosef walked back over to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Iosef Lancea**
> "“Mr. President. I am afraid I have bad news.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[63]`
Mówca: **Iosef Lancea**
> "“The military convoy carrying your children and ex-wife was ambushed by Rumburg troops on its way out of Holsord. Franc sacrificed his life in order to grant safe passage to Monica, your daughter, and the rest of his squad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Iosef Lancea**
> "“He died a hero, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“This can't be true.”"]** — Mówca: **Player**
> "“This can't be true.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“I need a minute, Iosef.”"]** — Mówca: **Player**
> "“I need a minute, Iosef.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Iosef Lancea**
> "“I'm afraid it is, sir. He valiantly gave his life for Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Iosef Lancea**
> "“Of course, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Iosef Lancea**
> "“I will give you some time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Narrator**
> "He left me alone in the room. I wept uncontrollably until I exhausted myself and passed out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[71]`
Mówca: **Iosef Lancea**
> "“Monica and Deana are unharmed and will be arriving in Benfi soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[72]`
  - -> `[66]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "“This is all my fault. I caused my son's death.”"]** — Mówca: **Player**
> "“This is all my fault. I caused my son's death.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Iosef Lancea**
> "“Please do not blame yourself, Mr. President. We need you to be strong. Your country needs you to be strong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "“Death is never the end, my dear daughter. It comes to all of us at one point in our lives.”"]** — Mówca: **Player**
> "“Death is never the end, my dear daughter. It comes to all of us at one point in our lives.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“No. We will not die, Deana. As long as I am here, don't worry.”"]** — Mówca: **Player**
> "“No. We will not die, Deana. As long as I am here, don't worry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "Keep silent and hug her."]** — Mówca: **Player_Italic**
> "I kept silent and hugged her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Deana**
> "“That's not the answer I was looking for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Monica**
> "“I don't know, Anton. Franc is gone and Sordland's a wreck... how are we supposed to go on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`
  - -> `[81]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "“Deana is still here, Monica.”"]** — Mówca: **Player**
> "“Deana is still here, Monica.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "“We still have each other. We need to live for his sake.”"]** — Mówca: **Player**
> "“We still have each other. We need to live for his sake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "“We have no choice.”"]** — Mówca: **Player**
> "“We have no choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Narrator**
> "Deana went to Monica and hugged her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "“Death is never the end, my dear daughter. It comes to all of us at one point in our lives.”"]** — Mówca: **Player**
> "“Death is never the end, my dear daughter. It comes to all of us at one point in our lives.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "“No. We will not die, Deana. As long as I am here, don't worry.”"]** — Mówca: **Player**
> "“No. We will not die, Deana. As long as I am here, don't worry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
**[WYBÓR GRACZA: "Keep silent and hug her."]** — Mówca: **Player_Italic**
> "I kept silent and hugged her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[86]`
Mówca: **Deana**
> ""All right. I trust you, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Narrator**
> "We went to a corner where Deana wouldn't be able to hear us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Monica**
> "“Anton, can you come here for a second?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[89]`
Mówca: **Monica**
> "“What is really going on? Tell me the truth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[90]`

### Węzeł `[90]`
**[WYBÓR GRACZA: "“We will make through this somehow. I promise.”"]** — Mówca: **Player**
> "“We will make through this somehow. I promise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "“We are most likely done for.”"]** — Mówca: **Player**
> "“We are most likely done for.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[92]`
Mówca: **Iosef Lancea**
> "“The enemy is preparing to breach the Palace. It's only a matter of time before they realize you're not there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`
  - -> `[95]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "“How long until they find us?""]** — Mówca: **Player**
> "“How long until they find us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[94]`
**[WYBÓR GRACZA: "“Are we safe here, Iosef?”"]** — Mówca: **Player**
> "“Are we safe here, Iosef?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[95]`
**[WYBÓR GRACZA: "“What do you make of the situation?”"]** — Mówca: **Player**
> "“What do you make of the situation?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[96]`
Mówca: **Iosef Lancea**
> "“Don't worry, sir. Unless they somehow got their hands on the Palace schematics, they don't know about the secret tunnel that leads here from the Situation Room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Iosef Lancea**
> "“And besides, this room was built to withstand nuclear attacks. We should be safe here for the moment. The diversion at the Palace should buy us some time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Iosef Lancea**
> "“Of course, the question is how much time. We have lost contact with the squadrons protecting the outer perimeter of the palace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Iosef Lancea**
> "“Your guess is as good as my own at this point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Narrator**
> "After thanking Iosef, I went back to the main room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[101]`
Mówca: **Monica**
> "“You better keep that promise, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[102]`
Mówca: **Narrator**
> "She walked to Deana and Franc to hug them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[103]`
Mówca: **Monica**
> "“But, Deana... Franc...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[104]`
Mówca: **Narrator**
> "She went back near Deana."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Narrator**
> "Franc walked up to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Franc**
> "“Dad. Seriously, tell me. Are we screwed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[107]`

### Węzeł `[107]`
**[WYBÓR GRACZA: "“I wish I knew that, son.”"]** — Mówca: **Player**
> "“I wish I knew that, son.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[108]`
**[WYBÓR GRACZA: "“Don't fret. You are a Rayne. You have to be strong.”"]** — Mówca: **Player**
> "“Don't fret. You are a Rayne. You have to be strong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Franc**
> "“So, the answer is yes, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[110]`
Mówca: **Franc**
> "“Not very reassuring.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[111]`
Mówca: **Narrator**
> "Iosef came out of the communications room and pulled me aside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Iosef Lancea**
> "“Sir. The Palace is about to fall. And one of the Rumburg combatants was overheard saying he'd located the tunnel entrance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[113]`
  - -> `[114]`
  - -> `[115]`

### Węzeł `[113]`
**[WYBÓR GRACZA: "“So is this the end?”"]** — Mówca: **Player**
> "“So is this the end?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[114]`
**[WYBÓR GRACZA: "“What are we going to do?”"]** — Mówca: **Player**
> "“What are we going to do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "“I order you to get us out of here. Immediately.”"]** — Mówca: **Player**
> "“I order you to get us out of here. Immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Iosef Lancea**
> "“I'm afraid that is not possible. They've got troops stationed in the woods above us. The only way to get out is through the Palace or not at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[117]`
Mówca: **Iosef Lancea**
> "“Our hands are tied. They've got troops stationed in the woods above us. The only way to get out is through the Palace or not at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Iosef Lancea**
> "“Looks like it. They've got troops stationed in the woods above us. The only way to get out is through the Palace or not at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Iosef Lancea**
> "“If I were you I would start saying my prayers, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "“I want to see my office one last time.”"]** — Mówca: **Player**
> "“I want to see my office one last time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[121]`
Mówca: **Iosef Lancea**
> "“Look around. Get comfortable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Iosef Lancea**
> "“Because this room will be our grave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[120]`
  - -> `[123]`

### Węzeł `[123]`
**[WYBÓR GRACZA: "“We will barricade ourselves in and hope for the best.”"]** — Mówca: **Player**
> "“We will barricade ourselves in and hope for the best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[124]`
Mówca: **Iosef Lancea**
> "“Are you mad? Do you want to run straight into the enemy's sights?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[125]`
  - -> `[127]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "“At least I will die fighting instead of cowering down here.”"]** — Mówca: **Player**
> "“At least I will die fighting instead of cowering down here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[126]`
**[WYBÓR GRACZA: "“Why does it matter if we're going to die anyway?""]** — Mówca: **Player**
> "“Why does it matter if we're going to die anyway?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
**[WYBÓR GRACZA: "“You're right, I don't. Maybe we should stay here. Maybe someone will come to our rescue.”"]** — Mówca: **Player**
> "“You're right, I don't. Maybe we should stay here. Maybe someone will come to our rescue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Iosef Lancea**
> "“I guess you have a point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Iosef Lancea**
> "“It's not like we have much of a choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[130]`
Mówca: **Iosef Lancea**
> "“It's one last battle for me, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Narrator**
> "His eyes started shining."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Iosef Lancea**
> "“Yes! I always wanted to go out with a bang anyway!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Narrator**
> "He took off his jacket and walked over to the bunker's weapons cache, loading himself up with everything that was left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Narrator**
> "He turned to me and gave me his handgun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Narrator**
> "The door to my office flew open. It was Iosef. His shoulder was bleeding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_Alone == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_Alone == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgWarLost_Alone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgWarLost_Alone == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgWarLost_Alone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[139]`
Mówca: **Monica**
> "“Anton, don't you fucking dare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
**[WYBÓR GRACZA: "“I'm just going to have a quick look around. I'll be right back.""]** — Mówca: **Player**
> "“I'm just going to have a quick look around. I'll be right back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
**[WYBÓR GRACZA: "“I'm sorry, Monica. It's the only way to save you and Deana.""]** — Mówca: **Player**
> "“I'm sorry, Monica. It's the only way to save you and Deana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Monica**
> ""At the Palace? That's suicide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[295]`

### Węzeł `[143]`
Mówca: **Monica**
> "“You don't get to decide that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[295]`

### Węzeł `[144]`
Mówca: **Narrator**
> "Iosef punched a code into the panel on the door, and it slid open. As we left the bunker, it closed behind us with a final-sounding thud."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Narrator**
> "The small electric vehicle Iosef had used to get me here from the Palace was still outside. We got in and drove down the dark passageway for several minutes, until we reached the secret entrance to the situation room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Narrator**
> "We disembarked and cautiously approached the door. Voices could be heard on the other side. Iosef shouldered his machine gun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Iosef Lancea**
> ""Wait here, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[148]`
Mówca: **Narrator**
> "Everything was the same as I had left it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Iosef Lancea**
> "“I'll go check the perimeter, Mr. President. Be right back.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[150]`
**[WYBÓR GRACZA: "Open the curtains to look outside."]** — Mówca: **Player_Italic**
> "I opened the curtains and looked out the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[151]`
**[WYBÓR GRACZA: "Sit in your chair for one last time."]** — Mówca: **Player_Italic**
> "I sat down in my chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[152]`
**[WYBÓR GRACZA: "Pour yourself a glass of Erlory Maroon 30-year-old."]** — Mówca: **Player_Italic**
> "I poured myself a glass of Erlory Maroon 30-year-old."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Office Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[157]`
  - -> `[160]`
  - -> `[163]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Curtain == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Curtain == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Curtain"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn11_SnO_Curtain == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Curtain"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Chair == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Chair == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Chair"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn11_SnO_Chair == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Chair"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Photo == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Photo == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Photo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn11_SnO_Photo == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Photo"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Photo == true && BaseGameIsolated.Turn11_SnO_Chair == true && BaseGameIsolated.Turn11_SnO_Curtain == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Photo == true && BaseGameIsolated.Turn11_SnO_Chair == true && BaseGameIsolated.Turn11_SnO_Curtain == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Photo"] == true  and  Variable["BaseGameIsolated.Turn11_SnO_Chair"] == true  and  Variable["BaseGameIsolated.Turn11_SnO_Curtain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn11_SnO_Photo == true && BaseGameIsolated.Turn11_SnO_Chair == true && BaseGameIsolated.Turn11_SnO_Curtain == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Photo"] == true  and  Variable["BaseGameIsolated.Turn11_SnO_Chair"] == true  and  Variable["BaseGameIsolated.Turn11_SnO_Curtain"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[166]`
Mówca: **Iosef Lancea**
> "“Out with a bang, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[167]`
Mówca: **Narrator**
> "The taste was as exquisite as ever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Narrator**
> "I looked at the chair in front of my desk and remembered happier times with Petr."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Narrator**
> "I raised my glass and finished it all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[170]`
Mówca: **Narrator**
> "I ran my hands over the leather armrests. I had always felt comfortable sitting here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Narrator**
> "My mind went back to all the conversations I'd had in this chair, all the important decisions I'd made."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Narrator**
> "I wondered which of them had led me to this miserable end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[173]`
Mówca: **Narrator**
> "Black smoke was rising from downtown Holsord. Buildings shook, groaned and collapsed as bombs went off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Narrator**
> "From afar, I saw the bodies of people -- civilians --strewn across roads and sidewalks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Narrator**
> "So this is what had become of Holsord. Of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Office Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[177]`
**[WYBÓR GRACZA: "“They only want *me*. I'm going to the Palace.""]** — Mówca: **Player**
> "“They only want *me*. I'm going to the Palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Iosef Lancea**
> "“Are you mad? Do you want to run straight into the enemy's sights?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`

### Węzeł `[179]`
**[WYBÓR GRACZA: "“I have a duty to this nation.”"]** — Mówca: **Player**
> "“I have a duty to this nation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[180]`
**[WYBÓR GRACZA: "“I will not let anyone else die for me.”"]** — Mówca: **Player**
> "“I will not let anyone else die for me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Iosef Lancea**
> "“You have shown me you are not a coward, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[182]`
Mówca: **Narrator**
> "We sat and waited. A grim silence descended."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[183]`
Mówca: **Narrator**
> "A half an hour passed, then an hour, then an hour and a half."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Iosef Lancea**
> "“Quiet. They are here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Narrator**
> "Suddenly, Iosef stood bolt upright."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[186]`
Mówca: **Narrator**
> "I could hear soldiers shouting on the other side of the heavy door. Then, a mechanical whirring sound."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[187]`
Mówca: **Narrator**
> "They were drilling their way through to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
**[WYBÓR GRACZA: "“Calm down. It's going to be all right.”"]** — Mówca: **Player**
> "“Calm down. It's going to be all right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_Alone == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_Alone == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgWarLost_Alone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgWarLost_Alone == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgWarLost_Alone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[192]`
Mówca: **Monica**
> "“Anton! We can't let them get in!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[193]`
**[WYBÓR GRACZA: "“Quiet.”"]** — Mówca: **Player**
> "“Quiet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Deana**
> "“Papa!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[193]`

### Węzeł `[195]`
Mówca: **Iosef Lancea**
> "“Mr. President. What do we do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`

### Węzeł `[196]`
Mówca: **Franc**
> "“Dad!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_WholeFamilyWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_WholeFamilyWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgWarLost_WholeFamilyWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgWarLost_WholeFamilyWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgWarLost_WholeFamilyWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[200]`
Mówca: **Narrator**
> "He turned to me and gave me his handgun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`
  - -> `[204]`

### Węzeł `[201]`
**[WYBÓR GRACZA: "“When they enter, we will declare surrender. Don't make any sudden moves.”"]** — Mówca: **Player**
> "“When they enter, we will declare surrender. Don't make any sudden moves.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[202]`
**[WYBÓR GRACZA: "“I hope I don't miss.”"]** — Mówca: **Player**
> "“I hope I don't miss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[203]`
Mówca: **Iosef Lancea**
> "“I doubt they will let us, but let's see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[204]`
**[WYBÓR GRACZA: "“Ready?”"]** — Mówca: **Player**
> "“Ready?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[205]`
Mówca: **Iosef Lancea**
> "“Now is the time to remember that military training.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Iosef Lancea**
> "“As ready as I can be.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[207]`
Mówca: **Narrator**
> "Iosef and I turned the table on its side to create cover."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Narrator**
> "The drill stopped and the door opened. Heavy footsteps filled the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Narrator**
> "A man yelled in broken Sordish. "Hands up!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Narrator**
> "Iosef held his hands up and stood up from behind the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Narrator**
> "A gunshot rang out. Iosef collapsed next to me in a pool of blood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[212]`
Mówca: **Iosef Lancea**
> "“I'm sorry, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Iosef Lancea**
> "“A Morgna wes core.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[214]`
Mówca: **Narrator**
> "He grabbed my shirt collar and spoke to me very softly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[215]`
Mówca: **Narrator**
> "His head fell to the side, motionless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[299]`

### Węzeł `[216]`
**[WYBÓR GRACZA: "“Vectern sis da.”"]** — Mówca: **Player**
> "“Vectern sis da.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Narrator**
> "I closed his eyes with my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Narrator**
> "The soldiers approached the table. I had no choice but to reveal myself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[219]`
Mówca: **Iosef Lancea**
> "“Mr. President. Take this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[220]`
**[WYBÓR GRACZA: "“Iosef. Bring the pills. They won't take us alive.""]** — Mówca: **Player**
> "“Iosef. Bring the pills. They won't take us alive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[221]`
**[WYBÓR GRACZA: ""We'll hold tight and hope for the best.""]** — Mówca: **Player**
> ""We'll hold tight and hope for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[222]`
Mówca: **Iosef Lancea**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[223]`
Mówca: **Iosef Lancea**
> "“Roger that, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_Alone == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_Alone == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgWarLost_Alone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgWarLost_Alone == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgWarLost_Alone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[227]`
Mówca: **Iosef Lancea**
> "“All ready, sir?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Iosef Lancea**
> "“No matter what, it was an honor to serve you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`
  - -> `[232]`

### Węzeł `[229]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[230]`
**[WYBÓR GRACZA: "“Likewise, Iosef.”"]** — Mówca: **Player**
> "“Likewise, Iosef.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[231]`
**[WYBÓR GRACZA: "“I'll see you on the other side.""]** — Mówca: **Player**
> "“I'll see you on the other side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[232]`
**[WYBÓR GRACZA: "Salute him."]** — Mówca: **Player_Italic**
> "I saluted him and he saluted me back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[233]`
**[WYBÓR GRACZA: "“Vectern sis da!”"]** — Mówca: **Player**
> "“Vectern sis da!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Iosef Lancea**
> "“A Morgna wes core!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[296]`

### Węzeł `[235]`
Mówca: **Iosef Lancea**
> "“I will be in the other room.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[236]`
Mówca: **Narrator**
> "Iosef soon returned with a couple of small pills."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[237]`
Mówca: **Iosef Lancea**
> "“Unfortunately, there are no pills, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[238]`
Mówca: **Iosef Lancea**
> "“We will have to do this the old-fashioned way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[239]`
Mówca: **Iosef Lancea**
> ""Give these to your family. We don't have enough for everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Iosef Lancea**
> "“You and I will have to do this the old-fashioned way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[241]`
Mówca: **Narrator**
> "He turned to me and gave me a handgun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[242]`
**[WYBÓR GRACZA: "“Likewise, Iosef.”"]** — Mówca: **Player**
> "“Likewise, Iosef.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[243]`
**[WYBÓR GRACZA: "Salute him."]** — Mówca: **Player_Italic**
> "I saluted him and he saluted me back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[244]`
Mówca: **Iosef Lancea**
> "“No matter what, it was an honor to serve you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`
  - -> `[246]`
  - -> `[243]`

### Węzeł `[245]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[246]`
**[WYBÓR GRACZA: "“I'll see you on the other side.""]** — Mówca: **Player**
> "“I'll see you on the other side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[247]`
Mówca: **Iosef Lancea**
> "“I will be in the other room.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[248]`
**[WYBÓR GRACZA: "“Vectern sis da!”"]** — Mówca: **Player**
> "“Vectern sis da!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[249]`
Mówca: **Iosef Lancea**
> "“A Morgna wes core!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[298]`

### Węzeł `[250]`
Mówca: **Narrator**
> "A minute later, I heard a solitary gunshot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Narrator**
> "A minute later, I heard a solitary gunshot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[252]`
Mówca: **Narrator**
> "The drill stopped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[253]`
Mówca: **Narrator**
> "I re-did my tie and turned to face the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[254]`
**[WYBÓR GRACZA: "Point the gun towards the soldier."]** — Mówca: **Player_Italic**
> "I pointed the gun towards the soldier."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[255]`
Mówca: **Narrator**
> "I looked down at the gun Iosef had given me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_PointGunToHead = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_PointGunToHead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[257]`
**[WYBÓR GRACZA: "Point the gun towards your head."]** — Mówca: **Player_Italic**
> "I pointed the gun towards my own head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[258]`
Mówca: **Narrator**
> "The door swung open and a Rumburgian soldier entered. He trained his rifle on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[257]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_PointGunToSoldier = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_PointGunToSoldier"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[260]`
Mówca: **Narrator**
> "I stood up, and one of the men turned his rifle on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[262]`
  - -> `[266]`

### Węzeł `[261]`
**[WYBÓR GRACZA: "Point the gun towards the soldier."]** — Mówca: **Player_Italic**
> "I pointed the gun towards the soldier."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[262]`
**[WYBÓR GRACZA: "Point the gun towards your head."]** — Mówca: **Player_Italic**
> "I pointed the gun towards my head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_PointGunToSoldier = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_PointGunToSoldier"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_PointGunToHead = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_PointGunToHead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[265]`
**[WYBÓR GRACZA: "“I surrender! Please don't hurt my family! I beg you! Please!”"]** — Mówca: **Player**
> "“I surrender! Please don't hurt my family! I beg you! Please!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_Alone == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_Alone == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgWarLost_Alone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgWarLost_Alone == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgWarLost_Alone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
**[WYBÓR GRACZA: "“I surrender! Please don't hurt me! I beg you! Please!”"]** — Mówca: **Player**
> "“I surrender! Please don't hurt me! I beg you! Please!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[270]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Surrender = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_Surrender"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[271]`
**[WYBÓR GRACZA: "“I surrender! Please don't hurt me! I beg you! Please!”"]** — Mówca: **Player**
> "“I surrender! Please don't hurt me! I beg you! Please!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[272]`
**[WYBÓR GRACZA: "“I surrender! Please don't hurt my family! I beg you! Please!”"]** — Mówca: **Player**
> "“I surrender! Please don't hurt my family! I beg you! Please!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_Alone == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_Alone == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgWarLost_Alone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgWarLost_Alone == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgWarLost_Alone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Surrender = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_Surrender"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[277]`
Mówca: **Narrator**
> "I thanked Iosef and turned to my family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Narrator**
> "I told them what they had to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[279]`
Mówca: **Narrator**
> "A couple of minutes later, Iosef appeared at the doorstep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[280]`
Mówca: **Narrator**
> "Iosef punched a code into the panel on the door, and it slid open. As we left the bunker, it closed behind us with a final-sounding thud."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[281]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Curtain = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_Curtain"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Chair = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_Chair"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Photo = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_Photo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[284]`
Mówca: **Narrator**
> "I breathed a sigh of relief that Deana and her mother were on their way to safety in Benfi, under the protection of Franc and his army squad. Monica had angrily protested my order at first, but relented when I told her the children's lives were on the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true  or  Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true  or  Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[288]`
Mówca: **Narrator**
> "They were supposed to have gotten there right about now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true  or  Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true  or  Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[292]`
Mówca: **Iosef Lancea**
> "“The military convoy carrying your wife and children was ambushed by Rumburg troops on its way out of Holsord. Franc sacrificed his life in order to grant safe passage to Monica, your daughter, and the rest of his squad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[293]`
**[WYBÓR GRACZA: "“Give 'em hell!""]** — Mówca: **Player**
> "“Give 'em hell!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[294]`
**[WYBÓR GRACZA: ""I love you.""]** — Mówca: **Player**
> ""I love you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[295]`
**[WYBÓR GRACZA: ""Don't open this door after I leave. No matter what you hear.""]** — Mówca: **Player**
> ""Don't open this door after I leave. No matter what you hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[296]`
**[WYBÓR GRACZA: "“For Sordland!""]** — Mówca: **Player**
> "“For Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[297]`
Mówca: **Narrator**
> "Iosef walked away. He returned after just a few short minutes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[298]`
**[WYBÓR GRACZA: "“For Sordland!""]** — Mówca: **Player**
> "“For Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[299]`
**[WYBÓR GRACZA: "“Goodbye, Iosef.""]** — Mówca: **Player**
> "“Goodbye, Iosef.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[300]`
Mówca: **Narrator**
> "I turned the radio off and swallowed hard. Nobody knew I wasn't at the Palace. Except for Iosef."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaTrialled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaTrialled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_LiviaTrialled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[304]`
Mówca: **Iosef Lancea**
> "“That depends, sir. If your ex-secretary handed Rumburg the Palace schematics, they might know about the tunnel that leads here from the Situation Room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[305]`
Mówca: **Iosef Lancea**
> "“But even if they do, this room was built to withstand nuclear attacks. We should be safe here for the moment. The diversion at the Palace should buy us some time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[306]`
Mówca: **Narrator**
> "My Minister of Defense had sprung into action the moment Rumburg began strafing Holsord, smuggling me out of the Palace into this remote bunker."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[307]`
Mówca: **Narrator**
> "He'd managed to get my family here as well. What was left of it, anyway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true) && BaseGame.Turn10_SnO_FrancPulledToHolsord == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[313]`

### Węzeł `[312]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true) && BaseGame.Turn10_SnO_FrancPulledToHolsord == false)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true)  and  Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[313]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Turn07_Personal_FrancConscripted == true || BaseGame.Turn07_Personal_FrancMilitarySchool == true) && BaseGame.Turn10_SnO_FrancPulledToHolsord == false))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true  or  Variable["BaseGame.Turn07_Personal_FrancMilitarySchool"] == true)  and  Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[314]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Home_Public == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Home_Public == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Home_Public == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[317]`
Mówca: **Narrator**
> "Miraculously, he'd managed to get my family here as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`
  - -> `[320]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[321]`
Mówca: **Narrator**
> "I breathed a sigh of relief that the children were out of the country with their mother, staying with a distant relative of Monica's in Arcasia. My ex-wife had the good sense to flee long before the invasion started."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true  or  Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true  or  Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[325]`
Mówca: **Narrator**
> "I breathed a sigh of relief that Deana was safely out of the country with her mother. Monica had taken our daughter and fled to a distant relative's house in Arcasia, shortly after Franc..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Narrator**
> "Franc..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[327]`
Mówca: **Narrator**
> "I still couldn't bear to think about what had happened to Franc."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[328]`
Mówca: **Narrator**
> "Iosef flung open the door and, in a flurry of gunfire, easily dispatched the small group of soldiers outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Narrator**
> "The two of us cautiously crept through the room, then up through the Palace's winding halls and staircases, avoiding footsteps when we heard them. Eventually, we finally reached my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true || BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true  or  Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_DivorceAfterElection == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Home_Public == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[338]`

### Węzeł `[337]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Home_Public == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Home_Public == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_FrancPulledToHolsord == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`
  - -> `[341]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_FrancPulledToHolsord == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_FrancPulledToHolsord == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[342]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[344]`

### Węzeł `[343]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true  or  Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[344]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_DivorceAfterElection == true || BaseGame.Relations_Monica_Divorce == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_DivorceAfterElection"] == true  or  Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_MonicaDeanaWithYou = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.RumburgWarLost_MonicaDeanaWithYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[346]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_WholeFamilyWithYou = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.RumburgWarLost_WholeFamilyWithYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgWarLost_Alone = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.RumburgWarLost_Alone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase1_Success == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`
  - -> `[350]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase1_Success == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase1_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_Phase1_Success == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase1_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[351]`
Mówca: **Iosef Lancea**
> ""Mr. President, before I go...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[352]`
Mówca: **Iosef Lancea**
> ""I'm sorry. I'm sorry for failing our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[353]`
Mówca: **Iosef Lancea**
> ""Our failure at Tzarsbourgh triggered a string of events that we could not imagine...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[354]`
Mówca: **Narrator**
> "Iosef tightened his grip on his handgun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase1_DigDown == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase1_DigDown == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase1_DigDown"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_Phase1_DigDown == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase1_DigDown"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[361]`
Mówca: **Iosef Lancea**
> ""We thought we could hold on and fight off Rumburg's first wave. Even with our best efforts, we failed...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[362]`
Mówca: **Iosef Lancea**
> ""We thought we had them trapped at Estord... ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[363]`
Mówca: **Iosef Lancea**
> ""It feels like just yesterday we were raising Sordland's banner over Tzarsbourgh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[364]`
Mówca: **Iosef Lancea**
> ""But then our attempt to capture Thornbourgh ended in failure...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase2_TakeDome == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`
  - -> `[367]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase2_TakeDome == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_Phase2_TakeDome == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[368]`
Mówca: **Iosef Lancea**
> ""But then we failed to take Dome, and before we knew it, all our hard-fought progress was lost...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[369]`
Mówca: **Narrator**
> "Iosef stared down at the floor, lost in regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`
  - -> `[396]`
  - -> `[397]`
  - -> `[403]`

### Węzeł `[370]`
Mówca: **Narrator**
> "I was interrupted by the sudden loud noise of gunfire in the hall outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Iosef Lancea**
> ""But then we failed to take Dome, and before we knew it, all our hard-fought progress was lost...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[375]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase1_DigDown == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`
  - -> `[377]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase1_DigDown == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase1_DigDown"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_Phase1_DigDown == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase1_DigDown"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[378]`
Mówca: **Iosef Lancea**
> ""Feels like just yesterday that we were raising Sordland's banner over Tzarsbourgh...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[379]`
Mówca: **Iosef Lancea**
> ""But then our attempt to capture Thornbourgh ended in failure...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[380]`
Mówca: **Iosef Lancea**
> ""Mr. President, I just wanted to say...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Iosef Lancea**
> ""I'm sorry. I'm sorry for failing our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Narrator**
> "Iosef tightened his grip on his handgun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase1_Success == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase1_Success == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase1_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[385]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_Phase1_Success == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase1_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[386]`
Mówca: **Iosef Lancea**
> ""We thought we had them trapped at Estord...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[387]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase2_TakeDome == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase2_TakeDome == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[389]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_Phase2_TakeDome == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[390]`
Mówca: **Iosef Lancea**
> ""Our failure at Tzarsbourgh triggered a string of events that we could not have imagined...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Iosef Lancea**
> ""We thought we could hold on and fight off Rumburg's first wave. Even with our best efforts, we failed...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[392]`
Mówca: **Narrator**
> "Iosef stared down at the concrete floor, lost in regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`
  - -> `[399]`
  - -> `[400]`
  - -> `[402]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Franc_Died = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Franc_Died"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[394]`
Mówca: **Deana**
> ""But I'm not even a grown-up yet! I'm not ready...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[395]`
**[WYBÓR GRACZA: ""It's my fault, General. I got us into an unwinnable war.""]** — Mówca: **Player**
> ""It's my fault, General. I got us into--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[396]`
**[WYBÓR GRACZA: ""We can't do anything about that now. All we can do is make our last stand.""]** — Mówca: **Player**
> ""We can't do anything about that now. All we can do is make our last--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[397]`
**[WYBÓR GRACZA: ""You're right. This mess we're in is entirely your fault.""]** — Mówca: **Player**
> ""You're right. This mess we're in--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[398]`
**[WYBÓR GRACZA: ""It's my fault, General. I got us into an unwinnable war.""]** — Mówca: **Player**
> ""It's my fault, General. I got us into an unwinnable war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[399]`
**[WYBÓR GRACZA: ""We can't do anything about that now. All we can do is try to survive.""]** — Mówca: **Player**
> ""We can't do anything about that now. All we can do is try to survive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[400]`
**[WYBÓR GRACZA: ""You're right. This mess we're in is entirely your fault.""]** — Mówca: **Player**
> ""You're right. This mess we're in is entirely your fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[401]`
Mówca: **Narrator**
> "He didn't reply. We sat down in opposite corners of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[402]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Italic**
> "I didn't reply. We sat down in opposite corners of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[403]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Italic**
> "I kept silent, listening to the sounds of the battle below us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[404]`
Mówca: **Narrator**
> "The noise drew closer. The soldiers had reached our floor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("GunshotExplosion");)*
- **Efekt (`userScript`):** `PlaySoundEffect("GunshotExplosion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Drill");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Drill");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: DisableToken("Sordland_Event_RumburgWar");)*
- **Efekt (`userScript`):** `DisableToken("Sordland_Event_RumburgWar");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: DisableToken("Sordland_Event_RumburgInvasion");)*
- **Efekt (`userScript`):** `DisableToken("Sordland_Event_RumburgInvasion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateCountryRelationship("Sordland_Country_Rumburg", "Hostile");)*
- **Efekt (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Rumburg","Hostile");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`
