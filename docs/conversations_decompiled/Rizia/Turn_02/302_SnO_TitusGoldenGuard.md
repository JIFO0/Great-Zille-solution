# Rizia/Turn 2/SnO_TitusGoldenGuard

- **ID konwersacji:** `302`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Rizia/Turn_02/302_SnO_TitusGoldenGuard.md`
- **Liczba węzłów dialogowych:** 729
- **Liczba wyborów gracza:** 199

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[81]** Titus Gordion
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_JoinedSuOmina`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Prologue_Summer_Hugo`
- `RiziaDLC.Relations_Titus`
- `RiziaDLC.Security_ValeroPoisoningTalk_Happened`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched`
- `RiziaDLCIsolated.Turn02_GGHub2_FightInWar`
- `RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation`
- `RiziaDLCIsolated.Turn02_GGHub2_Threats`
- `RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory`
- `RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground`
- `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent`
- `RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing`
- `RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory`
- `RiziaDLCIsolated.Turn02_SecurityTitus_Sit`
- `RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory`
- `RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground`
- `RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Artifact_Armor_TorasArmor`
- `RiziaDLC.Artifact_Sword_TeradorsFury`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_FunnyKing`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Vina`
- `RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched`
- `RiziaDLCIsolated.Turn02_GGHub2_FightInWar`
- `RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation`
- `RiziaDLCIsolated.Turn02_GGHub2_Threats`
- `RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory`
- `RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground`
- `RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent`
- `RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing`
- `RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory`
- `RiziaDLCIsolated.Turn02_SecurityTitus_MoveOn`
- `RiziaDLCIsolated.Turn02_SecurityTitus_Sit`
- `RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory`
- `RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground`
- `RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground`
- `RiziaDLCSupport.News_Turn02_RH_SupportGoldenGuard`
- `RiziaDLCSupport.Reports_Turn02_Nelvisar_FieldShutsDown`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 14
- **Węzły modyfikujące stan gry:** 51

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Hugo`
- `RiziaDLC.Relations_Vina`
- `RiziaDLCIsolated.Turn02_GGHub2_FightInWar`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[4]` (Paskal Beniwoll): `PlayLoopedMusic("R_Coalition","R_Coalition_Loop");`
- Węzeł `[48]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- Węzeł `[119]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground"] = true;`
- Węzeł `[121]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground"] = true;`
- Węzeł `[122]` (Paskal Beniwoll): `AddConversant("Titus Gordion");`
- Węzeł `[123]` (Paskal Beniwoll): `AddConversant("Hugo Toras");`
- Węzeł `[133]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- Węzeł `[143]` (Paskal Beniwoll): `RemoveConversant("Hugo Toras");`
- *...oraz 43 innych węzłów ze skryptami.*

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
  - -> `[728]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "As we approached, a pair of soldiers, flanked on either side of the entrance, greeted us with a formal salute."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[6]`
  - -> `[7]`
  - -> `[9]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Coalition", "R_Coalition_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Coalition","R_Coalition_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[5]`
Mówca: **Narrator**
> "The crisp morning air filled my lungs as I crossed the palace courtyard with Hugo."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "Salute back."]** — Mówca: **Player_Romus_Italic**
> "I saluted them in return."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "Ignore them."]** — Mówca: **Player_Romus_Italic**
> "I ignored the guards and continued onward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "Wave halfheartedly."]** — Mówca: **Player_Romus_Italic**
> "I waved halfheartedly at them as I passed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "Offer a high five."]** — Mówca: **Player_Romus_Italic**
> "I offered a high-five by holding up my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shh! I want to see what happens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As king, I mustn't indulge in gambling, whether with money or life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't have time for this. Would you kindly get their attention?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your oversight is duly noted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Agreed. There are substantial benefits to strengthening ties between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Forging a personal relationship is inconsequential. What matters most is his ability to perform his duties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not sure what there is to be gained, but I am willing to keep an open mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Doubtful. I've never formed close relationships with my security detail in the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""More than you know. I believe the Golden Guard possesses an untapped potential that would prove quite advantageous should the need arise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[19]`
Mówca: **Hugo Toras**
> ""Excellent. Even if nothing comes of it, your willingness to engage in meaningful conversation is encouraging.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`
  - -> `[492]`
  - -> `[485]`

### Węzeł `[20]`
Mówca: **Hugo Toras**
> ""I can tell you firsthand that he's fully capable of executing them with utmost proficiency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`
  - -> `[492]`
  - -> `[485]`

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""Your ascension to the throne calls for a strengthening of all associations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[22]`
Mówca: **Narrator**
> "I was headed to a long-overdue meeting with Titus regarding the Golden Guard, and my uncle had insisted on accompanying me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Hugo Toras**
> ""I'm glad you've arranged a formal meeting with Captain Gordion. There's much to be gained in fostering a robust relationship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[16]`
  - -> `[17]`
  - -> `[15]`

### Węzeł `[24]`
Mówca: **Hugo Toras**
> ""But I'm getting ahead of myself. Captain Gordion can tell you more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`
  - -> `[492]`
  - -> `[485]`

### Węzeł `[25]`
Mówca: **Hugo Toras**
> ""In this case, building trust with the Golden Guard would benefit palace security as well as your own personal well-being.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`
  - -> `[492]`
  - -> `[485]`

### Węzeł `[26]`
Mówca: **Narrator**
> "It wasn't long before we'd crossed the courtyard and reached the armory, which also served the Golden Guard's headquarters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[27]`
Mówca: **Narrator**
> "Both seemed unsure how to react."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`
  - -> `[30]`
  - -> `[31]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come on... Don't leave me hanging.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Celebratory palm slap, all around!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry, I'm granting you permission to touch me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""High-five me. That's an order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[32]`
Mówca: **Narrator**
> "Letting down their guard, literally and figuratively, they both reached out and gave me a high-five."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[39]`
  - -> `[38]`
  - -> `[33]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See? That wasn't so hard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright! That's what I'm talking about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[35]`
Mówca: **Narrator**
> "They looked at one another for confirmation before doing as instructed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[39]`
  - -> `[38]`
  - -> `[33]`

### Węzeł `[36]`
Mówca: **Narrator**
> "They hesitated at first before they each gave me a high-five."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[39]`
  - -> `[38]`
  - -> `[33]`

### Węzeł `[37]`
Mówca: **Narrator**
> "That made them smile before giving me a high-five."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[39]`
  - -> `[38]`
  - -> `[33]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excellent! You both have promising futures ahead of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now one down low.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Hugo Toras**
> ""I think it's best if we move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Narrator**
> "I lowered my outstretched palm just as Hugo stepped between me and the guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll leave when I say I'm ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. Lead the way!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're no fun... But yes. Let us continue onward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
Mówca: **Narrator**
> "I let a moment of silence fall between us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay. Now I'm ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Hugo Toras**
> ""Right. This way, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Hugo -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Narrator**
> "Hugo and I continued on our way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Narrator**
> "Upon entering the armory, I found myself surrounded by a collection of old weaponry and armor on display. The polished shields and rusted swords appeared frozen in time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[51]`
Mówca: **Narrator**
> "We eventually reached a training facility where we found Captain Gordion in boxing gloves sparring with another Golden Guardsman."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
Mówca: **Titus Gordion**
> ""You're wasting too much energy running around the ring. Next time--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""My money is on Captain Gordion. What do you say, 50 guilder?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[66]`
  - -> `[10]`
  - -> `[11]`
  - -> `[12]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll take that bet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Hugo Toras**
> ""You're on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[56]`
Mówca: **Hugo Toras**
> ""Fair enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[57]`
Mówca: **Hugo Toras**
> ""Certainly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]`

