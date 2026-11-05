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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **"“Can't say it's been a comfortable ride, Serge.”"** | `[4]` **Serge Wolkner**: "“We will be arriving at Hotel We..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Serge Wolkner**: "“I am sorry sir. The roads here ..." |
| `[6]` | **"“Thank you for letting me know.”"** | `[4]` **Serge Wolkner**: "“We will be arriving at Hotel We..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Serge Wolkner**: "“Any time. It is my duty.”" |
| `[10]` | **"“How is life, Serge?”"** | `[9]` **Narrator**: "After a moment, Serge started to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Serge Wolkner**: "“Sir, I just want to say... It h..." |
| `[13]` | **"“Congratulations.”"** | `[12]` **Serge Wolkner**: "“As you know, my wife Suzan rece..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Serge Wolkner**: "“I appreciate it, sir. Truly. I ..." |
| `[14]` | **"“Get ready, Serge. Because life is about to become a lot busier.”"** | `[12]` **Serge Wolkner**: "“As you know, my wife Suzan rece..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Serge Wolkner**: "“Oh, I know, sir. It already is ..." |
| `[18]` | **"“Tell me more about Suzan. What kind of a person is she?”"** | `[15]` **Serge Wolkner**: "“The doctors said he is very hea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Serge Wolkner**: "“She has a good heart. Her famil..." |
| `[19]` | **"“Why did you want another child?”"** | `[15]` **Serge Wolkner**: "“The doctors said he is very hea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Serge Wolkner**: "“I come from a big family. I'm o..." |
| `[20]` | **"“Deana is as lively as ever, but Franc seems to be a little distant.”"** | `[17]` **Serge Wolkner**: "“How are your children, sir, if ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Serge Wolkner**: "“That's very normal, sir. He is ..." |
| `[21]` | **"“They are both doing just fine. Going through different phases in life.”"** | `[17]` **Serge Wolkner**: "“How are your children, sir, if ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Serge Wolkner**: "“I can understand that completel..." |
| `[22]` | **"“So that means she must have gotten the smarts from her mother.”"** | `[16]` **Serge Wolkner**: "“But I shouldn't have made my in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Narrator**: "He let out a laugh." |
| `[23]` | **"“I also hope that Deana will grow to be like her mother someday.”"** | `[16]` **Serge Wolkner**: "“But I shouldn't have made my in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Serge Wolkner**: "“I'm sure she will sir. After al..." |
| `[35]` | **"“Thank you.”"** | `[130]` **Narrator**: "Serge got out of the car and ope..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Serge Wolkner**: "“Have a good day, Mr. President.”" |
| `[36]` | **"“See you later, Serge.”"** | `[130]` **Narrator**: "Serge got out of the car and ope..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Serge Wolkner**: "“Thank you sir. Likewise.”" |
| `[39]` | **"“What's that smile for?”"** | `[9]` **Narrator**: "After a moment, Serge started to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Serge Wolkner**: "“Sir, I just want to say... It h..." |
| `[40]` | **"“That's good. I hope the hospital had a good service.”"** | `[15]` **Serge Wolkner**: "“The doctors said he is very hea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Serge Wolkner**: "“Normally, we would have been tr..." |
| `[43]` | **"“Glad that I could help.”"** | `[42]` **Serge Wolkner**: "“But thanks to the special cover..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Serge Wolkner**: "“There are far more unfortunate ..." |
| `[44]` | **"“We need to increase the quality of the services for all.”"** | `[42]` **Serge Wolkner**: "“But thanks to the special cover..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Serge Wolkner**: "“That sounds like a tough issue ..." |
| `[45]` | **"“Emerald State is a great hospital.”"** | `[42]` **Serge Wolkner**: "“But thanks to the special cover..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Serge Wolkner**: "“The equipment and the staff wer..." |
| `[47]` | **"“Sarna is a nice little city.”"** | `[28]` **Serge Wolkner**: "“She's beautiful, of course. But..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Serge Wolkner**: "“The bazaar there is quite uniqu..." |
| `[48]` | **"“Selflessness is a respectable trait to have.”"** | `[28]` **Serge Wolkner**: "“She's beautiful, of course. But..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Serge Wolkner**: "“It should be mutual, that is wh..." |
| `[49]` | **"“Monica is persevering. It can be inspiring at times to have a partner like that.”"** | `[28]` **Serge Wolkner**: "“She's beautiful, of course. But..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Serge Wolkner**: "“It's only fitting. A lioness fo..." |
| `[50]` | **"“Are you fine?”"** | `[139]` **Narrator**: "The car hit a major pothole and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Serge Wolkner**: "“Yes sir. I hope the car is fine..." |
| `[51]` | **"“This is unacceptable. We need to invest in infrastructure here.”"** | `[139]` **Narrator**: "The car hit a major pothole and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Serge Wolkner**: "“I agree sir. We still need to d..." |
| `[52]` | **"“I do not value insecurity in my employees, Serge.”"** | `[16]` **Serge Wolkner**: "“But I shouldn't have made my in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Narrator**: "He looked visibly irked by my co..." |
| `[56]` | **"“Enough talking, Serge. Focus on the road.”"** | `[139]` **Narrator**: "The car hit a major pothole and ..." | `Variable["BaseGame.Relations_Serge_Friend"] == false` | `Variable["BaseGame.Relations_Serge_TalkSoured"] = true;` | `[63]` **Serge Wolkner**: "“I'm sorry. I will drive more ca..." |
| `[75]` | **"“I expect so much from them. They will make me proud.”"** | `[17]` **Serge Wolkner**: "“How are your children, sir, if ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Narrator**: "Serge nodded." |
| `[81]` | **"“My children can talk to me if they want. It is up to them.”"** | `[80]` **Serge Wolkner**: "“I had some troubles communicati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Serge Wolkner**: "“...I was unlucky. I never had a..." |
| `[82]` | **"“Communication is the key.”"** | `[80]` **Serge Wolkner**: "“I had some troubles communicati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Serge Wolkner**: ""It is."" |
| `[84]` | **"“Family is the cornerstone of life.”"** | `[46]` **Serge Wolkner**: "“You could call it a little trad..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Serge Wolkner**: "“Yes and it depends on what type..." |
| `[85]` | **"“Traditional or not if it is what you want, that is all that matters.”"** | `[46]` **Serge Wolkner**: "“You could call it a little trad..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Serge Wolkner**: "“We keep forgetting what we want..." |
| `[87]` | **"“I was never a family person.”"** | `[46]` **Serge Wolkner**: "“You could call it a little trad..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Serge Wolkner**: "“You have a good family.”" |
| `[96]` | **"“Good. Whatever gets us out of here quickly.”"** | `[4]` **Serge Wolkner**: "“We will be arriving at Hotel We..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Narrator**: "I let out a deep sigh." |
| `[98]` | **"Pretend not to notice."** | `[9]` **Narrator**: "After a moment, Serge started to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Serge Wolkner**: "“Sir, I just want to say... It h..." |
| `[102]` | **"“They are fine, but that's not your business Serge.”"** | `[17]` **Serge Wolkner**: "“How are your children, sir, if ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Serge Wolkner**: "“No sir. You are right, sir.”" |
| `[105]` | **"“I expect you to do your job. Not ask questions about my private life.”"** | `[103]` **Serge Wolkner**: "“No sir. You are right, sir.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Serge Wolkner**: "“Understood, Mr. President.”" |
| `[106]` | **"“It's okay.”"** | `[103]` **Serge Wolkner**: "“No sir. You are right, sir.”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Serge_TalkSoured"] = true;` | `[108]` **Narrator**: "There was a long silence. After ..." |
| `[110]` | **"“Spare me your lectures, Serge.”"** | `[79]` **Serge Wolkner**: "“You know... Those we care for...”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Serge Wolkner**: "“Yes sir. I am sorry sir.”" |
| `[111]` | **"“I agree.”"** | `[79]` **Serge Wolkner**: "“You know... Those we care for...”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Narrator**: "Serge continued after a moment o..." |
| `[113]` | **"“Spare me your lectures about parenthood, Serge.”"** | `[80]` **Serge Wolkner**: "“I had some troubles communicati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Serge Wolkner**: "“Yes sir. I am sorry sir.”" |
| `[121]` | **"“That is none of your business.”"** | `[125]` **Serge Wolkner**: "“All this attention, adjusting t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Serge Wolkner**: "“Yes sir. I am sorry sir.”" |
| `[122]` | **"“You are right. It is hard for her.”"** | `[125]` **Serge Wolkner**: "“All this attention, adjusting t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Serge Wolkner**: "“It must be sir. We sometimes fo..." |
| `[123]` | **"“It is hard for both of us.”"** | `[125]` **Serge Wolkner**: "“All this attention, adjusting t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Serge Wolkner**: "“It must be sir. We sometimes fo..." |
| `[126]` | **"“Very good. I must tend to my documents for a bit.”"** | `[15]` **Serge Wolkner**: "“The doctors said he is very hea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Serge Wolkner**: "“Of course, Mr. President.”" |
| `[132]` | **"Exit the vehicle."** | `[130]` **Narrator**: "Serge got out of the car and ope..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Narrator**: "As soon as I left the vehicle, t..." |
| `[142]` | **"“We will fix the economy. One way or another.”"** | `[141]` **Serge Wolkner**: "“I want to send her to a good pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Serge Wolkner**: "“If anyone can, that's you, Mr. ..." |
| `[143]` | **"“You know what? I can support the education of your children." [-1 Personal Wealth]"** | `[141]` **Serge Wolkner**: "“I want to send her to a good pr..." | `Variable["BaseGame.PersonalWealth"] >= 1` | `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame....`<br>`Variable["BaseGameSupport.Journal_Turn03_DriverTalk_PaidF...` | `[145]` **Serge Wolkner**: "“Mr. President, there is no way ..." |
| `[144]` | **"“It's hard for everyone.”"** | `[141]` **Serge Wolkner**: "“I want to send her to a good pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Serge Wolkner**: "“If anyone can fix the economy, ..." |
| `[152]` | **"“A good education is more valuable than any amount of money.”"** | `[148]` **Serge Wolkner**: "“Thank you so much.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Serge Wolkner**: "“Exactly, sir. You are right.”" |
| `[153]` | **"“I hope you return the favor by helping someone in need someday. Just like I did.”"** | `[148]` **Serge Wolkner**: "“Thank you so much.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Serge Wolkner**: "“I will, sir. Of course.”" |
| `[155]` | **"“No worries, Serge.”"** | `[148]` **Serge Wolkner**: "“Thank you so much.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Serge Wolkner**: "“I think I have decided. I will ..."<br>`[211]` **Serge Wolkner**: "“I won't forget your generosity,..." |
| `[160]` | **"“It has a nice ring to it. I like it.”"** | `[159]` **Serge Wolkner**: "“May he grow strong like you.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Narrator**: "The car hit a major pothole and ..." |
| `[161]` | **"“I am sure he will.”"** | `[159]` **Serge Wolkner**: "“May he grow strong like you.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Narrator**: "The car hit a major pothole and ..." |
| `[162]` | **"Nod."** | `[159]` **Serge Wolkner**: "“May he grow strong like you.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Narrator**: "The car hit a major pothole and ..." |
| `[184]` | **"“That's great news, Serge. I'm happy for you.”"** | `[12]` **Serge Wolkner**: "“As you know, my wife Suzan rece..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Serge Wolkner**: "“I appreciate it, sir. Truly. I ..." |
| `[185]` | **"“You are a good father, Serge.""** | `[80]` **Serge Wolkner**: "“I had some troubles communicati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Serge Wolkner**: "“I try my best, sir.”" |
| `[188]` | **"“Let's not talk about my family, Serge.”"** | `[125]` **Serge Wolkner**: "“All this attention, adjusting t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Serge Wolkner**: "“Yes sir. I am sorry sir.”" |
| `[189]` | **"“Yes, Serge. I get it...”"** | `[79]` **Serge Wolkner**: "“You know... Those we care for...”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Serge Wolkner**: "“Of course, sir.”" |
| `[198]` | **"“My driver's family shouldn't want for anything in this world. I'll cover your chi..."** | `[141]` **Serge Wolkner**: "“I want to send her to a good pr..." | `Variable["BaseGame.PersonalWealth"] >= 2` | `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame....`<br>`Variable["BaseGame.Relations_Serge_Friend"] = true;`<br>*(+1 skryptów)* | `[145]` **Serge Wolkner**: "“Mr. President, there is no way ..." |

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
  - -> `[3]` (*Narrator: "I was travelling to the snow-covered city of Narbel in th..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I was travelling to the snow-covered city of Narbel in the Nargis region for the rural development forum organized by the Ministry of Health and the Ministry of Education."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_R_MisogynistRally = true"*)

### Węzeł `[4]`
Mówca: **Serge Wolkner**
> "“We will be arriving at Hotel West in a few minutes, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: "“Thank you for letting me know.”"*)
  - -> `[5]` (*Player: "“Can't say it's been a comfortable ride, Serge.”"*)
  - -> `[96]` (*Player: "“Good. Whatever gets us out of here quickly.”"*)

### Węzeł `[5]`
**[WYBÓR GRACZA: "“Can't say it's been a comfortable ride, Serge.”"]** — Mówca: **Player**
> "“Can't say it's been a comfortable ride, Serge.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Serge Wolkner: "“I am sorry sir. The roads here aren't the best.”"*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "“Thank you for letting me know.”"]** — Mówca: **Player**
> "“Thank you for letting me know.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Serge Wolkner: "“Any time. It is my duty.”"*)

### Węzeł `[7]`
Mówca: **Serge Wolkner**
> "“Any time. It is my duty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "After a moment, Serge started to smile under his moustache."*)

### Węzeł `[8]`
Mówca: **Serge Wolkner**
> "“I am sorry sir. The roads here aren't the best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "After a moment, Serge started to smile under his moustache."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "After a moment, Serge started to smile under his moustache."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: "“What's that smile for?”"*)
  - -> `[10]` (*Player: "“How is life, Serge?”"*)
  - -> `[98]` (*Player_Italic: "Pretend not to notice."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“How is life, Serge?”"]** — Mówca: **Player**
> "“How is life, Serge?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Serge Wolkner: "“Sir, I just want to say... It has been great these last ..."*)

### Węzeł `[11]`
Mówca: **Serge Wolkner**
> "“Sir, I just want to say... It has been great these last two months.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Serge Wolkner: "“As you know, my wife Suzan recently gave birth to our so..."*)

### Węzeł `[12]`
Mówca: **Serge Wolkner**
> "“As you know, my wife Suzan recently gave birth to our son. And now my daughter just started at a very good high school in Holsord.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: "“Get ready, Serge. Because life is about to become a lot ..."*)
  - -> `[184]` (*Player: "“That's great news, Serge. I'm happy for you.”"*)
  - -> `[13]` (*Player: "“Congratulations.”"*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“Congratulations.”"]** — Mówca: **Player**
> "“Congratulations.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Serge Wolkner: "“I appreciate it, sir. Truly. I was worried that I wouldn..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "“Get ready, Serge. Because life is about to become a lot busier.”"]** — Mówca: **Player**
> "“Get ready, Serge. Because life is about to become a lot busier.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Serge Wolkner: "“Oh, I know, sir. It already is very busy. My daughter is..."*)

### Węzeł `[15]`
Mówca: **Serge Wolkner**
> "“The doctors said he is very healthy and thankfully so is my wife.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: "“Why did you want another child?”"*)
  - -> `[40]` (*Player: "“That's good. I hope the hospital had a good service.”"*)
  - -> `[18]` (*Player: "“Tell me more about Suzan. What kind of a person is she?”"*)
  - -> `[126]` (*Player: "“Very good. I must tend to my documents for a bit.”"*)

### Węzeł `[16]`
Mówca: **Serge Wolkner**
> "“But I shouldn't have made my insecurity get to me. Erica outsmarts me all the time. I'm very proud to have a daughter like her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: "“I also hope that Deana will grow to be like her mother s..."*)
  - -> `[22]` (*Player: "“So that means she must have gotten the smarts from her m..."*)
  - -> `[52]` (*Player: "“I do not value insecurity in my employees, Serge.”"*)

### Węzeł `[17]`
Mówca: **Serge Wolkner**
> "“How are your children, sir, if I may ask?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "“They are fine, but that's not your business Serge.”"*)
  - -> `[21]` (*Player: "“They are both doing just fine. Going through different p..."*)
  - -> `[20]` (*Player: "“Deana is as lively as ever, but Franc seems to be a litt..."*)
  - -> `[75]` (*Player: "“I expect so much from them. They will make me proud.”"*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Tell me more about Suzan. What kind of a person is she?”"]** — Mówca: **Player**
> "“Tell me more about Suzan. What kind of a person is she?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Serge Wolkner: "“She has a good heart. Her family comes from Sarna, so th..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "“Why did you want another child?”"]** — Mówca: **Player**
> "“Why did you want another child?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Serge Wolkner: "“I come from a big family. I'm one of five siblings so ha..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“Deana is as lively as ever, but Franc seems to be a little distant.”"]** — Mówca: **Player**
> "“Deana is as lively as ever, but Franc seems to be a little distant.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Serge Wolkner: "“That's very normal, sir. He is at that age. All of us we..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“They are both doing just fine. Going through different phases in life.”"]** — Mówca: **Player**
> "“They are both doing just fine. Going through different phases in life.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Serge Wolkner: "“I can understand that completely, sir.""*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“So that means she must have gotten the smarts from her mother.”"]** — Mówca: **Player**
> "“So that means she must have gotten the smarts from her mother.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "He let out a laugh."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "“I also hope that Deana will grow to be like her mother someday.”"]** — Mówca: **Player**
> "“I too hope that Deana will grow to be like her mother someday.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Serge Wolkner: "“I'm sure she will sir. After all she is the daughter of ..."*)

### Węzeł `[24]`
Mówca: **Serge Wolkner**
> "“Have I told you, sir? We named my son Georg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Serge Wolkner: "“The doctors said he is very healthy and thankfully so is..."*)

### Węzeł `[25]`
Mówca: **Serge Wolkner**
> "“Oh, I know, sir. It already is very busy. My daughter is a handful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Serge Wolkner: "“Thankfully, my work times allow me to spend some time wi..."*)

### Węzeł `[26]`
Mówca: **Serge Wolkner**
> "“I appreciate it, sir. Truly. I was worried that I wouldn't be able to afford a good private school if she scored less in the entrance exams.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Serge Wolkner: "“But I shouldn't have made my insecurity get to me. Erica..."*)

### Węzeł `[27]`
Mówca: **Serge Wolkner**
> "“I come from a big family. I'm one of five siblings so having company is a constant in my life.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Serge Wolkner: "“You could call it a little traditional but it just feels..."*)

### Węzeł `[28]`
Mówca: **Serge Wolkner**
> "“She's beautiful, of course. But what I really admire is her selflessness.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player: "“Sarna is a nice little city.”"*)
  - -> `[48]` (*Player: "“Selflessness is a respectable trait to have.”"*)
  - -> `[49]` (*Player: "“Monica is persevering. It can be inspiring at times to h..."*)

### Węzeł `[29]`
Mówca: **Serge Wolkner**
> "“I can understand that completely, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "He glanced towards the back."*)

### Węzeł `[30]`
Mówca: **Serge Wolkner**
> "“That's very normal, sir. He is at that age. All of us went through a rebellious phase.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "He glanced towards the back."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "The motorcade began approaching the hotel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "The Hotel West was supposedly the best hotel in Narbel. T..."*)

### Węzeł `[32]`
Mówca: **Serge Wolkner**
> "“I'm sure she will sir. After all she is the daughter of a lion and a lioness.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Serge Wolkner: "“My daughter looks up to the First Lady for inspiration a..."*)

### Węzeł `[33]`
Mówca: **Serge Wolkner**
> "“She must have!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Serge Wolkner: "“My daughter looks up to the First Lady for inspiration. ..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "He let out a laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Serge Wolkner: "“She must have!”"*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Serge Wolkner: "“Have a good day, Mr. President.”"*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“See you later, Serge.”"]** — Mówca: **Player**
> "“See you later, Serge.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Serge Wolkner: "“Thank you sir. Likewise.”"*)

### Węzeł `[37]`
Mówca: **Serge Wolkner**
> "“Have a good day, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "As soon as I left the vehicle, the fresh air of Narbel fi..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_R_SollNeedsToAnswer = true; BaseGameSupport.News_Turn03_E_PrivateEducation = true; BaseGameSupport.News_Turn03_R_LabourMarch = true;
BaseGameSupport.Report_Turn03_Vesord_TerrorAttack = true;
BaseGameSupport.Report_Turn03_Holsord_PFJPReport = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_R_SollNeedsToAnswer"] = true;
Variable["BaseGameSupport.News_Turn03_E_PrivateEducation"] = true;
Variable["BaseGameSupport.News_Turn03_R_LabourMarch"] = true;
Variable["BaseGameSupport.Report_Turn03_Vesord_TerrorAttack"] = true;
Variable["BaseGameSupport.Report_Turn03_Holsord_PFJPReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_Personal_DriverTalk = true"*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“What's that smile for?”"]** — Mówca: **Player**
> "“What's that smile for?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Serge Wolkner: "“Sir, I just want to say... It has been great these last ..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "“That's good. I hope the hospital had a good service.”"]** — Mówca: **Player**
> "“That's good. I hope the hospital had a good service.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Serge Wolkner: "“Normally, we would have been treated in one of the subur..."*)

### Węzeł `[41]`
Mówca: **Serge Wolkner**
> "“Normally, we would have been treated in one of the suburban hospitals.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Serge Wolkner: "“But thanks to the special coverage of the presidential s..."*)

### Węzeł `[42]`
Mówca: **Serge Wolkner**
> "“But thanks to the special coverage of the presidential staff, we were transferred to Emerald State Hospital.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player: "“Emerald State is a great hospital.”"*)
  - -> `[43]` (*Player: "“Glad that I could help.”"*)
  - -> `[44]` (*Player: "“We need to increase the quality of the services for all.”"*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“Glad that I could help.”"]** — Mówca: **Player**
> "“Glad that I could help.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Serge Wolkner: "“There are far more unfortunate people in this country. B..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“We need to increase the quality of the services for all.”"]** — Mówca: **Player**
> "“We need to increase the quality of the services for all.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Serge Wolkner: "“That sounds like a tough issue to solve.”"*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“Emerald State is a great hospital.”"]** — Mówca: **Player**
> "“Emerald State is a great hospital.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Serge Wolkner: "“The equipment and the staff were exceptional.”"*)

### Węzeł `[46]`
Mówca: **Serge Wolkner**
> "“You could call it a little traditional but it just feels right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: "“Family is the cornerstone of life.”"*)
  - -> `[85]` (*Player: "“Traditional or not if it is what you want, that is all t..."*)
  - -> `[87]` (*Player: "“I was never a family person.”"*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "“Sarna is a nice little city.”"]** — Mówca: **Player**
> "“Sarna is a nice little city.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Serge Wolkner: "“The bazaar there is quite unique and it is a good city. ..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "“Selflessness is a respectable trait to have.”"]** — Mówca: **Player**
> "“Selflessness is a respectable trait to have.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Serge Wolkner: "“It should be mutual, that is what matters most.”"*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "“Monica is persevering. It can be inspiring at times to have a partner like that.”"]** — Mówca: **Player**
> "“Monica is persevering. It can be inspiring at times to have a partner like that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Serge Wolkner: "“It's only fitting. A lioness for a lion.”"*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "“Are you fine?”"]** — Mówca: **Player**
> "“Are you fine?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Serge Wolkner: "“Yes sir. I hope the car is fine too.”"*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“This is unacceptable. We need to invest in infrastructure here.”"]** — Mówca: **Player**
> "“This is unacceptable. We need to invest in infrastructure here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Serge Wolkner: "“I agree sir. We still need to drive back tomorrow unless..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "“I do not value insecurity in my employees, Serge.”"]** — Mówca: **Player**
> "“I do not value insecurity in my employees, Serge.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "He looked visibly irked by my comment and nodded."*)

