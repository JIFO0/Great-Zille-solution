# Rizia/Turn 10/STRIKE SCENE/STRIKE SCENE Conversation

- **ID konwersacji:** `555`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/555_STRIKE_SCENE_Conversation.md`
- **Liczba węzłów dialogowych:** 196
- **Liczba wyborów gracza:** 38

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[72]** Leona Sazon
- **[73]** Lucita Azaro
- **[75]** Manus Sazon
- **[79]** Vina Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[98]** Angelica Sazon
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_AbdicationPath`
- `RiziaDLC.BirthdayGathering_Invited_Angelica`
- `RiziaDLC.BirthdayGathering_Invited_Manus`
- `RiziaDLC.BirthdayGathering_Invited_Vina`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon`
- `RiziaDLC.BirthdayGathering_ViolentAction`
- `RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff`
- `RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC`
- `RiziaDLC.BirthdayGathering_ViolentAction_Success`
- `RiziaDLC.Birthday_WarnedAboutCoup`
- `RiziaDLC.DiscussedFestiburu`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.PromiseToAbdicate`
- `RiziaDLC.Reform_Movement_Grows`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_TyrantKing`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Birthday_Adarfo_Usurped`
- `RiziaDLC.Panel_RoyalDecrees`
- `RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoStrike`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[350] Rizia/Turn 10/Birthday_Gathering** (../Turn_10/350_Birthday_Gathering.md), Węzeł `[169]`
- Węzeł `[4]` -> **[563] Rizia/Turn 10/STRIKE SCENE/PRE-STRIKE ABSOLUTIST KING SPEECH/PRE-STRIKE ABSOLUTIST KING SPEECH Conversation** (../Turn_10/563_PRE-STRIKE_ABSOLUTIST_KING_SPEECH_Conversation.md), Węzeł `[1]`
- Węzeł `[44]` -> **[558] Rizia/Turn 10/STRIKE SCENE/INTRO_ABDICATION/ABOLISHMENT/INTRO_ABDICATION/ABOLISHMENT Conversation** (../Turn_10/558_ABOLISHMENT_Conversation.md), Węzeł `[1]`
- Węzeł `[45]` -> **[557] Rizia/Turn 10/STRIKE SCENE/INTRO_REFORM/INTRO_REFORM Conversation** (../Turn_10/557_INTRO_REFORM_Conversation.md), Węzeł `[1]`
- Węzeł `[60]` -> **[566] Rizia/Turn 10/STRIKE SCENE/HOUSE STRIKE FAIL/HOUSE STRIKE FAIL Conversation** (../Turn_10/566_HOUSE_STRIKE_FAIL_Conversation.md), Węzeł `[1]`
- Węzeł `[65]` -> **[559] Rizia/Turn 10/STRIKE SCENE/ABSOLUTIST STRIKE SCENE/ABSOLUTIST STRIKE SCENE Conversation** (../Turn_10/559_ABSOLUTIST_STRIKE_SCENE_Conversation.md), Węzeł `[1]`
- Węzeł `[134]` -> **[564] Rizia/Turn 10/STRIKE SCENE/RustyReformSuccess/RustyReformSuccess Conversation** (../Turn_10/564_RustyReformSuccess_Conversation.md), Węzeł `[1]`
- Węzeł `[152]` -> **[565] Rizia/Turn 10/STRIKE SCENE/REVOLUTIONARIES SUCCESS BRANCH/REVOLUTIONARIES SUCCESS BRANCH Conversation** (../Turn_10/565_REVOLUTIONARIES_SUCCESS_BRANCH_Conversation.md), Węzeł `[1]`
- Węzeł `[188]` -> **[556] Rizia/Turn 10/STRIKE SCENE/INTRO_NONREFORM/INTRO_NONREFORM Conversation** (../Turn_10/556_INTRO_NONREFORM_Conversation.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **""Betrayal has its consequences.""** | `[138]` **Angelica Sazon**: ""Good God! Is that... gunfire?!""<br>`[142]` **Manus Sazon**: "Who’s shooting?! Why is there gu..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true` | `PlaySoundEffect("Explosion");`<br>`-- REFORM/REVOLUTION;`<br>*(+1 skryptów)* | `[85]` **Player_Romus**: ""Ladies and gentlemen, heads of ..."<br>`[83]` **Player_Romus**: ""I hate to spoil the fun, but it..."<br>*(oraz 1 innych odgałęzień)* |
| `[8]` | **""Surprise!""** | `[138]` **Angelica Sazon**: ""Good God! Is that... gunfire?!""<br>`[142]` **Manus Sazon**: "Who’s shooting?! Why is there gu..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | `PlaySoundEffect("Explosion");`<br>`-- REFORM/REVOLUTION;`<br>*(+1 skryptów)* | `[85]` **Player_Romus**: ""Ladies and gentlemen, heads of ..."<br>`[83]` **Player_Romus**: ""I hate to spoil the fun, but it..."<br>*(oraz 1 innych odgałęzień)* |
| `[9]` | **""Choices are the architecture of fate.""** | `[138]` **Angelica Sazon**: ""Good God! Is that... gunfire?!""<br>`[142]` **Manus Sazon**: "Who’s shooting?! Why is there gu..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("Explosion");`<br>`-- REFORM/REVOLUTION;`<br>*(+1 skryptów)* | `[85]` **Player_Romus**: ""Ladies and gentlemen, heads of ..."<br>`[83]` **Player_Romus**: ""I hate to spoil the fun, but it..."<br>*(oraz 1 innych odgałęzień)* |
| `[10]` | **""Please remain seated.""** | `[138]` **Angelica Sazon**: ""Good God! Is that... gunfire?!""<br>`[142]` **Manus Sazon**: "Who’s shooting?! Why is there gu..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("Explosion");`<br>`-- REFORM/REVOLUTION;`<br>*(+1 skryptów)* | `[85]` **Player_Romus**: ""Ladies and gentlemen, heads of ..."<br>`[83]` **Player_Romus**: ""I hate to spoil the fun, but it..."<br>*(oraz 1 innych odgałęzień)* |
| `[15]` | **""The bell has been rung, and its sound cannot be unstruck.""** | `[138]` **Angelica Sazon**: ""Good God! Is that... gunfire?!""<br>`[142]` **Manus Sazon**: "Who’s shooting?! Why is there gu..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("Explosion");`<br>`-- REFORM/REVOLUTION;`<br>*(+1 skryptów)* | `[85]` **Player_Romus**: ""Ladies and gentlemen, heads of ..."<br>`[83]` **Player_Romus**: ""I hate to spoil the fun, but it..."<br>*(oraz 1 innych odgałęzień)* |
| `[20]` | **"Raise your glass. [Signal for attack]"** | `[26]` **Narrator**: "I locked eyes with Titus and gav..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Narrator**: "It was subtle, but it was enough." |
| `[22]` | **""To my mother, Queen Estela, and to the future of Rizia!" [Signal for attack]"** | `[26]` **Narrator**: "I locked eyes with Titus and gav..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Narrator**: "I raised my glass." |
| `[56]` | **""I thought you might say that.""** | `[46]` **Narrator**: "I let out a long sigh."<br>`[47]` **Narrator**: "I locked eyes with one of Adarfo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Daria De Rava");`<br>`PlayLoopedMusic("R_Traitor","R_Traitor_Loop");` | `[5]` **Narrator**: "And that’s when we heard it -- a..."<br>`[62]` **Narrator**: "And that’s when it began." |
| `[57]` | **""Well, it was worth a try.""** | `[46]` **Narrator**: "I let out a long sigh."<br>`[47]` **Narrator**: "I locked eyes with one of Adarfo..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Daria De Rava");`<br>`PlayLoopedMusic("R_Traitor","R_Traitor_Loop");` | `[5]` **Narrator**: "And that’s when we heard it -- a..."<br>`[62]` **Narrator**: "And that’s when it began." |
| `[58]` | **""How unfortunate. For you.""** | `[46]` **Narrator**: "I let out a long sigh."<br>`[48]` **Narrator**: "I locked eyes with one of Adarfo..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Daria De Rava");`<br>`PlayLoopedMusic("R_Traitor","R_Traitor_Loop");` | `[5]` **Narrator**: "And that’s when we heard it -- a..."<br>`[62]` **Narrator**: "And that’s when it began." |
| `[72]` | **"Watch in silence."** | `[138]` **Angelica Sazon**: ""Good God! Is that... gunfire?!""<br>`[142]` **Manus Sazon**: "Who’s shooting?! Why is there gu..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("Explosion");`<br>`-- REFORM/REVOLUTION;`<br>*(+1 skryptów)* | `[85]` **Player_Romus**: ""Ladies and gentlemen, heads of ..."<br>`[83]` **Player_Romus**: ""I hate to spoil the fun, but it..."<br>*(oraz 1 innych odgałęzień)* |
| `[76]` | **""I gave you a peaceful way out of this.""** | `[138]` **Angelica Sazon**: ""Good God! Is that... gunfire?!""<br>`[142]` **Manus Sazon**: "Who’s shooting?! Why is there gu..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Reform_Path"] == true` | `PlaySoundEffect("Explosion");`<br>`-- REFORM/REVOLUTION;`<br>*(+1 skryptów)* | `[85]` **Player_Romus**: ""Ladies and gentlemen, heads of ..."<br>`[83]` **Player_Romus**: ""I hate to spoil the fun, but it..."<br>*(oraz 1 innych odgałęzień)* |
| `[83]` | **""I hate to spoil the fun, but it's time I had a talk with my fellow royal houses. ..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Narrator**: "There was a brief pause, followe..." |
| `[84]` | **""There's one renovation that hasn't been unveiled yet -- the new trophy room. Woul..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Narrator**: "There was a brief pause, followe..." |
| `[85]` | **""Ladies and gentlemen, heads of each House, I ask that you join me in private for ..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Narrator**: "There was a brief pause, followe..." |
| `[86]` | **""Enough with the pleasantries. I need the leaders of each house to come with me. N..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Narrator**: "There was a brief pause, followe..." |
| `[91]` | **""Nothing to concern yourself over, dear. I need you to stay here and entertain you..."** | `[90]` **Vina Toras**: ""Is something wrong, Father?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Narrator**: "A flash of disappointment crosse..." |
| `[94]` | **""Enjoy your birthday, Mother.""** | `[92]` **Estela Toras**: ""It seems I'm not invited either..."<br>`[108]` **Estela Toras**: ""I see. So I'm not invited, then.""<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Estela Toras**: ""I'd enjoy it a lot more if I kn..." |
| `[95]` | **""I’ll update you later when the time is right.""** | `[92]` **Estela Toras**: ""It seems I'm not invited either..."<br>`[108]` **Estela Toras**: ""I see. So I'm not invited, then.""<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Estela Toras**: ""How convenient. Well, somebody'..." |
| `[96]` | **""You’re not missing anything you'd want to see, believe me.""** | `[92]` **Estela Toras**: ""It seems I'm not invited either..."<br>`[108]` **Estela Toras**: ""I see. So I'm not invited, then.""<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Estela Toras**: ""If you say so, but that sounds ..." |
| `[97]` | **""Don't worry. I'll fill you in later.""** | `[90]` **Vina Toras**: ""Is something wrong, Father?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Narrator**: "She tilted her head in annoyance." |
| `[103]` | **""Just getting the festiburu hung up. You'll have the first swing after Grandmother..."** | `[90]` **Vina Toras**: ""Is something wrong, Father?"" | `Variable["RiziaDLC.DiscussedFestiburu"] == true` | *Brak zmian stanu* | `[107]` **Narrator**: "She tilted her head in annoyance." |
| `[111]` | **""I’m simply handling something that requires my immediate attention, that's all.""** | `[102]` **Estela Toras**: ""What are you up to, Romus?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Estela Toras**: ""How conveniently cryptic."" |
| `[113]` | **""Nothing to concern yourself over, Mother. We'll be back out before you know it.""** | `[102]` **Estela Toras**: ""What are you up to, Romus?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Estela Toras**: ""So I'm not invited, then."" |
| `[114]` | **""Up to? Nothing in the slightest. Just a little... royal housekeeping.""** | `[102]` **Estela Toras**: ""What are you up to, Romus?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Estela Toras**: ""I see. So I'm not invited, then."" |
| `[119]` | **""Just getting the festiburu hung up. You'll have the first swing, of course.""** | `[102]` **Estela Toras**: ""What are you up to, Romus?"" | `Variable["RiziaDLC.DiscussedFestiburu"] == true` | *Brak zmian stanu* | `[110]` **Estela Toras**: ""I don't recall ordering a festi..." |
| `[124]` | **""Change, mother. Change will happen.""** | `[102]` **Estela Toras**: ""What are you up to, Romus?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Estela Toras**: ""How conveniently cryptic."" |
| `[125]` | **""Quite the opposite. I'm about to convince the houses to finally listen to the peo..."** | `[90]` **Vina Toras**: ""Is something wrong, Father?"" | `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true` | *Brak zmian stanu* | `[107]` **Narrator**: "She tilted her head in annoyance." |
| `[129]` | **""No, Vina. I need to talk to them about something you'll surely approve of. Just t..."** | `[90]` **Vina Toras**: ""Is something wrong, Father?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Narrator**: "She tilted her head in annoyance." |
| `[130]` | **""I'll talk to you in a bit.""** | `[92]` **Estela Toras**: ""It seems I'm not invited either..."<br>`[108]` **Estela Toras**: ""I see. So I'm not invited, then.""<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Narrator**: "I kissed Mother on the cheek bef..." |
| `[163]` | **""All will be revealed. Just walk this way.""** | `[162]` **Lucita Azaro**: ""Romus, is there something you h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Lucita Azaro**: ""All right, Your Majesty. I trus..." |
| `[164]` | **""Whatever happens next, I want you to know that I love you.""** | `[162]` **Lucita Azaro**: ""Romus, is there something you h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Lucita Azaro**: ""I love you too, but..."" |
| `[165]` | **""Keep your father from doing anything stupid. That's all I ask of you.""** | `[162]` **Lucita Azaro**: ""Romus, is there something you h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Lucita Azaro**: ""I don't like the sound of that ..." |
| `[166]` | **""It's just a routine check-in with the houses. Why would I need to tell you about ..."** | `[162]` **Lucita Azaro**: ""Romus, is there something you h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Lucita Azaro**: ""As an Azaro and your wife, I'd ..." |
| `[172]` | **""All will be revealed. Just keep the wine flowing out here.""** | `[171]` **Pabel Adria**: ""Something you haven't been tell..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Pabel Adria**: ""I'll do what I can."" |
| `[173]` | **""Whatever happens next, I want you to know that I love you.""** | `[171]` **Pabel Adria**: ""Something you haven't been tell..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Pabel Adria**: ""I love you too, But please don'..." |
| `[174]` | **""This is all part of what we talked about. Soon, we'll be able to be together.""** | `[171]` **Pabel Adria**: ""Something you haven't been tell..." | `Variable["RiziaDLC.PromiseToAbdicate"] == true` | *Brak zmian stanu* | `[187]` **Pabel Adria**: ""Just don't do anything rash. Pl..." |
| `[175]` | **""It's just a routine check-in with the houses. Why would I need to tell you about ..."** | `[171]` **Pabel Adria**: ""Something you haven't been tell..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Pabel Adria**: ""Sure. Whatever you say..."" |

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
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Adarfo_AbdicationPath == true || RiziaDLC.Refor..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "I locked eyes with Titus and gave him the smallest of nods. Understanding, he moved with practiced silence, positioning himself by the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "And that’s when we heard it -- a piercing scream from the library, followed by a series of loud bangs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("BallGunshot");"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Everyone turned toward the noise, their faces drained of color."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Betrayal has its consequences.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true`
- **Kontekst wejściowy (poprzednik):** `[138]` (Angelica Sazon), `[142]` (Manus Sazon), `[143]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Success == false"*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Surprise!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[138]` (Angelica Sazon), `[142]` (Manus Sazon), `[143]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Success == false"*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Choices are the architecture of fate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Angelica Sazon), `[142]` (Manus Sazon), `[143]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Success == false"*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please remain seated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Angelica Sazon), `[142]` (Manus Sazon), `[143]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Success == false"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ITS_A_TRAP_hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Daria De Rava");"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player_Romus: ""Surprise!""*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The bell has been rung, and its sound cannot be unstruck.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Angelica Sazon), `[142]` (Manus Sazon), `[143]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Success == false"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_WarnedAboutCoup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_WarnedAboutCoup == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Birthday_WarnedAboutCoup == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_WarnedAboutCoup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Romus: ""Betrayal has its consequences.""*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Birthday_WarnedAboutCoup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[10]` (*Player_Romus: ""Please remain seated.""*)
  - -> `[72]` (*Player_Romus_Italic: "Watch in silence."*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_WarnedAboutCoup == true"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true"*)
  - -> `[9]` (*Player_Romus: ""Choices are the architecture of fate.""*)
  - -> `[15]` (*Player_Romus: ""The bell has been rung, and its sound cannot be unstruck.""*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "Raise your glass. [Signal for attack]"]** — Mówca: **Player_Romus_Italic**
