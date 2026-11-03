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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 56

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Relations_Monica_Slapped`
- `BaseGameSupport.Report_Turn05_Lachaven_EconomyAutocrat`
- `BaseGameSupport.Report_Turn05_Lachaven_EconomyBad`
- `BaseGameSupport.Report_Turn05_Lachaven_EconomyGood`
- `BaseGameSupport.Report_Turn05_Lachaven_EconomyGreat`
- `BaseGameSupport.Report_Turn05_Lachaven_EconomyOkay`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[186]` (Monica): `Variable["GameCondition.Turn05_Personal_MonicaTalk"] = true;`
- Węzeł `[189]` (Monica): `Variable["BaseGame.Relations_Monica_Slapped"] = true;`
- Węzeł `[199]` (Monica): `Variable["BaseGame.Turn06_P_SupportedMonicaAtConfrontation"] = true;`
- Węzeł `[200]` (Monica): `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- Węzeł `[201]` (Monica): `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- Węzeł `[202]` (Monica): `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 2;`
- Węzeł `[203]` (Monica): `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- Węzeł `[204]` (Monica): `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- *...oraz 48 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Monica)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It felt like eternity since the Benfi Festival. Had it really only been less than 24 hours?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "I was at home now, drinking an afternoon coffee on my balcony. A stack of newspapers lay by my side. I picked them up one by one, reading and re-reading the articles about the festival."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[5]`
Mówca: **Narrator**
> "I started regretting my decisions. Regardless, it was too late now. The damage was done."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[6]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[8]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_P_Monica_Benfi_Speech == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[9]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Media_Influenced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Media_Influenced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Media_Influenced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[11]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_Media_Influenced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Media_Influenced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[12]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_Force == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_Force == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_Force"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[14]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Personal_Festival_Force == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_Force"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[15]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[17]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_Monica_Barred == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[18]`
Mówca: **Narrator**
> "Some of the newspapers were merciless against Monica for interrupting Curtan during his speech. A few even called for her to be barred from political matters. Others expressed their support."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Narrator**
> "Some of the papers came out in full support of the First Lady for her brave speech. Others took Curtan's side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[20]`
Mówca: **Narrator**
> "In any event, I was relieved that the incident hadn't reflected too badly on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[21]`
Mówca: **Narrator**
> "As expected, the headlines were merciless. I was compared to a dictator for my intolerance of Curtan's opinion. Some even likened me to Tarquin Soll. The knowledge that Curtan would soon be fired provided little comfort."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[22]`
Mówca: **Narrator**
> "As expected, Marcel delivered. There was only a second-page article about Curtan Leste behaving deplorably and leaving the festival in disgrace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Narrator**
> "But my relief was short-lived. Marcel was effective, but he was also a double-edged sword. I couldn't help but think that if someone offered him a better deal, he'd turn on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Narrator**
> "As expected, Curtan delivered. The news was all about his apology for his disgraceful behavior during the festival."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Narrator**
> "I was putting the last newspaper down as Monica joined me on the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[26]`
Mówca: **Narrator**
> "I was putting the last newspaper down as Monica joined me on the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[27]`
Mówca: **Narrator**
> "I was putting the last newspaper down as Monica joined me on the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[28]`
Mówca: **Narrator**
> "I was putting the last newspaper down as Monica joined me on the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[29]`
Mówca: **Monica**
> "“Listen. Can we talk for a bit?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[30]`
Mówca: **Monica**
> "“So, you've seen the news?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`
  - -> `[50]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“If this is about the news, I know what you are going to say.”"]** — Mówca: **Player**
> "“If this is about the news, I know what you are going to say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "“Of course. What is it?”"]** — Mówca: **Player**
> "“Of course. What is it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "Gesture for her to sit down."]** — Mówca: **Player_Italic**
> "I gestured towards the chair next to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[34]`
Mówca: **Monica**
> "“I just wanted to thank you for supporting me, and apologize for creating such a spectacle.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[35]`
Mówca: **Monica**
> ""All I wanted was to bring the people of Sordland together, the way you're able to. But not like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Narrator**
> "Her eyes were getting moist. A single tear fell onto the newsprint."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[38]`
  - -> `[349]`
  - -> `[40]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "Wipe her tears away."]** — Mówca: **Player_Italic**
