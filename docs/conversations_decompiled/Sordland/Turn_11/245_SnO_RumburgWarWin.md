# Sordland/Turn11/SnO_RumburgWarWin

- **ID konwersacji:** `245`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Sordland/Turn_11/245_SnO_RumburgWarWin.md`
- **Liczba węzłów dialogowych:** 292
- **Liczba wyborów gracza:** 31

---

## 1. Uczestnicy Sceny

- **[3]** Patricio Alvarez
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[17]** Wiktor Smolak
- **[18]** Maartin Van Hoorten
- **[26]** Emmerich Hegel
- **[49]** Beatrice Livingston

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Agnolia_Alliance`
- `BaseGame.Joined_ATO`
- `BaseGame.Joined_CSP`
- `BaseGame.Lespia_Alliance`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.RumburgIncident_DeclareWar`
- `BaseGame.Rumburg_AlliesCalledToWar`
- `BaseGame.Situation_Law_BludishReconciliation`
- `BaseGame.Turn04_SnO_LE_Interior_Decreased`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGame.Turn07_Personal_University_Home_Public`
- `BaseGame.Turn10_SnO_FrancPulledToHolsord`
- `BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh`
- `BaseGame.Turn10_SnO_Phase1_Pincer`
- `BaseGame.Turn10_SnO_Phase2_TakeDome`
- `BaseGame.Valgsland_Alliance`
- `BaseGame.Wehlen_JointOperation`
- `BaseGame.Wehlen_PeaceConference`
- `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton`
- `BaseGameIsolated.Turn10_SnO_Deivid_JoinMeeting`
- `BaseGameIsolated.Turn10_SnO_Soll_JoinMeeting`
- `BaseGameIsolated.Turn11_SnO_Letter`
- `BaseGameIsolated.Turn11_SnO_Newspaper`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Ending_ElectionSpeech`
- `BaseGame.Shown_MiddleFinger_ToQueen`
- `BaseGameIsolated.Turn11_SnO_Letter`
- `BaseGameIsolated.Turn11_SnO_Newspaper`
- `GameCondition.Turn11_SnO_RumburgWarWin`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[11]` | **"Kiss her hand."** | `[10]` **Narrator**: "She put her hand forward." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "We entered the train cabin where..." |
| `[12]` | **"Shake her hand."** | `[10]` **Narrator**: "She put her hand forward." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "We entered the train cabin where..." |
| `[13]` | **"Gesture towards the wagon."** | `[10]` **Narrator**: "She put her hand forward." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "We entered the train cabin where..." |
| `[14]` | **"“What's wrong with being out in nature?""** | `[15]` **Beatrice Livingston**: "“You couldn't have chosen a bett..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Beatrice Livingston**: "“Don't take me for a fool, Mr. R..." |
| `[16]` | **"“You are here to sign your capitulation. You will meet me wherever I please.”"** | `[15]` **Beatrice Livingston**: "“You couldn't have chosen a bett..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Beatrice Livingston**: "“Hah. Such vulgarity. Barbarians..." |
| `[18]` | **"“Shut up. I don't want to spend any more time than I need with you.”"** | `[15]` **Beatrice Livingston**: "“You couldn't have chosen a bett..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Beatrice Livingston**: "“Hah. Such vulgarity. Barbarians..." |
| `[24]` | **"“Of course not. This is a simple coincidence. That's all.”"** | `[23]` **Beatrice Livingston**: "“You really are trying to humili..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Beatrice Livingston**: "“You're not only a barbarian, yo..." |
| `[26]` | **"“Ms. Livingston, you are forgetting the protocol. I expect you to say please first.”"** | `[25]` **Beatrice Livingston**: "“Give me the bloody papers. I ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Beatrice Livingston**: "“Oh, come on. Such childish beha..." |
| `[27]` | **"“You are not being a good loser, Ms. Livingston.”"** | `[38]` **Beatrice Livingston**: "“There you go. Are you quite sat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Beatrice Livingston**: "“I'm sure you would act the same..." |
| `[29]` | **"“Yes, I am. So what? What can you do without your country, Queen of Rumburg?”"** | `[23]` **Beatrice Livingston**: "“You really are trying to humili..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Narrator**: "She struggled to come up with a ..." |
| `[30]` | **"“Let's just get to the signing.""** | `[23]` **Beatrice Livingston**: "“You really are trying to humili..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Beatrice Livingston**: "“Give me the bloody papers. I ca..." |
| `[32]` | **"Hand her the papers."** | `[25]` **Beatrice Livingston**: "“Give me the bloody papers. I ca..."<br>`[33]` **Beatrice Livingston**: "“Oh, come on. Such childish beha..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[281]` **Narrator**: "She laid out the treaty and bega..." |
| `[34]` | **"“I said, say please.”"** | `[33]` **Beatrice Livingston**: "“Oh, come on. Such childish beha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Narrator**: "She paused for a second and glar..." |
| `[39]` | **"“Yes, I am happy.”"** | `[38]` **Beatrice Livingston**: "“There you go. Are you quite sat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Beatrice Livingston**: "“I hereby proclaim that you can ..." |
| `[42]` | **"“I don't want to see your face again.”"** | `[38]` **Beatrice Livingston**: "“There you go. Are you quite sat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Beatrice Livingston**: "“Rest assured, you will not.”" |
| `[44]` | **"“Before you go, there is one more thing.”"** | `[40]` **Beatrice Livingston**: "“I'm sure you would act the same..."<br>`[41]` **Beatrice Livingston**: "“I hereby proclaim that you can ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Beatrice Livingston**: "“What is it?”" |
| `[46]` | **"“Don't ever forget who your Suzerain is.”"** | `[45]` **Beatrice Livingston**: "“What is it?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Beatrice Livingston**: "“Oh, trust me...”" |
| `[56]` | **"Read the newspaper."** | `[53]` **Narrator**: "An assistant knocked sharply, th..."<br>`[80]` **Narrator**: "I put down the paper to take a s..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] == false` | *Brak zmian stanu* | `[54]` **Narrator**: "The first thing I saw was the he..." |
| `[57]` | **"Open the letter."** | `[53]` **Narrator**: "An assistant knocked sharply, th..."<br>`[80]` **Narrator**: "I put down the paper to take a s..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGameIsolated.Turn11_SnO_Letter"] == false` | *Brak zmian stanu* | `[81]` **Narrator**: "I recognized Franc's handwriting..." |
| `[125]` | **"“Please accept this pen as a reminder of this historic occasion.""** | `[45]` **Beatrice Livingston**: "“What is it?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Beatrice Livingston**: "“Oh, trust me...”" |
| `[193]` | **"“Ms. Livingston, it seems you are not fully comprehending the situation. I am not ..."** | `[192]` **Beatrice Livingston**: ""You want our two major cities i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Beatrice Livingston**: ""I will remember this, Rumburg w..." |
| `[194]` | **""Ms. Livingston, would you rather we continue to march toward Thornbourgh so that ..."** | `[192]` **Beatrice Livingston**: ""You want our two major cities i..." | `Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true` | *Brak zmian stanu* | `[200]` **Beatrice Livingston**: ""I will remember this, Rumburg w..." |
| `[195]` | **""I don't think you are in any position to negotiate.""** | `[192]` **Beatrice Livingston**: ""You want our two major cities i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Beatrice Livingston**: ""I will remember this, Rumburg w..." |
| `[199]` | **""Ms. Livingston, I can replace you with someone else and have that person sign the..."** | `[192]` **Beatrice Livingston**: ""You want our two major cities i..." | `(Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true) == false` | *Brak zmian stanu* | `[200]` **Beatrice Livingston**: ""I will remember this, Rumburg w..." |
| `[244]` | **""I don't think you are in any position to negotiate.""** | `[259]` **Beatrice Livingston**: ""Do you realize what this will d..."<br>`[243]` **Beatrice Livingston**: ""You want to destroy Rumburg wit..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Lespia_Alliance"] == true) == false`<br>`(Variable["BaseGame.Valgsland_Alliance"] == true) == false` | *Brak zmian stanu* | `[250]` **Beatrice Livingston**: ""I will remember this. Rumburg w..." |
| `[245]` | **"“Ms. Livingston, it seems you do not fully comprehend the situation. We are not as..."** | `[259]` **Beatrice Livingston**: ""Do you realize what this will d..."<br>`[243]` **Beatrice Livingston**: ""You want to destroy Rumburg wit..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Lespia_Alliance"] == true) == false`<br>`(Variable["BaseGame.Valgsland_Alliance"] == true) == false` | *Brak zmian stanu* | `[250]` **Beatrice Livingston**: ""I will remember this. Rumburg w..." |
| `[246]` | **""Ms. Livingston, would you rather we continue our march towards Thornbourgh so tha..."** | `[259]` **Beatrice Livingston**: ""Do you realize what this will d..."<br>`[243]` **Beatrice Livingston**: ""You want to destroy Rumburg wit..." | `Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true`<br>`(Variable["BaseGame.Lespia_Alliance"] == true) == false` | *Brak zmian stanu* | `[250]` **Beatrice Livingston**: ""I will remember this. Rumburg w..." |
| `[251]` | **""Ms. Livingston, we can always replace you with someone else and have that person ..."** | `[259]` **Beatrice Livingston**: ""Do you realize what this will d..."<br>`[243]` **Beatrice Livingston**: ""You want to destroy Rumburg wit..." | `(Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true) == false`<br>`(Variable["BaseGame.Lespia_Alliance"] == true) == false` | *Brak zmian stanu* | `[250]` **Beatrice Livingston**: ""I will remember this. Rumburg w..." |
| `[269]` | **"Give her the middle finger."** | `[45]` **Beatrice Livingston**: "“What is it?”" | `Variable["BaseGameIsolated.Turn11_SnO_Letter"] == true` | *Brak zmian stanu* | `[270]` **Player**: ""That's from my son.""<br>`[271]` **Player**: ""My parting gift from Sordland."" |
| `[270]` | **""That's from my son.""** | `[269]` **Player_Italic**: "I raised my middle finger in the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Beatrice Livingston**: ""Well, I never..."" |
| `[271]` | **""My parting gift from Sordland.""** | `[269]` **Player_Italic**: "I raised my middle finger in the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Beatrice Livingston**: ""Well, I never..."" |

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
  - -> `[52]` (*Narrator: "My cabin rocked gently as the Maroon Train sped through t..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "With a final whistle, the Maroon Train came to a stop in the middle of the Forest of October."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Lespia_Alliance == true ||  BaseGame.Agnolia_Al..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "I opened the window to look outside. The air was cool and I enjoyed the smell of nature for a brief moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("TrainWhistle");"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "I straightened my jacket as she approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Beatrice Livingston: "“Mr. Rayne.”"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "With a haughty sniff, she turned around and left the wagon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ElectionSpeech = true;"*)

### Węzeł `[7]`
Mówca: **Narrator**
> "A few minutes later, another train pulled in behind ours and stopped with a whistle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "Queen Beatrice stepped out of the front-most wagon."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "She looked much older and more tired than the last time I had seen her. Clearly, the war had taken its toll on her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "I straightened my jacket as she approached."*)

### Węzeł `[9]`
Mówca: **Beatrice Livingston**
> "“Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "She put her hand forward."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "She put her hand forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player_Italic: "Gesture towards the wagon."*)
  - -> `[11]` (*Player_Italic: "Kiss her hand."*)
  - -> `[12]` (*Player_Italic: "Shake her hand."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "Kiss her hand."]** — Mówca: **Player_Italic**
> "I kissed her hand."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "We entered the train cabin where the signing would take p..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "Shake her hand."]** — Mówca: **Player_Italic**
> "We shook hands."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "We entered the train cabin where the signing would take p..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "Gesture towards the wagon."]** — Mówca: **Player_Italic**
> "I gestured towards the wagon."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "We entered the train cabin where the signing would take p..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "“What's wrong with being out in nature?""]** — Mówca: **Player**
> "“What's wrong with being out in nature?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Beatrice Livingston: "“Don't take me for a fool, Mr. Rayne.”"*)

### Węzeł `[15]`
Mówca: **Beatrice Livingston**
> "“You couldn't have chosen a better location, could you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: "“What's wrong with being out in nature?""*)
  - -> `[16]` (*Player: "“You are here to sign your capitulation. You will meet me..."*)
  - -> `[18]` (*Player: "“Shut up. I don't want to spend any more time than I need..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“You are here to sign your capitulation. You will meet me wherever I please.”"]** — Mówca: **Player**
> "“You are here to sign your capitulation. You will meet me wherever I please.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Beatrice Livingston: "“Hah. Such vulgarity. Barbarians, all of you.”"*)

### Węzeł `[17]`
Mówca: **Beatrice Livingston**
> "“Don't take me for a fool, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Beatrice Livingston: "“As if your victory was not enough, you felt compelled to..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Shut up. I don't want to spend any more time than I need with you.”"]** — Mówca: **Player**
> "“Shut up. I don't want to spend any more time than I need with you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Beatrice Livingston: "“Hah. Such vulgarity. Barbarians, all of you.”"*)

### Węzeł `[19]`
Mówca: **Beatrice Livingston**
> "“Hah. Such vulgarity. Barbarians, all of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Beatrice Livingston: "“As if your victory was not enough, you felt compelled to..."*)

### Węzeł `[20]`
Mówca: **Beatrice Livingston**
> "“As if your victory was not enough, you felt compelled to drag me out to the middle of a forest to cement it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Beatrice Livingston: "“And not just any forest, of course.”"*)

### Węzeł `[21]`
Mówca: **Beatrice Livingston**
> "“And not just any forest, of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Beatrice Livingston: "“This is the same place where the ceasefire was signed fo..."*)

### Węzeł `[22]`
Mówca: **Beatrice Livingston**
> "“This is the same place where the ceasefire was signed for the 15-Day War.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Beatrice Livingston: "“You really are trying to humiliate me, aren't you?”"*)

### Węzeł `[23]`
Mówca: **Beatrice Livingston**
> "“You really are trying to humiliate me, aren't you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: "“Of course not. This is a simple coincidence. That's all.”"*)
  - -> `[29]` (*Player: "“Yes, I am. So what? What can you do without your country..."*)
  - -> `[30]` (*Player: "“Let's just get to the signing.""*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Of course not. This is a simple coincidence. That's all.”"]** — Mówca: **Player**
> "“Of course not. This is a simple coincidence. That's all.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Beatrice Livingston: "“You're not only a barbarian, you're a liar.""*)

### Węzeł `[25]`
Mówca: **Beatrice Livingston**
> "“Give me the bloody papers. I can't stand breathing the same air as you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: "“Ms. Livingston, you are forgetting the protocol. I expec..."*)
  - -> `[32]` (*Player_Italic: "Hand her the papers."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "“Ms. Livingston, you are forgetting the protocol. I expect you to say please first.”"]** — Mówca: **Player**
> "“Ms. Livingston, you are forgetting the protocol. I expect you to say please first.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Beatrice Livingston: "“Oh, come on. Such childish behavior.”"*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“You are not being a good loser, Ms. Livingston.”"]** — Mówca: **Player**
> "“You are not being a good loser, Ms. Livingston.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Beatrice Livingston: "“I'm sure you would act the same way if you were in my pl..."*)

### Węzeł `[28]`
Mówca: **Beatrice Livingston**
> "“You're not only a barbarian, you're a liar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Beatrice Livingston: "“Give me the bloody papers. I can't stand breathing the s..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“Yes, I am. So what? What can you do without your country, Queen of Rumburg?”"]** — Mówca: **Player**
> "“Yes, I am. So what? What can you do without your country, Queen of Rumburg?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "She struggled to come up with a response, then gave up an..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Let's just get to the signing.""]** — Mówca: **Player**
> "“Let's just get to the signing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Beatrice Livingston: "“Give me the bloody papers. I can't stand breathing the s..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "She struggled to come up with a response, then gave up and sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Beatrice Livingston: "“Give me the bloody papers. I can't stand breathing the s..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "Hand her the papers."]** — Mówca: **Player_Italic**
> "I handed her the papers."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Beatrice Livingston), `[33]` (Beatrice Livingston), `[35]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "She laid out the treaty and began to read the document."*)