### Węzeł `[53]`
Mówca: **Serge Wolkner**
> "“Yes, sir. I will be more careful from now on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_TalkSoured = true"*)

### Węzeł `[54]`
Mówca: **Serge Wolkner**
> "“She is an inspiration for almost all women in the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Serge Wolkner: "“But at the same time, it must be hard for the First Lady..."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "Serge sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Serge Wolkner: "“I've already started thinking about their university edu..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "“Enough talking, Serge. Focus on the road.”"]** — Mówca: **Player**
> "“Enough talking, Serge. Focus on the road.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Serge_Friend"] == false`
- **Kontekst wejściowy (poprzednik):** `[139]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_TalkSoured = true"*)

### Węzeł `[57]`
Mówca: **Serge Wolkner**
> "“The bazaar there is quite unique and it is a good city. Nothing compares to Holsord of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Serge sighed."*)

### Węzeł `[58]`
Mówca: **Serge Wolkner**
> "“It should be mutual, that is what matters most.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Serge sighed."*)

### Węzeł `[59]`
Mówca: **Serge Wolkner**
> "“It's only fitting. A lioness for a lion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Serge sighed."*)

### Węzeł `[60]`
Mówca: **Serge Wolkner**
> "“The equipment and the staff were exceptional.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Serge sighed."*)

