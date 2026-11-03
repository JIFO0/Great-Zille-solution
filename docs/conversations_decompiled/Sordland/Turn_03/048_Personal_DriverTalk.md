# Sordland/Turn03/Personal_DriverTalk

- **ID konwersacji:** `48`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/048_Personal_DriverTalk.md`
- **Liczba węzłów dialogowych:** 217
- **Liczba wyborów gracza:** 58

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[54]** Serge Wolkner

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn02_StatusReaction_BoostPolice`
- `BaseGame.Decision_Turn02_StatusReaction_CallRestraint`
- `BaseGame.Decision_Turn02_StatusReaction_VisitTowns`
- `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors`
- `BaseGame.PersonalWealth`
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGame.Relations_Serge_Friend`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn01_InT_Investment_Railway`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.PersonalWealth`
- `BaseGame.Relations_Serge_Acquaintance`
- `BaseGame.Relations_Serge_Friend`
- `BaseGame.Relations_Serge_TalkSoured`
- `BaseGameSupport.Journal_Turn03_DriverTalk_PaidForEducation`
- `BaseGameSupport.Journal_Turn03_DriverTalk_PaidForFamily`
- `BaseGameSupport.News_Turn03_E_PrivateEducation`
- `BaseGameSupport.News_Turn03_HP_Protest_CalledProtestersTraitors`
- `BaseGameSupport.News_Turn03_HP_Protest_Calm`
- `BaseGameSupport.News_Turn03_HP_Protest_DoneNothing`
- `BaseGameSupport.News_Turn03_HP_Protest_ExpandedPolice`
- `BaseGameSupport.News_Turn03_R_LabourMarch`
- `BaseGameSupport.News_Turn03_R_MisogynistRally`
- `BaseGameSupport.News_Turn03_R_SollNeedsToAnswer`
- `BaseGameSupport.Report_Turn03_Holsord_PFJPReport`
- `BaseGameSupport.Report_Turn03_Vesord_TerrorAttack`
- `GameCondition.Turn03_Personal_DriverTalk`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 28

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.PersonalWealth`
- `BaseGame.Relations_Serge_Acquaintance`
- `BaseGame.Relations_Serge_Friend`
- `BaseGame.Relations_Serge_TalkSoured`
- `BaseGameSupport.News_Turn03_R_SollNeedsToAnswer`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[38]` (Serge Wolkner): `Variable["BaseGameSupport.News_Turn03_R_SollNeedsToAnswer"] = true; Variable["BaseGameSupport.New...`
- Węzeł `[136]` (Serge Wolkner): `Variable["BaseGame.Relations_Serge_TalkSoured"] = true;`
- Węzeł `[137]` (Serge Wolkner): `Variable["BaseGame.Relations_Serge_TalkSoured"] = true;`
- Węzeł `[138]` (Serge Wolkner): `Variable["BaseGame.Relations_Serge_TalkSoured"] = true;`
- Węzeł `[149]` (Serge Wolkner): `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1; Variable["BaseGame...`
- Węzeł `[163]` (Serge Wolkner): `Variable["BaseGame.Relations_Serge_Friend"] = true;`
- Węzeł `[167]` (Serge Wolkner): `Variable["BaseGameSupport.Journal_Turn03_DriverTalk_PaidForEducation"] = true;`
- Węzeł `[177]` (Serge Wolkner): `Variable["BaseGameSupport.News_Turn03_HP_Protest_DoneNothing"] = true;`
- *...oraz 20 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Serge Wolkner)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I was travelling to the snow-covered city of Narbel in the Nargis region for the rural development forum organized by the Ministry of Health and the Ministry of Education."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[4]`
Mówca: **Serge Wolkner**
> "“We will be arriving at Hotel West in a few minutes, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[5]`
  - -> `[96]`

