# Sordland/Turn05/Personal_MonicaTalk

- **ID konwersacji:** `65`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/065_Personal_MonicaTalk.md`
- **Liczba węzłów dialogowych:** 410
- **Liczba wyborów gracza:** 50

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[20]** Deana

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn05_SPAid_AcceptArcasia`
- `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana`
- `BaseGame.Economy`
- `BaseGame.GovernmentBudget`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Diplomacy_RelaxedImmigration`
- `BaseGame.Policy_Diplomacy_TightenedImmigration`
- `BaseGame.Prologue_University_SupportWomensRights`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Relations_Lileas_GendermariePromise`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Relations_Monica_SupportedAtFestival`
- `BaseGame.Turn03_EnT_Military_Budget_Decrease`
- `BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled`
- `BaseGame.Turn04_P_Monica_Benfi_Speech`
- `BaseGame.Turn05_Admin_Media_Influenced`
- `BaseGame.Turn05_Admin_Monica_Barred`
- `BaseGame.Turn05_Admin_News_Contained`
- `BaseGame.Turn05_Personal_Festival_Force`
- `BaseGame.Turn05_Personal_Festival_LesteKicked`
- `BaseGame.Turn05_Personal_Festival_LesteLeft`
- `BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice`
- `BaseGame.Turn05_SnO_LE_Policy_CommunityPolice`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Public_Opinion`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Relations_Monica_Slapped`
- `BaseGame.Turn06_P_SupportedMonicaAtConfrontation`
- `BaseGameSupport.News_Turn05_E_SkilledImmigrationPositive`
- `BaseGameSupport.News_Turn05_G_CSPRevolutionsDestabilize`
- `BaseGameSupport.News_Turn05_G_QinalIntendsObserver`
- `BaseGameSupport.News_Turn05_HP_CurtanApologizes`
- `BaseGameSupport.News_Turn05_HP_LowerClassThreatened`
- `BaseGameSupport.News_Turn05_LT_Benfi_Curtan_MonicaShutDown`
- `BaseGameSupport.News_Turn05_LT_Benfi_Curtan_MonicaSupported`
- `BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanKicked_NoMedia`
- `BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanLeft_NoMedia`
- `BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanLeftorKicked_Media`
- `BaseGameSupport.News_Turn05_LT_Benfi_Monica_Listened`
- `BaseGameSupport.News_Turn05_LT_Benfi_Monica_ShutDown`
- `BaseGameSupport.News_Turn05_LT_ImmigrationDecreases`
- `BaseGameSupport.News_Turn05_ST_Benfi_Curtan_MonicaShutDown_NoDeal`
- `BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanKicked_NoDeal`
- `BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanLeft_NoDeal`
- `BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanLeftorKicked_Deal`
- `BaseGameSupport.Report_Turn05_Conriat_UCBase`
- `BaseGameSupport.Report_Turn05_Erlory_ArcasianBase`
- `BaseGameSupport.Report_Turn05_Holsord_NegativeApproval`
- `BaseGameSupport.Report_Turn05_Holsord_PositiveApproval`
- `BaseGameSupport.Report_Turn05_Lachaven_EconomyAutocrat`
- `BaseGameSupport.Report_Turn05_Lachaven_EconomyBad`
- `BaseGameSupport.Report_Turn05_Lachaven_EconomyGood`
- `BaseGameSupport.Report_Turn05_Lachaven_EconomyGreat`
- `BaseGameSupport.Report_Turn05_Lachaven_EconomyOkay`
- `GameCondition.Turn05_Decision_RumburgBorderReinforcement`
- `GameCondition.Turn05_Personal_MonicaTalk`
- `GameCondition.Turn05_SnO_FoundedPolice`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[31]` | **"“If this is about the news, I know what you are going to say.”"** | `[29]` **Monica**: "“Listen. Can we talk for a bit?"" | `(Variable["BaseGame.Turn05_Admin_Media_Influenced"]) == false` | *Brak zmian stanu* | `[344]` **Narrator**: "Monica sat and picked up the nea..."<br>`[343]` **Narrator**: "Monica sat and picked up the nea..." |
| `[32]` | **"“Of course. What is it?”"** | `[29]` **Monica**: "“Listen. Can we talk for a bit?"" | `(Variable["BaseGame.Turn05_Admin_Media_Influenced"]) == false` | *Brak zmian stanu* | `[344]` **Narrator**: "Monica sat and picked up the nea..."<br>`[343]` **Narrator**: "Monica sat and picked up the nea..." |
| `[33]` | **"Gesture for her to sit down."** | `[29]` **Monica**: "“Listen. Can we talk for a bit?"" | `(Variable["BaseGame.Turn05_Admin_Media_Influenced"]) == false` | *Brak zmian stanu* | `[344]` **Narrator**: "Monica sat and picked up the nea..."<br>`[343]` **Narrator**: "Monica sat and picked up the nea..." |
| `[37]` | **"Wipe her tears away."** | `[36]` **Narrator**: "Her eyes were getting moist. A s..." | `(Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true) == false` | *Brak zmian stanu* | `[41]` **Monica**: "“Oh, Anton.”" |
| `[38]` | **"“It's okay. Everything is under control.”"** | `[36]` **Narrator**: "Her eyes were getting moist. A s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Monica**: "“Oh, Anton.”" |
| `[39]` | **"“If you are going to succeed in this, you have to be stronger. I know you can be.”"** | `[36]` **Narrator**: "Her eyes were getting moist. A s..." | `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false` | *Brak zmian stanu* | `[41]` **Monica**: "“Oh, Anton.”" |
| `[40]` | **"“I did warn you. But you were always stubborn.”"** | `[36]` **Narrator**: "Her eyes were getting moist. A s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Monica**: "“I know. I'm sorry. But you are ..." |
| `[48]` | **""Monica, I know. We can talk about this--”"** | `[30]` **Monica**: "“So, you've seen the news?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Monica**: "“What is there to talk about? I'..." |
| `[49]` | **"“What news?”"** | `[30]` **Monica**: "“So, you've seen the news?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Monica**: "“Here, I have it memorized: Firs..." |
| `[50]` | **"Do not reply."** | `[30]` **Monica**: "“So, you've seen the news?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Monica**: "“Here, I have it memorized: Firs..." |
| `[53]` | **""You shouldn't have spoken out.”"** | `[51]` **Monica**: "“What is there to talk about? I'..."<br>`[52]` **Monica**: "“Here, I have it memorized: Firs..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[301]` **Monica**: ""Anton, how could you? You knew ..."<br>`[302]` **Monica**: ""Anton, how could you? First you..." |
| `[62]` | **"“Darling, believe me. My hands were tied.”"** | `[51]` **Monica**: "“What is there to talk about? I'..."<br>`[52]` **Monica**: "“Here, I have it memorized: Firs..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[301]` **Monica**: ""Anton, how could you? You knew ..."<br>`[302]` **Monica**: ""Anton, how could you? First you..." |
| `[63]` | **"Do not reply."** | `[51]` **Monica**: "“What is there to talk about? I'..."<br>`[52]` **Monica**: "“Here, I have it memorized: Firs..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[301]` **Monica**: ""Anton, how could you? You knew ..."<br>`[302]` **Monica**: ""Anton, how could you? First you..." |
| `[64]` | **"“I'm so sorry. I understand if you never forgive me.”"** | `[61]` **Monica**: "“You know... my mother was right..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[66]` **Monica**: "“Just...tell me why. Couldn't yo..." |
| `[65]` | **"“I thought you were capable of defending yourself. Clearly not.”"** | `[61]` **Monica**: "“You know... my mother was right..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[187]` **Monica**: "“I'm not sure I can forgive you ..." |
| `[67]` | **"“I didn't want to lose Curtan's support.”"** | `[66]` **Monica**: "“Just...tell me why. Couldn't yo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[94]` **Monica**: ""I see. That's where your priori..." |
| `[77]` | **"“I have to tell you something. I made a deal with Curtan.”"** | `[36]` **Narrator**: "Her eyes were getting moist. A s..." | `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true` | *Brak zmian stanu* | `[78]` **Monica**: "“What kind of deal?"" |
| `[79]` | **"“In return for his support, he asked me to bar you from politics. I accepted.”"** | `[78]` **Monica**: "“What kind of deal?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Narrator**: "I handed her my agreement with C..." |
| `[80]` | **"Hand her the written agreement barring Monica from politics."** | `[78]` **Monica**: "“What kind of deal?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Narrator**: "She looked at the page, eyes wid..." |
| `[85]` | **"“Sometimes you have to make sacrifices for the good of the country. You've got to ..."** | `[66]` **Monica**: "“Just...tell me why. Couldn't yo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[86]` **Monica**: "“But why did the sacrifice have ..." |
| `[87]` | **"“I'll give you one more chance. But this time I won't tolerate it if it meddles wi..."** | `[188]` **Monica**: "“But you do have one more chance..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[89]` **Monica**: "“I-- I can live with that, I sup..." |
| `[88]` | **"“You always have my support. I failed you this time -- it won't happen again.""** | `[188]` **Monica**: "“But you do have one more chance..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[90]` **Monica**: "“I-- Thank you.”" |
| `[91]` | **"“No. I was right not to let you speak at the festival. Next time, I won't bring yo..."** | `[188]` **Monica**: "“But you do have one more chance..." | `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"]) == false` | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[92]` **Narrator**: "Monica turned pale with anger. I..." |
| `[96]` | **"“I was afraid I'd make you look weak by stepping in.”"** | `[66]` **Monica**: "“Just...tell me why. Couldn't yo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[97]` **Monica**: "“I-- I suppose I can appreciate ..." |
| `[110]` | **"“I don't think so. You left me no choice but to make a deal with Curtan.”"** | `[325]` **Monica**: ""I know this isn't an urgent iss..."<br>`[326]` **Monica**: ""I know this is something you're..." | `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true` | *Brak zmian stanu* | `[112]` **Monica**: "“What kind of deal?”" |
| `[111]` | **"“I'm so sorry. I had to make a deal with Curtan.”"** | `[325]` **Monica**: ""I know this isn't an urgent iss..."<br>`[326]` **Monica**: ""I know this is something you're..." | `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true` | *Brak zmian stanu* | `[112]` **Monica**: "“What kind of deal?”" |
| `[114]` | **"Hand her your written agreement barring Monica from politics."** | `[112]` **Monica**: "“What kind of deal?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Narrator**: "She looked at the page, her eyes..." |
| `[115]` | **"“The only way he would let the festival debacle go was if I barred you from politi..."** | `[112]` **Monica**: "“What kind of deal?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Narrator**: "I handed her our written agreement." |
| `[119]` | **"“Of course, my love. I'm looking forward to working closer together.”"** | `[325]` **Monica**: ""I know this isn't an urgent iss..."<br>`[326]` **Monica**: ""I know this is something you're..." | `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false` | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...`<br>`Variable["BaseGame.Turn06_P_SupportedMonicaAtConfrontatio...` | `[330]` **Monica**: ""Good.""<br>`[331]` **Monica**: ""Oh, Anton. This means so much t..." |
| `[120]` | **"“I'm sorry, but no. Leave politics to the politicians. I promise I'll pass the ref..."** | `[325]` **Monica**: ""I know this isn't an urgent iss..."<br>`[326]` **Monica**: ""I know this is something you're..." | `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true` | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[121]` **Narrator**: "Monica turned pale with anger. I..." |
| `[132]` | **"“Monica, I am so sorry. I tried my best.""** | `[131]` **Monica**: "“Coward!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Monica**: ""You did no such thing! You used..." |
| `[133]` | **"Slap her."** | `[131]` **Monica**: "“Coward!”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...`<br>`Variable["BaseGame.Relations_Monica_Slapped"] = true;` | `[137]` **Narrator**: "What seemed like an eternity pas..." |
| `[136]` | **""Monica, I'm so sorry. This is not who I am.""** | `[137]` **Narrator**: "What seemed like an eternity pas..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[352]` **Narrator**: "Monica stood up." |
| `[138]` | **"“This is what happens when you insult the president.""** | `[137]` **Narrator**: "What seemed like an eternity pas..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[352]` **Narrator**: "Monica stood up." |
| `[140]` | **"Help her up."** | `[137]` **Narrator**: "What seemed like an eternity pas..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Narrator**: "She slapped it out of the way an..." |
| `[145]` | **"“It's nothing. We were just having an argument.”"** | `[144]` **Deana**: "“Papa. Why did you hit Mama?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Monica**: "“Come on, Deana. Lets go to the ..." |
| `[146]` | **"“Deana, go to your room. NOW!”"** | `[144]` **Deana**: "“Papa. Why did you hit Mama?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[147]` **Monica**: "“Stop yelling at her! Deana, let..." |
| `[148]` | **"Stay silent."** | `[144]` **Deana**: "“Papa. Why did you hit Mama?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Monica**: "“Come on, Deana. Lets go to the ..." |
| `[158]` | **"“It's nothing. We were just...talking about work.”"** | `[157]` **Deana**: "“Papa. Mama. Why are you fighting?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Monica**: "“Yes, it's nothing. Your papa an..." |
| `[159]` | **"Stay silent."** | `[157]` **Deana**: "“Papa. Mama. Why are you fighting?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Monica**: "“It's nothing. Your papa and I w..." |
| `[169]` | **"“It's nothing. We were just...talking about work.”"** | `[168]` **Deana**: "“Papa. Mama. Why are you fighting?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Monica**: "“Yes, it's nothing. Your papa an..." |
| `[170]` | **"Stay silent."** | `[168]` **Deana**: "“Papa. Mama. Why are you fighting?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Monica**: "“It's nothing. Your papa and I w..." |
| `[192]` | **"“It's nothing. We were just... talking about work.”"** | `[191]` **Deana**: "“Papa. Mama. Why are you fighting?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Monica**: "“Your father is right. We were j..." |
| `[195]` | **"Stay silent."** | `[191]` **Deana**: "“Papa. Mama. Why are you fighting?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[197]` **Monica**: "“It's nothing. Your papa and I w..." |
| `[286]` | **"“What's that supposed to mean?”"** | `[61]` **Monica**: "“You know... my mother was right..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Monica**: "“Oh, you know what it means."" |
| `[307]` | **"“No. I was wrong to have let you speak at the festival. I won't make the same mist..."** | `[188]` **Monica**: "“But you do have one more chance..." | `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"]` | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[92]` **Narrator**: "Monica turned pale with anger. I..." |
| `[337]` | **"“I'm rather busy, but all right.”"** | `[29]` **Monica**: "“Listen. Can we talk for a bit?"" | `Variable["BaseGame.Turn05_Admin_Media_Influenced"]` | *Brak zmian stanu* | `[345]` **Monica**: ""I've been reading the papers, t..." |
| `[338]` | **"“Of course. what is it?”"** | `[29]` **Monica**: "“Listen. Can we talk for a bit?"" | `Variable["BaseGame.Turn05_Admin_Media_Influenced"]` | *Brak zmian stanu* | `[345]` **Monica**: ""I've been reading the papers, t..." |
| `[339]` | **"Gesture for her to sit down."** | `[29]` **Monica**: "“Listen. Can we talk for a bit?"" | `Variable["BaseGame.Turn05_Admin_Media_Influenced"]` | *Brak zmian stanu* | `[345]` **Monica**: ""I've been reading the papers, t..." |
| `[348]` | **"“It's okay. I've had Curtan fired. That's the last of our troubles with him.""** | `[36]` **Narrator**: "Her eyes were getting moist. A s..." | `Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true` | *Brak zmian stanu* | `[41]` **Monica**: "“Oh, Anton.”" |

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
  - -> `[3]` (*Narrator: "It felt like eternity since the Benfi Festival. Had it re..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It felt like eternity since the Benfi Festival. Had it really only been less than 24 hours?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "I was at home now, drinking an afternoon coffee on my bal..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "I was at home now, drinking an afternoon coffee on my balcony. A stack of newspapers lay by my side. I picked them up one by one, reading and re-reading the articles about the festival."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == false && BaseGam..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "I started regretting my decisions. Regardless, it was too late now. The damage was done."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "I was putting the last newspaper down as Monica joined me..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_P_Monica_Benfi_Speech == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_Force == true"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_P_Monica_Benfi_Speech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "Some of the newspapers were merciless against Monica for ..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Media_Influenced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Media_Influenced == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_Media_Influenced == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Media_Influenced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Media_Influenced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "As expected, Marcel delivered. There was only a second-pa..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_Media_Influenced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Media_Influenced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_Force == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_Force == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Personal_Festival_Force == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_Force == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_Force"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_News_Contained == true"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Personal_Festival_Force == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_Force"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival == true"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_Monica_Barred == true)"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "As expected, Curtan delivered. The news was all about his..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_Monica_Barred == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "As expected, the headlines were merciless. I was compared..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "Some of the newspapers were merciless against Monica for interrupting Curtan during his speech. A few even called for her to be barred from political matters. Others expressed their support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "In any event, I was relieved that the incident hadn't ref..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "Some of the papers came out in full support of the First Lady for her brave speech. Others took Curtan's side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "Nearly all of them agreed that the First Lady had acquitt..."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "In any event, I was relieved that the incident hadn't reflected too badly on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "I was putting the last newspaper down as Monica joined me..."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "As expected, the headlines were merciless. I was compared to a dictator for my intolerance of Curtan's opinion. Some even likened me to Tarquin Soll. The knowledge that Curtan would soon be fired provided little comfort."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "I started regretting my decisions. Regardless, it was too..."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "As expected, Marcel delivered. There was only a second-page article about Curtan Leste behaving deplorably and leaving the festival in disgrace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "But my relief was short-lived. Marcel was effective, but ..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "But my relief was short-lived. Marcel was effective, but he was also a double-edged sword. I couldn't help but think that if someone offered him a better deal, he'd turn on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "I was putting the last newspaper down as Monica joined me..."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "As expected, Curtan delivered. The news was all about his apology for his disgraceful behavior during the festival."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "I was putting the last newspaper down as Monica joined me..."*)

### Węzeł `[25]`
Mówca: **Narrator**
> "I was putting the last newspaper down as Monica joined me on the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival == true"*)

### Węzeł `[26]`
Mówca: **Narrator**
> "I was putting the last newspaper down as Monica joined me on the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival == true"*)

### Węzeł `[27]`
Mówca: **Narrator**
> "I was putting the last newspaper down as Monica joined me on the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival == true"*)

### Węzeł `[28]`
Mówca: **Narrator**
> "I was putting the last newspaper down as Monica joined me on the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival == true"*)

### Węzeł `[29]`
Mówca: **Monica**
> "“Listen. Can we talk for a bit?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Media_Influenced"*)

### Węzeł `[30]`
Mówca: **Monica**
> "“So, you've seen the news?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: ""Monica, I know. We can talk about this--”"*)
  - -> `[49]` (*Player: "“What news?”"*)
  - -> `[50]` (*Player_Italic: "Do not reply."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“If this is about the news, I know what you are going to say.”"]** — Mówca: **Player**
> "“If this is about the news, I know what you are going to say.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_Admin_Media_Influenced"]) == false`
- **Kontekst wejściowy (poprzednik):** `[29]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_News_Contained"*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "“Of course. What is it?”"]** — Mówca: **Player**
> "“Of course. What is it?”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_Admin_Media_Influenced"]) == false`
- **Kontekst wejściowy (poprzednik):** `[29]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_News_Contained"*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "Gesture for her to sit down."]** — Mówca: **Player_Italic**
> "I gestured towards the chair next to me."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_Admin_Media_Influenced"]) == false`
- **Kontekst wejściowy (poprzednik):** `[29]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_News_Contained"*)

### Węzeł `[34]`
Mówca: **Monica**
> "“I just wanted to thank you for supporting me, and apologize for creating such a spectacle.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true"*)

### Węzeł `[35]`
Mówca: **Monica**
> ""All I wanted was to bring the people of Sordland together, the way you're able to. But not like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "Her eyes were getting moist. A single tear fell onto the ..."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "Her eyes were getting moist. A single tear fell onto the newsprint."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)
  - -> `[38]` (*Player: "“It's okay. Everything is under control.”"*)
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lileas_GendermariePromise == true"*)
  - -> `[40]` (*Player: "“I did warn you. But you were always stubborn.”"*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "Wipe her tears away."]** — Mówca: **Player_Italic**
> "I leaned forward and wiped her tears from her eyes. She clasped my hand to her face."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Monica: "“Oh, Anton.”"*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“It's okay. Everything is under control.”"]** — Mówca: **Player**
> "“It's okay. Everything is under control.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Monica: "“Oh, Anton.”"*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“If you are going to succeed in this, you have to be stronger. I know you can be.”"]** — Mówca: **Player**
> "“If you are going to succeed in this, you have to be stronger. I know you can be.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Monica: "“Oh, Anton.”"*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "“I did warn you. But you were always stubborn.”"]** — Mówca: **Player**
> "“I did warn you. But you were always stubborn.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Monica: "“I know. I'm sorry. But you are right.”"*)

### Węzeł `[41]`
Mówca: **Monica**
> "“Oh, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1"*)

### Węzeł `[42]`
Mówca: **Monica**
> "“I know. I'm sorry. But you are right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Monica: "“I am stubborn.”"*)

### Węzeł `[43]`
Mówca: **Narrator**
> "Her eyes filled with gratitude. I could see she'd slept as little as I had since the festival."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Monica: "“Thank you.”"*)

### Węzeł `[44]`
Mówca: **Monica**
> "“I am stubborn.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monica Asks For Support Again]"*)

### Węzeł `[45]`
Mówca: **Monica**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Monica: "“One more thing. You know how stubborn I am.”"*)

### Węzeł `[46]`
Mówca: **Monica**
> "“One more thing. You know how stubborn I am.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monica Asks For Support Again]"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Monica Supported Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Monica: "“Listen. Can we talk for a bit?""*)

### Węzeł `[48]`
**[WYBÓR GRACZA: ""Monica, I know. We can talk about this--”"]** — Mówca: **Player**
> ""Monica, I know. We can talk about this--”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Monica: "“What is there to talk about? I'm a disgrace with no supp..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "“What news?”"]** — Mówca: **Player**
> "“What news?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Monica: "“Here, I have it memorized: First Lady disgraced. No supp..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "Do not reply."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Monica: "“Here, I have it memorized: First Lady disgraced. No supp..."*)

### Węzeł `[51]`
Mówca: **Monica**
> "“What is there to talk about? I'm a disgrace with no support from my husband. It says so right here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: ""You shouldn't have spoken out.”"*)
  - -> `[63]` (*Player_Italic: "Do not reply."*)
  - -> `[62]` (*Player: "“Darling, believe me. My hands were tied.”"*)

### Węzeł `[52]`
Mówca: **Monica**
> "“Here, I have it memorized: First Lady disgraced. No support from her husband.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: ""You shouldn't have spoken out.”"*)
  - -> `[63]` (*Player_Italic: "Do not reply."*)
  - -> `[62]` (*Player: "“Darling, believe me. My hands were tied.”"*)

### Węzeł `[53]`
**[WYBÓR GRACZA: ""You shouldn't have spoken out.”"]** — Mówca: **Player**
> ""You shouldn't have spoken out.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Monica), `[52]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Monica Angry Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 2;"*)