### Węzeł `[58]`
Mówca: **Hugo Toras**
> ""Right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Hugo Toras**
> ""Captain Gordion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Narrator**
> "The captain turned to face us. He and his opponent bowed their heads when they saw me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Titus Gordion**
> ""Forgive me, Your Majesty. I didn't see you there. You're earlier than I expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`
  - -> `[13]`
  - -> `[64]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If anything, I should be the one apologizing for interrupting you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not your fault. I arrived sooner than anticipated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm surprised you were unaware of your king's whereabouts, considering that falls within your jurisdiction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[65]`
Mówca: **Narrator**
> "The two men circled each other for a while before they started swinging. Three rounds later, the Captain had his opponent on the ropes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, *my* money is on Captain Gordion. You take the other man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Hugo Toras**
> ""Very well. Let the best man win!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""It appears Captain Gordion has emerged victorious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[72]`
  - -> `[70]`
  - -> `[71]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, it does. I would pay you now, but I never carry cash.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know I'm not paying you, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think... should I hop in the ring? I bet I could take him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It certainly does. Looks like I owe you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Hugo Toras**
> ""One of the many perks of being king! I'll come to collect at a later date.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[74]`
Mówca: **Hugo Toras**
> ""Let this be a life lesson!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[75]`
Mówca: **Hugo Toras**
> ""That's not sportsmanlike at all. But very well, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Hugo Toras**
> ""As Grand Vizier to the king, I would be remiss to endorse such a course of action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Narrator**
> "I watched as Captain Gordion helped the other man to his feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[78]`
Mówca: **Titus Gordion**
> ""Your Majesty! Many apologies. I didn't see you there. You're earlier than I expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[82]`
  - -> `[79]`
  - -> `[81]`

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your lack of observation is disappointing. My early arrival shouldn't be unexpected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm here before my usual time. I should be the one apologizing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your oversight is evident. My punctuality shouldn't be a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to apologize. Just like in the ring, timing can be a challenge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[83]`
Mówca: **Titus Gordion**
> ""Forgive me. It won't happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[87]`
  - -> `[89]`

### Węzeł `[84]`
Mówca: **Titus Gordion**
> ""No need, but I appreciate the sentiment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[90]`
  - -> `[87]`
  - -> `[89]`

### Węzeł `[85]`
Mówca: **Titus Gordion**
> ""Yes, Your Majesty. It won't happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[87]`
  - -> `[89]`

### Węzeł `[86]`
Mówca: **Titus Gordion**
> ""Very true, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[90]`
  - -> `[87]`
  - -> `[89]`

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, I don't have all day. Let us retire so we may discuss the nature of my visit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[91]`
  - -> `[93]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must say, that's quite the right hook you got there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright, enough chit-chat. Let's get out of here and talk somewhere more private.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[91]`
  - -> `[93]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In any case, let us take our leave. We have much to discuss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[91]`
  - -> `[93]`

### Węzeł `[91]`
Mówca: **Titus Gordion**
> ""As you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[92]`
Mówca: **Titus Gordion**
> ""Absolutely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Titus Gordion**
> ""Of, course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Titus Gordion**
> ""If you'll follow me, we can delve into the matter you've here to address.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Follow_Titus_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[96]`
Mówca: **Narrator**
> "The two men circle each other for a while before exchanging swings. Three rounds later, the Captain had Hugo's guy in a tight spot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`
  - -> `[524]`
  - -> `[525]`

### Węzeł `[97]`
Mówca: **Hugo Toras**
> ""And Titus has emerged victoriously. Looks like I owe you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[101]`
  - -> `[99]`
  - -> `[100]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Guess I have a knack for picking winners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, don't worry about it. It was a lighthearted wager.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We should have them go another round. What do you say? Raise the bet? Double or nothing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yep. Now pay up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Hugo Toras**
> ""No doubt a useful skill to possess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[103]`
Mówca: **Hugo Toras**
> ""Certainly -- as soon as we've concluded this meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[104]`
Mówca: **Hugo Toras**
> ""Much appreciated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[105]`
Mówca: **Hugo Toras**
> ""Tempting, but no thanks. I've already lost once today. I don't need a repeat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[106]`
Mówca: **Titus Gordion**
> ""No need, but I appreciate the sentiment. I was just showing our newest recruit a thing or two in the ring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[110]`
  - -> `[669]`

### Węzeł `[107]`
Mówca: **Titus Gordion**
> ""My men have eyes on you at all times, Your Majesty. In the event of an emergency, I would have been contacted at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[110]`
  - -> `[669]`

### Węzeł `[108]`
Mówca: **Titus Gordion**
> ""Yes, sir. It won't happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[669]`

### Węzeł `[109]`
Mówca: **Titus Gordion**
> ""Well, it's great to have you here, regardless of when you arrived.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[110]`
  - -> `[669]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In any event, we should get moving. We have plenty to talk about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Titus Gordion**
> ""Absolutely. Right this way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must say, that's quite the right hook you got there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[113]`
Mówca: **Hugo Toras**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[114]`
Mówca: **Narrator**
> "Although the other fighter managed to land a few hits, the match concluded with Captain Gordion prevailing, thanks to a powerful punch to his opponent's jaw."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[115]`
  - -> `[117]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "Clear your throat."]** — Mówca: **Player_Romus_Italic**
> "I cleared my throat to make them aware of my presence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "Applaud."]** — Mówca: **Player_Romus_Italic**
> "I lightly applauded his win."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bravo!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[118]`
Mówca: **Titus Gordion**
> ""Courtesy of my former boxing days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`
  - -> `[503]`
  - -> `[504]`

### Węzeł `[120]`
Mówca: **Titus Gordion**
> ""Compliments of my old boxing days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `AddConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[124]`
Mówca: **Hugo Toras**
> ""Well, Your Majesty... shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[125]`
  - -> `[128]`
  - -> `[127]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we must.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks, but your counsel is no longer required. I'd like to speak to the captain alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe the kind of trust you want me to build with the Golden Guard can only be established by meeting Titus one-on-one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[129]`
Mówca: **Narrator**
> "Captain Gordion removed his boxing gloves as he headed toward an entrance to another wing of the armory."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Take a tour of the armory or find some other means to entertain yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. Now get to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can wait around until my business is complete, but you're welcome to take your leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Hugo -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[134]`
Mówca: **Hugo Toras**
> ""I see. Well, if that is your wish, I will stay where I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[131]`
  - -> `[130]`

### Węzeł `[135]`
Mówca: **Hugo Toras**
> ""Really? I mean... yes, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[131]`
  - -> `[130]`

### Węzeł `[136]`
Mówca: **Hugo Toras**
> ""After you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]`

### Węzeł `[137]`
Mówca: **Hugo Toras**
> ""If you want to ensure the good captain is on our side, then yes. We 'must.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]`

### Węzeł `[138]`
Mówca: **Narrator**
> "Hugo seemed to force a smile before bowing his head and turning away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[139]`
Mówca: **Hugo Toras**
> ""Very well, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[140]`
Mówca: **Hugo Toras**
> ""As you command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[141]`
Mówca: **Hugo Toras**
> ""Yes. Understood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[142]`
Mówca: **Narrator**
> "Hugo and I caught up to Titus as he stepped inside the building."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[144]`
Mówca: **Narrator**
> "Upon entering, we were once again enveloped by an array of antiquated weaponry and armor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Quite the arsenal you've got here, Captain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I like what you've done with the place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've often found that focusing too much on memorializing the past can impede progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bows and arrows? Duchess Azaro wasn't kidding when she said our military needed upgrading.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]`