> "I grabbed my glass and held it up high."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "It was subtle, but it was enough."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "It was subtle, but it was enough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "As we lifted our glasses, the doors clicked shut."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: ""To my mother, Queen Estela, and to the future of Rizia!" [Signal for attack]"]** — Mówca: **Player_Romus**
> ""To my mother, Queen Estela, and to the future of Rizia!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "I raised my glass."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "I raised my glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "It was subtle, but it was enough."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "As we lifted our glasses, the doors clicked shut."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "Jump to: [ITS_A_TRAP_hub]"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RaiseAToast_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "I locked eyes with Titus and gave him the smallest of nod..."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "I locked eyes with Titus and gave him the smallest of nods. Understanding, he moved with practiced silence, positioning himself by the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus: ""To my mother, Queen Estela, and to the future of Rizia!"..."*)
  - -> `[20]` (*Player_Romus_Italic: "Raise your glass. [Signal for attack]"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ITS_A_TRAP_hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "ITS_A_TRAP_hub"*)

### Węzeł `[28]`
Mówca: **Narrator**
> "I locked eyes with Titus and gave him the smallest of nods. Understanding, he moved with practiced silence, positioning himself by the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "Jump to: [ITS_A_TRAP_hub]"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGua..."*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenG..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "I locked eyes with Titus and gave him the smallest of nod..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC ..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC ..."*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPM..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "Jump to: [ITS_A_TRAP_hub]"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenSta..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "I locked eyes with one of Adarfo's men, who was disguised as a server, and gave him the smallest of nods."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "Jump to: [ITS_A_TRAP_hub]"*)