### Węzeł `[55]`
Mówca: **Narrator**
> "She grabbed one of the newspapers from the top of the stack and started reading out what a columnist wrote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)

### Węzeł `[56]`
Mówca: **Monica**
> "“With her shameful outburst at Anrica mayor Curtan Leste, First Lady Monica Rayne once again proved that politics is an area best left to gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Monica: "“With the President providing no support, her challenge t..."*)

### Węzeł `[57]`
Mówca: **Monica**
> "“The President provided no support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Monica: "“You can't even stand Leste, and you took his side! While..."*)

### Węzeł `[58]`
Mówca: **Monica**
> "“You can't even stand Leste, and you took his side! While making me look like a fool!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "She started ripping the newspaper to shreds."*)

### Węzeł `[59]`
Mówca: **Narrator**
> "She started ripping the newspaper to shreds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Monica: "“After all these years by your side, playing the doting w..."*)

### Węzeł `[60]`
Mówca: **Monica**
> "“After all these years by your side, playing the doting wife...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Monica: "“You know... my mother was right about you.”"*)

### Węzeł `[61]`
Mówca: **Monica**
> "“You know... my mother was right about you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: "“I thought you were capable of defending yourself. Clearl..."*)
  - -> `[286]` (*Player: "“What's that supposed to mean?”"*)
  - -> `[64]` (*Player: "“I'm so sorry. I understand if you never forgive me.”"*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Darling, believe me. My hands were tied.”"]** — Mówca: **Player**
> "“Darling, believe me. My hands were tied.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Monica), `[52]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "Do not reply."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Monica), `[52]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)

### Węzeł `[64]`
**[WYBÓR GRACZA: "“I'm so sorry. I understand if you never forgive me.”"]** — Mówca: **Player**
> "“I'm so sorry. I understand if you never forgive me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1"*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“I thought you were capable of defending yourself. Clearly not.”"]** — Mówca: **Player**
> "“I thought you were capable of defending yourself. Clearly not.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 2"*)