### Węzeł `[150]`
Mówca: **Hugo Toras**
> ""I'm pleased you take such an interest in preserving Rizia's history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`
  - -> `[147]`
  - -> `[145]`
  - -> `[148]`

### Węzeł `[151]`
Mówca: **Narrator**
> "Titus motioned toward the displays."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[152]`
Mówca: **Narrator**
> "That drew a laugh from my uncle, while the captain simply smiled patiently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[153]`
Mówca: **Titus Gordion**
> ""You're more than welcome to visit anytime -- not that you need an invitation. In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[154]`
Mówca: **Titus Gordion**
> ""True, though I personally believe that such memorials can offer inspiration. Especially during times of great difficulty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[155]`
Mówca: **Titus Gordion**
> ""Believe me, this is just a fraction of what the palace has got tucked away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[156]`
Mówca: **Titus Gordion**
> ""Well, we still have several trebuchets on standby in case we need to fling cows at the enemy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]`

### Węzeł `[157]`
Mówca: **Titus Gordion**
> ""I brought most of this out of storage soon after I took command. A considerable portion of what you see was in bad shape and required extensive refurbishment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[158]`
Mówca: **Hugo Toras**
> ""Ha! As long as we get the green light from animal rights activists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Titus Gordion**
> ""But in all seriousness...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Titus Gordion**
> ""If you desire, I'd be honored to provide you with the background and history of anything here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[161]`
  - -> `[164]`
  - -> `[163]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, by all means.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. Let's hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, thank you. I always found history lessons boring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tempted as I am, time is of the essence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Titus Gordion**
> ""Certainly. What would you like to hear about first?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[166]`
Mówca: **Titus Gordion**
> ""Perhaps some other day then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[167]`
Mówca: **Titus Gordion**
> ""Excellent. Where would you like to start?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Titus Gordion**
> ""Understandable. The study of history isn't to everyone's liking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaHistoryHub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[180]`
  - -> `[183]`
  - -> `[174]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why don't you tell me about that sword?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me about that impressive suit of armor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough history. I'm ready to move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm curious to know about... whatever *that* is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory == true || RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory == true || RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory == true || RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory == true || RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory"] == true  or  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory"] == true  or  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory == true || RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory == true || RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory"] == true  or  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory"] == true  or  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[186]`
Mówca: **Titus Gordion**
> ""Very well. This way, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_ArmorHistory"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_SwordHistory"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_IronMaidenHistory"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[190]`
Mówca: **Titus Gordion**
> ""You'll be happy to know it hasn't been used in quite some time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]`
  - -> `[446]`
  - -> `[447]`
  - -> `[448]`

### Węzeł `[191]`
Mówca: **Titus Gordion**
> ""Enhanced interrogation methods have come a long way in the past century. No need for metal spikes unless you're a traditionalist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [RiziaHistoryHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_MoveOn = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_MoveOn"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[194]`
Mówca: **Titus Gordion**
> ""That would be 'Saint Mercy,' our aptly named iron maiden -- a torture device from a bygone era. It was last used on suspected spies during the War of Rizian Succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]`

### Węzeł `[195]`
Mówca: **Titus Gordion**
> ""'Terador's Fury.' Its notoriety spans back several hundred years, just after the Empire of Valgos seized Pales from Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Titus Gordion**
> ""Although we lost our most important port, we managed to keep our enemy from making further inroads into the kingdom at the Battle of Terador.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[197]`
Mówca: **Titus Gordion**
> ""After securing power in Monqiz, his dynasty maintained a stronghold over the city-state throughout the Markian era.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`

### Węzeł `[198]`
Mówca: **Hugo Toras**
> ""Legend has it, this sword took off the head of the Valgos army's top general.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[200]`
  - -> `[199]`

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's considered bad luck to mention severed heads in the presence of a king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A bad day for him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`

### Węzeł `[201]`
Mówca: **Titus Gordion**
> ""That would be the armor of King Henricus Toras, the ancestor from whom all members of your house are descended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But it wasn't enough to prevent Pales being taken from Rizia. That's what keeps me awake at night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[203]`
Mówca: **Titus Gordion**
> ""But I'm sure you knew that already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`
  - -> `[453]`
  - -> `[452]`

### Węzeł `[204]`
Mówca: **Hugo Toras**
> ""Yes. However, if I may be so bold, Your Majesty, there are valuable lessons to be learned from looking to Rizia's past -- lessons that could address present-day challenges, should they arise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[205]`
  - -> `[208]`
  - -> `[207]`

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you both think it's that important, then go ahead, Captain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine, fine... You've convinced me. Let's hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What part of 'I have other priorities' do you not understand?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree with you, Uncle. However, it isn't something I'm interested in delving into at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Hugo Toras**
> ""Very well. I'll refrain from mentioning it further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[210]`
Mówca: **Hugo Toras**
> ""Got it. I won't bring it up again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Hugo -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[212]`
Mówca: **Titus Gordion**
> ""Certainly. Where would you like to start?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[213]`
Mówca: **Titus Gordion**
> ""Any items of particular interest?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[214]`
Mówca: **Hugo Toras**
> ""If I may be so bold, Your Majesty, there are valuable lessons to be learned from looking to Rizia's past -- lessons that could address present-day challenges, should they arise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[205]`
  - -> `[208]`
  - -> `[215]`

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I already said I'm not interested. Nor did I ask for your advice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Hugo Toras**
> ""Then I won't mention it again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[217]`
Mówca: **Narrator**
> "We continued onward until we reached Captain Gordion's office on the far side of the hall. It too was adorned with a large collection of war memorabilia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Narrator**
> "Captain Gordion gestured to a sitting area."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Titus Gordion**
> ""Please, have a seat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[220]`
Mówca: **Narrator**
> "Uncle Hugo sat on a sofa that looked to have been plucked from the 19th century."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`
  - -> `[502]`