### Węzeł `[33]`
Mówca: **Beatrice Livingston**
> "“Oh, come on. Such childish behavior.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: "“I said, say please.”"*)
  - -> `[32]` (*Player_Italic: "Hand her the papers."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“I said, say please.”"]** — Mówca: **Player**
> "“I said, say please.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "She paused for a second and glared at me in pure fury."*)

### Węzeł `[35]`
Mówca: **Beatrice Livingston**
> "“Please... hand me the papers, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player_Italic: "Hand her the papers."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "Beatrice angrily scribbled her signature and put down the pen before passing on the document. I signed the agreement and gave it to my assistant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Beatrice Livingston: "“There you go. Are you quite satisfied?”"*)

### Węzeł `[37]`
Mówca: **Narrator**
> "The witnesses were called for the signing of the agreement titled the 'Treaty of Rayne'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "Beatrice angrily scribbled her signature and put down the..."*)

### Węzeł `[38]`
Mówca: **Beatrice Livingston**
> "“There you go. Are you quite satisfied?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: "“Yes, I am happy.”"*)
  - -> `[27]` (*Player: "“You are not being a good loser, Ms. Livingston.”"*)
  - -> `[42]` (*Player: "“I don't want to see your face again.”"*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Yes, I am happy.”"]** — Mówca: **Player**
> "“Yes, I am happy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Beatrice Livingston: "“I hereby proclaim that you can go fuck yourself.""*)