### Węzeł `[66]`
Mówca: **Monica**
> "“Just...tell me why. Couldn't you have said something?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: "“I didn't want to lose Curtan's support.”"*)
  - -> `[85]` (*Player: "“Sometimes you have to make sacrifices for the good of th..."*)
  - -> `[96]` (*Player: "“I was afraid I'd make you look weak by stepping in.”"*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "“I didn't want to lose Curtan's support.”"]** — Mówca: **Player**
> "“I didn't want to lose Curtan's support.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1"*)

### Węzeł `[68]`
Mówca: **Monica**
> "“I am what?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Monica: "“No, no. No you didn't. How is this even legal?""*)

### Węzeł `[69]`
Mówca: **Monica**
> "“No, no. No you didn't. How is this even legal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Monica: "“You...You betrayed me.”"*)

### Węzeł `[70]`
Mówca: **Monica**
> "“You...You betrayed me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "Tears were rolling down from her cheeks."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Monica Told Barred`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 3"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monica Supported Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "Monica Supported Hub"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monica Angry Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "Monica Angry Hub"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_Monica_Barred == true)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: "“I have to tell you something. I made a deal with Curtan.”"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_Monica_Barred == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: "“If you are going to succeed in this, you have to be stro..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“I have to tell you something. I made a deal with Curtan.”"]** — Mówca: **Player**
> "“I have to tell you something. I made a deal with Curtan.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Monica: "“What kind of deal?""*)