### Węzeł `[221]`
**[WYBÓR GRACZA: "Sit."]** — Mówca: **Player_Romus_Italic**
> "I sat on a nearby leather armchair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[222]`
**[WYBÓR GRACZA: "Remain standing."]** — Mówca: **Player_Romus_Italic**
> "I remained standing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[223]`
Mówca: **Narrator**
> "Hugo, seeming suddenly self-aware of being the only one sitting, promptly stood back up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Drinking on the job? You should both be ashamed of yourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The fact that you would consider drinking on the job raises questions about your professionalism, Titus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just a little bit. I've got to stay sharp for the rest of the day's activities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You had me at 'fortified'. Regular wine's for weaklings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[228]`
Mówca: **Titus Gordion**
> ""Would you care for some fortified wine? It's an exceptional vintage dating back to 1893. From Rizia's very own Cantuavo vineyards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[229]`
Mówca: **Narrator**
> "The captain took out a bottle of wine from a cabinet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks, but no thanks. I only drink wine from 1892.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[231]`
Mówca: **Titus Gordion**
> ""So to what do I owe the pleasure of your company today?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`
  - -> `[246]`
  - -> `[248]`
  - -> `[249]`

### Węzeł `[232]`
Mówca: **Narrator**
> "Captain Gordion put the bottle away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[233]`
Mówca: **Titus Gordion**
> ""You're right. My mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[234]`
Mówca: **Hugo Toras**
> ""And mine as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Titus Gordion**
> ""Sorry. I'm afraid I'm fresh out of wine from that year.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[237]`
Mówca: **Hugo Toras**
> ""I believe His Majesty was joking. But perhaps we should all abstain after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[238]`
Mówca: **Narrator**
> "Captain Gordion uncorked the bottle and poured us each a glass. We briefly toasted and took a sip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_Sit = false;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_Sit"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_Sit = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_Sit"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[241]`
Mówca: **Narrator**
> "After putting it away, he settled in a chair across from me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[242]`
Mówca: **Narrator**
> "After putting it away, he stood facing me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_Sit == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_Sit == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_Sit"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[245]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_Sit == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_Sit"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As the King of Rizia, I have many enemies. I wanted to make sure you're not one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm looking to develop a clearer understanding of the individuals comprising my security detail, particularly the man who's leading them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wanted to get away from my council and speak to a real commoner. Your perspectives are always so refreshing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My uncle suggested I get to know you better, believing that building a personal relationship beyond our professional one would be highly beneficial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Titus Gordion**
> ""Well, I'm more than happy to tell you about myself, though you might find hearing about the Golden Guard more interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[251]`
Mówca: **Titus Gordion**
> ""I don't see why not. What would you like to know?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[252]`
Mówca: **Titus Gordion**
> ""It's been quite some time since I was among the common people, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[253]`
Mówca: **Titus Gordion**
> ""Certainly not, Your Majesty. Please, ask me anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why don't you tell me more about yourself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's hear more about the Golden Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground == true && RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground  == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground == true && RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground  == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground"] == true  and  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"]  == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`
  - -> `[381]`

### Węzeł `[258]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground == true && RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground  == true 
))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground"] == true  and  Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"]  == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[265]`
Mówca: **Titus Gordion**
> ""Well, I was born and raised in Porte Drazon. My father was in the military while my mother took care of me and my siblings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[266]`
Mówca: **Titus Gordion**
> ""I'd be honored. As you already know, each guardsman stationed in this palace and across Rizia Imperii has sworn an oath to protect the royal household. We answer to no one else but you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`
  - -> `[290]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GoldenTitusHistoryHub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[262]`
  - -> `[256]`
  - -> `[695]`

### Węzeł `[268]`
Mówca: **Titus Gordion**
> ""Gladly. Aside from general security, the Golden Guard has had a long history of carrying out more *private* matters for the king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[292]`
  - -> `[293]`
  - -> `[294]`

### Węzeł `[269]`
Mówca: **Titus Gordion**
> ""As in *offensive* operations, if you get my meaning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He gave his life for a good cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So much senseless bloodshed. May it never happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Titus Gordion**
> ""That's where my military training comes in. I was selected to benefit from the highest-level instruction at Camp Domus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[273]`
Mówca: **Titus Gordion**
> ""For what it's worth, sir, he believed in the cause. He never turned against King Valero.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[274]`
Mówca: **Titus Gordion**
> ""He believed in it with all his heart. He never turned against King Valero.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry for your loss. Didn't mean to bring up bad memories.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[276]`
Mówca: **Titus Gordion**
> ""Not a problem, sir. He died fighting for what he believed in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[277]`
Mówca: **Titus Gordion**
> ""I took up championship boxing to support us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[665]`
  - -> `[689]`
  - -> `[686]`

### Węzeł `[278]`
Mówca: **Titus Gordion**
> ""I had a fairly normal childhood until my father was killed during the operation to take back Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`
  - -> `[275]`

### Węzeł `[279]`
Mówca: **Titus Gordion**
> ""Needless to say, his death brought about a long period of financial instability. My mother did what she could, but it wasn't enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[280]`
Mówca: **Hugo Toras**
> ""How did you get by?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, that explains your fisticuffs from earlier! You fared well, I assume?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Were you any good?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Titus Gordion**
> ""Good enough to catch the eye of military recruiters. I do sometimes miss those days in the ring on occasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Titus Gordion**
> ""Good enough to attract the attention of military recruiters. I do find myself longing for those days in the ring from time to time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[285]`
Mówca: **Titus Gordion**
> ""I worked my way up through the ranks until just a few years ago, when General Taddeus Azaro approached me with the idea of reinstating the Golden Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GoldenTitusHistoryHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_TitusBackground"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, yes... We've been over that already. Tell me something I don't know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I am forever grateful. Please, continue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Private matters?' How intriguing. Please elaborate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, I'm definitely interested in hearing more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds rather ominous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't like the sound of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[295]`
Mówca: **Hugo Toras**
> ""Outside of less scrupulous dealings, it might also pique your interest to know that they were once tasked with serving as emergency firefighters in the event of an unruly blaze.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`

### Węzeł `[296]`
Mówca: **Titus Gordion**
> ""For king and country, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[297]`
Mówca: **Titus Gordion**
> ""We do what we must to ensure the protection of the monarchy. And sometimes that requires us to extend beyond our typical duties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[298]`
Mówca: **Titus Gordion**
> ""Let's just say... the public is better off not not knowing the types of operations we've handled beyond simple security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[299]`
Mówca: **Titus Gordion**
> ""The real world isn't as black and white as it seems, which is where we come in. We navigate in the gray.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[300]`
Mówca: **Narrator**
> "Titus hesitated a moment, casting a curious glance at Hugo as he did."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[301]`
Mówca: **Hugo Toras**
> ""Alright, I'll come out and say it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[302]`
Mówca: **Hugo Toras**
> ""Since their return, their dealing with such matters has been limited in scope, however, the potential to broaden their... *flexibility* is still there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[303]`
  - -> `[305]`
  - -> `[306]`

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If what you're saying is true, then I am truly shocked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd heard rumors of such clandestine actions, but this is the first time I've received official confirmation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I find the notion of an organization working outside the rule of law truly worrisome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is it wrong to see great potential in sanctioning such actions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Titus Gordion**
> ""As I said, I am at your command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[308]`
Mówca: **Titus Gordion**
> ""We only work within the confines given to us by the king. It's a matter of defining what those parameters are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[309]`
Mówca: **Titus Gordion**
> ""Secrecy is of the utmost importance to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[310]`
Mówca: **Titus Gordion**
> ""By deploying us to assist in disaster relief, the crown could demonstrate concern for the well-being of the local populace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[311]`
  - -> `[313]`
  - -> `[314]`

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we're relying on the Golden Guard to handle fires, we have far bigger problems on our hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can rest assured that I won't be sending you out on any firefighting excursions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Seeing as how putting out fires falls within your existing duties, extinguishing *literal* fires doesn't sound too far-fetched.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, then next time I hear of any kittens stuck in trees, I'll let you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Titus Gordion**
> ""Much appreciated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[317]`
Mówca: **Titus Gordion**
> ""I'm actually allergic to cats, but I won't let that get in my way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[318]`
Mówca: **Titus Gordion**
> ""Fair point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[319]`
Mówca: **Titus Gordion**
> ""Hopefully it won't get to that point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_GoldenGuardBackground"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[321]`
Mówca: **Hugo Toras**
> ""I think that was a very productive meeting, if I do say so myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
  - -> `[324]`
  - -> `[326]`
  - -> `[327]`

### Węzeł `[322]`
Mówca: **Narrator**
> "Before long, Hugo and I left the armory and were making our way back through the palace courtyard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[323]`
Mówca: **Hugo Toras**
> ""Thanks again for your hospitality, Captain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Agreed. Your counsel was greatly appreciated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't ask for your opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As do I. Strengthening ties has its benefits, as you rightly pointed out. Let's hope for continued amicability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Hugo Toras**
> ""Yes, but as your Grand Vizier, I'm obligated to give advice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[335]`
  - -> `[334]`

### Węzeł `[329]`
Mówca: **Hugo Toras**
> ""I know I'm right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[349]`
  - -> `[350]`