### Węzeł `[5]`
**[WYBÓR GRACZA: "“Can't say it's been a comfortable ride, Serge.”"]** — Mówca: **Player**
> "“Can't say it's been a comfortable ride, Serge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "“Thank you for letting me know.”"]** — Mówca: **Player**
> "“Thank you for letting me know.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Serge Wolkner**
> "“Any time. It is my duty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Serge Wolkner**
> "“I am sorry sir. The roads here aren't the best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Narrator**
> "After a moment, Serge started to smile under his moustache."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[10]`
  - -> `[98]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "“How is life, Serge?”"]** — Mówca: **Player**
> "“How is life, Serge?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Serge Wolkner**
> "“Sir, I just want to say... It has been great these last two months.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Serge Wolkner**
> "“As you know, my wife Suzan recently gave birth to our son. And now my daughter just started at a very good high school in Holsord.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[184]`
  - -> `[13]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“Congratulations.”"]** — Mówca: **Player**
> "“Congratulations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "“Get ready, Serge. Because life is about to become a lot busier.”"]** — Mówca: **Player**
> "“Get ready, Serge. Because life is about to become a lot busier.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[15]`
Mówca: **Serge Wolkner**
> "“The doctors said he is very healthy and thankfully so is my wife.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[40]`
  - -> `[18]`
  - -> `[126]`

### Węzeł `[16]`
Mówca: **Serge Wolkner**
> "“But I shouldn't have made my insecurity get to me. Erica outsmarts me all the time. I'm very proud to have a daughter like her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[22]`
  - -> `[52]`

### Węzeł `[17]`
Mówca: **Serge Wolkner**
> "“How are your children, sir, if I may ask?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[21]`
  - -> `[20]`
  - -> `[75]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Tell me more about Suzan. What kind of a person is she?”"]** — Mówca: **Player**
> "“Tell me more about Suzan. What kind of a person is she?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "“Why did you want another child?”"]** — Mówca: **Player**
> "“Why did you want another child?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“Deana is as lively as ever, but Franc seems to be a little distant.”"]** — Mówca: **Player**
> "“Deana is as lively as ever, but Franc seems to be a little distant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "“They are both doing just fine. Going through different phases in life.”"]** — Mówca: **Player**
> "“They are both doing just fine. Going through different phases in life.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“So that means she must have gotten the smarts from her mother.”"]** — Mówca: **Player**
> "“So that means she must have gotten the smarts from her mother.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "“I also hope that Deana will grow to be like her mother someday.”"]** — Mówca: **Player**
> "“I too hope that Deana will grow to be like her mother someday.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[24]`
Mówca: **Serge Wolkner**
> "“Have I told you, sir? We named my son Georg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[25]`
Mówca: **Serge Wolkner**
> "“Oh, I know, sir. It already is very busy. My daughter is a handful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[26]`
Mówca: **Serge Wolkner**
> "“I appreciate it, sir. Truly. I was worried that I wouldn't be able to afford a good private school if she scored less in the entrance exams.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[27]`
Mówca: **Serge Wolkner**
> "“I come from a big family. I'm one of five siblings so having company is a constant in my life.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[28]`
Mówca: **Serge Wolkner**
> "“She's beautiful, of course. But what I really admire is her selflessness.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`
  - -> `[49]`