### Węzeł `[78]`
Mówca: **Monica**
> "“What kind of deal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: "“In return for his support, he asked me to bar you from p..."*)
  - -> `[80]` (*Player_Italic: "Hand her the written agreement barring Monica from politics."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "“In return for his support, he asked me to bar you from politics. I accepted.”"]** — Mówca: **Player**
> "“In return for his support, he asked me to bar you from politics. I accepted.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "I handed her my agreement with Curtan. She started readin..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "Hand her the written agreement barring Monica from politics."]** — Mówca: **Player_Italic**
> "I handed her the written agreement barring Monica from politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "She looked at the page, eyes wide with disbelief."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "She looked at the page, eyes wide with disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monica Told Barred]"*)

### Węzeł `[82]`
Mówca: **Narrator**
> "I handed her my agreement with Curtan. She started reading it, eyes wide with disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monica Told Barred]"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monica Told Barred]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "Monica Told Barred"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monica Told Barred]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "Monica Told Barred"*)

### Węzeł `[85]`
**[WYBÓR GRACZA: "“Sometimes you have to make sacrifices for the good of the country. You've got to learn that if you want to enter politics.”"]** — Mówca: **Player**
> "“Sometimes you have to make sacrifices for the good of the country. You've got to learn that if you want to enter politics.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1"*)

### Węzeł `[86]`
Mówca: **Monica**
> "“But why did the sacrifice have to be me? Never mind. You had your reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "There was a brief silence."*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "“I'll give you one more chance. But this time I won't tolerate it if it meddles with how I run the country.”"]** — Mówca: **Player**
> "“I'll give you one more chance. But this time I won't tolerate it if it meddles with how I run the country.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1"*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "“You always have my support. I failed you this time -- it won't happen again.""]** — Mówca: **Player**
> "“You always have my support. I failed you this time -- it won't happen again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1"*)

### Węzeł `[89]`
Mówca: **Monica**
> "“I-- I can live with that, I suppose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monica Asks For Support Again]"*)

### Węzeł `[90]`
Mówca: **Monica**
> "“I-- Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monica Asks For Support Again]"*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "“No. I was right not to let you speak at the festival. Next time, I won't bring you at all.""]** — Mówca: **Player**
> "“No. I was right not to let you speak at the festival. Next time, I won't bring you at all.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"]) == false`
- **Kontekst wejściowy (poprzednik):** `[188]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1"*)

### Węzeł `[92]`
Mówca: **Narrator**
> "Monica turned pale with anger. I had never seen her like this."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Monica: "“Far be it from me to disagree with the President.""*)

### Węzeł `[93]`
Mówca: **Monica**
> "“Far be it from me to disagree with the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Monica: "“But know this. I will never forget about what you did. N..."*)

### Węzeł `[94]`
Mówca: **Monica**
> ""I see. That's where your priorities lie.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "There was a brief silence."*)

### Węzeł `[95]`
Mówca: **Monica**
> "“But know this. I will never forget about what you did. Never!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "There was a noise from the balcony door. We both turned o..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA: "“I was afraid I'd make you look weak by stepping in.”"]** — Mówca: **Player**
> "“I was afraid I'd make you look weak by stepping in.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1"*)

### Węzeł `[97]`
Mówca: **Monica**
> "“I-- I suppose I can appreciate that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "There was a brief silence."*)

### Węzeł `[98]`
Mówca: **Monica**
> "“There is another chance, you know. For you to show your *real* support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monica Asks For Support Again]"*)

### Węzeł `[99]`
Mówca: **Narrator**
> "There was a brief silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Monica: "“There is another chance, you know. For you to show your ..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Monica Asks For Support Again`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech"*)

### Węzeł `[101]`
Mówca: **Monica**
> "“Perhaps the festival wasn't the proper forum to air my views on women's rights. But I still need to do this, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Monica: "“I want to officially adopt this cause as First Lady. To ..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monica Asks For Support Again]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "Monica Asks For Support Again"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monica Asks For Support Again]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "Monica Asks For Support Again"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monica Asks For Support Again]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "Monica Asks For Support Again"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monica Asks For Support Again]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "Monica Asks For Support Again"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monica Asks For Support Again]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "Monica Asks For Support Again"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_Monica_Barred == true)"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: "“I don't think so. You left me no choice but to make a de..."*)
  - -> `[111]` (*Player: "“I'm so sorry. I had to make a deal with Curtan.”"*)
  - -> `[120]` (*Player: "“I'm sorry, but no. Leave politics to the politicians. I ..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_Monica_Barred == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: "“Of course, my love. I'm looking forward to working close..."*)
  - -> `[120]` (*Player: "“I'm sorry, but no. Leave politics to the politicians. I ..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "“I don't think so. You left me no choice but to make a deal with Curtan.”"]** — Mówca: **Player**
> "“I don't think so. You left me no choice but to make a deal with Curtan.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Kontekst wejściowy (poprzednik):** `[325]` (Monica), `[326]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Monica: "“What kind of deal?”"*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "“I'm so sorry. I had to make a deal with Curtan.”"]** — Mówca: **Player**
> "“I'm so sorry. I had to make a deal with Curtan.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Kontekst wejściowy (poprzednik):** `[325]` (Monica), `[326]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Monica: "“What kind of deal?”"*)

### Węzeł `[112]`
Mówca: **Monica**
> "“What kind of deal?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: "“The only way he would let the festival debacle go was if..."*)
  - -> `[114]` (*Player_Italic: "Hand her your written agreement barring Monica from polit..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monica Told Barred]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "Monica Told Barred"*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "Hand her your written agreement barring Monica from politics."]** — Mówca: **Player_Italic**
> "I handed her my written agreement with Curtan barring Monica from politics."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "She looked at the page, her eyes wide with disbelief."*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "“The only way he would let the festival debacle go was if I barred you from politics.”"]** — Mówca: **Player**
> "“The only way he would let the festival debacle go was if I barred you from politics.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "I handed her our written agreement."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "I handed her our written agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monica Told Barred]"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monica Told Barred]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "Monica Told Barred"*)

### Węzeł `[118]`
Mówca: **Narrator**
> "She looked at the page, her eyes wide with disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monica Told Barred]"*)

### Węzeł `[119]`
**[WYBÓR GRACZA: "“Of course, my love. I'm looking forward to working closer together.”"]** — Mówca: **Player**
> ""Of course, my love. I'm looking forward to working closer together.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[325]` (Monica), `[326]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1"*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "“I'm sorry, but no. Leave politics to the politicians. I promise I'll pass the reforms you want.""]** — Mówca: **Player**
> "“I'm sorry, but no. Leave politics to the politicians. I promise I'll pass the reforms you want.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Kontekst wejściowy (poprzednik):** `[325]` (Monica), `[326]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 3"*)

### Węzeł `[121]`
Mówca: **Narrator**
> "Monica turned pale with anger. I had never seen her like this."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Monica: "“You know what? Fine.”"*)

### Węzeł `[122]`
Mówca: **Monica**
> "“You know what? Fine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Monica: "“But know this. I will never forget how you let me down. ..."*)

### Węzeł `[123]`
Mówca: **Monica**
> "“But know this. I will never forget how you let me down. Never!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "A noise came from the balcony door. We both turned our he..."*)

### Węzeł `[124]`
Mówca: **Monica**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "A noise came from the balcony door. We both turned our he..."*)