> "I leaned forward and wiped her tears from her eyes. She clasped my hand to her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“It's okay. Everything is under control.”"]** — Mówca: **Player**
> "“It's okay. Everything is under control.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“If you are going to succeed in this, you have to be stronger. I know you can be.”"]** — Mówca: **Player**
> "“If you are going to succeed in this, you have to be stronger. I know you can be.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "“I did warn you. But you were always stubborn.”"]** — Mówca: **Player**
> "“I did warn you. But you were always stubborn.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Monica**
> "“Oh, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[42]`
Mówca: **Monica**
> "“I know. I'm sorry. But you are right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Narrator**
> "Her eyes filled with gratitude. I could see she'd slept as little as I had since the festival."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Monica**
> "“I am stubborn.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[45]`
Mówca: **Monica**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Monica**
> "“One more thing. You know how stubborn I am.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[47]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Monica Supported Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[48]`
**[WYBÓR GRACZA: ""Monica, I know. We can talk about this--”"]** — Mówca: **Player**
> ""Monica, I know. We can talk about this--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "“What news?”"]** — Mówca: **Player**
> "“What news?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "Do not reply."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Monica**
> "“What is there to talk about? I'm a disgrace with no support from my husband. It says so right here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[63]`
  - -> `[62]`

### Węzeł `[52]`
Mówca: **Monica**
> "“Here, I have it memorized: First Lady disgraced. No support from her husband.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[63]`
  - -> `[62]`

### Węzeł `[53]`
**[WYBÓR GRACZA: ""You shouldn't have spoken out.”"]** — Mówca: **Player**
> ""You shouldn't have spoken out.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[54]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Monica Angry Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[55]`
Mówca: **Narrator**
> "She grabbed one of the newspapers from the top of the stack and started reading out what a columnist wrote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[56]`
Mówca: **Monica**
> "“With her shameful outburst at Anrica mayor Curtan Leste, First Lady Monica Rayne once again proved that politics is an area best left to gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[57]`
Mówca: **Monica**
> "“The President provided no support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Monica**
> "“You can't even stand Leste, and you took his side! While making me look like a fool!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Narrator**
> "She started ripping the newspaper to shreds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Monica**
> "“After all these years by your side, playing the doting wife...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Monica**
> "“You know... my mother was right about you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[286]`
  - -> `[64]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Darling, believe me. My hands were tied.”"]** — Mówca: **Player**
> "“Darling, believe me. My hands were tied.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "Do not reply."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“I'm so sorry. I understand if you never forgive me.”"]** — Mówca: **Player**
> "“I'm so sorry. I understand if you never forgive me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“I thought you were capable of defending yourself. Clearly not.”"]** — Mówca: **Player**
> "“I thought you were capable of defending yourself. Clearly not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[66]`
Mówca: **Monica**
> "“Just...tell me why. Couldn't you have said something?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[85]`
  - -> `[96]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "“I didn't want to lose Curtan's support.”"]** — Mówca: **Player**
> "“I didn't want to lose Curtan's support.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[68]`
Mówca: **Monica**
> "“I am what?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Monica**
> "“No, no. No you didn't. How is this even legal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Monica**
> "“You...You betrayed me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[71]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Monica Told Barred)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[72]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Monica Supported Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[73]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Monica Angry Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[74]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_Monica_Barred == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“I have to tell you something. I made a deal with Curtan.”"]** — Mówca: **Player**
> "“I have to tell you something. I made a deal with Curtan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Monica**
> "“What kind of deal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "“In return for his support, he asked me to bar you from politics. I accepted.”"]** — Mówca: **Player**
> "“In return for his support, he asked me to bar you from politics. I accepted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "Hand her the written agreement barring Monica from politics."]** — Mówca: **Player_Italic**
> "I handed her the written agreement barring Monica from politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Narrator**
> "She looked at the page, eyes wide with disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[82]`
Mówca: **Narrator**
> "I handed her my agreement with Curtan. She started reading it, eyes wide with disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Monica Told Barred])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[84]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Monica Told Barred])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[85]`
**[WYBÓR GRACZA: "“Sometimes you have to make sacrifices for the good of the country. You've got to learn that if you want to enter politics.”"]** — Mówca: **Player**
> "“Sometimes you have to make sacrifices for the good of the country. You've got to learn that if you want to enter politics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[86]`
Mówca: **Monica**
> "“But why did the sacrifice have to be me? Never mind. You had your reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "“I'll give you one more chance. But this time I won't tolerate it if it meddles with how I run the country.”"]** — Mówca: **Player**
> "“I'll give you one more chance. But this time I won't tolerate it if it meddles with how I run the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "“You always have my support. I failed you this time -- it won't happen again.""]** — Mówca: **Player**
> "“You always have my support. I failed you this time -- it won't happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[89]`
Mówca: **Monica**
> "“I-- I can live with that, I suppose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[90]`
Mówca: **Monica**
> "“I-- Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "“No. I was right not to let you speak at the festival. Next time, I won't bring you at all.""]** — Mówca: **Player**
> "“No. I was right not to let you speak at the festival. Next time, I won't bring you at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[92]`
Mówca: **Narrator**
> "Monica turned pale with anger. I had never seen her like this."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Monica**
> "“Far be it from me to disagree with the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Monica**
> ""I see. That's where your priorities lie.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[95]`
Mówca: **Monica**
> "“But know this. I will never forget about what you did. Never!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[96]`
**[WYBÓR GRACZA: "“I was afraid I'd make you look weak by stepping in.”"]** — Mówca: **Player**
> "“I was afraid I'd make you look weak by stepping in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[97]`
Mówca: **Monica**
> "“I-- I suppose I can appreciate that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Monica**
> "“There is another chance, you know. For you to show your *real* support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[99]`
Mówca: **Narrator**
> "There was a brief silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[100]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Monica Asks For Support Again)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[101]`
Mówca: **Monica**
> "“Perhaps the festival wasn't the proper forum to air my views on women's rights. But I still need to do this, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[102]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Monica Asks For Support Again])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[103]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Monica Asks For Support Again])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[104]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Monica Asks For Support Again])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[105]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Monica Asks For Support Again])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[106]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Monica Asks For Support Again])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[107]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`
  - -> `[120]`