### Węzeł `[40]`
Mówca: **Beatrice Livingston**
> "“I'm sure you would act the same way if you were in my place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: "“Before you go, there is one more thing.”"*)

### Węzeł `[41]`
Mówca: **Beatrice Livingston**
> "“I hereby proclaim that you can go fuck yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: "“Before you go, there is one more thing.”"*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "“I don't want to see your face again.”"]** — Mówca: **Player**
> "“I don't want to see your face again.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Beatrice Livingston: "“Rest assured, you will not.”"*)

### Węzeł `[43]`
Mówca: **Beatrice Livingston**
> "“Rest assured, you will not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: "“Before you go, there is one more thing.”"*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Before you go, there is one more thing.”"]** — Mówca: **Player**
> "“Before you go, there is one more thing.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Beatrice Livingston), `[41]` (Beatrice Livingston), `[43]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Beatrice Livingston: "“What is it?”"*)

### Węzeł `[45]`
Mówca: **Beatrice Livingston**
> "“What is it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: "“Don't ever forget who your Suzerain is.”"*)
  - -> `[125]` (*Player: "“Please accept this pen as a reminder of this historic oc..."*)
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Letter == true"*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Don't ever forget who your Suzerain is.”"]** — Mówca: **Player**
> "“Don't ever forget who your Suzerain is.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Beatrice Livingston: "“Oh, trust me...”"*)

### Węzeł `[47]`
Mówca: **Beatrice Livingston**
> "“I won't forget.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "With a haughty sniff, she turned around and left the wagon."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "She paused for a second and glared at me in pure fury."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Beatrice Livingston: "“Please... hand me the papers, Mr. Rayne.”"*)

### Węzeł `[49]`
Mówca: **Beatrice Livingston**
> "“Oh, trust me...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Beatrice Livingston: "“I won't forget.""*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn11_SnO_RumburgWarWin = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn11_SnO_RumburgWarWin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "DisableToken("Sordland_Event_RumburgWar");"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ElectionSpeech = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Ending_ElectionSpeech"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn11_SnO_RumburgWarWin = true"*)

### Węzeł `[52]`
Mówca: **Narrator**
> "My cabin rocked gently as the Maroon Train sped through the leafy outskirts of Estord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "An assistant knocked sharply, then slid the door open. He..."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "An assistant knocked sharply, then slid the door open. He approached my desk and handed me the day's newspaper and a letter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "Information Hub"*)