### Węzeł `[61]`
Mówca: **Serge Wolkner**
> "“There are far more unfortunate people in this country. But thanks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Serge sighed."*)

### Węzeł `[62]`
Mówca: **Serge Wolkner**
> "“That sounds like a tough issue to solve.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Serge sighed."*)

### Węzeł `[63]`
Mówca: **Serge Wolkner**
> "“I'm sorry. I will drive more carefully, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "The motorcade began approaching the hotel."*)

### Węzeł `[64]`
Mówca: **Serge Wolkner**
> "“I agree sir. We still need to drive back tomorrow unless you use one of those new helicopters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "The motorcade began approaching the hotel."*)

### Węzeł `[65]`
Mówca: **Serge Wolkner**
> "“Yes sir. I hope the car is fine too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "The motorcade began approaching the hotel."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Highway == true)"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "The scenery so far, however, was a reflection of Narbel's..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Highway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Railway == true)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "The scenery so far, however, was a reflection of Narbel's..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Railway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "The scenery so far, however, was a reflection of Narbel's..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "The scenery so far, however, was a reflection of Narbel's neglect. The main roads to the city were not maintained well. There were many bumps and empty discolored spots in the asphalt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "UpdateProgress("Progress_Highway", 50);  // Updates token..."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "The scenery so far, however, was a reflection of Narbel's neglect. The main roads to the city were not maintained well. There were many bumps and empty discolored spots in the asphalt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "UpdateProgress("Progress_Railway", 50);  // Updates token..."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "Serge nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Serge Wolkner: "“It must not be easy to be the children of a high-profile..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“I expect so much from them. They will make me proud.”"]** — Mówca: **Player**
> "“I expect so much from them. They will make me proud.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "Serge nodded."*)