### Węzeł `[330]`
Mówca: **Hugo Toras**
> ""I have no doubt that it will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[331]`
Mówca: **Hugo Toras**
> ""It is my honor, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[333]`
Mówca: **Hugo Toras**
> ""I look forward to providing you with further guidance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Watch your words. Your obligations mean little in the face of my authority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. But the next time you feel compelled to give unsolicited advice, you may find yourself on the receiving end of unsolicited... *feedback*, if you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. Please excuse my curtness. I welcome any advice you have to give.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[337]`
Mówca: **Narrator**
> "Hugo and I said our goodbyes and parted ways."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[338]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[339]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`
  - -> `[341]`

### Węzeł `[340]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Titus"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Titus >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Titus"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Narrator**
> "Titus was a good ally to have. Much could be gained by solidifying a strong relationship, and I looked forward to what his resources and skill sets would bring."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[343]`
Mówca: **Narrator**
> "I still wasn't fully sold on whether or not Titus could be trusted. But I was satisfied knowing that my influence over him remained strong."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Narrator**
> "For now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[346]`
Mówca: **Hugo Toras**
> ""Such collaboration will not only elevate but bring us closer to our goals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[347]`
Mówca: **Hugo Toras**
> ""I prefer... realistically optimistic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So sure of yourself, are you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Self-assuredness is a quality I value.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Some would call that arrogance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[351]`
Mówca: **Hugo Toras**
> ""As always, your perspective is highly valued.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[352]`
Mówca: **Hugo Toras**
> ""His Majesty's words are final.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[353]`
Mówca: **Narrator**
> "Hugo gave a slight nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[354]`
Mówca: **Hugo Toras**
> ""In my experience, a little confidence can go a long way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[355]`
Mówca: **Hugo Toras**
> ""Not arrogant. Self-confident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[356]`
Mówca: **Narrator**
> "Titus gave a heartfelt bow and left my company."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[359]`

### Węzeł `[358]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[359]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[360]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoWaitsforKing"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[361]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GoldenTitusHistoryHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[362]`
Mówca: **Narrator**
> "Navigating through the armory once more, I eventually found my uncle in the vicinity of Titus' boxing match."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[363]`
Mówca: **Narrator**
> "I retraced my steps through the armory, and before long, I found myself back outside crossing the courtyard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[364]`
Mówca: **Hugo Toras**
> ""There you are! I trust your discussion with Titus was productive?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's none of your concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, very. Though I'd rather not go into detail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As productive as one can be when talking to a dumb grunt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[368]`
Mówca: **Hugo Toras**
> ""I can assure you that he's anything but dumb. He's one of the most capable people I've ever met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[369]`
Mówca: **Hugo Toras**
> ""Your discretion is duly noted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[370]`
Mówca: **Hugo Toras**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Hugo Toras**
> ""That said, for me to offer you the most effective counsel, I suggest providing me with such details in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Hugo Toras**
> ""However, moving forward, I recommend ensuring that I am kept well-informed -- seeing as how I'm your advisor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Hugo_Part_Ways])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[374]`
Mówca: **Hugo Toras**
> ""I do hope you'll one day hold him in as high regard as I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was, actually. I seem to have misjudged the captain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[378]`

### Węzeł `[377]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Titus >= 2)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Titus"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[367]`
  - -> `[366]`
  - -> `[365]`

### Węzeł `[378]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Titus >= 2))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Titus"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[366]`
  - -> `[365]`

### Węzeł `[379]`
Mówca: **Hugo Toras**
> ""I'm pleased to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[380]`
Mówca: **Hugo Toras**
> ""I won't overstep my bounds by asking the nature of your chat. However, to provide you with optimal guidance, I propose sharing such information with me going forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[381]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your comprehensive explanation is appreciated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for sharing, Titus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your thorough explanation, Titus, but try to bring it to a natural conclusion a little sooner next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[384]`
Mówca: **Titus Gordion**
> ""It's my pleasure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[385]`
Mówca: **Titus Gordion**
> ""I'm glad I could provide you with further insight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[386]`
Mówca: **Titus Gordion**
> ""I'll make sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That will be all, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[388]`
Mówca: **Narrator**
> "I left my uncle and caught up to Captain Gordion as he stepped inside the building."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[389]`
Mówca: **Narrator**
> "Upon entering, I was once again enveloped by an array of antiquated weaponry and armor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[390]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[392]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`
  - -> `[145]`
  - -> `[148]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[395]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[396]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`
  - -> `[398]`

### Węzeł `[397]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[398]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[399]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`
  - -> `[401]`

### Węzeł `[400]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[401]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`

### Węzeł `[402]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`
  - -> `[404]`

### Węzeł `[403]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`
  - -> `[407]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[715]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`
  - -> `[410]`

### Węzeł `[409]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[410]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`
  - -> `[413]`

### Węzeł `[412]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`
  - -> `[416]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[417]`
Mówca: **Titus Gordion**
> ""So, I put on a pair of gloves and entered the world of championship boxing to provide for my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[281]`
  - -> `[689]`
  - -> `[686]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`
  - -> `[420]`

### Węzeł `[419]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[421]`
Mówca: **Narrator**
> "Titus hesitated a moment before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[422]`
Mówca: **Titus Gordion**
> ""The Golden Guard has had a long rich history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[423]`
Mówca: **Titus Gordion**
> ""Nevertheless the chance to fully restore our actions remains open.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[303]`
  - -> `[305]`
  - -> `[306]`

### Węzeł `[424]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`
  - -> `[426]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[427]`
Mówca: **Titus Gordion**
> ""If there's anything else I can do for you, don't hesitate to ask.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`
  - -> `[430]`

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[430]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`
  - -> `[433]`
  - -> `[432]`
  - -> `[434]`

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Til next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you. Until we meet again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[433]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks again for your hospitality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[434]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Goodbye, Titus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[435]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Leave_Titus_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[436]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Leave_Titus_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[437]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Titus Gordion");)*
- **Efekt (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[438]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Hugo += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[439]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Hugo += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[440]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Hugo -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[441]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Hugo -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[442]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Hugo -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Hugo"] = Variable["RiziaDLC.Relations_Hugo"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`

### Węzeł `[443]`
Mówca: **Narrator**
> "I motioned to a broadsword prominently displayed in the center of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[444]`
Mówca: **Narrator**
> "I pointed to an intricately adorned armored suit that stood out amongst the others."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[445]`
Mówca: **Narrator**
> "I gestured toward a metallic, coffin-like contraption that stood upright."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Most reassuring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[447]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hard to believe it was used at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[448]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Too bad. A lot of fun could be had with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[450]`
Mówca: **Titus Gordion**
> ""Not often. It was more to scare people, if anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[451]`
Mówca: **Titus Gordion**
> ""Enhanced interrogation is serious business, Your Majesty. There are much more efficient methods in existence today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[452]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm more interested in knowing if his armor would fit me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[453]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Obviously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, but it's always good to refresh myself on our history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[455]`
Mówca: **Titus Gordion**
> ""Everyone back then was much shorter, so, unfortunately, I don't believe it would, given your frame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[456]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`
  - -> `[458]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[458]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`

### Węzeł `[459]`
Mówca: **Hugo Toras**
> ""If you really want a suit of armor that fits, I'm sure we could arrange something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`
  - -> `[460]`
  - -> `[462]`

### Węzeł `[460]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's okay. I'd look ridiculous anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[461]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, please do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]`

### Węzeł `[462]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as we get a second one for you. Then we'd be a matching set.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[463]`
Mówca: **Narrator**
> "Hugo and Titus laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[464]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[465]`
Mówca: **Titus Gordion**
> ""My apologies. It won't happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[466]`
Mówca: **Titus Gordion**
> ""It is indeed a sore spot in our history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[467]`
Mówca: **Titus Gordion**
> ""To put it lightly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[468]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Follow_Titus_Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[469]`
Mówca: **Narrator**
> "Equally significant was my satisfaction in recognizing that my control over him remained unwavering."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`
  - -> `[472]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[473]`
Mówca: **Titus Gordion**
> ""This sword is said to be the very weapon that severed the head of the commanding general of the Valgos army.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[200]`
  - -> `[199]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`
  - -> `[476]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[476]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[477]`
Mówca: **Hugo Toras**
> ""I'm sure His Majesty knows the history of his own house, Captain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`
  - -> `[453]`
  - -> `[452]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`
  - -> `[480]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`

### Węzeł `[480]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[481]`
Mówca: **Hugo Toras**
> ""I can think of a few people who could benefit from such... physical therapy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]`

### Węzeł `[482]`
Mówca: **Hugo Toras**
> ""I'm not being serious, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn02_RH_SupportGoldenGuard = true; RiziaDLCSupport.Reports_Turn02_Nelvisar_FieldShutsDown = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn02_RH_SupportGoldenGuard"] = true;
Variable["RiziaDLCSupport.Reports_Turn02_Nelvisar_FieldShutsDown"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Hugo_Part_Ways)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've been impressed by Captain Gordion's loyalty thus far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]`