### Węzeł `[54]`
Mówca: **Narrator**
> "The first thing I saw was the headline: 'Conqueror Rayne' written in giant letters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "I continued reading."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Information Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Newspaper == false"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Letter == false"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Letter == true && BaseGameIso..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "Read the newspaper."]** — Mówca: **Player_Italic**
> "I took a look at the newspaper."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] == false`
- **Kontekst wejściowy (poprzednik):** `[53]` (Narrator), `[80]` (Narrator), `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "The first thing I saw was the headline: 'Conqueror Rayne'..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "Open the letter."]** — Mówca: **Player_Italic**
> "I opened the letter."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn11_SnO_Letter"] == false`
- **Kontekst wejściowy (poprzednik):** `[53]` (Narrator), `[80]` (Narrator), `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "I recognized Franc's handwriting immediately."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Newspaper == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Newspaper == false"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn11_SnO_Newspaper == false)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Newspaper == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Italic: "Read the newspaper."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn11_SnO_Newspaper == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Letter == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Letter == false"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn11_SnO_Letter == false)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Letter == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Letter"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player_Italic: "Open the letter."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn11_SnO_Letter == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Letter"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Newspaper = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "Jump to: [Information Hub]"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Letter = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_Letter"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "Jump to: [Information Hub]"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Information Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "Information Hub"*)

### Węzeł `[67]`
Mówca: **Narrator**
> "I continued reading."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)

### Węzeł `[68]`
Mówca: **Narrator**
> ""...After the triumphant victory of our soldiers, President Rayne welcomed them back home in Holsord. The entire country has broken out in celebration of Rumburg's defeat...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "I remembered the jubilant welcome ceremony and smiled. I ..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase1_Pincer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase1_Pincer == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_Phase1_Pincer == true)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase1_Pincer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase1_Pincer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: ""...Defense minister Iosef Lancea was the man of the hour..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_Phase1_Pincer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase1_Pincer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true"*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true)"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: ""Defense minister Iosef Lancea was the man of the hour as..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase2_TakeDome == true"*)

### Węzeł `[75]`
Mówca: **Narrator**
> ""...Defense minister Iosef Lancea was the man of the hour as his radical pincer attack plan caught the enemy off guard. Our troops immediately broke their ranks and started marching towards Rumburg's capital...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_SnO_Soll_JoinMeeting == true"*)

### Węzeł `[76]`
Mówca: **Narrator**
> ""Defense minister Iosef Lancea was the man of the hour as his radical plan, in his own words, 'Maradunen Schlium', caught the enemy off guard. Our troops immediately broke their ranks and started marching towards Rumburg's capital...'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_SnO_Soll_JoinMeeting == true"*)

### Węzeł `[77]`
Mówca: **Narrator**
> ""Defense minister Iosef Lancea was the man of the hour as his superior strategies broke the morale of the enemy. Our troops were victorious in their assault and tipped the scales in our favor. Soon after, they were on their way to Rumburg's capital...'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_SnO_Soll_JoinMeeting == true"*)

### Węzeł `[78]`
Mówca: **Narrator**
> ""Experts are still analyzing the particulars of the victory, but there is one fact they agree on: The siege of Thornbourgh was the turning point that drove Rumburg into where they are now. A full and unconditional surrender...'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: ""...President Rayne is currently on his way to sign the c..."*)

### Węzeł `[79]`
Mówca: **Narrator**
> ""...President Rayne is currently on his way to sign the capitulation agreement. The historic moment will be taking place in the exact same location as the signing of the 15-Day War's ceasefire. The Forest of October...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "I put down the paper to take a sip from my coffee."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "I put down the paper to take a sip from my coffee."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Newspaper = true"*)

### Węzeł `[81]`
Mówca: **Narrator**
> "I recognized Franc's handwriting immediately."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: ""Dear Father. I hope this letter finds you well.""*)

### Węzeł `[82]`
Mówca: **Narrator**
> ""Dear Father. I hope this letter finds you well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: ""Is that how you old folks say it? I know I could have ca..."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "'I wanted to congratulate you on our victory against Rumburg. We showed them who they were messing with.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)

### Węzeł `[84]`
Mówca: **Narrator**
> ""Is that how you old folks say it? I know I could have called, but a letter felt more appropriate for the occasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "'I wanted to congratulate you on our victory against Rumb..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_Arcasia == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == t..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_Arcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)

### Węzeł `[88]`
Mówca: **Narrator**
> ""Everyone's talking about the war here in Arcasia. I have to say it feels pretty nice being the son of the commander-in-chief of the winning side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: ""That said... I can't help but think about all the guys w..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Abroad_UnitedContana ..."*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Abroad_UnitedContan..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP == true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Home_Public == true"*)

### Węzeł `[92]`
Mówca: **Narrator**
> ""Everyone's talking about the war here in United Contana. I have to say it feels pretty nice being the son of the commander-in-chief of the winning side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: ""That said... I can't help but think about all the guys w..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Home_Public == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Personal_University_Home_Public == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Personal_University_Home_Public == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Personal_University_Home_Public == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: ""Everyone's talking about the war here at school. I know ..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Personal_University_Home_Public == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_FrancPulledToHolsord == true"*)

### Węzeł `[96]`
Mówca: **Narrator**
> ""Everyone's talking about the war here at school. I know I complain about how hard it is being your son sometimes, but I have to say it feels pretty nice right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: ""That said... I can't help but think about all the guys w..."*)

### Węzeł `[97]`
Mówca: **Narrator**
> ""That said... I can't help but think about all the guys who died. That could've been me over there. Considering how badly I flunked my exams, it probably should've been me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: ""But there's nothing I can do to change any of that now.""*)

### Węzeł `[98]`
Mówca: **Narrator**
> ""But there's nothing I can do to change any of that now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "'All I can ask is this: When you see the Queen, give her ..."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "'All I can ask is this: When you see the Queen, give her a big fat middle finger from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "'Best Regards, Franc Rayne.'"*)

### Węzeł `[100]`
Mówca: **Narrator**
> "'Best Regards, Franc Rayne.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true"*)

### Węzeł `[101]`
Mówca: **Narrator**
> "'P.S.: Mom is fine and Deana might have a boyfriend.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Letter = true"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Letter == true && BaseGameIsolated.Turn11_SnO_Newspaper == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Letter == true && BaseGameIso..."*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn11_SnO_Letter == true && BaseGameI..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Letter == true && BaseGameIsolated.Turn11_SnO_Newspaper == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Letter"] == true  and  Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "Smiling, I shoved the papers to the side of my desk. I he..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn11_SnO_Letter == true && BaseGameIsolated.Turn11_SnO_Newspaper == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Letter"] == true  and  Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[105]`
Mówca: **Narrator**
> "Smiling, I shoved the papers to the side of my desk. I heard another knock on my door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "The assistant let me know that we had almost arrived at o..."*)

### Węzeł `[106]`
Mówca: **Narrator**
> "The assistant let me know that we had almost arrived at our destination."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "I opened the window to look outside. The air was cool and..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "I stepped out of my cabin and exited the wagon to greet my esteemed guests."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Lespia_Alliance == true || 
BaseGame.Agnolia_Alliance == true ||
BaseGame.Valgsland_Alliance == true || BaseGame.Wehlen_JointOperation == true) && BaseGame.Rumburg_AlliesCalledToWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Lespia_Alliance == true ||  BaseGame.Agnolia_Al..."*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Lespia_Alliance == true ||  BaseGame.Agnolia_..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Lespia_Alliance == true || 
BaseGame.Agnolia_Alliance == true ||
BaseGame.Valgsland_Alliance == true || BaseGame.Wehlen_JointOperation == true) && BaseGame.Rumburg_AlliesCalledToWar == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  or  
Variable["BaseGame.Agnolia_Alliance"] == true  or 
Variable["BaseGame.Valgsland_Alliance"] == true  or  Variable["BaseGame.Wehlen_JointOperation"] == true)  and  Variable["BaseGame.Rumburg_AlliesCalledToWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "I stepped out of my cabin and exited the wagon to greet m..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Lespia_Alliance == true || 
BaseGame.Agnolia_Alliance == true ||
BaseGame.Valgsland_Alliance == true || BaseGame.Wehlen_JointOperation == true) && BaseGame.Rumburg_AlliesCalledToWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Lespia_Alliance"] == true  or  
Variable["BaseGame.Agnolia_Alliance"] == true  or 
Variable["BaseGame.Valgsland_Alliance"] == true  or  Variable["BaseGame.Wehlen_JointOperation"] == true)  and  Variable["BaseGame.Rumburg_AlliesCalledToWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "I stepped out of my cabin and exited the wagon to await t..."*)

### Węzeł `[111]`
Mówca: **Narrator**
> "I stepped out of my cabin and exited the wagon to await the Queen of Rumburg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "A few minutes later, another train pulled in behind ours ..."*)

### Węzeł `[112]`
Mówca: **Narrator**
> "Queen Beatrice stepped out of the front-most wagon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "She looked much older and more tired than the last time I..."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "We shook hands and waited in silence for the Queen's arrival."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "A few minutes later, another train pulled in behind ours ..."*)

### Węzeł `[114]`
Mówca: **Narrator**
> "We entered the train cabin where the signing would take place. It was dominated by a polished mahogany writing desk. I took my seat on one side of it; the Queen took hers on the other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Beatrice Livingston: "“You couldn't have chosen a better location, could you?""*)

### Węzeł `[115]`
Mówca: **Narrator**
> ""I can't help but think about all my friends and squadmates on the front lines. I know I'm lucky to be deployed here in Holsord, but part of me wishes I could've fought with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: ""But there's nothing I can do to change any of that now.""*)