### Węzeł `[29]`
Mówca: **Serge Wolkner**
> "“I can understand that completely, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[30]`
Mówca: **Serge Wolkner**
> "“That's very normal, sir. He is at that age. All of us went through a rebellious phase.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[31]`
Mówca: **Narrator**
> "The motorcade began approaching the hotel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[32]`
Mówca: **Serge Wolkner**
> "“I'm sure she will sir. After all she is the daughter of a lion and a lioness.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[33]`
Mówca: **Serge Wolkner**
> "“She must have!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[34]`
Mówca: **Narrator**
> "He let out a laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“See you later, Serge.”"]** — Mówca: **Player**
> "“See you later, Serge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[37]`
Mówca: **Serge Wolkner**
> "“Have a good day, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[38]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_R_SollNeedsToAnswer = true; BaseGameSupport.News_Turn03_E_PrivateEducation = true; BaseGameSupport.News_Turn03_R_LabourMarch = true;
BaseGameSupport.Report_Turn03_Vesord_TerrorAttack = true;
BaseGameSupport.Report_Turn03_Holsord_PFJPReport = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_R_SollNeedsToAnswer"] = true;
Variable["BaseGameSupport.News_Turn03_E_PrivateEducation"] = true;
Variable["BaseGameSupport.News_Turn03_R_LabourMarch"] = true;
Variable["BaseGameSupport.Report_Turn03_Vesord_TerrorAttack"] = true;
Variable["BaseGameSupport.Report_Turn03_Holsord_PFJPReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“What's that smile for?”"]** — Mówca: **Player**
> "“What's that smile for?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "“That's good. I hope the hospital had a good service.”"]** — Mówca: **Player**
> "“That's good. I hope the hospital had a good service.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Serge Wolkner**
> "“Normally, we would have been treated in one of the suburban hospitals.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Serge Wolkner**
> "“But thanks to the special coverage of the presidential staff, we were transferred to Emerald State Hospital.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“Glad that I could help.”"]** — Mówca: **Player**
> "“Glad that I could help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“We need to increase the quality of the services for all.”"]** — Mówca: **Player**
> "“We need to increase the quality of the services for all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“Emerald State is a great hospital.”"]** — Mówca: **Player**
> "“Emerald State is a great hospital.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[46]`
Mówca: **Serge Wolkner**
> "“You could call it a little traditional but it just feels right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`
  - -> `[87]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "“Sarna is a nice little city.”"]** — Mówca: **Player**
> "“Sarna is a nice little city.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Selflessness is a respectable trait to have.”"]** — Mówca: **Player**
> "“Selflessness is a respectable trait to have.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "“Monica is persevering. It can be inspiring at times to have a partner like that.”"]** — Mówca: **Player**
> "“Monica is persevering. It can be inspiring at times to have a partner like that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "“Are you fine?”"]** — Mówca: **Player**
> "“Are you fine?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“This is unacceptable. We need to invest in infrastructure here.”"]** — Mówca: **Player**
> "“This is unacceptable. We need to invest in infrastructure here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "“I do not value insecurity in my employees, Serge.”"]** — Mówca: **Player**
> "“I do not value insecurity in my employees, Serge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[53]`
Mówca: **Serge Wolkner**
> "“Yes, sir. I will be more careful from now on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[54]`
Mówca: **Serge Wolkner**
> "“She is an inspiration for almost all women in the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[55]`
Mówca: **Narrator**
> "Serge sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "“Enough talking, Serge. Focus on the road.”"]** — Mówca: **Player**
> "“Enough talking, Serge. Focus on the road.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[57]`
Mówca: **Serge Wolkner**
> "“The bazaar there is quite unique and it is a good city. Nothing compares to Holsord of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[58]`
Mówca: **Serge Wolkner**
> "“It should be mutual, that is what matters most.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[59]`
Mówca: **Serge Wolkner**
> "“It's only fitting. A lioness for a lion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[60]`
Mówca: **Serge Wolkner**
> "“The equipment and the staff were exceptional.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[61]`
Mówca: **Serge Wolkner**
> "“There are far more unfortunate people in this country. But thanks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[62]`
Mówca: **Serge Wolkner**
> "“That sounds like a tough issue to solve.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[63]`
Mówca: **Serge Wolkner**
> "“I'm sorry. I will drive more carefully, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[64]`
Mówca: **Serge Wolkner**
> "“I agree sir. We still need to drive back tomorrow unless you use one of those new helicopters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[65]`
Mówca: **Serge Wolkner**
> "“Yes sir. I hope the car is fine too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[66]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Highway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[68]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Highway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[71]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Railway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[72]`
Mówca: **Narrator**
> "The scenery so far, however, was a reflection of Narbel's neglect. The main roads to the city were not maintained well. There were many bumps and empty discolored spots in the asphalt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[73]`
Mówca: **Narrator**
> "The scenery so far, however, was a reflection of Narbel's neglect. The main roads to the city were not maintained well. There were many bumps and empty discolored spots in the asphalt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[74]`
Mówca: **Narrator**
> "Serge nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“I expect so much from them. They will make me proud.”"]** — Mówca: **Player**
> "“I expect so much from them. They will make me proud.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[76]`
Mówca: **Serge Wolkner**
> "“It must not be easy to be the children of a high-profile person like you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[77]`
Mówca: **Serge Wolkner**
> "“My daughter looks up to the First Lady for inspiration and it's not just limited to my daughter, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[78]`
Mówca: **Serge Wolkner**
> "“It must be sir. We sometimes forget the important people in life between all the responsibility and rush.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Serge Wolkner**
> "“You know... Those we care for...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`
  - -> `[189]`