### Węzeł `[76]`
Mówca: **Serge Wolkner**
> "“It must not be easy to be the children of a high-profile person like you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Serge Wolkner: "“I had some troubles communicating with Erica as she grew..."*)

### Węzeł `[77]`
Mówca: **Serge Wolkner**
> "“My daughter looks up to the First Lady for inspiration and it's not just limited to my daughter, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Serge Wolkner: "“She is an inspiration for almost all women in the country.”"*)

### Węzeł `[78]`
Mówca: **Serge Wolkner**
> "“It must be sir. We sometimes forget the important people in life between all the responsibility and rush.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Serge Wolkner: "“You know... Those we care for...”"*)

### Węzeł `[79]`
Mówca: **Serge Wolkner**
> "“You know... Those we care for...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: "“Spare me your lectures, Serge.”"*)
  - -> `[111]` (*Player: "“I agree.”"*)
  - -> `[189]` (*Player: "“Yes, Serge. I get it...”"*)

### Węzeł `[80]`
Mówca: **Serge Wolkner**
> "“I had some troubles communicating with Erica as she grew up, but we found a common ground by going to plays.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player: "“You are a good father, Serge.""*)
  - -> `[81]` (*Player: "“My children can talk to me if they want. It is up to them.”"*)
  - -> `[82]` (*Player: "“Communication is the key.”"*)
  - -> `[113]` (*Player: "“Spare me your lectures about parenthood, Serge.”"*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "“My children can talk to me if they want. It is up to them.”"]** — Mówca: **Player**