### Węzeł `[116]`
Mówca: **Narrator**
> ""Still... I wonder if you and the other bigwigs back in Holsord know the real cost of this war. It's not just that I could've died. It's that some of the things I did make me wish I had.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: ""It's hard for me and the other guys to sleep at night. I..."*)

### Węzeł `[117]`
Mówca: **Narrator**
> ""It's hard for me and the other guys to sleep at night. I can only hope the memories will go away with time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: ""But there's nothing I can do to change any of that now.""*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_FrancPulledToHolsord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_FrancPulledToHolsord == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_FrancPulledToHolsord == true)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_FrancPulledToHolsord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: ""Everyone at Camp Strongarm is talking about the war, obv..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_FrancPulledToHolsord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: ""Still... I wonder if you and the other bigwigs back in H..."*)

### Węzeł `[121]`
Mówca: **Narrator**
> ""Everyone at Camp Strongarm is talking about the war, obviously. And they're talking about me. Not in a good way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: ""I can't help but think about all my friends and squadmat..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "'P.S.: Mom is fine and Deana might have a boyfriend.'"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Letter = true"*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "“Please accept this pen as a reminder of this historic occasion.""]** — Mówca: **Player**
> "“Please accept this pen as a reminder of this historic occasion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Beatrice Livingston: "“Oh, trust me...”"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_ATO == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: ""Everyone's talking about the war here in Arcasia. I have..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_ATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: ""Everyone's talking about the war here in Arcasia. I have..."*)

### Węzeł `[129]`
Mówca: **Narrator**
> ""Everyone's talking about the war here in Arcasia. I have to say it feels pretty nice being part of the winning coalition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: ""That said... I can't help but think about all the guys w..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_CSP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_CSP == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_CSP == true)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_CSP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: ""Everyone's talking about the war here in United Contana...."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_CSP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: ""Everyone's talking about the war here in United Contana...."*)

### Węzeł `[133]`
Mówca: **Narrator**
> ""Everyone's talking about the war here in United Contana. I have to say it feels pretty nice being part of the winning coalition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: ""That said... I can't help but think about all the guys w..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true && (BaseGame.Situation_Law_BludishReconciliation == true || (BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true && BaseGame.Turn04_SnO_LE_Interior_Decreased == false))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true && (BaseGame.Situa..."*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_JointOperation == true && (BaseGame.Sit..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true && (BaseGame.Situation_Law_BludishReconciliation == true || (BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true && BaseGame.Turn04_SnO_LE_Interior_Decreased == false))`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true  and  (Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  (Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true  and  Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: ""...no matter what, Wehlen came to Sordland's aid in its ..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_JointOperation == true && (BaseGame.Situation_Law_BludishReconciliation == true || (BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true && BaseGame.Turn04_SnO_LE_Interior_Decreased == false)))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true  and  (Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  (Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true  and  Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false))) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: ""...After the triumphant victory of our soldiers, Preside..."*)

### Węzeł `[137]`
Mówca: **Narrator**
> ""...no matter what, Wehlen came to Sordland's aid in its time of need. This is definitely the start of a new and lasting alliance in the region, Wiktor Smolak proclaimed...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: ""...After the triumphant victory of our soldiers, Preside..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == true)"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "Patricio Alvarez stepped out of the wagon next to mine."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_Alliance == true)"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "Emmerich Hegel stepped out of the wagon next to mine."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)

### Węzeł `[144]`
Mówca: **Patricio Alvarez**
> "“President Rayne. Let's get this over with as quickly as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)

### Węzeł `[145]`
Mówca: **Narrator**
> "Patricio Alvarez stepped out of the wagon next to mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Patricio Alvarez: "“President Rayne. Let's get this over with as quickly as ..."*)

### Węzeł `[146]`
Mówca: **Emmerich Hegel**
> "“President Rayne. Let's get this over with as quickly as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)

### Węzeł `[147]`
Mówca: **Narrator**
> "Emmerich Hegel stepped out of the wagon next to mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Emmerich Hegel: "“President Rayne. Let's get this over with as quickly as ..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_Alliance == true)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "Maartin Van Hoorten arrived at the clearing near the tracks."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_PeaceConference == true"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_PeaceConference == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_PeaceConference == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_PeaceConference == true)"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_PeaceConference == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_PeaceConference"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Wiktor Smolak walked over with his arms open. He was smil..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_PeaceConference == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_PeaceConference"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "We shook hands and waited in silence for the Queen's arri..."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "Maartin Van Hoorten arrived at the clearing near the tracks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Maartin Van Hoorten: "“Mr. President. The time has finally come.”"*)

### Węzeł `[155]`
Mówca: **Maartin Van Hoorten**
> "“Mr. President. The time has finally come.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_PeaceConference == true"*)

### Węzeł `[156]`
Mówca: **Narrator**
> "Wiktor Smolak walked over with his arms open. He was smiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Wiktor Smolak: "“Anton! My friend! It's certainly been a long ride but fi..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Wiktor Smolak: "“Anton! My friend! It's certainly been a long ride but fi..."*)

### Węzeł `[160]`
Mówca: **Wiktor Smolak**
> "“I can't wait to see the look of defeat on her face.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "We shook hands and waited in silence for the Queen's arri..."*)

### Węzeł `[161]`
Mówca: **Wiktor Smolak**
> "“Anton! My friend! It's certainly been a long ride but finally, we are here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Wiktor Smolak: "“I can't wait to see the look of defeat on her face.”"*)

### Węzeł `[162]`
Mówca: **Wiktor Smolak**
> "“Anton! My friend! It's certainly been a long ride but finally, we are here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Wiktor Smolak: "“I can't wait to see the look of defeat on her face.”"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == true)"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: ""...Lespia leader Patricio Alvarez raised his fist alongs..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_Alliance == true)"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: ""...Valgsland leader Emmerich Hegel raised his fist along..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)