### Węzeł `[36]`
Mówca: **Narrator**
> "I locked eyes with one of Adarfo's men who was already inside the room, blending in with the security guards. I gave him the smallest of nods."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "Jump to: [ITS_A_TRAP_hub]"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenSta..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenS..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "I locked eyes with one of Adarfo's men, who was disguised..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityP..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityP..."*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_Securit..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "I locked eyes with one of Adarfo's men who was already in..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "Jump to: [ITS_A_TRAP_hub]"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_AbdicationPath == true)"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_AbdicationPath == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[46]`
Mówca: **Narrator**
> "I let out a long sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""I thought you might say that.""*)
  - -> `[57]` (*Player_Romus: ""Well, it was worth a try.""*)
  - -> `[58]` (*Player_Romus: ""How unfortunate. For you.""*)

### Węzeł `[47]`
Mówca: **Narrator**
> "I locked eyes with one of Adarfo's men, who was disguised as a server, and gave him the smallest of nods."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""I thought you might say that.""*)
  - -> `[57]` (*Player_Romus: ""Well, it was worth a try.""*)

### Węzeł `[48]`
Mówca: **Narrator**
> "I locked eyes with one of Adarfo's men who was already inside the room, blending in with the security guards. I gave him the smallest of nods."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""I thought you might say that.""*)
  - -> `[57]` (*Player_Romus: ""Well, it was worth a try.""*)
  - -> `[58]` (*Player_Romus: ""How unfortunate. For you.""*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenSta..."*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenS..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "I locked eyes with one of Adarfo's men, who was disguised..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityP..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityP..."*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_Securit..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "I locked eyes with one of Adarfo's men who was already in..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_SecurityPlansObtained"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "I let out a long sigh."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ITS_A_TRAP_hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "ITS_A_TRAP_hub"*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thought you might say that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator), `[47]` (Narrator), `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "Jump to: [ITS_A_TRAP_hub]"*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, it was worth a try.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator), `[47]` (Narrator), `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "Jump to: [ITS_A_TRAP_hub]"*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How unfortunate. For you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator), `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "Jump to: [ITS_A_TRAP_hub]"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Success == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Success == false"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Success == false)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Success == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Success == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true"*)