### Węzeł `[125]`
Mówca: **Monica**
> "“I want to officially adopt this cause as First Lady. To actually get involved in politics, not just give impromptu speeches. I could even help your education minister with those reforms she's working on...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_SupportWomensRights"*)

### Węzeł `[126]`
Mówca: **Narrator**
> "Tears were rolling down from her cheeks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Monica: ""All those years by your side, playing the doting wife...""*)

### Węzeł `[127]`
Mówca: **Monica**
> ""All those years by your side, playing the doting wife...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Monica: "“Who was there when everything was about to collapse? Who..."*)

### Węzeł `[128]`
Mówca: **Monica**
> "“Who was there when everything was about to collapse? Who was there when nobody else was? Me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Monica: "“And this is how you repay me?""*)

### Węzeł `[129]`
Mówca: **Monica**
> "“And this is how you repay me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Monica: "“You selfish pig. You ungrateful bastard. You...""*)

### Węzeł `[130]`
Mówca: **Monica**
> "“You selfish pig. You ungrateful bastard. You...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Monica: "“Coward!”"*)

### Węzeł `[131]`
Mówca: **Monica**
> "“Coward!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player: "“Monica, I am so sorry. I tried my best.""*)
  - -> `[133]` (*Player_Italic: "Slap her."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "“Monica, I am so sorry. I tried my best.""]** — Mówca: **Player**
> "“Monica, I am so sorry. I tried my best.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Monica: ""You did no such thing! You used your own wife as a barga..."*)

### Węzeł `[133]`
**[WYBÓR GRACZA: "Slap her."]** — Mówca: **Player_Italic**
> "I slapped her, and she fell to the balcony floor. She looked up at me in complete and utter shock."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 3"*)

### Węzeł `[134]`
Mówca: **Monica**
> ""You did no such thing! You used your own wife as a bargaining chip!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Monica: "“I don't think I can forgive this, Anton...""*)

### Węzeł `[135]`
Mówca: **Monica**
> "“I don't think I can forgive this, Anton...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "A noise came from the balcony door. We both turned our he..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA: ""Monica, I'm so sorry. This is not who I am.""]** — Mówca: **Player**
> ""Monica, I'm so sorry. This is not who I am.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Narrator: "Monica stood up."*)

### Węzeł `[137]`
Mówca: **Narrator**
> "What seemed like an eternity passed. She did not move."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player: ""Monica, I'm so sorry. This is not who I am.""*)
  - -> `[138]` (*Player: "“This is what happens when you insult the president.""*)
  - -> `[140]` (*Player_Italic: "Help her up."*)

### Węzeł `[138]`
**[WYBÓR GRACZA: "“This is what happens when you insult the president.""]** — Mówca: **Player**
> "“This is what happens when you insult the president.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 2"*)

### Węzeł `[139]`
Mówca: **Monica**
> "“You've changed, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Monica: "“You're no longer the man I married.”"*)

### Węzeł `[140]`
**[WYBÓR GRACZA: "Help her up."]** — Mówca: **Player_Italic**
> "I extended a hand to help her up."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "She slapped it out of the way and stood up herself."*)

### Węzeł `[141]`
Mówca: **Monica**
> "“You're no longer the man I married.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "There was a noise from the balcony door. We both turned o..."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "She slapped it out of the way and stood up herself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Monica: "“You've changed, Anton.”"*)

### Węzeł `[143]`
Mówca: **Narrator**
> "There was a noise from the balcony door. We both turned our heads to see Deana standing there, a fearful look in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Deana: "“Papa. Why did you hit Mama?”"*)

### Węzeł `[144]`
Mówca: **Deana**
> "“Papa. Why did you hit Mama?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Player: "“It's nothing. We were just having an argument.”"*)
  - -> `[148]` (*Player_Italic: "Stay silent."*)
  - -> `[146]` (*Player: "“Deana, go to your room. NOW!”"*)

### Węzeł `[145]`
**[WYBÓR GRACZA: "“It's nothing. We were just having an argument.”"]** — Mówca: **Player**
> "“It's nothing. We were just having an argument.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Monica: "“Come on, Deana. Lets go to the kitchen.”"*)

### Węzeł `[146]`
**[WYBÓR GRACZA: "“Deana, go to your room. NOW!”"]** — Mówca: **Player**
> "“Deana, go to your room. NOW!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1"*)

### Węzeł `[147]`
Mówca: **Monica**
> "“Stop yelling at her! Deana, let's go to the kitchen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "Monica pierced me with her eyes one more time as they lef..."*)

### Węzeł `[148]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Monica: "“Come on, Deana. Lets go to the kitchen.”"*)

### Węzeł `[149]`
Mówca: **Monica**
> "“Come on, Deana. Lets go to the kitchen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "Monica pierced me with her eyes one more time as they lef..."*)

### Węzeł `[150]`
Mówca: **Narrator**
> "Monica pierced me with her eyes one more time as they left the balcony and closed the door behind them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "Her words repeated in my head again and again."*)

### Węzeł `[151]`
Mówca: **Narrator**
> "Her words repeated in my head again and again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "“Coward.”"*)

### Węzeł `[152]`
Mówca: **Narrator**
> "“You're no longer the man I married.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "She was right."*)

### Węzeł `[153]`
Mówca: **Narrator**
> "She was right."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "What had I done?"*)

### Węzeł `[154]`
Mówca: **Narrator**
> "What had I done?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Personal_MonicaTalk = true"*)

### Węzeł `[155]`
Mówca: **Narrator**
> "Her words repeated in my head again and again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "“Coward.”"*)

### Węzeł `[156]`
Mówca: **Narrator**
> "A noise came from the balcony door. We both turned our heads to see Deana standing there, a confused look in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Deana: "“Papa. Mama. Why are you fighting?”"*)

### Węzeł `[157]`
Mówca: **Deana**
> "“Papa. Mama. Why are you fighting?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Player: "“It's nothing. We were just...talking about work.”"*)
  - -> `[159]` (*Player_Italic: "Stay silent."*)

### Węzeł `[158]`
**[WYBÓR GRACZA: "“It's nothing. We were just...talking about work.”"]** — Mówca: **Player**
> "“It's nothing. We were just...talking about work.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Monica: "“Yes, it's nothing. Your papa and I were just having a li..."*)

### Węzeł `[159]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[157]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Monica: "“It's nothing. Your papa and I were just having a little ..."*)

### Węzeł `[160]`
Mówca: **Monica**
> "“Yes, it's nothing. Your papa and I were just having a little disagreement. Come on, Deana. Lets go to the kitchen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "Monica pierced me with her eyes one more time as they lef..."*)

### Węzeł `[161]`
Mówca: **Narrator**
> "She was right."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Personal_MonicaTalk = true"*)

### Węzeł `[162]`
Mówca: **Narrator**
> "I thought to myself..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "She was right."*)

### Węzeł `[163]`
Mówca: **Narrator**
> "“Coward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "I thought to myself..."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "Monica pierced me with her eyes one more time as they left the balcony and closed the door behind them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "Her words repeated in my head again and again."*)

### Węzeł `[165]`
Mówca: **Monica**
> "“It's nothing. Your papa and I were just having a little disagreement. Come on, Deana. Lets go to the kitchen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "Monica pierced me with her eyes one more time as they lef..."*)

### Węzeł `[166]`
Mówca: **Narrator**
> "“Coward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "“You're no longer the man I married.”"*)

### Węzeł `[167]`
Mówca: **Narrator**
> "A noise came from the balcony door. We both turned our heads to see Deana standing there, a confused look in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Deana: "“Papa. Mama. Why are you fighting?”"*)

### Węzeł `[168]`
Mówca: **Deana**
> "“Papa. Mama. Why are you fighting?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: "“It's nothing. We were just...talking about work.”"*)
  - -> `[170]` (*Player_Italic: "Stay silent."*)

### Węzeł `[169]`
**[WYBÓR GRACZA: "“It's nothing. We were just...talking about work.”"]** — Mówca: **Player**
> "“It's nothing. We were just...talking about work.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Monica: "“Yes, it's nothing. Your papa and I were just having a li..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Monica: "“It's nothing. Your papa and I were just having a little ..."*)

### Węzeł `[171]`
Mówca: **Narrator**
> "Monica pierced me with her eyes as they left the balcony and closed the door behind them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "Her words repeated in my head again and again."*)

### Węzeł `[172]`
Mówca: **Monica**
> "“It's nothing. Your papa and I were just having a little disagreement. Come on, Deana. Lets go to the kitchen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "Monica pierced me with her eyes as they left the balcony ..."*)