### Węzeł `[169]`
Mówca: **Narrator**
> ""...Lespia leader Patricio Alvarez raised his fist alongside President Rayne after the victory parade in a display of unity...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)

### Węzeł `[170]`
Mówca: **Narrator**
> ""...Valgsland leader Emmerich Hegel raised his fist alongside President Rayne after the victory parade in a display of unity...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_Alliance == true)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: ""...PM Maartin Van Hoorten proclaimed that peace had fina..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true && (BaseGame.Situa..."*)

### Węzeł `[174]`
Mówca: **Narrator**
> ""...PM Maartin Van Hoorten proclaimed that peace had finally arrived in Eastern Merkopa...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true && (BaseGame.Situa..."*)

### Węzeł `[175]`
Mówca: **Narrator**
> "I remembered the jubilant welcome ceremony and smiled. I flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase1_Pincer == true"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_AlliesCalledToWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_AlliesCalledToWar == true"*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_AlliesCalledToWar == true)"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_AlliesCalledToWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_AlliesCalledToWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Beatrice Livingston: ""Part I... Section II... Reparations... ""*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_AlliesCalledToWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_AlliesCalledToWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Beatrice Livingston: ""Part I ... Section II ... Reparations ... ""*)

### Węzeł `[179]`
Mówca: **Beatrice Livingston**
> ""Part I ... Section II ... Reparations ... ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Beatrice Livingston: ""Sordland's government affirms and the Rumburg accepts th..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_AlliesCalledToWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_AlliesCalledToWar == true"*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_AlliesCalledToWar == true)"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_AlliesCalledToWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_AlliesCalledToWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "The witnesses were called for the signing of the agreemen..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_AlliesCalledToWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_AlliesCalledToWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "The witnesses were called for the signing of the agreemen..."*)

### Węzeł `[183]`
Mówca: **Narrator**
> "The witnesses were called for the signing of the agreement titled the 'Treaty of Estord'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "Beatrice angrily scribbled her signature and put down the..."*)

### Węzeł `[184]`
Mówca: **Beatrice Livingston**
> ""Sordland's government affirms and the Rumburg accepts the responsibility of Rumburg for causing for the losses and damages...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[185]`
Mówca: **Beatrice Livingston**
> ""You want us to pay reparations for a war that you declared!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Beatrice Livingston: ""This is outrageous!""*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Beatrice Livingston: ""You want us to pay reparations for a war that you declar..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Beatrice Livingston: ""Wait, what's this?""*)

### Węzeł `[189]`
Mówca: **Beatrice Livingston**
> ""Section V... Sordland's Front...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Beatrice Livingston: ""Rumburg will immediately surrender the cities of Tzarsbo..."*)

### Węzeł `[190]`
Mówca: **Beatrice Livingston**
> ""This is outrageous!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Beatrice Livingston: ""Wait, what's this?""*)

### Węzeł `[191]`
Mówca: **Beatrice Livingston**
> ""Rumburg will immediately surrender the cities of Tzarsbourgh, Dome, and their respective surrounding territories...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Beatrice Livingston: ""You want our two major cities in the south? This will cr..."*)

### Węzeł `[192]`
Mówca: **Beatrice Livingston**
> ""You want our two major cities in the south? This will cripple us for years to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Player: "“Ms. Livingston, it seems you are not fully comprehending..."*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase2_TakeDome == true"*)
  - -> `[195]` (*Player: ""I don't think you are in any position to negotiate.""*)

### Węzeł `[193]`
**[WYBÓR GRACZA: "“Ms. Livingston, it seems you are not fully comprehending the situation. I am not asking!”"]** — Mówca: **Player**
> "“Ms. Livingston, it seems you are not fully comprehending the situation. I am not asking!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Beatrice Livingston: ""I will remember this, Rumburg will remember this.""*)

### Węzeł `[194]`
**[WYBÓR GRACZA: ""Ms. Livingston, would you rather we continue to march toward Thornbourgh so that we can sign the treaty there?""]** — Mówca: **Player**
> ""Ms. Livingston, would you rather we continue to march toward Thornbourgh so that we can sign the treaty there?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true`
- **Kontekst wejściowy (poprzednik):** `[192]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Beatrice Livingston: ""I will remember this, Rumburg will remember this.""*)

### Węzeł `[195]`
**[WYBÓR GRACZA: ""I don't think you are in any position to negotiate.""]** — Mówca: **Player**
> ""I don't think you are in any position to negotiate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Beatrice Livingston: ""I will remember this, Rumburg will remember this.""*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase2_TakeDome == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase2_TakeDome == true"*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_Phase2_TakeDome == true)"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase2_TakeDome == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player: ""Ms. Livingston, would you rather we continue to march to..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_Phase2_TakeDome == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player: ""Ms. Livingston, I can replace you with someone else and ..."*)

### Węzeł `[199]`
**[WYBÓR GRACZA: ""Ms. Livingston, I can replace you with someone else and have that person sign the treaty instead.""]** — Mówca: **Player**
> ""Ms. Livingston, I can replace you with someone else and have that person sign the treaty instead.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[192]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Beatrice Livingston: ""I will remember this, Rumburg will remember this.""*)

### Węzeł `[200]`
Mówca: **Beatrice Livingston**
> ""I will remember this, Rumburg will remember this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_AlliesCalledToWar == true"*)

### Węzeł `[201]`
Mówca: **Beatrice Livingston**
> ""Part I... Section II... Reparations... ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Beatrice Livingston: ""Sordland's government and its allies affirm and Rumburg ..."*)

### Węzeł `[202]`
Mówca: **Beatrice Livingston**
> ""Sordland's government and its allies affirm and Rumburg accepts the responsibility for causing for the losses and damages...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[203]`
Mówca: **Beatrice Livingston**
> ""Section V... Sordland's Front...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)

### Węzeł `[204]`
Mówca: **Beatrice Livingston**
> ""You want us to pay reparations for a war that you declared!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Beatrice Livingston: ""This is outrageous!""*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Beatrice Livingston: ""You want us to pay reparations for a war that you declar..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Beatrice Livingston: ""Wait, what's this?""*)

### Węzeł `[208]`
Mówca: **Beatrice Livingston**
> ""This is outrageous!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Beatrice Livingston: ""Wait, what's this?""*)

### Węzeł `[209]`
Mówca: **Beatrice Livingston**
> ""Rumburg will immediately surrender the cities of Tzarsbourgh, Dome, and their respective surrounding territories to the Republic of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Beatrice Livingston: ""You want our two major cities in the south? This will cr..."*)

### Węzeł `[210]`
Mówca: **Beatrice Livingston**
> ""You want our two major cities in the south? This will cripple us for years to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_PeaceConference == true"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_Alliance == true"*)
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_Alliance == true)"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Beatrice Livingston: ""Rumburg will immediately surrender the city of Tzarsbour..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Beatrice Livingston: ""Rumburg will immediately surrender the cities of Tzarsbo..."*)

### Węzeł `[214]`
Mówca: **Beatrice Livingston**
> ""Rumburg will immediately surrender the city of Tzarsbourgh and its surrounding territories to the Republic of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Beatrice Livingston: ""Section VII... Dome...""*)