### Węzeł `[62]`
Mówca: **Narrator**
> "And that’s when it began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Success == false"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true"*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Path == true)"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true"*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_AbdicationPath == true)"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AbdicationPath == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AbdicationPath"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Explosion");"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_AbdicationPath == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true && RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosR..."*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfo..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true && RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "And that’s when we heard it -- a piercing scream from the..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true && RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "And that’s when it began."*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "Watch in silence."]** — Mówca: **Player_Romus_Italic**
> "I watched in silence."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Angelica Sazon), `[142]` (Manus Sazon), `[143]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Success == false"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Path == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player_Romus: ""I gave you a peaceful way out of this.""*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I gave you a peaceful way out of this.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[138]` (Angelica Sazon), `[142]` (Manus Sazon), `[143]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Success == false"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// REFORM/REVOLUTION`
- **Efekt skryptowy (`userScript`):** `-- REFORM/REVOLUTION;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[85]` (*Player_Romus: ""Ladies and gentlemen, heads of each House, I ask that yo..."*)
  - -> `[83]` (*Player_Romus: ""I hate to spoil the fun, but it's time I had a talk with..."*)
  - -> `[84]` (*Player_Romus: ""There's one renovation that hasn't been unveiled yet -- ..."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "There was a brief pause, followed by a subtle exchange of glances."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)

### Węzeł `[79]`
Mówca: **Narrator**
> "With a rustling of formalwear, the other Torases and the heads of House Sazon and House Azaro got up and followed me into the trophy room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "Several catering staff were already present, moving brisk..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Vina == true)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Vina Toras: ""Is something wrong, Father?""*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Estela Toras: ""What are you up to, Romus?""*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hate to spoil the fun, but it's time I had a talk with my fellow royal houses. Please come to the trophy room.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "There was a brief pause, followed by a subtle exchange of..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's one renovation that hasn't been unveiled yet -- the new trophy room. Would the leaders of each house be so kind as to follow me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "There was a brief pause, followed by a subtle exchange of..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ladies and gentlemen, heads of each House, I ask that you join me in private for a brief discussion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "There was a brief pause, followed by a subtle exchange of..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough with the pleasantries. I need the leaders of each house to come with me. Now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "There was a brief pause, followed by a subtle exchange of..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player_Romus: ""Enough with the pleasantries. I need the leaders of each..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[90]`
Mówca: **Vina Toras**
> ""Is something wrong, Father?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[129]` (*Player_Romus: ""No, Vina. I need to talk to them about something you'll ..."*)
  - -> `[97]` (*Player_Romus: ""Don't worry. I'll fill you in later.""*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedFestiburu == true"*)
  - -> `[91]` (*Player_Romus: ""Nothing to concern yourself over, dear. I need you to st..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing to concern yourself over, dear. I need you to stay here and entertain your grandmother.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "A flash of disappointment crossed Vina's face."*)

### Węzeł `[92]`
Mówca: **Estela Toras**
> ""It seems I'm not invited either, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Romus: ""You’re not missing anything you'd want to see, believe me.""*)
  - -> `[95]` (*Player_Romus: ""I’ll update you later when the time is right.""*)
  - -> `[94]` (*Player_Romus: ""Enjoy your birthday, Mother.""*)
  - -> `[130]` (*Player_Romus: ""I'll talk to you in a bit.""*)

### Węzeł `[93]`
Mówca: **Narrator**
> "A flash of disappointment crossed Vina's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Estela Toras: ""It seems I'm not invited either, then.""*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enjoy your birthday, Mother.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Estela Toras), `[108]` (Estela Toras), `[110]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Estela Toras: ""I'd enjoy it a lot more if I knew what mischief my son w..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’ll update you later when the time is right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Estela Toras), `[108]` (Estela Toras), `[110]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Estela Toras: ""How convenient. Well, somebody's got to keep the lesser ..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You’re not missing anything you'd want to see, believe me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Estela Toras), `[108]` (Estela Toras), `[110]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Estela Toras: ""If you say so, but that sounds rather ominous.""*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. I'll fill you in later.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "She tilted her head in annoyance."*)

### Węzeł `[98]`
Mówca: **Estela Toras**
> ""If you say so, but that sounds rather ominous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "I kissed Mother on the cheek before stepping away."*)