### Węzeł `[80]`
Mówca: **Serge Wolkner**
> "“I had some troubles communicating with Erica as she grew up, but we found a common ground by going to plays.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[81]`
  - -> `[82]`
  - -> `[113]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "“My children can talk to me if they want. It is up to them.”"]** — Mówca: **Player**
> "“My children can talk to me if they want. It is up to them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "“Communication is the key.”"]** — Mówca: **Player**
> "“Communication is the key.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[83]`
Mówca: **Serge Wolkner**
> "“...I was unlucky. I never had a connection with my father. He was absent from our life, and I just can't have the same situation with my children...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "“Family is the cornerstone of life.”"]** — Mówca: **Player**
> "“Family is the cornerstone of life. We shouldn't forget that and it seems we do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[85]`
**[WYBÓR GRACZA: "“Traditional or not if it is what you want, that is all that matters.”"]** — Mówca: **Player**
> "“Traditional or not if it is what you want, that is all that matters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[86]`
Mówca: **Narrator**
> "He glanced towards the back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "“I was never a family person.”"]** — Mówca: **Player**
> "“I was never a family person.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[88]`
Mówca: **Serge Wolkner**
> "“Yes and it depends on what type of environment it is. If its hostile...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[89]`
Mówca: **Serge Wolkner**
> "“We keep forgetting what we want and lose ourselves in the process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[90]`
Mówca: **Serge Wolkner**
> "“You have a good family.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[91]`
Mówca: **Serge Wolkner**
> "“She has a good heart. Her family comes from Sarna, so they are a little more traditional.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[92]`
Mówca: **Narrator**
> "The mountainous city was infamously one of Sordland's poorest. It had a gritty edge, and its people were hardy and wary."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Narrator**
> "Even after the discovery of gas and oil in the area, years of neglect by the central government were apparent on the buildings and the general infrastructure. The natural resources were now under the control of Gasom, which elevated the corporation to a place of power."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Narrator**
> "My task in this forum was mainly symbolic. Fake smiles and handshakes with oil barons, meeting with local politicians, but most importantly of all, making sure that Narbel did not feel like it was forgotten by the government."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[95]`
Mówca: **Narrator**
> "As if my discomfort from the bumpy ride was apparent to him, Serge rolled down the partition window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[96]`
**[WYBÓR GRACZA: "“Good. Whatever gets us out of here quickly.”"]** — Mówca: **Player**
> "“Good. Whatever gets us out of here quickly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Narrator**
> "I let out a deep sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[98]`
**[WYBÓR GRACZA: "Pretend not to notice."]** — Mówca: **Player_Italic**
> "I pretended not to notice and looked out the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[99]`
Mówca: **Serge Wolkner**
> "“Thankfully, my work times allow me to spend some time with my family, except for these distant trips. I'm very lucky to have this job.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[100]`
Mówca: **Narrator**
> "Serge continued after a moment of silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[101]`
Mówca: **Narrator**
> "Navigating and swerving to avoid the inconveniences, our motorcade finally started nearing the city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[102]`
**[WYBÓR GRACZA: "“They are fine, but that's not your business Serge.”"]** — Mówca: **Player**
> "“They are fine, but that's not your business Serge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Serge Wolkner**
> "“No sir. You are right, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[104]`
Mówca: **Narrator**
> "He looked visibly irked by my comment and nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "“I expect you to do your job. Not ask questions about my private life.”"]** — Mówca: **Player**
> "“I expect you to do your job. Not ask questions about my private life.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
**[WYBÓR GRACZA: "“It's okay.”"]** — Mówca: **Player**
> "“It's okay.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[107]`
Mówca: **Serge Wolkner**
> "“Understood, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[108]`
Mówca: **Narrator**
> "There was a long silence. After several minutes, Serge attempted to break silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[109]`
Mówca: **Narrator**
> "There was a long silence. After several minutes, Serge attempted to break silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "“Spare me your lectures, Serge.”"]** — Mówca: **Player**
> "“Spare me your lectures, Serge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
**[WYBÓR GRACZA: "“I agree.”"]** — Mówca: **Player**
> "“I agree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[112]`
Mówca: **Serge Wolkner**
> "“Yes sir. I am sorry sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[113]`
**[WYBÓR GRACZA: "“Spare me your lectures about parenthood, Serge.”"]** — Mówca: **Player**
> "“Spare me your lectures about parenthood, Serge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[114]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Lachaven_Rich == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[117]`
Mówca: **Narrator**
> "My thoughts faded to my childhood. My father was also absent from home most of the time. I never connected with him, just like Serge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Narrator**
> "Being a president meant that I had to be away from home most of the time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Narrator**
> "I wondered if Franc also thought of me as an absent father figure. Could that be the reason behind his attitude?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[120]`
Mówca: **Serge Wolkner**
> "“But at the same time, it must be hard for the First Lady as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[121]`
**[WYBÓR GRACZA: "“That is none of your business.”"]** — Mówca: **Player**
> "“That is none of your business.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[122]`
**[WYBÓR GRACZA: "“You are right. It is hard for her.”"]** — Mówca: **Player**
> "“You are right. It is hard for her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[123]`
**[WYBÓR GRACZA: "“It is hard for both of us.”"]** — Mówca: **Player**
> "“It is hard for both of us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[124]`
Mówca: **Serge Wolkner**
> "“My daughter looks up to the First Lady for inspiration. Not only my daughter, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[125]`
Mówca: **Serge Wolkner**
> "“All this attention, adjusting to this new high-profile life, and a husband that has great responsibility...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[188]`
  - -> `[122]`
  - -> `[123]`