### Węzeł `[109]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_Monica_Barred == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "“I don't think so. You left me no choice but to make a deal with Curtan.”"]** — Mówca: **Player**
> "“I don't think so. You left me no choice but to make a deal with Curtan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
**[WYBÓR GRACZA: "“I'm so sorry. I had to make a deal with Curtan.”"]** — Mówca: **Player**
> "“I'm so sorry. I had to make a deal with Curtan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Monica**
> "“What kind of deal?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Monica Told Barred])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[114]`
**[WYBÓR GRACZA: "Hand her your written agreement barring Monica from politics."]** — Mówca: **Player_Italic**
> "I handed her my written agreement with Curtan barring Monica from politics."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "“The only way he would let the festival debacle go was if I barred you from politics.”"]** — Mówca: **Player**
> "“The only way he would let the festival debacle go was if I barred you from politics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Narrator**
> "I handed her our written agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: Jump to: [Monica Told Barred])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[118]`
Mówca: **Narrator**
> "She looked at the page, her eyes wide with disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[119]`
**[WYBÓR GRACZA: "“Of course, my love. I'm looking forward to working closer together.”"]** — Mówca: **Player**
> ""Of course, my love. I'm looking forward to working closer together.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "“I'm sorry, but no. Leave politics to the politicians. I promise I'll pass the reforms you want.""]** — Mówca: **Player**
> "“I'm sorry, but no. Leave politics to the politicians. I promise I'll pass the reforms you want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[121]`
Mówca: **Narrator**
> "Monica turned pale with anger. I had never seen her like this."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Monica**
> "“You know what? Fine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Monica**
> "“But know this. I will never forget how you let me down. Never!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[124]`
Mówca: **Monica**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[125]`
Mówca: **Monica**
> "“I want to officially adopt this cause as First Lady. To actually get involved in politics, not just give impromptu speeches. I could even help your education minister with those reforms she's working on...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[126]`
Mówca: **Narrator**
> "Tears were rolling down from her cheeks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Monica**
> ""All those years by your side, playing the doting wife...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Monica**
> "“Who was there when everything was about to collapse? Who was there when nobody else was? Me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Monica**
> "“And this is how you repay me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Monica**
> "“You selfish pig. You ungrateful bastard. You...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Monica**
> "“Coward!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
**[WYBÓR GRACZA: "“Monica, I am so sorry. I tried my best.""]** — Mówca: **Player**
> "“Monica, I am so sorry. I tried my best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
**[WYBÓR GRACZA: "Slap her."]** — Mówca: **Player_Italic**
> "I slapped her, and she fell to the balcony floor. She looked up at me in complete and utter shock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[134]`
Mówca: **Monica**
> ""You did no such thing! You used your own wife as a bargaining chip!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Monica**
> "“I don't think I can forgive this, Anton...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[136]`
**[WYBÓR GRACZA: ""Monica, I'm so sorry. This is not who I am.""]** — Mówca: **Player**
> ""Monica, I'm so sorry. This is not who I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[137]`
Mówca: **Narrator**
> "What seemed like an eternity passed. She did not move."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[138]`
  - -> `[140]`

### Węzeł `[138]`
**[WYBÓR GRACZA: "“This is what happens when you insult the president.""]** — Mówca: **Player**
> "“This is what happens when you insult the president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[139]`
Mówca: **Monica**
> "“You've changed, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[140]`
**[WYBÓR GRACZA: "Help her up."]** — Mówca: **Player_Italic**
> "I extended a hand to help her up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Monica**
> "“You're no longer the man I married.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Narrator**
> "She slapped it out of the way and stood up herself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[143]`
Mówca: **Narrator**
> "There was a noise from the balcony door. We both turned our heads to see Deana standing there, a fearful look in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Deana**
> "“Papa. Why did you hit Mama?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[148]`
  - -> `[146]`

### Węzeł `[145]`
**[WYBÓR GRACZA: "“It's nothing. We were just having an argument.”"]** — Mówca: **Player**
> "“It's nothing. We were just having an argument.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[146]`
**[WYBÓR GRACZA: "“Deana, go to your room. NOW!”"]** — Mówca: **Player**
> "“Deana, go to your room. NOW!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[147]`
Mówca: **Monica**
> "“Stop yelling at her! Deana, let's go to the kitchen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[148]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Monica**
> "“Come on, Deana. Lets go to the kitchen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Narrator**
> "Monica pierced me with her eyes one more time as they left the balcony and closed the door behind them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Narrator**
> "Her words repeated in my head again and again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[152]`
Mówca: **Narrator**
> "“You're no longer the man I married.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Narrator**
> "She was right."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Narrator**
> "What had I done?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[155]`
Mówca: **Narrator**
> "Her words repeated in my head again and again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[156]`
Mówca: **Narrator**
> "A noise came from the balcony door. We both turned our heads to see Deana standing there, a confused look in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Deana**
> "“Papa. Mama. Why are you fighting?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
**[WYBÓR GRACZA: "“It's nothing. We were just...talking about work.”"]** — Mówca: **Player**
> "“It's nothing. We were just...talking about work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[160]`
Mówca: **Monica**
> "“Yes, it's nothing. Your papa and I were just having a little disagreement. Come on, Deana. Lets go to the kitchen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[161]`
Mówca: **Narrator**
> "She was right."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[162]`
Mówca: **Narrator**
> "I thought to myself..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[163]`
Mówca: **Narrator**
> "“Coward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[164]`
Mówca: **Narrator**
> "Monica pierced me with her eyes one more time as they left the balcony and closed the door behind them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[165]`
Mówca: **Monica**
> "“It's nothing. Your papa and I were just having a little disagreement. Come on, Deana. Lets go to the kitchen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[166]`
Mówca: **Narrator**
> "“Coward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[167]`
Mówca: **Narrator**
> "A noise came from the balcony door. We both turned our heads to see Deana standing there, a confused look in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Deana**
> "“Papa. Mama. Why are you fighting?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
**[WYBÓR GRACZA: "“It's nothing. We were just...talking about work.”"]** — Mówca: **Player**
> "“It's nothing. We were just...talking about work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[170]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Narrator**
> "Monica pierced me with her eyes as they left the balcony and closed the door behind them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[172]`
Mówca: **Monica**
> "“It's nothing. Your papa and I were just having a little disagreement. Come on, Deana. Lets go to the kitchen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[173]`
Mówca: **Narrator**
> "She was never going to."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[174]`
Mówca: **Narrator**
> ""I will never forget how you let me down. Never!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[175]`
Mówca: **Narrator**
> "Her words repeated in my head again and again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[176]`
Mówca: **Monica**
> "“Yes, it's nothing. Your papa and I were just having a little disagreement. Come on, Deana. Lets go to the kitchen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[177]`
Mówca: **Narrator**
> "I thought to myself..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[178]`
Mówca: **Narrator**
> "A noise came from the balcony door. We both turned our heads to see Deana standing there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Deana**
> "“Mama, I'm hungry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Monica**
> "“Lets go to the kitchen, baby. We'll make Papa the best snack ever!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Deana**
> "“Yeah!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Narrator**
> "They left the balcony and returned half an hour later with a large cookie. Deana had written my name in icing on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Narrator**
> "As I sipped my coffee and nibbled the cookie, I thought that I had made the right choice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Narrator**
> "Things were going to get harder, but at least my life at home was somewhat..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Narrator**
> "Peaceful."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: GameCondition.Turn05_Personal_MonicaTalk = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn05_Personal_MonicaTalk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[187]`
Mówca: **Monica**
> "“I'm not sure I can forgive you for this, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Monica**
> "“But you do have one more chance to make it up to me. And offer your *real* support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[88]`
  - -> `[87]`

### Węzeł `[189]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Slapped = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Slapped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[190]`
Mówca: **Narrator**
> "There was a noise from the balcony door. We both turned our heads to see Deana standing there, a confused look in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Deana**
> "“Papa. Mama. Why are you fighting?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[195]`

### Węzeł `[192]`
**[WYBÓR GRACZA: "“It's nothing. We were just... talking about work.”"]** — Mówca: **Player**
> "“It's nothing. We were just... talking about work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Narrator**
> "Monica pierced me with her eyes one more time as they left the balcony and closed the door behind them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[194]`
Mówca: **Monica**
> "“Your father is right. We were just having a little disagreement. Come on, Deana. Lets go to the kitchen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[195]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[196]`
Mówca: **Narrator**
> "Her words repeated in my head, again and again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Monica**
> "“It's nothing. Your papa and I were just having a little disagreement. Come on, Deana. Lets go to the kitchen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[198]`
Mówca: **Narrator**
> "“I will never forget about what you did. Never!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[199]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn06_P_SupportedMonicaAtConfrontation = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn06_P_SupportedMonicaAtConfrontation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[200]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[201]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[202]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[203]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[204]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[205]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[206]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 3)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[207]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 3)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[208]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[209]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[210]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == false && BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == false && BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == false && BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == false && BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == false  and  Variable["BaseGame.Turn05_SnO_LE_Policy_CommunityPolice"] == false  and  Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == false && BaseGame.Turn05_SnO_LE_Policy_CommunityPolice == false && BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice == false ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == false  and  Variable["BaseGame.Turn05_SnO_LE_Policy_CommunityPolice"] == false  and  Variable["BaseGame.Turn05_SnO_LE_Policy_AntiCorruptionPolice"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[213]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: GameCondition.Turn05_SnO_FoundedPolice = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn05_SnO_FoundedPolice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[214]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[216]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[217]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Erlory_ArcasianBase = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Erlory_ArcasianBase"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[218]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[220]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[221]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Conriat_UCBase = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Conriat_UCBase"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[222]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 6 && BaseGame.GovernmentBudget >= -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`
  - -> `[224]`

### Węzeł `[223]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 6 && BaseGame.GovernmentBudget >= -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] >= 6  and  Variable["BaseGame.GovernmentBudget"] >= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[224]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy >= 6 && BaseGame.GovernmentBudget >= -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 6  and  Variable["BaseGame.GovernmentBudget"] >= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[225]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 4 && BaseGame.GovernmentBudget >= -3)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[227]`

### Węzeł `[226]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 4 && BaseGame.GovernmentBudget >= -3)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] >= 4  and  Variable["BaseGame.GovernmentBudget"] >= -3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[227]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy >= 4 && BaseGame.GovernmentBudget >= -3))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 4  and  Variable["BaseGame.GovernmentBudget"] >= -3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 2 && BaseGame.GovernmentBudget >= -1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Economy >= 2 && BaseGame.GovernmentBudget >= -1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Economy"] >= 2  and  Variable["BaseGame.GovernmentBudget"] >= -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[230]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Economy >= 2 && BaseGame.GovernmentBudget >= -1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Economy"] >= 2  and  Variable["BaseGame.GovernmentBudget"] >= -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[233]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[234]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Lachaven_EconomyGreat = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Lachaven_EconomyGreat"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[235]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Lachaven_EconomyGood = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Lachaven_EconomyGood"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[236]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Lachaven_EconomyOkay = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Lachaven_EconomyOkay"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[237]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Lachaven_EconomyAutocrat = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Lachaven_EconomyAutocrat"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[238]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Lachaven_EconomyBad = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Lachaven_EconomyBad"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[239]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == true && BaseGame.Relations_Monica_SupportedAtFestival == true && BaseGame.Turn05_Personal_Festival_Force == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[240]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == true && BaseGame.Relations_Monica_SupportedAtFestival == true && BaseGame.Turn05_Personal_Festival_Force == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true  and  Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true  and  Variable["BaseGame.Turn05_Personal_Festival_Force"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[241]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_P_Monica_Benfi_Speech == true && BaseGame.Relations_Monica_SupportedAtFestival == true && BaseGame.Turn05_Personal_Festival_Force == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true  and  Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true  and  Variable["BaseGame.Turn05_Personal_Festival_Force"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[242]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == false && BaseGame.Relations_Monica_SupportedAtFestival == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == false && BaseGame.Relations_Monica_SupportedAtFestival == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == false  and  Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[244]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_P_Monica_Benfi_Speech == false && BaseGame.Relations_Monica_SupportedAtFestival == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == false  and  Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == false && BaseGame.Relations_Monica_SupportedAtFestival == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`

### Węzeł `[246]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == false && BaseGame.Relations_Monica_SupportedAtFestival == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == false  and  Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[247]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_P_Monica_Benfi_Speech == false && BaseGame.Relations_Monica_SupportedAtFestival == false ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == false  and  Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[248]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_LT_Benfi_Curtan_MonicaSupported = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_Benfi_Curtan_MonicaSupported"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[249]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_LT_Benfi_Curtan_MonicaShutDown = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_Benfi_Curtan_MonicaShutDown"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_LT_Benfi_Monica_Listened = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_Benfi_Monica_Listened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[251]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[253]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_ST_Benfi_Curtan_MonicaShutDown_NoDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_Benfi_Curtan_MonicaShutDown_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[255]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_SupportedAtFestival == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[258]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_LT_Benfi_Monica_ShutDown = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_Benfi_Monica_ShutDown"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[259]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteKicked == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteKicked == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Personal_Festival_LesteKicked == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[262]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[264]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[265]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[267]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[268]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Media_Influenced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Media_Influenced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Media_Influenced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[270]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_Media_Influenced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Media_Influenced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[271]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Media_Influenced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Media_Influenced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Media_Influenced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[273]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_Media_Influenced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Media_Influenced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[274]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanLeftorKicked_Deal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanLeftorKicked_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[275]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanLeftorKicked_Media = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanLeftorKicked_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[276]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanKicked_NoMedia = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanKicked_NoMedia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[277]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanLeftorKicked_Deal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanLeftorKicked_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[278]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanLeftorKicked_Media = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanLeftorKicked_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[279]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanLeft_NoMedia = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_Benfi_Monica_CurtanLeft_NoMedia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[280]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanKicked_NoDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanKicked_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[281]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanLeft_NoDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_Benfi_Monica_CurtanLeft_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[282]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Monica_Barred == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_Monica_Barred == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[285]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_HP_CurtanApologizes = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_CurtanApologizes"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[286]`
**[WYBÓR GRACZA: "“What's that supposed to mean?”"]** — Mówca: **Player**
> "“What's that supposed to mean?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[287]`
Mówca: **Monica**
> "“Oh, you know what it means.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Narrator**
> "She looked down at the pieces of torn newspaper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[289]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[291]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_SupportedAtFestival == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[292]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[294]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_SupportedAtFestival == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[295]`
Mówca: **Narrator**
> "A few of the papers came out in support of the First Lady for her brave speech, while denigrating Curtan for his rude interruption. But most agreed that Monica had humiliated herself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Narrator**
> "I could only imagine what would have happened if I had let her continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[297]`
Mówca: **Narrator**
> "Nearly all of them agreed that the First Lady had acquitted herself very well following the interruption."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[298]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_P_Monica_Benfi_Speech == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Monica**
> ""Anton, how could you? You knew how important that speech was to me, and you let that dinosaur Leste make a mockery of me and my cause!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[302]`
Mówca: **Monica**
> ""Anton, how could you? First you deny me the opportunity to speak at the festival, then you let that dinosaur Leste make a mockery of me and my cause!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[303]`
Mówca: **Monica**
> "“What began as an unexpectedly impassioned plea for ladies' rights at the opening of the Benfi Festival turned into a circus sideshow as First Lady Monica Rayne failed to counter the rightful objections of the Mayor of Anrica, Curtan Leste.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[304]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[306]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_P_Monica_Benfi_Speech == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[307]`
**[WYBÓR GRACZA: "“No. I was wrong to have let you speak at the festival. I won't make the same mistake again.""]** — Mówca: **Player**
> "“No. I was wrong to have let you speak at the festival. I won't make the same mistake again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[308]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[310]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_P_Monica_Benfi_Speech))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[311]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[313]`

### Węzeł `[312]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_P_Monica_Benfi_Speech))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[314]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_Force)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
  - -> `[316]`

### Węzeł `[315]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_Force)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_Force"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Personal_Festival_Force))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_Force"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Monica**
> ""All that business with Leste at the festival distracted from my real message. I'm still not giving up on women's rights, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[318]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`
  - -> `[320]`

### Węzeł `[319]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_SupportedAtFestival))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_SupportedAtFestival"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[321]`
Mówca: **Monica**
> ""When I gave that speech, I saw hope in the eyes of all the women in the audience. This is the right path for me, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[322]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_SupportWomensRights)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_SupportWomensRights)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_SupportWomensRights"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[324]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_SupportWomensRights))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_SupportWomensRights"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[325]`
Mówca: **Monica**
> ""I know this isn't an urgent issue for you. But it's vital to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[326]`
Mówca: **Monica**
> ""I know this is something you're passionate about as well. Can I count on you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[327]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion <0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion <0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Opinion"] <0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Opinion <0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Opinion"] <0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[330]`
Mówca: **Monica**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[331]`
Mówca: **Monica**
> ""Oh, Anton. This means so much to me!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[332]`
Mówca: **Narrator**
> "Monica hugged me tightly, and I felt some of the past day's tension melt away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[333]`
Mówca: **Narrator**
> "Monica gave me a quick hug."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[334]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Media_Influenced)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_Media_Influenced)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Media_Influenced"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[339]`
  - -> `[338]`

