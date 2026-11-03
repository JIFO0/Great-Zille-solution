# Sordland/Turn09/Personal_PetrFuneral

- **ID konwersacji:** `187`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/187_Personal_PetrFuneral.md`
- **Liczba węzłów dialogowych:** 146
- **Liczba wyborów gracza:** 39

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[20]** Deana
- **[28]** Evelyn Vectern
- **[54]** Serge Wolkner

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral`
- `BaseGame.Decision_Turn09_PetrFuneral_StateFuneral`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Turn07_Personal_FrancConscripted`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameSupport.News_Turn09_HP_Petr_PrivateFuneral`
- `BaseGameSupport.News_Turn09_HP_Petr_StateFuneral`
- `BaseGameSupport.News_Turn09_R_Petr_StateFuneral`
- `GameCondition.Turn09_Personal_PetrFuneral`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 3
- **Węzły modyfikujące stan gry:** 7

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[90]` (Lucian Galade): `Variable["GameCondition.Turn09_Personal_PetrFuneral"] = true;`
- Węzeł `[127]` (Lucian Galade): `Variable["BaseGameSupport.News_Turn09_HP_Petr_StateFuneral"] = true;`
- Węzeł `[134]` (Lucian Galade): `Variable["BaseGameSupport.News_Turn09_HP_Petr_PrivateFuneral"] = true;`
- Węzeł `[142]` (Lucian Galade): `Variable["BaseGameSupport.News_Turn09_R_Petr_StateFuneral"] = true;`
- Węzeł `[143]` (Lucian Galade): `DisableCollectionItem("CollectionItem_WhiskeyBottle");`
- Węzeł `[144]` (Lucian Galade): `UpdateCharacterTitle("Evelyn Vectern","Former Second Lady");`
- Węzeł `[145]` (Lucian Galade): `End();`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[94]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Our convoy pulled up to the gates of the Public Cemetery in Erlory -- Petr's hometown. Monica and Deana were beside me in the car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Monica looked numb and empty. Deana appeared to be deep in thought."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[5]`
Mówca: **Deana**
> "“But how did Uncle Petr die? Why won't anyone tell me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "“He killed himself, Deana.""]** — Mówca: **Player**
> "“He killed himself, Deana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[7]`
Mówca: **Monica**
> "“He...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Monica looked like she was about to cry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[9]`
Mówca: **Monica**
> "“It doesn't matter, sweetheart.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Narrator**
> "She turned her head to look out the window, hiding her tears."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`
  - -> `[117]`

### Węzeł `[11]`
Mówca: **Deana**
> "“Papa? Tell me the truth!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[12]`
  - -> `[6]`