### Węzeł `[173]`
Mówca: **Narrator**
> "She was never going to."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Personal_MonicaTalk = true"*)

### Węzeł `[174]`
Mówca: **Narrator**
> ""I will never forget how you let me down. Never!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "I thought to myself..."*)

### Węzeł `[175]`
Mówca: **Narrator**
> "Her words repeated in my head again and again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: ""I will never forget how you let me down. Never!""*)

### Węzeł `[176]`
Mówca: **Monica**
> "“Yes, it's nothing. Your papa and I were just having a little disagreement. Come on, Deana. Lets go to the kitchen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "Monica pierced me with her eyes as they left the balcony ..."*)

### Węzeł `[177]`
Mówca: **Narrator**
> "I thought to myself..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "She was never going to."*)

### Węzeł `[178]`
Mówca: **Narrator**
> "A noise came from the balcony door. We both turned our heads to see Deana standing there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Deana: "“Mama, I'm hungry.”"*)

### Węzeł `[179]`
Mówca: **Deana**
> "“Mama, I'm hungry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Monica: "“Lets go to the kitchen, baby. We'll make Papa the best s..."*)

### Węzeł `[180]`
Mówca: **Monica**
> "“Lets go to the kitchen, baby. We'll make Papa the best snack ever!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Deana: "“Yeah!”"*)

### Węzeł `[181]`
Mówca: **Deana**
> "“Yeah!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "They left the balcony and returned half an hour later wit..."*)

### Węzeł `[182]`
Mówca: **Narrator**
> "They left the balcony and returned half an hour later with a large cookie. Deana had written my name in icing on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "As I sipped my coffee and nibbled the cookie, I thought t..."*)

### Węzeł `[183]`
Mówca: **Narrator**
> "As I sipped my coffee and nibbled the cookie, I thought that I had made the right choice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Things were going to get harder, but at least my life at ..."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "Things were going to get harder, but at least my life at home was somewhat..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Peaceful."*)

### Węzeł `[185]`
Mówca: **Narrator**
> "Peaceful."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Personal_MonicaTalk = true"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn05_Personal_MonicaTalk = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn05_Personal_MonicaTalk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)

### Węzeł `[187]`
Mówca: **Monica**
> "“I'm not sure I can forgive you for this, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Monica: "“But you do have one more chance to make it up to me. And..."*)

### Węzeł `[188]`
Mówca: **Monica**
> "“But you do have one more chance to make it up to me. And offer your *real* support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech"*)
  - -> `[88]` (*Player: "“You always have my support. I failed you this time -- it..."*)
  - -> `[87]` (*Player: "“I'll give you one more chance. But this time I won't tol..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Slapped = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Slapped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "What seemed like an eternity passed. She did not move."*)

### Węzeł `[190]`
Mówca: **Narrator**
> "There was a noise from the balcony door. We both turned our heads to see Deana standing there, a confused look in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Deana: "“Papa. Mama. Why are you fighting?”"*)

### Węzeł `[191]`
Mówca: **Deana**
> "“Papa. Mama. Why are you fighting?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Player: "“It's nothing. We were just... talking about work.”"*)
  - -> `[195]` (*Player_Italic: "Stay silent."*)

### Węzeł `[192]`
**[WYBÓR GRACZA: "“It's nothing. We were just... talking about work.”"]** — Mówca: **Player**
> "“It's nothing. We were just... talking about work.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Monica: "“Your father is right. We were just having a little disag..."*)

### Węzeł `[193]`
Mówca: **Narrator**
> "Monica pierced me with her eyes one more time as they left the balcony and closed the door behind them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Narrator: "Her words repeated in my head, again and again."*)

### Węzeł `[194]`
Mówca: **Monica**
> "“Your father is right. We were just having a little disagreement. Come on, Deana. Lets go to the kitchen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "Monica pierced me with her eyes one more time as they lef..."*)

### Węzeł `[195]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Monica: "“It's nothing. Your papa and I were just having a little ..."*)

### Węzeł `[196]`
Mówca: **Narrator**
> "Her words repeated in my head, again and again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Narrator: "“I will never forget about what you did. Never!”"*)

### Węzeł `[197]`
Mówca: **Monica**
> "“It's nothing. Your papa and I were just having a little disagreement. Come on, Deana. Lets go to the kitchen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "Monica pierced me with her eyes one more time as they lef..."*)

### Węzeł `[198]`
Mówca: **Narrator**
> "“I will never forget about what you did. Never!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Personal_MonicaTalk = true"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_P_SupportedMonicaAtConfrontation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_P_SupportedMonicaAtConfrontation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion <0"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Her eyes filled with gratitude. I could see she'd slept a..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Monica: "“I'm not sure I can forgive you for this, Anton.”"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Monica: "“I-- Thank you.”"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Monica: "“I-- I can live with that, I suppose.”"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "Monica turned pale with anger. I had never seen her like ..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 3`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Monica: "“I am what?!”"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 3`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Slapped = true"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Narrator: "Monica stood up."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Monica: "“Stop yelling at her! Deana, let's go to the kitchen.”"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == false && BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == false && BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == false..."*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == fal..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == false && BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == false && BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == false  and  Variable["BaseGame.Turn05_SnO_LE_Policy_CommunityPolice"] == false  and  Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_SnO_FoundedPolice = true"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == false && BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == false && BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == false  and  Variable["BaseGame.Turn05_SnO_LE_Policy_CommunityPolice"] == false  and  Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == false"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn05_SnO_FoundedPolice = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn05_SnO_FoundedPolice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == false"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == t..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Conriat", "City_UCAccess");"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == false..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Erlory_ArcasianBase = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Erlory_ArcasianBase"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == false..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true"*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true)"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Erlory", "City_ArcasiaAcces..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Conriat_UCBase = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Conriat_UCBase"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == false..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 6 && BaseGame.GovernmentBudget >= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 6 && BaseGame.GovernmentBudget >= -5"*)
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 6 && BaseGame.GovernmentBudget >= -5)"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 6 && BaseGame.GovernmentBudget >= -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 6  and  Variable["BaseGame.GovernmentBudget"] >= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Lachaven_EconomyGreat = true"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 6 && BaseGame.GovernmentBudget >= -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 6  and  Variable["BaseGame.GovernmentBudget"] >= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 4 && BaseGame.GovernmentBudget >= -3"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 4 && BaseGame.GovernmentBudget >= -3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 4 && BaseGame.GovernmentBudget >= -3"*)
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 4 && BaseGame.GovernmentBudget >= -3)"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 4 && BaseGame.GovernmentBudget >= -3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 4  and  Variable["BaseGame.GovernmentBudget"] >= -3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Lachaven_EconomyGood = true"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 4 && BaseGame.GovernmentBudget >= -3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 4  and  Variable["BaseGame.GovernmentBudget"] >= -3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 2 && BaseGame.GovernmentBudget >= -1"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 2 && BaseGame.GovernmentBudget >= -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 2 && BaseGame.GovernmentBudget >= -1"*)
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy >= 2 && BaseGame.GovernmentBudget >= -1)"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy >= 2 && BaseGame.GovernmentBudget >= -1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] >= 2  and  Variable["BaseGame.GovernmentBudget"] >= -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Lachaven_EconomyOkay = true"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy >= 2 && BaseGame.GovernmentBudget >= -1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 2  and  Variable["BaseGame.GovernmentBudget"] >= -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Lachaven_EconomyAutocrat = ..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Lachaven_EconomyBad = true"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Lachaven_EconomyGreat = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Lachaven_EconomyGreat"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Lachaven_EconomyGood = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Lachaven_EconomyGood"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Lachaven_EconomyOkay = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Lachaven_EconomyOkay"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Lachaven_EconomyAutocrat = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Lachaven_EconomyAutocrat"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Lachaven_EconomyBad = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Lachaven_EconomyBad"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == true && BaseGame.Relations_Monica_SupportedAtFestival == true && BaseGame.Turn05_Personal_Festival_Force == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true && BaseGame..."*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_P_Monica_Benfi_Speech == true && BaseGa..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == true && BaseGame.Relations_Monica_SupportedAtFestival == true && BaseGame.Turn05_Personal_Festival_Force == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true  and  Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true  and  Variable["BaseGame.Turn05_Personal_Festival_Force"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_LT_Benfi_Monica_Listened = true"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_P_Monica_Benfi_Speech == true && BaseGame.Relations_Monica_SupportedAtFestival == true && BaseGame.Turn05_Personal_Festival_Force == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true  and  Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true  and  Variable["BaseGame.Turn05_Personal_Festival_Force"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival == false"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == false && BaseGame.Relations_Monica_SupportedAtFestival == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == false && BaseGam..."*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_P_Monica_Benfi_Speech == false && BaseG..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == false && BaseGame.Relations_Monica_SupportedAtFestival == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == false  and  Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_LT_Benfi_Curtan_MonicaSupport..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_P_Monica_Benfi_Speech == false && BaseGame.Relations_Monica_SupportedAtFestival == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == false  and  Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == false && BaseGam..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == false && BaseGame.Relations_Monica_SupportedAtFestival == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == false && BaseGam..."*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_P_Monica_Benfi_Speech == false && BaseG..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == false && BaseGame.Relations_Monica_SupportedAtFestival == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == false  and  Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_LT_Benfi_Curtan_MonicaShutDow..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_P_Monica_Benfi_Speech == false && BaseGame.Relations_Monica_SupportedAtFestival == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == false  and  Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true && BaseGame..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_LT_Benfi_Curtan_MonicaSupported = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_Benfi_Curtan_MonicaSupported"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_LT_Benfi_Curtan_MonicaShutDown = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_Benfi_Curtan_MonicaShutDown"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_LT_Benfi_Monica_Listened = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_Benfi_Monica_Listened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_Benfi_Curtan_MonicaShutDow..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_Benfi_Curtan_MonicaShutDown_NoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_Benfi_Curtan_MonicaShutDown_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival == false"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_SupportedAtFestival == false)"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_LT_Benfi_Monica_ShutDown = true"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_SupportedAtFestival == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_LT_Benfi_Monica_ShutDown = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_Benfi_Monica_ShutDown"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteKicked == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true"*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Personal_Festival_LesteKicked == true)"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteKicked == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Personal_Festival_LesteKicked == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanLeftorK..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanKicked_..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanLeftorK..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanLeft_No..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Media_Influenced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Media_Influenced == true"*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_Media_Influenced == true)"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Media_Influenced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Media_Influenced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanLeftorK..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_Media_Influenced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Media_Influenced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanKicked_..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Media_Influenced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Media_Influenced == true"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_Media_Influenced == true)"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Media_Influenced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Media_Influenced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanLeftorK..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_Media_Influenced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Media_Influenced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanLeft_No..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanLeftorKicked_Deal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanLeftorKicked_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Media_Influenced == true"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanLeftorKicked_Media = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanLeftorKicked_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanKicked_NoMedia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanKicked_NoMedia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanLeftorKicked_Deal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanLeftorKicked_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Media_Influenced == true"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanLeftorKicked_Media = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanLeftorKicked_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanLeft_NoMedia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanLeft_NoMedia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanKicked_NoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanKicked_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanKicked_..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanLeft_NoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanLeft_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanLeft_No..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_Monica_Barred == true)"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_HP_CurtanApologizes = true"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_Monica_Barred == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 6 && BaseGame.GovernmentBudget >= -5"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_HP_CurtanApologizes = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_CurtanApologizes"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy >= 6 && BaseGame.GovernmentBudget >= -5"*)