### Węzeł `[486]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope that today's visit will prove you right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[487]`
Mówca: **Titus Gordion**
> ""What else can I tell you about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[488]`
Mówca: **Titus Gordion**
> ""What else would you like to know?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[489]`
Mówca: **Titus Gordion**
> ""If you would like, Your Majesty, I can have the sword polished for ceremonial use.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]`
  - -> `[658]`

### Węzeł `[490]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `AddConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[491]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus is all that stands between me and an assassin's bullet, and I know next to nothing about him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Be honest with me, Hugo. Do you believe Gordion can be trusted?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[493]`
Mówca: **Hugo Toras**
> ""What I know is that there has never been a more loyal subject than Captain Titus Gordion. He lives and breathes honor and devotion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`
  - -> `[496]`
  - -> `[497]`
  - -> `[486]`

### Węzeł `[494]`
Mówca: **Hugo Toras**
> ""As have I. And I have the feeling his expertise extends far beyond personal security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`
  - -> `[486]`
  - -> `[499]`

### Węzeł `[495]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's what worries me. Fanatical devotion can be dangerous should one find themselves on its unfavorable side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[496]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not quite sure we're on the same page just yet. But we shall see what today brings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[497]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I look forward to getting to know him better today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[498]`
Mówca: **Hugo Toras**
> ""He is, without a doubt, one of the most trustworthy individuals in the entire kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`
  - -> `[486]`
  - -> `[500]`

### Węzeł `[499]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm pleased to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[500]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He'd better be. I won't tolerate anything less.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[501]`
**[WYBÓR GRACZA: "Sit down."]** — Mówca: **Player_Romus_Italic**
> "I took a seat in a leather armchair close by."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[502]`
**[WYBÓR GRACZA: "Keep standing."]** — Mówca: **Player_Romus_Italic**
> "I chose to stand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[503]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, I don't have all day. Let's find a place to discuss the purpose of my visit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`
  - -> `[506]`
  - -> `[508]`

### Węzeł `[504]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay, that's enough small talk. Let's shift this conversation to a private setting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`
  - -> `[506]`
  - -> `[508]`

### Węzeł `[505]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Regardless, we should go. We've got plenty to talk about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`
  - -> `[506]`
  - -> `[508]`

### Węzeł `[506]`
Mówca: **Titus Gordion**
> ""Whatever you'd like, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[507]`
Mówca: **Titus Gordion**
> ""Very good, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[508]`
Mówca: **Titus Gordion**
> ""Sure thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[509]`
Mówca: **Titus Gordion**
> ""If you'll come with me, I can take you somewhere more secluded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[510]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Follow_Titus_Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[511]`
Mówca: **Hugo Toras**
> ""They also carried out arrests and even liquidation of individuals who posed a threat to the crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[512]`
Mówca: **Hugo Toras**
> ""Since the founding of the Golden Guard, long before your father reinstated them, they were known to engage in espionage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[513]`
Mówca: **Titus Gordion**
> ""Since our founding, we've engaged in espionage, apprehensions, and eliminating threats to the crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[514]`
Mówca: **Titus Gordion**
> ""But in the wake of our revival, we have yet to involve ourselves in such affairs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[515]`
Mówca: **Hugo Toras**
> ""Still feeling confident about your choice?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`
  - -> `[518]`
  - -> `[517]`

### Węzeł `[516]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My certainty hasn't waned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[517]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must admit, I fear I've placed my bets on the wrong man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[518]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I should ask you the same question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[519]`
Mówca: **Hugo Toras**
> ""Humility is a sign of strength and moral character. You shouldn't be afraid to display it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`

### Węzeł `[520]`
Mówca: **Hugo Toras**
> ""Then I guess we'll see where that certainty takes us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[521]`
Mówca: **Hugo Toras**
> ""Some might say you're deflecting. But in any case, yes. Very confident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[522]`
Mówca: **Narrator**
> "Hugo made himself laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]`

### Węzeł `[523]`
Mówca: **Narrator**
> "We continued watching the fight. My guy did manage to land a few hits, but in the end, Captain Gordion came out on top with a powerful punch to the jaw."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[524]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you say we double the bet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[525]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are your knees starting to shake, Uncle?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[526]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It appears my man has the upper hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[527]`
Mówca: **Hugo Toras**
> ""I'm afraid you might be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[528]`
Mówca: **Hugo Toras**
> ""Not when the Captain has the initiative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[529]`
Mówca: **Hugo Toras**
> ""Never. Though I can't say the same about my confidence in my man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[530]`
Mówca: **Narrator**
> "We continued watching the fight. Hugo's fighter landed a few more hits, but Captain Gordion ultimately came out on top thanks to a swift punch to the jaw."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[531]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Same. I like what you've done with the place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[532]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`
  - -> `[534]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[534]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[535]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina -= 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[536]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`
  - -> `[538]`

### Węzeł `[537]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[538]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[539]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[540]`
Mówca: **Titus Gordion**
> ""Discretion is the Golden Guard way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[541]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[542]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nonsense. I can't turn down a chance to drink with my new bodyguard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`

### Węzeł `[543]`
Mówca: **Narrator**
> "Hugo shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[544]`
Mówca: **Hugo Toras**
> ""If you insist, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`

### Węzeł `[545]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`
  - -> `[547]`

### Węzeł `[546]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]`

### Węzeł `[547]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[720]`

### Węzeł `[548]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why not? I can't turn down the chance to drink with my new bodyguard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[549]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not presume to speak for me, Uncle. I shall drink if I wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[550]`
Mówca: **Narrator**
> "Hugo looked puzzled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[551]`
Mówca: **Hugo Toras**
> ""Apologies, Your Majesty. I presumed wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`

### Węzeł `[552]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, thank you, Hugo. Another time, perhaps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[553]`
Mówca: **Titus Gordion**
> ""We in the Golden Guard are trained to keep our resources sharp in any situation. Intoxicated or otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[554]`
Mówca: **Titus Gordion**
> ""But you're right to have your doubts. Forgive me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[555]`
Mówca: **Titus Gordion**
> ""My apologies to you both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[556]`
Mówca: **Titus Gordion**
> ""I'm honored, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[557]`
Mówca: **Titus Gordion**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[558]`
Mówca: **Titus Gordion**
> ""This one's strong indeed. But it's mellowed out over the years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[559]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[560]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you have eyes on me at all times? Even during... intimate moments?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]`