### Węzeł `[99]`
Mówca: **Estela Toras**
> ""How convenient. Well, somebody's got to keep the lesser nobles entertained during your secret chat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "I kissed Mother on the cheek before stepping away."*)

### Węzeł `[100]`
Mówca: **Estela Toras**
> ""I'd enjoy it a lot more if I knew what mischief my son was planning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "I kissed Mother on the cheek before stepping away."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "I kissed Mother on the cheek before stepping away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Estela Toras");"*)

### Węzeł `[102]`
Mówca: **Estela Toras**
> ""What are you up to, Romus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player_Romus: ""Nothing to concern yourself over, Mother. We'll be back ..."*)
  - -> `[114]` (*Player_Romus: ""Up to? Nothing in the slightest. Just a little... royal ..."*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedFestiburu == true"*)
  - -> `[111]` (*Player_Romus: ""I’m simply handling something that requires my immediate..."*)
  - -> `[124]` (*Player_Romus: ""Change, mother. Change will happen.""*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just getting the festiburu hung up. You'll have the first swing after Grandmother, of course.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.DiscussedFestiburu"] == true`
- **Kontekst wejściowy (poprzednik):** `[90]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "She tilted her head in annoyance."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DiscussedFestiburu == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedFestiburu == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.DiscussedFestiburu == true)"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DiscussedFestiburu == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.DiscussedFestiburu"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player_Romus: ""Just getting the festiburu hung up. You'll have the firs..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.DiscussedFestiburu == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.DiscussedFestiburu"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[107]`
Mówca: **Narrator**
> "She tilted her head in annoyance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Vina Toras: ""So I'm not invited. Got it.""*)

### Węzeł `[108]`
Mówca: **Estela Toras**
> ""I see. So I'm not invited, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Romus: ""You’re not missing anything you'd want to see, believe me.""*)
  - -> `[95]` (*Player_Romus: ""I’ll update you later when the time is right.""*)
  - -> `[94]` (*Player_Romus: ""Enjoy your birthday, Mother.""*)
  - -> `[130]` (*Player_Romus: ""I'll talk to you in a bit.""*)

### Węzeł `[109]`
Mówca: **Vina Toras**
> ""So I'm not invited. Got it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Estela Toras: ""It seems I'm not invited either, then.""*)

### Węzeł `[110]`
Mówca: **Estela Toras**
> ""I don't recall ordering a festiburu. What's really going on, darling?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Romus: ""You’re not missing anything you'd want to see, believe me.""*)
  - -> `[95]` (*Player_Romus: ""I’ll update you later when the time is right.""*)
  - -> `[94]` (*Player_Romus: ""Enjoy your birthday, Mother.""*)
  - -> `[130]` (*Player_Romus: ""I'll talk to you in a bit.""*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’m simply handling something that requires my immediate attention, that's all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Estela Toras: ""How conveniently cryptic.""*)

### Węzeł `[112]`
Mówca: **Estela Toras**
> ""How conveniently cryptic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Romus: ""You’re not missing anything you'd want to see, believe me.""*)
  - -> `[95]` (*Player_Romus: ""I’ll update you later when the time is right.""*)
  - -> `[94]` (*Player_Romus: ""Enjoy your birthday, Mother.""*)
  - -> `[130]` (*Player_Romus: ""I'll talk to you in a bit.""*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing to concern yourself over, Mother. We'll be back out before you know it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Estela Toras: ""So I'm not invited, then.""*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Up to? Nothing in the slightest. Just a little... royal housekeeping.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Estela Toras: ""I see. So I'm not invited, then.""*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DiscussedFestiburu == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.DiscussedFestiburu == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.DiscussedFestiburu == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.DiscussedFestiburu == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.DiscussedFestiburu"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player_Romus: ""Just getting the festiburu hung up. You'll have the firs..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.DiscussedFestiburu == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.DiscussedFestiburu"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[118]`
Mówca: **Estela Toras**
> ""So I'm not invited, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Romus: ""You’re not missing anything you'd want to see, believe me.""*)
  - -> `[95]` (*Player_Romus: ""I’ll update you later when the time is right.""*)
  - -> `[94]` (*Player_Romus: ""Enjoy your birthday, Mother.""*)
  - -> `[130]` (*Player_Romus: ""I'll talk to you in a bit.""*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just getting the festiburu hung up. You'll have the first swing, of course.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.DiscussedFestiburu"] == true`
- **Kontekst wejściowy (poprzednik):** `[102]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Estela Toras: ""I don't recall ordering a festiburu. What's really going..."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "Several catering staff were already present, moving briskly to rearrange chairs and set out refreshments."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Adarfo_AbdicationPath == true || RiziaDLC.Reform_Path == true) && RiziaDLC.BirthdayGathering_ViolentAction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Adarfo_AbdicationPath == true || RiziaDLC.Refor..."*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Adarfo_AbdicationPath == true || RiziaDLC.Ref..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Adarfo_AbdicationPath == true || RiziaDLC.Reform_Path == true) && RiziaDLC.BirthdayGathering_ViolentAction == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AbdicationPath"] == true  or  Variable["RiziaDLC.Reform_Path"] == true)  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "// REFORM/REVOLUTION"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Adarfo_AbdicationPath == true || RiziaDLC.Reform_Path == true) && RiziaDLC.BirthdayGathering_ViolentAction == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Adarfo_AbdicationPath"] == true  or  Variable["RiziaDLC.Reform_Path"] == true)  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");"*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Change, mother. Change will happen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Estela Toras: ""How conveniently cryptic.""*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Quite the opposite. I'm about to convince the houses to finally listen to the people's demands.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Kontekst wejściowy (poprzednik):** `[90]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "She tilted her head in annoyance."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player_Romus: ""Quite the opposite. I'm about to convince the houses to ..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Vina. I need to talk to them about something you'll surely approve of. Just trust me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "She tilted her head in annoyance."*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll talk to you in a bit.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Estela Toras), `[108]` (Estela Toras), `[110]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "I kissed Mother on the cheek before stepping away."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [ITS_A_TRAP_hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "ITS_A_TRAP_hub"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRe..."*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_Adarfos..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Explosion");"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosRevolutionaries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == t..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Invited_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Angelica Sazon: ""Good God! Is that... gunfire?!""*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Invited_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)

### Węzeł `[138]`
Mówca: **Angelica Sazon**
> ""Good God! Is that... gunfire?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == tru..."*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == t..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Invited_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Manus Sazon: "Who’s shooting?! Why is there gunfire?!""*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Invited_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Invited_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Leona Sazon: ""Oh my God! Is that gunfire?!""*)

### Węzeł `[142]`
Mówca: **Manus Sazon**
> "Who’s shooting?! Why is there gunfire?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[143]`
Mówca: **Leona Sazon**
> ""Oh my God! Is that gunfire?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[144]`
Mówca: **Narrator**
> "At that precise moment, the man concealed behind Titus' guards sprang into action, swiftly disarming one of them and hurling a smoke grenade with a loud bang."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "The sound of glass shattering rang through the room as ar..."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "The sound of glass shattering rang through the room as armed men entered through broken windows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoStrike = true;"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenSta..."*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenS..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "The catering staff, who had been moving quietly among the..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "At that precise moment, the man concealed behind Titus' g..."*)

### Węzeł `[149]`
Mówca: **Narrator**
> "The catering staff, who had been moving quietly among the nobles in the trophy room, pulled out weapons from beneath platters, aprons, and serving trays."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "Others, concealed in the shadows and alcoves of the room,..."*)

### Węzeł `[150]`
Mówca: **Narrator**
> "Others, concealed in the shadows and alcoves of the room, sprang into action, attacking the Golden Guard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoStrike = true;"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoStrike = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Birthday_AdarfoStrike"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Estela Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Estela Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Invited_Vina == true"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Invited_Vina == true)"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Invited_Vina == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras");"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Invited_Vina == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Invited_Vina"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "With a rustling of formalwear, the other Torases and the ..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Vina Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "With a rustling of formalwear, the other Torases and the ..."*)

### Węzeł `[158]`
Mówca: **Narrator**
> "My wife rose from her seat warily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Lucita Azaro: ""Romus, is there something you haven't been telling me?""*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "My wife rose from her seat warily."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[162]`
Mówca: **Lucita Azaro**
> ""Romus, is there something you haven't been telling me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player_Romus: ""All will be revealed. Just walk this way.""*)
  - -> `[164]` (*Player_Romus: ""Whatever happens next, I want you to know that I love you.""*)
  - -> `[165]` (*Player_Romus: ""Keep your father from doing anything stupid. That's all ..."*)
  - -> `[166]` (*Player_Romus: ""It's just a routine check-in with the houses. Why would ..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All will be revealed. Just walk this way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Lucita Azaro: ""All right, Your Majesty. I trust you.""*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whatever happens next, I want you to know that I love you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Lucita Azaro: ""I love you too, but...""*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep your father from doing anything stupid. That's all I ask of you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Lucita Azaro: ""I don't like the sound of that at all...""*)

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's just a routine check-in with the houses. Why would I need to tell you about that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Lucita Azaro: ""As an Azaro and your wife, I'd say I deserve to be fille..."*)

### Węzeł `[167]`
Mówca: **Narrator**
> "As I crossed the room, Pabel intercepted me. He kept a forced smile on his face as he spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Pabel Adria: ""Something you haven't been telling me, Rom?""*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "As I crossed the room, Pabel intercepted me. He kept a fo..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Estela Toras");"*)

### Węzeł `[171]`
Mówca: **Pabel Adria**
> ""Something you haven't been telling me, Rom?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player_Romus: ""All will be revealed. Just keep the wine flowing out here.""*)
  - -> `[173]` (*Player_Romus: ""Whatever happens next, I want you to know that I love you.""*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PromiseToAbdicate == true"*)
  - -> `[175]` (*Player_Romus: ""It's just a routine check-in with the houses. Why would ..."*)

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All will be revealed. Just keep the wine flowing out here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Pabel Adria: ""I'll do what I can.""*)

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whatever happens next, I want you to know that I love you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Pabel Adria: ""I love you too, But please don't do anything rash.""*)

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is all part of what we talked about. Soon, we'll be able to be together.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PromiseToAbdicate"] == true`
- **Kontekst wejściowy (poprzednik):** `[171]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Pabel Adria: ""Just don't do anything rash. Please.""*)

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's just a routine check-in with the houses. Why would I need to tell you about that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Pabel Adria: ""Sure. Whatever you say...""*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PromiseToAbdicate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PromiseToAbdicate == true"*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PromiseToAbdicate == true)"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PromiseToAbdicate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PromiseToAbdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player_Romus: ""This is all part of what we talked about. Soon, we'll be..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PromiseToAbdicate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PromiseToAbdicate"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[179]`
Mówca: **Pabel Adria**
> ""Sure. Whatever you say...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Estela Toras");"*)

### Węzeł `[180]`
Mówca: **Lucita Azaro**
> ""As an Azaro and your wife, I'd say I deserve to be filled in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Estela Toras");"*)

### Węzeł `[181]`
Mówca: **Lucita Azaro**
> ""I don't like the sound of that at all...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "As she walked into the room, her hand instinctively wande..."*)

### Węzeł `[182]`
Mówca: **Lucita Azaro**
> ""I love you too, but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "As she walked into the room, her hand instinctively wande..."*)

### Węzeł `[183]`
Mówca: **Lucita Azaro**
> ""All right, Your Majesty. I trust you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Estela Toras");"*)

### Węzeł `[184]`
Mówca: **Narrator**
> "As she walked into the room, her hand instinctively wandered towards the holster where I knew she kept her dagger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Estela Toras");"*)