### Węzeł `[286]`
**[WYBÓR GRACZA: "“What's that supposed to mean?”"]** — Mówca: **Player**
> "“What's that supposed to mean?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Monica: "“Oh, you know what it means.""*)

### Węzeł `[287]`
Mówca: **Monica**
> "“Oh, you know what it means.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "She looked down at the pieces of torn newspaper."*)

### Węzeł `[288]`
Mówca: **Narrator**
> "She looked down at the pieces of torn newspaper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 2"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival == true"*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_SupportedAtFestival == true)"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monica Supported Hub]"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_SupportedAtFestival == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monica Angry Hub]"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival == true"*)
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_SupportedAtFestival == true)"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "Some of the papers came out in full support of the First ..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_SupportedAtFestival == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "A few of the papers came out in support of the First Lady..."*)

### Węzeł `[295]`
Mówca: **Narrator**
> "A few of the papers came out in support of the First Lady for her brave speech, while denigrating Curtan for his rude interruption. But most agreed that Monica had humiliated herself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "I could only imagine what would have happened if I had le..."*)

### Węzeł `[296]`
Mówca: **Narrator**
> "I could only imagine what would have happened if I had let her continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "I was putting the last newspaper down as Monica joined me..."*)

### Węzeł `[297]`
Mówca: **Narrator**
> "Nearly all of them agreed that the First Lady had acquitted herself very well following the interruption."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "I was putting the last newspaper down as Monica joined me..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_P_Monica_Benfi_Speech == true)"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Monica: ""Anton, how could you? You knew how important that speech..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_P_Monica_Benfi_Speech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Monica: ""Anton, how could you? First you deny me the opportunity ..."*)

### Węzeł `[301]`
Mówca: **Monica**
> ""Anton, how could you? You knew how important that speech was to me, and you let that dinosaur Leste make a mockery of me and my cause!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "She grabbed one of the newspapers from the top of the sta..."*)

### Węzeł `[302]`
Mówca: **Monica**
> ""Anton, how could you? First you deny me the opportunity to speak at the festival, then you let that dinosaur Leste make a mockery of me and my cause!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "She grabbed one of the newspapers from the top of the sta..."*)

### Węzeł `[303]`
Mówca: **Monica**
> "“What began as an unexpectedly impassioned plea for ladies' rights at the opening of the Benfi Festival turned into a circus sideshow as First Lady Monica Rayne failed to counter the rightful objections of the Mayor of Anrica, Curtan Leste.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Monica: "“Powerless to defend herself from this challenge, she tur..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_P_Monica_Benfi_Speech == true)"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Monica: "“What began as an unexpectedly impassioned plea for ladie..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_P_Monica_Benfi_Speech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Monica: "“With her shameful outburst at Anrica mayor Curtan Leste,..."*)

### Węzeł `[307]`
**[WYBÓR GRACZA: "“No. I was wrong to have let you speak at the festival. I won't make the same mistake again.""]** — Mówca: **Player**
> "“No. I was wrong to have let you speak at the festival. I won't make the same mistake again.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"]`
- **Kontekst wejściowy (poprzednik):** `[188]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech"*)
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_P_Monica_Benfi_Speech)"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Player: "“No. I was wrong to have let you speak at the festival. I..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_P_Monica_Benfi_Speech)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: "“No. I was right not to let you speak at the festival. Ne..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech"*)
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_P_Monica_Benfi_Speech)"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_Force"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_P_Monica_Benfi_Speech)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Monica: "“Perhaps the festival wasn't the proper forum to air my v..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_Force`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_Force"*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Personal_Festival_Force)"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_Force`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_Force"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Monica: ""All that business with Leste at the festival distracted ..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Personal_Festival_Force)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_Force"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival"*)

### Węzeł `[317]`
Mówca: **Monica**
> ""All that business with Leste at the festival distracted from my real message. I'm still not giving up on women's rights, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Monica: "“I want to officially adopt this cause as First Lady. To ..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival"*)
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_SupportedAtFestival)"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Monica: ""When I gave that speech, I saw hope in the eyes of all t..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_SupportedAtFestival)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_SupportedAtFestival"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Monica: "“Perhaps the festival wasn't the proper forum to air my v..."*)

### Węzeł `[321]`
Mówca: **Monica**
> ""When I gave that speech, I saw hope in the eyes of all the women in the audience. This is the right path for me, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Monica: "“I want to officially adopt this cause as First Lady. To ..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_SupportWomensRights`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_SupportWomensRights"*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_SupportWomensRights)"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_SupportWomensRights`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_SupportWomensRights"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Monica: ""I know this is something you're passionate about as well..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_SupportWomensRights)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_SupportWomensRights"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Monica: ""I know this isn't an urgent issue for you. But it's vita..."*)

### Węzeł `[325]`
Mówca: **Monica**
> ""I know this isn't an urgent issue for you. But it's vital to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)

### Węzeł `[326]`
Mówca: **Monica**
> ""I know this is something you're passionate about as well. Can I count on you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion <0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion <0"*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Opinion <0)"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion <0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Opinion"] <0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Monica: ""Good.""*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Opinion <0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Opinion"] <0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Monica: ""Oh, Anton. This means so much to me!""*)

### Węzeł `[330]`
Mówca: **Monica**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Narrator: "Monica gave me a quick hug."*)

### Węzeł `[331]`
Mówca: **Monica**
> ""Oh, Anton. This means so much to me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Narrator: "Monica hugged me tightly, and I felt some of the past day..."*)