### Węzeł `[215]`
Mówca: **Beatrice Livingston**
> ""...recognizing the moral obligation to redress the wrong done by Rumburg in 1921, both to the rights of Agnolia and to the wishes of the population of Dome...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Beatrice Livingston: ""The territories shall be restored to the Republic of Agn..."*)

### Węzeł `[216]`
Mówca: **Beatrice Livingston**
> ""Section VII... Dome...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Beatrice Livingston: ""...recognizing the moral obligation to redress the wrong..."*)

### Węzeł `[217]`
Mówca: **Beatrice Livingston**
> ""The territories shall be restored to the Republic of Agnolia... ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Beatrice Livingston: ""You want our two major cities in the south? This will cr..."*)

### Węzeł `[218]`
Mówca: **Beatrice Livingston**
> ""You want our two major cities in the south? This will cripple us for years to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Maartin Van Hoorten: ""It is only natural that you return what you have taken f..."*)

### Węzeł `[219]`
Mówca: **Maartin Van Hoorten**
> ""It is only natural that you return what you have taken from us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Maartin Van Hoorten: ""The people of Dome will finally be freed from your tyran..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_PeaceConference == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_PeaceConference == true"*)
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_PeaceConference == true)"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_PeaceConference == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_PeaceConference"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Wiktor Smolak: ""Oh, it's not done yet, *my Queen*.""*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_PeaceConference == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_PeaceConference"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)

### Węzeł `[223]`
Mówca: **Maartin Van Hoorten**
> ""The people of Dome will finally be freed from your tyrannical rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_PeaceConference == true"*)

### Węzeł `[224]`
Mówca: **Wiktor Smolak**
> ""Oh, it's not done yet, *my Queen*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Wiktor Smolak: ""Have a look at Section IX. I believe it is titled 'The W..."*)

### Węzeł `[225]`
Mówca: **Wiktor Smolak**
> ""Have a look at Section IX. I believe it is titled 'The Wehzek People'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Beatrice Livingston: ""Rumburg will immediately surrender the territories surro..."*)

### Węzeł `[226]`
Mówca: **Beatrice Livingston**
> ""Rumburg will immediately surrender the territories surrounding Datefort to Wehlen in accordance with the wishes of the Wehzek people living in these territories.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Beatrice Livingston: ""What is this madness? What about all the Rumburgian and ..."*)

### Węzeł `[227]`
Mówca: **Beatrice Livingston**
> ""What is this madness? What about all the Rumburgian and Bludish people living there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Wiktor Smolak: ""That is none of your business.""*)

### Węzeł `[228]`
Mówca: **Wiktor Smolak**
> ""That is none of your business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true"*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Wiktor Smolak: ""I'm sure that my friend Anton and I can come to another ..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Wiktor Smolak: ""I'm sure that President Rayne and I can come to another ..."*)

### Węzeł `[232]`
Mówca: **Wiktor Smolak**
> ""I'm sure that my friend Anton and I can come to another agreement similar to the last one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Beatrice Livingston: ""You not only intended to commit a genocide of the Bludis..."*)

### Węzeł `[233]`
Mówca: **Wiktor Smolak**
> ""I'm sure that President Rayne and I can come to another agreement similar to the last one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Beatrice Livingston: ""You not only intended to commit a genocide of the Bludis..."*)

### Węzeł `[234]`
Mówca: **Beatrice Livingston**
> ""You not only intended to commit a genocide of the Bludish people, but of Rumburgians as well. I won't stand for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Wiktor Smolak: ""That will depend on how they behave, don't you agree?""*)

### Węzeł `[235]`
Mówca: **Wiktor Smolak**
> ""That will depend on how they behave, don't you agree?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Valgsland_Alliance == true"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Valgsland_Alliance == true)"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Emmerich Hegel: ""You won't be in any position to worry about that.""*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)

### Węzeł `[239]`
Mówca: **Emmerich Hegel**
> ""You won't be in any position to worry about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Emmerich Hegel: ""It is due time to free the Rumburgian people from your t..."*)

### Węzeł `[240]`
Mówca: **Emmerich Hegel**
> ""It is due time to free the Rumburgian people from your tyrannical rule. The workers' revolution is about to begin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Beatrice Livingston: ""Section X... The People's Revolution.... The Queen of Ru..."*)

### Węzeł `[241]`
Mówca: **Beatrice Livingston**
> ""Section X... The People's Revolution.... The Queen of Rumburg will immediately abdicate and transfer her authority to the newly established National Liberation Committee that will be elected by the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Beatrice Livingston: ""The Republic of Valgsland, as a representative of the CS..."*)

### Węzeł `[242]`
Mówca: **Beatrice Livingston**
> ""The Republic of Valgsland, as a representative of the CSP, will work closely with Rumburg's new government to advise and oversee this transition of power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Beatrice Livingston: ""You want to destroy Rumburg with your poisonous ideology.""*)

### Węzeł `[243]`
Mówca: **Beatrice Livingston**
> ""You want to destroy Rumburg with your poisonous ideology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)

### Węzeł `[244]`
**[WYBÓR GRACZA: ""I don't think you are in any position to negotiate.""]** — Mówca: **Player**
> ""I don't think you are in any position to negotiate.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false` AND `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[259]` (Beatrice Livingston), `[243]` (Beatrice Livingston), `[235]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Beatrice Livingston: ""I will remember this. Rumburg will remember this.""*)

### Węzeł `[245]`
**[WYBÓR GRACZA: "“Ms. Livingston, it seems you do not fully comprehend the situation. We are not asking!""]** — Mówca: **Player**
> "“Ms. Livingston, it seems you do not fully comprehend the situation. We are not asking!""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false` AND `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[259]` (Beatrice Livingston), `[243]` (Beatrice Livingston), `[235]` (Wiktor Smolak)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Beatrice Livingston: ""I will remember this. Rumburg will remember this.""*)

### Węzeł `[246]`
**[WYBÓR GRACZA: ""Ms. Livingston, would you rather we continue our march towards Thornbourgh so that we can sign the treaty there?""]** — Mówca: **Player**
> ""Ms. Livingston, would you rather we continue our march towards Thornbourgh so that we can sign the treaty there?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true` AND `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[259]` (Beatrice Livingston), `[243]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Beatrice Livingston: ""I will remember this. Rumburg will remember this.""*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase2_TakeDome == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase2_TakeDome == true"*)
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_Phase2_TakeDome == true)"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase2_TakeDome == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player: ""Ms. Livingston, would you rather we continue our march t..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_Phase2_TakeDome == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Player: ""Ms. Livingston, we can always replace you with someone e..."*)

### Węzeł `[250]`
Mówca: **Beatrice Livingston**
> ""I will remember this. Rumburg will remember this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_AlliesCalledToWar == true"*)