### Węzeł `[12]`
**[WYBÓR GRACZA: ""He... fell. It was an accident.""]** — Mówca: **Player**
> ""He... fell. It was an accident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“You will understand when you are older.”"]** — Mówca: **Player**
> "“You will understand when you are older.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[14]`
Mówca: **Deana**
> "“But... but why?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[15]`
Mówca: **Deana**
> "“Like when I fall off my bike?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[16]`
Mówca: **Deana**
> "“That's not fair. I'm almost 12.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[17]`
Mówca: **Monica**
> "“Anton! She is still too young.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[18]`
**[WYBÓR GRACZA: ""I can't sugar-coat reality for her forever, Monica.""]** — Mówca: **Player**
> ""I can't sugar-coat reality for her forever, Monica.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "“Your mother is right, Deana. Sorry.”"]** — Mówca: **Player**
> "“Your mother is right, Deana. Sorry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[20]`
Mówca: **Monica**
> "“It's better to remember Uncle Petr by the way he lived, not by the way he died.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[18]`
  - -> `[21]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "Do not reply."]** — Mówca: **Player_Italic**
> "I did not reply. Deana looked as confused as she had before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
Mówca: **Monica**
> ""No, honey. Nothing like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Serge Wolkner**
> "“We have arrived, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[24]`
Mówca: **Narrator**
> "The driver's window rolled down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[25]`
Mówca: **Narrator**
> "Serge went outside and opened our door. As soon as we stepped out, camera flashes went off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Narrator**
> "Evelyn Vectern was waiting for us. Upon seeing her, Monica ran up to her and they hugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Monica**
> "“Evelyn. I'm so sorry. How are you holding up?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Evelyn Vectern**
> "“So-so. It's hard to play the bereaved widow, knowing the kind of man he really was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Evelyn Vectern**
> "“But still. We were married almost 20 years, Monica.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Narrator**
> "They hugged once again. Evelyn wiped her tears and patted Deana on the head before turning to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[36]`
  - -> `[33]`

### Węzeł `[31]`
Mówca: **Evelyn Vectern**
> "“And the way he died...It's just too...sudden.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "“My condolences.”"]** — Mówca: **Player**
> "“My condolences.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "Hug her."]** — Mówca: **Player_Italic**
> "I hugged her. She took my hands in hers as she pulled back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Evelyn Vectern**
> "“Thank you, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Evelyn Vectern**
> "“I know there's nothing either of us could have done. But I still can't help feeling responsible for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[108]`
  - -> `[107]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“I can't believe he's gone.”"]** — Mówca: **Player**
> "“I can't believe he's gone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[37]`
Mówca: **Evelyn Vectern**
> "“All right. Let's go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[38]`
Mówca: **Narrator**
> "The four of us -- Evelyn, Monica, Deana and I -- took our places towards the front of the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Narrator**
> "From afar, we heard the sound of military boots approaching. A soldier was leading a group with a large framed photo of Petr in his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Narrator**
> "Behind him followed other soldiers, marching alongside a cart with a carved goat on the front."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Narrator**
> "On top of the cart, wrapped in a Sordish flag, was the coffin of Petr Vectern. The Fourth Vice President of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Narrator**
> "The group stopped in front of us. They lifted the coffin up off the cart and laid it down on a platform."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Narrator**
> "One of the soldiers took the flag, folded it and presented it to me. I walked behind the podium to deliver my speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[44]`
Mówca: **Narrator**
> "The crowd was sparse -- Petr hadn't had many friends left by the end. His father and brothers lifted the coffin on their shoulders and brought it to the grave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Narrator**
> "The priest completed his ceremony. It was time for me to make a speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Today, we mourn Petr Vectern. The Fourth Vice President of Sordland and...”"]** — Mówca: **Player**
> "“Today, we mourn Petr Vectern. The Fourth Vice President of Sordland and...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`
  - -> `[49]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "“...a true Sord who strived to achieve the best for his country against all odds.”"]** — Mówca: **Player**
> "“...a true Sord who strived to achieve the best for his country against all odds.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`
  - -> `[50]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "“...a very successful statesman with whom I worked very closely over many years.""]** — Mówca: **Player**
> "“...a very successful statesman with whom I worked very closely over many years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`
  - -> `[50]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "“...my brother. Our bond was not a bond of blood. It was something stronger. It was a bond of friendship and camaraderie.”"]** — Mówca: **Player**
> "“...my brother. Our bond was not a bond of blood. It was something stronger. It was a bond of friendship and camaraderie.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`
  - -> `[50]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "“He was there with me from the very beginning. He swore he would support our cause until the end.”"]** — Mówca: **Player**
> "“He was there with me from the very beginning. He swore he would support our cause until the end.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[53]`
  - -> `[55]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“God's word says no man can be perfect. And Petr was certainly no exception.”"]** — Mówca: **Player**
> "“God's word says no man can be perfect. And Petr was certainly no exception.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[53]`
  - -> `[55]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "“We drank together. Cried together. Laughed together. Fought together.”"]** — Mówca: **Player**
> "“We drank together. Cried together. Laughed together. Fought together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[53]`
  - -> `[55]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "“Though we did not always see eye to eye, I owe Petr everything. I wouldn't be President if not for him.”"]** — Mówca: **Player**
> "“Though we did not always see eye to eye, I owe Petr everything. I wouldn't be President if not for him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[56]`
  - -> `[57]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "“Despite his unconscionable actions towards the very end of his life, I choose to remember him as he was.”"]** — Mówca: **Player**
> "“Despite his unconscionable actions towards the very end of his life, I choose to remember him as he was.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[56]`
  - -> `[57]`