### Węzeł `[332]`
Mówca: **Narrator**
> "Monica hugged me tightly, and I felt some of the past day's tension melt away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Monica: "“Thank you.”"*)

### Węzeł `[333]`
Mówca: **Narrator**
> "Monica gave me a quick hug."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Monica: "“Thank you.”"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Media_Influenced`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Media_Influenced"*)
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_Media_Influenced)"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Media_Influenced`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Media_Influenced"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Player: "“I'm rather busy, but all right.”"*)
  - -> `[339]` (*Player_Italic: "Gesture for her to sit down."*)
  - -> `[338]` (*Player: "“Of course. what is it?”"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_Media_Influenced)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Media_Influenced"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: "“If this is about the news, I know what you are going to ..."*)
  - -> `[33]` (*Player_Italic: "Gesture for her to sit down."*)
  - -> `[32]` (*Player: "“Of course. What is it?”"*)

### Węzeł `[337]`
**[WYBÓR GRACZA: "“I'm rather busy, but all right.”"]** — Mówca: **Player**
> "“I'm rather busy, but all right.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_Admin_Media_Influenced"]`
- **Kontekst wejściowy (poprzednik):** `[29]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Monica: ""I've been reading the papers, too. I'm happy the confron..."*)

### Węzeł `[338]`
**[WYBÓR GRACZA: "“Of course. what is it?”"]** — Mówca: **Player**
> "“Of course. What is it?”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_Admin_Media_Influenced"]`
- **Kontekst wejściowy (poprzednik):** `[29]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Monica: ""I've been reading the papers, too. I'm happy the confron..."*)

### Węzeł `[339]`
**[WYBÓR GRACZA: "Gesture for her to sit down."]** — Mówca: **Player_Italic**
> "I gestured towards the chair next to me. She sat down."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_Admin_Media_Influenced"]`
- **Kontekst wejściowy (poprzednik):** `[29]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Monica: ""I've been reading the papers, too. I'm happy the confron..."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_News_Contained`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_News_Contained"*)
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_News_Contained)"*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_News_Contained`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_News_Contained"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Narrator: "Monica sat and picked up the nearest newspaper. She flipp..."*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_News_Contained)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_News_Contained"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "Monica sat and picked up the nearest newspaper. She point..."*)

### Węzeł `[343]`
Mówca: **Narrator**
> "Monica sat and picked up the nearest newspaper. She pointed to a particularly insulting headline on the front page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Monica: "“I never in a million years would have wished for this, A..."*)

### Węzeł `[344]`
Mówca: **Narrator**
> "Monica sat and picked up the nearest newspaper. She flipped it open to the article about Curtan's apology."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Monica: "“I'm glad that beast admitted he was in the wrong. But it..."*)

### Węzeł `[345]`
Mówca: **Monica**
> ""I've been reading the papers, too. I'm happy the confrontation with Curtan didn't seem to have caused much damage. But it could have gone so much worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true"*)

### Węzeł `[346]`
Mówca: **Monica**
> "“I'm glad that beast admitted he was in the wrong. But it could very easily have gone another way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true"*)

### Węzeł `[347]`
Mówca: **Monica**
> "“I never in a million years would have wished for this, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true"*)

### Węzeł `[348]`
**[WYBÓR GRACZA: "“It's okay. I've had Curtan fired. That's the last of our troubles with him.""]** — Mówca: **Player**
> "“It's okay. I've had Curtan fired. That's the last of our troubles with him.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true`
- **Kontekst wejściowy (poprzednik):** `[36]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Monica: "“Oh, Anton.”"*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lileas_GendermariePromise == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Lileas_GendermariePromise == true"*)
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Lileas_GendermariePromise == true)"*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Lileas_GendermariePromise == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Player: "“It's okay. I've had Curtan fired. That's the last of our..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Lileas_GendermariePromise == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player_Italic: "Wipe her tears away."*)

### Węzeł `[352]`
Mówca: **Narrator**
> "Monica stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Monica: "“You've changed, Anton.”"*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == false"*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Decrease == false)"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Decision_RumburgBorderReinforcement ..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Decrease == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion >= 10"*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn05_Decision_RumburgBorderReinforcement = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn05_Decision_RumburgBorderReinforcement"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion >= 10"*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_News_Contained == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_News_Contained == true"*)
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_News_Contained == true)"*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_News_Contained == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_News_Contained"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Media_Influenced == true"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_News_Contained == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_News_Contained"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Media_Influenced == true"*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteKicked == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true"*)
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Personal_Festival_LesteKicked == true)"*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteKicked == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 2;"*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Personal_Festival_LesteKicked == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteLeft == true"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteLeft == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteLeft == true"*)
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Personal_Festival_LesteLeft == true)"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteLeft == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteLeft"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1;"*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Personal_Festival_LesteLeft == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteLeft"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 1;"*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Monica: "“I just wanted to thank you for supporting me, and apolog..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Monica: "“I just wanted to thank you for supporting me, and apolog..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Monica: "“I just wanted to thank you for supporting me, and apolog..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Monica: "“I just wanted to thank you for supporting me, and apolog..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteLeft == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteLeft == true"*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Personal_Festival_LesteLeft == true)"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteLeft == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteLeft"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 2;"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Personal_Festival_LesteLeft == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteLeft"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Monica: "“I just wanted to thank you for supporting me, and apolog..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 5;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Monica: "“I just wanted to thank you for supporting me, and apolog..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteKicked == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true"*)
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Personal_Festival_LesteKicked == true)"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteKicked == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 5;"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Personal_Festival_LesteKicked == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteLeft == true"*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Monica: "“So, you've seen the news?”"*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Monica: "“Just...tell me why. Couldn't you have said something?""*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Monica: "“But why did the sacrifice have to be me? Never mind. You..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Monica: "“I-- I suppose I can appreciate that.”"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Monica: ""I see. That's where your priorities lie.""*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 3`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "Monica turned pale with anger. I had never seen her like ..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_P_SupportedMonicaAtConfrontation = true"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion >= 10"*)
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion >= 10)"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion >= 10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Holsord_PositiveApproval = ..."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion >= 10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -5"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Holsord_PositiveApproval = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_PositiveApproval"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_RelaxedImmigration == true"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -5"*)
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion <= -5)"*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Holsord_NegativeApproval = ..."*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion <= -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_RelaxedImmigration == true"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Holsord_NegativeApproval = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_NegativeApproval"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_RelaxedImmigration == true"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true"*)
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true)"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Monica: ""You were right. Gloria was right. I made myself look lik..."*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Monica: ""All I wanted was to bring the people of Sordland togethe..."*)

### Węzeł `[395]`
Mówca: **Monica**
> ""You were right. Gloria was right. I made myself look like an idiot and damaged the very cause I was fighting for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "Her eyes were getting moist. A single tear fell onto the ..."*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Erlory", "City_ArcasiaAccess");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Erlory","City_ArcasiaAccess");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Erlory_ArcasianBase = true"*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Conriat", "City_UCAccess");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Conriat","City_UCAccess");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Conriat_UCBase = true"*)

### Węzeł `[398]`
Mówca: **Monica**
> "“With the President providing no support, her challenge to Leste was quickly defeated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Monica: "“The President provided no support.""*)

### Węzeł `[399]`
Mówca: **Monica**
> "“Powerless to defend herself from this challenge, she turned to the President, who provided no support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Monica: "“The President provided no support.""*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_RelaxedImmigration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_RelaxedImmigration == true"*)
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_RelaxedImmigration == true)"*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_RelaxedImmigration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_E_SkilledImmigrationPositive ..."*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_RelaxedImmigration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_TightenedImmigration == true"*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_E_SkilledImmigrationPositive = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_E_SkilledImmigrationPositive"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_HP_LowerClassThreatened = tru..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_TightenedImmigration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_TightenedImmigration == true"*)
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_TightenedImmigration == true)"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_TightenedImmigration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_LT_ImmigrationDecreases = true;"*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_TightenedImmigration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_HP_LowerClassThreatened = tru..."*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_LT_ImmigrationDecreases = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_ImmigrationDecreases"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_HP_LowerClassThreatened = tru..."*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_HP_LowerClassThreatened = true;
BaseGameSupport.News_Turn05_G_CSPRevolutionsDestabilize = true;
BaseGameSupport.News_Turn05_G_QinalIntendsObserver = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_LowerClassThreatened"] = true;
Variable["BaseGameSupport.News_Turn05_G_CSPRevolutionsDestabilize"] = true;
Variable["BaseGameSupport.News_Turn05_G_QinalIntendsObserver"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "End();"*)