### Węzeł `[336]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_Media_Influenced))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Media_Influenced"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[33]`
  - -> `[32]`

### Węzeł `[337]`
**[WYBÓR GRACZA: "“I'm rather busy, but all right.”"]** — Mówca: **Player**
> "“I'm rather busy, but all right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[338]`
**[WYBÓR GRACZA: "“Of course. what is it?”"]** — Mówca: **Player**
> "“Of course. What is it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[339]`
**[WYBÓR GRACZA: "Gesture for her to sit down."]** — Mówca: **Player_Italic**
> "I gestured towards the chair next to me. She sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[340]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_News_Contained)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_News_Contained)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_News_Contained"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[342]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_News_Contained))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_News_Contained"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[343]`
Mówca: **Narrator**
> "Monica sat and picked up the nearest newspaper. She pointed to a particularly insulting headline on the front page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[344]`
Mówca: **Narrator**
> "Monica sat and picked up the nearest newspaper. She flipped it open to the article about Curtan's apology."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Monica**
> ""I've been reading the papers, too. I'm happy the confrontation with Curtan didn't seem to have caused much damage. But it could have gone so much worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[346]`
Mówca: **Monica**
> "“I'm glad that beast admitted he was in the wrong. But it could very easily have gone another way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[347]`
Mówca: **Monica**
> "“I never in a million years would have wished for this, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[348]`
**[WYBÓR GRACZA: "“It's okay. I've had Curtan fired. That's the last of our troubles with him.""]** — Mówca: **Player**
> "“It's okay. I've had Curtan fired. That's the last of our troubles with him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[349]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lileas_GendermariePromise == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`
  - -> `[351]`

### Węzeł `[350]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lileas_GendermariePromise == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[351]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Lileas_GendermariePromise == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Lileas_GendermariePromise"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[352]`
Mówca: **Narrator**
> "Monica stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[353]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Decrease == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Decrease == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Decrease == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[356]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: GameCondition.Turn05_Decision_RumburgBorderReinforcement = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn05_Decision_RumburgBorderReinforcement"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[357]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_News_Contained == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[359]`

### Węzeł `[358]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Admin_News_Contained == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_News_Contained"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[359]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Admin_News_Contained == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_News_Contained"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[360]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteKicked == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`
  - -> `[362]`

### Węzeł `[361]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteKicked == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[362]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Personal_Festival_LesteKicked == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[363]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteLeft == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`
  - -> `[365]`

### Węzeł `[364]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteLeft == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteLeft"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[365]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Personal_Festival_LesteLeft == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteLeft"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[366]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[367]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[368]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[369]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[370]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteLeft == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`
  - -> `[372]`

### Węzeł `[371]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteLeft == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteLeft"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[372]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Personal_Festival_LesteLeft == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteLeft"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[373]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion -= 5;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[374]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteKicked == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteKicked == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[376]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Personal_Festival_LesteKicked == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[377]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[378]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[379]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[380]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[381]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[382]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 3)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[383]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[384]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion >= 10)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`
  - -> `[386]`

### Węzeł `[385]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion >= 10)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] >= 10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[386]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion >= 10))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] >= 10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Holsord_PositiveApproval = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_PositiveApproval"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[388]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion <= -5)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`
  - -> `[390]`