### Węzeł `[561]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is it possible, hypothetically speaking, for the Golden Guard to support the Crown in a murder investigation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]`

### Węzeł `[562]`
Mówca: **Titus Gordion**
> ""If we were granted the resources, such an investigation would not be out of the question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[563]`
Mówca: **Titus Gordion**
> ""Would you care to elaborate?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]`
  - -> `[571]`
  - -> `[572]`

### Węzeł `[564]`
Mówca: **Narrator**
> "Hugo straightened up, suddenly more alert. Titus appeared unfazed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[565]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`
  - -> `[567]`

### Węzeł `[566]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`

### Węzeł `[567]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]`

### Węzeł `[568]`
Mówca: **Narrator**
> "Titus didn't blink."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]`

### Węzeł `[569]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you deem to be the biggest threat to my personal safety right now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`

### Węzeł `[570]`
Mówca: **Titus Gordion**
> ""Is there anything else you'd like to know?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[571]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There isn't a murder. I'm speaking purely in a speculative context.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]`

### Węzeł `[572]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will, should the need arise. I'm still determining if there's sufficient justification for such an inquiry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`

### Węzeł `[573]`
Mówca: **Titus Gordion**
> ""Understandable. In any event, I'm here to assist you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[574]`
Mówca: **Titus Gordion**
> ""Very well. Either way, I'm at your service.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[575]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Such an investigation might require conducting surveillance within Palace walls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]`

### Węzeł `[576]`
Mówca: **Titus Gordion**
> ""Understood. The Guard would definitely be the best option for such a sensitive undertaking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[577]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GG Questions 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`
  - -> `[611]`
  - -> `[701]`
  - -> `[614]`
  - -> `[387]`

### Węzeł `[578]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GG Questions 2])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]`

### Węzeł `[579]`
Mówca: **Titus Gordion**
> ""It is our utmost aim to protect the Royal Family's security while respecting your privacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]`

### Węzeł `[580]`
Mówca: **Titus Gordion**
> ""You can expect that we'll be watching you and your family members in public, and standing guard outside any room you enter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[581]`
Mówca: **Titus Gordion**
> ""But what you do in that room is no business of ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`
  - -> `[602]`
  - -> `[603]`
  - -> `[604]`

### Węzeł `[582]`
Mówca: **Narrator**
> "Titus looked around, then turned back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`

### Węzeł `[583]`
Mówca: **Titus Gordion**
> ""Your government security forces seem to have a handle on the populace. But who has a handle on them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]`

### Węzeł `[584]`
Mówca: **Titus Gordion**
> ""I don't want to overstep my bounds so early into my employ. But I do believe the Azaros could pose a threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`

### Węzeł `[585]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]`
  - -> `[587]`

### Węzeł `[586]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`

### Węzeł `[587]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`
  - -> `[593]`
  - -> `[594]`
  - -> `[595]`

### Węzeł `[588]`
Mówca: **Hugo Toras**
> ""Please don't worry His Majesty with such speculations, Captain Gordion. House Azaro and House Toras have been close allies since the War of Rizian Succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`
  - -> `[590]`
  - -> `[591]`

### Węzeł `[589]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. If there's any house we should be worried about, it's the Sazons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[590]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate you voicing your concerns, Titus, even if I do not share them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]`

### Węzeł `[591]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't hastily dismiss the captain's suspicions, Hugo. I wouldn't be surprised if the Azaros had designs on the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[592]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nonsense. The Azaros have been close allies since the War of Rizian Succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[593]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I share your suspicions. If you uncover even the slightest evidence that the family is plotting against me, I want to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`

### Węzeł `[594]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're not worried about the Sazons?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]`

### Węzeł `[595]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about my own family? Will you protect me if Hugo tries to usurp me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[596]`
Mówca: **Titus Gordion**
> ""I stand corrected, then. You know better than I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[597]`
Mówca: **Titus Gordion**
> ""I will try to keep a close eye on them with the limited resources the Golden Guard has been given.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[598]`
Mówca: **Titus Gordion**
> ""I doubt they would try another attempt at your life. Not after how badly your kidnapping ended for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[599]`
Mówca: **Titus Gordion**
> ""Usurp, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`

### Węzeł `[600]`
Mówca: **Titus Gordion**
> ""Happy to have your ear, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[601]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'd better not be listening in, either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[602]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Surely you must leave your post at some point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[603]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. That's the correct answer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[604]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And if I *want* you to watch me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[605]`
Mówca: **Titus Gordion**
> ""Certainly not, Your Majesty. Any other questions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[606]`
Mówca: **Titus Gordion**
> ""We keep a tight rotation. Asleep or awake, you will always be protected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[607]`
Mówca: **Titus Gordion**
> ""I, uh... do you have any other questions, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[608]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == false && RiziaDLC.Security_ValeroPoisoningTalk_Happened == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]`
  - -> `[610]`

### Węzeł `[609]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == false && RiziaDLC.Security_ValeroPoisoningTalk_Happened == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation"] == false  and  Variable["RiziaDLC.Security_ValeroPoisoningTalk_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[610]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == false && RiziaDLC.Security_ValeroPoisoningTalk_Happened == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation"] == false  and  Variable["RiziaDLC.Security_ValeroPoisoningTalk_Happened"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[611]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]`
  - -> `[613]`

### Węzeł `[612]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[613]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[614]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_GGHub2_Threats == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`
  - -> `[616]`

### Węzeł `[615]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_GGHub2_Threats == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_Threats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[616]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_GGHub2_Threats == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_GGHub2_Threats"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[617]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_GGHub2_Threats = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_Threats"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]`

### Węzeł `[618]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]`

### Węzeł `[619]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]`

### Węzeł `[620]`
Mówca: **Narrator**
> "Hugo paused and scrutinized me for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`

### Węzeł `[621]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`
  - -> `[623]`

### Węzeł `[622]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]`

### Węzeł `[623]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_GGHub2_MurderInvestigation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]`

### Węzeł `[624]`
Mówca: **Hugo Toras**
> ""A murder investigation, Your Majesty? Is there something you'd like to tell me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]`
  - -> `[638]`
  - -> `[639]`

### Węzeł `[625]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]`
  - -> `[627]`

### Węzeł `[626]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]`

### Węzeł `[627]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_GGHub2_AlwaysWatched"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[628]`
Mówca: **Narrator**
> "Hugo paused and scrutinized me for a second."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]`

### Węzeł `[629]`
Mówca: **Hugo Toras**
> ""'Intimate moments'? I wasn't aware you were seeing someone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]`
  - -> `[631]`
  - -> `[632]`

### Węzeł `[630]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not right now, but anything could happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]`

### Węzeł `[631]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nobody you need to know about, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]`

### Węzeł `[632]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even a king's got to polish the crown jewels every once in a while, you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]`

### Węzeł `[633]`
Mówca: **Hugo Toras**
> ""Any union that could result in children is of great relevance to our house, Your Majesty. I hope you exercise caution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[634]`
Mówca: **Hugo Toras**
> ""I see. Do be mindful that any union that could result in children is of great importance to our house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[635]`
Mówca: **Narrator**
> "Hugo reddened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`

### Węzeł `[636]`
Mówca: **Hugo Toras**
> ""Understood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[637]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As I said, I was asking hypothetically.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]`

### Węzeł `[638]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suspect Father may have died of something other than natural causes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[639]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. I'm on the hunt for whoever killed your sense of humor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]`