> "“My children can talk to me if they want. It is up to them.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Serge Wolkner: "“...I was unlucky. I never had a connection with my fathe..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "“Communication is the key.”"]** — Mówca: **Player**
> "“Communication is the key.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Serge Wolkner: ""It is.""*)

### Węzeł `[83]`
Mówca: **Serge Wolkner**
> "“...I was unlucky. I never had a connection with my father. He was absent from our life, and I just can't have the same situation with my children...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“Family is the cornerstone of life.”"]** — Mówca: **Player**
> "“Family is the cornerstone of life. We shouldn't forget that and it seems we do.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Serge Wolkner: "“Yes and it depends on what type of environment it is. If..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA: "“Traditional or not if it is what you want, that is all that matters.”"]** — Mówca: **Player**
> "“Traditional or not if it is what you want, that is all that matters.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Serge Wolkner: "“We keep forgetting what we want and lose ourselves in th..."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "He glanced towards the back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Serge Wolkner: "“I had some troubles communicating with Erica as she grew..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "“I was never a family person.”"]** — Mówca: **Player**
> "“I was never a family person.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Serge Wolkner: "“You have a good family.”"*)

### Węzeł `[88]`
Mówca: **Serge Wolkner**
> "“Yes and it depends on what type of environment it is. If its hostile...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Serge sighed."*)

### Węzeł `[89]`
Mówca: **Serge Wolkner**
> "“We keep forgetting what we want and lose ourselves in the process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Serge sighed."*)

### Węzeł `[90]`
Mówca: **Serge Wolkner**
> "“You have a good family.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Serge sighed."*)

### Węzeł `[91]`
Mówca: **Serge Wolkner**
> "“She has a good heart. Her family comes from Sarna, so they are a little more traditional.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Serge Wolkner: "“She's beautiful, of course. But what I really admire is ..."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "The mountainous city was infamously one of Sordland's poorest. It had a gritty edge, and its people were hardy and wary."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Even after the discovery of gas and oil in the area, year..."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "Even after the discovery of gas and oil in the area, years of neglect by the central government were apparent on the buildings and the general infrastructure. The natural resources were now under the control of Gasom, which elevated the corporation to a place of power."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "My task in this forum was mainly symbolic. Fake smiles an..."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "My task in this forum was mainly symbolic. Fake smiles and handshakes with oil barons, meeting with local politicians, but most importantly of all, making sure that Narbel did not feel like it was forgotten by the government."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)

### Węzeł `[95]`
Mówca: **Narrator**
> "As if my discomfort from the bumpy ride was apparent to him, Serge rolled down the partition window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Serge Wolkner: "“We will be arriving at Hotel West in a few minutes, sir.”"*)

### Węzeł `[96]`
**[WYBÓR GRACZA: "“Good. Whatever gets us out of here quickly.”"]** — Mówca: **Player**
> "“Good. Whatever gets us out of here quickly.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "I let out a deep sigh."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "I let out a deep sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "After a moment, Serge started to smile under his moustache."*)