### Węzeł `[251]`
**[WYBÓR GRACZA: ""Ms. Livingston, we can always replace you with someone else and have that person sign the treaty instead.""]** — Mówca: **Player**
> ""Ms. Livingston, we can always replace you with someone else and have that person sign the treaty instead.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true) == false` AND `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[259]` (Beatrice Livingston), `[243]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Beatrice Livingston: ""I will remember this. Rumburg will remember this.""*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == true)"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Patricio Alvarez: ""Ms. Livingston, we only want to assure peace in the regi..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[255]`
Mówca: **Patricio Alvarez**
> ""Ms. Livingston, we only want to assure peace in the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Beatrice Livingston: ""Section X... Status of Forces Agreement... Rumburg grant..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player: "“Ms. Livingston, it seems you do not fully comprehend the..."*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase2_TakeDome == true"*)
  - -> `[244]` (*Player: ""I don't think you are in any position to negotiate.""*)

### Węzeł `[257]`
Mówca: **Beatrice Livingston**
> ""Section X... Status of Forces Agreement... Rumburg grants, and ATO accepts, the right, upon the coming into force of this Treaty, to deploy ATO land, air and sea forces in and about Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Beatrice Livingston: ""During the exercise of the right ... Rumburg will not gr..."*)

### Węzeł `[258]`
Mówca: **Beatrice Livingston**
> ""During the exercise of the right ... Rumburg will not grant, without the prior consent of ATO, any bases or any rights, powers or authority whatsoever, in or relating to bases or the right of garrison or of maneuver, or transit of ground, air or naval forces to any third power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Patricio Alvarez: ""That's not all. You missed a couple of points from Secti..."*)

### Węzeł `[259]`
Mówca: **Beatrice Livingston**
> ""Do you realize what this will do to us? We'll lose our freedom, our ability to defend ourselves, our economic independence...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[260]`
Mówca: **Patricio Alvarez**
> ""That's not all. You missed a couple of points from Section II, Reparation. Let me summarize it for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Patricio Alvarez: ""According to Section II, Rumburg will remove all tariffs..."*)

### Węzeł `[261]`
Mówca: **Patricio Alvarez**
> ""According to Section II, Rumburg will remove all tariffs on Lespian products being sold in any Rumburgian territories.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Patricio Alvarez: ""The Republic of Lespia will have priority access to Rumb..."*)

### Węzeł `[262]`
Mówca: **Patricio Alvarez**
> ""The Republic of Lespia will have priority access to Rumburg's market.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Patricio Alvarez: ""Furthermore, all Lespian companies established in any te..."*)

### Węzeł `[263]`
Mówca: **Patricio Alvarez**
> ""Furthermore, all Lespian companies established in any territories of Rumburg will enjoy a 10-year tax-free period.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Beatrice Livingston: ""Do you realize what this will do to us? We'll lose our f..."*)

### Węzeł `[264]`
Mówca: **Beatrice Livingston**
> ""Wait, what's this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Beatrice Livingston: ""Section V... Sordland's Front...""*)

### Węzeł `[265]`
Mówca: **Beatrice Livingston**
> ""Wait, what's this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Beatrice Livingston: ""Section V... Sordland's Front...""*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Letter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn11_SnO_Letter == true"*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn11_SnO_Letter == true)"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn11_SnO_Letter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Letter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player_Italic: "Give her the middle finger."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn11_SnO_Letter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Letter"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[269]`
**[WYBÓR GRACZA: "Give her the middle finger."]** — Mówca: **Player_Italic**
> "I raised my middle finger in the Queen's face."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn11_SnO_Letter"] == true`
- **Kontekst wejściowy (poprzednik):** `[45]` (Beatrice Livingston)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Player: ""That's from my son.""*)
  - -> `[271]` (*Player: ""My parting gift from Sordland.""*)

### Węzeł `[270]`
**[WYBÓR GRACZA: ""That's from my son.""]** — Mówca: **Player**
> ""That's from my son.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[269]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Beatrice Livingston: ""Well, I never...""*)

### Węzeł `[271]`
**[WYBÓR GRACZA: ""My parting gift from Sordland.""]** — Mówca: **Player**
> ""My parting gift from Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[269]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Beatrice Livingston: ""Well, I never...""*)

### Węzeł `[272]`
Mówca: **Beatrice Livingston**
> ""Well, I never...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.Shown_MiddleFinger_ToQueen = true"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_SnO_Soll_JoinMeeting == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_SnO_Soll_JoinMeeting == true"*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn10_SnO_Soll_JoinMeeting == true)"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_SnO_Soll_JoinMeeting == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_SnO_Soll_JoinMeeting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Narrator: ""Of course, the real credit goes to Colonel Tarquin Soll,..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn10_SnO_Soll_JoinMeeting == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_SnO_Soll_JoinMeeting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_SnO_Deivid_JoinMeeting"*)

### Węzeł `[276]`
Mówca: **Narrator**
> ""Of course, the real credit goes to Colonel Tarquin Soll, who selflessly came out of retirement to aid in the war plans.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: ""Experts are still analyzing the particulars of the victo..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_SnO_Deivid_JoinMeeting`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_SnO_Deivid_JoinMeeting"*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn10_SnO_Deivid_JoinMeeting)"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_SnO_Deivid_JoinMeeting`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_SnO_Deivid_JoinMeeting"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: ""Credit as well goes to Foreign Minister Deivid Wisci, wh..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn10_SnO_Deivid_JoinMeeting)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_SnO_Deivid_JoinMeeting"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: ""Experts are still analyzing the particulars of the victo..."*)

### Węzeł `[280]`
Mówca: **Narrator**
> ""Credit as well goes to Foreign Minister Deivid Wisci, whose insight into Sordland's allies proved invaluable. He certainly deserves a long and peaceful retirement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: ""Experts are still analyzing the particulars of the victo..."*)

### Węzeł `[281]`
Mówca: **Narrator**
> "She laid out the treaty and began to read the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_AlliesCalledToWar == true"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("TrainWhistle");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("TrainWhistle");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "With a final whistle, the Maroon Train came to a stop in ..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Shown_MiddleFinger_ToQueen = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Shown_MiddleFinger_ToQueen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "With a haughty sniff, she turned around and left the wagon."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `DisableToken("Sordland_Event_RumburgWar");`
- **Efekt skryptowy (`userScript`):** `DisableToken("Sordland_Event_RumburgWar");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "DisableToken("Sordland_Event_RumburgInvasion");"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `DisableToken("Sordland_Event_RumburgInvasion");`
- **Efekt skryptowy (`userScript`):** `DisableToken("Sordland_Event_RumburgInvasion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Rumburg", "Ho..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase2_TakeDome == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn10_SnO_Phase2_TakeDome == true"*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn10_SnO_Phase2_TakeDome == true)"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn10_SnO_Phase2_TakeDome == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: ""Defense minister Iosef Lancea was the man of the hour as..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn10_SnO_Phase2_TakeDome == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: ""Defense minister Iosef Lancea was the man of the hour as..."*)

### Węzeł `[290]`
Mówca: **Narrator**
> ""Defense minister Iosef Lancea was the man of the hour as his superior strategies broke the morale of the enemy at Dome. Following that operation, our troops were victorious in their assaults towards their capital and tipped the scales in our favor. Soon after, they were routing the enemy in the fields around Thornbourgh...'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_SnO_Soll_JoinMeeting == true"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Rumburg", "Hostile");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Rumburg","Hostile");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "End();"*)