### Węzeł `[55]`
**[WYBÓR GRACZA: "“We must all remember him not at his worst, but for the good deeds he has done.""]** — Mówca: **Player**
> "“We must all remember him not at his worst, but for the good deeds he has done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "“The path he paved will go down in history.”"]** — Mówca: **Player**
> "“The path he paved will go down in history.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[59]`
  - -> `[60]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "“Never before Sordland had a Vice President like Petr. Never again will it.""]** — Mówca: **Player**
> "“Never before Sordland had a Vice President like Petr. Never again will it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[59]`
  - -> `[60]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "“The past is past. We must always look to the future. That's what he would've wanted.”"]** — Mówca: **Player**
> "“The past is past. We must always look to the future. That's what he would've wanted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Farewell brother. You will be missed.”"]** — Mówca: **Player**
> "“Farewell brother. You will be missed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "“Morning shall come!”"]** — Mówca: **Player**
> "“Morning shall come!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Narrator**
> "Everyone in the crowd yelled: "Victory is close!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Narrator**
> "Amid the applause, I went back to join Monica and Deana."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Narrator**
> "As I walked past Evelyn, she mouthed the words: "Thank you"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[68]`
Mówca: **Narrator**
> "Trumpets cut through the silence. Stern-looking soldiers formed a line and held their rifles in front."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Narrator**
> "One after another, ten shots rang out. With each shot, I shuddered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[70]`
Mówca: **Narrator**
> "I felt a tug on my left arm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[71]`
Mówca: **Narrator**
> "The priest's voice cut through the silence. Everyone joined in the prayer he was chanting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Narrator**
> "Looking at the coffin, I shuddered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Narrator**
> "The coffin started to be lowered into the grave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Deana**
> "“Are you crying?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[75]`
Mówca: **Narrator**
> "I had known Petr for almost 30 years. The time we spent together flashed back before my eyes. The good memories and bad ones. All of it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[76]`
Mówca: **Narrator**
> "It didn't matter anymore. He was gone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[77]`
Mówca: **Narrator**
> "Surprised, I checked my face. My eyes were wet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`
  - -> `[80]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "“It's raining.”"]** — Mówca: **Player**
> "“It's raining.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "“Yes.”"]** — Mówca: **Player**
> "“Yes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "“No, I'm not.”"]** — Mówca: **Player**
> "“No, I'm not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[81]`
Mówca: **Narrator**
> "She looked up to the sky."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Deana**
> "“Papa, it's not raini-.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Monica**
> "“Come on Deana. Let's go.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Narrator**
> "She hugged my leg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[85]`
Mówca: **Narrator**
> "The coffin was fully lowered and the tombstone placed. The crowd began dispersing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
**[WYBÓR GRACZA: "Leave a bottle of whiskey on the grave."]** — Mówca: **Player_Italic**
> "I left a bottle on the grave. Erlory 30-year-old. His favorite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "Leave."]** — Mówca: **Player_Italic**
> "I left as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[88]`
Mówca: **Narrator**
> "I stayed there by myself for another half hour."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[89]`
Mówca: **Narrator**
> "The sun finally set after painting the sky blood red."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn09_Personal_PetrFuneral = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn09_Personal_PetrFuneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[91]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[93]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[94]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[96]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[97]`
Mówca: **Narrator**
> "Our convoy pulled up to the gates of the National Cemetery in Erlorly -- Petr's hometown. Monica and Deana were beside me in the car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Narrator**
> "The news of Petr's death had hit Franc especially hard. Rather than attend the funeral, he had taken a few days off from school to have time to himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[99]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_FrancConscripted == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_FrancConscripted == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_FrancConscripted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[102]`
Mówca: **Narrator**
> "The news of Petr's death had hit Franc especially hard. Rather than attend the funeral, he had taken a few days of personal leave from the army to have time to himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[103]`
Mówca: **Serge Wolkner**
> ""My deepest condolences. I know you and Mr. Vectern were very close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`
  - -> `[104]`

### Węzeł `[104]`
**[WYBÓR GRACZA: ""Thank you, Serge.""]** — Mówca: **Player**
> ""Thank you, Serge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[105]`
**[WYBÓR GRACZA: ""We weren't at the end.""]** — Mówca: **Player**
> ""We weren't at the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""You're right. We were.""]** — Mówca: **Player**
> ""You're right. We were.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""I know what you mean.""]** — Mówca: **Player**
> ""I know what you mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[108]`
**[WYBÓR GRACZA: ""It's not your fault, Evelyn.""]** — Mówca: **Player**
> ""It's not your fault, Evelyn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[109]`
**[WYBÓR GRACZA: ""You shouldn't feel guilty. And neither should I.""]** — Mówca: **Player**
> ""You shouldn't feel guilty. And neither should I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Narrator**
> "Evelyn swallowed hard. Her eyes filled with resolve."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[111]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[114]`
Mówca: **Narrator**
> "It didn't matter anymore. He was gone. Because of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "Hug Monica."]** — Mówca: **Player_Italic**
> "I reached over to give Monica a hug."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "Hug Deana."]** — Mówca: **Player_Italic**
> "I wrapped an arm around my daughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[117]`
**[WYBÓR GRACZA: "Don't do anything."]** — Mówca: **Player_Italic**
> "I sat there, silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[118]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion < 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Opinion < 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Narrator**
> "She recoiled at my touch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[122]`
Mówca: **Narrator**
> "She hugged me back tightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[123]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[125]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Narrator**
> "The four of us -- Evelyn, Monica, Deana and I -- took our places in front of the Vectern family plot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[127]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn09_HP_Petr_StateFuneral = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Petr_StateFuneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[128]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[130]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[134]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn09_HP_Petr_PrivateFuneral = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_Petr_PrivateFuneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[135]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true && BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true && BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true  and  Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true && BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true  and  Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[138]`
Mówca: **Narrator**
> "The sun finally set after painting the sky blood red."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[139]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[141]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn09_R_Petr_StateFuneral = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn09_R_Petr_StateFuneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[143]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: DisableCollectionItem("CollectionItem_WhiskeyBottle"))*
- **Efekt (`userScript`):** `DisableCollectionItem("CollectionItem_WhiskeyBottle");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[144]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Evelyn Vectern", "Former Second Lady");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Evelyn Vectern","Former Second Lady");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[145]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