### Węzeł `[389]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Public_Opinion <= -5)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[390]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Public_Opinion <= -5))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[391]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Holsord_NegativeApproval = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_NegativeApproval"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[392]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`
  - -> `[394]`

### Węzeł `[393]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[394]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[395]`
Mówca: **Monica**
> ""You were right. Gloria was right. I made myself look like an idiot and damaged the very cause I was fighting for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[396]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Erlory", "City_ArcasiaAccess");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Erlory","City_ArcasiaAccess");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[397]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: AddTokenStatus("Sordland_City_Conriat", "City_UCAccess");)*
- **Efekt (`userScript`):** `AddTokenStatus("Sordland_City_Conriat","City_UCAccess");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[398]`
Mówca: **Monica**
> "“With the President providing no support, her challenge to Leste was quickly defeated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[399]`
Mówca: **Monica**
> "“Powerless to defend herself from this challenge, she turned to the President, who provided no support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[400]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[401]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_RelaxedImmigration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`
  - -> `[403]`

### Węzeł `[402]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_RelaxedImmigration == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[403]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_RelaxedImmigration == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[404]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_E_SkilledImmigrationPositive = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_E_SkilledImmigrationPositive"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[405]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_TightenedImmigration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`
  - -> `[407]`

### Węzeł `[406]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_TightenedImmigration == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]`

### Węzeł `[407]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_TightenedImmigration == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_LT_ImmigrationDecreases = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_LT_ImmigrationDecreases"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[409]`
Mówca: **Monica**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_HP_LowerClassThreatened = true;
BaseGameSupport.News_Turn05_G_CSPRevolutionsDestabilize = true;
BaseGameSupport.News_Turn05_G_QinalIntendsObserver = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_LowerClassThreatened"] = true;
Variable["BaseGameSupport.News_Turn05_G_CSPRevolutionsDestabilize"] = true;
Variable["BaseGameSupport.News_Turn05_G_QinalIntendsObserver"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`