### Węzeł `[98]`
**[WYBÓR GRACZA: "Pretend not to notice."]** — Mówca: **Player_Italic**
> "I pretended not to notice and looked out the window."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Serge Wolkner: "“Sir, I just want to say... It has been great these last ..."*)

### Węzeł `[99]`
Mówca: **Serge Wolkner**
> "“Thankfully, my work times allow me to spend some time with my family, except for these distant trips. I'm very lucky to have this job.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Serge Wolkner: "“How are your children, sir, if I may ask?”"*)

### Węzeł `[100]`
Mówca: **Narrator**
> "Serge continued after a moment of silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Serge Wolkner: "“Have I told you, sir? We named my son Georg.”"*)

### Węzeł `[101]`
Mówca: **Narrator**
> "Navigating and swerving to avoid the inconveniences, our motorcade finally started nearing the city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "As if my discomfort from the bumpy ride was apparent to h..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA: "“They are fine, but that's not your business Serge.”"]** — Mówca: **Player**
> "“They are fine, but that's not your business Serge.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Serge Wolkner: "“No sir. You are right, sir.”"*)

### Węzeł `[103]`
Mówca: **Serge Wolkner**
> "“No sir. You are right, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: "“I expect you to do your job. Not ask questions about my ..."*)
  - -> `[106]` (*Player: "“It's okay.”"*)

### Węzeł `[104]`
Mówca: **Narrator**
> "He looked visibly irked by my comment and nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Serge Wolkner: "“Yes, sir. I will be more careful from now on.”"*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "“I expect you to do your job. Not ask questions about my private life.”"]** — Mówca: **Player**
> "“I expect you to do your job. Not ask questions about my private life.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Serge Wolkner: "“Understood, Mr. President.”"*)

### Węzeł `[106]`
**[WYBÓR GRACZA: "“It's okay.”"]** — Mówca: **Player**
> "“It's okay.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_TalkSoured = true"*)

### Węzeł `[107]`
Mówca: **Serge Wolkner**
> "“Understood, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_TalkSoured = true"*)

### Węzeł `[108]`
Mówca: **Narrator**
> "There was a long silence. After several minutes, Serge attempted to break silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Serge Wolkner: "“Have I told you, sir? We named my son Georg.”"*)

### Węzeł `[109]`
Mówca: **Narrator**
> "There was a long silence. After several minutes, Serge attempted to break silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Serge Wolkner: "“Have I told you, sir? We named my son Georg.”"*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "“Spare me your lectures, Serge.”"]** — Mówca: **Player**
> "“Spare me your lectures, Serge.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Serge Wolkner: "“Yes sir. I am sorry sir.”"*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "“I agree.”"]** — Mówca: **Player**
> "“I agree.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Serge continued after a moment of silence."*)

### Węzeł `[112]`
Mówca: **Serge Wolkner**
> "“Yes sir. I am sorry sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_TalkSoured = true"*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "“Spare me your lectures about parenthood, Serge.”"]** — Mówca: **Player**
> "“Spare me your lectures about parenthood, Serge.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Serge Wolkner: "“Yes sir. I am sorry sir.”"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "My thoughts faded to my childhood. My father was also abs..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "Being a president meant that I had to be away from home m..."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "My thoughts faded to my childhood. My father was also absent from home most of the time. I never connected with him, just like Serge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "I wondered if Franc also thought of me as an absent fathe..."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "Being a president meant that I had to be away from home most of the time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "I wondered if Franc also thought of me as an absent fathe..."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "I wondered if Franc also thought of me as an absent father figure. Could that be the reason behind his attitude?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Serge continued after a moment of silence."*)

### Węzeł `[120]`
Mówca: **Serge Wolkner**
> "“But at the same time, it must be hard for the First Lady as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Serge Wolkner: "“All this attention, adjusting to this new high-profile l..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: "“That is none of your business.”"]** — Mówca: **Player**
> "“That is none of your business.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Serge Wolkner: "“Yes sir. I am sorry sir.”"*)

### Węzeł `[122]`
**[WYBÓR GRACZA: "“You are right. It is hard for her.”"]** — Mówca: **Player**
> "“You are right. It is hard for her.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Serge Wolkner: "“It must be sir. We sometimes forget the important people..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: "“It is hard for both of us.”"]** — Mówca: **Player**
> "“It is hard for both of us.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Serge Wolkner: "“It must be sir. We sometimes forget the important people..."*)

### Węzeł `[124]`
Mówca: **Serge Wolkner**
> "“My daughter looks up to the First Lady for inspiration. Not only my daughter, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Serge Wolkner: "“She is an inspiration for almost all women in the country.”"*)

### Węzeł `[125]`
Mówca: **Serge Wolkner**
> "“All this attention, adjusting to this new high-profile life, and a husband that has great responsibility...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: "“That is none of your business.”"*)
  - -> `[188]` (*Player: "“Let's not talk about my family, Serge.”"*)
  - -> `[122]` (*Player: "“You are right. It is hard for her.”"*)
  - -> `[123]` (*Player: "“It is hard for both of us.”"*)

### Węzeł `[126]`
**[WYBÓR GRACZA: "“Very good. I must tend to my documents for a bit.”"]** — Mówca: **Player**
> "“Very good. I must tend to my documents for a bit.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Serge Wolkner: "“Of course, Mr. President.”"*)

### Węzeł `[127]`
Mówca: **Serge Wolkner**
> "“Of course, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Serge sighed."*)

### Węzeł `[128]`
Mówca: **Narrator**
> "The Hotel West was supposedly the best hotel in Narbel. The large 25-story main building was undoubtedly one of the taller and more expensive buildings in the city. It towered over the nearby slums and had been a target for protests when it was first built."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "A crowd was gathered in front of the hotel with the welco..."*)

### Węzeł `[129]`
Mówca: **Narrator**
> "A crowd was gathered in front of the hotel with the welcoming committee at its centre. As we approached the red carpeted entrance I could see the Mayor of Narbel and his top aides."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "Serge got out of the car and opened the door. He bowed hi..."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "Serge got out of the car and opened the door. He bowed his head respectfully and gestured towards the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player_Italic: "Exit the vehicle."*)
  - -> `[35]` (*Player: "“Thank you.”"*)
  - -> `[36]` (*Player: "“See you later, Serge.”"*)

### Węzeł `[131]`
Mówca: **Serge Wolkner**
> "“Thank you sir. Likewise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "As soon as I left the vehicle, the fresh air of Narbel fi..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "Exit the vehicle."]** — Mówca: **Player_Italic**
> "I gathered my documents, my bag and I left the car."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "As soon as I left the vehicle, the fresh air of Narbel fi..."*)