### Węzeł `[126]`
**[WYBÓR GRACZA: "“Very good. I must tend to my documents for a bit.”"]** — Mówca: **Player**
> "“Very good. I must tend to my documents for a bit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Serge Wolkner**
> "“Of course, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[128]`
Mówca: **Narrator**
> "The Hotel West was supposedly the best hotel in Narbel. The large 25-story main building was undoubtedly one of the taller and more expensive buildings in the city. It towered over the nearby slums and had been a target for protests when it was first built."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Narrator**
> "A crowd was gathered in front of the hotel with the welcoming committee at its centre. As we approached the red carpeted entrance I could see the Mayor of Narbel and his top aides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Narrator**
> "Serge got out of the car and opened the door. He bowed his head respectfully and gestured towards the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[35]`
  - -> `[36]`

### Węzeł `[131]`
Mówca: **Serge Wolkner**
> "“Thank you sir. Likewise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
**[WYBÓR GRACZA: "Exit the vehicle."]** — Mówca: **Player_Italic**
> "I gathered my documents, my bag and I left the car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Narrator**
> "As soon as I left the vehicle, the fresh air of Narbel filled my lungs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Narrator**
> "Almost immediately, everyone present in the crowd flocked over to me with an excessive display of courtesy, smiles and handshakes while I donned the mask of a politician."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Narrator**
> "A mask that I was very used to."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[136]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_TalkSoured = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Serge_TalkSoured"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[137]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_TalkSoured = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Serge_TalkSoured"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[138]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_TalkSoured = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Serge_TalkSoured"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[139]`
Mówca: **Narrator**
> "The car hit a major pothole and a bump which lifted us up in our seats for a second."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[51]`
  - -> `[50]`

### Węzeł `[140]`
Mówca: **Serge Wolkner**
> "“I've already started thinking about their university education. Especially Erica.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Serge Wolkner**
> "“I want to send her to a good private school but with the current state of the economy, it's going to be hard for us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[194]`
  - -> `[142]`
  - -> `[144]`