### Węzeł `[185]`
Mówca: **Pabel Adria**
> ""I'll do what I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Estela Toras");"*)

### Węzeł `[186]`
Mówca: **Pabel Adria**
> ""I love you too, But please don't do anything rash.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Estela Toras");"*)

### Węzeł `[187]`
Mówca: **Pabel Adria**
> ""Just don't do anything rash. Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Estela Toras");"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Crisis","R_Crisis_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Crisis", "R_Crisis_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Crisis","R_Crisis_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AbdicationPath == true"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Traitor", "R_Traitor_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Traitor","R_Traitor_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.BirthdayGathering_ViolentAction_Deploy_AdarfosR..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("BallGunshot");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("BallGunshot");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Everyone turned toward the noise, their faces drained of ..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Explosion");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Explosion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction_Adarfo_HiddenSta..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_Adarfo_Usurped = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Birthday_Adarfo_Usurped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Panel_RoyalDecrees = false"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EvaluateConditionalInstruction("AbsolutistStrikeFallout");`
- **Efekt skryptowy (`userScript`):** `EvaluateConditionalInstruction("AbsolutistStrikeFallout");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Panel_RoyalDecrees = false`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Panel_RoyalDecrees"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Daria De Rava");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Daria De Rava");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Traitor", "R_Traitor_Loop");"*)