### Węzeł `[133]`
Mówca: **Narrator**
> "As soon as I left the vehicle, the fresh air of Narbel filled my lungs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "Almost immediately, everyone present in the crowd flocked..."*)

### Węzeł `[134]`
Mówca: **Narrator**
> "Almost immediately, everyone present in the crowd flocked over to me with an excessive display of courtesy, smiles and handshakes while I donned the mask of a politician."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "A mask that I was very used to."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "A mask that I was very used to."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_CallRestraint == ..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_TalkSoured = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Serge_TalkSoured"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "There was a long silence. After several minutes, Serge at..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_TalkSoured = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Serge_TalkSoured"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "There was a long silence. After several minutes, Serge at..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_TalkSoured = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Serge_TalkSoured"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Serge Wolkner: "“I'm sorry. I will drive more carefully, sir.”"*)

### Węzeł `[139]`
Mówca: **Narrator**
> "The car hit a major pothole and a bump which lifted us up in our seats for a second."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == false"*)
  - -> `[51]` (*Player: "“This is unacceptable. We need to invest in infrastructur..."*)
  - -> `[50]` (*Player: "“Are you fine?”"*)

### Węzeł `[140]`
Mówca: **Serge Wolkner**
> "“I've already started thinking about their university education. Especially Erica.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Serge Wolkner: "“I want to send her to a good private school but with the..."*)

### Węzeł `[141]`
Mówca: **Serge Wolkner**
> "“I want to send her to a good private school but with the current state of the economy, it's going to be hard for us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 1"*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 2"*)
  - -> `[142]` (*Player: "“We will fix the economy. One way or another.”"*)
  - -> `[144]` (*Player: "“It's hard for everyone.”"*)

### Węzeł `[142]`
**[WYBÓR GRACZA: "“We will fix the economy. One way or another.”"]** — Mówca: **Player**
> "“We will fix the economy. One way or another.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Serge Wolkner: "“If anyone can, that's you, Mr. President.”"*)

### Węzeł `[143]`
**[WYBÓR GRACZA: "“You know what? I can support the education of your children." [-1 Personal Wealth]"]** — Mówca: **Player**
> "“You know what? I can support the education of your children.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] >= 1`
- **Kontekst wejściowy (poprzednik):** `[141]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth -= 1; BaseGame.Relations_Serge_Ac..."*)

### Węzeł `[144]`
**[WYBÓR GRACZA: "“It's hard for everyone.”"]** — Mówca: **Player**
> "“It's hard for everyone.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Serge Wolkner: "“If anyone can fix the economy, that's you, Mr. President.”"*)

### Węzeł `[145]`
Mówca: **Serge Wolkner**
> "“Mr. President, there is no way I can--.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "With one look from me, Serge cut his sentence short and n..."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "With one look from me, Serge cut his sentence short and nodded at me after removing his hat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Serge Wolkner: "“Mr. President, I don't know how I can ever repay you for..."*)

### Węzeł `[147]`
Mówca: **Serge Wolkner**
> "“Mr. President, I don't know how I can ever repay you for this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Serge Wolkner: "“Thank you so much.”"*)

### Węzeł `[148]`
Mówca: **Serge Wolkner**
> "“Thank you so much.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player: "“A good education is more valuable than any amount of mon..."*)
  - -> `[153]` (*Player: "“I hope you return the favor by helping someone in need s..."*)
  - -> `[155]` (*Player: "“No worries, Serge.”"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth -= 1;
BaseGame.Relations_Serge_Acquaintance = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;
Variable["BaseGame.Relations_Serge_Acquaintance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn03_DriverTalk_PaidForEducatio..."*)

### Węzeł `[150]`
Mówca: **Serge Wolkner**
> "“If anyone can, that's you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "The car hit a major pothole and a bump which lifted us up..."*)

### Węzeł `[151]`
Mówca: **Serge Wolkner**
> "“If anyone can fix the economy, that's you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "The car hit a major pothole and a bump which lifted us up..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA: "“A good education is more valuable than any amount of money.”"]** — Mówca: **Player**
> "“A good education is more valuable than any amount of money.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Serge Wolkner: "“Exactly, sir. You are right.”"*)

### Węzeł `[153]`
**[WYBÓR GRACZA: "“I hope you return the favor by helping someone in need someday. Just like I did.”"]** — Mówca: **Player**
> "“I hope you return the favor by helping someone in need someday. Just like I did.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Serge Wolkner: "“I will, sir. Of course.”"*)

### Węzeł `[154]`
Mówca: **Serge Wolkner**
> "“I will, sir. Of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == true"*)

### Węzeł `[155]`
**[WYBÓR GRACZA: "“No worries, Serge.”"]** — Mówca: **Player**
> "“No worries, Serge.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == true"*)

### Węzeł `[156]`
Mówca: **Serge Wolkner**
> "“Exactly, sir. You are right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == true"*)

### Węzeł `[157]`
Mówca: **Serge Wolkner**
> "“I think I have decided. I will give your name to my boy. ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Serge Wolkner: "“Georg Anton Wolkner.”"*)

### Węzeł `[158]`
Mówca: **Serge Wolkner**
> "“Georg Anton Wolkner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Serge Wolkner: "“May he grow strong like you.”"*)

### Węzeł `[159]`
Mówca: **Serge Wolkner**
> "“May he grow strong like you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Player: "“It has a nice ring to it. I like it.”"*)
  - -> `[161]` (*Player: "“I am sure he will.”"*)
  - -> `[162]` (*Player_Italic: "Nod."*)

### Węzeł `[160]`
**[WYBÓR GRACZA: "“It has a nice ring to it. I like it.”"]** — Mówca: **Player**
> "“It has a nice ring to it. I like it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "The car hit a major pothole and a bump which lifted us up..."*)

### Węzeł `[161]`
**[WYBÓR GRACZA: "“I am sure he will.”"]** — Mówca: **Player**
> "“I am sure he will.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "The car hit a major pothole and a bump which lifted us up..."*)

### Węzeł `[162]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "The car hit a major pothole and a bump which lifted us up..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_Friend = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Serge_Friend"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn03_DriverTalk_PaidForFamily =..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_Friend == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == false"*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Serge_Friend == false)"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_Friend == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Serge_Friend"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: "“Enough talking, Serge. Focus on the road.”"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Serge_Friend == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Serge_Friend"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn03_DriverTalk_PaidForEducation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn03_DriverTalk_PaidForEducation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Serge Wolkner: "“Mr. President, there is no way I can--.”"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_CallRestraint == true || BaseGame.Decision_Turn02_StatusReaction_VisitTowns == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_CallRestraint == ..."*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_StatusReaction_CallRestraint =..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_CallRestraint == true || BaseGame.Decision_Turn02_StatusReaction_VisitTowns == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_CallRestraint"] == true  or  Variable["BaseGame.Decision_Turn02_StatusReaction_VisitTowns"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Holsord", "City_Widespre..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_StatusReaction_CallRestraint == true || BaseGame.Decision_Turn02_StatusReaction_VisitTowns == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_CallRestraint"] == true  or  Variable["BaseGame.Decision_Turn02_StatusReaction_VisitTowns"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_StatusReaction_WarnTraitors ==..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Protest_CalledProtestersTr..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == ..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Holsord", "City_Widespre..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_StatusReaction_BoostPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_BoostPolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Protest_DoneNothing = true"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Protest_DoneNothing = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Protest_DoneNothing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Watching idly as nationwide protests eru..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Protest_ExpandedPolice = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Protest_ExpandedPolice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Expanding the police force to contain pr..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Protest_Calm = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Protest_Calm"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Calling for solidarity to calm the natio..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Protest_CalledProtestersTraitors = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Protest_CalledProtestersTraitors"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Labelling all protestors as traitors", "..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_Personal_DriverTalk = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_Personal_DriverTalk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_R_MisogynistRally = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_R_MisogynistRally"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "The mountainous city was infamously one of Sordland's poo..."*)

### Węzeł `[183]`
Mówca: **Narrator**
> "The scenery so far, however, was a reflection of Narbel's neglect. The main roads to the city were not maintained well. There were many bumps and empty discolored spots in the asphalt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Navigating and swerving to avoid the inconveniences, our ..."*)