### Węzeł `[142]`
**[WYBÓR GRACZA: "“We will fix the economy. One way or another.”"]** — Mówca: **Player**
> "“We will fix the economy. One way or another.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[143]`
**[WYBÓR GRACZA: "“You know what? I can support the education of your children." [-1 Personal Wealth]"]** — Mówca: **Player**
> "“You know what? I can support the education of your children.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[144]`
**[WYBÓR GRACZA: "“It's hard for everyone.”"]** — Mówca: **Player**
> "“It's hard for everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[145]`
Mówca: **Serge Wolkner**
> "“Mr. President, there is no way I can--.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Narrator**
> "With one look from me, Serge cut his sentence short and nodded at me after removing his hat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Serge Wolkner**
> "“Mr. President, I don't know how I can ever repay you for this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Serge Wolkner**
> "“Thank you so much.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`
  - -> `[155]`

### Węzeł `[149]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth -= 1;
BaseGame.Relations_Serge_Acquaintance = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;
Variable["BaseGame.Relations_Serge_Acquaintance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[150]`
Mówca: **Serge Wolkner**
> "“If anyone can, that's you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[151]`
Mówca: **Serge Wolkner**
> "“If anyone can fix the economy, that's you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[152]`
**[WYBÓR GRACZA: "“A good education is more valuable than any amount of money.”"]** — Mówca: **Player**
> "“A good education is more valuable than any amount of money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[153]`
**[WYBÓR GRACZA: "“I hope you return the favor by helping someone in need someday. Just like I did.”"]** — Mówca: **Player**
> "“I hope you return the favor by helping someone in need someday. Just like I did.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Serge Wolkner**
> "“I will, sir. Of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[155]`
**[WYBÓR GRACZA: "“No worries, Serge.”"]** — Mówca: **Player**
> "“No worries, Serge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[156]`
Mówca: **Serge Wolkner**
> "“Exactly, sir. You are right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[157]`
Mówca: **Serge Wolkner**
> "“I think I have decided. I will give your name to my boy. ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Serge Wolkner**
> "“Georg Anton Wolkner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Serge Wolkner**
> "“May he grow strong like you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`
  - -> `[161]`
  - -> `[162]`

### Węzeł `[160]`
**[WYBÓR GRACZA: "“It has a nice ring to it. I like it.”"]** — Mówca: **Player**
> "“It has a nice ring to it. I like it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[161]`
**[WYBÓR GRACZA: "“I am sure he will.”"]** — Mówca: **Player**
> "“I am sure he will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[162]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[163]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_Friend = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Serge_Friend"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[164]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_Friend == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_Friend == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Serge_Friend"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[166]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Serge_Friend == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Serge_Friend"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[167]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn03_DriverTalk_PaidForEducation = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn03_DriverTalk_PaidForEducation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[168]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_CallRestraint == true || BaseGame.Decision_Turn02_StatusReaction_VisitTowns == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_CallRestraint == true || BaseGame.Decision_Turn02_StatusReaction_VisitTowns == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_CallRestraint"] == true  or  Variable["BaseGame.Decision_Turn02_StatusReaction_VisitTowns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[170]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_StatusReaction_CallRestraint == true || BaseGame.Decision_Turn02_StatusReaction_VisitTowns == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_CallRestraint"] == true  or  Variable["BaseGame.Decision_Turn02_StatusReaction_VisitTowns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[173]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[176]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Protest_DoneNothing = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Protest_DoneNothing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[178]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Protest_ExpandedPolice = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Protest_ExpandedPolice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[179]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Protest_Calm = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Protest_Calm"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[180]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_HP_Protest_CalledProtestersTraitors = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Protest_CalledProtestersTraitors"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[181]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_Personal_DriverTalk = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_Personal_DriverTalk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[182]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_R_MisogynistRally = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_R_MisogynistRally"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[183]`
Mówca: **Narrator**
> "The scenery so far, however, was a reflection of Narbel's neglect. The main roads to the city were not maintained well. There were many bumps and empty discolored spots in the asphalt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[184]`
**[WYBÓR GRACZA: "“That's great news, Serge. I'm happy for you.”"]** — Mówca: **Player**
> "“That's great news, Serge. I'm happy for you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[185]`
**[WYBÓR GRACZA: "“You are a good father, Serge.""]** — Mówca: **Player**
> "“You are a good father, Serge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Serge Wolkner**
> "“I try my best, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[187]`
Mówca: **Serge Wolkner**
> ""It is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[188]`
**[WYBÓR GRACZA: "“Let's not talk about my family, Serge.”"]** — Mówca: **Player**
> "“Let's not talk about my family, Serge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[189]`
**[WYBÓR GRACZA: "“Yes, Serge. I get it...”"]** — Mówca: **Player**
> "“Yes, Serge. I get it...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Serge Wolkner**
> "“Of course, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[191]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[193]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth >= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[194]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 2)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 2)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[196]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth >= 2))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[197]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth -= 2;
BaseGame.Relations_Serge_Friend = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 2;
Variable["BaseGame.Relations_Serge_Friend"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[198]`
**[WYBÓR GRACZA: "“My driver's family shouldn't want for anything in this world. I'll cover your children's education and any other extra expenses you need." [-2 Personal Wealth]"]** — Mówca: **Player**
> "“My driver's family shouldn't want for anything in this world. I'll cover your children's education and any other extra expenses you need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[199]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: UpdateProgress("Progress_Highway", 50);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%))*
- **Efekt (`userScript`):** `UpdateProgress("Progress_Highway", 50);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[200]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: UpdateProgress("Progress_Railway", 50);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%))*
- **Efekt (`userScript`):** `UpdateProgress("Progress_Railway", 50);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[201]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Holsord", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Holsord","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Holsord", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Holsord","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[203]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Jen", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Jen","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Morna", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Morna","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[205]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Jen", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Jen","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Morna", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Morna","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[207]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn03_DriverTalk_PaidForFamily = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn03_DriverTalk_PaidForFamily"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[208]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_Friend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_Friend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Serge_Friend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[210]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Serge_Friend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Serge_Friend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Serge Wolkner**
> "“I won't forget your generosity, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[212]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[213]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: SetRichPresence("Calling for solidarity to calm the nation", "Presidential Office", "Maroon Palace");)*
- **Efekt (`userScript`):** `SetRichPresence("Calling for solidarity to calm the nation","Presidential Office","Maroon Palace");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[214]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: SetRichPresence("Labelling all protestors as traitors", "Presidential Office", "Maroon Palace");)*
- **Efekt (`userScript`):** `SetRichPresence("Labelling all protestors as traitors","Presidential Office","Maroon Palace");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[215]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: SetRichPresence("Expanding the police force to contain protests", "Presidential Office", "Maroon Palace");)*
- **Efekt (`userScript`):** `SetRichPresence("Expanding the police force to contain protests","Presidential Office","Maroon Palace");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[216]`
Mówca: **Serge Wolkner**
*(Węzeł logiki narracyjnej: SetRichPresence("Watching idly as nationwide protests erupt", "Presidential Office", "Maroon Palace");)*
- **Efekt (`userScript`):** `SetRichPresence("Watching idly as nationwide protests erupt","Presidential Office","Maroon Palace");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