### Węzeł `[640]`
Mówca: **Hugo Toras**
> ""Ha.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[641]`
Mówca: **Narrator**
> "He drew back in mild surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[642]`
Mówca: **Hugo Toras**
> ""My brother was very ill. He barely recognized me during his last hours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`

### Węzeł `[643]`
Mówca: **Hugo Toras**
> ""You're free to deploy the Golden Guard however you want, of course. But there are better uses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[644]`
Mówca: **Hugo Toras**
> ""Very well. I was only wondering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[645]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`
  - -> `[647]`

### Węzeł `[646]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[647]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]`

### Węzeł `[648]`
Mówca: **Narrator**
> "The captain smiled patiently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[649]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]`
  - -> `[651]`

### Węzeł `[650]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[651]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[652]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[653]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[654]`
Mówca: **Titus Gordion**
> ""Never in my life would I expect such an upstanding member of House Toras to turn on his own family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`

### Węzeł `[655]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Artifact_Armor_TorasArmor = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Artifact_Armor_TorasArmor"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[656]`
Mówca: **Titus Gordion**
> ""Is there anything else you're curious about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[657]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That would be great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]`

### Węzeł `[658]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What year are we in? Not necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[659]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Artifact_Sword_TeradorsFury = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Artifact_Sword_TeradorsFury"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`

### Węzeł `[660]`
Mówca: **Narrator**
> "As the two men circled each other, we observed their careful dance before they engaged in combat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[661]`
Mówca: **Titus Gordion**
> ""Upon the foundation of the Kingdom of Rizia, they assumed control over the entire province of Valenqiris.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[662]`
Mówca: **Titus Gordion**
> ""Lined with spikes on the inside, it was designed to inflict excruciating pain when closed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[663]`
Mówca: **Titus Gordion**
> ""On the other hand, his son Ricardus and his nationalist associates could prove troublesome. But they're in Brenas, far out of my jurisdiction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[664]`
Mówca: **Titus Gordion**
> ""A long time ago, yes. But it was more to do with public relations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[665]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`
  - -> `[667]`

### Węzeł `[666]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]`

### Węzeł `[667]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_Turn02_SecurityTitus_MentionBoxingBackground"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[668]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, yes. You mentioned something about your boxing days. You fared well, I assume?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[669]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'll have to teach me how to fight like that sometime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[670]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`
  - -> `[672]`

### Węzeł `[671]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]`

### Węzeł `[672]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]`

### Węzeł `[673]`
Mówca: **Titus Gordion**
> ""Nothing you haven't already learned from the Rizian Armed Forces, I'm sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[674]`
Mówca: **Titus Gordion**
> ""If I do my job correctly, you'll never need to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[675]`
Mówca: **Titus Gordion**
> ""But enough tomfoolery. I know you must be very busy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]`

### Węzeł `[676]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hypothetically, could it still be used today?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`

### Węzeł `[677]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Tyrant += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]`

### Węzeł `[678]`
Mówca: **Titus Gordion**
> ""I don't see why not. However, much more sophisticated enhanced interrogation methods have arisen in the meantime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`

### Węzeł `[679]`
Mówca: **Titus Gordion**
> ""Are you seriously interested in obtaining a suit of armor, Your Majesty? I'm sure we could arrange something if you were.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`
  - -> `[460]`
  - -> `[462]`

### Węzeł `[680]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`
  - -> `[682]`

### Węzeł `[681]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[682]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`

### Węzeł `[683]`
Mówca: **Narrator**
> "Titus laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[684]`
Mówca: **Hugo Toras**
> ""Pour me a glass as well, then. I wouldn't want to spoil the mood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[685]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Such a crude sport. I prefer hunting. It allows you to keep a gentlemanly distance between you and your target.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`

### Węzeł `[686]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]`
  - -> `[688]`

### Węzeł `[687]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Summer_Hugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Summer_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]`

### Węzeł `[688]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Summer_Hugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Summer_Hugo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[689]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you're good at hand-to-hand combat. But my enemies will come at me with long-range rifles, not boxing gloves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[690]`
Mówca: **Titus Gordion**
> ""I'm well trained in the art of firearms as well, Your Majesty. I was hand-recruited to benefit from the highest-level instruction at Camp Domus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[691]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`
  - -> `[693]`

### Węzeł `[692]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedSuOmina == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]`

### Węzeł `[693]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedSuOmina == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedSuOmina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]`

### Węzeł `[694]`
Mówca: **Titus Gordion**
> ""But of course I will alert you immediately should I witness any suspicious behavior.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[695]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I feel like I've heard enough of the past for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]`

### Węzeł `[696]`
Mówca: **Titus Gordion**
> ""Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`

### Węzeł `[697]`
Mówca: **Hugo Toras**
> ""Indeed, you're right. However, Romus, have you noticed that the blade appears somewhat tarnished?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[698]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]`
  - -> `[700]`

### Węzeł `[699]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]`

### Węzeł `[700]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_SecurityTitus_HugoPresent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[701]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_GGHub2_FightInWar == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]`
  - -> `[703]`

### Węzeł `[702]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_GGHub2_FightInWar == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_FightInWar"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`

### Węzeł `[703]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_GGHub2_FightInWar == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_GGHub2_FightInWar"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[704]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would the Golden Guard aid our military if a war broke out?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`

### Węzeł `[705]`
Mówca: **Narrator**
> "Titus saluted reflexively."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`

### Węzeł `[706]`
Mówca: **Titus Gordion**
> ""Certainly, Your Majesty. Some suspect that the Golden Guard's secret involvement helped your ancestor Ariana Toras' army win the War of Rizian Succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]`

### Węzeł `[707]`
Mówca: **Titus Gordion**
> ""With our current numbers, however, I fear we would not be of much use.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]`

### Węzeł `[708]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_FunnyKing += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]`

### Węzeł `[709]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our professional relationship requires honesty. I will tell you straight away that I don't drink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]`

### Węzeł `[710]`
Mówca: **Titus Gordion**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]`

### Węzeł `[711]`
Mówca: **Narrator**
> "He withdrew the proffered bottle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]`

### Węzeł `[712]`
Mówca: **Titus Gordion**
> ""Thank you for letting me know. To be honest, I hardly drink myself -- I just keep wine around for royal visits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[713]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_GGHub2_FightInWar = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_GGHub2_FightInWar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`

### Węzeł `[714]`
Mówca: **Hugo Toras**
> ""I didn't know you were a connoisseur, Captain. I'll have a glass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`
  - -> `[224]`

### Węzeł `[715]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[548]`
  - -> `[545]`

### Węzeł `[716]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]`
  - -> `[718]`

### Węzeł `[717]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]`

### Węzeł `[718]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[719]`
Mówca: **Hugo Toras**
> ""It's early, Captain. Perhaps we should all abstain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`
  - -> `[542]`
  - -> `[552]`
  - -> `[225]`

### Węzeł `[720]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]`
  - -> `[722]`

### Węzeł `[721]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Monqiz_PartyPrince == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[722]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Monqiz_PartyPrince == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[723]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`
  - -> `[725]`

### Węzeł `[724]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]`

### Węzeł `[725]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_SoberKing == true && RiziaDLC.PersonalValues_FellOffWagon == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true  and  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[726]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValues_FellOffWagon = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValues_FellOffWagon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]`

### Węzeł `[727]`
Mówca: **Narrator**
> "It was the first taste of alcohol I'd had in years. Savoring its bouquet, I wondered why I'd stopped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[728]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Meeting with the King’s Secret Service", "Palace Rezna", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Meeting with the King’s Secret Service","Palace Rezna","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