### Węzeł `[184]`
**[WYBÓR GRACZA: "“That's great news, Serge. I'm happy for you.”"]** — Mówca: **Player**
> "“That's great news, Serge. I'm happy for you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Serge Wolkner: "“I appreciate it, sir. Truly. I was worried that I wouldn..."*)

### Węzeł `[185]`
**[WYBÓR GRACZA: "“You are a good father, Serge.""]** — Mówca: **Player**
> "“You are a good father, Serge.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Serge Wolkner: "“I try my best, sir.”"*)

### Węzeł `[186]`
Mówca: **Serge Wolkner**
> "“I try my best, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Serge Wolkner: "“...I was unlucky. I never had a connection with my fathe..."*)

### Węzeł `[187]`
Mówca: **Serge Wolkner**
> ""It is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Serge Wolkner: "“...I was unlucky. I never had a connection with my fathe..."*)

### Węzeł `[188]`
**[WYBÓR GRACZA: "“Let's not talk about my family, Serge.”"]** — Mówca: **Player**
> "“Let's not talk about my family, Serge.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Serge Wolkner: "“Yes sir. I am sorry sir.”"*)

### Węzeł `[189]`
**[WYBÓR GRACZA: "“Yes, Serge. I get it...”"]** — Mówca: **Player**
> "“Yes, Serge. I get it...”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Serge Wolkner: "“Of course, sir.”"*)

### Węzeł `[190]`
Mówca: **Serge Wolkner**
> "“Of course, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Serge Wolkner: "“Yes sir. I am sorry sir.”"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 1"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth >= 1)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player: "“You know what? I can support the education of your child..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 2"*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth >= 2)"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Player: "“My driver's family shouldn't want for anything in this w..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth -= 2;
BaseGame.Relations_Serge_Friend = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 2;
Variable["BaseGame.Relations_Serge_Friend"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend = true"*)

### Węzeł `[198]`
**[WYBÓR GRACZA: "“My driver's family shouldn't want for anything in this world. I'll cover your children's education and any other extra expenses you need." [-2 Personal Wealth]"]** — Mówca: **Player**
> "“My driver's family shouldn't want for anything in this world. I'll cover your children's education and any other extra expenses you need.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[141]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth -= 2; BaseGame.Relations_Serge_Fr..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateProgress("Progress_Highway", 50);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%)`
- **Efekt skryptowy (`userScript`):** `UpdateProgress("Progress_Highway", 50);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Navigating and swerving to avoid the inconveniences, our ..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateProgress("Progress_Railway", 50);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%)`
- **Efekt skryptowy (`userScript`):** `UpdateProgress("Progress_Railway", 50);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Navigating and swerving to avoid the inconveniences, our ..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Holsord", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Holsord","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Jen", "City_WidespreadPr..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Holsord", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Holsord","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Jen", "City_WidespreadPr..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Jen", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Jen","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Morna", "City_Widespread..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Morna", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Morna","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Protest_Calm = true"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Jen", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Jen","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Morna", "City_Widespread..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Morna", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Morna","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Protest_ExpandedPolice = true"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn03_DriverTalk_PaidForFamily = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn03_DriverTalk_PaidForFamily"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Serge Wolkner: "“Mr. President, there is no way I can--.”"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_Friend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == true"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Serge_Friend == true)"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_Friend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Serge_Friend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Serge Wolkner: "“I think I have decided. I will give your name to my boy. ”"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Serge_Friend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Serge_Friend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Serge Wolkner: "“I won't forget your generosity, sir.”"*)

### Węzeł `[211]`
Mówca: **Serge Wolkner**
> "“I won't forget your generosity, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "The car hit a major pothole and a bump which lifted us up..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Calling for solidarity to calm the nation", "Presidential Office", "Maroon Palace");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Calling for solidarity to calm the nation","Presidential Office","Maroon Palace");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_R_SollNeedsToAnswer = true; B..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Labelling all protestors as traitors", "Presidential Office", "Maroon Palace");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Labelling all protestors as traitors","Presidential Office","Maroon Palace");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_R_SollNeedsToAnswer = true; B..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Expanding the police force to contain protests", "Presidential Office", "Maroon Palace");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Expanding the police force to contain protests","Presidential Office","Maroon Palace");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_R_SollNeedsToAnswer = true; B..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Watching idly as nationwide protests erupt", "Presidential Office", "Maroon Palace");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Watching idly as nationwide protests erupt","Presidential Office","Maroon Palace");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_R_SollNeedsToAnswer = true; B..."*)
